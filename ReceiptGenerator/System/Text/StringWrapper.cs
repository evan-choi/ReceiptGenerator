namespace System.Text
{
    public class StringWrapper : IFormattable
    {
        public string Value { get; set; }
        
        public StringWrapper(string value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return Value;
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return Value;
        }
    }
}
