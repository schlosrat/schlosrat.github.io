// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.StandardUserDataDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
