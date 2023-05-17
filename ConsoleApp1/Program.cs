// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Entities;

Console.WriteLine("Hello, World!");


DbStorage dbStorage = new DbStorage();
 var lst =from a in   dbStorage.people.ToList()
          where a.Name .StartsWith("a")
          select a;