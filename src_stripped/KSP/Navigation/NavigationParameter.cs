﻿// Decompiled with JetBrains decompiler
// Type: KSP.Navigation.NavigationParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Navigation
{
  [Serializable]
  public struct NavigationParameter
  {
    public const float _defaultSelectionAngularRange = 60f;
    public const float _defaultOffsetTolerance = 10f;
    public const float _defaultDirectionalTolerance = 10f;
    public const float _defaultmixedRadius = 200f;
    public const float _defaultOffsetToleranceNear = 10f;
    public const float _defaultOffsetToleranceFar = 200f;
    public static NavigationParameter Default;
    public SelectionPriorityMode SelectionPriorityMode;
    public bool IgnoreCovered;
    public float CoveredTolerance;
    [Header("Simple mode")]
    [Range(1f, 89f)]
    [SerializeField]
    private float _selectionAngularRange;
    [Range(0.0f, 100f)]
    [SerializeField]
    private float _offsetTolerance;
    [SerializeField]
    [Range(0.0f, 100f)]
    private float _directionalTolerance;
    [Header("Mixed mode")]
    [SerializeField]
    private float _mixedRadius;
    [SerializeField]
    [Header("Mixed offset tolerance mode")]
    private float _offsetToleranceNear;
    [SerializeField]
    private float _offsetToleranceFar;

    public float AngularRange
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float OffsetTolerance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float DirectionalTolerance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float MixedRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float OffsetToleranceNear
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float OffsetToleranceFar
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static NavigationParameter() => throw null;
  }
}
