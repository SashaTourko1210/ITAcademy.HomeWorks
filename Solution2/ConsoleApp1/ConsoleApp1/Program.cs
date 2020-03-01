using System;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //чтение файла
            //читаем до конца
            //разбиваем его
            //создаем массив
            //в цикле конвертируем
            //освобождаем память
            //сохраняем
            StreamReader textReader = new StreamReader(@"C:\Users\sasha\Downloads\image.txt", true);
            string textReaderResult = textReader.ReadToEnd();
            string[] arrayOfTextResult = textReaderResult.Split(' ');
            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];
            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;
            }
            textReader.Dispose();
            File.WriteAllBytes(@"C:\Users\sasha\Downloads\image.png", imageBytes);
        }
    }
}
