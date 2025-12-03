# Webhooks --- Short URL Click Events

When someone clicks one of your short URLs, myapi.rest sends a webhook
event to your configured endpoint.

------------------------------------------------------------------------

## Event: `shorturl.click`

**Method:** `POST`\
**Content-Type:** `application/json`

### Sample Payload

``` json
{
  "occurredAt": "2025-12-01 06:11:08",
  "id": "18",
  "code": "KJPwJbu",
  "domain": "grc.pw",
  "ip": "105.245.231.156",
  "user_agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36",
  "referer": "",
  "accept_language": "en-ZA,en-GB;q=0.9,en-US;q=0.8,en;q=0.7"
}
```

### Field Reference

  Field             Type     Description
  ----------------- -------- ------------------------------------
  occurredAt        string   Timestamp of the click.
  id                string   Event identifier.
  code              string   The short code clicked.
  domain            string   Domain that served the short link.
  ip                string   IP address of the visitor.
  user_agent        string   User-Agent header.
  referer           string   Referring page (if any).
  accept_language   string   Browser language header.

------------------------------------------------------------------------

## Handling Webhooks

-   Respond with **2xx** to confirm receipt.\
-   Process asynchronously for reliability.\
-   Log errors for debugging.

A simple webhook handler can store click data, update analytics, or
trigger downstream workflows.
