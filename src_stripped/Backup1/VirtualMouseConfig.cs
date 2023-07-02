// Decompiled with JetBrains decompiler
// Type: VirtualMouseConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class VirtualMouseConfig
{
  [SerializeField]
  [Header("Virtual cursor reference")]
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
  [Range(0.0f, 1f)]
  [Header("Min speed stick scope.")]
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
  [SerializeField]
  [Range(0.0f, 0.1f)]
  [Header("Dead Zone")]
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
