﻿// Decompiled with JetBrains decompiler
// Type: KSP.Animation.AnimationManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Networking.MP.Utils;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Animation
{
  public abstract class AnimationManager : KerbalMonoBehaviour
  {
    [SerializeField]
    [FormerlySerializedAs("debugMode")]
    public bool DebugMode;
    [FormerlySerializedAs("emoteData")]
    [SerializeField]
    protected AnimationManager.AnimSetData _emoteData;
    [FormerlySerializedAs("emoteAltData")]
    [SerializeField]
    protected AnimationManager.AnimSetData _emoteAltData;
    [SerializeField]
    [FormerlySerializedAs("fidgetData")]
    protected AnimationManager.AnimSetData _fidgetData;
    [SerializeField]
    [FormerlySerializedAs("fidgetAltData")]
    protected AnimationManager.AnimSetData _fidgetAltData;
    [FormerlySerializedAs("emoteCount")]
    public int EmoteCount;
    [FormerlySerializedAs("emoteAltCount")]
    public int EmoteAltCount;
    [FormerlySerializedAs("fidgetCount")]
    public int FidgetCount;
    [FormerlySerializedAs("fidgetAltCount")]
    public int FidgetAltCount;
    [FormerlySerializedAs("animator")]
    [HideInInspector]
    public Animator Animator;
    [FormerlySerializedAs("character")]
    [HideInInspector]
    public Kerbal3DModel Character3DModel;
    [FormerlySerializedAs("globalPlaybackMulName")]
    [SerializeField]
    protected string _globalPlaybackMulParamName;
    [SerializeField]
    [FormerlySerializedAs("canFidgetParamName")]
    protected string _canFidgetParamName;
    [FormerlySerializedAs("eyeOffsetParamName")]
    [SerializeField]
    protected string _eyeOffsetParamName;
    [FormerlySerializedAs("eyeSymmetryParamName")]
    [SerializeField]
    protected string _eyeSymmetryParamName;
    protected int _globalPlaybackMulID;
    protected int _canFidgetID;
    protected int _eyeOffsetID;
    protected int _eyeSymmetryID;
    protected int _lastTimeWarpRateIndex;
    [FormerlySerializedAs("eyeOffsetPercentage")]
    public float EyeOffsetPercentageValue;
    [FormerlySerializedAs("eyeSymmetryValue")]
    public float EyeSymmetryValue;
    protected bool _attributesInitialized;
    protected static MPRandom _randomizer;
    protected float _initialFidgetDelayCountdown;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void InitAttributeValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetPlaybackMulValue() => throw null;

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
    protected virtual void InitAnimTreeParamIndices() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DebugPrint(string message, int severity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAnimSpeedToTimeWarpIndex() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected AnimationManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static AnimationManager() => throw null;

    [Serializable]
    public class AnimSetData
    {
      [FormerlySerializedAs("parentLayerName")]
      public string ParentLayerName;
      [HideInInspector]
      [FormerlySerializedAs("parentLayerIndex")]
      public int ParentLayerIndex;
      [FormerlySerializedAs("stateName")]
      public string StateName;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public AnimSetData() => throw null;
    }
  }
}
