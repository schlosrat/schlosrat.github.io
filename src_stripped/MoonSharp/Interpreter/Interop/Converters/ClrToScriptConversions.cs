// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.Converters.ClrToScriptConversions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
