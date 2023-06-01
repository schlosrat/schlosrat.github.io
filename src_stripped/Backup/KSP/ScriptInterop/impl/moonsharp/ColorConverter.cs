// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.ColorConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (Color), "Color", new string[] {"UnityEngine.Color"})]
  public class ColorConverter : 
    IStructConverter<Color>,
    IValueConverter<Color>,
    IValueConverter<Color?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<Color> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColorConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    Color IValueConverter<Color>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(Color? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Color? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(Color clrValue, Script script) => throw null;
  }
}
