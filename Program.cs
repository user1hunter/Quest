using System;
using System.Collections.Generic;

// Every class in the program is defined within the "Quest" namespace
// Classes within the same namespace refer to one another without a "using" statement
namespace Quest
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create a few challenges for our Adventurer's quest
      // The "Challenge" Constructor takes three arguments
      //   the text of the challenge
      //   a correct answer
      //   a number of awesome points to gain or lose depending on the success of the challenge
      Challenge twoPlusTwo = new Challenge("2 + 2?", 4, 10);
      Challenge theAnswer = new Challenge(
          "What's the answer to life, the universe and everything?", 42, 25);
      Challenge whatSecond = new Challenge(
          "What is the current second?", DateTime.Now.Second, 50);

      int randomNumber = new Random().Next() % 10;
      Challenge guessRandom = new Challenge("What number am I thinking of?", randomNumber, 25);

      Challenge favoriteBeatle = new Challenge(
          @"Who's your favorite Beatle?
    1) John
    2) Paul
    3) George
    4) Ringo
",
          4, 20
      );

      // "Awesomeness" is like our Adventurer's current "score"
      // A higher Awesomeness is better

      // Here we set some reasonable min and max values.
      //  If an Adventurer has an Awesomeness greater than the max, they are truly awesome
      //  If an Adventurer has an Awesomeness less than the min, they are terrible
      int minAwesomeness = 0;
      int maxAwesomeness = 100;

      //Asks User for their name
      Console.WriteLine("Please enter your name, Adventurer.");
      string name = Console.ReadLine();

      //This adds the colors and the length to the robe for our adventurer
      Robe adventurersRobe = new Robe
      {
        Colors = new List<string>
          {
              "red",
              "blue",
              "white",
              "green",
              "pink",
              "purple",
              "orange",
              "black"
          },
        Length = 35
      };

      //This is adds the shininess level and the description is added through an if statemtnt in Hats.cs
      Hat adventurersHat = new Hat
      {
        ShininessLevel = 6
      };

      //instance of the prize 
      Prize showPrize = new Prize("A Potatoe Medal!!!");

      // Make a new "Adventurer" object using the "Adventurer" class and passing in the name, robe, and hat
      Adventurer theAdventurer = new Adventurer(name, adventurersRobe, adventurersHat);

      //Writing the secription of our adventurer to the console 
      Console.WriteLine(theAdventurer.GetDescription());

      // A list of challenges for the Adventurer to complete
      // Note we can use the List class here because have the line "using System.Collections.Generic;" at the top of the file.
      List<Challenge> challenges = new List<Challenge>()
            {
                twoPlusTwo,
                theAnswer,
                whatSecond,
                guessRandom,
                favoriteBeatle
            };

      //flag for whether the game will run again 
      bool gameActive = true;

      //loop for repeating the game if the user chooses to at the end
      while (gameActive == true)
      {
        // Loop through all the challenges and subject the Adventurer to them
        foreach (Challenge challenge in challenges)
        {
          challenge.RunChallenge(theAdventurer);
        }

        // This code examines how Awesome the Adventurer is after completing the challenges
        // And praises or humiliates them accordingly
        if (theAdventurer.Awesomeness >= maxAwesomeness)
        {
          Console.WriteLine("YOU DID IT! You are truly awesome!");
        }
        else if (theAdventurer.Awesomeness <= minAwesomeness)
        {
          Console.WriteLine("Get out of my sight. Your lack of awesomeness offends me!");
        }
        else
        {
          Console.WriteLine("I guess you did...ok? ...sorta. Still, you should get out of my sight.");
        }

        //This is the call for the showPrize method
        showPrize.ShowPrize(theAdventurer);

        //this is the question to determine whether the user would like to quest again 
        Console.WriteLine("Would you like to play again? Y or N.");
        string repeatGame = Console.ReadLine();

        //this is the statement that determines whether the flag is set to run through the game or not
        if (repeatGame != "Y")
        {
          gameActive = false;
        }
      }
    }
  }
}