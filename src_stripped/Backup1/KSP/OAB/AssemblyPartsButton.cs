// Decompiled with JetBrains decompiler
// Type: KSP.OAB.AssemblyPartsButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace KSP.OAB
{
  public class AssemblyPartsButton : 
    KerbalMonoBehaviour,
    IPointerEnterHandler,
    IEventSystemHandler,
    IPointerExitHandler,
    ISelectHandler,
    IDeselectHandler
  {
    private ObjectAssemblyUIEvents events;
    public IObjectAssemblyAvailablePart part;
    public PartCategories category;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI tagsText;
    public Image icon;
    public Image iconBorder;
    public Image hoverBG;
    public Image iconOutline;
    public Image sizeTagBG;
    public Image favoriteTagBG;
    private bool iconSet;
    private IDisposable subscribeHandle;
    private SubscriptionHandle _favoriteRemovedHandle;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(
      ObjectAssemblyUIEvents eventsToUse,
      IObjectAssemblyAvailablePart partToUse)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowSizeTag(bool show, string text = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowFavoritesTag(bool show) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFilterColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSizeTagColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerEnter(PointerEventData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerExit(PointerEventData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFavoriteRemoved(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnSelect(BaseEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDeselect(BaseEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetIcon(Sprite sprite) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreatePart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator UnlockUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssemblyPartsButton() => throw null;
  }
}
