const apiKey = process.env.MYAPI_API_KEY;

if (!apiKey) {
  console.error("Please set MYAPI_API_KEY environment variable.");
  process.exit(1);
}

async function createShortUrl() {
  const res = await fetch("https://api.myapi.rest/api/shorturl/generate", {
    method: "POST",
    headers: {
      "Authorization": `Bearer ${apiKey}`,
      "Content-Type": "application/json"
    },
    body: JSON.stringify({
      long_url: "https://jenturner.studio",
      expires_at: "2026-11-15T10:01:57.102Z"
    })
  });

  if (!res.ok) {
    console.error("Request failed:", res.status, await res.text());
    return;
  }

  const data = await res.json();
  console.log("Short URL:", data.shorturl);
}

createShortUrl().catch(console.error);
