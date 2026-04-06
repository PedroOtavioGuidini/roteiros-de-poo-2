# Exercícios de Testes de Integração

**1. Para que servem os testes de integração?**

Servem para garantir que todos os componentes do sistema funcionem de forma correta e segura em conjunto, assegurando que o sistema se comporte conforme o esperado.

---

**2. Qual a principal diferença entre teste unitário e teste de integração?**

O teste unitário verifica uma parte isolada do sistema, enquanto o teste de integração verifica o funcionamento conjunto entre dois ou mais componentes.

---

**3. Os testes de integração precisam ser automatizados?**

Não. Os testes de integração também podem ser realizados de forma manual, especialmente quando se deseja analisar componentes específicos com mais atenção.

---

**4. Por que os testes de integração são importantes?**

Porque permitem verificar se os componentes do sistema estão funcionando em harmonia. Além disso, possibilitam a automação do processo, tornando o sistema mais seguro e eficiente.

---

**5. Quais os principais problemas que podem ser encontrados nos testes de integração?**

- **Perda de dados:** pode ocorrer por falhas na transmissão, erros no código ou problemas no sistema.
- **Resultados divergentes:** geralmente originados por erros na comunicação entre componentes, uso de dados incorretos ou falhas no processamento das informações.

---

**6. Qual é o processo de um teste de integração?**

1. Identificar quais módulos do sistema serão integrados.
2. Definir os cenários de teste, ou seja, o que será verificado entre essas partes.
3. Criar os casos de teste com os dados de entrada e os resultados esperados.
4. Executar os testes para observar como os módulos funcionam juntos.
5. Validar os resultados, comparando com o que era esperado.
6. Documentar tudo, registrando os testes realizados e os possíveis erros encontrados.

---

**7. Qual a diferença entre integração vertical e integração horizontal?**

- **Integração vertical:** testa a comunicação entre camadas do sistema (ex: `Controller → Service → Repository`).
- **Integração horizontal:** testa a comunicação entre módulos no mesmo nível (ex: um `Service` se comunicando com outro `Service`).

---

**8. Um teste que passa pela Controller, Service e banco de dados é de qual tipo?**

É uma integração vertical, pois envolve múltiplas camadas do sistema até chegar ao banco de dados.

---

**9. O que é integração de interfaces?**

É quando se testa se uma classe está implementando corretamente uma interface, ou seja, se está respeitando o contrato definido por ela.

---

**10. Por que os testes de integração tendem a ser mais lentos que os unitários?**

Porque envolvem várias partes do sistema funcionando juntas, podendo utilizar banco de dados, APIs e outros recursos externos, o que naturalmente torna a execução mais demorada.

---

**11. Um teste entre dois serviços internos do sistema é de qual tipo? Quando deixaria de ser?**

a) Integração horizontal (ou de serviços).  
b) Deixaria de ser integração horizontal se passasse a envolver um sistema externo, tornando-se, nesse caso, uma integração de sistemas.

---

**12. Um teste que consome uma API externa é de qual tipo?**

Integração de sistemas, pois envolve comunicação com um recurso externo ao sistema.

---

**13. O que é teste de regressão?**

É um tipo de teste que garante que alterações no código não quebraram funcionalidades que já estavam funcionando anteriormente.

---

**14. Testar se uma classe implementa corretamente uma interface é de qual tipo?**

Integração de interfaces, pois verifica se a implementação está de acordo com o contrato definido pela interface.

---

**15. Por que não se deve usar apenas testes de integração?**

Porque são mais lentos e complexos. Nem tudo precisa ser testado em conjunto — os testes unitários ajudam a validar partes menores de forma muito mais rápida.

---

**16. O que pode ocorrer mesmo que cada módulo funcione corretamente de forma isolada?**

Podem ocorrer erros na comunicação entre os módulos quando eles passam a funcionar juntos.

---

**17. Por que integração de serviços não é o mesmo que integração de sistemas?**

Porque integração de serviços é um caso específico dentro da integração de sistemas. Sistemas podem envolver outros elementos além de serviços, tornando o escopo mais amplo.

---

**18. Em um sistema de e-commerce com fluxo interno e API de pagamento externa, quais tipos de integração estão presentes?**

Integração vertical (fluxo interno entre camadas) e integração de sistemas (comunicação com a API externa de pagamento).

---

**19. Qual a diferença entre dependências mockadas e dependências reais?**

- **Dependências mockadas:** são simuladas, utilizadas principalmente em testes unitários para isolar o componente testado.
- **Dependências reais:** são usadas de verdade (banco de dados, APIs), sendo comuns em testes de integração, tornando o teste mais próximo do ambiente de produção.

---

**20. Quais as vantagens da automação nos testes de integração?**

Execução mais rápida, redução de erros humanos e facilidade de repetir os testes sempre que necessário.

---

**21. Os testes de integração substituem os testes unitários?**

Não. Somente os testes de integração não garantem que cada parte do sistema funciona de forma isolada. É fundamental ter testes unitários também.

---

**22. Por que é arriscado depender de uma API externa nos testes?**

Porque a API externa pode estar fora do ar, lenta ou retornando erros, mesmo que o sistema em si esteja funcionando corretamente.

---

**23. Qual a relação entre arquitetura de software e testes de integração?**

Uma arquitetura bem organizada facilita a criação dos testes, pois torna mais claro como cada parte se relaciona, permitindo testar as integrações de forma mais eficiente.

---

**24. Testes de integração substituem testes unitários?**

Não, eles se complementam. Os testes unitários verificam partes isoladas do sistema, enquanto os de integração verificam o funcionamento do conjunto.

---

**25. Qual o maior desafio dos testes de integração?**

Lidar com dependências externas e garantir que todos os componentes funcionem juntos sem erros.
