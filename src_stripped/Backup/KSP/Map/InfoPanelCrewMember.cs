// Decompiled with JetBrains decompiler
// Type: KSP.Map.InfoPanelCrewMember
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Map
{
  public class InfoPanelCrewMember : KerbalMonoBehaviour
  {
    [SerializeField]
    private TextMeshProUGUI _crewMemberName;
    [SerializeField]
    private Image _crewMemberIcon;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(string crewMemberName, Sprite crewMemberIcon) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InfoPanelCrewMember() => throw null;
  }
}
