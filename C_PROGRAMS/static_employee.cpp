#include<iostream>
using namespace std;


class Employee
{
	public:
		int empno;
		string empname;
		static string company;
	Employee(int empno,string empname)
	{
	
		this->empno=empno;
		this->empname=empname;
	}
	void display()
	{
		cout<<"empno "<<empno<<endl;
		cout<<"empname "<<empname<<endl;
		cout<<"company name - "<<company<<endl;
	}
};
string Employee::company="supra";
int main()
{
	Employee E1=Employee(222,"hera");
	Employee E2=Employee(245,"supriya");
	E1.display();
	E2.display();
	return 0;
	
}
