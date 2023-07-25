// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIValue_WriteEnum_BoolSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding.Core
{
  public class UIValue_WriteEnum_BoolSet : UIValueEnumBinder
  {
    [Header("Bool UIValue Binders for each value")]
    [SerializeField]
    public List<UIValue_WriteEnum_BoolSet.BoolToggleEntry> boolBindings;
    [Header("Handling fallback sending")]
    [SerializeField]
    private bool setFallbackOnUncheck;
    [SerializeField]
    private string fallbackValueToSend;
    private Dictionary<string, List<UIValueBinder>> valueBinderMap;
    private Dictionary<string, Property<bool>> valuePropertyMap;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void PopulateValueMap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdatePopulateValueMap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void ForceRedraw(string boundValue, bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BindMappedValueBinders() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnbindMappedValueBinders() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateValueBindersMap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePropertyMap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleFallbackSend() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_WriteEnum_BoolSet() => throw null;

    [Serializable]
    public struct BoolToggleEntry
    {
      public string enumValue;
      public List<UIValueBinder> boolBinder;
    }
  }
}
