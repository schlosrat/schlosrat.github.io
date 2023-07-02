// Decompiled with JetBrains decompiler
// Type: KSP.Api.CoreTypes.IKspEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
