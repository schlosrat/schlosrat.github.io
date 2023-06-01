// Decompiled with JetBrains decompiler
// Type: ScaledSpaceTextureGeneratorSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class ScaledSpaceTextureGeneratorSettings
{
  public bool IncludeBackground;
  public bool IncludeOcean;
  public float OceanHeight;
  public Color OceanColor;
  public bool ExportDiffuse;
  public bool ExportEmission;
  public bool ExportSpecular;
  public bool ExportNormal;
  public Texture2D OverrideDiffuseTexture;
  public Texture2D OverrideNormalTexture;
  public bool SaveAsPNG;
  public Texture2D PolarNormals;
  public int TotalLines;
  public int BlendLines;
  public bool UsePolarNormals;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ScaledSpaceTextureGeneratorSettings() => throw null;
}
