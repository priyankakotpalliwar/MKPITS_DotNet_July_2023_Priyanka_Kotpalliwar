#include<iostream>
using namespace std;
class person
{
	protected:
		string name;
		
	
};
class student:public person
{
	public:
		void putdata(string s)
		{
			name=s;
			
		}
		void displaydata()
		{
			cout<<"name"<<name;
			
		}
};
int main()
{
	student s1;
	s1.putdata("\namar ");
	s1.displaydata(); 
	
}
