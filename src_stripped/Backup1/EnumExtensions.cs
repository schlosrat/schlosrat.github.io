// Decompiled with JetBrains decompiler
// Type: EnumExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
