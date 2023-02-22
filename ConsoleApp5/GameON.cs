using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class GameON
    {
        public string GetOutput(int number)
        {
            if (number % 15 == 0)
                return "GameON";
            if (number % 5 == 0)
                return "Game";
            if (number % 3 == 0)
                return "ON";

            return number.ToString();
        }
    }
}
