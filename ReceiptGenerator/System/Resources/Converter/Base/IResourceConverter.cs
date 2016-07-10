using System.IO;

namespace System.Resources.Converter
{
    public interface IResourceConverter
    {
        object ToResource(Stream s);
    }
}
