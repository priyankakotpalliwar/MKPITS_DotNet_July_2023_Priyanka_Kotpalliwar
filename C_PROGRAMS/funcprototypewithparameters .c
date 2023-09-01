#include<stdio.h>
void deposit(int amt,int bal);
void withdrawl(int amt,int bal);
void main()
{
	int amt,bal=1000;
	printf("enter the amount");
	scanf("%d",&amt);
	deposit(amt,bal);
	withdrawl(amt,bal);
}
void deposit(int amt,int bal)
{
	bal=bal+amt;
	printf("amount deposited ,bal=%d",bal);
	
}
void withdrawl(int amt,int bal)
{
	bal=bal-amt;
	printf("amount with,bal=%d",bal);
	
}
