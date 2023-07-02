// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.UserData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Interop;
using MoonSharp.Interpreter.Interop.BasicDescriptors;
using MoonSharp.Interpreter.Interop.RegistrationPolicies;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter
{
  public class UserData : RefIdObject
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    private UserData() => throw null;

    public DynValue UserValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public object Object
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IUserDataDescriptor Descriptor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static UserData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IUserDataDescriptor RegisterType<T>(
      InteropAccessMode accessMode = InteropAccessMode.Default,
      string friendlyName = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IUserDataDescriptor RegisterType(
      Type type,
      InteropAccessMode accessMode = InteropAccessMode.Default,
      string friendlyName = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IUserDataDescriptor RegisterProxyType(
      IProxyFactory proxyFactory,
      InteropAccessMode accessMode = InteropAccessMode.Default,
      string friendlyName = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IUserDataDescriptor RegisterProxyType<TProxy, TTarget>(
      Func<TTarget, TProxy> wrapDelegate,
      InteropAccessMode accessMode = InteropAccessMode.Default,
      string friendlyName = null)
      where TProxy : class
      where TTarget : class
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IUserDataDescriptor RegisterType<T>(IUserDataDescriptor customDescriptor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IUserDataDescriptor RegisterType(Type type, IUserDataDescriptor customDescriptor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IUserDataDescriptor RegisterType(IUserDataDescriptor customDescriptor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RegisterAssembly(Assembly asm = null, bool includeExtensionTypes = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsTypeRegistered(Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsTypeRegistered<T>() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UnregisterType<T>() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UnregisterType(Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue Create(object o, IUserDataDescriptor descr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue Create(object o) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue CreateStatic(IUserDataDescriptor descr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue CreateStatic(Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue CreateStatic<T>() => throw null;

    public static IRegistrationPolicy RegistrationPolicy
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public static InteropAccessMode DefaultAccessMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RegisterExtensionType(Type type, InteropAccessMode mode = InteropAccessMode.Default) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<IOverloadableMemberDescriptor> GetExtensionMethodsByNameAndType(
      string name,
      Type extendedType)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetExtensionMethodsChangeVersion() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IUserDataDescriptor GetDescriptorForType<T>(bool searchInterfaces) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IUserDataDescriptor GetDescriptorForType(Type type, bool searchInterfaces) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IUserDataDescriptor GetDescriptorForObject(object o) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Table GetDescriptionOfRegisteredTypes(bool useHistoricalData = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<Type> GetRegisteredTypes(bool useHistoricalData = false) => throw null;
  }
}
