// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.PartDefinitionContainerConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (PartDefinitionContainer), "partcontainer", new string[] {"PartDefinitionContainer", "KSP.Sim.Definitions.PartDefinitionContainer"})]
  public class PartDefinitionContainerConverter : 
    IStructConverter<PartDefinitionContainer>,
    IValueConverter<PartDefinitionContainer>,
    IValueConverter<PartDefinitionContainer?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<PartDefinitionContainer> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartDefinitionContainerConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    PartDefinitionContainer IValueConverter<PartDefinitionContainer>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(PartDefinitionContainer? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartDefinitionContainer? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(PartDefinitionContainer clrValue, Script script) => throw null;
  }
}
