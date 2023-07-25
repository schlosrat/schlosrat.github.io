// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.External.ClipperLib.Clipper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AwesomeTechnologies.External.ClipperLib
{
  public class Clipper : ClipperBase
  {
    public const int ioReverseSolution = 1;
    public const int ioStrictlySimple = 2;
    public const int ioPreserveCollinear = 4;
    private ClipType m_ClipType;
    private Maxima m_Maxima;
    private TEdge m_SortedEdges;
    private List<IntersectNode> m_IntersectList;
    private IComparer<IntersectNode> m_IntersectNodeComparer;
    private bool m_ExecuteLocked;
    private PolyFillType m_ClipFillType;
    private PolyFillType m_SubjFillType;
    private List<Join> m_Joins;
    private List<Join> m_GhostJoins;
    private bool m_UsingPolyTree;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Clipper(int InitOptions = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InsertMaxima(long X) => throw null;

    public bool ReverseSolution
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool StrictlySimple
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Execute(ClipType clipType, List<List<IntPoint>> solution, PolyFillType FillType = PolyFillType.pftEvenOdd) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Execute(ClipType clipType, PolyTree polytree, PolyFillType FillType = PolyFillType.pftEvenOdd) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Execute(
      ClipType clipType,
      List<List<IntPoint>> solution,
      PolyFillType subjFillType,
      PolyFillType clipFillType)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Execute(
      ClipType clipType,
      PolyTree polytree,
      PolyFillType subjFillType,
      PolyFillType clipFillType)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void FixHoleLinkage(OutRec outRec) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ExecuteInternal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisposeAllPolyPts() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddJoin(OutPt Op1, OutPt Op2, IntPoint OffPt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddGhostJoin(OutPt Op, IntPoint OffPt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InsertLocalMinimaIntoAEL(long botY) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InsertEdgeIntoAEL(TEdge edge, TEdge startEdge) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool E2InsertsBeforeE1(TEdge e1, TEdge e2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsEvenOddFillType(TEdge edge) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsEvenOddAltFillType(TEdge edge) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsContributing(TEdge edge) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetWindingCount(TEdge edge) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddEdgeToSEL(TEdge edge) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal bool PopEdgeFromSEL(out TEdge e) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CopyAELToSEL() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SwapPositionsInSEL(TEdge edge1, TEdge edge2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddLocalMaxPoly(TEdge e1, TEdge e2, IntPoint pt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private OutPt AddLocalMinPoly(TEdge e1, TEdge e2, IntPoint pt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private OutPt AddOutPt(TEdge e, IntPoint pt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private OutPt GetLastOutPt(TEdge e) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void SwapPoints(ref IntPoint pt1, ref IntPoint pt2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool HorzSegmentsOverlap(long seg1a, long seg1b, long seg2a, long seg2b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetHoleState(TEdge e, OutRec outRec) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetDx(IntPoint pt1, IntPoint pt2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool FirstIsBottomPt(OutPt btmPt1, OutPt btmPt2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private OutPt GetBottomPt(OutPt pp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private OutRec GetLowermostRec(OutRec outRec1, OutRec outRec2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool OutRec1RightOfOutRec2(OutRec outRec1, OutRec outRec2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private OutRec GetOutRec(int idx) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AppendPolygon(TEdge e1, TEdge e2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ReversePolyPtLinks(OutPt pp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SwapSides(TEdge edge1, TEdge edge2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SwapPolyIndexes(TEdge edge1, TEdge edge2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void IntersectEdges(TEdge e1, TEdge e2, IntPoint pt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DeleteFromSEL(TEdge e) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessHorizontals() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetHorzDirection(
      TEdge HorzEdge,
      out Direction Dir,
      out long Left,
      out long Right)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessHorizontal(TEdge horzEdge) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private TEdge GetNextInAEL(TEdge e, Direction Direction) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsMinima(TEdge e) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsMaxima(TEdge e, double Y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsIntermediate(TEdge e, double Y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal TEdge GetMaximaPair(TEdge e) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal TEdge GetMaximaPairEx(TEdge e) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ProcessIntersections(long topY) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BuildIntersectList(long topY) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool EdgesAdjacent(IntersectNode inode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int IntersectNodeSort(IntersectNode node1, IntersectNode node2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool FixupIntersectionOrder() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessIntersectList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static long Round(double value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static long TopX(TEdge edge, long currentY) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void IntersectPoint(TEdge edge1, TEdge edge2, out IntPoint ip) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessEdgesAtTopOfScanbeam(long topY) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DoMaxima(TEdge e) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ReversePaths(List<List<IntPoint>> polys) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Orientation(List<IntPoint> poly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int PointCount(OutPt pts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BuildResult(List<List<IntPoint>> polyg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BuildResult2(PolyTree polytree) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FixupOutPolyline(OutRec outrec) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FixupOutPolygon(OutRec outRec) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private OutPt DupOutPt(OutPt outPt, bool InsertAfter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetOverlap(long a1, long a2, long b1, long b2, out long Left, out long Right) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool JoinHorz(
      OutPt op1,
      OutPt op1b,
      OutPt op2,
      OutPt op2b,
      IntPoint Pt,
      bool DiscardLeft)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool JoinPoints(Join j, OutRec outRec1, OutRec outRec2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int PointInPolygon(IntPoint pt, List<IntPoint> path) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int PointInPolygon(IntPoint pt, OutPt op) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool Poly2ContainsPoly1(OutPt outPt1, OutPt outPt2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FixupFirstLefts1(OutRec OldOutRec, OutRec NewOutRec) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FixupFirstLefts2(OutRec innerOutRec, OutRec outerOutRec) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FixupFirstLefts3(OutRec OldOutRec, OutRec NewOutRec) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static OutRec ParseFirstLeft(OutRec FirstLeft) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void JoinCommonEdges() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateOutPtIdxs(OutRec outrec) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DoSimplePolygons() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Area(List<IntPoint> poly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal double Area(OutRec outRec) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal double Area(OutPt op) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<List<IntPoint>> SimplifyPolygon(List<IntPoint> poly, PolyFillType fillType = PolyFillType.pftEvenOdd) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<List<IntPoint>> SimplifyPolygons(
      List<List<IntPoint>> polys,
      PolyFillType fillType = PolyFillType.pftEvenOdd)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double DistanceSqrd(IntPoint pt1, IntPoint pt2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double DistanceFromLineSqrd(IntPoint pt, IntPoint ln1, IntPoint ln2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool SlopesNearCollinear(
      IntPoint pt1,
      IntPoint pt2,
      IntPoint pt3,
      double distSqrd)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool PointsAreClose(IntPoint pt1, IntPoint pt2, double distSqrd) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static OutPt ExcludeOp(OutPt op) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<IntPoint> CleanPolygon(List<IntPoint> path, double distance = 1.415) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<List<IntPoint>> CleanPolygons(List<List<IntPoint>> polys, double distance = 1.415) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static List<List<IntPoint>> Minkowski(
      List<IntPoint> pattern,
      List<IntPoint> path,
      bool IsSum,
      bool IsClosed)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<List<IntPoint>> MinkowskiSum(
      List<IntPoint> pattern,
      List<IntPoint> path,
      bool pathIsClosed)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static List<IntPoint> TranslatePath(List<IntPoint> path, IntPoint delta) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<List<IntPoint>> MinkowskiSum(
      List<IntPoint> pattern,
      List<List<IntPoint>> paths,
      bool pathIsClosed)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<List<IntPoint>> MinkowskiDiff(List<IntPoint> poly1, List<IntPoint> poly2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<List<IntPoint>> PolyTreeToPaths(PolyTree polytree) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void AddPolyNodeToPaths(
      PolyNode polynode,
      Clipper.NodeType nt,
      List<List<IntPoint>> paths)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<List<IntPoint>> OpenPathsFromPolyTree(PolyTree polytree) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<List<IntPoint>> ClosedPathsFromPolyTree(PolyTree polytree) => throw null;

    internal enum NodeType
    {
      ntAny,
      ntOpen,
      ntClosed,
    }
  }
}
