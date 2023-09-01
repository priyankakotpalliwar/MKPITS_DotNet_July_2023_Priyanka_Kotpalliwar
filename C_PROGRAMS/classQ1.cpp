#include<iostream>
using namespace std;
class car
{
	public:
		
		string name;
		string model;
		int year;
		

	void startengine()
	
	{
		cout<<"engine started"<<endl;
	
	}
	void brake()
	{
		cout<<"brake applied"<<endl;
	
	}
};
int main()
{
	car c1 ;
	c1.startengine();
	//c1.startengine();
	c1.name="THAR";
	c1.model="mahidra";
	c1.year=2023;
	cout<<c1.name<<endl;
	cout<<c1.model<<endl;
	cout<<c1.year<<endl;
	c1.brake();
	return 0;
	
}
