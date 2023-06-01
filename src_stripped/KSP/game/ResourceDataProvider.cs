// Decompiled with JetBrains decompiler
// Type: KSP.Game.ResourceDataProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public class ResourceDataProvider : DataBus<VesselComponent>
  {
    private ContextListProperty<ResourceInfoDataContext> NonStageableResources;
    private StagingComponent _stagingComponent;
    public PropertyExternal<bool> NonStageableResourcesVisible;
    private bool _nonStageableResourcesUIVisible;
    private bool _resourceManagerUIVisible;

    public ContextListProperty<PartContainersDataContext> PartContainers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SyncTo(VesselComponent dataSource) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void InitializeData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStagingStackChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnResourceRequestsUpdated() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetResourcesInParts() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DefineStagedResources() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DefineNonStageableResources() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsNonStageableResourcesVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNonStageableResourcesVisible(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CloseNonStageableResourceWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsResourceManagerVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceDataProvider() => throw null;
  }
}
