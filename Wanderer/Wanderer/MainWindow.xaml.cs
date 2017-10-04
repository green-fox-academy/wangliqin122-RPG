using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;

namespace Wanderer
{
    public partial class MainWindow : Window
    {   
        FoxDraw foxDraw;
        Map map;
        Hero hero;

        public MainWindow()
        {
            InitializeComponent();
            foxDraw = new FoxDraw(canvas);
            map = new Map();
            hero = new Hero();

            map.MapCreator(foxDraw);
            hero.HeroAdder(foxDraw);
        }
        
        private void WindowKeyDown(object sender, KeyEventArgs e)
        {          
            map = new Map();
            map.MapCreator(foxDraw);

            if (e.Key == Key.Left)
            {
                hero.MoveLeft(foxDraw);
            }

            if (e.Key == Key.Right)
            {
                hero.MoveRight(foxDraw);
            }
            if (e.Key == Key.Up)
            {
                hero.MoveUp(foxDraw);
            }
            if (e.Key == Key.Down)
            {
                hero.MoveDown(foxDraw);
            }
        }
    }
}