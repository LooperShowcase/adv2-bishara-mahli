using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bishara_mahli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Welcome to my game" );
            char[] lines = { '_', '_', '_', '_' };
            for(int i = 0; i < lines.Length; i++)
            {
                Console.Write(lines[i]+" ");    
            }
            string tw = getTodayword();
            int heart = getTodayword().Length;
            while (heart >0)
            {
              char c  = askUser();
                int result = checkletter (tw, c, lines);
                if(result == -1)
                {
                    heart--;
                    Console.WriteLine("you have " + heart + "  hearts left");
                    if(heart == 0)
                    {
                        Console.WriteLine("you lost");
                    }

                }
                
               
               
            }

           
        }
        public static  char askUser()
        {
            Console.WriteLine("pleas enter a char");
            char c = Console.ReadLine()[0];
            return c;

        }
       public static  string getTodayword()
       {
            string[] myname = { "play", "raja", "easy", "lose","door","kick" };
            Random rnd = new Random();
            int number = rnd.Next(myname.Length);
            return myname[number];
        }

        public static int checkletter(string todayWord , char ch , char[] list)
        {
            for (int i = 0; i < todayWord.Length; i++)
            {
                if (todayWord[i] == ch && list[i] != ch)
                {
                    return i;
                    
                }    
            }
            return -1;
        }




    }
}
