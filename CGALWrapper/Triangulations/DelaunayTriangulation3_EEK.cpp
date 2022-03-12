#pragma once
#include "DelaunayTriangulation3_EEK.h"
#include "BaseTriangulation3.h"
#include "DelaunayTriangulation3.h"

typedef typename CGAL::Triangulation_vertex_base_with_info_3<int, EEK>		Vb;
typedef typename CGAL::Delaunay_triangulation_cell_base_3<EEK>                Cb;
typedef typename CGAL::Triangulation_data_structure_3<Vb, Cb>               Tds;

typedef CGAL::Delaunay_triangulation_3<EEK, Tds> 						DelaunayTriangulation_3;

typedef typename DelaunayTriangulation_3::Point						Point_3;
typedef typename DelaunayTriangulation_3::Cell_handle				Cell;
typedef typename DelaunayTriangulation_3::Vertex_handle				Vertex;

typedef DelaunayTriangulation3<EEK, DelaunayTriangulation_3, Vertex, Cell> Tri3;

void* DelaunayTriangulation3_EEK_Create()
{
	return Tri3::NewTriangulation3();
}

void DelaunayTriangulation3_EEK_Release(void* ptr)
{
	Tri3::DeleteTriangulation3(ptr);
}

void* DelaunayTriangulation3_EEK_Copy(void* ptr)
{
	auto tri = Tri3::CastToTriangulation3(ptr);
	return tri->Copy();
}

void DelaunayTriangulation3_EEK_Clear(void* ptr)
{
	auto tri = Tri3::CastToTriangulation3(ptr);
	tri->Clear();
}

int DelaunayTriangulation3_EEK_BuildStamp(void* ptr)
{
	auto tri = Tri3::CastToTriangulation3(ptr);
	return tri->buildStamp;
}

int DelaunayTriangulation3_EEK_Dimension(void* ptr)
{
	auto tri = Tri3::CastToTriangulation3(ptr);
	return tri->Dimension();
}

BOOL DelaunayTriangulation3_EEK_IsValid(void* ptr)
{
	auto tri = Tri3::CastToTriangulation3(ptr);
	return tri->IsValid();
}

int DelaunayTriangulation3_EEK_VertexCount(void* ptr)
{
	auto tri = Tri3::CastToTriangulation3(ptr);
	return tri->VertexCount();
}

int DelaunayTriangulation3_EEK_CellCount(void* ptr)
{
	auto tri = Tri3::CastToTriangulation3(ptr);
	return tri->CellCount();
}

int DelaunayTriangulation3_EEK_FiniteCellCount(void* ptr)
{
	auto tri = Tri3::CastToTriangulation3(ptr);
	return tri->FiniteCellCount();
}

int DelaunayTriangulation3_EEK_EdgeCount(void* ptr)
{
	auto tri = Tri3::CastToTriangulation3(ptr);
	return tri->EdgeCount();
}

int DelaunayTriangulation3_EEK_FiniteEdgeCount(void* ptr)
{
	auto tri = Tri3::CastToTriangulation3(ptr);
	return tri->FiniteEdgeCount();
}

int DelaunayTriangulation3_EEK_FacetCount(void* ptr)
{
	auto tri = Tri3::CastToTriangulation3(ptr);
	return tri->FacetCount();
}

int DelaunayTriangulation3_EEK_FiniteFacetCount(void* ptr)
{
	auto tri = Tri3::CastToTriangulation3(ptr);
	return tri->FiniteFacetCount();
}

void DelaunayTriangulation3_EEK_InsertPoint(void* ptr, const Point3d& point)
{
	auto tri = Tri3::CastToTriangulation3(ptr);
	tri->InsertPoint(point);
}

void DelaunayTriangulation3_EEK_InsertPoints(void* ptr, Point3d* points, int count)
{
	auto tri = Tri3::CastToTriangulation3(ptr);
	tri->InsertPoints(points, count);
}

void DelaunayTriangulation3_EEK_GetPoints(void* ptr, Point3d* points, int count)
{
	auto tri = Tri3::CastToTriangulation3(ptr);
	tri->GetPoints(points, count);
}

void DelaunayTriangulation3_EEK_GetSegmentIndices(void* ptr, int* indices, int count)
{
	auto tri = Tri3::CastToTriangulation3(ptr);
	tri->GetSegmentIndices(indices, count);
}

void DelaunayTriangulation3_EEK_GetTriangleIndices(void* ptr, int* indices, int count)
{
	auto tri = Tri3::CastToTriangulation3(ptr);
	tri->GetTriangleIndices(indices, count);
}

void DelaunayTriangulation3_EEK_GetTetrahedraIndices(void* ptr, int* indices, int count)
{
	auto tri = Tri3::CastToTriangulation3(ptr);
	tri->GetTetrahedraIndices(indices, count);
}

void DelaunayTriangulation3_EEK_Transform(void* ptr, const Matrix4x4d& matrix)
{
	auto tri = Tri3::CastToTriangulation3(ptr);
	tri->Transform(matrix);
}
