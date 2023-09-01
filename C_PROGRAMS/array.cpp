#include<iostream>
using namespace std;
int main()
{
	int i;
	int arr1[5];
	int arr2[5];
	for(i=0;i<5;i++)
	{
		cout<<"enter the number";
		cin>>arr1[i];
		
	}
	for(i=0;i<5;i++)
	{
		arr2[i]=arr1[i];
		
		
	}
	cout<<"elemets of arr1";
	
	for(i=0;i<5;i++)
	{
		cout<<"\n "<<arr1[i];
	
	} 
	cout<<"elements of array 2";
	for(i=0;i<5;i++)
	{
		cout<<"\n "<<arr2[i];
	}
	return 0;
	
}
