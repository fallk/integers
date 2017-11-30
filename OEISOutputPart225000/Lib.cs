using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A275662
{
public static readonly long[] Value={ 1L,3L,1L,7L,6L,1L,15L,18L,7L,1L,31L,48L,17L,9L,1L,63L,109L,49L,20L,11L,1L,127L,240L,115L,52L,24L,13L,1L,255L,498L,258L,122L,61L,28L,15L,1L,511L,1026L,551L,261L,136L,71L,32L,17L,1L,1023L,2065L,1163L,531L,298L,157L,81L,36L,19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275662Inst : IEnumerable<long>
{
public static readonly long[] Value=A275662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275662.Bytes);
public long this[int i]=>Value[i];

public static A275662Inst Instance=new A275662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275663
{
public static readonly long[] Value={ 1L,1L,3L,2L,3L,3L,3L,2L,4L,3L,3L,3L,3L,3L,3L,3L,3L,4L,3L,3L,4L,3L,3L,3L,4L,3L,5L,3L,3L,3L,5L,3L,5L,3L,3L,5L,3L,3L,3L,3L,5L,4L,5L,3L,3L,3L,5L,3L,4L,4L,3L,3L,3L,5L,5L,3L,5L,3L,3L,3L,3L,5L,3L,4L,5L,5L,3L,3L,3L,3L,5L,5L,5L,3L,5L,3L,3L,3L,3L,3L,4L,5L,5L,4L,5L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275663Inst : IEnumerable<long>
{
public static readonly long[] Value=A275663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275663.Bytes);
public long this[int i]=>Value[i];

public static A275663Inst Instance=new A275663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275664
{
public static readonly BigInteger[] Value={ 2L,4L,6L,14L,86L,3614L,6526886L,21300113901614L,BigInteger.Parse("226847426110843688722000886"),BigInteger.Parse("25729877366557343481074291996721923093306518970391614") };
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
public class A275664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275664Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275664.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275664.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275664Inst Instance=new A275664Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275665
{
public static readonly long[] Value={ 1L,6L,10L,12L,14L,15L,18L,20L,21L,22L,24L,26L,28L,33L,34L,35L,36L,38L,39L,40L,44L,45L,46L,48L,50L,51L,52L,54L,55L,56L,57L,58L,62L,63L,65L,68L,69L,72L,74L,75L,76L,77L,80L,82L,85L,86L,87L,88L,91L,92L,93L,94L,95L,96L,98L,99L,100L,104L,106L,108L,111L,112L,115L,116L,117L,118L,119L,122L,123L,124L,129L,133L,134L,135L,136L,141L,142L,143L,144L,145L,146L,147L,148L,152L,153L,155L,158L,159L,160L,161L,162L,164L,165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275665Inst : IEnumerable<long>
{
public static readonly long[] Value=A275665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275665.Bytes);
public long this[int i]=>Value[i];

public static A275665Inst Instance=new A275665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275666
{
public static readonly long[] Value={ 2L,3L,6L,2L,5L,5L,10L,3L,5L,5L,6L,10L,2L,4L,6L,12L,3L,3L,4L,12L,4L,5L,5L,6L,10L,12L,2L,7L,7L,7L,14L,3L,6L,7L,7L,7L,14L,4L,6L,7L,7L,7L,12L,14L,5L,5L,7L,7L,7L,10L,14L,2L,3L,10L,15L,2L,4L,10L,12L,15L,2L,5L,6L,15L,15L,3L,3L,5L,15L,15L,3L,3L,6L,10L,15L,3L,5L,5L,5L,15L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275666Inst : IEnumerable<long>
{
public static readonly long[] Value=A275666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275666.Bytes);
public long this[int i]=>Value[i];

public static A275666Inst Instance=new A275666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275667
{
public static readonly long[] Value={ 1L,3L,7L,9L,7L,21L,25L,27L,7L,21L,49L,63L,25L,75L,103L,81L,7L,21L,49L,63L,49L,147L,175L,189L,25L,75L,175L,225L,103L,309L,409L,243L,7L,21L,49L,63L,49L,147L,175L,189L,49L,147L,343L,441L,175L,525L,721L,567L,25L,75L,175L,225L,175L,525L,625L,675L,103L,309L,721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275667Inst : IEnumerable<long>
{
public static readonly long[] Value=A275667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275667.Bytes);
public long this[int i]=>Value[i];

public static A275667Inst Instance=new A275667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275668
{
public static readonly long[] Value={ 1L,3L,5L,10L,12L,15L,33L,35L,39L,42L,45L,50L,58L,68L,75L,117L,119L,164L,180L,189L,194L,216L,236L,246L,249L,259L,262L,389L,391L,404L,420L,501L,552L,604L,609L,658L,825L,827L,888L,910L,946L,1035L,1049L,1088L,1160L,1229L,1279L,1535L,1537L,1577L,1600L,1603L,1613L,1652L,1677L,1687L,1736L,1744L,1784L,1796L,1847L,1910L,1975L,2214L,2397L,2426L,2561L,2615L,2629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275668Inst : IEnumerable<long>
{
public static readonly long[] Value=A275668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275668.Bytes);
public long this[int i]=>Value[i];

public static A275668Inst Instance=new A275668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275669
{
public static readonly long[] Value={ 3L,5L,7L,9L,11L,12L,13L,15L,17L,19L,21L,22L,23L,25L,26L,27L,29L,31L,32L,33L,35L,37L,39L,40L,41L,42L,43L,45L,47L,48L,49L,51L,52L,53L,54L,55L,57L,59L,61L,62L,63L,65L,67L,68L,69L,70L,71L,72L,73L,74L,75L,77L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275669Inst : IEnumerable<long>
{
public static readonly long[] Value=A275669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275669.Bytes);
public long this[int i]=>Value[i];

public static A275669Inst Instance=new A275669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275670
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,0L,4L,0L,8L,1L,0L,16L,4L,0L,32L,14L,0L,64L,40L,0L,128L,108L,2L,0L,256L,272L,12L,0L,512L,664L,52L,0L,1024L,1568L,188L,0L,2048L,3632L,608L,1L,0L,4096L,8256L,1816L,12L,0L,8192L,18528L,5128L,76L,0L,16384L,41088L,13856L,360L,0L,32768L,90304L,36176L,1446L,0L,65536L,196864L,91856L,5192L,4L,0L,131072L,426368L,227968L,17192L,42L,0L,262144L,918016L,555040L,53504L,284L,0L,524288L,1966848L,1329696L,158588L,1496L,0L,1048576L,4195328L,3141632L,451824L,6704L,0L,2097152L,8914432L,7334208L,1245936L,26772L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275670Inst : IEnumerable<long>
{
public static readonly long[] Value=A275670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275670.Bytes);
public long this[int i]=>Value[i];

public static A275670Inst Instance=new A275670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275671
{
public static readonly long[] Value={ 4L,6L,8L,12L,14L,18L,20L,24L,28L,30L,32L,36L,38L,40L,42L,44L,48L,54L,56L,60L,62L,68L,72L,74L,78L,80L,84L,90L,96L,98L,102L,104L,108L,110L,112L,114L,120L,124L,126L,128L,132L,138L,140L,144L,150L,152L,156L,158L,160L,162L,164L,168L,174L,176L,180L,182L,186L,192L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275671Inst : IEnumerable<long>
{
public static readonly long[] Value=A275671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275671.Bytes);
public long this[int i]=>Value[i];

public static A275671Inst Instance=new A275671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275672
{
public static readonly long[] Value={ 0L,1L,3L,4L,6L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275672Inst : IEnumerable<long>
{
public static readonly long[] Value=A275672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275672.Bytes);
public long this[int i]=>Value[i];

public static A275672Inst Instance=new A275672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275673
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,11L,13L,15L,17L,19L,22L,25L,28L,31L,34L,37L,41L,45L,49L,53L,57L,61L,66L,71L,76L,81L,86L,91L,97L,103L,109L,115L,121L,127L,134L,141L,148L,155L,162L,169L,177L,185L,193L,201L,209L,217L,226L,235L,244L,253L,262L,271L,281L,291L,301L,311L,321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275673Inst : IEnumerable<long>
{
public static readonly long[] Value=A275673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275673.Bytes);
public long this[int i]=>Value[i];

public static A275673Inst Instance=new A275673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275674
{
public static readonly long[] Value={ 1L,2L,4L,16L,25L,50L,64L,100L,361L,1444L,1600L,4096L,5776L,9025L,36100L,65536L,102400L,262144L,1478656L,1638400L,6553600L,23658496L,36966400L,94633984L,591462400L,1073741824L,2365849600L,26843545600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275674Inst : IEnumerable<long>
{
public static readonly long[] Value=A275674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275674.Bytes);
public long this[int i]=>Value[i];

public static A275674Inst Instance=new A275674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275675
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,1L,1L,2L,1L,2L,2L,1L,2L,1L,3L,2L,2L,3L,2L,4L,1L,1L,2L,2L,3L,3L,1L,1L,2L,2L,3L,3L,1L,3L,3L,2L,1L,2L,1L,5L,3L,2L,2L,3L,4L,1L,4L,2L,3L,5L,2L,2L,3L,1L,3L,3L,1L,4L,2L,4L,1L,2L,3L,2L,6L,2L,3L,3L,2L,2L,2L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275675Inst : IEnumerable<long>
{
public static readonly long[] Value=A275675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275675.Bytes);
public long this[int i]=>Value[i];

public static A275675Inst Instance=new A275675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275676
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,2L,1L,3L,2L,3L,4L,1L,1L,3L,1L,3L,4L,2L,3L,3L,3L,1L,2L,3L,2L,7L,2L,1L,4L,3L,4L,5L,3L,2L,4L,2L,4L,4L,1L,5L,8L,3L,2L,4L,1L,7L,3L,1L,2L,4L,5L,1L,5L,2L,4L,7L,3L,3L,5L,1L,3L,5L,1L,6L,6L,7L,2L,4L,5L,2L,9L,3L,4L,6L,3L,3L,2L,2L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275676Inst : IEnumerable<long>
{
public static readonly long[] Value=A275676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275676.Bytes);
public long this[int i]=>Value[i];

public static A275676Inst Instance=new A275676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275677
{
public static readonly long[] Value={ 0L,1L,2L,5L,3L,11L,4L,32L,6L,33L,7L,51L,8L,92L,9L,139L,10L,22L,12L,227L,13L,20L,14L,370L,15L,36L,16L,602L,17L,75L,18L,978L,19L,120L,21L,1586L,23L,2583L,24L,4169L,25L,202L,26L,6752L,27L,10939L,28L,29L,327L,30L,31L,34L,35L,539L,37L,38L,39L,40L,934L,41L,42L,56L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275677Inst : IEnumerable<long>
{
public static readonly long[] Value=A275677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275677.Bytes);
public long this[int i]=>Value[i];

public static A275677Inst Instance=new A275677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275678
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,3L,1L,2L,3L,4L,2L,1L,2L,3L,2L,1L,4L,4L,1L,3L,5L,3L,1L,3L,5L,5L,3L,1L,2L,7L,2L,2L,5L,3L,3L,3L,6L,2L,2L,4L,6L,7L,1L,2L,4L,7L,1L,1L,3L,5L,5L,2L,5L,5L,4L,3L,8L,4L,2L,2L,1L,7L,3L,1L,6L,8L,2L,4L,8L,6L,2L,4L,6L,3L,4L,1L,3L,6L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275678Inst : IEnumerable<long>
{
public static readonly long[] Value=A275678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275678.Bytes);
public long this[int i]=>Value[i];

public static A275678Inst Instance=new A275678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275679
{
public static readonly long[] Value={ 1L,1L,1L,4L,3L,20L,43L,136L,711L,1606L,12653L,36852L,250673L,1212498L,6016715L,45081688L,196537387L,1789229594L,8963510621L,76863454428L,512264745473L,3744799424978L,32870550965259L,219159966518160L,2257073412153459L,15778075163815474L,165231652982941085L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275679Inst : IEnumerable<long>
{
public static readonly long[] Value=A275679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275679.Bytes);
public long this[int i]=>Value[i];

public static A275679Inst Instance=new A275679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275680
{
public static readonly long[] Value={ 1L,9L,70L,10L,12L,72L,74L,30L,75L,14L,90L,76L,15L,16L,33L,18L,100L,91L,92L,93L,77L,34L,78L,700L,102L,104L,94L,105L,106L,35L,36L,702L,703L,95L,38L,39L,704L,300L,108L,705L,706L,96L,707L,98L,301L,99L,110L,302L,303L,710L,304L,111L,712L,112L,306L,115L,116L,308L,310L,900L,117L,118L,119L,312L,120L,121L,316L,318L,122L,319L,123L,124L,901L,125L,902L,904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275680Inst : IEnumerable<long>
{
public static readonly long[] Value=A275680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275680.Bytes);
public long this[int i]=>Value[i];

public static A275680Inst Instance=new A275680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275681
{
public static readonly long[] Value={ 7L,13L,19L,17L,23L,29L,31L,37L,43L,47L,53L,59L,67L,73L,79L,97L,103L,109L,101L,107L,113L,151L,157L,163L,167L,173L,179L,227L,233L,239L,257L,263L,269L,271L,277L,283L,347L,353L,359L,367L,373L,379L,557L,563L,569L,587L,593L,599L,607L,613L,619L,647L,653L,659L,727L,733L,739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275681Inst : IEnumerable<long>
{
public static readonly long[] Value=A275681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275681.Bytes);
public long this[int i]=>Value[i];

public static A275681Inst Instance=new A275681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275682
{
public static readonly long[] Value={ 11L,17L,23L,29L,41L,47L,53L,59L,61L,67L,73L,79L,251L,257L,263L,269L,601L,607L,613L,619L,641L,647L,653L,659L,1091L,1097L,1103L,1109L,1481L,1487L,1493L,1499L,1601L,1607L,1613L,1619L,1741L,1747L,1753L,1759L,1861L,1867L,1873L,1879L,2371L,2377L,2383L,2389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275682Inst : IEnumerable<long>
{
public static readonly long[] Value=A275682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275682.Bytes);
public long this[int i]=>Value[i];

public static A275682Inst Instance=new A275682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275683
{
public static readonly long[] Value={ 4L,2821L,1821127L,1598241813L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275683Inst : IEnumerable<long>
{
public static readonly long[] Value=A275683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275683.Bytes);
public long this[int i]=>Value[i];

public static A275683Inst Instance=new A275683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275684
{
public static readonly long[] Value={ 4L,25261L,349781731L,4114571944591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275684Inst : IEnumerable<long>
{
public static readonly long[] Value=A275684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275684.Bytes);
public long this[int i]=>Value[i];

public static A275684Inst Instance=new A275684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275685
{
public static readonly long[] Value={ 4L,408807L,3959234101L,3554007760224751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275685Inst : IEnumerable<long>
{
public static readonly long[] Value=A275685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275685.Bytes);
public long this[int i]=>Value[i];

public static A275685Inst Instance=new A275685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275686
{
public static readonly long[] Value={ 6L,427L,264607L,4975694077L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275686Inst : IEnumerable<long>
{
public static readonly long[] Value=A275686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275686.Bytes);
public long this[int i]=>Value[i];

public static A275686Inst Instance=new A275686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275687
{
public static readonly long[] Value={ 0L,9561L,70495851L,465621162291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275687Inst : IEnumerable<long>
{
public static readonly long[] Value=A275687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275687.Bytes);
public long this[int i]=>Value[i];

public static A275687Inst Instance=new A275687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275688
{
public static readonly long[] Value={ 1L,5L,8L,1L,4L,0L,2L,1L,6L,8L,0L,3L,1L,1L,2L,2L,9L,4L,5L,3L,4L,2L,9L,8L,7L,9L,8L,7L,4L,4L,0L,5L,8L,5L,4L,1L,9L,5L,1L,8L,5L,9L,8L,3L,8L,8L,9L,0L,3L,8L,0L,8L,4L,6L,0L,2L,9L,3L,0L,2L,4L,5L,2L,7L,5L,3L,4L,8L,1L,4L,7L,0L,1L,2L,4L,7L,7L,6L,2L,7L,9L,0L,9L,9L,6L,9L,6L,8L,2L,7L,8L,1L,1L,5L,3L,1L,0L,5L,0L,4L,9L,6L,0L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275688Inst : IEnumerable<long>
{
public static readonly long[] Value=A275688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275688.Bytes);
public long this[int i]=>Value[i];

public static A275688Inst Instance=new A275688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275689
{
public static readonly long[] Value={ 1L,3L,0L,0L,6L,5L,1L,1L,4L,9L,7L,9L,1L,0L,1L,8L,7L,0L,3L,3L,2L,3L,8L,6L,3L,9L,5L,8L,2L,6L,0L,3L,5L,6L,5L,3L,9L,9L,7L,5L,3L,8L,2L,3L,7L,3L,3L,8L,0L,6L,1L,9L,1L,3L,6L,3L,5L,1L,2L,2L,6L,2L,5L,3L,2L,4L,8L,9L,8L,9L,5L,2L,5L,4L,3L,9L,4L,6L,2L,0L,7L,7L,6L,4L,7L,2L,9L,1L,6L,8L,3L,6L,3L,4L,6L,9L,3L,6L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275689Inst : IEnumerable<long>
{
public static readonly long[] Value=A275689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275689.Bytes);
public long this[int i]=>Value[i];

public static A275689Inst Instance=new A275689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275690
{
public static readonly long[] Value={ 1L,1L,3L,9L,30L,99L,334L,1116L,3744L,12504L,41724L,138840L,461187L,1528554L,5057028L,16699293L,55051065L,181184337L,595400772L,1953715239L,6401926227L,20950064478L,68472011889L,223521012585L,728827015536L,2373846887673L,7723658267667L,25104640758607L,81519763177575L,264463605423009L,857192148657477L,2775964660002954L,8982278557410627L,29040795844301862L,93819208534071840L,302863860771034455L,976981070712962919L,3149327670664845204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275690Inst : IEnumerable<long>
{
public static readonly long[] Value=A275690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275690.Bytes);
public long this[int i]=>Value[i];

public static A275690Inst Instance=new A275690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275691
{
public static readonly long[] Value={ 1L,0L,1L,2L,4L,8L,17L,36L,78L,168L,364L,786L,1700L,3668L,7916L,17056L,36729L,78996L,169772L,364472L,781814L,1675464L,3587660L,7675722L,16409240L,35052552L,74822496L,159599700L,340199178L,724675528L,1542673868L,3281957116L,6977971852L,14827596904L,31489490296L,66837617960L,141789447876L,300636048724L,637116434912L,1349532001896L,2857195771769L,6046370298448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275691Inst : IEnumerable<long>
{
public static readonly long[] Value=A275691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275691.Bytes);
public long this[int i]=>Value[i];

public static A275691Inst Instance=new A275691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275692
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,8L,12L,14L,16L,20L,24L,26L,28L,30L,32L,40L,48L,50L,52L,56L,58L,60L,62L,64L,72L,80L,84L,96L,98L,100L,104L,106L,108L,112L,114L,116L,118L,120L,122L,124L,126L,128L,144L,160L,164L,168L,192L,194L,196L,200L,202L,208L,210L,212L,216L,218L,224L,226L,228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275692Inst : IEnumerable<long>
{
public static readonly long[] Value=A275692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275692.Bytes);
public long this[int i]=>Value[i];

public static A275692Inst Instance=new A275692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275693
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,30L,210L,211L,212L,213L,214L,215L,216L,217L,218L,219L,220L,221L,222L,223L,224L,225L,226L,227L,228L,229L,230L,231L,232L,2310L,2311L,2312L,2313L,2314L,2315L,2316L,2317L,2318L,2319L,2320L,2321L,2322L,2323L,2324L,2325L,2326L,2327L,2328L,2329L,2330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275693Inst : IEnumerable<long>
{
public static readonly long[] Value=A275693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275693.Bytes);
public long this[int i]=>Value[i];

public static A275693Inst Instance=new A275693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275694
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275694Inst : IEnumerable<long>
{
public static readonly long[] Value=A275694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275694.Bytes);
public long this[int i]=>Value[i];

public static A275694Inst Instance=new A275694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275695
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,1L,1L,9L,33L,385L,13825L,5474305L,75873853441L,415386585427968001L,BigInteger.Parse("3501887406773528570406162401"),BigInteger.Parse("44079910680970588907541344275243042224979209"),BigInteger.Parse("400942556117903539711475671972145122347091674105174721165559627509313") };
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
public class A275695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275695Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275695.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275695.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275695Inst Instance=new A275695Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275696
{
public static readonly long[] Value={ 3L,6L,7L,1L,6L,8L,6L,7L,0L,7L,4L,3L,0L,0L,6L,4L,5L,0L,0L,7L,8L,0L,6L,1L,4L,1L,4L,9L,9L,0L,9L,9L,7L,8L,2L,7L,4L,6L,6L,1L,5L,9L,3L,1L,8L,3L,5L,4L,8L,9L,6L,8L,2L,7L,0L,3L,4L,6L,8L,0L,0L,1L,1L,9L,7L,0L,5L,2L,1L,6L,5L,6L,6L,8L,9L,8L,3L,4L,8L,0L,0L,3L,6L,1L,5L,7L,3L,6L,6L,2L,5L,0L,1L,4L,5L,1L,1L,6L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275696Inst : IEnumerable<long>
{
public static readonly long[] Value=A275696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275696.Bytes);
public long this[int i]=>Value[i];

public static A275696Inst Instance=new A275696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275697
{
public static readonly long[] Value={ 2L,3L,5L,11L,13L,17L,29L,31L,37L,41L,59L,61L,71L,73L,89L,97L,101L,107L,109L,113L,137L,149L,151L,157L,179L,181L,191L,193L,197L,227L,229L,239L,241L,269L,271L,277L,281L,311L,313L,331L,347L,349L,367L,373L,397L,401L,419L,421L,431L,433L,449L,457L,461L,521L,523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275697Inst : IEnumerable<long>
{
public static readonly long[] Value=A275697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275697.Bytes);
public long this[int i]=>Value[i];

public static A275697Inst Instance=new A275697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275698
{
public static readonly BigInteger[] Value={ 2L,5L,13L,133L,17293L,298995973L,89398590973228813L,BigInteger.Parse("7992108067998667938125889533702533"),BigInteger.Parse("63873791370569400659097694858350356285036046451665934814399129508493") };
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
public class A275698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275698Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275698.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275698.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275698Inst Instance=new A275698Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275699
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,1L,1L,2L,1L,2L,1L,4L,2L,2L,1L,1L,3L,1L,1L,1L,2L,2L,1L,1L,5L,1L,3L,1L,1L,3L,3L,1L,2L,1L,1L,4L,1L,1L,2L,2L,3L,3L,1L,1L,2L,1L,1L,2L,1L,6L,1L,2L,2L,1L,4L,1L,1L,1L,2L,1L,1L,4L,3L,1L,2L,1L,1L,1L,1L,3L,2L,2L,1L,2L,5L,2L,1L,3L,1L,1L,3L,1L,4L,1L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275699Inst : IEnumerable<long>
{
public static readonly long[] Value=A275699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275699.Bytes);
public long this[int i]=>Value[i];

public static A275699Inst Instance=new A275699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275700
{
public static readonly long[] Value={ 2L,6L,10L,42L,22L,390L,34L,798L,230L,1914L,62L,101010L,82L,4386L,5170L,42294L,118L,547170L,134L,951258L,12410L,14694L,166L,170807910L,2134L,24846L,23690L,3285114L,218L,660741510L,254L,5540514L,42470L,49206L,55726L,21399271530L,314L,65526L,68470L,3126785046L,358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275700Inst : IEnumerable<long>
{
public static readonly long[] Value=A275700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275700.Bytes);
public long this[int i]=>Value[i];

public static A275700Inst Instance=new A275700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275701
{
public static readonly long[] Value={ 80L,1184L,6464L,29312L,78975L,510464L,557192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275701Inst : IEnumerable<long>
{
public static readonly long[] Value=A275701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275701.Bytes);
public long this[int i]=>Value[i];

public static A275701Inst Instance=new A275701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275702
{
public static readonly long[] Value={ 58L,75L,328L,850L,1210L,2848L,35968L,537088L,549768921088L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275702Inst : IEnumerable<long>
{
public static readonly long[] Value=A275702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275702.Bytes);
public long this[int i]=>Value[i];

public static A275702Inst Instance=new A275702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275703
{
public static readonly long[] Value={ 9L,8L,5L,5L,5L,1L,0L,9L,1L,2L,9L,7L,4L,3L,5L,1L,0L,4L,0L,9L,8L,4L,3L,9L,2L,4L,4L,4L,8L,4L,9L,5L,4L,2L,6L,1L,4L,0L,4L,8L,8L,5L,6L,9L,3L,4L,6L,9L,3L,2L,6L,8L,8L,8L,0L,3L,4L,8L,3L,3L,3L,9L,3L,2L,5L,4L,1L,9L,6L,8L,0L,2L,1L,8L,6L,2L,7L,1L,7L,1L,3L,5L,7L,3L,9L,3L,7L,2L,9L,1L,1L,2L,7L,9L,5L,5L,9L,4L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275703Inst : IEnumerable<long>
{
public static readonly long[] Value=A275703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275703.Bytes);
public long this[int i]=>Value[i];

public static A275703Inst Instance=new A275703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275704
{
public static readonly long[] Value={ 1L,5L,2L,1L,2L,5L,1L,8L,8L,1L,5L,2L,1L,2L,5L,1L,8L,8L,1L,5L,2L,1L,2L,5L,1L,8L,8L,1L,5L,2L,1L,2L,5L,1L,8L,8L,1L,5L,2L,1L,2L,5L,1L,8L,8L,1L,5L,2L,1L,2L,5L,1L,8L,8L,1L,5L,2L,1L,2L,5L,1L,8L,8L,1L,5L,2L,1L,2L,5L,1L,8L,8L,1L,5L,2L,1L,2L,5L,1L,8L,8L,1L,5L,2L,1L,2L,5L,1L,8L,8L,1L,5L,2L,1L,2L,5L,1L,8L,8L,1L,5L,2L,1L,2L,5L,1L,8L,8L,1L,5L,2L,1L,2L,5L,1L,8L,8L,1L,5L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275704Inst : IEnumerable<long>
{
public static readonly long[] Value=A275704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275704.Bytes);
public long this[int i]=>Value[i];

public static A275704Inst Instance=new A275704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275705
{
public static readonly long[] Value={ 1L,-2L,-1L,-3L,-5L,-6L,-4L,-7L,-12L,-18L,-9L,-13L,-20L,-32L,-50L,11L,2L,-11L,-31L,-63L,-113L,3L,14L,16L,5L,-26L,-89L,-202L,6L,9L,23L,39L,44L,18L,-71L,-273L,4L,10L,19L,42L,81L,125L,143L,72L,-201L,8L,12L,22L,41L,83L,164L,289L,432L,504L,303L,7L,15L,27L,49L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275705Inst : IEnumerable<long>
{
public static readonly long[] Value=A275705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275705.Bytes);
public long this[int i]=>Value[i];

public static A275705Inst Instance=new A275705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275706
{
public static readonly BigInteger[] Value={ 1L,1L,2L,1L,-40L,135L,-860L,20145L,-137100L,-6726225L,-212460900L,-3642898575L,654642826500L,-26505894416625L,3335048243533500L,-1368325090374591375L,BigInteger.Parse("133951676745003682500"),BigInteger.Parse("123266968248328746879375"),BigInteger.Parse("63057521158814641016317500"),BigInteger.Parse("17732380504905960076345280625") };
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
public class A275706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275706Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275706.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275706.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275706Inst Instance=new A275706Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275707
{
public static readonly BigInteger[] Value={ 1L,2L,8L,38L,216L,1402L,10156L,80838L,698704L,6498674L,64579284L,681642238L,7605025720L,89318058858L,1100376445564L,14176837311158L,190498308591264L,2663482511782114L,38667106019619748L,581765160424218606L,9055862445043643656L,BigInteger.Parse("145619330650420134362") };
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
public class A275707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275707Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275707.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275707.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275707Inst Instance=new A275707Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275708
{
public static readonly long[] Value={ 1L,2L,3L,8L,4L,5L,15L,6L,10L,12L,7L,9L,14L,11L,19L,17L,18L,24L,30L,43L,23L,21L,27L,58L,33L,26L,16L,35L,45L,39L,22L,42L,29L,38L,40L,34L,31L,28L,52L,25L,36L,53L,32L,37L,20L,66L,54L,13L,50L,44L,55L,70L,49L,46L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275708Inst : IEnumerable<long>
{
public static readonly long[] Value=A275708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275708.Bytes);
public long this[int i]=>Value[i];

public static A275708Inst Instance=new A275708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275709
{
public static readonly long[] Value={ 0L,5L,28L,81L,176L,325L,540L,833L,1216L,1701L,2300L,3025L,3888L,4901L,6076L,7425L,8960L,10693L,12636L,14801L,17200L,19845L,22748L,25921L,29376L,33125L,37180L,41553L,46256L,51301L,56700L,62465L,68608L,75141L,82076L,89425L,97200L,105413L,114076L,123201L,132800L,142885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275709Inst : IEnumerable<long>
{
public static readonly long[] Value=A275709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275709.Bytes);
public long this[int i]=>Value[i];

public static A275709Inst Instance=new A275709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275710
{
public static readonly long[] Value={ 9L,9L,2L,5L,9L,3L,8L,1L,9L,9L,2L,2L,8L,3L,0L,2L,8L,2L,6L,7L,0L,4L,2L,5L,7L,1L,3L,1L,3L,3L,3L,9L,3L,6L,8L,5L,2L,3L,1L,1L,1L,5L,6L,9L,2L,4L,3L,1L,4L,0L,6L,8L,5L,1L,6L,2L,9L,5L,1L,3L,0L,8L,7L,5L,6L,2L,6L,7L,0L,2L,0L,5L,2L,1L,8L,6L,4L,7L,0L,5L,1L,9L,8L,1L,3L,1L,4L,2L,0L,3L,7L,7L,4L,5L,7L,2L,3L,9L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275710Inst : IEnumerable<long>
{
public static readonly long[] Value=A275710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275710.Bytes);
public long this[int i]=>Value[i];

public static A275710Inst Instance=new A275710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275711
{
public static readonly ulong[] Value={ 1L,1L,1L,2L,5L,16L,61L,272L,1385L,7936L,50521L,353791L,2702767L,22368251L,199360995L,1903757268L,19391512295L,209865342434L,2404879677510L,29088885104489L,370371188272931L,4951498052966308L,69348874393874527L,1015423886503257017L,15514534163575397655UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275711Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A275711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275711.Bytes);
public ulong this[int i]=>Value[i];

public static A275711Inst Instance=new A275711Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275712
{
public static readonly long[] Value={ 8L,4L,8L,1L,3L,2L,2L,1L,1L,8L,7L,6L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275712Inst : IEnumerable<long>
{
public static readonly long[] Value=A275712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275712.Bytes);
public long this[int i]=>Value[i];

public static A275712Inst Instance=new A275712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275713
{
public static readonly long[] Value={ 4L,32L,40L,64L,96L,96L,96L,160L,160L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275713Inst : IEnumerable<long>
{
public static readonly long[] Value=A275713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275713.Bytes);
public long this[int i]=>Value[i];

public static A275713Inst Instance=new A275713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275714
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,4L,0L,1L,0L,1L,7L,3L,1L,0L,1L,0L,9L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,35L,43L,0L,0L,1L,0L,1L,62L,102L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,595L,0L,68L,0L,1L,0L,1L,361L,1480L,871L,187L,17L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275714Inst : IEnumerable<long>
{
public static readonly long[] Value=A275714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275714.Bytes);
public long this[int i]=>Value[i];

public static A275714Inst Instance=new A275714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275715
{
public static readonly long[] Value={ 0L,1L,3L,7L,15L,31L,63L,127L,2L,255L,511L,6L,1023L,2047L,4095L,8191L,5L,16383L,14L,32767L,65535L,30L,131071L,262143L,524287L,13L,1048575L,2097151L,62L,4194303L,29L,126L,8388607L,16777215L,33554431L,67108863L,134217727L,268435455L,254L,61L,11L,4L,536870911L,1073741823L,125L,2147483647L,4294967295L,27L,510L,8589934591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275715Inst : IEnumerable<long>
{
public static readonly long[] Value=A275715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275715.Bytes);
public long this[int i]=>Value[i];

public static A275715Inst Instance=new A275715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275716
{
public static readonly long[] Value={ 1L,2L,9L,3L,42L,17L,12L,4L,209L,115L,82L,41L,59L,26L,19L,5L,1042L,801L,572L,444L,409L,283L,202L,57L,292L,180L,129L,48L,92L,31L,22L,6L,5209L,5603L,4002L,4881L,2859L,3106L,2219L,733L,2042L,1977L,1412L,620L,1009L,395L,282L,97L,1459L,1258L,899L,525L,642L,334L,239L,74L,459L,213L,152L,63L,109L,40L,29L,7L,26042L,39217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275716Inst : IEnumerable<long>
{
public static readonly long[] Value=A275716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275716.Bytes);
public long this[int i]=>Value[i];

public static A275716Inst Instance=new A275716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275717
{
public static readonly long[] Value={ 2L,3L,4L,6L,8L,12L,14L,15L,16L,18L,20L,24L,26L,27L,30L,32L,35L,36L,38L,39L,40L,42L,44L,45L,48L,50L,52L,54L,56L,60L,62L,63L,64L,66L,68L,70L,72L,74L,75L,78L,80L,81L,84L,86L,87L,88L,90L,92L,95L,96L,98L,100L,102L,104L,108L,110L,112L,114L,116L,117L,119L,120L,122L,123L,124L,125L,126L,128L,130L,132L,135L,138L,140L,143L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275717Inst : IEnumerable<long>
{
public static readonly long[] Value=A275717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275717.Bytes);
public long this[int i]=>Value[i];

public static A275717Inst Instance=new A275717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275718
{
public static readonly long[] Value={ 5L,7L,9L,10L,11L,13L,17L,19L,21L,22L,23L,25L,28L,29L,31L,33L,34L,37L,41L,43L,46L,47L,49L,51L,53L,55L,57L,58L,59L,61L,65L,67L,69L,71L,73L,76L,77L,79L,82L,83L,85L,89L,91L,93L,94L,97L,99L,101L,103L,105L,106L,107L,109L,111L,113L,115L,118L,121L,127L,129L,131L,133L,134L,136L,137L,139L,141L,142L,145L,148L,149L,151L,153L,154L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275718Inst : IEnumerable<long>
{
public static readonly long[] Value=A275718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275718.Bytes);
public long this[int i]=>Value[i];

public static A275718Inst Instance=new A275718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275719
{
public static readonly long[] Value={ 3L,4L,5L,4L,3L,1L,3L,4L,5L,4L,3L,1L,2L,2L,1L,1L,-1L,1L,3L,4L,6L,5L,5L,6L,5L,5L,5L,4L,3L,1L,3L,4L,5L,5L,5L,6L,5L,5L,7L,5L,5L,8L,7L,7L,7L,9L,9L,9L,8L,9L,8L,7L,7L,7L,5L,5L,6L,7L,11L,12L,12L,13L,12L,13L,13L,14L,15L,14L,15L,16L,14L,13L,13L,11L,11L,11L,14L,13L,14L,11L,11L,13L,13L,15L,14L,14L,13L,13L,14L,13L,15L,15L,13L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275719Inst : IEnumerable<long>
{
public static readonly long[] Value=A275719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275719.Bytes);
public long this[int i]=>Value[i];

public static A275719Inst Instance=new A275719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275720
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,3L,2L,3L,2L,1L,0L,1L,0L,1L,2L,3L,2L,3L,2L,3L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,2L,3L,2L,3L,2L,3L,4L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,1L,0L,1L,0L,1L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,4L,3L,2L,3L,2L,3L,4L,3L,2L,3L,2L,3L,4L,5L,4L,5L,4L,5L,4L,3L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,4L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275720Inst : IEnumerable<long>
{
public static readonly long[] Value=A275720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275720.Bytes);
public long this[int i]=>Value[i];

public static A275720Inst Instance=new A275720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275721
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,13L,14L,15L,17L,19L,23L,25L,26L,29L,31L,34L,35L,37L,38L,39L,41L,43L,44L,47L,49L,51L,53L,55L,59L,61L,62L,63L,65L,67L,69L,71L,73L,74L,77L,79L,80L,83L,85L,86L,87L,89L,91L,94L,95L,97L,99L,101L,103L,107L,109L,111L,113L,115L,116L,118L,119L,121L,122L,123L,124L,125L,127L,129L,131L,134L,137L,139L,142L,143L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275721Inst : IEnumerable<long>
{
public static readonly long[] Value=A275721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275721.Bytes);
public long this[int i]=>Value[i];

public static A275721Inst Instance=new A275721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275722
{
public static readonly long[] Value={ 4L,6L,8L,9L,10L,12L,16L,18L,20L,21L,22L,24L,27L,28L,30L,32L,33L,36L,40L,42L,45L,46L,48L,50L,52L,54L,56L,57L,58L,60L,64L,66L,68L,70L,72L,75L,76L,78L,81L,82L,84L,88L,90L,92L,93L,96L,98L,100L,102L,104L,105L,106L,108L,110L,112L,114L,117L,120L,126L,128L,130L,132L,133L,135L,136L,138L,140L,141L,144L,147L,148L,150L,152L,153L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275722Inst : IEnumerable<long>
{
public static readonly long[] Value=A275722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275722.Bytes);
public long this[int i]=>Value[i];

public static A275722Inst Instance=new A275722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275723
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,2L,4L,1L,2L,3L,4L,5L,1L,2L,2L,4L,5L,6L,1L,2L,3L,4L,3L,4L,7L,1L,2L,2L,4L,2L,6L,7L,8L,1L,2L,3L,4L,2L,4L,7L,8L,9L,1L,2L,2L,4L,2L,6L,7L,8L,4L,10L,1L,2L,3L,4L,5L,4L,7L,8L,9L,10L,11L,1L,2L,2L,4L,5L,6L,7L,8L,4L,6L,11L,12L,1L,2L,3L,4L,3L,4L,5L,8L,9L,4L,11L,8L,13L,1L,2L,2L,4L,2L,6L,5L,8L,4L,4L,11L,12L,13L,14L,1L,2L,3L,4L,2L,4L,3L,8L,9L,4L,11L,8L,13L,14L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275723Inst : IEnumerable<long>
{
public static readonly long[] Value=A275723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275723.Bytes);
public long this[int i]=>Value[i];

public static A275723Inst Instance=new A275723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275724
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,4L,2L,2L,1L,5L,4L,3L,2L,1L,6L,5L,4L,2L,2L,1L,7L,4L,3L,4L,3L,2L,1L,8L,7L,6L,2L,4L,2L,2L,1L,9L,8L,7L,4L,2L,4L,3L,2L,1L,10L,4L,8L,7L,6L,2L,4L,2L,2L,1L,11L,10L,9L,8L,7L,4L,5L,4L,3L,2L,1L,12L,11L,6L,4L,8L,7L,6L,5L,4L,2L,2L,1L,13L,8L,11L,4L,9L,8L,5L,4L,3L,4L,3L,2L,1L,14L,13L,12L,11L,4L,4L,8L,5L,6L,2L,4L,2L,2L,1L,15L,14L,13L,8L,11L,4L,9L,8L,3L,4L,2L,4L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275724Inst : IEnumerable<long>
{
public static readonly long[] Value=A275724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275724.Bytes);
public long this[int i]=>Value[i];

public static A275724Inst Instance=new A275724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275725
{
public static readonly long[] Value={ 2L,4L,18L,8L,12L,8L,150L,100L,54L,16L,24L,16L,90L,40L,54L,16L,36L,16L,60L,40L,36L,16L,24L,16L,1470L,980L,882L,392L,588L,392L,750L,500L,162L,32L,48L,32L,270L,80L,162L,32L,108L,32L,120L,80L,72L,32L,48L,32L,1050L,700L,378L,112L,168L,112L,750L,500L,162L,32L,48L,32L,450L,200L,162L,32L,72L,32L,300L,200L,108L,32L,48L,32L,630L,280L,378L,112L,252L,112L,450L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275725Inst : IEnumerable<long>
{
public static readonly long[] Value=A275725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275725.Bytes);
public long this[int i]=>Value[i];

public static A275725Inst Instance=new A275725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275726
{
public static readonly long[] Value={ 1L,2L,5L,3L,4L,3L,11L,10L,7L,4L,5L,4L,9L,7L,7L,4L,6L,4L,8L,7L,6L,4L,5L,4L,23L,22L,21L,19L,20L,19L,15L,14L,9L,5L,6L,5L,11L,8L,9L,5L,8L,5L,9L,8L,7L,5L,6L,5L,19L,18L,15L,12L,13L,12L,15L,14L,9L,5L,6L,5L,13L,11L,9L,5L,7L,5L,12L,11L,8L,5L,6L,5L,17L,15L,15L,12L,14L,12L,13L,11L,9L,5L,7L,5L,11L,8L,9L,5L,8L,5L,10L,8L,8L,5L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275726Inst : IEnumerable<long>
{
public static readonly long[] Value=A275726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275726.Bytes);
public long this[int i]=>Value[i];

public static A275726Inst Instance=new A275726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275727
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,3L,4L,5L,6L,7L,6L,7L,4L,5L,6L,7L,6L,7L,4L,5L,6L,7L,6L,7L,8L,9L,10L,11L,10L,11L,12L,13L,14L,15L,14L,15L,12L,13L,14L,15L,14L,15L,12L,13L,14L,15L,14L,15L,8L,9L,10L,11L,10L,11L,12L,13L,14L,15L,14L,15L,12L,13L,14L,15L,14L,15L,12L,13L,14L,15L,14L,15L,8L,9L,10L,11L,10L,11L,12L,13L,14L,15L,14L,15L,12L,13L,14L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275727Inst : IEnumerable<long>
{
public static readonly long[] Value=A275727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275727.Bytes);
public long this[int i]=>Value[i];

public static A275727Inst Instance=new A275727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275728
{
public static readonly long[] Value={ 0L,1L,2L,3L,1L,2L,4L,5L,6L,7L,5L,6L,2L,3L,4L,5L,3L,4L,1L,2L,3L,4L,2L,3L,8L,9L,10L,11L,9L,10L,12L,13L,14L,15L,13L,14L,10L,11L,12L,13L,11L,12L,9L,10L,11L,12L,10L,11L,4L,5L,6L,7L,5L,6L,8L,9L,10L,11L,9L,10L,6L,7L,8L,9L,7L,8L,5L,6L,7L,8L,6L,7L,2L,3L,4L,5L,3L,4L,6L,7L,8L,9L,7L,8L,4L,5L,6L,7L,5L,6L,3L,4L,5L,6L,4L,5L,1L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275728Inst : IEnumerable<long>
{
public static readonly long[] Value=A275728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275728.Bytes);
public long this[int i]=>Value[i];

public static A275728Inst Instance=new A275728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275729
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,1L,2L,2L,3L,3L,4L,2L,3L,3L,4L,4L,5L,4L,5L,5L,6L,6L,7L,1L,2L,2L,3L,3L,4L,2L,3L,3L,4L,4L,5L,3L,4L,4L,5L,5L,6L,5L,6L,6L,7L,7L,8L,2L,3L,3L,4L,4L,5L,3L,4L,4L,5L,5L,6L,4L,5L,5L,6L,6L,7L,6L,7L,7L,8L,8L,9L,4L,5L,5L,6L,6L,7L,5L,6L,6L,7L,7L,8L,6L,7L,7L,8L,8L,9L,8L,9L,9L,10L,10L,11L,8L,9L,9L,10L,10L,11L,9L,10L,10L,11L,11L,12L,10L,11L,11L,12L,12L,13L,12L,13L,13L,14L,14L,15L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275729Inst : IEnumerable<long>
{
public static readonly long[] Value=A275729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275729.Bytes);
public long this[int i]=>Value[i];

public static A275729Inst Instance=new A275729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275730
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,0L,1L,0L,2L,0L,1L,2L,1L,4L,0L,1L,2L,3L,0L,4L,0L,1L,2L,3L,4L,1L,6L,0L,1L,2L,3L,4L,5L,6L,6L,0L,1L,2L,3L,4L,5L,0L,7L,8L,0L,1L,2L,3L,4L,5L,6L,1L,6L,8L,0L,1L,2L,3L,4L,5L,6L,7L,2L,7L,10L,0L,1L,2L,3L,4L,5L,6L,7L,8L,3L,6L,10L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,4L,7L,12L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,5L,12L,12L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,0L,13L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275730Inst : IEnumerable<long>
{
public static readonly long[] Value=A275730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275730.Bytes);
public long this[int i]=>Value[i];

public static A275730Inst Instance=new A275730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275731
{
public static readonly long[] Value={ 0L,0L,0L,2L,1L,0L,2L,0L,1L,0L,4L,1L,2L,1L,0L,4L,0L,3L,2L,1L,0L,6L,1L,4L,3L,2L,1L,0L,6L,6L,5L,4L,3L,2L,1L,0L,8L,7L,0L,5L,4L,3L,2L,1L,0L,8L,6L,1L,6L,5L,4L,3L,2L,1L,0L,10L,7L,2L,7L,6L,5L,4L,3L,2L,1L,0L,10L,6L,3L,8L,7L,6L,5L,4L,3L,2L,1L,0L,12L,7L,4L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,12L,12L,5L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,14L,13L,0L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275731Inst : IEnumerable<long>
{
public static readonly long[] Value=A275731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275731.Bytes);
public long this[int i]=>Value[i];

public static A275731Inst Instance=new A275731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275732
{
public static readonly long[] Value={ 1L,2L,3L,6L,1L,2L,5L,10L,15L,30L,5L,10L,1L,2L,3L,6L,1L,2L,1L,2L,3L,6L,1L,2L,7L,14L,21L,42L,7L,14L,35L,70L,105L,210L,35L,70L,7L,14L,21L,42L,7L,14L,7L,14L,21L,42L,7L,14L,1L,2L,3L,6L,1L,2L,5L,10L,15L,30L,5L,10L,1L,2L,3L,6L,1L,2L,1L,2L,3L,6L,1L,2L,1L,2L,3L,6L,1L,2L,5L,10L,15L,30L,5L,10L,1L,2L,3L,6L,1L,2L,1L,2L,3L,6L,1L,2L,1L,2L,3L,6L,1L,2L,5L,10L,15L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275732Inst : IEnumerable<long>
{
public static readonly long[] Value=A275732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275732.Bytes);
public long this[int i]=>Value[i];

public static A275732Inst Instance=new A275732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275733
{
public static readonly long[] Value={ 1L,2L,3L,6L,3L,6L,5L,10L,15L,30L,15L,30L,5L,10L,15L,30L,15L,30L,5L,10L,15L,30L,15L,30L,7L,14L,21L,42L,21L,42L,35L,70L,105L,210L,105L,210L,35L,70L,105L,210L,105L,210L,35L,70L,105L,210L,105L,210L,7L,14L,21L,42L,21L,42L,35L,70L,105L,210L,105L,210L,35L,70L,105L,210L,105L,210L,35L,70L,105L,210L,105L,210L,7L,14L,21L,42L,21L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275733Inst : IEnumerable<long>
{
public static readonly long[] Value=A275733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275733.Bytes);
public long this[int i]=>Value[i];

public static A275733Inst Instance=new A275733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275734
{
public static readonly long[] Value={ 1L,2L,3L,6L,2L,4L,5L,10L,15L,30L,10L,20L,3L,6L,9L,18L,6L,12L,2L,4L,6L,12L,4L,8L,7L,14L,21L,42L,14L,28L,35L,70L,105L,210L,70L,140L,21L,42L,63L,126L,42L,84L,14L,28L,42L,84L,28L,56L,5L,10L,15L,30L,10L,20L,25L,50L,75L,150L,50L,100L,15L,30L,45L,90L,30L,60L,10L,20L,30L,60L,20L,40L,3L,6L,9L,18L,6L,12L,15L,30L,45L,90L,30L,60L,9L,18L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275734Inst : IEnumerable<long>
{
public static readonly long[] Value=A275734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275734.Bytes);
public long this[int i]=>Value[i];

public static A275734Inst Instance=new A275734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275735
{
public static readonly long[] Value={ 1L,2L,2L,4L,3L,6L,2L,4L,4L,8L,6L,12L,3L,6L,6L,12L,9L,18L,5L,10L,10L,20L,15L,30L,2L,4L,4L,8L,6L,12L,4L,8L,8L,16L,12L,24L,6L,12L,12L,24L,18L,36L,10L,20L,20L,40L,30L,60L,3L,6L,6L,12L,9L,18L,6L,12L,12L,24L,18L,36L,9L,18L,18L,36L,27L,54L,15L,30L,30L,60L,45L,90L,5L,10L,10L,20L,15L,30L,10L,20L,20L,40L,30L,60L,15L,30L,30L,60L,45L,90L,25L,50L,50L,100L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275735Inst : IEnumerable<long>
{
public static readonly long[] Value=A275735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275735.Bytes);
public long this[int i]=>Value[i];

public static A275735Inst Instance=new A275735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275736
{
public static readonly long[] Value={ 0L,1L,2L,3L,0L,1L,4L,5L,6L,7L,4L,5L,0L,1L,2L,3L,0L,1L,0L,1L,2L,3L,0L,1L,8L,9L,10L,11L,8L,9L,12L,13L,14L,15L,12L,13L,8L,9L,10L,11L,8L,9L,8L,9L,10L,11L,8L,9L,0L,1L,2L,3L,0L,1L,4L,5L,6L,7L,4L,5L,0L,1L,2L,3L,0L,1L,0L,1L,2L,3L,0L,1L,0L,1L,2L,3L,0L,1L,4L,5L,6L,7L,4L,5L,0L,1L,2L,3L,0L,1L,0L,1L,2L,3L,0L,1L,0L,1L,2L,3L,0L,1L,4L,5L,6L,7L,4L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275736Inst : IEnumerable<long>
{
public static readonly long[] Value=A275736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275736.Bytes);
public long this[int i]=>Value[i];

public static A275736Inst Instance=new A275736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275737
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275737Inst : IEnumerable<long>
{
public static readonly long[] Value=A275737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275737.Bytes);
public long this[int i]=>Value[i];

public static A275737Inst Instance=new A275737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275738
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,1L,1L,3L,3L,1L,3L,4L,1L,1L,2L,3L,3L,2L,5L,5L,1L,1L,1L,5L,3L,3L,5L,3L,2L,2L,1L,2L,4L,2L,7L,7L,1L,2L,3L,5L,3L,2L,3L,8L,3L,1L,3L,4L,4L,3L,9L,6L,3L,3L,1L,4L,4L,1L,6L,5L,2L,3L,2L,5L,3L,3L,5L,8L,3L,1L,3L,7L,4L,4L,8L,4L,2L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275738Inst : IEnumerable<long>
{
public static readonly long[] Value=A275738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275738.Bytes);
public long this[int i]=>Value[i];

public static A275738Inst Instance=new A275738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275739
{
public static readonly long[] Value={ 617L,1723L,2731L,3191L,6547L,11087L,13103L,21683L,21839L,47737L,49727L,49739L,51679L,52361L,60679L,63719L,117721L,133169L,145531L,232681L,275183L,281353L,306431L,341879L,373463L,607319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275739Inst : IEnumerable<long>
{
public static readonly long[] Value=A275739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275739.Bytes);
public long this[int i]=>Value[i];

public static A275739Inst Instance=new A275739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275740
{
public static readonly long[] Value={ 0L,2L,8L,21L,46L,83L,136L,210L,306L,426L,575L,758L,972L,1223L,1519L,1855L,2236L,2669L,3156L,3694L,4290L,4956L,5678L,6467L,7332L,8269L,9278L,10368L,11548L,12804L,14148L,15593L,17126L,18753L,20485L,22325L,24262L,26308L,28481L,30756L,33148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275740Inst : IEnumerable<long>
{
public static readonly long[] Value=A275740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275740.Bytes);
public long this[int i]=>Value[i];

public static A275740Inst Instance=new A275740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275741
{
public static readonly long[] Value={ 1L,3L,10L,6L,6L,17L,15L,11L,25L,38L,9L,37L,47L,39L,86L,58L,107L,50L,101L,36L,98L,45L,123L,92L,170L,57L,80L,72L,158L,194L,194L,67L,78L,133L,120L,302L,144L,158L,128L,97L,91L,303L,76L,191L,139L,178L,302L,117L,242L,179L,335L,390L,362L,197L,290L,314L,327L,227L,429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275741Inst : IEnumerable<long>
{
public static readonly long[] Value=A275741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275741.Bytes);
public long this[int i]=>Value[i];

public static A275741Inst Instance=new A275741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275742
{
public static readonly long[] Value={ 3L,4L,4L,7L,15L,15L,15L,15L,23L,31L,31L,47L,31L,39L,39L,63L,63L,63L,55L,79L,63L,79L,71L,95L,95L,95L,119L,119L,95L,111L,135L,143L,143L,143L,127L,159L,143L,167L,167L,191L,159L,191L,175L,191L,191L,207L,191L,215L,247L,223L,239L,255L,255L,239L,239L,247L,255L,255L,271L,287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275742Inst : IEnumerable<long>
{
public static readonly long[] Value=A275742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275742.Bytes);
public long this[int i]=>Value[i];

public static A275742Inst Instance=new A275742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275743
{
public static readonly long[] Value={ 1L,12L,83L,600L,3058L,18222L,130411L,783480L,3418488L,24857930L,181308931L,610675758L,6529545751L,18840405540L,102444103996L,95639401274L,3188347929974L,27288773879397L,96923972375603L,702926766993950L,2980668206142664L,20046633698159181L,88137290213079355L,502113072640777785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275743Inst : IEnumerable<long>
{
public static readonly long[] Value=A275743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275743.Bytes);
public long this[int i]=>Value[i];

public static A275743Inst Instance=new A275743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275744
{
public static readonly long[] Value={ 0L,1L,0L,2L,0L,0L,5L,1L,0L,0L,19L,2L,0L,0L,0L,85L,8L,1L,0L,0L,0L,509L,29L,2L,0L,0L,0L,0L,4060L,138L,8L,1L,0L,0L,0L,0L,41301L,774L,33L,2L,0L,0L,0L,0L,0L,510489L,5693L,153L,8L,1L,0L,0L,0L,0L,0L,7319447L,53581L,861L,33L,2L,0L,0L,0L,0L,0L,0L,117940535L,626717L,6173L,158L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275744Inst : IEnumerable<long>
{
public static readonly long[] Value=A275744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275744.Bytes);
public long this[int i]=>Value[i];

public static A275744Inst Instance=new A275744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275745
{
public static readonly long[] Value={ -1L,-1L,1L,0L,-4L,-2L,2L,4L,0L,-2L,0L,-10L,10L,4L,8L,-10L,-4L,-2L,12L,-8L,10L,0L,12L,-6L,2L,6L,-16L,-12L,14L,2L,-8L,-12L,-6L,-4L,22L,-8L,14L,-4L,0L,-18L,20L,-10L,16L,2L,6L,-8L,20L,8L,-20L,6L,-6L,-16L,-14L,12L,18L,16L,14L,16L,6L,-6L,-12L,6L,28L,-24L,26L,-2L,12L,-14L,-28L,-2L,18L,-24L,-24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275745Inst : IEnumerable<long>
{
public static readonly long[] Value=A275745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275745.Bytes);
public long this[int i]=>Value[i];

public static A275745Inst Instance=new A275745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275746
{
public static readonly ulong[] Value={ 3L,62L,840L,12350L,99912L,2358913L,12173587L,120900206L,1224812108L,20439317893L,130357794430L,1534358290778L,13544972574336L,142155007727976L,1648210755327790L,14816750258004918L,151900144117560355L,1525977077403654254L,16185530587326104490UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275746Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A275746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275746.Bytes);
public ulong this[int i]=>Value[i];

public static A275746Inst Instance=new A275746Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275747
{
public static readonly BigInteger[] Value={ 4L,114L,1595L,24195L,190463L,4613167L,23815950L,240951477L,2448240688L,40379465440L,258630935725L,3044619003271L,26232953378021L,264066033166293L,3218396161633945L,29248021240625765L,302064442857973298L,3027736057187540859L,BigInteger.Parse("32207709908667683204") };
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
public class A275747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275747Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275747.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275747.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275747Inst Instance=new A275747Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275748
{
public static readonly long[] Value={ 1L,2L,5L,2L,4L,5L,6L,3L,6L,4L,6L,5L,5L,6L,4L,3L,5L,6L,6L,4L,4L,6L,4L,5L,6L,5L,6L,6L,6L,4L,6L,3L,6L,6L,4L,6L,6L,6L,7L,4L,6L,4L,6L,6L,6L,4L,6L,5L,6L,6L,6L,5L,4L,6L,7L,6L,6L,6L,7L,4L,4L,6L,6L,3L,6L,6L,6L,6L,5L,4L,6L,6L,7L,6L,3L,6L,6L,7L,6L,4L,4L,6L,6L,4L,3L,6L,6L,6L,7L,6L,6L,4L,4L,6L,6L,5L,7L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275748Inst : IEnumerable<long>
{
public static readonly long[] Value=A275748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275748.Bytes);
public long this[int i]=>Value[i];

public static A275748Inst Instance=new A275748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275749
{
public static readonly long[] Value={ 5L,101L,524261L,8388581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275749Inst : IEnumerable<long>
{
public static readonly long[] Value=A275749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275749.Bytes);
public long this[int i]=>Value[i];

public static A275749Inst Instance=new A275749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275750
{
public static readonly BigInteger[] Value={ 37L,229L,997L,1048549L,4194277L,67108837L,1125899906842597L,72057594037927909L,288230376151711717L,BigInteger.Parse("1361129467683753853853498429727072845797"),BigInteger.Parse("1393796574908163946345982392040522594123749"),BigInteger.Parse("1725436586697640946858688965569256363112777243042596638790631055949797") };
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
public class A275750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275750Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275750.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275750.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275750Inst Instance=new A275750Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275751
{
public static readonly ulong[] Value={ 1L,1L,4L,19L,92L,446L,2150L,10280L,48761L,229558L,1073278L,4986624L,23037102L,105877968L,484337300L,2206188412L,10010589904L,45264063504L,204016241794L,916898737038L,4109984712933L,18379240912034L,82012499946246L,365245641944278L,1623757696702586L,7207073607368924L,31941896126213722L,141377838141158888L,624983649220555836L,2759711619634526196L,12173102200970091434UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275751Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A275751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275751.Bytes);
public ulong this[int i]=>Value[i];

public static A275751Inst Instance=new A275751Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275752
{
public static readonly ulong[] Value={ 1L,2L,8L,36L,166L,770L,3574L,16560L,76516L,352498L,1619014L,7414134L,33855996L,154181234L,700333366L,3173299648L,14345094004L,64704125888L,291235313046L,1308229210186L,5865335253474L,26248821086374L,117265700856282L,523010482541564L,2328947839518852L,10354971182171076L,45973304229373220L,203824525466826232L,902455230607927616L,3990584636812405052L,17624255201680536016UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275752Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A275752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275752.Bytes);
public ulong this[int i]=>Value[i];

public static A275752Inst Instance=new A275752Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275753
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,6L,24L,121L,726L,5079L,40560L,364476L,3640206L,40006088L,479768292L,6234255060L,87253162246L,1308521644539L,20933229087888L,355826789037120L,6404379412914120L,121676068664102592L,2433412615998606796L,BigInteger.Parse("51099894751020809916"),BigInteger.Parse("1124167011334895525130"),BigInteger.Parse("25855277489356103801281"),BigInteger.Parse("620515705723028539161588"),BigInteger.Parse("15512668351278349312387584"),BigInteger.Parse("403324551099671595472594130") };
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
public class A275753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275753Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275753.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275753.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275753Inst Instance=new A275753Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275754
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,25L,126L,759L,5280L,41922L,374348L,3718632L,40687982L,486272963L,6302207628L,88028389880L,1318140365566L,21062423444982L,357696122160256L,6433377303116791L,122156160094379094L,2441860821816085218L,BigInteger.Parse("51257318297766697640"),BigInteger.Parse("1127262952173081139014"),BigInteger.Parse("25919345794724305427250"),BigInteger.Parse("621907163139705123859022"),BigInteger.Parse("15544308709055844154008420"),BigInteger.Parse("404076225273612078440996928"),BigInteger.Parse("10908274705160761799960317228") };
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
public class A275754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275754Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275754.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275754.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275754Inst Instance=new A275754Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275755
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,19L,65L,234L,873L,3346L,13099L,52154L,210541L,859768L,3545263L,14741148L,61736903L,260192880L,1102704585L,4696416190L,20090502706L,86285786519L,371917832707L,1608317086940L,6975728777332L,30338392601498L,132277349730004L,578075052215714L,2531710609461484L,11109852467209553L,48843541287179595L,215108137824940916L,948874606956945665L,4191979050580762418L,BigInteger.Parse("18545890698661636784"),BigInteger.Parse("82159569800859439840"),BigInteger.Parse("364432560308538162214"),BigInteger.Parse("1618431087549954575022") };
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
public class A275755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275755Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275755.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275755.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275755Inst Instance=new A275755Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275756
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,20L,71L,264L,1018L,4032L,16305L,67042L,279444L,1178088L,5014596L,21521488L,93027025L,404630318L,1769704106L,7778030834L,34335337802L,152168657438L,676796514510L,3019945599904L,13515300673984L,60649985907334L,272847379282493L,1230295797205452L,5559373120441048L,25171114275512520L,114177375142080814L,518806321789317040L,2361183952087172306L,10762422470020855820UL,BigInteger.Parse("49125407360603361370"),BigInteger.Parse("224533932290057629076"),BigInteger.Parse("1027553322543206612019"),BigInteger.Parse("4708070541211739962738"),BigInteger.Parse("21595828228486254332762") };
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
public class A275756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275756Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275756.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275756.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275756Inst Instance=new A275756Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275757
{
public static readonly BigInteger[] Value={ 1L,1L,3L,11L,46L,207L,977L,4767L,23835L,121424L,627747L,3284055L,17348254L,92387544L,495371637L,2671588333L,14480158111L,78822638280L,430685654483L,2361012092488L,12980509646385L,71547277918984L,395252428706918L,2187886348193235L,12132382884810469L,67383306100049693L,374771558921409855L,2086989709106321626L,11634599273439782284UL,BigInteger.Parse("64923785744439199536"),BigInteger.Parse("362598744217074249165"),BigInteger.Parse("2026617482659866472677") };
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
public class A275757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275757Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275757.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275757.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275757Inst Instance=new A275757Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275758
{
public static readonly BigInteger[] Value={ 1L,1L,4L,21L,126L,817L,5574L,39418L,286286L,2122491L,15995696L,122166551L,943430560L,7353998931L,57783603764L,457176705018L,3639000808140L,29119701312548L,234120338807316L,1890257713736568L,15319612051101438L,124583720191974904L,1016307862050772614L,8314217332992596050L,BigInteger.Parse("68193993494598345010"),BigInteger.Parse("560671685990956975367"),BigInteger.Parse("4619857060146629819160"),BigInteger.Parse("38144728242794104501561"),BigInteger.Parse("315546193363448088862064"),BigInteger.Parse("2614910268303053285326541") };
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
public class A275758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275758Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275758.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275758.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275758Inst Instance=new A275758Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275759
{
public static readonly BigInteger[] Value={ 1L,1L,0L,-5L,0L,196L,0L,-21440L,0L,4605736L,0L,-1636894280L,0L,869411900176L,0L,-645115754969600L,0L,637400080589929216L,0L,BigInteger.Parse("-808996241179323833600"),0L,BigInteger.Parse("1282689609051390935443456"),0L,BigInteger.Parse("-2484567925086557616137108480"),0L,BigInteger.Parse("5773170916638182711440802000896"),0L,BigInteger.Parse("-15849498359717283169328377665597440"),0L,BigInteger.Parse("50754498157679863282024469922251431936"),0L,BigInteger.Parse("-187503919340846371804132353057069945159680") };
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
public class A275759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275759Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275759.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275759.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275759Inst Instance=new A275759Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275760
{
public static readonly long[] Value={ 1L,0L,1L,0L,-1L,0L,1L,0L,-1L,1L,0L,1L,-2L,0L,-1L,2L,-1L,0L,1L,-2L,3L,0L,-1L,3L,-4L,1L,0L,1L,-4L,5L,-4L,0L,-1L,4L,-8L,7L,-1L,0L,1L,-4L,11L,-10L,5L,0L,-1L,5L,-13L,16L,-11L,1L,0L,1L,-6L,16L,-24L,18L,-6L,0L,-1L,6L,-20L,33L,-30L,16L,-1L,0L,1L,-6L,24L,-44L,49L,-30L,7L,0L,-1L,7L,-28L,57L,-74L,53L,-22L,1L,0L,1L,-8L,32L,-74L,105L,-92L,47L,-8L,0L,-1L,8L,-37L,94L,-145L,149L,-89L,29L,-1L,0L,1L,-8L,43L,-114L,200L,-226L,163L,-70L,9L,0L,-1L,9L,-48L,138L,-268L,332L,-281L,143L,-37L,1L,0L,1L,-10L,53L,-168L,346L,-480L,454L,-276L,100L,-10L,0L,-1L,10L,-60L,200L,-442L,675L,-704L,503L,-221L,46L,-1L,0L,1L,-10L,67L,-234L,561L,-922L,1064L,-860L,450L,-138L,11L,0L,-1L,11L,-73L,273L,-701L,1236L,-1567L,1402L,-863L,330L,-56L,1L,0L,1L,-12L,80L,-318L,861L,-1634L,2246L,-2214L,1554L,-710L,185L,-12L,0L,-1L,12L,-88L,367L,-1047L,2130L,-3144L,3403L,-2657L,1429L,-478L,67L,-1L,0L,1L,-12L,96L,-418L,1268L,-2732L,4325L,-5088L,4378L,-2700L,1088L,-242L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275760Inst : IEnumerable<long>
{
public static readonly long[] Value=A275760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275760.Bytes);
public long this[int i]=>Value[i];

public static A275760Inst Instance=new A275760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275761
{
public static readonly long[] Value={ 1L,1L,-1L,1L,0L,-1L,0L,2L,-1L,-2L,1L,3L,-3L,-1L,3L,1L,-7L,3L,7L,-2L,-12L,10L,5L,-10L,-8L,27L,-8L,-23L,2L,46L,-38L,-20L,30L,45L,-100L,27L,71L,12L,-183L,141L,65L,-71L,-213L,384L,-100L,-202L,-145L,729L,-545L,-172L,93L,993L,-1497L,430L,452L,962L,-2982L,2188L,250L,451L,-4527L,6014L,-2119L,-296L,-5456L,12440L,-9197L,1206L,-5307L,20547L,-24963L,11156L,-5513L,28712L,-53013L,40590L,-15529L,36553L,-93599L,107065L,-60129L,52093L,-145383L,231326L,-186656L,113800L,-214705L,429584L,-474454L,323536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275761Inst : IEnumerable<long>
{
public static readonly long[] Value=A275761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275761.Bytes);
public long this[int i]=>Value[i];

public static A275761Inst Instance=new A275761Inst();

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