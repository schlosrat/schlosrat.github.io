// Decompiled with JetBrains decompiler
// Type: EnumExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public static class EnumExtensions
{
  [MethodImpl(MethodImplOptions.NoInlining)]
  public static string Description(this Enum e) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static string GetTranslatedDescription(this Enum e) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static List<string> GetDescriptions<TEnum>(TEnum value) where TEnum : struct, IConvertible => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool HasFlag<T>(this T value, T flag) where T : struct, Enum => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static string ToStringFlags(this Enum value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static string ToBinaryString(this Enum value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool IsBackingTypeSigned(this Enum value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static ulong ToUInt64(this Enum value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static long ToInt64(this Enum value) => throw null;
}
