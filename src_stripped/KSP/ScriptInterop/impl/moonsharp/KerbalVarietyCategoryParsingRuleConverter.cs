// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.KerbalVarietyCategoryParsingRuleConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Modding.Variety;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (KerbalVarietyCategoryParsingRule), "KerbalVarietyCategoryParsingRule", new string[] {"KSP.Contexts.Kerbal.KerbalVarietyCategoryParsingRule"})]
  public class KerbalVarietyCategoryParsingRuleConverter : 
    IStructConverter<KerbalVarietyCategoryParsingRule>,
    IValueConverter<KerbalVarietyCategoryParsingRule>,
    IValueConverter<KerbalVarietyCategoryParsingRule?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<KerbalVarietyCategoryParsingRule> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalVarietyCategoryParsingRuleConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    KerbalVarietyCategoryParsingRule IValueConverter<KerbalVarietyCategoryParsingRule>.ToValue(
      DynValue scriptValue)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(KerbalVarietyCategoryParsingRule? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalVarietyCategoryParsingRule? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(KerbalVarietyCategoryParsingRule clrValue, Script script) => throw null;
  }
}
