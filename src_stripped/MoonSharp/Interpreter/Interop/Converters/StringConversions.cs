// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.Converters.StringConversions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
