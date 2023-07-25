// Decompiled with JetBrains decompiler
// Type: KSP.VFX.VFXParticleParameterizer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VFX
{
  [RequireComponent(typeof (ParticleSystem))]
  [DisallowMultipleComponent]
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
