#include<stdio.h>
void addition(int n1,int n2)
{
	int result=n1+n2;
	printf("addition of two no.=%d",result);
}
void main()
{
	int num1;
	int num2;
	printf("enter the number");
	scanf("%d%d",&num1,&num2);
	addition(num1,num2);
	printf("\n bye");
}
