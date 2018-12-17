using System;
using System.Collections.Generic;
using System.Text;

namespace IPlayerApp
{
    class Player : IPlayable, IRecodable
    {
       
        void IPlayable.Pause()
        {
            Console.WriteLine("Мusic Paused");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Recording Paused");
        }

        void IPlayable.Play()
        {
            Console.WriteLine("Music Started");
        }

        void IRecodable.Record()
        {
            Console.WriteLine("Recording is in progress");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Music Stopped");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Recording Paused");
        }
    }
}
