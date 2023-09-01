#include<stdio.h>
void main()
{
	char ch;
	printf("enter the charc \n");
	scanf("%c",&ch);
	switch(ch)
	{
		
		case 'a':
		case 'i':
		case 'o':
		case 'u':
			
			printf("%c is the vowel",ch);
			break;
		default:
			printf("%c is not a vowel",ch);
			break;
	}
}
