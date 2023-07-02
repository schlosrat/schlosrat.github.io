// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Common.VisibleVegetationCellSelector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.Common
{
  public class VisibleVegetationCellSelector
  {
    private VegetationSystemPro _vegetationSystemPro;
    public VisibleVegetationCellSelector.MultiOnVegetationCellVisibleDelegate OnVegetationCellVisibleDelegate;
    public VisibleVegetationCellSelector.MultiOnVegetationCellInvisibleDelegate OnVegetationCellInvisibleDelegate;
    [NonSerialized]
    public readonly List<SelectedVegetationCell> VisibleSelectorVegetationCellList;
    private bool _useTransformCameras;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VisibleVegetationCellSelector(bool useTransformCameras) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(VegetationSystemPro vegetationSystemPro) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddVisibleVegetationCells() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private SelectedVegetationCell GetSelectorVegetationCell(VegetationCell vegetationCell) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddVisisbleCellsFromCamera(VegetationStudioCamera vegetationStudioCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveVisisbleCellsFromCamera(VegetationStudioCamera vegetationStudioCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAddCamera(VegetationStudioCamera vegetationStudioCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRemoveCamera(VegetationStudioCamera vegetationStudioCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawDebugGizmos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Color SelectVegetationCellGizmoColor(int count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVegetationCellDistanceBandChanged(
      VegetationStudioCamera vegetationStudioCamera,
      VegetationCell vegetationCell,
      int currentDistanceBand,
      int previousDistanceBand)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVegetationCellVisible(
      VegetationStudioCamera vegetationStudioCamera,
      VegetationCell vegetationCell)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVegetationCellInvisible(
      VegetationStudioCamera vegetationStudioCamera,
      VegetationCell vegetationCell)
    {
      throw null;
    }

    public delegate void MultiOnVegetationCellVisibleDelegate(VegetationCell vegetationCell);

    public delegate void MultiOnVegetationCellInvisibleDelegate(VegetationCell vegetationCell);
  }
}
