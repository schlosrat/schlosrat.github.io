// Decompiled with JetBrains decompiler
// Type: KSP.Api.CoreTypes.Property`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.Generic;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Api.CoreTypes
{
  [Serializable]
  public class Property<T> : 
    PropertyReadonly<T>,
    IPropertyWritable<T>,
    IPropertyWritable,
    IProperty,
    IProperty<T>
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Property(T initialValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Property(T initialValue, Func<T, T> validator) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IPropertyWritable.SetObject(object value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IPropertyWritable<T>.SetValue(T value) => throw null;
  }
}
