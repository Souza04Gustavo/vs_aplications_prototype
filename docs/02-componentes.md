# 2. Componentes Principais

## Hardware
*   ESP32-ETH01
*   Arduino Mega 2560
*   Solenoides/travas (portas e compartimentos)
*   Sensores de porta
*   Display OLED (Arduino)

## Software (Bibliotecas Chave - ESP32)
*   `<WiFi.h>`, `<HTTPClient.h>`: Rede e API.
*   `<ArduinoJson.h>`: Manipulação de JSON.
*   `<SPI.h>`: Comunicação com Arduino.
*   `<LittleFS.h>`: Armazenamento de credenciais.
*   `<WebServer_WT32_ETH01.h>`: Servidor web para configuração.

## Software (Bibliotecas Chave - Arduino)
*   `<SPI.h>`: Comunicação com ESP32 (escravo).
*   `<U8g2lib.h>`: Display OLED.

---
[Voltar ao Início](../README.md)