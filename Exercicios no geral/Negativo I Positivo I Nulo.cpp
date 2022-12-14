#include <stdlib.h>
#include <stdio.h>

int numero;

void verifica (){
	
	if (numero > 0)
	  printf ("Este numero e positivo.");
	else if (numero < 0)
	  printf ("Este numero e negativo.");
	else 
	  printf ("Este numero e nulo.");	

}

int main () {
	
	printf("Digite algum numero: \n");
	scanf("%d", &numero);
	verifica ();
    system ("pause");
	return (0);
		
}
