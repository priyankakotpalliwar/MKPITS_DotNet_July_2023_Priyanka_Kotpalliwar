#include<iostream>
using namespace std;
class Employee
{
	public:
		string employeename;
		string designation;
		int employeeno;
		int salary;
		void getdetails()
		{
			cout<<"enter employee name  designation employeeno salay"<<endl;
			cin>>employeename>>employeeno>>designation>>salary;	
		
		}
		void displaydetails()
		{
			cout<<"employee name"<<employeename;
			cout<<"employeeno."<<employeeno;
			cout<<"designation"<<designation;
			cout<<"salary of the employee"<<salary;
		}
		
};
int main()
{
	Employee e1;
	e1.getdetails();
	e1.displaydetails();
}
