//Problem 4. Download file

//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.


using System;
using System.IO;
using System.Net;



class DownloadFile
{
    static void Main()
    {
        //asks user for path
        string url = "http://telerikacademy.com/Content/Images/news-img01.png";
        string name = "Telerikninja.png";
        string path = Directory.GetCurrentDirectory();
        WebClient webClient = new WebClient();
        try
        {
            webClient.DownloadFile(url, name);

            Console.WriteLine("File successfully downloaded to {0}", path);
        }
        catch (NotSupportedException e)
        {

            Console.WriteLine(e.Message);

        }
        catch (WebException e)
        {

            Console.WriteLine(e.Message);

        }
        catch (ArgumentException e)
        {

            Console.WriteLine(e.Message);

        }
        catch (UnauthorizedAccessException e)
        {

            Console.WriteLine(e.Message);

        }
        finally
        {
            //frees used resources
            webClient.Dispose();
        }
    }
}

