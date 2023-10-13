// Decompiled with JetBrains decompiler
// Type: ProceduralAnimator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ProceduralAnimator : MonoBehaviour
{
  [SerializeField]
  private bool debugSpinWheelsMode;
  [SerializeField]
  private float debugWheelSpinSpeed;
  private bool hasAnimator;
  public ProceduralAnimator.ProceduralAnimationInfo[] animationArray;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetRotationByAngle(
    float angle,
    ProceduralAnimator.ProceduralAnimationStyle[] styleFilter = null)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetRotationByAngle(
    float angle,
    ProceduralAnimator.ProceduralAnimationStyle styleToAnimate)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetAdditiveRotationByDistance(
    float distanceTraveled,
    ProceduralAnimator.ProceduralAnimationStyle[] styleFilter = null)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetAdditiveRotationByDistance(
    float distanceTraveled,
    ProceduralAnimator.ProceduralAnimationStyle styleToAnimate)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Vector3 GetRotVectorFromRotAxis(
    ProceduralAnimator.ProceduralAnimationInfo animInfo,
    ProceduralAnimator.ProceduralAnimationAxis curAxis)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void HoldLastPoseOverAnimator() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void DebugSpinAllWheelsAtSpeed(float speed) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void LateUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ProceduralAnimator() => throw null;

  [Serializable]
  public class ProceduralAnimationInfo
  {
    public ProceduralAnimator.ProceduralAnimationStyle style;
    public ProceduralAnimator.ProceduralAnimationAxis animAxis;
    public bool invertDirection;
    public Transform toAnimate;
    [HideInInspector]
    public float radius;
    [HideInInspector]
    public Quaternion originalOrientation;
    [HideInInspector]
    public Quaternion lastOrientation;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProceduralAnimationInfo() => throw null;
  }

  public enum ProceduralAnimationAxis
  {
    X,
    Y,
    Z,
  }

  public enum ProceduralAnimationStyle
  {
    WHEEL,
    TURN,
  }
}
