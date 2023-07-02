// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ProceduralPartDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
