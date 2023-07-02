// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.UI.DataBinding02_BindingSwap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    [SerializeField]
    [Header("UI Binding")]
    private RectTransform entityUILocator;
    [SerializeField]
    private UIData_DemoEntity entityUIPrefab;
    private UIData_DemoEntity entityUIInstance;
    [SerializeField]
    [Header("The Index in the list we are displaying")]
    private int listIndex;
    private int lastIndex;
    [SerializeField]
    [Header("The List of data we are displaying from")]
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
