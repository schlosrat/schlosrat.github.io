// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.Vector2Converter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (Vector2), "Vec2", new string[] {"Vector2", "UnityEngine.Vector2"})]
  public class Vector2Converter : 
    IStructConverter<Vector2>,
    IValueConverter<Vector2>,
    IValueConverter<Vector2?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<Vector2> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2Converter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    Vector2 IValueConverter<Vector2>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(Vector2? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(Vector2 clrValue, Script script) => throw null;
  }
}
