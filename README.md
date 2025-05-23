# Sistema de Controle de Gaveteiro Inteligente

## Visão Geral
Este projeto controla um gaveteiro inteligente (16 portas, 16 compartimentos/porta) remotamente via web. Um ESP32 gerencia a comunicação e comanda um Arduino Mega para o controle físico.

## Funcionalidades Chave
*   Abertura remota de portas/compartimentos.
*   Conexão Ethernet ou Wi-Fi (com configuração via AP).
*   Registro do dispositivo no backend.
*   Comunicação SPI entre ESP32 e Arduino.
*   Monitoramento de sensores de porta.


## Planilha


<p>A planilha abaixo é interativa e pode ser rolada:</p>

<iframe src="https://docs.google.com/spreadsheets/d/e/2PACX-1vS7ztB25fEQCpBAENChTXUzVHI5VO_87PDvmnz8HwPExWxyJEmypBygY17J2e2FshhTQV_4VCZMQVP5/pubhtml?widget=true&headers=false" width="100%" height="600"></iframe>



---

## Documentação Detalhada

<details>
<summary><strong>1. Visão Geral e Arquitetura</strong> (Clique para expandir)</summary>

### Arquitetura do Sistema
O sistema é composto por três camadas principais:
1.  **Aplicação Web:** Interface do usuário e backend para gerenciar requisições.
2.  **ESP32-ETH01:** Conecta-se à rede (Ethernet/Wi-Fi), comunica-se com o backend (API) e com o Arduino (SPI).
3.  **Arduino Mega:** Recebe comandos SPI, controla travas das gavetas/compartimentos e lê sensores.

### Diagrama do Fluxo
![Fluxo de Interações do Sistema](./media/fluxograma_sistema.png)
*(Certifique-se que a pasta 'media' está na raiz e contém a imagem)*

</details>

<details>
<summary><strong>2. Componentes Principais</strong> (Clique para expandir)</summary>

### Hardware
*   ESP32-ETH01
*   Arduino Mega 2560
*   Solenoides/travas (portas e compartimentos)
*   Sensores de porta
*   Display OLED (Arduino)

### Software (Bibliotecas Chave - ESP32)
*   `<WiFi.h>`, `<HTTPClient.h>`: Rede e API.
*   `<ArduinoJson.h>`: Manipulação de JSON.
*   `<SPI.h>`: Comunicação com Arduino.
*   `<LittleFS.h>`: Armazenamento de credenciais.
*   `<WebServer_WT32_ETH01.h>`: Servidor web para configuração.

### Software (Bibliotecas Chave - Arduino)
*   `<SPI.h>`: Comunicação com ESP32 (escravo).
*   `<U8g2lib.h>`: Display OLED.

</details>

<details>
<summary><strong>3. Operação e Configuração</strong> (Clique para expandir)</summary>

### Fluxo de Operação Simplificado
1.  **Inicialização:**
    *   Arduino inicializa SPI (escravo).
    *   ESP32 inicializa SPI (mestre), conecta à rede (Ethernet ou Wi-Fi configurável).
    *   ESP32 registra-se no servidor backend ou carrega credenciais salvas.
2.  **Ciclo Principal (ESP32):**
    *   Consulta o backend por comandos de abertura.
    *   Se houver comandos:
        *   Comunica via SPI ao Arduino a porta e compartimentos a abrir.
        *   Verifica status dos sensores (via Arduino).
        *   Se seguro, Arduino aciona as travas.
        *   Informa ao backend sobre abertura e posterior fechamento.

### Configuração Chave (ESP32)
*   URLs do servidor e token de homologação no código.
*   `modo_teste_wifi`:
    *   `1`: Credenciais Wi-Fi fixas.
    *   `0`: Modo Access Point para configuração Wi-Fi pelo usuário.

### Configuração Chave (Arduino)
*   Pino `networkSelect` (Pin 40): Define se o ESP32 deve priorizar Ethernet ou Wi-Fi.

</details>
