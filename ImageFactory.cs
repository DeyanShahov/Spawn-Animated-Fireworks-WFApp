﻿namespace Spawn_Animated_Fireworks_WFApp
{
    public static class ImageFactory
    {
        private static readonly string assetsPath = Path.Combine(Application.StartupPath)
           .Replace("bin\\Debug\\net6.0-windows\\", "Assets\\");

        public readonly static List<string> Backgrounds = GetFilePath("backgrounds", "jpg");

        public readonly static List<string> Images = GetFilePath("images", "png");


        public static List<string> GetFilePath(string folderName, string fileType)
        {
            return Directory.GetFiles(assetsPath + $"{folderName}", $"*.{fileType}").ToList();
        }
    }
}
