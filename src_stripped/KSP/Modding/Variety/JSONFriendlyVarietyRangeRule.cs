// Decompiled with JetBrains decompiler
// Type: KSP.Modding.Variety.JSONFriendlyVarietyRangeRule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Modding.Variety
{
  public struct JSONFriendlyVarietyRangeRule
  {
    public string name;
    public string valueType;
    public VarietyRangeType varietyRangeType;
    public float probabilityOfEmpty;
    public object min;
    public object max;
    public object overrideValue;
    public List<object> specificOptions;
    public string subcategoryKey;
    public string attachToName;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static VarietyRangeRule ConvertJSONToVarietyRangeRule(
      JSONFriendlyVarietyRangeRule jsonMiddleData)
    {
      throw null;
    }
  }
}
