using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Biblioteca;

namespace Armas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CollecionArmas col = new CollecionArmas();
        public MainWindow()
        {
            InitializeComponent();
            CBXTipoAxe.ItemsSource = Enum.GetValues(typeof(Hachas));
            CBXTipoEsp.ItemsSource = Enum.GetValues(typeof(Espadas));
            
        }

        private void btnAgregarEspada_Click(object sender, RoutedEventArgs e)
        {
            Swords swo = new Swords();
            swo.NombreArma = txtNomEsp.Text;
            swo.CantidadArma = int.Parse(txtCantEsp.Text);
            swo.FechaCreacion = (DateTime)DPCreEsp.SelectedDate;
            swo.Precio = int.Parse(txtPreExp.Text);
            swo.TipoEspada = (Espadas)CBXTipoEsp.SelectedItem;
            swo.FechaCheckeoArmas = (DateTime)DPFecRepEsp.SelectedDate;
            swo.CantidadReparaciones = int.Parse(txtRepEsp.Text);
            swo.CalcularEfectividadReparacion();

            col.Add(swo);

            DGEsp.ItemsSource = col.ListaEsp();
        }

        private void btnAgregarHacha_Click(object sender, RoutedEventArgs e)
        {
            Axes ax = new Axes();

            ax.NombreArma = txtNomAxe.Text;
            ax.CantidadArma = int.Parse(txtCantAxe.Text);
            ax.FechaCreacion = (DateTime)DPFechaCreAxe.SelectedDate;
            ax.Precio = int.Parse(txtPreAxe.Text);
            ax.TipoHacha = (Hachas)CBXTipoAxe.SelectedItem;
            ax.FechaCheckeoArmas = (DateTime)DPFechaRepAxe.SelectedDate;
            ax.CantidadReparaciones = int.Parse(txtCantRepAxe.Text);
            ax.CalcularEfectividadReparacion();

            col.Add(ax);

            DGAxe.ItemsSource = col.ListaAxe();
        }
    }
}
