#include<stdio.h>
int calculation(int r,float *a,float *c)
{
	*a=r*3.14f*r;
	*c=2*3.14*r;
	
	
}
int main()
{
	int radius;
	float area,circ;
	
	printf("enter the radius");
	scanf("%d",&radius);
	calculation(radius,&area,&circ);
	printf(" area of the circle %f",area);
	printf("\ncircumference of the circle %f",circ);
}
