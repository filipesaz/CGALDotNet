﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

using REAL = System.Single;

namespace CGALDotNetGeometry.Numerics
{

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Point3f : IEquatable<Point3f>
    {
        public REAL x, y, z;

        /// <summary>
        /// The unit x point.
        /// </summary>
	    public readonly static Point3f UnitX = new Point3f(1, 0, 0);

        /// <summary>
        /// The unit y point.
        /// </summary>
	    public readonly static Point3f UnitY = new Point3f(0, 1, 0);

        /// <summary>
        /// The unit z point.
        /// </summary>
        public readonly static Point3f UnitZ = new Point3f(0, 0, 1);

        /// <summary>
        /// A point of zeros.
        /// </summary>
	    public readonly static Point3f Zero = new Point3f(0);

        /// <summary>
        /// A point of ones.
        /// </summary>
	    public readonly static Point3f One = new Point3f(1);

        /// <summary>
        /// A point of 0.5.
        /// </summary>
        public readonly static Point3f Half = new Point3f(0.5f);

        /// <summary>
        /// A point of positive infinity.
        /// </summary>
        public readonly static Point3f PositiveInfinity = new Point3f(REAL.PositiveInfinity);

        /// <summary>
        /// A point of negative infinity.
        /// </summary>
        public readonly static Point3f NegativeInfinity = new Point3f(REAL.NegativeInfinity);

        /// <summary>
        /// 3D point to 3D swizzle point.
        /// </summary>
        public Point3f xzy => new Point3f(x, z, y);

        /// <summary>
        /// 3D point to 2D point.
        /// </summary>
        public Point2f xy => new Point2f(x, y);

        /// <summary>
        /// 3D point to 2D point.
        /// </summary>
        public Point2f xz => new Point2f(x, z);

        /// <summary>
        /// 3D point to 4D point with w as 0.
        /// </summary>
        public Point4f xyz0 => new Point4f(x, y, z, 0);

        /// <summary>
        /// 3D point to 4D point with w as 1.
        /// </summary>
        public Point4f xyz1 => new Point4f(x, y, z, 1);

        /// <summary>
        /// A point all with the value v.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Point3f(REAL v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }

        /// <summary>
        /// A point from the varibles.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Point3f(REAL x, REAL y, REAL z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>
        /// Array accessor for variables. 
        /// </summary>
        /// <param name="i">The variables index.</param>
        /// <returns>The variable value</returns>
        unsafe public REAL this[int i]
        {
            get
            {
                if ((uint)i >= 3)
                    throw new IndexOutOfRangeException("Point3f index out of range.");

                fixed (Point3f* array = &this) { return ((REAL*)array)[i]; }
            }
            set
            {
                if ((uint)i >= 3)
                    throw new IndexOutOfRangeException("Point3f index out of range.");

                fixed (REAL* array = &x) { array[i] = value; }
            }
        }

        /// <summary>
        /// Point as vector.
        /// </summary>
        public Vector3f Vector3f => new Vector3f(x, y, z);

        /// <summary>
        /// Point as vector.
        /// </summary>
        public Vector4d Vector4d => new Vector4d(x, y, z, 1);

        /// <summary>
        /// The sum of the points components.
        /// </summary>
        public REAL Sum
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return x + y + z;
            }
        }

        /// <summary>
        /// The product of the points components.
        /// </summary>
        public REAL Product
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return x * y * z;
            }
        }

        /// <summary>
        /// The points absolute values.
        /// </summary>
        public Point3f Absolute
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return new Point3f(Math.Abs(x), Math.Abs(y), Math.Abs(z));
            }
        }

        /// <summary>
        /// The length of the vector.
        /// </summary>
        public REAL Magnitude
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return MathUtil.SafeSqrt(SqrMagnitude);
            }
        }

        /// <summary>
        /// The length of the vector squared.
        /// </summary>
		public REAL SqrMagnitude
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (x * x + y * y + z * z);
            }
        }

        /// <summary>
        /// Add two point and vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Point3f operator +(Point3f v1, Vector3f v2)
        {
            return new Point3f(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        /// <summary>
        /// Add two points.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Point3f operator +(Point3f v1, Point3f v2)
        {
            return new Point3f(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        /// <summary>
        /// Add point and scalar.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Point3f operator +(Point3f v1, REAL s)
        {
            return new Point3f(v1.x + s, v1.y + s, v1.z + s);
        }

        /// <summary>
        /// Add point and scalar.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Point3f operator +(REAL s, Point3f v1)
        {
            return new Point3f(s + v1.x, s + v1.y, s + v1.z);
        }

        /// <summary>
        /// Negate point.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Point3f operator -(Point3f v)
        {
            return new Point3f(-v.x, -v.y, -v.z);
        }

        /// <summary>
        /// Subtract two points.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Point3f operator -(Point3f v1, Point3f v2)
        {
            return new Point3f(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        /// <summary>
        /// Subtract a point and a vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Point3f operator -(Point3f v1, Vector3f v2)
        {
            return new Point3f(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        /// <summary>
        /// Subtract point and scalar.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Point3f operator -(Point3f v1, REAL s)
        {
            return new Point3f(v1.x - s, v1.y - s, v1.z - s);
        }

        /// <summary>
        /// Subtract point and scalar.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Point3f operator -(REAL s, Point3f v1)
        {
            return new Point3f(s - v1.x, s - v1.y, s - v1.z);
        }

        /// <summary>
        /// Multiply two points.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Point3f operator *(Point3f v1, Point3f v2)
        {
            return new Point3f(v1.x * v2.x, v1.y * v2.y, v1.z * v2.z);
        }

        /// <summary>
        /// Multiply a point and a scalar.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Point3f operator *(Point3f v, REAL s)
        {
            return new Point3f(v.x * s, v.y * s, v.z * s);
        }

        /// <summary>
        /// Multiply a point and a scalar.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Point3f operator *(REAL s, Point3f v)
        {
            return new Point3f(v.x * s, v.y * s, v.z * s);
        }

        /// <summary>
        /// Divide two points.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Point3f operator /(Point3f v1, Point3f v2)
        {
            return new Point3f(v1.x / v2.x, v1.y / v2.y, v1.z / v2.z);
        }

        /// <summary>
        /// Divide a point and a scalar.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Point3f operator /(Point3f v, REAL s)
        {
            return new Point3f(v.x / s, v.y / s, v.z / s);
        }

        /// <summary>
        /// Implict cast from a tuple.
        /// </summary>
        /// <param name="v">The vector to cast from</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Point3f(ValueTuple<REAL, REAL, REAL> v)
        {
            return new Point3f(v.Item1, v.Item2, v.Item3);
        }

        /// <summary>
        /// Are these points equal.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Point3f v1, Point3f v2)
        {
            return (v1.x == v2.x && v1.y == v2.y && v1.z == v2.z);
        }

        /// <summary>
        /// Are these points not equal.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Point3f v1, Point3f v2)
        {
            return (v1.x != v2.x || v1.y != v2.y || v1.z != v2.z);
        }

        /// <summary>
        /// Are these points equal.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object obj)
        {
            if (!(obj is Point3f)) return false;
            Point3f v = (Point3f)obj;
            return this == v;
        }

        /// <summary>
        /// Are these points equal.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Point3f v)
        {
            return this == v;
        }

        /// <summary>
        /// Vectors hash code. 
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = (int)2166136261;
                hash = (hash * 16777619) ^ x.GetHashCode();
                hash = (hash * 16777619) ^ y.GetHashCode();
                hash = (hash * 16777619) ^ z.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// Vector as a string.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("{0},{1},{2}", x, y, z);
        }

        /// <summary>
        /// Vector as a string.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string f)
        {
            return string.Format("{0},{1},{2}", x.ToString(f), y.ToString(f), z.ToString(f));
        }

        /// <summary>
        /// Distance between two points.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static REAL Distance(Point3f v0, Point3f v1)
        {
            return MathUtil.Sqrt(SqrDistance(v0, v1));
        }

        /// <summary>
        /// Square distance between two points.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static REAL SqrDistance(Point3f v0, Point3f v1)
        {
            REAL x = v0.x - v1.x;
            REAL y = v0.y - v1.y;
            REAL z = v0.z - v1.z;
            return x * x + y * y + z * z;
        }

        /// <summary>
        /// Direction between two points.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3f Direction(Point3f v0, Point3f v1)
        {
            return (v1 - v0).Vector3f.Normalized;
        }

        /// <summary>
        /// The minimum value between s and each component in point.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Point3f Min(Point3f v, REAL s)
        {
            v.x = MathUtil.Min(v.x, s);
            v.y = MathUtil.Min(v.y, s);
            v.z = MathUtil.Min(v.z, s);
            return v;
        }

        /// <summary>
        /// The minimum value between each component in points.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Point3f Min(Point3f v0, Point3f v1)
        {
            v0.x = MathUtil.Min(v0.x, v1.x);
            v0.y = MathUtil.Min(v0.y, v1.y);
            v0.z = MathUtil.Min(v0.z, v1.z);
            return v0;
        }

        /// <summary>
        /// The maximum value between s and each component in point.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Point3f Max(Point3f v, REAL s)
        {
            v.x = MathUtil.Max(v.x, s);
            v.y = MathUtil.Max(v.y, s);
            v.z = MathUtil.Max(v.z, s);
            return v;
        }

        /// <summary>
        /// The maximum value between each component in points.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Point3f Max(Point3f v0, Point3f v1)
        {
            v0.x = MathUtil.Max(v0.x, v1.x);
            v0.y = MathUtil.Max(v0.y, v1.y);
            v0.z = MathUtil.Max(v0.z, v1.z);
            return v0;
        }

        /// <summary>
        /// Clamp each component to specified min and max.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Point3f Clamp(Point3f v, REAL min, REAL max)
        {
            v.x = MathUtil.Max(MathUtil.Min(v.x, max), min);
            v.y = MathUtil.Max(MathUtil.Min(v.y, max), min);
            v.z = MathUtil.Max(MathUtil.Min(v.z, max), min);
            return v;
        }

        /// <summary>
        /// Clamp each component to specified min and max.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Point3f Clamp(Point3f v, Point3f min, Point3f max)
        {
            v.x = MathUtil.Max(MathUtil.Min(v.x, max.x), min.x);
            v.y = MathUtil.Max(MathUtil.Min(v.y, max.y), min.y);
            v.z = MathUtil.Max(MathUtil.Min(v.z, max.z), min.z);
            return v;
        }

        /// <summary>
        /// Lerp between two points.
        /// </summary>
        public static Point3f Lerp(Point3f from, Point3f to, REAL t)
        {
            if (t < 0.0f) t = 0.0f;
            if (t > 1.0f) t = 1.0f;

            if (t == 0.0) return from;
            if (t == 1.0) return to;

            REAL t1 = 1.0f - t;
            var v = new Point3f();
            v.x = from.x * t1 + to.x * t;
            v.y = from.y * t1 + to.y * t;
            v.z = from.z * t1 + to.z * t;
            return v;
        }

        /// <summary>
        /// A rounded point.
        /// </summary>
        /// <param name="digits">The number of digits to round to.</param>
        /// <returns>The rounded point</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Point3f Rounded(int digits = 0)
        {
            REAL x = MathUtil.Round(this.x, digits);
            REAL y = MathUtil.Round(this.y, digits);
            REAL z = MathUtil.Round(this.z, digits);
            return new Point3f(x, y, z);
        }

        /// <summary>
        /// Round the point.
        /// </summary>
        /// <param name="digits">The number of digits to round to.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Round(int digits = 0)
        {
            x = MathUtil.Round(x, digits);
            y = MathUtil.Round(y, digits);
            z = MathUtil.Round(z, digits);
        }

    }
}
