namespace Trivia
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Player
    {
        public string Name { get; set; }
        public int Place { get; set; }
        public int Purse { get; set; }
        public bool InPenaltyBox { get; set; }

        public Player(string name)
        {
            Name = name;
        }
    }
}
