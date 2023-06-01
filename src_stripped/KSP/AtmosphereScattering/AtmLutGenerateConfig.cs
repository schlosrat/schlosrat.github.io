// Decompiled with JetBrains decompiler
// Type: KSP.AtmosphereScattering.AtmLutGenerateConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.AtmosphereScattering
{
  [Serializable]
  public class AtmLutGenerateConfig
  {
    public Vector2Int transmittanceSize;
    public Vector3Int scatteringSize;
    public Vector2Int irradianceSize;
    public Vector3Int cameraVolumeSize;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Apply(ComputeShader shader) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AtmLutGenerateConfig() => throw null;

    private static class Keys
    {
      private static readonly int transmittanceSize;
      private static readonly int scatteringSize;
      private static readonly int irradianceSize;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static Keys() => throw null;
    }
  }
}
