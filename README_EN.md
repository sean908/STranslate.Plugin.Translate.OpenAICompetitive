# OpenAI Competitive

[中文](./README.md)

OpenAI Competitive is an OpenAI-compatible translation plugin for [STranslate](https://github.com/zggsong/STranslate).

It is derived from the development pattern of STranslate's built-in OpenAI translation plugin and is designed for both the official OpenAI API and third-party providers that expose OpenAI-compatible APIs.

## Features

- Custom provider name, making it easier to distinguish services in the STranslate service list and translation popup.
- Custom API URL and API key.
- Manual model name input.
- Model discovery via `/v1/models` using the current API URL and API key.
- Server-returned models can be selected directly from the model dropdown.
- Keeps STranslate's existing prompt editor, temperature control, and connection validation workflow.

## Use Cases

- Use the official OpenAI API.
- Use third-party services compatible with the OpenAI API format.
- Configure multiple OpenAI-compatible providers and distinguish them by name in STranslate.

## Installation

1. Download the `.spkg` file from Releases.
2. Open STranslate.
3. Go to the plugin management page.
4. Install the local `.spkg` file.
5. Restart or refresh plugins, then add `OpenAI Competitive` as a translation service.

## Usage

After adding the service, configure the plugin settings:

- Provider name: Displayed in the STranslate service list and translation popup.
- API URL: Endpoint of OpenAI or an OpenAI-compatible provider.
- API Key: Credential required by the provider.
- Model: Enter manually or click "Fetch models" to retrieve models from `/v1/models`.

If the provider base URL is:

```text
https://api.example.com
```

The plugin will fetch models from:

```text
https://api.example.com/v1/models
```

## Relationship With STranslate

This repository only maintains the OpenAI Competitive plugin.

Original STranslate project:

https://github.com/zggsong/STranslate

Thanks to STranslate for providing the plugin system and the built-in OpenAI plugin implementation pattern.
