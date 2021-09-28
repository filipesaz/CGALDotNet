#pragma once
#include "Triangulation2_EEK.h"
#include "Triangulation2.h"

#include <CGAL/Constrained_Delaunay_triangulation_2.h>
#include <CGAL/Triangulation_conformer_2.h>

void* Triangulation2_EEK_Create()
{
	return Triangulation2<EEK>::NewTriangulation2();
}

void Triangulation2_EEK_Release(void* ptr)
{
	Triangulation2<EEK>::DeleteTriangulation2(ptr);
}

void Triangulation2_EEK_Clear(void* ptr)
{
	Triangulation2<EEK>::Clear(ptr);
}

void* Triangulation2_EEK_Copy(void* ptr)
{
	return Triangulation2<EEK>::Copy(ptr);
}

void Triangulation2_EEK_SetIndices(void* ptr)
{
	Triangulation2<EEK>::SetIndices(ptr);
}

int Triangulation2_EEK_BuildStamp(void* ptr)
{
	return Triangulation2<EEK>::BuildStamp(ptr);
}

BOOL Triangulation2_EEK_IsValid(void* ptr, int level)
{
	return Triangulation2<EEK>::IsValid(ptr, level);
}

int Triangulation2_EEK_VertexCount(void* ptr)
{
	return Triangulation2<EEK>::VertexCount(ptr);
}

int Triangulation2_EEK_FaceCount(void* ptr)
{
	return Triangulation2<EEK>::FaceCount(ptr);
}

void Triangulation2_EEK_InsertPoint(void* ptr, Point2d point)
{
	Triangulation2<EEK>::InsertPoint(ptr, point);
}

void Triangulation2_EEK_InsertPoints(void* ptr, Point2d* points, int startIndex, int count)
{
	Triangulation2<EEK>::InsertPoints(ptr, points, startIndex, count);
}

void Triangulation2_EEK_InsertPolygon(void* triPtr, void* polyPtr)
{
	Triangulation2<EEK>::InsertPolygon(triPtr, polyPtr);
}

void Triangulation2_EEK_InsertPolygonWithHoles(void* triPtr, void* pwhPtr)
{
	Triangulation2<EEK>::InsertPolygonWithHoles(triPtr, pwhPtr);
}

void Triangulation2_EEK_GetPoints(void* ptr, Point2d* points, int startIndex, int count)
{
	Triangulation2<EEK>::GetPoints(ptr, points, startIndex, count);
}

void Triangulation2_EEK_GetIndices(void* ptr, int* indices, int startIndex, int count)
{
	Triangulation2<EEK>::GetIndices(ptr, indices, startIndex, count);
}

BOOL Triangulation2_EEK_GetVertex(void* ptr, int index, TriVertex2& vertex)
{
	return Triangulation2<EEK>::GetVertex(ptr, index, vertex);
}

void Triangulation2_EEK_GetVertices(void* ptr, TriVertex2* vertices, int startIndex, int count)
{
	Triangulation2<EEK>::GetVertices(ptr, vertices, startIndex, count);
}

bool Triangulation2_EEK_GetFace(void* ptr, int index, TriFace2& face)
{
	return Triangulation2<EEK>::GetFace(ptr, index, face);
}

void Triangulation2_EEK_GetFaces(void* ptr, TriFace2* faces, int startIndex, int count)
{
	Triangulation2<EEK>::GetFaces(ptr, faces, startIndex, count);
}

BOOL Triangulation2_EEK_GetSegment(void* ptr, int faceIndex, int neighbourIndex, Segment2d& segment)
{
	return Triangulation2<EEK>::GetSegment(ptr, faceIndex, neighbourIndex, segment);
}

BOOL Triangulation2_EEK_GetTriangle(void* ptr, int faceIndex, Triangle2d& triangle)
{
	return Triangulation2<EEK>::GetTriangle(ptr, faceIndex, triangle);
}

void Triangulation2_EEK_GetTriangles(void* ptr, Triangle2d* triangles, int startIndex, int count)
{
	Triangulation2<EEK>::GetTriangles(ptr, triangles, startIndex, count);
}

BOOL Triangulation2_EEK_GetCircumcenter(void* ptr, int faceIndex, Point2d& circumcenter)
{
	return Triangulation2<EEK>::GetCircumcenter(ptr, faceIndex, circumcenter);
}

void Triangulation2_EEK_GetCircumcenters(void* ptr, Point2d* circumcenters, int startIndex, int count)
{
	Triangulation2<EEK>::GetCircumcenters(ptr, circumcenters, startIndex, count);
}

int Triangulation2_EEK_NeighbourIndex(void* ptr, int faceIndex, int index)
{
	return Triangulation2<EEK>::NeighbourIndex(ptr, faceIndex, index);
}

BOOL Triangulation2_EEK_LocateFace(void* ptr, Point2d point, TriFace2& face)
{
	return Triangulation2<EEK>::LocateFace(ptr, point, face);
}

BOOL Triangulation2_EEK_MoveVertex(void* ptr, int index, Point2d point, BOOL ifNoCollision, TriVertex2& vertex)
{
	return Triangulation2<EEK>::MoveVertex(ptr, index, point, ifNoCollision, vertex);
}

BOOL Triangulation2_EEK_RemoveVertex(void* ptr, int index)
{
	return Triangulation2<EEK>::RemoveVertex(ptr, index);
}

BOOL Triangulation2_EEK_FlipEdge(void* ptr, int faceIndex, int neighbour)
{
	return Triangulation2<EEK>::FlipEdge(ptr, faceIndex, neighbour);
}

void Triangulation2_EEK_Transform(void* ptr, Point2d translation, double rotation, double scale)
{
	Triangulation2<EEK>::Transform(ptr, translation, rotation, scale);
}








