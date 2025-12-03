using System.Net.Http.Headers;
using System.Net.Http.Json;

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

var response = await client.PostAsJsonAsync("/api/shorturl/generate", payload);
response.EnsureSuccessStatusCode();

var json = await response.Content.ReadAsStringAsync();
Console.WriteLine(json);
