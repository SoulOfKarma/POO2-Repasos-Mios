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
        Cajon[] cajax = new Cajon[0];
        public MainWindow()
        {
            InitializeComponent();
            cbxMaterial.ItemsSource = Enum.GetValues(typeof(Material));
            cbxTamano.ItemsSource = Enum.GetValues(typeof(Tamano));
            cbxTipoF.ItemsSource = Enum.GetValues(typeof(TipoFruta));
            cbxMaterial.SelectedIndex = 0;
            cbxTamano.SelectedIndex = 0;
            cbxTipoF.SelectedIndex = 0;
        }

        private void btnAgregarCaja_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cajon caj = new Cajon();
                caj.CodCaja = txtCodCaja.Text;
                caj.CapMax = int.Parse(txtCapMax.Text);
                caj.Empresa = txtEmpresa.Text;
                caj.Mat = (Material)cbxMaterial.SelectedItem;
                caj.Tam = (Tamano)cbxTamano.SelectedItem;

                Array.Resize(ref cajax,cajax.Length+1);
                cajax[cajax.Length - 1] = caj;
                cbxCodCaFru.Items.Add(caj.CodCaja);

            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void btnAgregarFruta_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               foreach (var tmp in cajax)
                {
                    if (tmp.CodCaja.Equals(cbxCodCaFru.SelectedItem))
                    {
                        Fruta fruts = new Fruta();
                        fruts.TipoFruta = (TipoFruta)cbxTipoF.SelectedItem;
                        fruts.Origen = txtOrigen.Text;
                        fruts.Destino = txtDestino.Text;
                        fruts.Codfruta = (tmp.Fru.Length + 1) + "-" + fruts.TipoFruta + "-" + tmp.Empresa;
                        int res = tmp.AgregarFruta(fruts);
                        if (res == 1)
                        {
                            MessageBox.Show("Se agrego " + fruts.Codfruta);
                        }
                        else
                        {
                            MessageBox.Show("No se agrego " + fruts.Codfruta);
                        }
                    }
                }

            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
    }
}
