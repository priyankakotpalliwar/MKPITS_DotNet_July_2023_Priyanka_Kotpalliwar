#include<iostream>
using namespace std;
class Employee
{
	public:
		string employeename;
		int   employeeno;
		
	Employee()
	{
		employeename="priyanka";
		employeeno=33;
		
	}
	void display()
	{
		cout<<"employee name "<<employeename<<endl;
		cout<<"employee no."<<employeeno<<endl;
	}
	
};
int main()
{
	Employee e1;
	e1.display();
	return 0;
}
