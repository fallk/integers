using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A139541
{
public static readonly BigInteger[] Value={ 1L,3L,315L,155925L,212837625L,618718975875L,3287253918823875L,BigInteger.Parse("28845653137679503125"),BigInteger.Parse("388983632561608099640625"),BigInteger.Parse("7637693625347175036443671875"),BigInteger.Parse("209402646126143497974176151796875") };
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
public class A139541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139541Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A139541.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A139541.Bytes);
public BigInteger this[int i]=>Value[i];

public static A139541Inst Instance=new A139541Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139542
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,10L,12L,15L,18L,21L,24L,28L,32L,36L,42L,48L,54L,60L,66L,72L,80L,88L,96L,104L,112L,120L,130L,140L,150L,160L,170L,180L,192L,204L,216L,228L,240L,255L,270L,285L,300L,315L,330L,345L,360L,378L,396L,414L,432L,450L,468L,486L,504L,525L,546L,567L,588L,609L };
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
public class A139542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139542Inst : IEnumerable<long>
{
public static readonly long[] Value=A139542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139542.Bytes);
public long this[int i]=>Value[i];

public static A139542Inst Instance=new A139542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139543
{
public static readonly long[] Value={ 3L,93L,402L,2846L,28242L,826393L };
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
public class A139543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139543Inst : IEnumerable<long>
{
public static readonly long[] Value=A139543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139543.Bytes);
public long this[int i]=>Value[i];

public static A139543Inst Instance=new A139543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139592
{
public static readonly long[] Value={ 0L,2L,10L,20L,36L,54L,78L,104L,136L,170L,210L,252L,300L,350L,406L,464L,528L,594L,666L,740L,820L,902L,990L,1080L,1176L,1274L,1378L,1484L,1596L,1710L,1830L,1952L,2080L,2210L,2346L,2484L,2628L,2774L,2926L,3080L,3240L,3402L,3570L,3740L };
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
public class A139592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139592Inst : IEnumerable<long>
{
public static readonly long[] Value=A139592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139592.Bytes);
public long this[int i]=>Value[i];

public static A139592Inst Instance=new A139592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139593
{
public static readonly long[] Value={ 0L,3L,11L,22L,38L,57L,81L,108L,140L,175L,215L,258L,306L,357L,413L,472L,536L,603L,675L,750L,830L,913L,1001L,1092L,1188L,1287L,1391L,1498L,1610L,1725L,1845L,1968L,2096L,2227L,2363L,2502L,2646L,2793L,2945L,3100L,3260L,3423L,3591L,3762L };
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
public class A139593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139593Inst : IEnumerable<long>
{
public static readonly long[] Value=A139593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139593.Bytes);
public long this[int i]=>Value[i];

public static A139593Inst Instance=new A139593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139594
{
public static readonly long[] Value={ 0L,1L,9L,39L,116L,275L,561L,1029L,1744L,2781L,4225L,6171L,8724L,11999L,16121L,21225L,27456L,34969L,43929L,54511L,66900L,81291L,97889L,116909L,138576L,163125L,190801L,221859L,256564L,295191L,338025L,385361L,437504L,494769L,557481L,625975L,700596L };
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
public class A139594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139594Inst : IEnumerable<long>
{
public static readonly long[] Value=A139594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139594.Bytes);
public long this[int i]=>Value[i];

public static A139594Inst Instance=new A139594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139595
{
public static readonly long[] Value={ 0L,5L,13L,26L,42L,63L,87L,116L,148L,185L,225L,270L,318L,371L,427L,488L,552L,621L,693L,770L,850L,935L,1023L,1116L,1212L,1313L,1417L,1526L,1638L,1755L,1875L,2000L,2128L,2261L,2397L,2538L,2682L,2831L,2983L,3140L,3300L,3465L,3633L,3806L };
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
public class A139595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139595Inst : IEnumerable<long>
{
public static readonly long[] Value=A139595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139595.Bytes);
public long this[int i]=>Value[i];

public static A139595Inst Instance=new A139595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139596
{
public static readonly long[] Value={ 0L,6L,14L,28L,44L,66L,90L,120L,152L,190L,230L,276L,324L,378L,434L,496L,560L,630L,702L,780L,860L,946L,1034L,1128L,1224L,1326L,1430L,1540L,1652L,1770L,1890L,2016L,2144L,2278L,2414L,2556L,2700L,2850L,3002L,3160L,3320L,3486L,3654L,3828L };
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
public class A139596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139596Inst : IEnumerable<long>
{
public static readonly long[] Value=A139596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139596.Bytes);
public long this[int i]=>Value[i];

public static A139596Inst Instance=new A139596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139597
{
public static readonly long[] Value={ 0L,7L,15L,30L,46L,69L,93L,124L,156L,195L,235L,282L,330L,385L,441L,504L,568L,639L,711L,790L,870L,957L,1045L,1140L,1236L,1339L,1443L,1554L,1666L,1785L,1905L,2032L,2160L,2295L,2431L,2574L,2718L,2869L,3021L,3180L,3340L,3507L,3675L,3850L };
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
public class A139597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139597Inst : IEnumerable<long>
{
public static readonly long[] Value=A139597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139597.Bytes);
public long this[int i]=>Value[i];

public static A139597Inst Instance=new A139597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139598
{
public static readonly long[] Value={ 0L,8L,16L,32L,48L,72L,96L,128L,160L,200L,240L,288L,336L,392L,448L,512L,576L,648L,720L,800L,880L,968L,1056L,1152L,1248L,1352L,1456L,1568L,1680L,1800L,1920L,2048L,2176L,2312L,2448L,2592L,2736L,2888L,3040L,3200L,3360L,3528L,3696L,3872L };
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
public class A139598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139598Inst : IEnumerable<long>
{
public static readonly long[] Value=A139598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139598.Bytes);
public long this[int i]=>Value[i];

public static A139598Inst Instance=new A139598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139599
{
public static readonly long[] Value={ 3L,7L,11L,41L,47L,53L,71L,73L,83L,101L,127L,149L,157L,173L,181L,197L,211L,223L,229L,263L,271L,307L,337L,359L,373L,379L,397L,419L,433L,443L,509L,521L,571L,593L,599L,613L,617L,619L,641L,659L,673L,677L,719L,733L,739L,743L,751L,761L,773L,787L,811L,821L,887L,937L };
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
public class A139599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139599Inst : IEnumerable<long>
{
public static readonly long[] Value=A139599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139599.Bytes);
public long this[int i]=>Value[i];

public static A139599Inst Instance=new A139599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139600
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,0L,1L,3L,3L,0L,1L,4L,6L,4L,0L,1L,5L,9L,10L,5L,0L,1L,6L,12L,16L,15L,6L,0L,1L,7L,15L,22L,25L,21L,7L,0L,1L,8L,18L,28L,35L,36L,28L,8L,0L,1L,9L,21L,34L,45L,51L,49L,36L,9L,0L,1L,10L,24L,40L,55L,66L,70L,64L,45L,10L,0L,1L,11L,27L,46L,65L,81L,91L,92L,81L,55L,11L };
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
public class A139600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139600Inst : IEnumerable<long>
{
public static readonly long[] Value=A139600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139600.Bytes);
public long this[int i]=>Value[i];

public static A139600Inst Instance=new A139600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139601
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,3L,0L,1L,4L,6L,0L,1L,5L,9L,10L,0L,1L,6L,12L,16L,15L,0L,1L,7L,15L,22L,25L,21L,0L,1L,8L,18L,28L,35L,36L,28L,0L,1L,9L,21L,34L,45L,51L,49L,36L,0L,1L,10L,24L,40L,55L,66L,70L,64L,45L,0L,1L,11L,27L,46L,65L,81L,91L,92L,81L,55L,0L,1L,12L,30L,52L,75L,96L,112L,120L,117L,100L,66L };
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
public class A139601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139601Inst : IEnumerable<long>
{
public static readonly long[] Value=A139601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139601.Bytes);
public long this[int i]=>Value[i];

public static A139601Inst Instance=new A139601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139602
{
public static readonly long[] Value={ 11L,19L,61L,43L,97L,163L,191L,229L,283L,223L,743L,991L,541L,457L,877L,1327L,1049L,1321L,1733L,1307L,1987L,6011L,2971L,5153L,2029L,8693L,2551L,4789L,5407L,2129L,6473L,4481L,4889L,4217L,7951L,11743L,13789L,9851L,7253L,11491L,20393L,17231L,9749L,20747L,6599L,13873L,16369L,15461L,17123L,13451L,9967L,26959L,21089L,41863L,27437L,26003L,40189L,18661L,16673L,64693L };
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
public class A139602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139602Inst : IEnumerable<long>
{
public static readonly long[] Value=A139602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139602.Bytes);
public long this[int i]=>Value[i];

public static A139602Inst Instance=new A139602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139603
{
public static readonly long[] Value={ 2L,7L,11L,19L,43L,79L,83L,107L,127L,131L,139L,151L,167L,211L,227L,239L,263L,271L,283L,307L,347L,359L,431L,439L,479L,491L,503L,523L,547L,563L,571L,607L,659L,739L,743L,787L,811L,827L,887L,919L,967L };
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
public class A139603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139603Inst : IEnumerable<long>
{
public static readonly long[] Value=A139603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139603.Bytes);
public long this[int i]=>Value[i];

public static A139603Inst Instance=new A139603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139604
{
public static readonly long[] Value={ 9L,5L,4L,1L,0L,8L,5L,-12L,0L,16L,9L,0L,-32L,0L,32L,5L,20L,0L,-80L,0L,64L,1L,0L,72L,0L,-192L,0L,128L,5L,-28L,0L,224L,0L,-448L,0L,256L,9L,0L,-128L,0L,640L,0L,-1024L,0L,512L,5L,36L,0L,-480L,0L,1728L,0L,-2304L,0L,1024L,1L,0L,200L,0L,-1600L,0L,4480L,0L,-5120L,0L,2048L };
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
public class A139604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139604Inst : IEnumerable<long>
{
public static readonly long[] Value=A139604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139604.Bytes);
public long this[int i]=>Value[i];

public static A139604Inst Instance=new A139604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139605
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,1L,4L,1L,4L,7L,6L,1L,1L,7L,4L,11L,1L,5L,30L,15L,10L,25L,10L,1L,1L,11L,15L,32L,34L,26L,1L,6L,57L,34L,146L,31L,15L,120L,90L,20L,65L,15L,1L,1L,16L,26L,15L,76L,192L,34L,122L,180L,57L,1L,7L,98L,140L,406L,462L,588L,63L,21L,252L,154L,896L,301L };
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
public class A139605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139605Inst : IEnumerable<long>
{
public static readonly long[] Value=A139605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139605.Bytes);
public long this[int i]=>Value[i];

public static A139605Inst Instance=new A139605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139606
{
public static readonly long[] Value={ 6L,21L,36L,51L,66L,81L,96L,111L,126L,141L,156L,171L,186L,201L,216L,231L,246L,261L,276L,291L,306L,321L,336L,351L,366L,381L,396L,411L,426L,441L,456L,471L,486L,501L,516L,531L,546L,561L,576L,591L,606L,621L,636L,651L,666L,681L,696L,711L,726L,741L,756L,771L,786L };
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
public class A139606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139606Inst : IEnumerable<long>
{
public static readonly long[] Value=A139606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139606.Bytes);
public long this[int i]=>Value[i];

public static A139606Inst Instance=new A139606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139607
{
public static readonly long[] Value={ 7L,28L,49L,70L,91L,112L,133L,154L,175L,196L,217L,238L,259L,280L,301L,322L,343L,364L,385L,406L,427L,448L,469L,490L,511L,532L,553L,574L,595L,616L,637L,658L,679L,700L,721L,742L,763L,784L,805L,826L,847L,868L,889L,910L,931L,952L,973L,994L };
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
public class A139607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139607Inst : IEnumerable<long>
{
public static readonly long[] Value=A139607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139607.Bytes);
public long this[int i]=>Value[i];

public static A139607Inst Instance=new A139607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139720
{
public static readonly long[] Value={ 9L,4L,6L,4L,19L,9L,9L,2L,6L,5L,3L,8L,9L,1L,20L,0L,3L,8L,10L,4L,7L,11L,0L,16L,17L,7L,11L,2L,15L,14L,4L,8L,2L,5L,3L,23L,2L,3L,1L,1L,16L,19L,5L,25L,16L,11L,20L,5L,14L,1L,4L,0L,14L,9L,13L,10L,0L,9L,11L,6L,5L,7L,20L,7L,4L,6L,9L,19L,10L,0L,24L,0L,5L,3L,3L,8L,1L,2L,20L,19L,13L,17L,13L,15L,2L,1L,0L,3L,11L };
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
public class A139720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139720Inst : IEnumerable<long>
{
public static readonly long[] Value=A139720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139720.Bytes);
public long this[int i]=>Value[i];

public static A139720Inst Instance=new A139720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139721
{
public static readonly long[] Value={ 8L,5L,1L,6L,0L,1L,15L,2L,17L,21L,4L,19L,3L,7L,13L,4L,27L,23L,1L,18L,0L,13L,0L,5L,23L,3L,8L,7L,0L,1L,14L,12L,32L,2L,8L,5L,0L,2L,13L,18L,0L,6L,10L,9L,3L,6L,15L,11L,18L,3L,10L,0L,2L,0L,10L,6L,5L,6L,15L,7L,9L,6L,18L,15L,12L,13L,1L,21L,1L,10L,19L,25L,9L,9L,14L,8L,15L,2L,7L,14L,5L,8L,4L,0L,6L,5L,12L,1L };
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
public class A139721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139721Inst : IEnumerable<long>
{
public static readonly long[] Value=A139721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139721.Bytes);
public long this[int i]=>Value[i];

public static A139721Inst Instance=new A139721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139722
{
public static readonly long[] Value={ 16L,3L,12L,20L,1L,0L,9L,16L,4L,11L,14L,5L,0L,18L,5L,5L,4L,19L,0L,4L,3L,8L,0L,14L,0L,4L,3L,23L,2L,7L,3L,4L,1L,4L,14L,2L,6L,17L,17L,8L,22L,4L,7L,1L,5L,7L,48L,3L,0L,9L,15L,16L,13L,0L,5L,9L,1L,6L,16L,27L,2L,3L,5L,15L,17L,22L,2L,0L,6L,3L,3L,2L,26L,21L,2L,0L,13L,19L,14L,27L,0L,2L,3L,8L,11L,0L,48L,12L,10L };
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
public class A139722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139722Inst : IEnumerable<long>
{
public static readonly long[] Value=A139722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139722.Bytes);
public long this[int i]=>Value[i];

public static A139722Inst Instance=new A139722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139723
{
public static readonly long[] Value={ 3L,1L,20L,16L,2L,9L,28L,18L,20L,0L,1L,7L,1L,14L,13L,4L,0L,0L,11L,18L,2L,11L,14L,11L,3L,15L,31L,10L,0L,8L,12L,6L,9L,11L,2L,8L,9L,4L,9L,6L,1L,1L,3L,24L,3L,17L,3L,3L,1L,38L,18L,27L,15L,18L,6L,7L,3L,7L,7L,32L,7L,2L,1L,4L,11L,4L,6L,23L,19L,27L,2L,16L,1L,4L,2L,0L,12L,6L,6L,2L,25L,4L,2L,26L,3L,8L,0L,7L,1L,9L };
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
public class A139723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139723Inst : IEnumerable<long>
{
public static readonly long[] Value=A139723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139723.Bytes);
public long this[int i]=>Value[i];

public static A139723Inst Instance=new A139723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139724
{
public static readonly long[] Value={ 12L,1L,18L,27L,2L,2L,6L,15L,9L,8L,0L,8L,53L,2L,15L,10L,0L,6L,6L,7L,4L,13L,3L,0L,4L,4L,7L,0L,8L,3L,18L,0L,1L,19L,14L,2L,8L,17L,0L,8L,9L,12L,15L,9L,18L,5L,5L,37L,3L,4L,1L,0L,4L,8L,19L,18L,5L,6L,6L,1L,0L,11L,8L,2L,19L,5L,9L,18L,18L,16L,10L,2L,13L,12L,42L,2L,17L,6L,14L,6L,27L,15L,5L,0L,23L,8L,2L,36L,2L };
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
public class A139724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139724Inst : IEnumerable<long>
{
public static readonly long[] Value=A139724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139724.Bytes);
public long this[int i]=>Value[i];

public static A139724Inst Instance=new A139724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139725
{
public static readonly long[] Value={ 15L,9L,7L,8L,9L,29L,2L,20L,18L,16L,9L,42L,14L,7L,2L,6L,45L,10L,1L,4L,13L,22L,7L,53L,1L,4L,16L,9L,12L,5L,4L,4L,6L,2L,7L,19L,31L,1L,3L,3L,7L,2L,0L,6L,1L,5L,1L,6L,6L,17L,11L,0L,2L,0L,4L,1L,0L,6L,3L,1L,1L,30L,4L,3L,49L,0L,1L,0L,10L,1L,13L,2L,10L,2L,63L,9L,3L,7L,14L,1L,0L,5L,15L,5L,17L,1L,3L,4L,0L,4L,0L,6L };
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
public class A139725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139725Inst : IEnumerable<long>
{
public static readonly long[] Value=A139725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139725.Bytes);
public long this[int i]=>Value[i];

public static A139725Inst Instance=new A139725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139726
{
public static readonly long[] Value={ 6L,7L,7L,0L,16L,14L,6L,3L,2L,2L,3L,12L,3L,1L,5L,10L,9L,12L,2L,1L,8L,9L,17L,7L,6L,0L,16L,5L,4L,2L,18L,11L,11L,25L,11L,0L,3L,0L,10L,17L,19L,0L,9L,41L,5L,15L,2L,21L,0L,7L,7L,1L,10L,18L,28L,30L,4L,1L,17L,12L,3L,11L,12L,5L,22L,14L,3L,24L,7L,3L,19L,14L,5L,15L,7L,17L,11L,7L,11L,0L,12L,1L,3L,0L,2L,6L,1L };
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
public class A139726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139726Inst : IEnumerable<long>
{
public static readonly long[] Value=A139726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139726.Bytes);
public long this[int i]=>Value[i];

public static A139726Inst Instance=new A139726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139727
{
public static readonly long[] Value={ 6L,1L,15L,7L,3L,1L,0L,9L,2L,3L,16L,0L,19L,21L,6L,14L,24L,10L,6L,2L,2L,5L,8L,5L,32L,1L,9L,24L,9L,33L,2L,4L,4L,11L,2L,31L,2L,7L,14L,1L,1L,3L,10L,6L,18L,0L,4L,16L,4L,8L,1L,2L,25L,1L,3L,8L,6L,3L,10L,7L,21L,41L,2L,18L,5L,10L,10L,3L,2L,3L,7L,0L,7L,3L,13L,5L,8L,0L,13L,0L,0L,0L,0L,0L,4L,4L,0L,4L,10L,5L,6L,6L };
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
public class A139727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139727Inst : IEnumerable<long>
{
public static readonly long[] Value=A139727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139727.Bytes);
public long this[int i]=>Value[i];

public static A139727Inst Instance=new A139727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139728
{
public static readonly long[] Value={ 17L,3L,10L,5L,5L,7L,11L,8L,9L,4L,6L,3L,13L,12L,4L,2L,8L,18L,11L,37L,2L,15L,5L,16L,3L,15L,0L,2L,15L,2L,9L,16L,2L,0L,4L,2L,5L,22L,4L,4L,12L,21L,7L,41L,19L,6L,2L,19L,1L,6L,4L,3L,34L,4L,0L,0L,14L,19L,18L,1L,9L,12L,1L,18L,11L,4L,3L,21L,3L,4L,19L,5L,11L,8L,12L,2L,8L,10L,14L,1L,0L,0L,20L,6L,13L,9L,47L,10L };
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
public class A139728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139728Inst : IEnumerable<long>
{
public static readonly long[] Value=A139728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139728.Bytes);
public long this[int i]=>Value[i];

public static A139728Inst Instance=new A139728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139729
{
public static readonly long[] Value={ 0L,1L,1L,25L,161L,681L,3057L,15225L,55105L,233801L,269201L,3471385L,1882337L,50495465L,186023729L,63600825L,3793632897L,12667859593L,28111390417L,253002513753L,352877275169L,3175895476521L,15388919755377L,68131533620729L,120602593342913L,240998409954249L };
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
public class A139729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139729Inst : IEnumerable<long>
{
public static readonly long[] Value=A139729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139729.Bytes);
public long this[int i]=>Value[i];

public static A139729Inst Instance=new A139729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139730
{
public static readonly long[] Value={ 0L,4L,6L,104L,311L,2799L,191L,17344L,77971L,701739L,456276L,33403359L,202973981L,361922079L,815892461L,19550063399L,145432992466L,88193807194L,1556683717871L,10195456195214L,34538646772551L,120112957671709L,2034690935451631L,1622917881955304L,50369047802832111L };
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
public class A139730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139730Inst : IEnumerable<long>
{
public static readonly long[] Value=A139730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139730.Bytes);
public long this[int i]=>Value[i];

public static A139730Inst Instance=new A139730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139731
{
public static readonly long[] Value={ 0L,3L,9L,81L,81L,4617L,18225L,24057L,1056321L,4468041L,40212369L,180512793L,1624615137L,8091189225L,72820703025L,420293834937L,2372089560705L,4422146601609L,90579297748689L,510533809732953L,938645847533601L,19416287947991337L,108935739610788465L,585556544970294777L };
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
public class A139731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139731Inst : IEnumerable<long>
{
public static readonly long[] Value=A139731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139731.Bytes);
public long this[int i]=>Value[i];

public static A139731Inst Instance=new A139731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139732
{
public static readonly long[] Value={ 0L,2L,32L,43L,1759L,8628L,60845L,665254L,2693114L,24238026L,97081413L,1721158464L,5603792461L,22751557747L,495431050944L,1745987167100L,25209007523786L,160415206574872L,280584289237813L,5782085798961215L,29240981819904649L,502545635271977844L };
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
public class A139732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139732Inst : IEnumerable<long>
{
public static readonly long[] Value=A139732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139732.Bytes);
public long this[int i]=>Value[i];

public static A139732Inst Instance=new A139732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139733
{
public static readonly long[] Value={ 0L,1L,17L,217L,2465L,26281L,7153L,588665L,9492289L,118985033L,265558929L,5611255833L,7551629537L,342842572777L,886559899441L,29969271650489L,164170328587905L,914583003869833L,5979447221143249L,53815024990289241L,628450412988459041L,7961896726109825321L };
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
public class A139733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139733Inst : IEnumerable<long>
{
public static readonly long[] Value=A139733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139733.Bytes);
public long this[int i]=>Value[i];

public static A139733Inst Instance=new A139733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139734
{
public static readonly long[] Value={ 0L,1L,1L,1L,37L,127L,541L,1036L,3799L,5185L,51850L,164206L,224884L,1185958L,3887965L,5398867L,10941949L,66372769L,276307201L,438549076L,3223229293L,7824802123L,15485902012L,60715841293L,42299339968L,705422936161L,1970497704952L,1911916251217L,11493565027183L };
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
public class A139734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139734Inst : IEnumerable<long>
{
public static readonly long[] Value=A139734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139734.Bytes);
public long this[int i]=>Value[i];

public static A139734Inst Instance=new A139734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139735
{
public static readonly long[] Value={ 0L,2L,4L,40L,16L,672L,576L,5760L,57600L,182784L,779264L,3598336L,10817536L,41066496L,8011776L,616988672L,1874919424L,1569325056L,15693250560L,19493552128L,194935521280L,1949355212800L,10697459105792L,36605846880256L,225320980447232L,1409990787072L };
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
public class A139735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139735Inst : IEnumerable<long>
{
public static readonly long[] Value=A139735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139735.Bytes);
public long this[int i]=>Value[i];

public static A139735Inst Instance=new A139735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139800
{
public static readonly long[] Value={ 1L,0L,0L,0L,2L,2L,4L,8L,18L,34L,68L,136L,274L,546L,1092L,2184L,4370L,8738L,17476L,34952L,69906L,139810L,279620L,559240L,1118482L,2236962L,4473924L,8947848L,17895698L,35791394L,71582788L,143165576L,286331154L,572662306L,1145324612L,2290649224L };
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
public class A139800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139800Inst : IEnumerable<long>
{
public static readonly long[] Value=A139800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139800.Bytes);
public long this[int i]=>Value[i];

public static A139800Inst Instance=new A139800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139801
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,3L,3L,6L,9L,9L,3L,6L,10L,14L,14L,4L,10L,20L,34L,48L,48L,4L,10L,20L,35L,55L,75L,75L,5L,15L,35L,70L,125L,200L,275L,275L,5L,15L,35L,70L,126L,209L,319L,429L,429L,6L,21L,56L,126L,252L,461L,780L,1209L,1638L,1638L };
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
public class A139801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139801Inst : IEnumerable<long>
{
public static readonly long[] Value=A139801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139801.Bytes);
public long this[int i]=>Value[i];

public static A139801Inst Instance=new A139801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139802
{
public static readonly BigInteger[] Value={ 1L,2L,3L,16L,125L,2821109907456L,BigInteger.Parse("4337654948097993282537354757263188251697832994620405101744893017744569432720994168089672192211758909320807") };
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
public class A139802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139802Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A139802.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A139802.Bytes);
public BigInteger this[int i]=>Value[i];

public static A139802Inst Instance=new A139802Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139803
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,1L,2L,3L,4L,5L,2L,7L,4L,1L,2L,3L,4L,9L,2L,955L,468L };
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
public class A139803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139803Inst : IEnumerable<long>
{
public static readonly long[] Value=A139803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139803.Bytes);
public long this[int i]=>Value[i];

public static A139803Inst Instance=new A139803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139804
{
public static readonly long[] Value={ 1L,1L,17L,1L,701L,1367L,1487L,16057L,61151L };
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
public class A139804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139804Inst : IEnumerable<long>
{
public static readonly long[] Value=A139804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139804.Bytes);
public long this[int i]=>Value[i];

public static A139804Inst Instance=new A139804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139805
{
public static readonly long[] Value={ 20L,28L,36L,42L,44L,48L,52L,54L,60L,66L,68L,72L,76L,78L,80L,84L,88L,90L,92L,96L,99L,100L,102L,104L,108L,110L,112L,114L,116L,117L,120L,124L,126L,130L,132L,136L,138L,140L,144L,148L,150L,152L,153L,156L,160L,162L,164L,168L,170L,171L,172L,174L,176L,180L,184L,186L,188L };
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
public class A139805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139805Inst : IEnumerable<long>
{
public static readonly long[] Value=A139805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139805.Bytes);
public long this[int i]=>Value[i];

public static A139805Inst Instance=new A139805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139806
{
public static readonly long[] Value={ 1L,3L,7L,15L,27L,55L,111L,223L,443L,887L,1775L,3551L,7099L,14199L,28399L,56799L,113595L,227191L,454383L,908767L,1817531L,3635063L,7270127L,14540255L,29080507L,58161015L,116322031L,232644063L,465288123L,930576247L,1861152495L,3722304991L,7444609979L,14889219959L };
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
public class A139806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139806Inst : IEnumerable<long>
{
public static readonly long[] Value=A139806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139806.Bytes);
public long this[int i]=>Value[i];

public static A139806Inst Instance=new A139806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139807
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,5L,4L,8L,7L,11L,11L,17L,16L,25L,24L,35L,35L,50L,49L,70L,69L,94L,96L,129L,129L,172L,174L,227L,232L,298L,303L,389L,396L,498L,513L,639L,655L,814L,834L,1025L,1057L,1287L,1326L,1610L,1657L,1995L,2063L,2469L,2548L,3039L,3138L,3720L,3851L,4539L,4696L,5523L };
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
public class A139807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139807Inst : IEnumerable<long>
{
public static readonly long[] Value=A139807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139807.Bytes);
public long this[int i]=>Value[i];

public static A139807Inst Instance=new A139807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139808
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,3L,2L,0L,0L,-2L,-4L,6L,16L,8L,0L,0L,-2L,0L,26L,20L,-92L,-120L,64L,160L,64L,0L,0L,-2L,-6L,38L,130L,-204L,-964L,144L,3120L,1664L,-4224L,-4352L,1280L,3072L,1024L,0L,0L,0L,-6L,-42L,74L,1022L,548L,-9100L,-12656L,37968L,79584L,-70336L,-243712L,7168L,389632L,179200L,-292864L,-258048L,49152L,114688L };
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
public class A139808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139808Inst : IEnumerable<long>
{
public static readonly long[] Value=A139808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139808.Bytes);
public long this[int i]=>Value[i];

public static A139808Inst Instance=new A139808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139809
{
public static readonly long[] Value={ 1L,1L,4L,-2L,-4L,28L,48L,4L,32L,-32L,-544L,-368L,1472L,1536L,12L,48L,-672L,-2656L,8304L,36480L,-15360L,-144384L,-56064L,166912L,122880L,36L,432L,-1440L,-28320L,-13296L,549888L,811264L,-4222976L,-8578560L,13056000L,35942400L,-10592256L,-64811008L,-17072128L,41877504L,23592960L,-144L,-864L };
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
public class A139809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139809Inst : IEnumerable<long>
{
public static readonly long[] Value=A139809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139809.Bytes);
public long this[int i]=>Value[i];

public static A139809Inst Instance=new A139809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139810
{
public static readonly BigInteger[] Value={ 1L,2L,15L,417L,42176L,15701273L,21418970801L,107224417436160L,1968910887183791359L,BigInteger.Parse("132633131268024896655873"),BigInteger.Parse("32775983842712963307230834176"),BigInteger.Parse("29712661745725058784174163778464369") };
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
public class A139810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139810Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A139810.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A139810.Bytes);
public BigInteger this[int i]=>Value[i];

public static A139810Inst Instance=new A139810Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139811
{
public static readonly long[] Value={ 19L,43L,47L,61L,73L,79L,83L,89L,109L,113L,137L,139L,157L,167L,181L,197L,199L,211L,229L,233L,239L,241L,271L,281L,283L,293L,313L,317L,353L,359L,383L,389L,401L,439L,443L,449L,463L,467L,503L,509L,521L,523L };
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
public class A139811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139811Inst : IEnumerable<long>
{
public static readonly long[] Value=A139811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139811.Bytes);
public long this[int i]=>Value[i];

public static A139811Inst Instance=new A139811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139812
{
public static readonly long[] Value={ 5L,7L,11L,13L,17L,23L,29L,31L,37L,41L,53L,59L,67L,71L,97L,101L,103L,107L,127L,131L,149L,151L,163L,173L,179L,191L,193L,223L,227L,251L,257L,263L,269L,277L,307L,311L,331L,337L,347L,349L,367L,373L,379L,397L,409L,419L,421L,431L,433L,457L,461L,479L,487L,491L,499L,541L };
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
public class A139812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139812Inst : IEnumerable<long>
{
public static readonly long[] Value=A139812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139812.Bytes);
public long this[int i]=>Value[i];

public static A139812Inst Instance=new A139812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139813
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,2L,6L,6L,2L,2L,8L,6L,8L,2L,2L,10L,20L,20L,10L,2L,2L,12L,30L,20L,30L,12L,2L,2L,14L,42L,70L,70L,42L,14L,2L,2L,16L,56L,112L,70L,112L,56L,16L,2L,2L,18L,72L,168L,252L,252L,168L,72L,18L,2L,2L,20L,90L,240L,420L,252L,420L,240L,90L,20L,2L };
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
public class A139813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139813Inst : IEnumerable<long>
{
public static readonly long[] Value=A139813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139813.Bytes);
public long this[int i]=>Value[i];

public static A139813Inst Instance=new A139813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139814
{
public static readonly long[] Value={ 0L,1L,3L,7L,11L,23L,47L,95L,187L,375L,751L,1503L,3003L,6007L,12015L,24031L,48059L,96119L,192239L,384479L,768955L,1537911L,3075823L,6151647L,12303291L,24606583L,49213167L,98426335L,196852667L,393705335L,787410671L,1574821343L,3149642683L };
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
public class A139814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139814Inst : IEnumerable<long>
{
public static readonly long[] Value=A139814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139814.Bytes);
public long this[int i]=>Value[i];

public static A139814Inst Instance=new A139814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139815
{
public static readonly long[] Value={ 3L,-16L,4L,88L,-48L,8L,-496L,432L,-144L,16L,2848L,-3456L,1728L,-384L,32L,-16576L,25920L,-17280L,5760L,-960L,64L,97408L,-186624L,155520L,-69120L,17280L,-2304L,128L,-576256L,1306368L,-1306368L,725760L,-241920L,48384L,-5376L,256L,3424768L,-8957952L,10450944L,-6967296L,2903040L,-774144L,129024L };
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
public class A139815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139815Inst : IEnumerable<long>
{
public static readonly long[] Value=A139815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139815.Bytes);
public long this[int i]=>Value[i];

public static A139815Inst Instance=new A139815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139848
{
public static readonly long[] Value={ 7L,43L,67L,127L,163L,463L,487L,547L,823L,883L,907L,967L,1087L,1303L,1327L,1423L,1663L,1723L,1747L,2083L,2143L,2347L,2503L,2647L,2683L,2767L,3067L,3187L,3343L,3607L,3823L,3847L,3907L,3943L,4027L,4243L,4327L,4363L,4447L,4603L,4663L,4783L,5023L };
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
public class A139848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139848Inst : IEnumerable<long>
{
public static readonly long[] Value=A139848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139848.Bytes);
public long this[int i]=>Value[i];

public static A139848Inst Instance=new A139848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139849
{
public static readonly long[] Value={ 13L,73L,97L,157L,313L,397L,433L,577L,733L,853L,937L,997L,1153L,1237L,1657L,1693L,1753L,1777L,1993L,2113L,2593L,2617L,2677L,2833L,2917L,2953L,3037L,3253L,3373L,3433L,3457L,3517L,3673L,3793L,3853L,3877L,4093L,4177L,4273L,4297L,4357L,4513L };
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
public class A139849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139849Inst : IEnumerable<long>
{
public static readonly long[] Value=A139849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139849.Bytes);
public long this[int i]=>Value[i];

public static A139849Inst Instance=new A139849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139850
{
public static readonly long[] Value={ 11L,71L,179L,191L,239L,359L,431L,491L,599L,659L,911L,1019L,1031L,1439L,1451L,1499L,1619L,1871L,2039L,2111L,2339L,2459L,2531L,2591L,2699L,2711L,2879L,3011L,3119L,3299L,3371L,3539L,3719L,3851L,4019L,4139L,4211L,4271L,4391L,4691L,4799L,5051L };
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
public class A139850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139850Inst : IEnumerable<long>
{
public static readonly long[] Value=A139850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139850.Bytes);
public long this[int i]=>Value[i];

public static A139850Inst Instance=new A139850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139851
{
public static readonly long[] Value={ 29L,37L,53L,109L,149L,197L,277L,317L,373L,389L,421L,541L,557L,613L,653L,701L,709L,757L,821L,877L,1061L,1093L,1117L,1213L,1229L,1373L,1381L,1429L,1453L,1493L,1549L,1597L,1621L,1709L,1733L,1789L,1877L,1901L,1933L,1997L,2053L,2069L,2213L,2221L,2237L };
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
public class A139851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139851Inst : IEnumerable<long>
{
public static readonly long[] Value=A139851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139851.Bytes);
public long this[int i]=>Value[i];

public static A139851Inst Instance=new A139851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139852
{
public static readonly long[] Value={ 7L,23L,71L,79L,127L,151L,191L,239L,263L,359L,431L,463L,487L,599L,631L,743L,751L,823L,863L,911L,919L,967L,991L,1031L,1087L,1103L,1303L,1327L,1367L,1423L,1439L,1471L,1583L,1607L,1663L,1759L,1831L,1871L,1999L,2039L,2087L,2111L,2143L,2207L,2311L };
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
public class A139852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139852Inst : IEnumerable<long>
{
public static readonly long[] Value=A139852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139852.Bytes);
public long this[int i]=>Value[i];

public static A139852Inst Instance=new A139852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139853
{
public static readonly long[] Value={ 11L,43L,67L,107L,163L,179L,211L,331L,347L,379L,443L,491L,499L,547L,571L,659L,683L,739L,827L,883L,907L,947L,1019L,1051L,1163L,1171L,1187L,1283L,1451L,1499L,1523L,1579L,1619L,1667L,1723L,1747L,1787L,2003L,2011L,2027L,2083L,2179L,2251L,2339L,2347L };
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
public class A139853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139853Inst : IEnumerable<long>
{
public static readonly long[] Value=A139853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139853.Bytes);
public long this[int i]=>Value[i];

public static A139853Inst Instance=new A139853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139854
{
public static readonly long[] Value={ 3L,43L,67L,163L,283L,307L,523L,547L,643L,787L,883L,907L,1123L,1483L,1627L,1723L,1747L,1867L,1987L,2083L,2203L,2347L,2467L,2683L,2707L,2803L,3067L,3163L,3187L,3307L,3547L,3643L,3907L,4003L,4027L,4243L,4363L,4483L,4507L,4603L,4723L,4987L,5107L };
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
public class A139854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139854Inst : IEnumerable<long>
{
public static readonly long[] Value=A139854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139854.Bytes);
public long this[int i]=>Value[i];

public static A139854Inst Instance=new A139854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139855
{
public static readonly long[] Value={ 31L,79L,151L,199L,271L,439L,631L,751L,919L,991L,1039L,1231L,1279L,1399L,1471L,1759L,1831L,1879L,1951L,1999L,2239L,2311L,2551L,2671L,2719L,2791L,3079L,3271L,3319L,3391L,3511L,3559L,3631L,3919L,4111L,4159L,4231L,4519L,4591L,4639L,4759L,4831L };
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
public class A139855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139855Inst : IEnumerable<long>
{
public static readonly long[] Value=A139855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139855.Bytes);
public long this[int i]=>Value[i];

public static A139855Inst Instance=new A139855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139856
{
public static readonly long[] Value={ 5L,29L,101L,149L,269L,389L,461L,509L,701L,821L,941L,1061L,1109L,1181L,1229L,1301L,1709L,1901L,1949L,2069L,2141L,2309L,2381L,2549L,2621L,2741L,2789L,2861L,2909L,3221L,3389L,3461L,3581L,3701L,3821L,3989L,4229L,4349L,4421L,5021L,5189L,5261L };
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
public class A139856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139856Inst : IEnumerable<long>
{
public static readonly long[] Value=A139856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139856.Bytes);
public long this[int i]=>Value[i];

public static A139856Inst Instance=new A139856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139857
{
public static readonly long[] Value={ 23L,47L,167L,263L,383L,503L,647L,743L,863L,887L,983L,1103L,1223L,1367L,1487L,1583L,1607L,1823L,1847L,2063L,2087L,2207L,2423L,2447L,2543L,2663L,2687L,2903L,2927L,3023L,3167L,3407L,3527L,3623L,3767L,3863L,4007L,4127L,4463L,4583L,4703L,4943L };
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
public class A139857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139857Inst : IEnumerable<long>
{
public static readonly long[] Value=A139857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139857.Bytes);
public long this[int i]=>Value[i];

public static A139857Inst Instance=new A139857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139858
{
public static readonly long[] Value={ 17L,113L,137L,233L,257L,353L,593L,617L,857L,953L,977L,1097L,1193L,1217L,1433L,1553L,1697L,1913L,2153L,2273L,2297L,2393L,2417L,2633L,2657L,2753L,2777L,2897L,3137L,3257L,3593L,3617L,3833L,4073L,4217L,4337L,4457L,4673L,4793L,4817L,4937L,5153L };
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
public class A139858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139858Inst : IEnumerable<long>
{
public static readonly long[] Value=A139858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139858.Bytes);
public long this[int i]=>Value[i];

public static A139858Inst Instance=new A139858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139859
{
public static readonly long[] Value={ 11L,59L,131L,179L,251L,419L,491L,659L,971L,1019L,1091L,1259L,1451L,1499L,1571L,1619L,1811L,1931L,1979L,2099L,2339L,2411L,2459L,2531L,2579L,2699L,2819L,2939L,3011L,3251L,3299L,3371L,3491L,3539L,3659L,3779L,3851L,4019L,4091L,4139L,4211L,4259L };
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
public class A139859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139859Inst : IEnumerable<long>
{
public static readonly long[] Value=A139859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139859.Bytes);
public long this[int i]=>Value[i];

public static A139859Inst Instance=new A139859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139860
{
public static readonly long[] Value={ 13L,37L,157L,277L,373L,397L,613L,733L,757L,853L,877L,997L,1093L,1117L,1213L,1237L,1453L,1597L,1693L,1933L,2053L,2293L,2437L,2557L,2677L,2797L,2917L,3037L,3253L,3373L,3517L,3613L,3637L,3733L,3853L,3877L,4093L,4357L,4597L,4813L,4933L,4957L };
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
public class A139860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139860Inst : IEnumerable<long>
{
public static readonly long[] Value=A139860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139860.Bytes);
public long this[int i]=>Value[i];

public static A139860Inst Instance=new A139860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139861
{
public static readonly long[] Value={ 2L,67L,73L,83L,97L,137L,163L,193L,227L,307L,353L,457L,577L,587L,593L,617L,643L,683L,787L,827L,947L,977L,1033L,1097L,1123L,1163L,1217L,1307L,1523L,1553L,1627L,1657L,1697L,1723L,1747L,1753L,1787L,1867L,1913L,1987L,2017L,2113L,2137L,2153L,2203L };
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
public class A139861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139861Inst : IEnumerable<long>
{
public static readonly long[] Value=A139861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139861.Bytes);
public long this[int i]=>Value[i];

public static A139861Inst Instance=new A139861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139862
{
public static readonly long[] Value={ 5L,31L,71L,109L,149L,151L,229L,239L,271L,349L,359L,421L,431L,461L,479L,509L,541L,631L,661L,709L,821L,839L,941L,1021L,1061L,1151L,1181L,1229L,1279L,1319L,1399L,1471L,1549L,1669L,1709L,1789L,1831L,1861L,1879L,2039L,2069L,2111L,2221L,2269L,2309L };
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
public class A139862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139862Inst : IEnumerable<long>
{
public static readonly long[] Value=A139862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139862.Bytes);
public long this[int i]=>Value[i];

public static A139862Inst Instance=new A139862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139863
{
public static readonly long[] Value={ 13L,23L,53L,103L,127L,157L,173L,263L,277L,367L,373L,503L,607L,647L,653L,677L,727L,757L,797L,823L,887L,997L,1013L,1063L,1093L,1117L,1213L,1223L,1277L,1303L,1327L,1447L,1453L,1543L,1583L,1613L,1637L,1663L,1693L,1733L,1823L,1847L,1933L,1973L,2053L };
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
public class A139863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139863Inst : IEnumerable<long>
{
public static readonly long[] Value=A139863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139863.Bytes);
public long this[int i]=>Value[i];

public static A139863Inst Instance=new A139863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139912
{
public static readonly long[] Value={ 23L,107L,179L,191L,263L,347L,443L,491L,599L,659L,911L,1031L,1187L,1283L,1439L,1499L,1583L,1667L,1871L,2003L,2027L,2207L,2339L,2447L,2531L,2591L,2843L,2963L,3119L,3299L,3371L,3467L,3539L,3623L,3719L,3767L,3851L,4211L,4391L,4463L,4523L,4547L };
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
public class A139912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139912Inst : IEnumerable<long>
{
public static readonly long[] Value=A139912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139912.Bytes);
public long this[int i]=>Value[i];

public static A139912Inst Instance=new A139912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139913
{
public static readonly long[] Value={ 17L,101L,173L,257L,269L,521L,677L,797L,857L,881L,1013L,1049L,1109L,1193L,1277L,1301L,1361L,1433L,1613L,1637L,1889L,1949L,1973L,2141L,2357L,2393L,2441L,2609L,2729L,2861L,3041L,3449L,3461L,3533L,3617L,3701L,3797L,3821L,4073L,4133L,4157L,4241L };
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
public class A139913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139913Inst : IEnumerable<long>
{
public static readonly long[] Value=A139913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139913.Bytes);
public long this[int i]=>Value[i];

public static A139913Inst Instance=new A139913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139914
{
public static readonly long[] Value={ 71L,79L,151L,191L,239L,359L,431L,599L,631L,751L,911L,919L,991L,1031L,1439L,1471L,1759L,1831L,1871L,1999L,2039L,2111L,2311L,2591L,2671L,2711L,2879L,3119L,3271L,3319L,3511L,3719L,4111L,4159L,4271L,4391L,4519L,4799L,4831L,4951L,4999L,5119L };
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
public class A139914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139914Inst : IEnumerable<long>
{
public static readonly long[] Value=A139914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139914.Bytes);
public long this[int i]=>Value[i];

public static A139914Inst Instance=new A139914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139915
{
public static readonly long[] Value={ 5L,61L,101L,181L,229L,269L,349L,461L,509L,661L,829L,941L,1021L,1069L,1109L,1181L,1301L,1669L,1741L,1861L,1949L,2029L,2141L,2309L,2341L,2621L,2749L,2789L,2861L,3181L,3461L,3541L,3701L,3709L,3821L,3989L,4021L,4261L,4549L,4861L,5101L,5309L };
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
public class A139915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139915Inst : IEnumerable<long>
{
public static readonly long[] Value=A139915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139915.Bytes);
public long this[int i]=>Value[i];

public static A139915Inst Instance=new A139915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139916
{
public static readonly long[] Value={ 7L,47L,103L,167L,223L,367L,383L,503L,607L,647L,727L,887L,983L,1063L,1223L,1447L,1487L,1543L,1567L,1783L,1823L,1847L,2063L,2287L,2383L,2663L,2687L,2887L,2903L,3023L,3167L,3407L,3463L,3527L,3583L,3727L,3863L,3967L,4007L,4423L,4567L,4583L,4703L };
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
public class A139916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139916Inst : IEnumerable<long>
{
public static readonly long[] Value=A139916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139916.Bytes);
public long this[int i]=>Value[i];

public static A139916Inst Instance=new A139916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139917
{
public static readonly long[] Value={ 43L,67L,107L,163L,347L,443L,547L,683L,827L,883L,907L,947L,1163L,1187L,1283L,1523L,1667L,1723L,1747L,1787L,2003L,2027L,2083L,2347L,2683L,2843L,2963L,3067L,3187L,3203L,3347L,3467L,3803L,3907L,4027L,4243L,4363L,4523L,4547L,4603L,4643L,5107L };
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
public class A139917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139917Inst : IEnumerable<long>
{
public static readonly long[] Value=A139917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139917.Bytes);
public long this[int i]=>Value[i];

public static A139917Inst Instance=new A139917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139918
{
public static readonly long[] Value={ 37L,53L,197L,277L,317L,373L,557L,613L,653L,757L,877L,1093L,1117L,1213L,1373L,1453L,1493L,1597L,1733L,1877L,1933L,1997L,2053L,2213L,2237L,2293L,2333L,2437L,2557L,2797L,2837L,3413L,3557L,3613L,3637L,3677L,3733L,3917L,4013L,4253L,4397L,4517L };
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
public class A139918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139918Inst : IEnumerable<long>
{
public static readonly long[] Value=A139918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139918.Bytes);
public long this[int i]=>Value[i];

public static A139918Inst Instance=new A139918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139919
{
public static readonly long[] Value={ 17L,73L,97L,257L,313L,353L,433L,577L,593L,857L,937L,1097L,1153L,1193L,1217L,1433L,1553L,1657L,1697L,1753L,1777L,1993L,2113L,2273L,2393L,2593L,2617L,2777L,2833L,2897L,2953L,3433L,3457L,3617L,3673L,3793L,4073L,4177L,4217L,4273L,4297L,4457L };
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
public class A139919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139919Inst : IEnumerable<long>
{
public static readonly long[] Value=A139919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139919.Bytes);
public long this[int i]=>Value[i];

public static A139919Inst Instance=new A139919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139920
{
public static readonly long[] Value={ 19L,59L,131L,139L,251L,419L,619L,691L,811L,859L,971L,1091L,1259L,1291L,1459L,1531L,1571L,1699L,1811L,1931L,1979L,2099L,2131L,2371L,2411L,2539L,2579L,2659L,2819L,2939L,2971L,3251L,3331L,3491L,3499L,3659L,3779L,4051L,4091L,4219L,4259L,4339L };
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
public class A139920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139920Inst : IEnumerable<long>
{
public static readonly long[] Value=A139920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139920.Bytes);
public long this[int i]=>Value[i];

public static A139920Inst Instance=new A139920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139921
{
public static readonly long[] Value={ 3L,107L,131L,179L,251L,347L,419L,443L,467L,491L,563L,659L,971L,1091L,1187L,1283L,1427L,1499L,1667L,1811L,1907L,1979L,2003L,2027L,2339L,2531L,2843L,2939L,2963L,3251L,3299L,3371L,3467L,3539L,3779L,3851L,3923L,4091L,4211L,4523L,4547L,4787L };
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
public class A139921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139921Inst : IEnumerable<long>
{
public static readonly long[] Value=A139921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139921.Bytes);
public long this[int i]=>Value[i];

public static A139921Inst Instance=new A139921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139922
{
public static readonly long[] Value={ 79L,103L,127L,199L,367L,439L,607L,727L,751L,823L,919L,991L,1039L,1063L,1231L,1303L,1327L,1447L,1543L,1663L,1759L,1951L,1999L,2239L,2287L,2311L,2383L,2551L,2791L,2887L,3319L,3511L,3559L,3631L,3727L,3823L,3847L,3943L,4111L,4159L,4423L,4447L };
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
public class A139922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139922Inst : IEnumerable<long>
{
public static readonly long[] Value=A139922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139922.Bytes);
public long this[int i]=>Value[i];

public static A139922Inst Instance=new A139922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139923
{
public static readonly long[] Value={ 47L,71L,167L,239L,359L,383L,431L,479L,743L,839L,863L,983L,1103L,1151L,1319L,1367L,1487L,1607L,2039L,2087L,2111L,2351L,2399L,2423L,2543L,2663L,2711L,2879L,2927L,3023L,3167L,3191L,3359L,3671L,3863L,3911L,4127L,4271L,4583L,4751L,4799L,4919L };
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
public class A139923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139923Inst : IEnumerable<long>
{
public static readonly long[] Value=A139923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139923.Bytes);
public long this[int i]=>Value[i];

public static A139923Inst Instance=new A139923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139924
{
public static readonly long[] Value={ 41L,89L,137L,281L,353L,401L,449L,593L,617L,761L,929L,977L,1097L,1217L,1289L,1409L,1553L,1601L,1697L,1721L,1913L,2153L,2273L,2633L,2657L,2777L,2801L,2897L,2969L,3089L,3209L,3257L,3593L,3833L,3881L,4049L,4217L,4337L,4409L,4457L,4649L,4673L };
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
public class A139924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139924Inst : IEnumerable<long>
{
public static readonly long[] Value=A139924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139924.Bytes);
public long this[int i]=>Value[i];

public static A139924Inst Instance=new A139924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139925
{
public static readonly long[] Value={ 29L,53L,101L,173L,269L,389L,653L,677L,701L,797L,1013L,1109L,1277L,1301L,1613L,1637L,1733L,1901L,1949L,1973L,2141L,2213L,2237L,2357L,2549L,2837L,2861L,2909L,3221L,3389L,3461L,3533L,3701L,3797L,3821L,3917L,4013L,4133L,4157L,4229L,4397L,4421L };
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
public class A139925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139925Inst : IEnumerable<long>
{
public static readonly long[] Value=A139925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139925.Bytes);
public long this[int i]=>Value[i];

public static A139925Inst Instance=new A139925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139926
{
public static readonly long[] Value={ 13L,37L,109L,229L,349L,397L,421L,541L,613L,661L,709L,733L,853L,877L,1021L,1237L,1549L,1597L,1669L,1789L,1861L,2221L,2269L,2293L,2437L,2749L,2797L,2917L,3037L,3061L,3109L,3229L,3373L,3469L,3517L,3541L,3733L,3853L,4093L,4357L,4597L,4621L,4789L };
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
public class A139926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139926Inst : IEnumerable<long>
{
public static readonly long[] Value=A139926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139926.Bytes);
public long this[int i]=>Value[i];

public static A139926Inst Instance=new A139926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139927
{
public static readonly long[] Value={ 19L,67L,163L,307L,331L,379L,499L,619L,643L,691L,739L,787L,811L,1051L,1123L,1579L,1627L,1723L,1747L,1867L,1987L,2179L,2203L,2251L,2347L,2371L,2659L,2683L,2803L,2971L,3187L,3307L,3499L,3547L,3739L,3907L,3931L,4051L,4219L,4243L,4363L,4483L };
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
public class A139927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139927Inst : IEnumerable<long>
{
public static readonly long[] Value=A139927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139927.Bytes);
public long this[int i]=>Value[i];

public static A139927Inst Instance=new A139927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139960
{
public static readonly long[] Value={ 37L,61L,109L,181L,277L,397L,541L,709L,853L,877L,997L,1093L,1117L,1213L,1621L,1669L,1693L,1741L,1933L,2029L,2221L,2341L,2437L,2557L,2749L,2917L,3037L,3253L,3301L,3373L,3541L,3709L,3733L,3853L,4261L,4357L,4549L,4597L,4621L,4789L,4933L,4957L };
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
public class A139960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139960Inst : IEnumerable<long>
{
public static readonly long[] Value=A139960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139960.Bytes);
public long this[int i]=>Value[i];

public static A139960Inst Instance=new A139960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139961
{
public static readonly long[] Value={ 17L,41L,113L,233L,401L,449L,521L,617L,641L,809L,857L,881L,929L,1049L,1193L,1217L,1289L,1433L,1553L,1601L,1697L,2081L,2153L,2273L,2417L,2441L,2657L,2777L,2897L,2969L,3089L,3257L,3329L,3593L,3881L,4001L,4049L,4073L,4289L,4409L,4457L,4481L };
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
public class A139961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139961Inst : IEnumerable<long>
{
public static readonly long[] Value=A139961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139961.Bytes);
public long this[int i]=>Value[i];

public static A139961Inst Instance=new A139961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139962
{
public static readonly long[] Value={ 23L,71L,167L,311L,431L,479L,503L,719L,743L,839L,887L,911L,983L,1031L,1151L,1319L,1367L,1439L,1559L,1847L,2063L,2111L,2207L,2351L,2543L,2591L,2663L,2879L,2927L,2999L,3023L,3167L,3191L,3359L,3407L,3767L,4007L,4391L,4583L,4703L,4799L,4919L };
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
public class A139962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139962Inst : IEnumerable<long>
{
public static readonly long[] Value=A139962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139962.Bytes);
public long this[int i]=>Value[i];

public static A139962Inst Instance=new A139962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139963
{
public static readonly long[] Value={ 2L,233L,239L,263L,281L,359L,431L,569L,743L,809L,953L,1031L,1289L,1481L,1583L,1913L,2081L,2087L,2111L,2129L,2153L,2207L,2417L,2543L,2591L,2657L,2801L,2879L,2969L,3119L,3137L,3329L,3593L,3761L,3929L,4001L,4127L,4391L,4463L,4649L,4817L,4967L };
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
public class A139963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139963Inst : IEnumerable<long>
{
public static readonly long[] Value=A139963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139963.Bytes);
public long this[int i]=>Value[i];

public static A139963Inst Instance=new A139963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139964
{
public static readonly long[] Value={ 3L,157L,181L,229L,397L,619L,643L,661L,691L,829L,859L,1021L,1123L,1237L,1291L,1483L,1699L,1741L,2029L,2203L,2341L,2467L,2539L,2677L,2707L,2803L,2971L,3037L,3331L,3499L,3547L,3853L,3877L,4051L,4093L,4261L,4339L,4357L,4651L,4723L,4933L,4987L };
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
public class A139964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139964Inst : IEnumerable<long>
{
public static readonly long[] Value=A139964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139964.Bytes);
public long this[int i]=>Value[i];

public static A139964Inst Instance=new A139964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139965
{
public static readonly long[] Value={ 83L,101L,131L,173L,227L,293L,461L,563L,677L,941L,1091L,1427L,1613L,1811L,1931L,1949L,1979L,2141L,2243L,2309L,2411L,2477L,2789L,2939L,3251L,3461L,3533L,3659L,3779L,3797L,3923L,3989L,4091L,4133L,4157L,4259L,4373L,4451L,4637L,4787L,5099L,5309L };
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
public class A139965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139965Inst : IEnumerable<long>
{
public static readonly long[] Value=A139965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139965.Bytes);
public long this[int i]=>Value[i];

public static A139965Inst Instance=new A139965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139966
{
public static readonly long[] Value={ 7L,73L,241L,271L,409L,439L,601L,607L,769L,937L,1063L,1231L,1249L,1399L,1447L,1657L,1777L,1993L,2089L,2239L,2287L,2383L,2551L,2593L,2617L,2719L,2791L,2833L,3079L,3121L,3559L,3583L,3673L,3769L,3967L,4177L,4231L,4297L,4441L,4567L,4639L,4759L };
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
public class A139966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139966Inst : IEnumerable<long>
{
public static readonly long[] Value=A139966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139966.Bytes);
public long this[int i]=>Value[i];

public static A139966Inst Instance=new A139966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139967
{
public static readonly long[] Value={ 11L,53L,179L,317L,389L,443L,653L,683L,947L,1061L,1373L,1499L,1523L,1709L,1787L,1901L,2003L,2027L,2069L,2237L,2333L,2381L,2531L,2699L,2843L,2909L,2963L,3221L,3347L,3371L,3389L,3413L,3557L,3677L,3851L,3917L,4013L,4019L,4139L,4211L,4229L,4349L };
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
public class A139967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139967Inst : IEnumerable<long>
{
public static readonly long[] Value=A139967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139967.Bytes);
public long this[int i]=>Value[i];

public static A139967Inst Instance=new A139967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139968
{
public static readonly long[] Value={ 47L,89L,257L,311L,353L,383L,521L,647L,719L,839L,881L,929L,983L,1049L,1193L,1433L,1511L,1697L,1721L,2399L,2663L,2687L,2729L,2777L,2897L,3023L,3041L,3191L,3359L,3617L,3881L,4007L,4049L,4073L,4079L,4217L,4409L,4679L,4871L,4889L,5039L,5087L };
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
public class A139968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139968Inst : IEnumerable<long>
{
public static readonly long[] Value=A139968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139968.Bytes);
public long this[int i]=>Value[i];

public static A139968Inst Instance=new A139968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139969
{
public static readonly long[] Value={ 43L,109L,211L,277L,373L,541L,547L,571L,613L,739L,877L,1051L,1117L,1381L,1429L,1579L,1597L,1723L,1789L,1933L,2053L,2221L,2251L,2389L,2437L,2683L,2851L,3109L,3187L,3229L,3571L,3637L,3691L,3739L,3907L,4099L,4243L,4363L,4813L,4957L,5077L,5419L };
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
public class A139969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139969Inst : IEnumerable<long>
{
public static readonly long[] Value=A139969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139969.Bytes);
public long this[int i]=>Value[i];

public static A139969Inst Instance=new A139969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139970
{
public static readonly long[] Value={ 131L,139L,179L,211L,251L,419L,491L,571L,659L,859L,971L,1091L,1171L,1291L,1459L,1499L,1531L,1699L,1811L,1979L,2011L,2131L,2339L,2531L,2539L,2731L,2851L,2939L,3019L,3251L,3259L,3299L,3331L,3371L,3539L,3571L,3691L,3779L,3851L,4091L,4099L,4211L };
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
public class A139970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139970Inst : IEnumerable<long>
{
public static readonly long[] Value=A139970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139970.Bytes);
public long this[int i]=>Value[i];

public static A139970Inst Instance=new A139970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139971
{
public static readonly long[] Value={ 5L,109L,149L,229L,349L,421L,461L,509L,541L,661L,709L,821L,941L,1021L,1061L,1181L,1229L,1549L,1669L,1709L,1789L,1861L,2069L,2221L,2269L,2309L,2381L,2621L,2741L,2749L,2789L,3061L,3109L,3229L,3469L,3541L,3581L,3989L,4349L,4621L,4789L,4909L };
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
public class A139971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139971Inst : IEnumerable<long>
{
public static readonly long[] Value=A139971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139971.Bytes);
public long this[int i]=>Value[i];

public static A139971Inst Instance=new A139971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139972
{
public static readonly long[] Value={ 73L,97L,137L,193L,353L,457L,577L,593L,617L,977L,1033L,1097L,1217L,1553L,1657L,1697L,1753L,1913L,2017L,2113L,2137L,2153L,2273L,2377L,2593L,2633L,2657L,2777L,2897L,2953L,3217L,3257L,3313L,3593L,3673L,3697L,3833L,4153L,4217L,4297L,4337L,4457L };
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
public class A139972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139972Inst : IEnumerable<long>
{
public static readonly long[] Value=A139972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139972.Bytes);
public long this[int i]=>Value[i];

public static A139972Inst Instance=new A139972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139973
{
public static readonly long[] Value={ 67L,83L,163L,227L,307L,587L,643L,683L,787L,827L,947L,1123L,1163L,1307L,1523L,1627L,1723L,1747L,1787L,1867L,1987L,2203L,2243L,2267L,2347L,2683L,2803L,3083L,3187L,3203L,3307L,3323L,3347L,3547L,3803L,3907L,3947L,4243L,4283L,4363L,4483L,4643L };
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
public class A139973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139973Inst : IEnumerable<long>
{
public static readonly long[] Value=A139973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139973.Bytes);
public long this[int i]=>Value[i];

public static A139973Inst Instance=new A139973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139974
{
public static readonly long[] Value={ 13L,53L,157L,173L,277L,373L,653L,677L,757L,797L,997L,1013L,1093L,1117L,1213L,1277L,1453L,1613L,1637L,1693L,1733L,1933L,1973L,2053L,2213L,2237L,2357L,2557L,2677L,2837L,3253L,3533L,3613L,3637L,3797L,3877L,3917L,4013L,4133L,4157L,4397L,4637L };
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
public class A139974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139974Inst : IEnumerable<long>
{
public static readonly long[] Value=A139974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139974.Bytes);
public long this[int i]=>Value[i];

public static A139974Inst Instance=new A139974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139975
{
public static readonly long[] Value={ 31L,71L,151L,239L,271L,359L,431L,479L,631L,839L,1151L,1279L,1319L,1399L,1471L,1831L,1879L,2039L,2111L,2351L,2399L,2671L,2711L,2719L,2879L,3079L,3191L,3271L,3359L,3391L,3671L,3911L,3919L,4231L,4271L,4519L,4591L,4639L,4751L,4799L,4831L,4919L };
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
public class A139975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139975Inst : IEnumerable<long>
{
public static readonly long[] Value=A139975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139975.Bytes);
public long this[int i]=>Value[i];

public static A139975Inst Instance=new A139975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140008
{
public static readonly long[] Value={ 79L,151L,271L,439L,919L,1231L,1399L,1471L,1759L,1999L,2239L,2551L,2719L,2791L,3079L,3319L,3511L,3559L,4111L,4231L,4639L,4759L,4831L,5431L,6079L,6151L,6199L,6679L,6871L,6991L,7039L,8191L,8311L,8599L,8719L,8839L,9151L,9319L,9391L,9511L,9631L };
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
public class A140008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140008Inst : IEnumerable<long>
{
public static readonly long[] Value=A140008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140008.Bytes);
public long this[int i]=>Value[i];

public static A140008Inst Instance=new A140008Inst();

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