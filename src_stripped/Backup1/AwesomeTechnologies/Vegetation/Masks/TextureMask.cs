// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Vegetation.Masks.TextureMask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using System;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace AwesomeTechnologies.Vegetation.Masks
{
  [Serializable]
  public class TextureMask
  {
    public Rect TextureRect;
    public Vector2 Repeat;
    public Texture2D MaskTexture;
    private NativeArray<RGBABytes> _rgbaNativeArray;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JobHandle SampleIncludeMask(
      VegetationInstanceData instanceData,
      Rect spawnRect,
      TextureMaskType textureMaskType,
      TextureMaskRule textureMaskRule,
      JobHandle dependsOn)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JobHandle SampleExcludeMask(
      VegetationInstanceData instanceData,
      Rect spawnRect,
      TextureMaskType textureMaskType,
      TextureMaskRule textureMaskRule,
      JobHandle dependsOn)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextureMask() => throw null;
  }
}
