// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.VehicleBoundingSphereRadiusPropertyWatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/Vehicle/VehicleBoundingSphereRadius", true, "Radius of the vehicle's Bounding Sphere ", "Utilized by VFX & Wwise for estimating vessel size")]
  public class VehicleBoundingSphereRadiusPropertyWatcher : VehiclePropertyWatcher
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Type baseType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetValueDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VehicleBoundingSphereRadiusPropertyWatcher() => throw null;
  }
}
