// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.PartDefinitionConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (PartDefinition), "PartDefinition", new string[] {"KSP.Sim.Definitions.PartDefinition"})]
  public class PartDefinitionConverter : 
    IStructConverter<PartDefinition>,
    IValueConverter<PartDefinition>,
    IValueConverter<PartDefinition?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<PartDefinition> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartDefinitionConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    PartDefinition IValueConverter<PartDefinition>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(PartDefinition? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartDefinition? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(PartDefinition clrValue, Script script) => throw null;
  }
}
