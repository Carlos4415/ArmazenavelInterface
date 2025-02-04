# ArmazenavelInterface

Este programa demonstra o uso de **interfaces** em **C#** para simular o armazenamento e recuperação de dados.

A interface `IArmazenavel` define dois métodos principais: **Salvar** e **Recuperar**, que são implementados por duas classes diferentes:

- **Arquivo**: Representa o armazenamento de dados em arquivos.
- **BancoDeDados**: Representa o armazenamento de dados em um banco de dados.

Cada uma dessas classes fornece uma implementação específica dos métodos `Salvar` e `Recuperar`, simulando o processo de salvar e recuperar dados de diferentes fontes. O objetivo deste programa é ilustrar como interfaces podem ser usadas para promover flexibilidade e reutilização de código, permitindo que diferentes formas de armazenamento de dados sejam facilmente substituídas em uma aplicação.

## Funcionalidades

- **Interface IArmazenavel**: Define os métodos `Salvar` e `Recuperar` que devem ser implementados por qualquer classe que deseje oferecer armazenamento e recuperação de dados.
- **Classe Arquivo**: Implementa os métodos `Salvar` e `Recuperar` para simular o armazenamento de dados em arquivos.
- **Classe BancoDeDados**: Implementa os métodos `Salvar` e `Recuperar` para simular o armazenamento de dados em um banco de dados.

## Como Usar

1. **Clone o repositório** para o seu ambiente local:
   ```bash
   git clone https://github.com/Carlos4415/ArmazenavelInterface.git
