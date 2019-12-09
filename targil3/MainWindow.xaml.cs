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
        public List<Host> hostsList = new List<Host>()
            {
                new Host ()
                {
                    HostName = "Alis",
                    Units = new List<HostingUnit>()
                    {
                        new HostingUnit()
                        {
                            UnitName = " Alice's Palace",
                            Rooms= 6,
                            IsSwimmingPool= true,
                            AllOrders =new List<DateTime>(),
                            Uris= new List<string>(){ "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSX9Ofzot8S1NHEEVDt2MoWVKKwPulEevDe1SJd8X77IJTIfv_E&s",
                            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSO-00K23N0JSxkmVmGRJ_s09V1frEXGrjNEC4IirVvVnXo2S9I&s",
                                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQeEtcVHR2PnhamUd2_Tz5ttTydvOje7tXvCdiypckfbBo4KPgQ&s"}
                        },
                        new HostingUnit()
                        {
                            UnitName = " Alice's cabin",
                            Rooms= 4,
                            IsSwimmingPool= true,
                            AllOrders =new List<DateTime>(),
                            Uris= new List<string>(){ "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSjk95imCn5a30aRWQPRcwQehjsh4HnJ8tbaviqyMtXyVlqsRrg3w&s",
                            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR18qBj5c2U4MYC7UEp3sVdlwl15olGmF_o3wLo32LXuur46b2MWw&s",
                            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTVkArEueDDq3ug1mrpsjLss_WkzAmWAYHrAOsg6OIK2f96Ydnn&s"}
                        },
                        new HostingUnit()
                        {
                            UnitName = " Alisa",
                            Rooms= 4,
                            IsSwimmingPool= true,
                            AllOrders =new List<DateTime>(),
                            Uris= new List<string>(){ "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQa9hpCoKoaVKyMRXxLPx-9SA7Hwr4Bqs-KJOyKJgU-ZCanIXg8mQ&s",
                            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSjj5GPtSt859ZUXx-I3I-F83HCRR3M8lOpjtxk1lLa50jUZrER&s",
                                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTefY7WT3KUu7tvHuKpbdvNXQlzF5YfiJmuyXc3lLUbmUGN4CvK&s",
                            }
                        }

                    }

                },
                 new Host ()
                {
                    HostName = "דן ",
                    Units = new List<HostingUnit>()
                    {
                        new HostingUnit()
                        {
                            UnitName = "Danny's",
                            Rooms= 2,
                            IsSwimmingPool= true,
                            AllOrders =new List<DateTime>(),
                            Uris= new List<string>(){ "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQQ4LWX64Bbm1dkbNbydHHKeatYiXbHb7I_LI2F7TPWQVdRFyI4mg&s",
                            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRlfp4Bfx2Z7VW8Hv9SFgkUAIQs-MViy9ZlJ0Tc6z0K93MxNK2SuA&s",
                            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSz2vsLN3ARyXODjXT6VihdQtIVmRjr_qOiiFeLfjkB3pTA4M_1&s"}
                        },
                        new HostingUnit()
                        {
                            UnitName = "Danny's",
                            Rooms= 2,
                            IsSwimmingPool= false,
                            AllOrders =new List<DateTime>(),
                            Uris= new List<string>(){"https://images.hapisga.co.il/ssd/sites/92/545d0286912c81b.jpg",
                            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR8dPrGHOwslsdw5VlhoxvQYK8PIb9C3OpeGjiEWphA6UzklpL0&s",
                            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSc44a5hkvPDO56KGDWjIVl1SETT15eRAgV2rKU1b5hilZsRYZg&s"}
                        },
                        new HostingUnit()
                        {
                            UnitName = "Danny's",
                            Rooms= 4,
                            IsSwimmingPool= true,
                            AllOrders =new List<DateTime>(),
                            Uris= new List<string>(){"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSPEp71Tp_mJGCiHFY4q0jUPoh6hY_dT4BC6Mfhuuq3gPj37wut&s",
                            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS6cO0HhB_lxgmGc7ci0cwJShxY-6bgh2HUmGogZxJpZynjih66&s",
                            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSnWXi8hz20s2cmN43hqqoOxcfOflK9pZAUsuARS-DdyKEMawvlKQ&s"}
                        }
                    }
                },
                 new Host ()
                {
                    HostName = "Gili",
                    Units = new List<HostingUnit>()
                    {
                        new HostingUnit()
                        {
                            UnitName = " The Place  ",
                            Rooms= 4,
                            IsSwimmingPool= false,
                            AllOrders =new List<DateTime>(),
                            Uris= new List<string>(){"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQhDLJ6waFfC85wP6sGjew3bDOg1kUIFFotXHGev1QfrW0mA5Uo&s",
                            "https://pic.rrr.co.il/images/mymemorybagolan/16%20(Big).jpg",
                            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRpUdeeuv80L6MQomC9duK7IwTY2k1sR7luq5yELeXeu39GfQIu&s"}
                        },
                        new HostingUnit()
                        {
                            UnitName = "The Apt",
                            Rooms= 4,
                            IsSwimmingPool= false,
                            AllOrders =new List<DateTime>(),
                            Uris= new List<string>(){ "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRO-SU1Q27A7cUsJbH3JmIZnNa536SG1pMnXKrSgsaY4Ma2Wxfo&s",
                                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSlq6tVEaCyRPW8Zqo-EfC-1SRs3DshKAerB1lqBFf8Os_I58aL&s",
                                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQf7KyAOtnzssD072e-Mt3htuCLFuXPQXZsuuL_5VFQP7F3atdl0A&s"
                          }
                        },
                        new HostingUnit()
                        {
                            UnitName = "The Thing",
                            Rooms= 4,
                            IsSwimmingPool= true,
                            AllOrders =new List<DateTime>(),
                            Uris= new List<string>(){ "https://www.zimmer.co.il/14624/DSCN3061.jpg",
                            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRsWWRhK_tih_SVz4mBvsyyJTjrt_a5LFcrCY4A0sY0FqY8Bo0k&s",
                            "https://www.weekend-family.co.il/images/customerimages/24620/gallery/image_24620_1.jpg"}
                        }
                    }
                }
            };


        public MainWindow()
        {
            InitializeComponent();
            cbHostList.ItemsSource = hostsList;
            cbHostList.DisplayMemberPath = "HostName";
            cbHostList.SelectedIndex = 0;
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