#include<stdio.h>
void main()
{
	char name[20];
	char*ptr;
	int cnt;
	printf("enter stringg:");
	gets(name);
	ptr=name;
	while(*ptr !='\0')
	{
		cnt=cnt+1;
		*ptr++;
		
	}
	printf("count of string is %d",cnt);
}
