using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasSong_Alex
{
    //on the {number} day of christmas my true love gave to me; add each phrase on after

    class Lyrics
    {
        public int number = 1;

        public Lyrics()
        {
            opening();
            Console.ReadKey();
        }

        public void opening()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Welcome to the application, \nwould you like to play The 12 Days of Christmas? \n(y) yes \n(n) no");

            string input = Console.ReadLine();

            if (input == "y")
            {
                Loop();
            }
            else if (input == "n")
            {
                Environment.Exit(0);
            }
        }

        public void Loop()
        {
            string[] verse = new string[13];

            verse[0] = "and a partridge in a pear tree";
            verse[1] = "A partridge in a pear tree";
            verse[2] = "Two turtle doves,";
            verse[3] = "Three French hens,";
            verse[4] = "Four calling birds,";
            verse[5] = "Five gold rings,";
            verse[6] = "Six geese a laying,";
            verse[7] = "Seven swans a swimming,";
            verse[8] = "Eight maids a milking,";
            verse[9] = "Nine ladies dancing,";
            verse[10] = "Ten lords a leaping,";
            verse[11] = "Eleven pipers piping,";
            verse[12] = "Twelve drummers drumming,";

            for (int i = 1; i < verse.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nOn the " + number + " day of Christmas my true love gave to me");
                Console.WriteLine(verse[i]);
                if (i > 12)
                {
                    Console.WriteLine(verse[12]);
                }
                if (i > 11)
                {
                    Console.WriteLine(verse[11]);
                }
                if (i > 10)
                {
                    Console.WriteLine(verse[10]);
                }
                if (i > 9)
                {
                    Console.WriteLine(verse[9]);
                }
                if (i > 8)
                {
                    Console.WriteLine(verse[8]);
                }
                if (i > 7)
                {
                    Console.WriteLine(verse[7]);
                }
                if (i > 6)
                {
                    Console.WriteLine(verse[6]);
                }
                if (i > 5)
                {
                    Console.WriteLine(verse[5]);
                }
                if (i > 4)
                {
                    Console.WriteLine(verse[4]);
                }
                if (i > 3)
                {
                    Console.WriteLine(verse[3]);
                }
                if (i > 2)
                {
                    Console.WriteLine(verse[2]);
                }
                if (i > 1)
                {
                    Console.WriteLine(verse[0]);
                }
                Console.ReadKey();
                number++;
            }
        }
    }
}
