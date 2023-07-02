// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.Converters.StringConversions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
