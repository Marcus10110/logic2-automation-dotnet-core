// See https://aka.ms/new-console-template for more information
using Grpc.Net.Client;

namespace Logic2App
{
    class Program
    {
        static void Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("http://127.0.0.1:10430");
            var client = new Saleae.Automation.Manager.ManagerClient(channel);
            var reply = client.GetAppInfo(new Saleae.Automation.GetAppInfoRequest { });
            Console.WriteLine("Logic 2 App Version: " + reply.AppInfo.ApplicationVersion);
        }
    }
}