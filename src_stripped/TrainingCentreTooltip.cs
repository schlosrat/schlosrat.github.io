// Decompiled with JetBrains decompiler
// Type: TrainingCentreTooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.UI;
using KSP.UI.Binding;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof (LayoutElement))]
[RequireComponent(typeof (CanvasGroup))]
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
