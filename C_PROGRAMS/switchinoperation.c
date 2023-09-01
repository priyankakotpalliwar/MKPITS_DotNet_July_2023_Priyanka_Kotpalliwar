#include<stdio.h>
void main()
{
	int num1,num2,result=0;
	char op;
	printf("enter the two number");
	scanf("%d%d",&num1,&num2);
	printf("enter the operator(+,-*,/)");
	//fflush(stdin);
	scanf("%c",&op);
	switch(op)
	{
		case '+':
			result=num1+num2;
			break;
		case '-':
			result=num1-num2;
			break;
		case '*':
			result=num1*num2;
			break;
		case '/':
			result=num1/num2;
			break;
		default:
			printf("invalild op");
			break;
			
	}
	printf("result=%d",result);
}
