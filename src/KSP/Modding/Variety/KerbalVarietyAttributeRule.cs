// Decompiled with JetBrains decompiler
// Type: KSP.Modding.Variety.KerbalVarietyAttributeRule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Modding.Variety
{
  public struct KerbalVarietyAttributeRule
  {
    public string attributeName;
    public List<string> dependsOn;
    public string attributeRangeRuleKey;
    public string preGenerationFunction;
    public string applyFunction;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static KerbalVarietyAttributeRule Defaults() => throw null;
  }
}
