# 1. Visão Geral e Arquitetura

Este sistema permite o controle remoto de um gaveteiro. A interação ocorre entre uma Aplicação Web, um ESP32 (comunicação) e um Arduino Mega (controle de hardware).

## Arquitetura
1.  **Aplicação Web:** Interface do usuário e backend para gerenciar requisições.
2.  **ESP32-ETH01:** Conecta-se à rede (Ethernet/Wi-Fi), comunica-se com o backend (API) e com o Arduino (SPI).
3.  **Arduino Mega:** Recebe comandos SPI, controla travas das gavetas/compartimentos e lê sensores.

### Diagrama do Fluxo
![Fluxo de Interações do Sistema](../../media/fluxograma_sistema.png)
*(Certifique-se que o caminho para a imagem está correto)*

---
[Voltar ao Início](../README.md)