// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.LuaTypeExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
