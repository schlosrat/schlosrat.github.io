// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.Converters.ScriptToClrConversions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop.Converters
{
  internal static class ScriptToClrConversions
  {
    internal const int WEIGHT_MAX_VALUE = 100;
    internal const int WEIGHT_CUSTOM_CONVERTER_MATCH = 100;
    internal const int WEIGHT_EXACT_MATCH = 100;
    internal const int WEIGHT_STRING_TO_STRINGBUILDER = 99;
    internal const int WEIGHT_STRING_TO_CHAR = 98;
    internal const int WEIGHT_NIL_TO_NULLABLE = 100;
    internal const int WEIGHT_NIL_TO_REFTYPE = 100;
    internal const int WEIGHT_VOID_WITH_DEFAULT = 50;
    internal const int WEIGHT_VOID_WITHOUT_DEFAULT = 25;
    internal const int WEIGHT_NIL_WITH_DEFAULT = 25;
    internal const int WEIGHT_BOOL_TO_STRING = 5;
    internal const int WEIGHT_NUMBER_TO_STRING = 50;
    internal const int WEIGHT_NUMBER_TO_ENUM = 90;
    internal const int WEIGHT_USERDATA_TO_STRING = 5;
    internal const int WEIGHT_TABLE_CONVERSION = 90;
    internal const int WEIGHT_NUMBER_DOWNCAST = 99;
    internal const int WEIGHT_NO_MATCH = 0;
    internal const int WEIGHT_NO_EXTRA_PARAMS_BONUS = 100;
    internal const int WEIGHT_EXTRA_PARAMS_MALUS = 2;
    internal const int WEIGHT_BYREF_BONUSMALUS = -10;
    internal const int WEIGHT_VARARGS_MALUS = 1;
    internal const int WEIGHT_VARARGS_EMPTY = 40;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object DynValueToObject(DynValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object DynValueToObjectOfType(
      DynValue value,
      Type desiredType,
      object defaultValue,
      bool isOptional)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int DynValueToObjectOfTypeWeight(
      DynValue value,
      Type desiredType,
      bool isOptional)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int GetNumericTypeWeight(Type desiredType) => throw null;
  }
}
