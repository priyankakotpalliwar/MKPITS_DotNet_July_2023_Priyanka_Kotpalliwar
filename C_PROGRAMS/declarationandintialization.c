#include<stdio.h>
int main()
{
	int i;
	int sum=0;
	int marks[3]={10,20,30};
	for(i=0;i<3;i++)
	{
		printf("\nmarks= %d",marks[i]);
		sum=sum+marks[i];
	}
	printf("\ntotal marks=%d",sum);
}
