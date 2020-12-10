using System;
using System.Media;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Ejemplos : Form
    {
        public Ejemplos()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Verificar_Click(object sender, EventArgs e)
        {
            EstadoCaja.Text = "";
            if (string.IsNullOrEmpty(Dato.Text.Trim()))
            {
                MessageBox.Show("Debe introducir un numero!");
                return;
            }

            int n = Convert.ToInt32(Dato.Text.Trim());

            if (Utilidades.utilidades.esPrimo(n))
            {
                MessageBox.Show("Es primo");
            }
            else
            {
                MessageBox.Show("No es primo");
            }
        }
        private void Primos100_Click(object sender, EventArgs e)
        {
            Caja.Text = "";
            EstadoCaja.Text = "100 primos";
            int cp = 0, n = 0;

            while (cp < 100)
            {
                n++;
                if (Utilidades.utilidades.esPrimo(n))
                {
                    cp++;
                    Caja.Text += "\t" + n.ToString();

                }
            }
        }

        private void matriz_Click(object sender, EventArgs e)
        {
            EstadoCaja.Text = "Matriz";
            Caja.Text = "";
            int[,] m = new int[5, 5];
            int cp = 0;

            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if (f == c) m[f, c] = 1;
                    else
                    if (f + c == 4) m[f, c] = 2;
                    else
                    {
                        if (f < c)
                        {
                            if (f + c < 4)
                                m[f, c] = 3;
                            else
                                m[f, c] = 4;
                        }
                        else
                        {
                            if (f + c < 4)
                                m[f, c] = 6;
                            else
                                m[f, c] = 5;
                        }
                    }

                    if (Utilidades.utilidades.esPrimo(m[f, c]))
                    {
                        cp++;
                    }
                }
            }
            Caja.Text = Utilidades.utilidades.ImprimirMatriz(m);
            Dato.Text = cp.ToString();
        }

        private void NaL_Click(object sender, EventArgs e)
        {
            EstadoCaja.Text = "De numeros a letras";
            Caja.Text = "";

            if (string.IsNullOrEmpty(Dato.Text.Trim()))
            {
                MessageBox.Show("Debe introducir un numero!");
                return;
            }

            Int64 n = Convert.ToInt64(Dato.Text.Trim());
            Caja.Text = "\n \n \n \t" + Utilidades.utilidades.ConvierteLetras(n);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] m = new int[5, 5];
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if (f % 2 == 0)
                        m[f, c] = f - c;
                    else
                        m[f, c] = (f + 1) * (f + 1);

                }
            }
            Caja.Text = Utilidades.utilidades.ImprimirMatriz(m);

            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if (c % 2 == 0)
                        m[f, c] = f - c;
                    else
                        m[f, c] = (f + c) * (f + c);
                }
            }
            Caja.Text += "\n" + Utilidades.utilidades.ImprimirMatriz(m);
        }

        private void LaSonido_Click(object sender, EventArgs e)
        {
            string letras = "";

            if (string.IsNullOrEmpty(Dato.Text.Trim()))
            {
                MessageBox.Show("Debe introducir un numero!");
                return;
            }

            Int64 n = Convert.ToInt64(Dato.Text.Trim());
            letras = Utilidades.utilidades.ConvierteLetras(n);

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            int[,] m = new int[5, 5];
            int cp = 0;
            Int64 resultadop3 = 0;

            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if (f == c)
                        m[f, c] = f;
                    else
                    {
                        if (f % 2 == 0)
                            m[f, c] = (f - c) - 2;
                        else
                            m[f, c] = (f + c) * (f + c);
                    }

                    if (Utilidades.utilidades.esPrimo(m[f, c]))
                        cp++;
                }
            }

            resultadop3 = (Int64)Math.Pow(cp, m[1, 4]);

            //Punto 1 
            Caja.Text = Utilidades.utilidades.ImprimirMatriz(m);
            //Punto 2
            Caja.Text += "Cantidad de primos: " + cp;
            //Punto 3
            Caja.Text += " \n \n Resultado del punto 3: " + resultadop3;
            //Punto 4
            Caja.Text += " \n \n Resultado puntos 3 traducido a letras: " + Utilidades.utilidades.ConvierteLetras(resultadop3);
            //Puntos 5
            Caja.Text += " \n \n Punto 5: Reproduciendo audio...";
            Utilidades.utilidades.TraducirAvoz(resultadop3);
            //Punto 6
            Caja.Text += " \n \n Punto 6: " + Utilidades.utilidades.Verificar2numeros(5, 17);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] m = new int[5, 5];

            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if (f + c == 4)
                        m[f, c] = f;
                    else
                    {
                        if (c % 2 == 0)
                            m[f, c] = (f - c) - 2;
                        else
                            m[f, c] = (f + c) * (f + c);


                    }
                }
            }

            Caja.Text = Utilidades.utilidades.ImprimirMatriz(m);
        }

        private void CrearArchivo_Click(object sender, EventArgs e)
        {
            Utilidades.utilidades.CreaArchivo(@"archivo.txt", Caja.Text.Trim());
        }

        private void LeerArchivo_Click(object sender, EventArgs e)
        {
            Caja.Text = Utilidades.utilidades.LeerArchivo(@"archivo.txt");
        }

        private void SQL_Click(object sender, EventArgs e)
        {
            DataGriw.DataSource = Utilidades.utilidades.ConectarSQL("SELECT * FROM Clientes").Tables[0];
        }

        private void Validar_Click(object sender, EventArgs e)
        {
            bool error = Utilidades.utilidades.ValidaForm(this, errorProvider1);
            if (error)
                MessageBox.Show("Hay errores");
            else
                MessageBox.Show("No hay errores");
        }

        private void FB_Click(object sender, EventArgs e)
        {
            FormBase obj = new FormBase();
            obj.Show();
        }
    }
}
