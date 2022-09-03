namespace ValorantLineups
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
            this.TabControl.Location = new Point(0, -24);
            var w = this.TabControl.Size.Width;
            var h = this.TabControl.Size.Height;
            this.TabControl.Size = new Size(w, h + 24);
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
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.TabControl.SelectedIndex--;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Normal;
        }

        private void HavenButton_Click(object sender, EventArgs e)
        {
            this.TabControl.SelectedIndex++;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }

        private void RightButton_Click(object sender, EventArgs e)
        {

        }

        private void LeftButton_Click(object sender, EventArgs e)
        {

        }
    }
}