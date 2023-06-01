// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.ResolutionConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (Resolution), "Resolution", new string[] {"UnityEngine.Resolution)"})]
  public class ResolutionConverter : 
    IStructConverter<Resolution>,
    IValueConverter<Resolution>,
    IValueConverter<Resolution?>
  {
    private TypeInterop typeInterop;
    private Resolution defaults;
    private MoonSharpBinding.Struct<Resolution> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResolutionConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    Resolution IValueConverter<Resolution>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Resolution? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(Resolution? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(Resolution clrValue, Script script) => throw null;
  }
}
