#include<iostream>
using namespace std;
class circle
{
	public:
		int radius;
		float calculationarea()
		{
			float a=3.14f*radius*radius;
			return a;
			
		}
		float calculatecirc()
		{
			float cir=2*3.14f*radius;
			return cir;
		}
};
int main()
{
	float result;
	circle c1;
	cout<<"enter radius";
	cin>>c1.radius;
	result=c1.calculationarea();
	cout<<"circumference ="<<result;
	
	
	
}
