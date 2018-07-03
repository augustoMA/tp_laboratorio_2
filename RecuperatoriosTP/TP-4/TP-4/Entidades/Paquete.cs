using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        private string _direccionEntrega;
        private string _trackingID;
        private EEstado _estado;

        public string DireccionEntrega
        {
            get { return this._direccionEntrega; }
            set
            {
                 this._direccionEntrega = value;
            }
        }

        public string TrackingID
        {
            get { return this._trackingID; }
            set
            {
                this._trackingID = value;
            }
        }

        public EEstado Estado
        {
            get { return this._estado; }
            set
            {
                this._estado = value;
            }
        }

        public Paquete(string direccionEntrega, string trackingID)
        {
            this.DireccionEntrega = direccionEntrega;
            this.TrackingID = trackingID;
            this.Estado = EEstado.Ingresado;
        }

        public void MockCicloDeVida()
        {
            do
            {
                Thread.Sleep(10000);
                this.Estado++;
                this.InformarEstado.Invoke(this, new EventArgs());

            } while (this.Estado != EEstado.Entregado);

            try
            {
                PaqueteDAO.Insert(this);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        string IMostrar<Paquete>.MostrarDatos(IMostrar<Paquete> elemento)
        {
            StringBuilder stringBuild = new StringBuilder();
            stringBuild.AppendFormat("{0} para {1}", ((Paquete)elemento).TrackingID, ((Paquete)elemento).DireccionEntrega);

            return stringBuild.ToString();
        }

        public static bool operator ==(Paquete paquete1, Paquete paquete2)
        {
            bool retorno = false;

            if (paquete1.TrackingID == paquete2.TrackingID)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Paquete paquete1, Paquete paquete2)
        {
            return !(paquete1 == paquete2);
        }

        public override string ToString()
        {
            return ((IMostrar<Paquete>)this).MostrarDatos(this);
        }

        public delegate void DelegadoEstado(object sender, EventArgs e);
        public event DelegadoEstado InformarEstado;
    }
}
