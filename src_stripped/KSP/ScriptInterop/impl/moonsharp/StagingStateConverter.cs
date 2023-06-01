// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.StagingStateConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.State;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (StagingState), "StagingState", new string[] {"KSP.Sim.State.StagingState"})]
  public class StagingStateConverter : 
    IStructConverter<StagingState>,
    IValueConverter<StagingState>,
    IValueConverter<StagingState?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<StagingState> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagingStateConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    StagingState IValueConverter<StagingState>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(StagingState? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagingState? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(StagingState clrValue, Script script) => throw null;
  }
}
