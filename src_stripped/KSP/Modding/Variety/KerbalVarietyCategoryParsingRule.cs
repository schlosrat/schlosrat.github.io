// Decompiled with JetBrains decompiler
// Type: KSP.Modding.Variety.KerbalVarietyCategoryParsingRule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Modding.Variety
{
  public struct KerbalVarietyCategoryParsingRule
  {
    public string CategoryName;
    public List<string> StartsWithKeys;
    public List<string> ContainsKeys;
    public List<string> EndsWithKeys;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static KerbalVarietyCategoryParsingRule Defaults() => throw null;
  }
}
