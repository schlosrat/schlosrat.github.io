// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.PropertyTableAssigner`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop
{
  public class PropertyTableAssigner<T> : IPropertyTableAssigner
  {
    private PropertyTableAssigner m_InternalAssigner;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PropertyTableAssigner(params string[] expectedMissingProperties) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddExpectedMissingProperty(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AssignObject(T obj, Table data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PropertyTableAssigner GetTypeUnsafeAssigner() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSubassignerForType(Type propertyType, IPropertyTableAssigner assigner) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSubassigner<SubassignerType>(PropertyTableAssigner<SubassignerType> assigner) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IPropertyTableAssigner.AssignObjectUnchecked(object o, Table data) => throw null;
  }
}
