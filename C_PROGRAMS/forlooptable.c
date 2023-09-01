#include<stdio.h>
int main()

{
	int num;
	int counter;
	int result=0;
	printf("enter the number");
	scanf("%d",&num);
	for(counter=1;counter<=10;counter++)
	{
		result=num*counter;
		printf("\n%d*%d=%d",num,counter,result);
	}
}
