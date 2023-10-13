// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.CameraAttachTo
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
  [Serializable]
  public class CameraAttachTo : CameraMode
  {
    public Transform attachTarget;
    [Space(5f)]
    public bool enableRotation;
    public bool resetRotationOnEnable;
    public bool requireKeyPressedToRotate;
    public KeyCode keyToRequire;
    public Transform lookAtTarget;
    [Space(5f)]
    public RotationController.Rotation horizontal;
    public RotationController.Rotation vertical;
    [Space(5f)]
    public string horizontalAxis;
    public string verticalAxis;
    public float horizontalSensitivity;
    public float verticalSensitivity;
    private Camera m_camera;
    private bool m_vrPresent;
    private float m_savedFov;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Initialize(Transform self) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetTargetConfig(VPCameraTarget targetConfig) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnable(Transform self) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Update(Transform self, Transform target, float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetDriverFov(Transform self, float fieldOfView) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisable(Transform self) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraAttachTo() => throw null;
  }
}
