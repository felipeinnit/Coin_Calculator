using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      
      //user input
      Console.WriteLine("Enter the amount to the convertion: ");
     string totalCoinString = Console.ReadLine();
     double total = Convert.ToDouble(totalCoinString);

     Console.WriteLine($"{total} cents is equal to...");

     //
      int bronze = 1;
      int silver = 5;
      int gold = 10;

    //number of gold medals
     double howManyGold = Math.Floor(total/gold);
     double coinsLeftInGold = total % gold;
     Console.WriteLine(howManyGold);
     Console.WriteLine(coinsLeftInGold);
    
    //the number of silver coins
    double howManySilver = Math.Floor(coinsLeftInGold/silver);
    double coinsLeftInSilver = coinsLeftInGold % silver;

    //the number of bronze
    double howManyBronze = Math.Floor(coinsLeftInSilver/bronze);

    //result
    Console.WriteLine($"Gold Coins: {howManyGold}");
    Console.WriteLine($"Silver Coins: {howManySilver}");
    Console.WriteLine($"Bronze Coins: {howManyBronze}");

    Console.ReadKey();

    }
  }
}
