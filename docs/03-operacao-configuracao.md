# 3. Operação e Configuração

## Fluxo de Operação Simplificado
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

## Configuração Chave (ESP32)
*   URLs do servidor e token de homologação no código.
*   `modo_teste_wifi`:
    *   `1`: Credenciais Wi-Fi fixas.
    *   `0`: Modo Access Point para configuração Wi-Fi pelo usuário.

## Configuração Chave (Arduino)
*   Pino `networkSelect` (Pin 40): Define se o ESP32 deve priorizar Ethernet ou Wi-Fi.

---
[Voltar ao Início](../README.md)