#include<stdio.h>
void main()
{
	int sub1,sub2,sub3,total;
	float percen;
	printf("enter subject marks");
	scanf("%d %d %d",& sub1,&sub2,&sub3);
	total=sub1+sub2+sub3;
	percen=(total/300.0f)*100.0f;
	printf("total marks=%d",total);
    printf("\n percentage is %f",percen);
}
