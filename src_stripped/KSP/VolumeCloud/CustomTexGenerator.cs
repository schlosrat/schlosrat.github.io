// Decompiled with JetBrains decompiler
// Type: KSP.VolumeCloud.CustomTexGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VolumeCloud
{
  [Serializable]
  public class CustomTexGenerator : INoiseGenerator
  {
    public float channel1WorleyPercent;
    public int channel1WorleyPeriod;
    public int channel1PerlinPeriod;
    public int worleyOcataves;
    public int perlinOctaves;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float Noise(Vector3 pos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CustomTexGenerator() => throw null;
  }
}
