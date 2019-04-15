using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Tarea3_FSI
{
   
    public partial class Form1 : Form
    {
        CArreglo objarreglo = new CArreglo();
        Cvendedor objvendedor = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int auxcodigo = Convert.ToInt32(textBoxCodigo.Text);
            string auxnombre = textBoxVendedor.Text;
            int auxmonto = Convert.ToInt32(textBoxVentas.Text);
            objvendedor = new Cvendedor(auxcodigo, auxnombre, auxmonto);
            if(objarreglo.Insertar(objvendedor,auxcodigo)==1)
            {
                MessageBox.Show("Ha repetido Codigo ¡Estafador!");
            }
            else
            {
                listBoxCodigo.Items.Add(auxcodigo.ToString());
                listBoxVendedor.Items.Add(auxnombre);
                listBoxVentas.Items.Add(auxmonto.ToString());
                textBoxCodigo.Clear();
                textBoxVendedor.Clear();
                textBoxVentas.Clear();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mostrar = objarreglo.Mostrar_Mayor();

            MessageBox.Show("Nombre: "+mostrar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string aux = objarreglo.Mostrar_Menor();

            MessageBox.Show("Nombre: " + aux);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string promedio = objarreglo.Mostrar_Promedio().ToString();
            MessageBox.Show("Promedio: "+promedio);
        }

        private void button5_Click(object sender, EventArgs e)
        {

       //  string []mensaje=  objarreglo.Ordenar();

            /*    
               for(int i=0;i<mensaje.Length;i++)
               {
                   string aux1 = mensaje[i];
                   int aux3;
                   char a3= aux1[0];
                   aux3 = (int)(a3);
                   string aux2 = mensaje[i + 1];
                   char a4;
                   int aux4;
                   a4 = aux2[0];
                   aux4 = (int)(a4);
                   if(aux3>aux4)
                   {
                       string aux;
                       aux = mensaje[i];
                       mensaje[i] = mensaje[i+1];
                       mensaje[i+1] = aux;
                   }

               }
               */


            /* for (int i = 0; i < mensaje.Length; i++)
                  {
                          MessageBox.Show(mensaje[i]);

                  }
             */
            listBoxVendedor.Sorted = true;
            listBoxCodigo.Items.Clear();
            listBoxVentas.Items.Clear();
            Array auxarr = objarreglo.Devolver_Arreglo();
            for (int i=0;i<listBoxVendedor.Items.Count;i++)
            {
               
                string aux = listBoxVendedor.Items[i].ToString();
                foreach (Cvendedor elemento in auxarr)
                {
                    if (elemento != null)
                    {
                        if (elemento.Nombre == aux)
                        {
                                listBoxCodigo.Items.Insert(i, elemento.Codigo);
                            listBoxVentas.Items.Insert(i, elemento.Monto);
                        }

                    }
                 }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por su visita");
            Close();
        }
    }
}
