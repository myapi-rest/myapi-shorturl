[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![Website](https://img.shields.io/badge/site-myapi.rest-0EA5E9)](https://myapi.rest)
[![Discussions](https://img.shields.io/badge/discussions-join-2563EB)](https://github.com/myapi-rest/myapi.rest/discussions)
[![myapi.rest Suite](https://img.shields.io/badge/myapi.rest-API%20Suite-0F766E)](https://github.com/myapi-rest)

# myapi.rest — Short URL API

Create fast, reliable short URLs through a simple REST API.

## Features
- Generate short links instantly  
- Optional expiry timestamps  
- Webhook support for click events  
- Developer-friendly and lightweight  

## Quick Example

```bash
curl --location 'https://api.myapi.rest/api/shorturl/generate'   --header 'Authorization: Bearer <API_KEY>'   --header 'Content-Type: application/json'   --data '{
    "long_url": "https://myapi.rest",
    "expires_at": "2026-12-01T10:00:00Z"
  }'
```

**Sample response:**

```json
{
  "shorturl": "https://grc.pw/Z7hye8b"
}
```

## Documentation
See the [`/docs`](./docs) folder for full usage guides, examples, errors, and endpoint details.

## Examples
Language examples are available in the [`/examples`](./examples) directory, including:
- C#
- JavaScript
- Python
- PHP
- Postman Collection

## myapi.rest Suite

This API is part of the broader **myapi.rest** developer suite.  
For all APIs, documentation, and examples, visit:

👉 https://github.com/myapi-rest/myapi.rest
