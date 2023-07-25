// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.StandardGenericsUserDataDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop
{
  public class StandardGenericsUserDataDescriptor : IUserDataDescriptor, IGeneratorUserDataDescriptor
  {
    public InteropAccessMode AccessMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardGenericsUserDataDescriptor(Type type, InteropAccessMode accessMode) => throw null;

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Type Type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IUserDataDescriptor Generate(Type type) => throw null;
  }
}
