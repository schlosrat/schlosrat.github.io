// Decompiled with JetBrains decompiler
// Type: AnimatorVariableRandomizer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using KSP.Networking.MP.Utils;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class AnimatorVariableRandomizer : OABOrFlightEnablable
{
  [SerializeField]
  [Space(10f)]
  [FormerlySerializedAs("RandomizeRepeatedly")]
  private bool _randomizeRepeatedly;
  [NonReorderable]
  [FormerlySerializedAs("AnimatorVariables")]
  [SerializeField]
  private AnimatorVariableRandomizer.RandomAnimatorVariableData[] _animatorVariables;
  private Animator _animator;
  private Kerbal3DModel _character;
  private static MPRandom _randomizer;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Init() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ApplyRandomization(string fullName) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private float GetNextRandomFloatInRange(float min, float max) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator RandomizeSpecificVariableWithDelay(
    AnimatorVariableRandomizer.RandomAnimatorVariableData variableData)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void RandomizeSpecificVariable(
    AnimatorVariableRandomizer.RandomAnimatorVariableData variableData)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AnimatorVariableRandomizer() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static AnimatorVariableRandomizer() => throw null;

  public enum AnimatorVariableType
  {
    NONE,
    FLOAT,
    INT,
    FLOATASINT,
    TRIGGER,
    BOOL,
  }

  [Serializable]
  internal struct RandomAnimatorVariableData
  {
    public string VariableName;
    public AnimatorVariableRandomizer.AnimatorVariableType VariableType;
    public float Min;
    public float Max;
    public float RepeatDelayMin;
    public float RepeatDelayMax;
  }
}
