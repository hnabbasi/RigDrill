using System;
using System.Collections.Generic;
using System.ServiceModel.Channels;

namespace RigDrill
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
        }

        public List<RigIdentifierModel> Rigs
        {
            get { return WellRepository.GetRigs(); }
        }
    }
}

