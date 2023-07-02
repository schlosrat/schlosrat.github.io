// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.Vector4dConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (Vector4d), "Vec4d", new string[] {"Vector4d", "UnityEngine.Vector4d"})]
  public class Vector4dConverter : 
    IStructConverter<Vector4d>,
    IValueConverter<Vector4d>,
    IValueConverter<Vector4d?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<Vector4d> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector4dConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    Vector4d IValueConverter<Vector4d>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(Vector4d? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector4d? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(Vector4d clrValue, Script script) => throw null;
  }
}
