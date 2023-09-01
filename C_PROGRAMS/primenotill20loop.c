#include<stdio.h>
void main()
{
	int counter=2;
	int rem=0;
	int num=20;
	while(counter>num)
	{
		rem=counter%num;
		//num==counter;
		counter=counter+1;
		num=counter;
		printf(" \n %d",rem);
	
	
	}
}
