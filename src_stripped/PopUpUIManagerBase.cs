// Decompiled with JetBrains decompiler
// Type: PopUpUIManagerBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using KSP.Messages;
using System.Runtime.CompilerServices;

public class PopUpUIManagerBase : KerbalMonoBehaviour
{
  protected SubscriptionHandle _trainingCenterLoadHandle;
  protected SubscriptionHandle _gameStateChangedHandle;

  public virtual bool IsVisible
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected virtual bool GetVisibleStatus() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected virtual void SetVisibilityOfManager(bool visibility) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected virtual void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected virtual void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected virtual void OnTrainingCenterLoad(MessageCenterMessage msg) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected virtual void OnGameStateChanged(MessageCenterMessage msg) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PopUpUIManagerBase() => throw null;
}
