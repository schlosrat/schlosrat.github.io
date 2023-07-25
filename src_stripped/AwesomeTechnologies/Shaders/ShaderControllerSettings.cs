// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Shaders.ShaderControllerSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.Common;
using AwesomeTechnologies.VegetationSystem;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.Shaders
{
  [Serializable]
  public class ShaderControllerSettings : BaseControllerSettings
  {
    public string Heading;
    public string Description;
    public bool SupportsInstantIndirect;
    public bool LODFadeCrossfade;
    public bool LODFadePercentage;
    public bool SampleWind;
    public bool UpdateWind;
    public bool DynamicHUE;
    public bool BillboardSnow;
    public bool BillboardHDWind;
    public string OverrideBillboardAtlasShader;
    public string OverrideBillboardAtlasNormalShader;
    public BillboardRenderMode BillboardRenderMode;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ShaderControllerSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ShaderControllerSettings(ShaderControllerSettings source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool HasShader(Material material, string[] shaderNames) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetFloatFromMaterials(Material[] materials, string propertyName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetFloatFromMaterials(
      Material[] materials,
      string propertyName,
      string[] shaderNames)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsKeywordEnabledOnFirstMaterial(Material[] materials, string keyword) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector4 GetVector4FromMaterials(Material[] materials, string propertyName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Color GetColorFromMaterials(
      Material[] materials,
      string propertyName,
      string[] shaderNames)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Color GetColorFromMaterials(Material[] materials, string propertyName) => throw null;
  }
}
