// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors.HardwiredMemberDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Interop.BasicDescriptors;
using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors
{
  public abstract class HardwiredMemberDescriptor : IMemberDescriptor
  {
    public Type MemberType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected HardwiredMemberDescriptor(
      Type memberType,
      string name,
      bool isStatic,
      MemberDescriptorAccess access)
    {
      throw null;
    }

    public bool IsStatic
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public MemberDescriptorAccess MemberAccess
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue GetValue(Script script, object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetValue(Script script, object obj, DynValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual object GetValueImpl(Script script, object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void SetValueImpl(Script script, object obj, object value) => throw null;
  }
}
