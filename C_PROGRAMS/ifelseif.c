#include<stdio.h>
int main()
{
	int n1,n2,n3;
	printf("enter the three no. ");
	scanf("%d%d%d",&n1,&n2,&n3);
	if(n1>n2 && n1>n3)
	{
		printf("n1 is greater %d",n1);
	}
	else if(n2>n3)
	{
		printf("the greater no. is n2");
	}
	else
	{
		printf("the greater is n3");
	}
	return 0;
}
