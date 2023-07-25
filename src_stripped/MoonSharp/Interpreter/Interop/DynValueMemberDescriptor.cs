// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.DynValueMemberDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Interop.BasicDescriptors;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop
{
  public class DynValueMemberDescriptor : IMemberDescriptor, IWireableDescriptor
  {
    private DynValue m_Value;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected DynValueMemberDescriptor(string name, string serializedTableValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected DynValueMemberDescriptor(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValueMemberDescriptor(string name, DynValue value) => throw null;

    public bool IsStatic
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
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

    public virtual DynValue Value
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue GetValue(Script script, object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetValue(Script script, object obj, DynValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PrepareForWiring(Table t) => throw null;
  }
}
