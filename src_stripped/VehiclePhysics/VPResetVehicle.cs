// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPResetVehicle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Utility/Reset Vehicle", 1)]
  public class VPResetVehicle : VehicleBehaviour
  {
    public KeyCode resetVehicleKey;
    public float heightIncrement;
    public bool resetState;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DoReset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ResetVehicle(VehicleBase vehicle, float height, bool hardReset = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPResetVehicle() => throw null;
  }
}
