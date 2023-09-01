#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		int mobileno;
	void getpersonaldata(string n,int m)
	{
		name=n;
		mobileno=m;
	}
		
};
class Employee: public person
{
		
	public:
		int empno;
		int salary;
		void getemployeedata(int e,int s)
		{
			empno=e;
			salary=s;
		}
		void displaydata()
		{
			cout<<"name "<<name<<endl;
				
			cout<<"mobileno "<<mobileno<<endl;
			cout<<"empno "<<empno<<endl;
				
			cout<<"salary "<<salary<<endl;
		
				
		}
};
int main()
{
	Employee emp;
	cout<<"enter employee details \t mobile no. \t employee name \t & salary"<<emp.mobileno<<emp.name<<emp.salary;
	cin>>emp.mobileno>>emp.name>>emp.salary;
	emp.getpersonaldata(emp.name,emp.mobileno);
	emp.getemployeedata(emp.empno,emp.salary);
	emp.displaydata();
	return 0;
}

