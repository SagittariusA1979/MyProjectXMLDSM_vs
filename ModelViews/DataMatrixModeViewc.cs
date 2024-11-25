using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using MyProjectXMLDSM_vs.Models;
using Windows.Devices.PointOfService;

namespace MyProjectXMLDSM_vs.ModelViews
{
    public partial class DataMatrixModeView : ObservableObject
    {
        private DataMatrix _dataMatrix;

        [ObservableProperty]
        private string ipPrinter;

        [ObservableProperty]
        private int _port;

        public DataMatrixModeView() 
        {
            this.IpPrinter = string.Empty;
            this.Port = 0;

            _dataMatrix = new DataMatrix(IpPrinter, Port);

        }
    }
}
