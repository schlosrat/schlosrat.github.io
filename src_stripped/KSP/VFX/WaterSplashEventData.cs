// Decompiled with JetBrains decompiler
// Type: KSP.VFX.WaterSplashEventData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
