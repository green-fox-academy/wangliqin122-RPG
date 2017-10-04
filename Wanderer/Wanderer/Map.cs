using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;
using Wanderer;
using System.Windows.Controls;

namespace Wanderer
{
    public class Map
    {
        private string tile = @"./Asset/floor.png";
        private string wall = @"./Asset/wall.png";
        private int x = 0;
        private int y = 0;
        private int size = 50;
        private int max = 500;

        public List<bool[]> bricks = new List<bool[]>()
        {
        new bool [] {true, true, true, false, true, false, true, true, true, true},
        new bool [] {true, true, true, false, true, false, true, false, false, true},
        new bool [] {true, false, false, false, true, false, true, false, false, true},
        new bool [] {true, true, true, true, true, false, true, true, true, true},
        new bool [] {false, false, false, false, true, false, false, false, false, true},
        new bool [] {true, false, true, false, true, true, true, true, false, true},
        new bool [] {true, false, true, false, true, false, false, false, true, true},
        new bool [] {true, true, true, true, true, false, false, true, false, true},
        new bool [] {true, false, false, false, true, true, true, true, false, true},
        new bool [] {true, true, true, false, true, false, false, true, true, true},
        };

        public void MapCreator(FoxDraw foxDraw)
        {
            for (int i = 0; i < 10; i++)
            {
                y += size;
                x = 0;
                for (int j = 0; j < 10; j++)
                {
                    x += size;
                    if (bricks[i][j] == true)
                    {
                        foxDraw.AddImage(tile, x, y);
                    }
                    else
                    {
                        foxDraw.AddImage(wall, x, y);
                    }
                }
            }          
        }
        public bool IsInMap()
        {
            return !(x > max || y > max || y < 0 || x < 0);
        }
    }
}