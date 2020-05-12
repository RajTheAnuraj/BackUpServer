using System;
namespace BackUpServerAPI.Interfaces
{
    public interface IStore
    {
        bool CreateDirectory(string path);
        bool DirectoryExists(string path);
        bool RemoveDirectory(string path);
        bool RemoveDirectoryWithForce(string path);

    }
}
