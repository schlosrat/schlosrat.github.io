// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.UserDataRegistries.ExtensionMethodsRegistry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter.DataStructs;
using MoonSharp.Interpreter.Interop.BasicDescriptors;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop.UserDataRegistries
{
  internal class ExtensionMethodsRegistry
  {
    private static object s_Lock;
    private static MultiDictionary<string, IOverloadableMemberDescriptor> s_Registry;
    private static MultiDictionary<string, ExtensionMethodsRegistry.UnresolvedGenericMethod> s_UnresolvedGenericsRegistry;
    private static int s_ExtensionMethodChangeVersion;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RegisterExtensionType(Type type, InteropAccessMode mode = InteropAccessMode.Default) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static object FrameworkGetMethods() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<IOverloadableMemberDescriptor> GetExtensionMethodsByName(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetExtensionMethodsChangeVersion() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<IOverloadableMemberDescriptor> GetExtensionMethodsByNameAndType(
      string name,
      Type extendedType)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static MethodInfo InstantiateMethodInfo(
      MethodInfo mi,
      Type extensionType,
      Type genericType,
      Type extendedType)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Type GetGenericMatch(Type extensionType, Type extendedType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ExtensionMethodsRegistry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ExtensionMethodsRegistry() => throw null;

    private class UnresolvedGenericMethod
    {
      public readonly MethodInfo Method;
      public readonly InteropAccessMode AccessMode;
      public readonly HashSet<Type> AlreadyAddedTypes;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public UnresolvedGenericMethod(MethodInfo mi, InteropAccessMode mode) => throw null;
    }
  }
}
