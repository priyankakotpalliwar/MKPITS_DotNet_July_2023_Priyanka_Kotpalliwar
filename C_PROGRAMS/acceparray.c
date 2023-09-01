#include<stdio.h>
int main()
{
	int i;
	int sum=0;
	int marks[5];
	
	for(i=0;i<5;i++)
	{
		printf("enter the marks %d",marks[i]);
		scanf("%d",&marks[i]);
		
	}
	for(i=0;i<5;i++)
	{
	
		printf(" marks =%d",marks[i]);
		sum=sum+marks[i];
	}
	printf("\nthe total marks is %d",sum);
}
