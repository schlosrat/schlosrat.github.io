// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.SerializedSurfaceLocationConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (SerializedSurfaceLocation), "SerializedSurfaceLocation", new string[] {"KSP.Sim.SerializedSurfaceLocation"})]
  public class SerializedSurfaceLocationConverter : 
    IStructConverter<SerializedSurfaceLocation>,
    IValueConverter<SerializedSurfaceLocation>,
    IValueConverter<SerializedSurfaceLocation?>
  {
    private TypeInterop typeInterop;
    private SerializedSurfaceLocation defaults;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedSurfaceLocationConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    SerializedSurfaceLocation IValueConverter<SerializedSurfaceLocation>.ToValue(
      DynValue scriptValue)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedSurfaceLocation? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(SerializedSurfaceLocation? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(SerializedSurfaceLocation clrValue, Script script) => throw null;
  }
}
