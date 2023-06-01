// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.WorkspaceSelectionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Game.Missions
{
  [Serializable]
  public class WorkspaceSelectionData
  {
    public string WorkspaceAddressableKey;
    public string ThumbnailKey;
    [NonSerialized]
    public bool WorkspaceBtnIsSelected;
    [NonSerialized]
    public bool ThumbnailBtnIsSelected;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WorkspaceSelectionData() => throw null;
  }
}
