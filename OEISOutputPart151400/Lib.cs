using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A194505
{
public static readonly long[] Value={ 1L,2L,1L,3L,8L,4L,4L,27L,72L,2L,5L,64L,776L,1020L,1L,6L,125L,4160L,59052L,32768L,1L,7L,216L,15804L,1048560L,14348907L,2097152L,1L,8L,343L,46872L,9765630L,1073741824L,10460353203L,268460064L,16L,9L,512L,118096L,60466140L,30517578125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194505Inst : IEnumerable<long>
{
public static readonly long[] Value=A194505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194505.Bytes);
public long this[int i]=>Value[i];

public static A194505Inst Instance=new A194505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194506
{
public static readonly BigInteger[] Value={ 3L,12L,120L,360L,1008L,20160L,259200L,907200L,6652800L,19160064L,39626496000L,62270208000L,603542016000L,640493568000L,1067062284288000L,4001483566080000L,4174096582656000L,162193467211776000L,13651830701752320000UL,BigInteger.Parse("481714597618974720000") };
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
public class A194506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194506Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194506.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194506.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194506Inst Instance=new A194506Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194507
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,8L,10L,7L,12L,9L,14L,18L,11L,15L,16L,13L,20L,24L,22L,30L,21L,17L,26L,28L,19L,36L,27L,25L,42L,23L,32L,34L,40L,33L,38L,48L,29L,35L,44L,31L,39L,60L,54L,50L,46L,45L,52L,66L,37L,56L,58L,51L,41L,70L,72L,43L,62L,78L,84L,64L,57L,49L,90L,47L,68L,55L,63L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194507Inst : IEnumerable<long>
{
public static readonly long[] Value=A194507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194507.Bytes);
public long this[int i]=>Value[i];

public static A194507Inst Instance=new A194507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194508
{
public static readonly long[] Value={ -1L,1L,0L,2L,1L,0L,2L,1L,3L,2L,1L,3L,2L,4L,3L,2L,4L,3L,5L,4L,3L,5L,4L,6L,5L,4L,6L,5L,7L,6L,5L,7L,6L,8L,7L,6L,8L,7L,9L,8L,7L,9L,8L,10L,9L,8L,10L,9L,11L,10L,9L,11L,10L,12L,11L,10L,12L,11L,13L,12L,11L,13L,12L,14L,13L,12L,14L,13L,15L,14L,13L,15L,14L,16L,15L,14L,16L,15L,17L,16L,15L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194508Inst : IEnumerable<long>
{
public static readonly long[] Value=A194508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194508.Bytes);
public long this[int i]=>Value[i];

public static A194508Inst Instance=new A194508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194509
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,2L,1L,2L,1L,2L,3L,2L,3L,2L,3L,4L,3L,4L,3L,4L,5L,4L,5L,4L,5L,6L,5L,6L,5L,6L,7L,6L,7L,6L,7L,8L,7L,8L,7L,8L,9L,8L,9L,8L,9L,10L,9L,10L,9L,10L,11L,10L,11L,10L,11L,12L,11L,12L,11L,12L,13L,12L,13L,12L,13L,14L,13L,14L,13L,14L,15L,14L,15L,14L,15L,16L,15L,16L,15L,16L,17L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194509Inst : IEnumerable<long>
{
public static readonly long[] Value=A194509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194509.Bytes);
public long this[int i]=>Value[i];

public static A194509Inst Instance=new A194509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194510
{
public static readonly long[] Value={ 3L,1L,-1L,2L,0L,3L,1L,4L,2L,0L,3L,1L,4L,2L,5L,3L,1L,4L,2L,5L,3L,6L,4L,2L,5L,3L,6L,4L,7L,5L,3L,6L,4L,7L,5L,8L,6L,4L,7L,5L,8L,6L,9L,7L,5L,8L,6L,9L,7L,10L,8L,6L,9L,7L,10L,8L,11L,9L,7L,10L,8L,11L,9L,12L,10L,8L,11L,9L,12L,10L,13L,11L,9L,12L,10L,13L,11L,14L,12L,10L,13L,11L,14L,12L,15L,13L,11L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194510Inst : IEnumerable<long>
{
public static readonly long[] Value=A194510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194510.Bytes);
public long this[int i]=>Value[i];

public static A194510Inst Instance=new A194510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194511
{
public static readonly long[] Value={ -1L,0L,1L,0L,1L,0L,1L,0L,1L,2L,1L,2L,1L,2L,1L,2L,3L,2L,3L,2L,3L,2L,3L,4L,3L,4L,3L,4L,3L,4L,5L,4L,5L,4L,5L,4L,5L,6L,5L,6L,5L,6L,5L,6L,7L,6L,7L,6L,7L,6L,7L,8L,7L,8L,7L,8L,7L,8L,9L,8L,9L,8L,9L,8L,9L,10L,9L,10L,9L,10L,9L,10L,11L,10L,11L,10L,11L,10L,11L,12L,11L,12L,11L,12L,11L,12L,13L,12L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194511Inst : IEnumerable<long>
{
public static readonly long[] Value=A194511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194511.Bytes);
public long this[int i]=>Value[i];

public static A194511Inst Instance=new A194511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194512
{
public static readonly long[] Value={ 4L,1L,5L,2L,-1L,3L,0L,4L,1L,5L,2L,6L,3L,0L,4L,1L,5L,2L,6L,3L,7L,4L,1L,5L,2L,6L,3L,7L,4L,8L,5L,2L,6L,3L,7L,4L,8L,5L,9L,6L,3L,7L,4L,8L,5L,9L,6L,10L,7L,4L,8L,5L,9L,6L,10L,7L,11L,8L,5L,9L,6L,10L,7L,11L,8L,12L,9L,6L,10L,7L,11L,8L,12L,9L,13L,10L,7L,11L,8L,12L,9L,13L,10L,14L,11L,8L,12L,9L,13L,10L,14L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194512Inst : IEnumerable<long>
{
public static readonly long[] Value=A194512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194512.Bytes);
public long this[int i]=>Value[i];

public static A194512Inst Instance=new A194512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194513
{
public static readonly long[] Value={ -1L,0L,-1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,10L,9L,10L,9L,10L,9L,10L,9L,10L,11L,10L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194513Inst : IEnumerable<long>
{
public static readonly long[] Value=A194513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194513.Bytes);
public long this[int i]=>Value[i];

public static A194513Inst Instance=new A194513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194514
{
public static readonly long[] Value={ -1L,2L,1L,0L,-1L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,5L,4L,3L,2L,5L,4L,3L,6L,5L,4L,3L,6L,5L,4L,7L,6L,5L,4L,7L,6L,5L,8L,7L,6L,5L,8L,7L,6L,9L,8L,7L,6L,9L,8L,7L,10L,9L,8L,7L,10L,9L,8L,11L,10L,9L,8L,11L,10L,9L,12L,11L,10L,9L,12L,11L,10L,13L,12L,11L,10L,13L,12L,11L,14L,13L,12L,11L,14L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194514Inst : IEnumerable<long>
{
public static readonly long[] Value=A194514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194514.Bytes);
public long this[int i]=>Value[i];

public static A194514Inst Instance=new A194514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194515
{
public static readonly long[] Value={ 1L,-1L,0L,1L,2L,0L,1L,2L,0L,1L,2L,3L,1L,2L,3L,1L,2L,3L,4L,2L,3L,4L,2L,3L,4L,5L,3L,4L,5L,3L,4L,5L,6L,4L,5L,6L,4L,5L,6L,7L,5L,6L,7L,5L,6L,7L,8L,6L,7L,8L,6L,7L,8L,9L,7L,8L,9L,7L,8L,9L,10L,8L,9L,10L,8L,9L,10L,11L,9L,10L,11L,9L,10L,11L,12L,10L,11L,12L,10L,11L,12L,13L,11L,12L,13L,11L,12L,13L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194515Inst : IEnumerable<long>
{
public static readonly long[] Value=A194515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194515.Bytes);
public long this[int i]=>Value[i];

public static A194515Inst Instance=new A194515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194516
{
public static readonly long[] Value={ 2L,-1L,1L,3L,0L,2L,-1L,1L,3L,0L,2L,4L,1L,3L,0L,2L,4L,1L,3L,5L,2L,4L,1L,3L,5L,2L,4L,6L,3L,5L,2L,4L,6L,3L,5L,7L,4L,6L,3L,5L,7L,4L,6L,8L,5L,7L,4L,6L,8L,5L,7L,9L,6L,8L,5L,7L,9L,6L,8L,10L,7L,9L,6L,8L,10L,7L,9L,11L,8L,10L,7L,9L,11L,8L,10L,12L,9L,11L,8L,10L,12L,9L,11L,13L,10L,12L,9L,11L,13L,10L,12L,14L,11L,13L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194516Inst : IEnumerable<long>
{
public static readonly long[] Value=A194516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194516.Bytes);
public long this[int i]=>Value[i];

public static A194516Inst Instance=new A194516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194517
{
public static readonly long[] Value={ -1L,1L,0L,-1L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,3L,2L,1L,3L,2L,1L,3L,2L,4L,3L,2L,4L,3L,2L,4L,3L,5L,4L,3L,5L,4L,3L,5L,4L,6L,5L,4L,6L,5L,4L,6L,5L,7L,6L,5L,7L,6L,5L,7L,6L,8L,7L,6L,8L,7L,6L,8L,7L,9L,8L,7L,9L,8L,7L,9L,8L,10L,9L,8L,10L,9L,8L,10L,9L,11L,10L,9L,11L,10L,9L,11L,10L,12L,11L,10L,12L,11L,10L,12L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194517Inst : IEnumerable<long>
{
public static readonly long[] Value=A194517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194517.Bytes);
public long this[int i]=>Value[i];

public static A194517Inst Instance=new A194517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194518
{
public static readonly long[] Value={ -2L,3L,1L,-1L,4L,2L,0L,5L,3L,1L,-1L,4L,2L,0L,5L,3L,1L,6L,4L,2L,0L,5L,3L,1L,6L,4L,2L,7L,5L,3L,1L,6L,4L,2L,7L,5L,3L,8L,6L,4L,2L,7L,5L,3L,8L,6L,4L,9L,7L,5L,3L,8L,6L,4L,9L,7L,5L,10L,8L,6L,4L,9L,7L,5L,10L,8L,6L,11L,9L,7L,5L,10L,8L,6L,11L,9L,7L,12L,10L,8L,6L,11L,9L,7L,12L,10L,8L,13L,11L,9L,7L,12L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194518Inst : IEnumerable<long>
{
public static readonly long[] Value=A194518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194518.Bytes);
public long this[int i]=>Value[i];

public static A194518Inst Instance=new A194518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194519
{
public static readonly long[] Value={ 1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,2L,0L,1L,2L,0L,1L,2L,0L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,4L,2L,3L,4L,2L,3L,4L,2L,3L,4L,5L,3L,4L,5L,3L,4L,5L,3L,4L,5L,6L,4L,5L,6L,4L,5L,6L,4L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,8L,6L,7L,8L,6L,7L,8L,6L,7L,8L,9L,7L,8L,9L,7L,8L,9L,7L,8L,9L,10L,8L,9L,10L,8L,9L,10L,8L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194519Inst : IEnumerable<long>
{
public static readonly long[] Value=A194519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194519.Bytes);
public long this[int i]=>Value[i];

public static A194519Inst Instance=new A194519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194520
{
public static readonly long[] Value={ 3L,-2L,1L,4L,-1L,2L,5L,0L,3L,4L,1L,4L,-1L,2L,5L,0L,3L,6L,1L,4L,5L,2L,5L,0L,3L,6L,1L,4L,7L,2L,5L,6L,3L,6L,1L,4L,7L,2L,5L,8L,3L,6L,7L,4L,7L,2L,5L,8L,3L,6L,9L,4L,7L,8L,5L,8L,3L,6L,9L,4L,7L,10L,5L,8L,9L,6L,9L,4L,7L,10L,5L,8L,11L,6L,9L,10L,7L,10L,5L,8L,11L,6L,9L,12L,7L,10L,11L,8L,11L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194520Inst : IEnumerable<long>
{
public static readonly long[] Value=A194520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194520.Bytes);
public long this[int i]=>Value[i];

public static A194520Inst Instance=new A194520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194521
{
public static readonly long[] Value={ -1L,1L,0L,-1L,1L,0L,3L,1L,0L,-1L,1L,0L,2L,1L,0L,2L,1L,4L,2L,1L,0L,2L,1L,3L,2L,1L,3L,2L,5L,3L,2L,1L,3L,2L,4L,3L,2L,4L,3L,6L,4L,3L,2L,4L,3L,5L,4L,3L,5L,4L,7L,5L,4L,3L,5L,4L,6L,5L,4L,6L,5L,8L,6L,5L,4L,6L,5L,7L,6L,5L,7L,6L,9L,7L,6L,5L,7L,6L,8L,7L,6L,8L,7L,10L,8L,7L,6L,8L,7L,9L,8L,7L,9L,8L,11L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194521Inst : IEnumerable<long>
{
public static readonly long[] Value=A194521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194521.Bytes);
public long this[int i]=>Value[i];

public static A194521Inst Instance=new A194521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194522
{
public static readonly long[] Value={ -1L,-2L,2L,1L,0L,-1L,3L,2L,1L,0L,-1L,3L,2L,1L,0L,4L,3L,2L,1L,0L,4L,3L,2L,1L,5L,4L,3L,2L,1L,5L,4L,3L,2L,6L,5L,4L,3L,2L,6L,5L,4L,3L,7L,6L,5L,4L,3L,7L,6L,5L,4L,8L,7L,6L,5L,4L,8L,7L,6L,5L,9L,8L,7L,6L,5L,9L,8L,7L,6L,10L,9L,8L,7L,6L,10L,9L,8L,7L,11L,10L,9L,8L,7L,11L,10L,9L,8L,12L,11L,10L,9L,8L,12L,11L,10L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194522Inst : IEnumerable<long>
{
public static readonly long[] Value=A194522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194522.Bytes);
public long this[int i]=>Value[i];

public static A194522Inst Instance=new A194522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194523
{
public static readonly long[] Value={ 1L,2L,1L,0L,1L,2L,-1L,0L,1L,2L,3L,2L,1L,2L,3L,0L,1L,2L,3L,4L,3L,2L,3L,4L,1L,2L,3L,4L,5L,4L,3L,4L,5L,2L,3L,4L,5L,6L,5L,4L,5L,6L,3L,4L,5L,6L,7L,6L,5L,6L,7L,4L,5L,6L,7L,8L,7L,6L,7L,8L,5L,6L,7L,8L,9L,8L,7L,8L,9L,6L,7L,8L,9L,10L,9L,8L,9L,10L,7L,8L,9L,10L,11L,10L,9L,10L,11L,8L,9L,10L,11L,12L,11L,10L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194523Inst : IEnumerable<long>
{
public static readonly long[] Value=A194523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194523.Bytes);
public long this[int i]=>Value[i];

public static A194523Inst Instance=new A194523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194524
{
public static readonly long[] Value={ 2L,4L,-1L,1L,3L,-2L,0L,2L,4L,-1L,1L,3L,5L,0L,2L,4L,-1L,1L,3L,5L,0L,2L,4L,6L,1L,3L,5L,0L,2L,4L,6L,1L,3L,5L,7L,2L,4L,6L,1L,3L,5L,7L,2L,4L,6L,8L,3L,5L,7L,2L,4L,6L,8L,3L,5L,7L,9L,4L,6L,8L,3L,5L,7L,9L,4L,6L,8L,10L,5L,7L,9L,4L,6L,8L,10L,5L,7L,9L,11L,6L,8L,10L,5L,7L,9L,11L,6L,8L,10L,12L,7L,9L,11L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194524Inst : IEnumerable<long>
{
public static readonly long[] Value=A194524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194524.Bytes);
public long this[int i]=>Value[i];

public static A194524Inst Instance=new A194524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194525
{
public static readonly long[] Value={ -1L,-2L,1L,0L,-1L,2L,1L,0L,-1L,2L,1L,0L,-1L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,5L,4L,3L,2L,5L,4L,3L,2L,5L,4L,3L,6L,5L,4L,3L,6L,5L,4L,3L,6L,5L,4L,7L,6L,5L,4L,7L,6L,5L,4L,7L,6L,5L,8L,7L,6L,5L,8L,7L,6L,5L,8L,7L,6L,9L,8L,7L,6L,9L,8L,7L,6L,9L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194525Inst : IEnumerable<long>
{
public static readonly long[] Value=A194525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194525.Bytes);
public long this[int i]=>Value[i];

public static A194525Inst Instance=new A194525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194526
{
public static readonly long[] Value={ -1L,-2L,3L,2L,1L,0L,-1L,-2L,3L,2L,-1L,0L,-1L,4L,3L,2L,1L,0L,-1L,4L,3L,0L,1L,0L,5L,4L,3L,2L,1L,0L,5L,4L,1L,2L,1L,6L,5L,4L,3L,2L,1L,6L,5L,2L,3L,2L,7L,6L,5L,4L,3L,2L,7L,6L,3L,4L,3L,8L,7L,6L,5L,4L,3L,8L,7L,4L,5L,4L,9L,8L,7L,6L,5L,4L,9L,8L,5L,6L,5L,10L,9L,8L,7L,6L,5L,10L,9L,6L,7L,6L,11L,10L,9L,8L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194526Inst : IEnumerable<long>
{
public static readonly long[] Value=A194526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194526.Bytes);
public long this[int i]=>Value[i];

public static A194526Inst Instance=new A194526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194527
{
public static readonly long[] Value={ 1L,2L,-2L,-1L,0L,1L,2L,3L,-1L,0L,2L,2L,3L,-1L,0L,1L,2L,3L,4L,0L,1L,3L,3L,4L,0L,1L,2L,3L,4L,5L,1L,2L,4L,4L,5L,1L,2L,3L,4L,5L,6L,2L,3L,5L,5L,6L,2L,3L,4L,5L,6L,7L,3L,4L,6L,6L,7L,3L,4L,5L,6L,7L,8L,4L,5L,7L,7L,8L,4L,5L,6L,7L,8L,9L,5L,6L,8L,8L,9L,5L,6L,7L,8L,9L,10L,6L,7L,9L,9L,10L,6L,7L,8L,9L,10L,11L,7L,8L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194527Inst : IEnumerable<long>
{
public static readonly long[] Value=A194527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194527.Bytes);
public long this[int i]=>Value[i];

public static A194527Inst Instance=new A194527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194528
{
public static readonly long[] Value={ -3L,2L,-1L,4L,1L,-2L,3L,0L,-3L,2L,-1L,-4L,1L,-2L,3L,0L,5L,2L,-1L,4L,1L,-2L,3L,0L,-3L,2L,-1L,4L,1L,6L,3L,0L,5L,2L,-1L,4L,1L,-2L,3L,0L,5L,2L,7L,4L,1L,6L,3L,0L,5L,2L,-1L,4L,1L,6L,3L,8L,5L,2L,7L,4L,1L,6L,3L,0L,5L,2L,7L,4L,9L,6L,3L,8L,5L,2L,7L,4L,1L,6L,3L,8L,5L,10L,7L,4L,9L,6L,3L,8L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194528Inst : IEnumerable<long>
{
public static readonly long[] Value=A194528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194528.Bytes);
public long this[int i]=>Value[i];

public static A194528Inst Instance=new A194528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194529
{
public static readonly long[] Value={ 2L,-1L,1L,-2L,0L,2L,-1L,1L,3L,0L,2L,4L,1L,3L,0L,2L,-1L,1L,3L,0L,2L,4L,1L,3L,5L,2L,4L,1L,3L,0L,2L,4L,1L,3L,5L,2L,4L,6L,3L,5L,2L,4L,1L,3L,5L,2L,4L,6L,3L,5L,7L,4L,6L,3L,5L,2L,4L,6L,3L,5L,7L,4L,6L,8L,5L,7L,4L,6L,3L,5L,7L,4L,6L,8L,5L,7L,9L,6L,8L,5L,7L,4L,6L,8L,5L,7L,9L,6L,8L,10L,7L,9L,6L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194529Inst : IEnumerable<long>
{
public static readonly long[] Value=A194529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194529.Bytes);
public long this[int i]=>Value[i];

public static A194529Inst Instance=new A194529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194530
{
public static readonly BigInteger[] Value={ 0L,1L,3L,9L,32L,132L,623L,3314L,19628L,128126L,914005L,7074517L,59050739L,528741491L,5055414317L,51406084221L,553946196892L,6305737560455L,75610546284387L,952559077043183L,12579235034203780L,173759983171005721L,2505751777457313815L,BigInteger.Parse("37657189917162605826") };
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
public class A194530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194530Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194530.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194530.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194530Inst Instance=new A194530Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194531
{
public static readonly long[] Value={ 0L,1L,1L,2L,5L,5L,7L,28L,3L,15L,55L,22L,13L,91L,35L,40L,34L,51L,57L,190L,35L,77L,253L,92L,25L,325L,117L,126L,203L,145L,155L,496L,44L,187L,595L,210L,111L,703L,247L,260L,205L,287L,301L,946L,165L,345L,1081L,376L,98L,1225L,425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194531Inst : IEnumerable<long>
{
public static readonly long[] Value=A194531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194531.Bytes);
public long this[int i]=>Value[i];

public static A194531Inst Instance=new A194531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194532
{
public static readonly long[] Value={ 1L,21L,91L,336L,651L,1911L,2451L,5376L,7371L,13671L,14763L,30576L,28731L,51471L,59241L,86016L,83811L,154791L,130683L,218736L,223041L,310023L,280371L,489216L,406875L,603351L,597051L,823536L,708123L,1244061L,924483L,1376256L,1343433L,1760031L,1595601L,2476656L,1875531L,2744343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194532Inst : IEnumerable<long>
{
public static readonly long[] Value=A194532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194532.Bytes);
public long this[int i]=>Value[i];

public static A194532Inst Instance=new A194532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194533
{
public static readonly long[] Value={ 1L,85L,820L,5440L,16276L,69700L,120100L,348160L,597780L,1383460L,1786324L,4460800L,4855540L,10208500L,13346320L,22282240L,24221380L,50811300L,47176564L,88541440L,98482000L,151837540L,148316260L,285491200L,254312500L,412720900L,435781620L,653344000L,595531444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194533Inst : IEnumerable<long>
{
public static readonly long[] Value=A194533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194533.Bytes);
public long this[int i]=>Value[i];

public static A194533Inst Instance=new A194533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194534
{
public static readonly BigInteger[] Value={ 1L,4L,59L,1851L,119548L,16039294L,4460214471L,2572187445993L,3075932897564028L,7627704068111688574L,BigInteger.Parse("39223874584658826539499"),BigInteger.Parse("418261269510360187893175534"),BigInteger.Parse("9248796169262343437995449320699"),BigInteger.Parse("424095060368117191810477243815045914") };
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
public class A194534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194534Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194534.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194534.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194534Inst Instance=new A194534Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194535
{
public static readonly BigInteger[] Value={ 1L,4L,116L,16556L,7721920L,11525456507L,54979732214116L,838387866908847478L,BigInteger.Parse("40866499579695484000499"),BigInteger.Parse("6367568042830726931523028453"),BigInteger.Parse("3171485572844765112503023656979959") };
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
public class A194535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194535Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194535.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194535.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194535Inst Instance=new A194535Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194536
{
public static readonly BigInteger[] Value={ 1L,4L,131L,43785L,79201795L,627974590650L,21399815343394998L,BigInteger.Parse("3132305932642809585983"),BigInteger.Parse("1969210116072259125767299138") };
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
public class A194536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194536Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194536.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194536.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194536Inst Instance=new A194536Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194537
{
public static readonly BigInteger[] Value={ 1L,4L,132L,62038L,286773762L,8096809998526L,1243336605965267360L,BigInteger.Parse("1026437889413641002431445") };
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
public class A194537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194537Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194537.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194537.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194537Inst Instance=new A194537Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194538
{
public static readonly BigInteger[] Value={ 1L,4L,132L,67377L,543350470L,40994098419294L,BigInteger.Parse("21253155706215768591"),BigInteger.Parse("71381360690596538575641162") };
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
public class A194538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194538Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194538.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194538.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194538Inst Instance=new A194538Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194539
{
public static readonly BigInteger[] Value={ 1L,4L,132L,68106L,703256449L,108504879480483L,BigInteger.Parse("153378412416345530447") };
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
public class A194539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194539Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194539.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194539.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194539Inst Instance=new A194539Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194540
{
public static readonly long[] Value={ 1L,1L,3L,1L,4L,6L,1L,4L,59L,12L,1L,4L,116L,1851L,23L,1L,4L,131L,16556L,119548L,43L,1L,4L,132L,43785L,7721920L,16039294L,79L,1L,4L,132L,62038L,79201795L,11525456507L,4460214471L,143L,1L,4L,132L,67377L,286773762L,627974590650L,54979732214116L,2572187445993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194540Inst : IEnumerable<long>
{
public static readonly long[] Value=A194540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194540.Bytes);
public long this[int i]=>Value[i];

public static A194540Inst Instance=new A194540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194541
{
public static readonly long[] Value={ 1L,5L,16L,47L,130L,357L,973L,2647L,7197L,19564L,53181L,144561L,392958L,1068172L,2903593L,7892784L,21454811L,58320223L,158530804L,430931404L,1171393005L,3184176320L,8655488630L,23528057461L,63955891057L,173850136486L,472573666887L,1284588411309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194541Inst : IEnumerable<long>
{
public static readonly long[] Value=A194541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194541.Bytes);
public long this[int i]=>Value[i];

public static A194541Inst Instance=new A194541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194542
{
public static readonly long[] Value={ 1L,2L,15L,18L,36L,42L,72L,78L,84L,126L,132L,140L,165L,168L,192L,200L,204L,234L,252L,260L,264L,270L,280L,288L,348L,400L,408L,440L,462L,504L,520L,546L,560L,741L,816L,825L,880L,882L,888L,912L,1040L,1044L,1248L,1464L,1470L,1632L,1638L,1692L,1710L,1749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194542Inst : IEnumerable<long>
{
public static readonly long[] Value=A194542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194542.Bytes);
public long this[int i]=>Value[i];

public static A194542Inst Instance=new A194542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194543
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,3L,2L,1L,1L,5L,2L,2L,1L,1L,7L,3L,2L,2L,1L,1L,11L,4L,3L,2L,2L,1L,1L,15L,5L,3L,3L,2L,2L,1L,1L,22L,6L,4L,3L,3L,2L,2L,1L,1L,30L,8L,5L,4L,3L,3L,2L,2L,1L,1L,42L,10L,6L,4L,4L,3L,3L,2L,2L,1L,1L,56L,12L,7L,5L,4L,4L,3L,3L,2L,2L,1L,1L,77L,15L,9L,6L,5L,4L,4L,3L,3L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194543Inst : IEnumerable<long>
{
public static readonly long[] Value=A194543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194543.Bytes);
public long this[int i]=>Value[i];

public static A194543Inst Instance=new A194543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194544
{
public static readonly long[] Value={ 0L,0L,2L,3L,10L,14L,33L,46L,87L,125L,208L,291L,461L,633L,942L,1292L,1851L,2491L,3484L,4629L,6321L,8326L,11143L,14513L,19168L,24720L,32185L,41193L,53030L,67297L,85830L,108116L,136651L,171040L,214462L,266731L,332197L,410730L,508201L,625082L,768920L,940938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194544Inst : IEnumerable<long>
{
public static readonly long[] Value=A194544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194544.Bytes);
public long this[int i]=>Value[i];

public static A194544Inst Instance=new A194544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194545
{
public static readonly long[] Value={ 0L,1L,2L,4L,11L,16L,33L,48L,89L,134L,214L,305L,478L,663L,976L,1356L,1934L,2617L,3654L,4877L,6652L,8808L,11772L,15386L,20329L,26308L,34249L,43987L,56651L,72079L,92008L,116171L,146967L,184381L,231399L,288398L,359581L,445426L,551721L,679868L,837238L,1026256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194545Inst : IEnumerable<long>
{
public static readonly long[] Value=A194545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194545.Bytes);
public long this[int i]=>Value[i];

public static A194545Inst Instance=new A194545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194546
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,3L,2L,4L,1L,2L,3L,2L,4L,3L,5L,1L,2L,3L,2L,4L,3L,5L,2L,4L,3L,6L,1L,2L,3L,2L,4L,3L,5L,2L,4L,3L,6L,3L,5L,4L,7L,1L,2L,3L,2L,4L,3L,5L,2L,4L,3L,6L,3L,5L,4L,7L,2L,4L,3L,6L,5L,4L,8L,1L,2L,3L,2L,4L,3L,5L,2L,4L,3L,6L,3L,5L,4L,7L,2L,4L,3L,6L,5L,4L,8L,3L,5L,4L,7L,3L,6L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194546Inst : IEnumerable<long>
{
public static readonly long[] Value=A194546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194546.Bytes);
public long this[int i]=>Value[i];

public static A194546Inst Instance=new A194546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194547
{
public static readonly long[] Value={ 0L,-1L,1L,-2L,0L,2L,-3L,-1L,1L,0L,3L,-4L,-2L,0L,-1L,2L,1L,4L,-5L,-3L,-1L,-2L,1L,0L,3L,-1L,2L,1L,5L,-6L,-4L,-2L,-3L,0L,-1L,2L,-2L,1L,0L,4L,0L,3L,2L,6L,-7L,-5L,-3L,-4L,-1L,-2L,1L,-3L,0L,-1L,3L,-1L,2L,1L,5L,-2L,1L,0L,4L,3L,2L,7L,-8L,-6L,-4L,-5L,-2L,-3L,0L,-4L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194547Inst : IEnumerable<long>
{
public static readonly long[] Value=A194547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194547.Bytes);
public long this[int i]=>Value[i];

public static A194547Inst Instance=new A194547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194548
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,1L,3L,2L,2L,1L,3L,2L,2L,1L,4L,3L,3L,2L,2L,2L,1L,4L,3L,3L,2L,3L,2L,2L,1L,5L,4L,4L,3L,3L,3L,2L,3L,2L,2L,2L,1L,5L,4L,4L,3L,4L,3L,3L,2L,3L,3L,2L,2L,2L,1L,6L,5L,5L,4L,4L,4L,3L,4L,3L,3L,3L,2L,4L,3L,3L,2L,3L,2L,2L,2L,1L,6L,5L,5L,4L,5L,4L,4L,3L,4L,4L,3L,3L,3L,2L,4L,3L,3L,3L,2L,3L,2L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194548Inst : IEnumerable<long>
{
public static readonly long[] Value=A194548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194548.Bytes);
public long this[int i]=>Value[i];

public static A194548Inst Instance=new A194548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194549
{
public static readonly long[] Value={ 1L,1L,2L,0L,3L,1L,4L,-1L,2L,1L,5L,0L,3L,2L,6L,-2L,1L,0L,4L,3L,2L,7L,-1L,2L,1L,5L,0L,4L,3L,8L,-3L,0L,-1L,3L,2L,1L,6L,1L,5L,4L,3L,9L,-2L,1L,0L,4L,-1L,3L,2L,7L,2L,1L,6L,5L,4L,10L,-4L,-1L,-2L,2L,1L,0L,5L,0L,4L,3L,2L,8L,-1L,3L,2L,7L,1L,6L,5L,4L,11L,-3L,0L,-1L,3L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194549Inst : IEnumerable<long>
{
public static readonly long[] Value=A194549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194549.Bytes);
public long this[int i]=>Value[i];

public static A194549Inst Instance=new A194549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194550
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,2L,1L,4L,1L,3L,1L,5L,1L,2L,1L,4L,1L,3L,1L,6L,1L,3L,1L,5L,1L,4L,1L,7L,1L,2L,1L,4L,1L,3L,1L,6L,1L,5L,1L,4L,1L,8L,1L,3L,1L,5L,1L,4L,1L,7L,1L,3L,1L,6L,1L,5L,1L,9L,1L,2L,1L,4L,1L,3L,1L,6L,1L,5L,1L,4L,1L,8L,1L,4L,1L,7L,1L,6L,1L,5L,1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194550Inst : IEnumerable<long>
{
public static readonly long[] Value=A194550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194550.Bytes);
public long this[int i]=>Value[i];

public static A194550Inst Instance=new A194550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194551
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,3L,6L,4L,7L,5L,4L,8L,3L,6L,5L,9L,4L,7L,6L,5L,10L,5L,4L,8L,7L,6L,11L,3L,6L,5L,9L,4L,8L,7L,6L,12L,4L,7L,6L,5L,10L,5L,9L,8L,7L,13L,5L,4L,8L,7L,6L,11L,6L,5L,10L,9L,8L,7L,14L,3L,6L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194551Inst : IEnumerable<long>
{
public static readonly long[] Value=A194551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194551.Bytes);
public long this[int i]=>Value[i];

public static A194551Inst Instance=new A194551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194552
{
public static readonly long[] Value={ 0L,2L,5L,13L,23L,47L,75L,131L,203L,323L,477L,729L,1041L,1517L,2132L,3012L,4134L,5718L,7713L,10453L,13918L,18538L,24357L,32037L,41612L,54040L,69538L,89362L,113925L,145095L,183473L,231697L,290899L,364577L,454632L,566016L,701436L,867800L,1069430L,1315550L,1612595L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194552Inst : IEnumerable<long>
{
public static readonly long[] Value=A194552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194552.Bytes);
public long this[int i]=>Value[i];

public static A194552Inst Instance=new A194552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194553
{
public static readonly BigInteger[] Value={ 1L,33554433L,847322163875L,1126747195452067L,299149123783795749L,BigInteger.Parse("28728311253806654501"),BigInteger.Parse("1369498907693894602183"),BigInteger.Parse("39120000482621126610375"),BigInteger.Parse("755676919554809750479817"),BigInteger.Parse("10717897987691852588770249"),BigInteger.Parse("118347059433883722041830251") };
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
public class A194553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194553Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194553.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194553.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194553Inst Instance=new A194553Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194554
{
public static readonly long[] Value={ 9L,7L,5L,6L,7L,8L,8L,4L,7L,8L,0L,3L,6L,6L,9L,3L,8L,5L,6L,4L,3L,4L,6L,8L,9L,6L,6L,0L,5L,5L,4L,2L,3L,1L,1L,0L,5L,2L,2L,9L,4L,6L,9L,7L,1L,6L,4L,8L,1L,0L,8L,5L,3L,7L,6L,8L,8L,7L,2L,0L,2L,6L,5L,0L,3L,7L,8L,0L,6L,6L,8L,4L,2L,2L,9L,8L,4L,5L,8L,4L,4L,2L,7L,9L,4L,9L,0L,8L,2L,6L,2L,6L,7L,2L,7L,4L,4L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194554Inst : IEnumerable<long>
{
public static readonly long[] Value=A194554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194554.Bytes);
public long this[int i]=>Value[i];

public static A194554Inst Instance=new A194554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194555
{
public static readonly long[] Value={ 2L,1L,9L,2L,0L,4L,8L,9L,4L,9L,0L,0L,8L,7L,6L,1L,3L,2L,8L,9L,0L,7L,6L,7L,9L,4L,9L,7L,4L,4L,6L,5L,7L,2L,6L,5L,8L,7L,3L,6L,9L,2L,6L,4L,6L,1L,1L,9L,0L,7L,9L,6L,3L,9L,2L,6L,4L,8L,5L,0L,9L,2L,1L,7L,3L,8L,9L,3L,1L,7L,0L,7L,6L,5L,2L,1L,9L,9L,7L,4L,7L,2L,2L,3L,5L,3L,0L,1L,9L,5L,4L,0L,6L,1L,5L,3L,4L,6L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194555Inst : IEnumerable<long>
{
public static readonly long[] Value=A194555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194555.Bytes);
public long this[int i]=>Value[i];

public static A194555Inst Instance=new A194555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194556
{
public static readonly long[] Value={ 1L,5L,4L,3L,8L,8L,8L,7L,3L,5L,8L,5L,5L,2L,5L,8L,3L,1L,8L,3L,6L,0L,4L,4L,6L,0L,0L,1L,3L,0L,7L,4L,9L,0L,9L,7L,1L,8L,8L,7L,1L,4L,9L,4L,2L,7L,9L,6L,8L,0L,2L,7L,2L,4L,1L,2L,8L,5L,4L,3L,3L,0L,4L,5L,3L,2L,9L,4L,4L,1L,8L,3L,6L,3L,0L,2L,2L,0L,7L,2L,0L,7L,9L,6L,9L,2L,3L,7L,0L,7L,3L,2L,6L,2L,5L,7L,6L,1L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194556Inst : IEnumerable<long>
{
public static readonly long[] Value=A194556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194556.Bytes);
public long this[int i]=>Value[i];

public static A194556Inst Instance=new A194556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194557
{
public static readonly long[] Value={ 1L,7L,3L,6L,1L,9L,0L,5L,2L,5L,0L,9L,5L,3L,1L,3L,5L,2L,1L,5L,4L,1L,5L,7L,1L,4L,8L,2L,6L,8L,3L,3L,2L,6L,7L,5L,8L,2L,2L,9L,5L,5L,3L,2L,1L,8L,4L,8L,9L,0L,8L,6L,4L,0L,7L,8L,4L,5L,4L,6L,9L,6L,0L,5L,7L,4L,4L,6L,7L,6L,3L,7L,4L,5L,8L,4L,3L,3L,5L,6L,3L,1L,2L,3L,2L,3L,4L,2L,1L,7L,1L,0L,0L,6L,1L,8L,3L,5L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194557Inst : IEnumerable<long>
{
public static readonly long[] Value=A194557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194557.Bytes);
public long this[int i]=>Value[i];

public static A194557Inst Instance=new A194557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194558
{
public static readonly long[] Value={ 1L,1L,2L,3L,11L,15L,88L,115L,893L,1261L,12226L,16111L,221227L,282583L,4411016L,6248747L,113517609L,148484297L,3421012690L,4385030203L,110766993131L,153110987871L,4175683922312L,5442592336083L,179150412103621L,229026788618389L,7917824064488690L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194558Inst : IEnumerable<long>
{
public static readonly long[] Value=A194558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194558.Bytes);
public long this[int i]=>Value[i];

public static A194558Inst Instance=new A194558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194559
{
public static readonly BigInteger[] Value={ 1L,1L,4L,18L,132L,900L,10560L,96600L,1500240L,19066320L,369714240L,5359163040L,147177898560L,2443958637120L,76298578836480L,1621294897622400L,58906376034105600L,1309870975014201600L,BigInteger.Parse("60357698670132864000"),BigInteger.Parse("1469955465552513139200"),BigInteger.Parse("74262907856067567436800") };
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
public class A194559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194559Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194559.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194559.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194559Inst Instance=new A194559Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194560
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,10L,2L,20L,14L,49L,2L,217L,2L,438L,310L,1580L,2L,6352L,2L,18062L,7824L,58799L,2L,258971L,2532L,742915L,246794L,2729095L,2L,11154954L,2L,35779660L,8414818L,129644809L,242354L,531132915L,2L,1767263211L,300830821L,6593815523L,2L,26289925026L,2L,91708135773L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194560Inst : IEnumerable<long>
{
public static readonly long[] Value=A194560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194560.Bytes);
public long this[int i]=>Value[i];

public static A194560Inst Instance=new A194560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194561
{
public static readonly BigInteger[] Value={ 1L,134217729L,7625731702715L,18022024106966971L,7468594995433310109L,BigInteger.Parse("1030940949674393077661"),BigInteger.Parse("66735852732611749389079"),BigInteger.Parse("2483564001592792629551895") };
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
public class A194561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194561Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194561.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194561.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194561Inst Instance=new A194561Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194562
{
public static readonly long[] Value={ 0L,9L,4L,0L,4L,7L,8L,2L,7L,6L,1L,6L,6L,9L,9L,0L,1L,6L,1L,7L,4L,3L,3L,4L,3L,3L,2L,0L,8L,4L,4L,9L,3L,9L,9L,2L,7L,8L,5L,3L,3L,8L,0L,2L,9L,6L,1L,8L,4L,1L,8L,4L,8L,8L,0L,1L,4L,2L,1L,9L,3L,5L,4L,5L,6L,0L,1L,7L,5L,3L,4L,5L,6L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194562Inst : IEnumerable<long>
{
public static readonly long[] Value=A194562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194562.Bytes);
public long this[int i]=>Value[i];

public static A194562Inst Instance=new A194562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194563
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,11L,29L,71L,172L,429L,1109L,2920L,7730L,20589L,55059L,147881L,399684L,1086523L,2968414L,8145414L,22432134L,61964161L,171621042L,476482795L,1325825751L,3696818803L,10328130168L,28908075633L,81053999054L,227636478284L,640289071629L,1803570718863L,5087114281297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194563Inst : IEnumerable<long>
{
public static readonly long[] Value=A194563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194563.Bytes);
public long this[int i]=>Value[i];

public static A194563Inst Instance=new A194563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194564
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,2L,4L,2L,2L,1L,2L,4L,2L,2L,0L,1L,3L,9L,9L,13L,5L,5L,1L,3L,9L,9L,13L,5L,5L,0L,1L,4L,16L,24L,46L,34L,44L,14L,14L,1L,4L,16L,24L,46L,34L,44L,14L,14L,0L,1L,5L,25L,50L,120L,130L,208L,126L,154L,42L,42L,1L,5L,25L,50L,120L,130L,208L,126L,154L,42L,42L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194564Inst : IEnumerable<long>
{
public static readonly long[] Value=A194564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194564.Bytes);
public long this[int i]=>Value[i];

public static A194564Inst Instance=new A194564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194565
{
public static readonly long[] Value={ 122L,123L,127L,130L,138L,143L,155L,162L,163L,164L,170L,173L,178L,185L,187L,190L,204L,205L,207L,208L,213L,215L,216L,218L,232L,237L,239L,242L,244L,245L,246L,248L,249L,251L,255L,256L,259L,261L,266L,268L,270L,278L,279L,283L,284L,286L,287L,289L,295L,298L,299L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194565Inst : IEnumerable<long>
{
public static readonly long[] Value=A194565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194565.Bytes);
public long this[int i]=>Value[i];

public static A194565Inst Instance=new A194565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194566
{
public static readonly BigInteger[] Value={ 1L,BigInteger.Parse("1267650600228229401496703205377"),BigInteger.Parse("515377520732011332304111729993850674198810727377"),BigInteger.Parse("1606938044259505653062694103672199063651968615055494942823377") };
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
public class A194566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194566Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194566.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194566.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194566Inst Instance=new A194566Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194567
{
public static readonly long[] Value={ 2L,8L,2L,1L,4L,3L,9L,3L,7L,2L,1L,2L,2L,0L,7L,8L,8L,9L,3L,4L,0L,3L,1L,9L,1L,3L,3L,0L,2L,9L,4L,4L,8L,5L,1L,9L,5L,3L,4L,5L,8L,8L,1L,7L,4L,4L,0L,7L,3L,1L,1L,4L,0L,9L,2L,2L,7L,9L,8L,5L,7L,6L,9L,3L,9L,4L,1L,2L,1L,4L,3L,0L,4L,5L,0L,5L,5L,1L,7L,3L,9L,1L,2L,4L,5L,6L,8L,6L,5L,6L,5L,3L,4L,7L,8L,3L,9L,6L,4L,4L,3L,8L,9L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194567Inst : IEnumerable<long>
{
public static readonly long[] Value=A194567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194567.Bytes);
public long this[int i]=>Value[i];

public static A194567Inst Instance=new A194567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194568
{
public static readonly long[] Value={ 78L,4044L,5064L,294380L,1691586L,8413520L,68121168L,663003222L,966241404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194568Inst : IEnumerable<long>
{
public static readonly long[] Value=A194568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194568.Bytes);
public long this[int i]=>Value[i];

public static A194568Inst Instance=new A194568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194569
{
public static readonly BigInteger[] Value={ 1L,4L,25L,232L,3182L,65372L,1988549L,90079152L,6068358966L,607621801869L,90481144660781L,20030966609918016L,6592839659614699902L,BigInteger.Parse("3226130598077418710561"),BigInteger.Parse("2346968934938492776129480") };
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
public class A194569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194569Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194569.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194569.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194569Inst Instance=new A194569Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194570
{
public static readonly BigInteger[] Value={ 1L,5L,113L,7696L,1429748L,723276072L,996233663484L,3736289882783364L,BigInteger.Parse("38153100681294466800"),BigInteger.Parse("1060791108320009447746940"),BigInteger.Parse("80304497397124644777045379184"),BigInteger.Parse("16552355212984292716901267397576440") };
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
public class A194570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194570Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194570.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194570.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194570Inst Instance=new A194570Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194571
{
public static readonly BigInteger[] Value={ 1L,5L,178L,39317L,35539864L,123214409287L,1633861873067053L,BigInteger.Parse("82861549363088245839"),BigInteger.Parse("16072167254492939441649954"),BigInteger.Parse("11922831948374582734623213683388") };
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
public class A194571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194571Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194571.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194571.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194571Inst Instance=new A194571Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194572
{
public static readonly BigInteger[] Value={ 1L,5L,193L,80780L,225623340L,3211386454648L,223665935176544829L,BigInteger.Parse("76009506543180381646618"),BigInteger.Parse("126023279808505699474721273930"),BigInteger.Parse("1019406708191445081689134021299430885") };
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
public class A194572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194572Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194572.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194572.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194572Inst Instance=new A194572Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194573
{
public static readonly BigInteger[] Value={ 1L,5L,194L,103442L,625181527L,26882336930339L,7006905313120058520L,BigInteger.Parse("10818569910116671839072764"),BigInteger.Parse("98751690024107856003006162934229") };
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
public class A194573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194573Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194573.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194573.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194573Inst Instance=new A194573Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194574
{
public static readonly BigInteger[] Value={ 1L,5L,194L,109314L,1023490379L,103716766788027L,BigInteger.Parse("80480437921181928079"),BigInteger.Parse("438719474917484694724554104") };
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
public class A194574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194574Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194574.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194574.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194574Inst Instance=new A194574Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194575
{
public static readonly BigInteger[] Value={ 1L,5L,194L,110064L,1237399743L,230795314260831L,BigInteger.Parse("443383367826271457152"),BigInteger.Parse("7112925826561472131385895933") };
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
public class A194575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194575Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194575.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194575.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194575Inst Instance=new A194575Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194576
{
public static readonly long[] Value={ 1L,1L,4L,1L,5L,25L,1L,5L,113L,232L,1L,5L,178L,7696L,3182L,1L,5L,193L,39317L,1429748L,65372L,1L,5L,194L,80780L,35539864L,723276072L,1988549L,1L,5L,194L,103442L,225623340L,123214409287L,996233663484L,90079152L,1L,5L,194L,109314L,625181527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194576Inst : IEnumerable<long>
{
public static readonly long[] Value=A194576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194576.Bytes);
public long this[int i]=>Value[i];

public static A194576Inst Instance=new A194576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194577
{
public static readonly long[] Value={ 1L,1L,-2L,4L,-2L,-4L,-2L,12L,2L,-4L,-2L,-16L,-2L,-4L,6L,36L,-2L,8L,-2L,-16L,6L,-4L,-2L,-56L,2L,-4L,-2L,-16L,-2L,20L,-2L,108L,6L,-4L,6L,36L,-2L,-4L,6L,-56L,-2L,20L,-2L,-16L,-10L,-4L,-2L,-192L,2L,8L,6L,-16L,-2L,-12L,6L,-56L,6L,-4L,-2L,88L,-2L,-4L,-10L,324L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194577Inst : IEnumerable<long>
{
public static readonly long[] Value=A194577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194577.Bytes);
public long this[int i]=>Value[i];

public static A194577Inst Instance=new A194577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194578
{
public static readonly long[] Value={ 1L,3L,43L,68L,93L,228L,612L,1903L,32292L,44868L,252072L,36564198L,55862807L,134735264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194578Inst : IEnumerable<long>
{
public static readonly long[] Value=A194578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194578.Bytes);
public long this[int i]=>Value[i];

public static A194578Inst Instance=new A194578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194579
{
public static readonly long[] Value={ 4L,6L,8L,10L,12L,16L,22L,27L,28L,32L,40L,44L,46L,52L,58L,68L,80L,82L,88L,106L,112L,116L,124L,125L,136L,148L,164L,165L,166L,172L,176L,178L,192L,208L,226L,232L,236L,250L,256L,262L,284L,292L,304L,316L,328L,332L,346L,352L,358L,368L,382L,388L,420L,428L,435L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194579Inst : IEnumerable<long>
{
public static readonly long[] Value=A194579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194579.Bytes);
public long this[int i]=>Value[i];

public static A194579Inst Instance=new A194579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194580
{
public static readonly long[] Value={ 1L,15L,35L,143L,243L,323L,465L,899L,1183L,1386L,1763L,2065L,2352L,3060L,3599L,3612L,3696L,3887L,5183L,5358L,5590L,9889L,10403L,11663L,12337L,12740L,12879L,14329L,14455L,14645L,16401L,19043L,19097L,20835L,22477L,22499L,22678L,23427L,25553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194580Inst : IEnumerable<long>
{
public static readonly long[] Value=A194580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194580.Bytes);
public long this[int i]=>Value[i];

public static A194580Inst Instance=new A194580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194581
{
public static readonly long[] Value={ 3L,7L,13L,19L,43L,103L,109L,193L,229L,313L,349L,401L,463L,491L,509L,643L,743L,761L,823L,859L,883L,911L,997L,1093L,1237L,1279L,1303L,1429L,1459L,1483L,1489L,1499L,1571L,1609L,1637L,1831L,1873L,1999L,2003L,2069L,2083L,2221L,2239L,2243L,2251L,2269L,2273L,2399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194581Inst : IEnumerable<long>
{
public static readonly long[] Value=A194581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194581.Bytes);
public long this[int i]=>Value[i];

public static A194581Inst Instance=new A194581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194582
{
public static readonly long[] Value={ 1L,0L,1L,0L,3L,1L,0L,2L,6L,1L,0L,2L,13L,9L,1L,0L,2L,16L,33L,12L,1L,0L,2L,20L,69L,62L,15L,1L,0L,2L,24L,108L,188L,100L,18L,1L,0L,2L,28L,156L,401L,400L,147L,21L,1L,0L,2L,32L,212L,704L,1115L,732L,203L,24L,1L,0L,2L,36L,276L,1120L,2433L,2547L,1211L,268L,27L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194582Inst : IEnumerable<long>
{
public static readonly long[] Value=A194582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194582.Bytes);
public long this[int i]=>Value[i];

public static A194582Inst Instance=new A194582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194583
{
public static readonly BigInteger[] Value={ 1L,1L,3L,1L,7L,43L,1L,15L,211L,2619L,1L,31L,931L,26251L,654811L,1L,63L,3907L,234795L,13255291L,662827803L,1L,127L,16003L,1985131L,238658491L,26961325147L,2699483026843L,1L,255L,64771L,16323819L,4050110011L,973958217435L,220115609012251L,44102911693372059L,1L,511L,260611L,132393451L,66733574971L,33115631264731L,15928113739803931L,7200501591899676571L,BigInteger.Parse("2886238576935227688091") };
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
public class A194583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194583Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194583.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194583.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194583Inst Instance=new A194583Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194584
{
public static readonly long[] Value={ 5L,3L,5L,5L,3L,5L,3L,5L,5L,3L,5L,5L,3L,5L,3L,5L,5L,3L,5L,3L,5L,5L,3L,5L,5L,3L,5L,3L,5L,5L,3L,5L,5L,3L,5L,3L,5L,5L,3L,5L,3L,5L,5L,3L,5L,5L,3L,5L,3L,5L,5L,3L,5L,3L,5L,5L,3L,5L,5L,3L,5L,3L,5L,5L,3L,5L,5L,3L,5L,3L,5L,5L,3L,5L,3L,5L,5L,3L,5L,5L,3L,5L,3L,5L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194584Inst : IEnumerable<long>
{
public static readonly long[] Value=A194584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194584.Bytes);
public long this[int i]=>Value[i];

public static A194584Inst Instance=new A194584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194585
{
public static readonly long[] Value={ 2184L,27830L,32214L,57860L,62244L,87890L,92274L,117920L,122304L,147950L,152334L,177980L,182364L,208010L,212394L,238040L,242424L,268070L,272454L,298100L,302484L,328130L,332514L,358160L,362544L,388190L,392574L,418220L,422604L,448250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194585Inst : IEnumerable<long>
{
public static readonly long[] Value=A194585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194585.Bytes);
public long this[int i]=>Value[i];

public static A194585Inst Instance=new A194585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194586
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,0L,0L,3L,0L,6L,0L,4L,0L,24L,0L,0L,5L,0L,60L,0L,30L,0L,6L,0L,120L,0L,180L,0L,0L,7L,0L,210L,0L,630L,0L,140L,0L,8L,0L,336L,0L,1680L,0L,1120L,0L,0L,9L,0L,504L,0L,3780L,0L,5040L,0L,630L,0L,10L,0L,720L,0L,7560L,0L,16800L,0L,6300L,0L,0L,11L,0L,990L,0L,13860L,0L,46200L,0L,34650L,0L,2772L,0L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194586Inst : IEnumerable<long>
{
public static readonly long[] Value=A194586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194586.Bytes);
public long this[int i]=>Value[i];

public static A194586Inst Instance=new A194586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194587
{
public static readonly long[] Value={ 1L,0L,-1L,0L,-3L,4L,0L,-1L,4L,-3L,0L,-15L,140L,-270L,144L,0L,-1L,20L,-75L,96L,-40L,0L,-21L,868L,-5670L,13104L,-12600L,4320L,0L,-1L,84L,-903L,3360L,-5600L,4320L,-1260L,0L,-15L,2540L,-43470L,244944L,-630000L,820800L,-529200L,134400L,0L,-1L,340L,-9075L,74592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194587Inst : IEnumerable<long>
{
public static readonly long[] Value=A194587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194587.Bytes);
public long this[int i]=>Value[i];

public static A194587Inst Instance=new A194587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194588
{
public static readonly long[] Value={ 1L,0L,2L,2L,8L,17L,49L,128L,356L,983L,2759L,7779L,22087L,63000L,180478L,518846L,1496236L,4326383L,12539335L,36419069L,105971473L,308866226L,901573732L,2635235789L,7712078755L,22594899002L,66266698424L,194531585078L,571561286576L,1680679630089L,4945738222801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194588Inst : IEnumerable<long>
{
public static readonly long[] Value=A194588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194588.Bytes);
public long this[int i]=>Value[i];

public static A194588Inst Instance=new A194588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194589
{
public static readonly long[] Value={ 0L,0L,1L,1L,5L,11L,34L,92L,265L,751L,2156L,6194L,17874L,51702L,149941L,435749L,1268761L,3700391L,10808548L,31613474L,92577784L,271407896L,796484503L,2339561795L,6877992334L,20236257626L,59581937299L,175546527727L,517538571125L,1526679067331L,4505996000730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194589Inst : IEnumerable<long>
{
public static readonly long[] Value=A194589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194589.Bytes);
public long this[int i]=>Value[i];

public static A194589Inst Instance=new A194589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194590
{
public static readonly long[] Value={ 0L,0L,1L,-2L,7L,-14L,38L,-76L,187L,-374L,874L,-1748L,3958L,-7916L,17548L,-35096L,76627L,-153254L,330818L,-661636L,1415650L,-2831300L,6015316L,-12030632L,25413342L,-50826684L,106853668L,-213707336L,447472972L,-894945944L,1867450648L,-3734901296L,7770342787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194590Inst : IEnumerable<long>
{
public static readonly long[] Value=A194590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194590.Bytes);
public long this[int i]=>Value[i];

public static A194590Inst Instance=new A194590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194591
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,2L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,4L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,5L,0L,3L,0L,1L,1L,1L,0L,2L,0L,1L,0L,2L,0L,2L,0L,1L,1L,2L,0L,1L,0L,1L,0L,1L,0L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194591Inst : IEnumerable<long>
{
public static readonly long[] Value=A194591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194591.Bytes);
public long this[int i]=>Value[i];

public static A194591Inst Instance=new A194591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194592
{
public static readonly long[] Value={ 8L,12L,15L,18L,0L,24L,25L,30L,0L,33L,0L,0L,0L,38L,45L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194592Inst : IEnumerable<long>
{
public static readonly long[] Value=A194592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194592.Bytes);
public long this[int i]=>Value[i];

public static A194592Inst Instance=new A194592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194593
{
public static readonly long[] Value={ 9L,10L,14L,22L,46L,94L,118L,166L,214L,334L,358L,454L,526L,694L,718L,766L,934L,958L,1006L,1126L,1174L,1438L,1678L,1726L,1774L,1966L,2038L,2374L,2566L,2614L,2638L,2734L,2878L,2974L,3046L,3238L,3646L,3814L,4054L,4078L,4126L,4198L,4414L,4894L,4918L,5158L,5638L,5758L,5806L,5926L,5998L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194593Inst : IEnumerable<long>
{
public static readonly long[] Value=A194593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194593.Bytes);
public long this[int i]=>Value[i];

public static A194593Inst Instance=new A194593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194594
{
public static readonly long[] Value={ 4L,6L,8L,10L,12L,16L,22L,27L,32L,40L,44L,58L,68L,80L,82L,88L,116L,125L,136L,164L,165L,176L,192L,232L,236L,250L,256L,284L,328L,352L,358L,382L,420L,428L,435L,462L,472L,478L,486L,512L,548L,562L,640L,651L,656L,665L,704L,714L,764L,768L,788L,798L,808L,819L,838L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194594Inst : IEnumerable<long>
{
public static readonly long[] Value=A194594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194594.Bytes);
public long this[int i]=>Value[i];

public static A194594Inst Instance=new A194594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194595
{
public static readonly long[] Value={ 1L,3L,1L,7L,14L,1L,13L,81L,39L,1L,21L,304L,456L,84L,1L,31L,875L,3000L,1750L,155L,1L,43L,2106L,13875L,18500L,5265L,258L,1L,57L,4459L,50421L,128625L,84035L,13377L,399L,1L,73L,8576L,153664L,669536L,836920L,307328L,30016L,584L,1L,91L,15309L,409536L,2815344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194595Inst : IEnumerable<long>
{
public static readonly long[] Value=A194595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194595.Bytes);
public long this[int i]=>Value[i];

public static A194595Inst Instance=new A194595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194596
{
public static readonly long[] Value={ 0L,1L,3L,17L,82L,489L,2923L,18401L,116848L,753726L,4898579L,32085696L,211398614L,1400292492L,9318028028L,62259251309L,417496576187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194596Inst : IEnumerable<long>
{
public static readonly long[] Value=A194596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194596.Bytes);
public long this[int i]=>Value[i];

public static A194596Inst Instance=new A194596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194597
{
public static readonly long[] Value={ 1L,6L,6L,1L,9L,3L,1L,3L,9L,1L,6L,6L,1L,9L,3L,1L,3L,9L,1L,6L,6L,1L,9L,3L,1L,3L,9L,1L,6L,6L,1L,9L,3L,1L,3L,9L,1L,6L,6L,1L,9L,3L,1L,3L,9L,1L,6L,6L,1L,9L,3L,1L,3L,9L,1L,6L,6L,1L,9L,3L,1L,3L,9L,1L,6L,6L,1L,9L,3L,1L,3L,9L,1L,6L,6L,1L,9L,3L,1L,3L,9L,1L,6L,6L,1L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194597Inst : IEnumerable<long>
{
public static readonly long[] Value=A194597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194597.Bytes);
public long this[int i]=>Value[i];

public static A194597Inst Instance=new A194597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194598
{
public static readonly long[] Value={ 2L,3L,13L,19L,31L,43L,53L,61L,71L,73L,101L,103L,109L,113L,131L,139L,151L,157L,173L,181L,191L,193L,199L,229L,233L,239L,241L,251L,269L,271L,283L,293L,311L,313L,349L,353L,373L,379L,409L,419L,421L,433L,439L,443L,463L,491L,499L,509L,523L,571L,577L,593L,599L,601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194598Inst : IEnumerable<long>
{
public static readonly long[] Value=A194598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194598.Bytes);
public long this[int i]=>Value[i];

public static A194598Inst Instance=new A194598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194599
{
public static readonly long[] Value={ 1L,6L,5L,8L,5L,6L,1L,0L,3L,0L,1L,6L,5L,8L,5L,6L,1L,0L,3L,0L,1L,6L,5L,8L,5L,6L,1L,0L,3L,0L,1L,6L,5L,8L,5L,6L,1L,0L,3L,0L,1L,6L,5L,8L,5L,6L,1L,0L,3L,0L,1L,6L,5L,8L,5L,6L,1L,0L,3L,0L,1L,6L,5L,8L,5L,6L,1L,0L,3L,0L,1L,6L,5L,8L,5L,6L,1L,0L,3L,0L,1L,6L,5L,8L,5L,6L,1L,0L,3L,0L,1L,6L,5L,8L,5L,6L,1L,0L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194599Inst : IEnumerable<long>
{
public static readonly long[] Value=A194599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194599.Bytes);
public long this[int i]=>Value[i];

public static A194599Inst Instance=new A194599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194600
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,11L,18L,20L,28L,70L,106L,208L,726L,910L,2906L,7431L,14073L,22394L,41422L,82587L,85461L,356981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194600Inst : IEnumerable<long>
{
public static readonly long[] Value=A194600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194600.Bytes);
public long this[int i]=>Value[i];

public static A194600Inst Instance=new A194600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194601
{
public static readonly long[] Value={ 1L,8L,16L,36L,40L,68L,72L,116L,128L,180L,204L,256L,292L,332L,368L,500L,480L,492L,700L,592L,820L,760L,976L,992L,1096L,1132L,1332L,1344L,1488L,1580L,1680L,1812L,1848L,1996L,2156L,2168L,2140L,2624L,2572L,2680L,3008L,2980L,3396L,2960L,3804L,3356L,4420L,3868L,4236L,4284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194601Inst : IEnumerable<long>
{
public static readonly long[] Value=A194601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194601.Bytes);
public long this[int i]=>Value[i];

public static A194601Inst Instance=new A194601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194602
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,11L,15L,21L,23L,27L,31L,43L,47L,55L,63L,85L,87L,91L,95L,111L,119L,127L,171L,175L,183L,191L,219L,223L,239L,255L,341L,343L,347L,351L,367L,375L,383L,439L,447L,479L,495L,511L,683L,687L,695L,703L,731L,735L,751L,767L,879L,887L,895L,959L,991L,1023L,1365L,1367L,1371L,1375L,1391L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194602Inst : IEnumerable<long>
{
public static readonly long[] Value=A194602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194602.Bytes);
public long this[int i]=>Value[i];

public static A194602Inst Instance=new A194602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194603
{
public static readonly long[] Value={ 2L,3L,2L,3L,11L,5L,13L,7L,17L,11L,23L,11L,53L,13L,29L,17L,67L,17L,37L,19L,41L,23L,47L,23L,101L,53L,53L,29L,59L,29L,61L,31L,67L,67L,71L,37L,73L,37L,79L,41L,83L,41L,173L,43L,89L,47L,751L,47L,97L,101L,101L,53L,107L,53L,109L,113L,113L,59L,1889L,59L,487L,61L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194603Inst : IEnumerable<long>
{
public static readonly long[] Value=A194603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194603.Bytes);
public long this[int i]=>Value[i];

public static A194603Inst Instance=new A194603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194604
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,3L,16L,0L,0L,6L,78L,193L,0L,0L,10L,228L,1548L,2080L,0L,0L,15L,520L,6714L,27768L,21121L,0L,0L,21L,1020L,21280L,181032L,474288L,206896L,0L,0L,28L,1806L,55395L,807040L,4697166L,7888608L,1979713L,0L,0L,36L,2968L,125748L,2817240L,29708800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194604Inst : IEnumerable<long>
{
public static readonly long[] Value=A194604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194604.Bytes);
public long this[int i]=>Value[i];

public static A194604Inst Instance=new A194604Inst();

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