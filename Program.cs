// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using APIExamples;


BookResponse? bookResponse = await BookApiCalls.GetBookInfoAsync("en_GB", 2, "100");
if (bookResponse != null)
{
    foreach(var data in bookResponse.Results)
    {
        Console.WriteLine($"Id :{data.Id}");
        Console.WriteLine($"Title : {data.Title}");
        Console.WriteLine($"Author : {data.Author}");
        Console.WriteLine($"Genre : {data.Genre}");
        Console.WriteLine($"Description : {data.Description}");
    }
}