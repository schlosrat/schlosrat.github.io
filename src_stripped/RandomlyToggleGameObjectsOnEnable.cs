// Decompiled with JetBrains decompiler
// Type: RandomlyToggleGameObjectsOnEnable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RandomlyToggleGameObjectsOnEnable : MonoBehaviour
{
  [SerializeField]
  private bool _stateToSetTo;
  [SerializeField]
  private int _minToSet;
  [SerializeField]
  private int _maxToSet;
  [Space(10f)]
  [SerializeField]
  private List<GameObject> _managedGameObjects;
  private List<GameObject> _sanitizedAndUniqueListOfManagedGameObjects;
  private static System.Random _randomizer;
  private int _safeMin;
  private int _safeMax;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void InitSanitizedGOList() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetRandomStateForManagedGameObjects() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void DoRandomToggling(bool targetState, int numberToSetToTargetState) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ToggleAllManagedGameObjects(bool stateToSetTo) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private int[] GetShuffledIndexArray(int numberOfIndiciesToChooseFrom) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public RandomlyToggleGameObjectsOnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static RandomlyToggleGameObjectsOnEnable() => throw null;
}
