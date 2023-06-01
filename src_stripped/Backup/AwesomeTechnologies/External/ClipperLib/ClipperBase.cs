// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.External.ClipperLib.ClipperBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AwesomeTechnologies.External.ClipperLib
{
  public class ClipperBase
  {
    internal const double horizontal = -3.4E+38;
    internal const int Skip = -2;
    internal const int Unassigned = -1;
    internal const double tolerance = 1E-20;
    public const long loRange = 1073741823;
    public const long hiRange = 4611686018427387903;
    internal LocalMinima m_MinimaList;
    internal LocalMinima m_CurrentLM;
    internal List<List<TEdge>> m_edges;
    internal Scanbeam m_Scanbeam;
    internal List<OutRec> m_PolyOuts;
    internal TEdge m_ActiveEdges;
    internal bool m_UseFullRange;
    internal bool m_HasOpenPaths;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool near_zero(double val) => throw null;

    public bool PreserveCollinear
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Swap(ref long val1, ref long val2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool IsHorizontal(TEdge e) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal bool PointIsVertex(IntPoint pt, OutPt pp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal bool PointOnLineSegment(
      IntPoint pt,
      IntPoint linePt1,
      IntPoint linePt2,
      bool UseFullRange)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal bool PointOnPolygon(IntPoint pt, OutPt pp, bool UseFullRange) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool SlopesEqual(TEdge e1, TEdge e2, bool UseFullRange) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool SlopesEqual(IntPoint pt1, IntPoint pt2, IntPoint pt3, bool UseFullRange) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool SlopesEqual(
      IntPoint pt1,
      IntPoint pt2,
      IntPoint pt3,
      IntPoint pt4,
      bool UseFullRange)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ClipperBase() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisposeLocalMinimaList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RangeTest(IntPoint Pt, ref bool useFullRange) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitEdge(TEdge e, TEdge eNext, TEdge ePrev, IntPoint pt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitEdge2(TEdge e, PolyType polyType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private TEdge FindNextLocMin(TEdge E) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private TEdge ProcessBound(TEdge E, bool LeftBoundIsForward) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AddPath(List<IntPoint> pg, PolyType polyType, bool Closed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AddPaths(List<List<IntPoint>> ppg, PolyType polyType, bool closed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal bool Pt2IsBetweenPt1AndPt3(IntPoint pt1, IntPoint pt2, IntPoint pt3) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private TEdge RemoveEdge(TEdge e) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetDx(TEdge e) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InsertLocalMinima(LocalMinima newLm) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal bool PopLocalMinima(long Y, out LocalMinima current) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ReverseHorizontal(TEdge e) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal virtual void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IntRect GetBounds(List<List<IntPoint>> paths) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void InsertScanbeam(long Y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal bool PopScanbeam(out long Y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal bool LocalMinimaPending() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal OutRec CreateOutRec() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void DisposeOutRec(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void UpdateEdgeIntoAEL(ref TEdge e) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void SwapPositionsInAEL(TEdge edge1, TEdge edge2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void DeleteFromAEL(TEdge e) => throw null;
  }
}
