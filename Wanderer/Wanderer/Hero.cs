using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace Wanderer
{
    class Hero : Character
    {
        private string heroImage = @"./Asset/hero-down.png";
        private string heroRight = @"./Asset/hero-right.png";
        private string heroLeft = @"./Asset/hero-left.png";
        private string heroUp = @"./Asset/hero-up.png";
        private int startX = 50;
        private int startY = 50;
        private int size = 50;
        private int max = 500;

        Map map = new Map();
        Character character = new Character();

        public bool IsInMap()
        {
            return (startX < max || startY < max || startY > 0 || startX > 0);
        }

        public void HeroAdder(FoxDraw foxDraw)
        {
            foxDraw.AddImage(heroImage, startX, startY);
        }

        public void MoveRight(FoxDraw foxDraw)
        { 
            if (!IsInMap()/*startX < max*/)
            {
                startX += size;  
            }
            foxDraw.AddImage(heroRight, startX, startY);
        }

        public void MoveLeft(FoxDraw foxDraw)
        {
            if (startX > size)
            {
                startX -= size;
            }             
            foxDraw.AddImage(heroLeft, startX, startY);
        }

        public void MoveDown(FoxDraw foxDraw)
        {
            if (startY < max)
            {
                startY += size;
            }
            foxDraw.AddImage(heroImage, startX, startY);
        }      

        public void MoveUp(FoxDraw foxDraw)
        {
            if (startY > size)
            {
                startY -= size;
            }
            foxDraw.AddImage(heroUp, startX, startY);
        }
    }
}