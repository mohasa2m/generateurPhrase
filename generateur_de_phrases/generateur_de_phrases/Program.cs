using System;

namespace generateur_de_phrases
{
    internal class Program
    {
        static string ObtenirElementAleatoire(string[] t)
        {
            Random r = new Random();
            int i = r.Next(t.Length);
            return t[i];
            

        }
        static void Main(string[] args)
        {
            var sujets = new string[] { 
                "Un lapin", 
                "Une grand-mère",
                "Un chat",
                "Un bonhomme de neige",
                "Une limace",
                "Une fee",
                "Un magicien",
                "Une tortue",
            };

            var verbes = new string[] {
                "mange",
                "écrase",
                "détruit",
                "observe",
                "attrape",
                "regarde",
                "avale",
                "nétoie",
                "se bat avec",
                "s'accoche à", 
            };

            var complements = new string[]
            {
                "un arbre",
                "un livre",
                "la lune",
                "le soleil",
                "un serpent",
                "une carte",
                "une girafe",
                "le ciel",
                "une piscine",
                "un gateau",
                "une souris",
                "un crapaud",
            };

            const int NB_PHRASES= 100;
            var phrasesUniques = new List<string>();
            int doublonEvites = 0;

            while (phrasesUniques.Count < NB_PHRASES)
            {
                var sujet = ObtenirElementAleatoire(sujets);
                var verbe = ObtenirElementAleatoire(verbes);
                var complement = ObtenirElementAleatoire(complements);
                var phrase = sujet + " " + verbe + " " + complement;
                phrase = phrase.Replace("à le", "au");

                if (!phrasesUniques.Contains(phrase))
                {
                    phrasesUniques.Add(phrase);

                }
                else
                {
                    doublonEvites++;
                }
            }

            foreach(var phrase in phrasesUniques)
            {
             Console.WriteLine(phrase);
            }

            Console.WriteLine();
            Console.WriteLine("Nombre de phrases uniques: " + phrasesUniques.Count);
            Console.WriteLine("Nombre de doublons evités: " + doublonEvites);
        }
    }
}