using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Familia integrante = new Familia();

            integrante.setNombre("Franco");
            Console.WriteLine(integrante.getNombre());

            Console.WriteLine("Sus funciones son: ");
            integrante.Respirar();
            integrante.Comer();

            Console.WriteLine("");

            Perro firulais = new Perro("Doki", "Dokito");

            firulais.SetInfoPerro("Doki", "Dokito");
            Console.WriteLine(firulais.getInfoPerro());

            Console.WriteLine("Sus funciones son: ");
            firulais.Respirar();
            firulais.Comer();
            firulais.Ladrar();

            Console.WriteLine("");

            Gato michi = new Gato("Tom");

            michi.setNombreGato("Tom");
            Console.WriteLine(michi.getNombreGato());

            Console.WriteLine("Sus funciones son: ");
            michi.Respirar();
            michi.Comer();
            michi.Maullar();

            Console.WriteLine("");

            Humano persona = new Humano("Manolo");

            persona.setNombreHumano("Gonzalo");
            Console.WriteLine(persona.getNombreHumano());

            Console.WriteLine("Sus funciones son: ");
            persona.Respirar();
            persona.Comer();
            persona.Hablar();
        }
    }

    class Familia
    {
        private string nombreIntegrante;

        public Familia() // Constructor por defecto
        {
            this.nombreIntegrante = "Manolito";
        }
                                                        // Constructor sobrecargado porque hay dos con el mismo nombre
        public Familia(string nombreOtorgado) // Constructor por parametro
        {
            nombreIntegrante = nombreOtorgado;
        }

        public string getNombre()
        {
            return "El nombre del integrante de la familia es " + nombreIntegrante;
        }

        public void setNombre(string nombreIntegrante)
        {
            this.nombreIntegrante = nombreIntegrante;
        }

        public void Respirar()
        {
            Console.WriteLine("Respiro");
        }

        public void Comer()
        {
            Console.WriteLine("Como");
        }
    }

    class Perro
    {
        private string nombrePerro;
        private string apodoPerro;

        public Perro(string nombrePerro, string apodoPerro)
        {
            this.nombrePerro = nombrePerro;
            this.apodoPerro = apodoPerro;
        }

        public string getInfoPerro()
        {
            return "El nombre del perro es " + nombrePerro + " y su apodo es " + apodoPerro;
        }

        public void SetInfoPerro(string nombre, string apodo)
        {
            nombrePerro = nombre;
            apodoPerro = apodo;
        }

        public void Respirar()
        {
            Console.WriteLine("Respiro");
        }

        public void Comer()
        {
            Console.WriteLine("Como");
        }

        public void Ladrar()
        {
            Console.WriteLine("Ladro");
        }
    }

    class Gato
    {
        private string nombreGato;

        public Gato(string nombreGato)
        {
            this.nombreGato = nombreGato;
        }

        public string getNombreGato()
        {
            return "El nombre del gato es " + nombreGato;
        }

        public void setNombreGato(string nombreGato)
        {
            this.nombreGato = nombreGato;
        }

        public void Respirar()
        {
            Console.WriteLine("Respiro");
        }

        public void Comer()
        {
            Console.WriteLine("Como");
        }

        public void Maullar()
        {
            Console.WriteLine("Maullo");
        }
    }

    class Humano
    {
        private string nombreHumano;

        public Humano (string nombreHumano)
        {
            this.nombreHumano = nombreHumano;
        }

        public string getNombreHumano()
        {
            return "El nombre del humano es " + nombreHumano;
        }

        public void setNombreHumano(string nombreHumano)
        {
            this.nombreHumano = nombreHumano;
        }

        public void Respirar()
        {
            Console.WriteLine("Respiro");
        }

        public void Comer()
        {
            Console.WriteLine("Como");
        }

        public void Hablar()
        {
            Console.WriteLine("Hablo");
        }
    }
}
