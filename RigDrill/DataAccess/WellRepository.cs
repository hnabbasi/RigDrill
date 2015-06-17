using System;
using System.Collections.Generic;

namespace RigDrill
{
    public class WellRepository
    {
        private static List<RigIdentifierModel> _rigIdentifierModelList;

        public static List<RigIdentifierModel> GetRigs() {

            _rigIdentifierModelList = new List<RigIdentifierModel>();

            _rigIdentifierModelList.Add(
                new RigIdentifierModel
                {
                    WellId = "WELL001",
                    WellName = "Rig One",
                    WellLocLatitude = 30.320505,
                    WellLocLongitude = -97.731772,
                    WellIconUrl = "http://www.hussainabbasi.com/docs/sogeti/rig1.jpg"
                });
            _rigIdentifierModelList.Add(
                new RigIdentifierModel
                {
                    WellId = "WELL002",
                    WellName = "Rig Two",
                    WellLocLatitude = 27.803919,
                    WellLocLongitude = -97.398705,
                    WellIconUrl = "http://www.hussainabbasi.com/docs/sogeti/rig2.jpg"
                });
            _rigIdentifierModelList.Add(
                new RigIdentifierModel {
                    WellId = "WELL003",
                    WellName = "Rig Three",
                WellLocLatitude = 29.662024, 
                WellLocLongitude = -95.009432,
                    WellIconUrl="http://www.hussainabbasi.com/docs/sogeti/rig3.jpg"
                });
            return _rigIdentifierModelList;
        }
    }
}

