// Decompiled with JetBrains decompiler
// Type: KSP.VFX.WaterSplashEventData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VFX
{
  public struct WaterSplashEventData
  {
    public Vector3 direction;
    public Vector3 position;
    public float velocity;
    public float deviationFromVertical;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WaterSplashEventData(
      Vector3 direction,
      Vector3 position,
      float velocity,
      float deviationFromVertical)
    {
      throw null;
    }
  }
}
