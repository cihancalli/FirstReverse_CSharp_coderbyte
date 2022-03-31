using System;

namespace FirstReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstReverse(Console.ReadLine()));
        }

        public static string FirstReverse(string str) {

            // code goes here  
            string answer = "";
            for(int i = str.Length-1; i>=0; i--){
            answer += str[i];
            }
            return answer;
        }
    }
}
