#! "netcoreapp2.1"

using System.Net.Http;

var client = new HttpClient();
var ip = await client.GetStringAsync("https://api.ipify.org");
Console.WriteLine($"My IP is: {ip}");

