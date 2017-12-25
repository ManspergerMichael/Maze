using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class MazeGame : Form
    {
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\media\chord.wav");
        System.Media.SoundPlayer finishSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\media\tada.wav");
        
        public MazeGame()
        {
            InitializeComponent();
            moveToStart();//moves mouse to starting point
            
        }

        private void finishLabel_MouseEnter(object sender, EventArgs e)
        {
            finishSoundPlayer.Play();
            MessageBox.Show("A Winner is You!");
            Close();
        }

        private void moveToStart()
        {
            startSoundPlayer.Play();
            // upper left corner of a panel is (0, 0)
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 10); // 10 pixles down and to the right
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            moveToStart();
        }
    }
}
