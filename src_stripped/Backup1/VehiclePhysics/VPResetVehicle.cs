// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPResetVehicle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
