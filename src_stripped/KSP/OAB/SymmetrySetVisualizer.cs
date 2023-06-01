// Decompiled with JetBrains decompiler
// Type: KSP.OAB.SymmetrySetVisualizer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Modules;
using KSP.Utilities;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class SymmetrySetVisualizer : IDisposable
  {
    private readonly GameObjectPool<Transform> _visualsPool;
    private readonly List<Transform> _visualsInPlay;
    private readonly GameObject _placeholderVisual;
    private HashSet<ObjectAssemblyPart> _proceduralParts;
    private OABOrderedDictionary<IObjectAssemblyPart, Transform> _singleCopyMap;

    public List<Transform> VisualsInPlay
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public OABOrderedDictionary<IObjectAssemblyPart, Transform> SingleCopyMap
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SymmetrySetVisualizer(GameObject visualPrefab = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void VisualizeSingle(PositionData positionData, IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Visualize(List<PositionData> positions) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void VisualizePart(
      PositionData currentPosition,
      Transform currentVisual,
      bool initProceduralPart)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Hide() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitProceduralPartSymmetryMirror(
      PositionData currentPosition,
      ObjectAssemblyPart part,
      Module_ProceduralPart proceduralPart)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetPartSelectionShader(ObjectAssemblyPart part) => throw null;
  }
}
