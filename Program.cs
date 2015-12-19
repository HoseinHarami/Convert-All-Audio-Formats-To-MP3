using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Lame;
using System.IO;
using NAudio.Wave;

//It's a simple program that uses NAudio and NAudio.Lame libraries

namespace My_MP3_Compressor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input audio address (like : E://Music.wav)");
            string inputFile = Console.ReadLine();
            Console.WriteLine("Enter outpot address (like : E://Music.mp3)");
            string outpotAddress = Console.ReadLine();
            Converter converter = new Converter();
            byte[] MP3Bytes = converter.ConvertToMp3(inputFile);
            File.WriteAllBytes(outpotAddress, MP3Bytes);
        }
    }
}
