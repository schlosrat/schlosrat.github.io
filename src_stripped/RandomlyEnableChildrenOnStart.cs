// Decompiled with JetBrains decompiler
// Type: RandomlyEnableChildrenOnStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class RandomlyEnableChildrenOnStart : MonoBehaviour
{
  [FormerlySerializedAs("stateToRandomlySet")]
  [SerializeField]
  private bool _stateToSet;
  [SerializeField]
  [FormerlySerializedAs("min")]
  private int _min;
  [FormerlySerializedAs("max")]
  [SerializeField]
  private int _max;
  [Space(5f)]
  [SerializeField]
  private bool _reEnableChildrenOnEnable;
  private static System.Random _randomizer;
  private bool _initialized;
  private int _childCount;
  private int _safeMin;
  private int _safeMax;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Init() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public RandomlyEnableChildrenOnStart() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static RandomlyEnableChildrenOnStart() => throw null;
}
