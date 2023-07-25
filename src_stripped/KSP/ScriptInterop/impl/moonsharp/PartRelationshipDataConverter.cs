// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.PartRelationshipDataConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (PartRelationshipData), "PartRelationship", new string[] {"KSP.Sim.PartRelationshipData"})]
  public class PartRelationshipDataConverter : 
    IStructConverter<PartRelationshipData>,
    IValueConverter<PartRelationshipData>,
    IValueConverter<PartRelationshipData?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<PartRelationshipData> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartRelationshipDataConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartRelationshipData ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(PartRelationshipData? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    PartRelationshipData? IValueConverter<PartRelationshipData?>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(PartRelationshipData clrValue, Script script) => throw null;
  }
}
