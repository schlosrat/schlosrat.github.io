// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PartOwnerBehavior
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class PartOwnerBehavior : 
    ViewObjectComponent<PartOwnerComponent>,
    IEnumerable<PartBehavior>,
    IEnumerable,
    ILateUpdate
  {
    private RigidbodyBehavior _rigidBody;
    private bool _childPhysXStarted;
    private bool _ownerPhysXStarted;
    [SerializeField]
    private List<PartOwnerBehavior.JointConnection> jointConnections;
    private List<PartOwnerBehavior.JointConnection> _strutJointConnections;
    private List<ConfigurableJoint> _tempJointStorage;
    private static List<AttachNodeData> _tempAttachNodeStorage;
    private Vector3d _gravityInPhysicsSpace;
    private bool _isGravityInPhysicsSpaceDirty;
    private bool _isJointConnectionsDirty;
    public Vector3 CenterOfMass;
    private HandOfKraken _handOfKraken;

    public JointOptimization jointOptimization
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool VisualizeJoints
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public PartOwnerComponent Model
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public event Action<PartBehavior> PartRemoved
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public System.Type ModelType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private RigidbodyBehavior rigidBody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsChildPhysXStarted
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsOwnerPhysXStarted
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IEnumerable<PartBehavior> Parts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int PartsCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int JointsCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IEnumerable<PartOwnerBehavior.JointConnection> JointConnections
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsHandOfKrakenCorrectingOrbit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Position HandOfKrakenExpectedPos
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsHandOfKrakenEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    internal bool IsHandOfKrakenTryingToCorrect
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    internal bool IsHandOfKrakenOrbitCorrectInStandOff
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    internal bool HasHandOfKrakenGotExpectedOrbit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    internal bool IsHandOfKrakenOrbitUnderAcceleration
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SyncTo(PartOwnerComponent simObjectComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Destroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartsChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsAllPartsCreated() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool VerifyStopPhysX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool VerifyPackPhysX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool VerifyUnpackPhysX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StopPhysX(Transform parent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PackPhysX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnpackPhysX(bool force = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartBehavior GetPartViewComponent(PartComponent partSimComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetPartViewComponent(IGGuid guid, out PartBehavior partViewComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetMassAverages(out Vector3 centerOfMass, out Vector3 velocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetJointsUnbreakable(bool isUnbreakable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void RecreateJoints(
      PartBehavior rootView,
      ref Stack<IGGuid> parentHistory,
      ref HashSet<IGGuid> processHistory)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateJoints(
      PartBehavior rootView,
      ref Stack<IGGuid> parentHistory,
      ref HashSet<IGGuid> processHistory)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal PartOwnerBehavior.JointConnection CreateJointsBetweenParts(
      PartBehavior hostPartView,
      PartBehavior connectedPartView,
      AttachNodeData node,
      bool isRigid,
      PartOwnerBehavior.JointConnectionType connectionType,
      AttachNodeType nodeType)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void GetJointBreakLimits(
      PartBehavior hostPartView,
      PartBehavior connectedPartView,
      AttachNodeData node,
      bool isRigid,
      out float breakForce,
      out float breakTorque,
      out float stiffness)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float CalculateMaximumJointTorque() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DestroyJoints() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetJointConnection(
      PartBehavior hostView,
      PartBehavior targetView,
      AttachNodeType attachNodeType,
      out PartOwnerBehavior.JointConnection result)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetJointConnection(
      ConfigurableJoint joint,
      out PartOwnerBehavior.JointConnection result)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BreakJointConnection(PartOwnerBehavior.JointConnection jointConnection) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveDisconnectedJointConnections(bool waitaFrame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator CoroutineRemoveDisconnectedJointConnections() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveDisconnectedJointConnections() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void StoreStrutJointData(PartOwnerBehavior.JointConnection joint) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void RemoveStrutJointData(PartOwnerBehavior.JointConnection joint) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemovePart(PartBehavior part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetUnbreakableJoints() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetGravityForceAtCurrentPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateJointVisualizations() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void ILateUpdate.OnLateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator<PartBehavior> GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    IEnumerator IEnumerable.GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetAllRigidbodyAndJointTransforms() => throw null;

    [ContextMenu("Enable Orbit Override when no Acceleration")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableHandOfKraken() => throw null;

    [ContextMenu("Disable Orbit Override when no Acceleration")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisableHandOfKraken() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StartHandOfKrakenOrbitCorrectStandOff() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartOwnerBehavior() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PartOwnerBehavior() => throw null;

    public enum JointConnectionType
    {
      Physical,
      Virtual,
    }

    [Serializable]
    public class JointConnection
    {
      public PartBehavior host;
      public PartBehavior target;
      public IEnumerable<ConfigurableJoint> Joints;
      public DebugShapesDraw.Sphere[] visualJoints;
      public PartOwnerBehavior.JointConnectionType connectionType;
      public AttachNodeType nodeType;
      public AttachNodeData AttachNode;
      public float BreakForce;
      public float BreakTorque;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public JointConnection() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public JointConnection(
        PartBehavior hostView,
        PartBehavior connectedView,
        IEnumerable<ConfigurableJoint> newJoints,
        float breakForce,
        float breakTorque,
        PartOwnerBehavior.JointConnectionType connectionType,
        AttachNodeData attachNode,
        AttachNodeType nodeType = AttachNodeType.Stack)
      {
        throw null;
      }
    }
  }
}
