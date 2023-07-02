// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.External.ClipperLib.ClipperOffset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AwesomeTechnologies.External.ClipperLib
{
  public class ClipperOffset
  {
    private List<List<IntPoint>> m_destPolys;
    private List<IntPoint> m_srcPoly;
    private List<IntPoint> m_destPoly;
    private List<DoublePoint> m_normals;
    private double m_delta;
    private double m_sinA;
    private double m_sin;
    private double m_cos;
    private double m_miterLim;
    private double m_StepsPerRad;
    private IntPoint m_lowest;
    private PolyNode m_polyNodes;
    private const double two_pi = 6.2831853071795862;
    private const double def_arc_tolerance = 0.25;

    public double ArcTolerance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double MiterLimit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ClipperOffset(double miterLimit = 2.0, double arcTolerance = 0.25) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static long Round(double value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddPath(List<IntPoint> path, JoinType joinType, EndType endType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddPaths(List<List<IntPoint>> paths, JoinType joinType, EndType endType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FixOrientations() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static DoublePoint GetUnitNormal(IntPoint pt1, IntPoint pt2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DoOffset(double delta) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(ref List<List<IntPoint>> solution, double delta) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(ref PolyTree solution, double delta) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OffsetPoint(int j, ref int k, JoinType jointype) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void DoSquare(int j, int k) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void DoMiter(int j, int k, double r) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void DoRound(int j, int k) => throw null;
  }
}
