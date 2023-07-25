// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Shaders.IShaderController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
