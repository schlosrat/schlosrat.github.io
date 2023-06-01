// Decompiled with JetBrains decompiler
// Type: KSP.Animation.RandomAnimationTriggerManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Networking.MP.Utils;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Animation
{
  public class RandomAnimationTriggerManager : KerbalMonoBehaviour
  {
    [FormerlySerializedAs("minWaitTime")]
    [SerializeField]
    private float _minWaitTime;
    [FormerlySerializedAs("maxWaitTime")]
    [SerializeField]
    private float _maxWaitTime;
    [FormerlySerializedAs("triggerName")]
    [SerializeField]
    private string _triggerName;
    private Animator _animator;
    private float _timeForNextTrigger;
    private float _timer;
    private bool _waitTimerIsActive;
    private static MPRandom _randomizer;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetNextRandomTriggerTime() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CycleTransitionEnded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RandomAnimationTriggerManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static RandomAnimationTriggerManager() => throw null;
  }
}
