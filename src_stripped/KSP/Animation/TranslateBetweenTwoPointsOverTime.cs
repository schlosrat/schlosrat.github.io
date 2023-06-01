// Decompiled with JetBrains decompiler
// Type: KSP.Animation.TranslateBetweenTwoPointsOverTime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace KSP.Animation
{
  public class TranslateBetweenTwoPointsOverTime : KerbalMonoBehaviour
  {
    [SerializeField]
    private bool _pointsWillBeMoving;
    [SerializeField]
    private float _transitionTimeInSeconds;
    [Space(10f)]
    [SerializeField]
    private List<TranslateBetweenTwoPointsOverTime.PointPairData> PointPairChoices;
    [Space(10f)]
    [SerializeField]
    private UnityEvent OnCompletion;
    private bool _doTranslate;
    private TranslateBetweenTwoPointsOverTime.PointPairData _curPointPair;
    private Vector3 _translationVector;
    private Vector3 _startPos;
    private Vector3 _randomStartOffset;
    private Vector3 _endPos;
    private Vector3 _randomEndOffset;
    private System.Random _randomizer;
    private float _timer;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CanThisScriptRun() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandlePositionUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ChooseRandomPointPair() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculateTranslationVector() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float RandomFloatBetweenNegOneAndOne() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetSingleRandomOffset(float offsetExtent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RandomizeOffsets() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RestartTransition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReRandomizeTransition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TranslateBetweenTwoPointsOverTime() => throw null;

    [Serializable]
    public class PointPairData
    {
      public Transform StartPoint;
      public Vector3 StartOffsetMaximums;
      [Space(5f)]
      public Transform EndPoint;
      public Vector3 EndOffsetMaximums;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public PointPairData() => throw null;
    }
  }
}
