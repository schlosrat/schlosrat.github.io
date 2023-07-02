// Decompiled with JetBrains decompiler
// Type: KSP.VFX.FlameoutVFXData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
