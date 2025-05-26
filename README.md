# vs_aplications_prototypes

Este repositório armazena protótipos de aplicações desenvolvidas com Microsoft Visual Studio, servindo como um espaço para testes e demonstrações de funcionalidades.

## Projetos

1.  **TesteCameraBasico:**
    *   Aplicação Visual Studio que captura imagens de câmeras e as envia via MQTT para outra aplicação conectada ao mesmo host (broker MQTT).

2.  **ClienteServidorFlask (Nome do Projeto VS a ser definido):**
    *   Aplicação Visual Studio que funciona como cliente para um servidor web Python/Flask.
    *   **Funcionalidades do Cliente VS:** Interage com o servidor para:
        *   Realizar upload de imagens.
        *   Realizar upload de arquivos G-Code.
        *   Controlar o estado de um "LED" virtual no servidor.
    *   **Servidor Python/Flask Associado:**
        *   Recebe e armazena arquivos de imagem e G-Code enviados pelo cliente.
        *   Gerencia o estado de um LED virtual (Ligado/Desligado).
        *   Fornece uma interface web básica para visualização e serve os arquivos enviados.