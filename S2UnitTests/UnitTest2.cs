using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using S2.OopInheritance.OopLearning.BL;

namespace S2.UnitTesting
{
    public class UnitTest2
    {

        [Fact]
        public void FileInfo()
        {

            DocumentFileInfo fileInfo = new DocumentFileInfo("testfile", 46, new DateTime(2020, 03, 01));



            Assert.True(fileInfo.IsSizeTooLarge());

        }

        [Fact]
        public void VideoFileInfo()
        {

            VideoFileInfo videoFile = new VideoFileInfo("testfile", 44, new DateTime(2020, 03, 01), 1920, 1080, 60);
            var x = videoFile.FileSize;

            Assert.True(videoFile.IsSizeTooLarge());

        }

    }
}
