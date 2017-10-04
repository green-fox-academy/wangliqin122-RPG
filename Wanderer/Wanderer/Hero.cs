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

        //public bool IsInMap()
        //{
        //    return !(startX > max || startY > max || startY < 0 || startX < 0);
        //}

        public void HeroAdder(FoxDraw foxDraw)
        {
            foxDraw.AddImage(heroImage, startX, startY);
        }

        public void MoveRight(FoxDraw foxDraw)
        { 
            if (startX < max && map.bricks[(startY-50)/size][(startX-50)/size + 1])
            {
                startX += size;  
            }
            foxDraw.AddImage(heroRight, startX, startY);
        }

        public void MoveLeft(FoxDraw foxDraw)
        {
            if (startX > size && map.bricks[(startY-50)/size][(startX-50)/size - 1])
            {
                startX -= size;
            }             
            foxDraw.AddImage(heroLeft, startX, startY);
        }

        public void MoveDown(FoxDraw foxDraw)
        {
            if (startY < max && map.bricks[(startY-50)/size + 1][(startX-50)/size])
            {
                startY += size;
            }
            foxDraw.AddImage(heroImage, startX, startY);
        }      

        public void MoveUp(FoxDraw foxDraw)
        {
            if (startY > size && map.bricks[(startY-50)/size - 1][(startX-50)/size])
            {
                startY -= size;
            }
            foxDraw.AddImage(heroUp, startX, startY);
        }
    }
}