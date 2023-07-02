// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Shaders.NMTreeShaderControler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.Shaders
{
  public class NMTreeShaderControler : IShaderController
  {
    private static readonly string[] FoliageShaderNames;
    private static readonly string[] BarkShaderNames;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool StaticMatchShader(string shaderName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool MatchShader(string shaderName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool MatchBillboardShader(Material[] materials) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsBarkShader(string shaderName) => throw null;

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
    public NMTreeShaderControler() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static NMTreeShaderControler() => throw null;
  }
}
