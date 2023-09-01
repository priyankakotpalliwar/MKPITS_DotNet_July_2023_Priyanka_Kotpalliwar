#include<stdio.h>
void main()
{
	int i;
	int n;
	int num[100];
	printf("enter the number");
	scanf("%d",&n);
	for(i=0;i<n;i++)
	{
		printf("\nenter marks");
		scanf("%d",&num[i]);
		
	}
	for(i=n-1;i>=0;i--)
	{
		printf("\n num=%d",num[i]);
	}
	
}
