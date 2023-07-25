// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.PartBehaviourModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.OAB;
using KSP.Sim.impl;
using KSP.Sim.ResourceSystem;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.Definitions
{
  [Serializable]
  public abstract class PartBehaviourModule : 
    KerbalMonoBehaviour,
    IPartModule,
    IFixedUpdate,
    IPriorityOverride,
    IUpdate,
    IObjectAssemblyPartModule
  {
    public ModuleDataList DataModules;
    public List<ModuleActionGroupAction> ModuleActions;
    private Data_ModuleActions dataActionMappings;
    private PartBehaviourModule.PartBackingModes _cachedBackingMode;
    private PartBehavior _part;
    private PartComponentModule _componentModule;
    private IObjectAssemblyPart _OABPart;
    private SubscriptionHandle _onActionActivateMessageHandle;
    private bool isInitRunning;

    public abstract System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public virtual bool IsActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnInitialize() => throw null;

    public virtual System.Type LegacyWriteOverTarget
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ThermalUpdate(double deltaTime) => throw null;

    public PartBehaviourModule.PartBackingModes PartBackingMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PartBehavior part
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public PartComponentModule ComponentModule
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    protected ResourceFlowRequestBroker resourceFlowRequestBroker
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PartOwnerBehavior partOwner
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public VesselBehavior vessel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ISimulationObjectView simulationObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public ITransformModel transform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool moduleIsEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsInitialized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ModuleAction executedAction
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string GetModuleDisplayName() => throw null;

    [Obsolete]
    public bool stagingEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [Obsolete]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetInfo() => throw null;

    [Obsolete]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsStageable() => throw null;

    [Obsolete]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnActive() => throw null;

    public IObjectAssemblyPart OABPart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnStart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLegacyData(PartBehavior part, ISimulationObjectView simObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitForDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDataModuleValues(SerializedPartModule spm) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void InitForNewOABPart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void RemoveResourceRequest(ResourceFlowRequestHandle handle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnAnimStateEnter(Animator animator, int stateMachinePathHash) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnAnimStateExit(Animator animator, int stateMachinePathHash) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected bool IsPhysXEnabled() => throw null;

    public bool IsLocallyAuthorized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    int IPriorityOverride.ExecutionPriorityOverride
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnFixedUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnModuleFixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnModuleOABFixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnModuleUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnModuleOABUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnActionActivateEventMessage(MessageCenterMessage actionActivateMessage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void AddActionGroupAction(ModuleActionGroupAction action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void AddActionGroupAction(
      Action<bool> action,
      KSPActionGroup defaultActionGroup,
      string displayName,
      ModuleProperty<bool> stateProperty = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void AddActionGroupAction(
      Action action,
      KSPActionGroup defaultActionGroup,
      string displayName)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void OnActionGroupMappingChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetRendererMaterialsByName(
      List<string> materialNames,
      out List<Material> foundMaterials)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected PartBehaviourModule() => throw null;

    public enum PartBackingModes
    {
      None,
      Flight,
      OAB,
    }
  }
}
