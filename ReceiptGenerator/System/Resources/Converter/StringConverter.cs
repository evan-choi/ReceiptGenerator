using System.IO;
using System.Text;

namespace System.Resources.Converter
{
    internal class StringConverter : BaseResourceConverter<string>
    {
        protected override string ToResource(Stream s)
        {
            using (var sr = new StreamReader(s, Encoding.Default))
            {
                return sr.ReadToEnd();
            }
        }
    }
}