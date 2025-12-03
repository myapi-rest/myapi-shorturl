<?php

$apiKey = getenv('MYAPI_API_KEY');
if (!$apiKey) {
    die("Please set MYAPI_API_KEY environment variable.\n");
}

$ch = curl_init('https://api.myapi.rest/api/shorturl/generate');
$data = [
    'long_url'   => 'https://jenturner.studio',
    'expires_at' => '2026-11-15T10:01:57.102Z',
];

curl_setopt_array($ch, [
    CURLOPT_RETURNTRANSFER => true,
    CURLOPT_POST           => true,
    CURLOPT_HTTPHEADER     => [
        'Content-Type: application/json',
        'Authorization: Bearer ' . $apiKey,
    ],
    CURLOPT_POSTFIELDS     => json_encode($data),
]);

$response = curl_exec($ch);
$httpCode = curl_getinfo($ch, CURLINFO_HTTP_CODE);
curl_close($ch);

echo "HTTP $httpCode\n$response\n";
