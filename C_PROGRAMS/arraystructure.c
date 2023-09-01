#include<stdio.h>
struct student
{
	//int rno;
	char name[100];
	int rno;
};
void main()
{
	struct student stud[5];
	int counter;
	for(counter=0;counter<5;counter++)
	{
		printf("\n enter the name and roll no.");
		scanf("%s",&stud[counter].name);
		scanf("%d",&stud[counter].rno);
		
	}
	printf("\n student details ");
	for (counter=0;counter<5;counter++)
	{
		//printf("\n student details ");
		printf("name =%s, roll no.=%d\n",stud[counter].name, stud[counter].rno);
	}
	
	
}
