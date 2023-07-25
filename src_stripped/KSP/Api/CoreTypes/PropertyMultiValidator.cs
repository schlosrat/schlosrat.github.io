// Decompiled with JetBrains decompiler
// Type: KSP.Api.CoreTypes.PropertyMultiValidator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes.Generic;
using KSP.Api.Generic;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Api.CoreTypes
{
  public class PropertyMultiValidator : IProperty<bool>, IProperty
  {
    protected EventHandlerProxy<bool> onChangedProxy;
    protected Dictionary<IProperty, Func<object, bool>> propertyValidators;
    protected bool storedIsValid;

    public Type StoredType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public event Action<bool> OnChangedValue
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

    protected bool DefaultWhenEmpty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PropertyMultiValidator(bool defaultWhenEmpty = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public object GetObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetValue() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddValidation(IProperty property, Func<object, bool> validator) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveValidation(IProperty property) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearValidations() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void RunAllValidators() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void InvokeValueChanged(bool newValue) => throw null;
  }
}
