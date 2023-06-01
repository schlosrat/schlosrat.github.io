// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.VesselStateConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.State;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (VesselState), "VesselState", new string[] {"KSP.Sim.State.VesselState"})]
  public class VesselStateConverter : 
    IStructConverter<VesselState>,
    IValueConverter<VesselState>,
    IValueConverter<VesselState?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<VesselState> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselStateConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    VesselState IValueConverter<VesselState>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(VesselState? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselState? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(VesselState clrValue, Script script) => throw null;
  }
}
