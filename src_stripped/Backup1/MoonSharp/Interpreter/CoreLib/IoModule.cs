// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.CoreLib.IoModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.CoreLib.IO;
using MoonSharp.Interpreter.Platforms;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace MoonSharp.Interpreter.CoreLib
{
  [MoonSharpModule(Namespace = "io")]
  public class IoModule
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MoonSharpInit(Table globalTable, Table ioTable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static DynValue __index_callback(
      ScriptExecutionContext executionContext,
      CallbackArguments args)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static DynValue GetStandardFile(Script S, StandardFileType file) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SetStandardFile(Script S, StandardFileType file, Stream optionsStream) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static FileUserDataBase GetDefaultFile(
      ScriptExecutionContext executionContext,
      StandardFileType file)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SetDefaultFile(
      ScriptExecutionContext executionContext,
      StandardFileType file,
      FileUserDataBase fileHandle)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void SetDefaultFile(
      Script script,
      StandardFileType file,
      FileUserDataBase fileHandle)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetDefaultFile(Script script, StandardFileType file, Stream stream) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue close(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue flush(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue input(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue output(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static DynValue HandleDefaultStreamSetter(
      ScriptExecutionContext executionContext,
      CallbackArguments args,
      StandardFileType defaultFiles)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Encoding GetUTF8Encoding() => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue lines(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue open(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string IoExceptionToLuaMessage(Exception ex, string filename) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue type(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue read(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue write(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue tmpfile(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static FileUserDataBase Open(
      ScriptExecutionContext executionContext,
      string filename,
      Encoding encoding,
      string mode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IoModule() => throw null;
  }
}
