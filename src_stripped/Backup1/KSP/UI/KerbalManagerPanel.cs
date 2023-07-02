// Decompiled with JetBrains decompiler
// Type: KSP.UI.KerbalManagerPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
