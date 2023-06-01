// Decompiled with JetBrains decompiler
// Type: KSP.VFX.VFXParticleParameterizer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VFX
{
  [DisallowMultipleComponent]
  [RequireComponent(typeof (ParticleSystem))]
  public class VFXParticleParameterizer : VFXParameterizer
  {
    private ParticleSystem _particleSystem;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UpdateFromContextData(
      FXContextData contextData,
      FXPartContextData partData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VFXParticleParameterizer() => throw null;
  }
}
