using System;
using System.IO;

namespace Events
{
    public class FileCreatedEventArgs : EventArgs
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Path { get; set; }
        public FileInfo FileInfo => new FileInfo(Path);
    }
}