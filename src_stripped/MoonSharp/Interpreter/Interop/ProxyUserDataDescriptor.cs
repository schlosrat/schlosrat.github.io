// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.ProxyUserDataDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop
{
  public sealed class ProxyUserDataDescriptor : IUserDataDescriptor
  {
    private IUserDataDescriptor m_ProxyDescriptor;
    private IProxyFactory m_ProxyFactory;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ProxyUserDataDescriptor(
      IProxyFactory proxyFactory,
      IUserDataDescriptor proxyDescriptor,
      string friendlyName = null)
    {
      throw null;
    }

    public IUserDataDescriptor InnerDescriptor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Type Type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private object Proxy(object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Index(Script script, object obj, DynValue index, bool isDirectIndexing) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetIndex(
      Script script,
      object obj,
      DynValue index,
      DynValue value,
      bool isDirectIndexing)
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
