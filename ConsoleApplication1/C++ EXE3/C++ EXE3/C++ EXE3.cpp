// Autor  : Walid Marghata 
#include<stdio.h>
#include<stdlib.h>

int main() {
	int id, qt;
	float val = 0;

	printf("[-------LANCHONETE-------]");
	printf("\n");
	printf("\n [1] Cachorro Quente R$ 4.00");
	printf("\n [2] X-Salada R$ 4.50");
	printf("\n [3] X-Bacon R$ 5.00");
	printf("\n [4] Torrada Simples R$ 2.00");
	printf("\n [5] Refrigerante 1.50\n");
	printf("\nDigite o codigo e o valor da quantidade:\n");
	scanf("%d %d", &id, &qt);
	if (id == 1)
		val = qt * 4.00;
	if (id == 2)
		val = qt * 4.50;
	if (id == 3)
		val = qt * 5.00;
	if (id == 4)
		val = qt * 2.00;
	if (id == 5)
		val = qt * 1.50;
	printf("\nTOTAL: R$%.2f\n", val);
	system("pause");
	return 0;
}