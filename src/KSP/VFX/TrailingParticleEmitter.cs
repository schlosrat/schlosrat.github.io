// Decompiled with JetBrains decompiler
// Type: KSP.VFX.TrailingParticleEmitter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VFX
{
  internal class TrailingParticleEmitter : KerbalMonoBehaviour
  {
    private ParticleSystem _particleSystem;
    [SerializeField]
    [Tooltip("If true, emit particles from script")]
    public bool EmitScriptedParticlesOverDistance;
    private ParticleSystem.EmitParams _partParams;
    private Vector3 _previousFramePosition;
    private float _storedFrameOffset;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TrailingParticleEmitter() => throw null;
  }
}
