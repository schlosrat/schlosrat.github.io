// Decompiled with JetBrains decompiler
// Type: KSP.Api.CoreTypes.IKspEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
