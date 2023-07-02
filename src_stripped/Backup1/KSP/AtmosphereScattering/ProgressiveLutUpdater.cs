// Decompiled with JetBrains decompiler
// Type: KSP.AtmosphereScattering.ProgressiveLutUpdater
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.AtmosphereScattering
{
  public class ProgressiveLutUpdater
  {
    private ProgressiveLutUpdater.ITimeLogger logger;
    public const int k_MultiScatteringOrderDepth = 4;
    public RenderTexture[] groundIrradianceTemp;
    public RenderTexture multiScatteringDensity;
    public RenderTexture[] multiScatteringTemp;
    public RenderTexture transmittance;
    public RenderTexture singleRayleigh;
    public RenderTexture singleMie;
    public RenderTexture multiScatteringCombine;
    public RenderTexture groundIrradianceCombine;
    internal string name;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Cleanup() => throw null;

    public AtmosphereConfig atmConfigToUse
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public AtmosphereConfig atmConfigUsedToUpdate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public AtmLutGenerateConfig lutConfig
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProgressiveLutUpdater(
      AtmosphereConfig atmConfig,
      AtmLutGenerateConfig lutConfig,
      ProgressiveLutUpdater.ITimeLogger logger = null)
    {
      throw null;
    }

    public bool working
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Log(string t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator UpdateCoroutine() => throw null;

    public interface ITimeLogger
    {
      void Log(string itemName);
    }
  }
}
