## Tipos de Valores Nulos em .NET

> Resumo sobre valores nulos 📚

### O que é um Valor Nulo?

Na programação _null_ significa "nulo/nada ou algo sem valor".

> E esse conceito é muito bem aplicado no contexto de banco de dados ou em um contexto de serialização, ou desserialização onde possa existir um campo null. Por exemplo: uma tabela de banco de dados que possui uma coluna com um campo vazio. E para representar este valor no código é necessário fazer um tratamento.

### Como declarar uma variável nula?

> Simples! Para declarar uma variável que aceite um valor null é necessário pôr o sinal de `?` após a declaração do tipo da variável. ex: `bool? receberEmail = null;`. Isso faz com que a variável aceite o valor nulo.

* Acessando o valor nulo da variável

> Para acessar o valor de uma variável nula, utiliza-se a propriedade `HasValue` que verifica se a variável declarada possui valor, aceitando o `null`.

> [!NOTE]
> No código disposto acima, foi utilizado o Gerenciador de Pacotes [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json) para desserialização de um arquivo JSON.

## Referências
- [Tipos que permitem valor nulo](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/nullable-value-types)
- [Referências que permitem um valor nulo e tipos que não permitem valor nulo](https://learn.microsoft.com/pt-br/dotnet/csharp/tutorials/nullable-reference-types)
