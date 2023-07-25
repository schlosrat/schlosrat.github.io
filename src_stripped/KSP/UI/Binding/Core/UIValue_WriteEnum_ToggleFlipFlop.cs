// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIValue_WriteEnum_ToggleFlipFlop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UI.Control;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace KSP.UI.Binding.Core
{
  public class UIValue_WriteEnum_ToggleFlipFlop : UIValueEnumBinder
  {
    [SerializeField]
    private List<UIValue_WriteEnum_ToggleFlipFlop.EnumToggleEntry> _enumToggles;
    private ToggleGroupExtended _toggleGroup;
    private bool _ignoreToggleEvents;
    private List<UnityAction<bool>> _suscribedCallbacks;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnClick() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ActiveSetToggle(ToggleExtended toggle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void HandleToggle(ToggleExtended toggle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_WriteEnum_ToggleFlipFlop() => throw null;

    [Serializable]
    public struct EnumToggleEntry
    {
      public string EnumValue;
      public ToggleExtended Toggle;
    }
  }
}
