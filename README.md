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
