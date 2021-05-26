using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
    public class FileCreator
    {
        private readonly FileEventHandlers _fileEventHandlers;

        public FileCreator(FileEventHandlers fileEventHandlers)
        {
            _fileEventHandlers = fileEventHandlers ?? throw new ArgumentNullException(nameof(fileEventHandlers));
        }

        public async Task CreateAsync(string path, string content, CancellationToken cancellationToken = default)
        {
            await File.WriteAllTextAsync(path, content, cancellationToken);
            var fileCreatedEvent = new FileCreatedEventArgs
            {
                CreatedAt = DateTime.UtcNow,
                Id = Guid.NewGuid(),
                Path = path
            };
            var sender = new Sender
            {
                Name = "FileCreator"
            };
            _fileEventHandlers.PublishFileCreated(sender, fileCreatedEvent);
        }
    }
}
