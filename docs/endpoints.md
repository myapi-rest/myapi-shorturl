# Endpoints --- Short URL API

Base URL:

    https://api.myapi.rest

All endpoints require: - `Authorization: Bearer <API_KEY>` -
`Content-Type: application/json` for JSON bodies

------------------------------------------------------------------------

## POST `/api/shorturl/generate`

Generate a new short URL.

### Request

**Method:** POST\
**Path:** `/api/shorturl/generate`

**Headers:** - `Authorization: Bearer <API_KEY>` -
`Content-Type: application/json`

### Body

``` json
{
  "long_url": "https://jenturner.studio",
  "expires_at": "2026-11-15T10:01:57.102Z"
}
```

### Request Body Fields

| Field       | Type   | Required | Description                              |
|-------------|--------|----------|------------------------------------------|
| long_url    | string | Yes      | The target URL to shorten.               |
| expires_at  | string | No       | Optional ISO 8601 UTC expiry timestamp.  |


### Response (200 OK)

``` json
{
  "shorturl": "https://grc.pw/Z7hye8b"
}
```

  Field      Type     Description
  ---------- -------- --------------------------
  shorturl   string   The generated short URL.

### Error Codes

-   **400** --- Invalid or missing parameters\
-   **401** --- Missing/invalid API key\
-   **429** --- Rate limit exceeded\
-   **500** --- Internal server error

See the **Errors** document for more details.
