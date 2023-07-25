// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.VesselStateConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
