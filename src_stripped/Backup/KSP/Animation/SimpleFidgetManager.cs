// Decompiled with JetBrains decompiler
// Type: KSP.Animation.SimpleFidgetManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Networking.MP.Utils;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Animation
{
  public class SimpleFidgetManager : KerbalMonoBehaviour
  {
    private Animator _animator;
    [FormerlySerializedAs("fidgetData")]
    [SerializeField]
    private AnimationManager.AnimSetData _fidgetData;
    [SerializeField]
    [FormerlySerializedAs("fidgetAltData")]
    private AnimationManager.AnimSetData _fidgetAltData;
    [Space(10f)]
    [FormerlySerializedAs("fidgetCount")]
    [SerializeField]
    private int _fidgetCount;
    [FormerlySerializedAs("fidgetAltCount")]
    [SerializeField]
    private int _fidgetAltCount;
    [FormerlySerializedAs("minWaitTime")]
    [SerializeField]
    private float _minWaitTime;
    [FormerlySerializedAs("maxWaitTime")]
    [SerializeField]
    private float _maxWaitTime;
    [SerializeField]
    [FormerlySerializedAs("canFidgetParamName")]
    private string _canFidgetParamName;
    [FormerlySerializedAs("triggerName")]
    [SerializeField]
    private string _triggerName;
    [FormerlySerializedAs("randomFidgetIntName")]
    [SerializeField]
    private string _randomFidgetIntName;
    [SerializeField]
    [FormerlySerializedAs("globalPlaybackMulName")]
    private string _globalPlaybackMulName;
    [SerializeField]
    [FormerlySerializedAs("playbackMulMin")]
    private float _playbackMulMin;
    [SerializeField]
    [FormerlySerializedAs("playbackMulMax")]
    private float _playbackMulMax;
    private static MPRandom _randomizer;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetAnimLayerIndexByName(string parentLayerName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator Fidget(
      Animator animator,
      int layerIndex,
      int fidgetTriggerID,
      float minDelay,
      float maxDelay,
      int randomIndexID,
      int animCount)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimpleFidgetManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SimpleFidgetManager() => throw null;
  }
}
