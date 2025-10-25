# FastFoxVpn.cs
Mobile-API for [FastFox VPN](https://play.google.com/store/apps/details?id=com.fastfoxvpn) application which is an ultimate solution for your online privacy and security needs

## Example
```cs
using System;
using FastFoxVpnApi;
using System.Threading.Tasks;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new FastFoxVpn();
            string servers = await api.GetServers("uuid");
            Console.WriteLine(servers);
        }
    }
}
```
