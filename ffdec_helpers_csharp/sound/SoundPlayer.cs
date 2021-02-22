using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ffdec_helpers_csharp.sound
{
    public abstract class SoundPlayer
    {
        private FileStream fs;

        protected SoundPlayer(FileStream fs)
        {
            this.fs = fs;
        }

        public abstract long samplesCount();

        public abstract long getSamplePosition();

        public abstract void play();

        public abstract void stop();

        public abstract void skip(long samples);

        public abstract bool isPlaying();

        public abstract long getFrameRate();
    }
}
