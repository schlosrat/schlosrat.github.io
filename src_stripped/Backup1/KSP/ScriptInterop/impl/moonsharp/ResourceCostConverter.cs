// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.ResourceCostConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (PartResourceCostDefinition), "PartResourceCost", new string[] {"KSP.Sim.Definitions.PartResourceCostDefinition"})]
  public class ResourceCostConverter : 
    IStructConverter<PartResourceCostDefinition>,
    IValueConverter<PartResourceCostDefinition>,
    IValueConverter<PartResourceCostDefinition?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<PartResourceCostDefinition> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceCostConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    PartResourceCostDefinition IValueConverter<PartResourceCostDefinition>.ToValue(
      DynValue scriptValue)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(PartResourceCostDefinition? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartResourceCostDefinition? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(PartResourceCostDefinition clrValue, Script script) => throw null;
  }
}
