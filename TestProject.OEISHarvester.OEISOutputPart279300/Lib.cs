using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A090655
{
public static readonly long[] Value={ 9L,9L,0L,8L,3L,2L,6L,9L,1L,3L,1L,9L,5L,9L,8L,3L,9L,3L,9L,6L,7L,8L,8L,3L,1L,9L,0L,1L,2L,0L,5L,7L,4L,3L,9L,1L,9L,3L,7L,6L,9L,4L,4L,8L,6L,0L,7L,6L,7L,8L,6L,9L,3L,1L,9L,0L,6L,5L,6L,7L,9L,5L,8L,4L,3L,4L,0L,7L,5L,0L,4L,2L,2L,4L,3L,9L,5L,1L,5L,6L,6L,7L,8L,0L,6L,9L,2L,8L,6L,2L,3L,0L,2L,7L,7L,3L,6L,0L,7L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090655Inst : IEnumerable<long>
{
public static readonly long[] Value=A090655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090655.Bytes);
public long this[int i]=>Value[i];

public static A090655Inst Instance=new A090655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090656
{
public static readonly long[] Value={ 1L,0L,9L,1L,6L,0L,7L,9L,7L,8L,3L,0L,9L,9L,6L,1L,6L,0L,4L,2L,5L,6L,7L,3L,2L,8L,2L,9L,1L,5L,6L,1L,6L,1L,7L,0L,4L,8L,4L,1L,5L,5L,0L,1L,2L,3L,0L,7L,9L,4L,3L,4L,0L,3L,2L,2L,8L,7L,9L,7L,1L,9L,6L,6L,9L,1L,4L,2L,8L,2L,2L,4L,5L,9L,1L,0L,5L,6L,5L,3L,0L,3L,6L,7L,6L,5L,7L,5L,2L,5L,2L,7L,1L,8L,3L,1L,0L,9L,1L,7L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090656Inst : IEnumerable<long>
{
public static readonly long[] Value=A090656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090656.Bytes);
public long this[int i]=>Value[i];

public static A090656Inst Instance=new A090656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090657
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,2L,0L,3L,18L,6L,0L,4L,84L,144L,24L,0L,5L,300L,1500L,1200L,120L,0L,6L,930L,10800L,23400L,10800L,720L,0L,7L,2646L,63210L,294000L,352800L,105840L,5040L,0L,8L,7112L,324576L,2857680L,7056000L,5362560L,1128960L,40320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090657Inst : IEnumerable<long>
{
public static readonly long[] Value=A090657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090657.Bytes);
public long this[int i]=>Value[i];

public static A090657Inst Instance=new A090657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090658
{
public static readonly long[] Value={ 4L,8L,12L,20L,24L,32L,44L,48L,60L,68L,72L,80L,84L,104L,108L,128L,132L,140L,152L,164L,168L,180L,192L,200L,212L,224L,228L,240L,252L,264L,272L,284L,308L,312L,332L,348L,360L,368L,380L,384L,420L,432L,440L,444L,464L,468L,480L,488L,492L,500L,504L,524L,548L,564L,572L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090658Inst : IEnumerable<long>
{
public static readonly long[] Value=A090658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090658.Bytes);
public long this[int i]=>Value[i];

public static A090658Inst Instance=new A090658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090659
{
public static readonly long[] Value={ 25L,91L,703L,1891L,12403L,38503L,79003L,88831L,146611L,188191L,218791L,269011L,286903L,385003L,497503L,597871L,736291L,765703L,954271L,1056331L,1314631L,1869211L,2741311L,3270403L,3913003L,4255903L,4686391L,5292631L,6186403L,6969511L,8086231L,9080191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090659Inst : IEnumerable<long>
{
public static readonly long[] Value=A090659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090659.Bytes);
public long this[int i]=>Value[i];

public static A090659Inst Instance=new A090659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090676
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,9L,16L,27L,39L,57L,77L,105L,135L,174L,217L,269L,325L,393L,466L,552L,642L,747L,857L,984L,1116L,1266L,1423L,1598L,1780L,1983L,2194L,2427L,2667L,2931L,3203L,3501L,3807L,4140L,4483L,4853L,5233L,5643L,6064L,6516L,6978L,7473L,7979L,8520L,9072L,9660L,10261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090676Inst : IEnumerable<long>
{
public static readonly long[] Value=A090676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090676.Bytes);
public long this[int i]=>Value[i];

public static A090676Inst Instance=new A090676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090677
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,3L,2L,2L,2L,4L,3L,2L,3L,4L,4L,2L,3L,4L,5L,3L,3L,5L,5L,4L,3L,5L,5L,5L,4L,5L,6L,5L,5L,5L,7L,6L,6L,6L,7L,7L,6L,7L,7L,8L,7L,8L,8L,8L,8L,8L,9L,8L,9L,9L,10L,9L,9L,10L,11L,11L,10L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090677Inst : IEnumerable<long>
{
public static readonly long[] Value=A090677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090677.Bytes);
public long this[int i]=>Value[i];

public static A090677Inst Instance=new A090677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090678
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090678Inst : IEnumerable<long>
{
public static readonly long[] Value=A090678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090678.Bytes);
public long this[int i]=>Value[i];

public static A090678Inst Instance=new A090678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090679
{
public static readonly long[] Value={ 5L,8L,17L,25L,42L,59L,84L,101L,144L,152L,195L,212L,254L,271L,280L,322L,339L,381L,398L,441L,492L,593L,610L,653L,738L,806L,848L,873L,907L,933L,1145L,1162L,1170L,1213L,1247L,1442L,1459L,1484L,1501L,1544L,1629L,1739L,1807L,1824L,1841L,1866L,2019L,2053L,2095L,2104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090679Inst : IEnumerable<long>
{
public static readonly long[] Value=A090679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090679.Bytes);
public long this[int i]=>Value[i];

public static A090679Inst Instance=new A090679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090680
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,2L,3L,1L,3L,2L,2L,2L,4L,2L,4L,1L,1L,3L,5L,1L,1L,3L,2L,2L,6L,1L,7L,1L,3L,4L,2L,2L,9L,4L,3L,3L,9L,2L,9L,2L,2L,5L,9L,1L,1L,2L,4L,3L,11L,2L,2L,2L,5L,7L,13L,2L,12L,6L,2L,2L,3L,1L,13L,4L,5L,3L,14L,2L,13L,8L,3L,3L,2L,3L,15L,2L,2L,8L,15L,1L,3L,8L,7L,2L,16L,1L,3L,6L,6L,10L,6L,4L,19L,4L,4L,4L,20L,4L,19L,3L,3L,10L,19L,2L,18L,1L,5L,1L,18L,2L,3L,4L,1L,10L,2L,2L,2L,12L,8L,6L,5L,4L,23L,3L,8L,3L,23L,2L,4L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090680Inst : IEnumerable<long>
{
public static readonly long[] Value=A090680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090680.Bytes);
public long this[int i]=>Value[i];

public static A090680Inst Instance=new A090680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090681
{
public static readonly BigInteger[] Value={ 1L,1L,31L,5461L,3202291L,4722116521L,14717667114151L,86125672563201181L,BigInteger.Parse("868320396104950823611"),BigInteger.Parse("14129659550745551130667441"),BigInteger.Parse("352552873457246307069012458671"),BigInteger.Parse("12942188000689093683411117827763301") };
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
public class A090681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090681Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090681.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090681.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090681Inst Instance=new A090681Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090682
{
public static readonly long[] Value={ 4L,4L,6L,8L,10L,12L,15L,16L,20L,20L,23L,24L,26L,27L,28L,30L,30L,32L,33L,35L,37L,40L,41L,42L,45L,47L,48L,49L,50L,51L,56L,57L,57L,58L,59L,63L,64L,64L,65L,66L,67L,70L,71L,71L,72L,72L,75L,76L,76L,77L,80L,80L,81L,82L,82L,84L,86L,86L,87L,88L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090682Inst : IEnumerable<long>
{
public static readonly long[] Value=A090682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090682.Bytes);
public long this[int i]=>Value[i];

public static A090682Inst Instance=new A090682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090683
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,3L,9L,1L,0L,4L,42L,24L,1L,0L,5L,150L,250L,50L,1L,0L,6L,465L,1800L,975L,90L,1L,0L,7L,1323L,10535L,12250L,2940L,147L,1L,0L,8L,3556L,54096L,119070L,58800L,7448L,224L,1L,0L,9L,9180L,254100L,979020L,875826L,222264L,16632L,324L,1L,0L,10L,22995L,1119600L,7162050L,10716300L,4793670L,705600L,33750L,450L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090683Inst : IEnumerable<long>
{
public static readonly long[] Value=A090683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090683.Bytes);
public long this[int i]=>Value[i];

public static A090683Inst Instance=new A090683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090684
{
public static readonly long[] Value={ 7L,31L,71L,127L,199L,647L,967L,1151L,1567L,2311L,2591L,2887L,3527L,4231L,4999L,5407L,6271L,7687L,8191L,11551L,12799L,16927L,19207L,20807L,23327L,25087L,27847L,31751L,34847L,35911L,39199L,47431L,49927L,51199L,53791L,59167L,63367L,69191L,70687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090684Inst : IEnumerable<long>
{
public static readonly long[] Value=A090684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090684.Bytes);
public long this[int i]=>Value[i];

public static A090684Inst Instance=new A090684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090685
{
public static readonly long[] Value={ 73L,1153L,1801L,2593L,3529L,8713L,10369L,18433L,20809L,34849L,48673L,52489L,69193L,83233L,103969L,115201L,139393L,180001L,187273L,209953L,259201L,267913L,362953L,405001L,415873L,426889L,438049L,449353L,472393L,484129L,508033L,622729L,636193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090685Inst : IEnumerable<long>
{
public static readonly long[] Value=A090685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090685.Bytes);
public long this[int i]=>Value[i];

public static A090685Inst Instance=new A090685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090686
{
public static readonly long[] Value={ 5L,23L,53L,149L,293L,383L,599L,863L,1013L,1733L,2399L,2903L,4373L,4703L,5399L,6143L,7349L,8663L,11093L,12149L,16223L,18149L,20183L,21599L,23063L,23813L,25349L,27743L,29399L,31973L,33749L,35573L,40343L,41333L,45413L,51893L,56453L,59999L,62423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090686Inst : IEnumerable<long>
{
public static readonly long[] Value=A090686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090686.Bytes);
public long this[int i]=>Value[i];

public static A090686Inst Instance=new A090686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090687
{
public static readonly long[] Value={ 7L,97L,151L,487L,601L,727L,2647L,3457L,4057L,7351L,9127L,9601L,11617L,12697L,14407L,15607L,17497L,20887L,21601L,29401L,33751L,37447L,39367L,42337L,47527L,53017L,54151L,71287L,77977L,80737L,84967L,95257L,102967L,110977L,126151L,142297L,151687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090687Inst : IEnumerable<long>
{
public static readonly long[] Value=A090687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090687.Bytes);
public long this[int i]=>Value[i];

public static A090687Inst Instance=new A090687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090688
{
public static readonly long[] Value={ 3L,7L,2L,3L,19L,5L,251L,7L,89L,43L,11L,467L,13L,59L,67L,17L,683L,19L,83L,197L,367L,23L,103L,107L,251L,463L,29L,4463L,31L,131L,1223L,139L,11987L,37L,7643L,359L,163L,41L,13931L,43L,179L,33533L,751L,47L,199L,5099L,467L,211L,53L,1979L,223L,227L,521L,23599L,59L,8783L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090688Inst : IEnumerable<long>
{
public static readonly long[] Value=A090688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090688.Bytes);
public long this[int i]=>Value[i];

public static A090688Inst Instance=new A090688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090689
{
public static readonly long[] Value={ 3L,7L,19L,43L,59L,67L,83L,89L,103L,107L,131L,139L,163L,179L,197L,199L,211L,223L,227L,251L,263L,283L,307L,311L,331L,347L,359L,367L,379L,383L,419L,443L,463L,467L,479L,487L,491L,499L,503L,521L,523L,547L,563L,571L,587L,619L,643L,647L,659L,683L,691L,739L,743L,751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090689Inst : IEnumerable<long>
{
public static readonly long[] Value=A090689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090689.Bytes);
public long this[int i]=>Value[i];

public static A090689Inst Instance=new A090689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090690
{
public static readonly long[] Value={ 13L,29L,37L,53L,61L,73L,97L,101L,109L,127L,137L,149L,157L,173L,181L,193L,197L,229L,257L,269L,277L,293L,317L,337L,349L,373L,389L,397L,421L,457L,461L,487L,509L,541L,557L,569L,577L,613L,617L,641L,653L,661L,673L,677L,701L,709L,733L,757L,773L,797L,809L,811L,821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090690Inst : IEnumerable<long>
{
public static readonly long[] Value=A090690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090690.Bytes);
public long this[int i]=>Value[i];

public static A090690Inst Instance=new A090690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090691
{
public static readonly long[] Value={ 50L,25L,124L,62L,31L,154L,77L,384L,192L,96L,48L,24L,12L,6L,3L,14L,7L,34L,17L,84L,42L,21L,104L,52L,26L,13L,64L,32L,16L,8L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090691Inst : IEnumerable<long>
{
public static readonly long[] Value=A090691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090691.Bytes);
public long this[int i]=>Value[i];

public static A090691Inst Instance=new A090691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090772
{
public static readonly long[] Value={ 2L,8L,12L,18L,22L,28L,32L,38L,42L,48L,52L,58L,62L,68L,72L,78L,82L,88L,92L,98L,102L,108L,112L,118L,122L,128L,132L,138L,142L,148L,152L,158L,162L,168L,172L,178L,182L,188L,192L,198L,202L,208L,212L,218L,222L,228L,232L,238L,242L,248L,252L,258L,262L,268L,272L,278L,282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090772Inst : IEnumerable<long>
{
public static readonly long[] Value=A090772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090772.Bytes);
public long this[int i]=>Value[i];

public static A090772Inst Instance=new A090772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090773
{
public static readonly long[] Value={ 4L,6L,14L,16L,24L,26L,34L,36L,44L,46L,54L,56L,64L,66L,74L,76L,84L,86L,94L,96L,104L,106L,114L,116L,124L,126L,134L,136L,144L,146L,154L,156L,164L,166L,174L,176L,184L,186L,194L,196L,204L,206L,214L,216L,224L,226L,234L,236L,244L,246L,254L,256L,264L,266L,274L,276L,284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090773Inst : IEnumerable<long>
{
public static readonly long[] Value=A090773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090773.Bytes);
public long this[int i]=>Value[i];

public static A090773Inst Instance=new A090773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090774
{
public static readonly long[] Value={ 1L,3L,6L,2L,13L,12L,7L,10L,25L,14L,5L,27L,20L,29L,24L,4L,21L,51L,22L,49L,26L,15L,18L,41L,59L,40L,53L,28L,11L,55L,36L,45L,99L,42L,57L,30L,9L,43L,103L,38L,81L,107L,44L,61L,48L,8L,37L,83L,119L,72L,85L,115L,46L,97L,50L,31L,34L,73L,91L,199L,74L,89L,123L,80L,101L,52L,23L,111L,68L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090774Inst : IEnumerable<long>
{
public static readonly long[] Value=A090774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090774.Bytes);
public long this[int i]=>Value[i];

public static A090774Inst Instance=new A090774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090775
{
public static readonly long[] Value={ 1L,106L,246L,651L,1351L,1456L,3711L,13301L,21596L,52066L,73361L,96111L,117461L,141226L,158326L,159201L,159811L,169561L,178346L,214376L,240436L,280581L,296766L,301056L,329861L,337786L,377721L,413581L,464171L,473046L,535746L,539371L,572761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090775Inst : IEnumerable<long>
{
public static readonly long[] Value=A090775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090775.Bytes);
public long this[int i]=>Value[i];

public static A090775Inst Instance=new A090775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090776
{
public static readonly long[] Value={ 12L,24L,55L,62L,90L,262L,1090L,1245L,1459L,2057L,3043L,3296L,7390L,11625L,13961L,26423L,27557L,29833L,48809L,55711L,68794L,70180L,72554L,78025L,84654L,108590L,112321L,117995L,147101L,160730L,176889L,180829L,184182L,203586L,204116L,217587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090776Inst : IEnumerable<long>
{
public static readonly long[] Value=A090776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090776.Bytes);
public long this[int i]=>Value[i];

public static A090776Inst Instance=new A090776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090777
{
public static readonly long[] Value={ 1L,6L,28L,120L,364L,496L,672L,840L,1080L,1488L,1782L,2280L,3276L,3472L,7440L,8128L,8736L,11880L,12400L,18360L,20832L,24384L,25296L,26208L,30240L,30256L,32760L,35640L,37200L,56896L,57240L,84360L,86800L,90768L,115560L,121920L,131040L,149856L,170688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090777Inst : IEnumerable<long>
{
public static readonly long[] Value=A090777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090777.Bytes);
public long this[int i]=>Value[i];

public static A090777Inst Instance=new A090777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090778
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,10L,12L,16L,18L,20L,24L,32L,36L,40L,42L,48L,50L,54L,60L,64L,72L,80L,84L,96L,100L,108L,114L,120L,126L,128L,136L,144L,156L,160L,162L,168L,180L,192L,200L,216L,220L,228L,240L,250L,252L,256L,272L,288L,294L,300L,312L,320L,324L,336L,342L,360L,378L,384L,400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090778Inst : IEnumerable<long>
{
public static readonly long[] Value=A090778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090778.Bytes);
public long this[int i]=>Value[i];

public static A090778Inst Instance=new A090778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090779
{
public static readonly long[] Value={ 1L,4L,8L,9L,16L,18L,25L,27L,32L,36L,49L,50L,54L,64L,72L,81L,98L,100L,108L,121L,125L,128L,144L,147L,162L,169L,196L,200L,216L,225L,242L,243L,250L,256L,288L,289L,294L,324L,338L,343L,361L,392L,400L,432L,441L,450L,484L,486L,500L,507L,512L,529L,576L,578L,588L,605L,625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090779Inst : IEnumerable<long>
{
public static readonly long[] Value=A090779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090779.Bytes);
public long this[int i]=>Value[i];

public static A090779Inst Instance=new A090779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090780
{
public static readonly long[] Value={ 1L,1L,3L,2L,10L,3L,21L,4L,9L,10L,55L,6L,78L,21L,30L,8L,136L,9L,171L,20L,63L,55L,253L,12L,50L,78L,27L,42L,406L,30L,465L,16L,165L,136L,210L,18L,666L,171L,234L,40L,820L,63L,903L,110L,90L,253L,1081L,24L,147L,50L,408L,156L,1378L,27L,550L,84L,513L,406L,1711L,60L,1830L,465L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090780Inst : IEnumerable<long>
{
public static readonly long[] Value=A090780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090780.Bytes);
public long this[int i]=>Value[i];

public static A090780Inst Instance=new A090780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090781
{
public static readonly long[] Value={ 5L,16L,21L,24L,40L,45L,48L,96L,112L,117L,144L,160L,165L,192L,264L,280L,285L,288L,336L,352L,357L,504L,520L,525L,648L,816L,832L,837L,936L,952L,957L,1152L,1344L,1360L,1365L,1368L,1440L,1656L,1672L,1677L,1752L,1824L,1840L,1845L,1872L,1968L,2184L,2200L,2205L,2328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090781Inst : IEnumerable<long>
{
public static readonly long[] Value=A090781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090781.Bytes);
public long this[int i]=>Value[i];

public static A090781Inst Instance=new A090781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090782
{
public static readonly long[] Value={ 120L,168L,312L,408L,480L,552L,600L,672L,720L,1008L,1200L,1800L,2160L,2472L,2832L,2880L,3312L,3672L,4560L,5040L,5640L,6120L,6480L,6528L,7248L,7320L,7752L,7872L,8160L,8352L,8400L,8712L,8880L,9048L,9768L,9960L,10032L,10200L,10320L,10488L,10608L,10848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090782Inst : IEnumerable<long>
{
public static readonly long[] Value=A090782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090782.Bytes);
public long this[int i]=>Value[i];

public static A090782Inst Instance=new A090782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090783
{
public static readonly long[] Value={ 1848L,6888L,14280L,16008L,19152L,36120L,112728L,116832L,129480L,139080L,176520L,190632L,190968L,199752L,216840L,236208L,252120L,274848L,303960L,314160L,340368L,363720L,435792L,458280L,503160L,513240L,686160L,688680L,698880L,712680L,721560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090783Inst : IEnumerable<long>
{
public static readonly long[] Value=A090783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090783.Bytes);
public long this[int i]=>Value[i];

public static A090783Inst Instance=new A090783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090784
{
public static readonly long[] Value={ 72L,120L,168L,312L,408L,552L,600L,768L,792L,912L,1032L,2472L,3048L,3192L,3288L,3528L,3720L,4008L,5160L,5208L,5808L,5928L,6072L,6480L,6792L,6840L,7080L,7152L,7248L,7512L,7728L,7800L,8520L,8760L,9072L,11400L,11880L,11928L,12792L,13200L,13320L,13440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090784Inst : IEnumerable<long>
{
public static readonly long[] Value=A090784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090784.Bytes);
public long this[int i]=>Value[i];

public static A090784Inst Instance=new A090784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090785
{
public static readonly long[] Value={ 5L,16L,24L,48L,240L,288L,360L,432L,648L,672L,720L,840L,888L,960L,1080L,1128L,1248L,1320L,1392L,1488L,1560L,1608L,1680L,1728L,1800L,1920L,2040L,2088L,2112L,2232L,2280L,2400L,2520L,2568L,2640L,2808L,2832L,2880L,3120L,3240L,3312L,3360L,3432L,3672L,3912L,4080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090785Inst : IEnumerable<long>
{
public static readonly long[] Value=A090785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090785.Bytes);
public long this[int i]=>Value[i];

public static A090785Inst Instance=new A090785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090786
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,3L,14L,7L,0L,5L,16L,53L,4L,27L,6L,13L,18L,69L,8L,9L,8L,73L,106L,15L,32L,19L,38L,193L,76L,95L,46L,3L,62L,25L,94L,273L,4L,57L,12L,19L,54L,27L,2L,193L,54L,185L,4L,33L,10L,219L,0L,17L,168L,15L,92L,49L,224L,233L,210L,707L,68L,207L,2L,127L,216L,5L,14L,61L,68L,785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090786Inst : IEnumerable<long>
{
public static readonly long[] Value=A090786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090786.Bytes);
public long this[int i]=>Value[i];

public static A090786Inst Instance=new A090786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090787
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,2L,1L,0L,1L,2L,1L,0L,0L,2L,3L,1L,0L,0L,1L,2L,2L,1L,0L,1L,3L,3L,2L,2L,2L,1L,1L,3L,2L,0L,2L,3L,1L,1L,3L,4L,2L,1L,1L,2L,3L,3L,4L,2L,1L,2L,2L,1L,0L,3L,6L,5L,3L,1L,3L,3L,2L,3L,2L,3L,5L,5L,3L,4L,6L,4L,2L,1L,2L,4L,4L,5L,6L,7L,5L,2L,2L,2L,3L,5L,6L,4L,2L,6L,7L,4L,4L,4L,2L,2L,7L,9L,6L,3L,4L,7L,6L,4L,2L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090787Inst : IEnumerable<long>
{
public static readonly long[] Value=A090787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090787.Bytes);
public long this[int i]=>Value[i];

public static A090787Inst Instance=new A090787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090820
{
public static readonly long[] Value={ 25L,60L,120L,125L,180L,240L,300L,360L,480L,540L,600L,625L,660L,720L,840L,900L,960L,1080L,1200L,1320L,1440L,1500L,1620L,1680L,1800L,1860L,1920L,1980L,2160L,2400L,2460L,2520L,2640L,2700L,2760L,2880L,3000L,3060L,3125L,3240L,3300L,3360L,3420L,3600L,3660L,3720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090820Inst : IEnumerable<long>
{
public static readonly long[] Value=A090820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090820.Bytes);
public long this[int i]=>Value[i];

public static A090820Inst Instance=new A090820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090821
{
public static readonly long[] Value={ 4L,24L,48L,72L,90L,120L,168L,210L,240L,288L,360L,420L,462L,528L,600L,650L,702L,756L,840L,960L,1056L,1122L,1190L,1260L,1368L,1482L,1560L,1680L,1848L,1980L,2070L,2208L,2352L,2450L,2550L,2652L,2808L,2970L,3080L,3192L,3306L,3480L,3720L,3906L,4032L,4160L,4290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090821Inst : IEnumerable<long>
{
public static readonly long[] Value=A090821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090821.Bytes);
public long this[int i]=>Value[i];

public static A090821Inst Instance=new A090821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090822
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,2L,2L,3L,1L,1L,2L,1L,1L,2L,2L,2L,3L,2L,1L,1L,2L,1L,1L,2L,2L,2L,3L,1L,1L,2L,1L,1L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,3L,2L,1L,1L,2L,1L,1L,2L,2L,2L,3L,1L,1L,2L,1L,1L,2L,2L,2L,3L,2L,1L,1L,2L,1L,1L,2L,2L,2L,3L,1L,1L,2L,1L,1L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,3L,2L,2L,2L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090822Inst : IEnumerable<long>
{
public static readonly long[] Value=A090822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090822.Bytes);
public long this[int i]=>Value[i];

public static A090822Inst Instance=new A090822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090823
{
public static readonly BigInteger[] Value={ 61L,8205L,3440347021L,7080447489597L,BigInteger.Parse("171336855102372210685"),BigInteger.Parse("1747517658865390518778893"),BigInteger.Parse("610345691966794096778276272763149"),BigInteger.Parse("49983985045539556672075839852554462798428935229") };
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
public class A090823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090823Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090823.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090823.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090823Inst Instance=new A090823Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090824
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,2L,1L,1L,0L,1L,2L,2L,1L,1L,0L,1L,4L,7L,4L,1L,1L,0L,1L,4L,20L,19L,5L,1L,1L,0L,1L,7L,67L,159L,57L,8L,1L,1L,0L,1L,8L,238L,1607L,1163L,157L,9L,1L,1L,0L,1L,12L,868L,20478L,37251L,7546L,387L,13L,1L,1L,0L,1L,14L,3311L,312511L,1749868L,688733L,41377L,895L,16L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090824Inst : IEnumerable<long>
{
public static readonly long[] Value=A090824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090824.Bytes);
public long this[int i]=>Value[i];

public static A090824Inst Instance=new A090824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090825
{
public static readonly long[] Value={ 1L,49L,91L,119L,133L,169L,217L,221L,247L,259L,289L,301L,323L,329L,335L,343L,361L,403L,413L,427L,469L,481L,497L,511L,517L,527L,553L,559L,589L,611L,629L,637L,679L,703L,707L,721L,731L,749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090825Inst : IEnumerable<long>
{
public static readonly long[] Value=A090825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090825.Bytes);
public long this[int i]=>Value[i];

public static A090825Inst Instance=new A090825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090826
{
public static readonly long[] Value={ 0L,1L,2L,5L,12L,31L,85L,248L,762L,2440L,8064L,27300L,94150L,329462L,1166512L,4170414L,15031771L,54559855L,199236416L,731434971L,2697934577L,9993489968L,37157691565L,138633745173L,518851050388L,1947388942885L,7328186394725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090826Inst : IEnumerable<long>
{
public static readonly long[] Value=A090826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090826.Bytes);
public long this[int i]=>Value[i];

public static A090826Inst Instance=new A090826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090827
{
public static readonly long[] Value={ 1L,1L,2L,5L,13L,34L,91L,245L,659L,1786L,4846L,13182L,35962L,98418L,270121L,743533L,2052073L,5678238L,15750382L,43793198L,122042214L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090827Inst : IEnumerable<long>
{
public static readonly long[] Value=A090827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090827.Bytes);
public long this[int i]=>Value[i];

public static A090827Inst Instance=new A090827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090828
{
public static readonly long[] Value={ 1L,1L,2L,3L,7L,14L,37L,95L,285L,876L,2862L,9582L,33022L,115454L,409721L,1467781L,5305211L,19302774L,70662612L,259980148L,960908596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090828Inst : IEnumerable<long>
{
public static readonly long[] Value=A090828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090828.Bytes);
public long this[int i]=>Value[i];

public static A090828Inst Instance=new A090828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090829
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,5L,12L,14L,20L,20L,28L,28L,36L,36L,44L,44L,52L,52L,60L,60L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090829Inst : IEnumerable<long>
{
public static readonly long[] Value=A090829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090829.Bytes);
public long this[int i]=>Value[i];

public static A090829Inst Instance=new A090829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090830
{
public static readonly long[] Value={ 1L,1L,1L,3L,12L,60L,120L,840L,1680L,5040L,5040L,55440L,110880L,1441440L,1441440L,1441440L,1441440L,24504480L,24504480L,465585120L,931170240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090830Inst : IEnumerable<long>
{
public static readonly long[] Value=A090830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090830.Bytes);
public long this[int i]=>Value[i];

public static A090830Inst Instance=new A090830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090831
{
public static readonly long[] Value={ 2L,7L,22L,75L,298L,1409L,7900L,52021L,397756L,3468667L,33656220L,354326769L,3970080798L,46804154165L,577838630958L,7468797926219L,101264140457250L,1443524097355225L,21670184170964846L,342875871451985761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090831Inst : IEnumerable<long>
{
public static readonly long[] Value=A090831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090831.Bytes);
public long this[int i]=>Value[i];

public static A090831Inst Instance=new A090831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090832
{
public static readonly long[] Value={ 54L,271L,464L,682L,709L,821L,829L,1510L,1594L,1726L,1842L,1853L,2009L,2086L,2209L,2600L,2876L,3253L,3303L,5463L,5689L,6252L,6386L,7064L,7438L,7620L,7728L,7918L,8090L,8145L,8229L,8631L,8654L,8828L,9105L,9184L,9243L,9997L,10052L,10074L,10329L,10934L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090832Inst : IEnumerable<long>
{
public static readonly long[] Value=A090832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090832.Bytes);
public long this[int i]=>Value[i];

public static A090832Inst Instance=new A090832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090833
{
public static readonly long[] Value={ 41L,290L,550L,850L,896L,1051L,1060L,2106L,2241L,2456L,2631L,2650L,2911L,3035L,3245L,3886L,4361L,5015L,5105L,8935L,9346L,10366L,10615L,11890L,12586L,12925L,13131L,13485L,13796L,13905L,14071L,14850L,14896L,15215L,15736L,15876L,15985L,17451L,17560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090833Inst : IEnumerable<long>
{
public static readonly long[] Value=A090833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090833.Bytes);
public long this[int i]=>Value[i];

public static A090833Inst Instance=new A090833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090834
{
public static readonly long[] Value={ 251L,5381L,6311L,12641L,13451L,14741L,15791L,17471L,23321L,26171L,56081L,62201L,75521L,78791L,82781L,84431L,89381L,94421L,95261L,104711L,115751L,120551L,121001L,154061L,162251L,163841L,179801L,185051L,187361L,191021L,206021L,214451L,222311L,226631L,243521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090834Inst : IEnumerable<long>
{
public static readonly long[] Value=A090834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090834.Bytes);
public long this[int i]=>Value[i];

public static A090834Inst Instance=new A090834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090835
{
public static readonly long[] Value={ 54L,709L,821L,1510L,1594L,1726L,1842L,2009L,2609L,2876L,5689L,6252L,7438L,7728L,8090L,8229L,8654L,9105L,9184L,9997L,10934L,11343L,11390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090835Inst : IEnumerable<long>
{
public static readonly long[] Value=A090835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090835.Bytes);
public long this[int i]=>Value[i];

public static A090835Inst Instance=new A090835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090868
{
public static readonly long[] Value={ 1L,1L,3L,2L,6L,5L,11L,8L,20L,15L,32L,24L,51L,39L,80L,58L,119L,90L,175L,130L,255L,190L,361L,268L,508L,379L,706L,522L,967L,722L,1313L,974L,1771L,1317L,2363L,1754L,3131L,2330L,4123L,3058L,5388L,4010L,7001L,5200L,9053L,6731L,11631L,8642L,14878L,11068L,18944L,14076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090868Inst : IEnumerable<long>
{
public static readonly long[] Value=A090868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090868.Bytes);
public long this[int i]=>Value[i];

public static A090868Inst Instance=new A090868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090869
{
public static readonly long[] Value={ 613L,877L,1117L,1721L,1753L,2153L,2557L,2671L,4349L,4943L,5039L,5179L,5443L,5641L,5939L,6037L,6827L,6997L,7591L,7853L,8069L,8209L,8527L,8669L,9221L,9311L,9377L,9859L,10729L,11149L,11353L,11503L,11933L,12211L,12413L,12743L,12923L,13001L,13037L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090869Inst : IEnumerable<long>
{
public static readonly long[] Value=A090869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090869.Bytes);
public long this[int i]=>Value[i];

public static A090869Inst Instance=new A090869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090870
{
public static readonly long[] Value={ 2L,3L,7L,69L,1642L,12073L,12073L,6496152L,118033638L,5575956036L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090870Inst : IEnumerable<long>
{
public static readonly long[] Value=A090870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090870.Bytes);
public long this[int i]=>Value[i];

public static A090870Inst Instance=new A090870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090871
{
public static readonly long[] Value={ 589407L,2372675L,5609052L,5698663L,12353466L,12534100L,14155932L,24208353L,25303609L,24208353L,25303609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090871Inst : IEnumerable<long>
{
public static readonly long[] Value=A090871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090871.Bytes);
public long this[int i]=>Value[i];

public static A090871Inst Instance=new A090871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090872
{
public static readonly long[] Value={ 2L,2L,2L,2L,2L,7072833120L,2072005925466L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090872Inst : IEnumerable<long>
{
public static readonly long[] Value=A090872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090872.Bytes);
public long this[int i]=>Value[i];

public static A090872Inst Instance=new A090872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090873
{
public static readonly long[] Value={ 1L,1L,218368L,9324385L,6628674L,601L,365082L,532253L,449140L,4193407L,175746L,2857547L,2752708L,6315245L,80612L,3354745L,10892L,953L,6577504L,157437L,2247676L,11357637L,7650L,272935L,318784L,8034141L,1158380L,22315L,610550L,340357L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090873Inst : IEnumerable<long>
{
public static readonly long[] Value=A090873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090873.Bytes);
public long this[int i]=>Value[i];

public static A090873Inst Instance=new A090873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090874
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1806390369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090874Inst : IEnumerable<long>
{
public static readonly long[] Value=A090874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090874.Bytes);
public long this[int i]=>Value[i];

public static A090874Inst Instance=new A090874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090875
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2321204055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090875Inst : IEnumerable<long>
{
public static readonly long[] Value=A090875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090875.Bytes);
public long this[int i]=>Value[i];

public static A090875Inst Instance=new A090875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090876
{
public static readonly long[] Value={ 39L,62L,72L,108L,114L,144L,166L,176L,256L,286L,294L,312L,326L,340L,360L,372L,418L,426L,458L,472L,490L,506L,528L,542L,574L,590L,604L,630L,674L,704L,714L,730L,756L,768L,784L,800L,810L,816L,830L,854L,874L,882L,898L,914L,928L,952L,968L,1008L,1064L,1074L,1092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090876Inst : IEnumerable<long>
{
public static readonly long[] Value=A090876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090876.Bytes);
public long this[int i]=>Value[i];

public static A090876Inst Instance=new A090876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090877
{
public static readonly long[] Value={ 35L,56L,62L,94L,92L,118L,132L,138L,210L,228L,232L,230L,240L,246L,254L,250L,276L,280L,300L,306L,312L,312L,314L,324L,348L,336L,330L,352L,372L,378L,380L,384L,398L,406L,402L,414L,416L,418L,408L,408L,420L,424L,420L,432L,426L,414L,414L,446L,438L,440L,430L,436L,448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090877Inst : IEnumerable<long>
{
public static readonly long[] Value=A090877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090877.Bytes);
public long this[int i]=>Value[i];

public static A090877Inst Instance=new A090877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090878
{
public static readonly BigInteger[] Value={ 2L,5L,26L,103L,2194L,1223L,472730L,556403L,21323986L,7281587L,125858034202L,180451625L,121437725363954L,595953719897L,26649932810926L,3211211914492699L,BigInteger.Parse("285050975993898158530"),549689343118061L,BigInteger.Parse("640611888918574971191834") };
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
public class A090878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090878Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090878.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090878.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090878Inst Instance=new A090878Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090879
{
public static readonly long[] Value={ 1L,4L,7L,20L,21L,94L,71L,328L,457L,1194L,1035L,7052L,4109L,17294L,33807L,83984L,65553L,389650L,262163L,1484820L,1949717L,4216854L,4194327L,29409304L,22020121L,67215386L,119799835L,350453788L,268435485L,1755807774L,1073741855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090879Inst : IEnumerable<long>
{
public static readonly long[] Value=A090879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090879.Bytes);
public long this[int i]=>Value[i];

public static A090879Inst Instance=new A090879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090880
{
public static readonly long[] Value={ 0L,1L,3L,2L,9L,4L,27L,3L,6L,10L,81L,5L,243L,28L,12L,4L,729L,7L,2187L,11L,30L,82L,6561L,6L,18L,244L,9L,29L,19683L,13L,59049L,5L,84L,730L,36L,8L,177147L,2188L,246L,12L,531441L,31L,1594323L,83L,15L,6562L,4782969L,7L,54L,19L,732L,245L,14348907L,10L,90L,30L,2190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090880Inst : IEnumerable<long>
{
public static readonly long[] Value=A090880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090880.Bytes);
public long this[int i]=>Value[i];

public static A090880Inst Instance=new A090880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090881
{
public static readonly long[] Value={ 0L,1L,4L,2L,16L,5L,64L,3L,8L,17L,256L,6L,1024L,65L,20L,4L,4096L,9L,16384L,18L,68L,257L,65536L,7L,32L,1025L,12L,66L,262144L,21L,1048576L,5L,260L,4097L,80L,10L,4194304L,16385L,1028L,19L,16777216L,69L,67108864L,258L,24L,65537L,268435456L,8L,128L,33L,4100L,1026L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090881Inst : IEnumerable<long>
{
public static readonly long[] Value=A090881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090881.Bytes);
public long this[int i]=>Value[i];

public static A090881Inst Instance=new A090881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090882
{
public static readonly long[] Value={ 0L,1L,5L,2L,25L,6L,125L,3L,10L,26L,625L,7L,3125L,126L,30L,4L,15625L,11L,78125L,27L,130L,626L,390625L,8L,50L,3126L,15L,127L,1953125L,31L,9765625L,5L,630L,15626L,150L,12L,48828125L,78126L,3130L,28L,244140625L,131L,1220703125L,627L,35L,390626L,6103515625L,9L,250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090882Inst : IEnumerable<long>
{
public static readonly long[] Value=A090882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090882.Bytes);
public long this[int i]=>Value[i];

public static A090882Inst Instance=new A090882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090883
{
public static readonly long[] Value={ 0L,1L,3L,2L,25L,7L,343L,3L,18L,101L,14641L,14L,371293L,2745L,240L,4L,24137569L,37L,893871739L,402L,9282L,234257L,78310985281L,27L,1250L,11881377L,81L,21954L,14507145975869L,931L,819628286980801L,5L,1185954L,1544804417L,44100L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090883Inst : IEnumerable<long>
{
public static readonly long[] Value=A090883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090883.Bytes);
public long this[int i]=>Value[i];

public static A090883Inst Instance=new A090883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090900
{
public static readonly BigInteger[] Value={ 2L,9L,27L,6561L,39135393L,1291467969L,3404825447L,248155780267521L,BigInteger.Parse("8422942255954625293713"),BigInteger.Parse("717897987691852588770249") };
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
public class A090900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090900Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090900.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090900.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090900Inst Instance=new A090900Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090901
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,17L,38L,91L,230L,605L,1661L,4735L,13998L,42795L,135021L,438826L,1466690L,5033778L,17716515L,63865399L,235547709L,887938469L,3418054843L,13424588130L,53753996494L,219278318407L,910679550679L,3848136018924L,16534775039068L,72206065899240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090901Inst : IEnumerable<long>
{
public static readonly long[] Value=A090901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090901.Bytes);
public long this[int i]=>Value[i];

public static A090901Inst Instance=new A090901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090902
{
public static readonly ulong[] Value={ 1L,1L,2L,5L,17L,64L,268L,1236L,6286L,35031L,212401L,1392489L,9817398L,74078419L,595722994L,5086611025L,45961503660L,438168680119L,4395396953168L,46281082011630L,510378647082537L,5882795810558767L,70740717281280862L,885944239324190839L,11537420341016416104UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090902Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A090902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090902.Bytes);
public ulong this[int i]=>Value[i];

public static A090902Inst Instance=new A090902Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090903
{
public static readonly long[] Value={ 1L,3L,3L,3L,4L,5L,5L,6L,7L,7L,0L,7L,6L,0L,3L,3L,6L,1L,3L,3L,0L,7L,3L,1L,9L,6L,7L,3L,8L,3L,4L,1L,6L,7L,8L,7L,7L,5L,3L,5L,8L,3L,6L,4L,7L,3L,4L,7L,8L,5L,7L,9L,7L,2L,2L,5L,2L,5L,0L,9L,8L,1L,9L,8L,1L,0L,0L,3L,9L,9L,9L,5L,4L,5L,1L,7L,3L,6L,1L,6L,0L,6L,8L,2L,9L,7L,2L,1L,7L,3L,5L,8L,9L,5L,7L,1L,2L,2L,2L,6L,1L,7L,7L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090903Inst : IEnumerable<long>
{
public static readonly long[] Value=A090903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090903.Bytes);
public long this[int i]=>Value[i];

public static A090903Inst Instance=new A090903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090904
{
public static readonly BigInteger[] Value={ 1L,2L,12L,1680L,2162160L,4626053752320000L,BigInteger.Parse("13644281345408020027550269440000"),BigInteger.Parse("4402827357584746886229433170489943024971625310770489684257669120000000000") };
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
public class A090904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090904Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090904.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090904.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090904Inst Instance=new A090904Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090905
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,15L,27L,47L,87L,167L,327L,635L,1263L,2519L,5007L,10007L,19947L,39875L,79739L,159399L,318779L,637503L,1274999L,2549979L,5099903L,10199787L,20399535L,40799063L,81598083L,163196135L,326392259L,652784499L,1305568943L,2611137839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090905Inst : IEnumerable<long>
{
public static readonly long[] Value=A090905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090905.Bytes);
public long this[int i]=>Value[i];

public static A090905Inst Instance=new A090905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090906
{
public static readonly long[] Value={ 1L,1L,2L,4L,6L,12L,20L,40L,80L,160L,308L,628L,1256L,2488L,5000L,9940L,19928L,39864L,79660L,159380L,318724L,637496L,1274980L,2549924L,5099884L,10199748L,20399528L,40799020L,81598052L,163196124L,326392240L,652784444L,1305568896L,2611137796L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090906Inst : IEnumerable<long>
{
public static readonly long[] Value=A090906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090906.Bytes);
public long this[int i]=>Value[i];

public static A090906Inst Instance=new A090906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090907
{
public static readonly BigInteger[] Value={ 2L,6L,140L,1287L,2139552000L,2949442889323392L,BigInteger.Parse("322686644032484531917367528014184448000000") };
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
public class A090907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090907Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090907.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090907.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090907Inst Instance=new A090907Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090908
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,9L,11L,12L,14L,16L,17L,19L,21L,22L,24L,25L,27L,29L,30L,32L,33L,35L,37L,38L,40L,42L,43L,45L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090908Inst : IEnumerable<long>
{
public static readonly long[] Value=A090908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090908.Bytes);
public long this[int i]=>Value[i];

public static A090908Inst Instance=new A090908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090909
{
public static readonly long[] Value={ 0L,2L,5L,7L,10L,13L,15L,18L,20L,23L,26L,28L,31L,34L,36L,39L,41L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090909Inst : IEnumerable<long>
{
public static readonly long[] Value=A090909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090909.Bytes);
public long this[int i]=>Value[i];

public static A090909Inst Instance=new A090909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090910
{
public static readonly long[] Value={ 1L,3L,6L,23L,4L,9L,2L,45L,8L,67L,56L,123L,34L,5L,78L,7L,234L,1415L,1234L,1011L,910L,89L,456L,1213L,12L,2345L,678L,2425L,3456L,1819L,123456L,2627L,45678L,4445L,101112L,3031L,5678L,345L,1516L,789L,1718L,567L,2728L,100101L,2324L,4567L,1314L,891011L,4344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090910Inst : IEnumerable<long>
{
public static readonly long[] Value=A090910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090910.Bytes);
public long this[int i]=>Value[i];

public static A090910Inst Instance=new A090910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090911
{
public static readonly long[] Value={ 1L,3L,6L,1L,8L,45L,2L,789L,56L,3L,34L,5L,78L,7L,234L,1L,12L,1213L,456L,7L,1314L,23L,4L,45L,1516L,5L,234L,23L,6L,67L,8L,345L,34L,123L,56L,9L,1112L,3L,910L,23L,456L,67L,234L,1415L,6L,89L,456L,2345L,4L,567L,1718L,9L,2122L,23L,1516L,89L,910L,1011L,2L,2223L,10111012L,1415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090911Inst : IEnumerable<long>
{
public static readonly long[] Value=A090911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090911.Bytes);
public long this[int i]=>Value[i];

public static A090911Inst Instance=new A090911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090912
{
public static readonly long[] Value={ 2L,3L,5L,7L,37L,43L,787L,733L,53L,31L,29L,73L,71L,227L,233L,11L,1201L,757L,449L,1307L,1291L,19L,41L,1471L,1511L,229L,211L,17L,61L,59L,337L,311L,89L,67L,47L,1103L,1109L,907L,887L,433L,389L,167L,1181L,1409L,83L,367L,1889L,2341L,563L,1151L,1709L,2113L,2099L,1493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090912Inst : IEnumerable<long>
{
public static readonly long[] Value=A090912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090912.Bytes);
public long this[int i]=>Value[i];

public static A090912Inst Instance=new A090912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090913
{
public static readonly long[] Value={ 2L,3L,17L,19L,5L,7L,43L,37L,59L,11L,67L,89L,29L,73L,71L,227L,1181L,181L,223L,101L,821L,367L,757L,1201L,2333L,1667L,1747L,1031L,1637L,121637L,120829L,43051L,41233L,96667L,98081L,2647L,5333L,1171L,727L,929L,1151L,2161L,97373L,97777L,2243L,3253L,889697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090913Inst : IEnumerable<long>
{
public static readonly long[] Value=A090913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090913.Bytes);
public long this[int i]=>Value[i];

public static A090913Inst Instance=new A090913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090914
{
public static readonly BigInteger[] Value={ 1L,1L,12L,1800L,3528000L,93350880000L,34157460395520000L,BigInteger.Parse("176018448722253096960000"),BigInteger.Parse("12957844528516872887046144000000"),BigInteger.Parse("13783997562964632581368087262085120000000") };
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
public class A090914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090914Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090914.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090914.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090914Inst Instance=new A090914Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090915
{
public static readonly long[] Value={ 1L,8L,7L,6L,5L,4L,3L,2L,9L,24L,23L,22L,21L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,25L,48L,47L,46L,45L,44L,43L,42L,41L,40L,39L,38L,37L,36L,35L,34L,33L,32L,31L,30L,29L,28L,27L,26L,49L,80L,79L,78L,77L,76L,75L,74L,73L,72L,71L,70L,69L,68L,67L,66L,65L,64L,63L,62L,61L,60L,59L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090915Inst : IEnumerable<long>
{
public static readonly long[] Value=A090915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090915.Bytes);
public long this[int i]=>Value[i];

public static A090915Inst Instance=new A090915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091028
{
public static readonly BigInteger[] Value={ 1L,-1L,-299L,40751L,5067841L,-7323445921L,-999631061099L,8071239253153439L,3226932423143680609L,BigInteger.Parse("-35637793578511857426241"),BigInteger.Parse("-56681720635442893862661899"),BigInteger.Parse("428341845237867375193339807439"),BigInteger.Parse("2249822227541602344980346463546081") };
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
public class A091028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091028Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091028.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091028.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091028Inst Instance=new A091028Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091029
{
public static readonly long[] Value={ 1L,3L,-2L,2L,6L,-9L,3L,15L,0L,-24L,18L,-4L,5L,69L,-75L,-20L,60L,-30L,5L,63L,217L,-462L,225L,80L,-120L,45L,-6L,14L,462L,300L,-1848L,1785L,-525L,-210L,210L,-63L,7L,252L,2460L,-1809L,-4932L,8428L,-5208L,1050L,448L,-336L,84L,-8L,42L,2556L,9747L,-18775L,-2655L,28296L,-28182L,12726L,-1890L,-840L,504L,-108L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091029Inst : IEnumerable<long>
{
public static readonly long[] Value=A091029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091029.Bytes);
public long this[int i]=>Value[i];

public static A091029Inst Instance=new A091029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091030
{
public static readonly long[] Value={ 1L,14L,183L,2380L,30941L,402234L,5229043L,67977560L,883708281L,11488207654L,149346699503L,1941507093540L,25239592216021L,328114698808274L,4265491084507563L,55451384098598320L,720867993281778161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091030Inst : IEnumerable<long>
{
public static readonly long[] Value=A091030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091030.Bytes);
public long this[int i]=>Value[i];

public static A091030Inst Instance=new A091030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091031
{
public static readonly long[] Value={ 1L,16L,114L,644L,3270L,15642L,72072L,323752L,1428102L,6214520L,26761196L,114287736L,484816540L,2045277990L,8588492100L,35923392720L,149753379270L,622458753840L,2580709189740L,10675646755800L,44074384410420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091031Inst : IEnumerable<long>
{
public static readonly long[] Value=A091031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091031.Bytes);
public long this[int i]=>Value[i];

public static A091031Inst Instance=new A091031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091032
{
public static readonly BigInteger[] Value={ 1L,60L,5040L,604800L,99792000L,21794572800L,6102480384000L,2134124568576000L,912338253066240000L,BigInteger.Parse("468333636574003200000"),BigInteger.Parse("284372184127734743040000"),BigInteger.Parse("201645730563302817792000000"),BigInteger.Parse("165147853331345007771648000000") };
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
public class A091032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091032Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091032.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091032.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091032Inst Instance=new A091032Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091033
{
public static readonly BigInteger[] Value={ 1L,180L,25200L,4233600L,898128000L,239740300800L,79332244992000L,32011868528640000L,15509750302126080000UL,BigInteger.Parse("8898339094906060800000"),BigInteger.Parse("5971815866682429603840000"),BigInteger.Parse("4637851802955964809216000000") };
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
public class A091033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091033Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091033.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091033.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091033Inst Instance=new A091033Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091034
{
public static readonly BigInteger[] Value={ 1L,280L,70560L,19958400L,6659452800L,2644408166400L,1244905998336000L,689322235650048000L,BigInteger.Parse("444916954745303040000"),BigInteger.Parse("331767548149023866880000"),BigInteger.Parse("283424276847308960563200000"),BigInteger.Parse("275246422218908346286080000000") };
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
public class A091034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091034Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091034.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091034.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091034Inst Instance=new A091034Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091035
{
public static readonly BigInteger[] Value={ 1L,840L,352800L,139708800L,59935075200L,29088489830400L,16183777978368000L,10339833534750720000UL,BigInteger.Parse("7563588230670151680000"),BigInteger.Parse("6303583414831453470720000"),BigInteger.Parse("5951909813793488171827200000"),BigInteger.Parse("6330667711034891964579840000000") };
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
public class A091035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091035Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091035.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091035.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091035Inst Instance=new A091035Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091036
{
public static readonly BigInteger[] Value={ 1L,840L,498960L,285405120L,173145772800L,115598414131200L,86165279456256000L,BigInteger.Parse("72034173625430016000"),BigInteger.Parse("67538393730337001472000"),BigInteger.Parse("70856069211827240140800000"),BigInteger.Parse("82901600977837870964736000000") };
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
public class A091036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091036Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091036.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091036.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091036Inst Instance=new A091036Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091037
{
public static readonly BigInteger[] Value={ 1L,144L,17856L,2156544L,259117056L,31102009344L,3732432224256L,447896453382144L,53747684481171456L,6449724779548114944L,BigInteger.Parse("773967036949154758656"),BigInteger.Parse("92876045955579714207744") };
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
public class A091037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091037Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091037.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091037.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091037Inst Instance=new A091037Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091038
{
public static readonly BigInteger[] Value={ 1L,840L,619200L,447552000L,322444800000L,232185139200000L,167176286208000000L,BigInteger.Parse("120367284387840000000"),BigInteger.Parse("86664487757414400000000"),BigInteger.Parse("62398436345118720000000000"),BigInteger.Parse("44926874787659120640000000000") };
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
public class A091038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091038Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091038.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091038.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091038Inst Instance=new A091038Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091039
{
public static readonly long[] Value={ 1L,3L,1L,7L,8L,1L,15L,52L,30L,1L,31L,320L,756L,144L,1L,63L,1936L,18360L,17856L,840L,1L,127L,11648L,441936L,2156544L,619200L,5760L,1L,255L,69952L,10614240L,259117056L,447552000L,29548800L,45360L,1L,511L,419840L,254788416L,31102009344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091039Inst : IEnumerable<long>
{
public static readonly long[] Value=A091039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091039.Bytes);
public long this[int i]=>Value[i];

public static A091039Inst Instance=new A091039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091040
{
public static readonly BigInteger[] Value={ 1L,4L,16L,98L,1252L,39056L,3235216L,746947664L,504955938112L,1063702416056576L,7035749505695570176L,BigInteger.Parse("160587398553186610959104"),BigInteger.Parse("12278492143557175831484111872"),BigInteger.Parse("3469220019297527430713345352498176") };
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
public class A091040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091040Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091040.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091040.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091040Inst Instance=new A091040Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091041
{
public static readonly BigInteger[] Value={ 1L,2L,0L,-8L,324L,-530L,-1112688L,169476046L,144151873344L,-449531744387330L,-660618519039237888L,BigInteger.Parse("83329012852592671058686"),BigInteger.Parse("-2072231651447029998880551936"),BigInteger.Parse("-1674940664087026476131857832322050"),BigInteger.Parse("1501486075410203396595208137534328983552") };
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
public class A091041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091041Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A091041.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A091041.Bytes);
public BigInteger this[int i]=>Value[i];

public static A091041Inst Instance=new A091041Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A091042
{
public static readonly long[] Value={ 1L,1L,3L,1L,10L,5L,1L,21L,35L,7L,1L,36L,126L,84L,9L,1L,55L,330L,462L,165L,11L,1L,78L,715L,1716L,1287L,286L,13L,1L,105L,1365L,5005L,6435L,3003L,455L,15L,1L,136L,2380L,12376L,24310L,19448L,6188L,680L,17L,1L,171L,3876L,27132L,75582L,92378L,50388L,11628L,969L,19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A091042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A091042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A091042Inst : IEnumerable<long>
{
public static readonly long[] Value=A091042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A091042.Bytes);
public long this[int i]=>Value[i];

public static A091042Inst Instance=new A091042Inst();

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