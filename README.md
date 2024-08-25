# Sistema de Controle de Estoque (Console)

Este é um simples sistema de controle de estoque desenvolvido em C#. O sistema permite gerenciar produtos, incluindo adicionar, listar, remover itens e controlar entradas e saídas de estoque.
Foi densevolvido com intuito para aprendizagem da linguagem C# e obetação de nota.
## Funcionalidades

- **Adicionar Item**: Permite adicionar novos produtos ao estoque.
- **Listar Itens**: Exibe todos os produtos cadastrados no estoque.
- **Buscar Item**: Busca um produto específico no estoque usando o índice.
- **Remover Item**: Remove um produto do estoque.
- **Entrada de Estoque**: Registra a entrada de novas unidades de um produto existente.
- **Saída de Estoque**: Registra a saída de unidades de um produto existente.

## Requisitos

- .NET 6.0 SDK ou superior

## Como Executar

1. Clone este repositório em sua máquina local:

   ```bash
   git clone https://github.com/seu-usuario/controle-estoque-console.git
   ```

2. Navegue até a pasta do projeto:

   ```bash
   cd controle-estoque-console
   ```

3. Compile o projeto:

   ```bash
   dotnet build
   ```

4. Execute o projeto:

   ```bash
   dotnet run
   ```

## Uso

Ao iniciar o sistema, você verá um menu com as seguintes opções:

1. **Adicionar Item**: Adiciona um novo produto ao estoque solicitando informações como nome, preço, tipo, descrição e fabricante.
2. **Listar Itens**: Exibe uma lista numerada de todos os produtos no estoque.
3. **Remover Item**: Solicita a posição do item a ser removido do estoque.
4. **Entrada de Estoque**: Solicita a posição do item e a quantidade de entrada no estoque.
5. **Saída de Estoque**: Solicita a posição do item e a quantidade de saída do estoque.
6. **Sair**: Encerra o programa.

### Exemplo de Uso

1. **Adicionar um Produto:**

   ```text
   Informe o Nome do Produto: Mouse
   Informe o Preço do Produto: 50.00
   Informe o Tipo do Produto: Periférico
   Informe a Descrição do Produto: Mouse óptico
   Informe a Fabricante do Produto: Logitech
   ```

2. **Listar Itens:**

   ```text
   1. Mouse - Periférico - Logitech - 50.00 - Mouse óptico - Quantidade: 0
   ```

3. **Remover um Produto:**

   ```text
   Informe a posição do item para remover do estoque: 1
   Deseja remover este item? (S/N): S
   ```

4. **Entrada de Estoque:**

   ```text
   Informe a posição do item para entrada de estoque: 1
   Informe a quantidade de entrada: 20
   ```

5. **Saída de Estoque:**

   ```text
   Informe a posição do item para saída de estoque: 1
   Informe a quantidade de saída: 5
   ```

## Estrutura do Código

- **GerenciadorEstoque.cs**: Classe principal que gerencia o estoque, contendo métodos para adicionar, listar, buscar, remover, entrada e saída de estoque.
- **ItemEstoque.cs**: Representa um item no estoque com propriedades como nome, preço, tipo, descrição, fabricante e quantidade.

## Melhorias Futuras

- Implementação de persistência de dados (armazenamento em arquivo ou banco de dados).
- Suporte para categorias de produtos.
- Interface gráfica para uma melhor experiência do usuário.

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para enviar pull requests e relatar problemas.

## Licença

Este projeto é licenciado sob a licença MIT. Veja o arquivo `LICENSE` para mais detalhes.

---
