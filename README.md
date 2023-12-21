# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de projeto

Neste desafio, o desenvolvedor tem a responsabilidade de conceber um sistema dedicado ao funcionamento de dispositivos celulares. A tarefa consiste em criar uma abstração para um celular, permitindo que diferentes marcas e modelos possuam comportamentos distintos. Isso viabilizará a reutilização de código e seguirá os princípios da orientação a objetos.

O objetivo é desenvolver um sistema em .NET, de natureza console, que mapeie uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. Para isso, será necessário criar as classes de acordo com o diagrama fornecido.

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
O código estava pela metade, e o que fiz foi dar continuidade obedecendo as regras descritas acima, completando as partes faltantes do código para que no final, obtivesse um programa funcional.
