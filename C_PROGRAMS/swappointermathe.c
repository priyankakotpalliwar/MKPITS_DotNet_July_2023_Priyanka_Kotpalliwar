#include<stdio.h>
void main()
{
	int n1=5;
	int n2=10;
	int *p1=&n1;
	int *p2=&n2;
	printf("the value  equal=%d %d",*p1, *p2);
	*p1=*p1+*p2;
	*p2=*p1-*p2;
	*p1=*p1-*p2;
	printf("after swap=%d %d",*p1,*p2);
}
