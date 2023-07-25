// Decompiled with JetBrains decompiler
// Type: KSP.VolumeCloud.WorleyNoiseGenerator
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
  public class WorleyNoiseGenerator : BaseNoiseGenerator
  {
    public float brightness;
    public float contrast;
    public int octaves;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override float Noise(Vector3 pos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int wrap(int n, int period) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float Noise(Vector3 pos, int period) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float OctaveNoise(Vector3 pos, int period, int octaves, float persistence = 0.5f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WorleyNoiseGenerator() => throw null;
  }
}
