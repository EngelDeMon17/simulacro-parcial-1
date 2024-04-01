using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace simulacro_parcial_1
{
    public partial class Form1 : Form
    {
        List<Departamento> departamentos = new List<Departamento>();
        List<Temperatura> temperaturas = new List<Temperatura>();
        BindingList<Dato> datos = new BindingList<Dato>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string fileName = "Departamentos.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Departamento departamento = new Departamento();
                departamento.Id = Convert.ToInt16(reader.ReadLine());
                departamento.Nombre= reader.ReadLine();

                departamentos.Add(departamento);
            }

            reader.Close();

            comboBoxDepartamentos.DisplayMember = "Nombre";
            comboBoxDepartamentos.ValueMember = "Id";
            comboBoxDepartamentos.DataSource = departamentos;
            comboBoxDepartamentos.Refresh();
        }
        private void GuardarTemperatura()
        {

            FileStream stream = new FileStream("Temperaturas.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (var temperatura in temperaturas)
            {
                writer.WriteLine(temperatura.IdDepartamento);
                writer.WriteLine(temperatura.TemperaturaLeida);
                writer.WriteLine(temperatura.FechaLectura);
            }

            writer.Close();
        }
        private void comboBoxDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }   

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            Temperatura temperatura = new Temperatura();
            temperatura.IdDepartamento = Convert.ToInt32(comboBoxDepartamentos.SelectedValue);
            temperatura.TemperaturaLeida = Convert.ToInt32(textBoxTemperatura.Text);
            temperatura.FechaLectura = DateTime.Now;

            temperaturas.Add(temperatura);

            GuardarTemperatura();

        }

        private void buttonMostrarDatos_Click(object sender, EventArgs e)
        {
            foreach (var departamento in departamentos)
            {
                foreach (var temperatura in temperaturas)
                {
                    if (departamento.Id == temperatura.IdDepartamento)
                    {
                        Dato dato = new Dato();
                        dato.NombreDepartamento = departamento.Nombre;
                        dato.Temperatura = temperatura.TemperaturaLeida;
                        dato.Fecha = temperatura.FechaLectura;

                        datos.Add(dato);
                    }
                }
            }

            dataGridViewDatos.DataSource = null;
            dataGridViewDatos.DataSource = datos;
            dataGridViewDatos.Refresh();
        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
          
            var datosOrdenados = datos.OrderBy(dato => dato.Temperatura).ToList();
            dataGridViewDatos.DataSource = datosOrdenados;

            double promedio = datos.Average(dato => dato.Temperatura);
            labelPromedio.Text = promedio.ToString();
            labelPromedio.Visible = true;


        }
    }
}
