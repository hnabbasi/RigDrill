using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace RigDrill
{
    public partial class RigsDashboardView : ContentPage
    {
        private RigDashboardViewModel _vm;

        public RigsDashboardView(string wellId, string wellName)
        {
            InitializeComponent();
            _vm = new RigDashboardViewModel(wellId);
            BindingContext = _vm;
            Title = String.Format("{0} Dashboard", wellName);

            AnimateDashboard();
        }

        private void AnimateDashboard()
        {
            // Start a timer that runs after 1 minute.
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
                {
                    Task.Factory.StartNew(async () =>
                        {
                            // Do the actual request and wait for it to finish.
                            await Task.Run(()=> UpdateDashboard());
                            // Switch back to the UI thread to update the UI
                            Device.BeginInvokeOnMainThread(() =>
                                {
                                    // Update the UI
                                    // ...
                                    // Now repeat by scheduling a new request
                                    AnimateDashboard();
                                });
                        });

                    // Don't repeat the timer (we will start a new timer when the request is finished)
                    return false;
                });
        }

        private void UpdateDashboard() {
            var rnd = new Random();
            _vm.ChokeAPressure = (float)rnd.Next(20, 24);
            _vm.ChokeBPressure = (float)rnd.Next(17, 19);
            _vm.RotaryTorque = (float)rnd.Next(90, 95);
            _vm.RotarySpeed = rnd.Next(123, 126);
            _vm.MudTemperature = (float)rnd.Next(80, 84);
        }
    }
}

