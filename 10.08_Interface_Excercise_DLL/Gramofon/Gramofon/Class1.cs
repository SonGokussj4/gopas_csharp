using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerLibrary
{
    public class Gramofon : IPlayer
    {
        string[] songs;
        int idx = 0;

        public void InsertDesku(params string[] songs)
        {
            this.songs = songs;
        }

        public bool Next()
        {
            if (this.idx < this.songs.Length - 1)
            {
                this.idx++;
                this.Play();
                return true;
            }
            return false;
        }

        public string Play()
        {
            return this.songs[this.idx];
        }
    }
}
