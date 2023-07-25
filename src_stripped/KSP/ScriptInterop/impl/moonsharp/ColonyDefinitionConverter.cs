// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.ColonyDefinitionConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (ColonyDefinition), "Colony", new string[] {"ColonyDefinition", "KSP.Sim.Definitions.ColonyDefinition"})]
  public class ColonyDefinitionConverter : 
    IStructConverter<ColonyDefinition>,
    IValueConverter<ColonyDefinition>,
    IValueConverter<ColonyDefinition?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<ColonyDefinition> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColonyDefinitionConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ColonyDefinition IValueConverter<ColonyDefinition>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(ColonyDefinition? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColonyDefinition? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(ColonyDefinition clrValue, Script script) => throw null;
  }
}
