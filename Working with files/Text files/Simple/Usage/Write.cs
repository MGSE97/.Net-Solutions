using System;
using System.Collections.Generic;
using System.Text;

namespace Usage
{
    public static class Write
    {
        public static string Text = "Hello";

        public static string FileStream()
        {
            string fileName = string.Format(Program.FileToWrite, "FileStream");

            using (var fileStream = new System.IO.FileStream(fileName, System.IO.FileMode.Create))
                using (var textWriter = new System.IO.StreamWriter(fileStream))
                    textWriter.WriteLine(Text);

            return fileName;
        }

        public static string File()
        {
            string fileName = string.Format(Program.FileToWrite, "File");

            System.IO.File.WriteAllText(fileName, Text);

            return fileName;
        }

        public static string FileInfo()
        {
            string fileName = string.Format(Program.FileToWrite, "FileInfo");

            var fileInfo = new System.IO.FileInfo(fileName);
            using (var textWriter = new System.IO.StreamWriter(fileInfo.OpenWrite()))
                textWriter.Write(Text);

            return fileName;
        }

        public static string TextWriter()
        {
            string fileName = string.Format(Program.FileToWrite, "TextWriter");

            using (System.IO.TextWriter textWriter = new System.IO.StreamWriter(fileName))
                textWriter.WriteLine(Text);

            return fileName;
        }
    }
}
