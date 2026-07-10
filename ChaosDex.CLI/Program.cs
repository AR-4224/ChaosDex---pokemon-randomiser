using ChaosDex.Core.Models;
using ChaosDex.Core.Services;

Console.WriteLine("ChaosDex V0.1");

Console.WriteLine("Enter the ROM's file path:");
string path = Console.ReadLine();

Rom myRom = RomLoader.Load(path);

Console.WriteLine("");
Console.WriteLine("ROM Loaded!");
Console.WriteLine("");
Console.WriteLine("FileName:" + myRom.FileName);
Console.WriteLine("");
Console.WriteLine("Path:" + path);
Console.WriteLine("");
Console.WriteLine("Size:" + (myRom.Size / 1000000) + " MB");