// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.CoreLib.ErrorHandlingModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.CoreLib
{
  [MoonSharpModule]
  public class ErrorHandlingModule
  {
    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue pcall(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static DynValue SetErrorHandlerStrategy(
      string funcName,
      ScriptExecutionContext executionContext,
      CallbackArguments args,
      DynValue handlerBeforeUnwind)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static DynValue MakeReturnTuple(bool retstatus, CallbackArguments args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue pcall_continuation(
      ScriptExecutionContext executionContext,
      CallbackArguments args)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue pcall_onerror(
      ScriptExecutionContext executionContext,
      CallbackArguments args)
    {
      throw null;
    }

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue xpcall(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ErrorHandlingModule() => throw null;
  }
}
