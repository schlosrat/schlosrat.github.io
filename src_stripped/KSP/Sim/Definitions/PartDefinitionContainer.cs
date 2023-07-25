// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.PartDefinitionContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.State;
using System;

namespace KSP.Sim.Definitions
{
  [Serializable]
  public struct PartDefinitionContainer
  {
    public string partGuid;
    public string partName;
    public PartDefinition partDefinition;
    [Obsolete("partState should be refactored out of PartDefinitionContainer.  I think the attachment state should be renamed attachment definition and stored here tho.")]
    public PartState? partState;
  }
}
