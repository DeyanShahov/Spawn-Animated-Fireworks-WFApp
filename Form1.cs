namespace Spawn_Animated_Fireworks_WFApp
{
    public partial class Form1 : Form
    {
        List<Image> backgroundImagesList = new List<Image>();
        List<Image> fireworkFramesList = new List<Image>();
        List<Firework> fireworksList = new List<Firework>();
        int backgroundNumber;

        public Form1()
        {
            InitializeComponent();
            SetUp();
        }

        private void SetUp()
        {
            foreach (string frame in ImageFactory.Images)
            {
                Image tempFrame = Image.FromFile(frame);
                fireworkFramesList.Add(tempFrame);
            }

            foreach (string background in ImageFactory.Backgrounds)
            {
                Image tempBack = Image.FromFile(background);
                backgroundImagesList.Add(tempBack);
            }

            this.BackgroundImage = backgroundImagesList[0];
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (backgroundNumber < backgroundImagesList.Count - 1) backgroundNumber++;
                else backgroundNumber = 0;

                this.BackgroundImage = backgroundImagesList[backgroundNumber];
            }
        }

        private void FormMouseDown(object sender, MouseEventArgs e)
        {
            Firework newFirework = new Firework(fireworkFramesList[0]);
            newFirework.position.X = e.X - newFirework.width / 2;
            newFirework.position.Y = e.Y - newFirework.height / 2;         
            fireworksList.Add(newFirework);
        }

        private void FormPaintEvent(object sender, PaintEventArgs e)
        {
            foreach (Firework newFirework in fireworksList.ToList())
            {
                if (newFirework.animationComplete == false)
                {
                    e.Graphics.DrawImage(newFirework.firework, newFirework.position.X,
                        newFirework.position.Y, newFirework.width, newFirework.height);
                }
            }
        }

        private void AnimationTimerEvent(object sender, EventArgs e)
        {
            if (fireworksList != null)
            {
                foreach (Firework firework in fireworksList.ToList())
                {
                    if (firework.animationComplete == false) firework.AnimationFirework(fireworkFramesList);
                    else fireworksList.Remove(firework);
                }
            }

            this.Invalidate();
        }
    }
}