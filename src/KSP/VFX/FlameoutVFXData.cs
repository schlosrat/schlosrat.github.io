// Decompiled with JetBrains decompiler
// Type: KSP.VFX.FlameoutVFXData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VFX
{
  public class FlameoutVFXData : KerbalMonoBehaviour
  {
    [SerializeField]
    private GameObject[] _vfxToPlay;
    [SerializeField]
    private GameObject[] _vfxToStop;
    private List<ParticleSystem> _managedParticlesToPlay;
    private List<ParticleSystem> _managedParticlesToStop;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TriggerVFX(bool doFlameOut) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlayOrStopPSArray(List<ParticleSystem> particleSystemList, bool doPlay) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlameoutVFXData() => throw null;
  }
}
