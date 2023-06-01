// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.CameraLocalPitchPropertyWatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/Camera/CameraLocalPitch", true, "Up/Down rotation in degrees applied to the camera in its local coordinate system. (-90 = local down, 90 = local up)", "")]
  public class CameraLocalPitchPropertyWatcher : CameraGimbalPropertyWatcher
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Type baseType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetValueDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraLocalPitchPropertyWatcher() => throw null;
  }
}
