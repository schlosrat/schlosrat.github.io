// Decompiled with JetBrains decompiler
// Type: RandomlyEnableChildrenOnStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class RandomlyEnableChildrenOnStart : MonoBehaviour
{
  [SerializeField]
  [FormerlySerializedAs("stateToRandomlySet")]
  private bool _stateToSet;
  [SerializeField]
  [FormerlySerializedAs("min")]
  private int _min;
  [SerializeField]
  [FormerlySerializedAs("max")]
  private int _max;
  [SerializeField]
  [Space(5f)]
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
