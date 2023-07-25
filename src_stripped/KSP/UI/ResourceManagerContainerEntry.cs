// Decompiled with JetBrains decompiler
// Type: KSP.UI.ResourceManagerContainerEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Sim.impl;
using KSP.Sim.ResourceSystem;
using System.Runtime.CompilerServices;

namespace KSP.UI
{
  public class ResourceManagerContainerEntry : ApiDataContext
  {
    [DataProperty("ResourceAbbreviation")]
    public Property<string> ResourceAbbreviation;
    [DataProperty("CurAmount")]
    public PropertyExternal<float> CurAmount;
    [DataProperty("TotalAmount")]
    public PropertyExternal<float> TotalAmount;
    [DataProperty("Units")]
    public PropertyExternal<string> ResUnits;
    [DataProperty("AmountNormalized")]
    public PropertyExternal<float> AmountNormalized;
    [DataProperty("IsInFlowStateOn")]
    public Property<bool> IsInFlowStateOn;
    [DataProperty("IsOutFlowStateOn")]
    public Property<bool> IsOutFlowStateOn;
    [DataProperty("IsBalanceFlowStateOn")]
    public Property<bool> IsBalanceFlowStateOn;
    private ResourceManagerUI _resourceManagerUI;
    private ResourceManagerPartEntry _parentPartEntry;
    private FlowState _currFlowState;
    private FlowState _prevFlowState;
    private ResourceDefinitionData _definition;
    private IResourceContainer _container;

    public ResourceManagerPartEntry ParentPartEntry
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ResourceDefinitionID ResourceID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string ResourceName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public FlowState ContainerFlowState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceManagerContainerEntry(
      ResourceManagerUI resourceManagerUI,
      ResourceManagerPartEntry partEntry,
      VesselComponent activeVessel,
      IResourceContainer container,
      ResourceDefinitionData definition)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFlowState(FlowState flowState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitEntry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void Cleanup(VesselComponent activeVessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetStoredUnits() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetCapacityUnits() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetUnits(string resourceName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetUnitAmountNormalized() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ValidateExternalProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnIsInFlowStateChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnIsOutFlowStateChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnIsBalanceFlowStateChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateFlowState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnResourceRequestsUpdated() => throw null;
  }
}
