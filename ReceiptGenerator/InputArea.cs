using System.Drawing;

namespace SWMaestro
{
    struct InputArea
    {
        private static Font baseFont = new Font("돋움체", 11);

        public RectangleF Area { get; set; }
        public ContentAlignment ContentAlignment { get; set; }
        public string Format { get; set; }
        public Font Font { get; }
        
        public InputArea(RectangleF area, ContentAlignment alignment, Font font = null, string format = null)
        {
            this.Area = area;
            this.ContentAlignment = alignment;
            this.Format = format;
            this.Font = font ?? baseFont;
        }
    }
}
