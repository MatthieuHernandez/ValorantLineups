using System.Reflection.Emit;
using System.Windows.Forms;

namespace ValorantLineups
{
    public partial class Form1 : Form
    {
        private Lineup lineup;

        public Form1()
        {
            this.InitializeComponent();
            this.TabControl.Location = new Point(-4, -24);
            var w = this.TabControl.Size.Width;
            var h = this.TabControl.Size.Height;
            this.TabControl.Size = new Size(w + 8, h + 28);
            this.lineup = new Lineup(this.PictureBox);
            this.LeftButton.Parent = this.PictureBox;
            this.RightButton.Parent = this.PictureBox;
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.TabControl.SelectedIndex != 0)
            {
                // Will be removed from previous tab and added to new selected tab
                this.TabControl.SelectedTab.Controls.Add(this.BackButton);
            }
        }

        private void KilljoyButton_Click(object sender, EventArgs e)
        {
            this.TabControl.SelectedIndex++;
            this.lineup.SelectedAgent = "Killjoy";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.TabControl.SelectedIndex--;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Normal;
            this.BackButton.BringToFront();
        }

        private void HavenButton_Click(object sender, EventArgs e)
        {
            this.TabControl.SelectedIndex++;
            this.lineup.SelectedMap = "Haven";
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.BackButton.Parent = this.PictureBox;

        }

        private void RightButton_Click(object sender, EventArgs e) => this.lineup.NextLineup();

        private void LeftButton_Click(object sender, EventArgs e) => this.lineup.PreviousLineup();

    }
}