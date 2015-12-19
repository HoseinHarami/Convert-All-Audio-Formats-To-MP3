using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using NAudio.Lame;
using System.IO;

namespace My_MP3_Compressor
{
    class Converter
    {
        //It's a simple function that uses NAudio.Wave and Naudio.Lame libraries for converting audio formats to mp3
        public byte[] ConvertToMp3(string File)
        {
            using (var returnMS = new MemoryStream())
            using (var reader = new NAudio.Wave.AudioFileReader(File))
            using (var writer = new LameMP3FileWriter(returnMS, reader.WaveFormat, 128))
            {
                reader.CopyTo(writer);
                return returnMS.ToArray();
            }
        }
    }
}
