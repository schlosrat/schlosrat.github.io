// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.BillboardCellFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.BillboardSystem;
using AwesomeTechnologies.Utility.Quadtree;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  public class BillboardCellFactory
  {
    public float CellSize;
    public QuadTree<BillboardCell> BillboardCellQuadTree;
    public List<BillboardCell> BillboardCellList;
    public List<IVegetationStudioTerrain> VegetationStudioTerrainList;
    public TerrainType TerrainType;
    private const float polarSphereWidth = 360f;
    private const float polarSphereHeight = 360f;
    public float PolarSphereRadius;
    public float BillboardCellSize;
    public Bounds VegetationSystemBounds;
    public float SeaLevel;
    public bool ExcludeSeaLevelCells;
    public VegetationSystemPro VegetationSystemPro;
    private readonly List<BillboardCell> _existingBillboardCellList;
    private readonly List<BillboardCell> _newBillboardCellList;
    private readonly Rect _polarWorldRect;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateBillboardCells(
      Rect rect,
      List<BillboardCell> overlapBillboardCellList,
      List<BillboardCell> newBillboardCellList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreatePolarBillboardCells(
      Rect rect,
      List<BillboardCell> overlapBillboardCellList,
      List<BillboardCell> newBillboardCellList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private BillboardCell CellExists(int x, int y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PrepareBillboardCells(List<BillboardCell> prepareList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCellBounds(List<BillboardCell> newBillboardCellList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateFlatBillboardCells(Rect rect) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateBillboardCells(Bounds bounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateBillboardCells(Bounds bounds, List<BillboardCell> overlapBillboardCellList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BillboardCellFactory() => throw null;
  }
}
