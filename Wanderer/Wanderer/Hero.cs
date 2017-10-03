using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace Wanderer
{
    class Hero : Map
    {
        private string heroImage = @"./Asset/hero-down.png";
        private int startX = 50;
        private int startY = 50;
        private int size = 50;

        public void HeroAdder(FoxDraw foxDraw)
        {
            foxDraw.AddImage(heroImage, startX, startY);   
        }

        public void MoveRight(FoxDraw foxDraw)
        {
            if (bricks[,] == true)
            {

            }
                foxDraw.AddImage(heroImage, startX + size, startY);
        }
    }
}