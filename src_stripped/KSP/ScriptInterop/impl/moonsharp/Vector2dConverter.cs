// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.Vector2dConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (Vector2d), "Vec2d", new string[] {"Vector2d", "UnityEngine.Vector2d"})]
  public class Vector2dConverter : 
    IStructConverter<Vector2d>,
    IValueConverter<Vector2d>,
    IValueConverter<Vector2d?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<Vector2d> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2dConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    Vector2d IValueConverter<Vector2d>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(Vector2d? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2d? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(Vector2d clrValue, Script script) => throw null;
  }
}
