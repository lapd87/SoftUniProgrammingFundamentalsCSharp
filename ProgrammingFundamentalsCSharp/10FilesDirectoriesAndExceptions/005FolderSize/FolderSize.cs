namespace FolderSize
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] fileList = Directory.GetFiles("TestFolder");

            double totalSize = 0;

            foreach (var file in fileList)
            {
                FileInfo info = new FileInfo(file);

                totalSize += info.Length;
            }

            File.WriteAllText("Output.txt", (totalSize / 1024 / 1024).ToString());
        }
    }
}
