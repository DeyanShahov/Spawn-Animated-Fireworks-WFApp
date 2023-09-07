namespace Spawn_Animated_Fireworks_WFApp
{
    public partial class Form1 : Form
    {
        private readonly string assetsPath = Path.Combine(Application.StartupPath)
           .Replace("bin\\Debug\\net6.0-windows\\", "Assets\\");

        List<string> imageLocation = new List<string>();
        List<Firework> fireworksList = new List<Firework>();
        int backgroundNumber;

        public Form1()
        {
            InitializeComponent();
            SetUp();
        }

        private void SetUp()
        {
            imageLocation = Directory.GetFiles(assetsPath + "backgrounds", "*.jpg").ToList();
            this.BackgroundImage = Image.FromFile(imageLocation[0]);
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (backgroundNumber < imageLocation.Count - 1) backgroundNumber++;
                else backgroundNumber = 0;

                this.BackgroundImage = Image.FromFile(imageLocation[backgroundNumber]);
            }            
        }

        private void FormMouseDown(object sender, MouseEventArgs e)
        {

        }

        private void FormPaintEvent(object sender, PaintEventArgs e)
        {

        }

        private void AnimationTimerEvent(object sender, EventArgs e)
        {

        }
    }
}