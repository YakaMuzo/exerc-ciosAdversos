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
	printf("Digite o n�mero que deseja dividir (Dividendo): \n");
	scanf("%d", &dividendo);
	fflush(stdin);
	printf("Digite por quanto deseja dividir (Divisor): \n");
	scanf("%d", &divisor);
	quociente=dividendo/divisor;
	resto=dividendo%divisor;
	
	printf("O quociente da sua divis�o �: %d\n",quociente);
	fflush(stdin);
	printf("O resto  da sua divis�o �: %d\n",resto);
	fflush(stdin);
	
	printf("Ou seja, o quociente dos n�meros %d e %d � %d e o que resta dessa divis�o � %d.\n",dividendo,divisor,quociente,resto);

	system ("pause");
	return (0);	
	
}

