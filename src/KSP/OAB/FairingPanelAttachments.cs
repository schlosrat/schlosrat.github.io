// Decompiled with JetBrains decompiler
// Type: KSP.OAB.FairingPanelAttachments
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  [Serializable]
  public class FairingPanelAttachments
  {
    public List<IGGuid> AttachedPartIds;
    public int panelIndex;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FairingPanelAttachments() => throw null;
  }
}
