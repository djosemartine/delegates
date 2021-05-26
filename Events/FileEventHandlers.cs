using System;

namespace Events
{
    public class FileEventHandlers
    {
        public event EventHandler<FileCreatedEventArgs> FileCreatedEventHandler;

        public void PublishFileCreated(object sender, FileCreatedEventArgs fileEvent)
        {
            FileCreatedEventHandler?.Invoke(sender, fileEvent);
        }
    }
}
