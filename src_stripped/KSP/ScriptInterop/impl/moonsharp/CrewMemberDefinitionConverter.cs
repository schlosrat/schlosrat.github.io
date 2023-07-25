// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.CrewMemberDefinitionConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (CrewMemberDefinition), "Crew", new string[] {"CrewMemberDefinition", "KSP.Sim.Definitions.CrewMemberDefinition"})]
  public class CrewMemberDefinitionConverter : 
    IStructConverter<CrewMemberDefinition>,
    IValueConverter<CrewMemberDefinition>,
    IValueConverter<CrewMemberDefinition?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<CrewMemberDefinition> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CrewMemberDefinitionConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    CrewMemberDefinition IValueConverter<CrewMemberDefinition>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(CrewMemberDefinition? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CrewMemberDefinition? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(CrewMemberDefinition clrValue, Script script) => throw null;
  }
}
