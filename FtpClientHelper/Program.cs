using System;
using FtpClientHelper.Helper;

namespace FtpClientHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            TestFtpClientHelper();
        }

        static void TestFtpClientHelper()
        {
            var ftpClientHelper = new FtpClient("ftp://localhost", "testing", "");
            ftpClientHelper.Download("Download.txt", @"D:/LocalFTP_User/Download_" + Guid.NewGuid() + ".txt");
            ftpClientHelper.Upload("Upload_" + Guid.NewGuid() + ".txt", @"D:/LocalFTP_User/Upload.txt");
            ftpClientHelper.Delete("delete.txt");
            ftpClientHelper.GetFileSize("getFileSize.txt");
            ftpClientHelper.Rename("oldName.txt", "newName.txt");
            ftpClientHelper.CreateDirectory("testDir");
            ftpClientHelper.DeleteDir("testDir");
            var directoryListDetailed = ftpClientHelper.DirectoryListDetailed("helloworld");
            var DirectoryListSimple = ftpClientHelper.DirectoryListSimple("helloworld");
        }
    }
}
