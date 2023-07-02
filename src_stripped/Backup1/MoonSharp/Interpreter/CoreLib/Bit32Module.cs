// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.CoreLib.Bit32Module
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.CoreLib
{
  [MoonSharpModule(Namespace = "bit32")]
  public class Bit32Module
  {
    private static readonly uint[] MASKS;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static uint ToUInt32(DynValue v) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int ToInt32(DynValue v) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static uint NBitMask(int bits) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static uint Bitwise(
      string funcName,
      CallbackArguments args,
      Func<uint, uint, uint> accumFunc)
    {
      throw null;
    }

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue extract(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue replace(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void ValidatePosWidth(string func, int argPos, int pos, int width) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue arshift(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue rshift(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue lshift(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue band(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue btest(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue bor(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue bnot(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue bxor(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue lrotate(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue rrotate(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Bit32Module() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Bit32Module() => throw null;
  }
}
