# OpenAI Competitive

[English](./README_EN.md)

OpenAI Competitive 是一个适用于 [STranslate](https://github.com/zggsong/STranslate) 的 OpenAI 兼容翻译插件。

它基于 STranslate 原项目内置 OpenAI 翻译插件的开发范式整理而来，面向 OpenAI 官方接口以及兼容 OpenAI API 格式的第三方模型服务。

## 功能特性

- 支持自定义供应商名称，便于在 STranslate 的服务列表和翻译浮窗中区分不同服务。
- 支持自定义 API URL 和 API Key。
- 支持手动填写模型名称。
- 支持通过当前 API URL 和 API Key 请求 `/v1/models` 获取模型列表。
- 获取模型成功后，可直接从下拉框选择服务端返回的模型。
- 保留 STranslate 原有提示词编辑、温度控制和连接校验能力。

## 适用场景

- 使用 OpenAI 官方接口。
- 使用兼容 OpenAI API 的第三方服务。
- 同时配置多个 OpenAI 兼容供应商，并希望在 STranslate 中用不同名称区分。

## 安装

1. 从 Release 下载 `.spkg` 文件。
2. 打开 STranslate。
3. 进入插件管理页面。
4. 选择本地 `.spkg` 文件安装。
5. 重启或刷新插件后，在翻译服务中添加 `OpenAI Competitive`。

## 使用说明

添加服务后，在插件设置页填写：

- 供应商名称：用于在 STranslate 服务列表和翻译浮窗中显示。
- API URL：OpenAI 或兼容服务的接口地址。
- API Key：访问服务所需的密钥。
- 模型：可手动输入，也可点击“获取模型”从 `/v1/models` 拉取。

如果服务商的 base URL 是：

```text
https://api.example.com
```

插件获取模型时会请求：

```text
https://api.example.com/v1/models
```

## 与 STranslate 的关系

本仓库只维护 OpenAI Competitive 插件。

STranslate 原项目地址：

https://github.com/zggsong/STranslate

感谢 STranslate 提供插件系统和内置 OpenAI 插件实现范式。
