
---

## 🧪 `examples/` folder

### `examples/csharp/Program.cs`

```csharp
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var apiKey = Environment.GetEnvironmentVariable("MYAPI_API_KEY");
        if (string.IsNullOrWhiteSpace(apiKey))
        {
            Console.WriteLine("Please set MYAPI_API_KEY environment variable.");
            return;
        }

        using var client = new HttpClient
        {
            BaseAddress = new Uri("https://api.myapi.rest")
        };

        client.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", apiKey);

        var payload = new
        {
            long_url = "https://jenturner.studio",
            expires_at = "2026-11-15T10:01:57.102Z"
        };

        Console.WriteLine("Sending request...");

        var response = await client.PostAsJsonAsync("/api/shorturl/generate", payload);

        Console.WriteLine($"HTTP {(int)response.StatusCode} {response.StatusCode}");

        var body = await response.Content.ReadAsStringAsync();
        Console.WriteLine("Response body:");
        Console.WriteLine(body);
    }
}
