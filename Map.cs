﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_BasedRPGFirst
{
    class Map 
    {
        public string[,] mapE;
        public Map()
        {
            
            
        }

        public void border()
        {
         mapE = new string[,] {
        {"x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x",},
        {"x",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","x",},
        {"x",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","x",},
        {"x",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","x",},
        {"x",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","x",},
        {"x",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","x",},
        {"x",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","x",},
        {"x",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","x",},
        {"x",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","x","x","x",".","x","x","x","x",".",".",".","x",},
        {"x",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","x",".",".",".",".",".",".","x",".",".",".","x",},
        {"x",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","x",".",".",".",".",".",".","x",".",".",".","x",},
        {"x",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","x",".",".",".",".",".",".","x",".",".",".","x",},
        {"x",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","x",".",".",".",".",".",".","x",".",".",".","x",},
        {"x",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","x",".",".",".",".",".",".","x",".",".",".","x",},
        {"x",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".",".","x",".",".",".",".",".",".","x",".",".",".","x",},
        {"x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x","x",},

        };
            int MaxI = mapE.GetLength(0) - 1;
            int MaxJ = mapE.GetLength(1) - 1;
            for (int i = 0; i <= MaxI; i++)
            {

                for (int j = 0; j <= MaxJ; j++)
                {
                    Console.Write(mapE[i, j]);
                }
                Console.WriteLine("");

            }
        }
    }
}
