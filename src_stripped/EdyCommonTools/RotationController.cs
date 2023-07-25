// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.RotationController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace EdyCommonTools
{
  public class RotationController : MonoBehaviour
  {
    public Transform target;
    public bool rotateInWorldSpace;
    public bool invertHVorder;
    public RotationController.Rotation horizontal;
    public RotationController.Rotation vertical;
    [FormerlySerializedAs("pitch")]
    public RotationController.Rotation roll;
    public RotationController.OnRotationFinished onRotationFinished;
    private Transform m_transform;
    private bool m_isRotating;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTransform() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RotationController() => throw null;

    public delegate void OnRotationFinished();

    [Serializable]
    public class Rotation
    {
      public float angle;
      public RotationController.Rotation.Mode mode;
      public float targetOffset;
      public bool damped;
      public float damping;
      public bool clamped;
      public float minAngle;
      public float maxAngle;
      private float m_currentAngle;
      private float m_targetAngle;
      private RotationController.Rotation.Axis m_axis;
      private Vector3 m_axisVector;
      private Transform m_lastTarget;
      private Renderer m_targetRenderer;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Rotation(RotationController.Rotation.Axis axis) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Rotation(
        RotationController.Rotation.Axis axis,
        RotationController.Rotation.Mode rotationMode)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Rotation(
        RotationController.Rotation.Axis axis,
        RotationController.Rotation.Mode rotationMode,
        float min,
        float max)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void ResetAngle(float newAngle) => throw null;

      public Quaternion rotation
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public bool isRotating
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Update(float deltaTime, Transform self, Transform target, Transform reference) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private float AngleToTarget(Vector3 pos, Vector3 targetPos, Transform reference) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private Vector3 GetAxisVector(RotationController.Rotation.Axis axis) => throw null;

      public enum Axis
      {
        Up,
        Right,
        Forward,
      }

      public enum Mode
      {
        Disabled,
        Free,
        LookAtTarget,
        LookAtTargetCenter,
      }
    }
  }
}
