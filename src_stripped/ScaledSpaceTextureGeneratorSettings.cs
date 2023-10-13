// Decompiled with JetBrains decompiler
// Type: ScaledSpaceTextureGeneratorSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
