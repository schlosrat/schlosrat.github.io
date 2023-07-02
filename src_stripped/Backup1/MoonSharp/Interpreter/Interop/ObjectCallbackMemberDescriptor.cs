// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.ObjectCallbackMemberDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
