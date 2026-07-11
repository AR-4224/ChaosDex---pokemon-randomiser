using ChaosDex.Core.Models;
using ChaosDex.Core.Readers;
using ChaosDex.Core.Services;

Console.WriteLine("ChaosDex V0.1");

Console.WriteLine("Enter the ROM's file path:");
string path = Console.ReadLine();

Rom myRom = RomLoader.Load(path);
RomHeader myHeader = HeaderReader.ReadHeader(myRom);

Console.WriteLine("");
Console.WriteLine("ROM Loaded!");
Console.WriteLine("");
Console.WriteLine("Title:       : "+ myHeader.GameTitle);
Console.WriteLine("");
Console.WriteLine("Game Code    : " + myHeader.GameCode);
Console.WriteLine("");
Console.WriteLine("Maker Code   : " + myHeader.MakerCode);
Console.WriteLine("");
Console.WriteLine("Version      : " + myHeader.Version);