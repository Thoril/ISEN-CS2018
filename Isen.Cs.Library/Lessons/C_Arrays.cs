using System;

namespace Isen.Cs.Library.Lessons
{
    public class C_Arrays
    {
        public static void StaticRunner()
        {
            new C_Arrays().RunArrays();
        }

        public void RunArrays()
        {
            int [] arrayOfInt = new int[3];
            arrayOfInt[0] = 22;
            arrayOfInt[0] = 23;
            arrayOfInt[0] = 24;
            Console.Write("[");
            foreach (var integer in (arrayOfInt))
            {
                Console.Write($"{integer}\t");  
            }
            Console.WriteLine("]");
            
            string [] literalArray =  { "Bonjour", "Aurevoir" ,"Bonne nuit","Coucou"};
            Console.Write("[");
            foreach (var str in (literalArray))
            {
                Console.Write($"{str} / ");
            }
            Console.WriteLine("]");
            
            //Tableau à 2 dimensions
            string [,] array2D = 
            {
                {"A1","B1","C1"},
                {"A2","B2","C2"},
                {"A3","B3","C3"},
            };
            for (var x = 0; x < array2D.GetLength(0); x++)
            {
                for (int i = 0; i < array2D.GetLength(1); i++)
                {
                    Console.Write($"{array2D[x,i]}|");
                }
                Console.WriteLine();
            }
            
            //Tableau imbriqués
            string[][] nestedArrays = 
            {
                new string[] {"A1","B1","C1"}, 
                new string[] {"A2","B2"}, 
                new string[] {"A3","B3","C3"}
            };
            
            for (var x = 0; x < nestedArrays.Length; x++)
            {
                for (int i = 0; i < nestedArrays[x].Length; i++)
                {
                    Console.Write($"{nestedArrays[x][i]}|");
                }
                Console.WriteLine();
            }
        }

        #region Values and Refs

        private void RunValuesAndRefs()
        {
            //Types Valeurs  et Types référence 
            int four = 4;
            Console.WriteLine($"{nameof(four)} = {four}");
            four = AddOneAsPureMethod(four);
            Console.WriteLine($"{nameof(four)} = {four}");
            AddOneByRef(ref four);
            Console.WriteLine($"{nameof(four)} = {four}");

            TryParseInt("42", out int parsed);
            Console.WriteLine($"parsed = {parsed}");
            
            //String passage par valeur ou ref ? réponse par valeur
            var lowerString = "hello";
            Console.WriteLine($"hello : {lowerString.ToUpper()}");
        }

        public void AddOne(int a)
        {
            a++; //scope uniquement dans la methode 
        }
        
        public int  AddOneAsPureMethod(int a)
        {
            return ++a;
        }

        public void AddOneByRef(ref int a)
        {
            a++;
        }

        public bool TryParseInt(string input, out int result)
        {
            try
            {
                result = int.Parse(input);
                return true;
            }
            catch 
            {
                result = int.MinValue;
                return false;
            }
        }
        #endregion
        
    }
}