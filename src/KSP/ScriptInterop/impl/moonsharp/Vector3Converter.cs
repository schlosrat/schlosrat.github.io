// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.Vector3Converter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (Vector3), "Vec3", new string[] {"Vector3", "UnityEngine.Vector3"})]
  public class Vector3Converter : 
    IStructConverter<Vector3>,
    IValueConverter<Vector3>,
    IValueConverter<Vector3?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<Vector3> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3Converter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    Vector3 IValueConverter<Vector3>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(Vector3? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(Vector3 clrValue, Script script) => throw null;
  }
}
