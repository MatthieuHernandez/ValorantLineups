using System.IO;

namespace ValorantLineups
{
    internal class Lineup
    {
        private int lineupIndex;

        public string? SelectedAgent
        {
            get => selectedAgent;
            set
            {
                this.lineupIndex = 0;
                this.selectedAgent = value;
            }
        }

        public string? SelectedMap
        {
            get => selectedMap;
            set
            {
                this.lineupIndex = 0;
                this.selectedMap = value;
                this.LoadLineup();
            }
        }

        private readonly PictureBox lineupBox;
        private string? selectedAgent;
        private string? selectedMap;

        public Lineup(PictureBox lineupBox)
        {
            this.lineupBox = lineupBox;
        }

        public void NextLineup()
        {
            this.LoadLineup(1);
        }
        public void PreviousLineup()
        {
            this.LoadLineup(-1);
        }

        private void LoadLineup(int value = 0)
        {
            this.lineupIndex += value;
            var path = $"./screenshots/{SelectedAgent}/{SelectedMap}/{lineupIndex}.png";
            if (lineupIndex <= 0)
            {
                lineupIndex = 0;
                this.lineupBox.Image = new Bitmap("./screenshots/Black.png");
            }

            else
                if(File.Exists(path))
                    this.lineupBox.Image = new Bitmap(path);
                else
                    this.lineupIndex -= value;
        }
    }
}
