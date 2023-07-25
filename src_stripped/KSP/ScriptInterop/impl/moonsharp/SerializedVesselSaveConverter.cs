// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.SerializedVesselSaveConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
