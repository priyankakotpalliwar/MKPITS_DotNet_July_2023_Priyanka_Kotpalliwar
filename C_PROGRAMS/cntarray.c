#include<stdio.h>
int main()
{
	int arr[5];
	int i,cnt=0;
	int j;
	for(i=0;i<5;i++)
	{
		printf("enter the number");
		scanf("%d",&arr[i]);
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
		//cnt++;
		//break;
		
	}
	printf("\n no. of duplicate number",cnt);
}
