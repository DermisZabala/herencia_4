using System;
using System.Security.Cryptography.X509Certificates;

namespace Herencia_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Humano hamel = new Humano("Hamel", 19);
            Gato misumisu = new Gato("Misu", 5);
            Perro chivi = new Perro("Chivi", 3);
            Caballo pasitos = new Caballo("Paso Largo", 9);

            Mamifero[] mamifero = new Mamifero[4];
            mamifero[0] = hamel;
            mamifero[1] = chivi;
            mamifero[2] = misumisu;
            mamifero[3] = pasitos;
            
            
            for(int i = 0; i<4; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Soy un humano");
                        hamel.GetNombre();
                        hamel.GetEdad();
                        mamifero[i].Pensar();
                        Console.WriteLine("\n");
                        break;
                    case 1:
                        Console.WriteLine("Soy un perro");
                        chivi.GetNombre();
                        chivi.GetEdad();
                        mamifero[i].Pensar();
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        Console.WriteLine("Soy un gato");
                        misumisu.GetNombre();
                        misumisu.GetEdad();
                        mamifero[i].Pensar();
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        Console.WriteLine("Soy un caballo");
                        pasitos.GetNombre();
                        pasitos.GetEdad();
                        mamifero[i].Pensar();
                        Console.WriteLine("\n");
                        break;
                }
            }
        }
    }
    class Mamifero
    {
        private int edad;
        private string nombre;

        public Mamifero(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public void GetNombre()
        {
            Console.WriteLine("Mi nombre es " + nombre);
        }
        public void GetEdad()
        {
            Console.WriteLine("Tengo " + edad + " años de edad");
        }
        public virtual void Pensar()
        {
            Console.WriteLine("Tengo una capacidad de pensamiento basico");
        }
    }
    class Humano : Mamifero
    {
        public Humano(string nombre, int edad) :base(nombre, edad)
        {

        }
        public override void Pensar()
        {
            Console.WriteLine("Pienso de manera compleja.");
        }
    }
    class Gato : Mamifero
    {
        public Gato(string nombre, int edad) :base(nombre, edad)
        {
            
        }
        public override void Pensar()
        {
            Console.WriteLine("Exhibo adaptabilidad y aprendizaje a través de la experiencia.");
        }
    }
    class Perro : Mamifero
    {
        public Perro(string nombre, int edad) :base(nombre, edad)
        {
            
        }
        public override void Pensar()
        {
            Console.WriteLine("Muestro inteligencia aprendida y comunicación con humanos.");
        }

    }
    class Caballo : Mamifero
    {
        public Caballo(string nombre, int edad) :base(nombre, edad)
        {

        }
    }
}
