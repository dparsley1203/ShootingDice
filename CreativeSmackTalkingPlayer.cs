using System;
using System.Collections.Generic; 

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public List<string> Taunt = new List<string>()
        {
            "Aint them a Peach",
            "Snake Eyes!",
            "You look like a horse!!"
        };

          public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            Console.WriteLine($"{Name} says, {Taunt[new Random().Next(0, Taunt.Count)]}"); //Testing the insult input
            return new Random().Next(DiceSize) + 1;
        }
    }
}