using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetspeak;

namespace Leetspeak.Tests
{
    [TestClass]
    public class LeetLetterTest
    {
            
        [TestMethod]
        public void IsLeetLetter_eIsChangedTo3_True()
        {
            LeetLetter testLeetLetter = new LeetLetter();
            Assert.AreEqual("3", testLeetLetter.IsLeetLetter("E"));
        }
        
    }
}
//     class Car
//   {
//     private string _makeModel;
//     private int _price;
//     private int _miles;
//     private string _drivesLike;

//     public Car(string makeModel, int price, int miles, string drivesLike)
//     {
//       _makeModel = makeModel;
//       _price = price;
//       _miles = miles;
//       _drivesLike = drivesLike;
//     }

//     public string GetMakeModel()
//     {
//         return _makeModel;
//     }

//     public int GetPrice()
//     {
//       return _price;
//     }

//     public int GetMiles()
//     {
//       return _miles;
//     }
//     public string GetDrivesLike()
//     {
//       return _drivesLike;
//     }
//     public bool WorthBuying(int maxPrice)
//     {
//       return (_price < maxPrice);
//     }
//      public void SetPrice(int newPrice)
//     {
//       _price = newPrice;
//     }
//     public static string MakeSound (string sound)
//     {
//       return "Our cars sound like " + sound;
//     }
//   }
