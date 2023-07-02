// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.VegetationPackageProModelInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  public class VegetationPackageProModelInfo
  {
    public readonly List<VegetationItemModelInfo> VegetationItemModelList;
    public readonly EnvironmentSettings EnvironmentSettings;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationPackageProModelInfo(
      VegetationPackagePro vegetationPackagePro,
      EnvironmentSettings environmentSettings,
      List<GameObject> windSamplerList,
      int cameraCount,
      VegetationRenderSettings vegetationRenderSettings)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetAdditionalBoundingSphereRadius() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateCameraWindSamplerItems(List<GameObject> windSamplerList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateCameraBuffers(int cameraCount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;
  }
}
