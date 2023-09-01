#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		string city;
		
};
class student:public person
{
	public:
		int rno;
		int marks;
};
int main()
{
	student s1;
	s1.name="amit\n";
	s1.city="nagpur\n";
	s1.marks=58;
	s1.rno=135 ;
	cout<<s1.name<<s1.city<<s1.marks<<s1.rno<<endl;
	return 0;
}
