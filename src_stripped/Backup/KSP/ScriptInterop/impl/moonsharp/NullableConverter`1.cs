// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.NullableConverter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  public class NullableConverter<T> : IStructConverter<T>, IValueConverter<T>, IValueConverter<T?> where T : struct
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<T> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NullableConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T ToValue(DynValue from) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    T? IValueConverter<T?>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(T? definition, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(T clrValue, Script script) => throw null;
  }
}
