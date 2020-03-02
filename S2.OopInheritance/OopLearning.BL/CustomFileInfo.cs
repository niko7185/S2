using System;
using System.Collections.Generic;
using System.Text;

namespace S2.OopInheritance.OopLearning.BL
{
    class CustomFileInfo
    {

        private string fileName;
        private int fileSize;
        private DateTime creationTime;

        protected string FileName
        {
            get => fileName;

            set
            {

                if(string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(nameof(FileName), "File name cannot be empty");

                fileName = value;
            }
        }

        protected int FileSize
        {
            get => fileSize;

            set
            {

                if(value > 0)
                    throw new ArgumentOutOfRangeException(nameof(FileSize), "File size must be higher than 0");

                fileSize = value;
            }
        }

        protected DateTime CreationTime
        {
            get => creationTime;

            set
            {

                if(value > DateTime.Now)
                    throw new ArgumentOutOfRangeException(nameof(CreationTime), "Creation time cannot be in the futrue");

                creationTime = value;
            }
        }

        protected CustomFileInfo(string fileName, int fileSize, DateTime creationTime)
        {

            FileName = fileName;

            FileSize = fileSize;

            CreationTime = creationTime;

        }

        public override string ToString()
        {
            return FileName;
        }

    }
}
