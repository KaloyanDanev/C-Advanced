using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem_7._Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            var filesDictionary = new Dictionary<string, List<FileInfo>>();
            var files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                string extension = fileInfo.Extension;
                long size = fileInfo.Length;

                if (!filesDictionary.ContainsKey(extension))
                {
                    filesDictionary[extension] = new List<FileInfo>();
                }
                filesDictionary[extension].Add(fileInfo);
            }
            filesDictionary = filesDictionary.OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fullFileName = desktop + "/report.txt";

            using (var writer = new StreamWriter(fullFileName))
            {
                foreach (var pair in filesDictionary)
                {
                    string extension = pair.Key;
                    writer.WriteLine(extension);
                    var fileInfos = pair.Value.OrderByDescending(fi=>fi.Length);
                    foreach (var fileinfo in fileInfos)
                    {
                        double fileSize = (double) fileinfo.Length / 1024;
                        writer.WriteLine($"--{fileinfo.Name} - {fileSize:f3}kb");
                    }

                }
            }
        }
    }
}
