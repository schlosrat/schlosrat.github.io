// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.DescriptorHelpers
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop
{
  public static class DescriptorHelpers
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool? GetVisibilityFromAttributes(this MemberInfo mi) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsDelegateType(this Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetClrVisibility(this Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetClrVisibility(this FieldInfo info) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetClrVisibility(this PropertyInfo info) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetClrVisibility(this MethodBase info) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsPropertyInfoPublic(this PropertyInfo pi) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<string> GetMetaNamesFromAttributes(this MethodInfo mi) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Type[] SafeGetTypes(this Assembly asm) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetConversionMethodName(this Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<Type> GetAllImplementedTypes(this Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsValidSimpleIdentifier(string str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ToValidSimpleIdentifier(string str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string Camelify(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string UpperFirstLetter(string name) => throw null;
  }
}
