using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;

namespace Stream
{
    internal class PipeCommunication
    {
        public static void Main()
        {
            using (AnonymousPipeServerStream server = new AnonymousPipeServerStream(PipeDirection.Out))
            using (AnonymousPipeClientStream client = new AnonymousPipeClientStream(PipeDirection.In, server.ClientSafePipeHandle))
            {
                Thread writer = new Thread(() =>
                {
                    byte[] msg = Encoding.UTF8.GetBytes("Hello from Writer Thread");
                    server.Write(msg, 0, msg.Length);
                    server.DisposeLocalCopyOfClientHandle();
                });

                Thread reader = new Thread(() =>
                {
                    byte[] buffer = new byte[256];
                    int bytesRead = client.Read(buffer, 0, buffer.Length);
                    Console.WriteLine(Encoding.UTF8.GetString(buffer, 0, bytesRead));
                });

                writer.Start();
                reader.Start();

                writer.Join();
                reader.Join();
            }
        }
    }
}
