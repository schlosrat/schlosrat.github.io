// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.ObjectCallbackMemberDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter.Interop.BasicDescriptors;
using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop
{
  public class ObjectCallbackMemberDescriptor : FunctionMemberDescriptorBase
  {
    private Func<object, ScriptExecutionContext, CallbackArguments, object> m_CallbackFunc;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectCallbackMemberDescriptor(string funcName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectCallbackMemberDescriptor(
      string funcName,
      Func<object, ScriptExecutionContext, CallbackArguments, object> callBack)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectCallbackMemberDescriptor(
      string funcName,
      Func<object, ScriptExecutionContext, CallbackArguments, object> callBack,
      ParameterDescriptor[] parameters)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DynValue Execute(
      Script script,
      object obj,
      ScriptExecutionContext context,
      CallbackArguments args)
    {
      throw null;
    }
  }
}
