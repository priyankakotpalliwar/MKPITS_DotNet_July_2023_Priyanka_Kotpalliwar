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
		int rarea(int l,int b)
		{
			int ra;
			ra=l*b;
			return ra;
		}
};
class triangle:public shape
{
	public:
		float ctarea(int b,int h)
		{
			float ta;
			ta=0.5f*b*h;
			return ta;
		}
};
int main()
{
	rectangle r;
	triangle t;
	int length,breath,base,height;
	int ra;
	float ta;
	cout<<"enter length,breath"<<endl;
	cin>>length>>breath;
	ra=r.rarea(length,breath);
	cout<<"area of rectangle"<<ra<<endl;
	cout<<"enter base and heigth"<<endl;
	cin>>base>>height;
	ta=t.ctarea(base,height);
	cout<<"area of triangle"<<ta<<endl;
	return 0; 
}
