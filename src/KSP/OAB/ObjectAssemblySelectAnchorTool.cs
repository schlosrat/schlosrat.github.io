// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblySelectAnchorTool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  public class ObjectAssemblySelectAnchorTool : ObjectAssemblyPlacementTool
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblySelectAnchorTool(
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

    protected override bool CanOutlineDisabledRenderers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    protected override bool DoOutlinesFilterNames
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
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
    public override void SetOutlinedPart(IObjectAssemblyPart part, bool includeChildren) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsNewAnchorPartValidRecursive(IObjectAssemblyPart part) => throw null;
  }
}
