#include<stdio.h>
int main()
{
	

	int num=5;
	int *ptr=&num;
	
	printf("address=%x\n");
	printf("value at address=%d ",*ptr);
}
