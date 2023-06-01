// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.SplineFollower
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace EdyCommonTools
{
  [ExecuteInEditMode]
  public class SplineFollower : MonoBehaviour
  {
    public Spline spline;
    [Space(5f)]
    public SplineFollower.Mode mode;
    public float position;
    public float speed;
    [Space(5f)]
    public Spline.WrapMode wrapMode;
    public bool followRotation;
    [Header("Advanced")]
    public SplineFollower.UpdateMode updateMode;
    [Range(1f, 10f)]
    public int preciseSpeedSubsteps;
    public float preciseSpeedTangentThreshold;
    public bool preciseSpeedEnhancedCrossing;
    public bool alternateSpeedReport;
    public bool interpolateGizmo;
    public bool enableGizmos;
    public bool showPosition;
    public bool showDirection;
    [Range(0.0f, 2f)]
    public float directionLength;
    [Range(0.0f, 2f)]
    public float positionRadius;
    public bool showSpeedLabel;
    public bool showTangent;
    public bool showNormal;
    public bool showBinormal;
    [Range(0.1f, 1f)]
    public float tangentScale;
    [Range(0.1f, 2f)]
    public float normalLength;
    private Transform m_transform;
    private Vector3 m_velocity;
    private float m_actualSpeed;
    private Vector3 m_lastWorldPos;
    private float m_lastSplinePos;
    private InterpolatedValue<Vector3> m_gizmoPosition;

    public Vector3 velocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float actualSpeed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 gizmoPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FixedUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDistance(float distance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetDistance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MoveDistance(float distance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Move(float speed, float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdatePose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DoAutoMove() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MoveBySpeed(float speed, float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float MoveInternal(ref float s, float speed, float dt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDrawGizmos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SplineFollower() => throw null;

    public enum Mode
    {
      ControlPoints,
      PreciseSpeed,
      UniformDistance,
    }

    public enum UpdateMode
    {
      Update,
      FixedUpdate,
      LateUpdate,
      External,
    }
  }
}
