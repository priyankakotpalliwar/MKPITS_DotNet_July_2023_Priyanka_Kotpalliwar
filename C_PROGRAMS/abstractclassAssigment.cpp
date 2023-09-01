#include<iostream>
using namespace std;
class mediaplayer
{
	public:
		virtual void play()=0;
		virtual void pause()=0;
		virtual void stop()=0;
		
};
class audioplayer:public mediaplayer
{
	public:
		void play()
		{
			cout<<"the audio will play"<<endl;
		}
		void pause()
		{
			cout<<"the audio will pause"<<endl;
		}
		void stop()
		{
			cout<<"the  audio is stop"<<endl;
		}
		
	
};
class vedioplayer:public mediaplayer
{
	public:
		void play()
		{
			cout<<"the vedio will play"<<endl;
		}
		void pause()
		{
			cout<<"the vedio will pause"<<endl;
		}
		void stop()
		{
			cout<<"the  vedio is stop"<<endl;
		}





		
};
int main()
{
	vedioplayer V;
	V.pause();
	V.play();
	V.stop();
	audioplayer A;
	A.pause();
	A.play();
	A.stop();
	return 0;
}
