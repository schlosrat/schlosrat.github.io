// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.PredictiveCellLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  [Serializable]
  public class PredictiveCellLoader
  {
    private readonly VegetationSystemPro _vegetationSystemPro;
    public readonly List<VegetationCell> PreloadVegetationCellList;
    private readonly List<VegetationCell> _tempPreloadList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PredictiveCellLoader(VegetationSystemPro vegetationSystemPro) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetCellsToLoad(List<VegetationCell> preloadList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private VegetationCell GetFirstUnloadedCell() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PreloadArea(Rect rect) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveCellsFlaggedForRemoval() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PreloadArea(Rect rect, List<VegetationCell> overlapVegetationCellList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PreloadArea(Vector3 position, float radiusMeter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PreloadAllVegetationCells() => throw null;
  }
}
