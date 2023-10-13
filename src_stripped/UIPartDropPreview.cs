// Decompiled with JetBrains decompiler
// Type: UIPartDropPreview
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.OAB;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UIPartDropPreview : MonoBehaviour
{
  public Image partPreviewIcon;
  private ObjectAssemblyBuilderEvents buildEvents;
  private ObjectAssemblyUIEvents uiEvents;
  private IObjectAssemblyPart partGrabbed;
  private bool isCursorOverPartsPanel;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Initialize(
    ObjectAssemblyUIEvents eventsToUse,
    ObjectAssemblyBuilderEvents builderEvents,
    OABSessionInformation statsToUse)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdatePartPreviewVisibility() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdatePosition() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdatePartPreviewIcon() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnPartDrop(IObjectAssemblyPart part) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnPartGrab(IObjectAssemblyPart part) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnPartDelete(IObjectAssemblyPart part) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnPartStateChange() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public UIPartDropPreview() => throw null;
}
