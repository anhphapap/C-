using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace AnimalRace
{
    internal class Player
    {
        PictureBox player;
        Panel road;
        double timeRun;
        String name;

        public Player()
        {

        }

        public Player(PictureBox player, Panel road, String name)
        {
            this.player = player;
            this.road = road;
            this.name = name;
            this.timeRun = 0;
        }

        public void prepare()
        {
            player.Left = 0;
            timeRun = 0;
        }

        public double run()
        {
            if (player.Left + player.Width > road.Width)
            {
                player.Left = road.Width - player.Width;
                if (Form1.time == -1 || timeRun == Form1.time)
                {
                    Form1.time = timeRun;
                    return -1;
                }
                return -2;
            }
            else if (player.Left + player.Width < road.Width)
            {
                player.Left += Form1.rand.Next(0, 50);
                timeRun += 0.1;
            }
            return timeRun;
        }

        public String showName()
        {
            return name;
        }
    }
}
