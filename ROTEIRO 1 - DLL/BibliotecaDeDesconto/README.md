# 📦 BibliotecaDeDesconto

Biblioteca em C# (.NET) para cálculo de **descontos em produtos** e **valor de frete** com base em peso e distância.

---

## 🚀 Como usar

### 1. Pré-requisitos

- [.NET SDK 6.0+](https://dotnet.microsoft.com/download)

---

### 2. Adicionando a DLL ao seu projeto

Copie o arquivo `BibliotecaDeDesconto.dll` para a pasta do seu projeto e adicione a referência no arquivo `.csproj`:

```xml
<ItemGroup>
  <Reference Include="BibliotecaDeDesconto">
    <HintPath>BibliotecaDeDesconto.dll</HintPath>
  </Reference>
</ItemGroup>
```

---

### 3. Exemplo de uso

```csharp
using BibliotecaDeDesconto;

CalculadoraDesconto calc = new CalculadoraDesconto();

// Aplicar 10% de desconto em um produto de R$200,00
double valorFinal = calc.AplicarDesconto(200.00, 10);
Console.WriteLine("Valor com desconto: R$" + valorFinal);
// Saída: Valor com desconto: R$180,00

// Calcular frete para 3kg e 150km de distância
double frete = calc.CalcularFrete(3.0, 150.0);
Console.WriteLine("Frete: R$" + frete);
// Saída: Frete: R$7,80
```

---

## 📖 Referência da API

### `AplicarDesconto(double valor, double percentual)`

Aplica um percentual de desconto sobre um valor.

| Parâmetro   | Tipo     | Descrição                          |
|-------------|----------|------------------------------------|
| `valor`     | `double` | Valor original do produto          |
| `percentual`| `double` | Percentual de desconto (0 a 100)   |

**Retorno:** `double` — Valor final com desconto arredondado em 2 casas decimais.

**Exceções:**
- `ArgumentException` se o valor for negativo
- `ArgumentException` se o percentual estiver fora do intervalo 0–100

---

### `CalcularFrete(double peso, double distancia)`

Calcula o frete com base no peso e na distância.

**Fórmula:** `frete = (peso × 0.10) + (distância × 0.05)`

| Parâmetro   | Tipo     | Descrição               |
|-------------|----------|-------------------------|
| `peso`      | `double` | Peso do produto em kg   |
| `distancia` | `double` | Distância em km         |

**Retorno:** `double` — Valor do frete em reais arredondado em 2 casas decimais.

**Exceções:**
- `ArgumentException` se peso ou distância forem zero ou negativos

---

## 📂 Estrutura do repositório

```
BibliotecaDeDesconto/
│
├── src/
│   └── CalculadoraDesconto.cs   # Código-fonte da biblioteca
│
├── exemplo/
│   └── Program.cs               # Exemplo de uso com console
│
├── BibliotecaDeDesconto.dll     # DLL compilada pronta para uso
└── README.md                    # Esta documentação
```

---

## 🧪 Testando

Execute o projeto de exemplo na pasta `exemplo/`:

```bash
dotnet run
```

---

## 👨‍💻 Autor

Desenvolvido como projeto de aula — Disciplina de Programação Orientada a Objetos.
```
