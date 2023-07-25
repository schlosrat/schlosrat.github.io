// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ProceduralPartDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  [Serializable]
  public class ProceduralPartDefinition
  {
    public ProceduralPartDefinitionID ProceduralPartID;
    public string Name;
    public string DisplayNameKey;
    public string EditMenuHeaderKey;
    public List<ProceduralPartAttribute> Attributes;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProceduralPartDefinition(
      ProceduralPartDefinitionID proceduralPartID,
      string name,
      string displayNameKey,
      string editMenuHeaderKey,
      List<ProceduralPartAttribute> attributes)
    {
      throw null;
    }
  }
}
