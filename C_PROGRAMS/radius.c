#include<stdio.h>
void main()
{
	int radius;
	float area,circ;
	printf("enter a number");
	scanf("%d",&radius);
	area=3.14f*radius*radius;
	circ=2*3.14f*radius;
	printf("area =%f",area);
	printf("\ncirc=%f",circ);
}
