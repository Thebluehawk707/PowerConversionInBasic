#include "pch.h"
#include "PowerFunctions.h"
#include "math.h"

double __stdcall mW2dBm(double mW)
{
	return (10 * log10(mW));
}

double __stdcall dBm2mW(double dBm)
{
	return (pow(10, (dBm / 10)));
}