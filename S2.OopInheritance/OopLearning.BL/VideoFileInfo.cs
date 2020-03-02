using System;
using System.Collections.Generic;
using System.Text;

namespace S2.OopInheritance.OopLearning.BL
{
    class VideoFileInfo : ImageFileInfo
    {

        private int duration;

        public int Duration
        {
            get
            {
                return duration;
            }

            set
            {

                if(value > 0)
                    throw new ArgumentOutOfRangeException(nameof(Duration), "Duration must be greater than 0");

                duration = value;
            }
        }

        public VideoFileInfo(string fileName, int fileSize, DateTime creationTime, int width, int height, int duration) : base(fileName, fileSize, creationTime, width, height)
        {
            Duration = duration;
        }

        public override string ToString()
        {
            return "Video: " + FileName;
        }

    }
}
