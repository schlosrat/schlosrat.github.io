// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Shaders.IShaderController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using UnityEngine;

namespace AwesomeTechnologies.Shaders
{
  public interface IShaderController
  {
    bool MatchShader(string shaderName);

    ShaderControllerSettings Settings { get; set; }

    void CreateDefaultSettings(Material[] materials);

    void UpdateMaterial(Material material, EnvironmentSettings environmentSettings);

    void UpdateWind(Material material, WindSettings windSettings);

    bool MatchBillboardShader(Material[] materials);
  }
}
