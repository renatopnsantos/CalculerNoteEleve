using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculerNoteEleve

{
    public class eleve : personne
    {
        public static void Main(string[] args)
        {

            personne p = new personne();
            note n = new note();

            Console.WriteLine("******** Contrôle de notes des elèves ********");

            Console.WriteLine("Digite o código do aluno");
            p.id_personne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tapez le prénom d'elève: ");
            p.prenon = Console.ReadLine().ToUpper();

            Console.WriteLine("Tapez le nom de famille d'elève: ");
            p.nom_famille = Console.ReadLine().ToUpper();


            Console.WriteLine("Tapez la première note d'elève: ");
            n.n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tapez la deuxième note d'elève: ");
            n.n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tapez la troisième note d'elève: ");
            n.n3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tapez la quatrième note d'elève: ");
            n.n4 = Convert.ToInt32(Console.ReadLine());


            n.note_fin = Convert.ToInt32(n.n1 + n.n2 + n.n3 + n.n4) / 4;

            Console.WriteLine($"Bonjour {p.prenon} {p.nom_famille} ta note final est {n.note_fin}");


            Console.ReadKey();


        }
    }
}
