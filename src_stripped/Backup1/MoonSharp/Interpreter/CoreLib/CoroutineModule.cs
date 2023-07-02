// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.CoreLib.CoroutineModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.CoreLib
{
  [MoonSharpModule(Namespace = "coroutine")]
  public class CoroutineModule
  {
    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue create(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue wrap(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue __wrap_wrapper(
      ScriptExecutionContext executionContext,
      CallbackArguments args)
    {
      throw null;
    }

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue resume(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue yield(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue running(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue status(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CoroutineModule() => throw null;
  }
}
