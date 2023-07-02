// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.SerializedSituationConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
