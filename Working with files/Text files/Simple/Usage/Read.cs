namespace Usage
{
    public static class Read
    {
        public static string FileStream()
        {
            string text = null;

            using (var fileStream = new System.IO.FileStream(Program.FileToRead, System.IO.FileMode.Open))
                using (var textReader = new System.IO.StreamReader(fileStream))
                    text = textReader.ReadToEnd();

            return text;
        }

        public static string File()
        {
            string[] lines = System.IO.File.ReadAllLines(Program.FileToRead);
            if (lines.Length > 0)
                return string.Join('\n', lines);

            return null;
        }

        public static string FileInfo()
        {
            string text = null;

            var fileInfo = new System.IO.FileInfo(Program.FileToRead);

            if (fileInfo.Exists)
                using (var fileStream = fileInfo.OpenRead())
                    using (var textReader = new System.IO.StreamReader(fileStream))
                        text = textReader.ReadToEnd();

            return text;
        }

        public static string TextReader()
        {
            string text = null;

            using (System.IO.TextReader textReader = new System.IO.StreamReader(Program.FileToRead))
                text = textReader.ReadToEnd();

            return text;
        }
    }
}
