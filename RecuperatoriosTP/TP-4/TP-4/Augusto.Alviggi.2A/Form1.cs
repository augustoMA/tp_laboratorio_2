using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Augusto.Alviggi._2A
{
    public partial class Form1 : Form
    {
        private Correo correo;

        public Form1()
        {
            InitializeComponent();
            this.rtxtLista.Enabled = false;
            this.correo = new Correo();
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.correo.FinEntregas();
        }

        private void ActualizarEstados()
        {
            foreach (Control i in this.gbEstados.Controls)
            {
                if (i is ListBox)
                {
                    ((ListBox)i).Items.Clear();
                }
            }

            foreach (Paquete item in this.correo.Paquetes)
            {
                switch (item.Estado)
                {
                    case EEstado.Ingresado:
                        this.lbIngresado.Items.Add(item); 
                        break;
                    case EEstado.EnViaje:
                        this.lbEnViaje.Items.Add(item);
                        break;
                    case EEstado.Entregado:
                        this.lbEntregado.Items.Add(item);
                        break;
                    default:
                        break;
                }
            }
        }

        void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if (((object)elemento) != null)
            {
                if (((Object)elemento) is Correo)
                {
                    this.rtxtLista.Text = ((Correo)elemento).ToString();
                }
                else if (((Object)elemento) is Paquete)
                {
                    this.rtxtLista.Text = ((Paquete)elemento).ToString();
                }

                GuardaString.Guardar(this.rtxtLista.Text, "Salida");
            }
        }

        void paq_InformarEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado Pd = new Paquete.DelegadoEstado(paq_InformarEstado);
                this.Invoke(Pd, new object[] { sender, e });
            }
            else
            { 
                this.ActualizarEstados();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Paquete paquete = new Paquete(this.txtMostrar.Text, this.mtxtAgregar.Text);

            paquete.InformarEstado += new Paquete.DelegadoEstado(this.paq_InformarEstado);

            try
            {
                this.correo += paquete;
                this.ActualizarEstados();
            }
            catch (TrackingIDRepetidoException Excepcion)
            {
                MessageBox.Show(Excepcion.Message.ToString(), "Alerta", MessageBoxButtons.OK);
            }
            catch (Exception ExcepcionN)
            {
                MessageBox.Show("Error en base de datos", "Alerta", MessageBoxButtons.OK);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }

        private void mostrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lbEntregado.SelectedItem);
        }

        private void lbEntregado_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip1.Show((ListBox)sender, e.Location, ToolStripDropDownDirection.Right);
            }
        }
    }
}
