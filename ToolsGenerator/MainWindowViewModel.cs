using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsGenerator
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _testo = "Mattia"; public string Testo { get => _testo; set { Set(() => Testo, ref _testo, value); }}
    }
}
