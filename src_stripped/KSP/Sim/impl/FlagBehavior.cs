// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.FlagBehavior
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class FlagBehavior : ViewObjectComponent<FlagComponent>
  {
    private static readonly int DISABLE_FLAG_INTERACT_CONTEXT;
    private static readonly int FLAG_MAIN_TEXTURE;
    private Animator _animator;
    private RigidbodyBehavior _rigidBody;
    private FlagObject _flagObject;
    private InteractInstance _flagRemovalInteractInstance;

    public FlagComponent Model
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public RigidbodyBehavior RigidBody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SyncTo(FlagComponent simObjectComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PlayPlantAnimation(float playbackMul) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateFlagRemovalInteractEnabled(bool enable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Transform GetTransformParent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFloatingOriginSnapEnd() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FetchFlagRemovalInteractInstance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateFlagTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlagBehavior() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static FlagBehavior() => throw null;
  }
}
