// Decompiled with JetBrains decompiler
// Type: DebugTestingToolbox
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class DebugTestingToolbox : MonoBehaviour
{
  [Tooltip("A Universal Thrust Percentage for debug testing.")]
  [SerializeField]
  [Range(0.0f, 1f)]
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
