﻿using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

using CGALDotNet;
using CGALDotNet.Geometry;
using CGALDotNet.Polygons;
using CGALDotNet.Polylines;
using CGALDotNet.Triangulations;
using CGALDotNet.Arrangements;
using CGALDotNet.Polyhedra;
using CGALDotNet.Meshing;
using CGALDotNet.Hulls;
using CGALDotNet.Processing;

namespace CGALDotNetConsole
{
    public class Program
    {
        

        public static void Main(string[] args)
        {

            var fea = PolygonMeshProcessingFeatures<EEK>.Instance;

            var poly = PolyhedronFactory<EEK>.CreateCylinder();


            int edges = fea.DetectSharpEdges(poly, new Degree(20));
         
            
            Console.WriteLine("edges = " + edges);
        }



    }
}
