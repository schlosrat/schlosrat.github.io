// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.TerrainTextureSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  [Serializable]
  public class TerrainTextureSettings
  {
    public AnimationCurve TextureHeightCurve;
    public AnimationCurve TextureSteepnessCurve;
    public bool UseNoise;
    public float NoiseScale;
    public float TextureWeight;
    public Vector2 NoiseOffset;
    public bool InverseNoise;
    public int TextureLayer;
    public bool Enabled;
    public bool LockTexture;
    public NativeArray<float> HeightCurveArray;
    public NativeArray<float> SteepnessCurveArray;
    public bool ConcaveEnable;
    public bool ConvexEnable;
    public bool ConcaveAverage;
    public float ConcaveMinHeightDifference;
    public float ConcaveDistance;
    public ConcaveMode ConcaveMode;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TerrainTextureSettings() => throw null;
  }
}
