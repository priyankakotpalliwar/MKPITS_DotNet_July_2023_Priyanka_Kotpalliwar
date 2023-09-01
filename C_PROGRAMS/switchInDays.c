#include<stdio.h>
void main()
{
	int day_no;
	printf("enter day no");
	scanf("%d",&day_no);
	switch(day_no)
	{
		case 1:
			printf("the day is monday");
			break;
		case 2:
			printf("tuesday mornin");
			break;
		case 3:
			printf("wednesday night");
			break;
		default:
			printf("not valid");
			break;
			
	}
}
