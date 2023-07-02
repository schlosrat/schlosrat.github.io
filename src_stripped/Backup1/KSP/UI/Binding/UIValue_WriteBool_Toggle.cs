// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_WriteBool_Toggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI.Binding
{
  public class UIValue_WriteBool_Toggle : UIValueBinder<bool>
  {
    [SerializeField]
    public List<ToggleExtended> toggles;
    [SerializeField]
    private bool makeNonclickableWhenOn;
    private bool ignoreToggleEvents;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddNewToggle(ToggleExtended addToggle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ToggleExtended GetToggle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandleToggleValueChangedByConsole(bool newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleToggleValueChanged(bool newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnClick() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetInteractableState(bool isInteractable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_WriteBool_Toggle() => throw null;
  }
}
