// Decompiled with JetBrains decompiler
// Type: IVACamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof (Camera))]
public class IVACamera : IGameCamera
{
  public float minZoom;
  public float maxZoom;
  public float minPitch;
  public float maxPitch;
  public float maxRot;
  public float distanceCenter;
  public float distanceMaxRot;
  private float orbitFactor;
  private float currentZoom;
  private float currentPitch;
  private float currentRot;
  private float initialZoom;
  private Vector3 initialPosition;
  private Quaternion initialRotation;
  private Vector3 currentPosition;
  private Quaternion currentRotation;
  private float orbitSensitivity;
  private float mouseZoomSensitivity;
  private Camera _camera;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ResetState() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateState() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [Obsolete("unported dependencies", true)]
  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void DeactivateAll() => throw null;

  public bool isActive
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [Obsolete("unported dependencies", true)]
  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Activate() => throw null;

  [Obsolete("unported dependencies", true)]
  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Deactivate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void ResetCamera() => throw null;

  [Obsolete("unported dependencies", true)]
  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void EnableCamera() => throw null;

  [Obsolete("unported dependencies", true)]
  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void DisableCamera() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public IVACamera() => throw null;
}
