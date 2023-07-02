// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.UserDataRegistries.TypeDescriptorRegistry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Interop.RegistrationPolicies;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop.UserDataRegistries
{
  internal static class TypeDescriptorRegistry
  {
    private static object s_Lock;
    private static Dictionary<Type, IUserDataDescriptor> s_TypeRegistry;
    private static Dictionary<Type, IUserDataDescriptor> s_TypeRegistryHistory;
    private static InteropAccessMode s_DefaultAccessMode;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void RegisterAssembly(Assembly asm = null, bool includeExtensionTypes = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool IsTypeRegistered(Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void UnregisterType(Type t) => throw null;

    internal static InteropAccessMode DefaultAccessMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static IUserDataDescriptor RegisterProxyType_Impl(
      IProxyFactory proxyFactory,
      InteropAccessMode accessMode,
      string friendlyName)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static IUserDataDescriptor RegisterType_Impl(
      Type type,
      InteropAccessMode accessMode,
      string friendlyName,
      IUserDataDescriptor descriptor)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IUserDataDescriptor PerformRegistration(
      Type type,
      IUserDataDescriptor newDescriptor,
      IUserDataDescriptor oldDescriptor)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static InteropAccessMode ResolveDefaultAccessModeForType(
      InteropAccessMode accessMode,
      Type type)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static IUserDataDescriptor GetDescriptorForType(Type type, bool searchInterfaces) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool FrameworkIsAssignableFrom(Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsTypeBlacklisted(Type t) => throw null;

    public static IEnumerable<KeyValuePair<Type, IUserDataDescriptor>> RegisteredTypes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static IEnumerable<KeyValuePair<Type, IUserDataDescriptor>> RegisteredTypesHistory
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    internal static IRegistrationPolicy RegistrationPolicy
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static TypeDescriptorRegistry() => throw null;
  }
}
