#include<stdio.h>
void main()
{
	int num;
	int counter=1;
	int table;
	printf("enter the number");
	scanf("%d",&num);
	while(counter<=10)
	{
		table=num*counter;
		counter=counter+1;
	
		printf("\n%d*%d=%d",num,counter,table);
	}
}
