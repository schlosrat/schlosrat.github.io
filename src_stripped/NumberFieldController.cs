// Decompiled with JetBrains decompiler
// Type: NumberFieldController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class NumberFieldController : 
  KerbalMonoBehaviour,
  IPointerEnterHandler,
  IEventSystemHandler,
  IPointerExitHandler
{
  [SerializeField]
  private ContextBindRoot _bindRoot;
  [Space]
  [SerializeField]
  private CanvasGroup _numPad;
  public DataContext _dataContext;
  private InputFieldExtended _inputField;
  private bool _isCursorOnButton;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void InitializeContextBinding() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void HandleStateChange(SelectionState state, bool val) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void EndEditEvent(string text) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnPointerEnter(PointerEventData eventData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnPointerExit(PointerEventData eventData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDeselect(string text) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void WriteInString(string number) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnButtonDelete() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnButtonValidate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public NumberFieldController() => throw null;
}
