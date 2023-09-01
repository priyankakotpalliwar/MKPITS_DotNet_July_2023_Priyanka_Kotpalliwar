#include<iostream>
using namespace std;
int main()
{
	int counter=2;
	int rem=0;
	int num;
	cout<<"enter the number";
	cin>>num;
	while(counter<num)
	{
		rem=num%counter;
		if(rem==0)
		
		{
			cout<<"it is prime number";
			break;
			
		}
		else;
		{
		
		counter=counter+1;
		cout<<"not prime number";
    	}
		
		
	}
	//cout<<"it is a prime number";
	return 0;
}
