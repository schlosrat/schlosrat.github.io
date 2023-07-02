// Decompiled with JetBrains decompiler
// Type: KSP.VFX.TrailingParticleEmitter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
