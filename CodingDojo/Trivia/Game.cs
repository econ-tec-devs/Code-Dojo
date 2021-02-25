// -----------------------------------------------------------------------
// <copyright file="Game.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Trivia
{
    using System;

    public class Game
    {
        private int playersCount;

        public string createRockQuestion(int index)
        {
            return $"Rock Question {index}";
        }

        public void add(string name)
        {
            if (playersCount+1 > 5)
            {
                throw new IndexOutOfRangeException();
            }

            this.playersCount++;
            Console.WriteLine($"{name} was added" + Environment.NewLine + $"They are player number {this.playersCount}");
        }

        public bool isPlayable()
        {
            return this.playersCount > 1;
        }
    }
}
