#include<stdio.h>
struct book
{
	char title[10];
	char author[100];
	int bookid;
};
void main()
{
	struct book b1;
	printf("enter title of the book");
	scanf("%s",b1.title);
	printf("enter author");
	scanf("\n %s",b1.author);
	b1.bookid=2563;
	printbook(b1);
}
void printbook(struct book b1)
{

	printf("here is your ordered book  %s with %s",b1.title,b1.author);
	printf("\n%d",b1.bookid);
}
