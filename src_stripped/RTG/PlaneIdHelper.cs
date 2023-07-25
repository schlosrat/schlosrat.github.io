// Decompiled with JetBrains decompiler
// Type: RTG.PlaneIdHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RTG
{
  public static class PlaneIdHelper
  {
    private static List<PlaneIdHelper.PlaneInfo> _planeInfo;
    private static PlaneId[] _allPlaneIds;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PlaneIdHelper() => throw null;

    public static PlaneId[] AllPlaneIds
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static AxisDescriptor GetFirstAxisDescriptor(
      PlaneId planeId,
      PlaneQuadrantId planeQuadrant)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static AxisDescriptor GetSecondAxisDescriptor(
      PlaneId planeId,
      PlaneQuadrantId planeQuadrant)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static AxisSign GetFirstAxisSign(PlaneId planeId, PlaneQuadrantId planeQuadrant) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static AxisSign GetSecondAxisSign(PlaneId planeId, PlaneQuadrantId planeQuadrant) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static PlaneQuadrantId GetQuadrantFromAxesSigns(
      PlaneId planeId,
      AxisSign firstAxisSign,
      AxisSign secondAxisSign)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int PlaneIdToFirstAxisIndex(PlaneId planeId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int PlaneIdToSecondAxisIndex(PlaneId planeId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static PlaneId NormalAxisIndexToPlaneId(int axisIndex) => throw null;

    private struct PlaneQuadrantInfo
    {
      public PlaneQuadrantId Quadrant;
      public AxisSign FirstAxisSign;
      public AxisSign SecondAxisSign;
    }

    private struct PlaneInfo
    {
      public PlaneId PlaneId;
      public List<PlaneIdHelper.PlaneQuadrantInfo> QuadrantInfo;
    }
  }
}
