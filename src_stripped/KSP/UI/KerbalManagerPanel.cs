// Decompiled with JetBrains decompiler
// Type: KSP.UI.KerbalManagerPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class KerbalManagerPanel
  {
    public RectTransform RectTransform;
    public KerbalManagerLocationInfo KerbalManagerLocationInfo;
    public List<KerbalInfo> Kerbals;
    public int KerbalCapacity;

    public bool HasRoom
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalManagerPanel(
      RectTransform rectTransform,
      KerbalManagerLocationInfo KerbalLocationInfo,
      List<KerbalInfo> kerbals = null,
      int kerbalCapacity = -1)
    {
      throw null;
    }
  }
}
