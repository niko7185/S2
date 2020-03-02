using System;
using System.Collections.Generic;
using System.Text;

namespace S2.OopInheritance.OopLearning.BL
{
    class DocumentFileInfo : CustomFileInfo
    {

        public DocumentFileInfo(string fileName, int fileSize, DateTime creationTime) : base(fileName, fileSize, creationTime)
        {

        }

        public bool IsSizeTooLarge()
        {

            return FileSize > 45 ? true : false;

        }

    }
}
