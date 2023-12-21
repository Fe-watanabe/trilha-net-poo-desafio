# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de projeto

Neste desafio o desenvolvedor é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que o desenvolvedor fizesse uma abstração de um celular e disponibilizasse maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

O desenvolvedor precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Para isso, deve-se criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
O código estava pela metade, e o que fiz foi dar continuidade obedecendo as regras descritas acima, completando as partes faltantes do código para que no final, obtivesse um programa funcional.
