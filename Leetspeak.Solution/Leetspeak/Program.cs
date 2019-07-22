using System;
using System.Collections.Generic;
using Leetspeak.Models;

namespace Leetspeak.Models {

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a word to be converted to Leet");
            string inputString = (" "+Console.ReadLine());
            // var chars = inputString.ToCharArray();
            // Console.WriteLine("inputString: {0}", inputString);
            // Console.WriteLine("Character array: ");
            // for (int ctr = 0; ctr < chars.Length; ctr++)
            //String leetString = new String(inputString);
            string leetString = inputString.Replace("e", "3").Replace("E", "3").Replace("o", "0").Replace("O", "0").Replace("I", "1").Replace("t", "7").Replace("T", "7").Replace("s", "z").Replace("S", "Z").Replace(" Z", " S").Replace(" z", " s");
            Console.WriteLine(leetString);

        }
    }
}