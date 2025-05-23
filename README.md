# Sistema de Controle de Gaveteiro Inteligente

## Visão Geral
Este projeto controla um gaveteiro inteligente (16 portas, 16 compartimentos/porta) remotamente via web. Um ESP32 gerencia a comunicação e comanda um Arduino Mega para o controle físico.

## Funcionalidades Chave
*   Abertura remota de portas/compartimentos.
*   Conexão Ethernet ou Wi-Fi (com configuração via AP).
*   Registro do dispositivo no backend.
*   Comunicação SPI entre ESP32 e Arduino.
*   Monitoramento de sensores de porta.

---

## Documentação Detalhada
*   [1. Visão Geral e Arquitetura](./docs/01-visao-geral-arquitetura.md)
*   [2. Componentes Principais](./docs/02-componentes.md)
*   [3. Operação e Configuração](./docs/03-operacao-configuracao.md)