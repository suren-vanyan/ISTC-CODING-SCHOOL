using System;

namespace IPlayerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            IPlayable playable = player;
            IRecodable recodable = player as IRecodable;
            playable.Play();
            playable.Pause();
            recodable.Record();

        }
    }
}
