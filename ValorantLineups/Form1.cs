namespace ValorantLineups
{
    public partial class Form1 : Form
    {
        private Lineup lineup;
        private List<KeyHandler> ghk;

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

            // Control keys
            this.TabControl.KeyDown += KeyHelper.DisableKey;
            ghk = new List<KeyHandler>
            {
                new (Keys.F1, this, LeftButton_Click),
                new (Keys.F2, this, RightButton_Click),
            };
        }

        protected override void WndProc(ref Message m)
        {
            Console.WriteLine(m.Msg);
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
                foreach (var keyHandler in this.ghk)
                {
                    if (m.WParam.ToInt32() == keyHandler.GetHashCode())
                        keyHandler.action.Invoke(null, null);
                }

            base.WndProc(ref m);
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.TabControl.SelectedIndex != 0)
            {
                // Will be removed from previous tab and added to new selected tab
                this.TabControl.SelectedTab.Controls.Add(this.BackButton);
            }
        }

        private void RightButton_Click(object sender, EventArgs e) => this.lineup.NextLineup();

        private void LeftButton_Click(object sender, EventArgs e) => this.lineup.PreviousLineup();

        private void KilljoyButton_Click(object sender, EventArgs e)
        {
            this.TabControl.SelectedIndex++;
            this.lineup.SelectedAgent = "Killjoy";
        }


        private void OmenButton_Click(object sender, EventArgs e)
        {
            this.TabControl.SelectedIndex++;
            this.lineup.SelectedAgent = "Omen";
        }

        private void VyseButton_Click(object sender, EventArgs e)
        {
            this.TabControl.SelectedIndex++;
            this.lineup.SelectedAgent = "Vyse";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.TabControl.SelectedIndex--;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Normal;
            this.BackButton.BringToFront();
        }

        private void MapButton_Click(string name)
        {
            this.TabControl.SelectedIndex++;
            this.lineup.SelectedMap = name;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.BackButton.Parent = this.PictureBox;
        }

        private void HavenButton_Click(object sender, EventArgs e) => MapButton_Click("Haven");

        private void AscentButton_Click(object sender, EventArgs e) => MapButton_Click("Ascent");

        private void FractureButton_Click(object sender, EventArgs e) => MapButton_Click("Fracture");

        private void SplitButton_Click(object sender, EventArgs e) => MapButton_Click("Fracture");

        private void BindButton_Click(object sender, EventArgs e) => MapButton_Click("Bind");

        private void PearlButton_Click(object sender, EventArgs e) => MapButton_Click("Pearl");

        private void AbyssButton_Click(object sender, EventArgs e) => MapButton_Click("Abyss");
    }
}