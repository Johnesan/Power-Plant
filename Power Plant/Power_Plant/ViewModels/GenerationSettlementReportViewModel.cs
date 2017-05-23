using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Plant.ViewModels
{
    class GenerationSettlementReportViewModel : INotifyPropertyChanged
    {
        public int IG5 { get; set; }
        public int MyProperty { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
