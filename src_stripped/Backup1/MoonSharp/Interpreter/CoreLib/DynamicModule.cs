// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.CoreLib.DynamicModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.CoreLib
{
  [MoonSharpModule(Namespace = "dynamic")]
  public class DynamicModule
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MoonSharpInit(Table globalTable, Table stringTable) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue eval(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue prepare(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynamicModule() => throw null;

    private class DynamicExprWrapper
    {
      public DynamicExpression Expr;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public DynamicExprWrapper() => throw null;
    }
  }
}
