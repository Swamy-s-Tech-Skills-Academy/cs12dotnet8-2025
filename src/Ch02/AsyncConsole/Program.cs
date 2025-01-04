ForegroundColor = ConsoleColor.DarkCyan;

using (var client = new HttpClient())
{
    // Start the asynchronous HTTP request
    Task<HttpResponseMessage> getTask = client.GetAsync("http://www.apple.com/");

    // Do some other work while waiting for the request
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"Doing some other work: {i}");
        await Task.Delay(500); // Simulate some work
    }

    // Now await the HTTP response
    HttpResponseMessage response = await getTask;

    if (response.IsSuccessStatusCode)
    {
        long contentLength = response.Content.Headers.ContentLength ?? -1;
        Console.WriteLine($"Apple's home page has {contentLength} bytes.");
    }
    else
    {
        Console.WriteLine($"Error: {response.StatusCode}");
    }
}

ResetColor();