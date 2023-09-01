#include<stdio.h>
int addition()
{
	int n1;
	int n2,result;
	printf("enter the number");
	scanf("%d %d",&n1,&n2);
	result=n1+n2;
	return result;
	
}
void main()
{
	char ch='y';
	do
	{
		int result;
		result=addition();
		printf("result=%d/n",result);
		printf("do yo want to continue ,'y'\n");
		fflush(stdin);
		scanf("%c",&ch);
	}
	while(ch== 'y');
}
