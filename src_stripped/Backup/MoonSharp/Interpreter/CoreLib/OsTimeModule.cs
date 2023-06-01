// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.CoreLib.OsTimeModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
