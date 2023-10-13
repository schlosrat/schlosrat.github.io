// Decompiled with JetBrains decompiler
// Type: KSP.Animation.SimpleFidgetManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
    [FormerlySerializedAs("fidgetAltData")]
    [SerializeField]
    private AnimationManager.AnimSetData _fidgetAltData;
    [FormerlySerializedAs("fidgetCount")]
    [SerializeField]
    [Space(10f)]
    private int _fidgetCount;
    [FormerlySerializedAs("fidgetAltCount")]
    [SerializeField]
    private int _fidgetAltCount;
    [SerializeField]
    [FormerlySerializedAs("minWaitTime")]
    private float _minWaitTime;
    [FormerlySerializedAs("maxWaitTime")]
    [SerializeField]
    private float _maxWaitTime;
    [FormerlySerializedAs("canFidgetParamName")]
    [SerializeField]
    private string _canFidgetParamName;
    [SerializeField]
    [FormerlySerializedAs("triggerName")]
    private string _triggerName;
    [SerializeField]
    [FormerlySerializedAs("randomFidgetIntName")]
    private string _randomFidgetIntName;
    [FormerlySerializedAs("globalPlaybackMulName")]
    [SerializeField]
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
