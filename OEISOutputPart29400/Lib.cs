using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A019685
{
public static readonly long[] Value={ 0L,1L,7L,4L,5L,3L,2L,9L,2L,5L,1L,9L,9L,4L,3L,2L,9L,5L,7L,6L,9L,2L,3L,6L,9L,0L,7L,6L,8L,4L,8L,8L,6L,1L,2L,7L,1L,3L,4L,4L,2L,8L,7L,1L,8L,8L,8L,5L,4L,1L,7L,2L,5L,4L,5L,6L,0L,9L,7L,1L,9L,1L,4L,4L,0L,1L,7L,1L,0L,0L,9L,1L,1L,4L,6L,0L,3L,4L,4L,9L,4L,4L,3L,6L,8L,2L,2L,4L,1L,5L,6L,9L,6L,3L,4L,5L,0L,9L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019685Inst : IEnumerable<long>
{
public static readonly long[] Value=A019685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019685.Bytes);
public long this[int i]=>Value[i];

public static A019685Inst Instance=new A019685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019684
{
public static readonly long[] Value={ 1L,8L,4L,7L,9L,9L,5L,6L,7L,8L,5L,8L,2L,2L,3L,1L,3L,1L,6L,7L,4L,2L,7L,3L,1L,4L,0L,1L,9L,2L,9L,1L,1L,9L,3L,4L,3L,6L,4L,5L,3L,9L,3L,7L,6L,4L,3L,3L,8L,2L,9L,7L,5L,4L,1L,7L,4L,9L,9L,6L,7L,4L,0L,7L,2L,3L,9L,8L,9L,2L,0L,0L,3L,6L,9L,7L,7L,6L,9L,9L,9L,9L,1L,9L,2L,9L,6L,1L,6L,6L,1L,9L,6L,5L,9L,5L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019684Inst : IEnumerable<long>
{
public static readonly long[] Value=A019684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019684.Bytes);
public long this[int i]=>Value[i];

public static A019684Inst Instance=new A019684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019683
{
public static readonly long[] Value={ 1L,9L,6L,3L,4L,9L,5L,4L,0L,8L,4L,9L,3L,6L,2L,0L,7L,7L,4L,0L,3L,9L,1L,5L,2L,1L,1L,4L,5L,4L,9L,6L,8L,9L,3L,0L,2L,6L,2L,3L,2L,3L,0L,8L,7L,4L,6L,0L,9L,4L,4L,1L,1L,3L,8L,1L,0L,9L,3L,4L,0L,3L,7L,0L,1L,9L,2L,3L,8L,5L,2L,5L,3L,9L,2L,8L,8L,8L,0L,6L,2L,4L,1L,4L,2L,5L,2L,1L,7L,6L,5L,8L,3L,8L,8L,2L,3L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019683Inst : IEnumerable<long>
{
public static readonly long[] Value=A019683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019683.Bytes);
public long this[int i]=>Value[i];

public static A019683Inst Instance=new A019683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019682
{
public static readonly BigInteger[] Value={ 1L,23L,363L,4891L,60515L,710619L,8059507L,89191307L,969344739L,10390594555L,110181318611L,1158295737963L,12091317123523L,125488476039131L,1296062772061875L,13331230899395659L,136647741897916067L,1396496332294665147L,14235133611505668499UL,BigInteger.Parse("144782868986965745195") };
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
public class A019682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019682Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019682.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019682Inst Instance=new A019682Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019681
{
public static readonly long[] Value={ 2L,2L,4L,3L,9L,9L,4L,7L,5L,2L,5L,6L,4L,1L,3L,8L,0L,2L,7L,4L,7L,3L,3L,1L,6L,7L,0L,2L,3L,4L,2L,5L,0L,2L,0L,6L,0L,1L,4L,0L,8L,3L,5L,2L,8L,5L,2L,6L,7L,9L,3L,2L,7L,2L,9L,2L,6L,7L,8L,1L,7L,5L,6L,5L,9L,3L,4L,1L,5L,4L,5L,7L,5L,9L,1L,8L,7L,2L,0L,7L,1L,3L,3L,0L,5L,7L,3L,9L,1L,6L,0L,9L,5L,8L,6L,5L,5L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019681Inst : IEnumerable<long>
{
public static readonly long[] Value=A019681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019681.Bytes);
public long this[int i]=>Value[i];

public static A019681Inst Instance=new A019681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019680
{
public static readonly long[] Value={ 2L,4L,1L,6L,6L,0L,9L,7L,3L,3L,5L,3L,0L,6L,1L,0L,1L,8L,3L,4L,3L,2L,8L,0L,2L,6L,0L,2L,5L,2L,2L,6L,9L,4L,5L,2L,6L,3L,0L,5L,5L,1L,4L,9L,2L,2L,5L,9L,6L,2L,3L,5L,2L,4L,6L,9L,0L,3L,8L,0L,3L,5L,3L,2L,5L,4L,4L,4L,7L,4L,1L,5L,8L,6L,8L,1L,6L,9L,9L,2L,2L,9L,7L,1L,3L,8L,7L,2L,9L,4L,2L,5L,7L,0L,8L,5L,9L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019680Inst : IEnumerable<long>
{
public static readonly long[] Value=A019680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019680.Bytes);
public long this[int i]=>Value[i];

public static A019680Inst Instance=new A019680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019679
{
public static readonly long[] Value={ 2L,6L,1L,7L,9L,9L,3L,8L,7L,7L,9L,9L,1L,4L,9L,4L,3L,6L,5L,3L,8L,5L,5L,3L,6L,1L,5L,2L,7L,3L,2L,9L,1L,9L,0L,7L,0L,1L,6L,4L,3L,0L,7L,8L,3L,2L,8L,1L,2L,5L,8L,8L,1L,8L,4L,1L,4L,5L,7L,8L,7L,1L,6L,0L,2L,5L,6L,5L,1L,3L,6L,7L,1L,9L,0L,5L,1L,7L,4L,1L,6L,5L,5L,2L,3L,3L,6L,2L,3L,5L,4L,4L,5L,1L,7L,6L,4L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019679Inst : IEnumerable<long>
{
public static readonly long[] Value=A019679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019679.Bytes);
public long this[int i]=>Value[i];

public static A019679Inst Instance=new A019679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019678
{
public static readonly long[] Value={ 2L,8L,5L,5L,9L,9L,3L,3L,2L,1L,4L,4L,5L,2L,6L,6L,5L,8L,0L,4L,2L,0L,5L,8L,4L,8L,9L,3L,8L,9L,0L,4L,5L,7L,1L,6L,7L,4L,5L,1L,9L,7L,2L,1L,8L,1L,2L,5L,0L,0L,9L,6L,2L,0L,0L,8L,8L,6L,3L,1L,3L,2L,6L,5L,7L,3L,4L,3L,7L,8L,5L,5L,1L,1L,6L,9L,2L,8L,0L,9L,0L,7L,8L,4L,3L,6L,6L,8L,0L,2L,3L,0L,3L,8L,2L,8L,8L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019678Inst : IEnumerable<long>
{
public static readonly long[] Value=A019678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019678.Bytes);
public long this[int i]=>Value[i];

public static A019678Inst Instance=new A019678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019661
{
public static readonly long[] Value={ 1L,7L,1L,8L,9L,8L,9L,6L,2L,6L,6L,6L,0L,1L,6L,3L,4L,4L,9L,7L,3L,0L,3L,6L,6L,5L,1L,5L,3L,5L,7L,4L,6L,0L,1L,8L,5L,5L,2L,8L,1L,8L,0L,9L,1L,3L,3L,2L,1L,5L,0L,9L,9L,1L,7L,0L,6L,9L,2L,5L,8L,8L,3L,0L,2L,7L,7L,6L,2L,1L,2L,7L,7L,8L,6L,0L,5L,6L,2L,8L,7L,3L,2L,0L,2L,3L,2L,7L,3L,9L,2L,8L,0L,4L,1L,5L,2L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019661Inst : IEnumerable<long>
{
public static readonly long[] Value=A019661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019661.Bytes);
public long this[int i]=>Value[i];

public static A019661Inst Instance=new A019661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019660
{
public static readonly long[] Value={ 1L,8L,2L,6L,4L,2L,6L,4L,7L,8L,3L,2L,6L,4L,2L,3L,6L,6L,5L,3L,3L,8L,5L,1L,4L,4L,2L,2L,5L,6L,7L,3L,0L,1L,4L,4L,7L,1L,2L,3L,6L,9L,2L,2L,2L,0L,4L,0L,4L,1L,0L,4L,2L,8L,6L,8L,8L,6L,0L,8L,7L,5L,0L,7L,1L,6L,9L,9L,7L,2L,6L,0L,7L,7L,2L,6L,8L,4L,8L,0L,5L,2L,7L,7L,7L,4L,7L,2L,8L,5L,4L,8L,5L,4L,4L,1L,1L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019660Inst : IEnumerable<long>
{
public static readonly long[] Value=A019660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019660.Bytes);
public long this[int i]=>Value[i];

public static A019660Inst Instance=new A019660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019659
{
public static readonly long[] Value={ 1L,9L,4L,8L,1L,8L,8L,2L,4L,3L,5L,4L,8L,1L,8L,5L,2L,4L,3L,0L,2L,7L,7L,4L,8L,7L,1L,7L,4L,0L,5L,1L,2L,1L,5L,4L,3L,5L,9L,8L,6L,0L,5L,0L,3L,5L,0L,9L,7L,7L,1L,1L,2L,3L,9L,3L,4L,5L,1L,6L,0L,0L,0L,7L,6L,4L,7L,9L,7L,0L,7L,8L,1L,5L,7L,5L,3L,0L,4L,5L,8L,9L,6L,2L,9L,3L,0L,4L,3L,7L,8L,5L,1L,1L,3L,7L,2L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019659Inst : IEnumerable<long>
{
public static readonly long[] Value=A019659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019659.Bytes);
public long this[int i]=>Value[i];

public static A019659Inst Instance=new A019659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019658
{
public static readonly long[] Value={ 2L,0L,8L,7L,3L,4L,4L,5L,4L,6L,6L,5L,8L,7L,6L,9L,9L,0L,3L,2L,4L,4L,0L,1L,6L,4L,8L,2L,9L,3L,4L,0L,5L,8L,7L,9L,6L,7L,1L,2L,7L,9L,1L,1L,0L,9L,0L,3L,3L,2L,6L,2L,0L,4L,2L,1L,5L,5L,5L,2L,8L,5L,7L,9L,6L,2L,2L,8L,2L,5L,8L,3L,7L,4L,0L,2L,1L,1L,2L,0L,6L,0L,3L,1L,7L,1L,1L,1L,8L,3L,4L,1L,1L,9L,3L,2L,7L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019658Inst : IEnumerable<long>
{
public static readonly long[] Value=A019658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019658.Bytes);
public long this[int i]=>Value[i];

public static A019658Inst Instance=new A019658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019657
{
public static readonly long[] Value={ 2L,2L,4L,7L,9L,0L,9L,5L,1L,1L,7L,8L,6L,3L,6L,7L,5L,8L,8L,1L,0L,8L,9L,4L,0L,8L,2L,7L,7L,7L,5L,1L,4L,0L,2L,4L,2L,6L,1L,3L,7L,7L,5L,0L,4L,0L,4L,9L,7L,3L,5L,9L,1L,2L,2L,3L,2L,1L,3L,3L,8L,4L,7L,0L,3L,6L,3L,0L,4L,3L,2L,0L,9L,5L,0L,9L,9L,6L,6L,8L,3L,4L,1L,8L,7L,6L,5L,8L,8L,9L,8L,2L,8L,2L,3L,5L,3L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019657Inst : IEnumerable<long>
{
public static readonly long[] Value=A019657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019657.Bytes);
public long this[int i]=>Value[i];

public static A019657Inst Instance=new A019657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019656
{
public static readonly long[] Value={ 2L,4L,3L,5L,2L,3L,5L,3L,0L,4L,4L,3L,5L,2L,3L,1L,5L,5L,3L,7L,8L,4L,6L,8L,5L,8L,9L,6L,7L,5L,6L,4L,0L,1L,9L,2L,9L,4L,9L,8L,2L,5L,6L,2L,9L,3L,8L,7L,2L,1L,3L,9L,0L,4L,9L,1L,8L,1L,4L,5L,0L,0L,0L,9L,5L,5L,9L,9L,6L,3L,4L,7L,6L,9L,6L,9L,1L,3L,0L,7L,3L,7L,0L,3L,6L,6L,3L,0L,4L,7L,3L,1L,3L,9L,2L,1L,5L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019656Inst : IEnumerable<long>
{
public static readonly long[] Value=A019656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019656.Bytes);
public long this[int i]=>Value[i];

public static A019656Inst Instance=new A019656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019655
{
public static readonly long[] Value={ 2L,6L,5L,6L,6L,2L,0L,3L,3L,2L,1L,1L,1L,1L,6L,1L,6L,9L,5L,0L,3L,7L,8L,3L,9L,1L,6L,0L,0L,9L,7L,8L,9L,3L,0L,1L,3L,9L,9L,8L,0L,9L,7L,7L,7L,5L,1L,3L,3L,2L,4L,2L,5L,9L,9L,1L,0L,7L,0L,3L,6L,3L,7L,4L,0L,6L,5L,4L,1L,4L,7L,0L,2L,1L,4L,8L,1L,4L,2L,6L,2L,2L,2L,2L,1L,7L,7L,8L,6L,9L,7L,9L,7L,0L,0L,5L,3L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019655Inst : IEnumerable<long>
{
public static readonly long[] Value=A019655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019655.Bytes);
public long this[int i]=>Value[i];

public static A019655Inst Instance=new A019655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019654
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,40L,655L,16573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019654Inst : IEnumerable<long>
{
public static readonly long[] Value=A019654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019654.Bytes);
public long this[int i]=>Value[i];

public static A019654Inst Instance=new A019654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019653
{
public static readonly long[] Value={ 3L,2L,4L,6L,9L,8L,0L,4L,0L,5L,9L,1L,3L,6L,4L,2L,0L,7L,1L,7L,1L,2L,9L,1L,4L,5L,2L,9L,0L,0L,8L,5L,3L,5L,9L,0L,5L,9L,9L,7L,6L,7L,5L,0L,5L,8L,4L,9L,6L,1L,8L,5L,3L,9L,8L,9L,0L,8L,6L,0L,0L,0L,1L,2L,7L,4L,6L,6L,1L,7L,9L,6L,9L,2L,9L,2L,1L,7L,4L,3L,1L,6L,0L,4L,8L,8L,4L,0L,6L,3L,0L,8L,5L,2L,2L,8L,7L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019653Inst : IEnumerable<long>
{
public static readonly long[] Value=A019653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019653.Bytes);
public long this[int i]=>Value[i];

public static A019653Inst Instance=new A019653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019652
{
public static readonly long[] Value={ 3L,6L,5L,2L,8L,5L,2L,9L,5L,6L,6L,5L,2L,8L,4L,7L,3L,3L,0L,6L,7L,7L,0L,2L,8L,8L,4L,5L,1L,3L,4L,6L,0L,2L,8L,9L,4L,2L,4L,7L,3L,8L,4L,4L,4L,0L,8L,0L,8L,2L,0L,8L,5L,7L,3L,7L,7L,2L,1L,7L,5L,0L,1L,4L,3L,3L,9L,9L,4L,5L,2L,1L,5L,4L,5L,3L,6L,9L,6L,1L,0L,5L,5L,5L,4L,9L,4L,5L,7L,0L,9L,7L,0L,8L,8L,2L,3L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019652Inst : IEnumerable<long>
{
public static readonly long[] Value=A019652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019652.Bytes);
public long this[int i]=>Value[i];

public static A019652Inst Instance=new A019652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019651
{
public static readonly long[] Value={ 4L,1L,7L,4L,6L,8L,9L,0L,9L,3L,3L,1L,7L,5L,3L,9L,8L,0L,6L,4L,8L,8L,0L,3L,2L,9L,6L,5L,8L,6L,8L,1L,1L,7L,5L,9L,3L,4L,2L,5L,5L,8L,2L,2L,1L,8L,0L,6L,6L,5L,2L,4L,0L,8L,4L,3L,1L,1L,0L,5L,7L,1L,5L,9L,2L,4L,5L,6L,5L,1L,6L,7L,4L,8L,0L,4L,2L,2L,4L,1L,2L,0L,6L,3L,4L,2L,2L,3L,6L,6L,8L,2L,3L,8L,6L,5L,5L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019651Inst : IEnumerable<long>
{
public static readonly long[] Value=A019651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019651.Bytes);
public long this[int i]=>Value[i];

public static A019651Inst Instance=new A019651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019650
{
public static readonly long[] Value={ 4L,8L,7L,0L,4L,7L,0L,6L,0L,8L,8L,7L,0L,4L,6L,3L,1L,0L,7L,5L,6L,9L,3L,7L,1L,7L,9L,3L,5L,1L,2L,8L,0L,3L,8L,5L,8L,9L,9L,6L,5L,1L,2L,5L,8L,7L,7L,4L,4L,2L,7L,8L,0L,9L,8L,3L,6L,2L,9L,0L,0L,0L,1L,9L,1L,1L,9L,9L,2L,6L,9L,5L,3L,9L,3L,8L,2L,6L,1L,4L,7L,4L,0L,7L,3L,2L,6L,0L,9L,4L,6L,2L,7L,8L,4L,3L,1L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019650Inst : IEnumerable<long>
{
public static readonly long[] Value=A019650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019650.Bytes);
public long this[int i]=>Value[i];

public static A019650Inst Instance=new A019650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019649
{
public static readonly long[] Value={ 5L,8L,4L,4L,5L,6L,4L,7L,3L,0L,6L,4L,4L,5L,5L,5L,7L,2L,9L,0L,8L,3L,2L,4L,6L,1L,5L,2L,2L,1L,5L,3L,6L,4L,6L,3L,0L,7L,9L,5L,8L,1L,5L,1L,0L,5L,2L,9L,3L,1L,3L,3L,7L,1L,8L,0L,3L,5L,4L,8L,0L,0L,2L,2L,9L,4L,3L,9L,1L,2L,3L,4L,4L,7L,2L,5L,9L,1L,3L,7L,6L,8L,8L,8L,7L,9L,1L,3L,1L,3L,5L,5L,3L,4L,1L,1L,7L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019649Inst : IEnumerable<long>
{
public static readonly long[] Value=A019649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019649.Bytes);
public long this[int i]=>Value[i];

public static A019649Inst Instance=new A019649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019648
{
public static readonly long[] Value={ 7L,3L,0L,5L,7L,0L,5L,9L,1L,3L,3L,0L,5L,6L,9L,4L,6L,6L,1L,3L,5L,4L,0L,5L,7L,6L,9L,0L,2L,6L,9L,2L,0L,5L,7L,8L,8L,4L,9L,4L,7L,6L,8L,8L,8L,1L,6L,1L,6L,4L,1L,7L,1L,4L,7L,5L,4L,4L,3L,5L,0L,0L,2L,8L,6L,7L,9L,8L,9L,0L,4L,3L,0L,9L,0L,7L,3L,9L,2L,2L,1L,1L,1L,0L,9L,8L,9L,1L,4L,1L,9L,4L,1L,7L,6L,4L,7L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019648Inst : IEnumerable<long>
{
public static readonly long[] Value=A019648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019648.Bytes);
public long this[int i]=>Value[i];

public static A019648Inst Instance=new A019648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019647
{
public static readonly long[] Value={ 9L,7L,4L,0L,9L,4L,1L,2L,1L,7L,7L,4L,0L,9L,2L,6L,2L,1L,5L,1L,3L,8L,7L,4L,3L,5L,8L,7L,0L,2L,5L,6L,0L,7L,7L,1L,7L,9L,9L,3L,0L,2L,5L,1L,7L,5L,4L,8L,8L,5L,5L,6L,1L,9L,6L,7L,2L,5L,8L,0L,0L,0L,3L,8L,2L,3L,9L,8L,5L,3L,9L,0L,7L,8L,7L,6L,5L,2L,2L,9L,4L,8L,1L,4L,6L,5L,2L,1L,8L,9L,2L,5L,5L,6L,8L,6L,3L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019647Inst : IEnumerable<long>
{
public static readonly long[] Value=A019647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019647.Bytes);
public long this[int i]=>Value[i];

public static A019647Inst Instance=new A019647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019646
{
public static readonly long[] Value={ 1L,4L,6L,1L,1L,4L,1L,1L,8L,2L,6L,6L,1L,1L,3L,8L,9L,3L,2L,2L,7L,0L,8L,1L,1L,5L,3L,8L,0L,5L,3L,8L,4L,1L,1L,5L,7L,6L,9L,8L,9L,5L,3L,7L,7L,6L,3L,2L,3L,2L,8L,3L,4L,2L,9L,5L,0L,8L,8L,7L,0L,0L,0L,5L,7L,3L,5L,9L,7L,8L,0L,8L,6L,1L,8L,1L,4L,7L,8L,4L,4L,2L,2L,2L,1L,9L,7L,8L,2L,8L,3L,8L,8L,3L,5L,2L,9L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019646Inst : IEnumerable<long>
{
public static readonly long[] Value=A019646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019646.Bytes);
public long this[int i]=>Value[i];

public static A019646Inst Instance=new A019646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019629
{
public static readonly long[] Value={ 4L,0L,6L,6L,5L,4L,0L,1L,0L,6L,0L,3L,5L,0L,3L,1L,9L,3L,5L,9L,3L,5L,0L,2L,4L,2L,2L,3L,5L,9L,3L,6L,0L,6L,9L,0L,2L,3L,9L,7L,5L,6L,5L,9L,6L,9L,4L,1L,1L,9L,5L,9L,5L,0L,5L,6L,5L,6L,9L,5L,2L,9L,1L,9L,1L,3L,2L,9L,6L,6L,0L,0L,5L,3L,1L,3L,0L,1L,4L,6L,7L,0L,2L,7L,2L,6L,4L,9L,4L,6L,1L,7L,6L,6L,8L,9L,2L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019629Inst : IEnumerable<long>
{
public static readonly long[] Value=A019629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019629.Bytes);
public long this[int i]=>Value[i];

public static A019629Inst Instance=new A019629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019628
{
public static readonly long[] Value={ 1L,23L,369L,5143L,66977L,841575L,10367953L,126315191L,1529146113L,18443562247L,221980457777L,2668373663319L,32052757927009L,384859080003239L,4619891122628241L,55449769683406327L,665474773978915265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019628Inst : IEnumerable<long>
{
public static readonly long[] Value=A019628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019628.Bytes);
public long this[int i]=>Value[i];

public static A019628Inst Instance=new A019628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019627
{
public static readonly long[] Value={ 4L,4L,9L,4L,5L,9L,6L,9L,5L,9L,3L,0L,1L,8L,7L,7L,4L,0L,2L,8L,7L,5L,5L,5L,3L,0L,8L,9L,2L,3L,5L,0L,3L,9L,2L,0L,7L,9L,1L,3L,0L,9L,9L,2L,2L,9L,3L,5L,0L,0L,6L,0L,5L,0L,6L,2L,5L,2L,4L,2L,1L,6L,4L,7L,4L,6L,2L,7L,5L,1L,9L,0L,0L,6L,0L,9L,1L,2L,1L,4L,7L,7L,6L,6L,9L,7L,7L,0L,4L,5L,7L,7L,4L,2L,3L,5L,4L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019627Inst : IEnumerable<long>
{
public static readonly long[] Value=A019627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019627.Bytes);
public long this[int i]=>Value[i];

public static A019627Inst Instance=new A019627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019626
{
public static readonly long[] Value={ 4L,7L,4L,4L,2L,9L,6L,7L,9L,0L,3L,7L,4L,2L,0L,3L,9L,2L,5L,2L,5L,7L,5L,2L,8L,2L,6L,0L,8L,5L,9L,2L,0L,8L,0L,5L,2L,7L,9L,7L,1L,6L,0L,2L,9L,7L,6L,4L,7L,2L,8L,6L,0L,8L,9L,9L,3L,3L,1L,1L,1L,7L,3L,8L,9L,8L,8L,4L,6L,0L,3L,3L,9L,5L,3L,1L,8L,5L,0L,4L,4L,8L,6L,5L,1L,4L,2L,4L,3L,7L,2L,0L,6L,1L,3L,7L,4L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019626Inst : IEnumerable<long>
{
public static readonly long[] Value=A019626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019626.Bytes);
public long this[int i]=>Value[i];

public static A019626Inst Instance=new A019626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019625
{
public static readonly long[] Value={ 5L,0L,2L,3L,3L,7L,3L,0L,7L,2L,1L,6L,0L,9L,2L,1L,8L,0L,3L,2L,1L,3L,8L,5L,3L,4L,5L,2L,6L,7L,4L,4L,5L,5L,5L,8L,5L,3L,1L,4L,6L,4L,0L,3L,1L,5L,1L,5L,5L,9L,4L,9L,9L,7L,7L,5L,7L,6L,2L,3L,5L,9L,5L,8L,9L,2L,8L,9L,5L,8L,0L,0L,6L,5L,6L,3L,1L,3L,5L,7L,6L,9L,1L,6L,0L,3L,3L,1L,6L,8L,8L,0L,6L,4L,9L,8L,4L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019625Inst : IEnumerable<long>
{
public static readonly long[] Value=A019625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019625.Bytes);
public long this[int i]=>Value[i];

public static A019625Inst Instance=new A019625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019624
{
public static readonly long[] Value={ 5L,3L,3L,7L,3L,3L,3L,8L,8L,9L,1L,7L,0L,9L,7L,9L,4L,1L,5L,9L,1L,4L,7L,1L,9L,2L,9L,3L,4L,6L,6L,6L,0L,9L,0L,5L,9L,3L,9L,6L,8L,0L,5L,3L,3L,4L,8L,5L,3L,1L,9L,6L,8L,5L,1L,1L,7L,4L,7L,5L,0L,7L,0L,6L,3L,6L,2L,0L,1L,7L,8L,8L,1L,9L,7L,3L,3L,3L,1L,7L,5L,4L,7L,3L,2L,8L,5L,2L,4L,1L,8L,5L,6L,9L,0L,4L,6L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019624Inst : IEnumerable<long>
{
public static readonly long[] Value=A019624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019624.Bytes);
public long this[int i]=>Value[i];

public static A019624Inst Instance=new A019624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019623
{
public static readonly long[] Value={ 1L,22L,335L,4400L,53661L,628122L,7178395L,80862100L,902846921L,10025125022L,110934086055L,1224883116600L,13505988249781L,148791855626722L,1638292574483315L,18032294531183900L,198432777621062241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019623Inst : IEnumerable<long>
{
public static readonly long[] Value=A019623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019623.Bytes);
public long this[int i]=>Value[i];

public static A019623Inst Instance=new A019623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019622
{
public static readonly long[] Value={ 6L,0L,9L,9L,8L,1L,0L,1L,5L,9L,0L,5L,2L,5L,4L,7L,9L,0L,3L,9L,0L,2L,5L,3L,6L,3L,3L,5L,3L,9L,0L,4L,1L,0L,3L,5L,3L,5L,9L,6L,3L,4L,8L,9L,5L,4L,1L,1L,7L,9L,3L,9L,2L,5L,8L,4L,8L,5L,4L,2L,9L,3L,7L,8L,6L,9L,9L,4L,4L,9L,0L,0L,7L,9L,6L,9L,5L,2L,2L,0L,0L,5L,4L,0L,8L,9L,7L,4L,1L,9L,2L,6L,5L,0L,3L,3L,8L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019622Inst : IEnumerable<long>
{
public static readonly long[] Value=A019622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019622.Bytes);
public long this[int i]=>Value[i];

public static A019622Inst Instance=new A019622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019621
{
public static readonly long[] Value={ 6L,5L,6L,9L,0L,2L,6L,3L,2L,5L,1L,3L,3L,5L,1L,3L,1L,2L,7L,2L,7L,9L,6L,5L,4L,5L,1L,5L,0L,3L,5L,8L,2L,6L,5L,3L,4L,6L,4L,2L,2L,2L,1L,9L,5L,0L,5L,8L,8L,5L,4L,9L,9L,7L,0L,6L,7L,6L,6L,1L,6L,2L,5L,3L,9L,8L,4L,0L,2L,2L,0L,0L,8L,5L,8L,2L,5L,6L,2L,1L,5L,9L,6L,7L,1L,2L,0L,2L,9L,7L,6L,7L,0L,0L,3L,6L,4L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019621Inst : IEnumerable<long>
{
public static readonly long[] Value=A019621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019621.Bytes);
public long this[int i]=>Value[i];

public static A019621Inst Instance=new A019621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019620
{
public static readonly long[] Value={ 7L,1L,1L,6L,4L,4L,5L,1L,8L,5L,5L,6L,1L,3L,0L,5L,8L,8L,7L,8L,8L,6L,2L,9L,2L,3L,9L,1L,2L,8L,8L,8L,1L,2L,0L,7L,9L,1L,9L,5L,7L,4L,0L,4L,4L,6L,4L,7L,0L,9L,2L,9L,1L,3L,4L,8L,9L,9L,6L,6L,7L,6L,0L,8L,4L,8L,2L,6L,9L,0L,5L,0L,9L,2L,9L,7L,7L,7L,5L,6L,7L,2L,9L,7L,7L,1L,3L,6L,5L,5L,8L,0L,9L,2L,0L,6L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019620Inst : IEnumerable<long>
{
public static readonly long[] Value=A019620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019620.Bytes);
public long this[int i]=>Value[i];

public static A019620Inst Instance=new A019620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019619
{
public static readonly long[] Value={ 7L,7L,6L,3L,3L,9L,4L,7L,4L,7L,8L,8L,5L,0L,6L,0L,9L,6L,8L,6L,0L,3L,2L,2L,8L,0L,6L,3L,2L,2L,4L,1L,5L,8L,6L,3L,1L,8L,4L,9L,8L,9L,8L,6L,6L,8L,8L,7L,7L,3L,7L,7L,2L,3L,8L,0L,7L,2L,3L,6L,4L,6L,6L,3L,7L,9L,9L,2L,9L,8L,7L,3L,7L,4L,1L,5L,7L,5L,5L,2L,7L,9L,6L,1L,1L,4L,2L,1L,6L,9L,9L,7L,3L,6L,7L,9L,4L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019619Inst : IEnumerable<long>
{
public static readonly long[] Value=A019619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019619.Bytes);
public long this[int i]=>Value[i];

public static A019619Inst Instance=new A019619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019618
{
public static readonly long[] Value={ 1L,21L,303L,3745L,42711L,464961L,4918663L,51086385L,524227671L,5336085601L,54018566823L,544793838225L,5480212349431L,55028108373441L,551863246323783L,5529708675105265L,55374624529091991L,554289026917064481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019618Inst : IEnumerable<long>
{
public static readonly long[] Value=A019618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019618.Bytes);
public long this[int i]=>Value[i];

public static A019618Inst Instance=new A019618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019617
{
public static readonly long[] Value={ 9L,4L,8L,8L,5L,9L,3L,5L,8L,0L,7L,4L,8L,4L,0L,7L,8L,5L,0L,5L,1L,5L,0L,5L,6L,5L,2L,1L,7L,1L,8L,4L,1L,6L,1L,0L,5L,5L,9L,4L,3L,2L,0L,5L,9L,5L,2L,9L,4L,5L,7L,2L,1L,7L,9L,8L,6L,6L,2L,2L,3L,4L,7L,7L,9L,7L,6L,9L,2L,0L,6L,7L,9L,0L,6L,3L,7L,0L,0L,8L,9L,7L,3L,0L,2L,8L,4L,8L,7L,4L,4L,1L,2L,2L,7L,4L,8L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019617Inst : IEnumerable<long>
{
public static readonly long[] Value=A019617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019617.Bytes);
public long this[int i]=>Value[i];

public static A019617Inst Instance=new A019617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019616
{
public static readonly long[] Value={ 1L,0L,6L,7L,4L,6L,6L,7L,7L,7L,8L,3L,4L,1L,9L,5L,8L,8L,3L,1L,8L,2L,9L,4L,3L,8L,5L,8L,6L,9L,3L,3L,2L,1L,8L,1L,1L,8L,7L,9L,3L,6L,1L,0L,6L,6L,9L,7L,0L,6L,3L,9L,3L,7L,0L,2L,3L,4L,9L,5L,0L,1L,4L,1L,2L,7L,2L,4L,0L,3L,5L,7L,6L,3L,9L,4L,6L,6L,6L,3L,5L,0L,9L,4L,6L,5L,7L,0L,4L,8L,3L,7L,1L,3L,8L,0L,9L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019616Inst : IEnumerable<long>
{
public static readonly long[] Value=A019616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019616.Bytes);
public long this[int i]=>Value[i];

public static A019616Inst Instance=new A019616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019615
{
public static readonly long[] Value={ 1L,2L,1L,9L,9L,6L,2L,0L,3L,1L,8L,1L,0L,5L,0L,9L,5L,8L,0L,7L,8L,0L,5L,0L,7L,2L,6L,7L,0L,7L,8L,0L,8L,2L,0L,7L,0L,7L,1L,9L,2L,6L,9L,7L,9L,0L,8L,2L,3L,5L,8L,7L,8L,5L,1L,6L,9L,7L,0L,8L,5L,8L,7L,5L,7L,3L,9L,8L,8L,9L,8L,0L,1L,5L,9L,3L,9L,0L,4L,4L,0L,1L,0L,8L,1L,7L,9L,4L,8L,3L,8L,5L,3L,0L,0L,6L,7L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019615Inst : IEnumerable<long>
{
public static readonly long[] Value=A019615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019615.Bytes);
public long this[int i]=>Value[i];

public static A019615Inst Instance=new A019615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019614
{
public static readonly long[] Value={ 1L,4L,2L,3L,2L,8L,9L,0L,3L,7L,1L,1L,2L,2L,6L,1L,1L,7L,7L,5L,7L,7L,2L,5L,8L,4L,7L,8L,2L,5L,7L,7L,6L,2L,4L,1L,5L,8L,3L,9L,1L,4L,8L,0L,8L,9L,2L,9L,4L,1L,8L,5L,8L,2L,6L,9L,7L,9L,9L,3L,3L,5L,2L,1L,6L,9L,6L,5L,3L,8L,1L,0L,1L,8L,5L,9L,5L,5L,5L,1L,3L,4L,5L,9L,5L,4L,2L,7L,3L,1L,1L,6L,1L,8L,4L,1L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019614Inst : IEnumerable<long>
{
public static readonly long[] Value=A019614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019614.Bytes);
public long this[int i]=>Value[i];

public static A019614Inst Instance=new A019614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019549
{
public static readonly long[] Value={ 23L,37L,53L,73L,113L,137L,173L,193L,197L,211L,223L,227L,229L,233L,241L,257L,271L,277L,283L,293L,311L,313L,317L,331L,337L,347L,353L,359L,367L,373L,379L,383L,389L,397L,433L,523L,541L,547L,557L,571L,577L,593L,613L,617L,673L,677L,719L,727L,733L,743L,757L,761L,773L,797L,977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019549Inst : IEnumerable<long>
{
public static readonly long[] Value=A019549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019549.Bytes);
public long this[int i]=>Value[i];

public static A019549Inst Instance=new A019549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019548
{
public static readonly long[] Value={ 1000L,8000L,10648L,27000L,64000L,125000L,216000L,343000L,512000L,729000L,1000000L,1331000L,1728000L,2197000L,2744000L,3375000L,4096000L,4913000L,5832000L,6859000L,8000000L,9261000L,10648000L,12167000L,13824000L,15625000L,17576000L,19683000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019548Inst : IEnumerable<long>
{
public static readonly long[] Value=A019548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019548.Bytes);
public long this[int i]=>Value[i];

public static A019548Inst Instance=new A019548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019547
{
public static readonly long[] Value={ 49L,100L,144L,169L,361L,400L,441L,900L,1225L,1369L,1444L,1600L,1681L,1936L,2500L,3249L,3600L,4225L,4900L,6400L,8100L,9025L,9409L,10000L,10404L,11025L,11449L,11664L,12100L,12544L,14161L,14400L,14641L,15625L,16641L,16900L,19044L,19600L,22500L,25600L,28900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019547Inst : IEnumerable<long>
{
public static readonly long[] Value=A019547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019547.Bytes);
public long this[int i]=>Value[i];

public static A019547Inst Instance=new A019547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019546
{
public static readonly long[] Value={ 2L,3L,5L,7L,23L,37L,53L,73L,223L,227L,233L,257L,277L,337L,353L,373L,523L,557L,577L,727L,733L,757L,773L,2237L,2273L,2333L,2357L,2377L,2557L,2753L,2777L,3253L,3257L,3323L,3373L,3527L,3533L,3557L,3727L,3733L,5227L,5233L,5237L,5273L,5323L,5333L,5527L,5557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019546Inst : IEnumerable<long>
{
public static readonly long[] Value=A019546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019546.Bytes);
public long this[int i]=>Value[i];

public static A019546Inst Instance=new A019546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019545
{
public static readonly BigInteger[] Value={ 0L,1L,8L,1000L,8000L,1000000L,8000000L,1000000000L,8000000000L,1000000000000L,8000000000000L,1000000000000000L,8000000000000000L,1000000000000000000L,8000000000000000000L,BigInteger.Parse("1000000000000000000000") };
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
public class A019545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019545Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019545.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019545Inst Instance=new A019545Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019544
{
public static readonly long[] Value={ 0L,1L,4L,9L,49L,100L,144L,400L,441L,900L,1444L,4900L,9409L,10000L,10404L,11449L,14400L,19044L,40000L,40401L,44100L,44944L,90000L,144400L,419904L,490000L,491401L,904401L,940900L,994009L,1000000L,1004004L,1014049L,1040400L,1100401L,1144900L,1440000L,1904400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019544Inst : IEnumerable<long>
{
public static readonly long[] Value=A019544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019544.Bytes);
public long this[int i]=>Value[i];

public static A019544Inst Instance=new A019544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019543
{
public static readonly long[] Value={ 2L,4L,15L,8L,256L,63L,32L,16L,511L,1024L,31L,31L,1024L,21846L,4095L,32L,127L,4095L,32768L,8192L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019543Inst : IEnumerable<long>
{
public static readonly long[] Value=A019543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019543.Bytes);
public long this[int i]=>Value[i];

public static A019543Inst Instance=new A019543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019542
{
public static readonly long[] Value={ 2L,4L,32L,8L,15L,64L,63L,16L,32L,128L,4096L,31L,31L,4095L,16384L,32L,1023L,127L,128L,4096L,299593L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019542Inst : IEnumerable<long>
{
public static readonly long[] Value=A019542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019542.Bytes);
public long this[int i]=>Value[i];

public static A019542Inst Instance=new A019542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019541
{
public static readonly long[] Value={ 1L,7L,16L,32L,15L,15L,32L,63L,512L,256L,511L,64L,31L,31L,64L,512L,4095L,1023L,127L,4095L,1048576L,262144L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019541Inst : IEnumerable<long>
{
public static readonly long[] Value=A019541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019541.Bytes);
public long this[int i]=>Value[i];

public static A019541Inst Instance=new A019541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019540
{
public static readonly long[] Value={ 2L,4L,16L,8L,15L,15L,128L,16L,64L,341L,32L,256L,31L,31L,4095L,32L,512L,1023L,127L,4095L,512L,1024L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019540Inst : IEnumerable<long>
{
public static readonly long[] Value=A019540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019540.Bytes);
public long this[int i]=>Value[i];

public static A019540Inst Instance=new A019540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019539
{
public static readonly long[] Value={ 2L,4L,7L,8L,16L,15L,15L,16L,63L,256L,128L,511L,32L,31L,31L,32L,256L,4095L,1023L,127L,4095L,524288L,131072L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019539Inst : IEnumerable<long>
{
public static readonly long[] Value=A019539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019539.Bytes);
public long this[int i]=>Value[i];

public static A019539Inst Instance=new A019539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019538
{
public static readonly long[] Value={ 1L,1L,2L,1L,6L,6L,1L,14L,36L,24L,1L,30L,150L,240L,120L,1L,62L,540L,1560L,1800L,720L,1L,126L,1806L,8400L,16800L,15120L,5040L,1L,254L,5796L,40824L,126000L,191520L,141120L,40320L,1L,510L,18150L,186480L,834120L,1905120L,2328480L,1451520L,362880L,1L,1022L,55980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019538Inst : IEnumerable<long>
{
public static readonly long[] Value=A019538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019538.Bytes);
public long this[int i]=>Value[i];

public static A019538Inst Instance=new A019538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019537
{
public static readonly BigInteger[] Value={ 1L,2L,4L,14L,61L,414L,3416L,34274L,394009L,5113712L,73758368L,1170495180L,20263806277L,380048113202L,7676106638884L,166114210737254L,3834434327929981L,94042629562443206L,2442147034770292496L,BigInteger.Parse("66942194906543381336"),BigInteger.Parse("1931543452346146410965"),BigInteger.Parse("58519191359170883258606") };
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
public class A019537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019537Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019537.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019537Inst Instance=new A019537Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019536
{
public static readonly long[] Value={ 1L,2L,5L,20L,109L,784L,6757L,68240L,787477L,10224812L,147512053L,2340964372L,40527565261L,760095929840L,15352212731933L,332228417657960L,7668868648772701L,188085259070219000L,4884294069438337429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019536Inst : IEnumerable<long>
{
public static readonly long[] Value=A019536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019536.Bytes);
public long this[int i]=>Value[i];

public static A019536Inst Instance=new A019536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019535
{
public static readonly long[] Value={ 8L,13L,22L,33L,58L,127L,145L,262L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019535Inst : IEnumerable<long>
{
public static readonly long[] Value=A019535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019535.Bytes);
public long this[int i]=>Value[i];

public static A019535Inst Instance=new A019535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019534
{
public static readonly long[] Value={ 7L,18L,63L,133L,285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019534Inst : IEnumerable<long>
{
public static readonly long[] Value=A019534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019534.Bytes);
public long this[int i]=>Value[i];

public static A019534Inst Instance=new A019534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019501
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,7L,28L,84L,210L,462L,924L,1758L,3444L,7602L,19278L,52458L,142044L,368130L,905136L,2130198L,4895919L,11280885L,26685540L,65491062L,165584034L,423910572L,1080774261L,2717940687L,6731334225L,16494155097L,40308269022L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019501Inst : IEnumerable<long>
{
public static readonly long[] Value=A019501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019501.Bytes);
public long this[int i]=>Value[i];

public static A019501Inst Instance=new A019501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019500
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,6L,21L,56L,126L,252L,492L,1062L,2667L,7252L,19509L,49824L,121019L,286974L,687384L,1702308L,4357383L,11322408L,29307458L,74897808L,189349041L,477491356L,1211349276L,3103673406L,8017385416L,20780391882L,53812468392L,138999941172L,358502419242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019500Inst : IEnumerable<long>
{
public static readonly long[] Value=A019500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019500.Bytes);
public long this[int i]=>Value[i];

public static A019500Inst Instance=new A019500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019499
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,5L,15L,35L,70L,146L,360L,980L,2620L,6620L,16276L,40740L,105820L,280780L,743700L,1950756L,5101470L,13429110L,35693650L,95433290L,255434106L,683340050L,1829832350L,4913953750L,13239959100L,35758234300L,96702404700L,261768987260L,709479051420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019499Inst : IEnumerable<long>
{
public static readonly long[] Value=A019499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019499.Bytes);
public long this[int i]=>Value[i];

public static A019499Inst Instance=new A019499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019498
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,10L,20L,47L,128L,340L,868L,2275L,6188L,16922L,46112L,126613L,351568L,981622L,2747876L,7723250L,21811856L,61828886L,175752728L,500984606L,1432111244L,4104175970L,11787811340L,33926475162L,97837209036L,282662156478L,818022923184L,2371103693427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019498Inst : IEnumerable<long>
{
public static readonly long[] Value=A019498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019498.Bytes);
public long this[int i]=>Value[i];

public static A019498Inst Instance=new A019498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019497
{
public static readonly long[] Value={ 1L,1L,1L,3L,6L,16L,42L,114L,322L,918L,2673L,7875L,23457L,70551L,213846L,652794L,2004864L,6190612L,19207416L,59850384L,187217679L,587689947L,1850692506L,5845013538L,18509607753L,58759391013L,186958014766L,596108115402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019497Inst : IEnumerable<long>
{
public static readonly long[] Value=A019497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019497.Bytes);
public long this[int i]=>Value[i];

public static A019497Inst Instance=new A019497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019496
{
public static readonly long[] Value={ 4L,11L,30L,81L,218L,586L,1575L,4233L,11377L,30578L,82185L,220890L,593690L,1595671L,4288713L,11526849L,30980914L,83267945L,223800714L,601513098L,1616697287L,4345225609L,11678738961L,31389151218L,84365171401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019496Inst : IEnumerable<long>
{
public static readonly long[] Value=A019496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019496.Bytes);
public long this[int i]=>Value[i];

public static A019496Inst Instance=new A019496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019495
{
public static readonly long[] Value={ 4L,11L,30L,81L,218L,586L,1575L,4233L,11376L,30572L,82159L,220793L,593356L,1594576L,4285239L,11516085L,30948148L,83169572L,223508615L,600653577L,1614187084L,4337941272L,11657715927L,31328764525L,84192434676L,226257439900L,608040726071L,1634039193249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019495Inst : IEnumerable<long>
{
public static readonly long[] Value=A019495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019495.Bytes);
public long this[int i]=>Value[i];

public static A019495Inst Instance=new A019495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019494
{
public static readonly long[] Value={ 4L,10L,24L,57L,135L,319L,753L,1777L,4193L,9893L,23341L,55069L,129925L,306533L,723205L,1706261L,4025589L,9497589L,22407701L,52866581L,124728341L,294272085L,694277333L,1638011349L,3864566869L,9117688405L,21511399509L,50751932757L,119739242325L,282501283669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019494Inst : IEnumerable<long>
{
public static readonly long[] Value=A019494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019494.Bytes);
public long this[int i]=>Value[i];

public static A019494Inst Instance=new A019494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019493
{
public static readonly long[] Value={ 4L,9L,20L,44L,96L,209L,455L,990L,2154L,4686L,10194L,22175L,48236L,104922L,228220L,496402L,1079712L,2348431L,5107921L,11109837L,24164007L,52556739L,114310581L,248624146L,540753403L,1176127722L,2558050589L,5563694894L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019493Inst : IEnumerable<long>
{
public static readonly long[] Value=A019493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019493.Bytes);
public long this[int i]=>Value[i];

public static A019493Inst Instance=new A019493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019492
{
public static readonly long[] Value={ 4L,9L,20L,44L,96L,209L,455L,990L,2154L,4686L,10194L,22176L,48241L,104942L,228287L,496607L,1080300L,2350043L,5112193L,11120867L,24191904L,52626132L,114480851L,249037213L,541745915L,1178493097L,2563648273L,5576861234L,12131688091L,26390804748L,57409535261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019492Inst : IEnumerable<long>
{
public static readonly long[] Value=A019492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019492.Bytes);
public long this[int i]=>Value[i];

public static A019492Inst Instance=new A019492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019491
{
public static readonly long[] Value={ 10L,20L,27L,28L,29L,34L,38L,44L,45L,46L,51L,52L,53L,54L,60L,61L,62L,69L,70L,74L,77L,78L,79L,81L,82L,87L,88L,92L,93L,94L,95L,101L,102L,103L,104L,105L,106L,110L,111L,112L,113L,114L,115L,116L,117L,118L,120L,122L,124L,125L,126L,127L,130L,138L,139L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019491Inst : IEnumerable<long>
{
public static readonly long[] Value=A019491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019491.Bytes);
public long this[int i]=>Value[i];

public static A019491Inst Instance=new A019491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019490
{
public static readonly long[] Value={ 1L,22L,340L,4600L,58576L,724192L,8822080L,106672000L,1284971776L,15449370112L,185571742720L,2227940915200L,26741787774976L,320940501164032L,3851520569589760L,46219655242547200L,554644317650354176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019490Inst : IEnumerable<long>
{
public static readonly long[] Value=A019490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019490.Bytes);
public long this[int i]=>Value[i];

public static A019490Inst Instance=new A019490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019489
{
public static readonly long[] Value={ 3L,7L,16L,36L,80L,177L,391L,863L,1904L,4200L,9264L,20433L,45067L,99399L,219232L,483532L,1066464L,2352161L,5187855L,11442175L,25236512L,55660880L,122763936L,270764385L,597189651L,1317143239L,2905050864L,6407291380L,14131726000L,31168502865L,68744297111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019489Inst : IEnumerable<long>
{
public static readonly long[] Value=A019489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019489.Bytes);
public long this[int i]=>Value[i];

public static A019489Inst Instance=new A019489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019488
{
public static readonly long[] Value={ 1L,21L,307L,3897L,46243L,529953L,5961259L,66380889L,735097555L,8115781905L,89452902331L,985061928201L,10842178002787L,119303005894977L,1312567620466123L,14439652232597433L,158844629298359539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019488Inst : IEnumerable<long>
{
public static readonly long[] Value=A019488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019488.Bytes);
public long this[int i]=>Value[i];

public static A019488Inst Instance=new A019488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019487
{
public static readonly long[] Value={ 2L,6L,17L,48L,135L,379L,1064L,2987L,8385L,23538L,66075L,185483L,520680L,1461631L,4103029L,11517850L,32332423L,90762215L,254783864L,715218523L,2007731289L,5636018642L,15821193955L,44412588755L,124673147016L,349977202919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019487Inst : IEnumerable<long>
{
public static readonly long[] Value=A019487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019487.Bytes);
public long this[int i]=>Value[i];

public static A019487Inst Instance=new A019487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019486
{
public static readonly long[] Value={ 2L,5L,12L,28L,65L,150L,346L,795L,1826L,4192L,9621L,22078L,50660L,116239L,266704L,611930L,1404013L,3221358L,7391048L,16957921L,38908004L,89269924L,204819503L,469934590L,1078210352L,2473828397L,5675911794L,13022719964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019486Inst : IEnumerable<long>
{
public static readonly long[] Value=A019486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019486.Bytes);
public long this[int i]=>Value[i];

public static A019486Inst Instance=new A019486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019437
{
public static readonly BigInteger[] Value={ 1L,3L,6L,120L,BigInteger.Parse("9290976268679343135539052852903295259378814351580596958743987989307824385062448596342880785099979140705774497073908459100742234151955724805414557103318958341618000723968000000000000000000000000000") };
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
public class A019437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019437Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019437.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019437Inst Instance=new A019437Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019436
{
public static readonly long[] Value={ 1L,2L,3L,6L,10L,18L,31L,60L,106L,196L,352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019436Inst : IEnumerable<long>
{
public static readonly long[] Value=A019436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019436.Bytes);
public long this[int i]=>Value[i];

public static A019436Inst Instance=new A019436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019435
{
public static readonly long[] Value={ 1L,2L,3L,7L,29L,46L,52L,68L,139L,150L,161L,172L,275L,2295L,10560L,10915L,14817L,1296672L,5117932L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019435Inst : IEnumerable<long>
{
public static readonly long[] Value=A019435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019435.Bytes);
public long this[int i]=>Value[i];

public static A019435Inst Instance=new A019435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019434
{
public static readonly long[] Value={ 3L,5L,17L,257L,65537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019434Inst : IEnumerable<long>
{
public static readonly long[] Value=A019434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019434.Bytes);
public long this[int i]=>Value[i];

public static A019434Inst Instance=new A019434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019433
{
public static readonly long[] Value={ 0L,9L,1L,28L,1L,48L,1L,68L,1L,88L,1L,108L,1L,128L,1L,148L,1L,168L,1L,188L,1L,208L,1L,228L,1L,248L,1L,268L,1L,288L,1L,308L,1L,328L,1L,348L,1L,368L,1L,388L,1L,408L,1L,428L,1L,448L,1L,468L,1L,488L,1L,508L,1L,528L,1L,548L,1L,568L,1L,588L,1L,608L,1L,628L,1L,648L,1L,668L,1L,688L,1L,708L,1L,728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019433Inst : IEnumerable<long>
{
public static readonly long[] Value=A019433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019433.Bytes);
public long this[int i]=>Value[i];

public static A019433Inst Instance=new A019433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019432
{
public static readonly long[] Value={ 0L,8L,1L,25L,1L,43L,1L,61L,1L,79L,1L,97L,1L,115L,1L,133L,1L,151L,1L,169L,1L,187L,1L,205L,1L,223L,1L,241L,1L,259L,1L,277L,1L,295L,1L,313L,1L,331L,1L,349L,1L,367L,1L,385L,1L,403L,1L,421L,1L,439L,1L,457L,1L,475L,1L,493L,1L,511L,1L,529L,1L,547L,1L,565L,1L,583L,1L,601L,1L,619L,1L,637L,1L,655L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019432Inst : IEnumerable<long>
{
public static readonly long[] Value=A019432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019432.Bytes);
public long this[int i]=>Value[i];

public static A019432Inst Instance=new A019432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019431
{
public static readonly long[] Value={ 0L,7L,1L,22L,1L,38L,1L,54L,1L,70L,1L,86L,1L,102L,1L,118L,1L,134L,1L,150L,1L,166L,1L,182L,1L,198L,1L,214L,1L,230L,1L,246L,1L,262L,1L,278L,1L,294L,1L,310L,1L,326L,1L,342L,1L,358L,1L,374L,1L,390L,1L,406L,1L,422L,1L,438L,1L,454L,1L,470L,1L,486L,1L,502L,1L,518L,1L,534L,1L,550L,1L,566L,1L,582L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019431Inst : IEnumerable<long>
{
public static readonly long[] Value=A019431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019431.Bytes);
public long this[int i]=>Value[i];

public static A019431Inst Instance=new A019431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019430
{
public static readonly long[] Value={ 0L,6L,1L,19L,1L,33L,1L,47L,1L,61L,1L,75L,1L,89L,1L,103L,1L,117L,1L,131L,1L,145L,1L,159L,1L,173L,1L,187L,1L,201L,1L,215L,1L,229L,1L,243L,1L,257L,1L,271L,1L,285L,1L,299L,1L,313L,1L,327L,1L,341L,1L,355L,1L,369L,1L,383L,1L,397L,1L,411L,1L,425L,1L,439L,1L,453L,1L,467L,1L,481L,1L,495L,1L,509L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019430Inst : IEnumerable<long>
{
public static readonly long[] Value=A019430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019430.Bytes);
public long this[int i]=>Value[i];

public static A019430Inst Instance=new A019430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019429
{
public static readonly long[] Value={ 0L,5L,1L,16L,1L,28L,1L,40L,1L,52L,1L,64L,1L,76L,1L,88L,1L,100L,1L,112L,1L,124L,1L,136L,1L,148L,1L,160L,1L,172L,1L,184L,1L,196L,1L,208L,1L,220L,1L,232L,1L,244L,1L,256L,1L,268L,1L,280L,1L,292L,1L,304L,1L,316L,1L,328L,1L,340L,1L,352L,1L,364L,1L,376L,1L,388L,1L,400L,1L,412L,1L,424L,1L,436L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019429Inst : IEnumerable<long>
{
public static readonly long[] Value=A019429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019429.Bytes);
public long this[int i]=>Value[i];

public static A019429Inst Instance=new A019429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019428
{
public static readonly long[] Value={ 0L,4L,1L,13L,1L,23L,1L,33L,1L,43L,1L,53L,1L,63L,1L,73L,1L,83L,1L,93L,1L,103L,1L,113L,1L,123L,1L,133L,1L,143L,1L,153L,1L,163L,1L,173L,1L,183L,1L,193L,1L,203L,1L,213L,1L,223L,1L,233L,1L,243L,1L,253L,1L,263L,1L,273L,1L,283L,1L,293L,1L,303L,1L,313L,1L,323L,1L,333L,1L,343L,1L,353L,1L,363L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019428Inst : IEnumerable<long>
{
public static readonly long[] Value=A019428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019428.Bytes);
public long this[int i]=>Value[i];

public static A019428Inst Instance=new A019428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019427
{
public static readonly long[] Value={ 0L,3L,1L,10L,1L,18L,1L,26L,1L,34L,1L,42L,1L,50L,1L,58L,1L,66L,1L,74L,1L,82L,1L,90L,1L,98L,1L,106L,1L,114L,1L,122L,1L,130L,1L,138L,1L,146L,1L,154L,1L,162L,1L,170L,1L,178L,1L,186L,1L,194L,1L,202L,1L,210L,1L,218L,1L,226L,1L,234L,1L,242L,1L,250L,1L,258L,1L,266L,1L,274L,1L,282L,1L,290L,1L,298L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019427Inst : IEnumerable<long>
{
public static readonly long[] Value=A019427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019427.Bytes);
public long this[int i]=>Value[i];

public static A019427Inst Instance=new A019427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019426
{
public static readonly long[] Value={ 0L,2L,1L,7L,1L,13L,1L,19L,1L,25L,1L,31L,1L,37L,1L,43L,1L,49L,1L,55L,1L,61L,1L,67L,1L,73L,1L,79L,1L,85L,1L,91L,1L,97L,1L,103L,1L,109L,1L,115L,1L,121L,1L,127L,1L,133L,1L,139L,1L,145L,1L,151L,1L,157L,1L,163L,1L,169L,1L,175L,1L,181L,1L,187L,1L,193L,1L,199L,1L,205L,1L,211L,1L,217L,1L,223L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019426Inst : IEnumerable<long>
{
public static readonly long[] Value=A019426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019426.Bytes);
public long this[int i]=>Value[i];

public static A019426Inst Instance=new A019426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019425
{
public static readonly long[] Value={ 0L,1L,1L,4L,1L,8L,1L,12L,1L,16L,1L,20L,1L,24L,1L,28L,1L,32L,1L,36L,1L,40L,1L,44L,1L,48L,1L,52L,1L,56L,1L,60L,1L,64L,1L,68L,1L,72L,1L,76L,1L,80L,1L,84L,1L,88L,1L,92L,1L,96L,1L,100L,1L,104L,1L,108L,1L,112L,1L,116L,1L,120L,1L,124L,1L,128L,1L,132L,1L,136L,1L,140L,1L,144L,1L,148L,1L,152L,1L,156L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019425Inst : IEnumerable<long>
{
public static readonly long[] Value=A019425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019425.Bytes);
public long this[int i]=>Value[i];

public static A019425Inst Instance=new A019425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019424
{
public static readonly long[] Value={ 1L,2667L,3937L,17490L,19410L,22578L,24610L,24910L,25466L,25910L,26554L,26818L,27285L,29342L,29733L,29762L,31102L,31535L,32043L,32997L,33985L,35585L,36635L,37985L,39697L,41393L,41837L,42347L,44047L,45637L,45739L,45937L,46117L,172011L,253921L,640737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019424Inst : IEnumerable<long>
{
public static readonly long[] Value=A019424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019424.Bytes);
public long this[int i]=>Value[i];

public static A019424Inst Instance=new A019424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019423
{
public static readonly long[] Value={ 1L,21L,31L,651L,889L,3210L,3498L,3710L,3882L,3910L,4310L,4922L,4982L,5182L,5457L,5885L,6035L,6095L,6307L,6797L,7117L,7327L,7597L,24573L,27559L,71193L,82110L,90510L,94981L,97410L,98671L,99301L,99510L,100110L,103362L,104622L,107778L,108438L,108822L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019423Inst : IEnumerable<long>
{
public static readonly long[] Value=A019423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019423.Bytes);
public long this[int i]=>Value[i];

public static A019423Inst Instance=new A019423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019422
{
public static readonly long[] Value={ 1L,217L,510L,642L,710L,742L,782L,795L,862L,935L,1177L,1207L,1219L,2667L,3937L,7590L,7854L,8743L,9481L,9798L,9858L,10810L,10934L,11186L,11235L,11510L,11594L,11715L,11985L,12082L,12243L,12903L,12945L,13022L,13462L,13587L,13685L,13822L,14223L,15085L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019422Inst : IEnumerable<long>
{
public static readonly long[] Value=A019422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019422.Bytes);
public long this[int i]=>Value[i];

public static A019422Inst Instance=new A019422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019421
{
public static readonly long[] Value={ 2L,17L,23L,41L,47L,59L,67L,71L,73L,101L,103L,109L,149L,173L,179L,191L,197L,199L,223L,233L,241L,251L,277L,293L,311L,331L,337L,349L,367L,373L,379L,383L,409L,419L,443L,457L,461L,467L,499L,541L,557L,569L,587L,593L,599L,613L,619L,631L,643L,673L,677L,683L,691L,719L,733L,761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019421Inst : IEnumerable<long>
{
public static readonly long[] Value=A019421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019421.Bytes);
public long this[int i]=>Value[i];

public static A019421Inst Instance=new A019421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019420
{
public static readonly long[] Value={ 3L,5L,13L,19L,29L,37L,43L,53L,59L,67L,83L,101L,107L,109L,131L,139L,149L,173L,179L,181L,197L,227L,229L,251L,269L,277L,283L,293L,307L,317L,331L,347L,373L,379L,389L,397L,419L,421L,443L,461L,467L,491L,499L,509L,523L,541L,557L,563L,587L,619L,643L,653L,659L,661L,677L,683L,691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019420Inst : IEnumerable<long>
{
public static readonly long[] Value=A019420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019420.Bytes);
public long this[int i]=>Value[i];

public static A019420Inst Instance=new A019420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019419
{
public static readonly long[] Value={ 2L,5L,13L,17L,19L,23L,29L,41L,59L,83L,107L,127L,131L,137L,149L,157L,173L,179L,181L,199L,223L,239L,251L,257L,263L,271L,277L,281L,311L,317L,331L,347L,349L,359L,367L,383L,401L,409L,439L,443L,457L,523L,563L,569L,587L,599L,619L,641L,653L,659L,709L,719L,757L,761L,797L,821L,827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019419Inst : IEnumerable<long>
{
public static readonly long[] Value=A019419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019419.Bytes);
public long this[int i]=>Value[i];

public static A019419Inst Instance=new A019419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019418
{
public static readonly long[] Value={ 7L,11L,17L,31L,37L,59L,61L,83L,89L,103L,107L,109L,113L,127L,131L,151L,157L,179L,181L,223L,227L,229L,233L,251L,257L,271L,277L,281L,347L,349L,353L,367L,401L,419L,421L,449L,467L,521L,541L,563L,569L,587L,593L,607L,617L,631L,641L,659L,683L,733L,751L,757L,809L,827L,853L,857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019418Inst : IEnumerable<long>
{
public static readonly long[] Value=A019418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019418.Bytes);
public long this[int i]=>Value[i];

public static A019418Inst Instance=new A019418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019417
{
public static readonly long[] Value={ 2L,3L,11L,17L,29L,41L,67L,89L,107L,109L,131L,137L,157L,167L,191L,197L,199L,227L,233L,239L,241L,251L,269L,271L,281L,307L,353L,359L,383L,401L,419L,457L,479L,491L,499L,509L,521L,547L,557L,563L,569L,577L,593L,601L,613L,617L,631L,641L,653L,661L,683L,719L,739L,743L,827L,853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019417Inst : IEnumerable<long>
{
public static readonly long[] Value=A019417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019417.Bytes);
public long this[int i]=>Value[i];

public static A019417Inst Instance=new A019417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019416
{
public static readonly long[] Value={ 7L,11L,37L,41L,53L,101L,107L,113L,137L,149L,157L,163L,173L,179L,191L,197L,227L,233L,239L,257L,263L,269L,271L,277L,281L,313L,383L,397L,419L,433L,443L,449L,467L,479L,487L,499L,541L,563L,569L,577L,587L,613L,641L,647L,653L,691L,709L,719L,773L,787L,809L,857L,859L,863L,881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019416Inst : IEnumerable<long>
{
public static readonly long[] Value=A019416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019416.Bytes);
public long this[int i]=>Value[i];

public static A019416Inst Instance=new A019416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019415
{
public static readonly long[] Value={ 2L,5L,13L,37L,41L,59L,71L,73L,101L,107L,113L,127L,131L,139L,149L,151L,191L,223L,227L,233L,257L,277L,293L,311L,317L,331L,337L,359L,367L,409L,419L,431L,433L,443L,467L,479L,487L,503L,521L,523L,563L,571L,593L,599L,601L,617L,631L,643L,653L,659L,683L,709L,757L,829L,839L,857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019415Inst : IEnumerable<long>
{
public static readonly long[] Value=A019415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019415.Bytes);
public long this[int i]=>Value[i];

public static A019415Inst Instance=new A019415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019414
{
public static readonly long[] Value={ 3L,5L,17L,37L,47L,53L,59L,61L,71L,89L,97L,113L,127L,137L,139L,149L,163L,167L,179L,211L,223L,229L,239L,241L,271L,293L,307L,311L,313L,347L,373L,389L,401L,433L,439L,443L,457L,463L,491L,499L,521L,547L,557L,569L,587L,599L,613L,617L,641L,661L,677L,683L,691L,701L,719L,733L,739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019414Inst : IEnumerable<long>
{
public static readonly long[] Value=A019414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019414.Bytes);
public long this[int i]=>Value[i];

public static A019414Inst Instance=new A019414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019413
{
public static readonly long[] Value={ 2L,17L,19L,37L,43L,47L,59L,61L,83L,107L,109L,127L,137L,149L,157L,167L,173L,179L,181L,191L,193L,197L,211L,227L,257L,263L,269L,271L,281L,313L,317L,347L,383L,401L,443L,449L,479L,541L,547L,557L,571L,587L,599L,601L,613L,617L,619L,643L,677L,751L,787L,797L,811L,821L,829L,839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019413Inst : IEnumerable<long>
{
public static readonly long[] Value=A019413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019413.Bytes);
public long this[int i]=>Value[i];

public static A019413Inst Instance=new A019413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019412
{
public static readonly long[] Value={ 11L,17L,19L,23L,29L,47L,59L,97L,101L,113L,131L,137L,139L,149L,167L,179L,181L,193L,223L,229L,233L,251L,257L,263L,269L,313L,331L,337L,349L,353L,367L,379L,383L,389L,421L,457L,461L,491L,499L,503L,509L,577L,593L,607L,617L,619L,647L,659L,673L,691L,701L,709L,739L,811L,829L,857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019412Inst : IEnumerable<long>
{
public static readonly long[] Value=A019412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019412.Bytes);
public long this[int i]=>Value[i];

public static A019412Inst Instance=new A019412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019411
{
public static readonly long[] Value={ 2L,3L,7L,13L,19L,23L,29L,37L,41L,43L,59L,83L,101L,113L,137L,149L,151L,163L,191L,197L,239L,293L,313L,337L,349L,353L,359L,379L,383L,389L,397L,431L,439L,457L,491L,499L,503L,557L,563L,569L,571L,577L,593L,599L,647L,653L,677L,683L,709L,719L,727L,743L,773L,787L,827L,839L,853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019411Inst : IEnumerable<long>
{
public static readonly long[] Value=A019411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019411.Bytes);
public long this[int i]=>Value[i];

public static A019411Inst Instance=new A019411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019410
{
public static readonly long[] Value={ 5L,17L,23L,41L,47L,53L,73L,83L,103L,107L,131L,139L,157L,191L,223L,227L,233L,269L,283L,307L,311L,317L,347L,367L,383L,389L,421L,463L,487L,491L,509L,547L,563L,569L,571L,593L,599L,601L,647L,653L,659L,661L,673L,709L,719L,739L,751L,757L,761L,769L,773L,787L,797L,809L,811L,839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019410Inst : IEnumerable<long>
{
public static readonly long[] Value=A019410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019410.Bytes);
public long this[int i]=>Value[i];

public static A019410Inst Instance=new A019410Inst();

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