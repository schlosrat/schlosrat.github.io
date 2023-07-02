// Decompiled with JetBrains decompiler
// Type: KSP.VFX.FXDockingContextualEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
