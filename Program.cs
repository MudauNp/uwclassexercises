using System.Diagnostics.Metrics;

namespace FirstClassExercise
{
    internal class Program
    {
         public static string ReversedString(string forwardText)
         {
            string returnString = "";

            for (int index = forwardText.Length - 1; index >=0; index--)
            {
                returnString += forwardText[index];
            }
              return returnString;
            

         }
        static void Main(string[] args)
            {
               string input = Console.ReadLine();
               string output = ReversedString(input);

            if (input == output)
                Console.WriteLine("True");
            else Console.WriteLine("false");
        }

         

       
            
        
    }
}