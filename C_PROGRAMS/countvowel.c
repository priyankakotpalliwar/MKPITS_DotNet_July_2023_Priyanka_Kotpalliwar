#include<stdio.h>
#include<string.h>
void main()
{
	char name[10];
	int cnt;
	char*ptr;
	printf("enter the name\n");
	gets(name);
	ptr=name;
	while (*ptr !='\0')
	{
		if(*ptr=='a' || *ptr=='e' || *ptr=='i' || *ptr=='o' || *ptr=='u')
		{
			cnt=cnt+1;
		}
		ptr++;
		
	}
	printf("\n%d",cnt);
	
	
}
