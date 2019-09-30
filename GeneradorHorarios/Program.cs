using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace GeneradorHorarios
{
    class Program
    {
        //itext
        //evopdf
        //github:public(clase)
        //       private(proyect)
        static void Main(string[] args)
        {
            
            PdfReader leer = new PdfReader("C:\\Users/windws10/Desktop/TOPICOS 2/GeneradorHorarios/Horarios Sistemas II-2019.pdf");
            string text = string.Empty;
            for (int i = 1; i <= leer.NumberOfPages; i++)
            {
                text += PdfTextExtractor.GetTextFromPage(leer, i);
            }
            // Console.WriteLine(text);
            string line = text.Split("\n");
            for(int i= 1;i<=line.Length; i++)
            {
                
                line += PdfTextExtractor.GetTextFromPage(leer, i);
                
            }
            Console.WriteLine(line);
            Console.ReadKey();

        }
    }
}
