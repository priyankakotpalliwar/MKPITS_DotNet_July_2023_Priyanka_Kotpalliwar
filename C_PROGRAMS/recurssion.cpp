#include<iostream>
using namespace std;
int myfunc(int x,int y)
{
	if(y<=0)
	{
		return 1;	
	}
	else
	{
		return x *(myfunc(x,y-1));
		
	}
}
int main()
{
	int res;
	res=myfunc(5,4);
	cout<<"res="<<res;
	return 0;
}
