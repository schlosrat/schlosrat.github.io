// Decompiled with JetBrains decompiler
// Type: Shapes.FpsController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Shapes
{
  [ExecuteAlways]
  public class FpsController : ImmediateModeShapeDrawer
  {
    public Transform head;
    public Camera cam;
    public Crosshair crosshair;
    public ChargeBar chargeBar;
    public AmmoBar ammoBar;
    public Compass compass;
    public Transform crosshairTransform;
    [Header("Player Movement")]
    [Range(0.8f, 1f)]
    public float smoof;
    public float moveSpeed;
    public float lookSensitivity;
    private float yaw;
    private float pitch;
    private Vector2 moveInput;
    private Vector3 moveVel;
    [Range(0.0f, 3.14159274f)]
    [Header("Sidebar Style")]
    public float ammoBarAngularSpanRad;
    [Range(0.0f, 0.05f)]
    public float ammoBarOutlineThickness;
    [Range(0.0f, 0.2f)]
    public float ammoBarThickness;
    [Range(0.0f, 0.2f)]
    public float ammoBarRadius;
    [Header("Animation")]
    [Range(0.0f, 0.3f)]
    public float fireSidebarRadiusPunchAmount;
    public AnimationCurve shakeAnimX;
    public AnimationCurve shakeAnimY;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void DrawShapes(Camera cam) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator FixedSteps() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DrawRoundedArcOutline(
      Vector2 origin,
      float radius,
      float thickness,
      float outlineThickness,
      float angStart,
      float angEnd)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetShake(float speed, float amp) => throw null;

    private bool InputFocus
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FixedUpdateManual() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FpsController() => throw null;
  }
}
