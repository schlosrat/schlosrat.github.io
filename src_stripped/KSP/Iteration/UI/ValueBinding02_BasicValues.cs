﻿// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.UI.ValueBinding02_BasicValues
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Iteration.UI
{
  public class ValueBinding02_BasicValues : MonoBehaviour
  {
    [SerializeField]
    private UIValueBinder stringText;
    [SerializeField]
    private UIValueBinder stringField;
    [Space]
    [SerializeField]
    private UIValueBinder intText;
    [SerializeField]
    private UIValueBinder intField;
    [SerializeField]
    [Space]
    private UIValueBinder floatText;
    [SerializeField]
    private UIValueBinder floatField;
    [SerializeField]
    [Header("Mock Data")]
    private string stringValue;
    [Space]
    [SerializeField]
    private int intValue;
    [Space]
    [SerializeField]
    private float floatValue;
    private PropertyExternal<string> stringProp;
    private PropertyExternal<int> intProp;
    private PropertyExternal<float> floatProp;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StringReadableChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void IntReadableChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FloatReadableChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ValueBinding02_BasicValues() => throw null;
  }
}
