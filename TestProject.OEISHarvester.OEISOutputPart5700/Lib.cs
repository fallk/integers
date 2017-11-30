using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A193783
{
public static readonly BigInteger[] Value={ 5L,32L,172L,2836L,91416L,5932132L,772063340L,201054032608L,104742810130844L,109165192335096960L,BigInteger.Parse("227605696416524730032"),BigInteger.Parse("949334416935490848158628"),BigInteger.Parse("7921224347549868400719029840"),BigInteger.Parse("132221576468713050783073932552152") };
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
public class A193783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193783Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193783.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193783Inst Instance=new A193783Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193782
{
public static readonly BigInteger[] Value={ 4L,17L,77L,1099L,33151L,2100065L,268468949L,68719995395L,35184382602599L,36028797316842905L,BigInteger.Parse("73786976306927999773"),BigInteger.Parse("302231454904310883795947"),BigInteger.Parse("2475880078570809183639151007"),BigInteger.Parse("40564819207303345898201553712849") };
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
public class A193782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193782Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193782.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193782Inst Instance=new A193782Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193781
{
public static readonly long[] Value={ 8L,8L,9L,4L,4L,9L,6L,8L,1L,5L,7L,0L,1L,3L,1L,0L,2L,4L,9L,3L,5L,7L,7L,8L,3L,1L,1L,5L,0L,8L,0L,9L,0L,4L,4L,6L,0L,2L,8L,9L,6L,1L,2L,9L,2L,4L,6L,2L,7L,1L,8L,1L,5L,4L,2L,5L,1L,0L,3L,2L,2L,8L,6L,0L,4L,7L,8L,7L,8L,3L,1L,4L,0L,6L,3L,8L,6L,2L,9L,3L,4L,6L,2L,6L,6L,7L,6L,6L,1L,4L,0L,3L,1L,9L,7L,7L,3L,5L,9L,7L,0L,8L,1L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193781Inst : IEnumerable<long>
{
public static readonly long[] Value=A193781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193781.Bytes);
public long this[int i]=>Value[i];

public static A193781Inst Instance=new A193781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193780
{
public static readonly long[] Value={ 6L,2L,5L,8L,5L,6L,9L,2L,3L,7L,0L,5L,0L,2L,2L,7L,5L,7L,7L,7L,3L,0L,2L,9L,5L,2L,3L,6L,6L,5L,0L,9L,0L,5L,3L,9L,5L,2L,4L,6L,8L,7L,5L,4L,0L,2L,6L,7L,0L,0L,5L,0L,9L,3L,1L,2L,5L,9L,4L,8L,4L,4L,4L,2L,5L,5L,2L,7L,0L,8L,7L,4L,7L,7L,6L,2L,3L,3L,3L,5L,0L,4L,3L,3L,3L,7L,2L,6L,1L,2L,3L,2L,8L,9L,8L,4L,4L,6L,3L,0L,4L,5L,8L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193780Inst : IEnumerable<long>
{
public static readonly long[] Value=A193780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193780.Bytes);
public long this[int i]=>Value[i];

public static A193780Inst Instance=new A193780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193779
{
public static readonly long[] Value={ 1L,-1L,-1L,1L,-1L,1L,1L,-2L,0L,2L,0L,-1L,1L,-2L,-1L,5L,-3L,-2L,5L,-4L,1L,4L,-7L,0L,6L,-3L,-3L,6L,-6L,-2L,15L,-12L,-6L,15L,-12L,3L,15L,-20L,-2L,20L,-11L,-7L,19L,-20L,-7L,40L,-29L,-14L,40L,-34L,3L,40L,-48L,-5L,52L,-33L,-17L,52L,-50L,-14L,93L,-74L,-32L,97L,-80L,3L,99L,-112L,-15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193779Inst : IEnumerable<long>
{
public static readonly long[] Value=A193779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193779.Bytes);
public long this[int i]=>Value[i];

public static A193779Inst Instance=new A193779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193778
{
public static readonly long[] Value={ 1L,2L,8L,32L,160L,832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193778Inst : IEnumerable<long>
{
public static readonly long[] Value=A193778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193778.Bytes);
public long this[int i]=>Value[i];

public static A193778Inst Instance=new A193778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193777
{
public static readonly long[] Value={ 1L,2L,6L,18L,58L,190L,642L,2206L,7746L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193777Inst : IEnumerable<long>
{
public static readonly long[] Value=A193777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193777.Bytes);
public long this[int i]=>Value[i];

public static A193777Inst Instance=new A193777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193776
{
public static readonly long[] Value={ 1L,2L,3L,5L,12L,17L,65L,80L,473L,527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193776Inst : IEnumerable<long>
{
public static readonly long[] Value=A193776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193776.Bytes);
public long this[int i]=>Value[i];

public static A193776Inst Instance=new A193776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193775
{
public static readonly long[] Value={ 1L,2L,3L,4L,10L,12L,52L,58L,394L,418L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193775Inst : IEnumerable<long>
{
public static readonly long[] Value=A193775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193775.Bytes);
public long this[int i]=>Value[i];

public static A193775Inst Instance=new A193775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193774
{
public static readonly long[] Value={ 1L,2L,4L,6L,20L,26L,124L,146L,956L,1050L,9100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193774Inst : IEnumerable<long>
{
public static readonly long[] Value=A193774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193774.Bytes);
public long this[int i]=>Value[i];

public static A193774Inst Instance=new A193774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193773
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,2L,1L,1L,2L,2L,1L,2L,1L,1L,3L,1L,2L,2L,1L,2L,2L,1L,1L,3L,2L,1L,2L,1L,1L,3L,2L,1L,3L,1L,2L,2L,1L,2L,2L,2L,1L,3L,1L,1L,4L,1L,1L,2L,1L,2L,3L,2L,2L,2L,2L,1L,2L,1L,2L,4L,1L,1L,2L,2L,2L,3L,1L,1L,3L,2L,1L,2L,2L,1L,4L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193773Inst : IEnumerable<long>
{
public static readonly long[] Value=A193773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193773.Bytes);
public long this[int i]=>Value[i];

public static A193773Inst Instance=new A193773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193772
{
public static readonly long[] Value={ 0L,11L,22L,33L,44L,55L,66L,77L,88L,99L,101L,110L,202L,211L,220L,303L,312L,321L,330L,404L,413L,422L,431L,440L,505L,514L,523L,532L,541L,550L,606L,615L,624L,633L,642L,651L,660L,707L,716L,725L,734L,743L,752L,761L,770L,808L,817L,826L,835L,844L,853L,862L,871L,880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193772Inst : IEnumerable<long>
{
public static readonly long[] Value=A193772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193772.Bytes);
public long this[int i]=>Value[i];

public static A193772Inst Instance=new A193772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193723
{
public static readonly long[] Value={ 1L,2L,1L,6L,5L,1L,18L,21L,8L,1L,54L,81L,45L,11L,1L,162L,297L,216L,78L,14L,1L,486L,1053L,945L,450L,120L,17L,1L,1458L,3645L,3888L,2295L,810L,171L,20L,1L,4374L,12393L,15309L,10773L,4725L,1323L,231L,23L,1L,13122L,41553L,58320L,47628L,24948L,8694L,2016L,300L,26L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193723Inst : IEnumerable<long>
{
public static readonly long[] Value=A193723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193723.Bytes);
public long this[int i]=>Value[i];

public static A193723Inst Instance=new A193723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193722
{
public static readonly long[] Value={ 1L,1L,2L,1L,5L,6L,1L,8L,21L,18L,1L,11L,45L,81L,54L,1L,14L,78L,216L,297L,162L,1L,17L,120L,450L,945L,1053L,486L,1L,20L,171L,810L,2295L,3888L,3645L,1458L,1L,23L,231L,1323L,4725L,10773L,15309L,12393L,4374L,1L,26L,300L,2016L,8694L,24948L,47628L,58320L,41553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193722Inst : IEnumerable<long>
{
public static readonly long[] Value=A193722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193722.Bytes);
public long this[int i]=>Value[i];

public static A193722Inst Instance=new A193722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193721
{
public static readonly long[] Value={ 5L,5L,4L,1L,0L,0L,2L,7L,7L,0L,7L,4L,1L,5L,4L,2L,9L,5L,7L,0L,4L,4L,5L,0L,0L,8L,1L,6L,3L,9L,4L,9L,2L,5L,7L,4L,0L,1L,0L,2L,5L,5L,2L,7L,0L,7L,6L,6L,3L,3L,2L,7L,8L,1L,1L,3L,1L,8L,5L,8L,1L,5L,6L,4L,9L,8L,1L,1L,7L,8L,2L,4L,3L,9L,7L,8L,6L,4L,2L,4L,9L,6L,9L,1L,5L,1L,9L,8L,4L,6L,1L,6L,0L,6L,3L,4L,2L,1L,3L,0L,2L,8L,4L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193721Inst : IEnumerable<long>
{
public static readonly long[] Value=A193721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193721.Bytes);
public long this[int i]=>Value[i];

public static A193721Inst Instance=new A193721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193720
{
public static readonly long[] Value={ 3L,8L,7L,8L,5L,5L,4L,8L,5L,8L,7L,4L,1L,0L,5L,6L,1L,8L,1L,0L,6L,6L,0L,8L,0L,1L,0L,8L,2L,1L,8L,8L,5L,0L,6L,4L,9L,6L,3L,6L,4L,5L,7L,8L,4L,5L,6L,5L,8L,1L,1L,9L,1L,2L,1L,4L,8L,3L,7L,6L,3L,7L,8L,3L,0L,7L,0L,9L,2L,8L,9L,6L,0L,0L,1L,9L,7L,0L,1L,5L,1L,4L,7L,4L,0L,5L,2L,3L,9L,2L,5L,5L,5L,6L,3L,7L,2L,0L,2L,1L,7L,5L,9L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193720Inst : IEnumerable<long>
{
public static readonly long[] Value=A193720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193720.Bytes);
public long this[int i]=>Value[i];

public static A193720Inst Instance=new A193720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193719
{
public static readonly long[] Value={ 1L,1L,0L,1L,6L,5L,9L,0L,2L,6L,4L,5L,7L,5L,7L,4L,0L,9L,0L,4L,3L,0L,9L,3L,3L,8L,1L,1L,3L,7L,8L,0L,4L,3L,8L,3L,3L,6L,9L,5L,9L,2L,2L,6L,2L,1L,5L,7L,5L,1L,5L,5L,3L,1L,3L,9L,8L,5L,5L,7L,2L,6L,5L,6L,9L,7L,4L,9L,0L,1L,6L,0L,1L,9L,7L,4L,0L,5L,8L,5L,6L,8L,4L,6L,1L,8L,3L,9L,1L,4L,5L,8L,8L,9L,1L,7L,7L,1L,7L,4L,3L,4L,0L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193719Inst : IEnumerable<long>
{
public static readonly long[] Value=A193719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193719.Bytes);
public long this[int i]=>Value[i];

public static A193719Inst Instance=new A193719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193718
{
public static readonly long[] Value={ 1L,2L,5L,7L,14L,12L,25L,24L,40L,51L,96L,93L,111L,-5L,-206L,-530L,-736L,-591L,778L,3819L,9292L,16373L,23055L,23706L,10101L,-31727L,-120766L,-283232L,-548925L,-932041L,-1380126L,-1654576L,-1144753L,1386362L,7943163L,21084398L,42787784L,71815410L,98995079L,100388956L,29623770L,-187442482L,-648478235L,-1449118398L,-2615085854L,-3963369427L,-4855203952L,-3819950381L,1908741941L,16724652946L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193718Inst : IEnumerable<long>
{
public static readonly long[] Value=A193718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193718.Bytes);
public long this[int i]=>Value[i];

public static A193718Inst Instance=new A193718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193717
{
public static readonly long[] Value={ 1L,4L,0L,0L,2L,4L,1L,0L,1L,7L,0L,6L,8L,5L,2L,3L,1L,7L,1L,0L,0L,2L,7L,0L,5L,7L,8L,8L,7L,5L,5L,3L,5L,0L,7L,5L,3L,2L,2L,4L,2L,8L,2L,1L,2L,7L,8L,5L,7L,7L,0L,5L,0L,8L,9L,8L,8L,1L,8L,5L,9L,6L,3L,1L,4L,1L,1L,6L,2L,7L,7L,1L,4L,6L,3L,7L,0L,5L,9L,7L,0L,2L,3L,0L,4L,9L,0L,7L,6L,1L,1L,0L,2L,6L,6L,3L,0L,9L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193717Inst : IEnumerable<long>
{
public static readonly long[] Value=A193717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193717.Bytes);
public long this[int i]=>Value[i];

public static A193717Inst Instance=new A193717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193716
{
public static readonly long[] Value={ 1L,8L,7L,4L,2L,6L,4L,2L,2L,8L,2L,8L,2L,3L,1L,0L,8L,0L,2L,6L,4L,5L,6L,9L,3L,1L,2L,2L,7L,3L,2L,7L,5L,0L,8L,1L,2L,5L,3L,0L,6L,9L,0L,1L,1L,7L,7L,0L,3L,1L,1L,5L,5L,7L,0L,8L,1L,0L,3L,2L,6L,0L,8L,3L,8L,8L,1L,8L,0L,2L,3L,3L,3L,1L,0L,6L,2L,0L,2L,8L,4L,9L,7L,6L,4L,9L,9L,2L,3L,1L,0L,6L,0L,2L,4L,4L,5L,8L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193716Inst : IEnumerable<long>
{
public static readonly long[] Value=A193716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193716.Bytes);
public long this[int i]=>Value[i];

public static A193716Inst Instance=new A193716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193715
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,9L,11L,12L,13L,15L,17L,18L,20L,22L,23L,25L,27L,29L,30L,32L,34L,35L,37L,39L,41L,42L,44L,46L,47L,49L,51L,52L,54L,56L,58L,59L,61L,63L,64L,66L,68L,70L,71L,73L,75L,76L,78L,80L,81L,82L,84L,86L,87L,89L,91L,92L,94L,96L,98L,99L,101L,103L,104L,106L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193715Inst : IEnumerable<long>
{
public static readonly long[] Value=A193715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193715.Bytes);
public long this[int i]=>Value[i];

public static A193715Inst Instance=new A193715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193714
{
public static readonly long[] Value={ 1L,3L,5L,8L,10L,12L,14L,16L,19L,21L,24L,26L,28L,31L,33L,36L,38L,40L,43L,45L,48L,50L,53L,55L,57L,60L,62L,65L,67L,69L,72L,74L,77L,79L,81L,83L,85L,88L,90L,93L,95L,97L,100L,102L,105L,107L,109L,112L,114L,117L,119L,122L,124L,126L,129L,131L,134L,136L,138L,141L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193714Inst : IEnumerable<long>
{
public static readonly long[] Value=A193714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193714.Bytes);
public long this[int i]=>Value[i];

public static A193714Inst Instance=new A193714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193713
{
public static readonly long[] Value={ 2L,3L,3L,7L,6L,5L,0L,3L,6L,9L,8L,8L,7L,5L,6L,6L,6L,5L,6L,8L,6L,8L,1L,6L,2L,7L,8L,5L,0L,5L,4L,0L,2L,1L,9L,9L,3L,9L,4L,6L,7L,4L,1L,5L,0L,8L,9L,6L,4L,4L,6L,1L,7L,3L,3L,3L,9L,4L,7L,3L,3L,9L,4L,4L,8L,2L,5L,4L,0L,6L,1L,8L,9L,9L,0L,9L,5L,5L,1L,5L,7L,5L,9L,3L,3L,0L,6L,8L,4L,0L,6L,3L,9L,4L,8L,3L,0L,7L,6L,9L,4L,0L,5L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193713Inst : IEnumerable<long>
{
public static readonly long[] Value=A193713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193713.Bytes);
public long this[int i]=>Value[i];

public static A193713Inst Instance=new A193713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193712
{
public static readonly long[] Value={ 9L,4L,4L,0L,9L,3L,2L,8L,4L,0L,4L,0L,7L,6L,9L,7L,3L,1L,8L,0L,0L,8L,6L,8L,9L,4L,8L,3L,1L,3L,1L,3L,5L,7L,0L,5L,3L,7L,5L,3L,0L,7L,5L,9L,3L,1L,9L,9L,1L,6L,3L,3L,2L,4L,3L,9L,5L,7L,3L,8L,3L,1L,0L,7L,2L,1L,1L,3L,8L,6L,6L,3L,7L,5L,6L,6L,2L,5L,0L,8L,2L,9L,4L,6L,4L,1L,9L,6L,0L,5L,6L,6L,6L,4L,8L,9L,6L,7L,6L,6L,3L,6L,4L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193712Inst : IEnumerable<long>
{
public static readonly long[] Value=A193712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193712.Bytes);
public long this[int i]=>Value[i];

public static A193712Inst Instance=new A193712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193711
{
public static readonly long[] Value={ 1L,4L,8L,14L,23L,33L,48L,64L,85L,110L,138L,174L,219L,268L,323L,387L,453L,531L,612L,703L,803L,908L,1028L,1149L,1285L,1429L,1582L,1751L,1922L,2112L,2308L,2518L,2743L,2974L,3227L,3483L,3759L,4048L,4348L,4672L,4997L,5348L,5709L,6087L,6487L,6893L,7328L,7769L,8234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193711Inst : IEnumerable<long>
{
public static readonly long[] Value=A193711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193711.Bytes);
public long this[int i]=>Value[i];

public static A193711Inst Instance=new A193711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193710
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,9L,1L,7L,23L,27L,1L,9L,43L,119L,73L,1L,11L,69L,309L,489L,195L,1L,13L,101L,629L,1565L,1987L,515L,1L,15L,139L,1111L,3617L,8281L,8043L,1357L,1L,17L,183L,1787L,6961L,23293L,43977L,32599L,3585L,1L,19L,233L,2689L,11913L,52551L,150639L,233983L,132713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193710Inst : IEnumerable<long>
{
public static readonly long[] Value=A193710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193710.Bytes);
public long this[int i]=>Value[i];

public static A193710Inst Instance=new A193710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193709
{
public static readonly long[] Value={ 1L,15L,183L,2689L,18789L,182477L,1749091L,16567391L,152394383L,1433139483L,13442332537L,125848692733L,1177478188091L,11030361936285L,103297490194959L,967247732981943L,9057265482772319L,84816644335515109L,794242509585815241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193709Inst : IEnumerable<long>
{
public static readonly long[] Value=A193709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193709.Bytes);
public long this[int i]=>Value[i];

public static A193709Inst Instance=new A193709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193708
{
public static readonly long[] Value={ 1L,13L,139L,1787L,11913L,102895L,883493L,7534239L,62963491L,533335257L,4512230169L,38134861983L,322180217835L,2723529411351L,23020233823025L,194563962109999L,1644444704071007L,13899067616530479L,117475708664617727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193708Inst : IEnumerable<long>
{
public static readonly long[] Value=A193708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193708.Bytes);
public long this[int i]=>Value[i];

public static A193708Inst Instance=new A193708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193659
{
public static readonly long[] Value={ 1L,2L,8L,43L,265L,1832L,14160L,121771L,1157557L,12080436L,137505288L,1696841395L,22578385961L,322377704664L,4917809053032L,79840791037379L,1374705370985669L,25024307510421060L,480230285880218992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193659Inst : IEnumerable<long>
{
public static readonly long[] Value=A193659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193659.Bytes);
public long this[int i]=>Value[i];

public static A193659Inst Instance=new A193659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193658
{
public static readonly ulong[] Value={ 1L,1L,3L,15L,83L,503L,3403L,25807L,218451L,2049687L,21160667L,238690847L,2923054435L,38641535143L,548635554795L,8328494925615L,134634766604915L,2309386642312631L,41897258229334267L,801610384425038911L,16132033041827096451UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193658Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A193658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193658.Bytes);
public ulong this[int i]=>Value[i];

public static A193658Inst Instance=new A193658Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193657
{
public static readonly long[] Value={ 1L,2L,7L,31L,165L,1031L,7423L,60621L,554249L,5611771L,62353011L,754471433L,9876716941L,139097096919L,2097156230471L,33704296561141L,575219994643473L,10389911153247731L,198019483156015579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193657Inst : IEnumerable<long>
{
public static readonly long[] Value=A193657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193657.Bytes);
public long this[int i]=>Value[i];

public static A193657Inst Instance=new A193657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193656
{
public static readonly long[] Value={ 1L,7L,43L,247L,1363L,7327L,38683L,201607L,1040803L,5335087L,27199723L,138095767L,698867443L,3527891647L,17773675963L,89405250727L,449173737283L,2254458621007L,11306652843403L,56670703170487L,283903271666323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193656Inst : IEnumerable<long>
{
public static readonly long[] Value=A193656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193656.Bytes);
public long this[int i]=>Value[i];

public static A193656Inst Instance=new A193656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193655
{
public static readonly long[] Value={ 1L,7L,29L,94L,280L,765L,2023L,5116L,12710L,30715L,73381L,172026L,400036L,917497L,2091683L,4718584L,10594978L,23592951L,52341409L,115343350L,253405856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193655Inst : IEnumerable<long>
{
public static readonly long[] Value=A193655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193655.Bytes);
public long this[int i]=>Value[i];

public static A193655Inst Instance=new A193655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193654
{
public static readonly long[] Value={ 1L,7L,28L,94L,275L,765L,2002L,5116L,12625L,30715L,73040L,172026L,398671L,917497L,2086222L,4718584L,10573133L,23592951L,52254028L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193654Inst : IEnumerable<long>
{
public static readonly long[] Value=A193654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193654.Bytes);
public long this[int i]=>Value[i];

public static A193654Inst Instance=new A193654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193653
{
public static readonly long[] Value={ 1L,2L,6L,20L,70L,248L,882L,3140L,11182L,39824L,141834L,505148L,1799110L,6407624L,22821090L,81278516L,289477726L,1030990208L,3671926074L,13077758636L,46577128054L,165886901432L,590814960402L,2104218684068L,7494285973006L,26691295287152L,95062457807466L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193653Inst : IEnumerable<long>
{
public static readonly long[] Value=A193653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193653.Bytes);
public long this[int i]=>Value[i];

public static A193653Inst Instance=new A193653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193652
{
public static readonly long[] Value={ 0L,1L,2L,3L,10L,11L,42L,43L,170L,171L,682L,683L,2730L,2731L,10922L,10923L,43690L,43691L,174762L,174763L,699050L,699051L,2796202L,2796203L,11184810L,11184811L,44739242L,44739243L,178956970L,178956971L,715827882L,715827883L,2863311530L,2863311531L,11453246122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193652Inst : IEnumerable<long>
{
public static readonly long[] Value=A193652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193652.Bytes);
public long this[int i]=>Value[i];

public static A193652Inst Instance=new A193652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193651
{
public static readonly BigInteger[] Value={ 1L,2L,8L,53L,473L,5198L,67568L,1013513L,17229713L,327364538L,6874655288L,158117071613L,3952926790313L,106729023338438L,3095141676814688L,95949391981255313L,3166329935381425313L,BigInteger.Parse("110821547738349885938"),BigInteger.Parse("4100397266318945779688") };
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
public class A193651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193651Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193651.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193651Inst Instance=new A193651Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193650
{
public static readonly long[] Value={ 1L,0L,3L,7L,10L,31L,24L,127L,136L,292L,352L,2047L,1664L,8191L,5504L,9664L,32896L,131071L,116736L,524287L,419840L,603904L,1398784L,8388607L,7897088L,17318416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193650Inst : IEnumerable<long>
{
public static readonly long[] Value=A193650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193650.Bytes);
public long this[int i]=>Value[i];

public static A193650Inst Instance=new A193650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193649
{
public static readonly long[] Value={ 1L,1L,3L,5L,15L,33L,91L,221L,583L,1465L,3795L,9653L,24831L,63441L,162763L,416525L,1067575L,2733673L,7003971L,17938661L,45954543L,117709185L,301527355L,772364093L,1978473511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193649Inst : IEnumerable<long>
{
public static readonly long[] Value=A193649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193649.Bytes);
public long this[int i]=>Value[i];

public static A193649Inst Instance=new A193649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193648
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,7L,1L,7L,13L,15L,1L,9L,19L,37L,33L,1L,11L,25L,67L,105L,73L,1L,13L,31L,105L,217L,297L,161L,1L,15L,37L,151L,369L,721L,841L,355L,1L,17L,43L,205L,561L,1393L,2377L,2381L,783L,1L,19L,49L,267L,793L,2361L,5105L,7855L,6741L,1727L,1L,21L,55L,337L,1065L,3673L,9361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193648Inst : IEnumerable<long>
{
public static readonly long[] Value=A193648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193648.Bytes);
public long this[int i]=>Value[i];

public static A193648Inst Instance=new A193648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193647
{
public static readonly long[] Value={ 1L,15L,43L,267L,1065L,5377L,23801L,113191L,517371L,2416835L,11155313L,51830017L,239940625L,1112996767L,5157111051L,23910123931L,110818577241L,513715752705L,2381164556233L,11037736722167L,51163163871835L,237160332965907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193647Inst : IEnumerable<long>
{
public static readonly long[] Value=A193647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193647.Bytes);
public long this[int i]=>Value[i];

public static A193647Inst Instance=new A193647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193646
{
public static readonly long[] Value={ 1L,13L,37L,205L,793L,3673L,15481L,68485L,295453L,1291237L,5605489L,24418801L,106183729L,462160957L,2010578005L,8748949309L,38065839625L,165631750345L,720670846249L,3135725035573L,13643790283981L,59365501769941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193646Inst : IEnumerable<long>
{
public static readonly long[] Value=A193646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193646.Bytes);
public long this[int i]=>Value[i];

public static A193646Inst Instance=new A193646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193645
{
public static readonly long[] Value={ 1L,11L,31L,151L,561L,2361L,9361L,38171L,153591L,621911L,2510721L,10150321L,41008321L,165729931L,669676751L,2706201271L,10935546481L,44190379881L,178571332881L,721601251291L,2915963545511L,11783308434231L,47615926483841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193645Inst : IEnumerable<long>
{
public static readonly long[] Value=A193645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193645.Bytes);
public long this[int i]=>Value[i];

public static A193645Inst Instance=new A193645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193644
{
public static readonly long[] Value={ 1L,9L,25L,105L,369L,1393L,5105L,18937L,69897L,258521L,955361L,3531745L,13054177L,48254185L,178365177L,659309641L,2437064529L,9008352081L,33298400977L,123083978969L,454966715881L,1681735706553L,6216355687361L,22978092329921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193644Inst : IEnumerable<long>
{
public static readonly long[] Value=A193644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193644.Bytes);
public long this[int i]=>Value[i];

public static A193644Inst Instance=new A193644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193387
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,7L,6L,1L,1L,15L,26L,10L,1L,1L,31L,100L,69L,15L,1L,1L,63L,366L,412L,150L,21L,1L,1L,127L,1317L,2305L,1270L,286L,28L,1L,1L,255L,4743L,12551L,9920L,3236L,497L,36L,1L,1L,511L,17275L,67933L,74525L,33301L,7210L,806L,45L,1L,1L,1023L,64029L,370168L,551232L,325860L,93926L,14540L,1239L,55L,1L,1L,2047L,242371L,2046980L,4072130L,3109628L,1151416L,232891L,27147L,1825L,66L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193387Inst : IEnumerable<long>
{
public static readonly long[] Value=A193387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193387.Bytes);
public long this[int i]=>Value[i];

public static A193387Inst Instance=new A193387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193386
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,2L,2L,2L,2L,2L,2L,4L,2L,3L,3L,4L,2L,3L,3L,4L,2L,2L,3L,4L,4L,3L,4L,4L,3L,4L,4L,4L,4L,6L,4L,6L,3L,6L,4L,6L,4L,4L,4L,6L,2L,2L,4L,4L,4L,5L,6L,4L,3L,6L,6L,6L,4L,2L,4L,8L,4L,6L,5L,8L,4L,4L,5L,4L,6L,4L,6L,9L,6L,6L,6L,8L,6L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193386Inst : IEnumerable<long>
{
public static readonly long[] Value=A193386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193386.Bytes);
public long this[int i]=>Value[i];

public static A193386Inst Instance=new A193386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193385
{
public static readonly long[] Value={ 1L,1L,2L,6L,27L,135L,810L,5670L,45465L,409185L,4091850L,45010350L,540134595L,7021749735L,98304496290L,1474567444350L,23593081136625L,401082379322625L,7219482827807250L,137170173728337750L,2743403475221484075L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193385Inst : IEnumerable<long>
{
public static readonly long[] Value=A193385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193385.Bytes);
public long this[int i]=>Value[i];

public static A193385Inst Instance=new A193385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193384
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,4L,8L,9L,18L,36L,72L,100L,200L,400L,800L,1225L,2450L,4900L,9800L,15876L,31752L,63504L,127008L,213444L,426888L,853776L,1707552L,2944656L,5889312L,11778624L,23557248L,41409225L,82818450L,165636900L,331273800L,590976100L,1181952200L,2363904400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193384Inst : IEnumerable<long>
{
public static readonly long[] Value=A193384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193384.Bytes);
public long this[int i]=>Value[i];

public static A193384Inst Instance=new A193384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193383
{
public static readonly long[] Value={ -1L,-1L,0L,1L,2L,2L,0L,-3L,-6L,-6L,0L,10L,20L,20L,0L,-35L,-70L,-70L,0L,126L,252L,252L,0L,-462L,-924L,-924L,0L,1716L,3432L,3432L,0L,-6435L,-12870L,-12870L,0L,24310L,48620L,48620L,0L,-92378L,-184756L,-184756L,0L,352716L,705432L,705432L,0L,-1352078L,-2704156L,-2704156L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193383Inst : IEnumerable<long>
{
public static readonly long[] Value=A193383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193383.Bytes);
public long this[int i]=>Value[i];

public static A193383Inst Instance=new A193383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193382
{
public static readonly long[] Value={ 1L,1L,0L,-1L,-1L,-1L,0L,2L,3L,3L,0L,-6L,-10L,-10L,0L,20L,35L,35L,0L,-70L,-126L,-126L,0L,252L,462L,462L,0L,-924L,-1716L,-1716L,0L,3432L,6435L,6435L,0L,-12870L,-24310L,-24310L,0L,48620L,92378L,92378L,0L,-184756L,-352716L,-352716L,0L,705432L,1352078L,1352078L,0L,-2704156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193382Inst : IEnumerable<long>
{
public static readonly long[] Value=A193382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193382.Bytes);
public long this[int i]=>Value[i];

public static A193382Inst Instance=new A193382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193381
{
public static readonly BigInteger[] Value={ 0L,12L,543L,9876L,1413121110L,201918171516L,27262524212322L,3534333231302928L,444342414039383736L,BigInteger.Parse("54535251494847464550"),BigInteger.Parse("6564636261605958575655"),BigInteger.Parse("777675747372717069676668"),BigInteger.Parse("90898887868584838281798078"),BigInteger.Parse("999897969594939291104103101102100") };
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
public class A193381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193381Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193381.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193381Inst Instance=new A193381Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193380
{
public static readonly BigInteger[] Value={ 1L,16L,218L,24277L,282624223L,35336530286L,4038946460332L,454417916411629L,50493713793377093L,5554535251494847465L,BigInteger.Parse("605967851146914507796"),BigInteger.Parse("65648063122810597558064"),BigInteger.Parse("7069922221437372952524460"),BigInteger.Parse("714212835424956578936007364364293") };
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
public class A193380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193380Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193380.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193380Inst Instance=new A193380Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193379
{
public static readonly long[] Value={ 1L,1L,4L,17L,20L,212L,464L,4361L,17812L,60532L,123088L,4117252L,29724752L,84585040L,430795584L,8219554697L,47479991380L,214977407060L,898098431312L,16268050731620L,98128441675472L,417822285118032L,1654860158000960L,35730391312348996L,243329575991962320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193379Inst : IEnumerable<long>
{
public static readonly long[] Value=A193379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193379.Bytes);
public long this[int i]=>Value[i];

public static A193379Inst Instance=new A193379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193378
{
public static readonly long[] Value={ 2L,-4L,2L,-4L,-20L,56L,-126L,-4L,308L,-696L,5444L,7224L,-7272L,-14224L,-191022L,-450404L,39524L,2309416L,5059084L,20045736L,18158632L,-170205936L,-18475212L,-725028200L,-1746739960L,9540210896L,-10852826168L,16441084912L,107790254896L,-422324078368L,1055213939634L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193378Inst : IEnumerable<long>
{
public static readonly long[] Value=A193378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193378.Bytes);
public long this[int i]=>Value[i];

public static A193378Inst Instance=new A193378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193377
{
public static readonly long[] Value={ 1L,1L,0L,-1L,-4L,-14L,8L,35L,44L,246L,168L,-1906L,296L,-5692L,-19440L,89539L,-104836L,110062L,946856L,-3306758L,8516696L,3998844L,-36402256L,82221230L,-492938376L,-657397540L,1092399120L,553666748L,22487269712L,48307873544L,-8248804576L,-259354056349L,-754908556068L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193377Inst : IEnumerable<long>
{
public static readonly long[] Value=A193377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193377.Bytes);
public long this[int i]=>Value[i];

public static A193377Inst Instance=new A193377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193376
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,3L,1L,4L,5L,5L,1L,5L,7L,11L,8L,1L,6L,9L,19L,21L,13L,1L,7L,11L,29L,40L,43L,21L,1L,8L,13L,41L,65L,97L,85L,34L,1L,9L,15L,55L,96L,181L,217L,171L,55L,1L,10L,17L,71L,133L,301L,441L,508L,341L,89L,1L,11L,19L,89L,176L,463L,781L,1165L,1159L,683L,144L,1L,12L,21L,109L,225L,673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193376Inst : IEnumerable<long>
{
public static readonly long[] Value=A193376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193376.Bytes);
public long this[int i]=>Value[i];

public static A193376Inst Instance=new A193376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193375
{
public static readonly BigInteger[] Value={ 1L,1L,1L,7L,25L,61L,1201L,7771L,30577L,514585L,8089921L,63701551L,832599241L,14055894997L,137066892145L,3084240161731L,70859008063201L,849408115312561L,15997591979202817L,358582896987674455L,6017079190150763641L,BigInteger.Parse("209473179919282488301") };
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
public class A193375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193375Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193375.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193375Inst Instance=new A193375Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193374
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,9L,21L,201L,1191L,4593L,36009L,620721L,5297931L,40360761L,474989373L,4345942329L,122776895151L,2118941145441L,21344580276561L,303071564084193L,4476037678611219L,59935820004483561L,3838519441659950181L,BigInteger.Parse("78361805638079449641") };
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
public class A193374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193374Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193374.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193374Inst Instance=new A193374Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193373
{
public static readonly long[] Value={ 9L,2L,0L,1L,5L,1L,1L,8L,4L,5L,1L,0L,6L,1L,0L,1L,1L,4L,9L,5L,4L,7L,0L,2L,8L,8L,8L,2L,4L,9L,1L,5L,6L,0L,3L,4L,8L,8L,9L,8L,5L,8L,5L,5L,4L,6L,8L,7L,2L,6L,0L,7L,0L,9L,4L,3L,2L,2L,4L,6L,7L,8L,8L,8L,2L,9L,5L,9L,9L,0L,0L,9L,7L,3L,6L,4L,7L,2L,0L,4L,3L,3L,4L,0L,3L,7L,1L,3L,5L,7L,9L,5L,9L,7L,3L,4L,4L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193373Inst : IEnumerable<long>
{
public static readonly long[] Value=A193373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193373.Bytes);
public long this[int i]=>Value[i];

public static A193373Inst Instance=new A193373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193372
{
public static readonly long[] Value={ 8L,411L,63632L,34109858L,67940603552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193372Inst : IEnumerable<long>
{
public static readonly long[] Value=A193372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193372.Bytes);
public long this[int i]=>Value[i];

public static A193372Inst Instance=new A193372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193355
{
public static readonly long[] Value={ 6L,5L,0L,6L,4L,5L,1L,4L,2L,2L,8L,4L,2L,8L,6L,5L,0L,4L,2L,7L,6L,6L,1L,8L,8L,0L,3L,3L,9L,0L,5L,9L,5L,4L,0L,7L,2L,0L,8L,7L,2L,6L,1L,4L,5L,0L,0L,0L,2L,9L,2L,2L,0L,1L,0L,5L,5L,2L,2L,5L,5L,0L,7L,3L,2L,4L,3L,0L,9L,1L,9L,3L,4L,0L,6L,6L,3L,2L,4L,5L,5L,9L,7L,3L,6L,4L,6L,0L,5L,4L,7L,1L,1L,3L,2L,4L,0L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193355Inst : IEnumerable<long>
{
public static readonly long[] Value=A193355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193355.Bytes);
public long this[int i]=>Value[i];

public static A193355Inst Instance=new A193355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193354
{
public static readonly long[] Value={ 1L,-32L,8L,480L,-256L,28L,-4480L,3840L,-896L,64L,29152L,-35840L,13440L,-2048L,126L,-140736L,233216L,-125440L,30720L,-4032L,224L,525952L,-1125888L,816256L,-286720L,60480L,-7168L,344L,-1580800L,4207616L,-3940608L,1865728L,-564480L,107520L,-11008L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193354Inst : IEnumerable<long>
{
public static readonly long[] Value=A193354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193354.Bytes);
public long this[int i]=>Value[i];

public static A193354Inst Instance=new A193354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193353
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,7L,30L,197L,1770L,22536L,409456L,10541949L,387914810L,20362048664L,1525681168956L,163330533908217L,24973901010606886L,5456672750531017964L,BigInteger.Parse("1704092792275195175172"),BigInteger.Parse("760753610853139920737328"),BigInteger.Parse("485646261179496433286709024") };
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
public class A193353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193353Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193353.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193353Inst Instance=new A193353Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193352
{
public static readonly long[] Value={ 0L,2L,8L,50L,416L,5616L,117308L,4862736L,435732112L,89647085656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193352Inst : IEnumerable<long>
{
public static readonly long[] Value=A193352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193352.Bytes);
public long this[int i]=>Value[i];

public static A193352Inst Instance=new A193352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193351
{
public static readonly long[] Value={ 3L,4L,8L,9L,16L,18L,49L,50L,64L,81L,169L,225L,288L,324L,392L,578L,625L,729L,882L,900L,1024L,1458L,1568L,1936L,2304L,2450L,2592L,3042L,3136L,3200L,3362L,3600L,4096L,4489L,4802L,4900L,5000L,6241L,6272L,6400L,6962L,7744L,7938L,8100L,10082L,11025L,11552L,12996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193351Inst : IEnumerable<long>
{
public static readonly long[] Value=A193351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193351.Bytes);
public long this[int i]=>Value[i];

public static A193351Inst Instance=new A193351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193350
{
public static readonly long[] Value={ 0L,2L,2L,0L,2L,6L,2L,6L,0L,6L,2L,8L,2L,6L,6L,0L,2L,8L,2L,8L,6L,6L,2L,14L,0L,6L,6L,8L,2L,14L,2L,8L,6L,6L,6L,0L,2L,6L,6L,14L,2L,14L,2L,8L,8L,6L,2L,12L,0L,8L,6L,8L,2L,14L,6L,14L,6L,6L,2L,24L,2L,6L,8L,0L,6L,14L,2L,8L,6L,14L,2L,24L,2L,6L,8L,8L,6L,14L,2L,12L,0L,6L,2L,24L,6L,6L,6L,14L,2L,24L,6L,8L,6L,6L,6L,24L,2L,8L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193350Inst : IEnumerable<long>
{
public static readonly long[] Value=A193350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193350.Bytes);
public long this[int i]=>Value[i];

public static A193350Inst Instance=new A193350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193349
{
public static readonly long[] Value={ 1L,1L,1L,4L,1L,1L,1L,1L,4L,1L,1L,4L,1L,1L,1L,6L,1L,4L,1L,4L,1L,1L,1L,1L,4L,1L,1L,4L,1L,1L,1L,4L,1L,1L,1L,13L,1L,1L,1L,1L,1L,1L,1L,4L,4L,1L,1L,6L,4L,4L,1L,4L,1L,1L,1L,1L,1L,1L,1L,4L,1L,1L,4L,8L,1L,1L,1L,4L,1L,1L,1L,4L,1L,1L,4L,4L,1L,1L,1L,6L,6L,1L,1L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193349Inst : IEnumerable<long>
{
public static readonly long[] Value=A193349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193349.Bytes);
public long this[int i]=>Value[i];

public static A193349Inst Instance=new A193349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193348
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193348Inst : IEnumerable<long>
{
public static readonly long[] Value=A193348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193348.Bytes);
public long this[int i]=>Value[i];

public static A193348Inst Instance=new A193348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193347
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,2L,1L,2L,0L,2L,1L,2L,1L,2L,2L,0L,1L,2L,1L,2L,2L,2L,1L,3L,0L,2L,2L,2L,1L,3L,1L,2L,2L,2L,2L,0L,1L,2L,2L,3L,1L,3L,1L,2L,2L,2L,1L,2L,0L,2L,2L,2L,1L,3L,2L,3L,2L,2L,1L,4L,1L,2L,2L,0L,2L,3L,1L,2L,2L,3L,1L,4L,1L,2L,2L,2L,2L,3L,1L,2L,0L,2L,1L,4L,2L,2L,2L,3L,1L,4L,2L,2L,2L,2L,2L,4L,1L,2L,2L,0L,1L,3L,1L,3L,3L,2L,1L,4L,1L,3L,2L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193347Inst : IEnumerable<long>
{
public static readonly long[] Value=A193347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193347.Bytes);
public long this[int i]=>Value[i];

public static A193347Inst Instance=new A193347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193346
{
public static readonly long[] Value={ 1L,144L,4960608L,55493434415544000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193346Inst : IEnumerable<long>
{
public static readonly long[] Value=A193346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193346.Bytes);
public long this[int i]=>Value[i];

public static A193346Inst Instance=new A193346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193345
{
public static readonly long[] Value={ 1L,1L,7L,8L,7L,0L,1L,9L,7L,2L,3L,0L,8L,5L,5L,1L,9L,6L,5L,4L,6L,3L,8L,8L,0L,5L,5L,0L,3L,2L,7L,9L,6L,8L,6L,7L,5L,0L,4L,9L,5L,0L,5L,9L,9L,0L,5L,2L,5L,3L,3L,6L,6L,3L,4L,8L,2L,7L,8L,0L,0L,9L,0L,9L,4L,8L,5L,0L,3L,4L,4L,4L,8L,7L,2L,2L,9L,7L,9L,3L,7L,7L,7L,3L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193345Inst : IEnumerable<long>
{
public static readonly long[] Value=A193345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193345.Bytes);
public long this[int i]=>Value[i];

public static A193345Inst Instance=new A193345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193344
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,2L,9L,13L,6L,5L,32L,72L,69L,24L,16L,132L,409L,605L,432L,120L,61L,623L,2480L,5016L,5498L,3120L,720L,271L,3314L,16222L,41955L,62626L,54370L,25560L,5040L,1372L,19628L,114594L,363123L,690935L,814690L,584580L,234360L,40320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193344Inst : IEnumerable<long>
{
public static readonly long[] Value=A193344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193344.Bytes);
public long this[int i]=>Value[i];

public static A193344Inst Instance=new A193344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193343
{
public static readonly long[] Value={ 42L,63L,94L,135L,96L,157L,138L,129L,130L,41L,52L,73L,104L,55L,106L,77L,148L,139L,140L,51L,62L,83L,114L,65L,116L,87L,158L,149L,150L,61L,72L,93L,124L,75L,126L,97L,168L,159L,160L,71L,82L,103L,44L,85L,136L,107L,88L,169L,170L,81L,92L,113L,54L,95L,146L,117L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193343Inst : IEnumerable<long>
{
public static readonly long[] Value=A193343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193343.Bytes);
public long this[int i]=>Value[i];

public static A193343Inst Instance=new A193343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193342
{
public static readonly BigInteger[] Value={ 1L,1L,-7L,873L,-335023L,314308145L,-608475110391L,2176841249613401L,BigInteger.Parse("-13293673514920102879"),BigInteger.Parse("130392618478782066711009"),BigInteger.Parse("-1956708639203083689685074535"),BigInteger.Parse("43167469497976800185127921454793"),BigInteger.Parse("-1354293569879914292359532215444184463"),BigInteger.Parse("58748391997267678043451322126451570916113") };
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
public class A193342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193342Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193342.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193342Inst Instance=new A193342Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193341
{
public static readonly BigInteger[] Value={ 1L,2L,6L,16L,0L,-144L,5488L,47104L,-2799360L,-29427200L,3293554176L,40830142464L,-7642645477376L,-109489995819008L,31826754503424000L,518027268557111296L,BigInteger.Parse("-221570477108873330688"),BigInteger.Parse("-4041287223180417957888"),BigInteger.Parse("2438941389381370203996160"),BigInteger.Parse("49292069262802363796684800") };
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
public class A193341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193341Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193341.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193341Inst Instance=new A193341Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193340
{
public static readonly BigInteger[] Value={ 1L,5L,105L,189L,385L,19305L,85085L,8729721L,1249937325L,37182145L,608142583125L,1452095555625L,215656441L,191898783962510625L,372509404162520625L,29248404810625L,BigInteger.Parse("431620764875678503125"),4873615036539089841L,181101347337625L,BigInteger.Parse("1553338924739899476440625") };
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
public class A193340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193340Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193340.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193340Inst Instance=new A193340Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193323
{
public static readonly BigInteger[] Value={ 0L,2L,5L,35L,536L,14925L,793364L,78403900L,14523841634L,5077912263585L,3333988310175135L,4109919842182410230L,BigInteger.Parse("9524298796836830690410"),BigInteger.Parse("41479594927306884269307590") };
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
public class A193323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193323Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193323.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193323Inst Instance=new A193323Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193322
{
public static readonly long[] Value={ 0L,0L,2L,2L,6L,2L,8L,2L,8L,6L,12L,2L,24L,8L,6L,6L,30L,8L,26L,6L,8L,12L,24L,2L,36L,24L,26L,8L,48L,6L,48L,14L,12L,30L,24L,8L,78L,26L,24L,6L,84L,8L,64L,12L,24L,24L,48L,6L,64L,36L,30L,24L,84L,26L,36L,8L,26L,48L,60L,6L,144L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193322Inst : IEnumerable<long>
{
public static readonly long[] Value=A193322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193322.Bytes);
public long this[int i]=>Value[i];

public static A193322Inst Instance=new A193322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193321
{
public static readonly long[] Value={ 1L,1L,2L,6L,23L,106L,565L,3391L,22523L,163578L,1286990L,10886149L,98377648L,944863003L,9602092037L,102856190049L,1157496371816L,13644751751698L,168052771354837L,2157537327051316L,28814062411243931L,399551143081559391L,5742819361050324227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193321Inst : IEnumerable<long>
{
public static readonly long[] Value=A193321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193321.Bytes);
public long this[int i]=>Value[i];

public static A193321Inst Instance=new A193321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193320
{
public static readonly ulong[] Value={ 1L,1L,1L,2L,7L,31L,158L,907L,5785L,40496L,307993L,2524639L,22158860L,207111169L,2051807533L,21458470274L,236087173027L,2724128688979L,32876740543526L,414007923183559L,5428110627157597L,73954177162273736L,1045162786551967021L,15297280935680456227UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193320Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A193320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193320.Bytes);
public ulong this[int i]=>Value[i];

public static A193320Inst Instance=new A193320Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193319
{
public static readonly ulong[] Value={ 1L,1L,3L,11L,49L,273L,1859L,14731L,131073L,1287041L,13822051L,161149227L,2024636273L,27227371345L,389753084259L,5912210812139L,94679315407489L,1595416629866625L,28204870292970563L,521740077282205387L,10074781737635639601UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193319Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A193319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193319.Bytes);
public ulong this[int i]=>Value[i];

public static A193319Inst Instance=new A193319Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193318
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,54L,229L,1111L,6020L,35873L,232677L,1629528L,12238621L,98006533L,832764146L,7477375601L,70696248123L,701636328534L,7289525389681L,79084544097475L,893993204314316L,10509131215500701L,128235999632164377L,1621637635101089040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193318Inst : IEnumerable<long>
{
public static readonly long[] Value=A193318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193318.Bytes);
public long this[int i]=>Value[i];

public static A193318Inst Instance=new A193318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193317
{
public static readonly BigInteger[] Value={ 0L,0L,1L,18L,300L,5550L,117780L,2873262L,80126228L,2534723280L,90239747220L,3588582531875L,158318375911740L,7700793136255440L,410691133882551795L,BigInteger.Parse("23894146232727414630"),BigInteger.Parse("1509723335738373490800"),BigInteger.Parse("103169903975944947302744"),BigInteger.Parse("7597003720932150826636260"),BigInteger.Parse("600748548233457344454385722") };
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
public class A193317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193317Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193317.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193317Inst Instance=new A193317Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193316
{
public static readonly long[] Value={ 0L,0L,1L,5L,9L,28L,53L,110L,229L,474L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193316Inst : IEnumerable<long>
{
public static readonly long[] Value=A193316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193316.Bytes);
public long this[int i]=>Value[i];

public static A193316Inst Instance=new A193316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193315
{
public static readonly long[] Value={ 1L,4L,9L,15L,25L,35L,49L,55L,77L,91L,121L,143L,169L,187L,221L,247L,289L,323L,361L,391L,437L,403L,529L,551L,589L,667L,713L,703L,841L,899L,961L,943L,1073L,1147L,1189L,1271L,1369L,1363L,1517L,1591L,1681L,1763L,1849L,1927L,2021L,1891L,2209L,2279L,2257L,2491L,2537L,2623L,2809L,2867L,2881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193315Inst : IEnumerable<long>
{
public static readonly long[] Value=A193315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193315.Bytes);
public long this[int i]=>Value[i];

public static A193315Inst Instance=new A193315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193314
{
public static readonly long[] Value={ 1L,2L,5L,14L,384L,1715L,714L,633555L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193314Inst : IEnumerable<long>
{
public static readonly long[] Value=A193314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193314.Bytes);
public long this[int i]=>Value[i];

public static A193314Inst Instance=new A193314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193313
{
public static readonly BigInteger[] Value={ 0L,0L,0L,384L,25487513L,3218172167526L,1689214255082226544L,BigInteger.Parse("4735679809903927663201085"),BigInteger.Parse("77891271754155746362358782867546") };
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
public class A193313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193313Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193313.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193313Inst Instance=new A193313Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193312
{
public static readonly BigInteger[] Value={ 0L,0L,0L,1967L,28086845L,1002248784605L,146362253556566778L,BigInteger.Parse("102707525087192055167866"),BigInteger.Parse("365249619799053405866337963930") };
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
public class A193312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193312Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193312.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193312Inst Instance=new A193312Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193311
{
public static readonly BigInteger[] Value={ 0L,0L,1L,4542L,14738163L,133285442691L,4508743067686948L,BigInteger.Parse("622715995190475951953"),BigInteger.Parse("359265265609409060043111601"),BigInteger.Parse("869862398667109067205080837833962") };
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
public class A193311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193311Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193311.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193311Inst Instance=new A193311Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193310
{
public static readonly BigInteger[] Value={ 0L,0L,9L,4369L,3042328L,5698808287L,33317286304173L,628998137157508637L,BigInteger.Parse("38569165397999629055394"),BigInteger.Parse("7686739047191692875345982285"),BigInteger.Parse("4979433998253869605167632947630885") };
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
public class A193310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193310Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193310.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193310Inst Instance=new A193310Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193309
{
public static readonly BigInteger[] Value={ 0L,0L,20L,1436L,175145L,47175440L,29471424170L,42983780102348L,146444614636063181L,BigInteger.Parse("1165528963228211645900"),BigInteger.Parse("21669813287663490052945610"),BigInteger.Parse("941174635410184709958677112920"),BigInteger.Parse("95492317441878724418372856301818197") };
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
public class A193309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193309Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193309.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193309Inst Instance=new A193309Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193308
{
public static readonly BigInteger[] Value={ 0L,1L,11L,107L,1475L,30743L,978695L,47696147L,3562705943L,408229283699L,71800542715031L,19393574332166999L,8047409187443508719L,BigInteger.Parse("5131576344077602362143"),BigInteger.Parse("5029742282540253810124751") };
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
public class A193308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193308Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193308.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193308Inst Instance=new A193308Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193291
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,3L,0L,0L,2L,0L,0L,12L,0L,0L,4L,0L,0L,12L,0L,0L,4L,0L,0L,60L,0L,0L,8L,0L,0L,48L,0L,0L,4L,0L,0L,128L,0L,0L,4L,0L,0L,48L,0L,0L,16L,0L,0L,288L,0L,0L,4L,0L,0L,96L,0L,0L,16L,0L,0L,768L,0L,0L,16L,0L,0L,48L,0L,0L,16L,0L,0L,1280L,0L,0L,24L,0L,0L,96L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193291Inst : IEnumerable<long>
{
public static readonly long[] Value=A193291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193291.Bytes);
public long this[int i]=>Value[i];

public static A193291Inst Instance=new A193291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193290
{
public static readonly BigInteger[] Value={ 1L,2L,10L,96L,1388L,26960L,659352L,19471984L,674425600L,26814697056L,1203912012000L,60251644584384L,3326134996826688L,200792710948417536L,13159474030202943744UL,BigInteger.Parse("930524202271542658560"),BigInteger.Parse("70616227020854238216192"),BigInteger.Parse("5724780985202503068533760") };
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
public class A193290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193290Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193290.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193290Inst Instance=new A193290Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193289
{
public static readonly BigInteger[] Value={ 1L,2L,16L,116L,1456L,18272L,315424L,5592512L,123304192L,2814746624L,75639399424L,2108241486848L,66872341633024L,2198914617257984L,80437062279012352L,3046047243283570688L,BigInteger.Parse("126259635313097506816"),BigInteger.Parse("5408763597941368291328"),BigInteger.Parse("250569314672586154835968") };
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
public class A193289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193289Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193289.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193289Inst Instance=new A193289Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193288
{
public static readonly BigInteger[] Value={ 1L,1L,7L,28L,289L,2131L,29161L,316072L,5395993L,77326165L,1583326171L,28229026156L,674412621697L,14384156661343L,392879390385301L,9753823992141496L,299849358712509361L,8492478062686906057L,BigInteger.Parse("290226665437376352463"),BigInteger.Parse("9233909417529486840412") };
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
public class A193288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193288Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193288.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193288Inst Instance=new A193288Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193287
{
public static readonly BigInteger[] Value={ 1L,1L,5L,19L,145L,981L,10141L,98575L,1289569L,16314121L,258568021L,4023553931L,74961787825L,1383475135069L,29636315118957L,632414472704071L,15316605861040321L,370875832116841105L,10021723060544059429UL,BigInteger.Parse("271409166367070755843") };
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
public class A193287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193287Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193287.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193287Inst Instance=new A193287Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193286
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,12L,16L,20L,25L,30L,36L,48L,64L,80L,100L,125L,150L,192L,256L,320L,400L,500L,625L,768L,1024L,1280L,1600L,2000L,2500L,3125L,4096L,5120L,6400L,8000L,10000L,12500L,16384L,20480L,25600L,32000L,40000L,50000L,65536L,81920L,102400L,128000L,160000L,200000L,262144L,327680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193286Inst : IEnumerable<long>
{
public static readonly long[] Value=A193286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193286.Bytes);
public long this[int i]=>Value[i];

public static A193286Inst Instance=new A193286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193285
{
public static readonly long[] Value={ 0L,0L,1L,12L,89L,645L,4862L,39906L,361931L,3626663L,39912033L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193285Inst : IEnumerable<long>
{
public static readonly long[] Value=A193285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193285.Bytes);
public long this[int i]=>Value[i];

public static A193285Inst Instance=new A193285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193284
{
public static readonly long[] Value={ 1L,2L,5L,12L,31L,75L,178L,414L,949L,2137L,4767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193284Inst : IEnumerable<long>
{
public static readonly long[] Value=A193284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193284.Bytes);
public long this[int i]=>Value[i];

public static A193284Inst Instance=new A193284Inst();

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