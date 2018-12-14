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
    public partial class LeaderBoard : Form
    {
        private List<User> users;

        public LeaderBoard()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            GameConfigurationManager gameConfig = new GameConfigurationManager();
            gameConfig.parseConfigurationFile();
            users = gameConfig.users;

            foreach (User user in users)
            {
                this.dataGridView1.Rows.Add(user.Name, user.Score);
            }

            this.dataGridView1.Sort(this.dataGridView1.Columns["Score"], ListSortDirection.Descending);
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            highScore.AutoSize = false;
            highScore.TextAlign = ContentAlignment.MiddleCenter;
            highScore.Left = (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width / 2) - (highScore.Width / 2);

            dataGridView1.Height = (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - highScore.Height - highScore.Location.Y -
                dataGridView1.Location.Y - backBtn.Height - 50);
            dataGridView1.Top = (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height / 2) - (dataGridView1.Height / 2);

            dataGridView1.Left = (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width / 2) - (dataGridView1.Width / 2);

            backBtn.Left = (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width / 2) - (backBtn.Width / 2);
            backBtn.Top = dataGridView1.Location.Y + dataGridView1.Height + 15;
        }

        private void backButtonClicked(object sender, EventArgs e)
        {
            this.Hide();
            GameScreen gameScreenForm = new GameScreen();
            gameScreenForm.ShowDialog();
            this.Close();
        }

        private void LeaderBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            GameScreen gameScreenForm = new GameScreen();
            gameScreenForm.ShowDialog();
            this.Close();
        }
    }
}
