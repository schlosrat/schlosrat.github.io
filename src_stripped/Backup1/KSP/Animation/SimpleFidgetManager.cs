// Decompiled with JetBrains decompiler
// Type: KSP.Animation.SimpleFidgetManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    [SerializeField]
    [FormerlySerializedAs("fidgetData")]
    private AnimationManager.AnimSetData _fidgetData;
    [FormerlySerializedAs("fidgetAltData")]
    [SerializeField]
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
    [FormerlySerializedAs("canFidgetParamName")]
    [SerializeField]
    private string _canFidgetParamName;
    [FormerlySerializedAs("triggerName")]
    [SerializeField]
    private string _triggerName;
    [FormerlySerializedAs("randomFidgetIntName")]
    [SerializeField]
    private string _randomFidgetIntName;
    [FormerlySerializedAs("globalPlaybackMulName")]
    [SerializeField]
    private string _globalPlaybackMulName;
    [FormerlySerializedAs("playbackMulMin")]
    [SerializeField]
    private float _playbackMulMin;
    [FormerlySerializedAs("playbackMulMax")]
    [SerializeField]
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
