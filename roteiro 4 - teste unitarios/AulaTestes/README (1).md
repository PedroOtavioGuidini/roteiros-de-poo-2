# Exercício 0 – Identificar e Corrigir Erros em Testes Unitários

## Questão A

O problema está no valor que o teste considera como correto. Como a operação `Somar(2, 3)` produz 5, o `Assert.Equal` precisa comparar com 5 — usar 4 faz o teste falhar por razão errada, não porque o código tem bug.

```csharp
// Incorreto
Assert.Equal(4, resultado);

// Corrigido
[Fact]
public void Somar_DeveRetornar5()
{
    var calc = new Calculadora();
    var resultado = calc.Somar(2, 3);
    Assert.Equal(5, resultado);
}
```

---

## Questão B

A falha está na escolha dos argumentos passados para `Dividir`. Dividir 10 por 2 é uma operação perfeitamente válida, portanto nenhuma exceção será disparada. Para que um `DivideByZeroException` seja lançado, o divisor precisa obrigatoriamente ser zero.

```csharp
// Incorreto
Assert.Throws<DivideByZeroException>(() => calc.Dividir(10, 2));

// Corrigido
[Fact]
public void Dividir_DeveLancarExcecao()
{
    var calc = new Calculadora();
    Assert.Throws<DivideByZeroException>(() => calc.Dividir(10, 0));
}
```

---

## Questão C

O equívoco aqui é que o `Assert.Empty` recebe uma lista criada na hora, completamente independente do carrinho testado. Isso faz com que o objeto real nunca seja inspecionado — o teste passa ou falha sem relação alguma com o comportamento do `Carrinho`.

```csharp
// Incorreto
Assert.Empty(new List<Item> { new Item() });

// Corrigido
[Fact]
public void Carrinho_DeveEstarVazioAposLimpar()
{
    var carrinho = new Carrinho();
    carrinho.Adicionar(new Item { Nome = "Produto", Preco = 15 });
    carrinho.Limpar();
    Assert.Equal(0, carrinho.Quantidade());
}
```

---

## Questão D

O erro está na categoria esperada. Um IMC de 31 ultrapassa o limite de 30, o que o coloca na faixa de obesidade — não de peso normal. A string passada ao `Assert.Equal` precisa refletir a classificação correta conforme a tabela de IMC.

```csharp
// Incorreto
Assert.Equal("Peso normal", resultado);

// Corrigido
[Fact]
public void Classificar_DeveRetornarObesidade_QuandoIMCFor31()
{
    var calc = new CalculadoraIMC();
    var resultado = calc.Classificar(31);
    Assert.Equal("Obesidade", resultado);
}
```
