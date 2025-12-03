# Quickstart --- Short URL API

This guide shows how to generate your first short URL using
**myapi.rest**.

------------------------------------------------------------------------

## 1. Get your API key

1.  Sign in to the myapi.rest dashboard.
2.  Create or copy an existing API key.
3.  Store it securely (e.g. as an environment variable).

Example (Linux/macOS):

``` bash
export MYAPI_API_KEY="YOUR_API_KEY_HERE"
```

Example (Windows PowerShell):

``` powershell
$env:MYAPI_API_KEY = "YOUR_API_KEY_HERE"
```

------------------------------------------------------------------------

## 2. Create a short URL with curl

``` bash
curl --location 'https://api.myapi.rest/api/shorturl/generate'   --header 'Content-Type: application/json'   --header 'Authorization: Bearer <API_KEY>'   --data '{
    "long_url": "https://jenturner.studio",
    "expires_at": "2026-11-15T10:01:57.102Z"
  }'
```

**Sample response:**

``` json
{
  "shorturl": "https://grc.pw/Z7hye8b"
}
```

------------------------------------------------------------------------

## 3. Use a language SDK / example

Check the [`examples/`](../examples) folder for ready-to-run examples
in:

-   C#
-   JavaScript (Node)
-   Python
-   PHP

Each example reads your API key from the `MYAPI_API_KEY` environment
variable and prints the API response.

------------------------------------------------------------------------

## 4. Next steps

-   Configure **webhooks** to receive click events\
-   Store your short URLs and map them to your own entities\
-   Embed links into emails, SMS, WhatsApp, QR codes, etc.

More details:

-   [Endpoints](./endpoints.md)\
-   [Webhooks](./webhooks.md)\
-   [Errors](./errors.md)
