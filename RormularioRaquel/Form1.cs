using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RormularioRaquel
{
    public partial class formulario : Form
    {

        /// <summary>
        /// clase para realizar formulario
        /// </summary>
        public List<IMaterializable> Materiales = new List<IMaterializable>(1000);
        public formulario()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">  recibe los materiales</param>
        /// <param name="e"></param>
        private void buttonAcero_Click(object sender, EventArgs e)
        {
            ///añade los materiales a la lista.
            Materiales.Add(CrearMateriales.aniadirMateriales((sender as Button).Text));
            
            ///la etiqueta para calcular el total de los materiales
            labelMaterialesTotales.Text = Materiales.Count.ToString();

            ///etiqueta para mostrar la cantidad media de los no perecederos
            labelCantidadMedia.Text = CalcularMediaNoPerecederos.CalcularMediaNP(Materiales).ToString();

            ///etiqueta para mostrar los kg del material perecedero no inflamable.
            labelKg.Text = PesoPerecedero.calcularPesoPerecedero(Materiales);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
