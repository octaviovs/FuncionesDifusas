using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuncionesDifusas.Funciones;

namespace FuncionesDifusas
{
    public partial class Form1 : Form
    {

        public List<double> ListaDatos;
        public List<double> parametros;


        public List<double> ListaDatosB;
        public List<double> parametrosB;


        public Trapezoidal Trape;
        public Triangular Triang;
        public operaciones MisOperaciones;
        public Form1()
        {
            InitializeComponent();





            parametros = new List<double>();
            parametros.Add(1.50);
            parametros.Add(1.55);
            parametros.Add(1.70);
            parametros.Add(1.75);


            parametrosB = new List<double>();
            parametrosB.Add(1.50);
            parametrosB.Add(1.55);
            parametrosB.Add(1.70);
            parametrosB.Add(1.75);



            ListaDatos = new List<double>();// lista donde se guardaran los datos ingresados
            ListaDatos.Add(1.50);
            ListaDatos.Add(1.52);
            ListaDatos.Add(1.54);
            ListaDatos.Add(1.56);
            ListaDatos.Add(1.58);
            ListaDatos.Add(1.60);
            ListaDatos.Add(1.62);
            ListaDatos.Add(1.64);
            ListaDatos.Add(1.66);
            ListaDatos.Add(1.68);
            ListaDatos.Add(1.70);
            ListaDatos.Add(1.72);
            ListaDatos.Add(1.74);
            ListaDatos.Add(1.76);


            ListaDatosB = new List<double>();// lista donde se guardaran los datos ingresados
            ListaDatosB.Add(1.51);
            ListaDatosB.Add(1.52);
            ListaDatosB.Add(1.53);
            ListaDatosB.Add(1.56);
            ListaDatosB.Add(1.59);
            ListaDatosB.Add(1.60);
            ListaDatosB.Add(1.61);
            ListaDatosB.Add(1.62);
            ListaDatosB.Add(1.63);
            ListaDatosB.Add(1.64);
            ListaDatosB.Add(1.69);
            ListaDatosB.Add(1.73);
            ListaDatosB.Add(1.74);
            ListaDatosB.Add(1.77);


            //imprimirmos los valoes en el textbox de datos
            llenarDatos(textBoxDatos, ListaDatos);
            llenarDatos(textBoxDatosB, ListaDatosB);
            //inizializo los objetos
            Trape = new Trapezoidal();
            Triang = new Triangular();
            MisOperaciones = new operaciones();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Metodos del formulario
        private void llenarDatos( TextBox textBoxDatos, List<double> ListaDatos) {
            textBoxDatos.Text = "";
            foreach (var item in ListaDatos)
                textBoxDatos.Text += item.ToString()+"  ,";
        }

        //Metodos de botones
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxResultado.Text = "";
                List<double> aux = new List<double>();
                if (radioButtonTrapezoidal.Checked)
                {
                    aux = Trape.resultado(ListaDatos, parametros);
                }
                if (radioButtonTriangular.Checked)
                {
                    aux = Triang.resultado(ListaDatos, parametros);
                }

                foreach (var item in aux)
                {
                    textBoxResultado.Text += item + "     \n";
                }

            }
            catch (Exception)
            {

            }
            finally {
               
            }
        }

        private void buttonAgregarNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                ListaDatos.Add(Convert.ToDouble(textBoxAgregarNuevo.Text));
            }
            catch (Exception)
            {


            }
            finally {
                llenarDatos(textBoxDatos, ListaDatos);
                textBoxAgregarNuevo.Text = "";
            }
            
        }

        private void buttonParametros_Click(object sender, EventArgs e)
        {
            parametros.Clear();
            parametros.Add(Convert.ToDouble(textBoxA.Text));
            parametros.Add(Convert.ToDouble(textBoxB.Text));
            parametros.Add(Convert.ToDouble(textBoxC.Text));
            parametros.Add(Convert.ToDouble(textBoxD.Text));
        }

        private void radioButtonTriangular_CheckedChanged(object sender, EventArgs e)
        {
            textBoxD.Enabled = false;
            textBoxDB.Enabled = false;
        }

        private void radioButtonTrapezoidal_CheckedChanged(object sender, EventArgs e)
        {
            textBoxD.Enabled = true;
            textBoxDB.Enabled = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAgregarNuevoB_Click(object sender, EventArgs e)
        {
            try
            {
                ListaDatosB.Add(Convert.ToDouble(textBoxAgregarNuevoB.Text));
            }
            catch (Exception)
            {


            }
            finally
            {
                llenarDatos(textBoxDatosB, ListaDatosB);
                textBoxAgregarNuevoB.Text = "";
            }
        }

        private void buttonParametrosB_Click(object sender, EventArgs e)
        {
            parametrosB.Clear();
            parametrosB.Add(Convert.ToDouble(textBoxAB.Text));
            parametrosB.Add(Convert.ToDouble(textBoxBB.Text));
            parametrosB.Add(Convert.ToDouble(textBoxCB.Text));
            parametrosB.Add(Convert.ToDouble(textBoxDB.Text));
        }

        private void button2_Click(object sender, EventArgs e) { 
        
            textBoxResultadoB.Text = "";
            List<double> aux = new List<double>();
            if (radioButtonTrapezoidal.Checked)
            {
                aux = Trape.resultado(ListaDatosB, parametrosB);
            }
            if (radioButtonTriangular.Checked)
            {
                aux = Triang.resultado(ListaDatosB, parametrosB);
            }

            foreach (var item in aux)
            {
                textBoxResultadoB.Text += item + "     \n";
            }
        }

        private void buttonActualizarConjutnos_Click(object sender, EventArgs e)
        {
            try
            {

                textBoxConA.Text = "";
                textBoxConB.Text = "";
                List<double> aux = new List<double>();
                List<double> auxB = new List<double>();
                if (radioButtonTrapezoidal.Checked)
                {
                    aux = Trape.resultado(ListaDatos, parametros);
                    auxB= Trape.resultado(ListaDatosB, parametros);
                }
                if (radioButtonTriangular.Checked)
                {
                    aux = Triang.resultado(ListaDatos, parametros);
                    auxB = Triang.resultado(ListaDatosB, parametrosB);
                }

                foreach (var item in aux)
                {
                    textBoxConA.Text += item + "     \n";
                }
                foreach (var item in auxB)
                {
                    textBoxConB.Text += item + "     \n";
                }

            }
            catch (Exception)
            {

            }
            finally
            {

            }
        }

        private void buttonOperaciones_Click(object sender, EventArgs e)
        {

            try
            {

               
                List<double> aux = new List<double>();
                List<double> auxB = new List<double>();
                List<double> ComplementoA = new List<double>();
                List<double> ComplementoB = new List<double>();
                List<double> union = new List<double>();
                List<double> interseccion = new List<double>();

                if (radioButtonTrapezoidal.Checked)
                {
                    aux = Trape.resultado(ListaDatos, parametros);
                    auxB = Trape.resultado(ListaDatosB, parametros);


                    union = MisOperaciones.union(aux, auxB);
                    interseccion = MisOperaciones.interseccion(aux, auxB);

                    ComplementoA = MisOperaciones.complemento(aux);
                    ComplementoB = MisOperaciones.complemento(auxB);

                }
                if (radioButtonTriangular.Checked)
                {
                  
                    aux = Triang.resultado(ListaDatos, parametros);
                    auxB = Triang.resultado(ListaDatosB, parametrosB);
               

                    union = MisOperaciones.union(aux, auxB);

                    interseccion = MisOperaciones.interseccion(aux, auxB);
                    ComplementoA = MisOperaciones.complemento(aux);
                    ComplementoB = MisOperaciones.complemento(auxB);
                }

                //union
                foreach (var item in union)
                {
                    textBoxUnion.Text += item + "     \n";
                }

                //interseccion
                foreach (var item in interseccion)
                {
                    textBoxinterseccion.Text += item + "     \n";
                }


                // complemento
                foreach (var item in ComplementoA)
                {
                    textBoxComplementoA.Text += item + "     \n";
                }
                foreach (var item in ComplementoB)
                {
                    textBoxComplementoB.Text += item + "     \n";
                }

            }
            catch (Exception)
            {

            }
            finally
            {

            }
        }
    }
}
