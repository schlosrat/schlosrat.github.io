// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.VegetationPackageProModelInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
