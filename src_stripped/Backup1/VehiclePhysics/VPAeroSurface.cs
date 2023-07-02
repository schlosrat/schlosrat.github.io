// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPAeroSurface
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Vehicle Dynamics/Aerodynamic Surface", 40)]
  public class VPAeroSurface : VehicleBehaviour
  {
    public float dragCoefficient;
    public float downforceCoefficient;
    public bool showDebugLabel;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void FixedUpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPAeroSurface() => throw null;
  }
}
