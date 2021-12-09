using System;
using ScrabbleScore.Models;


public class Program
{

  public static void Main()
  {
    Console.WriteLine("Welcome to your Scrabble Score Keeper!");
    Console.WriteLine("Enter the word you want to score:");
    string word = Console.ReadLine();
    Console.WriteLine("Your score is " + Score.CalculateScore(word).ToString());
  }
}

