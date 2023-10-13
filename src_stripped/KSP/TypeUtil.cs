// Decompiled with JetBrains decompiler
// Type: KSP.TypeUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP
{
  public static class TypeUtil
  {
    private static readonly Dictionary<Type, int> PrimativeSizeLookup;
    private static Dictionary<Type, Array> enumValueCache;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsNumericType(this Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsNumericType(this Type type, out bool isSigned) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int IsNumericTypeInternal(Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetPrimativeSize<T>() where T : struct => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsCollectionType(this Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Array GetEnumValues(Type enumType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetEnumSize(Type enumType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetEnumCount<T>() where T : struct, IConvertible => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object GetCycledEnum(Type enumType, object enumValue, int offset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T GetCycledEnum<T>(T enumValue, int offset) where T : struct, IConvertible => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object GetNextEnum(Type enumType, object enumValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T GetNextEnum<T>(T enumValue) where T : struct, IConvertible => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool GetNextValidEnum(
      Type enumType,
      object enumValue,
      Func<object, bool> validator,
      out object validEnum)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool GetNextValidEnum<T>(T enumValue, Func<T, bool> validator, out T validEnum) where T : struct, IConvertible, IComparable => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object GetPrevEnum(Type enumType, object enumValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T GetPrevEnum<T>(T enumValue) where T : struct, IConvertible => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool GetPrevValidEnum(
      Type enumType,
      object enumValue,
      Func<object, bool> validator,
      out object validEnum)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool GetPrevValidEnum<T>(T enumValue, Func<T, bool> validator, out T validEnum) where T : struct, IConvertible, IComparable => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static TypeUtil() => throw null;
  }
}
