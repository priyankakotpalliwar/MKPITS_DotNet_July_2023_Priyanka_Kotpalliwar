#include<iostream>
using namespace std;
class student
{
	private:
		int rno;
	public:
		void display()
		{
			cout<<"rno="<<rno;
		}
		void setup(int r)
		{
			rno=r;
		}
};
int main()
{
	student s1;
	int rn;
	cout<<"enter rno";
	cin>>rn;
	s1.setup(rn);
	s1.display();

}
