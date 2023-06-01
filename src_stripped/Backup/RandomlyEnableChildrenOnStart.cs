// Decompiled with JetBrains decompiler
// Type: RandomlyEnableChildrenOnStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class RandomlyEnableChildrenOnStart : MonoBehaviour
{
  [SerializeField]
  private bool stateToRandomlySet;
  [SerializeField]
  private int min;
  [SerializeField]
  private int max;
  private static System.Random randomizer;
  private int childCount;
  private int minInternal;
  private int maxInternal;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Init() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public RandomlyEnableChildrenOnStart() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static RandomlyEnableChildrenOnStart() => throw null;
}
