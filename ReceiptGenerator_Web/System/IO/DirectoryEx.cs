namespace System.IO
{
    public static class DirectoryEx
    {
        public static void CreateDirectory(this string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}