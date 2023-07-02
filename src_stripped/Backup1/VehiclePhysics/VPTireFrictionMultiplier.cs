// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPTireFrictionMultiplier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class VPTireFrictionMultiplier : VehicleBehaviour
  {
    [Range(0.0f, 2f)]
    public float frictionMultiplier;
    private float m_lastValue;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void FixedUpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetFrictionMultiplierInAllWheels(VehicleBase vehicle, float multiplier) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPTireFrictionMultiplier() => throw null;
  }
}
