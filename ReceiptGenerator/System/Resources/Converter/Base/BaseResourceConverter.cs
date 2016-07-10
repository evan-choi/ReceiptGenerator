using System;
using System.IO;

namespace System.Resources.Converter
{
    public abstract class BaseResourceConverter<T> : IResourceConverter
    { 
        protected abstract T ToResource(Stream s);

        object IResourceConverter.ToResource(Stream s)
        {
            return ToResource(s);
        }
    }
}
