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
        private string image = @"./Asset/floor.png";
        private string wall = @"./Asset/wall.png";
        private int x = 0;
        private int y = 0;
        private int size = 50;

        private List<int[]> bricks = new List<int[]>()
        {
        new int[] {150, 50},
        new int[] {250, 50},
        new int[] {150, 100},
        new int[] {250, 100},
        new int[] {350, 100},
        new int[] {400, 100},
        new int[] {50, 150},
        new int[] {100, 150},
        new int[] {150, 150},
        new int[] {250, 150},
        new int[] {350, 150},
        new int[] {400, 150},
        new int[] {250, 200},
        new int[] {0, 250},
        new int[] {50, 250},
        new int[] {100, 250},
        new int[] {150, 250},
        new int[] {250, 250},
        new int[] {300, 250},
        new int[] {350, 250},
        new int[] {400, 250},
        new int[] {50, 300},
        new int[] {150, 300},
        new int[] {400, 300},



        };

        public void MapCreator(FoxDraw foxDraw)
        {
            for (int i = 0; i < 10; i++)
            {   
                y += size;
                x = 0;
                for (int j = 0; j < 10; j++)
                {
                    foxDraw.AddImage(image, x, y);
                    x += size;
                }
            }

            for (int k = 0; k < bricks.Count; k++)
            {
                foxDraw.AddImage(wall, bricks[k][0], bricks[k][1]);
            }
 
        }
    }
}