#include<iostream>
using namespace std;
class shape
{
	public:
		int x;
		int y;
	void getdata(int a,int b)
	{
		x=a;
		y=b;
		
	}
};
class rectangle:public shape
{
	public:
		int crare()
		
		{
			int ra;
			ra=x*y;
			return ra;				
				
			
		}
};
class triangle:public shape
{
	public:
		float ctarea()
		{
			int ta;
			ta=0.5*x*y;
			return ta;
			
			
		}
};
int main()
{
   rectangle r;
   triangle t;
   int lenght,breath,base,heigth;
   int ra;
   float ta;
   cout<<"enter length and breath"<<endl;
   cin>>lenght>>breath;
   r.getdata(lenght,breath);
   ra=r.crare();
   cout <<"area of rectangle is "<<ra<<endl;
   cout<<"enter the base and heigth"<<endl;
   cin>>base>>heigth;
   t.getdata(base,heigth);
   ta=t.ctarea();
   cout<<"area of rectangle is "<<ta<<endl;
   return 0;
}
