// -----------------------------------------------------------------------
// <copyright file="Game.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace Trivia
{
    public class Game
    {
        public string createRockQuestion(int index)
        {
            return $"Rock Question {index}";
        }

        public void add(string name)
        {
            Console.WriteLine("Hans Wurst 1 was added" + Environment.NewLine + "They are player number 1");
        }
    }
}
