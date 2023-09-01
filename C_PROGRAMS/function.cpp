#include<iostream>
using namespace std;
void deposit(int amt,int bal);
void withdrawl(int amt,int bal);
int main()
{
	int amt,bal=1000;
	cout<<"enter the amount";
	cin>>amt;
	deposit(amt,bal);
	withdrawl(amt,bal);
	
}
void deposit(int amt,int bal)
{
	bal=bal+amt;
	cout<<"\n amount deposited"<<bal;
	
}
void withdrawl(int amt,int bal)
{
	bal=bal-amt;
	cout<<" \n amount withdrawl"<<bal;
}
