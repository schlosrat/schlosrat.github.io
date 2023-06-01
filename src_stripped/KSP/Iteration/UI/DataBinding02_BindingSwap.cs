// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.UI.DataBinding02_BindingSwap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Iteration.Data;
using KSP.Iteration.Data.impl;
using KSP.Iteration.UI.Binding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Iteration.UI
{
  public class DataBinding02_BindingSwap : MonoBehaviour
  {
    [Header("UI Elements")]
    [SerializeField]
    private TMP_Text textInfo;
    [SerializeField]
    private Button buttonPrev;
    [SerializeField]
    private Button buttonNext;
    [SerializeField]
    private Button buttonAdd;
    [SerializeField]
    private Button buttonRemove;
    [SerializeField]
    private Button buttonRandomize;
    [Header("UI Binding")]
    [SerializeField]
    private RectTransform entityUILocator;
    [SerializeField]
    private UIData_DemoEntity entityUIPrefab;
    private UIData_DemoEntity entityUIInstance;
    [SerializeField]
    [Header("The Index in the list we are displaying")]
    private int listIndex;
    private int lastIndex;
    [Header("The List of data we are displaying from")]
    [SerializeField]
    private List<DemoEntity> entityList;
    private Property<IDemoEntity> selectedEntity;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateListView() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateDataUILifetime() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateDemoUIControls() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateDrawnElement() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPrevClicked() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnNextClicked() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAddClicked() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRemoveClicked() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRandomizeClicked() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DataBinding02_BindingSwap() => throw null;
  }
}
