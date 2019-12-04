using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace targil3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Host currentHost;
        public List<Host> hostsList;
        public MainWindow()
        {
            InitializeComponent();
            cbHostList.ItemsSource = hostsList;
            cbHostList.DisplayMemberPath = "HostName";
            cbHostList.SelectedIndex = 0;

            hostsList = new List<Host>()
            {
                new Host ()
                {
                    HostName = "Dan",
                    Units = new List<HostingUnit>()
                    {
                        new HostingUnit()
                        {
                            UnitName = "צימר1 דן",
                            Rooms= 6,
                            IsSwimmingPool= true,
                            AllOrders =new List<DateTime>(),
                            Uris= new List<string>(){"https://www.zimertop.co.il/gallery/149121207443.jpg",
                                " https://www.zimertop.co.il/gallery/149121207442.jpg","https://www.zimertop.co.il/gallery/149121207451.jpg" }
                        },
                        new HostingUnit()
                        {
                            UnitName = "צימר2 דן",
                            Rooms= 4,
                            IsSwimmingPool= true,
                            AllOrders =new List<DateTime>(),
                            Uris= new List<string>(){"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTAIPZwPdR6KGpTYAbmNv3j5Ce-VQVGsfBbBhIrbd7GuxBfS4JEk8haDoc&s",
                                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ5-pCh6bawBMsCuIxLuObQcmhI9WeVIDoQKm11DYZKreGmQnPxjfaTNjY&s","https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTe2lRKCt42GL-xCKZfWwm2uJ0k66JAxNAyb9QFVDpe150xhP54ojI82do&s" }
                        }
                    }

                },
                 new Host ()
                {
                    HostName = "Yossi",
                    Units = new List<HostingUnit>()
                    {
                        new HostingUnit()
                        {
                            UnitName = "צימר1 יוסי",
                            Rooms= 2,
                            IsSwimmingPool= true,
                            AllOrders =new List<DateTime>(),
                            Uris= new List<string>(){"https://www.zimertop.co.il/gallery/149121207443.jpg",
                                " https://www.zimertop.co.il/gallery/149121207442.jpg","https://www.zimertop.co.il/gallery/149121207451.jpg"}
                        },
                        new HostingUnit()
                        {
                            UnitName = "צימר2 יוסי",
                            Rooms= 2,
                            IsSwimmingPool= false,
                            AllOrders =new List<DateTime>(),
                            Uris= new List<string>(){"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTAIPZwPdR6KGpTYAbmNv3j5Ce-VQVGsfBbBhIrbd7GuxBfS4JEk8haDoc&s",
                                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ5-pCh6bawBMsCuIxLuObQcmhI9WeVIDoQKm11DYZKreGmQnPxjfaTNjY&s",
                                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTe2lRKCt42GL-xCKZfWwm2uJ0k66JAxNAyb9QFVDpe150xhP54ojI82do&s" }
                        }
                    }

                },
                 new Host ()
                {
                    HostName = "gili",
                    Units = new List<HostingUnit>()
                    {
                        new HostingUnit()
                        {
                            UnitName = "צימר1 גילי",
                            Rooms= 4,
                            IsSwimmingPool= false,
                            AllOrders =new List<DateTime>(),
                            Uris= new List<string>(){"https://www.zimertop.co.il/gallery/149121207443.jpg",
                                " https://www.zimertop.co.il/gallery/149121207442.jpg","https://www.zimertop.co.il/gallery/149121207451.jpg"}
                        },
                        new HostingUnit()
                        {
                            UnitName = "צימר2 גילי",
                            Rooms= 4,
                            IsSwimmingPool= false,
                            AllOrders =new List<DateTime>(),
                            Uris= new List<string>(){"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTAIPZwPdR6KGpTYAbmNv3j5Ce-VQVGsfBbBhIrbd7GuxBfS4JEk8haDoc&s",
                                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ5-pCh6bawBMsCuIxLuObQcmhI9WeVIDoQKm11DYZKreGmQnPxjfaTNjY&s",
                                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTe2lRKCt42GL-xCKZfWwm2uJ0k66JAxNAyb9QFVDpe150xhP54ojI82do&s" }
                        }
                    }

                }
            };
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InitializeHost(cbHostList.SelectedIndex);
        }
        private void InitializeHost(int index)
        {
            MainGrid.Children.RemoveRange(1, 3);
            currentHost = hostsList[index];
            UpGrid.DataContext = currentHost;
            for (int i = 0; i < currentHost.Units.Count; i++)
            {
                HostingUnitUserControl a = new HostingUnitUserControl(currentHost.Units[i]);
                MainGrid.Children.Add(a);
                Grid.SetRow(a, i + 1);
            }
        }

    }
}
