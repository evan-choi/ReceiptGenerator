using System.Drawing.Imaging;
using System.IO;

namespace System.Drawing
{
    public static class BitmapEx
    {
        public static string ToBase64(this Bitmap source)
        {
            using (var ms = new MemoryStream())
            {
                source.Save(ms, ImageFormat.Jpeg);

                return Convert.ToBase64String(ms.ToArray());
            }
        }
    }
}