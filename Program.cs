using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAnimais
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Animal();
            Animal a3 = new Animal();
            Animal a4 = new Animal();
            Animal a5 = new Animal();
            int tlCachorro = 0, tlGato = 0, tlPeixe = 0;

            Console.WriteLine("Controle de animais");

            //primeiro animal
            Console.WriteLine("Informe o nome do 1º anial: ");
            a1.Nome = Console.ReadLine();
            Console.WriteLine("Informe o tipo do 1º animal (Cachorro, Gato ou Peixe): ");
            a1.Tipo = Console.ReadLine();

            if (a1.Tipo == "Cachorro") tlCachorro++;
            if (a1.Tipo == "Gato") tlGato++;
            if (a1.Tipo == "Peixe") tlPeixe++;

            //segundo animal
            Console.WriteLine("Informe o nome do 2º anial: ");
            a2.Nome = Console.ReadLine();
            Console.WriteLine("Informe o tipo do 2º animal (Cachorro, Gato ou Peixe): ");
            a2.Tipo = Console.ReadLine();

            if (a2.Tipo == "Cachorro") tlCachorro++;
            if (a2.Tipo == "Gato") tlGato++;
            if (a2.Tipo == "Peixe") tlPeixe++;

            //terceiro animal
            Console.WriteLine("Informe o nome do 3º anial: ");
            a3.Nome = Console.ReadLine();
            Console.WriteLine("Informe o tipo do 3º animal (Cachorro, Gato ou Peixe): ");
            a3.Tipo = Console.ReadLine();

            if (a3.Tipo == "Cachorro") tlCachorro++;
            if (a3.Tipo == "Gato") tlGato++;
            if (a3.Tipo == "Peixe") tlPeixe++;

            //quarto animal
            Console.WriteLine("Informe o nome do 4º anial: ");
            a4.Nome = Console.ReadLine();
            Console.WriteLine("Informe o tipo do 4º animal (Cachorro, Gato ou Peixe): ");
            a4.Tipo = Console.ReadLine();

            if (a4.Tipo == "Cachorro") tlCachorro++;
            if (a4.Tipo == "Gato") tlGato++;
            if (a4.Tipo == "Peixe") tlPeixe++;

            //quinto animal
            Console.WriteLine("Informe o nome do 5º anial: ");
            a5.Nome = Console.ReadLine();
            Console.WriteLine("Informe o tipo do 5º animal (Cachorro, Gato ou Peixe): ");
            a5.Tipo = Console.ReadLine();

            if (a5.Tipo == "Cachorro") tlCachorro++;
            if (a5.Tipo == "Gato") tlGato++;
            if (a5.Tipo == "Peixe") tlPeixe++;

            //resultado
            Console.WriteLine("Total de animais");
            Console.WriteLine("Cachorros: " + tlCachorro + " \nGatos: " + tlGato + " \nPeixes " + tlPeixe);
            Console.ReadKey();
        }
    }
}
