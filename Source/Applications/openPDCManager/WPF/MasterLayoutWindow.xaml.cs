﻿using System.Windows;
using System.Windows.Controls;
using openPDCManager.UserControls.CommonControls;
using openPDCManager.Data.Entities;
using System;
using openPDCManager.Pages.Devices;
using openPDCManager.Pages.Manage;
using openPDCManager.Pages.Adapters;
using openPDCManager.UserControls.OutputStreamControls;

namespace openPDCManager
{
    /// <summary>
    /// Interaction logic for MasterLayoutWindow.xaml
    /// </summary>
    public partial class MasterLayoutWindow : Window
    {
        #region [ Members ]

        const double layoutRootHeight = 900;
        const double layoutRootWidth = 1200;

        #endregion

        #region [ Constructor ]

        public MasterLayoutWindow()
        {
            InitializeComponent();            
            UserControlSelectNode.NodeCollectionChanged += new openPDCManager.UserControls.CommonControls.SelectNode.OnNodesChanged(UserControlSelectNode_NodeCollectionChanged);
            UserControlSelectNode.ComboboxNode.SelectionChanged += new SelectionChangedEventHandler(ComboboxNode_SelectionChanged);
            MainWindow.SizeChanged += new SizeChangedEventHandler(MainWindow_SizeChanged);
            Loaded += new RoutedEventHandler(MasterLayoutWindow_Loaded);
            //ExpanderErrorLog.Collapsed += new RoutedEventHandler(ExpanderErrorLog_Collapsed);
            //ExpanderErrorLog.Expanded += new RoutedEventHandler(ExpanderErrorLog_Expanded);
        }

        void ExpanderErrorLog_Expanded(object sender, RoutedEventArgs e)
        {
            //MainWindow.Height += 125;
        }

        void ExpanderErrorLog_Collapsed(object sender, RoutedEventArgs e)
        {
            //MainWindow.Height -= 125;
        }

        void MasterLayoutWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //TestUserControl test = new TestUserControl();
            //ContentFrame.Navigate(test);
            HomePageUserControl home = new HomePageUserControl();
            ContentFrame.Navigate(home);
        }

        #endregion

        #region [ Windows Event Handlers ]

        void MainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            LayoutRootScale.ScaleX = e.NewSize.Width / layoutRootWidth;
            LayoutRootScale.ScaleY = e.NewSize.Height / layoutRootHeight;
        }

        void MainWindow_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == System.Windows.Input.MouseButton.Left)
                this.DragMove();
        }

        #endregion

        #region [ Controls Event Handlers ]

        void ComboboxNode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (UserControlSelectNode.ComboboxNode.SelectedItem != null)
                TextBlockNode.Text = ((Node)UserControlSelectNode.ComboboxNode.SelectedItem).Name;
            HomePageUserControl home = new HomePageUserControl();
            ContentFrame.Navigate(home);
        }

        void UserControlSelectNode_NodeCollectionChanged(object sender, RoutedEventArgs e)
        {
            (sender as SelectNode).RefreshNodeList();
        }        

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;            
        }

        private void ButtonMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else
                this.WindowState = WindowState.Maximized;
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        #region [ Menu Event Handlers ]

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem item = (MenuItem)e.OriginalSource;
            if (item.Name == "CustomInputs")
            {
                AdapterUserControl adapter = new AdapterUserControl();
                adapter.TypeOfAdapter = AdapterType.Input;
                ContentFrame.Navigate(adapter);
            }
            else if (item.Name == "CustomActions")
            {
                AdapterUserControl adapter = new AdapterUserControl();
                adapter.TypeOfAdapter = AdapterType.Action;
                ContentFrame.Navigate(adapter);
            }
            else if (item.Name == "CustomOutputs")
            {
                AdapterUserControl adapter = new AdapterUserControl();
                adapter.TypeOfAdapter = AdapterType.Output;
                ContentFrame.Navigate(adapter);
            }
            else if (item.Name == "CalculatedMeasurements")
            {
                CalculatedMeasurementsUserControl calculatedMeasurementsUserControl = new CalculatedMeasurementsUserControl();
                ContentFrame.Navigate(calculatedMeasurementsUserControl);
            }
            else if (item.Name == "Historians")
            {
                HistoriansUserControl historiansUserControl = new HistoriansUserControl();
                ContentFrame.Navigate(historiansUserControl);
            }
            else if (item.Name == "Nodes")
            {
                NodesUserControl nodesUserControl = new NodesUserControl();
                ContentFrame.Navigate(nodesUserControl);
            }
            else if (item.Name == "Companies")
            {
                CompaniesUserControl companiesUserControl = new CompaniesUserControl();
                ContentFrame.Navigate(companiesUserControl);
            }
            else if (item.Name == "Vendors")
            {
                VendorUserControl vendorUserControl = new VendorUserControl();
                ContentFrame.Navigate(vendorUserControl);
            }
            else if (item.Name == "VendorDevices")
            {
                VendorDevicesUserControl vendorDevicesUserControl = new VendorDevicesUserControl();
                ContentFrame.Navigate(vendorDevicesUserControl);
            }
            else if (item.Name == "AddOtherDevice")
            {
                ManageOtherDevicesUserControl manageOtherDeviceUserControl = new ManageOtherDevicesUserControl();
                ContentFrame.Navigate(manageOtherDeviceUserControl);
            }
            else if (item.Name == "OtherDevices")
            {
                OtherDevicesUserControl otherDevicesUserControl = new OtherDevicesUserControl();
                ContentFrame.Navigate(otherDevicesUserControl);
            }
            else if (item.Name == "AddNew")
            {
                ManageDevicesUserControl manageDevicesUserControl = new ManageDevicesUserControl();
                ContentFrame.Navigate(manageDevicesUserControl);
            }
            else if (item.Name == "BrowseDevices")
            {
                BrowseDevicesUserControl browse = new openPDCManager.Pages.Devices.BrowseDevicesUserControl();
                ContentFrame.Navigate(browse);
            }
            else if (item.Name == "Measurements")
            {
                Measurements measurements = new Measurements(0);
                ContentFrame.Navigate(measurements);
            }
            else if (item.Name == "Home")
            {
                HomePageUserControl home = new HomePageUserControl();
                ContentFrame.Navigate(home);
            }
            else if (item.Name == "IaonTree")
            {
                IaonTreeUserControl iaonTree = new IaonTreeUserControl();
                ContentFrame.Navigate(iaonTree);
            }
            else if (item.Name == "RealTimeMeasurements")
            {
                DeviceMeasurementsUserControl deviceMeasurements = new DeviceMeasurementsUserControl();
                ContentFrame.Navigate(deviceMeasurements);
            }
            else if (item.Name == "RealTimeStatistics")
            {
                RealTimeStatisticsUserControl realTimeStatistics = new RealTimeStatisticsUserControl();
                ContentFrame.Navigate(realTimeStatistics);
            }
            else if (item.Name == "RemoteConsole")
            {
                MonitorUserControl monitorControl = new MonitorUserControl();
                ContentFrame.Navigate(monitorControl);
            }
            else if (item.Name == "OutputStreams")
            {
                OutputStreamsUserControl outputStreams = new OutputStreamsUserControl();
                ContentFrame.Navigate(outputStreams);
            }
        }

        #endregion

        #endregion

    }
}
