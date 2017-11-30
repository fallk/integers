using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A019509
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,1L,2L,3L,2L,0L,1L,0L,1L,0L,1L,2L,3L,2L,0L,1L,0L,1L,0L,1L,2L,3L,2L,0L,1L,0L,1L,0L,1L,2L,3L,2L,3L,2L,3L,4L,5L,4L,5L,4L,5L,3L,2L,3L,4L,5L,4L,0L,1L,0L,1L,2L,3L,2L,3L,2L,0L,1L,0L,1L,2L,3L,2L,3L,2L,0L,1L,0L,1L,4L,5L,2L,3L,2L,3L,5L,4L,5L,4L,5L,6L,0L,1L,3L,5L,4L,5L,4L,5L,6L,0L,1L,3L,6L,7L };
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
public class A019509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019509Inst : IEnumerable<long>
{
public static readonly long[] Value=A019509.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019509.Bytes);
public long this[int i]=>Value[i];

public static A019509Inst Instance=new A019509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019510
{
public static readonly long[] Value={ 2L,5L,1L,7L,20L,3L,5L,11L,2L,65L,7L,5L,8L,17L,15L,19L,10L,7L,11L,115L,4L,25L,13L,9L,70L,29L,5L,31L,16L,55L,17L,35L,6L,37L,95L,13L,20L,41L,7L,215L,22L,15L,23L,47L,40L,49L,25L,17L,26L,265L };
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
public class A019510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019510Inst : IEnumerable<long>
{
public static readonly long[] Value=A019510.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019510.Bytes);
public long this[int i]=>Value[i];

public static A019510Inst Instance=new A019510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019511
{
public static readonly long[] Value={ 1L,1L,2L,8L,9L,10L,512L,513L,514L,520L,521L,522L,729L,730L,731L,737L,738L,739L,1000L,1001L,1002L,1008L,1009L,1010L,1241L,1242L,1243L,1249L,1250L,1251L,1512L,1513L,1514L,1520L,1521L,1522L,1729L,1730L,1731L,1737L,1738L,1739L,2241L,2242L,2243L,2249L,2250L,2251L };
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
public class A019511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019511Inst : IEnumerable<long>
{
public static readonly long[] Value=A019511.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019511.Bytes);
public long this[int i]=>Value[i];

public static A019511Inst Instance=new A019511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019512
{
public static readonly long[] Value={ 1L,19L,245L,2675L,26661L,251139L,2278165L,20125075L,174364421L,1488724259L,12567504885L,105148209075L,873459639781L,7213661997379L,59291458568405L,485407880414675L,3960800821356741L,32229188196998499L };
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
public class A019512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019512Inst : IEnumerable<long>
{
public static readonly long[] Value=A019512.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019512.Bytes);
public long this[int i]=>Value[i];

public static A019512Inst Instance=new A019512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019513
{
public static readonly long[] Value={ 1L,10L,100L,101L,110L,200L,201L,1000L,1001L,1010L,1100L,1101L,1110L,1200L,10000L,10001L,10010L,10100L,10101L,10110L,10200L,10201L,11000L,11001L,11010L,11100L,11101L,11110L,11200L,11201L,12000L };
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
public class A019513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019513Inst : IEnumerable<long>
{
public static readonly long[] Value=A019513.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019513.Bytes);
public long this[int i]=>Value[i];

public static A019513Inst Instance=new A019513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019514
{
public static readonly BigInteger[] Value={ 2L,2L,9L,217L,13825L,1728001L,373248001L,128024064001L,65548320768001L,47784725839872001L,BigInteger.Parse("47784725839872000001"),BigInteger.Parse("63601470092869632000001"),BigInteger.Parse("109903340320478724096000001"),BigInteger.Parse("241457638684091756838912000001") };
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
public class A019514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019514Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019514.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019514.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019514Inst Instance=new A019514Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019515
{
public static readonly BigInteger[] Value={ 2L,2L,3L,13L,289L,34561L,24883201L,125411328001L,5056584744960001L,BigInteger.Parse("1834933472251084800001"),BigInteger.Parse("6658606584104736522240000001"),BigInteger.Parse("265790267296391946810949632000000001") };
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
public class A019515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019515Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019515.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019515.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019515Inst Instance=new A019515Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019516
{
public static readonly long[] Value={ 0L,1L,4L,6L,8L,9L,10L,11L,1L,1L,14L,1L,16L,1L,18L,19L,0L,1L,4L,6L,8L,9L,0L,1L,4L,6L,8L,9L,40L,41L,4L,4L,44L,4L,46L,4L,48L,49L,0L,1L,4L,6L,8L,9L,60L,61L,6L,6L,64L,6L,66L,6L,68L,69L,0L,1L,4L,6L,8L,9L,80L,81L,8L,8L,84L,8L,86L,8L,88L,89L,90L,91L,9L,9L,94L,9L,96L };
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
public class A019516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019516Inst : IEnumerable<long>
{
public static readonly long[] Value=A019516.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019516.Bytes);
public long this[int i]=>Value[i];

public static A019516Inst Instance=new A019516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019517
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,8L,2L,3L,5L,6L,7L,8L,2L,2L,22L,23L,2L,25L,26L,27L,28L,2L,3L,3L,32L,33L,3L,35L,36L,37L,38L,3L,2L,3L,5L,6L,7L,8L,5L,5L,52L,52L,5L,55L,56L,57L,58L,5L,6L,6L,62L };
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
public class A019517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019517Inst : IEnumerable<long>
{
public static readonly long[] Value=A019517.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019517.Bytes);
public long this[int i]=>Value[i];

public static A019517Inst Instance=new A019517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019518
{
public static readonly BigInteger[] Value={ 2L,23L,235L,2357L,235711L,23571113L,2357111317L,235711131719L,23571113171923L,2357111317192329L,235711131719232931L,BigInteger.Parse("23571113171923293137"),BigInteger.Parse("2357111317192329313741"),BigInteger.Parse("235711131719232931374143"),BigInteger.Parse("23571113171923293137414347") };
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
public class A019518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019518Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019518.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019518.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019518Inst Instance=new A019518Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019519
{
public static readonly BigInteger[] Value={ 1L,13L,135L,1357L,13579L,1357911L,135791113L,13579111315L,1357911131517L,135791113151719L,13579111315171921L,1357911131517192123L,BigInteger.Parse("135791113151719212325"),BigInteger.Parse("13579111315171921232527"),BigInteger.Parse("1357911131517192123252729"),BigInteger.Parse("135791113151719212325272931") };
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
public class A019519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019519Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019519.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019519.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019519Inst Instance=new A019519Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019520
{
public static readonly BigInteger[] Value={ 2L,24L,246L,2468L,246810L,24681012L,2468101214L,246810121416L,24681012141618L,2468101214161820L,246810121416182022L,BigInteger.Parse("24681012141618202224"),BigInteger.Parse("2468101214161820222426"),BigInteger.Parse("246810121416182022242628"),BigInteger.Parse("24681012141618202224262830"),BigInteger.Parse("2468101214161820222426283032") };
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
public class A019520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019520Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019520.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019520.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019520Inst Instance=new A019520Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019521
{
public static readonly BigInteger[] Value={ 1L,14L,149L,14916L,1491625L,149162536L,14916253649L,1491625364964L,149162536496481L,149162536496481100L,BigInteger.Parse("149162536496481100121"),BigInteger.Parse("149162536496481100121144"),BigInteger.Parse("149162536496481100121144169") };
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
public class A019521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019521Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019521.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019521.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019521Inst Instance=new A019521Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019522
{
public static readonly BigInteger[] Value={ 1L,18L,1827L,182764L,182764125L,182764125216L,182764125216343L,182764125216343512L,BigInteger.Parse("182764125216343512729"),BigInteger.Parse("1827641252163435127291000"),BigInteger.Parse("18276412521634351272910001331"),BigInteger.Parse("182764125216343512729100013311728") };
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
public class A019522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019522Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019522.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019522.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019522Inst Instance=new A019522Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019523
{
public static readonly BigInteger[] Value={ 1L,11L,112L,1123L,11235L,112358L,11235813L,1123581321L,112358132134L,11235813213455L,1123581321345589L,1123581321345589144L,BigInteger.Parse("1123581321345589144233"),BigInteger.Parse("1123581321345589144233377"),BigInteger.Parse("1123581321345589144233377610"),BigInteger.Parse("1123581321345589144233377610987") };
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
public class A019523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019523Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019523.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019523.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019523Inst Instance=new A019523Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019524
{
public static readonly BigInteger[] Value={ 11L,1212L,123123L,12341234L,1234512345L,123456123456L,12345671234567L,1234567812345678L,123456789123456789L,BigInteger.Parse("1234567891012345678910"),BigInteger.Parse("12345678910111234567891011"),BigInteger.Parse("123456789101112123456789101112") };
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
public class A019524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019524Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019524.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019524.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019524Inst Instance=new A019524Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019525
{
public static readonly long[] Value={ 2L,3L,6L,12L,27L,60L,138L,315L,726L,1668L,3843L,8844L,20370L,46899L,108006L,248700L,572715L,1318812L,3036954L,6993387L,16104246L,37084404L,85397139L,196650348L,452841762L,1042792803L,2401318086L,5529696492L,12733650747L,29322740220L };
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
public class A019525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019525Inst : IEnumerable<long>
{
public static readonly long[] Value=A019525.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019525.Bytes);
public long this[int i]=>Value[i];

public static A019525Inst Instance=new A019525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019526
{
public static readonly long[] Value={ 4L,5L,8L,13L,24L,44L,83L,158L,303L,582L,1120L,2157L,4156L,8009L,15436L,29752L,57347L,110538L,213067L,410698L,791644L,1525941L,2941344L,5669621L,10928544L,21065444L,40604947L,78268550L,150867479L,290806414L,560547384L,1080489821L,2082711092L };
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
public class A019526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019526Inst : IEnumerable<long>
{
public static readonly long[] Value=A019526.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019526.Bytes);
public long this[int i]=>Value[i];

public static A019526Inst Instance=new A019526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019527
{
public static readonly long[] Value={ 4L,4L,5L,6L,8L,11L,15L,21L,30L,43L,62L,90L,131L,191L,279L,408L,597L,874L,1280L,1875L,2747L,4025L,5898L,8643L,12666L,18562L,27203L,39867L,58427L,85628L,125493L,183918L,269544L,395035L,578951L,848493L,1243526L,1822475L,2670966L,3914490L,5736963L,8407927L };
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
public class A019527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019527Inst : IEnumerable<long>
{
public static readonly long[] Value=A019527.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019527.Bytes);
public long this[int i]=>Value[i];

public static A019527Inst Instance=new A019527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019528
{
public static readonly long[] Value={ 5L,5L,6L,8L,11L,16L,25L,38L,59L,93L,148L,235L,376L,602L,966L,1550L,2491L,4003L,6436L,10348L,16643L,26766L,43052L,69247L,111387L,179169L,288207L,463601L,745744L,1199593L,1929661L,3104041L,4993156L,8031978L,12920238L,20783483L,33432314L,53779215L };
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
public class A019528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019528Inst : IEnumerable<long>
{
public static readonly long[] Value=A019528.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019528.Bytes);
public long this[int i]=>Value[i];

public static A019528Inst Instance=new A019528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019529
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,10L,14L,18L,22L,27L,33L,39L,45L,52L,60L,68L,76L,85L,95L,105L,115L,126L,138L,150L,162L,175L,189L,202L,217L,232L,247L,263L,280L,297L,314L,332L,351L,370L,389L,409L,430L,451L,472L,494L,517L,540L,563L,587L,612L,637L,662L,688L,715L,741L,769L,797L,825L };
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
public class A019529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019529Inst : IEnumerable<long>
{
public static readonly long[] Value=A019529.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019529.Bytes);
public long this[int i]=>Value[i];

public static A019529Inst Instance=new A019529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019530
{
public static readonly long[] Value={ 0L,2L,3L,2L,5L,6L,7L,4L,3L,10L,11L,6L,13L,14L,15L,4L,17L,6L,19L,10L,21L,22L,23L,6L,5L,26L,3L,14L,29L,30L,31L,4L,33L,34L,35L,6L,37L,38L,39L,10L,41L,42L,43L,22L,15L,46L,47L,6L,7L,10L,51L,26L,53L,6L,55L,14L,57L,58L,59L,30L,61L,62L,21L,4L,65L,66L,67L,34L,69L,70L,71L,6L,73L,74L,15L,38L,77L,78L };
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
public class A019530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019530Inst : IEnumerable<long>
{
public static readonly long[] Value=A019530.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019530.Bytes);
public long this[int i]=>Value[i];

public static A019530Inst Instance=new A019530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019531
{
public static readonly long[] Value={ 5L,15L,35L,84L,207L,498L,1202L,2970L };
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
public class A019531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019531Inst : IEnumerable<long>
{
public static readonly long[] Value=A019531.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019531.Bytes);
public long this[int i]=>Value[i];

public static A019531Inst Instance=new A019531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019532
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,12L,24L };
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
public class A019532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019532Inst : IEnumerable<long>
{
public static readonly long[] Value=A019532.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019532.Bytes);
public long this[int i]=>Value[i];

public static A019532Inst Instance=new A019532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019533
{
public static readonly long[] Value={ 6L,10L,16L,31L,40L,68L,93L,154L,215L,354L,531L };
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
public class A019533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019533Inst : IEnumerable<long>
{
public static readonly long[] Value=A019533.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019533.Bytes);
public long this[int i]=>Value[i];

public static A019533Inst Instance=new A019533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019550
{
public static readonly long[] Value={ 12L,24L,36L,48L,510L,612L,714L,816L,918L,1020L,1122L,1224L,1326L,1428L,1530L,1632L,1734L,1836L,1938L,2040L,2142L,2244L,2346L,2448L,2550L,2652L,2754L,2856L,2958L,3060L,3162L,3264L,3366L,3468L,3570L,3672L,3774L,3876L,3978L,4080L };
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
public class A019550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019550Inst : IEnumerable<long>
{
public static readonly long[] Value=A019550.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019550.Bytes);
public long this[int i]=>Value[i];

public static A019550Inst Instance=new A019550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019551
{
public static readonly long[] Value={ 13L,26L,39L,412L,515L,618L,721L,824L,927L,1030L,1133L,1236L,1339L,1442L,1545L,1648L,1751L,1854L,1957L,2060L,2163L,2266L,2369L,2472L,2575L,2678L,2781L,2884L,2987L,3090L,3193L,3296L,3399L,34102L,35105L,36108L };
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
public class A019551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019551Inst : IEnumerable<long>
{
public static readonly long[] Value=A019551.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019551.Bytes);
public long this[int i]=>Value[i];

public static A019551Inst Instance=new A019551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019552
{
public static readonly long[] Value={ 14L,28L,312L,416L,520L,624L,728L,832L,936L,1040L,1144L,1248L,1352L,1456L,1560L,1664L,1768L,1872L,1976L,2080L,2184L,2288L,2392L,2496L,25100L,26104L,27108L,28112L,29116L,30120L,31124L,32128L,33132L,34136L,35140L,36144L,37148L,38152L,39156L,40160L,41164L };
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
public class A019552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019552Inst : IEnumerable<long>
{
public static readonly long[] Value=A019552.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019552.Bytes);
public long this[int i]=>Value[i];

public static A019552Inst Instance=new A019552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019553
{
public static readonly long[] Value={ 15L,210L,315L,420L,525L,630L,735L,840L,945L,1050L,1155L,1260L,1365L,1470L,1575L,1680L,1785L,1890L,1995L,20100L,21105L,22110L,23115L,24120L,25125L,26130L,27135L,28140L,29145L,30150L,31155L,32160L,33165L,34170L,35175L,36180L,37185L,38190L,39195L,40200L };
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
public class A019553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019553Inst : IEnumerable<long>
{
public static readonly long[] Value=A019553.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019553.Bytes);
public long this[int i]=>Value[i];

public static A019553Inst Instance=new A019553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019554
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,6L,7L,4L,3L,10L,11L,6L,13L,14L,15L,4L,17L,6L,19L,10L,21L,22L,23L,12L,5L,26L,9L,14L,29L,30L,31L,8L,33L,34L,35L,6L,37L,38L,39L,20L,41L,42L,43L,22L,15L,46L,47L,12L,7L,10L,51L,26L,53L,18L,55L,28L,57L,58L,59L,30L,61L,62L,21L,8L,65L,66L,67L,34L,69L,70L,71L,12L,73L,74L,15L,38L,77L };
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
public class A019554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019554Inst : IEnumerable<long>
{
public static readonly long[] Value=A019554.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019554.Bytes);
public long this[int i]=>Value[i];

public static A019554Inst Instance=new A019554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019555
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,6L,7L,2L,3L,10L,11L,6L,13L,14L,15L,4L,17L,6L,19L,10L,21L,22L,23L,6L,5L,26L,3L,14L,29L,30L,31L,4L,33L,34L,35L,6L,37L,38L,39L,10L,41L,42L,43L,22L,15L,46L,47L,12L,7L,10L,51L,26L,53L,6L,55L,14L,57L,58L,59L,30L,61L,62L,21L,4L,65L,66L,67L,34L,69L,70L,71L,6L,73L,74L,15L,38L,77L,78L };
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
public class A019555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019555Inst : IEnumerable<long>
{
public static readonly long[] Value=A019555.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019555.Bytes);
public long this[int i]=>Value[i];

public static A019555Inst Instance=new A019555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019556
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,2L,2L,2L,2L,2L,3L,2L,2L,4L,3L,3L,4L,3L,3L,4L,4L,3L,6L,4L,5L,5L,5L,3L,6L,6L,5L,6L,5L,6L,8L,6L,6L,6L,7L,5L,9L,7L,7L,8L,8L,7L,11L,9L,8L,9L,10L,8L,9L,8L,10L,11L,10L,7L,12L,10L,10L,13L,11L,9L,14L,11L,11L,10L };
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
public class A019556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019556Inst : IEnumerable<long>
{
public static readonly long[] Value=A019556.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019556.Bytes);
public long this[int i]=>Value[i];

public static A019556Inst Instance=new A019556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019557
{
public static readonly long[] Value={ 1L,12L,30L,48L,66L,84L,102L,120L,138L,156L,174L,192L,210L,228L,246L,264L,282L,300L,318L,336L,354L,372L,390L,408L,426L,444L,462L,480L,498L,516L,534L,552L,570L,588L,606L,624L,642L,660L,678L,696L,714L,732L,750L,768L,786L,804L,822L,840L,858L,876L,894L,912L,930L,948L,966L,984L,1002L,1020L,1038L,1056L };
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
public class A019557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019557Inst : IEnumerable<long>
{
public static readonly long[] Value=A019557.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019557.Bytes);
public long this[int i]=>Value[i];

public static A019557Inst Instance=new A019557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019558
{
public static readonly long[] Value={ 1L,48L,384L,1392L,3456L,6960L,12288L,19824L,29952L,43056L,59520L,79728L,104064L,132912L,166656L,205680L,250368L,301104L,358272L,422256L,493440L,572208L,658944L,754032L,857856L,970800L,1093248L,1225584L };
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
public class A019558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019558Inst : IEnumerable<long>
{
public static readonly long[] Value=A019558.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019558.Bytes);
public long this[int i]=>Value[i];

public static A019558Inst Instance=new A019558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019559
{
public static readonly long[] Value={ 4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L,4L,4L,6L,6L,6L };
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
public class A019559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019559Inst : IEnumerable<long>
{
public static readonly long[] Value=A019559.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019559.Bytes);
public long this[int i]=>Value[i];

public static A019559Inst Instance=new A019559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019560
{
public static readonly long[] Value={ 1L,32L,192L,608L,1408L,2720L,4672L,7392L,11008L,15648L,21440L,28512L,36992L,47008L,58688L,72160L,87552L,104992L,124608L,146528L,170880L,197792L,227392L,259808L,295168L,333600L,375232L,420192L,468608L };
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
public class A019560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019560Inst : IEnumerable<long>
{
public static readonly long[] Value=A019560.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019560.Bytes);
public long this[int i]=>Value[i];

public static A019560Inst Instance=new A019560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019561
{
public static readonly long[] Value={ 1L,50L,450L,1970L,5890L,14002L,28610L,52530L,89090L,142130L,216002L,315570L,446210L,613810L,824770L,1086002L,1404930L,1789490L,2248130L,2789810L,3424002L,4160690L,5010370L,5984050L,7093250L,8350002L };
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
public class A019561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019561Inst : IEnumerable<long>
{
public static readonly long[] Value=A019561.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019561.Bytes);
public long this[int i]=>Value[i];

public static A019561Inst Instance=new A019561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019562
{
public static readonly long[] Value={ 1L,72L,912L,5336L,20256L,58728L,142000L,301560L,581184L,1038984L,1749456L,2805528L,4320608L,6430632L,9296112L,13104184L,18070656L,24442056L,32497680L,42551640L,54954912L,70097384L,88409904L };
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
public class A019562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019562Inst : IEnumerable<long>
{
public static readonly long[] Value=A019562.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019562.Bytes);
public long this[int i]=>Value[i];

public static A019562Inst Instance=new A019562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019563
{
public static readonly long[] Value={ 1L,98L,1666L,12642L,59906L,209762L,596610L,1459810L,3188738L,6376034L,11879042L,20889442L,35011074L,56345954L,87588482L,132127842L,194158594L,278799458L,392220290L,541777250L,736156162L,985524066L };
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
public class A019563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019563Inst : IEnumerable<long>
{
public static readonly long[] Value=A019563.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019563.Bytes);
public long this[int i]=>Value[i];

public static A019563Inst Instance=new A019563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019564
{
public static readonly long[] Value={ 1L,128L,2816L,27008L,157184L,658048L,2187520L,6140800L,15158272L,33830016L,69629696L,134110592L,244396544L,425000576L,710003968L,1145628544L,1793234944L,2732779648L,4066763520L,5924704640L };
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
public class A019564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019564Inst : IEnumerable<long>
{
public static readonly long[] Value=A019564.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019564.Bytes);
public long this[int i]=>Value[i];

public static A019564Inst Instance=new A019564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019565
{
public static readonly long[] Value={ 1L,2L,3L,6L,5L,10L,15L,30L,7L,14L,21L,42L,35L,70L,105L,210L,11L,22L,33L,66L,55L,110L,165L,330L,77L,154L,231L,462L,385L,770L,1155L,2310L,13L,26L,39L,78L,65L,130L,195L,390L,91L,182L,273L,546L,455L,910L,1365L,2730L,143L,286L,429L,858L,715L,1430L,2145L,4290L };
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
public class A019565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019565Inst : IEnumerable<long>
{
public static readonly long[] Value=A019565.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019565.Bytes);
public long this[int i]=>Value[i];

public static A019565Inst Instance=new A019565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019566
{
public static readonly BigInteger[] Value={ 0L,9L,198L,3087L,41976L,530865L,6419754L,75308643L,864197532L,-1358024589L,-123580236690L,-2345801446791L,775432077543108L,178553219976533007L,BigInteger.Parse("27956332009875522906"),BigInteger.Parse("3805734210999774512805"),BigInteger.Parse("481583522109989673502704"),BigInteger.Parse("58259362312008979572492603") };
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
public class A019566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019566Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019566.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019566.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019566Inst Instance=new A019566Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019567
{
public static readonly long[] Value={ 1L,2L,3L,6L,4L,6L,10L,14L,5L,18L,10L,12L,21L,26L,9L,30L,6L,22L,9L,30L,27L,8L,11L,10L,24L,50L,12L,18L,14L,12L,55L,50L,7L,18L,34L,46L,14L,74L,24L,26L,33L,20L,78L,86L,29L,90L,18L,18L,48L,98L,33L,10L,45L,70L,15L,24L,60L,38L,29L,78L,12L,84L,41L,110L,8L,84L,26L,134L,12L,46L,35L,36L,68L,146L };
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
public class A019567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019567Inst : IEnumerable<long>
{
public static readonly long[] Value=A019567.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019567.Bytes);
public long this[int i]=>Value[i];

public static A019567Inst Instance=new A019567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019568
{
public static readonly long[] Value={ 2L,3L,7L,12L,16L,24L,31L,39L,47L,44L,60L,71L,79L };
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
public class A019568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019568Inst : IEnumerable<long>
{
public static readonly long[] Value=A019568.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019568.Bytes);
public long this[int i]=>Value[i];

public static A019568Inst Instance=new A019568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019569
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,2L,3L,3L,3L,3L,4L,3L,3L,4L,3L,3L,4L,3L,4L,4L,4L,4L,4L,4L,4L,5L,4L,5L,4L,3L,5L,4L,5L,4L,4L,4L,4L,5L,5L,5L,4L,4L,5L,5L,4L,5L,4L,4L,4L,4L,6L,6L,4L,4L,5L,6L,5L,5L,5L,4L,4L,5L,5L,3L,6L,5L,5L,5L,6L,4L,5L,5L,5L,6L,4L,6L,4L,5L,5L,5L,4L };
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
public class A019569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019569Inst : IEnumerable<long>
{
public static readonly long[] Value=A019569.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019569.Bytes);
public long this[int i]=>Value[i];

public static A019569Inst Instance=new A019569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019570
{
public static readonly long[] Value={ 0L,3L,1L,6L,-1L,-5L,2L };
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
public class A019570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019570Inst : IEnumerable<long>
{
public static readonly long[] Value=A019570.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019570.Bytes);
public long this[int i]=>Value[i];

public static A019570Inst Instance=new A019570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019571
{
public static readonly long[] Value={ 1L,4L,9L,16L,25L,39L,61L,84L,102L,124L,158L,200L,244L,284L,318L,360L,419L,481L,537L,592L,652L,720L,794L,871L,946L,1021L,1105L,1195L,1287L,1380L,1472L,1572L,1680L,1785L,1890L,2002L,2124L,2249L,2365L,2484L,2617L,2753L,2892L,3033L,3168L,3308L,3460L,3619L };
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
public class A019571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019571Inst : IEnumerable<long>
{
public static readonly long[] Value=A019571.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019571.Bytes);
public long this[int i]=>Value[i];

public static A019571Inst Instance=new A019571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019572
{
public static readonly long[] Value={ 1L,4L,9L,17L,27L,40L,61L,85L,106L,132L,167L,202L,237L,279L,322L,366L,420L,478L,534L,592L,654L,723L,798L,870L,940L,1020L,1109L,1197L,1286L,1379L,1474L,1573L,1678L,1787L,1894L,2001L,2119L,2245L,2368L,2491L,2620L,2752L,2888L,3030L,3170L,3311L,3463L,3618L };
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
public class A019572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019572Inst : IEnumerable<long>
{
public static readonly long[] Value=A019572.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019572.Bytes);
public long this[int i]=>Value[i];

public static A019572Inst Instance=new A019572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019573
{
public static readonly long[] Value={ 1L,4L,9L,16L,25L,39L,58L,79L,104L,130L,158L,195L,235L,275L,321L,372L,424L,477L,532L,589L,651L,721L,796L,871L,945L,1022L,1106L,1196L,1285L,1373L,1471L,1577L,1682L,1787L,1892L,2001L,2117L,2238L,2368L,2497L,2620L,2752L,2889L,3025L,3166L,3311L,3463L,3620L };
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
public class A019573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019573Inst : IEnumerable<long>
{
public static readonly long[] Value=A019573.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019573.Bytes);
public long this[int i]=>Value[i];

public static A019573Inst Instance=new A019573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019574
{
public static readonly long[] Value={ 1L,4L,10L,16L,25L,42L,61L,82L,108L,132L,156L,198L,244L,280L,320L,366L,418L,476L,536L,594L,652L,720L,796L,870L,946L,1024L,1104L,1196L,1288L,1374L,1472L,1576L,1678L,1784L,1892L,2008L,2126L,2240L,2366L,2490L,2610L,2752L,2896L,3030L,3170L,3312L,3462L,3620L };
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
public class A019574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019574Inst : IEnumerable<long>
{
public static readonly long[] Value=A019574.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019574.Bytes);
public long this[int i]=>Value[i];

public static A019574Inst Instance=new A019574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019575
{
public static readonly long[] Value={ 1L,2L,2L,6L,18L,3L,24L,180L,48L,4L,120L,2100L,800L,100L,5L,720L,28800L,14700L,2250L,180L,6L,5040L,458640L,301350L,52920L,5292L,294L,7L,40320L,8361360L,6867840L,1342600L,153664L,10976L,448L,8L,362880L,172141200L,172872000L,36991080L,4644864L,387072L,20736L,648L,9L };
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
public class A019575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019575Inst : IEnumerable<long>
{
public static readonly long[] Value=A019575.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019575.Bytes);
public long this[int i]=>Value[i];

public static A019575Inst Instance=new A019575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019576
{
public static readonly long[] Value={ 1L,1L,1L,2L,6L,1L,6L,45L,12L,1L,24L,420L,160L,20L,1L,120L,4800L,2450L,375L,30L,1L,720L,65520L,43050L,7560L,756L,42L,1L,5040L,1045170L,858480L,167825L,19208L,1372L,56L,1L,40320L,19126800L,19208000L,4110120L,516096L,43008L,2304L,72L,1L };
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
public class A019576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019576Inst : IEnumerable<long>
{
public static readonly long[] Value=A019576.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019576.Bytes);
public long this[int i]=>Value[i];

public static A019576Inst Instance=new A019576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019577
{
public static readonly BigInteger[] Value={ 0L,1L,6L,45L,420L,4800L,65520L,1045170L,19126800L,395448480L,9120988800L,232248416400L,6471820555200L,195912193276800L,6402199349145600L,224636583525354000L,8423131243022496000L,BigInteger.Parse("336138596955120960000"),BigInteger.Parse("14224375944427993344000"),BigInteger.Parse("636224790017466730080000") };
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
public class A019577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019577Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019577.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019577.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019577Inst Instance=new A019577Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019578
{
public static readonly long[] Value={ 1L,12L,160L,2450L,43050L,858480L,19208000L };
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
public class A019578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019578Inst : IEnumerable<long>
{
public static readonly long[] Value=A019578.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019578.Bytes);
public long this[int i]=>Value[i];

public static A019578Inst Instance=new A019578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019579
{
public static readonly long[] Value={ 2L,45L,160L,375L,756L,1372L,2304L,3645L,5500L,7986L,11232L,15379L,20580L,27000L,34816L,44217L,55404L,68590L,84000L,101871L,122452L,146004L,172800L,203125L,237276L,275562L,318304L,365835L,418500L,476656L,540672L,610929L,687820L,771750L,863136L,962407L };
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
public class A019579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019579Inst : IEnumerable<long>
{
public static readonly long[] Value=A019579.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019579.Bytes);
public long this[int i]=>Value[i];

public static A019579Inst Instance=new A019579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019580
{
public static readonly long[] Value={ 1L,20L,375L,7560L,167825L,4110120L };
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
public class A019580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019580Inst : IEnumerable<long>
{
public static readonly long[] Value=A019580.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019580.Bytes);
public long this[int i]=>Value[i];

public static A019580Inst Instance=new A019580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019581
{
public static readonly BigInteger[] Value={ 0L,2L,18L,180L,2100L,28800L,458640L,8361360L,172141200L,3954484800L,100330876800L,2786980996800L,84133667217600L,2742770705875200L,96032990237184000L,3594185336405664000L,BigInteger.Parse("143193231131382432000"),BigInteger.Parse("6050494745192177280000"),BigInteger.Parse("270263142944131873536000") };
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
public class A019581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019581Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019581.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019581.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019581Inst Instance=new A019581Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019582
{
public static readonly long[] Value={ 0L,0L,1L,12L,54L,160L,375L,756L,1372L,2304L,3645L,5500L,7986L,11232L,15379L,20580L,27000L,34816L,44217L,55404L,68590L,84000L,101871L,122452L,146004L,172800L,203125L,237276L,275562L,318304L,365835L,418500L,476656L,540672L,610929L,687820L,771750L,863136L };
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
public class A019582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019582Inst : IEnumerable<long>
{
public static readonly long[] Value=A019582.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019582.Bytes);
public long this[int i]=>Value[i];

public static A019582Inst Instance=new A019582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019583
{
public static readonly long[] Value={ 0L,0L,1L,24L,162L,640L,1875L,4536L,9604L,18432L,32805L,55000L,87846L,134784L,199927L,288120L,405000L,557056L,751689L,997272L,1303210L,1680000L,2139291L,2693944L,3358092L,4147200L,5078125L,6169176L };
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
public class A019583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019583Inst : IEnumerable<long>
{
public static readonly long[] Value=A019583.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019583.Bytes);
public long this[int i]=>Value[i];

public static A019583Inst Instance=new A019583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019584
{
public static readonly long[] Value={ 0L,0L,1L,18L,108L,400L,1125L,2646L,5488L,10368L,18225L,30250L,47916L,73008L,107653L,154350L,216000L,295936L,397953L,526338L,685900L,882000L,1120581L,1408198L,1752048L,2160000L,2640625L,3203226L };
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
public class A019584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019584Inst : IEnumerable<long>
{
public static readonly long[] Value=A019584.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019584.Bytes);
public long this[int i]=>Value[i];

public static A019584Inst Instance=new A019584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019585
{
public static readonly long[] Value={ 0L,-2L,-3L,-7L,-6L,-12L,-9L };
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
public class A019585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019585Inst : IEnumerable<long>
{
public static readonly long[] Value=A019585.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019585.Bytes);
public long this[int i]=>Value[i];

public static A019585Inst Instance=new A019585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019586
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,2L,1L,0L,3L,2L,1L,4L,0L,5L,3L,2L,6L,1L,7L,4L,0L,8L,5L,3L,9L,2L,10L,6L,1L,11L,7L,4L,12L,0L,13L,8L,5L,14L,3L,15L,9L,2L,16L,10L,6L,17L,1L,18L,11L,7L,19L,4L,20L,12L,0L,21L,13L,8L,22L,5L,23L,14L,3L,24L,15L,9L,25L,2L,26L,16L,10L,27L,6L,28L,17L,1L,29L,18L,11L,30L,7L,31L,19L,4L,32L,20L,12L };
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
public class A019586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019586Inst : IEnumerable<long>
{
public static readonly long[] Value=A019586.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019586.Bytes);
public long this[int i]=>Value[i];

public static A019586Inst Instance=new A019586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019587
{
public static readonly long[] Value={ 1L,1L,3L,2L,1L,5L,3L,8L,5L,2L,9L,5L,1L,10L,5L,15L,9L,3L,15L,8L,21L,13L,5L,20L,11L,2L,19L,9L,27L,16L,5L,25L,13L,1L,23L,10L,33L,19L,5L,30L,15L,41L,25L,9L,37L,20L,3L,33L,15L,46L,27L,8L,41L,21L,55L,34L,13L,49L,27L,5L,43L,20L,59L,35L,11L,52L,27L,2L,45L,19L,63L,36L,9L,55L,27L,74L,45L,16L,65L };
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
public class A019587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019587Inst : IEnumerable<long>
{
public static readonly long[] Value=A019587.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019587.Bytes);
public long this[int i]=>Value[i];

public static A019587Inst Instance=new A019587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019588
{
public static readonly long[] Value={ 1L,2L,1L,3L,5L,2L,5L,1L,5L,9L,3L,8L,13L,5L,11L,2L,9L,16L,5L,13L,1L,10L,19L,5L,15L,25L,9L,20L,3L,15L,27L,8L,21L,34L,13L,27L,5L,20L,35L,11L,27L,2L,19L,36L,9L,27L,45L,16L,35L,5L,25L,45L,13L,34L,1L,23L,45L,10L,33L,56L,19L,43L,5L,30L,55L,15L,41L,67L,25L,52L,9L,37L,65L,20L,49L,3L,33L,63L,15L };
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
public class A019588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019588Inst : IEnumerable<long>
{
public static readonly long[] Value=A019588.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019588.Bytes);
public long this[int i]=>Value[i];

public static A019588Inst Instance=new A019588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019589
{
public static readonly long[] Value={ 1L,1L,2L,5L,16L,59L,246L,1105L,5270L,26231L,135036L,713898L,3857113L };
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
public class A019589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019589Inst : IEnumerable<long>
{
public static readonly long[] Value=A019589.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019589.Bytes);
public long this[int i]=>Value[i];

public static A019589Inst Instance=new A019589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019590
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
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
public class A019590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019590Inst : IEnumerable<long>
{
public static readonly long[] Value=A019590.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019590.Bytes);
public long this[int i]=>Value[i];

public static A019590Inst Instance=new A019590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019591
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,1L,0L,2L,3L,0L,1L,4L,0L,2L,4L,0L,2L,3L,0L,1L,4L,0L,2L,4L,0L,2L,6L,0L,1L,3L,0L,2L,5L,0L,2L,6L,0L,1L,8L,0L,2L,3L,0L,2L,6L,0L,1L,4L,0L,2L,4L,0L,2L,3L,0L,1L,4L,0L,2L,8L,0L,2L,8L,0L,1L,3L,0L,2L,5L,0L,2L,7L,0L,1L,8L,0L,2L,3L,0L,2L,8L,0L,1L,4L,0L,2L,4L,0L,2L,3L,0L,1L,4L,0L,2L,8L,0L,2L,6L };
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
public class A019591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019591Inst : IEnumerable<long>
{
public static readonly long[] Value=A019591.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019591.Bytes);
public long this[int i]=>Value[i];

public static A019591Inst Instance=new A019591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019592
{
public static readonly long[] Value={ 1L,2L,7L,12L,17L,36L,41L,83L,275L,284L,307L,443L,444L,775L,869L,2523L,3485L,4069L,5772L,9689L,16403L,30902L,53359L,83792L,122933L,1090845L,1473689L,1510781L,1740110L,2652867L,2693291L,3008386L,3085790L,51051449L,55594816L };
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
public class A019592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019592Inst : IEnumerable<long>
{
public static readonly long[] Value=A019592.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019592.Bytes);
public long this[int i]=>Value[i];

public static A019592Inst Instance=new A019592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019593
{
public static readonly long[] Value={ 2L,22L,38L,114L,219L,354L,3035L,6182L,6502L,11935L,22946L,33122L,58975L,137394L,865634L,1060511L,2604630L,3041138L,13633887L,30516651L,51664754L,73000543L,126052390L,469204879L,12224092843L,14479084326L,19560684367L };
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
public class A019593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019593Inst : IEnumerable<long>
{
public static readonly long[] Value=A019593.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019593.Bytes);
public long this[int i]=>Value[i];

public static A019593Inst Instance=new A019593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019594
{
public static readonly long[] Value={ 1L,3L,2L,5L,8L,5L,9L,5L,10L,15L,9L,15L,21L,13L,20L,11L,19L,27L,16L,25L,13L,23L,33L,19L,30L,41L,25L,37L,20L,33L,46L,27L,41L,55L,34L,49L,27L,43L,59L,35L,52L,27L,45L,63L,36L,55L,74L,45L,65L,35L,56L,77L,45L,67L,34L,57L,80L,45L,69L,93L,56L,81L,43L };
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
public class A019594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019594Inst : IEnumerable<long>
{
public static readonly long[] Value=A019594.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019594.Bytes);
public long this[int i]=>Value[i];

public static A019594Inst Instance=new A019594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019595
{
public static readonly long[] Value={ 1L,2L,3L,7L,14L,30L,33L,66L,177L,227L,686L,932L,1283L,1623L,1827L,3603L,7429L,15750L,16438L,18650L,22139L,22967L,31412L,35482L,36075L,62639L,128086L,175642L,201758L,239985L,261506L,301601L,786609L,853738L,2283613L,2510846L,2568758L };
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
public class A019595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019595Inst : IEnumerable<long>
{
public static readonly long[] Value=A019595.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019595.Bytes);
public long this[int i]=>Value[i];

public static A019595Inst Instance=new A019595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019596
{
public static readonly long[] Value={ 2L,4L,47L,233L,477L,538L,1163L,4544L,23938L,47952L,74329L,385194L,424332L,838758L,3601963L,8880674L,9376182L,10177957L,10622608L,12051969L,14306604L,23190118L,25373883L,28661729L,138953419L,1150488807L,1204511338L };
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
public class A019596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019596Inst : IEnumerable<long>
{
public static readonly long[] Value=A019596.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019596.Bytes);
public long this[int i]=>Value[i];

public static A019596Inst Instance=new A019596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019597
{
public static readonly long[] Value={ 1L,7L,0L,7L,9L,4L,6L,8L,4L,4L,5L,3L,4L,7L,1L,3L,4L,1L,3L,0L,9L,2L,7L,1L,0L,1L,7L,3L,9L,0L,9L,3L,1L,4L,8L,9L,9L,0L,0L,6L,9L,7L,7L,7L,0L,7L,1L,5L,3L,0L,2L,2L,9L,9L,2L,3L,7L,5L,9L,2L,0L,2L,2L,6L,0L,3L,5L,8L,4L,5L,7L,2L,2L,2L,3L,1L,4L,6L,6L,1L,6L,1L,5L,1L,4L,5L,1L,2L,7L,7L,3L,9L,4L,2L,0L,9L,4L,7L,8L,8L,7L,8L,2L,7L,5L };
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
public class A019597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019597Inst : IEnumerable<long>
{
public static readonly long[] Value=A019597.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019597.Bytes);
public long this[int i]=>Value[i];

public static A019597Inst Instance=new A019597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019598
{
public static readonly long[] Value={ 5L,6L,9L,3L,1L,5L,6L,1L,4L,8L,4L,4L,9L,0L,4L,4L,7L,1L,0L,3L,0L,9L,0L,3L,3L,9L,1L,3L,0L,3L,1L,0L,4L,9L,6L,6L,3L,3L,5L,6L,5L,9L,2L,3L,5L,7L,1L,7L,6L,7L,4L,3L,3L,0L,7L,9L,1L,9L,7L,3L,4L,0L,8L,6L,7L,8L,6L,1L,5L,2L,4L,0L,7L,4L,3L,8L,2L,2L,0L,5L,3L,8L,3L,8L,1L,7L,0L,9L,2L,4L,6L,4L,7L,3L,6L,4L,9L,2L,9L };
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
public class A019598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019598Inst : IEnumerable<long>
{
public static readonly long[] Value=A019598.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019598.Bytes);
public long this[int i]=>Value[i];

public static A019598Inst Instance=new A019598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019599
{
public static readonly long[] Value={ 3L,4L,1L,5L,8L,9L,3L,6L,8L,9L,0L,6L,9L,4L,2L,6L,8L,2L,6L,1L,8L,5L,4L,2L,0L,3L,4L,7L,8L,1L,8L,6L,2L,9L,7L,9L,8L,0L,1L,3L,9L,5L,5L,4L,1L,4L,3L,0L,6L,0L,4L,5L,9L,8L,4L,7L,5L,1L,8L,4L,0L,4L,5L,2L,0L,7L,1L,6L,9L,1L,4L,4L,4L,4L,6L,2L,9L,3L,2L,3L,2L,3L,0L,2L,9L,0L,2L,5L,5L,4L,7L,8L,8L,4L,1L,8L,9L,5L,7L };
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
public class A019599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019599Inst : IEnumerable<long>
{
public static readonly long[] Value=A019599.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019599.Bytes);
public long this[int i]=>Value[i];

public static A019599Inst Instance=new A019599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019600
{
public static readonly long[] Value={ 2L,4L,3L,9L,9L,2L,4L,0L,6L,3L,6L,2L,1L,0L,1L,9L,1L,6L,1L,5L,6L,1L,0L,1L,4L,5L,3L,4L,1L,5L,6L,1L,6L,4L,1L,4L,1L,4L,3L,8L,5L,3L,9L,5L,8L,1L,6L,4L,7L,1L,7L,5L,7L,0L,3L,3L,9L,4L,1L,7L,1L,7L,5L,1L,4L,7L,9L,7L,7L,9L,6L,0L,3L,1L,8L,7L,8L,0L,8L,8L,0L,2L,1L,6L,3L,5L,8L,9L,6L,7L,7L,0L,6L,0L,1L,3L,5L,4L,1L };
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
public class A019600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019600Inst : IEnumerable<long>
{
public static readonly long[] Value=A019600.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019600.Bytes);
public long this[int i]=>Value[i];

public static A019600Inst Instance=new A019600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019601
{
public static readonly long[] Value={ 1L,8L,9L,7L,7L,1L,8L,7L,1L,6L,1L,4L,9L,6L,8L,1L,5L,7L,0L,1L,0L,3L,0L,1L,1L,3L,0L,4L,3L,4L,3L,6L,8L,3L,2L,2L,1L,1L,1L,8L,8L,6L,4L,1L,1L,9L,0L,5L,8L,9L,1L,4L,4L,3L,5L,9L,7L,3L,2L,4L,4L,6L,9L,5L,5L,9L,5L,3L,8L,4L,1L,3L,5L,8L,1L,2L,7L,4L,0L,1L,7L,9L,4L,6L,0L,5L,6L,9L,7L,4L,8L,8L,2L,4L,5L,4L,9L,7L,6L };
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
public class A019601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019601Inst : IEnumerable<long>
{
public static readonly long[] Value=A019601.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019601.Bytes);
public long this[int i]=>Value[i];

public static A019601Inst Instance=new A019601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019602
{
public static readonly long[] Value={ 1L,5L,5L,2L,6L,7L,8L,9L,4L,9L,5L,7L,7L,0L,1L,2L,1L,9L,3L,7L,2L,0L,6L,4L,5L,6L,1L,2L,6L,4L,4L,8L,3L,1L,7L,2L,6L,3L,6L,9L,9L,7L,9L,7L,3L,3L,7L,7L,5L,4L,7L,5L,4L,4L,7L,6L,1L,4L,4L,7L,2L,9L,3L,2L,7L,5L,9L,8L,5L,9L,7L,4L,7L,4L,8L,3L,1L,5L,1L,0L,5L,5L,9L,2L,2L,2L,8L,4L,3L,3L,9L,9L,4L,7L,3L,5L,8L,8L,9L };
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
public class A019602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019602Inst : IEnumerable<long>
{
public static readonly long[] Value=A019602.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019602.Bytes);
public long this[int i]=>Value[i];

public static A019602Inst Instance=new A019602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019603
{
public static readonly long[] Value={ 1L,3L,1L,3L,8L,0L,5L,2L,6L,5L,0L,2L,6L,7L,0L,2L,6L,2L,5L,4L,5L,5L,9L,3L,0L,9L,0L,3L,0L,0L,7L,1L,6L,5L,3L,0L,6L,9L,2L,8L,4L,4L,4L,3L,9L,0L,1L,1L,7L,7L,0L,9L,9L,9L,4L,1L,3L,5L,3L,2L,3L,2L,5L,0L,7L,9L,6L,8L,0L,4L,4L,0L,1L,7L,1L,6L,5L,1L,2L,4L,3L,1L,9L,3L,4L,2L,4L,0L,5L,9L,5L,3L,4L,0L,0L,7L,2L,9L,1L };
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
public class A019603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019603Inst : IEnumerable<long>
{
public static readonly long[] Value=A019603.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019603.Bytes);
public long this[int i]=>Value[i];

public static A019603Inst Instance=new A019603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019604
{
public static readonly long[] Value={ 1L,1L,3L,8L,6L,3L,1L,2L,2L,9L,6L,8L,9L,8L,0L,8L,9L,4L,2L,0L,6L,1L,8L,0L,6L,7L,8L,2L,6L,0L,6L,2L,0L,9L,9L,3L,2L,6L,7L,1L,3L,1L,8L,4L,7L,1L,4L,3L,5L,3L,4L,8L,6L,6L,1L,5L,8L,3L,9L,4L,6L,8L,1L,7L,3L,5L,7L,2L,3L,0L,4L,8L,1L,4L,8L,7L,6L,4L,4L,1L,0L,7L,6L,7L,6L,3L,4L,1L,8L,4L,9L,2L,9L,4L,7L,2L,9L,8L,5L };
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
public class A019604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019604Inst : IEnumerable<long>
{
public static readonly long[] Value=A019604.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019604.Bytes);
public long this[int i]=>Value[i];

public static A019604Inst Instance=new A019604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019605
{
public static readonly long[] Value={ 1L,0L,0L,4L,6L,7L,4L,6L,1L,4L,4L,3L,2L,1L,8L,4L,3L,6L,0L,6L,4L,2L,7L,7L,0L,6L,9L,0L,5L,3L,4L,8L,9L,1L,1L,1L,7L,0L,6L,2L,9L,2L,8L,0L,6L,3L,0L,3L,1L,1L,8L,9L,9L,9L,5L,5L,1L,5L,2L,4L,7L,1L,9L,1L,7L,8L,5L,7L,9L,1L,6L,0L,1L,3L,1L,2L,6L,2L,7L,1L,5L,3L,8L,3L,2L,0L,6L,6L,3L,3L,7L,6L,1L,2L,9L,9L,6L,9L,3L };
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
public class A019605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019605Inst : IEnumerable<long>
{
public static readonly long[] Value=A019605.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019605.Bytes);
public long this[int i]=>Value[i];

public static A019605Inst Instance=new A019605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019606
{
public static readonly long[] Value={ 8L,9L,8L,9L,1L,9L,3L,9L,1L,8L,6L,0L,3L,7L,5L,4L,8L,0L,5L,7L,5L,1L,1L,0L,6L,1L,7L,8L,4L,7L,0L,0L,7L,8L,4L,1L,5L,8L,2L,6L,1L,9L,8L,4L,5L,8L,7L,0L,0L,1L,2L,1L,0L,1L,2L,5L,0L,4L,8L,4L,3L,2L,9L,4L,9L,2L,5L,5L,0L,3L,8L,0L,1L,2L,1L,8L,2L,4L,2L,9L,5L,5L,3L,3L,9L,5L,4L,0L,9L,1L,5L,4L,8L,4L,7L,0L,9L,4L,1L };
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
public class A019606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019606Inst : IEnumerable<long>
{
public static readonly long[] Value=A019606.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019606.Bytes);
public long this[int i]=>Value[i];

public static A019606Inst Instance=new A019606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019607
{
public static readonly long[] Value={ 8L,1L,3L,3L,0L,8L,0L,2L,1L,2L,0L,7L,0L,0L,6L,3L,8L,7L,1L,8L,7L,0L,0L,4L,8L,4L,4L,7L,1L,8L,7L,2L,1L,3L,8L,0L,4L,7L,9L,5L,1L,3L,1L,9L,3L,8L,8L,2L,3L,9L,1L,9L,0L,1L,1L,3L,1L,3L,9L,0L,5L,8L,3L,8L,2L,6L,5L,9L,3L,2L,0L,1L,0L,6L,2L,6L,0L,2L,9L,3L,4L,0L,5L,4L,5L,2L,9L,8L,9L,2L,3L,5L,3L,3L,7L,8L,4L,7L,0L };
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
public class A019607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019607Inst : IEnumerable<long>
{
public static readonly long[] Value=A019607.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019607.Bytes);
public long this[int i]=>Value[i];

public static A019607Inst Instance=new A019607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019608
{
public static readonly long[] Value={ 7L,4L,2L,5L,8L,5L,5L,8L,4L,5L,8L,0L,3L,1L,0L,1L,7L,9L,6L,0L,5L,5L,2L,6L,1L,6L,2L,5L,6L,9L,2L,6L,7L,3L,4L,7L,3L,9L,4L,3L,3L,8L,1L,3L,3L,5L,4L,4L,7L,9L,2L,6L,0L,5L,3L,8L,0L,8L,3L,4L,8L,8L,0L,8L,8L,5L,1L,5L,0L,3L,1L,4L,0L,1L,3L,6L,8L,0L,9L,3L,9L,7L,8L,8L,9L,1L,8L,5L,9L,7L,3L,6L,6L,1L,2L,8L,1L,6L,9L };
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
public class A019608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019608Inst : IEnumerable<long>
{
public static readonly long[] Value=A019608.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019608.Bytes);
public long this[int i]=>Value[i];

public static A019608Inst Instance=new A019608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019609
{
public static readonly long[] Value={ 8L,5L,3L,9L,7L,3L,4L,2L,2L,2L,6L,7L,3L,5L,6L,7L,0L,6L,5L,4L,6L,3L,5L,5L,0L,8L,6L,9L,5L,4L,6L,5L,7L,4L,4L,9L,5L,0L,3L,4L,8L,8L,8L,5L,3L,5L,7L,6L,5L,1L,1L,4L,9L,6L,1L,8L,7L,9L,6L,0L,1L,1L,3L,0L,1L,7L,9L,2L,2L,8L,6L,1L,1L,1L,5L,7L,3L,3L,0L,8L,0L,7L,5L,7L,2L,5L,6L,3L,8L,6L,9L,7L,1L,0L,4L,7L,3L,9L,4L };
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
public class A019609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019609Inst : IEnumerable<long>
{
public static readonly long[] Value=A019609.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019609.Bytes);
public long this[int i]=>Value[i];

public static A019609Inst Instance=new A019609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019610
{
public static readonly long[] Value={ 4L,2L,6L,9L,8L,6L,7L,1L,1L,1L,3L,3L,6L,7L,8L,3L,5L,3L,2L,7L,3L,1L,7L,7L,5L,4L,3L,4L,7L,7L,3L,2L,8L,7L,2L,4L,7L,5L,1L,7L,4L,4L,4L,2L,6L,7L,8L,8L,2L,5L,5L,7L,4L,8L,0L,9L,3L,9L,8L,0L,0L,5L,6L,5L,0L,8L,9L,6L,1L,4L,3L,0L,5L,5L,7L,8L,6L,6L,5L,4L,0L,3L,7L,8L,6L,2L,8L,1L,9L,3L,4L,8L,5L,5L,2L,3L,6L,9L,7L };
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
public class A019610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019610Inst : IEnumerable<long>
{
public static readonly long[] Value=A019610.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019610.Bytes);
public long this[int i]=>Value[i];

public static A019610Inst Instance=new A019610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019611
{
public static readonly long[] Value={ 2L,8L,4L,6L,5L,7L,8L,0L,7L,4L,2L,2L,4L,5L,2L,2L,3L,5L,5L,1L,5L,4L,5L,1L,6L,9L,5L,6L,5L,1L,5L,5L,2L,4L,8L,3L,1L,6L,7L,8L,2L,9L,6L,1L,7L,8L,5L,8L,8L,3L,7L,1L,6L,5L,3L,9L,5L,9L,8L,6L,7L,0L,4L,3L,3L,9L,3L,0L,7L,6L,2L,0L,3L,7L,1L,9L,1L,1L,0L,2L,6L,9L,1L,9L,0L,8L,5L,4L,6L,2L,3L,2L,3L,6L,8L,2L,4L,6L,4L };
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
public class A019611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019611Inst : IEnumerable<long>
{
public static readonly long[] Value=A019611.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019611.Bytes);
public long this[int i]=>Value[i];

public static A019611Inst Instance=new A019611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019612
{
public static readonly long[] Value={ 2L,1L,3L,4L,9L,3L,3L,5L,5L,5L,6L,6L,8L,3L,9L,1L,7L,6L,6L,3L,6L,5L,8L,8L,7L,7L,1L,7L,3L,8L,6L,6L,4L,3L,6L,2L,3L,7L,5L,8L,7L,2L,2L,1L,3L,3L,9L,4L,1L,2L,7L,8L,7L,4L,0L,4L,6L,9L,9L,0L,0L,2L,8L,2L,5L,4L,4L,8L,0L,7L,1L,5L,2L,7L,8L,9L,3L,3L,2L,7L,0L,1L,8L,9L,3L,1L,4L,0L,9L,6L,7L,4L,2L,7L,6L,1L,8L,4L,8L };
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
public class A019612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019612Inst : IEnumerable<long>
{
public static readonly long[] Value=A019612.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019612.Bytes);
public long this[int i]=>Value[i];

public static A019612Inst Instance=new A019612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019613
{
public static readonly long[] Value={ 1L,20L,273L,3172L,33809L,342132L,3348241L,32033924L,301669137L,2808831124L,25937190929L,238042888356L,2174659962385L,19797924540596L,179763483454737L,1628947562960068L,14738065844679953L,133185374228264148L };
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
public class A019613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019613Inst : IEnumerable<long>
{
public static readonly long[] Value=A019613.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019613.Bytes);
public long this[int i]=>Value[i];

public static A019613Inst Instance=new A019613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019630
{
public static readonly long[] Value={ 3L,8L,8L,1L,6L,9L,7L,3L,7L,3L,9L,4L,2L,5L,3L,0L,4L,8L,4L,3L,0L,1L,6L,1L,4L,0L,3L,1L,6L,1L,2L,0L,7L,9L,3L,1L,5L,9L,2L,4L,9L,4L,9L,3L,3L,4L,4L,3L,8L,6L,8L,8L,6L,1L,9L,0L,3L,6L,1L,8L,2L,3L,3L,1L,8L,9L,9L,6L,4L,9L,3L,6L,8L,7L,0L,7L,8L,7L,7L,6L,3L,9L,8L,0L,5L,7L,1L,0L,8L,4L,9L,8L,6L,8L,3L,9L,7L,2L,4L };
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
public class A019630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019630Inst : IEnumerable<long>
{
public static readonly long[] Value=A019630.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019630.Bytes);
public long this[int i]=>Value[i];

public static A019630Inst Instance=new A019630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019631
{
public static readonly long[] Value={ 3L,7L,1L,2L,9L,2L,7L,9L,2L,2L,9L,0L,1L,5L,5L,0L,8L,9L,8L,0L,2L,7L,6L,3L,0L,8L,1L,2L,8L,4L,6L,3L,3L,6L,7L,3L,6L,9L,7L,1L,6L,9L,0L,6L,6L,7L,7L,2L,3L,9L,6L,3L,0L,2L,6L,9L,0L,4L,1L,7L,4L,4L,0L,4L,4L,2L,5L,7L,5L,1L,5L,7L,0L,0L,6L,8L,4L,0L,4L,6L,9L,8L,9L,4L,4L,5L,9L,2L,9L,8L,6L,8L,3L,0L,6L,4L,0L,8L,4L };
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
public class A019631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019631Inst : IEnumerable<long>
{
public static readonly long[] Value=A019631.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019631.Bytes);
public long this[int i]=>Value[i];

public static A019631Inst Instance=new A019631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019632
{
public static readonly long[] Value={ 3L,5L,5L,8L,2L,2L,2L,5L,9L,2L,7L,8L,0L,6L,5L,2L,9L,4L,3L,9L,4L,3L,1L,4L,6L,1L,9L,5L,6L,4L,4L,4L,0L,6L,0L,3L,9L,5L,9L,7L,8L,7L,0L,2L,2L,3L,2L,3L,5L,4L,6L,4L,5L,6L,7L,4L,4L,9L,8L,3L,3L,8L,0L,4L,2L,4L,1L,3L,4L,5L,2L,5L,4L,6L,4L,8L,8L,8L,7L,8L,3L,6L,4L,8L,8L,5L,6L,8L,2L,7L,9L,0L,4L,6L,0L,3L,0L,8L,0L };
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
public class A019632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019632Inst : IEnumerable<long>
{
public static readonly long[] Value=A019632.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019632.Bytes);
public long this[int i]=>Value[i];

public static A019632Inst Instance=new A019632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019633
{
public static readonly long[] Value={ 4L,1L,3L,2L,7L,3L,1L,3L,5L,4L,1L,2L,2L,4L,9L,2L,9L,3L,8L,4L,6L,9L,3L,9L,1L,8L,8L,4L,2L,9L,9L,8L,5L,2L,6L,4L,9L,4L,4L,5L,5L,2L,1L,9L,1L,6L,9L,9L,1L,3L,0L,8L,4L,5L,1L,5L,5L,6L,6L,5L,1L,2L,5L,3L,7L,9L,7L,9L,5L,7L,9L,2L,8L,5L,1L,3L,4L,1L,7L,0L,3L,2L,3L,6L,2L,5L,2L,0L,3L,6L,2L,4L,5L,5L,4L,6L,6L,2L,8L };
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
public class A019633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019633Inst : IEnumerable<long>
{
public static readonly long[] Value=A019633.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019633.Bytes);
public long this[int i]=>Value[i];

public static A019633Inst Instance=new A019633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019634
{
public static readonly long[] Value={ 1L,3L,7L,7L,5L,7L,7L,1L,1L,8L,0L,4L,0L,8L,3L,0L,9L,7L,9L,4L,8L,9L,7L,9L,7L,2L,9L,4L,7L,6L,6L,6L,1L,7L,5L,4L,9L,8L,1L,5L,1L,7L,3L,9L,7L,2L,3L,3L,0L,4L,3L,6L,1L,5L,0L,5L,1L,8L,8L,8L,3L,7L,5L,1L,2L,6L,5L,9L,8L,5L,9L,7L,6L,1L,7L,1L,1L,3L,9L,0L,1L,0L,7L,8L,7L,5L,0L,6L,7L,8L,7L,4L,8L,5L,1L,5L,5L,4L,2L };
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
public class A019634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019634Inst : IEnumerable<long>
{
public static readonly long[] Value=A019634.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019634.Bytes);
public long this[int i]=>Value[i];

public static A019634Inst Instance=new A019634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019635
{
public static readonly long[] Value={ 8L,2L,6L,5L,4L,6L,2L,7L,0L,8L,2L,4L,4L,9L,8L,5L,8L,7L,6L,9L,3L,8L,7L,8L,3L,7L,6L,8L,5L,9L,9L,7L,0L,5L,2L,9L,8L,8L,9L,1L,0L,4L,3L,8L,3L,3L,9L,8L,2L,6L,1L,6L,9L,0L,3L,1L,1L,3L,3L,0L,2L,5L,0L,7L,5L,9L,5L,9L,1L,5L,8L,5L,7L,0L,2L,6L,8L,3L,4L,0L,6L,4L,7L,2L,5L,0L,4L,0L,7L,2L,4L,9L,1L,0L,9L,3L,2L,5L,6L };
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
public class A019635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019635Inst : IEnumerable<long>
{
public static readonly long[] Value=A019635.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019635.Bytes);
public long this[int i]=>Value[i];

public static A019635Inst Instance=new A019635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019636
{
public static readonly long[] Value={ 5L,9L,0L,3L,9L,0L,1L,9L,3L,4L,4L,6L,0L,7L,0L,4L,1L,9L,7L,8L,1L,3L,4L,1L,6L,9L,7L,7L,5L,7L,1L,2L,1L,8L,0L,7L,0L,6L,3L,6L,4L,5L,9L,8L,8L,1L,4L,1L,6L,1L,5L,4L,9L,3L,0L,7L,9L,5L,2L,1L,6L,0L,7L,6L,8L,5L,4L,2L,2L,5L,6L,1L,2L,1L,6L,2L,0L,2L,4L,3L,3L,1L,9L,4L,6L,4L,5L,7L,6L,6L,0L,6L,5L,0L,6L,6L,6L,1L,1L };
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
public class A019636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019636Inst : IEnumerable<long>
{
public static readonly long[] Value=A019636.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019636.Bytes);
public long this[int i]=>Value[i];

public static A019636Inst Instance=new A019636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019637
{
public static readonly long[] Value={ 4L,5L,9L,1L,9L,2L,3L,7L,2L,6L,8L,0L,2L,7L,6L,9L,9L,3L,1L,6L,3L,2L,6L,5L,7L,6L,4L,9L,2L,2L,2L,0L,5L,8L,4L,9L,9L,3L,8L,3L,9L,1L,3L,2L,4L,1L,1L,0L,1L,4L,5L,3L,8L,3L,5L,0L,6L,2L,9L,4L,5L,8L,3L,7L,5L,5L,3L,2L,8L,6L,5L,8L,7L,2L,3L,7L,1L,3L,0L,0L,3L,5L,9L,5L,8L,3L,5L,5L,9L,5L,8L,2L,8L,3L,8L,5L,1L,4L,2L };
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
public class A019637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019637Inst : IEnumerable<long>
{
public static readonly long[] Value=A019637.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019637.Bytes);
public long this[int i]=>Value[i];

public static A019637Inst Instance=new A019637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019638
{
public static readonly long[] Value={ 3L,7L,5L,7L,0L,2L,8L,5L,0L,3L,7L,4L,7L,7L,2L,0L,8L,5L,3L,1L,5L,3L,9L,9L,2L,6L,2L,2L,0L,9L,0L,7L,7L,5L,1L,3L,5L,8L,5L,9L,5L,6L,5L,3L,7L,9L,0L,8L,3L,0L,0L,7L,6L,8L,3L,2L,3L,3L,3L,1L,9L,3L,2L,1L,6L,3L,4L,5L,0L,7L,2L,0L,7L,7L,3L,9L,4L,7L,0L,0L,2L,9L,4L,2L,0L,4L,7L,3L,0L,5L,6L,7L,7L,7L,6L,9L,6L,6L,2L };
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
public class A019638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019638Inst : IEnumerable<long>
{
public static readonly long[] Value=A019638.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019638.Bytes);
public long this[int i]=>Value[i];

public static A019638Inst Instance=new A019638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019639
{
public static readonly long[] Value={ 3L,1L,7L,9L,0L,2L,4L,1L,1L,8L,5L,5L,5L,7L,6L,3L,7L,9L,8L,8L,2L,2L,6L,0L,9L,1L,4L,1L,7L,6L,9L,1L,1L,7L,4L,2L,2L,6L,5L,0L,4L,0L,1L,4L,7L,4L,6L,0L,8L,6L,9L,8L,8L,0L,8L,8L,8L,9L,7L,3L,1L,7L,3L,3L,6L,9L,0L,7L,3L,6L,8L,6L,8L,0L,8L,7L,2L,4L,3L,8L,7L,1L,0L,4L,8L,0L,9L,2L,5L,8L,6L,5L,0L,4L,2L,0L,4L,8L,3L };
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
public class A019639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019639Inst : IEnumerable<long>
{
public static readonly long[] Value=A019639.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019639.Bytes);
public long this[int i]=>Value[i];

public static A019639Inst Instance=new A019639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019640
{
public static readonly long[] Value={ 2L,7L,5L,5L,1L,5L,4L,2L,3L,6L,0L,8L,1L,6L,6L,1L,9L,5L,8L,9L,7L,9L,5L,9L,4L,5L,8L,9L,5L,3L,3L,2L,3L,5L,0L,9L,9L,6L,3L,0L,3L,4L,7L,9L,4L,4L,6L,6L,0L,8L,7L,2L,3L,0L,1L,0L,3L,7L,7L,6L,7L,5L,0L,2L,5L,3L,1L,9L,7L,1L,9L,5L,2L,3L,4L,2L,2L,7L,8L,0L,2L,1L,5L,7L,5L,0L,1L,3L,5L,7L,4L,9L,7L,0L,3L,1L,0L,8L,5L };
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
public class A019640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019640Inst : IEnumerable<long>
{
public static readonly long[] Value=A019640.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019640.Bytes);
public long this[int i]=>Value[i];

public static A019640Inst Instance=new A019640Inst();

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