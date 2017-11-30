using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A086259
{
public static readonly long[] Value={ 1151L,1193L,1319L,1373L,1511L,1733L,1913L,1931L,1973L,2003L,3119L,3137L,3191L,3371L,3559L,3719L,3779L,3797L,3911L,3917L,5953L,7193L,7331L,7793L,7937L,9137L,9173L,9311L,9371L,9377L,10111L,11113L,11119L,11131L,11311L,11551L,13313L,13913L,15511L,19139L,19319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086259Inst : IEnumerable<long>
{
public static readonly long[] Value=A086259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086259.Bytes);
public long this[int i]=>Value[i];

public static A086259Inst Instance=new A086259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086308
{
public static readonly long[] Value={ 5L,3L,4L,9L,4L,9L,6L,0L,6L,1L,4L,2L,3L,0L,7L,0L,1L,4L,5L,5L,0L,3L,7L,9L,7L,1L,1L,0L,5L,2L,0L,6L,8L,3L,9L,8L,1L,4L,3L,1L,1L,6L,5L,1L,4L,0L,5L,6L,9L,9L,0L,0L,9L,3L,9L,7L,7L,0L,7L,6L,8L,1L,0L,2L,3L,7L,5L,2L,3L,2L,1L,7L,8L,8L,0L,6L,4L,0L,6L,7L,2L,3L,9L,7L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086308Inst : IEnumerable<long>
{
public static readonly long[] Value=A086308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086308.Bytes);
public long this[int i]=>Value[i];

public static A086308Inst Instance=new A086308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086309
{
public static readonly long[] Value={ 7L,1L,6L,6L,4L,4L,0L,1L,6L,0L,2L,7L,3L,8L,8L,0L,2L,0L,4L,9L,6L,8L,0L,8L,6L,8L,4L,7L,8L,4L,7L,0L,1L,1L,8L,2L,7L,4L,4L,7L,9L,4L,0L,9L,4L,6L,3L,2L,4L,1L,4L,2L,6L,8L,2L,8L,2L,0L,3L,0L,7L,6L,3L,0L,3L,7L,9L,4L,6L,2L,8L,8L,4L,7L,8L,5L,7L,5L,9L,2L,8L,1L,6L,1L,0L,3L,5L,8L,2L,4L,2L,1L,9L,2L,3L,1L,2L,8L,9L,9L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086309Inst : IEnumerable<long>
{
public static readonly long[] Value=A086309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086309.Bytes);
public long this[int i]=>Value[i];

public static A086309Inst Instance=new A086309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086310
{
public static readonly long[] Value={ 2L,7L,3L,9L,4L,8L,9L,7L,5L,1L,3L,8L,4L,2L,4L,6L,1L,3L,1L,3L,6L,8L,8L,4L,0L,0L,3L,7L,8L,2L,8L,0L,9L,0L,4L,5L,3L,1L,8L,1L,4L,8L,1L,4L,0L,4L,7L,9L,4L,2L,8L,3L,3L,4L,1L,4L,6L,5L,8L,1L,3L,5L,6L,1L,0L,6L,8L,3L,7L,0L,6L,9L,2L,9L,7L,3L,9L,0L,8L,4L,8L,2L,7L,5L,5L,0L,9L,2L,0L,1L,3L,2L,5L,7L,2L,4L,9L,4L,5L,4L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086310Inst : IEnumerable<long>
{
public static readonly long[] Value=A086310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086310.Bytes);
public long this[int i]=>Value[i];

public static A086310Inst Instance=new A086310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086311
{
public static readonly long[] Value={ 2L,8L,4L,4L,3L,8L,3L,1L,6L,8L,1L,1L,6L,7L,5L,6L,1L,6L,8L,2L,1L,6L,2L,2L,5L,7L,2L,3L,1L,4L,1L,0L,0L,8L,2L,6L,6L,4L,8L,9L,0L,3L,8L,5L,3L,0L,9L,0L,8L,7L,1L,0L,7L,7L,4L,3L,9L,5L,5L,3L,7L,5L,4L,6L,6L,6L,3L,6L,8L,1L,9L,0L,2L,3L,9L,4L,2L,4L,1L,2L,7L,7L,7L,4L,8L,8L,2L,1L,9L,5L,7L,9L,1L,7L,1L,8L,4L,8L,8L,0L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086311Inst : IEnumerable<long>
{
public static readonly long[] Value=A086311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086311.Bytes);
public long this[int i]=>Value[i];

public static A086311Inst Instance=new A086311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086312
{
public static readonly long[] Value={ 7L,6L,3L,0L,1L,4L,1L,8L,7L,1L,1L,1L,1L,4L,8L,3L,7L,0L,3L,4L,6L,6L,4L,4L,1L,1L,9L,4L,0L,6L,0L,1L,6L,8L,4L,1L,4L,2L,4L,9L,9L,1L,3L,7L,5L,2L,6L,2L,6L,2L,9L,7L,4L,2L,7L,6L,8L,9L,7L,9L,1L,0L,9L,0L,1L,7L,5L,7L,3L,2L,1L,9L,9L,9L,3L,1L,7L,7L,2L,1L,0L,0L,0L,7L,6L,2L,0L,2L,0L,8L,1L,1L,1L,2L,8L,7L,2L,3L,4L,5L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086312Inst : IEnumerable<long>
{
public static readonly long[] Value=A086312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086312.Bytes);
public long this[int i]=>Value[i];

public static A086312Inst Instance=new A086312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086313
{
public static readonly long[] Value={ 3L,7L,2L,0L,4L,8L,6L,8L,1L,2L,0L,7L,7L,7L,1L,8L,3L,3L,2L,4L,2L,0L,5L,4L,2L,5L,4L,0L,3L,0L,1L,2L,8L,8L,9L,2L,2L,7L,6L,1L,5L,2L,9L,5L,8L,9L,4L,0L,7L,6L,2L,9L,7L,8L,7L,9L,4L,3L,3L,1L,2L,2L,8L,5L,2L,2L,3L,7L,3L,2L,3L,8L,0L,8L,5L,6L,9L,7L,3L,0L,5L,5L,0L,7L,0L,3L,0L,6L,6L,0L,8L,0L,3L,2L,8L,8L,0L,9L,8L,9L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086313Inst : IEnumerable<long>
{
public static readonly long[] Value=A086313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086313.Bytes);
public long this[int i]=>Value[i];

public static A086313Inst Instance=new A086313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086314
{
public static readonly BigInteger[] Value={ 0L,1L,6L,33L,170L,1170L,10962L,172844L,4944024L,270116280L,28022441260L,5448008695536L,1969579223350128L,1321964082404214704L,BigInteger.Parse("1649890513414726210320"),BigInteger.Parse("3840060942271653473695680"),BigInteger.Parse("16723638762440239422492944768"),BigInteger.Parse("136749695973639295091912681599872") };
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
public class A086314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086314Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086314.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086314Inst Instance=new A086314Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086315
{
public static readonly long[] Value={ 7L,7L,4L,3L,1L,3L,1L,9L,8L,5L,5L,3L,6L,8L,9L,6L,5L,9L,1L,4L,4L,6L,2L,8L,3L,8L,5L,6L,7L,4L,9L,7L,8L,4L,2L,9L,5L,5L,9L,3L,6L,5L,2L,8L,2L,8L,4L,1L,8L,8L,0L,8L,8L,8L,8L,6L,6L,5L,1L,8L,5L,5L,9L,1L,8L,3L,8L,3L,2L,9L,9L,7L,1L,5L,1L,7L,6L,2L,9L,2L,9L,0L,1L,5L,1L,0L,9L,4L,3L,9L,0L,7L,9L,9L,5L,5L,4L,3L,5L,6L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086315Inst : IEnumerable<long>
{
public static readonly long[] Value=A086315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086315.Bytes);
public long this[int i]=>Value[i];

public static A086315Inst Instance=new A086315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086316
{
public static readonly long[] Value={ 6L,1L,3L,4L,7L,5L,2L,6L,9L,2L,0L,2L,2L,3L,4L,4L,1L,6L,0L,1L,8L,0L,4L,1L,6L,6L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086316Inst : IEnumerable<long>
{
public static readonly long[] Value=A086316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086316.Bytes);
public long this[int i]=>Value[i];

public static A086316Inst Instance=new A086316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086317
{
public static readonly long[] Value={ 2L,4L,8L,3L,2L,5L,3L,5L,3L,6L,1L,7L,2L,6L,3L,6L,8L,5L,8L,5L,6L,2L,2L,8L,8L,5L,1L,8L,1L,7L,8L,2L,2L,1L,2L,8L,9L,1L,8L,8L,6L,9L,7L,3L,4L,0L,8L,1L,4L,3L,6L,4L,5L,8L,5L,9L,2L,0L,2L,5L,9L,6L,9L,7L,3L,0L,6L,7L,4L,2L,5L,4L,0L,8L,8L,5L,8L,0L,9L,8L,3L,9L,0L,6L,4L,7L,6L,4L,0L,1L,6L,9L,1L,6L,7L,2L,1L,8L,2L,7L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086317Inst : IEnumerable<long>
{
public static readonly long[] Value=A086317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086317.Bytes);
public long this[int i]=>Value[i];

public static A086317Inst Instance=new A086317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086318
{
public static readonly long[] Value={ 7L,9L,1L,6L,0L,3L,1L,8L,3L,5L,7L,7L,5L,1L,1L,8L,0L,7L,8L,2L,3L,6L,2L,8L,4L,5L,5L,7L,2L,3L,2L,6L,8L,2L,2L,4L,0L,7L,1L,7L,4L,2L,4L,1L,8L,0L,9L,0L,7L,8L,9L,4L,6L,7L,3L,1L,2L,3L,0L,7L,8L,3L,0L,9L,9L,2L,2L,9L,0L,4L,4L,1L,5L,0L,3L,8L,9L,3L,2L,9L,2L,5L,5L,4L,4L,6L,6L,7L,9L,0L,8L,6L,8L,4L,0L,4L,6L,3L,0L,3L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086318Inst : IEnumerable<long>
{
public static readonly long[] Value=A086318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086318.Bytes);
public long this[int i]=>Value[i];

public static A086318Inst Instance=new A086318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086319
{
public static readonly long[] Value={ 2L,5L,11L,17L,23L,41L,47L,71L,89L,167L,191L,281L,353L,359L,761L,1409L,1433L,1439L,3041L,5639L,12161L,48647L,194591L,778361L,3113447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086319Inst : IEnumerable<long>
{
public static readonly long[] Value=A086319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086319.Bytes);
public long this[int i]=>Value[i];

public static A086319Inst Instance=new A086319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086320
{
public static readonly long[] Value={ 11L,1L,6L,3L,10L,1L,3L,6L,5L,3L,2L,3L,2L,1L,9L,1L,6L,3L,3L,2L,1L,5L,1L,4L,1L,3L,2L,3L,4L,2L,1L,3L,1L,1L,3L,2L,3L,1L,1L,1L,5L,2L,8L,3L,1L,1L,1L,1L,2L,3L,5L,2L,2L,1L,3L,2L,1L,2L,1L,1L,4L,1L,2L,1L,4L,1L,5L,1L,1L,2L,3L,2L,3L,3L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,3L,1L,1L,4L,2L,1L,5L,4L,2L,1L,3L,1L,2L,2L,6L,4L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086320Inst : IEnumerable<long>
{
public static readonly long[] Value=A086320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086320.Bytes);
public long this[int i]=>Value[i];

public static A086320Inst Instance=new A086320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086321
{
public static readonly long[] Value={ 2L,7L,17L,37L,47L,97L,107L,227L,277L,577L,587L,647L,1367L,1657L,1667L,3457L,3467L,3517L,3527L,3877L,10007L,20747L,20807L,21107L,21157L,60037L,124477L,124847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086321Inst : IEnumerable<long>
{
public static readonly long[] Value=A086321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086321.Bytes);
public long this[int i]=>Value[i];

public static A086321Inst Instance=new A086321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086322
{
public static readonly long[] Value={ 2L,17L,23L,167L,173L,227L,233L,1667L,1733L,2267L,2273L,2333L,16673L,17327L,17333L,22727L,23327L,23333L,173267L,173273L,227267L,233267L,233327L,1732727L,2272667L,2332667L,22726667L,23326673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086322Inst : IEnumerable<long>
{
public static readonly long[] Value=A086322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086322.Bytes);
public long this[int i]=>Value[i];

public static A086322Inst Instance=new A086322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086323
{
public static readonly long[] Value={ 1L,2L,6L,8L,30L,36L,126L,160L,450L,740L,2046L,2592L,8190L,12824L,30030L,48640L,131070L,194508L,524286L,812840L,1987818L,3486824L,8388606L,12400368L,33348150L,56700072L,128800098L,219681672L,536870910L,861181320L,2147483646L,3555730432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086323Inst : IEnumerable<long>
{
public static readonly long[] Value=A086323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086323.Bytes);
public long this[int i]=>Value[i];

public static A086323Inst Instance=new A086323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086340
{
public static readonly long[] Value={ 1L,3L,5L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086340Inst : IEnumerable<long>
{
public static readonly long[] Value=A086340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086340.Bytes);
public long this[int i]=>Value[i];

public static A086340Inst Instance=new A086340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086341
{
public static readonly long[] Value={ 1L,3L,3L,5L,7L,9L,15L,17L,31L,33L,63L,65L,127L,129L,255L,257L,511L,513L,1023L,1025L,2047L,2049L,4095L,4097L,8191L,8193L,16383L,16385L,32767L,32769L,65535L,65537L,131071L,131073L,262143L,262145L,524287L,524289L,1048575L,1048577L,2097151L,2097153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086341Inst : IEnumerable<long>
{
public static readonly long[] Value=A086341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086341.Bytes);
public long this[int i]=>Value[i];

public static A086341Inst Instance=new A086341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086342
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,2L,3L,1L,2L,2L,2L,2L,2L,3L,4L,1L,2L,2L,2L,2L,3L,2L,3L,2L,2L,2L,2L,3L,2L,4L,5L,1L,2L,2L,3L,2L,2L,2L,3L,2L,2L,3L,2L,2L,4L,3L,3L,2L,3L,2L,4L,2L,2L,2L,3L,3L,2L,2L,2L,4L,2L,5L,6L,1L,2L,2L,2L,2L,3L,3L,3L,2L,3L,2L,4L,2L,3L,3L,3L,2L,2L,2L,2L,3L,4L,2L,3L,2L,4L,4L,3L,3L,5L,3L,3L,2L,2L,3L,2L,2L,2L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086342Inst : IEnumerable<long>
{
public static readonly long[] Value=A086342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086342.Bytes);
public long this[int i]=>Value[i];

public static A086342Inst Instance=new A086342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086343
{
public static readonly long[] Value={ 2L,5L,9L,12L,17L,20L,24L,27L,33L,36L,40L,43L,48L,51L,55L,58L,65L,68L,72L,75L,80L,83L,87L,90L,96L,99L,103L,106L,111L,114L,118L,121L,129L,132L,136L,139L,144L,147L,151L,154L,160L,163L,167L,170L,175L,178L,182L,185L,192L,195L,199L,202L,207L,210L,214L,217L,223L,226L,230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086343Inst : IEnumerable<long>
{
public static readonly long[] Value=A086343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086343.Bytes);
public long this[int i]=>Value[i];

public static A086343Inst Instance=new A086343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086344
{
public static readonly long[] Value={ 1L,0L,4L,-8L,32L,-96L,320L,-1024L,3328L,-10752L,34816L,-112640L,364544L,-1179648L,3817472L,-12353536L,39976960L,-129368064L,418643968L,-1354760192L,4384096256L,-14187233280L,45910851584L,-148570636288L,480784678912L,-1555851902976L,5034842521600L,-16293092655104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086344Inst : IEnumerable<long>
{
public static readonly long[] Value=A086344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086344.Bytes);
public long this[int i]=>Value[i];

public static A086344Inst Instance=new A086344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086345
{
public static readonly BigInteger[] Value={ 1L,1L,5L,34L,535L,20848L,2120098L,572849763L,415361983540L,815590925440865L,4373589784210012634L,BigInteger.Parse("64535461714821630421106"),BigInteger.Parse("2637732191356603658136444467"),BigInteger.Parse("300363258297687600380548275359231") };
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
public class A086345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086345Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086345.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086345Inst Instance=new A086345Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086346
{
public static readonly long[] Value={ 1L,3L,18L,80L,400L,1904L,9248L,44544L,215296L,1039104L,5018112L,24227840L,116985856L,564850688L,2727354368L,13168803840L,63584665600L,307013812224L,1482394042368L,7157631156224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086346Inst : IEnumerable<long>
{
public static readonly long[] Value=A086346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086346.Bytes);
public long this[int i]=>Value[i];

public static A086346Inst Instance=new A086346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086347
{
public static readonly long[] Value={ 1L,5L,24L,116L,560L,2704L,13056L,63040L,304384L,1469696L,7096320L,34264064L,165441536L,798822400L,3857055744L,18623512576L,89922273280L,434183143424L,2096421666816L,10122419240960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086347Inst : IEnumerable<long>
{
public static readonly long[] Value=A086347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086347.Bytes);
public long this[int i]=>Value[i];

public static A086347Inst Instance=new A086347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086348
{
public static readonly long[] Value={ 1L,8L,32L,168L,784L,3840L,18432L,89216L,430336L,2078720L,10035200L,48457728L,233967616L,1129709568L,5454692352L,26337640448L,127169265664L,614027755520L,2964787822592L,14315262836736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086348Inst : IEnumerable<long>
{
public static readonly long[] Value=A086348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086348.Bytes);
public long this[int i]=>Value[i];

public static A086348Inst Instance=new A086348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086349
{
public static readonly long[] Value={ 1L,9L,40L,200L,952L,4624L,22272L,107648L,519552L,2509056L,12113920L,58492928L,282425344L,1363677184L,6584401920L,31792332800L,153506906112L,741197021184L,3578815578112L,17280050659328L,83435464425472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086349Inst : IEnumerable<long>
{
public static readonly long[] Value=A086349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086349.Bytes);
public long this[int i]=>Value[i];

public static A086349Inst Instance=new A086349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086350
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,3L,5L,2L,1L,4L,10L,12L,4L,1L,5L,17L,34L,29L,4L,1L,6L,26L,74L,116L,70L,8L,1L,7L,37L,138L,325L,396L,169L,8L,1L,8L,50L,232L,740L,1432L,1352L,408L,16L,1L,9L,65L,362L,1469L,3988L,6317L,4616L,985L,16L,1L,10L,82L,534L,2644L,9354L,21544L,27878L,15760L,2378L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086350Inst : IEnumerable<long>
{
public static readonly long[] Value=A086350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086350.Bytes);
public long this[int i]=>Value[i];

public static A086350Inst Instance=new A086350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086351
{
public static readonly long[] Value={ 1L,4L,17L,74L,325L,1432L,6317L,27878L,123049L,543148L,2397545L,10583234L,46716589L,206216896L,910285253L,4018193246L,17737162705L,78295623508L,345613602113L,1525612248122L,6734378273941L,29726983906792L,131221255523165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086351Inst : IEnumerable<long>
{
public static readonly long[] Value=A086351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086351.Bytes);
public long this[int i]=>Value[i];

public static A086351Inst Instance=new A086351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086352
{
public static readonly BigInteger[] Value={ 1L,2L,10L,74L,740L,9354L,143144L,2573586L,53180944L,1242078802L,32358633632L,930370449370L,29264294868544L,999646208968666L,36852747307934336L,1458402092927302178L,BigInteger.Parse("61665517131334975744"),BigInteger.Parse("2774522039432235946914") };
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
public class A086352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086352Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086352.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086352Inst Instance=new A086352Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086353
{
public static readonly long[] Value={ 1L,2L,6L,8L,2L,4L,2L,8L,8L,8L,6L,1L,2L,8L,8L,8L,8L,6L,8L,8L,8L,8L,8L,2L,2L,8L,4L,8L,6L,2L,2L,6L,1L,8L,8L,8L,2L,2L,6L,8L,8L,8L,8L,8L,8L,6L,8L,6L,8L,8L,8L,6L,6L,1L,8L,8L,5L,8L,6L,6L,8L,6L,8L,2L,8L,8L,8L,6L,8L,2L,8L,8L,2L,6L,6L,8L,9L,6L,8L,8L,6L,2L,2L,8L,8L,8L,8L,4L,6L,8L,9L,6L,2L,2L,8L,2L,8L,8L,4L,4L,8L,8L,6L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086353Inst : IEnumerable<long>
{
public static readonly long[] Value=A086353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086353.Bytes);
public long this[int i]=>Value[i];

public static A086353Inst Instance=new A086353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086354
{
public static readonly long[] Value={ 2L,4L,8L,6L,6L,8L,6L,6L,1L,8L,8L,2L,6L,2L,2L,4L,8L,2L,1L,6L,2L,2L,6L,8L,2L,8L,2L,8L,2L,2L,8L,6L,6L,2L,2L,6L,2L,2L,6L,8L,8L,6L,3L,4L,2L,2L,6L,6L,2L,8L,6L,2L,2L,9L,8L,6L,6L,5L,8L,2L,8L,8L,2L,6L,2L,8L,8L,8L,5L,8L,8L,8L,2L,8L,6L,4L,8L,6L,2L,7L,1L,8L,8L,4L,2L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086354Inst : IEnumerable<long>
{
public static readonly long[] Value=A086354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086354.Bytes);
public long this[int i]=>Value[i];

public static A086354Inst Instance=new A086354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086355
{
public static readonly long[] Value={ 2L,3L,5L,7L,1L,3L,7L,9L,6L,8L,3L,2L,4L,2L,6L,5L,2L,6L,8L,7L,2L,8L,8L,4L,8L,1L,3L,7L,9L,3L,4L,3L,2L,4L,8L,5L,5L,8L,8L,2L,8L,8L,9L,4L,8L,8L,2L,2L,6L,8L,8L,2L,8L,1L,7L,8L,8L,4L,4L,6L,6L,2L,2L,3L,9L,2L,9L,8L,6L,8L,2L,5L,2L,8L,4L,4L,2L,4L,4L,8L,8L,8L,2L,8L,8L,6L,6L,4L,8L,4L,6L,2L,6L,8L,8L,5L,2L,1L,3L,2L,4L,5L,9L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086355Inst : IEnumerable<long>
{
public static readonly long[] Value=A086355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086355.Bytes);
public long this[int i]=>Value[i];

public static A086355Inst Instance=new A086355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086372
{
public static readonly long[] Value={ -1L,0L,1L,-1L,1L,-1L,1L,0L,0L,0L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,2L,0L,1L,0L,2L,1L,1L,0L,3L,1L,1L,1L,3L,2L,1L,2L,3L,3L,2L,2L,4L,5L,1L,4L,5L,5L,3L,5L,6L,7L,4L,6L,8L,9L,5L,8L,11L,10L,8L,10L,13L,13L,11L,12L,17L,17L,13L,16L,22L,19L,19L,20L,26L,26L,23L,25L,33L,32L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086372Inst : IEnumerable<long>
{
public static readonly long[] Value=A086372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086372.Bytes);
public long this[int i]=>Value[i];

public static A086372Inst Instance=new A086372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086373
{
public static readonly BigInteger[] Value={ 1L,7L,168L,10080L,1401120L,303730560L,109469465280L,56335746378240L,41263790481123840L,BigInteger.Parse("41372254858231987200"),BigInteger.Parse("55175243131277553715200"),BigInteger.Parse("95478523289749232323891200"),BigInteger.Parse("209996618265179127555767193600") };
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
public class A086373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086373Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086373.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086373Inst Instance=new A086373Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086374
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,4L,3L,2L,5L,4L,3L,4L,3L,4L,7L,2L,3L,6L,3L,4L,7L,4L,3L,4L,5L,4L,7L,4L,3L,8L,3L,2L,7L,4L,7L,6L,3L,4L,7L,4L,3L,8L,3L,4L,11L,4L,3L,4L,5L,6L,7L,4L,3L,8L,7L,4L,7L,4L,3L,8L,3L,4L,11L,2L,7L,8L,3L,4L,7L,8L,3L,6L,3L,4L,11L,4L,7L,8L,3L,4L,9L,4L,3L,8L,7L,4L,7L,4L,3L,12L,7L,4L,7L,4L,7L,4L,3L,6L,11L,6L,3L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086374Inst : IEnumerable<long>
{
public static readonly long[] Value=A086374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086374.Bytes);
public long this[int i]=>Value[i];

public static A086374Inst Instance=new A086374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086375
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,3L,3L,3L,6L,2L,4L,4L,5L,4L,5L,2L,7L,4L,4L,4L,8L,3L,4L,5L,6L,4L,8L,2L,8L,4L,3L,6L,9L,4L,5L,4L,8L,4L,8L,2L,8L,6L,4L,6L,10L,3L,6L,5L,7L,4L,8L,4L,10L,6L,4L,4L,12L,2L,6L,6L,7L,8L,7L,4L,8L,4L,8L,4L,14L,2L,5L,6L,6L,8L,8L,4L,12L,5L,4L,5L,12L,4L,6L,6L,8L,4L,12L,4L,10L,6L,4L,6L,12L,4L,6L,6L,10L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086375Inst : IEnumerable<long>
{
public static readonly long[] Value=A086375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086375.Bytes);
public long this[int i]=>Value[i];

public static A086375Inst Instance=new A086375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086376
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,3L,2L,4L,3L,3L,4L,6L,5L,6L,7L,8L,8L,10L,11L,16L,16L,18L,21L,28L,29L,34L,41L,50L,56L,66L,80L,100L,114L,131L,158L,196L,225L,263L,320L,388L,455L,532L,644L,786L,921L,1083L,1321L,1600L,1891L,2218L,2711L,3280L,3895L,4588L,5591L,6780L,8051L,9519L,11624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086376Inst : IEnumerable<long>
{
public static readonly long[] Value=A086376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086376.Bytes);
public long this[int i]=>Value[i];

public static A086376Inst Instance=new A086376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086377
{
public static readonly long[] Value={ 1L,4L,6L,8L,11L,13L,16L,18L,21L,23L,25L,28L,30L,33L,35L,37L,40L,42L,45L,47L,49L,52L,54L,57L,59L,62L,64L,66L,69L,71L,74L,76L,78L,81L,83L,86L,88L,91L,93L,95L,98L,100L,103L,105L,107L,110L,112L,115L,117L,120L,122L,124L,127L,129L,132L,134L,136L,139L,141L,144L,146L,148L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086377Inst : IEnumerable<long>
{
public static readonly long[] Value=A086377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086377.Bytes);
public long this[int i]=>Value[i];

public static A086377Inst Instance=new A086377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086378
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,12L,16L,20L,25L,30L,36L,42L,49L,55L,56L,64L,70L,72L,81L,90L,100L,110L,121L,132L,144L,153L,155L,156L,169L,180L,182L,196L,210L,225L,240L,256L,272L,289L,305L,306L,324L,342L,361L,377L,380L,400L,420L,441L,462L,484L,504L,505L,506L,529L,546L,552L,576L,600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086378Inst : IEnumerable<long>
{
public static readonly long[] Value=A086378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086378.Bytes);
public long this[int i]=>Value[i];

public static A086378Inst Instance=new A086378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086379
{
public static readonly long[] Value={ 1L,2L,4L,6L,11L,22L,28L,66L,82L,112L,114L,121L,123L,129L,132L,136L,141L,147L,156L,163L,165L,174L,189L,192L,198L,211L,213L,219L,231L,235L,237L,253L,268L,273L,279L,286L,291L,297L,312L,316L,321L,325L,327L,334L,343L,345L,349L,352L,354L,361L,367L,369L,372L,376L,394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086379Inst : IEnumerable<long>
{
public static readonly long[] Value=A086379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086379.Bytes);
public long this[int i]=>Value[i];

public static A086379Inst Instance=new A086379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086380
{
public static readonly long[] Value={ 3L,15L,33L,57L,117L,147L,255L,477L,837L,903L,1035L,2193L,2487L,3345L,5325L,5727L,7377L,7833L,8205L,9723L,11055L,11763L,11955L,13545L,15015L,15267L,16047L,17667L,19923L,20385L,21663L,26247L,26457L,26643L,29187L,29493L,30207L,32397L,32967L,35475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086380Inst : IEnumerable<long>
{
public static readonly long[] Value=A086380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086380.Bytes);
public long this[int i]=>Value[i];

public static A086380Inst Instance=new A086380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086381
{
public static readonly long[] Value={ 1L,3L,15L,33L,45L,57L,117L,147L,243L,255L,303L,375L,423L,447L,453L,477L,573L,753L,837L,897L,903L,1035L,1497L,1905L,2055L,2085L,2193L,2283L,2433L,2487L,2535L,2583L,2757L,2823L,2943L,2955L,3003L,3213L,3285L,3345L,3603L,3657L,3687L,4407L,4575L,4977L,5037L,5043L,5325L,5355L,5367L,5403L,5727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086381Inst : IEnumerable<long>
{
public static readonly long[] Value=A086381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086381.Bytes);
public long this[int i]=>Value[i];

public static A086381Inst Instance=new A086381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086382
{
public static readonly long[] Value={ 2L,1L,2L,10L,1L,10L,2L,1L,2L,12L,1L,10L,2L,1L,2L,10L,1L,12L,2L,1L,2L,10L,1L,10L,2L,1L,2L,16L,1L,12L,2L,1L,2L,10L,1L,10L,2L,1L,2L,16L,1L,10L,2L,1L,2L,10L,1L,12L,2L,1L,2L,10L,1L,10L,2L,1L,2L,12L,1L,12L,2L,1L,2L,10L,1L,10L,2L,1L,2L,36L,1L,10L,2L,1L,2L,10L,1L,12L,2L,1L,2L,10L,1L,10L,2L,1L,2L,12L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086382Inst : IEnumerable<long>
{
public static readonly long[] Value=A086382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086382.Bytes);
public long this[int i]=>Value[i];

public static A086382Inst Instance=new A086382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086383
{
public static readonly BigInteger[] Value={ 2L,5L,29L,5741L,33461L,44560482149L,1746860020068409L,BigInteger.Parse("68480406462161287469"),BigInteger.Parse("13558774610046711780701"),BigInteger.Parse("4125636888562548868221559797461449"),BigInteger.Parse("4760981394323203445293052612223893281") };
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
public class A086383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086383Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086383.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086383Inst Instance=new A086383Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086384
{
public static readonly long[] Value={ 7L,1L,1L,5L,9L,5L,3L,5L,3L,7L,7L,1L,3L,5L,9L,7L,7L,5L,7L,7L,9L,3L,9L,9L,9L,5L,9L,5L,7L,9L,9L,7L,7L,7L,7L,3L,3L,5L,3L,5L,7L,5L,9L,5L,7L,1L,3L,1L,7L,5L,5L,1L,7L,7L,3L,9L,1L,9L,3L,3L,5L,9L,9L,1L,1L,7L,1L,3L,5L,9L,9L,3L,5L,7L,9L,3L,3L,9L,5L,5L,9L,5L,3L,7L,3L,1L,3L,3L,7L,9L,3L,9L,7L,3L,3L,3L,9L,7L,5L,3L,1L,9L,5L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086384Inst : IEnumerable<long>
{
public static readonly long[] Value=A086384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086384.Bytes);
public long this[int i]=>Value[i];

public static A086384Inst Instance=new A086384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086385
{
public static readonly long[] Value={ 3L,1L,1L,5L,9L,5L,3L,5L,9L,7L,9L,3L,3L,3L,3L,3L,7L,9L,5L,1L,9L,7L,1L,9L,3L,9L,9L,3L,7L,5L,1L,5L,9L,7L,9L,5L,9L,3L,7L,1L,9L,9L,3L,5L,3L,1L,1L,7L,7L,9L,1L,5L,1L,3L,3L,7L,9L,3L,9L,5L,5L,5L,3L,1L,7L,5L,3L,5L,9L,1L,1L,1L,1L,7L,5L,1L,7L,1L,9L,3L,5L,1L,1L,5L,5L,5L,9L,9L,9L,5L,9L,3L,3L,1L,9L,1L,9L,7L,5L,5L,9L,3L,3L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086385Inst : IEnumerable<long>
{
public static readonly long[] Value=A086385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086385.Bytes);
public long this[int i]=>Value[i];

public static A086385Inst Instance=new A086385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086386
{
public static readonly long[] Value={ 5L,19L,71L,3691L,191861L,26947261171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086386Inst : IEnumerable<long>
{
public static readonly long[] Value=A086386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086386.Bytes);
public long this[int i]=>Value[i];

public static A086386Inst Instance=new A086386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086387
{
public static readonly long[] Value={ 3L,5L,2L,5L,3L,5L,7L,3L,2L,3L,2L,3L,3L,3L,2L,7L,5L,2L,7L,3L,3L,7L,5L,5L,2L,7L,5L,2L,3L,7L,2L,2L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086387Inst : IEnumerable<long>
{
public static readonly long[] Value=A086387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086387.Bytes);
public long this[int i]=>Value[i];

public static A086387Inst Instance=new A086387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086532
{
public static readonly long[] Value={ 17L,23L,43L,61L,53L,41L,59L,83L,79L,61L,83L,107L,109L,97L,101L,131L,137L,131L,139L,151L,163L,181L,173L,137L,157L,181L,179L,197L,227L,233L,211L,193L,191L,227L,241L,229L,233L,239L,257L,269L,277L,283L,281L,293L,307L,313L,311L,317L,337L,349L,337L,307L,317L,353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086532Inst : IEnumerable<long>
{
public static readonly long[] Value=A086532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086532.Bytes);
public long this[int i]=>Value[i];

public static A086532Inst Instance=new A086532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086533
{
public static readonly long[] Value={ 17L,65L,89L,127L,137L,163L,179L,185L,191L,233L,247L,269L,305L,343L,427L,457L,547L,569L,583L,613L,637L,667L,673L,697L,733L,757L,779L,787L,817L,821L,853L,929L,967L,977L,989L,997L,1045L,1087L,1117L,1207L,1267L,1273L,1289L,1297L,1327L,1345L,1357L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086533Inst : IEnumerable<long>
{
public static readonly long[] Value=A086533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086533.Bytes);
public long this[int i]=>Value[i];

public static A086533Inst Instance=new A086533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086534
{
public static readonly long[] Value={ 2L,17L,271L,1249L,13121L,13121L,153089L,1272833L,28146689L,193562623L,652963841L,1378557953L,29096394751L,316431663103L,2191221587969L,15356401156097L,128200797454337L,314394051346433L,314394051346433L,28344942091829249L,201993039632138239L,267803891553271807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086534Inst : IEnumerable<long>
{
public static readonly long[] Value=A086534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086534.Bytes);
public long this[int i]=>Value[i];

public static A086534Inst Instance=new A086534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086535
{
public static readonly long[] Value={ 2L,2L,8L,6L,12L,40L,16L,42L,80L,108L,24L,1320L,28L,208L,768L,630L,36L,6800L,40L,6156L,1408L,504L,48L,212520L,312L,700L,2240L,16848L,60L,1002240L,64L,19530L,3264L,1188L,3456L,7854000L,76L,1480L,4480L,1680588L,84L,3752320L,88L,65016L,353280L,2160L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086535Inst : IEnumerable<long>
{
public static readonly long[] Value=A086535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086535.Bytes);
public long this[int i]=>Value[i];

public static A086535Inst Instance=new A086535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086536
{
public static readonly long[] Value={ 2L,2L,4L,6L,6L,20L,8L,42L,20L,18L,12L,660L,14L,104L,48L,210L,18L,340L,20L,342L,88L,84L,24L,106260L,78L,350L,140L,2808L,30L,20880L,32L,6510L,204L,198L,72L,78540L,38L,740L,280L,31122L,42L,234520L,44L,3612L,5520L,360L,48L,4994220L,200L,11466L,468L,17850L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086536Inst : IEnumerable<long>
{
public static readonly long[] Value=A086536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086536.Bytes);
public long this[int i]=>Value[i];

public static A086536Inst Instance=new A086536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086537
{
public static readonly long[] Value={ 1L,2L,3L,6L,4L,8L,12L,13L,11L,10L,26L,16L,32L,24L,42L,30L,48L,55L,17L,36L,52L,64L,118L,18L,27L,45L,9L,39L,72L,56L,104L,80L,40L,140L,84L,96L,160L,128L,192L,240L,144L,216L,120L,60L,180L,245L,75L,256L,114L,14L,304L,112L,320L,288L,292L,220L,280L,360L,384L,156L,261L,159L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086537Inst : IEnumerable<long>
{
public static readonly long[] Value=A086537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086537.Bytes);
public long this[int i]=>Value[i];

public static A086537Inst Instance=new A086537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086538
{
public static readonly long[] Value={ 1L,3L,6L,12L,16L,24L,36L,49L,60L,70L,96L,112L,144L,168L,210L,240L,288L,343L,360L,396L,448L,512L,630L,648L,675L,720L,729L,768L,840L,896L,1000L,1080L,1120L,1260L,1344L,1440L,1600L,1728L,1920L,2160L,2304L,2520L,2640L,2700L,2880L,3125L,3200L,3456L,3570L,3584L,3888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086538Inst : IEnumerable<long>
{
public static readonly long[] Value=A086538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086538.Bytes);
public long this[int i]=>Value[i];

public static A086538Inst Instance=new A086538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086539
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,8L,9L,11L,13L,17L,19L,23L,25L,28L,29L,31L,33L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,80L,83L,89L,91L,97L,101L,103L,107L,109L,111L,113L,121L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,230L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086539Inst : IEnumerable<long>
{
public static readonly long[] Value=A086539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086539.Bytes);
public long this[int i]=>Value[i];

public static A086539Inst Instance=new A086539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086540
{
public static readonly long[] Value={ 18L,55L,248L,340L,348L,722L,850L,949L,1061L,1148L,1204L,1205L,1241L,1277L,1314L,1315L,1667L,1672L,2148L,2716L,2948L,2949L,3258L,3581L,3650L,3651L,4044L,4265L,4627L,4842L,5092L,5093L,5451L,5741L,5765L,6244L,6355L,6356L,6565L,6640L,6851L,6963L,7362L,7404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086540Inst : IEnumerable<long>
{
public static readonly long[] Value=A086540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086540.Bytes);
public long this[int i]=>Value[i];

public static A086540Inst Instance=new A086540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086541
{
public static readonly BigInteger[] Value={ 1L,4L,9L,49L,2116L,1104601L,1220041748025L,BigInteger.Parse("73506264463383837985201"),BigInteger.Parse("152589000107917580345020742323132226398704361"),BigInteger.Parse("1669769004292648133509475727812173973930459916514124965718261930975078855532062950740889") };
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
public class A086541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086541Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086541.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086541Inst Instance=new A086541Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086542
{
public static readonly BigInteger[] Value={ 1L,2L,3L,7L,46L,1051L,1104555L,271120387399L,BigInteger.Parse("12352692018662068964269"),BigInteger.Parse("40862807102457463617366568538820398287649083"),BigInteger.Parse("225437603322499065887950319699480706044268704455246940203952437430893410176172636967447") };
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
public class A086542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086542Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086542.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086542Inst Instance=new A086542Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086543
{
public static readonly long[] Value={ 0L,1L,1L,3L,3L,7L,8L,15L,17L,30L,35L,56L,66L,101L,120L,176L,209L,297L,355L,490L,585L,792L,946L,1255L,1498L,1958L,2335L,3010L,3583L,4565L,5428L,6842L,8118L,10143L,12013L,14883L,17592L,21637L,25525L,31185L,36711L,44583L,52382L,63261L,74173L,89134L,104303L,124754L,145698L,173525L,202268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086543Inst : IEnumerable<long>
{
public static readonly long[] Value=A086543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086543.Bytes);
public long this[int i]=>Value[i];

public static A086543Inst Instance=new A086543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086544
{
public static readonly long[] Value={ 0L,10L,42L,43L,79L,88L,100L,102L,189L,198L,242L,250L,252L,263L,305L,262L,370L,306L,368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086544Inst : IEnumerable<long>
{
public static readonly long[] Value=A086544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086544.Bytes);
public long this[int i]=>Value[i];

public static A086544Inst Instance=new A086544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086545
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,6L,0L,4L,3L,2L,1L,4L,0L,2L,15L,8L,1L,0L,0L,10L,3L,2L,0L,24L,5L,0L,27L,0L,1L,10L,0L,0L,3L,2L,5L,0L,0L,2L,13L,20L,1L,0L,0L,4L,15L,0L,0L,0L,0L,50L,3L,0L,0L,18L,5L,8L,19L,0L,1L,12L,0L,2L,9L,32L,5L,66L,0L,4L,3L,0L,1L,24L,0L,2L,25L,38L,7L,78L,0L,16L,0L,2L,0L,12L,5L,0L,0L,44L,89L,30L,0L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086545Inst : IEnumerable<long>
{
public static readonly long[] Value=A086545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086545.Bytes);
public long this[int i]=>Value[i];

public static A086545Inst Instance=new A086545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086546
{
public static readonly BigInteger[] Value={ 1L,2L,10L,52L,1602L,9320L,335370L,2057052L,79838402L,20389179850L,130733490052L,35269446507320L,1495263184293450L,9772003262651052L,420005834402064002L,BigInteger.Parse("119930320621764716170"),BigInteger.Parse("34690018838525896638402"),BigInteger.Parse("229973223827810009313800") };
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
public class A086546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086546Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086546.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086546Inst Instance=new A086546Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086547
{
public static readonly long[] Value={ 23L,31L,49L,53L,62L,71L,80062991L,961L,106L,113L,124L,131L,141L,155L,163047361L,173L,188L,191L,207L,213L,221L,233L,248L,253009L,262L,270840023L,284L,293L,3002L,311L,3201078401357L,334L,341L,355L,3621409L,373L,381L,391L,4023L,419L,426L,431L,4412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086547Inst : IEnumerable<long>
{
public static readonly long[] Value=A086547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086547.Bytes);
public long this[int i]=>Value[i];

public static A086547Inst Instance=new A086547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086564
{
public static readonly long[] Value={ 0L,4L,3L,11L,9L,36L,15L,33L,39L,69L,63L,45L,171L,117L,243L,105L,150L,135L,165L,255L,231L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086564Inst : IEnumerable<long>
{
public static readonly long[] Value=A086564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086564.Bytes);
public long this[int i]=>Value[i];

public static A086564Inst Instance=new A086564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086565
{
public static readonly long[] Value={ 1L,2L,3L,9L,8L,6L,15L,12L,18L,45L,24L,32L,54L,30L,42L,64L,102L,72L,108L,154L,60L,84L,96L,140L,126L,200L,120L,204L,308L,168L,192L,280L,180L,210L,240L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086565Inst : IEnumerable<long>
{
public static readonly long[] Value=A086565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086565.Bytes);
public long this[int i]=>Value[i];

public static A086565Inst Instance=new A086565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086566
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,17L,23L,31L,47L,71L,107L,163L,241L,367L,557L,839L,1277L,1933L,2939L,4463L,6793L,10337L,15733L,23929L,36389L,55381L,84263L,128239L,195163L,297023L,452077L,688073L,1047271L,1593947L,2426041L,3692527L,5620159L,8554093L,13019651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086566Inst : IEnumerable<long>
{
public static readonly long[] Value=A086566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086566.Bytes);
public long this[int i]=>Value[i];

public static A086566Inst Instance=new A086566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086567
{
public static readonly long[] Value={ 1L,0L,3L,5L,4L,0L,5L,10L,7L,11L,6L,0L,7L,16L,11L,9L,10L,21L,8L,0L,9L,21L,12L,27L,11L,14L,17L,23L,10L,0L,11L,32L,18L,27L,18L,13L,15L,28L,19L,32L,12L,0L,13L,38L,25L,19L,18L,47L,15L,44L,16L,38L,18L,50L,14L,0L,15L,39L,20L,59L,18L,54L,28L,17L,24L,31L,21L,28L,29L,49L,16L,0L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086567Inst : IEnumerable<long>
{
public static readonly long[] Value=A086567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086567.Bytes);
public long this[int i]=>Value[i];

public static A086567Inst Instance=new A086567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086568
{
public static readonly long[] Value={ 1L,2L,2L,6L,2L,6L,2L,30L,6L,6L,2L,30L,2L,6L,6L,210L,2L,30L,2L,30L,6L,6L,2L,210L,6L,6L,30L,30L,2L,30L,2L,2310L,6L,6L,6L,210L,2L,6L,6L,210L,2L,30L,2L,30L,30L,6L,2L,2310L,6L,30L,6L,30L,2L,210L,6L,210L,6L,6L,2L,210L,2L,6L,30L,30030L,6L,30L,2L,30L,6L,30L,2L,2310L,2L,6L,30L,30L,6L,30L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086568Inst : IEnumerable<long>
{
public static readonly long[] Value=A086568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086568.Bytes);
public long this[int i]=>Value[i];

public static A086568Inst Instance=new A086568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086569
{
public static readonly BigInteger[] Value={ 1L,-3L,28L,-375L,3751L,-49392L,6835648L,-1343091375L,364668913756L,-210736858987743L,101832157445630503L,BigInteger.Parse("-67043511427995648000"),BigInteger.Parse("487627751563388801409591"),BigInteger.Parse("-4875797582053878382039400448"),BigInteger.Parse("58623274842128064372315087290368") };
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
public class A086569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086569Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086569.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086569Inst Instance=new A086569Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086570
{
public static readonly long[] Value={ 1L,5L,12L,20L,28L,36L,44L,52L,60L,68L,76L,84L,92L,100L,108L,116L,124L,132L,140L,148L,156L,164L,172L,180L,188L,196L,204L,212L,220L,228L,236L,244L,252L,260L,268L,276L,284L,292L,300L,308L,316L,324L,332L,340L,348L,356L,364L,372L,380L,388L,396L,404L,412L,420L,428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086570Inst : IEnumerable<long>
{
public static readonly long[] Value=A086570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086570.Bytes);
public long this[int i]=>Value[i];

public static A086570Inst Instance=new A086570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086571
{
public static readonly long[] Value={ 1L,1L,3L,2L,5L,2L,7L,4L,3L,5L,11L,4L,13L,7L,15L,8L,17L,6L,19L,10L,21L,11L,23L,6L,25L,13L,9L,14L,29L,10L,31L,8L,33L,17L,35L,9L,37L,19L,39L,20L,41L,14L,43L,22L,15L,23L,47L,12L,49L,25L,51L,26L,53L,18L,55L,28L,57L,29L,59L,12L,61L,31L,21L,16L,65L,22L,67L,34L,69L,35L,71L,18L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086571Inst : IEnumerable<long>
{
public static readonly long[] Value=A086571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086571.Bytes);
public long this[int i]=>Value[i];

public static A086571Inst Instance=new A086571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086572
{
public static readonly long[] Value={ 2L,1L,9L,6L,10L,4L,14L,12L,3L,5L,22L,8L,26L,7L,45L,32L,34L,24L,38L,30L,63L,11L,46L,18L,50L,13L,36L,42L,58L,20L,62L,16L,99L,17L,70L,27L,74L,19L,117L,100L,82L,28L,86L,66L,15L,23L,94L,60L,98L,25L,153L,78L,106L,72L,110L,84L,171L,29L,118L,48L,122L,31L,21L,80L,130L,44L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086572Inst : IEnumerable<long>
{
public static readonly long[] Value=A086572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086572.Bytes);
public long this[int i]=>Value[i];

public static A086572Inst Instance=new A086572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086573
{
public static readonly long[] Value={ 0L,18L,198L,1998L,19998L,199998L,1999998L,19999998L,199999998L,1999999998L,19999999998L,199999999998L,1999999999998L,19999999999998L,199999999999998L,1999999999999998L,19999999999999998L,199999999999999998L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086573Inst : IEnumerable<long>
{
public static readonly long[] Value=A086573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086573.Bytes);
public long this[int i]=>Value[i];

public static A086573Inst Instance=new A086573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086574
{
public static readonly long[] Value={ 0L,27L,297L,2997L,29997L,299997L,2999997L,29999997L,299999997L,2999999997L,29999999997L,299999999997L,2999999999997L,29999999999997L,299999999999997L,2999999999999997L,29999999999999997L,299999999999999997L,2999999999999999997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086574Inst : IEnumerable<long>
{
public static readonly long[] Value=A086574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086574.Bytes);
public long this[int i]=>Value[i];

public static A086574Inst Instance=new A086574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086575
{
public static readonly long[] Value={ 0L,36L,396L,3996L,39996L,399996L,3999996L,39999996L,399999996L,3999999996L,39999999996L,399999999996L,3999999999996L,39999999999996L,399999999999996L,3999999999999996L,39999999999999996L,399999999999999996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086575Inst : IEnumerable<long>
{
public static readonly long[] Value=A086575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086575.Bytes);
public long this[int i]=>Value[i];

public static A086575Inst Instance=new A086575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086576
{
public static readonly long[] Value={ 0L,45L,495L,4995L,49995L,499995L,4999995L,49999995L,499999995L,4999999995L,49999999995L,499999999995L,4999999999995L,49999999999995L,499999999999995L,4999999999999995L,49999999999999995L,499999999999999995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086576Inst : IEnumerable<long>
{
public static readonly long[] Value=A086576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086576.Bytes);
public long this[int i]=>Value[i];

public static A086576Inst Instance=new A086576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086577
{
public static readonly long[] Value={ 0L,54L,594L,5994L,59994L,599994L,5999994L,59999994L,599999994L,5999999994L,59999999994L,599999999994L,5999999999994L,59999999999994L,599999999999994L,5999999999999994L,59999999999999994L,599999999999999994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086577Inst : IEnumerable<long>
{
public static readonly long[] Value=A086577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086577.Bytes);
public long this[int i]=>Value[i];

public static A086577Inst Instance=new A086577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086578
{
public static readonly long[] Value={ 0L,63L,693L,6993L,69993L,699993L,6999993L,69999993L,699999993L,6999999993L,69999999993L,699999999993L,6999999999993L,69999999999993L,699999999999993L,6999999999999993L,69999999999999993L,699999999999999993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086578Inst : IEnumerable<long>
{
public static readonly long[] Value=A086578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086578.Bytes);
public long this[int i]=>Value[i];

public static A086578Inst Instance=new A086578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086579
{
public static readonly long[] Value={ 0L,72L,792L,7992L,79992L,799992L,7999992L,79999992L,799999992L,7999999992L,79999999992L,799999999992L,7999999999992L,79999999999992L,799999999999992L,7999999999999992L,79999999999999992L,799999999999999992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086579Inst : IEnumerable<long>
{
public static readonly long[] Value=A086579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086579.Bytes);
public long this[int i]=>Value[i];

public static A086579Inst Instance=new A086579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086612
{
public static readonly long[] Value={ 1L,1L,1L,-1L,2L,2L,-2L,-1L,6L,5L,-1L,-6L,0L,20L,14L,0L,-5L,-22L,10L,70L,42L,0L,2L,-30L,-80L,70L,252L,132L,0L,6L,6L,-165L,-280L,378L,924L,429L,0L,4L,52L,-20L,-840L,-924L,1848L,3432L,1430L,0L,1L,48L,330L,-406L,-4032L,-2772L,8580L,12870L,4862L,0L,0L,0L,440L,1750L,-3528L,-18480L,-6864L,38610L,48620L,16796L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086612Inst : IEnumerable<long>
{
public static readonly long[] Value=A086612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086612.Bytes);
public long this[int i]=>Value[i];

public static A086612Inst Instance=new A086612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086613
{
public static readonly long[] Value={ 1L,2L,3L,8L,27L,95L,346L,1298L,4982L,19481L,77344L,310981L,1263768L,5182584L,21420400L,89139754L,373179358L,1570606386L,6641563144L,28204255713L,120231876230L,514315720218L,2207041605690L,9498267611429L,40985335385212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086613Inst : IEnumerable<long>
{
public static readonly long[] Value=A086613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086613.Bytes);
public long this[int i]=>Value[i];

public static A086613Inst Instance=new A086613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086614
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,2L,4L,10L,12L,5L,5L,20L,42L,40L,14L,6L,35L,112L,180L,140L,42L,7L,56L,252L,600L,770L,504L,132L,8L,84L,504L,1650L,3080L,3276L,1848L,429L,9L,120L,924L,3960L,10010L,15288L,13860L,6864L,1430L,10L,165L,1584L,8580L,28028L,57330L,73920L,58344L,25740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086614Inst : IEnumerable<long>
{
public static readonly long[] Value=A086614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086614.Bytes);
public long this[int i]=>Value[i];

public static A086614Inst Instance=new A086614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086615
{
public static readonly long[] Value={ 1L,2L,4L,8L,17L,38L,89L,216L,539L,1374L,3562L,9360L,24871L,66706L,180340L,490912L,1344379L,3701158L,10237540L,28436824L,79288843L,221836402L,622599625L,1752360040L,4945087837L,13988490338L,39658308814L,112666081616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086615Inst : IEnumerable<long>
{
public static readonly long[] Value=A086615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086615.Bytes);
public long this[int i]=>Value[i];

public static A086615Inst Instance=new A086615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086616
{
public static readonly long[] Value={ 1L,3L,9L,31L,121L,515L,2321L,10879L,52465L,258563L,1296281L,6589727L,33887465L,175966211L,921353249L,4858956287L,25786112993L,137604139011L,737922992937L,3974647310111L,21493266631001L,116642921832963L,635074797251889L,3467998148181631L,18989465797056721L,104239408386028035L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086616Inst : IEnumerable<long>
{
public static readonly long[] Value=A086616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086616.Bytes);
public long this[int i]=>Value[i];

public static A086616Inst Instance=new A086616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086617
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,7L,4L,1L,1L,5L,13L,13L,5L,1L,1L,6L,21L,33L,21L,6L,1L,1L,7L,31L,69L,69L,31L,7L,1L,1L,8L,43L,126L,183L,126L,43L,8L,1L,1L,9L,57L,209L,411L,411L,209L,57L,9L,1L,1L,10L,73L,323L,815L,1118L,815L,323L,73L,10L,1L,1L,11L,91L,473L,1471L,2633L,2633L,1471L,473L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086617Inst : IEnumerable<long>
{
public static readonly long[] Value=A086617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086617.Bytes);
public long this[int i]=>Value[i];

public static A086617Inst Instance=new A086617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086618
{
public static readonly long[] Value={ 1L,2L,7L,33L,183L,1118L,7281L,49626L,349999L,2535078L,18758265L,141254655L,1079364105L,8350678170L,65298467487L,515349097713L,4100346740511L,32858696386766L,265001681344569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086618Inst : IEnumerable<long>
{
public static readonly long[] Value=A086618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086618.Bytes);
public long this[int i]=>Value[i];

public static A086618Inst Instance=new A086618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086619
{
public static readonly BigInteger[] Value={ 1L,2L,10L,150L,7650L,1438200L,1051324200L,3101406390000L,37945707181650000L,BigInteger.Parse("1966422437567466300000"),BigInteger.Parse("438887790263120370963300000"),BigInteger.Parse("427664112802721593716655529100000") };
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
public class A086619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086619Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086619.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086619Inst Instance=new A086619Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086620
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,5L,5L,1L,1L,7L,14L,7L,1L,1L,9L,28L,28L,9L,1L,1L,11L,47L,79L,47L,11L,1L,1L,13L,71L,175L,175L,71L,13L,1L,1L,15L,100L,331L,504L,331L,100L,15L,1L,1L,17L,134L,562L,1196L,1196L,562L,134L,17L,1L,1L,19L,173L,883L,2464L,3514L,2464L,883L,173L,19L,1L,1L,21L,217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086620Inst : IEnumerable<long>
{
public static readonly long[] Value=A086620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086620.Bytes);
public long this[int i]=>Value[i];

public static A086620Inst Instance=new A086620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086621
{
public static readonly long[] Value={ 1L,3L,14L,79L,504L,3514L,26172L,204831L,1664696L,13930840L,119312544L,1041227642L,9228614836L,82867255956L,752405060536L,6897376441167L,63760133568096L,593763928313128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086621Inst : IEnumerable<long>
{
public static readonly long[] Value=A086621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086621.Bytes);
public long this[int i]=>Value[i];

public static A086621Inst Instance=new A086621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086622
{
public static readonly long[] Value={ 1L,2L,5L,12L,30L,76L,197L,520L,1398L,3820L,10594L,29768L,84620L,243000L,704045L,2055760L,6043750L,17875020L,53148310L,158773320L,476311940L,1434313960L,4333867170L,13135533552L,39924668220L,121661345656L,371612931492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086622Inst : IEnumerable<long>
{
public static readonly long[] Value=A086622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086622.Bytes);
public long this[int i]=>Value[i];

public static A086622Inst Instance=new A086622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086623
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,3L,4L,3L,1L,1L,4L,8L,8L,4L,1L,1L,5L,14L,19L,14L,5L,1L,1L,6L,22L,40L,40L,22L,6L,1L,1L,7L,32L,76L,100L,76L,32L,7L,1L,1L,8L,44L,132L,222L,222L,132L,44L,8L,1L,1L,9L,58L,213L,448L,570L,448L,213L,58L,9L,1L,1L,10L,74L,324L,834L,1316L,1316L,834L,324L,74L,10L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086623Inst : IEnumerable<long>
{
public static readonly long[] Value=A086623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086623.Bytes);
public long this[int i]=>Value[i];

public static A086623Inst Instance=new A086623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086624
{
public static readonly long[] Value={ 1L,1L,4L,19L,100L,570L,3442L,21685L,141112L,941990L,6419174L,44493000L,312818326L,2226155632L,16008452202L,116167346499L,849724397580L,6259403310366L,46399703925202L,345894094030552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086624Inst : IEnumerable<long>
{
public static readonly long[] Value=A086624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086624.Bytes);
public long this[int i]=>Value[i];

public static A086624Inst Instance=new A086624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086625
{
public static readonly long[] Value={ 1L,2L,3L,6L,12L,26L,59L,138L,332L,814L,2028L,5118L,13054L,33598L,87143L,227542L,597640L,1577866L,4185108L,11146570L,29798682L,79932298L,215072896L,580327122L,1569942098L,4257254850L,11569980794L,31508150890L,85968266198L,234975421554L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086625Inst : IEnumerable<long>
{
public static readonly long[] Value=A086625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086625.Bytes);
public long this[int i]=>Value[i];

public static A086625Inst Instance=new A086625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086626
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,3L,1L,1L,6L,9L,6L,1L,1L,10L,24L,24L,10L,1L,1L,15L,57L,84L,57L,15L,1L,1L,21L,120L,249L,249L,120L,21L,1L,1L,28L,228L,654L,907L,654L,228L,28L,1L,1L,36L,399L,1554L,2880L,2880L,1554L,399L,36L,1L,1L,45L,654L,3384L,8178L,10821L,8178L,3384L,654L,45L,1L,1L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086626Inst : IEnumerable<long>
{
public static readonly long[] Value=A086626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086626.Bytes);
public long this[int i]=>Value[i];

public static A086626Inst Instance=new A086626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086627
{
public static readonly long[] Value={ 1L,1L,9L,84L,907L,10821L,137832L,1840560L,25467579L,362282805L,5269082817L,78037617936L,1173393814590L,17870848219324L,275178599887938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086627Inst : IEnumerable<long>
{
public static readonly long[] Value=A086627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086627.Bytes);
public long this[int i]=>Value[i];

public static A086627Inst Instance=new A086627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086676
{
public static readonly long[] Value={ 2L,3L,5L,8L,12L,18L,29L,44L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086676Inst : IEnumerable<long>
{
public static readonly long[] Value=A086676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086676.Bytes);
public long this[int i]=>Value[i];

public static A086676Inst Instance=new A086676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086677
{
public static readonly BigInteger[] Value={ 1L,4L,31L,360L,5625L,110880L,2643795L,74035080L,2382538725L,86656878000L,3515761193175L,157425426358200L,7711961781949425L,410298436511964000L,BigInteger.Parse("23559634669682986875"),BigInteger.Parse("1452240056377167057000"),BigInteger.Parse("95649328231839993736125") };
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
public class A086677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086677Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A086677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086677.Bytes);
public BigInteger this[int i]=>Value[i];

public static A086677Inst Instance=new A086677Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A086678
{
public static readonly long[] Value={ 1L,2L,8L,9L,11L,20L,27L,36L,41L,42L,71L,77L,86L,95L,105L,110L,113L,132L,134L,137L,138L,147L,149L,155L,183L,186L,189L,201L,209L,210L,212L,215L,218L,222L,230L,245L,258L,261L,278L,309L,317L,329L,336L,341L,347L,359L,371L,377L,380L,389L,411L,413L,417L,425L,432L,435L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A086678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A086678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A086678Inst : IEnumerable<long>
{
public static readonly long[] Value=A086678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A086678.Bytes);
public long this[int i]=>Value[i];

public static A086678Inst Instance=new A086678Inst();

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