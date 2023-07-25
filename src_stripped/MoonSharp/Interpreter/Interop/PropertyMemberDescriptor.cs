// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.PropertyMemberDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Interop.BasicDescriptors;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop
{
  public class PropertyMemberDescriptor : 
    IMemberDescriptor,
    IOptimizableDescriptor,
    IWireableDescriptor
  {
    private MethodInfo m_Getter;
    private MethodInfo m_Setter;
    private Func<object, object> m_OptimizedGetter;
    private Action<object, object> m_OptimizedSetter;

    public PropertyInfo PropertyInfo
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

    public bool CanRead
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool CanWrite
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static PropertyMemberDescriptor TryCreateIfVisible(
      PropertyInfo pi,
      InteropAccessMode accessMode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static PropertyMemberDescriptor TryCreate(
      PropertyInfo pi,
      InteropAccessMode accessMode,
      MethodInfo getter,
      MethodInfo setter)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PropertyMemberDescriptor(PropertyInfo pi, InteropAccessMode accessMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PropertyMemberDescriptor(
      PropertyInfo pi,
      InteropAccessMode accessMode,
      MethodInfo getter,
      MethodInfo setter)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue GetValue(Script script, object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void OptimizeGetter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void OptimizeSetter() => throw null;

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
