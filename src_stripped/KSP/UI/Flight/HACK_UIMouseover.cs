// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.HACK_UIMouseover
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.UI.Flight
{
  public class HACK_UIMouseover : 
    MonoBehaviour,
    IPointerEnterHandler,
    IEventSystemHandler,
    IPointerExitHandler
  {
    [TextArea]
    public string text;
    public HACK_UIMouseoverInfo infoPrefab;
    private HACK_UIMouseoverInfo infoSpawned;
    private RectTransform rootCanvas;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerEnter(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerExit(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CleanUpInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HACK_UIMouseover() => throw null;
  }
}
