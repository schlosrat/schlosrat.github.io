// Decompiled with JetBrains decompiler
// Type: KSP.VolumeCloud.BasicShape3dGenerator
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
  public class BasicShape3dGenerator : ITextureGenerator, ITextureFastGenerator
  {
    public int texResolution;
    public int octaves;
    public float persistence;
    public float perlinNoiseWeight;
    public float levelScale;
    public float blurWidth;
    public float outScale;
    public int perlinPeriod;
    public int worleyQuality;
    public int worleyPeriod;
    private int channel3WorleyPeriod;
    private int channel4WorleyPeriod;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Color Sample(Vector3 pos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Color[] SampleAll(bool is3d) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BasicShape3dGenerator() => throw null;
  }
}
