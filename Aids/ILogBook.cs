using System;

namespace SportClub.Aids {
    public interface ILogBook {
        void WriteEntry(string message);
        void WriteEntry(Exception e);
    }
}