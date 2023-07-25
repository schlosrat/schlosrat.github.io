// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.Vector3dConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (Vector3d), "Vec3d", new string[] {"Vector3d"})]
  public class Vector3dConverter : 
    IStructConverter<Vector3d>,
    IValueConverter<Vector3d>,
    IValueConverter<Vector3d?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<Vector3d> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3dConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    Vector3d IValueConverter<Vector3d>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(Vector3d? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(Vector3d clrValue, Script script) => throw null;
  }
}
