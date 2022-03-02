using System;

//same namespace as everything else
namespace Quest
{
  //this is the beginning to our prize class 
  public class Prize
  {
    //private field to hold a description of our prize
    private string _text;

    //made a constructor
    public Prize(string text)
    {
      _text = text;
    }

    public void ShowPrize(Adventurer adventurer)
    {
      if (adventurer.Awesomeness > 0)
      {
        Console.WriteLine(_text);
      }
      else if (adventurer.Awesomeness <= 0)
      {
        Console.WriteLine("Your adventure was not very cash money.");
      }
    }

  }
}