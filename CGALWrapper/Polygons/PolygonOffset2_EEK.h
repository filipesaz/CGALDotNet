#pragma once

#include "../CGALWrapper.h"
#include "../Geometry/Geometry2.h"
#include <CGAL/enum.h>

extern "C"
{
	CGALWRAPPER_API void* PolygonOffset2_EEK_Create();

	CGALWRAPPER_API void PolygonOffset2_EEK_Release(void* ptr);

	CGALWRAPPER_API int PolygonOffset2_EEK_PolygonBufferSize(void* ptr);

	CGALWRAPPER_API void PolygonOffset2_EEK_ClearPolygonBuffer(void* ptr);

	CGALWRAPPER_API void* PolygonOffset2_EEK_GetBufferedPolygon(void* ptr, int index);

	CGALWRAPPER_API void PolygonOffset2_EEK_CreateInteriorOffset(void* ptr, void* polyPtr, double offset);

	CGALWRAPPER_API void PolygonOffset2_EEK_CreateExteriorOffset(void* ptr, void* polyPtr, double offset);

}