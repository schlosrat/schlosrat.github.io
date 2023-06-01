// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ProceduralPartDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
