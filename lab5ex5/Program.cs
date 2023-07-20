using System;

namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*Program care va normaliza un sir de caractere citit de la tastatura astfel incat fiecare cuvant din sir sa inceapa cu MAJUSCULA, restul literelor fiind transformate in litere mici.*/


            Console.WriteLine("Introduceti sirul de caractere: ");
            string sirCaractere = Console.ReadLine();
        
            Console.WriteLine(MajusculeCuvinte(sirCaractere));
        }


        static string MajusculeCuvinte(string text)
        {
                
                text = text.ToLower();
                char[] matriceCaractere = text.ToCharArray();
              
                if (matriceCaractere.Length >= 1)
                {
                    if (char.IsLower(matriceCaractere[0]))
                    {
                        matriceCaractere[0] = char.ToUpper(matriceCaractere[0]);
                    }
                }
                

                for (int i = 1; i < matriceCaractere.Length; i++)
                {
                    if (matriceCaractere[i - 1] == ' ')
                    {
                        if (char.IsLower(matriceCaractere[i]))
                        {
                        matriceCaractere[i] = char.ToUpper(matriceCaractere[i]);
                        }
                    }
                }
                return new string(matriceCaractere);
            }
        }
    }
    


    
 

 
