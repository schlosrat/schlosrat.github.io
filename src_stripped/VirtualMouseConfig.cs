// Decompiled with JetBrains decompiler
// Type: VirtualMouseConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
  [SerializeField]
  [Header("Gamepad control speed")]
  private float _maxSpeed;
  [SerializeField]
  private float _minSpeed;
  [SerializeField]
  private float _accelerationLowSpeed;
  [SerializeField]
  private float _accelerationHighSpeed;
  [Header("Min speed stick scope.")]
  [SerializeField]
  [Range(0.0f, 1f)]
  public float MinStickValue;
  [SerializeField]
  [Range(0.0f, 1f)]
  [Header("High speed stick scope.")]
  public float HighSpeedPoint;
  [SerializeField]
  [Range(0.0f, 1f)]
  [Header("Releasing scope to freeze")]
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
