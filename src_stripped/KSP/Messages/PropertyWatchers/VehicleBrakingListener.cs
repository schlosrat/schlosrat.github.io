// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.VehicleBrakingListener
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
