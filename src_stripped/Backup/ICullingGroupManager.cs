// Decompiled with JetBrains decompiler
// Type: ICullingGroupManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using UnityEngine;

public interface ICullingGroupManager
{
  int ReserveSphere(Action<CullingGroup, CullingGroupEvent> callback);

  void ReleaseSphere(int index);

  void SetSphere(int idex, Vector3 center, float radius);
}
