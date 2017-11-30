using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A201557
{
public static readonly long[] Value={ 183783600L,367567200L,1396755360L,1745944200L,2327925600L,3491888400L,6983776800L,80313433200L,160626866400L,252706217563800L,288807105787200L,336941623418400L,404329948102080L,505412435127600L,673883246836800L,1010824870255200L,2021649740510400L,112201560598327200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201557Inst : IEnumerable<long>
{
public static readonly long[] Value=A201557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201557.Bytes);
public long this[int i]=>Value[i];

public static A201557Inst Instance=new A201557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201558
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,4L,2L,1L,1L,2L,4L,1L,2L,3L,7L,7L,7L,1L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201558Inst : IEnumerable<long>
{
public static readonly long[] Value=A201558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201558.Bytes);
public long this[int i]=>Value[i];

public static A201558Inst Instance=new A201558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201559
{
public static readonly long[] Value={ 1L,1L,9L,2L,3L,4L,7L,3L,3L,7L,1L,8L,6L,1L,9L,3L,2L,0L,2L,8L,9L,7L,5L,0L,4L,4L,2L,7L,4L,2L,5L,5L,9L,7L,8L,8L,3L,4L,0L,1L,1L,1L,9L,2L,3L,0L,8L,3L,7L,9L,9L,9L,4L,3L,0L,1L,3L,7L,1L,9L,4L,9L,2L,9L,9L,0L,5L,2L,4L,5L,8L,6L,4L,8L,4L,8L,3L,0L,1L,3L,9L,2L,4L,0L,8L,4L,9L,9L,8L,6L,3L,8L,3L,7L,8L,8L,3L,6L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201559Inst : IEnumerable<long>
{
public static readonly long[] Value=A201559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201559.Bytes);
public long this[int i]=>Value[i];

public static A201559Inst Instance=new A201559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201560
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,4L,0L,1L,7L,6L,0L,1L,0L,8L,11L,1L,0L,10L,0L,1L,15L,12L,0L,1L,21L,14L,19L,1L,0L,16L,0L,1L,23L,18L,1L,1L,0L,20L,27L,1L,0L,22L,0L,1L,22L,24L,0L,1L,43L,26L,35L,1L,0L,28L,1L,1L,39L,30L,0L,1L,0L,32L,43L,1L,53L,34L,0L,1L,47L,36L,0L,1L,0L,38L,51L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201560Inst : IEnumerable<long>
{
public static readonly long[] Value=A201560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201560.Bytes);
public long this[int i]=>Value[i];

public static A201560Inst Instance=new A201560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201561
{
public static readonly BigInteger[] Value={ 1L,2L,12L,136L,2160L,43952L,1092672L,32102656L,1088252160L,41809041152L,1795201638912L,85196352787456L,4428299422310400L,250187205957220352L,15265712890413023232UL,BigInteger.Parse("1000468694343925006336"),BigInteger.Parse("70089639485229413498880"),BigInteger.Parse("5227049493330884279140352"),BigInteger.Parse("413441163603081566484037632") };
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
public class A201561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201561Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201561.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201561Inst Instance=new A201561Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201562
{
public static readonly long[] Value={ 2L,4L,2L,5L,6L,2L,2L,4L,5L,6L,9L,6L,5L,4L,4L,2L,2L,3L,4L,3L,8L,7L,5L,1L,8L,8L,0L,9L,4L,8L,5L,0L,9L,2L,0L,3L,3L,8L,1L,8L,2L,8L,2L,1L,1L,5L,7L,2L,4L,2L,5L,9L,5L,1L,0L,5L,9L,0L,8L,6L,2L,4L,3L,0L,7L,7L,7L,7L,8L,7L,6L,1L,9L,2L,3L,5L,3L,7L,3L,1L,0L,7L,4L,2L,3L,2L,2L,8L,6L,5L,0L,0L,0L,2L,0L,3L,9L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201562Inst : IEnumerable<long>
{
public static readonly long[] Value=A201562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201562.Bytes);
public long this[int i]=>Value[i];

public static A201562Inst Instance=new A201562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201563
{
public static readonly long[] Value={ 3L,0L,4L,4L,0L,3L,0L,1L,6L,6L,1L,1L,9L,2L,3L,5L,2L,8L,1L,6L,2L,2L,9L,8L,3L,5L,4L,9L,8L,0L,1L,1L,0L,0L,7L,9L,0L,3L,6L,8L,8L,2L,8L,0L,4L,8L,6L,0L,0L,7L,4L,4L,4L,9L,6L,3L,6L,8L,1L,1L,0L,7L,1L,7L,1L,3L,0L,0L,5L,4L,3L,7L,6L,0L,8L,6L,7L,4L,0L,3L,4L,7L,2L,7L,6L,9L,7L,1L,2L,4L,3L,8L,5L,2L,4L,3L,1L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201563Inst : IEnumerable<long>
{
public static readonly long[] Value=A201563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201563.Bytes);
public long this[int i]=>Value[i];

public static A201563Inst Instance=new A201563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201564
{
public static readonly long[] Value={ 4L,6L,7L,5L,8L,0L,9L,4L,4L,0L,6L,3L,4L,7L,1L,3L,6L,7L,3L,6L,1L,4L,1L,9L,2L,7L,0L,7L,6L,6L,8L,6L,5L,3L,8L,8L,5L,9L,4L,0L,2L,5L,3L,7L,2L,6L,6L,9L,2L,4L,9L,0L,6L,6L,7L,9L,2L,9L,5L,5L,6L,8L,3L,7L,6L,1L,2L,1L,9L,5L,2L,4L,9L,1L,3L,8L,9L,8L,3L,8L,0L,4L,3L,4L,5L,9L,4L,1L,1L,8L,5L,8L,8L,3L,2L,8L,8L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201564Inst : IEnumerable<long>
{
public static readonly long[] Value=A201564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201564.Bytes);
public long this[int i]=>Value[i];

public static A201564Inst Instance=new A201564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201565
{
public static readonly long[] Value={ 3L,0L,5L,3L,1L,5L,1L,7L,2L,2L,5L,2L,4L,8L,7L,0L,2L,1L,1L,8L,0L,4L,1L,5L,5L,0L,5L,3L,1L,7L,8L,1L,1L,3L,7L,4L,5L,9L,6L,2L,2L,4L,7L,6L,7L,8L,3L,9L,2L,0L,5L,5L,3L,4L,7L,5L,4L,1L,5L,4L,4L,1L,3L,9L,0L,6L,3L,7L,7L,3L,7L,1L,6L,9L,0L,6L,9L,5L,2L,2L,2L,7L,9L,1L,6L,9L,7L,4L,3L,4L,0L,3L,5L,9L,3L,5L,7L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201565Inst : IEnumerable<long>
{
public static readonly long[] Value=A201565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201565.Bytes);
public long this[int i]=>Value[i];

public static A201565Inst Instance=new A201565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201566
{
public static readonly long[] Value={ 3L,2L,7L,6L,4L,8L,2L,4L,7L,1L,1L,3L,6L,6L,8L,6L,7L,8L,0L,9L,8L,2L,4L,7L,7L,0L,6L,2L,0L,9L,8L,1L,9L,5L,2L,9L,8L,4L,4L,3L,7L,8L,4L,5L,2L,8L,2L,0L,0L,2L,4L,4L,8L,6L,4L,8L,9L,9L,2L,1L,7L,0L,7L,4L,8L,2L,1L,6L,1L,7L,1L,2L,6L,7L,5L,1L,4L,2L,8L,3L,5L,6L,9L,6L,9L,5L,8L,9L,9L,8L,1L,6L,1L,6L,1L,7L,2L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201566Inst : IEnumerable<long>
{
public static readonly long[] Value=A201566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201566.Bytes);
public long this[int i]=>Value[i];

public static A201566Inst Instance=new A201566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201567
{
public static readonly long[] Value={ 3L,0L,6L,0L,6L,4L,7L,6L,2L,1L,6L,7L,4L,3L,9L,0L,6L,4L,9L,4L,6L,7L,0L,2L,1L,0L,6L,1L,4L,4L,1L,5L,7L,5L,3L,7L,2L,7L,8L,8L,8L,9L,0L,1L,2L,3L,3L,7L,6L,9L,2L,2L,2L,7L,4L,3L,9L,7L,9L,9L,5L,2L,3L,0L,0L,1L,8L,8L,1L,8L,3L,7L,3L,7L,3L,6L,9L,0L,6L,0L,9L,4L,1L,8L,6L,6L,2L,9L,2L,4L,4L,0L,1L,7L,3L,8L,0L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201567Inst : IEnumerable<long>
{
public static readonly long[] Value=A201567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201567.Bytes);
public long this[int i]=>Value[i];

public static A201567Inst Instance=new A201567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201568
{
public static readonly long[] Value={ 2L,4L,8L,7L,4L,9L,0L,0L,0L,7L,1L,6L,2L,9L,5L,9L,8L,5L,3L,6L,5L,2L,9L,2L,4L,0L,8L,3L,7L,1L,6L,9L,4L,1L,0L,3L,9L,7L,1L,7L,2L,2L,7L,0L,7L,8L,6L,8L,7L,3L,3L,4L,9L,6L,1L,4L,2L,4L,4L,2L,2L,3L,6L,6L,8L,1L,9L,7L,3L,6L,4L,6L,7L,3L,2L,3L,9L,3L,5L,8L,5L,8L,5L,1L,0L,8L,2L,9L,3L,6L,4L,2L,8L,2L,2L,8L,8L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201568Inst : IEnumerable<long>
{
public static readonly long[] Value=A201568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201568.Bytes);
public long this[int i]=>Value[i];

public static A201568Inst Instance=new A201568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201569
{
public static readonly long[] Value={ 3L,0L,6L,6L,9L,3L,0L,1L,7L,7L,6L,5L,5L,7L,9L,6L,7L,1L,5L,9L,2L,1L,0L,6L,2L,7L,1L,3L,7L,3L,8L,1L,9L,8L,0L,7L,6L,4L,5L,0L,3L,0L,6L,2L,1L,6L,7L,1L,9L,0L,4L,5L,6L,7L,5L,9L,0L,8L,5L,3L,0L,1L,7L,8L,9L,3L,4L,9L,7L,7L,9L,4L,1L,5L,5L,5L,0L,6L,8L,7L,0L,1L,3L,2L,5L,0L,4L,0L,0L,1L,4L,8L,0L,6L,4L,8L,0L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201569Inst : IEnumerable<long>
{
public static readonly long[] Value=A201569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201569.Bytes);
public long this[int i]=>Value[i];

public static A201569Inst Instance=new A201569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201570
{
public static readonly long[] Value={ 1L,9L,9L,7L,4L,2L,2L,9L,2L,8L,1L,9L,4L,7L,2L,1L,3L,7L,0L,8L,6L,7L,4L,0L,5L,1L,5L,9L,5L,5L,3L,4L,8L,1L,1L,4L,5L,3L,2L,5L,4L,5L,4L,4L,3L,9L,0L,3L,2L,5L,3L,2L,4L,3L,3L,4L,5L,3L,8L,3L,3L,5L,7L,7L,9L,2L,2L,9L,6L,3L,1L,0L,3L,9L,3L,7L,2L,6L,7L,6L,1L,4L,9L,0L,4L,3L,4L,8L,2L,7L,7L,7L,7L,7L,5L,6L,0L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201570Inst : IEnumerable<long>
{
public static readonly long[] Value=A201570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201570.Bytes);
public long this[int i]=>Value[i];

public static A201570Inst Instance=new A201570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201571
{
public static readonly long[] Value={ 3L,0L,7L,2L,2L,7L,9L,8L,3L,0L,0L,5L,1L,2L,5L,0L,3L,3L,5L,8L,5L,9L,8L,6L,6L,4L,6L,0L,4L,6L,4L,6L,9L,9L,0L,6L,0L,3L,6L,3L,7L,2L,9L,1L,3L,7L,8L,0L,4L,8L,4L,8L,3L,4L,3L,3L,0L,6L,3L,1L,4L,0L,6L,9L,7L,8L,4L,5L,2L,0L,7L,7L,8L,5L,0L,3L,1L,7L,1L,7L,0L,5L,5L,2L,3L,2L,0L,3L,8L,1L,8L,3L,5L,8L,4L,0L,9L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201571Inst : IEnumerable<long>
{
public static readonly long[] Value=A201571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201571.Bytes);
public long this[int i]=>Value[i];

public static A201571Inst Instance=new A201571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201572
{
public static readonly long[] Value={ 1L,6L,6L,6L,6L,9L,1L,6L,3L,1L,7L,5L,4L,0L,0L,9L,4L,9L,5L,6L,5L,2L,0L,0L,3L,2L,0L,6L,2L,7L,7L,6L,1L,2L,9L,9L,1L,5L,8L,1L,6L,7L,6L,7L,4L,4L,7L,5L,4L,0L,3L,4L,4L,9L,3L,4L,8L,0L,4L,8L,4L,6L,7L,5L,6L,4L,4L,2L,3L,4L,9L,3L,7L,1L,3L,9L,6L,9L,9L,0L,8L,9L,8L,1L,0L,3L,5L,3L,6L,6L,4L,1L,8L,6L,7L,0L,3L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201572Inst : IEnumerable<long>
{
public static readonly long[] Value=A201572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201572.Bytes);
public long this[int i]=>Value[i];

public static A201572Inst Instance=new A201572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201573
{
public static readonly long[] Value={ 3L,0L,7L,6L,8L,9L,4L,9L,2L,9L,2L,4L,6L,1L,9L,2L,0L,2L,3L,1L,6L,6L,6L,9L,3L,6L,4L,7L,3L,2L,7L,7L,2L,5L,7L,7L,3L,2L,4L,8L,4L,1L,9L,8L,0L,6L,5L,8L,2L,3L,7L,4L,3L,2L,0L,1L,5L,8L,3L,9L,9L,5L,2L,4L,3L,9L,9L,1L,1L,1L,5L,7L,6L,0L,6L,3L,1L,5L,1L,1L,6L,6L,3L,2L,3L,5L,2L,6L,3L,1L,1L,7L,4L,6L,7L,7L,2L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201573Inst : IEnumerable<long>
{
public static readonly long[] Value=A201573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201573.Bytes);
public long this[int i]=>Value[i];

public static A201573Inst Instance=new A201573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201574
{
public static readonly long[] Value={ 1L,4L,2L,9L,2L,7L,5L,8L,2L,9L,9L,3L,9L,2L,0L,8L,6L,7L,0L,0L,4L,3L,1L,0L,4L,4L,3L,0L,7L,5L,5L,4L,7L,4L,8L,2L,4L,0L,8L,8L,4L,3L,5L,1L,3L,9L,9L,1L,0L,5L,0L,9L,4L,5L,4L,0L,2L,7L,8L,5L,0L,1L,0L,4L,5L,9L,2L,8L,5L,0L,3L,0L,7L,9L,5L,5L,0L,5L,9L,4L,2L,2L,7L,2L,6L,3L,9L,7L,7L,6L,0L,5L,3L,6L,5L,1L,6L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201574Inst : IEnumerable<long>
{
public static readonly long[] Value=A201574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201574.Bytes);
public long this[int i]=>Value[i];

public static A201574Inst Instance=new A201574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201575
{
public static readonly long[] Value={ 3L,0L,8L,0L,9L,2L,0L,2L,3L,2L,2L,9L,5L,2L,0L,6L,8L,0L,4L,5L,5L,9L,3L,5L,8L,4L,9L,8L,2L,1L,2L,7L,5L,3L,7L,0L,1L,0L,8L,7L,2L,6L,9L,9L,6L,9L,0L,8L,2L,4L,2L,1L,1L,8L,5L,7L,5L,7L,2L,2L,8L,1L,7L,4L,8L,5L,3L,8L,9L,4L,3L,8L,2L,4L,7L,7L,5L,0L,5L,0L,9L,0L,3L,9L,8L,7L,9L,1L,5L,9L,7L,4L,0L,2L,6L,4L,8L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201575Inst : IEnumerable<long>
{
public static readonly long[] Value=A201575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201575.Bytes);
public long this[int i]=>Value[i];

public static A201575Inst Instance=new A201575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201576
{
public static readonly long[] Value={ 1L,2L,5L,0L,8L,1L,9L,2L,2L,6L,3L,5L,9L,9L,7L,4L,4L,1L,2L,8L,9L,1L,7L,7L,7L,0L,1L,6L,5L,3L,7L,8L,5L,7L,0L,7L,1L,8L,7L,6L,5L,5L,4L,8L,7L,1L,3L,4L,6L,8L,7L,6L,2L,6L,4L,8L,0L,7L,0L,8L,7L,1L,4L,2L,1L,6L,3L,6L,8L,2L,8L,2L,2L,8L,9L,2L,4L,8L,7L,3L,4L,6L,3L,7L,1L,4L,1L,7L,7L,6L,1L,6L,6L,7L,2L,8L,5L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201576Inst : IEnumerable<long>
{
public static readonly long[] Value=A201576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201576.Bytes);
public long this[int i]=>Value[i];

public static A201576Inst Instance=new A201576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201577
{
public static readonly long[] Value={ 3L,0L,8L,4L,4L,6L,4L,1L,4L,0L,5L,6L,4L,3L,8L,0L,8L,4L,9L,4L,5L,9L,1L,9L,0L,5L,9L,5L,3L,6L,4L,6L,4L,6L,0L,2L,1L,8L,3L,3L,5L,2L,0L,6L,1L,4L,9L,0L,4L,5L,8L,6L,4L,7L,6L,8L,3L,8L,8L,2L,8L,5L,6L,2L,6L,8L,3L,0L,8L,4L,7L,2L,4L,3L,6L,7L,1L,4L,1L,4L,6L,2L,8L,5L,9L,3L,5L,3L,3L,4L,0L,8L,3L,2L,7L,8L,3L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201577Inst : IEnumerable<long>
{
public static readonly long[] Value=A201577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201577.Bytes);
public long this[int i]=>Value[i];

public static A201577Inst Instance=new A201577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201578
{
public static readonly long[] Value={ 1L,0L,0L,0L,6L,6L,8L,8L,4L,0L,7L,2L,9L,1L,9L,3L,0L,9L,2L,7L,9L,8L,0L,5L,3L,8L,4L,4L,5L,9L,3L,8L,1L,1L,1L,5L,0L,6L,0L,7L,1L,7L,8L,5L,4L,6L,9L,8L,0L,2L,2L,5L,0L,0L,6L,0L,9L,9L,9L,8L,6L,7L,6L,2L,9L,6L,3L,7L,6L,9L,7L,5L,0L,6L,9L,5L,8L,2L,6L,1L,7L,7L,6L,0L,5L,8L,1L,0L,9L,3L,5L,5L,1L,2L,5L,2L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201578Inst : IEnumerable<long>
{
public static readonly long[] Value=A201578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201578.Bytes);
public long this[int i]=>Value[i];

public static A201578Inst Instance=new A201578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201579
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,7L,6L,4L,9L,5L,3L,0L,3L,3L,6L,5L,5L,2L,4L,1L,1L,3L,2L,1L,6L,9L,1L,8L,0L,0L,6L,5L,7L,5L,3L,3L,6L,1L,1L,7L,8L,7L,3L,4L,2L,3L,4L,6L,0L,7L,0L,0L,3L,7L,0L,8L,5L,6L,9L,6L,1L,2L,1L,2L,7L,2L,8L,3L,8L,6L,1L,8L,4L,4L,7L,2L,8L,6L,5L,9L,0L,9L,2L,5L,8L,1L,7L,6L,4L,2L,8L,9L,2L,7L,5L,3L,2L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201579Inst : IEnumerable<long>
{
public static readonly long[] Value=A201579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201579.Bytes);
public long this[int i]=>Value[i];

public static A201579Inst Instance=new A201579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201580
{
public static readonly long[] Value={ 3L,0L,8L,7L,6L,0L,9L,6L,0L,2L,7L,8L,3L,6L,0L,6L,1L,3L,3L,0L,0L,1L,1L,9L,0L,4L,9L,8L,8L,4L,6L,7L,0L,1L,5L,0L,7L,7L,1L,5L,8L,0L,1L,9L,5L,4L,6L,6L,8L,5L,6L,6L,5L,3L,7L,9L,3L,4L,2L,4L,0L,9L,4L,1L,4L,2L,9L,0L,1L,8L,0L,5L,2L,0L,5L,2L,6L,7L,1L,8L,3L,9L,8L,1L,8L,5L,7L,2L,8L,3L,5L,2L,7L,8L,2L,3L,7L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201580Inst : IEnumerable<long>
{
public static readonly long[] Value=A201580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201580.Bytes);
public long this[int i]=>Value[i];

public static A201580Inst Instance=new A201580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201581
{
public static readonly long[] Value={ 3L,0L,9L,0L,4L,2L,1L,2L,7L,0L,1L,5L,2L,1L,5L,1L,4L,5L,3L,6L,5L,1L,4L,9L,7L,4L,4L,3L,8L,9L,9L,9L,2L,0L,5L,3L,4L,3L,8L,7L,8L,8L,2L,1L,3L,8L,3L,1L,5L,6L,3L,5L,0L,1L,4L,0L,8L,5L,5L,5L,5L,1L,8L,9L,9L,6L,6L,3L,6L,3L,1L,5L,9L,8L,0L,6L,4L,7L,6L,1L,2L,8L,4L,0L,6L,0L,6L,1L,1L,0L,6L,8L,9L,9L,4L,4L,5L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201581Inst : IEnumerable<long>
{
public static readonly long[] Value=A201581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201581.Bytes);
public long this[int i]=>Value[i];

public static A201581Inst Instance=new A201581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201582
{
public static readonly long[] Value={ 3L,0L,3L,2L,6L,4L,5L,4L,1L,8L,3L,8L,8L,7L,5L,6L,1L,8L,8L,6L,7L,5L,3L,2L,5L,6L,3L,6L,8L,0L,2L,6L,0L,8L,9L,3L,2L,8L,4L,6L,7L,2L,3L,6L,2L,6L,7L,4L,9L,9L,7L,1L,8L,5L,9L,8L,5L,1L,9L,8L,4L,5L,6L,7L,7L,8L,0L,6L,7L,1L,1L,3L,4L,1L,9L,9L,2L,4L,2L,2L,5L,0L,4L,2L,5L,5L,8L,4L,3L,8L,8L,9L,8L,8L,9L,7L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201582Inst : IEnumerable<long>
{
public static readonly long[] Value=A201582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201582.Bytes);
public long this[int i]=>Value[i];

public static A201582Inst Instance=new A201582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201583
{
public static readonly long[] Value={ 8L,2L,5L,0L,2L,8L,9L,2L,4L,0L,1L,5L,0L,0L,6L,3L,3L,9L,3L,3L,3L,9L,4L,6L,3L,1L,8L,1L,8L,3L,3L,5L,7L,9L,7L,8L,6L,9L,2L,2L,8L,7L,1L,0L,1L,4L,8L,2L,8L,7L,1L,0L,8L,8L,5L,2L,7L,4L,2L,5L,2L,0L,4L,2L,7L,7L,8L,5L,7L,4L,3L,9L,1L,0L,4L,3L,1L,4L,1L,6L,8L,3L,6L,0L,1L,4L,4L,0L,9L,8L,7L,0L,3L,4L,7L,3L,9L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201583Inst : IEnumerable<long>
{
public static readonly long[] Value=A201583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201583.Bytes);
public long this[int i]=>Value[i];

public static A201583Inst Instance=new A201583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201584
{
public static readonly long[] Value={ 3L,0L,8L,9L,1L,7L,4L,2L,1L,1L,9L,2L,9L,9L,3L,0L,2L,0L,6L,5L,6L,0L,5L,7L,7L,4L,8L,7L,8L,6L,9L,9L,7L,3L,8L,0L,4L,9L,3L,7L,1L,6L,3L,0L,9L,6L,5L,6L,6L,7L,2L,1L,0L,0L,2L,6L,5L,8L,0L,5L,8L,8L,2L,2L,6L,9L,1L,1L,0L,0L,8L,9L,9L,1L,3L,2L,5L,0L,5L,1L,6L,3L,6L,1L,8L,4L,8L,9L,4L,4L,8L,0L,0L,1L,6L,6L,3L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201584Inst : IEnumerable<long>
{
public static readonly long[] Value=A201584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201584.Bytes);
public long this[int i]=>Value[i];

public static A201584Inst Instance=new A201584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201585
{
public static readonly long[] Value={ 7L,1L,3L,6L,1L,1L,5L,4L,1L,0L,6L,5L,4L,5L,3L,5L,1L,6L,9L,6L,7L,1L,2L,3L,4L,8L,7L,4L,8L,4L,8L,2L,8L,2L,3L,1L,1L,4L,4L,0L,0L,5L,5L,5L,1L,9L,8L,5L,0L,0L,2L,7L,5L,7L,8L,8L,6L,3L,6L,5L,8L,4L,1L,9L,1L,4L,4L,4L,9L,9L,0L,3L,5L,1L,3L,2L,8L,5L,5L,6L,4L,8L,4L,8L,0L,8L,7L,8L,7L,0L,0L,2L,5L,8L,9L,6L,5L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201585Inst : IEnumerable<long>
{
public static readonly long[] Value=A201585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201585.Bytes);
public long this[int i]=>Value[i];

public static A201585Inst Instance=new A201585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201586
{
public static readonly long[] Value={ 3L,1L,0L,7L,0L,5L,7L,0L,8L,4L,6L,6L,9L,2L,7L,9L,1L,3L,9L,4L,2L,1L,3L,3L,6L,3L,9L,7L,5L,8L,9L,0L,2L,3L,2L,6L,5L,5L,1L,8L,6L,0L,5L,8L,8L,9L,3L,2L,2L,5L,2L,6L,6L,1L,3L,6L,2L,2L,4L,2L,2L,4L,1L,7L,2L,2L,9L,4L,1L,3L,6L,5L,7L,1L,6L,6L,3L,2L,5L,1L,8L,1L,3L,0L,2L,2L,1L,8L,8L,2L,7L,7L,7L,5L,6L,4L,8L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201586Inst : IEnumerable<long>
{
public static readonly long[] Value=A201586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201586.Bytes);
public long this[int i]=>Value[i];

public static A201586Inst Instance=new A201586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201587
{
public static readonly long[] Value={ 6L,4L,4L,8L,9L,7L,4L,7L,5L,5L,4L,3L,6L,7L,3L,8L,3L,4L,4L,4L,3L,3L,5L,7L,3L,9L,0L,0L,4L,4L,4L,7L,4L,5L,2L,0L,1L,7L,0L,1L,3L,6L,8L,0L,5L,7L,9L,8L,7L,6L,3L,3L,7L,5L,0L,8L,8L,3L,4L,1L,4L,4L,8L,8L,6L,5L,5L,0L,7L,5L,9L,7L,3L,0L,8L,2L,2L,8L,5L,9L,1L,9L,6L,9L,6L,3L,7L,0L,0L,3L,0L,4L,9L,4L,5L,1L,7L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201587Inst : IEnumerable<long>
{
public static readonly long[] Value=A201587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201587.Bytes);
public long this[int i]=>Value[i];

public static A201587Inst Instance=new A201587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201588
{
public static readonly long[] Value={ 3L,1L,1L,5L,8L,3L,9L,0L,5L,1L,2L,7L,6L,2L,5L,3L,5L,2L,1L,1L,3L,1L,0L,8L,5L,0L,1L,5L,1L,9L,5L,2L,0L,8L,2L,5L,8L,7L,8L,1L,1L,1L,2L,0L,9L,6L,5L,8L,8L,8L,1L,7L,4L,0L,1L,0L,7L,7L,2L,8L,9L,3L,9L,0L,0L,7L,8L,2L,4L,7L,0L,2L,2L,4L,1L,3L,9L,2L,7L,8L,4L,1L,4L,1L,9L,7L,4L,9L,9L,3L,0L,3L,8L,8L,6L,8L,6L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201588Inst : IEnumerable<long>
{
public static readonly long[] Value=A201588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201588.Bytes);
public long this[int i]=>Value[i];

public static A201588Inst Instance=new A201588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201589
{
public static readonly long[] Value={ 5L,9L,6L,6L,2L,6L,8L,1L,9L,8L,6L,0L,7L,0L,4L,5L,4L,6L,7L,6L,1L,8L,3L,2L,8L,5L,9L,0L,8L,2L,1L,4L,1L,0L,4L,8L,3L,0L,3L,6L,5L,3L,1L,0L,0L,8L,7L,0L,2L,9L,3L,0L,5L,7L,4L,4L,7L,1L,8L,2L,0L,4L,7L,7L,5L,8L,3L,7L,4L,7L,8L,6L,0L,6L,4L,1L,9L,9L,1L,6L,3L,4L,1L,9L,4L,0L,7L,6L,9L,5L,5L,7L,2L,8L,9L,7L,2L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201589Inst : IEnumerable<long>
{
public static readonly long[] Value=A201589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201589.Bytes);
public long this[int i]=>Value[i];

public static A201589Inst Instance=new A201589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201590
{
public static readonly long[] Value={ 3L,1L,2L,1L,0L,5L,9L,4L,6L,3L,5L,2L,3L,8L,2L,7L,4L,1L,5L,3L,6L,0L,1L,7L,5L,7L,0L,0L,0L,3L,4L,0L,9L,2L,0L,4L,8L,9L,1L,0L,7L,4L,9L,9L,6L,8L,4L,4L,7L,8L,4L,7L,8L,2L,7L,1L,2L,2L,2L,5L,2L,7L,1L,0L,2L,4L,0L,7L,1L,2L,3L,5L,0L,6L,2L,6L,9L,9L,8L,4L,0L,2L,3L,6L,0L,2L,1L,5L,9L,2L,8L,2L,7L,3L,1L,7L,9L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201590Inst : IEnumerable<long>
{
public static readonly long[] Value=A201590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201590.Bytes);
public long this[int i]=>Value[i];

public static A201590Inst Instance=new A201590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201591
{
public static readonly long[] Value={ 5L,6L,0L,1L,0L,0L,6L,9L,4L,9L,1L,2L,1L,6L,0L,7L,6L,2L,8L,2L,3L,8L,4L,1L,3L,3L,3L,7L,9L,7L,8L,1L,2L,0L,7L,7L,5L,2L,9L,3L,7L,4L,5L,0L,3L,0L,3L,0L,8L,9L,6L,4L,1L,1L,5L,5L,8L,6L,1L,2L,2L,0L,4L,3L,0L,9L,0L,6L,7L,5L,9L,1L,6L,2L,1L,5L,6L,4L,8L,3L,3L,1L,4L,0L,8L,0L,7L,1L,6L,1L,8L,4L,7L,1L,4L,3L,7L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201591Inst : IEnumerable<long>
{
public static readonly long[] Value=A201591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201591.Bytes);
public long this[int i]=>Value[i];

public static A201591Inst Instance=new A201591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201592
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,3L,4L,1L,2L,4L,3L,1L,4L,2L,6L,3L,5L,6L,4L,1L,2L,5L,3L,4L,7L,6L,8L,1L,5L,2L,3L,8L,9L,6L,4L,9L,8L,5L,1L,2L,3L,6L,9L,4L,10L,7L,5L,1L,9L,2L,6L,8L,3L,11L,4L,12L,7L,10L,12L,5L,8L,1L,6L,2L,3L,10L,12L,7L,4L,9L,5L,8L,11L,12L,6L,1L,2L,3L,7L,14L,4L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201592Inst : IEnumerable<long>
{
public static readonly long[] Value=A201592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201592.Bytes);
public long this[int i]=>Value[i];

public static A201592Inst Instance=new A201592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201593
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,1L,3L,3L,2L,3L,4L,3L,4L,1L,4L,3L,2L,4L,5L,5L,4L,5L,5L,3L,4L,2L,6L,5L,6L,6L,3L,1L,5L,6L,2L,4L,6L,7L,7L,7L,6L,4L,7L,3L,6L,7L,8L,5L,8L,7L,6L,8L,3L,8L,1L,7L,5L,2L,8L,7L,9L,8L,9L,9L,6L,4L,8L,9L,7L,9L,8L,6L,5L,9L,10L,10L,10L,9L,3L,10L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201593Inst : IEnumerable<long>
{
public static readonly long[] Value=A201593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201593.Bytes);
public long this[int i]=>Value[i];

public static A201593Inst Instance=new A201593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201594
{
public static readonly BigInteger[] Value={ 1L,1L,4L,32L,384L,6176L,124928L,3049472L,87265280L,2865848320L,106258440192L,4391008927744L,200131590356992L,9973976451383296L,539604322034384896L,BigInteger.Parse("31496226303081709568"),BigInteger.Parse("1972926888464596598784"),BigInteger.Parse("132015791534989604028416"),BigInteger.Parse("9398128264859870497341440"),BigInteger.Parse("709248762402156849800413184") };
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
public class A201594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201594Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201594.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201594Inst Instance=new A201594Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201595
{
public static readonly BigInteger[] Value={ 1L,1L,4L,28L,288L,3936L,67328L,1385728L,33372160L,921118720L,28677169152L,994360565760L,38007586684928L,1587878686621696L,71990467473965056L,3520403893852831744L,BigInteger.Parse("184707311409882464256"),BigInteger.Parse("10350444842488122310656"),BigInteger.Parse("616975843658373414256640"),BigInteger.Parse("38981881007475178476666880") };
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
public class A201595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201595Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201595.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201595Inst Instance=new A201595Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201596
{
public static readonly long[] Value={ 6L,24L,30L,90L,150L,156L,210L,240L,306L,366L,384L,444L,810L,834L,1086L,1200L,1326L,2316L,3876L,4230L,4350L,8244L,8880L,9450L,10686L,10950L,11784L,12816L,13554L,15504L,15576L,16254L,16506L,16596L,19446L,19944L,21516L,38340L,39990L,41556L,45786L,47190L,48246L,59856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201596Inst : IEnumerable<long>
{
public static readonly long[] Value=A201596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201596.Bytes);
public long this[int i]=>Value[i];

public static A201596Inst Instance=new A201596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201597
{
public static readonly long[] Value={ 7L,13L,37L,103L,307L,457L,613L,2137L,2377L,2797L,3463L,4783L,5737L,9433L,14557L,24103L,45817L,52177L,126487L,317587L,580687L,715873L,2719663L,6227563L,8114857L,10085623L,10137493L,18773137L,21297553L,25291363L,43472497L,52645423L,69718147L,80002627L,89776327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201597Inst : IEnumerable<long>
{
public static readonly long[] Value=A201597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201597.Bytes);
public long this[int i]=>Value[i];

public static A201597Inst Instance=new A201597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201598
{
public static readonly long[] Value={ 6L,24L,60L,84L,114L,180L,210L,264L,390L,564L,630L,1050L,1200L,1530L,2016L,2844L,3426L,3756L,3864L,3936L,4074L,4110L,6090L,8250L,9240L,9270L,10344L,10506L,10734L,10920L,12930L,15204L,20190L,20286L,21216L,25746L,34920L,38820L,39390L,41754L,43020L,44310L,52500L,71346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201598Inst : IEnumerable<long>
{
public static readonly long[] Value=A201598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201598.Bytes);
public long this[int i]=>Value[i];

public static A201598Inst Instance=new A201598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201599
{
public static readonly long[] Value={ 5L,17L,41L,107L,347L,461L,881L,1607L,2267L,2687L,6197L,6827L,39227L,46181L,56891L,83267L,167621L,375251L,381527L,549161L,741677L,805031L,931571L,2095361L,2428451L,4769111L,4938287L,12300641L,12652457L,13430171L,14094797L,18074027L,29480651L,107379731L,138778301L,156377861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201599Inst : IEnumerable<long>
{
public static readonly long[] Value=A201599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201599.Bytes);
public long this[int i]=>Value[i];

public static A201599Inst Instance=new A201599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201600
{
public static readonly long[] Value={ 5L,11L,29L,59L,101L,389L,491L,1019L,1181L,1949L,2909L,3461L,5051L,8219L,8669L,10091L,10589L,11621L,13259L,13829L,14411L,16229L,23819L,26141L,27749L,28571L,39371L,44381L,50789L,51899L,61211L,63659L,64901L,67421L,68699L,75269L,82139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201600Inst : IEnumerable<long>
{
public static readonly long[] Value=A201600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201600.Bytes);
public long this[int i]=>Value[i];

public static A201600Inst Instance=new A201600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201601
{
public static readonly long[] Value={ 7L,13L,31L,61L,103L,157L,223L,607L,733L,1021L,1543L,1741L,1951L,3181L,3463L,5407L,6151L,8221L,9133L,10093L,12157L,12703L,13831L,16231L,19501L,23071L,25357L,27751L,28573L,30253L,31981L,33757L,39373L,40351L,41341L,44383L,46471L,47533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201601Inst : IEnumerable<long>
{
public static readonly long[] Value=A201601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201601.Bytes);
public long this[int i]=>Value[i];

public static A201601Inst Instance=new A201601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201602
{
public static readonly long[] Value={ 29L,113L,449L,701L,1009L,1373L,2269L,2801L,3389L,4733L,6301L,8093L,13553L,14813L,23549L,30493L,32369L,34301L,38333L,40433L,42589L,49393L,56701L,64513L,70001L,78653L,81649L,84701L,100801L,114689L,125693L,137201L,149213L,161729L,166013L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201602Inst : IEnumerable<long>
{
public static readonly long[] Value=A201602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201602.Bytes);
public long this[int i]=>Value[i];

public static A201602Inst Instance=new A201602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201603
{
public static readonly long[] Value={ 2L,569L,3089L,14177L,33329L,86249L,139169L,190577L,250049L,266177L,282809L,335729L,354377L,434009L,455177L,476849L,544889L,568577L,804449L,833177L,862409L,1148177L,1182449L,1324577L,1474769L,1673849L,1715177L,1885529L,2203049L,2647577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201603Inst : IEnumerable<long>
{
public static readonly long[] Value=A201603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201603.Bytes);
public long this[int i]=>Value[i];

public static A201603Inst Instance=new A201603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201604
{
public static readonly long[] Value={ 3L,31L,2803L,3391L,10111L,32371L,34303L,67231L,70003L,87811L,114691L,161731L,179203L,231871L,285631L,302851L,338803L,409951L,473203L,502771L,588703L,596851L,621631L,638431L,672703L,753091L,809203L,1075651L,1246591L,1294303L,1367551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201604Inst : IEnumerable<long>
{
public static readonly long[] Value=A201604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201604.Bytes);
public long this[int i]=>Value[i];

public static A201604Inst Instance=new A201604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201605
{
public static readonly long[] Value={ 11L,67L,179L,347L,571L,1187L,1579L,2027L,2531L,5107L,9587L,10651L,15467L,16811L,18211L,21179L,24371L,33331L,35291L,37307L,41507L,43691L,63179L,65867L,68611L,71411L,80147L,89387L,99131L,105907L,109379L,116491L,127579L,147179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201605Inst : IEnumerable<long>
{
public static readonly long[] Value=A201605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201605.Bytes);
public long this[int i]=>Value[i];

public static A201605Inst Instance=new A201605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201606
{
public static readonly long[] Value={ 5L,257L,1013L,2273L,30497L,36293L,90977L,183713L,197573L,326597L,383297L,423617L,533237L,707873L,734837L,790277L,1000193L,1097717L,1199777L,1270337L,1306373L,1379957L,1951493L,1996097L,2086817L,2371073L,2420213L,2570657L,3217793L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201606Inst : IEnumerable<long>
{
public static readonly long[] Value=A201606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201606.Bytes);
public long this[int i]=>Value[i];

public static A201606Inst Instance=new A201606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201607
{
public static readonly long[] Value={ 13L,181L,349L,853L,2029L,3709L,6733L,8581L,24373L,26053L,29581L,37309L,50581L,57973L,71413L,80149L,92581L,99133L,112909L,123829L,155413L,195229L,199933L,214381L,277213L,294181L,311653L,323581L,329629L,399853L,406573L,427069L,491581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201607Inst : IEnumerable<long>
{
public static readonly long[] Value=A201607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201607.Bytes);
public long this[int i]=>Value[i];

public static A201607Inst Instance=new A201607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201608
{
public static readonly long[] Value={ 71L,1583L,22751L,27791L,39383L,127583L,163871L,190583L,219311L,234431L,266183L,299951L,317591L,354383L,393191L,617471L,922391L,984383L,1048391L,1436471L,1513583L,2018591L,2156183L,2250431L,2298311L,2395583L,2545271L,2804831L,3076991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201608Inst : IEnumerable<long>
{
public static readonly long[] Value=A201608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201608.Bytes);
public long this[int i]=>Value[i];

public static A201608Inst Instance=new A201608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201609
{
public static readonly long[] Value={ 37L,457L,709L,1381L,1801L,7177L,8101L,14821L,17509L,21961L,23557L,32377L,44809L,54217L,61861L,70009L,75721L,94201L,107641L,137209L,141157L,153337L,166021L,179209L,188281L,202309L,216841L,221797L,231877L,252709L,268921L,280009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201609Inst : IEnumerable<long>
{
public static readonly long[] Value=A201609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201609.Bytes);
public long this[int i]=>Value[i];

public static A201609Inst Instance=new A201609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201610
{
public static readonly long[] Value={ 17L,73L,353L,577L,857L,1193L,5113L,5897L,6737L,10657L,11777L,12953L,15473L,18217L,27793L,37313L,41513L,55457L,57977L,80153L,83177L,86257L,89393L,99137L,102497L,105913L,112913L,123833L,135257L,139177L,151273L,159617L,172553L,176977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201610Inst : IEnumerable<long>
{
public static readonly long[] Value=A201610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201610.Bytes);
public long this[int i]=>Value[i];

public static A201610Inst Instance=new A201610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201611
{
public static readonly long[] Value={ 3L,11L,131L,971L,1571L,3203L,5003L,7691L,9803L,13451L,16931L,19211L,24203L,27851L,32771L,51203L,57803L,81611L,86531L,89891L,125003L,143651L,154571L,204803L,207371L,247811L,273803L,288803L,339491L,356171L,387203L,401411L,480203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201611Inst : IEnumerable<long>
{
public static readonly long[] Value=A201611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201611.Bytes);
public long this[int i]=>Value[i];

public static A201611Inst Instance=new A201611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201612
{
public static readonly long[] Value={ 5L,13L,37L,293L,397L,653L,2053L,3533L,3877L,5413L,6277L,6733L,10957L,14797L,15493L,19213L,23333L,25997L,30757L,36997L,48677L,55117L,56453L,69197L,75277L,76837L,86533L,98573L,100357L,109517L,117133L,129037L,139397L,143653L,154573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201612Inst : IEnumerable<long>
{
public static readonly long[] Value=A201612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201612.Bytes);
public long this[int i]=>Value[i];

public static A201612Inst Instance=new A201612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201613
{
public static readonly long[] Value={ 43L,59L,67L,107L,139L,251L,307L,347L,379L,547L,587L,859L,1699L,1867L,1931L,3371L,3499L,3739L,4507L,5059L,5347L,6907L,6971L,7451L,10091L,10627L,10667L,11467L,12491L,18787L,20411L,21227L,22907L,29947L,32059L,32779L,37547L,38651L,39619L,49307L,49747L,53147L,55787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201613Inst : IEnumerable<long>
{
public static readonly long[] Value=A201613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201613.Bytes);
public long this[int i]=>Value[i];

public static A201613Inst Instance=new A201613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201614
{
public static readonly long[] Value={ 3L,9L,6L,4L,7L,8L,4L,0L,0L,1L,7L,6L,7L,2L,8L,8L,0L,1L,3L,2L,0L,3L,7L,7L,2L,1L,9L,5L,4L,9L,1L,4L,5L,0L,1L,3L,1L,1L,7L,8L,3L,7L,6L,1L,4L,2L,2L,1L,9L,0L,4L,1L,8L,5L,1L,5L,8L,6L,6L,3L,8L,8L,9L,5L,4L,4L,0L,1L,0L,8L,7L,8L,0L,8L,5L,0L,8L,7L,7L,9L,9L,7L,0L,3L,9L,5L,5L,5L,9L,1L,1L,1L,0L,5L,2L,9L,9L,2L,9L,0L,2L,5L,5L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201614Inst : IEnumerable<long>
{
public static readonly long[] Value=A201614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201614.Bytes);
public long this[int i]=>Value[i];

public static A201614Inst Instance=new A201614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201615
{
public static readonly long[] Value={ 2L,1L,3L,7L,6L,6L,9L,5L,0L,9L,6L,7L,2L,6L,9L,8L,4L,3L,3L,3L,1L,7L,1L,4L,9L,8L,1L,6L,9L,0L,3L,2L,6L,1L,9L,4L,1L,9L,0L,3L,9L,6L,6L,6L,3L,1L,7L,4L,4L,2L,0L,9L,7L,5L,8L,4L,7L,2L,1L,2L,1L,4L,7L,1L,0L,5L,2L,3L,8L,7L,1L,0L,1L,1L,6L,3L,4L,5L,5L,0L,5L,2L,5L,3L,9L,6L,5L,8L,8L,6L,2L,6L,3L,0L,5L,3L,3L,3L,6L,6L,0L,8L,6L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201615Inst : IEnumerable<long>
{
public static readonly long[] Value=A201615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201615.Bytes);
public long this[int i]=>Value[i];

public static A201615Inst Instance=new A201615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201616
{
public static readonly long[] Value={ 1L,1L,2L,9L,7L,0L,5L,2L,2L,2L,0L,0L,5L,9L,7L,7L,4L,2L,2L,3L,8L,0L,4L,0L,6L,7L,7L,9L,0L,4L,2L,8L,7L,9L,4L,3L,4L,0L,8L,6L,1L,9L,1L,4L,5L,0L,2L,3L,1L,6L,4L,4L,8L,6L,2L,1L,1L,2L,1L,0L,5L,0L,7L,6L,7L,7L,7L,0L,1L,9L,5L,3L,8L,3L,2L,7L,3L,0L,7L,9L,8L,9L,2L,9L,2L,6L,3L,4L,6L,4L,8L,2L,2L,8L,9L,4L,3L,8L,9L,6L,9L,3L,7L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201616Inst : IEnumerable<long>
{
public static readonly long[] Value=A201616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201616.Bytes);
public long this[int i]=>Value[i];

public static A201616Inst Instance=new A201616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201617
{
public static readonly long[] Value={ 0L,16L,378L,91223L,136175057L,1492809994673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201617Inst : IEnumerable<long>
{
public static readonly long[] Value=A201617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201617.Bytes);
public long this[int i]=>Value[i];

public static A201617Inst Instance=new A201617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201618
{
public static readonly long[] Value={ 0L,4L,4L,10L,16L,26L,40L,59L,84L,116L,156L,205L,264L,334L,416L,511L,620L,744L,884L,1041L,1216L,1410L,1624L,1859L,2116L,2396L,2700L,3029L,3384L,3766L,4176L,4615L,5084L,5584L,6116L,6681L,7280L,7914L,8584L,9291L,10036L,10820L,11644L,12509L,13416L,14366L,15360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201618Inst : IEnumerable<long>
{
public static readonly long[] Value=A201618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201618.Bytes);
public long this[int i]=>Value[i];

public static A201618Inst Instance=new A201618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201619
{
public static readonly long[] Value={ 4L,16L,56L,211L,718L,2271L,6654L,18191L,46767L,113873L,264247L,587571L,1257743L,2602113L,5220668L,10186777L,19378603L,36016206L,65517188L,116838180L,204546828L,351977489L,595974410L,993932688L,1634127635L,2650699891L,4245165105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201619Inst : IEnumerable<long>
{
public static readonly long[] Value=A201619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201619.Bytes);
public long this[int i]=>Value[i];

public static A201619Inst Instance=new A201619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201620
{
public static readonly long[] Value={ 4L,56L,378L,3699L,31802L,256836L,1877283L,12466658L,75830797L,426330762L,2234037739L,10991599638L,51096736814L,225648517165L,951032245643L,3840801817887L,14914920467311L,55860582248737L,202312954584987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201620Inst : IEnumerable<long>
{
public static readonly long[] Value=A201620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201620.Bytes);
public long this[int i]=>Value[i];

public static A201620Inst Instance=new A201620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201621
{
public static readonly long[] Value={ 10L,211L,3699L,91223L,2111763L,45733593L,891142897L,15644678596L,249289360661L,3639136663173L,49094967861596L,616937242119695L,7271050760251026L,80851029109219123L,852557302953238048L,8562810135696296292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201621Inst : IEnumerable<long>
{
public static readonly long[] Value=A201621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201621.Bytes);
public long this[int i]=>Value[i];

public static A201621Inst Instance=new A201621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201622
{
public static readonly BigInteger[] Value={ 16L,718L,31802L,2111763L,136175057L,8368969235L,464328365996L,23135668030252L,1040850319379231L,42653434489979374L,1606362705401822170L,BigInteger.Parse("56058651943376958129"),BigInteger.Parse("1826011093775518985924"),BigInteger.Parse("55867244848599391254270") };
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
public class A201622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201622Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201622.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201622Inst Instance=new A201622Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201623
{
public static readonly BigInteger[] Value={ 26L,2271L,256836L,45733593L,8368969235L,1492809994673L,242036871702096L,35298906093734951L,4642502137893927659L,BigInteger.Parse("554913226364951538300"),BigInteger.Parse("60802653561518861509758"),BigInteger.Parse("6157866184324500142914732") };
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
public class A201623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201623Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201623.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201623Inst Instance=new A201623Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201624
{
public static readonly long[] Value={ 40L,6654L,1877283L,891142897L,464328365996L,242036871702096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201624Inst : IEnumerable<long>
{
public static readonly long[] Value=A201624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201624.Bytes);
public long this[int i]=>Value[i];

public static A201624Inst Instance=new A201624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201625
{
public static readonly long[] Value={ 0L,4L,4L,4L,16L,4L,10L,56L,56L,10L,16L,211L,378L,211L,16L,26L,718L,3699L,3699L,718L,26L,40L,2271L,31802L,91223L,31802L,2271L,40L,59L,6654L,256836L,2111763L,2111763L,256836L,6654L,59L,84L,18191L,1877283L,45733593L,136175057L,45733593L,1877283L,18191L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201625Inst : IEnumerable<long>
{
public static readonly long[] Value=A201625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201625.Bytes);
public long this[int i]=>Value[i];

public static A201625Inst Instance=new A201625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201626
{
public static readonly BigInteger[] Value={ 1L,2L,6L,228L,6745L,252792L,11281312L,585632520L,34690541994L,2309813476870L,170797663069044L,13888215374348892L,1231730727253607451L,BigInteger.Parse("118329596584708240732"),BigInteger.Parse("12241103359460777972760"),BigInteger.Parse("1356712722052907806912016") };
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
public class A201626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201626Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201626.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201626Inst Instance=new A201626Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201627
{
public static readonly BigInteger[] Value={ 1L,1L,4L,29L,312L,4481L,80768L,1754549L,44647040L,1303097665L,42923116032L,1575332861101L,63754405679104L,2820829737123841L,135469202252333056L,7018336152909163205L,BigInteger.Parse("390175030207597805568"),BigInteger.Parse("23169468447962190613121"),BigInteger.Parse("1463683656780476860989440"),BigInteger.Parse("98016257612539018485477821") };
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
public class A201627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201627Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201627.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201627Inst Instance=new A201627Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201628
{
public static readonly BigInteger[] Value={ 1L,1L,4L,31L,360L,5601L,109568L,2586151L,71555200L,2271961825L,81441188352L,3253620672303L,143361363439616L,6907049546879041L,361245668908466176L,BigInteger.Parse("20383791705206338807"),BigInteger.Parse("1234336634416972726272"),BigInteger.Parse("79843983527411321710401"),BigInteger.Parse("5494767253686351671459840"),BigInteger.Parse("400863405346004202504321343") };
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
public class A201628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201628Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201628.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201628Inst Instance=new A201628Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201629
{
public static readonly long[] Value={ 0L,0L,2L,4L,4L,4L,6L,8L,8L,8L,10L,12L,12L,12L,14L,16L,16L,16L,18L,20L,20L,20L,22L,24L,24L,24L,26L,28L,28L,28L,30L,32L,32L,32L,34L,36L,36L,36L,38L,40L,40L,40L,42L,44L,44L,44L,46L,48L,48L,48L,50L,52L,52L,52L,54L,56L,56L,56L,58L,60L,60L,60L,62L,64L,64L,64L,66L,68L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201629Inst : IEnumerable<long>
{
public static readonly long[] Value=A201629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201629.Bytes);
public long this[int i]=>Value[i];

public static A201629Inst Instance=new A201629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201630
{
public static readonly long[] Value={ 2L,7L,11L,25L,47L,97L,191L,385L,767L,1537L,3071L,6145L,12287L,24577L,49151L,98305L,196607L,393217L,786431L,1572865L,3145727L,6291457L,12582911L,25165825L,50331647L,100663297L,201326591L,402653185L,805306367L,1610612737L,3221225471L,6442450945L,12884901887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201630Inst : IEnumerable<long>
{
public static readonly long[] Value=A201630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201630.Bytes);
public long this[int i]=>Value[i];

public static A201630Inst Instance=new A201630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201631
{
public static readonly long[] Value={ 1L,3L,6L,13L,30L,70L,167L,405L,992L,2450L,6090L,15214L,38165L,96069L,242530L,613811L,1556856L,3956316L,10070871L,25674210L,65541142L,167517654L,428635032L,1097874434L,2814611701L,7221917871L,18544968768L,47655572191L,122544150258L,315313433594L,811792614547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201631Inst : IEnumerable<long>
{
public static readonly long[] Value=A201631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201631.Bytes);
public long this[int i]=>Value[i];

public static A201631Inst Instance=new A201631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201632
{
public static readonly long[] Value={ 35L,83L,1203L,2835L,40883L,96323L,1388835L,3272163L,47179523L,111157235L,1602714963L,3776073843L,54445129235L,128275353443L,1849531679043L,4357585943235L,62829631958243L,148029646716563L,2134357954901235L,5028650402419923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201632Inst : IEnumerable<long>
{
public static readonly long[] Value=A201632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201632.Bytes);
public long this[int i]=>Value[i];

public static A201632Inst Instance=new A201632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201633
{
public static readonly long[] Value={ 11L,28L,424L,1001L,14453L,34054L,491026L,1156883L,16680479L,39300016L,566645308L,1335043709L,19249260041L,45352186138L,653908196134L,1540639285031L,22213629408563L,52336383504964L,754609491695056L,1777896399883793L,25634509088223389L,60396141212544046L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201633Inst : IEnumerable<long>
{
public static readonly long[] Value=A201633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201633.Bytes);
public long this[int i]=>Value[i];

public static A201633Inst Instance=new A201633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201634
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,4L,1L,4L,8L,8L,1L,5L,13L,21L,16L,1L,6L,19L,40L,56L,32L,1L,7L,26L,66L,122L,154L,64L,1L,8L,34L,100L,222L,376L,440L,128L,1L,9L,43L,143L,365L,741L,1181L,1309L,256L,1L,10L,53L,196L,561L,1302L,2483L,3792L,4048L,512L,1L,11L,64L,260L,821L,2123L,4606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201634Inst : IEnumerable<long>
{
public static readonly long[] Value=A201634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201634.Bytes);
public long this[int i]=>Value[i];

public static A201634Inst Instance=new A201634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201635
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,2L,1L,2L,4L,6L,1L,3L,7L,13L,22L,1L,4L,11L,24L,46L,80L,1L,5L,16L,40L,86L,166L,296L,1L,6L,22L,62L,148L,314L,610L,1106L,1L,7L,29L,91L,239L,553L,1163L,2269L,4166L,1L,8L,37L,128L,367L,920L,2083L,4352L,8518L,15792L,1L,9L,46L,174L,541L,1461L,3544L,7896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201635Inst : IEnumerable<long>
{
public static readonly long[] Value=A201635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201635.Bytes);
public long this[int i]=>Value[i];

public static A201635Inst Instance=new A201635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201636
{
public static readonly long[] Value={ 1L,0L,1L,0L,4L,3L,0L,24L,40L,15L,0L,192L,520L,420L,105L,0L,1920L,7392L,9520L,5040L,945L,0L,23040L,116928L,211456L,176400L,69300L,10395L,0L,322560L,2055168L,4858560L,5642560L,3465000L,1081080L,135135L,0L,5160960L,39896064L,117722880L,177580480L,150870720L,73153080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201636Inst : IEnumerable<long>
{
public static readonly long[] Value=A201636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201636.Bytes);
public long this[int i]=>Value[i];

public static A201636Inst Instance=new A201636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201637
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,0L,1L,8L,6L,0L,1L,22L,58L,24L,0L,1L,52L,328L,444L,120L,0L,1L,114L,1452L,4400L,3708L,720L,0L,1L,240L,5610L,32120L,58140L,33984L,5040L,0L,1L,494L,19950L,195800L,644020L,785304L,341136L,40320L,0L,1L,1004L,67260L,1062500L,5765500L,12440064L,11026296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201637Inst : IEnumerable<long>
{
public static readonly long[] Value=A201637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201637.Bytes);
public long this[int i]=>Value[i];

public static A201637Inst Instance=new A201637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201638
{
public static readonly long[] Value={ 1L,3L,1L,12L,6L,1L,54L,33L,9L,1L,261L,180L,63L,12L,1L,1323L,990L,405L,102L,15L,1L,6939L,5508L,2511L,756L,150L,18L,1L,37341L,30996L,15309L,5229L,1260L,207L,21L,1L,205011L,176256L,92610L,34776L,9630L,1944L,273L,24L,1L,1143801L,1011609L,558414L,225828L,69498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201638Inst : IEnumerable<long>
{
public static readonly long[] Value=A201638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201638.Bytes);
public long this[int i]=>Value[i];

public static A201638Inst Instance=new A201638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201639
{
public static readonly long[] Value={ 1L,4L,1L,20L,8L,1L,112L,56L,12L,1L,672L,384L,108L,16L,1L,4224L,2640L,880L,176L,20L,1L,27456L,18304L,6864L,1664L,260L,24L,1L,183040L,128128L,52416L,14560L,2800L,360L,28L,1L,1244672L,905216L,396032L,121856L,27200L,4352L,476L,32L,1L,8599552L,6449664L,2976768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201639Inst : IEnumerable<long>
{
public static readonly long[] Value=A201639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201639.Bytes);
public long this[int i]=>Value[i];

public static A201639Inst Instance=new A201639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201640
{
public static readonly long[] Value={ 1L,8L,54L,368L,2550L,17952L,128086L,924128L,6729858L,49395440L,364979560L,2712343680L,20257516240L,151957919232L,1144281700110L,8646263301056L,65531851263978L,498047725561104L,3794627850238756L,28976634967413920L,221728252767064596L,1699859618636556608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201640Inst : IEnumerable<long>
{
public static readonly long[] Value=A201640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201640.Bytes);
public long this[int i]=>Value[i];

public static A201640Inst Instance=new A201640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201641
{
public static readonly long[] Value={ 1L,2L,1L,8L,4L,1L,32L,20L,6L,1L,144L,96L,36L,8L,1L,672L,480L,200L,56L,10L,1L,3264L,2432L,1104L,352L,80L,12L,1L,16256L,12544L,6048L,2128L,560L,108L,14L,1L,82688L,65536L,33152L,12544L,3680L,832L,140L,16L,1L,427520L,346368L,182016L,72960L,23232L,5904L,1176L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201641Inst : IEnumerable<long>
{
public static readonly long[] Value=A201641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201641.Bytes);
public long this[int i]=>Value[i];

public static A201641Inst Instance=new A201641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201642
{
public static readonly BigInteger[] Value={ 1L,12L,1211L,121121L,121121221L,12112122122112L,BigInteger.Parse("1211212212211211221211"),BigInteger.Parse("121121221221121122121121221121121"),BigInteger.Parse("1211212212211211221211212211211212212211212212112"),BigInteger.Parse("12112122122112112212112122112112122122112122121121122122112122122112112122") };
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
public class A201642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201642Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201642.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201642Inst Instance=new A201642Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201643
{
public static readonly long[] Value={ 3L,5L,7L,9L,15L,21L,27L,35L,63L,105L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201643Inst : IEnumerable<long>
{
public static readonly long[] Value=A201643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201643.Bytes);
public long this[int i]=>Value[i];

public static A201643Inst Instance=new A201643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201644
{
public static readonly long[] Value={ 3L,5L,7L,9L,11L,15L,35L,45L,231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201644Inst : IEnumerable<long>
{
public static readonly long[] Value=A201644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201644.Bytes);
public long this[int i]=>Value[i];

public static A201644Inst Instance=new A201644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201645
{
public static readonly long[] Value={ 1L,1L,1L,3L,7L,11L,21L,53L,113L,211L,451L,1049L,2223L,4517L,9881L,22203L,47531L,100531L,220933L,489737L,1059137L,2284401L,5025959L,11088703L,24161133L,52644061L,115913011L,255469863L,559494883L,1226060651L,2702052381L,5957474213L,13092891293L,28792397139L,63518607791L,140165690233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201645Inst : IEnumerable<long>
{
public static readonly long[] Value=A201645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201645.Bytes);
public long this[int i]=>Value[i];

public static A201645Inst Instance=new A201645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201646
{
public static readonly long[] Value={ 3L,5L,7L,9L,11L,15L,21L,135L,10395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201646Inst : IEnumerable<long>
{
public static readonly long[] Value=A201646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201646.Bytes);
public long this[int i]=>Value[i];

public static A201646Inst Instance=new A201646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201647
{
public static readonly long[] Value={ 3L,5L,7L,9L,11L,15L,21L,165L,693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201647Inst : IEnumerable<long>
{
public static readonly long[] Value=A201647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201647.Bytes);
public long this[int i]=>Value[i];

public static A201647Inst Instance=new A201647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201648
{
public static readonly long[] Value={ 3L,5L,7L,9L,11L,15L,21L,231L,315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201648Inst : IEnumerable<long>
{
public static readonly long[] Value=A201648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201648.Bytes);
public long this[int i]=>Value[i];

public static A201648Inst Instance=new A201648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201649
{
public static readonly long[] Value={ 3L,5L,7L,9L,11L,15L,33L,45L,385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201649Inst : IEnumerable<long>
{
public static readonly long[] Value=A201649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201649.Bytes);
public long this[int i]=>Value[i];

public static A201649Inst Instance=new A201649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201650
{
public static readonly long[] Value={ 6L,10L,14L,15L,21L,22L,26L,33L,34L,35L,38L,39L,46L,51L,55L,57L,58L,62L,65L,69L,77L,82L,85L,86L,87L,91L,93L,95L,115L,119L,123L,133L,155L,187L,203L,209L,215L,221L,247L,265L,287L,299L,319L,323L,391L,689L,731L,901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201650Inst : IEnumerable<long>
{
public static readonly long[] Value=A201650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201650.Bytes);
public long this[int i]=>Value[i];

public static A201650Inst Instance=new A201650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201651
{
public static readonly long[] Value={ 0L,1L,4L,2L,3L,8L,3L,6L,9L,12L,4L,5L,6L,7L,16L,5L,16L,7L,18L,17L,20L,6L,7L,12L,13L,18L,19L,24L,7L,18L,13L,24L,19L,22L,25L,28L,8L,9L,10L,11L,12L,13L,14L,15L,32L,9L,12L,11L,14L,13L,24L,15L,26L,33L,36L,10L,11L,32L,33L,14L,15L,36L,37L,34L,35L,40L,11L,14L,33L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201651Inst : IEnumerable<long>
{
public static readonly long[] Value=A201651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201651.Bytes);
public long this[int i]=>Value[i];

public static A201651Inst Instance=new A201651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201652
{
public static readonly long[] Value={ 0L,1L,0L,2L,3L,5L,2L,6L,9L,2L,7L,9L,10L,8L,15L,16L,15L,10L,14L,17L,16L,20L,23L,27L,23L,24L,32L,31L,33L,20L,34L,33L,36L,45L,34L,35L,42L,46L,45L,50L,45L,40L,49L,51L,44L,44L,54L,54L,53L,63L,58L,63L,56L,67L,68L,75L,58L,71L,73L,72L,73L,68L,78L,79L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201652Inst : IEnumerable<long>
{
public static readonly long[] Value=A201652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201652.Bytes);
public long this[int i]=>Value[i];

public static A201652Inst Instance=new A201652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201653
{
public static readonly long[] Value={ 3L,1L,2L,4L,5L,1L,9L,9L,1L,2L,5L,0L,1L,3L,8L,7L,6L,9L,3L,9L,6L,8L,8L,0L,1L,9L,6L,5L,0L,1L,1L,6L,2L,4L,9L,9L,4L,1L,4L,4L,8L,7L,8L,6L,3L,8L,0L,3L,1L,2L,5L,4L,7L,4L,3L,5L,3L,6L,7L,5L,6L,7L,1L,9L,1L,1L,5L,1L,2L,3L,6L,6L,8L,1L,2L,3L,6L,1L,2L,8L,1L,1L,4L,9L,6L,9L,6L,4L,8L,0L,0L,1L,1L,1L,0L,0L,4L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201653Inst : IEnumerable<long>
{
public static readonly long[] Value=A201653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201653.Bytes);
public long this[int i]=>Value[i];

public static A201653Inst Instance=new A201653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201654
{
public static readonly long[] Value={ 5L,3L,1L,0L,9L,3L,7L,8L,3L,2L,2L,8L,7L,7L,5L,5L,6L,9L,5L,4L,2L,4L,5L,4L,2L,6L,2L,8L,7L,2L,7L,2L,8L,7L,8L,8L,1L,2L,7L,0L,9L,7L,3L,8L,1L,6L,4L,0L,0L,6L,1L,0L,9L,0L,6L,3L,7L,8L,1L,0L,4L,1L,5L,3L,4L,8L,0L,6L,2L,2L,0L,8L,4L,6L,0L,4L,4L,8L,5L,0L,5L,1L,0L,5L,1L,5L,6L,1L,0L,9L,2L,0L,6L,1L,2L,7L,1L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201654Inst : IEnumerable<long>
{
public static readonly long[] Value=A201654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201654.Bytes);
public long this[int i]=>Value[i];

public static A201654Inst Instance=new A201654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201655
{
public static readonly long[] Value={ 3L,1L,2L,6L,9L,8L,2L,1L,0L,1L,7L,1L,4L,1L,9L,1L,0L,1L,6L,0L,1L,3L,9L,3L,9L,9L,9L,2L,7L,3L,0L,1L,6L,3L,7L,1L,7L,9L,8L,9L,7L,9L,7L,5L,8L,0L,5L,9L,7L,5L,5L,5L,6L,2L,5L,6L,1L,1L,3L,4L,3L,6L,3L,8L,0L,1L,0L,7L,5L,2L,7L,1L,7L,5L,3L,0L,4L,3L,9L,4L,9L,2L,1L,5L,2L,4L,6L,1L,1L,6L,8L,1L,9L,2L,6L,7L,8L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201655Inst : IEnumerable<long>
{
public static readonly long[] Value=A201655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201655.Bytes);
public long this[int i]=>Value[i];

public static A201655Inst Instance=new A201655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201656
{
public static readonly long[] Value={ 5L,0L,7L,2L,6L,2L,1L,9L,9L,3L,4L,9L,1L,0L,3L,7L,7L,8L,2L,6L,5L,8L,1L,2L,1L,4L,7L,7L,2L,6L,4L,0L,4L,1L,9L,7L,6L,3L,8L,5L,8L,6L,3L,1L,5L,1L,4L,1L,8L,5L,6L,3L,4L,8L,1L,6L,0L,9L,3L,5L,5L,8L,2L,8L,6L,9L,5L,1L,8L,0L,6L,5L,0L,1L,7L,6L,0L,7L,2L,3L,7L,3L,1L,3L,4L,4L,3L,8L,5L,7L,9L,3L,3L,9L,6L,1L,2L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201656Inst : IEnumerable<long>
{
public static readonly long[] Value=A201656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201656.Bytes);
public long this[int i]=>Value[i];

public static A201656Inst Instance=new A201656Inst();

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