using System;
using System.Collections.Generic;
using System.Text;

namespace S2.OopInheritance.OopLearning.BL
{
    public abstract class CustomFileInfo
    {

        protected string fileName;
        protected int fileSize;
        protected DateTime creationTime;

        public string FileName
        {
            get => fileName;

            set
            {

                if(string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(nameof(FileName), "File name cannot be empty");

                fileName = value;
            }
        }

        public int FileSize
        {
            get => fileSize;

            set
            {

                if(value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(FileSize), "File size must be higher than 0");

                fileSize = value;
            }
        }

        public DateTime CreationTime
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

        /// <summary>
        /// Checks whether or not the size of the file is above 45 MB
        /// </summary>
        /// <returns></returns>
        public virtual bool IsSizeTooLarge()
        {

            return FileSize > 45 ? true : false;

        }

        public override string ToString()
        {
            return FileName;
        }

    }
}
