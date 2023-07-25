// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.BillboardSystem.BillboardCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.Utility.Quadtree;
using AwesomeTechnologies.VegetationSystem;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.BillboardSystem
{
  public class BillboardCell : IHasRect
  {
    public Bounds BilllboardCellBounds;
    public List<VegetationPackageBillboardInstances> VegetationPackageBillboardInstancesList;
    public List<VegetationCell> OverlapVegetationCells;
    public int Index;
    public bool Prepared;
    public bool Loaded;
    public int xIndex;
    public int yIndex;
    public bool FlagForRemoval;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearCache() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearCache(int vegetationPackageIndex, int vegetationItemIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BillboardCell(Rect rectangle, float centerY, float sizeY) => throw null;

    public Rect Rectangle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BoundingSphere GetBoundingSphere() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BoundingSphere GetPolarBoundingSphere(float radius, Vector3 polarSpherePosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PrepareBillboardCell(
      List<VegetationPackagePro> vegetationPackageProList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DrawPolarVegetationCellGizmo(
      BillboardCell vegetationCell,
      float sphereRadius,
      Vector3 spherePosition)
    {
      throw null;
    }
  }
}
