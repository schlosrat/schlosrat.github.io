// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.CoreLib.LoadModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.CoreLib
{
  [MoonSharpModule]
  public class LoadModule
  {
    [MoonSharpModuleMethod]
    public const string require = "\r\nfunction(modulename)\r\n\tif (package == nil) then package = { }; end\r\n\tif (package.loaded == nil) then package.loaded = { }; end\r\n\r\n\tlocal m = package.loaded[modulename];\r\n\r\n\tif (m ~= nil) then\r\n\t\treturn m;\r\n\tend\r\n\r\n\tlocal func = __require_clr_impl(modulename);\r\n\r\n\tlocal res = func(modulename);\r\n\r\n\tif (res == nil) then\r\n\t\tres = true;\r\n\tend\r\n\r\n\tpackage.loaded[modulename] = res;\r\n\r\n\treturn res;\r\nend";

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MoonSharpInit(Table globalTable, Table ioTable) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue load(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue loadsafe(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue load_impl(
      ScriptExecutionContext executionContext,
      CallbackArguments args,
      Table defaultEnv)
    {
      throw null;
    }

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue loadfile(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue loadfilesafe(
      ScriptExecutionContext executionContext,
      CallbackArguments args)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static DynValue loadfile_impl(
      ScriptExecutionContext executionContext,
      CallbackArguments args,
      Table defaultEnv)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Table GetSafeDefaultEnv(ScriptExecutionContext executionContext) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue dofile(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue __require_clr_impl(
      ScriptExecutionContext executionContext,
      CallbackArguments args)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LoadModule() => throw null;
  }
}
