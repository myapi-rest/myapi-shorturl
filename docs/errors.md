# Errors --- Short URL API

The API uses standard HTTP status codes.\
Error responses typically return JSON with an `error` field.

### Example

``` json
{
  "error": "Invalid long_url"
}
```

------------------------------------------------------------------------

## 400 --- Bad Request

Common causes: - Missing required fields\
- Invalid `long_url`\
- Invalid `expires_at` format

------------------------------------------------------------------------

## 401 --- Unauthorized

Your `Authorization` header is missing or the key is invalid.

------------------------------------------------------------------------

## 403 --- Forbidden

Your key does not have permission to perform this action.

------------------------------------------------------------------------

## 404 --- Not Found

The requested endpoint or resource does not exist.

------------------------------------------------------------------------

## 429 --- Too Many Requests

You exceeded your rate limit or quota.

------------------------------------------------------------------------

## 500 --- Internal Server Error

A server-side error occurred. If this persists, contact support.
