#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		int mobileno;
};
class Employee:public person
{
	public:
		int empno;
		int salary;
};
class parttimeemployee:public Employee
{
	public:
		int hours;
};
int main()
{
	Employee e1;
	e1.name="priyanka";
	e1.mobileno=9823;
	e1.empno=33;
	e1.salary=15000;
	cout<<"employee details \n"<<endl;
	cout<<e1.name<<e1.mobileno<<e1.empno<<e1.salary<<endl;
	
	parttimeemployee p1;
	p1.name="huze n\";
	p1.mobileno=9834146770;
	p1.empno=33;
	p1.salary=6000;
	p1.hours=2;
	cout<<"part time employees \n"<<endl;
	
	cout<<p1.name<<p1.mobileno<<p1.empno<<p1.salary<<p1.hours<<endl;
	return 0;
	
}
