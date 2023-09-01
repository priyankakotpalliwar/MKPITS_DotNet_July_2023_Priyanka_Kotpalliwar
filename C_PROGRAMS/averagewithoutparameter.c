#include<stdio.h>
int average()
{
	float num1,num2,num3,num4,num5;
	float add;
	float result;
	printf("enter the 5 no. to calculate the average");
	scanf("%f%f%f%f%f",&num1,&num2,&num3,&num4,&num5);
	add=num1+num2+num3+num4+num5;
	printf("the addition of no. is%f",add);
	result=add/5;
	return result;
	
}
void main()
{
	float result;
	
	result=average();
	printf("the average of 5 number is %f",result);
}
