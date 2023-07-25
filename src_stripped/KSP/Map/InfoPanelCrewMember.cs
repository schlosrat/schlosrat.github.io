// Decompiled with JetBrains decompiler
// Type: KSP.Map.InfoPanelCrewMember
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
