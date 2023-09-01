#include<stdio.h>
void main()
{
	int i;
	int sum=0;
	int marks[3];
	
	scanf("%d",marks[0]);
	scanf("%d",marks[1]);
	scanf("%d",marks[2]);
//	 
//	marks[0]=22;
//	marks[1]=33;
//	marks[2]=44;
	
	for(i=0;i<3;i++)
	{
		printf(" \n marks =%d ",marks[i]);
		sum=sum+marks[i];
	}
	printf("\nthe total marks is %d",sum);
}
