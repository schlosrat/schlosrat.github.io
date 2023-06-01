// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIValueEnumBinder
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
  public abstract class UIValueEnumBinder : 
    UIValueBinder<string>,
    IUIValueEnumBindable,
    IUIValueBindable
  {
    [SerializeField]
    private List<string> mappedEnumValues;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnMappedEnumValuesChanged(
      IReadOnlyList<string> newValues,
      bool shouldRedraw)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void PopulateValueMap() => throw null;

    public IReadOnlyList<string> EnumValues
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int PositiveMod(int value, int mod) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetMappedEnumValueIndex(string enumValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMappedEnumValueIndex(int newIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddMappedEnumValueOffset(int indexOffset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void BindValue(IProperty valueProperty) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindValue(IProperty valueEnumProperty, IEnumerable<string> enumValues) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindValue(IProperty valueEnumProperty, System.Type enumType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMappedEnumValues(IEnumerable<string> enumValues, bool shouldRedraw = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMappedEnum(System.Type enumType, bool shouldRedraw = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected UIValueEnumBinder() => throw null;
  }
}
