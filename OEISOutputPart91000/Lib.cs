using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A111679
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,4L,9L,25L,49L,13L,17L,19L,23L,29L,6L,10L,14L,15L,21L,22L,31L,37L,41L,43L,47L,53L,59L,8L,27L,125L,343L,1331L,2197L,4913L,6859L,121L,169L,289L,361L,529L,841L,961L,1369L,1681L,26L,33L,34L,35L,38L,39L,46L,51L,55L,57L,61L,67L,71L,73L,79L,83L,89L,97L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111679Inst : IEnumerable<long>
{
public static readonly long[] Value=A111679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111679.Bytes);
public long this[int i]=>Value[i];

public static A111679Inst Instance=new A111679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111680
{
public static readonly long[] Value={ 1L,3L,11L,49L,29L,22L,59L,6859L,1681L,57L,107L,76L,179L,95L,146L,7890481L,271L,242L,389L,412L,217L,301L,541L,472L,26569L,391L,3307949L,692L,727L,285L,941L,38579489651L,502L,623L,746L,14884L,1201L,879L,1018L,1544L,1493L,598L,1823L,1132L,1684L,1191L,2203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111680Inst : IEnumerable<long>
{
public static readonly long[] Value=A111680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111680.Bytes);
public long this[int i]=>Value[i];

public static A111680Inst Instance=new A111680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111681
{
public static readonly long[] Value={ 1L,2L,5L,4L,13L,6L,31L,8L,121L,26L,61L,12L,109L,58L,106L,16L,181L,92L,277L,244L,155L,218L,397L,24L,1849L,302L,12167L,423L,547L,30L,733L,32L,393L,505L,626L,36L,947L,749L,886L,488L,1213L,286L,1499L,711L,1143L,1027L,1831L,48L,27889L,1719L,1195L,2308L,2207L,1576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111681Inst : IEnumerable<long>
{
public static readonly long[] Value=A111681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111681.Bytes);
public long this[int i]=>Value[i];

public static A111681Inst Instance=new A111681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111682
{
public static readonly BigInteger[] Value={ 1L,76L,16416L,6798016L,4551356800L,4470007597056L,6043460975190016L,10752691472850927616UL,BigInteger.Parse("24343005503622220775424"),BigInteger.Parse("68309311335401364275200000"),BigInteger.Parse("232660170298374017479641923584") };
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
public class A111682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111682Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111682.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111682.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111682Inst Instance=new A111682Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111683
{
public static readonly BigInteger[] Value={ 2L,3L,40L,5L,576L,11767L,221824L,168561L,6371200L,174442081L,4680778752L,4377478573L,202076363776L,7342081491375L,260552186822656L,226934809133761L,14420591159943168L,677361585374052121L,BigInteger.Parse("30335097991823360000") };
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
public class A111683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111683Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111683.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111683.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111683Inst Instance=new A111683Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111684
{
public static readonly long[] Value={ 2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,8L,8L,9L,9L,10L,10L,11L,11L,12L,12L,13L,13L,14L,15L,15L,16L,16L,17L,17L,18L,18L,19L,19L,20L,21L,21L,22L,22L,23L,23L,24L,24L,25L,25L,26L,26L,27L,28L,28L,29L,29L,30L,30L,31L,31L,32L,32L,33L,34L,34L,35L,35L,36L,36L,37L,37L,38L,38L,39L,39L,40L,41L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111684Inst : IEnumerable<long>
{
public static readonly long[] Value=A111684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111684.Bytes);
public long this[int i]=>Value[i];

public static A111684Inst Instance=new A111684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111685
{
public static readonly BigInteger[] Value={ 1L,8L,75L,984L,17045L,366288L,9374967L,278095760L,9375293169L,353906211240L,14785127222723L,677150215857192L,33734100501544365L,1816008001717251104L,BigInteger.Parse("105048613959883117935"),BigInteger.Parse("6497985798745934394528"),BigInteger.Parse("427999600108502895779657") };
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
public class A111685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111685Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111685.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111685.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111685Inst Instance=new A111685Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111686
{
public static readonly BigInteger[] Value={ 2L,15L,144L,1925L,33648L,726327L,18636560L,553680369L,18684924840L,705833193923L,29502690532392L,1351724235304365L,67359683340291104L,3627011494019437935L,BigInteger.Parse("209846445862386234528"),BigInteger.Parse("12982402818188717219657"),BigInteger.Parse("855210841645834409812920") };
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
public class A111686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111686Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111686.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111686.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111686Inst Instance=new A111686Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111687
{
public static readonly BigInteger[] Value={ 8L,144L,5760L,362880L,39916800L,6227020800L,1482030950400L,422378820864000L,155435406077952000L,BigInteger.Parse("81137281972690944000"),BigInteger.Parse("50305114823068385280000"),BigInteger.Parse("39087074217524135362560000"),BigInteger.Parse("35256540944206770097029120000") };
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
public class A111687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111687Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111687.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111687.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111687Inst Instance=new A111687Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111688
{
public static readonly long[] Value={ 2L,4L,5L,6L,7L,8L,11L,12L,13L,14L,17L,18L,19L,20L,23L,24L,29L,30L,31L,32L,37L,38L,41L,42L,43L,44L,47L,48L,53L,54L,59L,60L,61L,62L,67L,68L,71L,72L,73L,74L,79L,80L,83L,84L,89L,90L,97L,98L,101L,102L,103L,104L,107L,108L,109L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111688Inst : IEnumerable<long>
{
public static readonly long[] Value=A111688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111688.Bytes);
public long this[int i]=>Value[i];

public static A111688Inst Instance=new A111688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111689
{
public static readonly long[] Value={ 2L,9L,3L,4L,5L,6L,7L,8L,11L,10L,13L,12L,17L,14L,19L,15L,23L,16L,29L,18L,31L,20L,37L,21L,41L,22L,43L,24L,47L,25L,53L,26L,59L,27L,61L,28L,67L,30L,71L,32L,73L,33L,79L,34L,83L,35L,89L,36L,97L,38L,101L,39L,103L,40L,107L,42L,109L,44L,113L,45L,127L,46L,131L,48L,137L,49L,139L,50L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111689Inst : IEnumerable<long>
{
public static readonly long[] Value=A111689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111689.Bytes);
public long this[int i]=>Value[i];

public static A111689Inst Instance=new A111689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111690
{
public static readonly BigInteger[] Value={ 1L,1L,333L,1L,1L,83333L,1428571L,1L,111111111L,1L,909090909L,83333333333L,76923076923L,7142857142857L,33333333333333L,1L,588235294117647L,11111111111111111L,52631578947368421L,1L,BigInteger.Parse("47619047619047619047") };
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
public class A111690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111690Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111690.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111690.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111690Inst Instance=new A111690Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111691
{
public static readonly long[] Value={ 9L,9L,9L,9L,6L,1L,9L,2L,1L,6L,1L,4L,2L,0L,7L,8L,2L,4L,7L,2L,5L,2L,3L,7L,8L,6L,3L,6L,0L,4L,9L,4L,7L,1L,2L,5L,5L,1L,7L,1L,0L,2L,7L,3L,4L,3L,7L,7L,2L,7L,5L,8L,3L,5L,7L,7L,6L,6L,7L,5L,4L,1L,2L,7L,9L,3L,4L,3L,1L,1L,6L,5L,2L,6L,6L,0L,7L,4L,4L,7L,5L,8L,7L,0L,7L,9L,3L,4L,0L,4L,7L,1L,9L,4L,5L,0L,8L,8L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111691Inst : IEnumerable<long>
{
public static readonly long[] Value=A111691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111691.Bytes);
public long this[int i]=>Value[i];

public static A111691Inst Instance=new A111691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111692
{
public static readonly long[] Value={ 9L,9L,9L,9L,6L,9L,5L,3L,7L,1L,7L,5L,3L,6L,7L,4L,1L,5L,7L,8L,7L,5L,8L,6L,3L,9L,6L,4L,1L,2L,4L,8L,1L,6L,0L,7L,4L,4L,3L,8L,4L,5L,4L,7L,9L,3L,7L,2L,2L,8L,0L,1L,1L,8L,2L,0L,6L,8L,2L,5L,6L,8L,1L,9L,1L,6L,0L,1L,9L,3L,4L,8L,7L,7L,9L,5L,7L,2L,2L,8L,6L,0L,3L,2L,1L,8L,5L,9L,7L,8L,5L,1L,0L,4L,8L,3L,2L,0L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111692Inst : IEnumerable<long>
{
public static readonly long[] Value=A111692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111692.Bytes);
public long this[int i]=>Value[i];

public static A111692Inst Instance=new A111692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111693
{
public static readonly long[] Value={ 3L,11L,29L,53L,83L,127L,173L,227L,293L,367L,443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111693Inst : IEnumerable<long>
{
public static readonly long[] Value=A111693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111693.Bytes);
public long this[int i]=>Value[i];

public static A111693Inst Instance=new A111693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111694
{
public static readonly long[] Value={ 0L,8L,26L,57L,104L,170L,258L,371L,512L,684L,890L,1133L,1416L,1742L,2114L,2535L,3008L,3536L,4122L,4769L,5480L,6258L,7106L,8027L,9024L,10100L,11258L,12501L,13832L,15254L,16770L,18383L,20096L,21912L,23834L,25865L,28008L,30266L,32642L,35139L,37760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111694Inst : IEnumerable<long>
{
public static readonly long[] Value=A111694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111694.Bytes);
public long this[int i]=>Value[i];

public static A111694Inst Instance=new A111694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111695
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,10L,121L,792L,3718L,14014L,45045L,128128L,330616L,787644L,1755182L,190L,4410L,53361L,448063L,2932776L,15939000L,74824750L,311698530L,1174863690L,4066092030L,4060L,139345L,2460160L,29767936L,277513984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111695Inst : IEnumerable<long>
{
public static readonly long[] Value=A111695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111695.Bytes);
public long this[int i]=>Value[i];

public static A111695Inst Instance=new A111695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111696
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,11L,22L,78L,299L,1015L,3018L,8024L,19465L,43776L,92397L,191L,231L,462L,2024L,10902L,53430L,230555L,888381L,3108483L,10015411L,4061L,4526L,5456L,10912L,52360L,331177L,1954932L,10303242L,48911928L,211924271L,91391L,101311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111696Inst : IEnumerable<long>
{
public static readonly long[] Value=A111696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111696.Bytes);
public long this[int i]=>Value[i];

public static A111696Inst Instance=new A111696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111697
{
public static readonly long[] Value={ 464L,496L,696L,944L,4446L,4496L,4664L,6444L,6669L,6996L,9666L,9944L,44649L,44664L,44694L,44696L,44946L,44964L,46664L,46696L,49446L,49496L,49944L,64664L,66664L,66996L,69464L,69944L,69996L,94996L,96464L,96664L,96996L,99664L,99946L,99996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111697Inst : IEnumerable<long>
{
public static readonly long[] Value=A111697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111697.Bytes);
public long this[int i]=>Value[i];

public static A111697Inst Instance=new A111697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111698
{
public static readonly long[] Value={ 1L,5L,9L,2L,7L,12L,3L,10L,15L,4L,13L,18L,6L,16L,21L,8L,19L,24L,11L,22L,27L,14L,25L,30L,17L,28L,33L,20L,31L,36L,23L,34L,39L,26L,37L,42L,29L,40L,45L,32L,43L,48L,35L,46L,51L,38L,49L,54L,41L,52L,57L,44L,55L,60L,47L,58L,63L,50L,61L,66L,53L,64L,69L,56L,67L,72L,59L,70L,75L,62L,73L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111698Inst : IEnumerable<long>
{
public static readonly long[] Value=A111698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111698.Bytes);
public long this[int i]=>Value[i];

public static A111698Inst Instance=new A111698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111699
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,7L,13L,9L,16L,10L,22L,19L,31L,25L,11L,24L,42L,35L,6L,23L,40L,28L,53L,43L,5L,33L,58L,44L,73L,63L,20L,49L,75L,52L,14L,39L,86L,65L,21L,54L,100L,88L,30L,64L,17L,61L,115L,96L,38L,71L,113L,85L,142L,121L,78L,36L,98L,56L,132L,114L,177L,148L,105L,60L,125L,97L,174L,141L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111699Inst : IEnumerable<long>
{
public static readonly long[] Value=A111699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111699.Bytes);
public long this[int i]=>Value[i];

public static A111699Inst Instance=new A111699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111700
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,3L,1L,0L,1L,0L,1L,5L,1L,1L,0L,3L,0L,1L,1L,1L,1L,1L,0L,3L,0L,1L,0L,3L,3L,1L,0L,1L,1L,0L,3L,1L,1L,1L,0L,1L,1L,0L,3L,5L,1L,0L,1L,5L,1L,3L,0L,1L,1L,3L,1L,1L,1L,1L,3L,1L,3L,3L,0L,3L,0L,1L,1L,1L,3L,1L,0L,1L,3L,3L,1L,3L,1L,1L,3L,0L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111700Inst : IEnumerable<long>
{
public static readonly long[] Value=A111700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111700.Bytes);
public long this[int i]=>Value[i];

public static A111700Inst Instance=new A111700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111701
{
public static readonly long[] Value={ 1L,1L,3L,2L,5L,1L,7L,4L,9L,5L,11L,2L,13L,7L,15L,8L,17L,3L,19L,10L,21L,11L,23L,4L,25L,13L,27L,14L,29L,1L,31L,16L,33L,17L,35L,6L,37L,19L,39L,20L,41L,7L,43L,22L,45L,23L,47L,8L,49L,25L,51L,26L,53L,9L,55L,28L,57L,29L,59L,2L,61L,31L,63L,32L,65L,11L,67L,34L,69L,35L,71L,12L,73L,37L,75L,38L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111701Inst : IEnumerable<long>
{
public static readonly long[] Value=A111701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111701.Bytes);
public long this[int i]=>Value[i];

public static A111701Inst Instance=new A111701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111702
{
public static readonly long[] Value={ 3L,2L,2L,6L,6L,12L,12L,4L,12L,8L,30L,10L,20L,10L,20L,6L,18L,12L,6L,12L,12L,28L,42L,14L,42L,70L,14L,28L,48L,32L,16L,56L,40L,8L,16L,24L,18L,54L,36L,18L,36L,18L,72L,18L,90L,30L,60L,20L,10L,20L,30L,60L,10L,20L,40L,66L,44L,22L,66L,110L,132L,22L,44L,22L,44L,66L,12L,72L,48L,12L,36L,24L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111702Inst : IEnumerable<long>
{
public static readonly long[] Value=A111702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111702.Bytes);
public long this[int i]=>Value[i];

public static A111702Inst Instance=new A111702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111703
{
public static readonly long[] Value={ 3L,5L,7L,13L,19L,31L,43L,47L,59L,67L,97L,107L,127L,137L,157L,163L,181L,193L,199L,211L,223L,251L,293L,307L,349L,419L,433L,461L,509L,541L,557L,613L,653L,661L,677L,701L,719L,773L,809L,827L,863L,881L,953L,971L,1061L,1091L,1151L,1171L,1181L,1201L,1231L,1291L,1301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111703Inst : IEnumerable<long>
{
public static readonly long[] Value=A111703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111703.Bytes);
public long this[int i]=>Value[i];

public static A111703Inst Instance=new A111703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111704
{
public static readonly long[] Value={ 1L,4L,9L,16L,25L,36L,49L,64L,81L,100L,1111L,1224L,1339L,1456L,1575L,1696L,17119L,18144L,19171L,400L,4221L,4444L,4669L,4896L,50125L,52156L,54189L,56224L,58261L,900L,9331L,9664L,9999L,102136L,105175L,108216L,111259L,114304L,117351L,1600L,16441L,16884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111704Inst : IEnumerable<long>
{
public static readonly long[] Value=A111704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111704.Bytes);
public long this[int i]=>Value[i];

public static A111704Inst Instance=new A111704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111705
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,101L,102L,103L,104L,105L,106L,1007L,1008L,1009L,20L,201L,202L,203L,204L,2005L,2006L,2007L,2008L,2009L,30L,301L,302L,303L,3004L,3005L,3006L,3007L,3008L,3009L,40L,401L,402L,4003L,4004L,4005L,4006L,4007L,4008L,4009L,50L,501L,5002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111705Inst : IEnumerable<long>
{
public static readonly long[] Value=A111705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111705.Bytes);
public long this[int i]=>Value[i];

public static A111705Inst Instance=new A111705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111706
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,100L,101L,102L,103L,104L,105L,106L,107L,108L,109L,120L,121L,122L,123L,124L,125L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111706Inst : IEnumerable<long>
{
public static readonly long[] Value=A111706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111706.Bytes);
public long this[int i]=>Value[i];

public static A111706Inst Instance=new A111706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111707
{
public static readonly long[] Value={ 1L,4L,9L,16L,25L,36L,49L,64L,81L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,2L,4L,6L,8L,10L,12L,14L,16L,18L,0L,3L,6L,9L,12L,15L,18L,21L,24L,27L,0L,4L,8L,12L,16L,20L,24L,28L,32L,36L,0L,5L,10L,15L,20L,25L,30L,35L,40L,45L,0L,6L,12L,18L,24L,30L,36L,42L,48L,54L,0L,7L,14L,21L,28L,35L,42L,49L,56L,63L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111707Inst : IEnumerable<long>
{
public static readonly long[] Value=A111707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111707.Bytes);
public long this[int i]=>Value[i];

public static A111707Inst Instance=new A111707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111708
{
public static readonly long[] Value={ 9L,18L,27L,36L,45L,54L,63L,72L,81L,90L,1089L,1188L,1287L,1386L,1485L,1584L,1683L,1782L,1881L,1980L,2079L,2178L,2277L,2376L,2475L,2574L,2673L,2772L,2871L,2970L,3069L,3168L,3267L,3366L,3465L,3564L,3663L,3762L,3861L,3960L,4059L,4158L,4257L,4356L,4455L,4554L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111708Inst : IEnumerable<long>
{
public static readonly long[] Value=A111708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111708.Bytes);
public long this[int i]=>Value[i];

public static A111708Inst Instance=new A111708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111709
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,1L,0L,1L,2L,2L,1L,3L,2L,2L,2L,3L,3L,3L,2L,3L,4L,4L,3L,5L,4L,4L,4L,5L,5L,5L,4L,5L,6L,6L,5L,7L,6L,6L,6L,7L,7L,7L,6L,7L,8L,8L,7L,9L,8L,8L,8L,9L,9L,9L,8L,9L,10L,10L,9L,11L,10L,10L,10L,11L,11L,11L,10L,11L,12L,12L,11L,13L,12L,12L,12L,13L,13L,13L,12L,13L,14L,14L,13L,15L,14L,14L,14L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111709Inst : IEnumerable<long>
{
public static readonly long[] Value=A111709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111709.Bytes);
public long this[int i]=>Value[i];

public static A111709Inst Instance=new A111709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111710
{
public static readonly long[] Value={ 1L,4L,7L,13L,18L,27L,34L,46L,55L,70L,81L,99L,112L,133L,148L,172L,189L,216L,235L,265L,286L,319L,342L,378L,403L,442L,469L,511L,540L,585L,616L,664L,697L,748L,783L,837L,874L,931L,970L,1030L,1071L,1134L,1177L,1243L,1288L,1357L,1404L,1476L,1525L,1600L,1651L,1729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111710Inst : IEnumerable<long>
{
public static readonly long[] Value=A111710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111710.Bytes);
public long this[int i]=>Value[i];

public static A111710Inst Instance=new A111710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111711
{
public static readonly long[] Value={ 1L,2L,5L,8L,14L,19L,28L,35L,47L,56L,71L,82L,100L,113L,134L,149L,173L,190L,217L,236L,266L,287L,320L,343L,379L,404L,443L,470L,512L,541L,586L,617L,665L,698L,749L,784L,838L,875L,932L,971L,1031L,1072L,1135L,1178L,1244L,1289L,1358L,1405L,1477L,1526L,1601L,1652L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111711Inst : IEnumerable<long>
{
public static readonly long[] Value=A111711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111711.Bytes);
public long this[int i]=>Value[i];

public static A111711Inst Instance=new A111711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111712
{
public static readonly long[] Value={ 1L,3L,6L,10L,16L,22L,31L,39L,51L,61L,76L,88L,106L,120L,141L,157L,181L,199L,226L,246L,276L,298L,331L,355L,391L,417L,456L,484L,526L,556L,601L,633L,681L,715L,766L,802L,856L,894L,951L,991L,1051L,1093L,1156L,1200L,1266L,1312L,1381L,1429L,1501L,1551L,1626L,1678L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111712Inst : IEnumerable<long>
{
public static readonly long[] Value=A111712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111712.Bytes);
public long this[int i]=>Value[i];

public static A111712Inst Instance=new A111712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111713
{
public static readonly long[] Value={ 0L,1L,2L,14L,108L,930L,8700L,86598L,904176L,9804516L,109624536L,1257136130L,14726063264L,175650153588L,2128038439176L,26133761328150L,324786698542440L,4079191750094776L,51716838331485472L,661227615895716180L,8518677674587163584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111713Inst : IEnumerable<long>
{
public static readonly long[] Value=A111713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111713.Bytes);
public long this[int i]=>Value[i];

public static A111713Inst Instance=new A111713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111714
{
public static readonly long[] Value={ 2L,7L,1L,7L,8L,6L,7L,8L,5L,2L,4L,9L,6L,3L,4L,9L,6L,1L,4L,0L,1L,7L,7L,1L,2L,7L,0L,6L,4L,6L,5L,0L,2L,0L,7L,3L,3L,4L,3L,8L,8L,7L,6L,5L,4L,2L,9L,7L,1L,5L,2L,3L,6L,2L,3L,7L,0L,7L,6L,9L,1L,2L,1L,7L,1L,3L,7L,6L,6L,7L,8L,7L,9L,4L,0L,5L,5L,0L,9L,6L,1L,6L,4L,7L,8L,1L,3L,0L,6L,7L,3L,3L,8L,0L,0L,6L,2L,4L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111714Inst : IEnumerable<long>
{
public static readonly long[] Value=A111714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111714.Bytes);
public long this[int i]=>Value[i];

public static A111714Inst Instance=new A111714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111715
{
public static readonly long[] Value={ 0L,1L,5L,14L,39L,75L,124L,224L,345L,514L,710L,935L,1224L,1585L,2026L,2510L,3039L,3715L,4556L,5456L,6417L,7506L,8662L,9887L,11256L,12700L,14221L,15902L,17666L,19515L,21631L,23840L,26441L,29250L,32275L,35524L,38888L,42369L,46090L,49934L,54159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111715Inst : IEnumerable<long>
{
public static readonly long[] Value=A111715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111715.Bytes);
public long this[int i]=>Value[i];

public static A111715Inst Instance=new A111715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111716
{
public static readonly long[] Value={ 0L,0L,0L,1L,5L,2L,3L,1L,6L,4L,4L,3L,1L,6L,9L,2L,4L,8L,6L,3L,4L,5L,6L,1L,2L,6L,4L,5L,7L,8L,1L,6L,4L,9L,1L,0L,5L,5L,1L,4L,5L,9L,0L,7L,8L,7L,2L,9L,1L,6L,9L,2L,9L,5L,4L,3L,7L,1L,8L,0L,4L,8L,4L,2L,3L,6L,8L,5L,5L,7L,9L,7L,2L,8L,0L,4L,2L,0L,5L,0L,2L,0L,5L,6L,8L,6L,4L,8L,7L,4L,7L,8L,7L,2L,4L,8L,6L,5L,0L,2L,6L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111716Inst : IEnumerable<long>
{
public static readonly long[] Value=A111716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111716.Bytes);
public long this[int i]=>Value[i];

public static A111716Inst Instance=new A111716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111717
{
public static readonly long[] Value={ 3L,6L,7L,9L,3L,5L,4L,7L,5L,2L,5L,9L,2L,1L,9L,9L,8L,6L,8L,5L,5L,9L,5L,4L,9L,3L,6L,4L,4L,0L,2L,3L,8L,3L,8L,7L,1L,7L,4L,0L,8L,1L,6L,5L,4L,2L,1L,1L,8L,5L,8L,2L,1L,2L,6L,6L,4L,8L,7L,7L,5L,8L,3L,0L,7L,3L,2L,4L,2L,6L,4L,0L,1L,3L,0L,6L,4L,7L,0L,2L,8L,6L,4L,4L,6L,7L,7L,2L,6L,4L,7L,2L,9L,6L,6L,2L,8L,4L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111717Inst : IEnumerable<long>
{
public static readonly long[] Value=A111717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111717.Bytes);
public long this[int i]=>Value[i];

public static A111717Inst Instance=new A111717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111718
{
public static readonly long[] Value={ 6L,5L,6L,5L,2L,7L,9L,3L,5L,6L,5L,3L,5L,6L,2L,6L,5L,1L,4L,0L,2L,7L,0L,3L,4L,4L,3L,8L,9L,9L,3L,4L,2L,3L,6L,1L,6L,1L,1L,7L,5L,0L,8L,9L,2L,7L,1L,0L,5L,5L,7L,8L,4L,8L,0L,0L,8L,4L,5L,6L,6L,2L,8L,0L,9L,3L,4L,0L,9L,4L,8L,9L,9L,9L,4L,2L,4L,9L,7L,0L,0L,6L,3L,8L,3L,5L,4L,2L,1L,4L,8L,8L,2L,9L,7L,9L,7L,6L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111718Inst : IEnumerable<long>
{
public static readonly long[] Value=A111718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111718.Bytes);
public long this[int i]=>Value[i];

public static A111718Inst Instance=new A111718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111719
{
public static readonly long[] Value={ 0L,0L,0L,0L,6L,6L,1L,5L,0L,1L,9L,0L,7L,7L,1L,5L,3L,4L,9L,3L,6L,5L,8L,0L,6L,8L,6L,2L,0L,3L,0L,3L,6L,5L,4L,6L,7L,1L,4L,2L,3L,5L,9L,7L,6L,7L,5L,1L,1L,7L,6L,0L,6L,0L,8L,2L,5L,4L,7L,5L,6L,2L,0L,4L,8L,1L,5L,7L,5L,1L,0L,5L,5L,3L,3L,9L,5L,6L,2L,9L,1L,5L,4L,4L,1L,6L,9L,8L,2L,6L,0L,6L,2L,9L,6L,7L,6L,0L,9L,1L,2L,7L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111719Inst : IEnumerable<long>
{
public static readonly long[] Value=A111719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111719.Bytes);
public long this[int i]=>Value[i];

public static A111719Inst Instance=new A111719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111720
{
public static readonly long[] Value={ 1L,5L,1L,1L,7L,1L,1L,4L,3L,7L,7L,7L,0L,0L,4L,7L,3L,9L,8L,6L,8L,1L,5L,2L,3L,4L,0L,3L,8L,7L,3L,4L,6L,8L,2L,2L,7L,6L,2L,1L,7L,3L,5L,2L,2L,7L,1L,5L,7L,8L,6L,7L,1L,9L,5L,3L,8L,8L,7L,8L,0L,9L,3L,5L,6L,9L,0L,6L,5L,5L,9L,1L,3L,5L,4L,6L,0L,9L,8L,3L,2L,1L,4L,8L,0L,9L,3L,1L,4L,8L,7L,3L,9L,3L,4L,4L,5L,3L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111720Inst : IEnumerable<long>
{
public static readonly long[] Value=A111720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111720.Bytes);
public long this[int i]=>Value[i];

public static A111720Inst Instance=new A111720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111721
{
public static readonly long[] Value={ 1L,1L,7L,13L,25L,43L,73L,121L,199L,325L,529L,859L,1393L,2257L,3655L,5917L,9577L,15499L,25081L,40585L,65671L,106261L,171937L,278203L,450145L,728353L,1178503L,1906861L,3085369L,4992235L,8077609L,13069849L,21147463L,34217317L,55364785L,89582107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111721Inst : IEnumerable<long>
{
public static readonly long[] Value=A111721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111721.Bytes);
public long this[int i]=>Value[i];

public static A111721Inst Instance=new A111721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111722
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,9L,2L,8L,2L,9L,4L,7L,0L,7L,5L,9L,3L,0L,4L,7L,2L,6L,9L,4L,8L,3L,0L,7L,7L,9L,2L,7L,9L,2L,2L,4L,1L,4L,2L,9L,6L,1L,9L,8L,7L,2L,4L,7L,3L,2L,4L,2L,6L,5L,2L,2L,5L,9L,6L,8L,2L,1L,3L,4L,1L,0L,1L,2L,1L,2L,1L,6L,6L,0L,9L,8L,2L,5L,1L,4L,5L,1L,2L,6L,0L,5L,8L,0L,8L,2L,4L,9L,7L,9L,7L,4L,4L,8L,3L,2L,9L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111722Inst : IEnumerable<long>
{
public static readonly long[] Value=A111722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111722.Bytes);
public long this[int i]=>Value[i];

public static A111722Inst Instance=new A111722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111723
{
public static readonly long[] Value={ 1L,0L,4L,4L,31L,86L,449L,1968L,10420L,56582L,333235L,2069772L,13606113L,94065232L,682242552L,5175100432L,40954340995L,337362555010L,2886922399649L,25616738519384L,235313456176512L,2234350827008170L,21899832049913999L,221292603495494488L,2302631998398438321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111723Inst : IEnumerable<long>
{
public static readonly long[] Value=A111723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111723.Bytes);
public long this[int i]=>Value[i];

public static A111723Inst Instance=new A111723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111724
{
public static readonly long[] Value={ 0L,2L,1L,11L,21L,117L,428L,2172L,10727L,59393L,345335L,2143825L,14038324L,96834090L,700715993L,5305041715L,41910528809L,344714251149L,2945819805408L,26107419715988L,239556359980239L,2272364911439153L,22252173805170347L,224666265799310801L,2335958333831561032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111724Inst : IEnumerable<long>
{
public static readonly long[] Value=A111724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111724.Bytes);
public long this[int i]=>Value[i];

public static A111724Inst Instance=new A111724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111725
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,3L,2L,2L,4L,3L,4L,2L,4L,4L,8L,2L,6L,4L,6L,4L,10L,7L,8L,4L,6L,6L,12L,4L,8L,8L,12L,8L,8L,6L,12L,6L,8L,8L,16L,6L,12L,12L,8L,10L,22L,8L,12L,8L,16L,8L,24L,6L,16L,14L,18L,12L,28L,8L,16L,8L,24L,16L,24L,12L,20L,16L,30L,8L,24L,14L,24L,12L,16L,18L,24L,8L,24L,24L,18L,16L,40L,14L,32L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111725Inst : IEnumerable<long>
{
public static readonly long[] Value=A111725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111725.Bytes);
public long this[int i]=>Value[i];

public static A111725Inst Instance=new A111725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111726
{
public static readonly long[] Value={ 4L,15L,78L,58L,67L,97L,101L,120L,110L,174L,160L,214L,239L,261L,557L,548L,1287L,1274L,1524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111726Inst : IEnumerable<long>
{
public static readonly long[] Value=A111726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111726.Bytes);
public long this[int i]=>Value[i];

public static A111726Inst Instance=new A111726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111727
{
public static readonly BigInteger[] Value={ 5L,1834560L,BigInteger.Parse("517517500266693633076805172570524811961093324800"),BigInteger.Parse("4244773998140675903976169144320000"),BigInteger.Parse("3976213947924477545093906865809650247270400"),BigInteger.Parse("12291248474277267848395134563637563923813851715476607482451722240") };
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
public class A111727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111727Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111727.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111727.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111727Inst Instance=new A111727Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111728
{
public static readonly long[] Value={ 1L,4L,0L,1L,0L,1L,9L,6L,6L,5L,3L,2L,7L,6L,9L,3L,5L,6L,0L,3L,3L,2L,8L,3L,8L,6L,9L,2L,8L,3L,2L,9L,4L,7L,0L,0L,8L,7L,9L,2L,8L,9L,9L,1L,0L,9L,3L,8L,4L,6L,3L,4L,1L,5L,8L,4L,8L,9L,8L,9L,1L,8L,6L,6L,8L,9L,1L,8L,7L,5L,0L,7L,3L,0L,0L,8L,9L,3L,7L,4L,3L,4L,0L,5L,7L,6L,7L,3L,1L,2L,4L,9L,4L,7L,0L,7L,3L,4L,4L,3L,3L,6L,4L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111728Inst : IEnumerable<long>
{
public static readonly long[] Value=A111728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111728.Bytes);
public long this[int i]=>Value[i];

public static A111728Inst Instance=new A111728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111729
{
public static readonly long[] Value={ 2525L,3535L,4545L,5555L,6565L,7510L,8510L,9595L,2525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111729Inst : IEnumerable<long>
{
public static readonly long[] Value=A111729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111729.Bytes);
public long this[int i]=>Value[i];

public static A111729Inst Instance=new A111729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111730
{
public static readonly long[] Value={ 96L,4644L,4944L,6664L,6966L,9464L,9996L,44464L,44944L,46496L,46644L,49644L,49696L,64449L,64496L,66444L,66696L,69444L,69496L,69966L,94496L,94644L,94696L,96496L,96944L,99944L,99946L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111730Inst : IEnumerable<long>
{
public static readonly long[] Value=A111730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111730.Bytes);
public long this[int i]=>Value[i];

public static A111730Inst Instance=new A111730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111731
{
public static readonly long[] Value={ 4L,4L,4L,5L,4L,6L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111731Inst : IEnumerable<long>
{
public static readonly long[] Value=A111731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111731.Bytes);
public long this[int i]=>Value[i];

public static A111731Inst Instance=new A111731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111732
{
public static readonly long[] Value={ 0L,16L,80L,161L,305L,561L,885L,1285L,1861L,2486L,3215L,3999L,5023L,6319L,7919L,9855L,11880L,14184L,16585L,19085L,21789L,24705L,27841L,31441L,35410L,39506L,44130L,49314L,54939L,60715L,67115L,73676L,80732L,88476L,96576L,105040L,114256L,123860L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111732Inst : IEnumerable<long>
{
public static readonly long[] Value=A111732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111732.Bytes);
public long this[int i]=>Value[i];

public static A111732Inst Instance=new A111732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111733
{
public static readonly long[] Value={ 1L,1L,9L,17L,33L,57L,97L,161L,265L,433L,705L,1145L,1857L,3009L,4873L,7889L,12769L,20665L,33441L,54113L,87561L,141681L,229249L,370937L,600193L,971137L,1571337L,2542481L,4113825L,6656313L,10770145L,17426465L,28196617L,45623089L,73819713L,119442809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111733Inst : IEnumerable<long>
{
public static readonly long[] Value=A111733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111733.Bytes);
public long this[int i]=>Value[i];

public static A111733Inst Instance=new A111733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111734
{
public static readonly long[] Value={ -1L,1L,-1L,3L,-6L,10L,-15L,23L,-37L,61L,-100L,162L,-261L,421L,-681L,1103L,-1786L,2890L,-4675L,7563L,-12237L,19801L,-32040L,51842L,-83881L,135721L,-219601L,355323L,-574926L,930250L,-1505175L,2435423L,-3940597L,6376021L,-10316620L,16692642L,-27009261L,43701901L,-70711161L,114413063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111734Inst : IEnumerable<long>
{
public static readonly long[] Value=A111734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111734.Bytes);
public long this[int i]=>Value[i];

public static A111734Inst Instance=new A111734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111735
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,2L,2L,2L,2L,2L,4L,2L,4L,2L,8L,4L,2L,8L,10L,10L,4L,2L,2L,2L,2L,4L,2L,10L,4L,8L,2L,4L,8L,2L,2L,4L,8L,2L,2L,2L,4L,4L,4L,8L,2L,2L,8L,4L,2L,4L,2L,2L,4L,4L,2L,8L,2L,8L,8L,10L,4L,2L,8L,4L,2L,2L,4L,2L,8L,2L,2L,10L,2L,4L,14L,2L,4L,2L,10L,2L,2L,14L,4L,2L,2L,32L,14L,2L,16L,10L,8L,2L,10L,8L,2L,2L,4L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111735Inst : IEnumerable<long>
{
public static readonly long[] Value=A111735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111735.Bytes);
public long this[int i]=>Value[i];

public static A111735Inst Instance=new A111735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111736
{
public static readonly long[] Value={ 3L,1L,3L,1L,3L,1L,3L,3L,5L,11L,3L,1L,3L,1L,3L,11L,3L,7L,1L,9L,1L,1L,5L,3L,1L,5L,7L,3L,3L,5L,1L,17L,9L,1L,3L,3L,3L,1L,5L,9L,3L,3L,5L,1L,9L,1L,9L,15L,3L,3L,5L,11L,3L,5L,3L,9L,11L,3L,1L,5L,19L,9L,1L,5L,7L,9L,3L,13L,11L,3L,11L,3L,3L,1L,7L,11L,3L,9L,3L,1L,17L,9L,9L,1L,3L,5L,5L,3L,3L,9L,3L,15L,1L,9L,1L,5L,3L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111736Inst : IEnumerable<long>
{
public static readonly long[] Value=A111736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111736.Bytes);
public long this[int i]=>Value[i];

public static A111736Inst Instance=new A111736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111737
{
public static readonly long[] Value={ 1L,2L,4L,2L,4L,2L,4L,2L,12L,4L,2L,6L,6L,8L,4L,4L,12L,2L,2L,4L,2L,2L,4L,4L,2L,4L,6L,6L,2L,4L,6L,4L,6L,6L,6L,2L,2L,6L,4L,12L,12L,2L,12L,2L,6L,2L,6L,2L,16L,6L,6L,6L,8L,4L,4L,4L,16L,6L,14L,4L,8L,6L,8L,4L,2L,12L,2L,8L,6L,2L,12L,6L,12L,2L,6L,16L,4L,2L,6L,8L,4L,6L,6L,14L,8L,6L,6L,2L,4L,18L,4L,4L,2L,4L,8L,6L,4L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111737Inst : IEnumerable<long>
{
public static readonly long[] Value=A111737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111737.Bytes);
public long this[int i]=>Value[i];

public static A111737Inst Instance=new A111737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111738
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,13L,1L,5L,5L,1L,5L,5L,1L,13L,5L,1L,7L,5L,1L,5L,1L,7L,5L,1L,1L,1L,5L,5L,7L,1L,1L,5L,13L,1L,5L,5L,7L,1L,13L,1L,5L,5L,5L,7L,11L,23L,5L,7L,1L,5L,1L,5L,1L,1L,5L,1L,1L,7L,1L,1L,5L,1L,1L,5L,1L,5L,1L,5L,11L,7L,1L,1L,7L,11L,5L,1L,5L,5L,7L,5L,5L,11L,13L,1L,5L,7L,1L,11L,1L,5L,5L,7L,5L,1L,7L,11L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111738Inst : IEnumerable<long>
{
public static readonly long[] Value=A111738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111738.Bytes);
public long this[int i]=>Value[i];

public static A111738Inst Instance=new A111738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111739
{
public static readonly long[] Value={ 3L,2L,2L,4L,2L,6L,8L,4L,2L,8L,6L,4L,6L,6L,2L,2L,6L,4L,10L,2L,10L,4L,6L,8L,4L,2L,6L,2L,6L,6L,18L,2L,8L,4L,6L,4L,4L,10L,2L,2L,6L,10L,24L,10L,2L,6L,4L,6L,8L,4L,6L,20L,6L,2L,2L,6L,6L,4L,10L,6L,6L,2L,4L,2L,12L,2L,16L,12L,8L,4L,2L,8L,10L,6L,4L,2L,6L,10L,12L,16L,6L,6L,2L,6L,6L,8L,20L,4L,2L,10L,2L,6L,4L,12L,6L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111739Inst : IEnumerable<long>
{
public static readonly long[] Value=A111739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111739.Bytes);
public long this[int i]=>Value[i];

public static A111739Inst Instance=new A111739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111740
{
public static readonly long[] Value={ 1L,5L,1L,3L,1L,3L,1L,5L,7L,1L,3L,11L,3L,3L,3L,7L,7L,3L,5L,1L,3L,9L,9L,7L,11L,1L,3L,1L,5L,3L,3L,1L,1L,5L,1L,5L,3L,3L,25L,15L,1L,3L,3L,5L,3L,5L,5L,3L,7L,15L,3L,1L,3L,3L,7L,7L,1L,11L,5L,3L,3L,3L,3L,15L,17L,3L,9L,3L,1L,5L,9L,7L,3L,15L,5L,3L,7L,5L,1L,27L,7L,3L,1L,3L,5L,3L,1L,3L,3L,5L,3L,1L,11L,1L,9L,3L,1L,9L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111740Inst : IEnumerable<long>
{
public static readonly long[] Value=A111740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111740.Bytes);
public long this[int i]=>Value[i];

public static A111740Inst Instance=new A111740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111741
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,10L,4L,2L,4L,2L,2L,4L,4L,2L,8L,2L,10L,8L,4L,2L,2L,8L,4L,8L,4L,2L,2L,4L,2L,2L,8L,2L,4L,8L,20L,2L,10L,4L,8L,2L,2L,8L,2L,4L,4L,10L,2L,4L,10L,2L,2L,2L,10L,8L,20L,4L,2L,2L,10L,2L,2L,10L,4L,2L,2L,4L,20L,4L,14L,22L,4L,20L,4L,2L,2L,2L,10L,8L,4L,10L,8L,4L,2L,10L,16L,2L,8L,14L,4L,10L,8L,16L,8L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111741Inst : IEnumerable<long>
{
public static readonly long[] Value=A111741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111741.Bytes);
public long this[int i]=>Value[i];

public static A111741Inst Instance=new A111741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111742
{
public static readonly long[] Value={ 3L,1L,3L,1L,3L,1L,3L,1L,3L,3L,1L,3L,9L,1L,9L,11L,3L,3L,3L,9L,3L,7L,9L,17L,1L,3L,1L,17L,1L,21L,7L,9L,3L,9L,3L,1L,1L,7L,23L,3L,11L,1L,3L,1L,3L,3L,1L,7L,3L,3L,3L,3L,1L,11L,9L,3L,3L,1L,7L,9L,3L,9L,9L,9L,7L,11L,3L,1L,21L,1L,3L,3L,1L,3L,3L,3L,17L,19L,3L,1L,11L,1L,17L,7L,1L,11L,3L,13L,11L,7L,3L,3L,1L,9L,3L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111742Inst : IEnumerable<long>
{
public static readonly long[] Value=A111742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111742.Bytes);
public long this[int i]=>Value[i];

public static A111742Inst Instance=new A111742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111743
{
public static readonly long[] Value={ 14L,24L,40L,56L,101L,103L,107L,109L,113L,127L,129L,130L,131L,134L,137L,139L,141L,142L,146L,149L,151L,157L,158L,159L,163L,166L,167L,170L,173L,177L,178L,179L,181L,183L,190L,191L,193L,194L,197L,199L,201L,202L,206L,211L,213L,214L,218L,219L,223L,226L,227L,229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111743Inst : IEnumerable<long>
{
public static readonly long[] Value=A111743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111743.Bytes);
public long this[int i]=>Value[i];

public static A111743Inst Instance=new A111743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111744
{
public static readonly long[] Value={ 5L,3L,13L,7L,17L,11L,29L,19L,37L,23L,41L,31L,53L,43L,61L,47L,73L,59L,89L,67L,97L,71L,101L,79L,109L,83L,113L,103L,137L,107L,149L,127L,157L,131L,173L,139L,181L,151L,193L,163L,197L,167L,229L,179L,233L,191L,241L,199L,257L,211L,269L,223L,277L,227L,281L,239L,293L,251L,313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111744Inst : IEnumerable<long>
{
public static readonly long[] Value=A111744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111744.Bytes);
public long this[int i]=>Value[i];

public static A111744Inst Instance=new A111744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111745
{
public static readonly long[] Value={ 3L,5L,7L,13L,11L,17L,19L,29L,23L,37L,31L,41L,43L,53L,47L,61L,59L,73L,67L,89L,71L,97L,79L,101L,83L,109L,103L,113L,107L,137L,127L,149L,131L,157L,139L,173L,151L,181L,163L,193L,167L,197L,179L,229L,191L,233L,199L,241L,211L,257L,223L,269L,227L,277L,239L,281L,251L,293L,263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111745Inst : IEnumerable<long>
{
public static readonly long[] Value=A111745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111745.Bytes);
public long this[int i]=>Value[i];

public static A111745Inst Instance=new A111745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111746
{
public static readonly long[] Value={ 0L,5L,17L,42L,82L,143L,227L,340L,484L,665L,885L,1150L,1462L,1827L,2247L,2728L,3272L,3885L,4569L,5330L,6170L,7095L,8107L,9212L,10412L,11713L,13117L,14630L,16254L,17995L,19855L,21840L,23952L,26197L,28577L,31098L,33762L,36575L,39539L,42660L,45940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111746Inst : IEnumerable<long>
{
public static readonly long[] Value=A111746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111746.Bytes);
public long this[int i]=>Value[i];

public static A111746Inst Instance=new A111746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111747
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,8L,9L,27L,81L,243L,512L,2401L,4913L,19683L,59049L,177147L,390625L,1594323L,43046721L,129140163L,1977326743L,10460353203L,27512614111L,68719476736L,271818611107L,1174711139837L,7625597484987L,617673396283947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111747Inst : IEnumerable<long>
{
public static readonly long[] Value=A111747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111747.Bytes);
public long this[int i]=>Value[i];

public static A111747Inst Instance=new A111747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111748
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111748Inst : IEnumerable<long>
{
public static readonly long[] Value=A111748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111748.Bytes);
public long this[int i]=>Value[i];

public static A111748Inst Instance=new A111748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111749
{
public static readonly long[] Value={ 1L,3L,10L,39L,121L,405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111749Inst : IEnumerable<long>
{
public static readonly long[] Value=A111749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111749.Bytes);
public long this[int i]=>Value[i];

public static A111749Inst Instance=new A111749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111750
{
public static readonly long[] Value={ 280103L,1297573L,1319273L,1473443L,1589663L,1726603L,1798003L,1807063L,2048953L,2082793L,2126303L,2342393L,2434123L,2459273L,2770843L,2784563L,2824583L,2897053L,2952613L,2897053L,2952613L,2965043L,3036983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111750Inst : IEnumerable<long>
{
public static readonly long[] Value=A111750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111750.Bytes);
public long this[int i]=>Value[i];

public static A111750Inst Instance=new A111750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111751
{
public static readonly long[] Value={ 2L,22L,25L,28L,37L,40L,60L,73L,78L,80L,129L,135L,158L,162L,215L,220L,228L,238L,269L,285L,315L,332L,344L,347L,355L,365L,366L,390L,397L,402L,439L,443L,470L,477L,533L,549L,653L,694L,710L,715L,716L,745L,765L,782L,822L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111751Inst : IEnumerable<long>
{
public static readonly long[] Value=A111751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111751.Bytes);
public long this[int i]=>Value[i];

public static A111751Inst Instance=new A111751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111752
{
public static readonly BigInteger[] Value={ 1L,0L,3L,6L,49L,300L,2491L,22890L,239457L,2782584L,35595091L,496577070L,7499663953L,121855323876L,2118793593099L,39245026343250L,771255810671041L,16025261292247920L,350956070419872547L,8078570913162379734L,BigInteger.Parse("194969375055353840241"),BigInteger.Parse("4922311437793379501340") };
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
public class A111752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111752Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111752.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111752.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111752Inst Instance=new A111752Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111753
{
public static readonly BigInteger[] Value={ 0L,1L,0L,7L,24L,201L,1560L,14743L,154896L,1813969L,23346000L,327496071L,4970498280L,81121077337L,1416223931304L,26328776843671L,519178407998880L,10821355158998433L,237677397895531296L,5485802780426178439L,BigInteger.Parse("132728552830731814200"),BigInteger.Parse("3358841601972480225001") };
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
public class A111753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111753Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111753.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111753.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111753Inst Instance=new A111753Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111754
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,6L,2L,0L,3L,4L,4L,4L,3L,9L,3L,5L,5L,7L,3L,9L,8L,4L,0L,4L,4L,1L,6L,9L,7L,5L,4L,7L,8L,2L,8L,8L,4L,6L,4L,6L,0L,1L,6L,8L,1L,1L,9L,5L,1L,1L,9L,3L,9L,1L,1L,7L,2L,2L,3L,7L,8L,2L,2L,0L,0L,4L,8L,6L,6L,9L,1L,8L,6L,0L,9L,3L,0L,7L,1L,8L,9L,6L,5L,9L,0L,9L,2L,5L,4L,2L,3L,1L,6L,8L,2L,8L,0L,3L,1L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111754Inst : IEnumerable<long>
{
public static readonly long[] Value=A111754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111754.Bytes);
public long this[int i]=>Value[i];

public static A111754Inst Instance=new A111754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111755
{
public static readonly long[] Value={ 0L,1L,2L,0L,0L,1L,2L,3L,0L,0L,1L,2L,0L,0L,1L,0L,0L,1L,2L,0L,0L,1L,2L,3L,0L,0L,1L,2L,0L,0L,1L,2L,3L,0L,0L,0L,0L,1L,2L,0L,0L,1L,2L,3L,0L,0L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,3L,0L,0L,1L,2L,0L,0L,0L,0L,1L,2L,0L,0L,1L,2L,3L,0L,0L,1L,2L,0L,0L,1L,0L,0L,0L,1L,2L,0L,0L,1L,2L,3L,0L,0L,1L,2L,0L,0L,1L,0L,0L,1L,0L,0L,1L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111755Inst : IEnumerable<long>
{
public static readonly long[] Value=A111755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111755.Bytes);
public long this[int i]=>Value[i];

public static A111755Inst Instance=new A111755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111756
{
public static readonly long[] Value={ 3L,3L,3L,3L,5L,5L,5L,5L,5L,3L,7L,7L,7L,7L,5L,5L,9L,9L,3L,3L,11L,11L,11L,11L,5L,5L,13L,13L,13L,13L,3L,3L,17L,17L,17L,17L,5L,3L,19L,19L,19L,19L,5L,7L,7L,21L,3L,3L,23L,23L,23L,23L,5L,5L,3L,27L,3L,11L,7L,7L,13L,3L,29L,29L,29L,29L,5L,3L,31L,31L,31L,31L,5L,5L,3L,9L,3L,3L,37L,37L,37L,37L,5L,11L,11L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111756Inst : IEnumerable<long>
{
public static readonly long[] Value=A111756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111756.Bytes);
public long this[int i]=>Value[i];

public static A111756Inst Instance=new A111756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111757
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,2L,0L,4L,0L,13L,0L,48L,0L,238L,0L,1325L,0L,8297L,0L,54519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111757Inst : IEnumerable<long>
{
public static readonly long[] Value=A111757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111757.Bytes);
public long this[int i]=>Value[i];

public static A111757Inst Instance=new A111757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111758
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,12L,24L,74L,193L,635L,1990L,6933L,24144L,88203L,326053L,1234735L,4732762L,18403211L,72282202L,286705378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111758Inst : IEnumerable<long>
{
public static readonly long[] Value=A111758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111758.Bytes);
public long this[int i]=>Value[i];

public static A111758Inst Instance=new A111758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111759
{
public static readonly long[] Value={ 1L,2L,3L,7L,12L,29L,61L,162L,412L,1221L,3665L,12031L,40514L,143244L,518247L,1926638L,7285835L,28013935L,109058879L,429366751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111759Inst : IEnumerable<long>
{
public static readonly long[] Value=A111759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111759.Bytes);
public long this[int i]=>Value[i];

public static A111759Inst Instance=new A111759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111760
{
public static readonly long[] Value={ 1L,3L,2L,1L,1L,7L,6L,1L,7L,7L,8L,1L,3L,4L,5L,0L,6L,5L,2L,6L,3L,4L,3L,4L,1L,1L,1L,9L,2L,5L,4L,6L,6L,0L,5L,1L,3L,3L,4L,6L,3L,3L,7L,5L,8L,3L,5L,4L,9L,1L,6L,4L,4L,0L,5L,3L,0L,9L,8L,4L,7L,5L,5L,2L,3L,9L,1L,5L,7L,7L,7L,9L,4L,6L,0L,3L,6L,8L,0L,3L,2L,1L,7L,6L,9L,1L,0L,1L,2L,8L,6L,9L,8L,8L,0L,0L,6L,9L,7L,5L,2L,4L,1L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111760Inst : IEnumerable<long>
{
public static readonly long[] Value=A111760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111760.Bytes);
public long this[int i]=>Value[i];

public static A111760Inst Instance=new A111760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111761
{
public static readonly long[] Value={ 2L,5L,9L,4L,0L,2L,3L,0L,0L,2L,4L,9L,7L,5L,0L,9L,7L,9L,7L,4L,8L,6L,8L,6L,7L,7L,7L,9L,1L,1L,0L,5L,0L,1L,2L,0L,6L,0L,9L,0L,4L,7L,9L,6L,8L,2L,9L,6L,5L,1L,2L,1L,8L,8L,8L,6L,5L,9L,7L,6L,7L,9L,3L,3L,9L,9L,6L,5L,5L,5L,9L,9L,1L,2L,9L,8L,2L,3L,2L,0L,1L,1L,8L,0L,6L,3L,0L,4L,1L,9L,2L,9L,8L,5L,6L,1L,1L,9L,9L,6L,1L,3L,6L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111761Inst : IEnumerable<long>
{
public static readonly long[] Value=A111761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111761.Bytes);
public long this[int i]=>Value[i];

public static A111761Inst Instance=new A111761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111762
{
public static readonly long[] Value={ 3L,6L,3L,4L,7L,9L,8L,7L,2L,5L,9L,4L,5L,4L,2L,7L,9L,8L,9L,3L,3L,7L,9L,2L,0L,9L,2L,0L,1L,6L,3L,6L,1L,3L,9L,0L,4L,1L,4L,6L,3L,0L,9L,3L,9L,4L,1L,2L,8L,6L,1L,8L,8L,3L,1L,0L,9L,0L,6L,0L,2L,3L,5L,8L,8L,0L,0L,1L,5L,2L,2L,0L,7L,9L,4L,1L,5L,5L,3L,9L,2L,3L,8L,8L,8L,7L,8L,5L,3L,2L,9L,6L,5L,2L,0L,9L,3L,1L,4L,1L,2L,9L,2L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111762Inst : IEnumerable<long>
{
public static readonly long[] Value=A111762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111762.Bytes);
public long this[int i]=>Value[i];

public static A111762Inst Instance=new A111762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111763
{
public static readonly long[] Value={ 4L,4L,5L,0L,2L,4L,8L,8L,2L,0L,1L,5L,8L,8L,4L,5L,2L,9L,5L,9L,2L,8L,8L,5L,0L,1L,8L,7L,2L,8L,4L,1L,2L,5L,5L,6L,3L,3L,1L,4L,6L,4L,2L,4L,5L,6L,7L,4L,2L,9L,1L,4L,0L,9L,4L,1L,1L,9L,4L,2L,0L,0L,7L,0L,7L,2L,9L,1L,2L,5L,6L,0L,3L,6L,8L,8L,3L,3L,9L,9L,1L,3L,5L,5L,8L,1L,3L,1L,0L,7L,2L,0L,9L,8L,2L,1L,5L,2L,3L,9L,8L,1L,8L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111763Inst : IEnumerable<long>
{
public static readonly long[] Value=A111763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111763.Bytes);
public long this[int i]=>Value[i];

public static A111763Inst Instance=new A111763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111764
{
public static readonly long[] Value={ 1L,0L,1L,7L,6L,0L,8L,2L,9L,4L,8L,2L,1L,6L,1L,4L,9L,3L,1L,3L,1L,9L,6L,3L,9L,2L,5L,3L,6L,5L,5L,2L,3L,7L,1L,0L,9L,1L,2L,3L,8L,5L,8L,7L,3L,4L,7L,2L,6L,3L,5L,1L,6L,7L,6L,4L,4L,8L,5L,1L,9L,4L,4L,9L,5L,3L,2L,2L,3L,6L,1L,7L,1L,2L,3L,8L,0L,3L,6L,5L,7L,7L,6L,2L,9L,9L,2L,0L,9L,5L,2L,2L,3L,3L,8L,9L,6L,2L,9L,6L,8L,6L,5L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111764Inst : IEnumerable<long>
{
public static readonly long[] Value=A111764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111764.Bytes);
public long this[int i]=>Value[i];

public static A111764Inst Instance=new A111764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111765
{
public static readonly long[] Value={ 9L,8L,2L,6L,9L,6L,3L,9L,2L,2L,0L,5L,9L,0L,1L,1L,5L,5L,1L,3L,5L,1L,3L,2L,2L,2L,5L,3L,0L,4L,4L,0L,5L,4L,2L,0L,3L,0L,0L,1L,3L,5L,0L,2L,4L,9L,0L,4L,0L,6L,4L,5L,2L,6L,1L,3L,3L,7L,0L,6L,1L,5L,1L,4L,3L,5L,1L,1L,6L,3L,4L,1L,0L,9L,1L,9L,0L,0L,9L,1L,1L,2L,2L,2L,2L,0L,4L,6L,7L,8L,6L,1L,0L,7L,8L,2L,4L,4L,1L,6L,4L,7L,8L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111765Inst : IEnumerable<long>
{
public static readonly long[] Value=A111765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111765.Bytes);
public long this[int i]=>Value[i];

public static A111765Inst Instance=new A111765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111766
{
public static readonly long[] Value={ 0L,5L,24L,145L,840L,4901L,28560L,166465L,970224L,5654885L,32959080L,192099601L,1119638520L,6525731525L,38034750624L,221682772225L,1292061882720L,7530688524101L,43892069261880L,255821727047185L,1491038293021224L,8690408031080165L,50651409893459760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111766Inst : IEnumerable<long>
{
public static readonly long[] Value=A111766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111766.Bytes);
public long this[int i]=>Value[i];

public static A111766Inst Instance=new A111766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111767
{
public static readonly long[] Value={ 4L,0L,4L,8L,1L,2L,5L,4L,1L,8L,6L,8L,3L,1L,2L,5L,2L,2L,2L,3L,5L,0L,7L,5L,5L,2L,9L,7L,0L,8L,7L,3L,8L,9L,0L,0L,7L,4L,5L,2L,0L,4L,9L,6L,7L,2L,5L,0L,7L,1L,2L,4L,6L,1L,4L,3L,3L,5L,1L,0L,5L,9L,3L,5L,4L,6L,9L,1L,9L,0L,3L,4L,5L,4L,4L,5L,4L,4L,8L,3L,8L,7L,1L,8L,8L,4L,0L,3L,5L,4L,6L,2L,0L,4L,1L,5L,9L,7L,3L,4L,7L,7L,3L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111767Inst : IEnumerable<long>
{
public static readonly long[] Value=A111767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111767.Bytes);
public long this[int i]=>Value[i];

public static A111767Inst Instance=new A111767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111768
{
public static readonly long[] Value={ 2L,4L,7L,0L,2L,7L,9L,1L,9L,4L,8L,7L,0L,6L,5L,9L,0L,1L,3L,6L,9L,1L,5L,4L,0L,7L,9L,0L,8L,6L,8L,8L,4L,9L,2L,6L,9L,3L,8L,6L,2L,8L,8L,3L,2L,4L,6L,7L,4L,7L,7L,3L,6L,6L,1L,7L,0L,4L,4L,6L,2L,9L,6L,0L,4L,4L,5L,0L,3L,4L,3L,5L,2L,4L,4L,4L,0L,1L,2L,8L,4L,1L,5L,0L,4L,2L,9L,6L,1L,9L,9L,9L,6L,8L,2L,1L,1L,1L,0L,4L,4L,6L,7L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111768Inst : IEnumerable<long>
{
public static readonly long[] Value=A111768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111768.Bytes);
public long this[int i]=>Value[i];

public static A111768Inst Instance=new A111768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111769
{
public static readonly long[] Value={ 1L,7L,5L,8L,0L,7L,8L,5L,3L,1L,3L,8L,6L,3L,7L,2L,2L,5L,4L,8L,8L,5L,3L,5L,5L,1L,9L,0L,3L,7L,0L,6L,4L,2L,0L,2L,0L,9L,7L,8L,4L,4L,7L,9L,8L,6L,4L,5L,0L,8L,7L,0L,7L,4L,6L,4L,2L,1L,5L,9L,3L,7L,5L,0L,6L,6L,5L,9L,8L,3L,3L,0L,4L,2L,4L,0L,6L,7L,0L,5L,4L,9L,2L,5L,5L,9L,9L,0L,5L,4L,7L,9L,0L,9L,9L,8L,6L,5L,6L,7L,7L,5L,3L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111769Inst : IEnumerable<long>
{
public static readonly long[] Value=A111769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111769.Bytes);
public long this[int i]=>Value[i];

public static A111769Inst Instance=new A111769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111770
{
public static readonly long[] Value={ 5L,6L,8L,8L,0L,2L,8L,0L,4L,9L,6L,4L,2L,5L,1L,2L,6L,8L,5L,1L,2L,2L,1L,8L,3L,1L,5L,8L,5L,5L,2L,5L,1L,8L,2L,4L,6L,7L,0L,2L,7L,4L,7L,9L,6L,3L,0L,5L,5L,6L,7L,6L,6L,9L,9L,1L,1L,4L,3L,4L,2L,0L,3L,6L,4L,4L,4L,2L,4L,0L,3L,9L,7L,5L,4L,8L,9L,7L,8L,0L,0L,8L,4L,6L,5L,8L,5L,6L,4L,9L,9L,4L,7L,1L,6L,5L,5L,9L,1L,2L,3L,7L,2L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111770Inst : IEnumerable<long>
{
public static readonly long[] Value=A111770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111770.Bytes);
public long this[int i]=>Value[i];

public static A111770Inst Instance=new A111770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111771
{
public static readonly long[] Value={ 2L,22L,29L,99L,94L,44L,47L,77L,76L,66L,65L,55L,58L,88L,83L,33L,40L,110L,101L,11L,12L,12L,19L,109L,104L,34L,37L,87L,86L,56L,55L,65L,68L,78L,73L,43L,50L,100L,91L,21L,22L,2L,9L,9L,4L,24L,27L,97L,96L,46L,45L,75L,78L,68L,63L,53L,60L,90L,81L,31L,32L,102L,109L,19L,14L,14L,17L,107L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111771Inst : IEnumerable<long>
{
public static readonly long[] Value=A111771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111771.Bytes);
public long this[int i]=>Value[i];

public static A111771Inst Instance=new A111771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111772
{
public static readonly long[] Value={ 1L,1L,3L,7L,22L,77L,314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111772Inst : IEnumerable<long>
{
public static readonly long[] Value=A111772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111772.Bytes);
public long this[int i]=>Value[i];

public static A111772Inst Instance=new A111772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111773
{
public static readonly long[] Value={ 1L,2L,10L,92L,1321L,27882L,819330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111773Inst : IEnumerable<long>
{
public static readonly long[] Value=A111773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111773.Bytes);
public long this[int i]=>Value[i];

public static A111773Inst Instance=new A111773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111774
{
public static readonly long[] Value={ 6L,9L,10L,12L,14L,15L,18L,20L,21L,22L,24L,25L,26L,27L,28L,30L,33L,34L,35L,36L,38L,39L,40L,42L,44L,45L,46L,48L,49L,50L,51L,52L,54L,55L,56L,57L,58L,60L,62L,63L,65L,66L,68L,69L,70L,72L,74L,75L,76L,77L,78L,80L,81L,82L,84L,85L,86L,87L,88L,90L,91L,92L,93L,94L,95L,96L,98L,99L,100L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111774Inst : IEnumerable<long>
{
public static readonly long[] Value=A111774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111774.Bytes);
public long this[int i]=>Value[i];

public static A111774Inst Instance=new A111774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111775
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,2L,0L,0L,2L,0L,1L,2L,1L,0L,1L,1L,1L,2L,1L,0L,3L,0L,0L,2L,1L,2L,2L,0L,1L,2L,1L,0L,3L,0L,1L,4L,1L,0L,1L,1L,2L,2L,1L,0L,3L,2L,1L,2L,1L,0L,3L,0L,1L,4L,0L,2L,3L,0L,1L,2L,3L,0L,2L,0L,1L,4L,1L,2L,3L,0L,1L,3L,1L,0L,3L,2L,1L,2L,1L,0L,5L,2L,1L,2L,1L,2L,1L,0L,2L,4L,2L,0L,3L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111775Inst : IEnumerable<long>
{
public static readonly long[] Value=A111775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111775.Bytes);
public long this[int i]=>Value[i];

public static A111775Inst Instance=new A111775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111776
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,1L,4L,6L,10L,1L,8L,12L,20L,35L,1L,16L,24L,40L,70L,125L,1L,32L,48L,80L,140L,250L,450L,1L,64L,96L,160L,280L,500L,900L,1625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111776Inst : IEnumerable<long>
{
public static readonly long[] Value=A111776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111776.Bytes);
public long this[int i]=>Value[i];

public static A111776Inst Instance=new A111776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111777
{
public static readonly long[] Value={ 1L,12L,130L,1380L,15435L,182280L,2302020L,30958200L,444230325L,6771510900L,109568809350L,1874844071100L,33875023557375L,644264598978000L,12877256933541000L,269789087886318000L,5915648230774907625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A111777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111777Inst : IEnumerable<long>
{
public static readonly long[] Value=A111777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A111777.Bytes);
public long this[int i]=>Value[i];

public static A111777Inst Instance=new A111777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A111778
{
public static readonly BigInteger[] Value={ 1L,20L,315L,4620L,67830L,1020600L,15961050L,260706600L,4461170175L,80002622700L,1503527550525L,29583578524500L,608837350621500L,13088359506222000L,293538127312930500L,6858722586405690000L,BigInteger.Parse("166752692881988338125") };
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
public class A111778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A111778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A111778Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A111778.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A111778.Bytes);
public BigInteger this[int i]=>Value[i];

public static A111778Inst Instance=new A111778Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}