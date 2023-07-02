// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.Converters.ClrToScriptConversions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop.Converters
{
  internal static class ClrToScriptConversions
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static DynValue TryObjectToTrivialDynValue(Script script, object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static DynValue TryObjectToSimpleDynValue(Script script, object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static DynValue ObjectToDynValue(Script script, object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue EnumerationToDynValue(Script script, object obj) => throw null;
  }
}
