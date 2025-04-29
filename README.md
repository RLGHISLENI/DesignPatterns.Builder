# Implementando o Padrão Builder em C#

Vamos falar sobre o **Padrão Builder**, um dos padrões de projeto (design patterns) mais úteis na programação orientada a objetos. 

## O que é o Padrão Builder?

O Builder é um padrão de projeto **criacional** que nos permite construir objetos complexos passo a passo. 
Ele separa a construção de um objeto complexo de sua representação, permitindo que o mesmo processo de construção possa criar diferentes representações.

### Quando usar o Builder?

- Quando um objeto tem muitos parâmetros opcionais

- Quando a construção do objeto é complexa

- Quando queremos que o objeto seja imutável após sua criação

- Quando queremos diferentes variações do mesmo tipo de objeto

### Vantagens desta Implementação

- **Clareza:** O código fica mais legível e expressivo

- **Imutabilidade:** O objeto Computador é imutável após construção (exceto pelas propriedades opcionais que deixamos com set)

- **Encadeamento:** Podemos encadear as chamadas dos métodos (Fluent Interface)

- **Validação:** Poderíamos adicionar validações no método Build()

## Boas Práticas e Dicas

**Validação:** Sempre valide os parâmetros no método Build()

**Imutabilidade:** Considere tornar todas as propriedades somente leitura

**Métodos obrigatórios:** Torne explícitos quais métodos são obrigatórios

**Documentação:** Documente seu Builder para facilitar o uso

### Melhorando o Builder - Padrão mais Avançado

Podemos tornar nosso Builder ainda mais robusto utlizando uma Interface e um Diretor (Opcional). 
Para cenários mais complexos, podemos adicionar um Diretor que sabe como construir certas configurações padrão.
Isso nos permitirá criar diferentes implementações de Builders para diferentes tipos de objetos.

### Explicação dos Componentes no Exemplo Avançado

**1. Interface `IComputadorAvancadoBuilder`:**

- Define o contrato que todas as implementações de Builder devem seguir

- Permite trocar a implementação do Builder se necessário

- Garante que todos os métodos necessários estejam disponíveis

**2. Classe `ComputadorAvancado` (Produto):**

- Todas as propriedades são readonly (imutáveis após construção)

- Construtor `internal` para **garantir que só o Builder possa criar instâncias**

- Método para exibir as configurações de forma organizada

**3. ComputadorAvancadoBuilder (Implementação concreta):**

- Implementa a interface `IComputadorAvancadoBuilder`

- Mantém o estado da construção até chamar `Build()`

- Retorna `this` para permitir `method chaining` (estilo fluente)

- Inclui validações no método `Build()`

**4. Classe `ComputadorDirector` (Opcional):**

- Encapsula lógica de construção para configurações comuns

- Pode ter vários métodos para diferentes tipos de computadores

- Ainda permite customizações adicionais após usar o diretor

### Vantagens desta Implementação Avançada

- **Flexibilidade:** Pode-se usar o Builder diretamente ou via Director

- **Validação:** Verifica regras de negócio durante a construção

- **Imutabilidade:** O objeto final é imutável

- **Extensibilidade:** Fácil adicionar novos componentes

- **Clareza:** Código de construção é legível e expressivo

- **Reuso:** O Director encapsula configurações comuns

### Possíveis Melhorias

- **Enum para componentes:** Usar enums para placas-mãe, processadores, etc.

- **Validações mais complexas:** Verificar compatibilidade entre componentes

- **Métodos de reset:** Para reusar o Builder para múltiplas construções

- **Padrão Step Builder:** Para construção ainda mais guiada

## Exercício Proposto

Para praticar, tente implementar um Builder para uma classe Pizza com as seguintes características:

- **Tamanho (obrigatório):** Pequena, Média, Grande

- **Massa (obrigatório):** Fina, Grossa

- **Ingredientes (opcionais):** Queijo, Pepperoni, Cogumelos, etc.

- **Borda (opcional):** Recheada, Normal

**Depois crie:**

1. Uma pizza Margherita (queijo e tomate)

2. Uma pizza Pepperoni com borda recheada

3. Uma pizza vegetariana grande

## Conclusão

O padrão Builder é extremamente útil para criar objetos complexos de forma clara e flexível. 
Em C#, podemos implementá-lo de várias formas, desde a mais simples até versões mais sofisticadas com interfaces e diretores.

**Lembre-se:** a prática leva à perfeição! 

Experimente modificar o exemplo e criar seus próprios Builders para diferentes cenários.
