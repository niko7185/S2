using System;
using System.Collections.Generic;
using System.Text;

namespace S2.OopInheritance.OopLearning.BL
{
    class ImageFileInfo : CustomFileInfo
    {

        private int width;
        private int height;

        protected int Width
        {
            get => width;

            set
            {
                if(value > 0)
                    throw new ArgumentOutOfRangeException(nameof(Width), "Width must be greater than 0");

                width = value;
            }
        }

        protected int Height
        {
            get => height;

            set
            {
                if(value > 0)
                    throw new ArgumentOutOfRangeException(nameof(Height), "Height must be greater than 0");

                height = value;
            }
        }

        public ImageFileInfo(string fileName, int fileSize, DateTime creationTime, int width, int height) : base(fileName, fileSize, creationTime)
        {

            Width = width;

            Height = height;

        }

        public bool IsSizeTooLarge()
        {

            if(Width > 1920 || Height > 1080 || FileSize > 45)
                return true;
            else
                return false;

        }

    }
}
