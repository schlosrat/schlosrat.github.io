// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.StandardUserDataDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter.Interop.BasicDescriptors;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop
{
  public class StandardUserDataDescriptor : DispatchingUserDataDescriptor, IWireableDescriptor
  {
    public InteropAccessMode AccessMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardUserDataDescriptor(Type type, InteropAccessMode accessMode, string friendlyName = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FillMemberList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PrepareForWiring(Table t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Serialize(
      Table t,
      IEnumerable<KeyValuePair<string, IMemberDescriptor>> members)
    {
      throw null;
    }
  }
}
