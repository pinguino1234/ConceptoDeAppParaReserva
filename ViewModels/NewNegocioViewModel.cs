using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using ConceptoDeAppParaReserva.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptoDeAppParaReserva.ViewModels
{
    public partial class NewNegocioViewModel : ViewModelBase
    {
        [ObservableProperty]
        string _Nombre = string.Empty;

        [ObservableProperty]
        string _Descripcion = string.Empty;

        [ObservableProperty]
        string _Direccion = string.Empty;

        [ObservableProperty]
        int _Min = 0;

        [ObservableProperty]
        int _Max = 0;

        [ObservableProperty]
        int _Intervalo = 0;

        public void AddNewNegocio(object mnsg)
        {
            Negocio MiNegocio = new Negocio
            {
                Nombre = Nombre,
                Descripcion = Descripcion,
                Direccion = Direccion,
                MinPersonas = Min,
                MaxPersonas = Max,
                Intervalo = Intervalo
            };

            // Send a message from some other module
            WeakReferenceMessenger.Default.Send(new ReciveNewNegocio(MiNegocio));
        }
    }
}
