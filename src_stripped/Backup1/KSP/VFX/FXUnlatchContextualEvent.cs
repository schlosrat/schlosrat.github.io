// Decompiled with JetBrains decompiler
// Type: KSP.VFX.FXUnlatchContextualEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.VFX
{
  public class FXUnlatchContextualEvent : FXContextualEvent
  {
    private const string _vacuumClampPrefabName = "fx_launchclamp_vacuum";
    private const string _atmClampPrefabName = "fx_launchclamp_atm";

    public override string DefaultVFXAssetName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public override VFXEventType EventType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FXUnlatchContextualEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FXUnlatchContextualEvent(
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
      FXPartContextData partData)
    {
      throw null;
    }
  }
}
