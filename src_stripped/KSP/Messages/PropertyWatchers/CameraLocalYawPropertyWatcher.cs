// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.CameraLocalYawPropertyWatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/Camera/CameraLocalYaw", true, "Left/Right Rotation in degrees applied to the camera in its local coordinate system. (0 = local 'forward', increasing clockwise)", "")]
  public class CameraLocalYawPropertyWatcher : CameraGimbalPropertyWatcher
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Type baseType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetValueDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraLocalYawPropertyWatcher() => throw null;
  }
}
