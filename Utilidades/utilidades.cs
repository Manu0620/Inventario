using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Utilidades
{
    public class utilidades
    {
        public static bool esPrimo(int n)
        {
            int div = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    div++;
            }

            return (div == 2);
        }

        public static string ImprimirMatriz(int [,]m)
        {
            string ma = "";

            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    ma += "\t" + m[f, c].ToString();
                    
                }
                ma += "\n \n";
            }

            return ma;
        }

        public static string ConvierteLetras(Int64 n)
        {
            string cn = n.ToString().PadLeft(15, '0');
            Console.WriteLine(cn);
            int n1 = Convert.ToInt32(cn.Substring(0, 3));
            int n2 = Convert.ToInt32(cn.Substring(3, 3));
            int n3 = Convert.ToInt32(cn.Substring(6, 3));
            int n4 = Convert.ToInt32(cn.Substring(9, 3));
            int n5 = Convert.ToInt32(cn.Substring(12, 3));

            string letras = ""; 

            if (n1 > 0) letras += Convierte999(n1) + " billones";
            if (n2 > 0) letras += Convierte999(n2) + " mil";
            if (n3 > 0) letras += Convierte999(n3) + " millones";
            if (n4 > 0) letras += Convierte999(n4) + " mil";
            if (n5 > 0) letras += Convierte999(n5);

            //Arreglitos 
            letras = letras.ToLower().Replace("  "," ");
            letras = letras.Replace("uno billones", "billon");
            letras = letras.Replace("uno mil", "mil");
            letras = letras.Replace("y mil", "y uno mil");
            if (letras.Equals(" millones")) letras = letras.Replace("millones", "un millon");

            return letras;
        }

        public static string Convierte999(int n)
        {
            if (n <= 0 || n > 999)
                return "";

            string[] vu = new string[]
                {
                            "Manuel"," uno", " dos", " tres", " cuatro", " cinco", " seis", " siete", " ocho", " nueve",
                            " diez"," once"," doce"," trece"," catorce"," quince"," dieciséis"," diecisiete"," dieciocho"," diecinueve","veinte"
                            ," veintiuno"," veintidos"," veintitres"," veinticuatro"," veinticinco"," veintiseis"," veintisiete"," veintiocho"," veintinueve"
                };

            string[] vd = new string[]
                {
                    "Manuel"," diez"," veinte", " treinta"," cuarenta"," cincuenta"," sesenta"," setenta"," ochenta"," noventa"
                };

            string letras = "";

            if (n == 100)
                return " cien";

            string cn = n.ToString().PadLeft(3, '0'); // Rellenar de 0 ejemplo 5 = 005
            int c = Convert.ToInt32(cn.Substring(0, 1));
            int d = Convert.ToInt32(cn.Substring(1, 1));
            int u = Convert.ToInt32(cn.Substring(2, 1));
            int u2 = Convert.ToInt32(cn.Substring(1, 2));
            
            if (c > 0) letras += vu[c] + " cientos";
            
            if (u2 > 0)
            {
                if (u2 < 30)
                    letras += vu[u2];
                else
                {
                    letras += vd[d];
                    if (u > 0)
                        letras += " y " + vu[u];
                }
            }

            letras = letras.ToLower().Replace("  ", " ");
            letras = letras.Replace("cinco cientos", "quinientos");
            letras = letras.Replace("siete cientos", "setecientos");
            letras = letras.Replace("nueve cientos", "novecientos");
            letras = letras.Replace("uno cientos", "cientos");

            return letras;
        }

        public static void TraducirAvoz(Int64 n)
        {
            string letras = Utilidades.utilidades.ConvierteLetras(n);

            string[] vl = letras.Trim().Split(' ');
            Console.WriteLine(letras);

            for (int i = 0; i < vl.Length; i++)
            {
                string archivo = @"C:\Users\Maricela Filpo\Desktop\Clases\Ciclo 3-2020\Lab. Programacion III\Numeros\" + vl[i] + ".wav";
                using (var player = new SoundPlayer(archivo))
                {
                    player.PlaySync();
                }
            }
        }

        public static string Verificar2numeros(int n1, int n2)
        {
            string resultado;
            int menor, mayor, cn=0;

            if (Utilidades.utilidades.esPrimo(n1))
                resultado = "El numero 1 es primo ,";
            else
                resultado = "El numero 1 no es primo ,";

            if (Utilidades.utilidades.esPrimo(n1))
                resultado += " El numero 2 es primo y";
            else
                resultado += " El numero 2 no es primo y";

            if (n1 > n2)
            {
                mayor = n1;
                menor = n2;
            }
            else
            {
                mayor = n2;
                menor = n1;
            }

            for(int i = menor; i<mayor; i++)
            {
                if (Utilidades.utilidades.esPrimo(i))
                    cn++;
            }

            if (cn > 0)
                resultado += " si hay numeros primos entre ellos : " + cn;
            else
                resultado += " NO hay numeros primos entre ellos";

            return resultado;
        }

        public static void CreaArchivo(string archivo, string contenido)
        {
            if (!File.Exists(archivo))
            {
                using (StreamWriter sw = File.CreateText(archivo))
                {
                    sw.WriteLine(contenido);
                }
            }
        }

        public static string LeerArchivo(string archivo)
        {
            string c = "";
            string contenido = "";
            using (StreamReader sr = File.OpenText(archivo))
            {
                while ((c = sr.ReadLine()) != null)
                    contenido += c + "\n";
            }
            return contenido;
        }

        public static DataSet ConectarSQL(string comando)
        {
            string sConnectionString = "Data Source=(local);Initial Catalog=Inventario;Integrated Security=true";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = sConnectionString;
            connection.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(comando, connection);

            DP.Fill(DS);

            connection.Close();

            return DS;
        }

        public static bool ValidaForm(Control control, ErrorProvider error)
        {
            bool conerror = false;
            
            foreach (Control item in control.Controls)
            {
                if (item.Controls.Count > 0)
                {
                    bool conerror2 = ValidaForm(item, error);
                    if (conerror2 == true)
                        conerror = true;
                }

                if (item is Utilidades.textbox)
                {
                    Utilidades.textbox obj = (Utilidades.textbox) item;

                    if (obj.Validar == true)
                    {
                        error.SetError(obj, (string.IsNullOrEmpty(obj.Text.Trim())) ? "Campo obligatorio" : "");
                        if(string.IsNullOrEmpty(obj.Text.Trim()))
                            conerror = true;
                    }
                }
            }
            return conerror;
        }

        public static Boolean dsTieneDatos(DataSet dsdatos)
        {
            return dsTieneDatos(dsdatos, false);
        }

        public static Boolean dsTieneDatos(DataSet dsdatos, bool SoloUna)
        {
            if (dsdatos == null || dsdatos.IsInitialized == false)
                return false;

            try
            {
                if (dsdatos.Tables.Count == 0)
                    return false;

                if (dsdatos.Tables[0].Rows.Count > 0)
                    return true;

                if (SoloUna)
                    return false;

                for(int i=0; i< dsdatos.Tables.Count; i++)
                {

                }
            }
            catch {}

            return false;
        }

        public static Boolean dsTieneDatos(DataView dsdatos)
        {
            try
            {
                if (dsdatos.Table.Rows.Count > 0)
                    return true;
            }catch { }
            return false;
        }
    }
}
