// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPVehicleJoint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using EdyCommonTools;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Utility/Vehicle Joint", 0)]
  public class VPVehicleJoint : MonoBehaviour
  {
    public Transform thisAnchor;
    public Transform otherAnchor;
    public VPVehicleJoint.UpdateMode updateMode;
    public bool enableCollision;
    public bool restorePoseOnDisable;
    [Header("Linear Constraints")]
    public VPVehicleJoint.JointMotion xMotion;
    public VPVehicleJoint.JointMotion yMotion;
    public VPVehicleJoint.JointMotion zMotion;
    public float maxDistance;
    [Header("Angular Constraints")]
    public VPVehicleJoint.AngularJointMotion angularXMotion;
    public VPVehicleJoint.AngularJointMotion angularYMotion;
    public VPVehicleJoint.AngularJointMotion angularZMotion;
    [HelpBox("These are used in Damped Spring constraints. Require Update Mode = On Fixed Update to be modified in runtime.", HelpBoxMessageType.None)]
    [Header("Target Pose")]
    public Vector3 targetPosition;
    public Quaternion targetRotation;
    public bool resetFrameOnEnable;
    [Header("Advanced")]
    public bool propagateIsKinematic;
    [Space(5f)]
    public VPVehicleJoint.MatchInertiaMode matchInertiaMode;
    [Range(0.05f, 3f)]
    public float matchInertiaFactor;
    public bool resetInertiaOnDisable;
    [Space(5f)]
    public VPVehicleJoint.DebugLabel debugLabel;
    private Rigidbody m_thisRigidbody;
    private Rigidbody m_otherRigidbody;
    private bool m_isChildRigidbody;
    private ConfigurableJoint m_joint;
    private Vector3 m_thisInertiaTensor;
    private Vector3 m_otherInertiaTensor;
    private float m_thisMass;
    private float m_otherMass;
    private VPVehicleJoint.MatchInertiaMode m_prevInertiaMode;
    private float m_prevInertiaFactor;
    private VPVehicleJoint m_parentJoint;
    private Vector3 m_referencePosition;
    private Quaternion m_referenceRotation;
    private VehicleBase m_vehicle;

    public Vector3 referencePosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Quaternion referenceRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 thisAnchorPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 otherAnchorPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public ConfigurableJoint joint
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Rigidbody thisRigidbody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Rigidbody otherRigidbody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FixedUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ConfigureJoint() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckForDeprecations() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MatchInertia(bool firstRun = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCollisionEnter(Collision collision) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCollisionStay(Collision collision) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDrawGizmos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPVehicleJoint() => throw null;

    public enum UpdateMode
    {
      OnEnable,
      OnFixedUpdate,
      OnFixedUpdateInEditorOnly,
    }

    public enum MatchInertiaMode
    {
      None,
      ConnectedMasses,
      ConnectedInertia,
    }

    public enum DebugLabel
    {
      None,
      ForceAndTorque,
      MassAndInertia,
    }

    [Serializable]
    public class JointMotion
    {
      public VPVehicleJoint.JointMotion.Mode mode;
      public float spring;
      public float damper;
      public float maxForce;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ConfigurableJointMotion GetJointMotion(float maxDistance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static SoftJointLimit GetJointLimit(float maxDistance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public JointDrive GetJointDrive() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public JointMotion() => throw null;

      public enum Mode
      {
        Locked,
        Free,
        DampedSpring,
      }
    }

    [Serializable]
    public class AngularJointMotion
    {
      public VPVehicleJoint.AngularJointMotion.Mode mode;
      public float spring;
      public float damper;
      public float maxForce;
      public float maxAngle;
      [Obsolete("Limit is deprecated. Use DampedSpring with maxAngle > 0")]
      public float limit;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ConfigurableJointMotion GetJointMotion() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public SoftJointLimit GetJointLimit() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public JointDrive GetJointDrive() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public AngularJointMotion() => throw null;

      public enum Mode
      {
        Locked,
        Free,
        DampedSpring,
      }
    }
  }
}
