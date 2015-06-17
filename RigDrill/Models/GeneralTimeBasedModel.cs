using System;

namespace RigDrill
{
    public class GeneralTimeBasedModel
    {
        public string WellId
        {
            get;
            set;
        }

        public int ActivityCode
        {
            get;
            set;
        }

        public float ChokeAPressure
        {
            get;
            set;
        }


        public float ChokeBPressure
        {
            get;
            set;
        }


        public float RotaryTorque
        {
            get;
            set;
        }


        public int RotarySpeed
        {
            get;
            set;
        }


        public float MudTemprature
        {
            get;
            set;
        }
    }
}

