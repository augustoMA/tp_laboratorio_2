using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class GuardaString
    {
        public static bool Guardar(this string cadena, string archivo)
        {
            bool retorno = false;
            StreamWriter aux;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + archivo + ".txt";

            if ((aux = new StreamWriter(path, true)) != null)
            {
                aux.WriteLine(cadena);
                retorno = true;
            }

            aux.Close();
            return retorno;
        }
    }
}
