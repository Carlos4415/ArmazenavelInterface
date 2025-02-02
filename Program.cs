/*
    Este programa demonstra o uso de interfaces em C# para simular o armazenamento e recuperação de dados.
    A interface IArmazenavel define os métodos Salvar e Recuperar, que são implementados nas classes Arquivo e BancoDeDados.
    Cada classe fornece uma implementação específica dos métodos, simulando o processo de salvar e recuperar dados
    em um arquivo e em um banco de dados. O objetivo é ilustrar o uso de interfaces para promover flexibilidade e
    reutilização de código, permitindo a substituição de diferentes formas de armazenamento de dados em uma aplicação.
*/

using ArmazenavelInterface;

Arquivo arquivo = new();
arquivo.NomeArquivo = "dados.txt";

Console.WriteLine("Arquivo:");
arquivo.Recuperar();
arquivo.Salvar();

BancoDeDados bancoDeDados = new();
bancoDeDados.NomeBanco = "banco_de_dados_example";

Console.WriteLine("\nBanco de Dados:");
bancoDeDados.Recuperar();
bancoDeDados.Salvar();