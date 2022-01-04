using Leo.Extensions;

int i = 13508;
Console.WriteLine(i.GetBytes().GetHexString());
Console.WriteLine(i.GetBytes().GetBase64String());
Console.WriteLine(i.GetBytes().GetInt());


Console.WriteLine(i.GetBytes().GetHexString());
Console.WriteLine(i.GetBytes().GetHexString().FromHexString().GetInt());

Console.WriteLine("Hello, World!");
