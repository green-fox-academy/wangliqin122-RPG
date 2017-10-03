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
        private double x = 0;
        private double y = 0;
        private int size = 50;

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

            foxDraw.AddImage(wall, 150, 200);
 
        }
    }
}