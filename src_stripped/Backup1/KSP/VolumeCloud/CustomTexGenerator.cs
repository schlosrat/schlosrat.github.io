// Decompiled with JetBrains decompiler
// Type: KSP.VolumeCloud.CustomTexGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
