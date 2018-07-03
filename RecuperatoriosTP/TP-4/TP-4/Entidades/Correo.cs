using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        private List<Paquete> _paquetes;
        private List<Thread> _mockPaquetes;

        public List<Paquete> Paquetes
        {
            get { return this._paquetes; }
            set
            {
                this._paquetes = value;
            }
        }

        public Correo()
        {
            this._paquetes = new List<Paquete>();
            this._mockPaquetes = new List<Thread>();
        }

        public void FinEntregas()
        {
            foreach (Thread hilo in this._mockPaquetes)
            {
                hilo.Abort();
            }
            this._mockPaquetes.Clear();
        }

        string IMostrar<List<Paquete>>.MostrarDatos(IMostrar<List<Paquete>> elemento)
        {
            StringBuilder stringBuild = new StringBuilder();

            foreach (Paquete paqueteA in this.Paquetes)
            {
                stringBuild.AppendFormat("{0} ({1})\n", paqueteA.ToString(), paqueteA.Estado);
            }
            return stringBuild.ToString();
        }

        public override string ToString()
        {
            return ((IMostrar<List<Paquete>>)this).MostrarDatos(this);
        }

        public static Correo operator +(Correo correo1, Paquete paquete1)
        {
            Correo auxC = correo1;
            bool aux = false;

            foreach (Paquete paquete in auxC._paquetes)
            {
                if (paquete == paquete1)
                {
                    aux = true;
                    break;
                }
            }

            if (aux!=true)
            {
                try
                {
                    Thread auxHilo = new Thread(paquete1.MockCicloDeVida);
                    auxC._mockPaquetes.Add(auxHilo);
                    auxC._paquetes.Add(paquete1);
                    auxHilo.Start();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            else
            {
                throw new TrackingIDRepetidoException("ID " + paquete1.TrackingID + " ya ingresado, el paquete ya existe en la lista de envios.");
            }
            return auxC;
        }
    }
}
