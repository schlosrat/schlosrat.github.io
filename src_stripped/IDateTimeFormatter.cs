// Decompiled with JetBrains decompiler
// Type: IDateTimeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

public interface IDateTimeFormatter
{
  string PrintTimeLong(double time);

  string PrintTimeStamp(double time, bool days = false, bool years = false);

  string PrintTimeStampCompact(double time, bool days = false, bool years = false);

  string PrintTime(double time, int valuesOfInterest, bool explicitPositive);

  string PrintTimeCompact(double time, bool explicitPositive);

  string PrintDateDelta(double time, bool includeTime, bool includeSeconds, bool useAbs);

  string PrintDateDeltaCompact(double time, bool includeTime, bool includeSeconds, bool useAbs);

  string PrintDate(double time, bool includeTime, bool includeSeconds = false);

  string PrintDateNew(double time, bool includeTime);

  string PrintDateCompact(double time, bool includeTime, bool includeSeconds = false);

  int Minute { get; }

  int Hour { get; }

  int Day { get; }

  int Year { get; }
}
