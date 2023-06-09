﻿// Decompiled with JetBrains decompiler
// Type: TrainingCentreTooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI;
using KSP.UI.Binding;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof (CanvasGroup))]
[RequireComponent(typeof (LayoutElement))]
public class TrainingCentreTooltip : ExtendedTooltip<TutorialElementData>
{
  [SerializeField]
  private int contentSize;
  [SerializeField]
  private float delayTime;
  [SerializeField]
  private ContextBindRoot bindRoot;
  private DataContext dataContext;
  private Property<string> description;
  private const string DESCRIPTION_PROPERTY_KEY = "description";
  private LayoutElement layoutElement;
  private Coroutine showCoroutine;
  private CanvasGroup canvasGroup;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateTooltipData() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator LocalShow() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void Show() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void Hide() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Resize(string description) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public TrainingCentreTooltip() => throw null;
}
