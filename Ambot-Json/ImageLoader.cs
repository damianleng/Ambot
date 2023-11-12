using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambot_Json
{
    internal class ImageLoader
    {
        public static Image LoadImage(string relativePath)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string imageFilePath = Path.Combine(baseDirectory, relativePath);
            if (File.Exists(imageFilePath))
            {
                return Image.FromFile(imageFilePath);
            }
            else
            {
                // Handle the case when the image file does not exist
                return null;
            }
        }
    }
}
