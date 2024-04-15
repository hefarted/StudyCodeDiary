using StudyCodeDiary;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //ErrorHandlingDiary diary = new ErrorHandlingDiary();
        //diary.PerformDivision();

        FileManager fileManager = new FileManager();
        string filePath = @"C:\Users\elvin.inapan\Documents\test.txt";

        // Writing to a file
        fileManager.WriteToFile(filePath, "Hello, World!");

        // Reading from a file
        string content = fileManager.ReadFromFile(filePath);
        Console.WriteLine(content);

        // Appending to a file
        fileManager.AppendToFile(filePath, "Test");

        // Reading from a file
        string updatedContent = fileManager.ReadFromFile(filePath);
        Console.WriteLine(updatedContent);
    }
}
