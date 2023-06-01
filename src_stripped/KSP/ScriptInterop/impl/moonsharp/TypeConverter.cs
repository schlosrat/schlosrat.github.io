// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.TypeConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (Type), "Type", new string[] {"System.Type"})]
  public class TypeConverter : IValueConverter<Type>
  {
    private TypeInterop typeInterop;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TypeConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Type ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(Type value, Script script) => throw null;
  }
}
