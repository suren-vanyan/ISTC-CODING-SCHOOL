using System;
using System.Collections.Generic;
using System.Text;

namespace IPlayerApp
{
    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }
}
