// Decompiled with JetBrains decompiler
// Type: DebugTestingToolbox
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class DebugTestingToolbox : MonoBehaviour
{
  [Range(0.0f, 1f)]
  [SerializeField]
  [Tooltip("A Universal Thrust Percentage for debug testing.")]
  public static float ThrustPercentage;
  [Tooltip("Atmosphere to Vacuum VFX.")]
  public static float AtmoToVac;
  [Tooltip("Velocity.")]
  public static float Velocity;
  [Tooltip("Angular Velocity.")]
  public static float AngularVelocity;
  [Tooltip("Acceleration")]
  public static Vector3 Acceleration;
  [Tooltip("Altitude.")]
  public static float Altitude;
  [Tooltip("Fuel Level.")]
  public static float FuelLevel;
  [Tooltip("Temperature.")]
  public static float Temperature;
  private static DebugTestingToolbox fetch;

  public static DebugTestingToolbox Fetch
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DebugTestingToolbox() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static DebugTestingToolbox() => throw null;
}
