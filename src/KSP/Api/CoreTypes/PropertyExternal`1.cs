// Decompiled with JetBrains decompiler
// Type: KSP.Api.CoreTypes.PropertyExternal`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes.Generic;
using KSP.Api.Generic;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Api.CoreTypes
{
  public class PropertyExternal<T> : 
    IPropertyWritable<T>,
    IPropertyWritable,
    IProperty,
    IProperty<T>,
    IPropertyEnumValues
  {
    private EventHandlerProxy<T> onChangeProxy;
    private static string[] cachedEnumNames;
    private static int[] cachedEnumIndices;
    private Func<T> valueGetter;
    private Action<T> valueSetter;
    private Func<T, T> valueValidator;
    private T lastValueOnValidate;
    private bool forceUpdate;

    public event Action<T> OnChangedValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action<object> OnChangedObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action OnChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public Type StoredType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T GetValue() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public object GetObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IPropertyWritable.SetObject(object value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IPropertyWritable<T>.SetValue(T value) => throw null;

    public string[] EnumNames
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int[] EnumIndices
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PropertyExternal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetEnumValues(string[] newEnumNames, int[] newEnumIndices = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PropertyExternal(Func<T> getter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PropertyExternal(Func<T> getter, Action<T> setter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PropertyExternal(Func<T> getter, Action<T> setter, Func<T, T> validator) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ChangeExternal(Func<T> getter, bool skipEvent = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ChangeExternal(Func<T> getter, Action<T> setter, bool skipEvent = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ChangeExternal(
      Func<T> getter,
      Action<T> setter,
      Func<T, T> validator,
      bool skipEvent = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ForceNextUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ChangeExternal_Implementation(
      Func<T> getter,
      Action<T> setter,
      Func<T, T> validator,
      bool skipEvent)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ValidateExternal(bool skipEvent = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetValueInternal(T value, bool skipEvent = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InvokeValueChanged(T newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InvokeValueChanged() => throw null;
  }
}
