using System;
using System.Collections.Generic;

namespace RigDrill
{
    public static class WellDataRepository
    {
        private static List<GeneralTimeBasedModel> _generalTimeBasedModelList;

        public static GeneralTimeBasedModel GetRigData(string wellId) {

            _generalTimeBasedModelList = new List<GeneralTimeBasedModel>();

            switch (wellId)
            {
                case "WELL001":
                    return new GeneralTimeBasedModel
                        {
                            WellId = "WELL001",
                            ActivityCode = 2,
                            ChokeAPressure = 20.0f,
                            ChokeBPressure = 30.0f,
                            RotaryTorque = 55.0f,
                            RotarySpeed = 70,
                            MudTemprature = 150.1f
                        };

                case "WELL002":
                    return new GeneralTimeBasedModel
                        {
                            WellId = "WELL002",
                            ActivityCode = 2,
                            ChokeAPressure = 23.0f,
                            ChokeBPressure = 31.0f,
                            RotaryTorque = 51.0f,
                            RotarySpeed = 80,
                            MudTemprature = 130.0f
                        };
                
                case "WELL003":
                    return new GeneralTimeBasedModel
                        {
                            WellId = "WELL003",
                            ActivityCode = 2,
                            ChokeAPressure = 14.0f,
                            ChokeBPressure = 19.0f,
                            RotaryTorque = 45.0f,
                            RotarySpeed = 55,
                            MudTemprature = 100.0f
                        };
                default:
                    return new GeneralTimeBasedModel();
            }
        }
    }
}

