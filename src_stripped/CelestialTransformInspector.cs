// Decompiled with JetBrains decompiler
// Type: CelestialTransformInspector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CelestialTransformInspector : ExternalUniverseViewUser
{
  [HideInInspector]
  public CelestialTransformInspector.TransformType targetType;
  [HideInInspector]
  public CelestialTransformInspector.TransformType viewerType;
  [HideInInspector]
  public bool viewerRotating;
  [HideInInspector]
  public bool targetRotating;
  public ITransformModel targetTransform;
  public ITransformModel viewerTransform;
  private Dictionary<CelestialTransformInspector.TransformType, List<ITransformModel>> transformsByType;
  private bool transformsByTypeDirty;
  private const float RECACHE_INTERVAL = 2f;
  private float lastRecacheTime;
  private Stack<ITransformModel> scratchStack;
  private bool eventsHooked;
  private static List<ITransformFrame> scratchChain;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public IReadOnlyList<ITransformModel> GetTransformsOfType(
    CelestialTransformInspector.TransformType type)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void HandleLateUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void RecacheTransformsByType() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void AddToCollections(ITransformModel transform) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  private List<ITransformModel> GetList(CelestialTransformInspector.TransformType type) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void HandleUniverseConnected() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateEventHooks(bool hook) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void HandleSimObjectChange(SimulationObjectModel obj) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void HandleUniverseDisconnected() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
  private void ResetTransformsByType() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void GetDropdownEntries(
    CelestialTransformInspector.TransformType selectedType,
    ITransformModel curSelection,
    out int curIndex,
    out string[] entries,
    out IReadOnlyList<ITransformModel> transforms)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static ITransformFrame[] GetParentFrameCache(ITransformFrame frame) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static int FindSharedParentIndex(
    ITransformFrame[] viewerParents,
    ITransformFrame[] targetParents)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static string PrintFrame(ITransformFrame frame, string nameIfNull = "NULL") => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static string PrintViewerTargetHierarchy(
    ITransformFrame viewerFrame,
    ITransformFrame targetFrame,
    CelestialTransformInspector.HierarchyDrawConfig config,
    out bool isError)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public CelestialTransformInspector() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static CelestialTransformInspector() => throw null;

  public enum TransformType
  {
    All,
    SimObjects,
    NonSimObjects,
    SimCelestialBodies,
    SimVessels,
    SimParts,
    Observers,
    ScaledSpaceReferenceFrame,
    PhysicsSpaceReferenceFrame,
    PhysXOrigin,
  }

  public struct HierarchyDrawConfig
  {
    public int indentBase;
    public int indentSize;
    public string levelPrefix;
    public string levelSeperator;
    public string viewerPostfix;
    public string targetPostfix;
  }
}
