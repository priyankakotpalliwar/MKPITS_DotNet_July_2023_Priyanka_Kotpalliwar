#include<iostream>
using namespace std;
class Account
{
	public:
		int accno;
		int bal;
		static float roi;
	Account(int accno,int bal)
	{
		
	
		this->accno=accno;
		this->bal=bal;
	}
	void display()
	{
		cout<<"act no"<<accno<<endl;
		cout<<"bal"<<bal<<endl;
		cout<<"rate int"<<roi<<endl;
		
	}
};
float Account::roi=9.5f;
int main()
{
	Account A1=Account(123,3000);
	Account A2=Account(212,3000);
	A1.display();
	A2.display();
	return 0;
}
