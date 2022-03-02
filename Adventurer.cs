using System;

namespace Quest
{
  // An instance of the Adventurer class is an object that will undergo some challenges
  public class Adventurer
  {
    // This is an "immutable" property. It only has a "get".
    // The only place the Name can be set is in the Adventurer constructor
    // Note: the constructor is defined below.
    public string Name { get; }

    // This is a mutable property it has a "get" and a "set"
    //  So it can be read and changed by any code in the application
    public int Awesomeness { get; set; }

    //Robe property for our adventurer 
    public Robe ColorfulRobe { get; }

    //Read only Hat Property for our adventurer
    public Hat Hat { get; }

    public int challengesWon { get; set; }

    public Adventurer(string name, Robe robe, Hat hat)
    {
      Name = name;
      Awesomeness = 50;
      ColorfulRobe = robe;
      Hat = hat;
      challengesWon = 0;
    }

    //This is the description of our adventurer that gets wrote to the console after User puts their name in 
    public string GetDescription()
    {
      return $"Adventurer {Name} is wearing a {String.Join(", ", ColorfulRobe.Colors)} robe that is {ColorfulRobe.Length} inches long. Their hat is {Hat.ShininessDescription}. You have won {challengesWon} challenges.";
    }

    // This method returns a string that describes the Adventurer's status
    // Note one way to describe what this method does is:
    //   it transforms the Awesomeness integer into a status string
    public string GetAdventurerStatus()
    {
      string status = "okay";
      if (Awesomeness >= 75)
      {
        status = "great";
      }
      else if (Awesomeness < 25 && Awesomeness >= 10)
      {
        status = "not so good";
      }
      else if (Awesomeness < 10 && Awesomeness > 0)
      {
        status = "barely hanging on";
      }
      else if (Awesomeness <= 0)
      {
        status = "not gonna make it";
      }

      return $"Adventurer, {Name}, is {status}";
    }
  }
}