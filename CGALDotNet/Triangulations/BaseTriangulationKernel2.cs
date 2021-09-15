﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

using CGALDotNet.Geometry;
using CGALDotNet.Polygons;

namespace CGALDotNet.Triangulations
{
    internal abstract class BaseTriangulationKernel2
    {
        protected const string DLL_NAME = "CGALWrapper.dll";

        protected const CallingConvention CDECL = CallingConvention.Cdecl;

        internal string Name => "EEK";

        internal abstract IntPtr Create();

        internal abstract void Release(IntPtr ptr);

        internal abstract void Clear(IntPtr ptr);

        internal abstract IntPtr Copy(IntPtr ptr);

        internal abstract int BuildStamp(IntPtr ptr);

        internal abstract bool IsValid(IntPtr ptr, int level);

        internal abstract int VertexCount(IntPtr ptr);

        internal abstract int FaceCount(IntPtr ptr);

        internal abstract void InsertPoint(IntPtr ptr, Point2d point);

        internal abstract void InsertPoints(IntPtr ptr, Point2d[] points, int startIndex, int count);

        internal abstract void InsertPolygon(IntPtr triPtr, IntPtr polyPtr);

        internal abstract void InsertPolygonWithHoles(IntPtr triPtr, IntPtr pwhPtr);

        internal abstract void GetPoints(IntPtr ptr, Point2d[] points, int startIndex, int count);

        internal abstract void GetIndices(IntPtr ptr, int[] indices, int startIndex, int count);

        internal abstract bool GetVertex(IntPtr ptr, int index, out TriVertex2 vertex);

        internal abstract void GetVertices(IntPtr ptr, TriVertex2[] vertices, int startIndex, int count);

        internal abstract bool GetFace(IntPtr ptr, int index, out TriFace2 face);

        internal abstract void GetFaces(IntPtr ptr, TriFace2[] faces, int startIndex, int count);

        internal abstract bool GetSegment(IntPtr ptr, int faceIndex, int neighbourIndex, out Segment2d segment);

        internal abstract bool GetTriangle(IntPtr ptr, int faceIndex, out Triangle2d triangle);

        internal abstract void GetTriangles(IntPtr ptr, Triangle2d[] triangles, int startIndex, int count);

        internal abstract bool GetCircumcenter(IntPtr ptr, int faceIndex, out Point2d circumcenter);

        internal abstract void GetCircumcenters(IntPtr ptr, Point2d[] circumcenters, int startIndex, int count);

        internal abstract bool LocateFace(IntPtr ptr, Point2d point, out TriFace2 face);

        internal abstract bool MoveVertex(IntPtr ptr, int index, Point2d point, bool ifNoCollision, out TriVertex2 vertex);

        internal abstract bool RemoveVertex(IntPtr ptr, int index);

        internal abstract bool FlipEdge(IntPtr ptr, int faceIndex, int neighbour);


    }
}
