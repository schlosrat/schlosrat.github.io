// Decompiled with JetBrains decompiler
// Type: KSP.AtmosphereScattering.AtmLutGenerateConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
