using CommunityToolkit.Mvvm.ComponentModel;
using ConceptoDeAppParaReserva.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptoDeAppParaReserva.Models
{
    public partial class Negocio : ViewModelBase
    {
        [ObservableProperty]
        public string _Nombre = string.Empty;

        [ObservableProperty]
        public string _Direccion = string.Empty;

        [ObservableProperty]
        public string _Descripcion = string.Empty;

        [ObservableProperty]
        public string _NombnreImagen = string.Empty;

        [ObservableProperty]
        public int _MinPersonas = 1;

        [ObservableProperty]
        public int _MaxPersonas = 1;

        [ObservableProperty]
        public int _Intervalo = 1;
    }
}
