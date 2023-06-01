// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.Vector4Converter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (Vector4), "Vec4", new string[] {"Vector4", "UnityEngine.Vector4"})]
  public class Vector4Converter : 
    IStructConverter<Vector4>,
    IValueConverter<Vector4>,
    IValueConverter<Vector4?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<Vector4> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector4Converter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    Vector4 IValueConverter<Vector4>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(Vector4? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector4? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(Vector4 clrValue, Script script) => throw null;
  }
}
