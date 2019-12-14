using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VasyaLab3
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
  
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);

              

                string line;

                while((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { ' ' });

                    for (int i = 0; i < words.Length - 1; i += 2)
                    {
                        // Переставляем местами.
                        Console.Write(words[i + 1] + " " + words[i] + " ");
                    }

                    if (words.Length % 2 != 0)
                    {
                        Console.WriteLine(words[words.Length - 1]);

                    }
                }
               
            }
            else
            {
                Console.WriteLine("Произошла ошибка");
            }
            Console.Read();

        }
    }
}
