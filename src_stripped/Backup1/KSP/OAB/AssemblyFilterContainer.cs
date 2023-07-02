// Decompiled with JetBrains decompiler
// Type: KSP.OAB.AssemblyFilterContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace KSP.OAB
{
  public class AssemblyFilterContainer : 
    MonoBehaviour,
    IPointerEnterHandler,
    IEventSystemHandler,
    IPointerExitHandler,
    IPointerDownHandler,
    IPointerUpHandler
  {
    public AssemblyPartFilterType filterType;
    public int filterSubtype;
    public TextMeshProUGUI text;
    public Image[] imagesToTint;
    public TextMeshProUGUI[] textToTint;
    public int maxWidthChars;
    [HideInInspector]
    public string Family;
    [SerializeField]
    private GameObject header;
    [SerializeField]
    private Image headerBGImage;
    [SerializeField]
    private Image headerIconExpanded;
    [SerializeField]
    private Image headerIconCollapsed;
    [SerializeField]
    private GameObject buttonsContainer;
    [SerializeField]
    [Space]
    private Color backgroundActiveColor;
    private Color foregroundActiveColor;
    private Color backgroundNormalColor;
    private Color foregroundNormalColor;
    protected bool isLit;
    protected bool isDown;
    protected bool isCollapsed;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFilterColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFilterHighlightColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFullName(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetExpanded(bool expanded) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFilter(AssemblyPartFilterType filterToUse, int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowHeader(bool show) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerEnter(PointerEventData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerExit(PointerEventData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetHeaderLit(bool lit = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerDown(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerUp(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddButton(GameObject btn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObject GetButton(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowButtons(bool show = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetButtonCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DeactivateFilterButtons() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssemblyFilterContainer() => throw null;
  }
}
