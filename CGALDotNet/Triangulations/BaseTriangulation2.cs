﻿using System;
using System.Collections.Generic;
using System.Text;

using CGALDotNet.Geometry;
using CGALDotNet.Polygons;

namespace CGALDotNet.Triangulations
{
    public abstract class BaseTriangulation2 : CGALObject
    {
        private BaseTriangulation2()
        {

        }

        internal BaseTriangulation2(BaseTriangulationKernel2 kernel)
        {
            Kernel = kernel;
            Ptr = Kernel.Create();
        }

        internal BaseTriangulation2(BaseTriangulationKernel2 kernel, Point2d[] points)
        {
            Kernel = kernel;
            Ptr = Kernel.Create();
            InsertPoints(points);
        }

        internal BaseTriangulation2(BaseTriangulationKernel2 kernel, IntPtr ptr) : base(ptr)
        {
            Kernel = kernel;
        }

        protected private BaseTriangulationKernel2 Kernel { get; private set; }

        public int VertexCount => Kernel.VertexCount(Ptr);

        public int FaceCount => Kernel.FaceCount(Ptr);

        public int IndiceCount => FaceCount * 3;

        public void Clear()
        {
            Kernel.Clear(Ptr);
        }

        public bool IsValid()
        {
            return Kernel.IsValid(Ptr);
        }

        public void InsertPoint(Point2d point)
        {
            Kernel.InsertPoint(Ptr, point);
        }

        public void InsertPoints(Point2d[] points)
        {
            Kernel.InsertPoints(Ptr, points, 0, points.Length);
        }

        public void GetPoints(Point2d[] points)
        {
            int count = VertexCount;
            if (count == 0) return;

            ErrorUtil.CheckBounds(points, 0, count);
            Kernel.GetPoints(Ptr, points, 0, points.Length);
        }

        public void GetIndices(int[] indices)
        {
            int count = IndiceCount;
            if (count == 0) return;

            ErrorUtil.CheckBounds(indices, 0, count);
            Kernel.GetIndices(Ptr, indices, 0, indices.Length);
        }

        public bool GetVertex(int index, out TriVertex2 vertex)
        {
            return Kernel.GetVertex(Ptr, index, out vertex);
        }

        public void GetVertices(TriVertex2[] vertices)
        {
            int count = VertexCount;
            if (count == 0) return;

            ErrorUtil.CheckBounds(vertices, 0, count);
            Kernel.GetVertices(Ptr, vertices, 0, vertices.Length);
        }

        public bool GetFace(int index, out TriFace2 face)
        {
            return Kernel.GetFace(Ptr, index, out face);
        }

        public void GetFaces(TriFace2[] faces)
        {
            int count = FaceCount;
            if (count == 0) return;

            ErrorUtil.CheckBounds(faces, 0, count);
            Kernel.GetFaces(Ptr, faces, 0, faces.Length);
        }

        public bool GetSegment(int faceIndex, int neighbourIndex, out Segment2d segment)
        {
            return Kernel.GetSegment(Ptr, faceIndex, neighbourIndex, out segment);
        }

        public bool GetTriangle(int faceIndex, out Triangle2d triangle)
        {
            return Kernel.GetTriangle(Ptr, faceIndex, out triangle);
        }

        public void GetTriangles(Triangle2d[] triangles)
        {
            int count = FaceCount;
            if (count == 0) return;

            ErrorUtil.CheckBounds(triangles, 0, count);
            Kernel.GetTriangles(Ptr, triangles, 0, count);
        }

        public bool GetCircumcenter(int faceIndex, out Point2d circumcenter)
        {
            return Kernel.GetCircumcenter(Ptr, faceIndex, out circumcenter);
        }

        public void GetCircumcenters(Point2d[] circumcenters)
        {
            int count = FaceCount;
            if (count == 0) return;

            ErrorUtil.CheckBounds(circumcenters, 0, count);
            Kernel.GetCircumcenters(Ptr, circumcenters, 0, circumcenters.Length);
        }

        public bool LocateFace(Point2d point, out TriFace2 face)
        {
            return Kernel.LocateFace(Ptr, point, out face);
        }

        public bool MoveVertex(int index, Point2d point, bool ifNoCollision, out TriVertex2 vertex)
        {
            return Kernel.MoveVertex(Ptr, index, point, ifNoCollision, out vertex);
        }

        public bool RemoveVertex(int index)
        {
            return Kernel.RemoveVertex(Ptr, index);
        }

        public bool FlipEdge(int faceIndex, int neighbourIndex)
        {
            return Kernel.FlipEdge(Ptr, faceIndex, neighbourIndex);
        }

        public void Print()
        {
            var builder = new StringBuilder();
            Print(builder);
            Console.WriteLine(builder.ToString());
        }

        public virtual void Print(StringBuilder builder)
        {
            builder.AppendLine(ToString());
        }

        protected override void ReleasePtr()
        {
            Kernel.Release(Ptr);
        }
    }
}