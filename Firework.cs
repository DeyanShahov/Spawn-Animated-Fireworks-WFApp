namespace Spawn_Animated_Fireworks_WFApp
{
    internal class Firework
    {
        public int height;
        public int width;
        public int currentFrame = 0;
        public Point position = new Point();
        public bool animationComplete = false;
        public Image firework;

        public Firework(Image frameImage)
        {
            height = 200;
            width = 200;
            firework = frameImage;
        }

        public void AnimationFirework(List<Image> fireworkFrames)
        {
            if (currentFrame < fireworkFrames.Count - 1)
            {
                currentFrame++;
                firework = fireworkFrames[currentFrame];
            }
            else
            {
                currentFrame = 0;
                animationComplete = true;
                firework = null;
            }
        }
    }
}
