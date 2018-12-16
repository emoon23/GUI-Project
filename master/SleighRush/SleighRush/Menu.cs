using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SleighRush
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //Positioning the "Enter" button in the middle of the screen - regardless of screen size
            ENTER.Top = (this.Height / 2) - (ENTER.Height / 2);
            ENTER.Left = (this.Width / 2) - (ENTER.Width / 2);

            //Positioning the "Sleigh Rush" label in the middle of the screen, 33 pixels from the top of the screen - regardless of screen size
            label1.Top = 33;
            label1.Left = (this.Width / 2) - (label1.Width / 2);
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameScreen sc = new GameScreen();
            sc.ShowDialog();
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
