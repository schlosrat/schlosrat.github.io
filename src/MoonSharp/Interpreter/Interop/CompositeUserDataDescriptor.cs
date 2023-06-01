// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.CompositeUserDataDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop
{
  public class CompositeUserDataDescriptor : IUserDataDescriptor
  {
    private List<IUserDataDescriptor> m_Descriptors;
    private Type m_Type;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CompositeUserDataDescriptor(List<IUserDataDescriptor> descriptors, Type type) => throw null;

    public IList<IUserDataDescriptor> Descriptors
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Type Type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Index(Script script, object obj, DynValue index, bool isNameIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetIndex(
      Script script,
      object obj,
      DynValue index,
      DynValue value,
      bool isNameIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string AsString(object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue MetaIndex(Script script, object obj, string metaname) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsTypeCompatible(Type type, object obj) => throw null;
  }
}
