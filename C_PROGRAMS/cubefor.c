#include<stdio.h>
int main()
{
	int i;
	int num;
	int cube;
	printf("enter a number");
	scanf("%d",&num);
	for(i=1;i<=num;i++)
	{
		cube=i*i*i;
	
		printf("\n%d  is cube of %d",i,cube);
		
	}

}	
