using System;

namespace Homework5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Image Data Address. : ");
            string InputFile = Console.ReadLine();
            // C:\Users\milky\Desktop\newinput.txt


            Console.Write("Input Convolution Kernel Address. : ");
            string DataFileConvolutionKernel = Console.ReadLine();
            // C:\Users\milky\Desktop\newconvolution.txt


            Console.Write("Output Address. : ");
            string DataFileOutput = Console.ReadLine();
            // C:\Users\milky\Desktop\newoutput.txt


            Console.WriteLine("InputFile");
            double[,] imageDataInputFile = ReadImageDataFromFile(InputFile);

            Console.WriteLine("DataFileConvolutionKernel");

            double[,] imageDataConvolution = ReadImageDataFromFile(DataFileConvolutionKernel);

            double[,] imageDataArray = new double[5, 5];

            WriteImageDataToFile(DataFileOutput, imageDataArray);
            Console.WriteLine("Convolve");


            for (int i = -1; i <= 5; i++)
            {
                int newi = (i + 5) % 5;
                for (int j = -1; j <= 5; j++)
                {
                    int newj = (j + 5) % 5;
                    Console.Write("{0}   ", imageDataInputFile[newi, newj]);
                }
                Console.WriteLine();
            }

        }

        static double[,] ReadImageDataFromFile(string imageDataFilePath)
        {
            string[] lines = System.IO.File.ReadAllLines(imageDataFilePath);
            int imageHeight = lines.Length;
            int imageWidth = lines[0].Split(',').Length;
            double[,] imageDataArray = new double[imageHeight, imageWidth];

            for (int i = 0; i < imageHeight; i++)
            {
                string[] items = lines[i].Split(',');
                for (int j = 0; j < imageWidth; j++)
                {
                    imageDataArray[i, j] = double.Parse(items[j]);
                    Console.Write(" " + imageDataArray[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("imageDataArray : " + imageDataArray);

            return imageDataArray;
        }
        static void WriteImageDataToFile(string imageDataFilePath, double[,] imageDataArray)
        {


            string imageDataString = "";
            for (int i = 0; i < imageDataArray.GetLength(0); i++)
            {
                for (int j = 0; j < imageDataArray.GetLength(1) - 1; j++)
                {

                    imageDataString += imageDataArray[i, j] + ", ";

                }
                imageDataString += imageDataArray[i, imageDataArray.GetLength(1) - 1];
                imageDataString += "\n";

            }
            System.IO.File.WriteAllText(imageDataFilePath, imageDataString);
        }
    }
}

