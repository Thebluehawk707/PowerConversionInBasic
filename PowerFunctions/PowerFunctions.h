#pragma once

#ifdef POWERFUNCTIONS
#define POWERFUNCTIONS_API __declspec(dllexport)
#else
#define POWERFUNCTIONS_API __declspec(dllimport)
#endif

#ifdef __cplusplus

extern "C" {
#endif

	POWERFUNCTIONS_API double __stdcall mW2dBm(double mW);

	POWERFUNCTIONS_API double _stdcall dBm2mW(double dBm);

#ifdef __cplusplus
}
#endif // __cplusplus
