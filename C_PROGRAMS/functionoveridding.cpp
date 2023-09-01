#include<iostream>
using namespace std;
class Account
{
	public:
		int actno;
		int bal;
		void deposit(int amt)
		{
			cout<<"hello from account deposit"<<endl;
			
		}
};
class saving:public Account
{
	public:
		void deposit(int amt)
		{
			int interest=500;
			bal=bal+amt+interest;
			cout<<"bal withn interest"<<bal<<endl;
			
		}
};
class current:public Account
{
	public:
		void deposit(int amt)
		{
			bal=bal+amt;
			cout<<"bal without int"<<bal<<endl;
			
		}
};
int main()
{
	Account*act;
	saving s;
	
	current c;
	act=&s;
	act->actno=123;
	s.bal=2000;
	s.deposit(100);
//	current c;
	c.actno=333;
	c.bal=2000;
	c.deposit(200);
	return 0;
}
