// Decompiled with JetBrains decompiler
// Type: Texture2DArrayConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(menuName = "Intercept Games/RenderKit/Texture2DArray Config", order = 1)]
[ExecuteInEditMode]
public class Texture2DArrayConfig : ScriptableObject
{
  [HideInInspector]
  public Texture2DArrayConfig.TextureMode textureMode;
  [HideInInspector]
  public Texture2DArray albedoArray;
  [HideInInspector]
  public Texture2DArray normalSAOArray;
  [HideInInspector]
  public Texture2DArray metalnessArray;
  [HideInInspector]
  public bool enableGroupAutoFill;
  public Texture2DArrayConfig.TextureArrayGroup defaultTextureSettings;
  public List<Texture2DArrayConfig.PlatformTextureOverride> platformOverrides;
  [HideInInspector]
  public Texture2DArrayConfig.AllTextureChannel allTextureChannelHeight;
  [HideInInspector]
  public Texture2DArrayConfig.AllTextureChannel allTextureChannelSmoothness;
  [HideInInspector]
  public Texture2DArrayConfig.AllTextureChannel allTextureChannelAO;
  [HideInInspector]
  public List<Texture2DArrayConfig.TextureEntry> sourceTextures;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool IsPBR() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool IsDecal() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool IsDecalSplat() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Texture2DArrayConfig() => throw null;

  public enum AllTextureChannel
  {
    R,
    G,
    B,
    A,
    Custom,
  }

  public enum TextureChannel
  {
    R,
    G,
    B,
    A,
  }

  public enum Compression
  {
    AutomaticCompressed,
    ForceDXT,
    ForcePVR,
    ForceETC2,
    ForceASTC,
    ForceCrunch,
    Uncompressed,
  }

  public enum TextureSize
  {
    k32 = 32, // 0x00000020
    k64 = 64, // 0x00000040
    k128 = 128, // 0x00000080
    k256 = 256, // 0x00000100
    k512 = 512, // 0x00000200
    k1024 = 1024, // 0x00000400
    k2048 = 2048, // 0x00000800
    k4096 = 4096, // 0x00001000
  }

  [Serializable]
  public class TextureArraySettings
  {
    public Texture2DArrayConfig.TextureSize textureSize;
    public Texture2DArrayConfig.Compression compression;
    public FilterMode filterMode;
    [Range(0.0f, 16f)]
    public int Aniso;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextureArraySettings(
      Texture2DArrayConfig.TextureSize s,
      Texture2DArrayConfig.Compression c,
      FilterMode f,
      int a = 1)
    {
      throw null;
    }
  }

  public enum TextureMode
  {
    PBR,
    Decal,
    DecalSplatMap,
  }

  [Serializable]
  public class TextureArrayGroup
  {
    public Texture2DArrayConfig.TextureArraySettings albedoSettings;
    public Texture2DArrayConfig.TextureArraySettings normSAOSettings;
    public Texture2DArrayConfig.TextureArraySettings metalnessEmiSettings;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextureArrayGroup() => throw null;
  }

  [Serializable]
  public class PlatformTextureOverride
  {
    public Texture2DArrayConfig.TextureArrayGroup settings;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlatformTextureOverride() => throw null;
  }

  [Serializable]
  public class TextureEntry
  {
    public Texture2D albedo;
    public Texture2D height;
    public Texture2DArrayConfig.TextureChannel heightChannel;
    public Texture2D normal;
    public Texture2D smoothness;
    public Texture2DArrayConfig.TextureChannel smoothnessChannel;
    public Texture2D metalness;
    public Texture2D emission;
    public Texture2DArrayConfig.TextureChannel emissionChannel;
    public bool isRoughness;
    public Texture2D ao;
    public Texture2DArrayConfig.TextureChannel aoChannel;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasTextures() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextureEntry() => throw null;
  }
}
