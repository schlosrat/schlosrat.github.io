// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.PropertyTableAssigner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop
{
  public class PropertyTableAssigner : IPropertyTableAssigner
  {
    private Type m_Type;
    private Dictionary<string, PropertyInfo> m_PropertyMap;
    private Dictionary<Type, IPropertyTableAssigner> m_SubAssigners;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PropertyTableAssigner(Type type, params string[] expectedMissingProperties) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddExpectedMissingProperty(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryAssignProperty(object obj, string name, DynValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AssignProperty(object obj, string name, DynValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AssignObject(object obj, MoonSharp.Interpreter.Table data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSubassignerForType(Type propertyType, IPropertyTableAssigner assigner) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IPropertyTableAssigner.AssignObjectUnchecked(object obj, MoonSharp.Interpreter.Table data) => throw null;
  }
}
