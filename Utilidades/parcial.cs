using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public abstract class Vehiculo
    {
        public abstract void TipodeVehiculo();
        public abstract void ColordeVehiculo();
    }

    class Vehiculo1 : Vehiculo
    {
        public override void TipodeVehiculo()
        {
            Console.WriteLine("Camion");

        }

        public override void ColordeVehiculo()
        {
            Console.WriteLine("Rojo");
        }
    }

    class Vehiculo2 : Vehiculo
    {
        public override void TipodeVehiculo()
        {
            Console.WriteLine("Jeep");

        }

        public override void ColordeVehiculo()
        {
            Console.WriteLine("Azul");
        }
    }

    class Vehiculo3 : Vehiculo
    {
        public override void TipodeVehiculo()
        {
            Console.WriteLine("Sedan");

        }

        public override void ColordeVehiculo()
        {
            Console.WriteLine("Negro");
        }
    }

    class PrincipalVehiculo
    {
        static void Main(string [] args)
        {

            ArrayList Dealer = new ArrayList(3);


            Vehiculo1 v1 = new Vehiculo1();
            Vehiculo2 v2 = new Vehiculo2();
            Vehiculo3 v3 = new Vehiculo3();

            Dealer.Add(v1);
            Dealer.Add(v2);
            Dealer.Add(v3);

            int i = 0;

            foreach(Vehiculo v in Dealer)
            {
                i++;
                Console.WriteLine("Vehiculo "+ i +": \n");
                Console.WriteLine("Tipo de vehiculo: ");
                v.TipodeVehiculo();
                Console.WriteLine("Color de vehiculo: ");
                v.ColordeVehiculo();
            }
        }
    }

    class SobrecargaM
    {
        public static void Main(string [] args)
        {
            Console.WriteLine(Suma(10, 10));
            Console.WriteLine(Suma(10, 10, 10));
            Console.WriteLine(Suma(10, 10, 10, 10));
        }

        public static int Suma(int n1, int n2)
        {
            int suma = n1 + n2;

            return suma;
        }

        public static int Suma(int n1, int n2, int n3)
        {
            int suma = n1 + n2 + n3;

            return suma;
        }

        public static int Suma(int n1, int n2, int n3, int n4)
        {
            int suma = n1 + n2 + n3 + n4;

            return suma;
        }
    }

    public interface Perro
    {
        void Ladrar();
        void Comer();
    }

    public class PerroAcciones : Perro
    {
        public void Ladrar()
        {
            Console.WriteLine("Ladrando");
        }

        public void Comer()
        {
            Console.WriteLine("Comiendo");
        }
    }

    public class PrincipalPerro 
    {
        static void Main(string [] args)
        {
            PerroAcciones pa = new PerroAcciones();

            pa.Comer();
            pa.Ladrar();
        }
    }
}
