// using System;

// namespace Leetspeak
// {
//     public class LeetLetter
//     {
//         public string IsLeetLetter (string letter)
//         {
            
//             if ( letter == "e" || letter == "E")
//             {
//                 return "3";
//             }
//             else if (letter == "o" || letter =="O")
//             {
//                 return "0";   
//             }
//             else if (letter == "I")
//             {
//                 return "1";
//             }
//             else if (letter == "t" || letter == "T")
//             {
//                 return "7";
//             }
//             else if (letter == "s" || letter == "S")
//             {
                //  if (letter == str[0])
                //  {
                //      return letter;
                //  }
                //  else
                //  {
                     //return "z";
                 //}
                 
    //         }
    //         else
    //         {
    //             return letter;
    //         }

    //     }
    //     public string Replace ()
    // }
//      public class Program
//   {
//     public static void Main()
//     {
//       Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, "wonky");
//       Car yugo = new Car("1980 Yugo Koral", 700, 56000, "good");
//       Car ford = new Car("1988 Ford Country Squire", 1400, 239001, "poorly");
//       Car amc = new Car("1976 AMC Pacer", 400, 198000, "like a toyota");

//       List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

//       yugo.SetPrice(300);

//       Console.WriteLine("Enter maximum price: ");
//       string stringMaxPrice = Console.ReadLine();
//       int maxPrice = int.Parse(stringMaxPrice);

//       List<Car> CarsMatchingSearch = new List<Car>(0);

//       foreach (Car generic in Cars)
//       {
//         if (generic.WorthBuying(maxPrice))
//         {
//           CarsMatchingSearch.Add(generic);
//         }
//       }

//       foreach(Car generic in CarsMatchingSearch)
//       {
//         Console.WriteLine("----------------------");
//         Console.WriteLine(generic.GetMakeModel());
//         Console.WriteLine(generic.GetMiles() + " miles");
//         Console.WriteLine("$" + generic.GetPrice());
//         Console.WriteLine("Drives "+ generic.GetDrivesLike());
//         Console.WriteLine(Car.MakeSound("Bang"));
//       }
//     }
//   }

//}