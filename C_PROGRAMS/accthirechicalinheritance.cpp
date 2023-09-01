#include<iostream>
using namespace std;
class Account 
{
	public:
		int actno;
		int bal;
		int interest;
		void getdata(int a,int b,int c)
		{
			actno=a;
			bal=b;
			interest=c;
			
		}
};
class Saving:public Account
{
	public:
		//int interest;
		int depoist(int amt)
		{
			bal=bal+interest+amt;
			return bal;
			
		}
};
class current:public Account
{
	public:
		int deposit(int amt)
		{
			bal=bal+amt;
			return bal;
			
		}
};

int main()
{
	Saving s1;
	current c1;
	int result;
	int actno,bal,interest,amount;
	cout<<"enter account details"<<endl;
	cin>>actno>>bal>>interest>>amount;
	s1.getdata(amount,bal,interest);
	result=s1.depoist(amount);
	cout<<"saving bal"<<result<<endl;
	c1.getdata(actno,bal,interest);
	result=c1.deposit(amount);
	cout<<"current bal with a interest"<<result;
	return 0;
}
