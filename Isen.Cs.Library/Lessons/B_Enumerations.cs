using System;

namespace Isen.Cs.Library.Lessons
{
    public class B_Enumerations
    {
        public void RunEnumerations()
        {    
            //Affichage du label 
            Console.WriteLine($"JourSemaine.Lundi = {JourSemaine.Lundi}");
            //Afficher l'entier sous-jetant 
            Console.WriteLine($"JourSemaine.Lundi = {(int)JourSemaine.Lundi}");
            //int > vers valeur d'enum
            int day4 = 4;
            JourSemaine whoIsday4 = (JourSemaine) day4;
            Console.WriteLine($"day4 = {whoIsday4}");
            string mardi = "Mardi";
            JourSemaine parsed = (JourSemaine) Enum.Parse(typeof(JourSemaine),mardi);
            Console.WriteLine($"parsed = {parsed}");
            JourSemaine parsed2;
            //out a la meme fonction que le & en C (pointeur)
            bool ditItWork = Enum.TryParse("Mercredi", out parsed2);
            Console.WriteLine($"parsed2 = {parsed2} / worked ? {ditItWork}");
            //Enumérer les labels
            var enumNames = Enum.GetNames(typeof(JourSemaine));
            foreach (var enumName in enumNames)
            {
                Console.WriteLine(enumName);
            }

            var day = (JourSemaine) new Random().Next(1, 7);
            DayOfWeek dayOfWeek;
            switch (day)
            {
                case JourSemaine.Lundi :
                     dayOfWeek = DayOfWeek.Monday;
                    break;
                case JourSemaine.Mardi :
                    dayOfWeek = DayOfWeek.Tuesday;
                    break;
                case JourSemaine.Mercredi :
                    dayOfWeek = DayOfWeek.Wednesday;
                    break;
                case JourSemaine.Jeudi :
                    dayOfWeek = DayOfWeek.Thursday;
                    break;
                case JourSemaine.Vendredi :
                    dayOfWeek = DayOfWeek.Friday;
                    break;
                case JourSemaine.Samedi :
                    dayOfWeek = DayOfWeek.Saturday;
                    break;
                default :
                    dayOfWeek = DayOfWeek.Sunday;
                    break;
            }
            Console.WriteLine($" {nameof(dayOfWeek)} = {dayOfWeek}");

        }
        
        public enum JourSemaine
        {
            Lundi = 1,
            Mardi = 2,
            Mercredi = 3,
            Jeudi = 4,
            Vendredi = 5,
            Samedi = 6,
            Dimanche = 7
        }

        public enum Result
        {
            succes , echec
        }
    }
}