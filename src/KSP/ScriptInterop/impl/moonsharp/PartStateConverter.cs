// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.PartStateConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.State;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (PartState), "PartState", new string[] {"KSP.Sim.State.PartState"})]
  public class PartStateConverter : 
    IStructConverter<PartState>,
    IValueConverter<PartState>,
    IValueConverter<PartState?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<PartState> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartStateConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    PartState IValueConverter<PartState>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(PartState? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartState? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(PartState clrValue, Script script) => throw null;
  }
}
