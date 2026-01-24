using System;
using System.Collections.Generic;
using System.Text;

namespace Stream
{
    internal class ImageByteArray
    {
        static void Main()
        {
            byte[] imageBytes = File.ReadAllBytes("input.jpg");

            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                File.WriteAllBytes("output.jpg", ms.ToArray());
            }

            Console.WriteLine("Image conversion successful.");
        }
    }

}
