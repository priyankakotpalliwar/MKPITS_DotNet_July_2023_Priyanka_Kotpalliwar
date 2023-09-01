#include<iostream>
using namespace std;
int main()
{
	int arr[5];
	int i,cnt=0;
	int j;
	
	for(i=0;i<5;i++)
	
	{
		cout<<"enter the number ";
		cin>>arr[i];
	}
	for(i=0;i<5;i++)
	{
	
		for(j=i+1;j<5;j++)
		{
			if(arr[i]==arr[j])
			{
				cnt++;
				break;
			}
		}
//	cout<<"\n no of duplicate number"<<cnt;
		
	}
		cout<<"\n no of duplicate number"<<cnt;
}
