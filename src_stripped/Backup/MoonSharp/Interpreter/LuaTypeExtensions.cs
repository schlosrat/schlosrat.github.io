// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.LuaTypeExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter
{
  public static class LuaTypeExtensions
  {
    internal const DataType MaxMetaTypes = DataType.Table;
    internal const DataType MaxConvertibleTypes = DataType.ClrFunction;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CanHaveTypeMetatables(this DataType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ToErrorTypeString(this DataType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ToLuaDebuggerString(this DataType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ToLuaTypeString(this DataType type) => throw null;
  }
}
