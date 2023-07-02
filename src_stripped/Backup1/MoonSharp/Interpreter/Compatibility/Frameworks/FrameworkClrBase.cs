// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Compatibility.Frameworks.FrameworkClrBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Compatibility.Frameworks
{
  internal abstract class FrameworkClrBase : FrameworkReflectionBase
  {
    private BindingFlags BINDINGFLAGS_MEMBER;
    private BindingFlags BINDINGFLAGS_INNERCLASS;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Type GetTypeInfoFromType(Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override MethodInfo GetAddMethod(EventInfo ei) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override ConstructorInfo[] GetConstructors(Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override EventInfo[] GetEvents(Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override FieldInfo[] GetFields(Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Type[] GetGenericArguments(Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override MethodInfo GetGetMethod(PropertyInfo pi) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Type[] GetInterfaces(Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override MethodInfo GetMethod(Type type, string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override MethodInfo[] GetMethods(Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Type[] GetNestedTypes(Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override PropertyInfo[] GetProperties(Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override PropertyInfo GetProperty(Type type, string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override MethodInfo GetRemoveMethod(EventInfo ei) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override MethodInfo GetSetMethod(PropertyInfo pi) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool IsAssignableFrom(Type current, Type toCompare) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool IsInstanceOfType(Type t, object o) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override MethodInfo GetMethod(Type resourcesType, string name, Type[] types) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Type[] GetAssemblyTypes(Assembly asm) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected FrameworkClrBase() => throw null;
  }
}
