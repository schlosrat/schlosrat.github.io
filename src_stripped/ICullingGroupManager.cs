// Decompiled with JetBrains decompiler
// Type: ICullingGroupManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using UnityEngine;

public interface ICullingGroupManager
{
  int ReserveSphere(Action<CullingGroup, CullingGroupEvent> callback);

  void ReleaseSphere(int index);

  void SetSphere(int idex, Vector3 center, float radius);
}
