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

namespace Vista
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ColleccionKeyBlade col = new ColleccionKeyBlade();
        public MainWindow()
        {
            InitializeComponent();
            cbxElementArma.ItemsSource = Enum.GetValues(typeof(Element));
            cbxTipoArma.ItemsSource = Enum.GetValues(typeof(TypeKeyBlade));
            cbxTipoArmEsc.ItemsSource = Enum.GetValues(typeof(TypeKeyBlade));
            cbxElementEsc.ItemsSource = Enum.GetValues(typeof(Element));
        }

        private void btnArma_Click(object sender, RoutedEventArgs e)
        {
            Arma arm = new Arma();
            arm.Name = txtNameArma.Text;
            arm.Large = int.Parse(txtLargoArma.Text);
            arm.PointDamage = int.Parse(txtPointDmgArma.Text);
            arm.PointMagic = int.Parse(txtPointMagDmgArma.Text);
            arm.PointDef = int.Parse(txtPointDefArma.Text);
            arm.Description = txtDescriArms.Text;
            arm.Type = (TypeKeyBlade)cbxTipoArma.SelectedItem;
            arm.Elem = (Element)cbxElementArma.SelectedItem;
            arm.calcularDano();

            col.Add(arm);

            DGListaArma.ItemsSource = col.ListaArma();
        }

        private void DGEscudo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnEscudo_Click(object sender, RoutedEventArgs e)
        {
            Escudo esc = new Escudo();

            esc.Name = txtEscudoNombre.Text;
            esc.Large = int.Parse(txtLargoEsc.Text);
            esc.PointDamage = int.Parse(txtEscDan.Text);
            esc.PointMagic = int.Parse(txtEscMag.Text);
            esc.PointDef = int.Parse(txtEscDef.Text);
            esc.Description = txtDesEsc.Text;
            esc.Type = (TypeKeyBlade)cbxTipoArmEsc.SelectedItem;
            esc.Eleme = (Element)cbxElementEsc.SelectedItem;
            esc.calcularDano();

            col.Add(esc);

            DGEscudo.ItemsSource = col.ListaEscudo();
        }
    }
}
