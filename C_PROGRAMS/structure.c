#include<stdio.h>
struct book
{
	char title[100];
	char author[10];
	int bookid;
	
	
};
void main()
{
	struct book b1;
	strcpy(b1.title,"yolo");
	strcpy(b1.author,"priyanka");
	b1.bookid=2;
	printf("book title is %s",b1.title);
	printf("\n autor of book is %s",b1.author);
	printf("\n bookid is %d",b1.bookid);
	
}

