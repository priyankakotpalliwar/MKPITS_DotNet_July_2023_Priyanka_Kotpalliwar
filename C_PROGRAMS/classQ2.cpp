#include<iostream>
using namespace std;
class student
{
	public:
		int rollno;
		string name;
		string course;
		
		void getdata()
		{
			cout<<"enter the rollno,name,course"<<endl;
			cin>>rollno>>name>>course;
		}
		void displaydata()
		{
			cout<<"roll no of student   "<<rollno<<endl;
			cout<<"name of student   "<<name<<endl;
			cout<<"course is   "<<course;
		}
};
int main()
{
	student std1,std2;
	cout<<"student1"<<endl;
	std1.getdata();
	std1.displaydata();
	
	cout<<"student 2"<<endl;
	std2.getdata();
	std2.displaydata();
	
	return 0;
}
