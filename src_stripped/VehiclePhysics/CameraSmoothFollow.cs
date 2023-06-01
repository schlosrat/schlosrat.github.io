// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.CameraSmoothFollow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace VehiclePhysics
{
  [Serializable]
  public class CameraSmoothFollow : CameraMode
  {
    [Space(5f)]
    public float distance;
    public float height;
    [FormerlySerializedAs("viewHeightRatio")]
    public float heightMultiplier;
    [Space(5f)]
    public float heightDamping;
    public float rotationDamping;
    [Space(5f)]
    public bool followVelocity;
    public float velocityDamping;
    private Vector3 m_smoothLastPos;
    private Vector3 m_smoothVelocity;
    private float m_smoothTargetAngle;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetTargetConfig(VPCameraTarget targetConfig) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset(Transform self, Transform target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Update(Transform self, Transform target, float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraSmoothFollow() => throw null;
  }
}
