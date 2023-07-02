// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_DockingNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Messages;
using KSP.OAB;
using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using KSP.VFX;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  public class Module_DockingNode : PartBehaviourModule
  {
    public const float NEARBY_VESSEL_QUERY_RANGE_METERS = 1000f;
    [SerializeField]
    protected Data_DockingNode _dataDockingNode;
    private PartComponentModule_DockingNode _dockingComponent;
    private Transform _dockingTransform;
    private Transform _controlTransform;
    private Module_DockingNode _otherDockingModule;
    private List<VesselComponent> _tempNearbyVesselStorage;
    private List<PartComponentModule_DockingNode> _tempDockingModulesOnVessel;
    private ModuleAction _actionUndock;
    private ModuleAction _actionControlFromHere;
    private ModuleAction _actionSetAsTarget;
    private ModuleAction _actionDebugAlign;
    private Module_DockingNode.DockingNodeAcquireForce _acquireForce;
    private Module_DockingNode.DockingNodeAcquireTorque _acquireTorque;
    private Module_DockingNode.DockingNodeAcquireTorque _acquireTorqueRoll;
    private SubscriptionHandle _vesselChangedHandle;
    private Data_Deployable _dataDeployable;
    private Module_Deployable _moduleDeployable;
    private bool _hasDeployableModule;
    private IObjectAssemblyPartNode _deployableAttachNode;
    private AttachNodeData _dynamicAttachNodeData;
    private const double _minNodeSizeForMultiJoint = 1.0;
    private const int _amountOfJointsPerMultiNode = 3;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsDocked
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleFixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFixedUpdateReadyState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFixedUpdateDisengagedState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFixedUpdateAcquireDockeeState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFixedUpdateAcquireDockerState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ValidateDockingConfiguration(
      Module_DockingNode docker,
      Module_DockingNode dockee,
      out bool isWithinAcquireRange,
      out bool isWithinAcquireAngle,
      out bool isWithinCaptureVelocity)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetForces() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ApplyAcquireForces(Module_DockingNode otherDockingNode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryGetAttachedPart(out PartComponent attachedPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Transform GetDockingTransform() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSetAsTarget() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnControlFromHere() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDebugAlignToTarget() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Transform GetViewObjectTransform(
      SimulationObjectModel simObject,
      out Module_DockingNode outputDockingModule)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DockToModule(Module_DockingNode otherDockingModule) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ActivateUndockVFX(
      PartBehavior part,
      string explosiveNodeId,
      FXDockingContextualEvent vfxEvent,
      ContextualFxSystem vfxSystem)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AlignToTransform(Transform otherDockingTransform, float forwardOffsetScalar) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Undock() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UndockInternal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnActiveVesselChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePropertyAndActionEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetDistTo(Vector3 worldPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetDotProductWith(Vector3 targetForwardVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetRelativeVelocityTo(IMotionFrame targetFrame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsValidDockingConfiguration(string dockerGuidString, string dockeeGuidString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DockModules(string dockerGuidString, string dockeeGuidString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static PartBehavior GetPartBehavior(string guidString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UndockModule(string dockedGuidString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDeployStateChanged(bool isDeployed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ObjectAssemblyAvailablePartNode CreateOABFloatingAttachNode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private AttachNodeDefinition CreateFlightFloatingAttachNode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartPlaced(MessageCenterMessage partPlacedMessage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartSeparated(MessageCenterMessage partPlacedMessage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAnimationEnded(MessageCenterMessage mcm) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_DockingNode() => throw null;

    private class DockingNodeAcquireTorque : ITorque
    {
      public ForceType TorqueMode
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public Vector3d RelativeTorque
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public DockingNodeAcquireTorque(Vector3d relativeTorque) => throw null;
    }

    private class DockingNodeAcquireForce : IForce
    {
      public ForceType ForceMode
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public Vector3d RelativeForce
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public Vector3d RelativePosition
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public DockingNodeAcquireForce(Vector3d relativeForce, Vector3d relativePosition) => throw null;
    }
  }
}
