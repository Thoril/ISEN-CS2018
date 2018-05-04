using System;

namespace Isen.Cs.Library.Lessons
{
      public class A_Types
      {
            public void PrimitiveTypes()
            {
                //short entiet 16 bit signé
                short s = 12;
                //short et System.Int16 sont synonymes 
                Int16 shortMin = Int16.MinValue;
                short shortMax = short.MaxValue;
                //Syntaxe $"...{variable} ..." string interpolation 
                Console.WriteLine($"short (Int16) range : {shortMin} < {s} < {shortMax} ");
                
                /*Liste des primitifs entiers (toujours préférer la version courte quand elle existe
                short/Int16
                ushort/UInt16
                int/Int32
                uint/uInt32
                long/Int64
                ulong/uInt64                
                */
                
                //Litéraux
                string myString = "Hello"; //Ceci est un litéral
                //Litéraux des entiers
                //Le under socre est autorisé sur les types numériques pour la lisibilité
                int veryMuch = 123_456_789;
                //Types numériques décimaux
                //par default, un litéral à virgule est un double 
                double dbl = 12.3;
                float flt = 12.3f;
                decimal dec = 12.3m;
                
                //Bits (bool), octets(Bytes)
                bool bTrue = true;
                Boolean bFalse = !bTrue;
                
                sbyte byteB = 0xB;
                SByte minusByteB = -0xB;
                
                //Byte non signé
                byte byteBB = 0xFF;
                Byte byteBB2 = 0b1111_1111;
                
                //char 
                char letterC = 'c';
                Console.WriteLine($"Le code ASCII de {letterC} est {(int)letterC}");
                int ascii80 = 80;
                Console.WriteLine($"Le code ASCII de {(char)ascii80} est {ascii80}");
                
                //object <=> Systel.Object
                string str2 = "Hello";
                object oStr2 = (object) str2;
                Console.WriteLine($"oStr2 = {oStr2}");
                Console.WriteLine($"oStr2 = {oStr2.GetType()}");
                
                //Cats
                int myInt = 42;
                string castIntToString= myInt.ToString();


            }
      }
}