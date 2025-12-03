import os
import requests

api_key = os.getenv("MYAPI_API_KEY")
if not api_key:
    print("Please set MYAPI_API_KEY environment variable.")
    exit(1)

url = "https://api.myapi.rest/api/shorturl/generate"
payload = {
    "long_url": "https://jenturner.studio",
    "expires_at": "2026-11-15T10:01:57.102Z"
}
headers = {
    "Authorization": f"Bearer {api_key}",
    "Content-Type": "application/json"
}

response = requests.post(url, json=payload, headers=headers)
print(response.status_code, response.text)
