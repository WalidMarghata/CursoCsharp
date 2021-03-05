// Este programa calcula as raizes reais de // uma equacao do segundo grau
#include<stdio.h>
int main(void) {
	// declaracao de variavel 
	float A, B, C;
	float delta, x1, x2;
	printf("Entre com os coeficientes da equaçao\n");
	// leitura dos dados
	scanf("%f %f %f", &A, &B, &C); // %d inteiro %f real %c char %s string 
   // calculo do discriminante
	delta = B * B - 4. * A * C;
	// Teste do discriminante
	if (delta >= 0) {
		// calculo das raizes 
		x1 = (-B + sqrt(delta)) / (2. * A);
		x2 = (-B - sqrt(delta)) / (2. * A);
		printf("A equacao dada e: %f X^2 + %f X + %f\n", A, B, C);
		printf("As raizes reais sao: 1a. raiz = %f 2a.raiz= %f\n", x1, x2);
	}
	else {
		printf("Nao existem raizes reais");
	}
	getch();
} // fim do programa
