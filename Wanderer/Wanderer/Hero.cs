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
        private string name;
        private int x = 0;
        private int y = 0;
        private int size = 50;

        public Hero()
        {
            this.name = "mario";
        }
         
        public void HeroAdder(FoxDraw foxDraw)
        {
            foxDraw.AddImage(heroImage, x, y + size);   
        }

    }
}
