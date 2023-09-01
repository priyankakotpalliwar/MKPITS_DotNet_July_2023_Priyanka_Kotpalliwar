#include<stdio.h>
int main()
{
	int a=4;
    int i;
	int j;
	int row=3;
	int k=0;
	for(i=1;i<=row;i++)
    {
    	for(j=1;j>0;j--)
    	{
    		printf("c");
    	}
    	for(k=1;k<=(2*i-1);k++)
    	{
    		printf("* ");
		}
		printf("\n");		
	}
}
