using System;

namespace Basic
{
  public class Menu
  {
    public void Run()
    {
      char option = '\0';
      do
      {
        Console.Clear();
        if (option != '\0')
        {
          Console.WriteLine("Incorrect operation");
        }
        else
        {
          Console.WriteLine();
        }
        option = ShowMenu();

      } while (option < '1' || option > '2');

      RunProgram(option);
      Console.WriteLine("\n\nThanks for use this software :)");
    }

    private char ShowMenu()
    {
      Console.WriteLine("          MENU\n");
      Console.WriteLine("1.- Read Name");
      Console.WriteLine("2.- Sum A + B");
      Console.Write("\nChoose options : ");
      var option = Console.ReadKey();

      return option.KeyChar;
    }

    private void RunProgram(char option)
    {
      switch (option)
      {
        case '1':
          ReadName();
          break;
        case '2':
          SumNumbers();
          break;
        default:
          break;
      }
    }

    private void SumNumbers()
    {
      PrintTitleProgram("Sum Number ( A + B)");
      Console.Write("Enter First Number(A): ");
      string aString = Console.ReadLine();
      Console.Write("\nEnter Second Number(B): ");
      string bString = Console.ReadLine();
      int A = Int32.Parse(aString);
      int B = Int32.Parse(bString);
      Console.WriteLine($"\nThe sum is: {A + B}");
    }

    private void ReadName()
    {
      PrintTitleProgram("Read Name");
      Console.Write("Enter Your Name: ");
      String name = Console.ReadLine();
      Console.WriteLine($"Hi, {name}");
    }

    private void PrintTitleProgram(string name)
    {
      Console.WriteLine($"\n\n ---- ${name} ----");
    }
  }
}

