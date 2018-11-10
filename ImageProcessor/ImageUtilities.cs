using System.Drawing;
using System.Drawing.Imaging;

namespace ImageProcessor
{
    class ImageUtilities
    {
        private readonly ScreenCapture screenCapture;

        public ImageUtilities()
        {
            screenCapture = new ScreenCapture();
        }

        public Image GetFullScreenShot() => screenCapture.CaptureScreen();

        public void SaveFullScreenShot(string path, string name, ImageFormat format)
        {
            Image image = screenCapture.CaptureScreen();
            string fullPath = $"{path}\\{name}";
            image.Save(fullPath, format);
        }
    }
}
