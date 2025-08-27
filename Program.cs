using System.Diagnostics.CodeAnalysis;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using Microsoft.Data.SqlClient;
using TODOList.Model;
using TODOList.Repo;

namespace TODOList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Environment.SetEnvironmentVariable("env", "release");
            bool sortie = false;
            int arg;

            RepTODOListe Action = new RepTODOListe();
            try
            {
                while (!sortie)
                {
                    Console.WriteLine("choisir action;");
                    Console.WriteLine("1: Afficher tache");
                    Console.WriteLine("2: Ajouter tache");
                    Console.WriteLine("3: Supprimer tache");
                    Console.WriteLine("4: cloturer tache");
                    Console.WriteLine("5: fermer");

                    arg = int.Parse(Console.ReadLine());
                    switch (arg)
                    {
                        case 1:
                            List<TFiche> list = Action.GetListe();

                            Console.WriteLine("==========================");
                            foreach (TFiche item in list)
                            {
                                string output = "";
                                output = output + string.Format("{0}. {1} : {2} : {3}", item.id.ToString(), item.nomFiche, item.dateCrea.ToString(), item.descr);
                                Console.WriteLine(output);
                            }
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("entrez le nom de la tache");
                            string nom = Console.ReadLine();
                            Console.WriteLine("entrez une description");
                            string desc = Console.ReadLine();

                            Action.AddListe(nom, desc);
                            break;
                        case 3:
                            Console.WriteLine("entrez un id");
                            int id = int.Parse(Console.ReadLine());

                            Action.DelListe(id);
                            break;
                        case 4:
                            Console.WriteLine("TODO");
                            break;
                        case 5:
                            sortie = true;
                            break;
                        default:
                            Console.WriteLine("Incorecte");
                            break;
                    }
                }
            }
            finally
            {

            }
        }
    }
}
