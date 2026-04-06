using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

class Program
{
    static void Main()
    {
        var lista = new ListaProdutos
        {
            Produtos = new List<Produto>
            {
                new Produto { Nome = "Headset",    Preco = 199.90 },
                new Produto { Nome = "Teclado Mecânico", Preco = 349.90 },
                new Produto { Nome = "Mouse\"",   Preco = 1299.90 }
            }
        };

        string caminho = "produtos.xml";

        XmlSerializer serializer = new XmlSerializer(typeof(ListaProdutos));
        using (StreamWriter writer = new StreamWriter(caminho))
        {
            serializer.Serialize(writer, lista);
        }

       
        string conteudo = File.ReadAllText(caminho);
        Console.WriteLine(conteudo);
    }
}