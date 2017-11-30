using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A127237
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,2L,2L,8L,9L,4L,2L,6L,4L,8L,14L,6L,10L,12L,5L,10L,7L,16L,13L,12L,17L,14L,13L,12L,8L,16L,14L,14L,18L,16L,18L,14L,14L,20L,22L,14L,24L,20L,28L,18L,22L,16L,25L,30L,24L,24L,32L,26L,30L,32L,24L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127237Inst : IEnumerable<long>
{
public static readonly long[] Value=A127237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127237.Bytes);
public long this[int i]=>Value[i];

public static A127237Inst Instance=new A127237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127238
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,2L,2L,3L,3L,4L,3L,6L,4L,4L,5L,4L,3L,4L,3L,6L,8L,6L,6L,6L,9L,10L,8L,8L,12L,7L,7L,7L,7L,7L,6L,8L,13L,12L,8L,7L,12L,8L,13L,14L,12L,15L,13L,12L,12L,13L,14L,13L,12L,15L,12L,12L,12L,15L,14L,17L,17L,22L,17L,22L,14L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127238Inst : IEnumerable<long>
{
public static readonly long[] Value=A127238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127238.Bytes);
public long this[int i]=>Value[i];

public static A127238Inst Instance=new A127238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127239
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127239Inst : IEnumerable<long>
{
public static readonly long[] Value=A127239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127239.Bytes);
public long this[int i]=>Value[i];

public static A127239Inst Instance=new A127239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127288
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,10L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,25L,28L,30L,33L,24L,29L,26L,31L,32L,27L,34L,35L,36L,37L,39L,38L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,70L,67L,72L,75L,79L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127288Inst : IEnumerable<long>
{
public static readonly long[] Value=A127288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127288.Bytes);
public long this[int i]=>Value[i];

public static A127288Inst Instance=new A127288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127289
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,8L,7L,5L,4L,15L,20L,14L,19L,21L,18L,22L,16L,11L,13L,17L,12L,10L,9L,39L,53L,41L,55L,59L,40L,54L,38L,52L,57L,37L,51L,56L,58L,47L,60L,49L,62L,64L,48L,61L,43L,29L,34L,42L,28L,33L,35L,50L,63L,46L,32L,36L,44L,30L,25L,27L,45L,31L,26L,24L,23L,113L,155L,118L,160L,173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127289Inst : IEnumerable<long>
{
public static readonly long[] Value=A127289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127289.Bytes);
public long this[int i]=>Value[i];

public static A127289Inst Instance=new A127289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127290
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,4L,6L,5L,22L,21L,17L,20L,18L,11L,9L,16L,19L,14L,12L,10L,13L,15L,64L,63L,58L,62L,59L,48L,45L,57L,61L,54L,49L,46L,50L,55L,33L,30L,23L,28L,25L,47L,44L,56L,60L,53L,37L,42L,39L,51L,34L,31L,24L,29L,26L,35L,32L,36L,27L,38L,43L,40L,52L,41L,196L,195L,189L,194L,190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127290Inst : IEnumerable<long>
{
public static readonly long[] Value=A127290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127290.Bytes);
public long this[int i]=>Value[i];

public static A127290Inst Instance=new A127290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127291
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,7L,8L,5L,4L,15L,18L,14L,16L,17L,20L,22L,19L,11L,12L,21L,13L,10L,9L,39L,47L,40L,48L,50L,41L,49L,38L,43L,46L,37L,42L,44L,45L,53L,60L,54L,61L,63L,55L,62L,52L,29L,32L,51L,28L,30L,31L,59L,64L,57L,34L,36L,56L,33L,25L,26L,58L,35L,27L,24L,23L,113L,136L,116L,139L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127291Inst : IEnumerable<long>
{
public static readonly long[] Value=A127291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127291.Bytes);
public long this[int i]=>Value[i];

public static A127291Inst Instance=new A127291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127292
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,4L,5L,6L,22L,21L,17L,18L,20L,11L,9L,12L,13L,10L,16L,14L,19L,15L,64L,63L,58L,59L,62L,48L,45L,49L,50L,46L,57L,54L,61L,55L,33L,30L,23L,25L,28L,34L,31L,35L,36L,32L,24L,26L,29L,27L,47L,44L,37L,39L,42L,56L,53L,60L,51L,38L,40L,43L,41L,52L,196L,195L,189L,190L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127292Inst : IEnumerable<long>
{
public static readonly long[] Value=A127292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127292.Bytes);
public long this[int i]=>Value[i];

public static A127292Inst Instance=new A127292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127293
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,6L,8L,8L,9L,10L,8L,14L,18L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127293Inst : IEnumerable<long>
{
public static readonly long[] Value=A127293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127293.Bytes);
public long this[int i]=>Value[i];

public static A127293Inst Instance=new A127293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127294
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,21L,80L,255L,965L,3349L,9366L,30793L,80798L,396492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127294Inst : IEnumerable<long>
{
public static readonly long[] Value=A127294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127294.Bytes);
public long this[int i]=>Value[i];

public static A127294Inst Instance=new A127294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127295
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,30L,1260L,1680L,19825740L,10028280L,182416547040L,271239404020200L,BigInteger.Parse("219240769050559711332360"),BigInteger.Parse("6467876945923041743744426827092900"),BigInteger.Parse("27867228909478820644943875389480") };
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
public class A127295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127295Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A127295.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A127295.Bytes);
public BigInteger this[int i]=>Value[i];

public static A127295Inst Instance=new A127295Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127296
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,4L,2L,5L,7L,8L,10L,18L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127296Inst : IEnumerable<long>
{
public static readonly long[] Value=A127296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127296.Bytes);
public long this[int i]=>Value[i];

public static A127296Inst Instance=new A127296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127297
{
public static readonly long[] Value={ 1L,1L,2L,5L,10L,18L,86L,345L,866L,2639L,13341L,46236L,207882L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127297Inst : IEnumerable<long>
{
public static readonly long[] Value=A127297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127297.Bytes);
public long this[int i]=>Value[i];

public static A127297Inst Instance=new A127297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127298
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,30L,504L,1978L,714840L,500421564L,4855562127780L,1169461626163992L,BigInteger.Parse("112848995546998874467920"),7363180440L };
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
public class A127298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127298Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A127298.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A127298.Bytes);
public BigInteger this[int i]=>Value[i];

public static A127298Inst Instance=new A127298Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127299
{
public static readonly long[] Value={ 0L,1L,3L,2L,5L,8L,7L,6L,4L,15L,18L,10L,13L,21L,20L,22L,12L,11L,19L,17L,16L,14L,9L,29L,32L,52L,55L,62L,43L,46L,38L,41L,49L,24L,27L,35L,58L,34L,36L,57L,59L,64L,48L,50L,40L,39L,47L,26L,25L,33L,56L,61L,63L,54L,53L,60L,31L,30L,28L,51L,45L,44L,42L,37L,23L,113L,116L,136L,139L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127299Inst : IEnumerable<long>
{
public static readonly long[] Value=A127299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127299.Bytes);
public long this[int i]=>Value[i];

public static A127299Inst Instance=new A127299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127300
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,4L,7L,6L,5L,22L,11L,17L,16L,12L,21L,9L,20L,19L,10L,18L,14L,13L,15L,64L,33L,48L,47L,34L,58L,23L,57L,56L,24L,49L,37L,35L,38L,63L,30L,45L,44L,31L,62L,28L,61L,60L,29L,46L,42L,32L,43L,59L,25L,54L,53L,26L,50L,39L,36L,40L,55L,51L,27L,52L,41L,196L,102L,145L,144L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127300Inst : IEnumerable<long>
{
public static readonly long[] Value=A127300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127300.Bytes);
public long this[int i]=>Value[i];

public static A127300Inst Instance=new A127300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127301
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,6L,6L,7L,5L,16L,12L,12L,14L,10L,12L,9L,14L,19L,13L,10L,13L,17L,11L,32L,24L,24L,28L,20L,24L,18L,28L,38L,26L,20L,26L,34L,22L,24L,18L,18L,21L,15L,28L,21L,38L,53L,37L,26L,37L,43L,29L,20L,15L,26L,37L,23L,34L,43L,67L,41L,22L,29L,41L,59L,31L,64L,48L,48L,56L,40L,48L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127301Inst : IEnumerable<long>
{
public static readonly long[] Value=A127301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127301.Bytes);
public long this[int i]=>Value[i];

public static A127301Inst Instance=new A127301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127302
{
public static readonly long[] Value={ 1L,4L,14L,14L,86L,86L,49L,86L,86L,886L,886L,454L,886L,886L,301L,301L,301L,886L,886L,301L,454L,886L,886L,13766L,13766L,6418L,13766L,13766L,3986L,3986L,3986L,13766L,13766L,3986L,6418L,13766L,13766L,3101L,3101L,1589L,3101L,3101L,1849L,1849L,3101L,13766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127302Inst : IEnumerable<long>
{
public static readonly long[] Value=A127302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127302.Bytes);
public long this[int i]=>Value[i];

public static A127302Inst Instance=new A127302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127303
{
public static readonly long[] Value={ 1L,2L,11L,12L,111L,212L,1111L,1212L,11111L,21212L,111111L,221212L,1111111L,1221212L,11111111L,11221212L,111111111L,211221212L,1111111111L,2211221212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127303Inst : IEnumerable<long>
{
public static readonly long[] Value=A127303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127303.Bytes);
public long this[int i]=>Value[i];

public static A127303Inst Instance=new A127303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127624
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,11L,21L,41L,81L,161L,321L,641L,1281L,2561L,5121L,10241L,20481L,40951L,81881L,163721L,327361L,654561L,1308801L,2616961L,5232641L,10462721L,20920321L,41830401L,83640321L,167239691L,334397501L,668631281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127624Inst : IEnumerable<long>
{
public static readonly long[] Value=A127624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127624.Bytes);
public long this[int i]=>Value[i];

public static A127624Inst Instance=new A127624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127625
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,1L,1L,6L,3L,3L,1L,8L,6L,12L,1L,1L,10L,10L,30L,5L,2L,1L,12L,15L,60L,15L,12L,1L,1L,14L,21L,105L,35L,42L,7L,4L,1L,16L,28L,168L,70L,112L,28L,32L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127625Inst : IEnumerable<long>
{
public static readonly long[] Value=A127625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127625.Bytes);
public long this[int i]=>Value[i];

public static A127625Inst Instance=new A127625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127626
{
public static readonly long[] Value={ 1L,1L,3L,1L,0L,5L,1L,3L,0L,8L,1L,0L,0L,0L,9L,1L,3L,5L,0L,0L,15L,1L,0L,0L,0L,0L,0L,13L,1L,3L,0L,8L,0L,0L,0L,20L,1L,0L,5L,0L,0L,0L,0L,0L,21L,1L,3L,0L,0L,9L,0L,0L,0L,0L,27L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,21L,1L,3L,5L,8L,0L,15L,0L,0L,0L,0L,0L,40L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127626Inst : IEnumerable<long>
{
public static readonly long[] Value=A127626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127626.Bytes);
public long this[int i]=>Value[i];

public static A127626Inst Instance=new A127626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127627
{
public static readonly long[] Value={ 1L,-1L,3L,-1L,0L,5L,0L,-3L,0L,8L,-1L,0L,0L,0L,9L,1L,-3L,-5L,0L,0L,15L,-1L,0L,0L,0L,0L,0L,13L,0L,0L,0L,-8L,0L,0L,0L,20L,0L,0L,-5L,0L,0L,0L,0L,0L,21L,1L,-3L,0L,0L,-9L,0L,0L,0L,0L,27L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,21L,0L,3L,0L,-8L,0L,-15L,0L,0L,0L,0L,0L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127627Inst : IEnumerable<long>
{
public static readonly long[] Value=A127627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127627.Bytes);
public long this[int i]=>Value[i];

public static A127627Inst Instance=new A127627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127628
{
public static readonly long[] Value={ 1L,6L,42L,300L,2154L,15492L,111492L,802584L,5778090L,41600532L,299517996L,2156509416L,15526797252L,111792690600L,804906480840L,5795323452720L,41726317225770L,300429441596340L,2163091823919900L,15574260559056840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127628Inst : IEnumerable<long>
{
public static readonly long[] Value=A127628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127628.Bytes);
public long this[int i]=>Value[i];

public static A127628Inst Instance=new A127628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127629
{
public static readonly long[] Value={ 9L,28L,34L,58L,65L,75L,110L,126L,132L,201L,205L,217L,224L,246L,254L,258L,294L,344L,384L,399L,436L,498L,502L,513L,516L,520L,579L,657L,680L,690L,730L,786L,810L,866L,880L,978L,979L,1001L,1008L,1028L,1038L,1105L,1128L,1164L,1330L,1332L,1365L,1370L,1374L,1388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127629Inst : IEnumerable<long>
{
public static readonly long[] Value=A127629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127629.Bytes);
public long this[int i]=>Value[i];

public static A127629Inst Instance=new A127629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127630
{
public static readonly long[] Value={ 1L,1L,-3L,-3L,5L,5L,-7L,-7L,9L,9L,-11L,-11L,13L,13L,-15L,-15L,17L,17L,-19L,-19L,21L,21L,-23L,-23L,25L,25L,-27L,-27L,29L,29L,-31L,-31L,33L,33L,-35L,-35L,37L,37L,-39L,-39L,41L,41L,-43L,-43L,45L,45L,-47L,-47L,49L,49L,-51L,-51L,53L,53L,-55L,-55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127630Inst : IEnumerable<long>
{
public static readonly long[] Value=A127630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127630.Bytes);
public long this[int i]=>Value[i];

public static A127630Inst Instance=new A127630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127631
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,6L,4L,1L,0L,21L,16L,6L,1L,0L,80L,66L,30L,8L,1L,0L,322L,280L,143L,48L,10L,1L,0L,1348L,1216L,672L,260L,70L,12L,1L,0L,5814L,5385L,3150L,1344L,425L,96L,14L,1L,0L,25674L,24244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127631Inst : IEnumerable<long>
{
public static readonly long[] Value=A127631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127631.Bytes);
public long this[int i]=>Value[i];

public static A127631Inst Instance=new A127631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127632
{
public static readonly long[] Value={ 1L,1L,3L,11L,44L,185L,804L,3579L,16229L,74690L,347984L,1638169L,7780876L,37245028L,179503340L,870374211L,4243141332L,20786340271L,102275718924L,505235129250L,2504876652190L,12459922302900L,62167152967680L,311040862133625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127632Inst : IEnumerable<long>
{
public static readonly long[] Value=A127632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127632.Bytes);
public long this[int i]=>Value[i];

public static A127632Inst Instance=new A127632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127633
{
public static readonly long[] Value={ 1L,7L,19L,25L,37L,43L,55L,73L,79L,97L,109L,115L,127L,133L,145L,151L,163L,169L,181L,187L,199L,217L,223L,235L,241L,259L,271L,277L,289L,295L,307L,313L,331L,343L,349L,361L,367L,379L,385L,397L,403L,421L,439L,451L,457L,469L,475L,487L,493L,505L,511L,523L,529L,541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127633Inst : IEnumerable<long>
{
public static readonly long[] Value=A127633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127633.Bytes);
public long this[int i]=>Value[i];

public static A127633Inst Instance=new A127633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127634
{
public static readonly long[] Value={ 0L,1L,4L,16L,54L,178L,565L,1770L,5493L,16927L,51901L,158533L,482802L,1466859L,4448104L,13467249L,40720970L,122994566L,371156622L,1119161662L,3372427789L,10156591942L,30573367574L,91993546765L,276703494365L,832023918335L,2501142914874L,7516883840470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127634Inst : IEnumerable<long>
{
public static readonly long[] Value=A127634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127634.Bytes);
public long this[int i]=>Value[i];

public static A127634Inst Instance=new A127634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127635
{
public static readonly BigInteger[] Value={ 1L,4L,44L,1360L,118864L,29454720L,20723316480L,41430374667264L,235483137163985920L,BigInteger.Parse("3806579106735674587136"),BigInteger.Parse("175045931960590896961989632"),BigInteger.Parse("22902901668710944230193460535296"),BigInteger.Parse("8527272133354589357030560193109508096") };
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
public class A127635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127635Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A127635.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A127635.Bytes);
public BigInteger this[int i]=>Value[i];

public static A127635Inst Instance=new A127635Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127636
{
public static readonly BigInteger[] Value={ 1L,6L,99L,4590L,601749L,223671780L,236051526780L,707876792166456L,6035175245831686020L,BigInteger.Parse("146337688589606021286324"),BigInteger.Parse("10094030504239191283895044707"),BigInteger.Parse("1981045079056219549583047340549844") };
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
public class A127636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127636Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A127636.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A127636.Bytes);
public BigInteger this[int i]=>Value[i];

public static A127636Inst Instance=new A127636Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127637
{
public static readonly BigInteger[] Value={ 1L,3L,6L,66L,210L,3570L,207690L,930930L,56812470L,1803571770L,32395433070L,265257422430L,91348974206490L,24630635909489610L,438603767516904990L,14193386885746698630UL,BigInteger.Parse("2378522762792139793830"),BigInteger.Parse("351206814022419685159830"),BigInteger.Parse("28791787439593010836313310") };
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
public class A127637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127637Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A127637.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A127637.Bytes);
public BigInteger this[int i]=>Value[i];

public static A127637Inst Instance=new A127637Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127638
{
public static readonly long[] Value={ 2L,-2L,3L,-2L,0L,5L,0L,-3L,0L,7L,-2L,0L,0L,0L,11L,2L,-3L,-5L,0L,0L,13L,-2L,0L,0L,0L,0L,0L,17L,0L,0L,0L,-7L,0L,0L,0L,19L,0L,0L,-5L,0L,0L,0L,0L,0L,23L,2L,-3L,0L,0L,-11L,0L,0L,0L,0L,29L,-2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,31L,0L,3L,0L,-7L,0L,-13L,0L,0L,0L,0L,0L,37L,-2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,41L,2L,-3L,0L,0L,0L,0L,-17L,0L,0L,0L,0L,0L,0L,43L,2L,0L,-5L,0L,-11L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127638Inst : IEnumerable<long>
{
public static readonly long[] Value=A127638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127638.Bytes);
public long this[int i]=>Value[i];

public static A127638Inst Instance=new A127638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127639
{
public static readonly long[] Value={ 2L,2L,3L,2L,0L,5L,2L,3L,0L,7L,2L,0L,0L,0L,11L,2L,3L,5L,0L,0L,13L,2L,0L,0L,0L,0L,0L,17L,2L,3L,0L,7L,0L,0L,0L,19L,2L,0L,5L,0L,0L,0L,0L,0L,23L,2L,3L,0L,0L,11L,0L,0L,0L,0L,29L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,31L,2L,3L,5L,7L,0L,13L,0L,0L,0L,0L,0L,37L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,41L,2L,3L,0L,0L,0L,0L,17L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127639Inst : IEnumerable<long>
{
public static readonly long[] Value=A127639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127639.Bytes);
public long this[int i]=>Value[i];

public static A127639Inst Instance=new A127639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127656
{
public static readonly long[] Value={ 2L,2L,2L,3L,2L,2L,2L,3L,3L,2L,2L,3L,2L,2L,2L,3L,2L,3L,2L,3L,2L,2L,2L,3L,3L,2L,3L,3L,2L,2L,2L,3L,2L,2L,2L,1L,2L,2L,2L,3L,2L,2L,2L,3L,3L,2L,2L,4L,3L,3L,2L,3L,2L,3L,2L,3L,2L,2L,2L,3L,2L,2L,3L,3L,2L,2L,2L,3L,2L,2L,2L,5L,2L,2L,3L,3L,2L,2L,2L,3L,4L,2L,2L,3L,2L,2L,2L,3L,2L,3L,2L,3L,2L,2L,2L,3L,2L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127656Inst : IEnumerable<long>
{
public static readonly long[] Value=A127656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127656.Bytes);
public long this[int i]=>Value[i];

public static A127656Inst Instance=new A127656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127657
{
public static readonly long[] Value={ 36L,180L,252L,396L,468L,612L,684L,828L,900L,1044L,1116L,1260L,1332L,1352L,1476L,1548L,1692L,1728L,1800L,1908L,1980L,2124L,2196L,2340L,2412L,2556L,2628L,2700L,2772L,2844L,2880L,2916L,2988L,3000L,3060L,3204L,3276L,3420L,3492L,3636L,3708L,3750L,3852L,3924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127657Inst : IEnumerable<long>
{
public static readonly long[] Value=A127657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127657.Bytes);
public long this[int i]=>Value[i];

public static A127657Inst Instance=new A127657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127658
{
public static readonly long[] Value={ 900L,1352L,1728L,2880L,2916L,3000L,3750L,4356L,5292L,6480L,6760L,8100L,8640L,9464L,9900L,10404L,10648L,11700L,12000L,12096L,13500L,14580L,14872L,15300L,15552L,15876L,16000L,16200L,16224L,17100L,17836L,18252L,19008L,19044L,20160L,20412L,20700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127658Inst : IEnumerable<long>
{
public static readonly long[] Value=A127658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127658.Bytes);
public long this[int i]=>Value[i];

public static A127658Inst Instance=new A127658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127659
{
public static readonly long[] Value={ 90972L,100548L,454860L,502740L,937692L,968436L,1000692L,1106028L,1182636L,1307124L,1546524L,1709316L,2092356L,2312604L,2638188L,2820132L,2915892L,3116988L,3365964L,3720276L,3729852L,3911796L,4122468L,4275684L,4323564L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127659Inst : IEnumerable<long>
{
public static readonly long[] Value=A127659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127659.Bytes);
public long this[int i]=>Value[i];

public static A127659Inst Instance=new A127659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127660
{
public static readonly long[] Value={ 90972L,100548L,454860L,502740L,937692L,968436L,1000692L,1106028L,1182636L,1307124L,1383732L,1536416L,1546524L,1709316L,2092356L,2312604L,2502528L,2638188L,2690100L,2820132L,2915892L,3116988L,3365964L,3720276L,3729852L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127660Inst : IEnumerable<long>
{
public static readonly long[] Value=A127660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127660.Bytes);
public long this[int i]=>Value[i];

public static A127660Inst Instance=new A127660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127661
{
public static readonly long[] Value={ 2L,3L,3L,3L,3L,1L,3L,4L,3L,5L,3L,5L,3L,6L,4L,3L,3L,6L,3L,6L,4L,7L,3L,8L,3L,4L,4L,6L,3L,6L,3L,4L,5L,7L,4L,7L,3L,8L,4L,8L,3L,5L,3L,4L,5L,5L,3L,7L,3L,7L,5L,7L,3L,4L,4L,6L,4L,5L,3L,1L,3L,8L,4L,5L,4L,3L,3L,8L,5L,10L,3L,3L,3L,9L,4L,9L,4L,2L,3L,8L,3L,5L,3L,10L,4L,6L,6L,8L,3L,1L,5L,7L,5L,8L,4L,9L,3L,8L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127661Inst : IEnumerable<long>
{
public static readonly long[] Value=A127661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127661.Bytes);
public long this[int i]=>Value[i];

public static A127661Inst Instance=new A127661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127662
{
public static readonly long[] Value={ 6L,30L,42L,54L,60L,66L,72L,78L,90L,100L,140L,148L,152L,192L,194L,196L,208L,220L,238L,244L,252L,268L,274L,292L,296L,298L,300L,336L,348L,350L,360L,364L,372L,374L,380L,382L,386L,400L,416L,420L,424L,476L,482L,492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127662Inst : IEnumerable<long>
{
public static readonly long[] Value=A127662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127662.Bytes);
public long this[int i]=>Value[i];

public static A127662Inst Instance=new A127662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127663
{
public static readonly long[] Value={ 30L,42L,54L,66L,72L,78L,100L,140L,148L,152L,192L,194L,196L,208L,220L,238L,244L,252L,268L,274L,292L,296L,298L,300L,336L,348L,350L,360L,364L,372L,374L,380L,382L,386L,400L,416L,420L,424L,476L,482L,492L,516L,520L,532L,540L,542L,544L,550L,572L,576L,578L,586L,592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127663Inst : IEnumerable<long>
{
public static readonly long[] Value=A127663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127663.Bytes);
public long this[int i]=>Value[i];

public static A127663Inst Instance=new A127663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127664
{
public static readonly long[] Value={ 114L,126L,594L,846L,1140L,1260L,4320L,5940L,7920L,8460L,8640L,10744L,10856L,11760L,12285L,13500L,14595L,17700L,25728L,35712L,43632L,44772L,45888L,49308L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127664Inst : IEnumerable<long>
{
public static readonly long[] Value=A127664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127664.Bytes);
public long this[int i]=>Value[i];

public static A127664Inst Instance=new A127664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127665
{
public static readonly long[] Value={ 102L,114L,126L,210L,246L,258L,270L,318L,330L,342L,354L,366L,378L,388L,390L,408L,426L,436L,438L,450L,474L,484L,486L,498L,510L,522L,534L,536L,546L,552L,570L,582L,594L,600L,606L,618L,630L,642L,648L,654L,666L,672L,702L,726L,738L,750L,760L,762L,774L,786L,798L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127665Inst : IEnumerable<long>
{
public static readonly long[] Value=A127665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127665.Bytes);
public long this[int i]=>Value[i];

public static A127665Inst Instance=new A127665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127666
{
public static readonly long[] Value={ 945L,10395L,12285L,15015L,16065L,17955L,19305L,19635L,21735L,21945L,23205L,23625L,25245L,25935L,26565L,27405L,28215L,28875L,29295L,29835L,31395L,33345L,33495L,33915L,34125L,34155L,34965L,35805L,37125L,38745L,39585L,40635L,41055L,42315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127666Inst : IEnumerable<long>
{
public static readonly long[] Value=A127666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127666.Bytes);
public long this[int i]=>Value[i];

public static A127666Inst Instance=new A127666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127667
{
public static readonly long[] Value={ 945L,1743L,2175L,2655L,2823L,2865L,3105L,3375L,3537L,3585L,3729L,4209L,4665L,5775L,6559L,6681L,6969L,7257L,7263L,7785L,8457L,8583L,9657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127667Inst : IEnumerable<long>
{
public static readonly long[] Value=A127667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127667.Bytes);
public long this[int i]=>Value[i];

public static A127667Inst Instance=new A127667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127668
{
public static readonly long[] Value={ 1L,2L,11L,3L,21L,4L,111L,22L,31L,5L,211L,6L,41L,32L,1111L,7L,221L,8L,311L,42L,51L,9L,2111L,33L,61L,222L,411L,10L,321L,11L,11111L,52L,71L,43L,2211L,12L,81L,62L,3111L,13L,421L,14L,511L,322L,91L,15L,21111L,44L,331L,72L,611L,16L,2221L,53L,4111L,82L,101L,17L,3211L,18L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127668Inst : IEnumerable<long>
{
public static readonly long[] Value=A127668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127668.Bytes);
public long this[int i]=>Value[i];

public static A127668Inst Instance=new A127668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127669
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,3L,2L,2L,1L,3L,1L,2L,2L,5L,1L,3L,1L,3L,2L,2L,1L,5L,2L,2L,3L,3L,1L,3L,1L,7L,2L,2L,2L,5L,1L,2L,2L,5L,1L,3L,1L,3L,3L,2L,1L,7L,2L,3L,2L,3L,1L,5L,2L,5L,2L,2L,1L,5L,1L,2L,3L,11L,2L,3L,1L,3L,2L,3L,1L,7L,1L,2L,3L,3L,2L,3L,1L,7L,5L,2L,1L,5L,2L,2L,2L,5L,1L,5L,2L,3L,2L,2L,2L,11L,1L,3L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127669Inst : IEnumerable<long>
{
public static readonly long[] Value=A127669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127669.Bytes);
public long this[int i]=>Value[i];

public static A127669Inst Instance=new A127669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127670
{
public static readonly BigInteger[] Value={ 1L,4L,32L,400L,6912L,153664L,4194304L,136048896L,5120000000L,219503494144L,10567230160896L,564668382613504L,33174037869887488L,2125764000000000000L,BigInteger.Parse("147573952589676412928"),BigInteger.Parse("11034809241396899282944"),BigInteger.Parse("884295678882933431599104") };
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
public class A127670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127670Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A127670.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A127670.Bytes);
public BigInteger this[int i]=>Value[i];

public static A127670Inst Instance=new A127670Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127671
{
public static readonly long[] Value={ 1L,1L,-1L,1L,-3L,2L,1L,-4L,-3L,12L,-6L,1L,-5L,-10L,20L,30L,-60L,24L,1L,-6L,-15L,-10L,30L,120L,30L,-120L,-270L,360L,-120L,1L,-7L,-21L,-35L,42L,210L,140L,210L,-210L,-1260L,-630L,840L,2520L,-2520L,720L,1L,-8L,-28L,-56L,-35L,56L,336L,560L,420L,560L,-336L,-2520L,-1680L,-5040L,-630L,1680L,13440L,10080L,-6720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127671Inst : IEnumerable<long>
{
public static readonly long[] Value=A127671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127671.Bytes);
public long this[int i]=>Value[i];

public static A127671Inst Instance=new A127671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127704
{
public static readonly long[] Value={ 1L,0L,2L,-1L,1L,3L,-1L,-2L,1L,4L,-1L,0L,0L,1L,5L,0L,-3L,-3L,0L,1L,6L,-1L,0L,0L,0L,0L,1L,7L,0L,0L,-1L,-4L,0L,0L,1L,8L,0L,-1L,-3L,0L,0L,0L,0L,1L,9L,0L,-2L,0L,-1L,-5L,0L,0L,0L,1L,10L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,11L,1L,2L,-1L,-4L,-1L,-6L,0L,0L,0L,0L,1L,12L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,13L,0L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127704Inst : IEnumerable<long>
{
public static readonly long[] Value=A127704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127704.Bytes);
public long this[int i]=>Value[i];

public static A127704Inst Instance=new A127704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127705
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,1L,7L,4L,6L,3L,11L,4L,13L,5L,7L,8L,17L,6L,19L,8L,11L,9L,23L,8L,20L,11L,18L,12L,29L,9L,31L,16L,19L,15L,23L,12L,37L,17L,23L,16L,41L,13L,43L,20L,24L,21L,47L,16L,42L,20L,31L,24L,53L,18L,39L,24L,35L,27L,59L,16L,61L,29L,36L,32L,47L,21L,67L,32L,43L,25L,71L,24L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127705Inst : IEnumerable<long>
{
public static readonly long[] Value=A127705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127705.Bytes);
public long this[int i]=>Value[i];

public static A127705Inst Instance=new A127705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127706
{
public static readonly long[] Value={ 0L,0L,66L,16968L,9215792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127706Inst : IEnumerable<long>
{
public static readonly long[] Value=A127706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127706.Bytes);
public long this[int i]=>Value[i];

public static A127706Inst Instance=new A127706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127707
{
public static readonly long[] Value={ 1L,1L,1L,4L,1L,1L,1L,10L,4L,1L,1L,4L,1L,1L,1L,37L,1L,4L,1L,4L,1L,1L,1L,10L,4L,1L,11L,4L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127707Inst : IEnumerable<long>
{
public static readonly long[] Value=A127707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127707.Bytes);
public long this[int i]=>Value[i];

public static A127707Inst Instance=new A127707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127708
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,13L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127708Inst : IEnumerable<long>
{
public static readonly long[] Value=A127708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127708.Bytes);
public long this[int i]=>Value[i];

public static A127708Inst Instance=new A127708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127709
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,4L,1L,1L,7L,9L,1L,4L,28L,15L,1L,2L,47L,91L,26L,1L,27L,268L,257L,40L,10L,312L,1318L,643L,1L,137L,2807L,5347L,1L,35L,2204L,19516L,5L,771L,26312L,2L,186L,14758L,39L,4362L,11L,1013L,1L,214L,1L,43L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127709Inst : IEnumerable<long>
{
public static readonly long[] Value=A127709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127709.Bytes);
public long this[int i]=>Value[i];

public static A127709Inst Instance=new A127709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127710
{
public static readonly long[] Value={ 1L,0L,2L,0L,-2L,3L,0L,2L,-3L,4L,0L,0L,0L,-4L,5L,0L,-2L,3L,0L,-5L,6L,0L,0L,0L,0L,0L,-6L,7L,0L,2L,-3L,4L,0L,0L,-7L,8L,0L,0L,0L,0L,0L,0L,0L,-8L,9L,0L,0L,0L,-4L,5L,0L,0L,0L,-9L,10L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127710Inst : IEnumerable<long>
{
public static readonly long[] Value=A127710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127710.Bytes);
public long this[int i]=>Value[i];

public static A127710Inst Instance=new A127710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127711
{
public static readonly long[] Value={ 1L,0L,1L,0L,-1L,2L,0L,1L,-2L,3L,0L,0L,0L,-3L,5L,0L,-1L,2L,0L,-5L,8L,0L,0L,0L,0L,0L,-8L,13L,0L,1L,-2L,3L,0L,0L,-13L,21L,0L,0L,0L,0L,0L,0L,0L,-21L,34L,0L,0L,0L,-3L,5L,0L,0L,0L,-34L,55L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-55L,89L,0L,-1L,2L,0L,-5L,8L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127711Inst : IEnumerable<long>
{
public static readonly long[] Value=A127711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127711.Bytes);
public long this[int i]=>Value[i];

public static A127711Inst Instance=new A127711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127712
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,5L,10L,13L,23L,34L,59L,89L,149L,233L,387L,610L,1000L,1597L,2607L,4181L,6799L,10946L,17770L,28657L,46457L,75025L,121542L,196418L,318044L,514229L,832427L,1346269L,2178919L,3524578L,5703887L,9227465L,14931949L,24157817L,39090776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127712Inst : IEnumerable<long>
{
public static readonly long[] Value=A127712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127712.Bytes);
public long this[int i]=>Value[i];

public static A127712Inst Instance=new A127712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127713
{
public static readonly long[] Value={ 1L,2L,4L,10L,23L,59L,149L,387L,1000L,2607L,6799L,17770L,46457L,121542L,318044L,832427L,2178919L,5703887L,14931949L,39090776L,102338336L,267921095L,701419679L,1836329673L,4807555633L,12586315482L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127713Inst : IEnumerable<long>
{
public static readonly long[] Value=A127713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127713.Bytes);
public long this[int i]=>Value[i];

public static A127713Inst Instance=new A127713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127714
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,3L,3L,3L,1L,3L,5L,5L,8L,11L,11L,14L,14L,14L,1L,4L,9L,14L,14L,22L,33L,44L,44L,58L,72L,72L,86L,86L,86L,1L,5L,14L,28L,42L,42L,64L,97L,141L,185L,185L,243L,315L,387L,387L,473L,559L,559L,645L,645L,645L,1L,6L,20L,48L,90L,132L,132L,196L,293L,434L,619L,804L,804L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127714Inst : IEnumerable<long>
{
public static readonly long[] Value=A127714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127714.Bytes);
public long this[int i]=>Value[i];

public static A127714Inst Instance=new A127714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127715
{
public static readonly long[] Value={ 1L,1L,3L,14L,86L,645L,5662L,56632L,633545L,7820115L,105401961L,1538517351L,24157841308L,405778641302L,7256711524298L,137607733327779L,2757147167433326L,58188668578629283L,1289965088962987961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127715Inst : IEnumerable<long>
{
public static readonly long[] Value=A127715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127715.Bytes);
public long this[int i]=>Value[i];

public static A127715Inst Instance=new A127715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127716
{
public static readonly ulong[] Value={ 1L,1L,3L,11L,72L,473L,3727L,39646L,412679L,4765654L,61015451L,937386045L,14126033578L,227901084348L,3941375013541L,72677938745613L,1517730017193292L,31249446089387086L,675658943143264102L,15356377683044270187UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127716Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A127716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127716.Bytes);
public ulong this[int i]=>Value[i];

public static A127716Inst Instance=new A127716Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127717
{
public static readonly long[] Value={ 1L,3L,2L,6L,8L,3L,10L,20L,15L,4L,15L,40L,45L,24L,5L,21L,70L,105L,84L,35L,6L,28L,112L,210L,224L,140L,48L,7L,36L,168L,378L,504L,420L,216L,63L,8L,45L,240L,630L,1008L,1050L,720L,315L,80L,9L,55L,330L,990L,1848L,2310L,1980L,1155L,440L,99L,10L,66L,440L,1485L,3168L,4620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127717Inst : IEnumerable<long>
{
public static readonly long[] Value=A127717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127717.Bytes);
public long this[int i]=>Value[i];

public static A127717Inst Instance=new A127717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127718
{
public static readonly long[] Value={ 1L,2L,2L,4L,6L,3L,8L,14L,12L,4L,16L,30L,33L,20L,5L,32L,62L,78L,64L,30L,6L,64L,126L,171L,168L,110L,42L,7L,128L,254L,360L,396L,320L,174L,56L,8L,256L,510L,741L,876L,815L,558L,259L,72L,9L,512L,1022L,1506L,1864L,1910L,1536L,910L,368L,90L,10L,1024L,2046L,3039L,3872L,4240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127718Inst : IEnumerable<long>
{
public static readonly long[] Value=A127718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127718.Bytes);
public long this[int i]=>Value[i];

public static A127718Inst Instance=new A127718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127719
{
public static readonly long[] Value={ 2L,3L,6L,9L,14L,19L,25L,32L,39L,48L,57L,68L,80L,90L,102L,115L,129L,143L,158L,173L,187L,203L,220L,237L,256L,275L,294L,313L,331L,350L,372L,394L,418L,440L,465L,488L,513L,538L,564L,590L,616L,642L,670L,697L,724L,751L,780L,811L,843L,873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127719Inst : IEnumerable<long>
{
public static readonly long[] Value=A127719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127719.Bytes);
public long this[int i]=>Value[i];

public static A127719Inst Instance=new A127719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127752
{
public static readonly long[] Value={ 1L,4L,3L,7L,3L,6L,3L,10L,3L,6L,3L,9L,3L,6L,3L,13L,3L,6L,3L,9L,3L,6L,3L,12L,3L,6L,3L,9L,3L,6L,3L,16L,3L,6L,3L,9L,3L,6L,3L,12L,3L,6L,3L,9L,3L,6L,3L,15L,3L,6L,3L,9L,3L,6L,3L,12L,3L,6L,3L,9L,3L,6L,3L,19L,3L,6L,3L,9L,3L,6L,3L,12L,3L,6L,3L,9L,3L,6L,3L,15L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127752Inst : IEnumerable<long>
{
public static readonly long[] Value=A127752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127752.Bytes);
public long this[int i]=>Value[i];

public static A127752Inst Instance=new A127752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127753
{
public static readonly long[] Value={ 1L,0L,3L,0L,-3L,4L,0L,3L,-4L,7L,0L,0L,0L,-7L,11L,0L,-3L,4L,0L,-11L,18L,0L,0L,0L,0L,0L,-18L,29L,0L,3L,-4L,7L,0L,0L,-29L,47L,0L,0L,0L,0L,0L,0L,0L,-47L,76L,0L,0L,0L,-7L,11L,0L,0L,0L,-76L,123L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-123L,199L,0L,-3L,4L,0L,-11L,18L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127753Inst : IEnumerable<long>
{
public static readonly long[] Value=A127753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127753.Bytes);
public long this[int i]=>Value[i];

public static A127753Inst Instance=new A127753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127754
{
public static readonly long[] Value={ 1L,3L,1L,6L,4L,8L,11L,24L,29L,51L,76L,131L,199L,333L,521L,867L,1364L,2236L,3571L,5829L,9349L,15203L,24476L,39734L,64079L,103881L,167761L,271776L,439204L,711168L,1149851L,1861365L,3010349L,4872211L,7881196L,12754279L,20633239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127754Inst : IEnumerable<long>
{
public static readonly long[] Value=A127754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127754.Bytes);
public long this[int i]=>Value[i];

public static A127754Inst Instance=new A127754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127755
{
public static readonly long[] Value={ 1L,0L,1L,0L,-1L,2L,0L,1L,-2L,6L,0L,0L,0L,-6L,24L,0L,-1L,2L,0L,-24L,120L,0L,0L,0L,0L,0L,-120L,720L,0L,1L,-2L,6L,0L,0L,-720L,5040L,0L,0L,0L,0L,0L,0L,0L,-5040L,40320L,0L,0L,0L,-6L,24L,0L,0L,0L,-40320L,362880L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127755Inst : IEnumerable<long>
{
public static readonly long[] Value=A127755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127755.Bytes);
public long this[int i]=>Value[i];

public static A127755Inst Instance=new A127755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127756
{
public static readonly long[] Value={ 1L,1L,1L,5L,18L,97L,600L,4325L,35280L,322578L,3265920L,36288097L,439084800L,5748019800L,80951270400L,1220496081125L,19615115520000L,334764638243280L,6046686277632000L,115242726703426578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127756Inst : IEnumerable<long>
{
public static readonly long[] Value=A127756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127756.Bytes);
public long this[int i]=>Value[i];

public static A127756Inst Instance=new A127756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127757
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,11L,12L,12L,12L,12L,13L,13L,13L,13L,14L,14L,14L,14L,15L,15L,15L,15L,16L,16L,16L,16L,16L,17L,17L,17L,17L,18L,18L,18L,18L,19L,19L,19L,19L,19L,20L,20L,20L,20L,21L,21L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127757Inst : IEnumerable<long>
{
public static readonly long[] Value=A127757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127757.Bytes);
public long this[int i]=>Value[i];

public static A127757Inst Instance=new A127757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127758
{
public static readonly long[] Value={ 1L,2L,3L,6L,8L,11L,14L,18L,22L,26L,30L,35L,40L,46L,51L,58L,64L,71L,77L,85L,92L,100L,108L,116L,125L,134L,143L,152L,162L,172L,182L,193L,204L,215L,226L,238L,249L,261L,274L,286L,299L,312L,326L,339L,353L,367L,381L,396L,411L,426L,441L,457L,473L,489L,505L,521L,538L,555L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127758Inst : IEnumerable<long>
{
public static readonly long[] Value=A127758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127758.Bytes);
public long this[int i]=>Value[i];

public static A127758Inst Instance=new A127758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127759
{
public static readonly long[] Value={ 1L,3L,9L,18L,31L,50L,74L,105L,143L,189L,243L,307L,380L,463L,557L,663L,780L,910L,1054L,1211L,1382L,1569L,1770L,1988L,2222L,2473L,2742L,3029L,3334L,3659L,4003L,4368L,4753L,5159L,5587L,6038L,6511L,7008L,7528L,8072L,8642L,9236L,9857L,10503L,11177L,11877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127759Inst : IEnumerable<long>
{
public static readonly long[] Value=A127759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127759.Bytes);
public long this[int i]=>Value[i];

public static A127759Inst Instance=new A127759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127760
{
public static readonly long[] Value={ 1L,6L,22L,58L,125L,238L,411L,663L,1012L,1482L,2094L,2875L,3852L,5052L,6508L,8250L,10314L,12735L,15550L,18798L,22521L,26760L,31559L,36965L,43023L,49783L,57296L,65612L,74786L,84873L,95929L,108011L,121181L,135498L,151026L,167829L,185971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127760Inst : IEnumerable<long>
{
public static readonly long[] Value=A127760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127760.Bytes);
public long this[int i]=>Value[i];

public static A127760Inst Instance=new A127760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127761
{
public static readonly long[] Value={ 1L,10L,55L,193L,520L,1180L,2375L,4368L,7496L,12177L,18913L,28301L,41040L,57936L,79912L,108011L,143406L,187403L,241453L,307153L,386256L,480675L,592494L,723966L,877529L,1055804L,1261606L,1497950L,1768053L,2075346L,2423475L,2816310L,3257951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127761Inst : IEnumerable<long>
{
public static readonly long[] Value=A127761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127761.Bytes);
public long this[int i]=>Value[i];

public static A127761Inst Instance=new A127761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127762
{
public static readonly long[] Value={ 1L,2L,4L,7L,10L,13L,16L,20L,25L,29L,34L,39L,45L,51L,57L,64L,71L,78L,86L,93L,102L,110L,119L,128L,137L,147L,157L,167L,177L,188L,199L,210L,222L,234L,246L,258L,271L,284L,297L,311L,325L,339L,353L,368L,382L,398L,413L,429L,444L,461L,477L,494L,511L,528L,545L,563L,581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127762Inst : IEnumerable<long>
{
public static readonly long[] Value=A127762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127762.Bytes);
public long this[int i]=>Value[i];

public static A127762Inst Instance=new A127762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127763
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,8L,8L,8L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,12L,12L,12L,12L,13L,13L,13L,14L,14L,14L,14L,15L,15L,15L,15L,16L,16L,16L,17L,17L,17L,17L,18L,18L,18L,18L,19L,19L,19L,19L,20L,20L,20L,20L,21L,21L,21L,21L,22L,22L,22L,23L,23L,23L,23L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127763Inst : IEnumerable<long>
{
public static readonly long[] Value=A127763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127763.Bytes);
public long this[int i]=>Value[i];

public static A127763Inst Instance=new A127763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127764
{
public static readonly long[] Value={ 1L,4L,10L,20L,35L,55L,82L,116L,157L,206L,265L,333L,411L,500L,601L,714L,839L,978L,1130L,1298L,1480L,1678L,1892L,2123L,2371L,2637L,2922L,3225L,3548L,3892L,4256L,4641L,5047L,5477L,5928L,6404L,6903L,7426L,7974L,8548L,9148L,9774L,10427L,11108L,11816L,12553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127764Inst : IEnumerable<long>
{
public static readonly long[] Value=A127764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127764.Bytes);
public long this[int i]=>Value[i];

public static A127764Inst Instance=new A127764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127765
{
public static readonly long[] Value={ 1L,7L,25L,64L,137L,258L,444L,714L,1086L,1586L,2236L,3063L,4096L,5364L,6899L,8736L,10909L,13455L,16414L,19826L,23734L,28181L,33212L,38876L,45221L,52297L,60158L,68856L,78447L,88988L,100537L,113155L,126903L,141845L,158045L,175570L,194487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127765Inst : IEnumerable<long>
{
public static readonly long[] Value=A127765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127765.Bytes);
public long this[int i]=>Value[i];

public static A127765Inst Instance=new A127765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127766
{
public static readonly long[] Value={ 1L,12L,61L,210L,561L,1265L,2532L,4641L,7941L,12868L,19946L,29796L,43144L,60828L,83804L,113155L,150095L,195980L,252310L,320738L,403077L,501308L,617581L,754227L,913762L,1098894L,1312530L,1557780L,1837964L,2156622L,2517514L,2924630L,3382196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127766Inst : IEnumerable<long>
{
public static readonly long[] Value=A127766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127766.Bytes);
public long this[int i]=>Value[i];

public static A127766Inst Instance=new A127766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127767
{
public static readonly long[] Value={ 1L,0L,1L,0L,-1L,2L,0L,1L,-2L,5L,0L,0L,0L,-5L,14L,0L,-1L,2L,0L,-14L,42L,0L,0L,0L,0L,0L,-42L,132L,0L,1L,-2L,5L,0L,0L,-132L,429L,0L,0L,0L,0L,0L,0L,0L,-429L,1430L,0L,0L,0L,-5L,14L,0L,0L,0L,-1430L,4862L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-4862L,16796L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127767Inst : IEnumerable<long>
{
public static readonly long[] Value=A127767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127767.Bytes);
public long this[int i]=>Value[i];

public static A127767Inst Instance=new A127767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127800
{
public static readonly long[] Value={ 1L,0L,2L,0L,-2L,2L,0L,2L,-2L,2L,0L,0L,0L,-2L,2L,0L,-2L,2L,0L,-2L,2L,0L,0L,0L,0L,0L,-2L,2L,0L,2L,-2L,2L,0L,0L,-2L,2L,0L,0L,0L,0L,0L,0L,0L,-2L,2L,0L,0L,0L,-2L,2L,0L,0L,0L,-2L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-2L,2L,0L,-2L,2L,0L,-2L,2L,0L,0L,0L,0L,-2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127800Inst : IEnumerable<long>
{
public static readonly long[] Value=A127800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127800.Bytes);
public long this[int i]=>Value[i];

public static A127800Inst Instance=new A127800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127801
{
public static readonly long[] Value={ 1L,0L,3L,0L,-3L,3L,0L,3L,-3L,3L,0L,0L,0L,-3L,3L,0L,-3L,3L,0L,-3L,3L,0L,0L,0L,0L,0L,-3L,3L,0L,3L,-3L,3L,0L,0L,-3L,3L,0L,0L,0L,0L,0L,0L,0L,-3L,3L,0L,0L,0L,-3L,3L,0L,0L,0L,-3L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-3L,3L,0L,-3L,3L,0L,-3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127801Inst : IEnumerable<long>
{
public static readonly long[] Value=A127801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127801.Bytes);
public long this[int i]=>Value[i];

public static A127801Inst Instance=new A127801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127802
{
public static readonly long[] Value={ 1L,3L,0L,3L,0L,0L,0L,3L,0L,0L,0L,0L,0L,0L,0L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127802Inst : IEnumerable<long>
{
public static readonly long[] Value=A127802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127802.Bytes);
public long this[int i]=>Value[i];

public static A127802Inst Instance=new A127802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127803
{
public static readonly long[] Value={ 1L,0L,3L,0L,-3L,7L,0L,3L,-7L,15L,0L,0L,0L,-15L,31L,0L,-3L,7L,0L,-31L,63L,0L,0L,0L,0L,0L,-63L,127L,0L,3L,-7L,15L,0L,0L,-127L,255L,0L,0L,0L,0L,0L,0L,0L,-255L,511L,0L,0L,0L,-15L,31L,0L,0L,0L,-511L,1023L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1023L,2047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127803Inst : IEnumerable<long>
{
public static readonly long[] Value=A127803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127803.Bytes);
public long this[int i]=>Value[i];

public static A127803Inst Instance=new A127803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127804
{
public static readonly long[] Value={ 1L,3L,4L,11L,16L,36L,64L,139L,256L,528L,1024L,2084L,4096L,8256L,16384L,32907L,65536L,131328L,262144L,524816L,1048576L,2098176L,4194304L,8390692L,16777216L,33558528L,67108864L,134225984L,268435456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127804Inst : IEnumerable<long>
{
public static readonly long[] Value=A127804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127804.Bytes);
public long this[int i]=>Value[i];

public static A127804Inst Instance=new A127804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127805
{
public static readonly long[] Value={ 1L,0L,11L,0L,-11L,111L,0L,11L,-111L,1111L,0L,0L,0L,-1111L,11111L,0L,-11L,111L,0L,-11111L,111111L,0L,0L,0L,0L,0L,-111111L,1111111L,0L,11L,-111L,1111L,0L,0L,-1111111L,11111111L,0L,0L,0L,0L,0L,0L,0L,-11111111L,111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127805Inst : IEnumerable<long>
{
public static readonly long[] Value=A127805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127805.Bytes);
public long this[int i]=>Value[i];

public static A127805Inst Instance=new A127805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127806
{
public static readonly long[] Value={ 1L,11L,100L,1011L,10000L,100100L,1000000L,10001011L,100000000L,1000010000L,10000000000L,100000100100L,1000000000000L,10000001000000L,100000000000000L,1000000010001011L,10000000000000000L,100000000100000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127806Inst : IEnumerable<long>
{
public static readonly long[] Value=A127806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127806.Bytes);
public long this[int i]=>Value[i];

public static A127806Inst Instance=new A127806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127807
{
public static readonly long[] Value={ 3L,2L,2L,3L,2L,2L,3L,2L,5L,2L,3L,2L,6L,3L,5L,2L,2L,2L,2L,7L,5L,3L,2L,3L,5L,2L,5L,2L,6L,3L,3L,2L,3L,2L,2L,6L,5L,2L,5L,2L,2L,2L,19L,5L,2L,3L,2L,3L,2L,6L,3L,7L,7L,6L,3L,5L,2L,6L,5L,3L,3L,2L,5L,17L,10L,2L,3L,10L,2L,2L,3L,7L,6L,2L,2L,5L,2L,5L,3L,21L,2L,2L,7L,5L,15L,2L,3L,13L,2L,3L,2L,13L,3L,2L,7L,5L,2L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127807Inst : IEnumerable<long>
{
public static readonly long[] Value=A127807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127807.Bytes);
public long this[int i]=>Value[i];

public static A127807Inst Instance=new A127807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127808
{
public static readonly long[] Value={ 2L,2L,3L,2L,2L,3L,2L,5L,2L,3L,2L,6L,3L,5L,2L,2L,2L,2L,7L,5L,3L,2L,3L,5L,2L,5L,2L,6L,3L,3L,2L,3L,2L,2L,6L,5L,2L,5L,2L,2L,2L,19L,5L,2L,3L,2L,3L,2L,6L,3L,7L,7L,6L,3L,5L,2L,6L,5L,3L,3L,2L,5L,17L,10L,2L,3L,10L,2L,2L,3L,7L,6L,2L,2L,5L,2L,5L,3L,21L,2L,2L,7L,5L,15L,2L,3L,13L,2L,3L,2L,13L,3L,2L,7L,5L,2L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127808Inst : IEnumerable<long>
{
public static readonly long[] Value=A127808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127808.Bytes);
public long this[int i]=>Value[i];

public static A127808Inst Instance=new A127808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127809
{
public static readonly long[] Value={ 2L,2L,3L,2L,2L,3L,2L,5L,2L,3L,2L,6L,3L,5L,2L,2L,2L,2L,7L,5L,3L,2L,3L,5L,2L,5L,2L,6L,3L,3L,2L,3L,2L,2L,6L,5L,2L,5L,2L,2L,2L,19L,5L,2L,3L,2L,3L,2L,6L,3L,7L,7L,6L,3L,5L,2L,6L,5L,3L,3L,2L,5L,17L,10L,2L,3L,10L,2L,2L,3L,7L,6L,2L,2L,5L,2L,5L,3L,21L,2L,2L,7L,5L,15L,2L,3L,13L,2L,3L,2L,13L,3L,2L,7L,5L,2L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127809Inst : IEnumerable<long>
{
public static readonly long[] Value=A127809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127809.Bytes);
public long this[int i]=>Value[i];

public static A127809Inst Instance=new A127809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127810
{
public static readonly long[] Value={ 2L,2L,3L,2L,2L,3L,2L,5L,2L,3L,2L,6L,3L,5L,2L,2L,2L,2L,7L,5L,3L,2L,3L,5L,2L,5L,2L,6L,3L,3L,2L,3L,2L,2L,6L,5L,2L,5L,2L,2L,2L,19L,5L,2L,3L,2L,3L,2L,6L,3L,7L,7L,6L,3L,5L,2L,6L,5L,3L,3L,2L,5L,17L,10L,2L,3L,10L,2L,2L,3L,7L,6L,2L,2L,5L,2L,5L,3L,21L,2L,2L,7L,5L,15L,2L,3L,13L,2L,3L,2L,13L,3L,2L,7L,5L,2L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127810Inst : IEnumerable<long>
{
public static readonly long[] Value=A127810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127810.Bytes);
public long this[int i]=>Value[i];

public static A127810Inst Instance=new A127810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127811
{
public static readonly long[] Value={ 0L,1L,4L,12L,32L,74L,156L,310L,580L,1035L,1780L,2956L,4764L,7487L,11492L,17274L,25492L,36979L,52812L,74372L,103364L,141927L,192724L,258982L,344652L,454544L,594392L,771084L,992852L,1269377L,1612104L,2034508L,2552248L,3183594L,3949784L,4875248L,5988168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127811Inst : IEnumerable<long>
{
public static readonly long[] Value=A127811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127811.Bytes);
public long this[int i]=>Value[i];

public static A127811Inst Instance=new A127811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127812
{
public static readonly long[] Value={ 4L,1L,2L,3L,21L,5L,15L,7L,33L,22L,66L,11L,77L,13L,39L,26L,57L,17L,51L,19L,69L,46L,95L,23L,145L,465L,155L,435L,93L,29L,87L,31L,185L,777L,259L,555L,222L,37L,111L,74L,129L,41L,123L,43L,141L,94L,215L,47L,265L,1113L,371L,795L,318L,53L,159L,106L,177L,118L,354L,59L,366L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127812Inst : IEnumerable<long>
{
public static readonly long[] Value=A127812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127812.Bytes);
public long this[int i]=>Value[i];

public static A127812Inst Instance=new A127812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127813
{
public static readonly long[] Value={ 0L,0L,1L,8L,25L,72L,175L,384L,778L,1492L,2701L,4704L,7891L,12828L,20280L,31312L,47265L,70000L,101836L,145792L,205663L,286284L,393520L,534816L,719117L,957408L,1262909L,1651640L,2142476L,2758212L,3525503L,4475904L,5646291L,7079924L,8826657L,10944800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127813Inst : IEnumerable<long>
{
public static readonly long[] Value=A127813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127813.Bytes);
public long this[int i]=>Value[i];

public static A127813Inst Instance=new A127813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127814
{
public static readonly BigInteger[] Value={ 2L,3L,5L,-11L,779L,497941L,181860254581L,BigInteger.Parse("16687694789137362648661"),BigInteger.Parse("-263439569256003706800705587722279993788907979"),BigInteger.Parse("81512663708476146329709015825571064954724426915346799560162522434680208602364731247764459") };
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
public class A127814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127814Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A127814.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A127814.Bytes);
public BigInteger this[int i]=>Value[i];

public static A127814Inst Instance=new A127814Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127815
{
public static readonly BigInteger[] Value={ 1L,2L,6L,30L,330L,257070L,128005692870L,BigInteger.Parse("23279147893155496537470"),BigInteger.Parse("388475314992168993748220639081347493631827670"),BigInteger.Parse("102339769648127358726761918460732576814168548432921287355299929744910591862606847215978930") };
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
public class A127815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127815Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A127815.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A127815.Bytes);
public BigInteger this[int i]=>Value[i];

public static A127815Inst Instance=new A127815Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127832
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,2L,2L,1L,1L,4L,5L,4L,3L,1L,1L,5L,9L,9L,7L,4L,1L,1L,6L,14L,18L,9L,11L,5L,1L,1L,7L,20L,32L,27L,11L,16L,6L,1L,1L,8L,27L,52L,59L,27L,27L,22L,7L,1L,1L,9L,35L,79L,111L,86L,54L,49L,29L,8L,1L,1L,10L,44L,114L,190L,197L,140L,103L,78L,37L,9L,1L,1L,11L,54L,158L,304L,387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127832Inst : IEnumerable<long>
{
public static readonly long[] Value=A127832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127832.Bytes);
public long this[int i]=>Value[i];

public static A127832Inst Instance=new A127832Inst();

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