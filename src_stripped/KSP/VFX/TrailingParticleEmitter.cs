// Decompiled with JetBrains decompiler
// Type: KSP.VFX.TrailingParticleEmitter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
