#include <stdlib.h>
#include <stdio.h>
#include <locale.h>
#include <math.h>

int dividendo;
int divisor;
int quociente;
int resto;

int main (){
	
    setlocale(LC_ALL, "Portuguese");
	printf("Digite o número que deseja dividir (Dividendo): \n");
	scanf("%d", &dividendo);
	fflush(stdin);
	printf("Digite por quanto deseja dividir (Divisor): \n");
	scanf("%d", &divisor);
	quociente=dividendo/divisor;
	resto=dividendo%divisor;
	
	printf("O quociente da sua divisão é: %d\n",quociente);
	fflush(stdin);
	printf("O resto  da sua divisão é: %d\n",resto);
	fflush(stdin);
	
	printf("Ou seja, o quociente dos números %d e %d é %d e o que resta dessa divisão é %d.\n",dividendo,divisor,quociente,resto);

	system ("pause");
	return (0);	
	
}

