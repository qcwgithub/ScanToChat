using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace ScanToChat.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new ScanToChat.App(), args);
            host.Run();
        }
    }
}
