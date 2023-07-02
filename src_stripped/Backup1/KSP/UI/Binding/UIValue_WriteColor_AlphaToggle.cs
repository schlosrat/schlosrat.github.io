// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_WriteColor_AlphaToggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI.Binding
{
  public class UIValue_WriteColor_AlphaToggle : UIValueBinder<Color>
  {
    [SerializeField]
    private ToggleExtended toggle;
    [SerializeField]
    private bool makeNonclickableWhenOn;
    private bool ignoreToggleEvents;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleToggleValueChanged(bool newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetInteractableState(bool isInteractable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_WriteColor_AlphaToggle() => throw null;
  }
}
