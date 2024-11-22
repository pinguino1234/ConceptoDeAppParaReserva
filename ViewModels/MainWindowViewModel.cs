using Avalonia;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using ConceptoDeAppParaReserva.Models;
using HarfBuzzSharp;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConceptoDeAppParaReserva.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [ObservableProperty]
        ObservableCollection<Negocio> _Negocio = [];

        [ObservableProperty]
        bool _IsVisible = false;

        public MainWindowViewModel()
        {
            if (Design.IsDesignMode)
            {
                Negocio.Add(new Negocio
                {
                    Nombre = "Restaurante Playa Azul",
                    Descripcion = "Los Mejores Tacos de Tepatitlán!",
                    Direccion = "Bldv. Anacleto Glez Flores #457",
                    MinPersonas = 1,
                    MaxPersonas = 16,
                    Intervalo = 15
                });

                IsVisible = true;
            }

            WeakReferenceMessenger.Default.Register<ReciveNewNegocio>(this, (r, m) =>
            {
                Negocio.Add(m.Negocio);
                IsVisible = true;
            });
        }
    }

    // Create a message
    public class ReciveNewNegocio : ValueChangedMessage<Negocio>
    {
        public Negocio Negocio;

        public ReciveNewNegocio(Negocio negocio) : base(negocio)
        {
            Negocio = negocio;
        }
    }
}
