using System;
using BackUpServerAPI.Interfaces;

namespace BackUpServerAPI.Commands.FileSystem
{
    public class CreateDirectory: IUndoableCommand
    {
        private readonly IStore store;

        public CreateDirectory(IStore Store)
        {
            store = Store;
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
