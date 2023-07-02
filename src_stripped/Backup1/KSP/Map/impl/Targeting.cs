// Decompiled with JetBrains decompiler
// Type: KSP.Map.impl.Targeting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Utilities;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UtilScripts;

namespace KSP.Map.impl
{
  public class Targeting
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double sample_v(int index, int count, Targeting.Conic o) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void add_interval(
      Targeting.PairOfIntervals intervals,
      Targeting.Sample start,
      Targeting.Sample end)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Targeting.Sample check_void_transition(
      Targeting.PairOfIntervals intervals,
      Targeting.Sample prev,
      Targeting.Sample samp,
      Targeting.Sample ival_start)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Targeting.PairOfIntervals sample_orbits(
      Targeting.Conic orbit1,
      Targeting.Conic orbit2,
      int count)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Targeting.PairOfIntervals find_search_intervals(Targeting.PairOfIntervals ivals) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void add_crossing_subdivisions(
      List<Targeting.Interval> intervals,
      Targeting.Interval ival,
      bool reversed)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Targeting.PairOfIntervals subdivide_intervals(Targeting.PairOfIntervals ivals) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Targeting.Sample> Intercepts(
      Targeting.Conic orbit1,
      Targeting.Conic orbit2,
      int samples)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Targeting() => throw null;

    public struct Ray
    {
      public Vector3d p;
      public Vector3d v;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Ray(Vector3d p, Vector3d v) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Vector3d ClosestPoint(Vector3d point, bool forward = false) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Vector3d ClosestPoint(Targeting.Ray ray, bool forward = false) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Targeting.Ray Project(Targeting.Plane plane) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Vector3d Point(double t) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override string ToString() => throw null;
    }

    public struct Plane
    {
      public Vector3d p;
      public Vector3d n;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Plane(Vector3d p, Vector3d n) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Vector3d Intersept(Targeting.Ray ray) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override string ToString() => throw null;
    }

    public struct Frame
    {
      public Vector3d p;
      public Vector3d t;
      public Vector3d n;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Frame(Vector3d p, Vector3d t, Vector3d n) => throw null;
    }

    public class Conic
    {
      public double l;
      public double e;
      public double a;
      public double b;
      public double pe;
      public Vector3d pe_point;
      public double ap;
      public Vector3d ap_point;
      public Vector3d X;
      public Vector3d Y;
      public Vector3d N;
      public Vector3d focus;
      public Vector3d center;
      public Targeting.Plane conic_plane;
      public double min_v;
      public double max_v;
      private static readonly IObjectPool<Targeting.Conic> pool;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private Conic() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private static Targeting.Conic Create() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private static void Reset(Targeting.Conic obj) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Release() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static Targeting.Conic Borrow(IKeplerOrbit o) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public double Radius(double v) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Vector3d Point(double v) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public double Curvature(double v) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Vector3d Tangent(double v) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void true_anomaly_xy(Vector3d p, out double c, out double s) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public double TrueAnomaly(Vector3d p) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void tangent_xy(Vector3d p, out double vx, out double vy) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Vector3d Tangent(Vector3d p) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Vector3d Normal(double v) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Vector3d Normal(Vector3d p) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Targeting.Frame GetFrame(Vector3d p) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public int Intercepts(Targeting.Ray line, out Vector3d i1, out Vector3d i2) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool point_is_real(Vector3d p) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool point_inside(Vector3d p) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static Conic() => throw null;
    }

    public class Sample
    {
      public Targeting.Conic orbit1;
      public Targeting.Conic orbit2;
      public double v;
      public bool region_edge;
      public bool valid;
      public bool minimum;
      public Targeting.Frame src;
      public Targeting.Frame tgt1;
      public Targeting.Frame tgt2;
      public Targeting.Sample.Info info1;
      public Targeting.Sample.Info info2;
      public int tgt_index;
      private static readonly Pool<Targeting.Sample> pool;
      private static readonly List<Targeting.Sample> borrowed;

      public Targeting.Frame tgt
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public Targeting.Sample.Info info
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      private Sample() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private static Targeting.Sample Create() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private static void Reset(Targeting.Sample obj) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static void ReleaseAllBorrowed() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static Targeting.Sample Borrow(Targeting.Conic o1, Targeting.Conic o2, double v) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Targeting.Sample.Info GetInfo(int index) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Targeting.Frame GetTgt(int index) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static int get_normal_intercepts(
        Targeting.Conic o1,
        Vector3d p1,
        Targeting.Conic o2,
        out Vector3d i1,
        out Vector3d i2)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static int get_normal_intercept_frames(
        Targeting.Conic o1,
        Vector3d p1,
        Targeting.Conic o2,
        out Targeting.Frame f1,
        out Targeting.Frame f2)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      static Sample() => throw null;

      public struct Info
      {
        public Vector3d d;
        public double cos0;
        public double cos1;
        public double dot0;
        public double dot1;
        public double tangent_dot;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public void Set(Targeting.Frame f1, Targeting.Frame f2) => throw null;
      }
    }

    public class PairOfIntervals
    {
      private static readonly Pool<Targeting.PairOfIntervals> pool;
      private List<Targeting.Interval> A;
      private List<Targeting.Interval> B;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private PairOfIntervals() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private static Targeting.PairOfIntervals Create() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private static void Reset(Targeting.PairOfIntervals obj) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static Targeting.PairOfIntervals Borrow() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Release() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void ReleaseContent() => throw null;

      public List<Targeting.Interval> this[int key]
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      static PairOfIntervals() => throw null;
    }

    public class Interval
    {
      public Targeting.Sample s1;
      public Targeting.Sample s2;
      public int tgt_index;
      public Targeting.Sample.Info info1;
      public Targeting.Sample.Info info2;
      public bool void_region;
      public bool has_root;
      public bool minimum;
      public bool maximum;
      public Targeting.Interval prev;
      public Targeting.Interval next;
      public const double epsilon = 1E-08;
      public const double golden = 0.6180339887498949;
      private static readonly Pool<Targeting.Interval> pool;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private Interval() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private static Targeting.Interval Create() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private static void Reset(Targeting.Interval obj) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Release() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static Targeting.Interval Borrow(
        Targeting.Sample s1,
        Targeting.Sample s2,
        int tgt_index)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Link(Targeting.Interval prev, Targeting.Interval next) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public List<Targeting.Interval> Subdivide() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Targeting.Sample FindRoot() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static Targeting.Sample find_region_edge(
        Targeting.Conic orbit1,
        Targeting.Conic orbit2,
        double v1,
        double v2)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      static Interval() => throw null;
    }
  }
}
