// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyTool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public abstract class ObjectAssemblyTool : IObjectAssemblyTool, IDisposable
  {
    protected ObjectAssemblyBuilderEvents events;
    protected ObjectAssemblyUIEvents uiEvents;
    protected OABOutlineType outlineType;
    protected bool initialized;
    protected ObjectAssemblyBuilderHUD _OAB_HUD;

    public ObjectAssemblyBuilderHUD OAB_HUD
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyTool(
      ObjectAssemblyBuilderEvents eventSystemToUse,
      ObjectAssemblyUIEvents uiEventsToUse)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Terminate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void PrimaryActionClick() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void PrimaryActionDoubleClick() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SecondaryActionClick() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SecondaryActionUp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SectiondaryActionDown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void GamepadRightStickPerformed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void TertiaryActionDown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void TertiaryActionUp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void TertiaryActionClick() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnCameraRotate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnCameraRotateReleased() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnUserCreatedPart(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetupCursorForTool() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetOutlinedPart(IObjectAssemblyPart part, bool includeChildren) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetOutlineType(OABOutlineType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void AddOutlinedPartToList(
      IObjectAssemblyPart part,
      bool includeChildParts,
      int outlineType = 1)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ClearPartOutlines() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void AddOutlineToObject(
      GameObject objectToOutline,
      int colorIndex = 0,
      bool filterObjectsByName = true)
    {
      throw null;
    }
  }
}
