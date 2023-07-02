// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.KerbalVarietyRangeRuleConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Modding.Variety;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (VarietyRangeRule), "VarietyRangeRule", new string[] {"KSP.Contexts.Kerbal.VarietyRangeRule"})]
  public class KerbalVarietyRangeRuleConverter : 
    IStructConverter<VarietyRangeRule>,
    IValueConverter<VarietyRangeRule>,
    IValueConverter<VarietyRangeRule?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<VarietyRangeRule> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalVarietyRangeRuleConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    VarietyRangeRule IValueConverter<VarietyRangeRule>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(VarietyRangeRule? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VarietyRangeRule? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(VarietyRangeRule clrValue, Script script) => throw null;
  }
}
