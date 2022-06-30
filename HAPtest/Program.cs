// See https://aka.ms/new-console-template for more information

// This is a very basic example

using HtmlAgilityPack;

HtmlWeb web = new HtmlWeb(); // we can use this object to load the page
HtmlDocument document = web.Load("https://example.com/");

// we can ge the Title by hetting th h1
var title = document.DocumentNode.SelectNodes("//div/h1").First().InnerText;
var description = document.DocumentNode.SelectNodes("//div/p").First().InnerText;

Console.WriteLine(title);
Console.WriteLine();
Console.WriteLine(description);

Console.ReadLine(); 


