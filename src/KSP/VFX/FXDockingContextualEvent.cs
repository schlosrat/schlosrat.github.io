// Decompiled with JetBrains decompiler
// Type: KSP.VFX.FXDockingContextualEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.VFX
{
  public class FXDockingContextualEvent : FXContextualEvent
  {
    private const string _vacuumDecouplePrefabName = "fx_undock_vacuum";
    private const string _atmDecouplePrefabName = "fx_undock_atm";
    private bool _isUndock;

    public override string DefaultVFXAssetName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public override VFXEventType EventType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FXDockingContextualEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FXDockingContextualEvent(
      ContextualFxSystem system,
      FXContextualEventParams eventParams,
      FXPartContextData partData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string SelectPrefab(FXContextData context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetEventParameters(
      ContextualFxSystem system,
      FXContextualEventParams eventParams,
      FXPartContextData partData,
      bool isUndock)
    {
      throw null;
    }
  }
}
