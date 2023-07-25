// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyUIEngineeringReportFlawItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.UI.Binding;
using KSP.Utilities;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.OAB
{
  public class ObjectAssemblyUIEngineeringReportFlawItem : 
    KerbalMonoBehaviour,
    IPointerEnterHandler,
    IEventSystemHandler,
    IPointerExitHandler
  {
    public ContextBindRoot ContextBindRoot;
    public ObjectOutlinesManager ObjectOutlineManager;
    public TextMeshProTextOverflowWrapper TitleTextHeightHandler;
    [Tooltip("The index is color index in Outline Effect component that is attached to a camera component.")]
    public int OutlineColorIndex;
    private IObjectAssemblyPart _flawedPart;
    private PartCategories _flawCategory;
    private AssemblyPartsPicker _assemblyPartsPicker;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(
      EngineeringReportFlawItem flawData,
      AssemblyPartsPicker assemblyPartsPicker)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerEnter(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerExit(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnClicked() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyUIEngineeringReportFlawItem() => throw null;
  }
}
