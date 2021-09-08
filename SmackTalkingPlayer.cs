using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; }

        public SmackTalkingPlayer(string taunt)
        {
            Taunt = taunt;
        }

        public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            Console.WriteLine($"{Name} says, {Taunt}"); //Testing the insult input
            return new Random().Next(DiceSize) + 1;
        }

    //     public override void Play(Player other)

    //    {    int myRoll = Roll();
    //         int otherRoll = other.Roll();

    //         Console.WriteLine($"{Name} rolls a {myRoll}");  //Only works if SmackTalker rolls first
    //         Console.WriteLine($"{other.Name} rolls a {otherRoll}");
    //         if (myRoll > otherRoll)
    //         {
    //             Console.WriteLine($"{Name} Wins!");
    //         }
    //         else if (myRoll < otherRoll)
    //         {
    //             Console.WriteLine($"{other.Name} Wins!");
    //         }
    //         else
    //         {
    //             // if the rolls are equal it's a tie
    //             Console.WriteLine("It's a tie");
    //         }
    //     }
    }
}