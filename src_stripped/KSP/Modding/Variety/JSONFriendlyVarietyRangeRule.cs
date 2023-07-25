﻿// Decompiled with JetBrains decompiler
// Type: KSP.Modding.Variety.JSONFriendlyVarietyRangeRule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
