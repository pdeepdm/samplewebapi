// See https://aka.ms/new-console-template for more information
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;

Console.WriteLine("Hello, World!");

WebHost.CreateDefaultBuilder()
    .UseKestrel()
    .ConfigureServices(services => { services.AddMvc(); })
    .Configure(config => { config.UseMvc(); })
    .UseUrls("http://*:5000")
    .Build()
    .Run();
Console.ReadLine();