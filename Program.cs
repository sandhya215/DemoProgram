using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "Apassword";
            if(password.Length<8||password.Length>10)
            {
                Console.WriteLine("Password should be in minimum 8 to max 10");
            }
            else
            {
                Console.WriteLine("Your password is valid");
            }
            //First char is A
            if(password[0]=='p')
            {
                Console.WriteLine("Your password ik valid");
            }
            else
            {
                Console.WriteLine("Enter password starting with A");
            }
            //compare
            string str1 = "Training for ";
            string str2 = "C#";
            int rescompare = string.Compare(str2, str1);
            Console.WriteLine("Compared string are equal if result is 0 " + rescompare);
             string concatRes = string.Concat(str1, str2, " this ", "is good", " string ", "concat ", "is Awesome");
            Console.WriteLine("Concat results: " + concatRes);
            //Contains
            string name=("Dream big to live big");
            bool res = name.Contains("to");
            Console.WriteLine("Final String1=" + res);
            bool endstring = name.EndsWith("big");
            Console.WriteLine("Final String2=" + endstring);
            int indexof = name.IndexOf('l', 10);
            Console.WriteLine("Final String3=" + indexof);
            //Replace
            string replaced =name.Replace("live", "Fly");
            Console.WriteLine("replace results: " + replaced);
           //substring
            string subString = name.Substring(6, 3);
            Console.WriteLine("substring results: " + subString);
            //To lower
            string UpperString = "THIS IS CSHARP";
            string lowerString = UpperString.ToLower();
            Console.WriteLine("Lower string results: " + lowerString);
            Console.WriteLine("back to Upper string results: " + lowerString.ToUpper());
           
            //Trim 
            string charStr = "back to Upper string results";
            Console.WriteLine("Trimed string results: " + charStr.Trim());
        GetInputAgain:
            var userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Enter a valid input");
                goto GetInputAgain;
            }
            StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append("This is Testing SB");
            //stringBuilder.Append(" Good compare to Stirng");
            stringBuilder.Insert(0, "This is from the Next line");
            stringBuilder.Insert(1, "Electric");
            stringBuilder.Insert(2, "Furniture");
            stringBuilder.Insert(3, "Trending");
            Console.WriteLine(stringBuilder);
            Console.ReadLine();
        }
    }
}
