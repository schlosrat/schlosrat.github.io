// Decompiled with JetBrains decompiler
// Type: KSP.Api.CoreTypes.PropertyReadonly`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes.Generic;
using KSP.Api.Generic;
using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Api.CoreTypes
{
  [Serializable]
  public class PropertyReadonly<T> : IProperty<T>, IProperty, IPropertyEnumValues
  {
    protected EventHandlerProxy<T> onChangedProxy;
    private static string[] cachedEnumNames;
    private static int[] cachedEnumIndices;
    [SerializeField]
    protected T storedValue;
    protected readonly Func<T, T> valueValidator;

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

    [JsonIgnore]
    public System.Type StoredType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T GetValue() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public object GetObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetObject(object value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetValue(T value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetValue(IProperty<T> prop) => throw null;

    [JsonIgnore]
    public string[] EnumNames
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [JsonIgnore]
    public int[] EnumIndices
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PropertyReadonly() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetEnumValues(string[] newEnumNames, int[] newEnumIndices = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PropertyReadonly(T initialValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PropertyReadonly(T initialValue, Func<T, T> validator) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetValueInternal(T value, bool skipEvent = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void InvokeValueChanged(T newValue) => throw null;
  }
}
