// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_WriteBool_ToggleFlipFlop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI.Binding
{
  [RequireComponent(typeof (ToggleGroup))]
  public class UIValue_WriteBool_ToggleFlipFlop : UIValueBinder<bool>
  {
    [Header("Required")]
    [SerializeField]
    private Toggle toggleSetOn;
    [SerializeField]
    private Toggle toggleSetOff;
    [SerializeField]
    [Header("Optional")]
    private Button toggleButton;
    private ToggleGroup toggleGroup;
    private bool ignoreToggleEvents;

    private bool IsValueTrue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnClick() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ActiveSetOn() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ActiveSetOff() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void HandleToggleOn(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void HandleToggleOff(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void HandleButtonToggle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_WriteBool_ToggleFlipFlop() => throw null;
  }
}
