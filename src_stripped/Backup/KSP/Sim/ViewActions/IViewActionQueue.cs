// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ViewActions.IViewActionQueue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;

namespace KSP.Sim.ViewActions
{
  public interface IViewActionQueue
  {
    void SubmitViewAction(IViewAction action);

    void SubmitViewActions(IEnumerable<IViewAction> actions);

    void FlushViewActionQueue(IModelViewMap modelViewMap);

    void ClearViewActionQueue();
  }
}
