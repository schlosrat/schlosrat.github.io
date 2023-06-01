// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.QuaternionConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (Quaternion), "Quat3", new string[] {"Quaternion", "Quaternion3", "UnityEngine.Quaternion"})]
  public class QuaternionConverter : 
    IStructConverter<Quaternion>,
    IValueConverter<Quaternion>,
    IValueConverter<Quaternion?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<Quaternion> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuaternionConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    Quaternion IValueConverter<Quaternion>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(Quaternion? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Quaternion? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(Quaternion clrValue, Script script) => throw null;
  }
}
