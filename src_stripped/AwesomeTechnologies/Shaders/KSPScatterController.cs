// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Shaders.KSPScatterController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.Shaders
{
  public class KSPScatterController : IShaderController
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool StaticMatchShader(string shaderName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool MatchShader(string shaderName) => throw null;

    public ShaderControllerSettings Settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateDefaultSettings(Material[] materials) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateMaterial(Material material, EnvironmentSettings environmentSettings) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateWind(Material material, WindSettings windSettings) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool MatchBillboardShader(Material[] materials) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSPScatterController() => throw null;
  }
}
