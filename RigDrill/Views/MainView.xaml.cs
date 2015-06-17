using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace RigDrill
{
    public partial class MainView : ContentPage
    {
        private MainViewModel _vm;
        private Map mapView;

        public MainView()
        {
            InitializeComponent();
            _vm = new MainViewModel();
            InitializeToolBar();
            InitializeMapView();
            InitializeRigsList();
        }

        private void InitializeToolBar() {
            var btnToggleView = new ToolbarItem
            {
                Text = "Map",
                Order = ToolbarItemOrder.Primary
            };

            btnToggleView.Clicked += (object sender, EventArgs e) => {

                if(btnToggleView.Text == "Map") {
                    btnToggleView.Text = "List";
                    lvRigs.IsVisible = false;
                    mapView.IsVisible = true;
                } else {
                    btnToggleView.Text = "Map";
                    lvRigs.IsVisible = true;
                    mapView.IsVisible = false;
                }
            };

            this.ToolbarItems.Add(btnToggleView);
        }

        private void InitializeMapView() {
            mapView = new Map(
                    MapSpan.FromCenterAndRadius(
                    new Position(29.756990, -95.366959), Distance.FromMiles(200))) {

                IsShowingUser= true,
                VerticalOptions = LayoutOptions.FillAndExpand,
                IsVisible = false
            };
            MainStackLayout.Children.Add(mapView);
            UpdatePins();
        }

        private void UpdatePins() {
            foreach (var rig in _vm.Rigs)
            {
                mapView.Pins.Add(new Pin { Type = PinType.Place, Position = new Position(rig.WellLocLatitude, rig.WellLocLongitude), Label = rig.WellName });
            }
        }

        private void InitializeRigsList() {
            
            lvRigs.ItemsSource = _vm.Rigs;
            lvRigs.ItemSelected += (object sender, SelectedItemChangedEventArgs e) => {
                var rig = (RigIdentifierModel) e.SelectedItem;
                if(rig == null) return;
                Navigation.PushAsync(new RigsDashboardView(rig.WellId, rig.WellName));
                lvRigs.SelectedItem = null;
            };
        }
    }
}

