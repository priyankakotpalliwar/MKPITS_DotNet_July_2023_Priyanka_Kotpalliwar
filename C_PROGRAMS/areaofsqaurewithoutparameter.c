#include<stdio.h>
int square()
{
	int area;
	int num;
	//Area= a*a;
	printf("enter the side of area");
	scanf("%d",&num);
	area= num*num;
	return area;
}
void main()
{
	int area;
	area=square();
	printf("the area of square is %d",area);
	
}
