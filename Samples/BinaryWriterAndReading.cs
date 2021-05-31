using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Samples
{
    class BinaryWriterAndReading
    {
       

        static void Main(string[] args)
        {
            string path = @"D:\SamplesonFiles\another\sam.txt";
            // FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            /* BinaryWriter br = new BinaryWriter(fs);
             br.Write(123);
             br.Write("sampath");
             br.Write("Missing");
             br.Flush();
             br.Close();*/
            /*  using (BinaryReader br=new BinaryReader(fs))
               {
                   Console.WriteLine(br.ReadInt32());
                   Console.WriteLine(br.ReadString());
                   Console.WriteLine(br.ReadString());
               }
               */
           FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
          /*  BinaryWriter br1 = new BinaryWriter(fs);
            br1.Write(123);
            br1.Write("m");
            br1.Write("start");
            br1.Flush();
            br1.Close();*/

           using (BinaryReader br2=new BinaryReader(fs))
            {
                Console.WriteLine(br2.ReadInt32());
                Console.WriteLine(br2.ReadString());
                Console.WriteLine(br2.ReadString());
            }
            
            
            
        }
    }
}
