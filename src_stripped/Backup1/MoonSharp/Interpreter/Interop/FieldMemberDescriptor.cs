// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.FieldMemberDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Interop.BasicDescriptors;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop
{
  public class FieldMemberDescriptor : IMemberDescriptor, IOptimizableDescriptor, IWireableDescriptor
  {
    private object m_ConstValue;
    private Func<object, object> m_OptimizedGetter;

    public FieldInfo FieldInfo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public InteropAccessMode AccessMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
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

    public bool IsConst
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsReadonly
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static FieldMemberDescriptor TryCreateIfVisible(
      FieldInfo fi,
      InteropAccessMode accessMode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FieldMemberDescriptor(FieldInfo fi, InteropAccessMode accessMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue GetValue(Script script, object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void OptimizeGetter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetValue(Script script, object obj, DynValue v) => throw null;

    public MemberDescriptorAccess MemberAccess
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IOptimizableDescriptor.Optimize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PrepareForWiring(MoonSharp.Interpreter.Table t) => throw null;
  }
}
