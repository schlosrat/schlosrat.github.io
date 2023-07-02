// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Vegetation.Masks.TextureMaskGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Jobs;
using UnityEngine;

namespace AwesomeTechnologies.Vegetation.Masks
{
  [Serializable]
  public class TextureMaskGroup
  {
    public List<TextureMask> TextureMaskList;
    public string TextureMaskName;
    public TextureMaskType TextureMaskType;
    public List<TextureFormat> RequiredTextureFormatList;
    public string TextureMaskGroupID;

    public TextureMaskSettings Settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextureMaskGroup(TextureMaskType textureMaskType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Texture2D GetPreviewTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JobHandle SampleIncludeMask(
      VegetationInstanceData instanceData,
      Rect spawnRect,
      TextureMaskRule textureMaskRule,
      JobHandle dependsOn)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JobHandle SampleExcludeMask(
      VegetationInstanceData instanceData,
      Rect spawnRect,
      TextureMaskRule textureMaskRule,
      JobHandle dependsOn)
    {
      throw null;
    }
  }
}
