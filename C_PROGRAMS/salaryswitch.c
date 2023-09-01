#include<stdio.h>
void main()
{
	char name[20];
	char designation;
	int salary;
	printf("enter the emp name  \n");
	scanf("%s",&name);
	printf("enter designation (m,p,c)");
	fflush(stdin);
	scanf("%c",&designation);
	switch(designation)
	{
		case 'm':
			salary=50000;
			break;
		case 'c':
			salary=20000;
			break;
		case 'p':
			salary=10000;
			break;
		default:
			printf("not a member of office");
			break;
			
	}
	printf("employee=%s",name);
	printf("salary=%d",salary);
}
