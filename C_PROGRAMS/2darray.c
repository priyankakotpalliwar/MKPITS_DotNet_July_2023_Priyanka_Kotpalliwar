#include<stdio.h>
void main()
{
	int arr[3][3];
	int row ,col;
	for(row=0;row<3;row++)
	{
		for(col=0;col<3;col++)
		{
			printf("\n enter the number");
			scanf("%d",&arr[row][col]);
		}
	}
	for(row=0;row<3;row++)
	{
		for(col=0;col<3;col++)
		{
			printf("%d",arr[row][col]);
			
			
		}
		printf("\n");
	}
}
