// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ConfigurableJointInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class ConfigurableJointInfo
  {
    public PartBehavior host;
    public PartBehavior target;
    public PartOwnerBehavior.JointConnectionType connectionType;
    public AttachNodeType nodeType;
    public AttachNodeData attachNode;
    public Rigidbody connectedBody;
    private bool autoConfigureConnectedAnchor;
    private bool configuredInWorldSpace;
    private float breakForce;
    private float breakTorque;
    public Vector3 anchor;
    private Vector3 axis;
    private Vector3 secondaryAxis;
    public Vector3 connectedAnchor;
    private Vector3 targetVelocity;
    private Vector3 targetPosition;
    private Vector3 targetAngularVelocity;
    private ConfigurableJointMotion angularXMotion;
    private ConfigurableJointMotion angularYMotion;
    private ConfigurableJointMotion angularZMotion;
    private ConfigurableJointMotion xMotion;
    private ConfigurableJointMotion yMotion;
    private ConfigurableJointMotion zMotion;
    private JointDrive xDrive;
    private JointDrive yDrive;
    private JointDrive zDrive;
    private JointDrive angularXDrive;
    private JointDrive angularYZDrive;
    private RotationDriveMode rotationDriveMode;
    private SoftJointLimit linearLimit;
    private SoftJointLimit highAngularXLimit;
    private SoftJointLimit lowAngularXLimit;
    private SoftJointLimit angularYLimit;
    private SoftJointLimit angularZLimit;
    private SoftJointLimitSpring linearLimitSpring;
    private SoftJointLimitSpring angularXLimitSpring;
    private SoftJointLimitSpring angularYZLimitSpring;
    private Quaternion targetRotation;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StoreJointConnection(PartOwnerBehavior.JointConnection jointConnection) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RestoreJointConnection(PartOwnerBehavior.JointConnection jointConnection) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StoreInfo(ConfigurableJoint joint) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RestoreJoint(ConfigurableJoint joint) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ConfigurableJointInfo() => throw null;
  }
}
