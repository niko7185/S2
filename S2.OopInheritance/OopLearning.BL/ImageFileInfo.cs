using System;
using System.Collections.Generic;
using System.Text;

namespace S2.OopInheritance.OopLearning.BL
{

    /// <summary>
    /// Initializes a new instans of the <see cref="ImageFileInfo"/> class with all the information about the file.
    /// Contains information about the with and height of the file
    /// Is inherited from <seealso cref="CustomFileInfo"/>
    /// </summary>

    public class ImageFileInfo : CustomFileInfo
    {

        private int width;
        private int height;

        protected int Width
        {
            get => width;

            set
            {
                if(value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(Width), "Width must be greater than 0");

                width = value;
            }
        }

        protected int Height
        {
            get => height;

            set
            {
                if(value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(Height), "Height must be greater than 0");

                height = value;
            }
        }

        public ImageFileInfo(string fileName, int fileSize, DateTime creationTime, int width, int height) : base(fileName, fileSize, creationTime)
        {

            Width = width;

            Height = height;

        }

        /// <summary>
        /// Checks whether or not the size of the file is above 45 MB or if the width and height are too large
        /// </summary>
        /// <returns></returns>
        public override bool IsSizeTooLarge()
        {

            if(Width > 1920 || Height > 1080 || FileSize > 45)
                return true;
            else
                return false;

        }

    }
}
