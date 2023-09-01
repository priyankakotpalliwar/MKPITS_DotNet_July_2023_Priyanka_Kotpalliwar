#include<stdio.h>
int main()
{
	int num;
	printf("enter the no.");
	scanf("%d",&num);
	if(num<0)
	{
		printf("the number is negative");
	}
	else if(num==0)
	{
		printf("the number is equal to zero");
		
	}
	else
	{
		printf("the number is positivve");
	}
	return 0;
	
}
