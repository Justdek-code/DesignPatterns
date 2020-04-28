using System;

namespace Composite
{
    class CLient
    {
        static void Main(string[] args)
        {
            Component rootDirectory = new Directory("C:\\");
            Component file1 = new File("file1.txt");
            Component directory = new Directory("ProgramFiles\\");
            Component file2 = new File("file2.txt");
            Component file3 = new File("file3.txt");

            directory.Add(file2);
            directory.Add(file3);
            rootDirectory.Add(file1);
            rootDirectory.Add(directory);

            rootDirectory.DisplayContent();

            /* Output:
            Directory: C:\
                File: file1.txt
                Directory: ProgramFiles\
                    File: file2.txt
                    File: file3.txt
            */
        }
    }
}
