using System.IO;

namespace System.Resources.Converter
{
    internal class BytesConverter : BaseResourceConverter<byte[]>
    {
        protected override byte[] ToResource(Stream s)
        {
            byte[] buffer = new byte[s.Length];

            s.Read(buffer, 0, (int)s.Length);

            return buffer;
        }
    }
}
