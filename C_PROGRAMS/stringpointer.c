#include<stdio.h>
void main()
{
	char name[10];
	char *ptr;
	printf("enter the name\n");
	gets(name);
	ptr=name;
	while(*ptr!='\0');
	{
		printf("%c",*ptr);
		ptr++;
		
	}
}
