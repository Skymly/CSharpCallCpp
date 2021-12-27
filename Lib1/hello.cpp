#include "hello.h"

int add(int a,int b)
{
	return a + b;
}

extern "C" _declspec(dllexport) int max(int a, int b)
{
	if (a > b)
	{
		return a;
	}
	return b;
}