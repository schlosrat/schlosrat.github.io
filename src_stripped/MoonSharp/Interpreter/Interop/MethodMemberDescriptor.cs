// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.MethodMemberDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter.Interop.BasicDescriptors;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop
{
  public class MethodMemberDescriptor : 
    FunctionMemberDescriptorBase,
    IOptimizableDescriptor,
    IWireableDescriptor
  {
    private Func<object, object[], object> m_OptimizedFunc;
    private Action<object, object[]> m_OptimizedAction;
    private bool m_IsAction;
    private bool m_IsArrayCtor;

    public MethodBase MethodInfo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public InteropAccessMode AccessMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsConstructor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MethodMemberDescriptor(MethodBase methodBase, InteropAccessMode accessMode = InteropAccessMode.Default) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static MethodMemberDescriptor TryCreateIfVisible(
      MethodBase methodBase,
      InteropAccessMode accessMode,
      bool forceVisibility = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CheckMethodIsCompatible(MethodBase methodBase, bool throwException) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DynValue Execute(
      Script script,
      object obj,
      ScriptExecutionContext context,
      CallbackArguments args)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IOptimizableDescriptor.Optimize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PrepareForWiring(MoonSharp.Interpreter.Table t) => throw null;
  }
}
