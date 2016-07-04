using System;

using System.IO;


namespace HW_29._06_1
{
    class Checks
    {

        public string CheckTheExistingOfDirectory(String path )
        {
            bool exist = false;
            String newPath, dir;
           
            do
            {
                Console.WriteLine("Enter the name of the directory, where you want to store you new file: ");
                dir = Console.ReadLine();
                newPath = path + dir;
                if (Directory.Exists(newPath))
                {
                    Console.WriteLine("The directory is already exist. Enter the 1 if you want to write your file in existing directory."+
                       "Enter any other key if you want to enter another name for directory.");
                    String choice = Console.ReadLine();

                    if (choice == "1") { exist = true; }
                    else { continue; }
                }
                else { exist = true; }
            }
            while (!exist);

            return newPath;
        }


        public string CheckTheExistingOfFile(String newPath)
        {

            bool exist = false;
            String pathToTheFile, fileName; ;
         
            do
            {
                Console.WriteLine("Enter the name of the new file(for storing the information):");
                fileName = Console.ReadLine();
                pathToTheFile = newPath +"\\"+ fileName;
                
                if (File.Exists(pathToTheFile))
                {
                    Console.WriteLine("This file is already exist. Enter the 1 if you want to rewrite your file." +
                        "Enter any other key if you want to enter another name for file.");
                    String choice = Console.ReadLine();

                    if (choice == "1") { exist = true; }
                    else { continue; }
                }
                else { exist = true; }
            }
            while (!exist);
            return pathToTheFile;
        }


        public string CheckTheFileWithInformation() {
            String pathInform;
            bool exist = false;           
            do
            {
                Console.WriteLine("Enter the path to the file from what you would like to read :");
                pathInform = Console.ReadLine();
              
                if (!File.Exists(pathInform))
                {
                    Console.WriteLine("This file is not exist. Try again...");                
                }
                else { exist = true; }
            }
            while (!exist);

            return pathInform;
        }


        public void WriteInAFile(String pathToRead, String pathToWrite) {

            int counter = 0;
            string line;

            using (StreamWriter strWriter = new StreamWriter(pathToWrite))
            {
                StreamReader strReader = new StreamReader(pathToRead);
                while ((line = strReader.ReadLine()) != null && counter < 20)
                {

                    strWriter.WriteLine(line);
                    Console.WriteLine(line);
                    counter++;

                }

                strReader.Close();
            }

        }

    }
}
