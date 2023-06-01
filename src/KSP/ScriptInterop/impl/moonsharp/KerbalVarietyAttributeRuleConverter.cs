// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.KerbalVarietyAttributeRuleConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Modding.Variety;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (KerbalVarietyAttributeRule), "KerbalVarietyAttributeRule", new string[] {"KSP.Contexts.Kerbal.KerbalVarietyAttributeRule"})]
  public class KerbalVarietyAttributeRuleConverter : 
    IStructConverter<KerbalVarietyAttributeRule>,
    IValueConverter<KerbalVarietyAttributeRule>,
    IValueConverter<KerbalVarietyAttributeRule?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<KerbalVarietyAttributeRule> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalVarietyAttributeRuleConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    KerbalVarietyAttributeRule IValueConverter<KerbalVarietyAttributeRule>.ToValue(
      DynValue scriptValue)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(KerbalVarietyAttributeRule? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalVarietyAttributeRule? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(KerbalVarietyAttributeRule clrValue, Script script) => throw null;
  }
}
