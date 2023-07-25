// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.TerrainTextureSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
