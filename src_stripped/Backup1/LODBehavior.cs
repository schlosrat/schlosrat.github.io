// Decompiled with JetBrains decompiler
// Type: LODBehavior
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LODBehavior : MonoBehaviour
{
  public LODBehavior.LODLevel lod;
  public bool grabRenderersOnStart;
  [Tooltip("If true, bounds will be recalculated every frame. For optimization, set this to false if the bounds are known to always be the same")]
  public bool alwaysUpdateBounds;
  private Dictionary<CullingGroup, bool> lodRequests;
  private Bounds bounds;
  private Renderer[] renderers;
  private int sparseCullingIndex;
  private ICullingGroupManager cullingManager;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected virtual void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateCullingSphere() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void GrabRenderers() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetCullingManager(ICullingGroupManager manager) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void RemoveLODRequest(CullingGroup group) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetLODRequest(CullingGroup group, bool isVisible) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnCullingGroupStateChanged(CullingGroup group, CullingGroupEvent groupEvent) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateCulling() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ToggleLODComponents(bool isVisible) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateBounds() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDrawGizmosSelected() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public LODBehavior() => throw null;

  [Serializable]
  public class LODLevel
  {
    public List<Behaviour> componentsToDisable;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LODLevel() => throw null;
  }
}
