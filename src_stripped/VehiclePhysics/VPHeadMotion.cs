// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPHeadMotion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Effects/Head Motion", 20)]
  public class VPHeadMotion : MonoBehaviour
  {
    public VPHeadMotion.UpdateMode updateMode;
    [Header("Inertial motion")]
    public VPHeadMotion.HorizontalMotion longitudinal;
    public VPHeadMotion.HorizontalMotion lateral;
    public VPHeadMotion.VerticalMotion vertical;
    [Space(5f)]
    public float tiltRadius;
    [Space(5f)]
    public float maxDistance;
    public float maxTiltAngle;
    [Space(5f)]
    public float inertialMass;
    public bool useGravity;
    private Rigidbody m_rigidbody;
    private Rigidbody m_parentRigidbody;
    private Vector3 m_anchorPosition;
    private Vector3 m_originalPosition;
    private Quaternion m_originalRotation;
    private ConfigurableJoint m_joint;
    private SoftJointLimit m_limit;

    public Rigidbody motionBody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 localPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FixedUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ConfigureJointAndBody() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPHeadMotion() => throw null;

    public enum UpdateMode
    {
      OnEnable,
      OnFixedUpdate,
      OnFixedUpdateInEditorOnly,
    }

    [Serializable]
    public class HorizontalMotion
    {
      public VPHeadMotion.HorizontalMotion.Mode mode;
      public float springRate;
      public float damperRate;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ConfigurableJointMotion GetLinealMotion() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ConfigurableJointMotion GetAngularMotion() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public JointDrive GetLinealDrive() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public JointDrive GetAngularDrive() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public HorizontalMotion() => throw null;

      public enum Mode
      {
        Disabled,
        Tilt,
        Slide,
      }
    }

    [Serializable]
    public class VerticalMotion
    {
      public VPHeadMotion.VerticalMotion.Mode mode;
      public float springRate;
      public float damperRate;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ConfigurableJointMotion GetLinealMotion() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public JointDrive GetLinealDrive() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public VerticalMotion() => throw null;

      public enum Mode
      {
        Disabled,
        Slide,
      }
    }
  }
}
