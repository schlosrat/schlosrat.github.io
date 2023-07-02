// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyColorTool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  public class ObjectAssemblyColorTool : ObjectAssemblyPlacementTool
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyColorTool(
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

    protected override bool CanOutlineDisabledRenderers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetupCursorForTool() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnGrabbingPart(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void PrimaryActionClick() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetOutlinedPart(IObjectAssemblyPart part, bool includeChildren) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartCreated(IObjectAssemblyAvailablePart part) => throw null;
  }
}
