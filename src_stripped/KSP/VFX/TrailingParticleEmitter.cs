// Decompiled with JetBrains decompiler
// Type: KSP.VFX.TrailingParticleEmitter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
    [Tooltip("If true, emit particles from script")]
    [SerializeField]
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
