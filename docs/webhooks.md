You can configure a Click Event Webhook URL in your myapi.rest dashboard.
Whenever a short URL is clicked, we’ll POST a JSON payload to your webhook.

Sample Click Event Webhook Payload:

```bash
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
