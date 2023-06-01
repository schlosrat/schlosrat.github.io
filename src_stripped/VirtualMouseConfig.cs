// Decompiled with JetBrains decompiler
// Type: VirtualMouseConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class VirtualMouseConfig
{
  [Header("Virtual cursor reference")]
  [SerializeField]
  public Image VirtualMouseImage;
  [SerializeField]
  public Sprite DefaultVirtualCursorSprite;
  [Header("Gamepad control speed")]
  [SerializeField]
  private float _maxSpeed;
  [SerializeField]
  private float _minSpeed;
  [SerializeField]
  private float _accelerationLowSpeed;
  [SerializeField]
  private float _accelerationHighSpeed;
  [Header("Min speed stick scope.")]
  [Range(0.0f, 1f)]
  [SerializeField]
  public float MinStickValue;
  [Header("High speed stick scope.")]
  [Range(0.0f, 1f)]
  [SerializeField]
  public float HighSpeedPoint;
  [Header("Releasing scope to freeze")]
  [Range(0.0f, 1f)]
  [SerializeField]
  public float ReleaseScope;
  [Header("Dead Zone")]
  [SerializeField]
  [Range(0.0f, 0.1f)]
  public float DeadZone;
  private Vector2 _prevGamepadStick;
  private float _currentSpeed;
  private float _targetSpeed;
  private float _deltaReleasing;

  public float MaxSpeed
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public float MinSpeed
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public float AccelerationLowSpeed
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public float AccelerationHighSpeed
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  private float deltaReleasing
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Vector2 RefinedMovement(Vector2 gamepadStick) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public VirtualMouseConfig() => throw null;
}
