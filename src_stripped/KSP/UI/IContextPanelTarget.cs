// Decompiled with JetBrains decompiler
// Type: KSP.UI.IContextPanelTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using UnityEngine;

namespace KSP.UI
{
  public interface IContextPanelTarget
  {
    ContextPanelDataContext TargetData { get; }

    GameObject ParentObject { get; }

    bool IsValidTarget { get; }

    bool IgnoreTarget { get; }

    void UpdateTargetData();
  }
}
