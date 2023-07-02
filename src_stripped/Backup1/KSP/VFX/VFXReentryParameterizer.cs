// Decompiled with JetBrains decompiler
// Type: KSP.VFX.VFXReentryParameterizer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VFX
{
  [DisallowMultipleComponent]
  public class VFXReentryParameterizer : VFXParameterizer
  {
    public bool EnableDownscaleBlur;
    public float ReentryMeshDepthMuliplier;
    public float ReentryMeshDistanceOffset;
    public float ReentryMeshScaleMultiplier;
    public float ComputeDepthMult;
    public bool EnableParticleFX;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UpdateFromContextData(
      FXContextData contextData,
      FXPartContextData partData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VFXReentryParameterizer() => throw null;
  }
}
