using System;
using System.ServiceModel.Channels;

namespace RigDrill
{
    public class RigDashboardViewModel : BaseViewModel
    {
        private string wellId;
        private GeneralTimeBasedModel _rigData;
        private float _chokeAPressure;
        private float _chokeBPressure;
        private float _rotaryTorque;
        private int _rotarySpeed;
        private float _mudTemperature;

        public RigDashboardViewModel(string wellId)
        {
            this.wellId = wellId;
            _rigData = WellDataRepository.GetRigData(wellId);

            LoadData();
        }

        private void LoadData() {
            _chokeAPressure = _rigData.ChokeAPressure;
            _chokeBPressure = _rigData.ChokeBPressure;
            _rotaryTorque = _rigData.RotaryTorque;
            _rotarySpeed = _rigData.RotarySpeed;
            _mudTemperature = _rigData.MudTemprature;
        }

        public float ChokeAPressure
        {
            get { return _chokeAPressure; }
            set { _chokeAPressure = value; OnPropertyChanged(); }
        }

        public float ChokeBPressure
        {
            get { return _chokeBPressure; }
            set { _chokeBPressure = value; OnPropertyChanged();}
        }

        public float RotaryTorque
        {
            get { return _rotaryTorque; }
            set { _rotaryTorque = value; OnPropertyChanged();}
        }

        public int RotarySpeed
        {
            get { return _rotarySpeed; }
            set { _rotarySpeed = value; OnPropertyChanged();}
        }

        public float MudTemperature
        {
            get { return _mudTemperature; }
            set { _mudTemperature = value; OnPropertyChanged();}
        }



    }
}

