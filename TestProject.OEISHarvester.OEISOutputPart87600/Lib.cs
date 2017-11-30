using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A107241
{
public static readonly long[] Value={ 1L,2L,3L,4L,20L,69L,238L,863L,3264L,12100L,44861L,166662L,619591L,2301800L,8551800L,31774561L,118060082L,438649107L,1629796276L,6055504952L,22499207241L,83595676570L,310599326171L,1154030334396L,4287794153932L,15931278338957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107241Inst : IEnumerable<long>
{
public static readonly long[] Value=A107241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107241.Bytes);
public long this[int i]=>Value[i];

public static A107241Inst Instance=new A107241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107242
{
public static readonly long[] Value={ 0L,0L,1L,5L,14L,50L,194L,723L,2659L,9884L,36780L,136636L,507517L,1885793L,7006962L,26034006L,96728470L,359395319L,1335332919L,4961420008L,18434129192L,68491926888L,254481427113L,945524491213L,3513091674982L,13052875206698L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107242Inst : IEnumerable<long>
{
public static readonly long[] Value=A107242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107242.Bytes);
public long this[int i]=>Value[i];

public static A107242Inst Instance=new A107242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107243
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,6L,22L,86L,342L,1303L,5024L,19424L,75120L,290416L,1122160L,4337009L,16762634L,64787534L,250400910L,967783566L,3740437902L,14456621263L,55874162432L,215950971648L,834640190272L,3225844698176L,12467736540480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107243Inst : IEnumerable<long>
{
public static readonly long[] Value=A107243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107243.Bytes);
public long this[int i]=>Value[i];

public static A107243Inst Instance=new A107243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107244
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,2L,6L,22L,86L,342L,1366L,5335L,20960L,82464L,324528L,1277104L,5025200L,19770800L,77789489L,306071370L,1204272270L,4738336974L,18643463374L,73354544590L,288620849614L,1135607911375L,4468164041216L,17580442344960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107244Inst : IEnumerable<long>
{
public static readonly long[] Value=A107244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107244.Bytes);
public long this[int i]=>Value[i];

public static A107244Inst Instance=new A107244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107245
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,2L,6L,22L,86L,342L,1366L,5462L,21591L,85600L,339616L,1347632L,5347632L,21219888L,84199984L,334092848L,1325649969L,5260075594L,20871578510L,82816815054L,328610657230L,1303901211854L,5173777051854L,20529140314318L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107245Inst : IEnumerable<long>
{
public static readonly long[] Value=A107245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107245.Bytes);
public long this[int i]=>Value[i];

public static A107245Inst Instance=new A107245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107246
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,2L,6L,22L,86L,342L,1366L,5462L,21846L,86871L,345952L,1378208L,5490992L,21877296L,87163696L,347276080L,1383600944L,5512434480L,21962292529L,87500852554L,348615720590L,1388934122190L,5533708922574L,22047074027470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107246Inst : IEnumerable<long>
{
public static readonly long[] Value=A107246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107246.Bytes);
public long this[int i]=>Value[i];

public static A107246Inst Instance=new A107246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107247
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,2L,6L,22L,86L,342L,1366L,5462L,21846L,87382L,348503L,1390944L,5552544L,22166320L,88491056L,353269040L,1410299184L,5630100784L,22476064048L,89727075632L,358201316657L,1429983219018L,5708667195022L,22789694921422L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107247Inst : IEnumerable<long>
{
public static readonly long[] Value=A107247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107247.Bytes);
public long this[int i]=>Value[i];

public static A107247Inst Instance=new A107247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107248
{
public static readonly long[] Value={ 1L,1L,1L,37L,37L,169L,169L,553L,553L,2461L,2461L,11857L,11857L,51409L,51409L,219733L,219733L,969721L,969721L,4285177L,4285177L,18755149L,18755149L,82122913L,82122913L,360600481L,360600481L,1582788997L,1582788997L,6941826889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107248Inst : IEnumerable<long>
{
public static readonly long[] Value=A107248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107248.Bytes);
public long this[int i]=>Value[i];

public static A107248Inst Instance=new A107248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107249
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,2L,2L,1L,1L,6L,3L,3L,2L,1L,1L,10L,6L,6L,3L,3L,1L,1L,20L,10L,10L,6L,4L,3L,1L,1L,35L,20L,20L,10L,10L,4L,4L,1L,1L,70L,35L,35L,20L,15L,10L,5L,4L,1L,1L,126L,70L,70L,35L,35L,15L,15L,5L,5L,1L,1L,252L,126L,126L,70L,56L,35L,21L,15L,6L,5L,1L,1L,462L,252L,252L,126L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107249Inst : IEnumerable<long>
{
public static readonly long[] Value=A107249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107249.Bytes);
public long this[int i]=>Value[i];

public static A107249Inst Instance=new A107249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107250
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,9L,16L,30L,54L,104L,191L,372L,692L,1357L,2550L,5021L,9508L,18773L,35766L,70755L,135461L,268365L,515849L,1023092L,1973159L,3916831L,7575470L,15048428L,29175431L,57990158L,112665488L,224048847L,436089113L,867581269L,1691392152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107250Inst : IEnumerable<long>
{
public static readonly long[] Value=A107250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107250.Bytes);
public long this[int i]=>Value[i];

public static A107250Inst Instance=new A107250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107251
{
public static readonly BigInteger[] Value={ 1L,1L,12L,7200L,508032000L,7742895390720000L,BigInteger.Parse("40797452088662556672000000"),BigInteger.Parse("108985983996792124183843071590400000000"),BigInteger.Parse("203800994173724454677862841368011757060096000000000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107251Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A107251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107251.Bytes);
public BigInteger this[int i]=>Value[i];

public static A107251Inst Instance=new A107251Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107252
{
public static readonly BigInteger[] Value={ 1L,1L,6L,1440L,36288000L,184354652160000L,BigInteger.Parse("309071606732292096000000"),BigInteger.Parse("254046582743105184577722777600000000"),BigInteger.Parse("142518177743863255019484504453155074867200000000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107252Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A107252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107252.Bytes);
public BigInteger this[int i]=>Value[i];

public static A107252Inst Instance=new A107252Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107253
{
public static readonly long[] Value={ 1L,1L,51L,211L,565L,1221L,2311L,3991L,6441L,9865L,14491L,20571L,28381L,38221L,50415L,65311L,83281L,104721L,130051L,159715L,194181L,233941L,279511L,331431L,390265L,456601L,531051L,614251L,706861L,809565L,923071L,1048111L,1185441L,1335841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107253Inst : IEnumerable<long>
{
public static readonly long[] Value=A107253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107253.Bytes);
public long this[int i]=>Value[i];

public static A107253Inst Instance=new A107253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107254
{
public static readonly BigInteger[] Value={ 1L,1L,12L,8640L,870912000L,22122558259200000L,BigInteger.Parse("222531556847250309120000000"),BigInteger.Parse("1280394777025250130271722799104000000000"),BigInteger.Parse("5746332926632566442385615219551212618645504000000000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107254Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A107254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107254.Bytes);
public BigInteger this[int i]=>Value[i];

public static A107254Inst Instance=new A107254Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107255
{
public static readonly long[] Value={ 1L,1L,181L,931L,3001L,7621L,16621L,32551L,58801L,99721L,160741L,248491L,370921L,537421L,758941L,1048111L,1419361L,1889041L,2475541L,3199411L,4083481L,5152981L,6435661L,7961911L,9764881L,11880601L,14348101L,17209531L,20510281L,24299101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107255Inst : IEnumerable<long>
{
public static readonly long[] Value=A107255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107255.Bytes);
public long this[int i]=>Value[i];

public static A107255Inst Instance=new A107255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107256
{
public static readonly long[] Value={ 1L,1L,603L,3907L,15373L,46341L,117271L,261703L,530937L,999433L,1770931L,2985291L,4826053L,7528717L,11389743L,16776271L,24136561L,34011153L,47044747L,63998803L,85764861L,113378581L,148034503L,191101527L,244139113L,308914201L,387418851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107256Inst : IEnumerable<long>
{
public static readonly long[] Value=A107256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107256.Bytes);
public long this[int i]=>Value[i];

public static A107256Inst Instance=new A107256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107257
{
public static readonly long[] Value={ 5L,7L,11L,11L,13L,17L,17L,19L,23L,23L,29L,29L,29L,31L,37L,37L,37L,41L,41L,43L,47L,47L,53L,53L,53L,59L,59L,59L,61L,67L,67L,67L,71L,71L,73L,79L,79L,79L,83L,83L,89L,89L,89L,101L,101L,101L,101L,101L,101L,103L,107L,107L,109L,113L,113L,131L,131L,131L,131L,131L,131L,131L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107257Inst : IEnumerable<long>
{
public static readonly long[] Value=A107257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107257.Bytes);
public long this[int i]=>Value[i];

public static A107257Inst Instance=new A107257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107258
{
public static readonly long[] Value={ 25L,32L,43L,51L,52L,54L,59L,64L,72L,73L,75L,77L,82L,84L,85L,88L,97L,98L,101L,102L,103L,109L,111L,114L,115L,116L,119L,124L,127L,129L,130L,131L,132L,135L,140L,142L,143L,148L,151L,152L,162L,163L,164L,168L,169L,177L,178L,181L,182L,183L,185L,186L,188L,196L,197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107258Inst : IEnumerable<long>
{
public static readonly long[] Value=A107258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107258.Bytes);
public long this[int i]=>Value[i];

public static A107258Inst Instance=new A107258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107259
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,2L,3L,1L,3L,2L,1L,3L,1L,2L,2L,2L,2L,1L,2L,1L,1L,2L,2L,3L,2L,0L,1L,1L,2L,2L,1L,2L,0L,1L,2L,1L,3L,2L,1L,1L,1L,2L,1L,0L,2L,1L,1L,1L,1L,3L,1L,0L,0L,1L,0L,3L,2L,2L,3L,0L,1L,1L,1L,1L,0L,1L,2L,1L,2L,1L,2L,1L,0L,0L,1L,0L,2L,0L,1L,3L,1L,1L,0L,2L,0L,0L,1L,1L,0L,2L,1L,3L,2L,1L,1L,1L,1L,0L,0L,3L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107259Inst : IEnumerable<long>
{
public static readonly long[] Value=A107259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107259.Bytes);
public long this[int i]=>Value[i];

public static A107259Inst Instance=new A107259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107260
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,2L,2L,2L,1L,3L,2L,2L,2L,3L,3L,1L,3L,2L,2L,2L,3L,3L,2L,3L,3L,3L,1L,4L,2L,2L,2L,3L,3L,2L,3L,3L,3L,2L,4L,3L,3L,3L,4L,4L,1L,4L,2L,2L,2L,3L,3L,2L,3L,3L,3L,2L,4L,3L,3L,3L,4L,4L,2L,4L,3L,3L,3L,4L,4L,3L,4L,4L,4L,1L,5L,2L,2L,2L,3L,3L,2L,3L,3L,3L,2L,4L,3L,3L,3L,4L,4L,2L,4L,3L,3L,3L,4L,4L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107260Inst : IEnumerable<long>
{
public static readonly long[] Value=A107260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107260.Bytes);
public long this[int i]=>Value[i];

public static A107260Inst Instance=new A107260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107261
{
public static readonly long[] Value={ 0L,0L,2L,0L,1L,1L,3L,2L,2L,1L,3L,3L,3L,3L,3L,6L,0L,6L,3L,3L,4L,3L,3L,10L,1L,0L,1L,10L,3L,5L,5L,5L,3L,12L,1L,3L,2L,3L,1L,14L,4L,7L,5L,7L,4L,14L,3L,4L,2L,2L,2L,4L,5L,15L,7L,7L,5L,7L,7L,15L,5L,7L,2L,7L,0L,8L,2L,7L,5L,15L,9L,7L,6L,7L,9L,15L,5L,9L,3L,11L,1L,3L,1L,11L,3L,9L,5L,18L,9L,9L,6L,9L,9L,18L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107261Inst : IEnumerable<long>
{
public static readonly long[] Value=A107261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107261.Bytes);
public long this[int i]=>Value[i];

public static A107261Inst Instance=new A107261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107262
{
public static readonly long[] Value={ 64L,256L,841L,1021L,533L,1027L,0L,1231L,3721L,1937L,8836L,2421L,9026L,9608L,0L,0L,20451L,22209L,22805L,0L,23723L,22509L,22505L,0L,24337L,24347L,24651L,24967L,25605L,25927L,26577L,27889L,32400L,32762L,27565L,0L,29585L,30629L,0L,0L,32409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107262Inst : IEnumerable<long>
{
public static readonly long[] Value=A107262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107262.Bytes);
public long this[int i]=>Value[i];

public static A107262Inst Instance=new A107262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107263
{
public static readonly long[] Value={ 20678L,95695L,120724L,133876L,1148205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107263Inst : IEnumerable<long>
{
public static readonly long[] Value=A107263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107263.Bytes);
public long this[int i]=>Value[i];

public static A107263Inst Instance=new A107263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107264
{
public static readonly long[] Value={ 1L,3L,12L,54L,261L,1323L,6939L,37341L,205011L,1143801L,6466230L,36960300L,213243435L,1240219269L,7263473148L,42799541886L,253556163243L,1509356586897L,9023497273548L,54154973176074L,326154592965879L,1970575690572297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107264Inst : IEnumerable<long>
{
public static readonly long[] Value=A107264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107264.Bytes);
public long this[int i]=>Value[i];

public static A107264Inst Instance=new A107264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107265
{
public static readonly long[] Value={ 1L,5L,30L,200L,1425L,10625L,81875L,646875L,5211875L,42659375L,353725000L,2965031250L,25083859375L,213894609375L,1836516718750L,15863968750000L,137767560546875L,1202116083984375L,10534061644531250L,92664360625000000L,817975366904296875L,7243402948779296875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107265Inst : IEnumerable<long>
{
public static readonly long[] Value=A107265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107265.Bytes);
public long this[int i]=>Value[i];

public static A107265Inst Instance=new A107265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107266
{
public static readonly BigInteger[] Value={ 1L,6L,42L,324L,2664L,22896L,203256L,1849392L,17156448L,161663040L,1543053888L,14887836288L,144963737856L,1422685140480L,14058304458624L,139754913276672L,1396721001457152L,14025182471414784L,141432971217841152L,1431708373864249344L,14543342842406252544UL,BigInteger.Parse("148198801896234491904") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107266Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A107266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107266.Bytes);
public BigInteger this[int i]=>Value[i];

public static A107266Inst Instance=new A107266Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107267
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,2L,2L,1L,0L,4L,6L,3L,1L,0L,9L,20L,12L,4L,1L,0L,21L,72L,54L,20L,5L,1L,0L,51L,272L,261L,112L,30L,6L,1L,0L,127L,1064L,1323L,672L,200L,42L,7L,1L,0L,323L,4272L,6939L,4224L,1425L,324L,56L,8L,1L,0L,835L,17504L,37341L,27456L,10625L,2664L,490L,72L,9L,1L,0L,2188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107267Inst : IEnumerable<long>
{
public static readonly long[] Value=A107267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107267.Bytes);
public long this[int i]=>Value[i];

public static A107267Inst Instance=new A107267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107268
{
public static readonly long[] Value={ 1L,1L,2L,5L,14L,46L,173L,733L,3436L,17572L,96997L,573268L,3604687L,23990345L,168254444L,1238889493L,9546211068L,76761000444L,642524333589L,5586361188966L,50351455288661L,469653513479395L,4526242614854118L,45005754238016688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107268Inst : IEnumerable<long>
{
public static readonly long[] Value=A107268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107268.Bytes);
public long this[int i]=>Value[i];

public static A107268Inst Instance=new A107268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107269
{
public static readonly long[] Value={ 1L,0L,1L,1L,3L,6L,16L,44L,136L,457L,1669L,6547L,27334L,120465L,557094L,2692528L,13564940L,71102869L,387132791L,2185813423L,12775466408L,77154694819L,480630407368L,3083443893896L,20344187534051L,137884769704754L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107269Inst : IEnumerable<long>
{
public static readonly long[] Value=A107269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107269.Bytes);
public long this[int i]=>Value[i];

public static A107269Inst Instance=new A107269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107270
{
public static readonly BigInteger[] Value={ 1L,1L,2L,8L,72L,1440L,55008L,3507840L,342679680L,48401625600L,9472057781760L,2484361405532160L,850218223244544000L,BigInteger.Parse("371335242657899520000"),BigInteger.Parse("203148791342840318976000"),BigInteger.Parse("137006974339300359770112000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107270Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A107270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107270.Bytes);
public BigInteger this[int i]=>Value[i];

public static A107270Inst Instance=new A107270Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107271
{
public static readonly long[] Value={ 1L,3L,2L,6L,6L,2L,14L,24L,12L,50L,66L,28L,144L,216L,100L,460L,648L,288L,1396L,2028L,920L,4344L,6216L,2792L,13352L,19248L,8688L,41288L,59304L,26704L,127296L,183168L,82576L,393040L,565056L,254592L,1212688L,1744176L,786080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107271Inst : IEnumerable<long>
{
public static readonly long[] Value=A107271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107271.Bytes);
public long this[int i]=>Value[i];

public static A107271Inst Instance=new A107271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107272
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,22L,23L,32L,33L,44L,55L,56L,65L,66L,77L,78L,87L,88L,99L,101L,111L,121L,131L,141L,151L,161L,171L,181L,191L,202L,203L,204L,205L,206L,207L,208L,209L,212L,213L,222L,223L,224L,225L,226L,227L,228L,229L,232L,233L,234L,235L,236L,237L,238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107272Inst : IEnumerable<long>
{
public static readonly long[] Value=A107272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107272.Bytes);
public long this[int i]=>Value[i];

public static A107272Inst Instance=new A107272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107273
{
public static readonly long[] Value={ 10011001L,10025001L,10052001L,10088001L,10100101L,10111101L,10125101L,10152101L,10188101L,10200501L,10211501L,10225501L,10252501L,10288501L,11011011L,11025011L,11052011L,11088011L,11100111L,11111111L,11125111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107273Inst : IEnumerable<long>
{
public static readonly long[] Value=A107273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107273.Bytes);
public long this[int i]=>Value[i];

public static A107273Inst Instance=new A107273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107274
{
public static readonly long[] Value={ 101101L,102501L,111111L,112511L,121151L,122551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107274Inst : IEnumerable<long>
{
public static readonly long[] Value=A107274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107274.Bytes);
public long this[int i]=>Value[i];

public static A107274Inst Instance=new A107274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107275
{
public static readonly long[] Value={ 10011001L,10100101L,10111101L,10200501L,10500201L,10511201L,10800801L,11011011L,11100111L,11111111L,11200511L,11500211L,11511211L,11800811L,15011021L,15100121L,15111121L,15200521L,15500221L,15511221L,15800821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107275Inst : IEnumerable<long>
{
public static readonly long[] Value=A107275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107275.Bytes);
public long this[int i]=>Value[i];

public static A107275Inst Instance=new A107275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107276
{
public static readonly long[] Value={ 101101L,111111L,121151L,151121L,181181L,201105L,211115L,221155L,251125L,281185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107276Inst : IEnumerable<long>
{
public static readonly long[] Value=A107276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107276.Bytes);
public long this[int i]=>Value[i];

public static A107276Inst Instance=new A107276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107277
{
public static readonly long[] Value={ 0L,1L,12L,20L,30L,31L,41L,42L,52L,53L,63L,64L,74L,75L,85L,86L,96L,97L,107L,122L,233L,300L,401L,422L,523L,560L,611L,712L,730L,804L,811L,912L,930L,3444L,4111L,5001L,5222L,6233L,6400L,7011L,7222L,8233L,8400L,9011L,9222L,23333L,30000L,40111L,42222L,52333L,56000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107277Inst : IEnumerable<long>
{
public static readonly long[] Value=A107277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107277.Bytes);
public long this[int i]=>Value[i];

public static A107277Inst Instance=new A107277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107278
{
public static readonly long[] Value={ 1L,4L,17L,60L,209L,685L,2204L,6913L,21387L,65241L,197104L,590284L,1755804L,5191723L,15276610L,44761350L,130682371L,380337474L,1103927291L,3196494453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107278Inst : IEnumerable<long>
{
public static readonly long[] Value=A107278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107278.Bytes);
public long this[int i]=>Value[i];

public static A107278Inst Instance=new A107278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107279
{
public static readonly long[] Value={ 0L,0L,2L,1L,2L,1L,2L,1L,2L,0L,2L,1L,2L,1L,2L,0L,2L,1L,2L,1L,2L,0L,2L,1L,2L,0L,2L,0L,2L,1L,2L,1L,2L,0L,2L,0L,2L,1L,2L,0L,2L,1L,2L,1L,2L,0L,2L,1L,2L,0L,2L,0L,2L,1L,2L,0L,2L,0L,2L,1L,2L,1L,2L,0L,2L,0L,2L,1L,2L,0L,2L,1L,2L,1L,2L,0L,2L,0L,2L,1L,2L,0L,2L,1L,2L,0L,2L,0L,2L,1L,2L,0L,2L,0L,2L,0L,2L,1L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107279Inst : IEnumerable<long>
{
public static readonly long[] Value=A107279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107279.Bytes);
public long this[int i]=>Value[i];

public static A107279Inst Instance=new A107279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107280
{
public static readonly long[] Value={ 11L,36L,53L,54L,109L,123L,259L,380L,877L,1205L,1795L,14153L,21965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107280Inst : IEnumerable<long>
{
public static readonly long[] Value=A107280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107280.Bytes);
public long this[int i]=>Value[i];

public static A107280Inst Instance=new A107280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107281
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,13L,24L,44L,18L,68L,13L,99L,18L,13L,13L,44L,7L,46L,79L,123L,248L,45L,146L,349L,45L,45L,349L,349L,347L,145L,148L,46L,339L,335L,27L,17L,379L,234L,36L,469L,379L,488L,1336L,223L,247L,168L,368L,378L,149L,589L,1116L,1458L,1336L,139L,2339L,1348L,2368L,556L,2247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107281Inst : IEnumerable<long>
{
public static readonly long[] Value=A107281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107281.Bytes);
public long this[int i]=>Value[i];

public static A107281Inst Instance=new A107281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107282
{
public static readonly long[] Value={ 23L,32L,56L,65L,78L,87L,213L,273L,293L,312L,372L,392L,415L,416L,475L,476L,495L,496L,514L,516L,574L,576L,594L,596L,614L,615L,674L,675L,694L,695L,1041L,1074L,1075L,1076L,1102L,1103L,1104L,1105L,1106L,1107L,1108L,1109L,1231L,1252L,1253L,1254L,1255L,1256L,1257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107282Inst : IEnumerable<long>
{
public static readonly long[] Value=A107282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107282.Bytes);
public long this[int i]=>Value[i];

public static A107282Inst Instance=new A107282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107283
{
public static readonly BigInteger[] Value={ 2L,5L,16L,59L,254L,1297L,7820L,54791L,438394L,3945629L,39456392L,434020435L,5208245366L,67707189929L,947900659204L,14218509888287L,227496158212850L,3867434689618741L,69613824413137664L,1322662663849615979L,BigInteger.Parse("26453253276992319982"),BigInteger.Parse("555518318816838720065") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107283Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A107283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107283.Bytes);
public BigInteger this[int i]=>Value[i];

public static A107283Inst Instance=new A107283Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107284
{
public static readonly long[] Value={ 1L,2L,6L,20L,74L,284L,1116L,4424L,17622L,70340L,281076L,1123736L,4493828L,17973080L,71887896L,287542736L,1150153322L,4600578044L,18402241836L,73608826664L,294435025580L,1177739540168L,4710957036936L,18843825900272L,75375299107260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107284Inst : IEnumerable<long>
{
public static readonly long[] Value=A107284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107284.Bytes);
public long this[int i]=>Value[i];

public static A107284Inst Instance=new A107284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107285
{
public static readonly long[] Value={ 4010L,22055L,202505L,2007005L,20052005L,200502005L,2005002005L,20050002005L,200500002005L,2005000002005L,20050000002005L,200500000002005L,2005000000002005L,20050000000002005L,200500000000002005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107285Inst : IEnumerable<long>
{
public static readonly long[] Value=A107285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107285.Bytes);
public long this[int i]=>Value[i];

public static A107285Inst Instance=new A107285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107286
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,5L,2L,3L,2L,1L,2L,1L,2L,3L,2L,5L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,7L,2L,3L,2L,1L,2L,5L,2L,3L,2L,1L,2L,1L,2L,3L,2L,5L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,7L,2L,1L,2L,3L,2L,1L,2L,5L,2L,3L,2L,1L,2L,7L,2L,3L,2L,5L,2L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107286Inst : IEnumerable<long>
{
public static readonly long[] Value=A107286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107286.Bytes);
public long this[int i]=>Value[i];

public static A107286Inst Instance=new A107286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107287
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,4L,4L,6L,7L,10L,15L,22L,33L,47L,68L,97L,140L,202L,292L,422L,609L,879L,1268L,1830L,2641L,3812L,5502L,7941L,11461L,16541L,23873L,34455L,49728L,71771L,103585L,149501L,215770L,311414L,449454L,648683L,936224L,1351223L,1950178L,2814631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107287Inst : IEnumerable<long>
{
public static readonly long[] Value=A107287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107287.Bytes);
public long this[int i]=>Value[i];

public static A107287Inst Instance=new A107287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107288
{
public static readonly long[] Value={ 13L,31L,79L,97L,103L,211L,277L,349L,367L,439L,457L,547L,619L,673L,691L,709L,727L,853L,907L,997L,1021L,1069L,1087L,1201L,1249L,1429L,1447L,1483L,1609L,1627L,1663L,1699L,1753L,1789L,1861L,1879L,1933L,1951L,1987L,2011L,2239L,2293L,2347L,2383L,2437L,2473L,2617L,2671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107288Inst : IEnumerable<long>
{
public static readonly long[] Value=A107288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107288.Bytes);
public long this[int i]=>Value[i];

public static A107288Inst Instance=new A107288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107289
{
public static readonly long[] Value={ 4L,5L,7L,16L,17L,25L,26L,28L,29L,32L,34L,37L,38L,40L,44L,47L,49L,50L,52L,53L,56L,61L,62L,64L,65L,70L,73L,79L,82L,83L,89L,91L,98L,106L,107L,109L,115L,116L,118L,119L,125L,127L,133L,137L,142L,143L,146L,149L,151L,154L,155L,160L,161L,164L,170L,173L,181L,182L,187L,188L,199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107289Inst : IEnumerable<long>
{
public static readonly long[] Value=A107289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107289.Bytes);
public long this[int i]=>Value[i];

public static A107289Inst Instance=new A107289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107290
{
public static readonly BigInteger[] Value={ 3L,11L,43L,2731L,43691L,174763L,715827883L,768614336404564651L,BigInteger.Parse("206323339880896712483187371"),BigInteger.Parse("54086425609737787797192670096043"),BigInteger.Parse("56713727820156410577229101238628035243") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107290Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A107290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107290.Bytes);
public BigInteger this[int i]=>Value[i];

public static A107290Inst Instance=new A107290Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107291
{
public static readonly long[] Value={ 8L,33L,41L,495L,657L,1904L,4497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107291Inst : IEnumerable<long>
{
public static readonly long[] Value=A107291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107291.Bytes);
public long this[int i]=>Value[i];

public static A107291Inst Instance=new A107291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107292
{
public static readonly long[] Value={ 1L,3L,3L,1L,2L,2L,1L,3L,3L,1L,3L,1L,3L,3L,1L,3L,1L,3L,3L,1L,2L,2L,1L,3L,3L,1L,2L,1L,3L,3L,1L,2L,2L,1L,3L,3L,1L,2L,1L,3L,3L,1L,2L,2L,1L,3L,3L,1L,3L,1L,3L,3L,1L,3L,1L,3L,3L,1L,2L,2L,1L,3L,3L,1L,3L,1L,3L,1L,3L,3L,1L,2L,2L,1L,3L,3L,1L,3L,1L,3L,3L,1L,3L,1L,3L,3L,1L,2L,2L,1L,3L,3L,1L,3L,1L,3L,1L,3L,3L,1L,2L,2L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107292Inst : IEnumerable<long>
{
public static readonly long[] Value=A107292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107292.Bytes);
public long this[int i]=>Value[i];

public static A107292Inst Instance=new A107292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107293
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,2L,3L,4L,6L,9L,13L,19L,27L,39L,56L,81L,117L,169L,244L,352L,508L,733L,1058L,1527L,2204L,3181L,4591L,6626L,9563L,13802L,19920L,28750L,41494L,59887L,86433L,124746L,180042L,259849L,375032L,541272L,781201L,1127483L,1627261L,2348575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107293Inst : IEnumerable<long>
{
public static readonly long[] Value=A107293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107293.Bytes);
public long this[int i]=>Value[i];

public static A107293Inst Instance=new A107293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107294
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,3L,1L,1L,3L,7L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,3L,1L,1L,3L,1L,1L,1L,1L,1L,7L,1L,1L,1L,5L,5L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L,3L,1L,1L,1L,1L,1L,1L,1L,1L,5L,1L,1L,1L,1L,5L,9L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107294Inst : IEnumerable<long>
{
public static readonly long[] Value=A107294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107294.Bytes);
public long this[int i]=>Value[i];

public static A107294Inst Instance=new A107294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107295
{
public static readonly long[] Value={ 2L,4L,12L,14L,20L,42L,48L,56L,60L,88L,104L,120L,126L,134L,138L,160L,164L,182L,186L,204L,226L,254L,270L,276L,312L,316L,330L,336L,350L,382L,408L,410L,414L,422L,438L,448L,450L,480L,492L,494L,502L,522L,546L,568L,580L,596L,620L,624L,640L,650L,690L,696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107295Inst : IEnumerable<long>
{
public static readonly long[] Value=A107295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107295.Bytes);
public long this[int i]=>Value[i];

public static A107295Inst Instance=new A107295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107296
{
public static readonly long[] Value={ 1L,3L,1L,1L,2L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,3L,1L,1L,2L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,2L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,2L,1L,3L,1L,1L,2L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,3L,1L,1L,2L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,2L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,2L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107296Inst : IEnumerable<long>
{
public static readonly long[] Value=A107296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107296.Bytes);
public long this[int i]=>Value[i];

public static A107296Inst Instance=new A107296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107297
{
public static readonly long[] Value={ 1L,3L,1L,1L,2L,1L,3L,1L,1L,1L,3L,1L,1L,1L,1L,3L,1L,1L,2L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,2L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,2L,1L,3L,1L,1L,1L,3L,1L,1L,1L,1L,3L,1L,1L,2L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,2L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,2L,1L,3L,1L,1L,1L,3L,1L,1L,1L,1L,3L,1L,1L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107297Inst : IEnumerable<long>
{
public static readonly long[] Value=A107297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107297.Bytes);
public long this[int i]=>Value[i];

public static A107297Inst Instance=new A107297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107298
{
public static readonly long[] Value={ 3L,2L,5L,10L,25L,56L,128L,288L,649L,1459L,3280L,7371L,16564L,37220L,83634L,187925L,422265L,948822L,2131985L,4790528L,10764220L,24186984L,54347661L,122118087L,274396852L,616564131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107298Inst : IEnumerable<long>
{
public static readonly long[] Value=A107298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107298.Bytes);
public long this[int i]=>Value[i];

public static A107298Inst Instance=new A107298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107299
{
public static readonly long[] Value={ 3L,3L,10L,29L,94L,292L,913L,2844L,8862L,27605L,85990L,267852L,834337L,2598884L,8095286L,25216069L,78545726L,244662676L,762101617L,2373876076L,7394404494L,23032886325L,71745311318L,223480011292L,696119572545L,2168348106292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107299Inst : IEnumerable<long>
{
public static readonly long[] Value=A107299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107299.Bytes);
public long this[int i]=>Value[i];

public static A107299Inst Instance=new A107299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107300
{
public static readonly long[] Value={ 3L,2L,8L,14L,40L,92L,236L,576L,1440L,3560L,8848L,21936L,54448L,135072L,335168L,831584L,2063360L,5119552L,12702656L,31517696L,78201600L,194033280L,481434368L,1194532096L,2963866368L,7353928192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107300Inst : IEnumerable<long>
{
public static readonly long[] Value=A107300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107300.Bytes);
public long this[int i]=>Value[i];

public static A107300Inst Instance=new A107300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107301
{
public static readonly long[] Value={ 0L,6L,14L,54L,66L,80L,86L,90L,126L,128L,146L,198L,200L,206L,216L,234L,236L,266L,278L,296L,308L,326L,336L,350L,368L,380L,390L,420L,438L,446L,458L,476L,494L,530L,534L,536L,564L,584L,590L,594L,614L,630L,660L,668L,674L,678L,684L,716L,758L,860L,870L,894L,936L,944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107301Inst : IEnumerable<long>
{
public static readonly long[] Value=A107301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107301.Bytes);
public long this[int i]=>Value[i];

public static A107301Inst Instance=new A107301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107302
{
public static readonly long[] Value={ 0L,20L,24L,42L,44L,62L,72L,96L,104L,122L,152L,156L,180L,192L,200L,222L,230L,240L,242L,252L,254L,264L,294L,312L,356L,362L,380L,422L,426L,452L,482L,500L,504L,534L,546L,566L,590L,602L,650L,656L,672L,690L,710L,720L,726L,744L,770L,794L,804L,810L,836L,840L,864L,914L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107302Inst : IEnumerable<long>
{
public static readonly long[] Value=A107302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107302.Bytes);
public long this[int i]=>Value[i];

public static A107302Inst Instance=new A107302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107303
{
public static readonly long[] Value={ 4L,6L,8L,12L,14L,16L,22L,24L,26L,28L,34L,36L,38L,44L,48L,52L,54L,56L,62L,66L,68L,72L,76L,78L,82L,92L,94L,96L,104L,106L,112L,114L,118L,124L,126L,128L,134L,138L,142L,146L,148L,154L,156L,164L,168L,176L,182L,184L,192L,194L,202L,204L,206L,208L,212L,216L,222L,226L,232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107303Inst : IEnumerable<long>
{
public static readonly long[] Value=A107303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107303.Bytes);
public long this[int i]=>Value[i];

public static A107303Inst Instance=new A107303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107304
{
public static readonly long[] Value={ 2L,4L,6L,10L,12L,16L,18L,22L,24L,34L,36L,40L,46L,48L,54L,58L,60L,64L,72L,76L,78L,88L,90L,94L,102L,106L,114L,120L,124L,130L,132L,136L,138L,148L,150L,156L,166L,172L,174L,178L,192L,198L,204L,208L,214L,220L,222L,226L,232L,234L,240L,244L,246L,258L,262L,276L,286L,288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107304Inst : IEnumerable<long>
{
public static readonly long[] Value=A107304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107304.Bytes);
public long this[int i]=>Value[i];

public static A107304Inst Instance=new A107304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107305
{
public static readonly long[] Value={ 4L,6L,10L,16L,22L,24L,30L,36L,42L,60L,64L,70L,76L,84L,90L,94L,100L,102L,106L,120L,126L,132L,136L,142L,144L,150L,160L,172L,174L,184L,192L,196L,210L,214L,226L,232L,244L,246L,256L,270L,274L,276L,280L,282L,294L,304L,316L,322L,330L,340L,346L,354L,360L,366L,370L,372L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107305Inst : IEnumerable<long>
{
public static readonly long[] Value=A107305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107305.Bytes);
public long this[int i]=>Value[i];

public static A107305Inst Instance=new A107305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107306
{
public static readonly long[] Value={ 6L,10L,24L,28L,30L,36L,40L,48L,58L,64L,66L,70L,78L,84L,90L,94L,96L,106L,118L,124L,136L,150L,156L,166L,168L,174L,180L,184L,196L,198L,204L,208L,226L,238L,244L,250L,274L,276L,288L,300L,318L,328L,330L,334L,336L,348L,358L,360L,366L,370L,376L,388L,394L,400L,406L,408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107306Inst : IEnumerable<long>
{
public static readonly long[] Value=A107306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107306.Bytes);
public long this[int i]=>Value[i];

public static A107306Inst Instance=new A107306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107307
{
public static readonly long[] Value={ 1L,4L,15L,51L,183L,655L,2381L,8653L,31539L,114927L,419001L,1527457L,5568791L,20302171L,74016909L,269846637L,983794491L,3586668535L,13076103713L,47672218297L,173801058495L,633635426355L,2310077203221L,8421966964069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107307Inst : IEnumerable<long>
{
public static readonly long[] Value=A107307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107307.Bytes);
public long this[int i]=>Value[i];

public static A107307Inst Instance=new A107307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107308
{
public static readonly long[] Value={ 12L,16L,18L,22L,30L,36L,40L,42L,46L,48L,60L,70L,82L,88L,90L,96L,102L,112L,118L,120L,126L,130L,132L,148L,156L,166L,172L,180L,190L,196L,198L,202L,228L,238L,246L,250L,256L,258L,268L,280L,282L,286L,300L,316L,330L,340L,342L,348L,352L,382L,390L,406L,408L,420L,426L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107308Inst : IEnumerable<long>
{
public static readonly long[] Value=A107308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107308.Bytes);
public long this[int i]=>Value[i];

public static A107308Inst Instance=new A107308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107309
{
public static readonly long[] Value={ 53L,75L,1311L,1917L,3129L,4341L,6159L,7371L,103101L,109107L,139137L,151149L,181179L,193191L,199197L,229227L,241239L,271269L,283281L,313311L,349347L,421419L,433431L,463461L,523521L,571569L,601599L,619617L,643641L,661659L,811809L,823821L,829827L,859857L,883881L,10211019L,10331031L,10511049L,10631061L,10931091L,11531151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107309Inst : IEnumerable<long>
{
public static readonly long[] Value=A107309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107309.Bytes);
public long this[int i]=>Value[i];

public static A107309Inst Instance=new A107309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107310
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,5L,11L,7L,1L,25L,60L,46L,12L,1L,125L,325L,290L,106L,17L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107310Inst : IEnumerable<long>
{
public static readonly long[] Value=A107310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107310.Bytes);
public long this[int i]=>Value[i];

public static A107310Inst Instance=new A107310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107311
{
public static readonly long[] Value={ 1L,7L,2L,8L,6L,4L,7L,2L,3L,8L,9L,9L,8L,1L,8L,3L,6L,1L,8L,1L,3L,5L,1L,0L,3L,0L,1L,0L,2L,9L,7L,6L,9L,1L,4L,6L,4L,2L,3L,4L,1L,0L,9L,8L,4L,9L,3L,3L,5L,0L,3L,5L,7L,3L,2L,3L,2L,1L,2L,8L,5L,9L,0L,8L,4L,2L,3L,1L,7L,8L,5L,9L,6L,5L,3L,5L,7L,1L,0L,0L,8L,6L,7L,7L,2L,7L,4L,6L,0L,8L,1L,0L,8L,8L,9L,8L,2L,6L,4L,4L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107311Inst : IEnumerable<long>
{
public static readonly long[] Value=A107311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107311.Bytes);
public long this[int i]=>Value[i];

public static A107311Inst Instance=new A107311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107312
{
public static readonly long[] Value={ 3L,5L,17L,137L,347L,827L,2087L,2687L,3557L,3917L,4517L,4967L,5477L,5657L,5867L,6827L,7457L,7547L,7877L,8087L,8537L,8597L,10037L,10427L,10937L,12107L,12377L,13397L,13877L,16067L,17837L,17987L,19427L,19697L,20507L,20717L,20807L,22367L,22637L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107312Inst : IEnumerable<long>
{
public static readonly long[] Value=A107312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107312.Bytes);
public long this[int i]=>Value[i];

public static A107312Inst Instance=new A107312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107313
{
public static readonly long[] Value={ 1L,9L,18L,52L,94L,121L,144L,148L,163L,169L,522L,526L,925L,927L,961L,982L,1042L,1062L,1089L,1251L,1273L,1297L,1405L,1426L,1656L,1674L,1828L,1843L,1861L,5202L,5203L,5209L,5221L,5224L,5227L,5265L,9022L,9049L,9082L,9235L,9295L,9423L,9468L,9481L,9631L,9657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107313Inst : IEnumerable<long>
{
public static readonly long[] Value=A107313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107313.Bytes);
public long this[int i]=>Value[i];

public static A107313Inst Instance=new A107313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107314
{
public static readonly long[] Value={ 1L,72L,343L,521L,927L,1331L,1629L,3194L,5733L,7912L,9586L,12986L,19792L,35605L,38691L,52119L,52651L,57824L,70597L,73953L,76121L,91395L,98342L,119753L,144135L,156231L,175357L,189622L,305856L,328301L,335654L,367003L,376219L,391581L,521416L,526472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107314Inst : IEnumerable<long>
{
public static readonly long[] Value=A107314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107314.Bytes);
public long this[int i]=>Value[i];

public static A107314Inst Instance=new A107314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107315
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,12L,13L,14L,15L,16L,17L,18L,19L,31L,32L,33L,34L,35L,36L,37L,38L,39L,51L,52L,53L,54L,55L,56L,57L,58L,59L,71L,72L,73L,74L,75L,76L,77L,78L,79L,91L,92L,93L,94L,95L,96L,97L,98L,99L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107315Inst : IEnumerable<long>
{
public static readonly long[] Value=A107315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107315.Bytes);
public long this[int i]=>Value[i];

public static A107315Inst Instance=new A107315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107316
{
public static readonly long[] Value={ 2L,3L,6L,13L,29L,67L,156L,372L,900L,2202L,5443L,13562L,34031L,85900L,217934L,555381L,1420879L,3647776L,9393805L,24258259L,62800749L,162950583L,423687106L,1103713422L,2880195973L,7528061901L,19705490392L,51652038010L,135563251625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107316Inst : IEnumerable<long>
{
public static readonly long[] Value=A107316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107316.Bytes);
public long this[int i]=>Value[i];

public static A107316Inst Instance=new A107316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107317
{
public static readonly long[] Value={ 6L,14L,26L,62L,86L,146L,314L,422L,482L,614L,842L,926L,1202L,1514L,2246L,2966L,3446L,5102L,5942L,6614L,7082L,7814L,8846L,9662L,10226L,11402L,12014L,12326L,12962L,16022L,16382L,19802L,20606L,22262L,24422L,24866L,27614L,28562L,34586L,38366L,40046L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107317Inst : IEnumerable<long>
{
public static readonly long[] Value=A107317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107317.Bytes);
public long this[int i]=>Value[i];

public static A107317Inst Instance=new A107317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107318
{
public static readonly long[] Value={ 3L,12L,56L,254L,1620L,10804L,77614L,582800L,4548410L,36400976L,298182320L,2487444740L,21066301710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107318Inst : IEnumerable<long>
{
public static readonly long[] Value=A107318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107318.Bytes);
public long this[int i]=>Value[i];

public static A107318Inst Instance=new A107318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107319
{
public static readonly long[] Value={ 1L,63L,1260L,13860L,103950L,594594L,2774772L,11042460L,38648610L,121671550L,350414064L,935402832L,2338507080L,5521090680L,12394285200L,26606398896L,54875697723L,109181751525L,210275965900L,393175282500L,715579014150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107319Inst : IEnumerable<long>
{
public static readonly long[] Value=A107319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107319.Bytes);
public long this[int i]=>Value[i];

public static A107319Inst Instance=new A107319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107320
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,3L,3L,3L,4L,4L,4L,4L,6L,6L,7L,7L,9L,9L,9L,9L,10L,10L,11L,11L,12L,12L,11L,11L,12L,12L,12L,12L,14L,14L,12L,12L,14L,14L,15L,15L,16L,16L,16L,16L,17L,17L,17L,17L,20L,20L,20L,20L,21L,21L,24L,24L,27L,27L,27L,27L,28L,28L,29L,29L,30L,30L,29L,29L,30L,30L,35L,35L,36L,36L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107320Inst : IEnumerable<long>
{
public static readonly long[] Value=A107320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107320.Bytes);
public long this[int i]=>Value[i];

public static A107320Inst Instance=new A107320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107321
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,14L,42L,79L,254L,506L,1702L,3548L,12320L,26666L,94794L,211751L,766362L,1758352L,6453812L,15150922L,56238710L,134659120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107321Inst : IEnumerable<long>
{
public static readonly long[] Value=A107321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107321.Bytes);
public long this[int i]=>Value[i];

public static A107321Inst Instance=new A107321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107322
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,14L,22L,33L,34L,35L,38L,41L,43L,44L,45L,48L,53L,54L,55L,58L,66L,67L,69L,76L,77L,79L,83L,84L,85L,88L,96L,97L,99L,101L,102L,103L,104L,105L,106L,107L,108L,109L,111L,112L,113L,115L,118L,121L,122L,123L,124L,125L,126L,127L,128L,129L,131L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107322Inst : IEnumerable<long>
{
public static readonly long[] Value=A107322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107322.Bytes);
public long this[int i]=>Value[i];

public static A107322Inst Instance=new A107322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107323
{
public static readonly long[] Value={ 7L,5L,13L,11L,19L,17L,25L,31L,29L,35L,43L,41L,49L,55L,61L,59L,65L,73L,71L,77L,85L,91L,95L,103L,101L,109L,107L,115L,125L,133L,139L,137L,151L,149L,155L,161L,169L,175L,181L,179L,193L,191L,199L,197L,209L,221L,229L,227L,235L,241L,239L,253L,259L,265L,271L,269L,275L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107323Inst : IEnumerable<long>
{
public static readonly long[] Value=A107323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107323.Bytes);
public long this[int i]=>Value[i];

public static A107323Inst Instance=new A107323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107324
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,2L,4L,3L,3L,3L,6L,3L,7L,4L,4L,4L,9L,4L,10L,4L,5L,6L,12L,5L,5L,7L,6L,5L,15L,5L,16L,6L,7L,9L,6L,6L,19L,10L,8L,6L,21L,6L,22L,7L,7L,12L,24L,7L,7L,7L,10L,8L,27L,7L,8L,7L,11L,15L,30L,8L,31L,16L,8L,8L,9L,8L,34L,10L,13L,8L,36L,8L,37L,19L,10L,11L,9L,9L,40L,9L,9L,21L,42L,9L,11L,22L,16L,9L,45L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107324Inst : IEnumerable<long>
{
public static readonly long[] Value=A107324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107324.Bytes);
public long this[int i]=>Value[i];

public static A107324Inst Instance=new A107324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107325
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,3L,4L,3L,3L,4L,6L,4L,7L,5L,4L,4L,9L,5L,10L,5L,5L,7L,12L,5L,5L,8L,6L,6L,15L,6L,16L,6L,7L,10L,6L,6L,19L,11L,8L,7L,21L,7L,22L,8L,7L,13L,24L,7L,7L,8L,10L,9L,27L,8L,8L,8L,11L,16L,30L,8L,31L,17L,8L,8L,9L,9L,34L,11L,13L,9L,36L,9L,37L,20L,10L,12L,9L,10L,40L,9L,9L,22L,42L,10L,11L,23L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107325Inst : IEnumerable<long>
{
public static readonly long[] Value=A107325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107325.Bytes);
public long this[int i]=>Value[i];

public static A107325Inst Instance=new A107325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107326
{
public static readonly long[] Value={ 1L,2L,4L,8L,13L,16L,26L,32L,52L,64L,104L,128L,169L,208L,256L,338L,416L,512L,676L,832L,1024L,1352L,1664L,2048L,2197L,2704L,3328L,4096L,4394L,5408L,6656L,8192L,8788L,10816L,13312L,16384L,17576L,21632L,26624L,28561L,32768L,35152L,43264L,53248L,57122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107326Inst : IEnumerable<long>
{
public static readonly long[] Value=A107326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107326.Bytes);
public long this[int i]=>Value[i];

public static A107326Inst Instance=new A107326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107327
{
public static readonly long[] Value={ 2L,3L,11L,43L,251L,1931L,19237L,239347L,3627181L,65467067L,1381237531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107327Inst : IEnumerable<long>
{
public static readonly long[] Value=A107327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107327.Bytes);
public long this[int i]=>Value[i];

public static A107327Inst Instance=new A107327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107328
{
public static readonly long[] Value={ 3L,4L,8L,19L,48L,124L,323L,844L,2208L,5779L,15128L,39604L,103683L,271444L,710648L,1860499L,4870848L,12752044L,33385283L,87403804L,228826128L,599074579L,1568397608L,4106118244L,10749957123L,28143753124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107328Inst : IEnumerable<long>
{
public static readonly long[] Value=A107328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107328.Bytes);
public long this[int i]=>Value[i];

public static A107328Inst Instance=new A107328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107329
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,2L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107329Inst : IEnumerable<long>
{
public static readonly long[] Value=A107329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107329.Bytes);
public long this[int i]=>Value[i];

public static A107329Inst Instance=new A107329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107330
{
public static readonly long[] Value={ 3L,3L,12L,41L,148L,517L,1809L,6316L,22052L,76982L,268737L,938126L,3274873L,11432137L,39908034L,139313506L,486324452L,1697692337L,5926412412L,20688297461L,72220024873L,252110257132L,880082523684L,3072248060446L,10724798971577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107330Inst : IEnumerable<long>
{
public static readonly long[] Value=A107330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107330.Bytes);
public long this[int i]=>Value[i];

public static A107330Inst Instance=new A107330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107331
{
public static readonly long[] Value={ 1L,2L,2L,4L,3L,4L,3L,7L,5L,6L,4L,8L,4L,6L,6L,11L,5L,10L,5L,12L,6L,8L,5L,14L,8L,8L,10L,12L,6L,12L,6L,16L,8L,10L,9L,20L,7L,10L,8L,21L,7L,12L,7L,16L,15L,10L,7L,22L,10L,16L,10L,16L,8L,20L,12L,21L,10L,12L,8L,24L,8L,12L,15L,24L,12L,16L,9L,20L,10L,18L,9L,35L,9L,14L,16L,20L,12L,16L,9L,33L,19L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107331Inst : IEnumerable<long>
{
public static readonly long[] Value=A107331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107331.Bytes);
public long this[int i]=>Value[i];

public static A107331Inst Instance=new A107331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107332
{
public static readonly long[] Value={ 0L,1L,0L,0L,-1L,-1L,-1L,-1L,-1L,-2L,-3L,-5L,-7L,-10L,-14L,-20L,-29L,-42L,-61L,-88L,-127L,-183L,-264L,-381L,-550L,-794L,-1146L,-1654L,-2387L,-3445L,-4972L,-7176L,-10357L,-14948L,-21574L,-31137L,-44939L,-64859L,-93609L,-135103L,-194990L,-281423L,-406169L,-586211L,-846060L,-1221092L,-1762364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107332Inst : IEnumerable<long>
{
public static readonly long[] Value=A107332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107332.Bytes);
public long this[int i]=>Value[i];

public static A107332Inst Instance=new A107332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107333
{
public static readonly long[] Value={ 1L,3L,3L,1L,1L,2L,1L,2L,1L,3L,3L,1L,1L,3L,3L,1L,3L,1L,3L,3L,1L,3L,1L,3L,3L,1L,1L,2L,1L,2L,1L,3L,3L,1L,1L,3L,3L,1L,1L,2L,1L,2L,1L,3L,3L,1L,1L,2L,1L,3L,3L,1L,1L,2L,1L,2L,1L,3L,3L,1L,1L,2L,1L,3L,3L,1L,1L,2L,1L,2L,1L,3L,3L,1L,1L,3L,3L,1L,3L,1L,3L,3L,1L,3L,1L,3L,3L,1L,1L,2L,1L,2L,1L,3L,3L,1L,1L,3L,3L,1L,1L,2L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107333Inst : IEnumerable<long>
{
public static readonly long[] Value=A107333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107333.Bytes);
public long this[int i]=>Value[i];

public static A107333Inst Instance=new A107333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107334
{
public static readonly long[] Value={ 3L,2L,10L,20L,66L,172L,502L,1388L,3938L,11036L,31110L,87452L,246162L,692460L,1948502L,5482060L,15424706L,43398588L,122107174L,343560700L,966645746L,2719759244L,7652334326L,21530654892L,60578794274L,170444884572L,479564842182L,1349306749532L,3796418256466L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107334Inst : IEnumerable<long>
{
public static readonly long[] Value=A107334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107334.Bytes);
public long this[int i]=>Value[i];

public static A107334Inst Instance=new A107334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107335
{
public static readonly long[] Value={ 1L,1L,3L,2L,3L,1L,1L,1L,3L,2L,3L,1L,1L,3L,1L,1L,1L,3L,2L,3L,1L,1L,1L,3L,2L,3L,1L,1L,1L,3L,2L,3L,1L,1L,3L,1L,1L,1L,3L,2L,3L,1L,1L,1L,3L,2L,3L,1L,1L,1L,1L,3L,2L,3L,1L,1L,1L,3L,2L,3L,1L,1L,1L,3L,2L,3L,1L,1L,3L,1L,1L,1L,3L,2L,3L,1L,1L,1L,3L,2L,3L,1L,1L,1L,3L,2L,3L,1L,1L,3L,1L,1L,1L,3L,2L,3L,1L,1L,1L,3L,2L,3L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107335Inst : IEnumerable<long>
{
public static readonly long[] Value=A107335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107335.Bytes);
public long this[int i]=>Value[i];

public static A107335Inst Instance=new A107335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107336
{
public static readonly long[] Value={ 1L,2L,3L,3L,2L,1L,3L,1L,1L,3L,1L,2L,3L,3L,2L,1L,1L,1L,2L,3L,3L,2L,1L,1L,2L,3L,3L,2L,1L,1L,1L,2L,3L,3L,2L,1L,3L,1L,1L,3L,1L,2L,3L,3L,2L,1L,1L,2L,3L,3L,2L,1L,1L,2L,3L,3L,2L,1L,3L,1L,1L,3L,1L,2L,3L,3L,2L,1L,1L,2L,3L,3L,2L,1L,3L,1L,1L,3L,1L,2L,3L,3L,2L,1L,1L,2L,3L,3L,2L,1L,1L,2L,3L,3L,2L,1L,3L,1L,1L,3L,1L,2L,3L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107336Inst : IEnumerable<long>
{
public static readonly long[] Value=A107336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107336.Bytes);
public long this[int i]=>Value[i];

public static A107336Inst Instance=new A107336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107337
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,3L,1L,3L,1L,2L,1L,3L,2L,3L,1L,1L,3L,1L,1L,2L,1L,3L,2L,3L,1L,1L,1L,2L,1L,3L,2L,3L,1L,3L,1L,2L,1L,3L,2L,3L,1L,1L,3L,1L,1L,2L,1L,3L,2L,3L,1L,1L,2L,1L,3L,2L,3L,1L,1L,1L,2L,1L,3L,2L,3L,1L,1L,2L,1L,3L,2L,3L,1L,3L,1L,2L,1L,3L,2L,3L,1L,1L,3L,1L,1L,2L,1L,3L,2L,3L,1L,1L,2L,1L,3L,2L,3L,1L,1L,2L,1L,3L,2L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107337Inst : IEnumerable<long>
{
public static readonly long[] Value=A107337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107337.Bytes);
public long this[int i]=>Value[i];

public static A107337Inst Instance=new A107337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107338
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,3L,1L,2L,1L,3L,2L,1L,1L,3L,3L,1L,2L,1L,3L,2L,1L,1L,3L,1L,2L,1L,3L,2L,1L,3L,1L,2L,1L,3L,2L,1L,1L,3L,3L,1L,2L,1L,3L,2L,1L,1L,2L,1L,3L,2L,1L,1L,3L,1L,3L,1L,2L,1L,3L,2L,1L,3L,1L,2L,1L,3L,2L,1L,1L,3L,3L,1L,2L,1L,3L,2L,1L,1L,2L,1L,3L,2L,1L,1L,3L,1L,2L,1L,3L,2L,1L,3L,1L,2L,1L,3L,2L,1L,1L,3L,3L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107338Inst : IEnumerable<long>
{
public static readonly long[] Value=A107338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107338.Bytes);
public long this[int i]=>Value[i];

public static A107338Inst Instance=new A107338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107339
{
public static readonly long[] Value={ 5L,57L,574L,5748L,57486L,574868L,5748688L,57486888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107339Inst : IEnumerable<long>
{
public static readonly long[] Value=A107339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107339.Bytes);
public long this[int i]=>Value[i];

public static A107339Inst Instance=new A107339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107340
{
public static readonly long[] Value={ 3L,4L,6L,9L,14L,25L,40L,62L,89L,129L,185L,271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107340Inst : IEnumerable<long>
{
public static readonly long[] Value=A107340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107340.Bytes);
public long this[int i]=>Value[i];

public static A107340Inst Instance=new A107340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}