// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.VegetationCellFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.Utility.Quadtree;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  public class VegetationCellFactory
  {
    public float CellSize;
    public QuadTree<VegetationCell> VegetationCellQuadTree;
    public List<VegetationCell> VegetationCellList;
    public List<IVegetationStudioTerrain> VegetationStudioTerrainList;
    public TerrainType TerrainType;
    public VegetationCellType VegetationCellType;
    private const float polarSphereWidth = 360f;
    private const float polarSphereHeight = 360f;
    public float PolarSphereRadius;
    public float VegetationCellSize;
    public float CellSizeMultiplier;
    public Bounds VegetationSystemBounds;
    public float SeaLevel;
    public bool ExcludeSeaLevelCells;
    public VegetationSystemPro VegetationSystemPro;
    private readonly List<VegetationCell> _existingVegetationCellList;
    private readonly List<VegetationCell> _newVegetationCellList;
    private readonly Rect _polarWorldRect;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateVegetationCells(Rect rect, List<VegetationCell> overlapVegetationCellList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreatePolarVegetationCells(
      Rect rect,
      List<VegetationCell> overlapVegetationCellList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private VegetationCell CellExists(int x, int y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private VegetationCell CellExists(int x, int y, List<VegetationCell> cellList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PrepareVegetationCells(List<VegetationCell> prepareList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCellBounds(List<VegetationCell> newVegetationCellList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateFlatVegetationCells(Rect rect) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateVegetationCells(Bounds bounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateVegetationCells(Bounds bounds, List<VegetationCell> overlapVegetationCellList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationCellFactory() => throw null;
  }
}
