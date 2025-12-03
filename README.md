[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![Website](https://img.shields.io/badge/site-myapi.rest-0EA5E9)](https://myapi.rest)
[![Discussions](https://img.shields.io/badge/discussions-join-2563EB)](https://github.com/myapi-rest/myapi.rest/discussions)
[![myapi.rest Suite](https://img.shields.io/badge/myapi.rest-API%20Suite-0F766E)](https://github.com/myapi-rest)

# myapi.rest — Short URL API

A fast, secure API to generate branded short URLs with optional expiry and click webhooks.  
This service powers `https://grc.pw` and is part of the **myapi.rest** API suite.

---

## 🚀 Quick Start

Generate a short URL from a long URL:

```bash
curl --location 'https://api.myapi.rest/api/shorturl/generate' \
  --header 'Content-Type: application/json' \
  --header 'Authorization: Bearer <API_KEY>' \
  --data '{
    "long_url": "https://jenturner.studio",
    "expires_at": "2026-11-15T10:01:57.102Z"
  }'
```
```bash
Sample response:
{
  "shorturl": "https://grc.pw/Z7hye8b"
}
```
Replace <API_KEY> with your myapi.rest API key from the dashboard.
