using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A287747
{
public static readonly ulong[] Value={ 12345678910L,234567891011L,3456789101112L,45678910111213L,567891011121314L,6789101112131415L,78910111213141516L,891011121314151617L,9101112131415161718L,10111213141516171819UL,11121314151617181920UL,12131415161718192021UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287747Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A287747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287747.Bytes);
public ulong this[int i]=>Value[i];

public static A287747Inst Instance=new A287747Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287748
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,2L,7L,0L,2L,0L,3L,2L,10L,2L,2L,0L,2L,0L,5L,0L,4L,0L,4L,0L,3L,0L,4L,0L,6L,0L,6L,0L,4L,0L,3L,0L,3L,0L,6L,0L,4L,0L,4L,0L,4L,0L,4L,0L,5L,0L,7L,0L,2L,0L,2L,0L,25L,0L,10L,2L,2L,0L,6L,2L,2L,0L,8L,0L,8L,0L,2L,0L,3L,0L,2L,0L,9L,0L,4L,0L,5L,0L,16L,0L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287748Inst : IEnumerable<long>
{
public static readonly long[] Value=A287748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287748.Bytes);
public long this[int i]=>Value[i];

public static A287748Inst Instance=new A287748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287749
{
public static readonly BigInteger[] Value={ 1L,11L,1L,1110L,1L,111111L,0L,11111111L,1L,1111111110L,11L,111111111100L,11L,11111111111100L,1011L,1111111111110111L,1000L,111111111111110111L,1001L,11111111111111110110UL,1101L,BigInteger.Parse("1111111111111111110011"),1100L,BigInteger.Parse("111111111111111111110011"),1100L };
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
public class A287749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287749Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287749.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A287749.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287749Inst Instance=new A287749Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287750
{
public static readonly BigInteger[] Value={ 1L,11L,100L,111L,10000L,111111L,0L,11111111L,100000000L,111111111L,11000000000L,1111111111L,1100000000000L,111111111111L,110100000000000L,1110111111111111L,10000000000000L,111011111111111111L,1001000000000000000L,1101111111111111111L,BigInteger.Parse("101100000000000000000") };
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
public class A287750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287750Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287750.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A287750.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287750Inst Instance=new A287750Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287751
{
public static readonly long[] Value={ 1L,3L,1L,14L,1L,63L,0L,255L,1L,1022L,3L,4092L,3L,16380L,11L,65527L,8L,262135L,9L,1048566L,13L,4194291L,12L,16777203L,12L,67108859L,7L,268435448L,71L,1073741759L,224L,4294967071L,228L,17179869051L,132L,68719476603L,388L,274877906687L,320L,1099511627455L,339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287751Inst : IEnumerable<long>
{
public static readonly long[] Value=A287751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287751.Bytes);
public long this[int i]=>Value[i];

public static A287751Inst Instance=new A287751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287752
{
public static readonly long[] Value={ 1L,3L,4L,7L,16L,63L,0L,255L,256L,511L,1536L,1023L,6144L,4095L,26624L,61439L,8192L,245759L,294912L,458751L,1441792L,3407871L,1572864L,13631487L,6291456L,58720255L,117440512L,33554431L,473956352L,1065353215L,58720256L,4177526783L,1308622848L,14965276671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287752Inst : IEnumerable<long>
{
public static readonly long[] Value=A287752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287752.Bytes);
public long this[int i]=>Value[i];

public static A287752Inst Instance=new A287752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287753
{
public static readonly long[] Value={ 1L,1L,10L,1L,111L,0L,1100L,11L,11000L,110L,111001L,1001L,1110110L,10110L,11101001L,100101L,111011010L,1000110L,1110110001L,10001101L,11101101010L,100010110L,111011100001L,1000011101L,1110110100010L,10001001110L,11101110110001L,100000001101L,111011011101010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287753Inst : IEnumerable<long>
{
public static readonly long[] Value=A287753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287753.Bytes);
public long this[int i]=>Value[i];

public static A287753Inst Instance=new A287753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287786
{
public static readonly BigInteger[] Value={ 1L,10L,11L,1110L,101L,111100L,1101L,11111010L,10111L,1111110010L,110011L,111111100010L,1000111L,11111111011010L,11101101L,1111111110001110L,101101001L,111111111101011110L,1100001111L,11111111111001000110UL,10010011011L,BigInteger.Parse("1111111111110111110110"),111111100001L };
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
public class A287786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287786Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287786.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A287786.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287786Inst Instance=new A287786Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287787
{
public static readonly long[] Value={ 1L,1L,110L,111L,10100L,1111L,1011000L,1011111L,111010000L,100111111L,11001100000L,10001111111L,1110001000000L,1011011111111L,101101110000000L,111000111111111L,10010110100000000L,11110101111111111L,1111000011000000000L,1100010011111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287787Inst : IEnumerable<long>
{
public static readonly long[] Value=A287787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287787.Bytes);
public long this[int i]=>Value[i];

public static A287787Inst Instance=new A287787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287788
{
public static readonly long[] Value={ 1L,2L,3L,14L,5L,60L,13L,250L,23L,1010L,51L,4066L,71L,16346L,237L,65422L,361L,261982L,783L,1048134L,1179L,4193782L,4065L,16775382L,6087L,67106070L,13235L,268428420L,20401L,1073733508L,62433L,4294938012L,96981L,17179824520L,212685L,68719364496L,326617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287788Inst : IEnumerable<long>
{
public static readonly long[] Value=A287788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287788.Bytes);
public long this[int i]=>Value[i];

public static A287788Inst Instance=new A287788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287789
{
public static readonly long[] Value={ 1L,1L,6L,7L,20L,15L,88L,95L,464L,319L,1632L,1151L,7232L,5887L,23424L,29183L,77056L,125951L,493056L,403455L,1778688L,1830911L,4454400L,7020543L,29872128L,27443199L,107896832L,34766847L,297680896L,142540799L,1139245056L,967966719L,5750194176L,1177288703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287789Inst : IEnumerable<long>
{
public static readonly long[] Value=A287789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287789.Bytes);
public long this[int i]=>Value[i];

public static A287789Inst Instance=new A287789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287790
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287790Inst : IEnumerable<long>
{
public static readonly long[] Value=A287790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287790.Bytes);
public long this[int i]=>Value[i];

public static A287790Inst Instance=new A287790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287791
{
public static readonly long[] Value={ 1L,2L,6L,7L,8L,10L,11L,15L,16L,17L,21L,22L,23L,25L,26L,30L,31L,32L,34L,35L,39L,40L,41L,45L,46L,47L,49L,50L,54L,55L,56L,60L,61L,62L,64L,65L,69L,70L,71L,73L,74L,78L,79L,80L,84L,85L,86L,88L,89L,93L,94L,95L,97L,98L,102L,103L,104L,108L,109L,110L,112L,113L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287791Inst : IEnumerable<long>
{
public static readonly long[] Value=A287791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287791.Bytes);
public long this[int i]=>Value[i];

public static A287791Inst Instance=new A287791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287792
{
public static readonly long[] Value={ 3L,4L,5L,9L,12L,13L,14L,18L,19L,20L,24L,27L,28L,29L,33L,36L,37L,38L,42L,43L,44L,48L,51L,52L,53L,57L,58L,59L,63L,66L,67L,68L,72L,75L,76L,77L,81L,82L,83L,87L,90L,91L,92L,96L,99L,100L,101L,105L,106L,107L,111L,114L,115L,116L,120L,121L,122L,126L,129L,130L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287792Inst : IEnumerable<long>
{
public static readonly long[] Value=A287792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287792.Bytes);
public long this[int i]=>Value[i];

public static A287792Inst Instance=new A287792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287793
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,7L,6L,5L,4L,3L,2L,1L,2L,3L,4L,5L,6L,7L,8L,9L,8L,7L,6L,5L,4L,3L,2L,3L,4L,5L,6L,7L,8L,9L,10L,9L,8L,7L,6L,5L,4L,3L,4L,5L,6L,7L,8L,9L,10L,11L,10L,9L,8L,7L,6L,5L,4L,5L,6L,7L,8L,9L,10L,11L,12L,11L,10L,9L,8L,7L,6L,5L,6L,7L,8L,9L,10L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287793Inst : IEnumerable<long>
{
public static readonly long[] Value=A287793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287793.Bytes);
public long this[int i]=>Value[i];

public static A287793Inst Instance=new A287793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287794
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,8L,7L,6L,5L,4L,3L,2L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,9L,8L,7L,6L,5L,4L,3L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,10L,9L,8L,7L,6L,5L,4L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,11L,10L,9L,8L,7L,6L,5L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,12L,11L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287794Inst : IEnumerable<long>
{
public static readonly long[] Value=A287794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287794.Bytes);
public long this[int i]=>Value[i];

public static A287794Inst Instance=new A287794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287795
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287795Inst : IEnumerable<long>
{
public static readonly long[] Value=A287795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287795.Bytes);
public long this[int i]=>Value[i];

public static A287795Inst Instance=new A287795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287796
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,5L,6L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287796Inst : IEnumerable<long>
{
public static readonly long[] Value=A287796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287796.Bytes);
public long this[int i]=>Value[i];

public static A287796Inst Instance=new A287796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287797
{
public static readonly long[] Value={ 1L,2L,4L,3L,4L,5L,4L,4L,6L,8L,5L,6L,8L,10L,13L,6L,8L,9L,12L,15L,18L,7L,8L,11L,14L,18L,21L,25L,8L,8L,12L,16L,20L,24L,28L,32L,9L,10L,14L,18L,23L,27L,32L,36L,41L,10L,12L,15L,20L,25L,30L,35L,40L,45L,50L,11L,12L,17L,22L,28L,33L,39L,44L,50L,55L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287797Inst : IEnumerable<long>
{
public static readonly long[] Value=A287797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287797.Bytes);
public long this[int i]=>Value[i];

public static A287797Inst Instance=new A287797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287798
{
public static readonly long[] Value={ 159L,6L,5L,10L,20L,40L,80L,160L,320L,640L,1280L,2560L,5120L,10240L,20480L,40960L,81920L,163840L,327680L,655360L,1310720L,2621440L,5242880L,10485760L,20971520L,41943040L,83886080L,167772160L,335544320L,671088640L,1342177280L,2684354560L,5368709120L,10737418240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287798Inst : IEnumerable<long>
{
public static readonly long[] Value=A287798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287798.Bytes);
public long this[int i]=>Value[i];

public static A287798Inst Instance=new A287798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287799
{
public static readonly long[] Value={ 1L,3L,21L,33L,123L,219L,321L,3453L,6621L,16521L,18273L,25089L,27831L,29787L,62313L,69981L,75459L,95577L,101301L,105459L,157299L,196239L,197481L,247047L,259797L,281433L,359943L,390237L,418881L,460821L,529167L,569559L,595869L,680307L,727341L,945141L,955569L,964401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287799Inst : IEnumerable<long>
{
public static readonly long[] Value=A287799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287799.Bytes);
public long this[int i]=>Value[i];

public static A287799Inst Instance=new A287799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287800
{
public static readonly long[] Value={ 900L,2400L,3840L,6480L,7200L,11520L,13056L,39168L,42240L,79200L,83232L,96000L,126720L,145200L,153600L,157440L,174240L,195840L,207360L,288000L,300000L,317520L,326592L,387840L,435600L,460800L,472320L,480000L,900000L,971520L,1056000L,1161600L,1163520L,1228800L,1440000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287800Inst : IEnumerable<long>
{
public static readonly long[] Value=A287800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287800.Bytes);
public long this[int i]=>Value[i];

public static A287800Inst Instance=new A287800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287801
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287801Inst : IEnumerable<long>
{
public static readonly long[] Value=A287801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287801.Bytes);
public long this[int i]=>Value[i];

public static A287801Inst Instance=new A287801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287818
{
public static readonly long[] Value={ 1L,9L,69L,531L,4089L,31491L,242529L,1867851L,14385369L,110789811L,853254609L,6571393371L,50609994249L,389776014531L,3001884188289L,23119197549291L,178053936060729L,1371293449053651L,10561101680875569L,81336980637343611L,626421808927336809L,4824426473972595171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287818Inst : IEnumerable<long>
{
public static readonly long[] Value=A287818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287818.Bytes);
public long this[int i]=>Value[i];

public static A287818Inst Instance=new A287818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287819
{
public static readonly long[] Value={ 1L,9L,71L,561L,4433L,35031L,276827L,2187585L,17287073L,136608591L,1079529611L,8530826457L,67413620993L,532726379847L,4209793089371L,33267280400913L,262889866978817L,2077449112980255L,16416740845208075L,129730917736941417L,1025179795159015841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287819Inst : IEnumerable<long>
{
public static readonly long[] Value=A287819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287819.Bytes);
public long this[int i]=>Value[i];

public static A287819Inst Instance=new A287819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287820
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,1L,2L,2L,3L,1L,2L,2L,3L,3L,1L,2L,2L,2L,3L,3L,3L,1L,4L,2L,2L,2L,3L,3L,3L,3L,4L,1L,4L,2L,2L,2L,2L,3L,3L,3L,3L,4L,3L,1L,4L,4L,4L,2L,2L,2L,5L,2L,3L,3L,3L,3L,3L,3L,4L,3L,1L,4L,4L,4L,5L,2L,2L,2L,2L,2L,5L,3L,3L,3L,3L,3L,3L,3L,4L,3L,4L,1L,4L,4L,5L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287820Inst : IEnumerable<long>
{
public static readonly long[] Value=A287820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287820.Bytes);
public long this[int i]=>Value[i];

public static A287820Inst Instance=new A287820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287821
{
public static readonly long[] Value={ 2L,3L,4L,3L,5L,4L,6L,4L,5L,4L,7L,5L,6L,4L,5L,8L,6L,5L,7L,4L,5L,6L,9L,4L,7L,6L,8L,5L,6L,5L,7L,4L,10L,5L,8L,6L,7L,9L,6L,5L,7L,6L,4L,8L,11L,5L,6L,5L,9L,7L,8L,4L,10L,7L,6L,5L,8L,6L,7L,5L,9L,12L,5L,7L,6L,4L,10L,8L,7L,9L,11L,5L,8L,6L,7L,6L,9L,7L,8L,6L,10L,5L,13L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287821Inst : IEnumerable<long>
{
public static readonly long[] Value=A287821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287821.Bytes);
public long this[int i]=>Value[i];

public static A287821Inst Instance=new A287821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287822
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,3L,1L,1L,0L,5L,7L,1L,1L,0L,13L,18L,9L,1L,1L,0L,31L,59L,29L,11L,1L,1L,0L,71L,193L,112L,38L,13L,1L,1L,0L,181L,616L,405L,163L,48L,15L,1L,1L,0L,447L,1955L,1514L,648L,220L,59L,17L,1L,1L,0L,1111L,6244L,5565L,2571L,925L,288L,71L,19L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287822Inst : IEnumerable<long>
{
public static readonly long[] Value=A287822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287822.Bytes);
public long this[int i]=>Value[i];

public static A287822Inst Instance=new A287822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287823
{
public static readonly long[] Value={ 1L,0L,1L,3L,2L,2L,1L,0L,1L,2L,2L,3L,3L,4L,3L,5L,4L,6L,5L,6L,5L,6L,4L,4L,3L,4L,3L,3L,2L,2L,1L,0L,1L,2L,2L,3L,3L,4L,3L,4L,4L,6L,5L,6L,5L,6L,4L,5L,5L,8L,7L,9L,8L,10L,7L,8L,7L,10L,8L,9L,7L,8L,5L,7L,6L,10L,9L,12L,11L,14L,10L,12L,11L,16L,13L,15L,12L,14L,9L,10L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287823Inst : IEnumerable<long>
{
public static readonly long[] Value=A287823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287823.Bytes);
public long this[int i]=>Value[i];

public static A287823Inst Instance=new A287823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287824
{
public static readonly long[] Value={ 0L,2L,1L,0L,1L,2L,2L,4L,3L,4L,3L,3L,2L,2L,1L,0L,1L,2L,2L,3L,3L,4L,3L,4L,4L,6L,5L,6L,5L,6L,4L,6L,5L,8L,7L,9L,8L,10L,7L,8L,7L,10L,8L,9L,7L,8L,5L,5L,4L,6L,5L,6L,5L,6L,4L,4L,3L,4L,3L,3L,2L,2L,1L,0L,1L,2L,2L,3L,3L,4L,3L,4L,4L,6L,5L,6L,5L,6L,4L,5L,5L,8L,7L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287824Inst : IEnumerable<long>
{
public static readonly long[] Value=A287824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287824.Bytes);
public long this[int i]=>Value[i];

public static A287824Inst Instance=new A287824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287825
{
public static readonly long[] Value={ 1L,10L,82L,674L,5540L,45538L,374316L,3076828L,25291120L,207889674L,1708825732L,14046322404L,115458919774L,949057110644L,7801124426174L,64124215108032L,527092600834054L,4332631742719370L,35613662169258228L,292739611493034596L,2406281042646218328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287825Inst : IEnumerable<long>
{
public static readonly long[] Value=A287825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287825.Bytes);
public long this[int i]=>Value[i];

public static A287825Inst Instance=new A287825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287826
{
public static readonly long[] Value={ 1L,10L,84L,708L,5968L,50308L,424080L,3574860L,30134944L,254028100L,2141377008L,18051134892L,152165391616L,1282706408548L,10812811724688L,91148603152524L,768354066287200L,6476983198439812L,54598931916359472L,460251829451302764L,3879778213203474880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287826Inst : IEnumerable<long>
{
public static readonly long[] Value=A287826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287826.Bytes);
public long this[int i]=>Value[i];

public static A287826Inst Instance=new A287826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287827
{
public static readonly long[] Value={ 1L,10L,86L,742L,6404L,55274L,477082L,4117804L,35541714L,306768722L,2647791524L,22853698754L,197255539962L,1702558017644L,14695170558994L,126837403201602L,1094762853302164L,9449150445514434L,81557794797885642L,703944119701429084L,6075903902137709074L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287827Inst : IEnumerable<long>
{
public static readonly long[] Value=A287827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287827.Bytes);
public long this[int i]=>Value[i];

public static A287827Inst Instance=new A287827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287828
{
public static readonly long[] Value={ 1L,10L,88L,776L,6844L,60364L,532412L,4695892L,41417932L,365307620L,3222026092L,28418383780L,250651147340L,2210751960772L,19498910274028L,171981076403492L,1516879160180620L,13378927697789188L,118002614210453804L,1040787219651555556L,9179779989094951372L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A287828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287828Inst : IEnumerable<long>
{
public static readonly long[] Value=A287828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A287828.Bytes);
public long this[int i]=>Value[i];

public static A287828Inst Instance=new A287828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287829
{
public static readonly BigInteger[] Value={ 1L,10L,92L,848L,7816L,72040L,663992L,6120008L,56408056L,519912520L,4792028792L,44168084168L,407096815096L,3752207504200L,34584061167992L,318760965520328L,2938016812018936L,27079673239211080L,249593092776937592L,2300497181470860488L,BigInteger.Parse("21203660818791619576") };
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
public class A287829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287829Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287829.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A287829.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287829Inst Instance=new A287829Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287830
{
public static readonly BigInteger[] Value={ 1L,10L,94L,886L,8350L,78694L,741646L,6989590L,65872894L,620814406L,5850821230L,55140648694L,519669123166L,4897584703270L,46156938822094L,435002788211926L,4099652849195710L,38636886795609094L,364130592557264686L,3431722880197818550L,BigInteger.Parse("32342028292009425694") };
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
public class A287830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287830Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287830.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A287830.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287830Inst Instance=new A287830Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287831
{
public static readonly BigInteger[] Value={ 1L,10L,96L,924L,8892L,85572L,823500L,7924932L,76265388L,733938084L,7063035084L,67970944260L,654116708844L,6294876045156L,60578584659468L,582976518206148L,5610260171812140L,53990200655546148L,519573366930788172L,5000101506310370436L,BigInteger.Parse("48118353758378062956") };
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
public class A287831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287831Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287831.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A287831.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287831Inst Instance=new A287831Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287832
{
public static readonly BigInteger[] Value={ 1L,11L,101L,929L,8545L,78599L,722973L,6650087L,61169169L,562649373L,5175390189L,47604538285L,437878494689L,4027716327495L,37047945974857L,340776308298291L,3134546038698889L,28832341420057365L,265207115001514409L,2439441626426418609L,BigInteger.Parse("22438596523731989473") };
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
public class A287832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287832Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287832.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A287832.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287832Inst Instance=new A287832Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A287833
{
public static readonly BigInteger[] Value={ 1L,11L,103L,967L,9079L,85243L,800351L,7514541L,70554457L,662439857L,6219685951L,58396989455L,548292695881L,5147951686649L,48334414751849L,453814602701801L,4260891430727991L,40005754941255473L,375616336261903907L,3526683405274793053L,BigInteger.Parse("33112233522155404139") };
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
public class A287833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A287833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A287833Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A287833.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A287833.Bytes);
public BigInteger this[int i]=>Value[i];

public static A287833Inst Instance=new A287833Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288076
{
public static readonly BigInteger[] Value={ 56628L,2668750L,66449432L,1171704435L,16476937840L,196924458720L,2079913241120L,19925913354061L,176357530955320L,1461629029629340L,11460411934448048L,85694099173907510L,614960028331370816L,4257157940494918160L,BigInteger.Parse("28549761695867223680"),BigInteger.Parse("186131532080726321441"),BigInteger.Parse("1183191417356212860200"),BigInteger.Parse("7351865732351585503652") };
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
public class A288076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288076Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288076.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288076.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288076Inst Instance=new A288076Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288077
{
public static readonly BigInteger[] Value={ 1169740L,66449432L,1955808460L,40121261136L,647739636160L,8789123742880L,104395235785256L,1115525500250760L,10933959720960760L,99727841192820016L,855779329367736840L,6968569097113244096L,BigInteger.Parse("54217755730994858080"),BigInteger.Parse("405300088876353160320"),BigInteger.Parse("2924455840981270327952"),BigInteger.Parse("20446207814548586119000"),BigInteger.Parse("138958722742591452843432") };
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
public class A288077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288077Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288077.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288077.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288077Inst Instance=new A288077Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288078
{
public static readonly BigInteger[] Value={ 17454580L,1171704435L,40121261136L,945068384880L,17326957790896L,264477214235234L,3505018618003600L,41491242915292306L,447708887118504600L,4470547991985864322L,BigInteger.Parse("41790549086980226368"),BigInteger.Parse("369061676845849000520"),BigInteger.Parse("3101645444966543203008"),BigInteger.Parse("24954084939131951164980"),BigInteger.Parse("193145505023621965434976"),BigInteger.Parse("1444143475412182351017494"),BigInteger.Parse("10467259286591304015806600") };
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
public class A288078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288078Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288078.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288078.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288078Inst Instance=new A288078Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288079
{
public static readonly BigInteger[] Value={ 211083730L,16476937840L,647739636160L,17326957790896L,357391270819604L,6087558311398000L,89390908732820144L,1165172136542282424L,13767319160210071404UL,BigInteger.Parse("149789855223187292608"),BigInteger.Parse("1518921342035154605600"),BigInteger.Parse("14492634832409091816640"),BigInteger.Parse("131114130730951689447016"),BigInteger.Parse("1131791523345860091265696"),BigInteger.Parse("9370402052804684247760928") };
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
public class A288079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288079Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288079.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288079.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288079Inst Instance=new A288079Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288080
{
public static readonly BigInteger[] Value={ 2198596400L,196924458720L,8789123742880L,264477214235234L,6087558311398000L,114899070275212424L,1857975645023518752L,BigInteger.Parse("26522236056202555206"),BigInteger.Parse("341505418008822731328"),BigInteger.Parse("4031165546220945277040"),BigInteger.Parse("44171448380277095027584"),BigInteger.Parse("453764845712090669861060"),BigInteger.Parse("4405234525240663358548000"),BigInteger.Parse("40682085269643556632419504"),BigInteger.Parse("359336179016097679450360000") };
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
public class A288080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288080Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288080.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288080.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288080Inst Instance=new A288080Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288081
{
public static readonly BigInteger[] Value={ 20465052608L,2079913241120L,104395235785256L,3505018618003600L,89390908732820144L,1857975645023518752L,BigInteger.Parse("32904419378927915376"),BigInteger.Parse("511895831411154922176"),BigInteger.Parse("7151648337964982801760"),BigInteger.Parse("91230456810047671200128"),BigInteger.Parse("1076401288635137599528944"),BigInteger.Parse("11867194568934207062990560") };
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
public class A288081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288081Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288081.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288081.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288081Inst Instance=new A288081Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288082
{
public static readonly BigInteger[] Value={ 483L,15018L,258972L,3288327L,34374186L,313530000L,2583699888L,19678611645L,140725699686L,955708437684L,6216591472728L,38985279745230L,236923660397172L,1401097546161936L,8089830217844928L,45732525474843801L,253705943922820830L,1383896652090932364L,7434748752218650632L,BigInteger.Parse("39394773780853063650") };
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
public class A288082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288082Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288082.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288082.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288082Inst Instance=new A288082Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288083
{
public static readonly BigInteger[] Value={ 6468L,258972L,5554188L,85421118L,1059255456L,11270290416L,106853266632L,925572602058L,7454157823560L,56532447160536L,407653880116680L,2815913391715452L,18743188498056288L,120789163612555200L,756589971284883792L,4621041111902656770L,BigInteger.Parse("27595482540212519064"),BigInteger.Parse("161490751719681569736") };
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
public class A288083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288083Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288083.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288083.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288083Inst Instance=new A288083Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288084
{
public static readonly BigInteger[] Value={ 66066L,3288327L,85421118L,1558792200L,22555934280L,276221817810L,2979641557620L,29079129795702L,261637840342860L,2200626948631386L,17486142956133684L,132344695964811720L,960323177351524512L,6716133365837116980L,BigInteger.Parse("45466867668336614472"),BigInteger.Parse("299027167905149145858"),BigInteger.Parse("1916387674555902480660") };
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
public class A288084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288084Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288084.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288084.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288084Inst Instance=new A288084Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288085
{
public static readonly BigInteger[] Value={ 570570L,34374186L,1059255456L,22555934280L,375708427812L,5235847653036L,63648856688592L,694146691745820L,6928413234959820L,64232028100704156L,559373367462490656L,4616545437250956192L,BigInteger.Parse("36362952155187558600"),BigInteger.Parse("274925536462366808760"),BigInteger.Parse("2004633652255211204832"),BigInteger.Parse("14152391716870383219492") };
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
public class A288085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288085Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288085.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288085.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288085Inst Instance=new A288085Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288086
{
public static readonly BigInteger[] Value={ 4390386L,313530000L,11270290416L,276221817810L,5235847653036L,82234427131416L,1117259292848016L,13518984452463630L,148755268498286436L,1511718920778951024L,14358354462488121408UL,BigInteger.Parse("128656798319026864068"),BigInteger.Parse("1095747149735034238680"),BigInteger.Parse("8924653047010981590288"),BigInteger.Parse("69866689045523025725664") };
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
public class A288086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288086Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288086.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288086.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288086Inst Instance=new A288086Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288087
{
public static readonly BigInteger[] Value={ 31039008L,2583699888L,106853266632L,2979641557620L,63648856688592L,1117259292848016L,16842445235560944L,224686278407291148L,2710382626755160416L,BigInteger.Parse("30044423965980553536"),BigInteger.Parse("309859885439753598768"),BigInteger.Parse("3002524783711124880936"),BigInteger.Parse("27551689577648333614176"),BigInteger.Parse("240961534103705377359840"),BigInteger.Parse("2019318707410947848445792") };
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
public class A288087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288087Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288087.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288087.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288087Inst Instance=new A288087Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288088
{
public static readonly BigInteger[] Value={ 205633428L,19678611645L,925572602058L,29079129795702L,694146691745820L,13518984452463630L,224686278407291148L,3286157560248860532L,BigInteger.Parse("43241609165618454096"),BigInteger.Parse("520516978029736518606"),BigInteger.Parse("5805858136761540452700"),BigInteger.Parse("60619447491266688750132"),BigInteger.Parse("597358002436877437320936"),BigInteger.Parse("5593151345725345725640044") };
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
public class A288088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288088Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288088.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288088.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288088Inst Instance=new A288088Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288089
{
public static readonly BigInteger[] Value={ 1293938646L,140725699686L,7454157823560L,261637840342860L,6928413234959820L,148755268498286436L,2710382626755160416L,BigInteger.Parse("43241609165618454096"),BigInteger.Parse("617910462111714896820"),BigInteger.Parse("8044640800289827566756"),BigInteger.Parse("96690983139765469347024"),BigInteger.Parse("1084226645505246141589704"),BigInteger.Parse("11439196912435362172792536"),BigInteger.Parse("114351801899024314438876200") };
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
public class A288089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288089Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288089.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288089.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288089Inst Instance=new A288089Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288090
{
public static readonly BigInteger[] Value={ 7808250450L,955708437684L,56532447160536L,2200626948631386L,64232028100704156L,1511718920778951024L,BigInteger.Parse("30044423965980553536"),BigInteger.Parse("520516978029736518606"),BigInteger.Parse("8044640800289827566756"),BigInteger.Parse("112860842135424498808968"),BigInteger.Parse("1456882832375987896763184"),BigInteger.Parse("17491588653334242501297012"),BigInteger.Parse("197038603477850885815215480") };
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
public class A288090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288090Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288090.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288090.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288090Inst Instance=new A288090Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288091
{
public static readonly long[] Value={ 3L,4L,8L,5L,9L,4L,4L,9L,7L,7L,4L,5L,3L,5L,5L,7L,7L,4L,5L,2L,1L,8L,8L,0L,9L,0L,4L,4L,0L,4L,6L,4L,0L,4L,7L,9L,5L,0L,9L,2L,6L,8L,2L,3L,2L,0L,8L,8L,1L,9L,6L,9L,4L,0L,7L,6L,4L,7L,2L,4L,9L,9L,9L,8L,1L,3L,1L,6L,1L,3L,1L,7L,2L,2L,9L,0L,0L,5L,6L,6L,2L,9L,6L,4L,0L,2L,2L,1L,4L,4L,6L,9L,7L,5L,9L,8L,6L,0L,1L,8L,6L,8L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288091Inst : IEnumerable<long>
{
public static readonly long[] Value=A288091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288091.Bytes);
public long this[int i]=>Value[i];

public static A288091Inst Instance=new A288091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288156
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,2L,3L,3L,3L,4L,4L,5L,5L,5L,6L,6L,7L,7L,7L,8L,8L,9L,9L,9L,10L,10L,11L,11L,11L,12L,12L,13L,13L,13L,14L,14L,15L,15L,15L,16L,16L,17L,17L,17L,18L,18L,19L,19L,19L,20L,20L,21L,21L,21L,22L,22L,23L,23L,23L,24L,24L,25L,25L,25L,26L,26L,27L,27L,27L,28L,28L,29L,29L,29L,30L,30L,31L,31L,31L,32L,32L,33L,33L,33L,34L,34L,35L,35L,35L,36L,36L,37L,37L,37L,38L,38L,39L,39L,39L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288156Inst : IEnumerable<long>
{
public static readonly long[] Value=A288156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288156.Bytes);
public long this[int i]=>Value[i];

public static A288156Inst Instance=new A288156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288157
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,2L,2L,3L,3L,4L,2L,4L,3L,4L,3L,5L,4L,5L,2L,5L,4L,5L,4L,6L,5L,6L,4L,5L,4L,6L,5L,7L,5L,6L,4L,8L,6L,5L,4L,7L,5L,7L,6L,6L,6L,7L,5L,8L,6L,8L,5L,6L,4L,6L,6L,7L,7L,6L,5L,11L,7L,7L,7L,10L,7L,7L,6L,7L,5L,7L,6L,11L,6L,8L,7L,7L,6L,9L,6L,9L,9L,7L,5L,10L,7L,6L,7L,9L,7L,10L,8L,10L,8L,7L,6L,10L,7L,10L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288157Inst : IEnumerable<long>
{
public static readonly long[] Value=A288157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288157.Bytes);
public long this[int i]=>Value[i];

public static A288157Inst Instance=new A288157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288158
{
public static readonly long[] Value={ 2L,1L,1L,2L,3L,1L,3L,3L,5L,2L,9L,5L,7L,4L,3L,14L,8L,4L,4L,9L,11L,8L,3L,7L,9L,10L,2L,36L,3L,1L,4L,6L,4L,2L,17L,3L,7L,4L,6L,14L,17L,14L,51L,3L,9L,12L,38L,8L,13L,36L,64L,30L,14L,14L,4L,19L,13L,41L,5L,19L,4L,60L,8L,20L,3L,13L,24L,10L,31L,15L,14L,42L,19L,13L,1L,30L,11L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288158Inst : IEnumerable<long>
{
public static readonly long[] Value=A288158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288158.Bytes);
public long this[int i]=>Value[i];

public static A288158Inst Instance=new A288158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288159
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,2L,3L,6L,4L,4L,9L,3L,3L,5L,9L,7L,3L,3L,3L,5L,3L,7L,19L,5L,5L,2L,3L,7L,7L,9L,5L,15L,3L,10L,10L,7L,14L,6L,8L,6L,25L,6L,50L,45L,13L,4L,18L,31L,27L,2L,4L,33L,18L,2L,41L,18L,10L,9L,6L,7L,3L,32L,4L,39L,18L,17L,11L,30L,17L,18L,7L,51L,38L,11L,15L,13L,9L,10L,24L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288159Inst : IEnumerable<long>
{
public static readonly long[] Value=A288159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288159.Bytes);
public long this[int i]=>Value[i];

public static A288159Inst Instance=new A288159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288160
{
public static readonly long[] Value={ 1L,2L,2L,2L,1L,1L,0L,1L,1L,1L,1L,4L,6L,6L,0L,15L,2L,8L,3L,1L,9L,4L,3L,14L,1L,0L,3L,0L,1L,2L,1L,3L,4L,25L,0L,1L,24L,2L,17L,22L,2L,4L,16L,2L,13L,9L,17L,17L,0L,10L,17L,3L,6L,34L,0L,1L,69L,5L,26L,8L,4L,3L,3L,8L,16L,19L,3L,5L,5L,0L,18L,8L,75L,5L,0L,1L,0L,37L,19L,14L,85L,4L,4L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288160Inst : IEnumerable<long>
{
public static readonly long[] Value=A288160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288160.Bytes);
public long this[int i]=>Value[i];

public static A288160Inst Instance=new A288160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288161
{
public static readonly BigInteger[] Value={ 2L,18L,6L,1350L,270L,23814L,17010L,65063250L,7229250L,9762090030L,4437313650L,8267713725521250L,635977978886250L,81188783595533250L,297692206516955250L,BigInteger.Parse("22510683177794610356250"),BigInteger.Parse("1564913803803903393750"),BigInteger.Parse("40011216302189267004656036250"),BigInteger.Parse("10529267447944543948593693750") };
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
public class A288161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288161Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288161.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288161.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288161Inst Instance=new A288161Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288162
{
public static readonly long[] Value={ 26L,52L,104L,208L,338L,416L,676L,832L,1352L,1664L,2704L,3328L,4394L,5408L,6656L,8788L,10816L,13312L,17576L,21632L,26624L,35152L,43264L,53248L,57122L,70304L,86528L,106496L,114244L,140608L,173056L,212992L,228488L,281216L,346112L,425984L,456976L,562432L,692224L,742586L,851968L,913952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288162Inst : IEnumerable<long>
{
public static readonly long[] Value=A288162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288162.Bytes);
public long this[int i]=>Value[i];

public static A288162Inst Instance=new A288162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288163
{
public static readonly BigInteger[] Value={ 1L,1L,5L,84L,4004L,494760L,150120600L,107969547840L,179605731622464L,678695382464158080L,BigInteger.Parse("5745964983105758544000"),BigInteger.Parse("107798142804281290451059200"),BigInteger.Parse("4441362930723337358985334172160"),BigInteger.Parse("398854836980938754158182857661404160"),BigInteger.Parse("77576833096847783279235708819073596288000") };
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
public class A288163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288163Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288163.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288163.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288163Inst Instance=new A288163Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288164
{
public static readonly long[] Value={ 1L,2L,2310L,1155L,3L,4L,770L,1365L,6L,8L,385L,1785L,12L,10L,455L,231L,18L,20L,595L,273L,22L,30L,105L,77L,26L,60L,165L,91L,14L,66L,195L,35L,28L,78L,255L,55L,38L,42L,210L,65L,11L,84L,390L,85L,7L,114L,330L,70L,13L,33L,420L,130L,17L,21L,462L,110L,5L,39L,546L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288164Inst : IEnumerable<long>
{
public static readonly long[] Value=A288164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288164.Bytes);
public long this[int i]=>Value[i];

public static A288164Inst Instance=new A288164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288165
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,2L,1L,1L,3L,2L,1L,5L,3L,2L,6L,5L,3L,9L,6L,5L,11L,9L,6L,15L,11L,9L,18L,15L,11L,23L,18L,15L,27L,23L,18L,34L,27L,23L,39L,34L,27L,47L,39L,34L,54L,47L,39L,64L,54L,47L,72L,64L,54L,84L,72L,64L,94L,84L,72L,108L,94L,84L,120L,108L,94L,136L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288165Inst : IEnumerable<long>
{
public static readonly long[] Value=A288165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288165.Bytes);
public long this[int i]=>Value[i];

public static A288165Inst Instance=new A288165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288166
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,2L,1L,1L,0L,3L,2L,1L,1L,5L,3L,2L,1L,7L,5L,3L,2L,10L,7L,5L,3L,13L,10L,7L,5L,18L,13L,10L,7L,23L,18L,13L,10L,30L,23L,18L,13L,37L,30L,23L,18L,47L,37L,30L,23L,57L,47L,37L,30L,70L,57L,47L,37L,84L,70L,57L,47L,101L,84L,70L,57L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288166Inst : IEnumerable<long>
{
public static readonly long[] Value=A288166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288166.Bytes);
public long this[int i]=>Value[i];

public static A288166Inst Instance=new A288166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288167
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288167Inst : IEnumerable<long>
{
public static readonly long[] Value=A288167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288167.Bytes);
public long this[int i]=>Value[i];

public static A288167Inst Instance=new A288167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288168
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,7L,8L,9L,11L,12L,13L,15L,16L,17L,19L,20L,21L,22L,23L,24L,26L,27L,28L,29L,30L,31L,32L,34L,35L,36L,37L,38L,39L,40L,42L,43L,44L,46L,47L,48L,50L,51L,52L,53L,54L,55L,57L,58L,59L,61L,62L,63L,65L,66L,67L,68L,69L,70L,71L,73L,74L,75L,77L,78L,79L,81L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288168Inst : IEnumerable<long>
{
public static readonly long[] Value=A288168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288168.Bytes);
public long this[int i]=>Value[i];

public static A288168Inst Instance=new A288168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288169
{
public static readonly long[] Value={ 3L,10L,14L,18L,25L,33L,41L,45L,49L,56L,60L,64L,72L,76L,80L,88L,96L,104L,108L,112L,119L,127L,135L,139L,143L,151L,159L,167L,171L,175L,183L,187L,191L,199L,203L,207L,215L,223L,231L,235L,239L,246L,250L,254L,262L,266L,270L,278L,286L,294L,298L,302L,310L,314L,318L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288169Inst : IEnumerable<long>
{
public static readonly long[] Value=A288169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288169.Bytes);
public long this[int i]=>Value[i];

public static A288169Inst Instance=new A288169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288170
{
public static readonly long[] Value={ 2L,4L,8L,16L,34L,70L,144L,292L,590L,1186L,2380L,4768L,9546L,19102L,38216L,76444L,152902L,305818L,611652L,1223320L,2446658L,4893334L,9786688L,19573396L,39146814L,78293650L,156587324L,313174672L,626349370L,1252698766L,2505397560L,5010795148L,10021590326L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288170Inst : IEnumerable<long>
{
public static readonly long[] Value=A288170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288170.Bytes);
public long this[int i]=>Value[i];

public static A288170Inst Instance=new A288170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288171
{
public static readonly long[] Value={ 1L,2L,3L,2310L,1155L,770L,4L,6L,9L,1365L,385L,910L,8L,12L,11L,1785L,455L,210L,10L,18L,13L,231L,595L,330L,20L,22L,7L,273L,105L,390L,30L,26L,14L,77L,165L,195L,60L,28L,34L,91L,255L,285L,66L,38L,42L,35L,315L,55L,78L,44L,84L,70L,345L,65L,33L,52L,102L,130L,357L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288171Inst : IEnumerable<long>
{
public static readonly long[] Value=A288171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288171.Bytes);
public long this[int i]=>Value[i];

public static A288171Inst Instance=new A288171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288236
{
public static readonly long[] Value={ 1L,3L,5L,9L,17L,30L,52L,91L,160L,281L,493L,865L,1518L,2664L,4675L,8204L,14397L,25265L,44337L,77805L,136534L,239592L,420441L,737798L,1294700L,2271961L,3986877L,6996242L,12277127L,21544115L,37805987L,66342603L,116419152L,204294349L,358499270L,629100742L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288236Inst : IEnumerable<long>
{
public static readonly long[] Value=A288236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288236.Bytes);
public long this[int i]=>Value[i];

public static A288236Inst Instance=new A288236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288237
{
public static readonly long[] Value={ 1L,3L,5L,9L,17L,30L,52L,91L,160L,281L,493L,865L,1518L,2664L,4675L,8204L,14397L,25265L,44337L,77806L,136540L,239611L,420488L,737905L,1294933L,2272449L,3987870L,6998224L,12281027L,21551700L,37820597L,66370521L,116472145L,204394366L,358687108L,629451995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288237Inst : IEnumerable<long>
{
public static readonly long[] Value=A288237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288237.Bytes);
public long this[int i]=>Value[i];

public static A288237Inst Instance=new A288237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288238
{
public static readonly long[] Value={ 1L,9L,9L,9L,9L,8L,8L,5L,5L,4L,7L,9L,4L,8L,1L,5L,9L,6L,3L,1L,6L,3L,3L,9L,9L,2L,0L,4L,3L,6L,5L,1L,5L,5L,8L,8L,8L,3L,7L,2L,5L,9L,5L,2L,0L,5L,9L,9L,3L,0L,1L,5L,9L,0L,8L,8L,9L,0L,7L,6L,5L,9L,4L,2L,9L,8L,1L,6L,3L,1L,5L,6L,1L,5L,3L,9L,0L,2L,8L,0L,4L,7L,4L,4L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288238Inst : IEnumerable<long>
{
public static readonly long[] Value=A288238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288238.Bytes);
public long this[int i]=>Value[i];

public static A288238Inst Instance=new A288238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288239
{
public static readonly long[] Value={ 1L,9L,8L,7L,8L,4L,4L,5L,1L,7L,5L,0L,0L,9L,7L,0L,2L,1L,3L,2L,0L,8L,5L,9L,5L,2L,9L,7L,1L,2L,2L,2L,4L,8L,2L,4L,2L,8L,5L,1L,4L,1L,9L,5L,8L,8L,4L,5L,8L,3L,7L,6L,7L,7L,9L,8L,0L,8L,2L,6L,9L,4L,8L,9L,4L,1L,0L,4L,6L,6L,5L,5L,2L,7L,1L,4L,3L,7L,9L,6L,1L,2L,3L,8L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288239Inst : IEnumerable<long>
{
public static readonly long[] Value=A288239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288239.Bytes);
public long this[int i]=>Value[i];

public static A288239Inst Instance=new A288239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288240
{
public static readonly long[] Value={ 1L,9L,4L,6L,2L,9L,0L,3L,8L,3L,5L,0L,2L,7L,4L,5L,0L,5L,1L,2L,0L,9L,7L,3L,9L,5L,6L,5L,8L,1L,4L,8L,5L,8L,6L,7L,0L,4L,2L,4L,2L,1L,2L,6L,9L,2L,6L,7L,3L,3L,1L,2L,8L,3L,4L,4L,5L,6L,5L,5L,2L,6L,1L,2L,1L,3L,0L,2L,5L,7L,9L,1L,7L,4L,0L,3L,2L,0L,3L,8L,0L,8L,0L,6L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288240Inst : IEnumerable<long>
{
public static readonly long[] Value=A288240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288240.Bytes);
public long this[int i]=>Value[i];

public static A288240Inst Instance=new A288240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288241
{
public static readonly long[] Value={ 1L,9L,4L,7L,9L,4L,8L,4L,7L,1L,8L,8L,4L,7L,7L,9L,6L,7L,1L,0L,3L,1L,5L,5L,7L,0L,5L,1L,6L,9L,0L,2L,5L,8L,4L,5L,2L,9L,3L,5L,0L,2L,5L,3L,8L,9L,4L,1L,5L,5L,1L,4L,1L,6L,9L,8L,4L,7L,8L,7L,3L,3L,7L,5L,9L,2L,2L,8L,0L,5L,5L,3L,7L,9L,7L,3L,5L,0L,3L,7L,6L,6L,3L,8L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288241Inst : IEnumerable<long>
{
public static readonly long[] Value=A288241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288241.Bytes);
public long this[int i]=>Value[i];

public static A288241Inst Instance=new A288241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288242
{
public static readonly long[] Value={ 1L,7L,6L,4L,0L,4L,5L,6L,9L,2L,5L,1L,6L,3L,1L,0L,8L,6L,5L,8L,7L,6L,6L,6L,7L,1L,3L,8L,6L,7L,4L,2L,6L,3L,3L,5L,4L,1L,3L,2L,4L,7L,6L,9L,0L,5L,2L,0L,1L,2L,9L,8L,1L,1L,8L,0L,9L,5L,4L,1L,4L,9L,5L,1L,6L,8L,4L,2L,5L,2L,3L,0L,7L,1L,1L,2L,7L,1L,7L,9L,9L,6L,7L,3L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288242Inst : IEnumerable<long>
{
public static readonly long[] Value=A288242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288242.Bytes);
public long this[int i]=>Value[i];

public static A288242Inst Instance=new A288242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288243
{
public static readonly long[] Value={ 2L,4L,7L,10L,14L,19L,26L,35L,45L,57L,71L,87L,106L,127L,151L,178L,208L,242L,279L,320L,366L,417L,473L,534L,601L,676L,759L,849L,947L,1054L,1172L,1302L,1442L,1594L,1759L,1939L,2136L,2346L,2573L,2819L,3086L,3376L,3685L,4018L,4379L,4770L,5192L,5642L,6126L,6650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288243Inst : IEnumerable<long>
{
public static readonly long[] Value=A288243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288243.Bytes);
public long this[int i]=>Value[i];

public static A288243Inst Instance=new A288243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288244
{
public static readonly long[] Value={ 1L,2L,3L,5L,10L,11L,12L,13L,14L,15L,18L,19L,20L,24L,28L,31L,34L,36L,37L,39L,40L,41L,42L,45L,46L,48L,49L,57L,64L,66L,67L,68L,70L,72L,73L,75L,78L,79L,82L,83L,86L,89L,90L,92L,93L,95L,96L,97L,99L,100L,103L,105L,108L,109L,110L,116L,117L,120L,121L,124L,125L,126L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288244Inst : IEnumerable<long>
{
public static readonly long[] Value=A288244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288244.Bytes);
public long this[int i]=>Value[i];

public static A288244Inst Instance=new A288244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288245
{
public static readonly long[] Value={ 1L,7L,-6L,49L,-63L,15L,343L,-588L,140L,126L,-20L,2401L,-5145L,1225L,2205L,-175L,-525L,15L,16807L,-43218L,10290L,27783L,-1470L,-8820L,126L,-2646L,630L,525L,-6L,117649L,-352947L,84035L,302526L,-12005L,-108045L,1029L,-64827L,10290L,8575L,-49L,15435L,-441L,-1225L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288245Inst : IEnumerable<long>
{
public static readonly long[] Value=A288245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288245.Bytes);
public long this[int i]=>Value[i];

public static A288245Inst Instance=new A288245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288246
{
public static readonly long[] Value={ 1L,4L,8L,10L,11L,13L,20L,26L,29L,34L,35L,43L,46L,50L,53L,56L,68L,70L,71L,85L,86L,94L,95L,98L,125L,130L,131L,139L,149L,154L,160L,161L,163L,169L,170L,178L,184L,194L,196L,199L,208L,215L,229L,239L,259L,266L,269L,271L,280L,283L,286L,290L,298L,305L,313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288246Inst : IEnumerable<long>
{
public static readonly long[] Value=A288246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288246.Bytes);
public long this[int i]=>Value[i];

public static A288246Inst Instance=new A288246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288247
{
public static readonly long[] Value={ 3L,2L,3L,8L,9L,7L,9L,8L,11L,12L,12L,13L,14L,14L,15L,16L,17L,18L,19L,20L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288247Inst : IEnumerable<long>
{
public static readonly long[] Value=A288247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288247.Bytes);
public long this[int i]=>Value[i];

public static A288247Inst Instance=new A288247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288248
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,1L,3L,2L,10L,6L,5L,11L,4L,11L,19L,17L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288248Inst : IEnumerable<long>
{
public static readonly long[] Value=A288248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288248.Bytes);
public long this[int i]=>Value[i];

public static A288248Inst Instance=new A288248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288249
{
public static readonly long[] Value={ 3L,8L,18L,28L,44L,65L,88L,118L,151L,189L,226L,272L,323L,377L,433L,493L,558L,627L,701L,778L,860L,945L,1034L,1127L,1224L,1325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288249Inst : IEnumerable<long>
{
public static readonly long[] Value=A288249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288249.Bytes);
public long this[int i]=>Value[i];

public static A288249Inst Instance=new A288249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288250
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,3L,5L,1L,15L,5L,8L,2L,1L,8L,2L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288250Inst : IEnumerable<long>
{
public static readonly long[] Value=A288250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288250.Bytes);
public long this[int i]=>Value[i];

public static A288250Inst Instance=new A288250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288251
{
public static readonly long[] Value={ 4L,2L,1L,1L,4L,10L,4L,2L,5L,2L,2L,1L,16L,1L,16L,1L,4L,8L,4L,8L,3L,4L,2L,4L,2L,4L,10L,22L,2L,1L,2L,1L,2L,5L,11L,4L,1L,4L,1L,4L,1L,16L,34L,2L,28L,4L,2L,4L,2L,4L,8L,17L,1L,14L,5L,2L,1L,2L,1L,2L,4L,52L,4L,7L,16L,34L,1L,4L,1L,4L,1L,2L,26L,2L,22L,8L,17L,6L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A288251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288251Inst : IEnumerable<long>
{
public static readonly long[] Value=A288251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A288251.Bytes);
public long this[int i]=>Value[i];

public static A288251Inst Instance=new A288251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288271
{
public static readonly BigInteger[] Value={ 225225L,12317877L,351683046L,7034538511L,111159740692L,1480593013900L,17302190625720L,182231849209410L,1763184571730010L,15894791312284170L,134951136993773100L,1088243826731751690L,8391311316938069520L,BigInteger.Parse("62210659883935683120"),BigInteger.Parse("445441857820701181440"),BigInteger.Parse("3092035882104030618900") };
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
public class A288271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288271Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288271.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288271.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288271Inst Instance=new A288271Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288272
{
public static readonly BigInteger[] Value={ 12317877L,792534015L,26225260226L,600398249550L,10743797911132L,160576594766588L,2089035241981688L,24325590127655531L,258634264294653390L,2548272396065512974L,BigInteger.Parse("23532893106071038404"),BigInteger.Parse("205518653220527665304"),BigInteger.Parse("1709552077642556424368"),BigInteger.Parse("13623964536133602210560"),BigInteger.Parse("104522878918062035228512") };
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
public class A288272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288272Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288272.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288272.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288272Inst Instance=new A288272Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288273
{
public static readonly BigInteger[] Value={ 351683046L,26225260226L,993494827480L,25766235457300L,517592962672296L,8615949311310872L,123981042854132536L,1587135819804394530L,BigInteger.Parse("18451302662846918700"),BigInteger.Parse("197822824662547694148"),BigInteger.Parse("1979281881126113225376"),BigInteger.Parse("18654346303702719912848"),BigInteger.Parse("166862901890503876520320"),BigInteger.Parse("1425340713681247480547040"),BigInteger.Parse("11686190470805703242554960") };
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
public class A288273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288273Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288273.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288273.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288273Inst Instance=new A288273Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288274
{
public static readonly BigInteger[] Value={ 7034538511L,600398249550L,25766235457300L,750260619502310L,16789118602155860L,309197871098871838L,4892650539994184868L,BigInteger.Parse("68503375296263488977"),BigInteger.Parse("866831237081712285138"),BigInteger.Parse("10071757699155275906824"),BigInteger.Parse("108780460548715291414960"),BigInteger.Parse("1102776421660293787585728"),BigInteger.Parse("10575907938883627723298512"),BigInteger.Parse("96567859695821049858887188"),BigInteger.Parse("844021580327996006292420440") };
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
public class A288274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288274Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288274.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288274.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288274Inst Instance=new A288274Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288275
{
public static readonly BigInteger[] Value={ 111159740692L,10743797911132L,517592962672296L,16789118602155860L,415691294404230748L,8419549939292302908L,BigInteger.Parse("145737674581607574840"),BigInteger.Parse("2221381417843144801098"),BigInteger.Parse("30468100266480917147760"),BigInteger.Parse("382217975972687580876304"),BigInteger.Parse("4441222132558609054169216"),BigInteger.Parse("48280421251792089554320464") };
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
public class A288275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288275Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288275.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288275.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288275Inst Instance=new A288275Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288276
{
public static readonly BigInteger[] Value={ 1480593013900L,160576594766588L,8615949311310872L,309197871098871838L,8419549939292302908L,BigInteger.Parse("186553519919803261860"),BigInteger.Parse("3515647035511186627416"),BigInteger.Parse("58089920897558352891672"),BigInteger.Parse("860337164444236894357488"),BigInteger.Parse("11612741439751867739074432"),BigInteger.Parse("144715531380208437909370144"),BigInteger.Parse("1682205432436689960841795876") };
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
public class A288276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288276Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288276.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288276.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288276Inst Instance=new A288276Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288277
{
public static readonly BigInteger[] Value={ 17302190625720L,2089035241981688L,123981042854132536L,4892650539994184868L,BigInteger.Parse("145737674581607574840"),BigInteger.Parse("3515647035511186627416"),BigInteger.Parse("71823371612912533887168"),BigInteger.Parse("1281537868340178808063824"),BigInteger.Parse("20423544863369526066131328"),BigInteger.Parse("295680368360952875467454880"),BigInteger.Parse("3940377769373862621216994864") };
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
public class A288277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288277Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288277.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288277.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288277Inst Instance=new A288277Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288278
{
public static readonly BigInteger[] Value={ 182231849209410L,24325590127655531L,1587135819804394530L,BigInteger.Parse("68503375296263488977"),BigInteger.Parse("2221381417843144801098"),BigInteger.Parse("58089920897558352891672"),BigInteger.Parse("1281537868340178808063824"),BigInteger.Parse("24605894500188479477960928"),BigInteger.Parse("420612140517667008915254376"),BigInteger.Parse("6512251870890866709301451550"),BigInteger.Parse("92559480623350598649493386580") };
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
public class A288278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288278Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288278.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288278.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288278Inst Instance=new A288278Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288279
{
public static readonly BigInteger[] Value={ 1763184571730010L,258634264294653390L,BigInteger.Parse("18451302662846918700"),BigInteger.Parse("866831237081712285138"),BigInteger.Parse("30468100266480917147760"),BigInteger.Parse("860337164444236894357488"),BigInteger.Parse("20423544863369526066131328"),BigInteger.Parse("420612140517667008915254376"),BigInteger.Parse("7689357064107454375292572788"),BigInteger.Parse("126977551039680427095997314540"),BigInteger.Parse("1920060399356995304343259728312") };
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
public class A288279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288279Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288279.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288279.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288279Inst Instance=new A288279Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288280
{
public static readonly BigInteger[] Value={ 15894791312284170L,2548272396065512974L,BigInteger.Parse("197822824662547694148"),BigInteger.Parse("10071757699155275906824"),BigInteger.Parse("382217975972687580876304"),BigInteger.Parse("11612741439751867739074432"),BigInteger.Parse("295680368360952875467454880"),BigInteger.Parse("6512251870890866709301451550"),BigInteger.Parse("126977551039680427095997314540"),BigInteger.Parse("2230836871835420574103711453068") };
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
public class A288280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288280Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288280.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288280.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288280Inst Instance=new A288280Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288281
{
public static readonly BigInteger[] Value={ 59520825L,4304016990L,158959754226L,4034735959800L,79553497760100L,1302772718028600L,18475997006212200L,233454817237201560L,2682208751185413450L,BigInteger.Parse("28449551653853229900"),BigInteger.Parse("281858111998039476900"),BigInteger.Parse("2632472852850938916000"),BigInteger.Parse("23350616705746908461520"),BigInteger.Parse("197910970615681824664800"),BigInteger.Parse("1610886016462484019585600") };
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
public class A288281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288281Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288281.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288281.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288281Inst Instance=new A288281Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288282
{
public static readonly BigInteger[] Value={ 4304016990L,354949166565L,14805457339920L,420797306522502L,9220982517965400L,166713517116449940L,2595050050431235488L,BigInteger.Parse("35801820369640556595"),BigInteger.Parse("447016944351510642564"),BigInteger.Parse("5131008990500486096250"),BigInteger.Parse("54801783386722932356160"),BigInteger.Parse("549865627271249187555384"),BigInteger.Parse("5223273162178751507973600") };
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
public class A288282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288282Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288282.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288282.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288282Inst Instance=new A288282Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A288283
{
public static readonly BigInteger[] Value={ 158959754226L,14805457339920L,691650582088536L,21853758736216200L,528887751025584600L,10499075716384241952UL,BigInteger.Parse("178505550201444784920"),BigInteger.Parse("2677324515710001081372"),BigInteger.Parse("36188783145801243558900"),BigInteger.Parse("447964809766718459342400"),BigInteger.Parse("5141788096308757330278816"),BigInteger.Parse("55267879542927003057175200"),BigInteger.Parse("560775739552815581754138816") };
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
public class A288283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A288283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A288283Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A288283.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A288283.Bytes);
public BigInteger this[int i]=>Value[i];

public static A288283Inst Instance=new A288283Inst();

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