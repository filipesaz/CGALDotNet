#pragma once

#include "../CGALWrapper.h"
#include "../Geometry/Geometry3.h"
#include "TriUtil.h"

#include <vector>
#include "CGAL/Point_3.h"
#include <CGAL/Triangulation_3.h>
#include <CGAL/Triangulation_cell_base_with_info_3.h>
#include <CGAL/Triangulation_vertex_base_with_info_3.h>
#include <CGAL/Aff_transformation_3.h>

#include <CGAL/Delaunay_triangulation_3.h>
#include <CGAL/Delaunay_triangulation_cell_base_3.h>
#include <CGAL/Triangulation_vertex_base_with_info_3.h>

template<class K, class TRI, class VERT, class FACE>
class DelaunayTriangulation3 : public BaseTriangulation3<K, TRI, VERT, FACE>
{

public:

	typedef typename CGAL::Triangulation_vertex_base_with_info_3<int, K>		Vb;
	typedef typename CGAL::Delaunay_triangulation_cell_base_3<K>                Cb;
	typedef typename CGAL::Triangulation_data_structure_3<Vb, Cb>               Tds;

	typedef CGAL::Delaunay_triangulation_3<K, Tds> 						DelaunayTriangulation_3;

	typedef typename DelaunayTriangulation_3::Point						Point_3;
	typedef typename DelaunayTriangulation_3::Cell_handle				Cell;
	typedef typename DelaunayTriangulation_3::Vertex_handle				Vertex;

	typedef CGAL::Aff_transformation_3<K>								Transformation_3;

public:

	DelaunayTriangulation3()
	{

	}

	~DelaunayTriangulation3()
	{

	}

	inline static DelaunayTriangulation3* NewTriangulation3()
	{
		return new DelaunayTriangulation3();
	}

	inline static void DeleteTriangulation3(void* ptr)
	{
		auto obj = static_cast<DelaunayTriangulation3*>(ptr);

		if (obj != nullptr)
		{
			delete obj;
			obj = nullptr;
		}
	}

	inline static DelaunayTriangulation3* CastToTriangulation3(void* ptr)
	{
		return static_cast<DelaunayTriangulation3*>(ptr);
	}

	void* Copy()
	{
		auto copy = NewTriangulation3();
		copy->model = this->model;
		return copy;
	}
};