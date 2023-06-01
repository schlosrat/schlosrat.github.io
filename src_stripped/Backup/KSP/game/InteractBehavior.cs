// Decompiled with JetBrains decompiler
// Type: KSP.Game.InteractBehavior
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Messages;
using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace KSP.Game
{
  public class InteractBehavior : SpatialBehavior
  {
    [SerializeField]
    private List<InteractInstance> _instances;
    private List<AsyncOperationHandle<InteractPreset>> _loadedInteractPresetAsyncHandles;
    public Action<InteractBehavior, InteractInstance, InteractPreset> OnUsed;
    private PartOwnerComponent part;
    private bool _needParentFetched;

    public IGGuid partOwnerGuid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Use(InteractInstance instance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InteractInstance FindFirstInstance(InteractPreset interactPreset, bool includeDisabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InteractInstance FindFirstInstance(bool includeDisabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Unregister(SpatialInstance instance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Register(SpatialInstance instance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadInteractPresetsAsync() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ReleaseLoadedInteractPresets() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselCreated(MessageCenterMessage curMCM) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static InteractInstance FindFirstInstanceInChildren(
      Transform objectTransform,
      bool includeDisabled)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InteractBehavior() => throw null;
  }
}
