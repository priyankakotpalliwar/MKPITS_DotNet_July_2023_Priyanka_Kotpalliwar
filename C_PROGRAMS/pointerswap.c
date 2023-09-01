#include<stdio.h>
void main()
{
	int num1= 10;
	int num2=20;
	int *p1=&num1;
	int  *p2=&num2;
	printf("value stored equal=%d %d ",*p1,*p2);
	
	
	int temp=*p1;
	*p1=*p2;
	
	*p2=temp;
	printf("value stored equal =%d %d",*p1,*p2);
	
}
