// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIValueBinderGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding.Core
{
  public class UIValueBinderGroup : 
    UIValueBinder,
    IUIValueBindable,
    IUIValueNumberBindable,
    IUIValueEnumBindable
  {
    [Header("Binders to pass 'BindValue' calls to")]
    [SerializeField]
    private UIValueBinder[] binders;
    private bool isBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveCircularReferences() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void BindValue(IProperty valueProperty) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnClick() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindValue(IProperty numberProperty, double min, double max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMappedValueRange(double min, double max, bool shouldRedraw = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindValue(IProperty enumValueProperty, IEnumerable<string> enumValues) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindValue(IProperty enumValueProperty, System.Type enumType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMappedEnumValues(IEnumerable<string> enumValues, bool shouldRedraw = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMappedEnum(System.Type enumType, bool shouldRedraw = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValueBinderGroup() => throw null;
  }
}
