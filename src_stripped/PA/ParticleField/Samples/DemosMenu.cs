// Decompiled with JetBrains decompiler
// Type: PA.ParticleField.Samples.DemosMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace PA.ParticleField.Samples
{
  public class DemosMenu : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
  {
    public string[] names;
    public Text headerButton;
    public Color openColor;
    public Color closedColor;
    public GameObject dropDown;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Show(bool arg = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IPointerClickHandler.OnPointerClick(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DemosMenu() => throw null;
  }
}
