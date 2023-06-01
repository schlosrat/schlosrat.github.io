// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyRotationTool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  public class ObjectAssemblyRotationTool : ObjectAssemblyPlacementTool
  {
    private ManipulationWidget widget;
    private ManipulationWidget widgetPrefab;
    private ObjectAssemblyInputHandler input;
    private IObjectAssemblyPart curPart;
    private const string manipulationWidgetTagName = "UI_VAB_MANIPULATIONTOOL";

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyRotationTool(
      ObjectAssemblyBuilderEvents eventSystemToUse,
      ObjectAssemblyUIEvents uiEventsToUse,
      ObjectAssemblyInputHandler inputToUse,
      ObjectAssemblyPartTracker partTrackerToUse,
      OABSessionInformation stats,
      ObjectAssemblyCameraManager cameraManagerToUse,
      ObjectAssemblyAssets oabAssets)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Terminate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetupCursorForTool() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void PrimaryActionClick() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetPartToManaipulate(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnResetRotation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsWidgetUnderCursor() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartCreated(IObjectAssemblyAvailablePart part) => throw null;
  }
}
