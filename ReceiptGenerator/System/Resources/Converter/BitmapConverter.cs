using System.Drawing;
using System.IO;

namespace System.Resources.Converter
{
    internal class BitmapConverter : BaseResourceConverter<Bitmap>
    {
        protected override Bitmap ToResource(Stream s)
        {
            return new Bitmap(s);
        }
    }
}