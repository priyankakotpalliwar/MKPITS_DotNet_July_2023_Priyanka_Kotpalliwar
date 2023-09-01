#include<stdio.h>
void main()
{
	int counter=2;
	int num;
	int rem=0;
	printf("enter a number");
	scanf("%d",&num);
	while(counter>num)
	{
		rem=num%counter;
	
	if(rem==0)
	{
	
		
		printf("not a prime no");
		break;
	
	}
		counter=counter+1;
		
	
	
	if(num==counter)
	{
	
	printf("this is a prime no.");
	}
}
}
