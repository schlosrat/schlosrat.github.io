// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.SerializedVesselSaveConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (SerializedVesselSave), "VesselSave", new string[] {"VehicleSave", "KSP.Sim.SerializedVesselSave"})]
  public class SerializedVesselSaveConverter : 
    IStructConverter<SerializedVesselSave>,
    IValueConverter<SerializedVesselSave>,
    IValueConverter<SerializedVesselSave?>
  {
    private TypeInterop typeInterop;
    private SerializedVesselSave defaults;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedVesselSaveConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    SerializedVesselSave IValueConverter<SerializedVesselSave>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedVesselSave? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(SerializedVesselSave? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(SerializedVesselSave clrValue, Script script) => throw null;
  }
}
