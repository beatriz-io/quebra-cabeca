# quebra-cabeca

Quebra-cabeça

Em um quebra cabeças hipotético as peças são encaixadas lado a lado e contêm, cada uma, uma letra maiúscula.

Quando o quebra-cabeças estiver montado, a sequência de letras revelará uma frase. Cada peça possui, além da letra, dois números: um na parte esquerda e outro na parte direita. Uma peça se encaixa depois de outra, na sequência, quando seu número esquerdo for igual ao número direito da outra peça. O número esquerdo da primeira peça é sempre o 0 (zero) e o número direito da última peça é sempre o 1 (um). Cada número aparece no máximo uma vez na parte esquerda de alguma peça, e no máximo uma vez na parte direita.

Veja um exemplo na figura, com quatro peças formando a palavra "TEMA".

Entrada
A primeira linha da entrada contém um número natural N, indicando o número de peças do quebra-cabeças. As N linhas seguintes contêm, cada uma, a descrição de uma peça na forma E C D, onde: E é o número esquerdo; C é a letra maiúscula; e D é o número direito.
Saída
Seu programa deve escrever uma única linha na saída, contendo a sequência de letras formada quando o quebra-cabeças está montado.
Restrições
3 ≤ N ≤ 100000; 0 ≤ E ≤ 200000; e 0 ≤ D ≤ 200000
Há exatamente uma maneira de montar o quebra-cabeças utilizando todas as peças dadas.
Exemplos
Entrada
4
5 A 1
0 T 7
3 M 5
7 E 3
Saída
TEMA
	
Entrada
3
197452 I 1
0 O 39999
39999 B 197452
Saída
OBI
	
