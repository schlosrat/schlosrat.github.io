// Decompiled with JetBrains decompiler
// Type: KSP.Modules.PropellantState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.impl;
using KSP.Sim.ResourceSystem;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Modules
{
  public class PropellantState
  {
    private string _engineID;
    public bool pendingRequest;
    public double currentRequirement;
    public double requiredMass;
    public double normalizedPropellantLevel;
    public double amountReceived;
    public ResourceFlowMode flowMode;
    public ResourceDefinitionID resourceID;
    public ResourceDefinitionData resourceDef;
    public PropellantDefinition propellantDef;
    public ResourceFlowRequestHandle requestHandle;
    public FlowRequestResolutionState ReturnedRequestResolutionState;
    public ResourceFlowRequestCommandConfig engineRequestConfig;
    public double mixtureDensityRecipe;
    public double ratioSum;
    public double massperUnit;
    public ResourceFlowRequestBroker FlowRequestBroker;
    public IResourceContainer[] PartResourceContainer;

    public string engineID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PropellantState(
      IGGuid guid,
      ResourceFlowRequestBroker flowbroker,
      IResourceContainer[] resourceContainer,
      string engineID,
      PropellantDefinition propellantDef)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasNecessaryConnectedResource(ResourceDefinitionID resourceDefinitionID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetConnectedResourceRemaining(ResourceDefinitionID resourceDefinitionID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetConnectedResourceMaxCapacity(ResourceDefinitionID resourceDefinitionID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<ResourceUnitsPair> GetResourceIngredients(ResourceDefinitionID resourceDefinitionID) => throw null;
  }
}
