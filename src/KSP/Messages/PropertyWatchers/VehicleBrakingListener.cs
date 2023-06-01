// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.VehicleBrakingListener
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/Vehicle/VehicleBraking", false, "A 0-1 indicator if any part of a vehicle is applying a brake. 0 indicates an invalid active vessel.", "")]
  public class VehicleBrakingListener : VehiclePropertyWatcher
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Type baseType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetValueInt() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VehicleBrakingListener() => throw null;
  }
}
