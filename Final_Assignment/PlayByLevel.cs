﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assignment
{
    public static class PlayByLevel
    {
        public static List<String> Maps = new List<string>();

        static PlayByLevel()
        {
            Maps.Add(".___.___.___.   .\n" +
                    "|     M     |    \n" +
                    ".   .___.   .___.\n" +
                    "|       |     X  \n" +
                    ".   .___.   .___.\n" +
                    "|     T     |    \n" +
                    ".___.___.___.   .");

            Maps.Add(".___.___.___.___.___.___.___.\n" +
                    "|                           |\n" +
                    ".   .   .   .   .   .   .   .\n" +
                    "| M |   | T                 |\n" +
                    ".   .___.   .   .   .   .   .\n" +
                    "|                   |   |   |\n" +
                    ".   .   .   .   .   .___.   .\n" +
                    "|                           |\n" +
                    ".___.   .___.___.___.___.___.\n" +
                    "    | X |                    \n" +
                    ".   .   .   .   .   .   .   .");

            Maps.Add(".___.___.___.   .\n" +
                     "|     M     |    \n" +
                     ".   .___.   .___.\n" +
                     "|     T       X  \n" +
                     ".   .   .   .___.\n" +
                     "|   |       |    \n" +
                     ".___.   .   .   .\n" +
                     "|           |    \n" +
                     ".___.___.___.   .");

            Maps.Add(".   .   .   .   .   .\n" +
                    "            | X |    \n" +
                    ".___.___.___.   .___.\n" +
                    "|   | T             |\n" +
                    ".   .   .   .___.   .\n" +
                    "|       |       | M |\n" +
                    ".   .___.   .   .   .\n" +
                    "|           |       |\n" +
                    ".   .___.___.   .   .\n" +
                    "|           |   |   |\n" +
                    ".   .   .   .___.   .\n" +
                    "|                   |\n" +
                    ".___.___.___.___.___.");

            Maps.Add(".   .   .   .   .   .   .   .\n" +
                    "                    | X |    \n" +
                    ".___.___.___.___.___.   .___.\n" +
                    "|         T     |       |   |\n" +
                    ".   .           .   .___.   .\n" +
                    "|   |           |           |\n" +
                    ".   .___.   .   .   .___.   .\n" +
                    "|           |           |   |\n" +
                    ".       .___.   .   .___.   .\n" +
                    "|       | M     |   |       |\n" +
                    ".       .___.___.___.       .\n" +
                    "|                           |\n" +
                    ".___.___.___.___.___.___.___.");

            Maps.Add(".   .   .   .   .   .   .\n" +
                    "                | X |    \n" +
                    ".___.___.___.___.   .___.\n" +
                    "| T                 |   |\n" +
                    ".___.   .   .   .   .   .\n" +
                    "|       |       |   |   |\n" +
                    ".   .___.   .   .___.   .\n" +
                    "|   |   |   |     M     |\n" +
                    ".   .   .___.   .___.   .\n" +
                    "|   |           |       |\n" +
                    ".   .   .___.   .   .   .\n" +
                    "|   |   |               |\n" +
                    ".   .   .   .   .   .   .\n" +
                    "|                       |\n" +
                    ".___.___.___.___.___.___.");

            Maps.Add(".   .   .   .   .   .   .\n" +
                    "    | X |                \n" +
                    ".___.   .___.___.___.___.\n" +
                    "|                   |   |\n" +
                    ".   .___.   .   .___.   .\n" +
                    "|           |           |\n" +
                    ".   .   .   .   .___.   .\n" +
                    "|           |       |   |\n" +
                    ".   .   .   .   .   .   .\n" +
                    "|   |           |   |   |\n" +
                    ".___.   .   .   .___.   .\n" +
                    "| M               T |   |\n" +
                    ".   .   .___.   .   .   .\n" +
                    "|                       |\n" +
                    ".___.___.___.___.___.___.");

            Maps.Add(".___.___.___.___.___.___.___.___.___.\n" +
                    "| T             |       |           |\n" +
                    ".___.___.   .   .   .   .   .___.   .\n" +
                    "|       |   |   |   |   |       |   |\n" +
                    ".   .   .___.   .   .   .   .___.   .\n" +
                    "|   |     M |       |       |       |\n" +
                    ".   .___.   .   .___.___.___.   .   .\n" +
                    "|       |   |       |               |\n" +
                    ".___.   .   .___.   .   .___.___.___.\n" +
                    "|   |   |           |               |\n" +
                    ".   .   .___.   .___.___.___.___.   .\n" +
                    "|       |       |                   |\n" +
                    ".   .___.   .___.       .___.___.___.\n" +
                    "|   |   |       |   |               |\n" +
                    ".   .   .   .___.   .___.___.___.   .\n" +
                    "|   |                   |           |\n" +
                    ".___.   .___.___.___.___.___.___.___.\n" +
                    "    | X |                            \n" +
                    ".   .   .   .   .   .   .   .   .   .");
        }

    }
}