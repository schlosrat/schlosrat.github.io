// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_CargoBay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Messages;
using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_CargoBay : PartBehaviourModule
  {
    [FormerlySerializedAs("data")]
    [SerializeField]
    protected Data_CargoBay dataCargoBay;
    private Data_Deployable _dataDeployable;
    private List<PartBehavior> _connectingParts;
    private List<Module_CargoBay> _connectedCargoBays;
    private List<PartCollider> _ownColliders;
    private List<PartBehavior> _partsInCargo;
    private List<PartBehavior> _partsInCargoPrev;
    private Collider _bayCollider;
    private AttachNodeData _nodeOuterFore;
    private AttachNodeData _nodeOuterAft;
    private AttachNodeData _nodeInnerFore;
    private AttachNodeData _nodeInnerAft;
    private RaycastHit _hitInfo;
    protected int _layerMask;
    private WaitUntil _waitForVessel;
    private bool _isClosed;
    private bool _enableShieldedVolumeAfterColliderReset;

    public override System.Type PartComponentModuleType
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
    public void OnStartFinished() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartModuleActionActivated(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLookupRadius(float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLookupCenter(Vector3 p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FindAttachNodes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FindBayColliders(
      PartBehavior originalPart,
      Module_CargoBay origin,
      List<PartCollider> cList,
      List<Module_CargoBay> cBays)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<AttachNodeData> FindConnectingNodes(PartBehavior origin) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private AttachNodeData GetOpposingNode(PartBehavior origin) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ScheduleColliderReset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator ScheduledColliderResetCoroutine() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExecuteColliderReset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ColliderReset(bool enableShieldedVolume) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ColliderListCleanUp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<PartBehavior> FindEnclosedParts(
      List<PartBehavior> parts,
      List<PartCollider> ownColliders)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool PartWithinBounds(PartBehavior p, List<PartCollider> ownColliders) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<PartBehavior> FindNearbyParts(float radius, Vector3 center) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnableShieldedVolume() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisableShieldedVolume() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupDynamicCargoOccluders(bool testActive) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void setupDynamicOccluders(IEnumerable<IPartModule> modules, bool testActive) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShieldEnclosedParts(List<PartBehavior> enclosedParts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnShieldEnclosedParts(List<PartBehavior> enclosedParts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ModifyShieldInEnclosedParts(bool shieldStatus) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<PartCollider> FindPartColliders(PartBehavior p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddConnectingPart(PartBehavior p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearConnectingParts() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ScheduleColliderResetForAllBays() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ClosedAndLocked() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SelfClosedAndLocked() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected bool EndCapped() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void CheckClosedStatus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected bool TestAttachmentFit(AttachNodeData n) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_CargoBay() => throw null;
  }
}
