using System;
namespace BackUpServerAPI.Interfaces
{
    public interface IUndoableCommand
    {
        void Execute();
        void Undo();
    }
}
