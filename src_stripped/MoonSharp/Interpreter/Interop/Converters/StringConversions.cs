// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.Converters.StringConversions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop.Converters
{
  internal static class StringConversions
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static StringConversions.StringSubtype GetStringSubtype(Type desiredType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object ConvertString(
      StringConversions.StringSubtype stringSubType,
      string str,
      Type desiredType,
      DataType dataType)
    {
      throw null;
    }

    internal enum StringSubtype
    {
      None,
      String,
      StringBuilder,
      Char,
    }
  }
}
