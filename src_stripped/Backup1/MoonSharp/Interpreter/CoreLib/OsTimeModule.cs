// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.CoreLib.OsTimeModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.CoreLib
{
  [MoonSharpModule(Namespace = "os")]
  public class OsTimeModule
  {
    private static DateTime Time0;
    private static DateTime Epoch;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static DynValue GetUnixTime(DateTime dateTime, DateTime? epoch = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static DateTime FromUnixTime(double unixtime) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue clock(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue difftime(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue time(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static DateTime ParseTimeTable(Table t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int? GetTimeTableField(Table t, string key) => throw null;

    [MoonSharpModuleMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue date(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string StrFTime(string format, DateTime d) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OsTimeModule() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static OsTimeModule() => throw null;
  }
}
