using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public static class PaqueteDAO
    {
        private static SqlCommand _command;
        private static SqlConnection _connection;

        static PaqueteDAO()
        {
            PaqueteDAO._connection = new SqlConnection(Entidades.Properties.Settings.Default.Correo);
        }

        public static bool Insert(Paquete p)
        {
            bool aux = false;

            try
            {
                PaqueteDAO._connection.Open();
                PaqueteDAO._command = new SqlCommand("INSERT into [correo-sp-2017].[dbo].[Paquetes]([direccionEntrega],[trackingID],[alumno]) VALUES ('" + p.DireccionEntrega + "','" + p.TrackingID + "','Alviggi Augusto')", PaqueteDAO._connection);

                int registrosAfectados = PaqueteDAO._command.ExecuteNonQuery();

                if (registrosAfectados > 0)
                {
                    aux = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                PaqueteDAO._connection.Close();
            }

            return aux;
        }
    }
}



