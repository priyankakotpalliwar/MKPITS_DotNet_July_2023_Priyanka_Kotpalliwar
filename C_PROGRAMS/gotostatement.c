#include<stdio.h>
int main()
{
	int num,i=1;
	printf("enter the no. for table");
	scanf("%d",&num);
	table:
		printf("\n%d*%d=%d",num,i,num*i);
		i++;
		if(i<=10)
		{
			goto table;
		}
}
