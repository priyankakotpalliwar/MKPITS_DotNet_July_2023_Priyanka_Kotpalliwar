//check odd or even
#include<iostream>
using namespace std;
void checknumber();
int main()
{
	int num;

	cout<<"enter the number";
	cin>>num;
	checknumber();
	
}
void checknumber()
{
	int num;
	if(num%2==0)
	{
		cout<<"it is  the even number";
	}
	else 
	{
		cout<<"it is a odd no";
	}	
	
	
}

