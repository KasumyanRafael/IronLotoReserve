using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IronLotoReserve
{
    public partial class FormGame : Form
    {
        public string gamer1 = String.Empty;
        public string gamer2 = String.Empty;
        static int x = 3;
        static int y = 2;
        static int t = 5;
        bool IsPause = false;
        int cnt = 0;
        string[] s;
        int[,] firstTable = new int[x, y];
        int[,] secondTable = new int[x, y];
        int pictureshow = 0;
        int firstscore = 0;
        int secondscore = 0;
        int countPictures = 0;
        Word[] list;
        public FormGame()
        {
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
