// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPResetVehicle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
