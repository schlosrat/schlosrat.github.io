// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.SerializedSituationConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (SerializedSituation), "Situation", new string[] {"KSP.Sim.SerializedSituation"})]
  public class SerializedSituationConverter : 
    IStructConverter<SerializedSituation>,
    IValueConverter<SerializedSituation>,
    IValueConverter<SerializedSituation?>
  {
    private TypeInterop typeInterop;
    private SerializedSituation defaults;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedSituationConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    SerializedSituation IValueConverter<SerializedSituation>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedSituation? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(SerializedSituation? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(SerializedSituation clrValue, Script script) => throw null;
  }
}
