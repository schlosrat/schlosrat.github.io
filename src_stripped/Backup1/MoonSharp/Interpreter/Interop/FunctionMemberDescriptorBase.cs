// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.FunctionMemberDescriptorBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Interop.BasicDescriptors;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop
{
  public abstract class FunctionMemberDescriptorBase : 
    IOverloadableMemberDescriptor,
    IMemberDescriptor
  {
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

    public string SortDiscriminant
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ParameterDescriptor[] Parameters
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Type ExtensionMethodType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Type VarArgsArrayType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Type VarArgsElementType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void Initialize(
      string funcName,
      bool isStatic,
      ParameterDescriptor[] parameters,
      bool isExtensionMethod)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Func<ScriptExecutionContext, CallbackArguments, DynValue> GetCallback(
      Script script,
      object obj = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CallbackFunction GetCallbackFunction(Script script, object obj = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue GetCallbackAsDynValue(Script script, object obj = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue CreateCallbackDynValue(Script script, MethodInfo mi, object obj = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual object[] BuildArgumentList(
      Script script,
      object obj,
      ScriptExecutionContext context,
      CallbackArguments args,
      out List<int> outParams)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static DynValue BuildReturnValue(
      Script script,
      List<int> outParams,
      object[] pars,
      object retv)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract DynValue Execute(
      Script script,
      object obj,
      ScriptExecutionContext context,
      CallbackArguments args)
    {
      throw null;
    }

    public MemberDescriptorAccess MemberAccess
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual DynValue GetValue(Script script, object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetValue(Script script, object obj, DynValue v) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected FunctionMemberDescriptorBase() => throw null;
  }
}
