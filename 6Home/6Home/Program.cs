using System;

class Program

{
    static void Main()

    {

        string sentence = "Це приклад речення яке складається з десяти різних слів клас";



        string[] words = sentence.Split(' ');



        if (words.Length == 10)

        {
            string[] wordArray = new string[10];
            for (int i = 0; i < words.Length; i++)
            {

                wordArray[i] = words[i];

            }



            for (int i = 0; i < wordArray.Length; i++)
            {
                Console.WriteLine(wordArray[i]);

            }

        }
        /*TEST*/
        
        else
        {

            Console.WriteLine("Речення не містить рівно 10 слів.");
            Console.WriteLine("Речення не містить рівно 10 слів.");
         
        }

    }

}