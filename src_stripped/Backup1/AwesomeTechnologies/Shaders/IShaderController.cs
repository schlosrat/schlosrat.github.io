// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Shaders.IShaderController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
