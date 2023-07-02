// Decompiled with JetBrains decompiler
// Type: KSP.VFX.FXParachuteDeployContextualEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.VFX
{
  public class FXParachuteDeployContextualEvent : FXContextualEvent
  {
    private const string _vacuumParachuteDeployPrefabName = "fx_parachutedeploy_vacuum";
    private const string _atmParachuteDeployPrefabName = "fx_parachutedeploy_atm";

    public override string DefaultVFXAssetName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public override VFXEventType EventType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FXParachuteDeployContextualEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FXParachuteDeployContextualEvent(
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
