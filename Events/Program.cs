using System;
using System.Threading.Tasks;

namespace Events
{
    static class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Events");
            var fileEventHandlers = new FileEventHandlers();
            var fileCreator = new FileCreator(fileEventHandlers);
            await fileCreator.CreateAsync("init-file.txt", "Initiating app..");
            fileEventHandlers.FileCreatedEventHandler += (object sender, FileCreatedEventArgs e) => Console.WriteLine($"File Created in Path {e.Path}");
            fileEventHandlers.FileCreatedEventHandler += FileEventHandlers_FileCreatedEventHandler;
            await fileCreator.CreateAsync("text.txt", "Hello World!");
            await fileCreator.CreateAsync("file.txt", "Hello World from File!");
        }

        private static void FileEventHandlers_FileCreatedEventHandler(object sender, FileCreatedEventArgs e)
        {
            Console.WriteLine(sender);
        }
    }
}
