// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.VesselDefinitionConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (AssemblyDefinition), "Vessel", new string[] {"VesselDefinition", "KSP.Sim.Definitions.VesselDefinition"})]
  public class VesselDefinitionConverter : 
    IStructConverter<AssemblyDefinition>,
    IValueConverter<AssemblyDefinition>,
    IValueConverter<AssemblyDefinition?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<AssemblyDefinition> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselDefinitionConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    AssemblyDefinition IValueConverter<AssemblyDefinition>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(AssemblyDefinition? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssemblyDefinition? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(AssemblyDefinition clrValue, Script script) => throw null;
  }
}
