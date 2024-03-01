// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {

        var rand = new Random();
        DateTime Now = DateTime.Now;
        string sourceDirectory = @"C:\";
        var files = Directory.EnumerateFiles(sourceDirectory, "*.*", SearchOption.AllDirectories);
        var directories = Directory.EnumerateDirectories(sourceDirectory, "*.*", SearchOption.AllDirectories);
 
        foreach (string myFile in files){
        // Calling the SetLastAccessTime() function
        // to set last access date and time
            try {
                DateTime newDateTime = new DateTime(Now.Year, Now.Month, Now.Day, rand.Next(0, 23), rand.Next(0, 59), rand.Next(0, 59), rand.Next(0, 999));
                File.SetLastAccessTime(myFile, newDateTime);
                File.SetLastWriteTime(myFile, newDateTime);
                File.SetCreationTime(myFile, newDateTime);
            } catch {
                continue;
            }
        }

        foreach (string myDirectory in directories){
        // Calling the SetLastAccessTime() function
        // to set last access date and time
            try {
                DateTime newDateTime = new DateTime(Now.Year, Now.Month, Now.Day, rand.Next(0, 23), rand.Next(0, 59), rand.Next(0, 59), rand.Next(0, 999));
                Directory.SetLastAccessTime(myDirectory, newDateTime);
                Directory.SetLastWriteTime(myDirectory, newDateTime);
                Directory.SetCreationTime(myDirectory, newDateTime);
            } catch {
                continue;
            }
        }

    }
}
