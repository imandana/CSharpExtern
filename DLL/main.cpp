
#include "lib.h"

extern "C" __declspec(dllexport) int GetHasil()
{
	return hasil;
}
extern "C" __declspec(dllexport) int SuperConductorExport(int a, int b)
{
	return SuperConductor( a, b);
}
extern "C" __declspec(dllexport) void AddToHasilExport(int a)
{
	AddToHasil( a );
}