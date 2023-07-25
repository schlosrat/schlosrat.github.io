// Decompiled with JetBrains decompiler
// Type: KSP.VolumeCloud.CustomTexGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
