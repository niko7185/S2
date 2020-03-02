using System;
using System.Collections.Generic;
using System.Text;

namespace S2.OopInheritance.OopLearning.BL
{

    /// <summary>
    /// Initializes a new instans of the <see cref="DocumentFileInfo"/> class with all the information about the file.
    /// Is inherited from <seealso cref="CustomFileInfo"/>
    /// </summary>

    public class DocumentFileInfo : CustomFileInfo
    {

        public DocumentFileInfo(string fileName, int fileSize, DateTime creationTime) : base(fileName, fileSize, creationTime)
        {

        }

    }
}
