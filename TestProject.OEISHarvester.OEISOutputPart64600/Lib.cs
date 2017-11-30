using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A088065
{
public static readonly BigInteger[] Value={ 4L,64L,3364L,5963364L,60997005963364L,BigInteger.Parse("199819427993460997005963364"),BigInteger.Parse("779148655555947391948259040199819427993460997005963364"),BigInteger.Parse("33058582527625497709623707406768930141321702287214840779148655555947391948259040199819427993460997005963364") };
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
public class A088065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088065Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088065.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A088065.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088065Inst Instance=new A088065Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088066
{
public static readonly long[] Value={ 44L,48L,253L,1834L,4193L,6380L,6532L,6788L,7187L,8216L,8711L,9318L,9519L,9817L,9908L,10947L,11971L,13308L,13880L,17326L,18366L,22664L,27938L,29576L,31931L,34773L,35960L,40853L,45454L,48736L,52256L,52586L,53010L,53956L,54758L,59618L,62178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088066Inst : IEnumerable<long>
{
public static readonly long[] Value=A088066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088066.Bytes);
public long this[int i]=>Value[i];

public static A088066Inst Instance=new A088066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088067
{
public static readonly BigInteger[] Value={ 2L,49L,4913L,161638253018845201L,3039570296881249L,BigInteger.Parse("1139375455639725601277890624"),BigInteger.Parse("528398289001625555528682909170420863") };
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
public class A088067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088067Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088067.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A088067.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088067Inst Instance=new A088067Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088196
{
public static readonly long[] Value={ 2L,3L,6L,10L,11L,14L,18L,22L,27L,30L,35L,38L,42L,46L,51L,58L,59L,66L,70L,68L,78L,82L,86L,92L,99L,102L,106L,107L,110L,126L,130L,134L,138L,147L,150L,155L,162L,166L,171L,178L,179L,190L,188L,195L,198L,210L,222L,226L,227L,230L,238L,234L,250L,254L,262L,267L,270L,275L,278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088196Inst : IEnumerable<long>
{
public static readonly long[] Value=A088196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088196.Bytes);
public long this[int i]=>Value[i];

public static A088196Inst Instance=new A088196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088197
{
public static readonly long[] Value={ 1L,3L,4L,1L,3L,4L,4L,5L,3L,5L,3L,4L,4L,5L,7L,1L,7L,4L,-2L,10L,4L,4L,6L,7L,3L,4L,1L,3L,16L,4L,4L,4L,9L,3L,5L,7L,4L,5L,7L,1L,11L,-2L,7L,3L,12L,12L,4L,1L,3L,8L,-4L,16L,4L,8L,5L,3L,5L,3L,4L,9L,15L,4L,-2L,7L,15L,2L,14L,1L,3L,8L,8L,5L,7L,4L,5L,8L,3L,4L,16L,1L,11L,-2L,10L,4L,4L,6L,7L,3L,4L,12L,8L,4L,8L,4L,5L,11L,4L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088197Inst : IEnumerable<long>
{
public static readonly long[] Value=A088197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088197.Bytes);
public long this[int i]=>Value[i];

public static A088197Inst Instance=new A088197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088198
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,3L,1L,1L,2L,1L,2L,3L,1L,1L,2L,1L,2L,1L,1L,5L,1L,1L,3L,5L,2L,1L,1L,2L,3L,1L,1L,3L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,5L,2L,1L,1L,1L,1L,2L,3L,1L,7L,1L,3L,1L,2L,1L,2L,3L,1L,2L,1L,1L,5L,2L,1L,5L,1L,2L,3L,1L,1L,2L,1L,1L,2L,2L,3L,7L,1L,2L,1L,5L,1L,1L,3L,5L,2L,1L,1L,1L,1L,1L,1L,1L,2L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088198Inst : IEnumerable<long>
{
public static readonly long[] Value=A088198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088198.Bytes);
public long this[int i]=>Value[i];

public static A088198Inst Instance=new A088198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088199
{
public static readonly long[] Value={ 73L,193L,241L,313L,433L,601L,1033L,1129L,1153L,1201L,1321L,1489L,1609L,1873L,2089L,2113L,2593L,2689L,2713L,3001L,3049L,3121L,3169L,3361L,3529L,3673L,3769L,3889L,4129L,4273L,4729L,4801L,4969L,5233L,5281L,5449L,5521L,5569L,5641L,5689L,5881L,6361L,6553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088199Inst : IEnumerable<long>
{
public static readonly long[] Value=A088199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088199.Bytes);
public long this[int i]=>Value[i];

public static A088199Inst Instance=new A088199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088200
{
public static readonly long[] Value={ -2L,-2L,-4L,-2L,-2L,-4L,-2L,-4L,-2L,0L,-4L,-4L,-4L,-2L,-4L,-2L,-2L,-10L,-2L,-4L,0L,-4L,-4L,-8L,-10L,-2L,-4L,0L,-4L,-2L,-4L,-4L,-4L,-2L,-4L,0L,-4L,-6L,-4L,0L,-8L,-4L,-2L,-2L,0L,-4L,-4L,-4L,-10L,-2L,-14L,-2L,0L,0L,-6L,-4L,-4L,0L,-10L,-2L,0L,-4L,-10L,-4L,-2L,0L,-4L,-2L,-2L,-6L,-2L,-4L,0L,-2L,-4L,-4L,-10L,-8L,-2L,0L,0L,-8L,-4L,-8L,-4L,0L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088200Inst : IEnumerable<long>
{
public static readonly long[] Value=A088200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088200.Bytes);
public long this[int i]=>Value[i];

public static A088200Inst Instance=new A088200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088201
{
public static readonly long[] Value={ 5L,5L,7L,5L,5L,7L,5L,11L,5L,11L,7L,7L,7L,5L,7L,5L,5L,13L,5L,7L,11L,7L,7L,11L,13L,5L,7L,11L,7L,5L,11L,7L,7L,5L,7L,7L,7L,13L,7L,7L,11L,7L,5L,5L,11L,7L,7L,7L,13L,13L,17L,5L,11L,11L,17L,11L,7L,7L,13L,5L,7L,7L,13L,7L,5L,7L,7L,5L,5L,13L,5L,7L,11L,13L,7L,7L,17L,11L,5L,7L,11L,11L,7L,11L,7L,7L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088201Inst : IEnumerable<long>
{
public static readonly long[] Value=A088201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088201.Bytes);
public long this[int i]=>Value[i];

public static A088201Inst Instance=new A088201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088202
{
public static readonly long[] Value={ 1L,4L,5L,5L,5L,7L,7L,9L,10L,11L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088202Inst : IEnumerable<long>
{
public static readonly long[] Value=A088202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088202.Bytes);
public long this[int i]=>Value[i];

public static A088202Inst Instance=new A088202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088203
{
public static readonly long[] Value={ 2L,1L,2L,1L,1L,1L,2L,3L,1L,1L,2L,1L,3L,2L,1L,1L,2L,1L,1L,1L,3L,1L,2L,2L,1L,1L,2L,3L,1L,1L,3L,1L,1L,2L,2L,2L,1L,1L,2L,1L,3L,2L,1L,1L,3L,2L,1L,3L,2L,2L,1L,1L,2L,1L,1L,1L,3L,1L,2L,2L,1L,1L,3L,1L,2L,1L,1L,1L,3L,2L,2L,2L,1L,1L,2L,3L,1L,1L,3L,1L,1L,2L,2L,2L,1L,1L,3L,1L,1L,1L,2L,3L,1L,1L,3L,3L,2L,2L,1L,1L,2L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088203Inst : IEnumerable<long>
{
public static readonly long[] Value=A088203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088203.Bytes);
public long this[int i]=>Value[i];

public static A088203Inst Instance=new A088203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088204
{
public static readonly long[] Value={ 3L,1L,3L,1L,1L,1L,3L,3L,1L,2L,3L,1L,1L,1L,2L,1L,3L,3L,1L,1L,2L,1L,1L,2L,3L,2L,1L,1L,2L,2L,1L,1L,2L,1L,3L,1L,2L,2L,1L,2L,2L,2L,1L,1L,2L,1L,1L,1L,3L,1L,1L,2L,2L,1L,1L,3L,2L,2L,1L,1L,2L,3L,1L,1L,3L,2L,1L,2L,2L,2L,1L,1L,3L,2L,2L,2L,1L,1L,2L,1L,3L,2L,1L,1L,3L,1L,2L,1L,1L,3L,2L,2L,1L,1L,3L,3L,2L,2L,1L,1L,2L,1L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088204Inst : IEnumerable<long>
{
public static readonly long[] Value=A088204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088204.Bytes);
public long this[int i]=>Value[i];

public static A088204Inst Instance=new A088204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088205
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,1L,0L,3L,1L,1L,0L,1L,3L,2L,1L,1L,0L,1L,1L,1L,3L,1L,2L,2L,1L,1L,0L,3L,1L,1L,3L,1L,1L,2L,2L,2L,1L,1L,0L,1L,3L,2L,1L,1L,3L,2L,1L,3L,2L,2L,1L,1L,0L,1L,1L,1L,3L,1L,2L,2L,1L,1L,3L,1L,2L,1L,1L,1L,3L,2L,2L,2L,1L,1L,0L,3L,1L,1L,3L,1L,1L,2L,2L,2L,1L,1L,3L,1L,1L,1L,2L,3L,1L,1L,3L,3L,2L,2L,1L,1L,0L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088205Inst : IEnumerable<long>
{
public static readonly long[] Value=A088205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088205.Bytes);
public long this[int i]=>Value[i];

public static A088205Inst Instance=new A088205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088206
{
public static readonly long[] Value={ 1L,3L,7L,11L,17L,27L,39L,53L,75L,101L,131L,175L,231L,301L,399L,529L,691L,907L,1199L,1557L,2027L,2655L,3447L,4497L,5881L,7669L,10003L,13075L,17049L,22211L,28995L,37781L,49201L,64193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088206Inst : IEnumerable<long>
{
public static readonly long[] Value=A088206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088206.Bytes);
public long this[int i]=>Value[i];

public static A088206Inst Instance=new A088206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088207
{
public static readonly long[] Value={ 0L,2L,7L,14L,24L,37L,52L,70L,90L,113L,139L,167L,198L,232L,268L,307L,348L,392L,439L,488L,540L,594L,651L,711L,773L,838L,906L,976L,1049L,1124L,1202L,1283L,1366L,1452L,1541L,1632L,1726L,1822L,1921L,2023L,2127L,2234L,2343L,2455L,2570L,2687L,2807L,2930L,3055L,3183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088207Inst : IEnumerable<long>
{
public static readonly long[] Value=A088207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088207.Bytes);
public long this[int i]=>Value[i];

public static A088207Inst Instance=new A088207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088208
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,4L,2L,1L,5L,7L,3L,4L,8L,6L,2L,1L,9L,13L,5L,7L,15L,11L,3L,4L,12L,16L,8L,6L,14L,10L,2L,1L,17L,25L,9L,13L,29L,21L,5L,7L,23L,31L,15L,11L,27L,19L,3L,4L,20L,28L,12L,16L,32L,24L,8L,6L,22L,30L,14L,10L,26L,18L,2L,1L,33L,49L,17L,25L,57L,41L,9L,13L,45L,61L,29L,21L,53L,37L,5L,7L,39L,55L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088208Inst : IEnumerable<long>
{
public static readonly long[] Value=A088208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088208.Bytes);
public long this[int i]=>Value[i];

public static A088208Inst Instance=new A088208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088209
{
public static readonly long[] Value={ 1L,3L,7L,14L,28L,53L,99L,181L,327L,584L,1034L,1817L,3173L,5511L,9527L,16402L,28136L,48109L,82023L,139481L,236631L,400588L,676822L,1141489L,1921993L,3231243L,5424679L,9095126L,15230452L,25475429L,42566379L,71052157L,118489383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088209Inst : IEnumerable<long>
{
public static readonly long[] Value=A088209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088209.Bytes);
public long this[int i]=>Value[i];

public static A088209Inst Instance=new A088209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088210
{
public static readonly long[] Value={ 1L,5L,17L,53L,157L,449L,1253L,3433L,9273L,24765L,65529L,172061L,448853L,1164409L,3006157L,7728337L,19794545L,50532469L,128621281L,326513669L,826887693L,2089505841L,5269572021L,13265211961L,33336792745L,83648953133L,209591807177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088210Inst : IEnumerable<long>
{
public static readonly long[] Value=A088210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088210.Bytes);
public long this[int i]=>Value[i];

public static A088210Inst Instance=new A088210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088211
{
public static readonly long[] Value={ 1L,2L,7L,22L,65L,186L,519L,1422L,3841L,10258L,27143L,71270L,185921L,482314L,1245191L,3201182L,8199169L,20931234L,53276679L,135246390L,342508097L,865501658L,2182728199L,5494630702L,13808551681L,34648530866L,86815769095L,217237177222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088211Inst : IEnumerable<long>
{
public static readonly long[] Value=A088211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088211.Bytes);
public long this[int i]=>Value[i];

public static A088211Inst Instance=new A088211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088244
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,8L,15L,15L,24L,40L,45L,45L,66L,66L,72L,84L,112L,112L,153L,153L,171L,190L,200L,200L,253L,253L,264L,336L,364L,364L,405L,405L,480L,512L,528L,528L,630L,630L,648L,684L,741L,741L,800L,800L,840L,924L,946L,946L,1081L,1081L,1104L,1152L,1200L,1200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088244Inst : IEnumerable<long>
{
public static readonly long[] Value=A088244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088244.Bytes);
public long this[int i]=>Value[i];

public static A088244Inst Instance=new A088244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088245
{
public static readonly long[] Value={ 4L,5L,5L,9L,4L,5L,3L,2L,6L,3L,9L,0L,5L,1L,9L,9L,7L,1L,4L,9L,7L,4L,5L,7L,5L,8L,4L,4L,4L,3L,7L,7L,4L,3L,7L,5L,0L,6L,9L,6L,1L,4L,4L,8L,6L,0L,2L,5L,1L,0L,9L,4L,6L,9L,8L,0L,5L,2L,4L,0L,6L,4L,3L,5L,2L,3L,7L,7L,9L,0L,4L,4L,3L,3L,0L,0L,5L,9L,4L,8L,5L,3L,6L,0L,4L,4L,1L,7L,3L,2L,6L,6L,5L,2L,9L,8L,2L,6L,9L,2L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088245Inst : IEnumerable<long>
{
public static readonly long[] Value=A088245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088245.Bytes);
public long this[int i]=>Value[i];

public static A088245Inst Instance=new A088245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088246
{
public static readonly long[] Value={ 1L,0L,6L,3L,8L,7L,2L,4L,2L,8L,2L,4L,4L,5L,4L,6L,6L,0L,0L,1L,6L,0L,7L,3L,4L,3L,6L,3L,7L,0L,2L,1L,4L,0L,2L,0L,8L,4L,9L,5L,7L,6L,7L,1L,3L,4L,0L,5L,8L,5L,8L,8L,7L,6L,2L,8L,7L,8L,8L,9L,4L,8L,3L,4L,8L,8L,8L,8L,1L,7L,7L,7L,0L,1L,0L,3L,4L,7L,2L,1L,3L,2L,5L,0L,7L,6L,9L,7L,3L,7L,6L,2L,1L,9L,0L,2L,9L,2L,9L,4L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088246Inst : IEnumerable<long>
{
public static readonly long[] Value=A088246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088246.Bytes);
public long this[int i]=>Value[i];

public static A088246Inst Instance=new A088246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088247
{
public static readonly long[] Value={ 16L,27L,32L,64L,81L,125L,128L,243L,256L,343L,512L,625L,729L,1024L,1331L,2048L,2187L,2197L,2401L,3125L,4096L,4913L,6561L,6859L,8192L,12167L,14641L,15625L,16384L,16807L,19683L,24389L,28561L,29791L,32768L,50653L,59049L,65536L,68921L,78125L,79507L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088247Inst : IEnumerable<long>
{
public static readonly long[] Value=A088247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088247.Bytes);
public long this[int i]=>Value[i];

public static A088247Inst Instance=new A088247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088248
{
public static readonly long[] Value={ 27L,64L,81L,125L,243L,256L,343L,512L,625L,729L,1024L,1331L,2187L,2197L,2401L,3125L,4096L,4913L,6561L,6859L,12167L,14641L,15625L,16384L,16807L,19683L,24389L,28561L,29791L,32768L,50653L,59049L,65536L,68921L,78125L,79507L,83521L,103823L,117649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088248Inst : IEnumerable<long>
{
public static readonly long[] Value=A088248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088248.Bytes);
public long this[int i]=>Value[i];

public static A088248Inst Instance=new A088248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088249
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,131L,17471L,191L,0L,0L,313L,373L,0L,0L,0L,0L,0L,0L,0L,71317L,73037L,797L,0L,0L,97379L,101L,10301L,1074701L,1092901L,11311L,12721L,131L,1371731L,13931L,1490941L,151L,1572751L,16361L,1670761L,1730371L,17971L,181L,191L,19391L,1970791L,19991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088249Inst : IEnumerable<long>
{
public static readonly long[] Value=A088249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088249.Bytes);
public long this[int i]=>Value[i];

public static A088249Inst Instance=new A088249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088250
{
public static readonly ulong[] Value={ 1L,1L,2L,330L,10830L,25410L,512820L,512820L,12960606120L,434491727670L,1893245380950L,71023095613470L,878232256181280L,11429352906540438870UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088250Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A088250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088250.Bytes);
public ulong this[int i]=>Value[i];

public static A088250Inst Instance=new A088250Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088251
{
public static readonly long[] Value={ 2L,2L,3L,331L,10831L,25411L,512821L,512821L,12960606121L,434491727671L,1893245380951L,71023095613471L,878232256181281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088251Inst : IEnumerable<long>
{
public static readonly long[] Value=A088251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088251.Bytes);
public long this[int i]=>Value[i];

public static A088251Inst Instance=new A088251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088252
{
public static readonly long[] Value={ 2L,3L,7L,1321L,54151L,152461L,3589741L,4102561L,116645455081L,4344917276701L,20825699190451L,852277147361641L,11417019330356641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088252Inst : IEnumerable<long>
{
public static readonly long[] Value=A088252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088252.Bytes);
public long this[int i]=>Value[i];

public static A088252Inst Instance=new A088252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088253
{
public static readonly long[] Value={ 2L,13L,0L,15913L,38131823L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088253Inst : IEnumerable<long>
{
public static readonly long[] Value=A088253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088253.Bytes);
public long this[int i]=>Value[i];

public static A088253Inst Instance=new A088253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088254
{
public static readonly long[] Value={ 2L,3L,5L,11L,13L,17L,19L,29L,37L,41L,43L,53L,59L,71L,73L,97L,101L,107L,109L,127L,137L,149L,167L,179L,191L,193L,197L,227L,233L,239L,269L,281L,311L,331L,347L,349L,419L,431L,439L,461L,463L,467L,509L,521L,569L,599L,617L,641L,647L,659L,739L,757L,769L,809L,821L,827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088254Inst : IEnumerable<long>
{
public static readonly long[] Value=A088254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088254.Bytes);
public long this[int i]=>Value[i];

public static A088254Inst Instance=new A088254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088255
{
public static readonly long[] Value={ 4L,6L,30L,420L,2310L,43890L,1138830L,17160990L,300690390L,17100553470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088255Inst : IEnumerable<long>
{
public static readonly long[] Value=A088255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088255.Bytes);
public long this[int i]=>Value[i];

public static A088255Inst Instance=new A088255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088256
{
public static readonly long[] Value={ 6L,30L,2310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088256Inst : IEnumerable<long>
{
public static readonly long[] Value=A088256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088256.Bytes);
public long this[int i]=>Value[i];

public static A088256Inst Instance=new A088256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088257
{
public static readonly BigInteger[] Value={ 1L,2L,6L,30L,210L,2310L,30030L,200560490130L,304250263527210L,BigInteger.Parse("23768741896345550770650537601358310") };
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
public class A088257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088257Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088257.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A088257.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088257Inst Instance=new A088257Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088258
{
public static readonly BigInteger[] Value={ 1L,2L,6L,24L,720L,5040L,39916800L,479001600L,87178291200L,BigInteger.Parse("10888869450418352160768000000"),BigInteger.Parse("265252859812191058636308480000000"),BigInteger.Parse("263130836933693530167218012160000000") };
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
public class A088258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088258Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088258.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A088258.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088258Inst Instance=new A088258Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088259
{
public static readonly long[] Value={ 1L,4L,8L,16L,32L,36L,100L,128L,196L,256L,400L,576L,676L,1296L,1600L,2916L,3136L,4356L,5476L,7056L,8100L,8192L,8836L,12100L,13456L,14400L,15376L,15876L,16900L,17956L,21316L,22500L,24336L,25600L,28900L,30976L,32400L,33856L,41616L,42436L,44100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088259Inst : IEnumerable<long>
{
public static readonly long[] Value=A088259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088259.Bytes);
public long this[int i]=>Value[i];

public static A088259Inst Instance=new A088259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088292
{
public static readonly long[] Value={ 11L,101L,1427L,10067L,100517L,1000427L,10000247L,100001147L,1000000427L,10000001057L,100000000427L,1000000002227L,10000000002227L,100000000000067L,1000000000011227L,10000000000002137L,100000000000000337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088292Inst : IEnumerable<long>
{
public static readonly long[] Value=A088292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088292.Bytes);
public long this[int i]=>Value[i];

public static A088292Inst Instance=new A088292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088293
{
public static readonly BigInteger[] Value={ 11L,167L,1427L,12227L,111227L,11117213L,11111117L,1111111411L,11111111917L,111111118319L,1111111111717L,11111111132923L,111111111114823L,1111111111113823L,11111111111111923L,111111111111112319L,1111111111111116223L,11111111111111121119UL,BigInteger.Parse("111111111111111111523") };
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
public class A088293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088293Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088293.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A088293.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088293Inst Instance=new A088293Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088294
{
public static readonly long[] Value={ 199L,313L,919L,7321L,7963L,11717L,11777L,12323L,13339L,14747L,15959L,16363L,17117L,17351L,18181L,18787L,21121L,23369L,27127L,29129L,29387L,31393L,31751L,31957L,32369L,32987L,39139L,41141L,47147L,51151L,59159L,71171L,81181L,87187L,89189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088294Inst : IEnumerable<long>
{
public static readonly long[] Value=A088294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088294.Bytes);
public long this[int i]=>Value[i];

public static A088294Inst Instance=new A088294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088295
{
public static readonly long[] Value={ 11L,199L,3319L,11177L,111919L,1111339L,11133119L,111111199L,1111111919L,11111113319L,1111111139381L,1111111111177L,11111111113139L,111111111113113L,1111111111113319L,11111111311111319L,111111111311111113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088295Inst : IEnumerable<long>
{
public static readonly long[] Value=A088295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088295.Bytes);
public long this[int i]=>Value[i];

public static A088295Inst Instance=new A088295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088296
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,5L,1L,5L,7L,4L,5L,7L,2L,1L,7L,4L,11L,8L,7L,2L,11L,13L,5L,7L,14L,1L,5L,7L,16L,13L,1L,5L,14L,4L,13L,8L,1L,7L,19L,2L,13L,10L,20L,19L,11L,8L,17L,1L,16L,11L,23L,20L,10L,17L,1L,7L,11L,13L,8L,22L,5L,7L,16L,11L,26L,2L,25L,19L,5L,7L,23L,13L,25L,8L,19L,1L,26L,20L,17L,10L,19L,14L,5L,7L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088296Inst : IEnumerable<long>
{
public static readonly long[] Value=A088296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088296.Bytes);
public long this[int i]=>Value[i];

public static A088296Inst Instance=new A088296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088297
{
public static readonly long[] Value={ 2L,3L,5L,7L,263L,269L,463L,863L,2269L,2633L,2663L,2693L,2699L,4463L,4639L,4663L,6263L,6269L,6469L,6863L,6869L,8263L,8269L,8663L,8669L,8693L,8699L,8863L,22469L,22639L,22669L,22699L,24469L,26263L,26339L,26393L,26399L,26633L,26669L,26693L,26699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088297Inst : IEnumerable<long>
{
public static readonly long[] Value=A088297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088297.Bytes);
public long this[int i]=>Value[i];

public static A088297Inst Instance=new A088297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088298
{
public static readonly long[] Value={ 4L,5L,7L,7L,10L,8L,13L,11L,10L,13L,14L,13L,17L,19L,16L,19L,14L,17L,19L,23L,17L,16L,23L,22L,17L,28L,26L,25L,19L,22L,31L,29L,23L,31L,25L,29L,34L,31L,22L,35L,28L,31L,23L,25L,32L,35L,29L,40L,31L,35L,26L,29L,37L,32L,43L,40L,38L,37L,41L,31L,44L,43L,37L,41L,29L,47L,31L,37L,47L,46L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088298Inst : IEnumerable<long>
{
public static readonly long[] Value=A088298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088298.Bytes);
public long this[int i]=>Value[i];

public static A088298Inst Instance=new A088298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088299
{
public static readonly long[] Value={ 5L,7L,8L,11L,11L,13L,14L,16L,17L,17L,19L,20L,19L,20L,23L,23L,25L,25L,26L,25L,28L,29L,28L,29L,31L,29L,31L,32L,35L,35L,32L,34L,37L,35L,38L,37L,35L,38L,41L,37L,41L,41L,43L,44L,43L,43L,46L,41L,47L,46L,49L,49L,47L,49L,44L,47L,49L,50L,49L,53L,49L,50L,53L,52L,55L,49L,56L,56L,52L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088299Inst : IEnumerable<long>
{
public static readonly long[] Value=A088299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088299.Bytes);
public long this[int i]=>Value[i];

public static A088299Inst Instance=new A088299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088300
{
public static readonly long[] Value={ 1L,3L,10L,40L,168L,1008L,7920L,63360L,570240L,5702400L,47174400L,566092800L,8143027200L,114002380800L,1710035712000L,27360571392000L,397533007872000L,7155594141696000L,147254595231744000L,2945091904634880000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088300Inst : IEnumerable<long>
{
public static readonly long[] Value=A088300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088300.Bytes);
public long this[int i]=>Value[i];

public static A088300Inst Instance=new A088300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088301
{
public static readonly long[] Value={ 1L,2L,4L,48L,90L,12L,3360L,18L,9240L,15600L,756L,31680L,42840L,59280L,1848L,99360L,6497400L,2970L,185136L,234360L,18670080L,347760L,421800L,480480L,557928L,55965360L,70073640L,857280L,98960400L,1157520L,11880L,162983520L,190578024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088301Inst : IEnumerable<long>
{
public static readonly long[] Value=A088301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088301.Bytes);
public long this[int i]=>Value[i];

public static A088301Inst Instance=new A088301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088302
{
public static readonly long[] Value={ 1L,3L,2L,10L,60L,420L,28L,252L,2520L,27720L,66L,858L,12012L,180180L,2882880L,49008960L,882161280L,16761064320L,8398L,176358L,3879876L,89237148L,2141691552L,53542288800L,1392099508800L,37586686737600L,1052427228652800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088302Inst : IEnumerable<long>
{
public static readonly long[] Value=A088302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088302.Bytes);
public long this[int i]=>Value[i];

public static A088302Inst Instance=new A088302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088303
{
public static readonly long[] Value={ 1L,2L,3L,4L,10L,6L,420L,56L,63L,120L,1155L,792L,180180L,121080960L,5405400L,5765760L,14294280L,10585935360L,969969L,221707200L,219988969200L,853572720L,206137811880L,25700298624L,368103235500L,306261891936000L,9302704967556000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088303Inst : IEnumerable<long>
{
public static readonly long[] Value=A088303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088303.Bytes);
public long this[int i]=>Value[i];

public static A088303Inst Instance=new A088303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088304
{
public static readonly long[] Value={ 1L,1L,1L,4L,4L,24L,24L,3L,27L,270L,270L,3240L,3240L,45360L,3024L,189L,189L,3402L,3402L,68040L,3240L,71280L,71280L,2970L,74250L,1930500L,71500L,2002000L,2002000L,60060000L,60060000L,1876875L,56875L,1933750L,55250L,1989000L,1989000L,75582000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088304Inst : IEnumerable<long>
{
public static readonly long[] Value=A088304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088304.Bytes);
public long this[int i]=>Value[i];

public static A088304Inst Instance=new A088304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088305
{
public static readonly long[] Value={ 1L,1L,3L,8L,21L,55L,144L,377L,987L,2584L,6765L,17711L,46368L,121393L,317811L,832040L,2178309L,5702887L,14930352L,39088169L,102334155L,267914296L,701408733L,1836311903L,4807526976L,12586269025L,32951280099L,86267571272L,225851433717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088305Inst : IEnumerable<long>
{
public static readonly long[] Value=A088305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088305.Bytes);
public long this[int i]=>Value[i];

public static A088305Inst Instance=new A088305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088306
{
public static readonly long[] Value={ 1L,-2L,-11L,-33L,-52174L,260515L,-573204L,37362253L,-42781604L,122925461L,534483448L,3083975227L,902209779836L,-2685575996367L,-65398140378926L,74357078147863L,214112296674652L,642336890023956L,-5920787228742393L,-12055686754159438L,18190586279576483L,-48436859313312404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088306Inst : IEnumerable<long>
{
public static readonly long[] Value=A088306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088306.Bytes);
public long this[int i]=>Value[i];

public static A088306Inst Instance=new A088306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088307
{
public static readonly long[] Value={ 0L,5L,0L,10L,13L,0L,17L,0L,25L,0L,26L,29L,34L,41L,0L,37L,0L,0L,0L,61L,0L,50L,53L,58L,65L,74L,85L,0L,65L,0L,73L,0L,89L,0L,113L,0L,82L,85L,0L,97L,106L,0L,130L,145L,0L,101L,0L,109L,0L,0L,0L,149L,0L,181L,0L,122L,125L,130L,137L,146L,157L,170L,185L,202L,221L,0L,145L,0L,0L,0L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088307Inst : IEnumerable<long>
{
public static readonly long[] Value=A088307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088307.Bytes);
public long this[int i]=>Value[i];

public static A088307Inst Instance=new A088307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088340
{
public static readonly long[] Value={ 0L,2L,3L,7L,8L,10L,11L,13L,16L,17L,18L,20L,21L,23L,25L,27L,29L,31L,34L,35L,36L,39L,40L,41L,44L,46L,48L,49L,50L,52L,53L,59L,60L,62L,63L,69L,70L,71L,72L,76L,77L,78L,79L,82L,84L,86L,88L,89L,90L,92L,93L,99L,100L,101L,104L,105L,107L,108L,110L,111L,114L,115L,116L,118L,124L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088340Inst : IEnumerable<long>
{
public static readonly long[] Value=A088340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088340.Bytes);
public long this[int i]=>Value[i];

public static A088340Inst Instance=new A088340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088341
{
public static readonly long[] Value={ 0L,1L,18L,21L,28L,38L,42L,45L,46L,49L,51L,52L,56L,58L,62L,69L,74L,77L,79L,81L,82L,83L,86L,88L,93L,101L,103L,104L,107L,110L,113L,125L,128L,136L,140L,147L,158L,159L,164L,165L,173L,178L,180L,190L,193L,195L,196L,197L,198L,200L,203L,206L,210L,217L,218L,231L,233L,238L,241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088341Inst : IEnumerable<long>
{
public static readonly long[] Value=A088341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088341.Bytes);
public long this[int i]=>Value[i];

public static A088341Inst Instance=new A088341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088342
{
public static readonly BigInteger[] Value={ 1L,3L,14L,93L,837L,9742L,140449L,2420297L,48506250L,1107465929L,28354713349L,804166591614L,25016362993529L,846770894729841L,30978110173770106L,1217913727100939785L,BigInteger.Parse("51206137142679936933"),BigInteger.Parse("2292551430448659630790"),BigInteger.Parse("108888041255668778897857"),BigInteger.Parse("5468436908124359403377993") };
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
public class A088342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088342Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088342.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A088342.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088342Inst Instance=new A088342Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088343
{
public static readonly long[] Value={ 1L,2L,5L,9L,10L,22L,25L,26L,110L,998L,1158L,1410L,9860L,100270L,999100L,1005274L,1007044L,1055274L,1059163L,1063242L,1065027L,1083148L,1099446L,1103722L,1144506L,10146315L,99992456L,99997120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088343Inst : IEnumerable<long>
{
public static readonly long[] Value=A088343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088343.Bytes);
public long this[int i]=>Value[i];

public static A088343Inst Instance=new A088343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088344
{
public static readonly long[] Value={ 39L,27L,81L,24L,37L,29L,21L,87L,65L,61L,19L,68L,35L,90L,49L,17L,71L,47L,53L,14L,41L,15L,94L,32L,34L,78L,29L,69L,14L,34L,89L,7L,43L,4L,67L,21L,12L,91L,40L,16L,33L,87L,42L,4L,89L,11L,62L,26L,14L,67L,34L,86L,78L,44L,1L,10L,46L,3L,53L,20L,33L,13L,81L,5L,96L,9L,94L,14L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088344Inst : IEnumerable<long>
{
public static readonly long[] Value=A088344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088344.Bytes);
public long this[int i]=>Value[i];

public static A088344Inst Instance=new A088344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088345
{
public static readonly long[] Value={ 6L,12L,18L,28L,45L,48L,56L,72L,80L,96L,117L,196L,396L,475L,496L,702L,704L,775L,992L,1100L,1326L,1568L,1792L,2009L,2150L,2622L,2952L,3042L,3321L,3672L,4140L,5328L,5852L,6750L,6860L,7154L,7605L,7680L,8128L,9102L,10575L,11008L,12126L,12168L,12384L,12810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088345Inst : IEnumerable<long>
{
public static readonly long[] Value=A088345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088345.Bytes);
public long this[int i]=>Value[i];

public static A088345Inst Instance=new A088345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088346
{
public static readonly long[] Value={ 5L,9L,13L,17L,22L,27L,31L,36L,41L,46L,52L,57L,62L,68L,73L,79L,85L,90L,96L,102L,108L,114L,120L,126L,132L,138L,145L,151L,157L,164L,170L,176L,183L,189L,196L,202L,209L,215L,222L,229L,235L,242L,249L,255L,262L,269L,276L,283L,289L,296L,303L,310L,317L,324L,331L,338L,345L,352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088346Inst : IEnumerable<long>
{
public static readonly long[] Value=A088346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088346.Bytes);
public long this[int i]=>Value[i];

public static A088346Inst Instance=new A088346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088347
{
public static readonly long[] Value={ 2L,1L,1L,5L,1L,1L,1L,9L,1L,1L,12L,1L,1L,15L,1L,1L,1L,19L,1L,1L,22L,1L,1L,1L,26L,1L,1L,29L,1L,1L,32L,1L,1L,1L,36L,1L,1L,39L,1L,1L,1L,43L,1L,1L,46L,1L,1L,1L,50L,1L,1L,53L,1L,1L,56L,1L,1L,1L,60L,1L,1L,63L,1L,1L,1L,67L,1L,1L,70L,1L,1L,73L,1L,1L,1L,77L,1L,1L,80L,1L,1L,1L,84L,1L,1L,87L,1L,1L,90L,1L,1L,1L,94L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088347Inst : IEnumerable<long>
{
public static readonly long[] Value=A088347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088347.Bytes);
public long this[int i]=>Value[i];

public static A088347Inst Instance=new A088347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088348
{
public static readonly long[] Value={ 2L,5L,11L,17L,19L,31L,37L,41L,47L,53L,59L,73L,83L,89L,101L,107L,149L,173L,181L,191L,197L,227L,241L,257L,263L,269L,283L,311L,347L,349L,353L,409L,421L,431L,439L,463L,479L,503L,509L,547L,571L,599L,617L,631L,643L,659L,677L,691L,701L,719L,733L,743L,751L,761L,821L,839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088348Inst : IEnumerable<long>
{
public static readonly long[] Value=A088348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088348.Bytes);
public long this[int i]=>Value[i];

public static A088348Inst Instance=new A088348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088349
{
public static readonly long[] Value={ 5L,29L,173L,245L,365L,749L,1037L,1469L,2189L,3413L,3773L,4469L,5117L,6005L,6221L,7661L,8813L,8957L,9005L,11117L,13133L,14837L,18029L,20477L,20981L,22133L,22613L,22781L,26813L,29525L,29693L,30197L,30701L,31349L,31469L,36029L,37325L,40277L,45245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088349Inst : IEnumerable<long>
{
public static readonly long[] Value=A088349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088349.Bytes);
public long this[int i]=>Value[i];

public static A088349Inst Instance=new A088349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088350
{
public static readonly long[] Value={ 0L,1L,7L,10L,15L,31L,43L,61L,91L,142L,157L,186L,213L,250L,259L,319L,367L,373L,375L,463L,547L,618L,751L,853L,874L,922L,942L,949L,1117L,1230L,1237L,1258L,1279L,1306L,1311L,1501L,1555L,1678L,1885L,1887L,1914L,1959L,2203L,2238L,2251L,2446L,2554L,2623L,2650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088350Inst : IEnumerable<long>
{
public static readonly long[] Value=A088350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088350.Bytes);
public long this[int i]=>Value[i];

public static A088350Inst Instance=new A088350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088351
{
public static readonly BigInteger[] Value={ 1L,1L,-2L,10L,-80L,1000L,-21872L,977584L,-96293648L,20624493808L,-9328274380160L,8744603171127040L,BigInteger.Parse("-16802076392609925440"),BigInteger.Parse("65695424926762378460992"),BigInteger.Parse("-520141011157056880989068672") };
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
public class A088351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088351Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088351.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A088351.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088351Inst Instance=new A088351Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088352
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,9L,16L,28L,50L,89L,158L,282L,503L,896L,1598L,2850L,5082L,9064L,16166L,28832L,51424L,91719L,163588L,291774L,520407L,928196L,1655530L,2952805L,5266626L,9393565L,16754386L,29883166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088352Inst : IEnumerable<long>
{
public static readonly long[] Value=A088352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088352.Bytes);
public long this[int i]=>Value[i];

public static A088352Inst Instance=new A088352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088353
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,13L,24L,45L,84L,157L,293L,548L,1025L,1917L,3585L,6705L,12542L,23460L,43882L,82081L,153535L,287193L,537205L,1004861L,1879631L,3515926L,6576683L,12301953L,23011306L,43043596L,80514826L,150606312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088353Inst : IEnumerable<long>
{
public static readonly long[] Value=A088353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088353.Bytes);
public long this[int i]=>Value[i];

public static A088353Inst Instance=new A088353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088354
{
public static readonly long[] Value={ 1L,2L,4L,10L,24L,60L,150L,376L,944L,2372L,5962L,14988L,37684L,94752L,238252L,599090L,1506440L,3788036L,9525280L,23952020L,60229184L,151450970L,380835368L,957640640L,2408063340L,6055266600L,15226449480L,38288118984L,96278523274L,242100012876L,608779761460L,1530825191912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088354Inst : IEnumerable<long>
{
public static readonly long[] Value=A088354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088354.Bytes);
public long this[int i]=>Value[i];

public static A088354Inst Instance=new A088354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088355
{
public static readonly long[] Value={ 1L,2L,5L,14L,41L,122L,366L,1103L,3332L,10078L,30503L,92360L,279722L,847283L,2566640L,7775383L,23555412L,71361969L,216195801L,654983362L,1984334264L,6011741892L,18213205238L,55178866432L,167170395758L,506461095121L,1534379837420L,4648573702811L,14083369899731L,42667133594949L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088355Inst : IEnumerable<long>
{
public static readonly long[] Value=A088355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088355.Bytes);
public long this[int i]=>Value[i];

public static A088355Inst Instance=new A088355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088532
{
public static readonly long[] Value={ 1L,2L,4L,8L,15L,28L,55L,109L,226L,452L,935L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088532Inst : IEnumerable<long>
{
public static readonly long[] Value=A088532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088532.Bytes);
public long this[int i]=>Value[i];

public static A088532Inst Instance=new A088532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088533
{
public static readonly long[] Value={ 2L,3L,4L,7L,15L,22L,24L,40L,49L,58L,71L,74L,92L,124L,179L,183L,232L,237L,413L,542L,547L,731L,752L,758L,983L,1266L,1283L,1289L,1336L,1706L,1712L,1725L,2656L,2909L,3509L,3612L,3653L,3674L,3702L,3709L,4617L,4646L,4697L,5993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088533Inst : IEnumerable<long>
{
public static readonly long[] Value=A088533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088533.Bytes);
public long this[int i]=>Value[i];

public static A088533Inst Instance=new A088533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088534
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,2L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,2L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088534Inst : IEnumerable<long>
{
public static readonly long[] Value=A088534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088534.Bytes);
public long this[int i]=>Value[i];

public static A088534Inst Instance=new A088534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088535
{
public static readonly long[] Value={ 49L,147L,169L,196L,361L,441L,507L,588L,637L,676L,784L,931L,961L,1083L,1183L,1225L,1323L,1369L,1444L,1519L,1521L,1764L,1813L,1849L,1911L,2028L,2107L,2352L,2527L,2548L,2704L,2793L,2883L,2989L,3136L,3211L,3249L,3283L,3549L,3577L,3675L,3721L,3724L,3844L,3871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088535Inst : IEnumerable<long>
{
public static readonly long[] Value=A088535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088535.Bytes);
public long this[int i]=>Value[i];

public static A088535Inst Instance=new A088535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088536
{
public static readonly long[] Value={ 1L,4L,22L,130L,791L,4900L,30738L,194634L,1241383L,7963384L,51325352L,332095816L,2155894508L,14035149748L,91593941402L,599021799242L,3924954250975L,25760310654100L,169322682857430L,1114452091832130L,7344021912458295L,48448974411575280L,319942093205166840L,2114743632331515480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088536Inst : IEnumerable<long>
{
public static readonly long[] Value=A088536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088536.Bytes);
public long this[int i]=>Value[i];

public static A088536Inst Instance=new A088536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088537
{
public static readonly long[] Value={ 1L,6L,1L,5L,5L,4L,2L,6L,2L,6L,7L,1L,2L,8L,2L,4L,7L,2L,3L,8L,6L,7L,9L,2L,3L,3L,3L,2L,7L,5L,8L,6L,1L,8L,0L,9L,0L,1L,9L,6L,4L,2L,2L,9L,2L,3L,6L,1L,3L,7L,7L,7L,1L,4L,5L,6L,9L,3L,7L,3L,5L,3L,5L,9L,6L,1L,2L,6L,5L,1L,2L,3L,1L,6L,1L,5L,3L,3L,3L,6L,2L,9L,0L,4L,1L,6L,5L,8L,9L,5L,5L,1L,7L,1L,8L,7L,2L,1L,4L,5L,5L,7L,4L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088537Inst : IEnumerable<long>
{
public static readonly long[] Value=A088537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088537.Bytes);
public long this[int i]=>Value[i];

public static A088537Inst Instance=new A088537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088538
{
public static readonly long[] Value={ 1L,2L,7L,3L,2L,3L,9L,5L,4L,4L,7L,3L,5L,1L,6L,2L,6L,8L,6L,1L,5L,1L,0L,7L,0L,1L,0L,6L,9L,8L,0L,1L,1L,4L,8L,9L,6L,2L,7L,5L,6L,7L,7L,1L,6L,5L,9L,2L,3L,6L,5L,1L,5L,8L,9L,9L,8L,1L,3L,3L,8L,7L,5L,2L,4L,7L,1L,1L,7L,4L,3L,8L,1L,0L,7L,3L,8L,1L,2L,2L,8L,0L,7L,2L,0L,9L,1L,0L,4L,2L,2L,1L,3L,0L,0L,2L,4L,6L,8L,7L,6L,4L,8L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088538Inst : IEnumerable<long>
{
public static readonly long[] Value=A088538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088538.Bytes);
public long this[int i]=>Value[i];

public static A088538Inst Instance=new A088538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088539
{
public static readonly long[] Value={ 9L,4L,6L,8L,0L,6L,4L,0L,7L,1L,8L,0L,0L,7L,9L,3L,3L,4L,2L,1L,6L,0L,9L,4L,4L,1L,3L,1L,0L,9L,7L,5L,6L,2L,3L,3L,2L,5L,0L,0L,6L,9L,5L,0L,2L,6L,4L,7L,1L,6L,5L,3L,1L,2L,1L,8L,1L,9L,7L,9L,5L,6L,5L,5L,3L,5L,8L,2L,0L,1L,0L,6L,6L,3L,9L,3L,6L,3L,7L,9L,2L,8L,1L,3L,9L,8L,9L,1L,3L,3L,0L,0L,4L,9L,9L,6L,2L,6L,0L,5L,2L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088539Inst : IEnumerable<long>
{
public static readonly long[] Value=A088539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088539.Bytes);
public long this[int i]=>Value[i];

public static A088539Inst Instance=new A088539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088540
{
public static readonly long[] Value={ 1L,2L,9L,2L,3L,0L,4L,1L,5L,7L,1L,2L,8L,6L,8L,8L,6L,0L,7L,1L,0L,9L,1L,3L,8L,3L,8L,9L,8L,7L,0L,4L,3L,2L,0L,6L,5L,3L,4L,2L,9L,6L,1L,4L,2L,5L,0L,1L,2L,9L,9L,7L,2L,4L,1L,2L,2L,7L,6L,2L,9L,2L,3L,1L,6L,1L,9L,5L,0L,0L,0L,5L,5L,2L,8L,2L,3L,2L,0L,7L,9L,4L,2L,7L,3L,0L,3L,0L,7L,5L,9L,7L,5L,5L,2L,4L,4L,9L,9L,4L,1L,6L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088540Inst : IEnumerable<long>
{
public static readonly long[] Value=A088540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088540.Bytes);
public long this[int i]=>Value[i];

public static A088540Inst Instance=new A088540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088541
{
public static readonly long[] Value={ 8L,6L,8L,9L,2L,7L,7L,6L,8L,2L,3L,4L,3L,2L,3L,8L,2L,9L,9L,0L,9L,1L,5L,2L,7L,7L,9L,1L,0L,4L,6L,5L,2L,9L,1L,2L,2L,9L,3L,9L,4L,1L,2L,8L,7L,6L,2L,2L,7L,4L,9L,2L,1L,7L,7L,4L,9L,1L,0L,1L,1L,6L,0L,2L,6L,9L,5L,4L,1L,9L,6L,6L,3L,5L,7L,4L,9L,8L,1L,2L,3L,7L,9L,7L,7L,3L,2L,5L,3L,6L,8L,6L,4L,1L,8L,0L,6L,3L,1L,7L,7L,2L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088541Inst : IEnumerable<long>
{
public static readonly long[] Value=A088541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088541.Bytes);
public long this[int i]=>Value[i];

public static A088541Inst Instance=new A088541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088542
{
public static readonly long[] Value={ 2L,3L,7L,71L,179L,547L,983L,1283L,1289L,2909L,3709L,20269L,40829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088542Inst : IEnumerable<long>
{
public static readonly long[] Value=A088542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088542.Bytes);
public long this[int i]=>Value[i];

public static A088542Inst Instance=new A088542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088543
{
public static readonly long[] Value={ 1L,9L,3L,6L,4L,9L,1L,6L,7L,3L,1L,0L,3L,7L,0L,8L,4L,4L,2L,5L,8L,9L,6L,3L,2L,6L,9L,9L,8L,9L,1L,1L,9L,9L,8L,0L,5L,4L,1L,6L,4L,6L,0L,8L,5L,2L,6L,4L,5L,7L,9L,5L,4L,1L,3L,2L,9L,3L,7L,8L,6L,8L,8L,3L,0L,5L,6L,7L,4L,1L,5L,4L,5L,9L,6L,8L,4L,8L,9L,5L,1L,6L,7L,5L,9L,6L,4L,3L,6L,8L,8L,4L,2L,9L,3L,3L,6L,7L,5L,8L,9L,5L,8L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088543Inst : IEnumerable<long>
{
public static readonly long[] Value=A088543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088543.Bytes);
public long this[int i]=>Value[i];

public static A088543Inst Instance=new A088543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088544
{
public static readonly long[] Value={ 37L,229L,409L,793L,1261L,2041L,1789L,4381L,5233L,4069L,8317L,6073L,14449L,7969L,12181L,9997L,11041L,23473L,14089L,24457L,17341L,36181L,20773L,53461L,29341L,44269L,28009L,38509L,76297L,35869L,44257L,74209L,42841L,105769L,50137L,65701L,53209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088544Inst : IEnumerable<long>
{
public static readonly long[] Value=A088544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088544.Bytes);
public long this[int i]=>Value[i];

public static A088544Inst Instance=new A088544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088545
{
public static readonly long[] Value={ 1L,11L,61L,451L,3001L,20801L,141961L,974611L,6675901L,45768251L,313671601L,2150012161L,14736206161L,101003973851L,692290189501L,4745031073651L,32522917584361L,222915417520961L,1527884938291801L,10472279325329251L,71778069881360701L,491974211042344811L,3372041404278257761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088545Inst : IEnumerable<long>
{
public static readonly long[] Value=A088545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088545.Bytes);
public long this[int i]=>Value[i];

public static A088545Inst Instance=new A088545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088546
{
public static readonly long[] Value={ 7L,17L,23L,31L,47L,41L,49L,71L,73L,79L,89L,97L,113L,103L,119L,119L,127L,137L,151L,161L,161L,167L,191L,199L,193L,217L,217L,233L,223L,241L,263L,271L,257L,239L,281L,287L,287L,313L,289L,329L,329L,343L,311L,353L,367L,337L,359L,383L,409L,391L,401L,391L,433L,439L,463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088546Inst : IEnumerable<long>
{
public static readonly long[] Value=A088546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088546.Bytes);
public long this[int i]=>Value[i];

public static A088546Inst Instance=new A088546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088547
{
public static readonly long[] Value={ 2L,5L,41L,157L,401L,821L,2381L,3617L,12721L,20441L,25261L,37061L,81401L,169457L,278917L,333341L,462541L,499361L,712981L,1168757L,1455781L,1534217L,1615421L,2163461L,2705081L,3069797L,3198281L,3605141L,4045121L,4357481L,4519517L,4855541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088547Inst : IEnumerable<long>
{
public static readonly long[] Value=A088547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088547.Bytes);
public long this[int i]=>Value[i];

public static A088547Inst Instance=new A088547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088612
{
public static readonly long[] Value={ 1L,8L,9L,5L,16L,18L,20L,11L,13L,27L,28L,17L,36L,40L,44L,23L,48L,29L,50L,31L,54L,56L,60L,37L,38L,68L,41L,42L,76L,80L,81L,51L,88L,90L,92L,58L,98L,99L,100L,65L,108L,112L,116L,70L,71L,121L,124L,77L,78L,79L,132L,83L,136L,86L,144L,89L,148L,150L,152L,95L,156L,160L,102L,103L,168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088612Inst : IEnumerable<long>
{
public static readonly long[] Value=A088612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088612.Bytes);
public long this[int i]=>Value[i];

public static A088612Inst Instance=new A088612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088613
{
public static readonly long[] Value={ 4L,4L,9L,4L,20L,12L,28L,8L,9L,20L,44L,12L,52L,28L,45L,16L,68L,18L,76L,20L,63L,44L,92L,24L,25L,52L,27L,28L,116L,60L,124L,32L,99L,68L,140L,36L,148L,76L,117L,40L,164L,84L,172L,44L,45L,92L,188L,48L,49L,50L,153L,52L,212L,54L,220L,56L,171L,116L,236L,60L,244L,124L,63L,64L,260L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088613Inst : IEnumerable<long>
{
public static readonly long[] Value=A088613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088613.Bytes);
public long this[int i]=>Value[i];

public static A088613Inst Instance=new A088613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088614
{
public static readonly long[] Value={ 2L,9L,3L,27L,11L,51L,13L,33L,41L,93L,31L,99L,29L,63L,1117L,441L,503L,303L,163L,171L,59L,357L,67L,219L,113L,417L,691L,729L,239L,511L,227L,393L,211L,189L,3797L,291L,1789L,549L,419L,501L,103L,81L,3257L,39L,727L,531L,617L,69L,6883L,387L,521L,153L,1237L,287L,3391L,927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088614Inst : IEnumerable<long>
{
public static readonly long[] Value=A088614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088614.Bytes);
public long this[int i]=>Value[i];

public static A088614Inst Instance=new A088614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088615
{
public static readonly BigInteger[] Value={ 2L,29L,293L,29327L,2932711L,293271151L,29327115113L,2932711511333L,293271151133341L,29327115113334193L,2932711511333419331L,BigInteger.Parse("293271151133341933199"),BigInteger.Parse("29327115113334193319929") };
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
public class A088615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088615Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088615.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A088615.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088615Inst Instance=new A088615Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088616
{
public static readonly long[] Value={ 0L,0L,24L,6840L,6568800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088616Inst : IEnumerable<long>
{
public static readonly long[] Value=A088616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088616.Bytes);
public long this[int i]=>Value[i];

public static A088616Inst Instance=new A088616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088617
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,6L,10L,5L,1L,10L,30L,35L,14L,1L,15L,70L,140L,126L,42L,1L,21L,140L,420L,630L,462L,132L,1L,28L,252L,1050L,2310L,2772L,1716L,429L,1L,36L,420L,2310L,6930L,12012L,12012L,6435L,1430L,1L,45L,660L,4620L,18018L,42042L,60060L,51480L,24310L,4862L,1L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088617Inst : IEnumerable<long>
{
public static readonly long[] Value=A088617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088617.Bytes);
public long this[int i]=>Value[i];

public static A088617Inst Instance=new A088617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088618
{
public static readonly long[] Value={ 1L,5L,13L,3L,15L,9L,17L,7L,23L,19L,25L,35L,21L,39L,37L,11L,33L,45L,27L,47L,31L,51L,41L,55L,29L,43L,61L,59L,57L,53L,49L,63L,65L,75L,67L,71L,69L,79L,77L,81L,73L,85L,91L,95L,83L,97L,105L,87L,101L,99L,115L,107L,93L,123L,111L,117L,113L,109L,119L,103L,121L,125L,129L,135L,133L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088618Inst : IEnumerable<long>
{
public static readonly long[] Value=A088618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088618.Bytes);
public long this[int i]=>Value[i];

public static A088618Inst Instance=new A088618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088619
{
public static readonly long[] Value={ 3L,11L,21L,29L,39L,47L,59L,69L,101L,111L,131L,149L,171L,183L,197L,213L,231L,243L,249L,251L,297L,299L,317L,323L,329L,369L,387L,401L,411L,423L,431L,461L,501L,521L,527L,533L,537L,539L,543L,593L,651L,657L,669L,717L,741L,743L,779L,819L,867L,869L,873L,897L,939L,981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088619Inst : IEnumerable<long>
{
public static readonly long[] Value=A088619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088619.Bytes);
public long this[int i]=>Value[i];

public static A088619Inst Instance=new A088619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088620
{
public static readonly long[] Value={ 2L,5L,8L,9L,17L,27L,32L,39L,41L,56L,60L,65L,66L,68L,72L,78L,89L,98L,108L,117L,120L,128L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088620Inst : IEnumerable<long>
{
public static readonly long[] Value=A088620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088620.Bytes);
public long this[int i]=>Value[i];

public static A088620Inst Instance=new A088620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088621
{
public static readonly long[] Value={ 11L,0L,13L,0L,0L,0L,17L,0L,19L,0L,111121L,0L,113L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088621Inst : IEnumerable<long>
{
public static readonly long[] Value=A088621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088621.Bytes);
public long this[int i]=>Value[i];

public static A088621Inst Instance=new A088621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088622
{
public static readonly long[] Value={ 11L,41L,31L,41L,251L,61L,71L,641L,811L,101L,259374246011L,0L,131L,75295361L,151L,40961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088622Inst : IEnumerable<long>
{
public static readonly long[] Value=A088622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088622.Bytes);
public long this[int i]=>Value[i];

public static A088622Inst Instance=new A088622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088623
{
public static readonly BigInteger[] Value={ 11L,0L,13L,0L,0L,0L,17L,0L,19L,0L,114641L,0L,113L,0L,0L,0L,1289L,0L,1361L,0L,BigInteger.Parse("11025506433613486607375777617584133309366191904729927960524981845743709132117581"),0L,BigInteger.Parse("1907846434775996175406740561329"),0L,0L,0L,127L,0L,1500246412961L,0L,131L,0L };
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
public class A088623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088623Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088623.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A088623.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088623Inst Instance=new A088623Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088624
{
public static readonly long[] Value={ 2L,1L,4L,13L,10L,19L,40L,33L,56L,58L,54L,87L,75L,82L,106L,94L,136L,125L,145L,148L,207L,174L,201L,182L,210L,187L,251L,259L,230L,284L,238L,313L,312L,346L,320L,329L,338L,373L,433L,386L,424L,375L,392L,503L,449L,475L,495L,493L,488L,517L,538L,536L,587L,635L,593L,631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088624Inst : IEnumerable<long>
{
public static readonly long[] Value=A088624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088624.Bytes);
public long this[int i]=>Value[i];

public static A088624Inst Instance=new A088624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088625
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,14L,126L,630L,2310L,6930L,18018L,42042L,90090L,180180L,340340L,612612L,1058148L,1763580L,2848860L,4476780L,6864396L,10296594L,15142050L,21871850L,31081050L,43513470L,60090030L,81940950L,110442150L,147256200L,194378184L,254186856L,329501480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088625Inst : IEnumerable<long>
{
public static readonly long[] Value=A088625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088625.Bytes);
public long this[int i]=>Value[i];

public static A088625Inst Instance=new A088625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088626
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,42L,462L,2772L,12012L,42042L,126126L,336336L,816816L,1837836L,3879876L,7759752L,14814072L,27159132L,48050772L,82372752L,137287920L,223092870L,354323970L,551170620L,841260420L,1261890630L,1862790930L,2709514080L,3887563680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088626Inst : IEnumerable<long>
{
public static readonly long[] Value=A088626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088626.Bytes);
public long this[int i]=>Value[i];

public static A088626Inst Instance=new A088626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088627
{
public static readonly long[] Value={ 1L,1L,2L,0L,2L,2L,0L,1L,2L,0L,2L,1L,0L,2L,4L,0L,1L,2L,0L,2L,4L,0L,1L,1L,0L,2L,1L,0L,2L,4L,0L,0L,2L,0L,4L,2L,0L,1L,4L,0L,2L,2L,0L,2L,3L,0L,0L,1L,0L,2L,4L,0L,1L,2L,0L,2L,2L,0L,1L,3L,0L,0L,2L,0L,4L,3L,0L,1L,3L,0L,1L,0L,0L,2L,3L,0L,2L,2L,0L,1L,2L,0L,1L,3L,0L,2L,2L,0L,1L,3L,0L,1L,1L,0L,4L,2L,0L,2L,4L,0L,1L,2L,0L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088627Inst : IEnumerable<long>
{
public static readonly long[] Value=A088627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088627.Bytes);
public long this[int i]=>Value[i];

public static A088627Inst Instance=new A088627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088676
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,3L,3L,3L,4L,4L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,7L,7L,8L,9L,9L,9L,9L,9L,9L,9L,10L,11L,12L,12L,14L,15L,16L,17L,17L,17L,18L,20L,20L,20L,20L,22L,22L,23L,24L,25L,25L,26L,27L,28L,30L,31L,33L,34L,36L,36L,38L,41L,44L,49L,53L,55L,56L,59L,61L,62L,63L,65L,69L,69L,78L,85L,87L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088676Inst : IEnumerable<long>
{
public static readonly long[] Value=A088676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088676.Bytes);
public long this[int i]=>Value[i];

public static A088676Inst Instance=new A088676Inst();

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