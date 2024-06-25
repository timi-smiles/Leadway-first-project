// See https://aka.ms/new-console-template for more information

using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {


        Console.WriteLine("Enter your file location");
        string sourceFileName = Console.ReadLine();
        Console.WriteLine("Enter the file destination");
        string destFileName = Console.ReadLine();
        File.Move(sourceFileName, destFileName);






        //string sourceFileName = @"C:\Users\t-ogunnowo\Desktop\timi.docx";
        //string destFileName = @"C:\Users\t-ogunnowo\Documents\timi.docx";
        //File.Move(sourceFileName, destFileName);




        //Console.WriteLine("Enter your file location");
        //Console.ReadLine();
        //Console.WriteLine("Enter the file destination");
        //Console.ReadLine();

        //string desktopPath = @"C:\Users\t-ogunnowo\Desktop\";
        //string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);





        //File.Move(filePath, destFileName);

        //catch (FileNotFoundException ex)
        //{
        //    Console.WriteLine($"Source file not found: {ex.Message}");
        //}
        //catch (IOException ex)
        //{
        //    Console.WriteLine($"An I/O error occurred: {ex.Message}");
        //}
        //catch (UnauthorizedAccessException ex)
        //{
        //    Console.WriteLine($"You do not have permission to perform this action: {ex.Message}");
        //}
        //catch (ArgumentException ex)
        //{
        //    Console.WriteLine($"Invalid path: {ex.Message}");
        //}



        //try
        //{
        //    if (File.Exists(sourceFileName))
        //    {
        //        if (File.Exists(destFileName))
        //        {
        //            File.Move(sourceFileName, destFileName);
        //        }

        //    }
        //} catch (Exception ex) 
        //{
        //    Console.WriteLine(ex.Message);
        //};


    }
}