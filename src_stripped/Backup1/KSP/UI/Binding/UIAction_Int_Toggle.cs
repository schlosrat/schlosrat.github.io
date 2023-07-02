// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIAction_Int_Toggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.UI.Binding.Core;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI.Binding
{
  [DisableCustomEditorBase]
  public class UIAction_Int_Toggle : UIActionBinder
  {
    [Header("if left blank 'Action Key' will be used onToggleOff")]
    public string OnToggleOffAction;
    public ToggleExtended Toggle;
    public List<UIAction_Int_Button.IntArg> IntArgs;
    private string onToggleOnAction;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnToggleClicked() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckActionKeyChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private object[] GetArgs(IDataContextReadonly context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIAction_Int_Toggle() => throw null;
  }
}
