// Decompiled with JetBrains decompiler
// Type: KSP.Api.CoreTypes.IKspEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;

namespace KSP.Api.CoreTypes
{
  public interface IKspEvent
  {
    string Name { get; }

    event Action<KspEventData> OnEvent;

    void FireEvent(KspEventData data);
  }
}
