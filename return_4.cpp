///Sakhawat Adib
//feb 9, 2023   ||   IUT   ||    Bangladesh
 
#include<bits/stdc++.h>
using namespace std;

int ret_4(int k)
{
	int sum = 0;
	for(int i=0; i<k; i++)
	{
		if(i!=0 && i%2==0)
		{
			sum = sum + 4*pow(10,i) + 1;
		}
		else
		{
			sum = sum + 4*pow(10,i);
		}
	}
	return sum;
}
 
int main()
{
	int s;
	scanf("%d",&s);
	printf("\n\n\n%d",ret_4(s));
 
	return 0;
}
