// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.Vector3Converter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
