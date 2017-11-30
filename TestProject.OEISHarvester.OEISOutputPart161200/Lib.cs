using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A277457
{
public static readonly BigInteger[] Value={ 1L,3L,12L,71L,616L,7197L,105052L,1829291L,36922928L,846851993L,21744781684L,617832652527L,19242299657896L,651815827343189L,23857403245171724L,938247816632341043L,BigInteger.Parse("39455261828928309088"),BigInteger.Parse("1766645684585351990961"),BigInteger.Parse("83913998998426051745764"),BigInteger.Parse("4214295288128637488870327"),BigInteger.Parse("223120214856875472660345176") };
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
public class A277457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277457Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277457.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277457Inst Instance=new A277457Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277458
{
public static readonly BigInteger[] Value={ -1L,1L,0L,3L,16L,165L,2016L,30415L,539904L,11049129L,256038400L,6627314331L,189517916160L,5933803272397L,201893195083776L,7417376809230375L,292648536838045696L,12341039738944113105UL,BigInteger.Parse("553942486234823786496"),BigInteger.Parse("26369048375194607316019"),BigInteger.Parse("1326864458454400696320000") };
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
public class A277458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277458Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277458.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277458Inst Instance=new A277458Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277459
{
public static readonly long[] Value={ 102L,387L,433L,436L,527L,656L,882L,1108L,1181L,1531L,1546L,1555L,1667L,1797L,1822L,1823L,1913L,1991L,2009L,2074L,2083L,2151L,2311L,2353L,2370L,2615L,2626L,2646L,2671L,3202L,3232L,3256L,3278L,3293L,3371L,3413L,3511L,3599L,3634L,3904L,3929L,3934L,4123L,4152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277459Inst : IEnumerable<long>
{
public static readonly long[] Value=A277459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277459.Bytes);
public long this[int i]=>Value[i];

public static A277459Inst Instance=new A277459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277524
{
public static readonly long[] Value={ 1L,9L,0L,1L,7L,1L,3L,9L,0L,7L,5L,2L,6L,0L,0L,3L,9L,8L,6L,2L,6L,2L,6L,3L,9L,9L,8L,2L,1L,2L,4L,6L,9L,9L,5L,1L,4L,4L,4L,6L,4L,8L,8L,5L,7L,4L,5L,2L,4L,0L,5L,0L,5L,3L,1L,6L,2L,0L,0L,0L,9L,0L,0L,9L,1L,3L,5L,1L,5L,9L,4L,3L,5L,4L,5L,0L,7L,5L,5L,4L,2L,9L,0L,3L,4L,9L,2L,6L,8L,4L,0L,1L,4L,2L,1L,2L,6L,0L,2L,6L,6L,8L,4L,7L,1L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277524Inst : IEnumerable<long>
{
public static readonly long[] Value=A277524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277524.Bytes);
public long this[int i]=>Value[i];

public static A277524Inst Instance=new A277524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277525
{
public static readonly long[] Value={ 1L,7L,2L,9L,6L,3L,7L,6L,7L,7L,6L,7L,5L,5L,4L,3L,4L,1L,4L,4L,7L,5L,9L,9L,4L,3L,6L,6L,8L,6L,0L,8L,3L,4L,0L,4L,1L,1L,3L,7L,8L,5L,9L,2L,4L,8L,5L,8L,7L,6L,2L,4L,7L,5L,4L,3L,6L,2L,8L,4L,5L,2L,7L,3L,6L,5L,9L,6L,9L,2L,3L,4L,8L,6L,2L,8L,9L,4L,3L,3L,4L,5L,2L,1L,7L,5L,6L,7L,1L,2L,3L,8L,4L,8L,3L,8L,7L,0L,4L,5L,2L,4L,4L,0L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277525Inst : IEnumerable<long>
{
public static readonly long[] Value=A277525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277525.Bytes);
public long this[int i]=>Value[i];

public static A277525Inst Instance=new A277525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277526
{
public static readonly long[] Value={ 4L,9L,2L,8L,5L,9L,0L,7L,6L,3L,7L,5L,8L,5L,1L,0L,1L,7L,7L,6L,0L,3L,3L,5L,1L,7L,8L,7L,8L,9L,2L,8L,5L,7L,1L,2L,5L,7L,9L,5L,7L,1L,4L,7L,8L,2L,5L,3L,8L,5L,0L,5L,4L,6L,8L,4L,6L,7L,2L,6L,6L,0L,0L,4L,7L,1L,2L,7L,6L,2L,0L,4L,1L,6L,3L,9L,6L,2L,1L,2L,9L,2L,1L,9L,5L,9L,8L,8L,5L,3L,1L,4L,8L,7L,9L,3L,7L,9L,1L,6L,2L,6L,4L,3L,0L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277526Inst : IEnumerable<long>
{
public static readonly long[] Value=A277526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277526.Bytes);
public long this[int i]=>Value[i];

public static A277526Inst Instance=new A277526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277527
{
public static readonly long[] Value={ 2L,7L,7L,4L,4L,1L,3L,2L,0L,3L,5L,4L,0L,6L,1L,7L,9L,1L,0L,5L,8L,5L,6L,9L,5L,5L,1L,3L,9L,5L,9L,8L,4L,7L,5L,1L,4L,8L,8L,0L,3L,0L,9L,1L,5L,0L,5L,9L,4L,7L,0L,3L,9L,0L,8L,4L,1L,3L,5L,8L,3L,0L,8L,7L,8L,4L,7L,9L,7L,2L,0L,0L,0L,6L,0L,7L,2L,2L,5L,8L,9L,9L,7L,2L,5L,1L,5L,2L,7L,8L,1L,3L,3L,0L,5L,0L,1L,0L,8L,0L,0L,8L,8L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277527Inst : IEnumerable<long>
{
public static readonly long[] Value=A277527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277527.Bytes);
public long this[int i]=>Value[i];

public static A277527Inst Instance=new A277527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277528
{
public static readonly long[] Value={ 4L,3L,4L,9L,0L,2L,8L,8L,5L,6L,7L,2L,8L,8L,3L,7L,8L,4L,8L,0L,0L,2L,2L,2L,5L,2L,1L,4L,0L,8L,3L,8L,9L,5L,1L,4L,9L,9L,1L,6L,9L,6L,1L,5L,3L,3L,9L,0L,0L,0L,4L,4L,3L,1L,4L,0L,1L,3L,9L,2L,2L,9L,5L,3L,7L,6L,1L,2L,6L,2L,8L,9L,6L,9L,8L,7L,1L,5L,7L,4L,4L,0L,8L,8L,5L,2L,1L,1L,6L,6L,7L,8L,1L,7L,3L,8L,1L,8L,5L,1L,7L,6L,7L,0L,9L,8L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277528Inst : IEnumerable<long>
{
public static readonly long[] Value=A277528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277528.Bytes);
public long this[int i]=>Value[i];

public static A277528Inst Instance=new A277528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277529
{
public static readonly long[] Value={ 5L,0L,1L,0L,9L,2L,7L,6L,2L,7L,5L,0L,3L,6L,6L,9L,6L,8L,9L,5L,8L,6L,8L,0L,1L,7L,2L,3L,5L,3L,2L,2L,9L,4L,5L,1L,2L,7L,2L,1L,8L,3L,9L,4L,2L,3L,8L,3L,2L,4L,2L,6L,2L,4L,4L,6L,0L,2L,8L,9L,9L,9L,1L,1L,8L,5L,8L,4L,6L,3L,2L,4L,1L,1L,0L,1L,8L,9L,6L,2L,0L,2L,8L,2L,1L,0L,6L,6L,7L,3L,8L,4L,1L,4L,3L,1L,6L,6L,8L,7L,3L,6L,1L,0L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277529Inst : IEnumerable<long>
{
public static readonly long[] Value=A277529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277529.Bytes);
public long this[int i]=>Value[i];

public static A277529Inst Instance=new A277529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277530
{
public static readonly long[] Value={ 8L,4L,4L,6L,1L,7L,0L,8L,6L,7L,1L,0L,9L,3L,6L,1L,1L,9L,7L,5L,1L,5L,8L,2L,0L,7L,1L,1L,4L,9L,3L,8L,3L,2L,2L,3L,9L,5L,4L,6L,1L,0L,0L,2L,1L,7L,3L,6L,6L,2L,7L,5L,5L,1L,8L,4L,4L,1L,7L,2L,9L,4L,8L,3L,6L,5L,8L,0L,2L,4L,8L,4L,2L,5L,9L,8L,1L,7L,4L,6L,6L,3L,5L,1L,9L,8L,8L,5L,9L,6L,2L,2L,4L,9L,1L,5L,0L,1L,6L,9L,8L,4L,3L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277530Inst : IEnumerable<long>
{
public static readonly long[] Value=A277530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277530.Bytes);
public long this[int i]=>Value[i];

public static A277530Inst Instance=new A277530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277531
{
public static readonly long[] Value={ 1L,4L,1L,0L,9L,5L,0L,8L,6L,0L,4L,5L,7L,8L,2L,5L,2L,1L,6L,6L,7L,4L,8L,0L,7L,9L,5L,6L,6L,6L,2L,1L,3L,8L,6L,1L,1L,5L,9L,2L,7L,6L,0L,7L,4L,9L,5L,2L,5L,0L,6L,8L,9L,5L,9L,1L,6L,1L,0L,1L,8L,4L,7L,0L,8L,2L,4L,0L,0L,4L,4L,5L,8L,4L,4L,8L,8L,7L,2L,4L,0L,0L,8L,9L,3L,2L,4L,1L,1L,6L,2L,1L,3L,3L,3L,3L,4L,9L,8L,0L,6L,7L,0L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277531Inst : IEnumerable<long>
{
public static readonly long[] Value=A277531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277531.Bytes);
public long this[int i]=>Value[i];

public static A277531Inst Instance=new A277531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277532
{
public static readonly long[] Value={ 0L,1L,72L,2346L,3422L,3892L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277532Inst : IEnumerable<long>
{
public static readonly long[] Value=A277532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277532.Bytes);
public long this[int i]=>Value[i];

public static A277532Inst Instance=new A277532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277533
{
public static readonly long[] Value={ 5L,77L,777L,0L,0L,333333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277533Inst : IEnumerable<long>
{
public static readonly long[] Value=A277533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277533.Bytes);
public long this[int i]=>Value[i];

public static A277533Inst Instance=new A277533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277534
{
public static readonly long[] Value={ 5L,17L,0L,0L,65L,0L,0L,29L,65L,185L,0L,0L,169L,0L,0L,0L,221L,333L,0L,0L,273L,0L,0L,0L,157L,481L,0L,0L,1189L,0L,0L,641L,1353L,629L,0L,0L,1517L,0L,0L,425L,1681L,777L,0L,0L,1845L,0L,0L,0L,205L,925L,0L,0L,2173L,0L,0L,0L,2337L,1073L,0L,0L,2501L,0L,0L,0L,2665L,1221L,0L,0L,2829L,0L,0L,1405L,2993L,1369L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277534Inst : IEnumerable<long>
{
public static readonly long[] Value=A277534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277534.Bytes);
public long this[int i]=>Value[i];

public static A277534Inst Instance=new A277534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277535
{
public static readonly long[] Value={ 9L,9L,9L,9L,9L,9L,8L,3L,7L,2L,9L,7L,8L,0L,4L,9L,9L,5L,1L,0L,5L,9L,7L,3L,1L,7L,3L,2L,8L,1L,6L,0L,9L,6L,3L,1L,8L,5L,9L,5L,0L,2L,4L,4L,5L,9L,4L,5L,5L,3L,4L,6L,9L,0L,8L,3L,0L,2L,6L,4L,2L,5L,2L,2L,3L,0L,8L,2L,5L,3L,3L,4L,4L,6L,8L,5L,0L,3L,5L,2L,6L,1L,9L,3L,1L,1L,8L,8L,1L,7L,1L,0L,1L,0L,0L,0L,3L,1L,3L,7L,8L,3L,8L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277535Inst : IEnumerable<long>
{
public static readonly long[] Value=A277535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277535.Bytes);
public long this[int i]=>Value[i];

public static A277535Inst Instance=new A277535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277536
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,2L,0L,0L,3L,6L,0L,0L,8L,24L,24L,0L,0L,10L,170L,180L,120L,0L,0L,54L,900L,1980L,1440L,720L,0L,0L,-42L,6566L,19530L,21840L,12600L,5040L,0L,0L,944L,44072L,224112L,305760L,248640L,120960L,40320L,0L,0L,-5112L,365256L,2650536L,4818744L,4536000L,2993760L,1270080L,362880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277536Inst : IEnumerable<long>
{
public static readonly long[] Value=A277536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277536.Bytes);
public long this[int i]=>Value[i];

public static A277536Inst Instance=new A277536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277537
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,2L,0L,0L,1L,1L,2L,3L,0L,0L,1L,1L,2L,9L,8L,0L,0L,1L,1L,2L,9L,32L,10L,0L,0L,1L,1L,2L,9L,56L,180L,54L,0L,0L,1L,1L,2L,9L,56L,360L,954L,-42L,0L,0L,1L,1L,2L,9L,56L,480L,2934L,6524L,944L,0L,0L,1L,1L,2L,9L,56L,480L,4374L,26054L,45016L,-5112L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277537Inst : IEnumerable<long>
{
public static readonly long[] Value=A277537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277537.Bytes);
public long this[int i]=>Value[i];

public static A277537Inst Instance=new A277537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277538
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,56L,480L,5094L,65534L,944488L,15359184L,274118880L,5369469072L,114055774392L,2618129199504L,64505645760360L,1699067695202040L,47625773113856064L,1415693345589370368L,BigInteger.Parse("44474719907550007872"),BigInteger.Parse("1472352462644660486208"),BigInteger.Parse("51227002322058534554880") };
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
public class A277538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277538Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277538.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277538Inst Instance=new A277538Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277539
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,56L,480L,5094L,65534L,984808L,16629264L,312523680L,6425601072L,143775827832L,3471659156784L,90060216241800L,2496918043296840L,73703868906725184L,2307477802376274048L,BigInteger.Parse("76376765284713220032"),BigInteger.Parse("2664806795257276548288"),BigInteger.Parse("97747916619062963335680") };
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
public class A277539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277539Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277539.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277539Inst Instance=new A277539Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277588
{
public static readonly long[] Value={ 1L,10L,11L,21L,31L,41L,51L,61L,71L,81L,91L,100L,101L,110L,111L,121L,131L,141L,151L,161L,171L,181L,191L,201L,210L,211L,221L,231L,241L,251L,261L,271L,281L,291L,301L,310L,311L,321L,331L,341L,351L,361L,371L,381L,391L,401L,410L,411L,421L,431L,441L,451L,461L,471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277588Inst : IEnumerable<long>
{
public static readonly long[] Value=A277588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277588.Bytes);
public long this[int i]=>Value[i];

public static A277588Inst Instance=new A277588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277589
{
public static readonly long[] Value={ 2L,12L,20L,22L,32L,42L,52L,62L,72L,82L,92L,102L,112L,120L,122L,132L,142L,152L,162L,172L,182L,192L,200L,202L,212L,220L,222L,232L,242L,252L,262L,272L,282L,292L,302L,312L,320L,322L,332L,342L,352L,362L,372L,382L,392L,402L,412L,420L,422L,432L,442L,452L,462L,472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277589Inst : IEnumerable<long>
{
public static readonly long[] Value=A277589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277589.Bytes);
public long this[int i]=>Value[i];

public static A277589Inst Instance=new A277589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277590
{
public static readonly long[] Value={ 3L,13L,23L,30L,33L,43L,53L,63L,73L,83L,93L,103L,113L,123L,130L,133L,143L,153L,163L,173L,183L,193L,203L,213L,223L,230L,233L,243L,253L,263L,273L,283L,293L,300L,303L,313L,323L,330L,333L,343L,353L,363L,373L,383L,393L,403L,413L,423L,430L,433L,443L,453L,463L,473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277590Inst : IEnumerable<long>
{
public static readonly long[] Value=A277590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277590.Bytes);
public long this[int i]=>Value[i];

public static A277590Inst Instance=new A277590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277591
{
public static readonly long[] Value={ 4L,14L,24L,34L,40L,44L,54L,64L,74L,84L,94L,104L,114L,124L,134L,140L,144L,154L,164L,174L,184L,194L,204L,214L,224L,234L,240L,244L,254L,264L,274L,284L,294L,304L,314L,324L,334L,340L,344L,354L,364L,374L,384L,394L,400L,404L,414L,424L,434L,440L,444L,454L,464L,474L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277591Inst : IEnumerable<long>
{
public static readonly long[] Value=A277591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277591.Bytes);
public long this[int i]=>Value[i];

public static A277591Inst Instance=new A277591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277592
{
public static readonly long[] Value={ 5L,15L,25L,35L,45L,50L,55L,65L,75L,85L,95L,105L,115L,125L,135L,145L,150L,155L,165L,175L,185L,195L,205L,215L,225L,235L,245L,250L,255L,265L,275L,285L,295L,305L,315L,325L,335L,345L,350L,355L,365L,375L,385L,395L,405L,415L,425L,435L,445L,450L,455L,465L,475L,485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277592Inst : IEnumerable<long>
{
public static readonly long[] Value=A277592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277592.Bytes);
public long this[int i]=>Value[i];

public static A277592Inst Instance=new A277592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277593
{
public static readonly long[] Value={ 6L,16L,26L,36L,46L,56L,60L,66L,76L,86L,96L,106L,116L,126L,136L,146L,156L,160L,166L,176L,186L,196L,206L,216L,226L,236L,246L,256L,260L,266L,276L,286L,296L,306L,316L,326L,336L,346L,356L,360L,366L,376L,386L,396L,406L,416L,426L,436L,446L,456L,460L,466L,476L,486L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277593Inst : IEnumerable<long>
{
public static readonly long[] Value=A277593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277593.Bytes);
public long this[int i]=>Value[i];

public static A277593Inst Instance=new A277593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277594
{
public static readonly long[] Value={ 7L,17L,27L,37L,47L,57L,67L,70L,77L,87L,97L,107L,117L,127L,137L,147L,157L,167L,170L,177L,187L,197L,207L,217L,227L,237L,247L,257L,267L,270L,277L,287L,297L,307L,317L,327L,337L,347L,357L,367L,370L,377L,387L,397L,407L,417L,427L,437L,447L,457L,467L,470L,477L,487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277594Inst : IEnumerable<long>
{
public static readonly long[] Value=A277594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277594.Bytes);
public long this[int i]=>Value[i];

public static A277594Inst Instance=new A277594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277595
{
public static readonly long[] Value={ 8L,18L,28L,38L,48L,58L,68L,78L,80L,88L,98L,108L,118L,128L,138L,148L,158L,168L,178L,180L,188L,198L,208L,218L,228L,238L,248L,258L,268L,278L,280L,288L,298L,308L,318L,328L,338L,348L,358L,368L,378L,380L,388L,398L,408L,418L,428L,438L,448L,458L,468L,478L,480L,488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277595Inst : IEnumerable<long>
{
public static readonly long[] Value=A277595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277595.Bytes);
public long this[int i]=>Value[i];

public static A277595Inst Instance=new A277595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277596
{
public static readonly long[] Value={ 9L,19L,29L,39L,49L,59L,69L,79L,89L,90L,99L,109L,119L,129L,139L,149L,159L,169L,179L,189L,190L,199L,209L,219L,229L,239L,249L,259L,269L,279L,289L,290L,299L,309L,319L,329L,339L,349L,359L,369L,379L,389L,390L,399L,409L,419L,429L,439L,449L,459L,469L,479L,489L,490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277596Inst : IEnumerable<long>
{
public static readonly long[] Value=A277596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277596.Bytes);
public long this[int i]=>Value[i];

public static A277596Inst Instance=new A277596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277597
{
public static readonly long[] Value={ 1L,6L,10L,11L,16L,21L,26L,31L,36L,41L,46L,51L,56L,60L,61L,66L,71L,76L,81L,86L,91L,96L,100L,101L,106L,110L,111L,116L,121L,126L,131L,136L,141L,146L,151L,156L,160L,161L,166L,171L,176L,181L,186L,191L,196L,201L,206L,210L,211L,216L,221L,226L,231L,236L,241L,246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277597Inst : IEnumerable<long>
{
public static readonly long[] Value=A277597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277597.Bytes);
public long this[int i]=>Value[i];

public static A277597Inst Instance=new A277597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277598
{
public static readonly long[] Value={ 2L,7L,12L,17L,20L,22L,27L,32L,37L,42L,47L,52L,57L,62L,67L,70L,72L,77L,82L,87L,92L,97L,102L,107L,112L,117L,120L,122L,127L,132L,137L,142L,147L,152L,157L,162L,167L,170L,172L,177L,182L,187L,192L,197L,200L,202L,207L,212L,217L,220L,222L,227L,232L,237L,242L,247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277598Inst : IEnumerable<long>
{
public static readonly long[] Value=A277598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277598.Bytes);
public long this[int i]=>Value[i];

public static A277598Inst Instance=new A277598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277599
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,10L,11L,13L,15L,17L,19L,21L,23L,25L,27L,29L,30L,31L,33L,35L,37L,39L,41L,43L,45L,47L,49L,50L,51L,53L,55L,57L,59L,61L,63L,65L,67L,69L,70L,71L,73L,75L,77L,79L,81L,83L,85L,87L,89L,90L,91L,93L,95L,97L,99L,100L,101L,103L,105L,107L,109L,110L,111L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277599Inst : IEnumerable<long>
{
public static readonly long[] Value=A277599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277599.Bytes);
public long this[int i]=>Value[i];

public static A277599Inst Instance=new A277599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277600
{
public static readonly long[] Value={ 3L,8L,13L,18L,23L,28L,30L,33L,38L,43L,48L,53L,58L,63L,68L,73L,78L,80L,83L,88L,93L,98L,103L,108L,113L,118L,123L,128L,130L,133L,138L,143L,148L,153L,158L,163L,168L,173L,178L,180L,183L,188L,193L,198L,203L,208L,213L,218L,223L,228L,230L,233L,238L,243L,248L,253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277600Inst : IEnumerable<long>
{
public static readonly long[] Value=A277600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277600.Bytes);
public long this[int i]=>Value[i];

public static A277600Inst Instance=new A277600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277601
{
public static readonly long[] Value={ 4L,9L,14L,19L,24L,29L,34L,39L,40L,44L,49L,54L,59L,64L,69L,74L,79L,84L,89L,90L,94L,99L,104L,109L,114L,119L,124L,129L,134L,139L,140L,144L,149L,154L,159L,164L,169L,174L,179L,184L,189L,190L,194L,199L,204L,209L,214L,219L,224L,229L,234L,239L,240L,244L,249L,254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277601Inst : IEnumerable<long>
{
public static readonly long[] Value=A277601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277601.Bytes);
public long this[int i]=>Value[i];

public static A277601Inst Instance=new A277601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277602
{
public static readonly long[] Value={ 26L,27L,50L,65L,66L,82L,83L,84L,85L,86L,87L,88L,101L,102L,103L,104L,122L,123L,124L,125L,126L,127L,128L,145L,146L,147L,148L,149L,150L,151L,152L,153L,154L,170L,171L,172L,173L,174L,175L,197L,198L,199L,200L,226L,227L,228L,229L,230L,231L,232L,233L,234L,235L,236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277602Inst : IEnumerable<long>
{
public static readonly long[] Value=A277602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277602.Bytes);
public long this[int i]=>Value[i];

public static A277602Inst Instance=new A277602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277603
{
public static readonly BigInteger[] Value={ 36L,9045L,5195512L,5311399545L,8488859795196L,25466579385587L,19542965851120621L,58628897553361862L,BigInteger.Parse("61250772004870841520"),BigInteger.Parse("183752316014612524559"),BigInteger.Parse("250769086731739376780337"),BigInteger.Parse("752307260195218130341010"),BigInteger.Parse("1299515735021702625544976020"),BigInteger.Parse("3898547205065107876634928059") };
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
public class A277603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277603Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277603.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277603Inst Instance=new A277603Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277652
{
public static readonly long[] Value={ 0L,0L,4L,40L,312L,2212L,14920L,97632L,626080L,3957448L,24747948L,153483720L,945638232L,5795135820L,35357242128L,214919392128L,1302250826880L,7869116134672L,47437683195220L,285373276253352L,1713562776624952L,10272384482513140L,61489533128765784L,367581030765071200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277652Inst : IEnumerable<long>
{
public static readonly long[] Value=A277652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277652.Bytes);
public long this[int i]=>Value[i];

public static A277652Inst Instance=new A277652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277653
{
public static readonly long[] Value={ 0L,0L,1L,2L,8L,28L,98L,346L,1218L,4290L,15110L,53218L,187438L,660170L,2325166L,8189402L,28843662L,101589450L,357805342L,1260216122L,4438571726L,15632968522L,55060438334L,193926819802L,683024192622L,2405660280426L,8472908349854L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277653Inst : IEnumerable<long>
{
public static readonly long[] Value=A277653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277653.Bytes);
public long this[int i]=>Value[i];

public static A277653Inst Instance=new A277653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277654
{
public static readonly long[] Value={ 0L,1L,4L,47L,356L,2928L,23375L,189336L,1527478L,12337033L,99602551L,804255016L,6493758388L,52432856602L,423359381522L,3418341656804L,27600793196651L,222857733607580L,1799425381845099L,14529142393886177L,117312993383783121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277654Inst : IEnumerable<long>
{
public static readonly long[] Value=A277654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277654.Bytes);
public long this[int i]=>Value[i];

public static A277654Inst Instance=new A277654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277655
{
public static readonly BigInteger[] Value={ 0L,2L,47L,988L,18754L,376200L,7393463L,146226480L,2887603008L,57051216021L,1127051412486L,22265930239751L,439877330194814L,8690100341205478L,171679023552691198L,3391641194032785411L,BigInteger.Parse("67004275330116215523") };
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
public class A277655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277655Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277655.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277655Inst Instance=new A277655Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277656
{
public static readonly BigInteger[] Value={ 0L,8L,356L,18754L,853778L,41272404L,1939853778L,92010224525L,4354590810315L,206242664480842L,9765809059667609L,462455214528524834L,BigInteger.Parse("21898899233136089824"),BigInteger.Parse("1036995973723303272825"),BigInteger.Parse("49105621425306924377132") };
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
public class A277656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277656Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277656.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277656Inst Instance=new A277656Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277657
{
public static readonly BigInteger[] Value={ 0L,28L,2928L,376200L,41272404L,4770227060L,541407069559L,61782920451544L,7039498755007500L,802512669942654611L,BigInteger.Parse("91471885881045836163"),BigInteger.Parse("10426700328596033389040"),BigInteger.Parse("1188501290406035357519416") };
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
public class A277657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277657Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277657.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277657Inst Instance=new A277657Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277658
{
public static readonly BigInteger[] Value={ 0L,98L,23375L,7393463L,1939853778L,541407069559L,147555355904302L,40507831420784920L,11097550693801190042UL,BigInteger.Parse("3042257675643065012191"),BigInteger.Parse("833840708315324301188127"),BigInteger.Parse("228556846623263265433414261") };
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
public class A277658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277658Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277658.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277658Inst Instance=new A277658Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277659
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,2L,4L,2L,0L,0L,8L,47L,47L,8L,0L,0L,28L,356L,988L,356L,28L,0L,0L,98L,2928L,18754L,18754L,2928L,98L,0L,0L,346L,23375L,376200L,853778L,376200L,23375L,346L,0L,0L,1218L,189336L,7393463L,41272404L,41272404L,7393463L,189336L,1218L,0L,0L,4290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277659Inst : IEnumerable<long>
{
public static readonly long[] Value=A277659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277659.Bytes);
public long this[int i]=>Value[i];

public static A277659Inst Instance=new A277659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277660
{
public static readonly long[] Value={ 0L,0L,2L,30L,310L,2730L,21980L,167076L,1220100L,8650620L,59958030L,408172050L,2738441706L,18151701750L,119100934680L,774719545320L,5001728701800L,32081745977496L,204596905143930L,1298154208907430L,8199305968563710L,51576591659861730L,323239814342259892L,2019025558874685900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277660Inst : IEnumerable<long>
{
public static readonly long[] Value=A277660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277660.Bytes);
public long this[int i]=>Value[i];

public static A277660Inst Instance=new A277660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277661
{
public static readonly long[] Value={ 0L,0L,2L,18L,128L,840L,5306L,32802L,200064L,1209168L,7261042L,43394802L,258401216L,1534310232L,9089538922L,53748310338L,317337926144L,1871206403232L,11021718519266L,64859423566290L,381371547195648L,2240888478928488L,13159108981577242L,77232197285953890L,453066998085075840L,2656691258873376240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277661Inst : IEnumerable<long>
{
public static readonly long[] Value=A277661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277661.Bytes);
public long this[int i]=>Value[i];

public static A277661Inst Instance=new A277661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277662
{
public static readonly ulong[] Value={ 0L,0L,6L,102L,1142L,10650L,89576L,705012L,5297924L,38478492L,272262050L,1887071274L,12862479402L,86468603910L,574580180020L,3780504491400L,24663229376872L,159709443132888L,1027505285362590L,6572573611318158L,41827041105943870L,264959521695360786L,1671472578046156512L,10504743400858155708UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277662Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A277662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277662.Bytes);
public ulong this[int i]=>Value[i];

public static A277662Inst Instance=new A277662Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277663
{
public static readonly BigInteger[] Value={ 0L,0L,10L,378L,7048L,96000L,1092460L,11060700L,103150528L,905077728L,7576640950L,61098854454L,477942694136L,3645484792560L,27220292840440L,199588002587160L,1440630859132416L,10256896070590464L,72150109176698562L,502120765832371602L,3461203073248719400L,BigInteger.Parse("23654601049848668256") };
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
public class A277663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277663Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277663.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277663Inst Instance=new A277663Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277664
{
public static readonly BigInteger[] Value={ 0L,0L,22L,1638L,47454L,904530L,13529862L,172576362L,1966038698L,20583987894L,201838423616L,1878183167916L,16744919877108L,144061342087884L,1202594886126228L,9783039293041644L,77823360967288812L,607079393002409364L,4654603707195506610L,BigInteger.Parse("35144449267872359562"),BigInteger.Parse("261740341786424075106") };
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
public class A277664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277664Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277664.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277664Inst Instance=new A277664Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277665
{
public static readonly BigInteger[] Value={ 0L,0L,42L,6426L,291696L,7786680L,152881422L,2451889734L,34052988736L,424606263984L,4868397305884L,52193110266396L,529596113392928L,5132630490667056L,47846123752559076L,431382289963465044L,3778388016547646976L,BigInteger.Parse("32265703705734047808"),BigInteger.Parse("269434703704642529046"),BigInteger.Parse("2205554182120984631622") };
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
public class A277665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277665Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277665.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277665Inst Instance=new A277665Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277666
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,3L,3L,1L,0L,1L,4L,7L,4L,1L,0L,1L,5L,13L,16L,5L,1L,0L,1L,6L,21L,42L,37L,6L,1L,0L,1L,7L,31L,88L,136L,86L,7L,1L,0L,1L,8L,43L,160L,369L,440L,200L,8L,1L,0L,1L,9L,57L,264L,826L,1547L,1423L,465L,9L,1L,0L,1L,10L,73L,406L,1621L,4264L,6486L,4602L,1081L,10L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277666Inst : IEnumerable<long>
{
public static readonly long[] Value=A277666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277666.Bytes);
public long this[int i]=>Value[i];

public static A277666Inst Instance=new A277666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277667
{
public static readonly long[] Value={ 1L,4L,13L,42L,136L,440L,1423L,4602L,14883L,48132L,155660L,503408L,1628033L,5265096L,17027441L,55067134L,178088372L,575941872L,1862609199L,6023720790L,19480850935L,63001517896L,203748351160L,658926832032L,2130984459505L,6891652526348L,22287762039781L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277667Inst : IEnumerable<long>
{
public static readonly long[] Value=A277667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277667.Bytes);
public long this[int i]=>Value[i];

public static A277667Inst Instance=new A277667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277684
{
public static readonly long[] Value={ 0L,6L,17L,18L,69L,70L,297L,298L,299L,300L,300L,301L,302L,303L,304L,305L,306L,307L,464L,465L,466L,467L,624L,625L,1810L,1811L,1812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277684Inst : IEnumerable<long>
{
public static readonly long[] Value=A277684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277684.Bytes);
public long this[int i]=>Value[i];

public static A277684Inst Instance=new A277684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277685
{
public static readonly long[] Value={ 26L,21L,4L,20L,17L,3L,19L,19L,15L,14L,4L,15L,4L,20L,17L,17L,4L,4L,4L,4L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,19L,19L,19L,19L,19L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277685Inst : IEnumerable<long>
{
public static readonly long[] Value=A277685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277685.Bytes);
public long this[int i]=>Value[i];

public static A277685Inst Instance=new A277685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277686
{
public static readonly long[] Value={ 1L,1L,2L,5L,20L,91L,823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277686Inst : IEnumerable<long>
{
public static readonly long[] Value=A277686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277686.Bytes);
public long this[int i]=>Value[i];

public static A277686Inst Instance=new A277686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277687
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,4L,2L,4L,2L,18L,2L,29L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277687Inst : IEnumerable<long>
{
public static readonly long[] Value=A277687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277687.Bytes);
public long this[int i]=>Value[i];

public static A277687Inst Instance=new A277687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277688
{
public static readonly long[] Value={ 1L,3L,5L,19L,29L,31L,43L,49L,55L,59L,61L,71L,79L,83L,89L,91L,101L,109L,113L,115L,119L,125L,127L,131L,139L,149L,151L,155L,161L,163L,167L,169L,175L,179L,191L,193L,197L,199L,203L,209L,211L,215L,223L,227L,229L,239L,241L,247L,251L,253L,259L,265L,269L,271L,281L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277688Inst : IEnumerable<long>
{
public static readonly long[] Value=A277688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277688.Bytes);
public long this[int i]=>Value[i];

public static A277688Inst Instance=new A277688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277689
{
public static readonly long[] Value={ 13L,17L,23L,37L,43L,47L,53L,67L,73L,83L,97L,103L,107L,211L,307L,311L,503L,607L,811L,907L,911L,1151L,1181L,1373L,1787L,2003L,2011L,2131L,2383L,2797L,3011L,3181L,3191L,3313L,3373L,3727L,3797L,3919L,3929L,4003L,4007L,4373L,4787L,4919L,5003L,5011L,5101L,6007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277689Inst : IEnumerable<long>
{
public static readonly long[] Value=A277689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277689.Bytes);
public long this[int i]=>Value[i];

public static A277689Inst Instance=new A277689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277690
{
public static readonly long[] Value={ 2L,6L,13L,19L,26L,32L,38L,44L,51L,57L,63L,70L,76L,82L,88L,95L,101L,107L,114L,120L,126L,132L,139L,145L,151L,158L,164L,170L,176L,183L,189L,195L,202L,208L,214L,220L,227L,233L,239L,246L,252L,258L,264L,271L,277L,283L,290L,296L,302L,308L,315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277690Inst : IEnumerable<long>
{
public static readonly long[] Value=A277690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277690.Bytes);
public long this[int i]=>Value[i];

public static A277690Inst Instance=new A277690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277691
{
public static readonly long[] Value={ 1L,12L,710L,267L,159L,164L,76L,90L,16285L,2168L,3832L,7773L,29849L,34731L,1496L,23485L,51130L,17658L,38908L,38639L,270845L,450432L,57050L,145850L,631632L,240947L,398108L,306349L,288481L,410531L,1516421L,2621329L,781173L,333140L,2997665L,948049L,593835L,1506645L,1216039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277691Inst : IEnumerable<long>
{
public static readonly long[] Value=A277691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277691.Bytes);
public long this[int i]=>Value[i];

public static A277691Inst Instance=new A277691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277692
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,2L,1L,3L,2L,2L,1L,4L,1L,2L,3L,4L,1L,3L,1L,4L,3L,2L,1L,6L,2L,2L,3L,4L,1L,4L,1L,5L,3L,2L,3L,6L,1L,2L,3L,6L,1L,4L,1L,4L,5L,2L,1L,8L,2L,3L,3L,4L,1L,4L,3L,6L,3L,2L,1L,8L,1L,2L,5L,6L,3L,4L,1L,4L,3L,4L,1L,9L,1L,2L,5L,4L,3L,4L,1L,8L,4L,2L,1L,8L,3L,2L,3L,6L,1L,6L,3L,4L,3L,2L,3L,10L,1L,3L,5L,6L,1L,4L,1L,6L,7L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277692Inst : IEnumerable<long>
{
public static readonly long[] Value=A277692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277692.Bytes);
public long this[int i]=>Value[i];

public static A277692Inst Instance=new A277692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277693
{
public static readonly long[] Value={ 1L,12L,33277L,4177L,278L,3680912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277693Inst : IEnumerable<long>
{
public static readonly long[] Value=A277693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277693.Bytes);
public long this[int i]=>Value[i];

public static A277693Inst Instance=new A277693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277694
{
public static readonly long[] Value={ 11L,13L,15L,17L,19L,31L,33L,35L,37L,39L,51L,53L,55L,57L,59L,71L,73L,75L,77L,79L,91L,93L,95L,97L,99L,100L,102L,104L,106L,108L,110L,111L,112L,113L,114L,115L,116L,117L,118L,119L,120L,122L,124L,126L,128L,130L,131L,132L,133L,134L,135L,136L,137L,138L,139L,140L,142L,144L,146L,148L,150L,151L,152L,153L,154L,155L,156L,157L,158L,159L,160L,162L,164L,166L,168L,170L,171L,172L,173L,174L,175L,176L,177L,178L,179L,180L,182L,184L,186L,188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277694Inst : IEnumerable<long>
{
public static readonly long[] Value=A277694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277694.Bytes);
public long this[int i]=>Value[i];

public static A277694Inst Instance=new A277694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277695
{
public static readonly long[] Value={ 1L,2L,4L,8L,3L,16L,6L,32L,12L,5L,13L,64L,7L,24L,10L,26L,128L,14L,27L,17L,25L,49L,48L,20L,257L,11L,21L,52L,15L,256L,28L,54L,34L,50L,55L,98L,515L,99L,9L,65L,31L,29L,97L,105L,51L,96L,40L,514L,22L,101L,43L,35L,1031L,513L,81L,42L,69L,23L,57L,104L,63L,30L,512L,56L,108L,68L,111L,100L,139L,199L,163L,110L,196L,203L,19L,211L,2063L,33L,195L,53L,1030L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277695Inst : IEnumerable<long>
{
public static readonly long[] Value=A277695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277695.Bytes);
public long this[int i]=>Value[i];

public static A277695Inst Instance=new A277695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277696
{
public static readonly long[] Value={ 1L,2L,5L,3L,10L,7L,13L,4L,39L,15L,26L,9L,11L,18L,29L,6L,20L,92L,75L,24L,27L,49L,58L,14L,21L,16L,19L,31L,42L,62L,41L,8L,78L,33L,52L,270L,172L,196L,147L,47L,312L,56L,51L,126L,101L,143L,82L,23L,22L,34L,45L,28L,80L,32L,35L,64L,59L,96L,90L,153L,118L,95L,61L,12L,40L,224L,150L,66L,57L,129L,116L,1134L,534L,606L,316L,752L,404L,520L,207L,120L,55L,1400L,600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277696Inst : IEnumerable<long>
{
public static readonly long[] Value=A277696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277696.Bytes);
public long this[int i]=>Value[i];

public static A277696Inst Instance=new A277696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277697
{
public static readonly long[] Value={ 0L,1L,2L,0L,3L,1L,4L,0L,0L,1L,5L,2L,6L,1L,2L,0L,7L,1L,8L,3L,2L,1L,9L,2L,0L,1L,0L,4L,10L,1L,11L,0L,2L,1L,3L,0L,12L,1L,2L,3L,13L,1L,14L,5L,3L,1L,15L,2L,0L,1L,2L,6L,16L,1L,3L,4L,2L,1L,17L,2L,18L,1L,4L,0L,3L,1L,19L,7L,2L,1L,20L,0L,21L,1L,2L,8L,4L,1L,22L,3L,0L,1L,23L,2L,3L,1L,2L,5L,24L,1L,4L,9L,2L,1L,3L,2L,25L,1L,5L,0L,26L,1L,27L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277697Inst : IEnumerable<long>
{
public static readonly long[] Value=A277697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277697.Bytes);
public long this[int i]=>Value[i];

public static A277697Inst Instance=new A277697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277698
{
public static readonly long[] Value={ 1L,2L,3L,1L,5L,2L,7L,1L,1L,2L,11L,3L,13L,2L,3L,1L,17L,2L,19L,5L,3L,2L,23L,3L,1L,2L,1L,7L,29L,2L,31L,1L,3L,2L,5L,1L,37L,2L,3L,5L,41L,2L,43L,11L,5L,2L,47L,3L,1L,2L,3L,13L,53L,2L,5L,7L,3L,2L,59L,3L,61L,2L,7L,1L,5L,2L,67L,17L,3L,2L,71L,1L,73L,2L,3L,19L,7L,2L,79L,5L,1L,2L,83L,3L,5L,2L,3L,11L,89L,2L,7L,23L,3L,2L,5L,3L,97L,2L,11L,1L,101L,2L,103L,13L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277698Inst : IEnumerable<long>
{
public static readonly long[] Value=A277698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277698.Bytes);
public long this[int i]=>Value[i];

public static A277698Inst Instance=new A277698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277699
{
public static readonly long[] Value={ 1L,4L,9L,16L,57L,36L,49L,64L,209L,228L,217L,144L,233L,196L,225L,256L,801L,836L,809L,912L,793L,868L,785L,576L,1009L,932L,1017L,784L,969L,900L,961L,1024L,3137L,3204L,3145L,3344L,3193L,3236L,3185L,3648L,3217L,3172L,3225L,3472L,3241L,3140L,3233L,2304L,3937L,4036L,3945L,3728L,3929L,4068L,3921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277699Inst : IEnumerable<long>
{
public static readonly long[] Value=A277699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277699.Bytes);
public long this[int i]=>Value[i];

public static A277699Inst Instance=new A277699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277732
{
public static readonly long[] Value={ 1L,3L,6L,8L,11L,12L,14L,17L,19L,22L,23L,25L,27L,30L,32L,35L,36L,38L,41L,43L,46L,47L,49L,51L,54L,56L,59L,61L,64L,65L,67L,70L,72L,75L,76L,78L,80L,83L,85L,88L,89L,91L,94L,96L,99L,100L,102L,104L,107L,109L,112L,114L,117L,118L,120L,123L,125L,128L,129L,131L,134L,136L,139L,140L,142L,144L,147L,149L,152L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277732Inst : IEnumerable<long>
{
public static readonly long[] Value=A277732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277732.Bytes);
public long this[int i]=>Value[i];

public static A277732Inst Instance=new A277732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277733
{
public static readonly long[] Value={ 2L,4L,7L,9L,13L,15L,18L,20L,24L,26L,28L,31L,33L,37L,39L,42L,44L,48L,50L,52L,55L,57L,60L,62L,66L,68L,71L,73L,77L,79L,81L,84L,86L,90L,92L,95L,97L,101L,103L,105L,108L,110L,113L,115L,119L,121L,124L,126L,130L,132L,135L,137L,141L,143L,145L,148L,150L,154L,156L,159L,161L,165L,167L,169L,172L,174L,177L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277733Inst : IEnumerable<long>
{
public static readonly long[] Value=A277733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277733.Bytes);
public long this[int i]=>Value[i];

public static A277733Inst Instance=new A277733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277734
{
public static readonly long[] Value={ 5L,10L,16L,21L,29L,34L,40L,45L,53L,58L,63L,69L,74L,82L,87L,93L,98L,106L,111L,116L,122L,127L,133L,138L,146L,151L,157L,162L,170L,175L,180L,186L,191L,199L,204L,210L,215L,223L,228L,233L,239L,244L,250L,255L,263L,268L,274L,279L,287L,292L,298L,303L,311L,316L,321L,327L,332L,340L,345L,351L,356L,364L,369L,374L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277734Inst : IEnumerable<long>
{
public static readonly long[] Value=A277734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277734.Bytes);
public long this[int i]=>Value[i];

public static A277734Inst Instance=new A277734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277735
{
public static readonly long[] Value={ 0L,1L,2L,0L,0L,0L,1L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,0L,0L,0L,1L,0L,1L,2L,0L,0L,0L,1L,0L,1L,2L,0L,0L,0L,1L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,0L,0L,1L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,0L,0L,1L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,0L,0L,0L,1L,0L,1L,2L,0L,0L,0L,1L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277735Inst : IEnumerable<long>
{
public static readonly long[] Value=A277735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277735.Bytes);
public long this[int i]=>Value[i];

public static A277735Inst Instance=new A277735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277736
{
public static readonly long[] Value={ 1L,4L,5L,6L,8L,10L,13L,14L,17L,18L,21L,22L,23L,25L,28L,29L,30L,32L,35L,36L,37L,39L,41L,44L,45L,48L,49L,50L,52L,54L,57L,58L,61L,62L,63L,65L,67L,70L,71L,74L,75L,78L,79L,80L,82L,85L,86L,87L,89L,91L,94L,95L,98L,99L,102L,103L,104L,106L,109L,110L,111L,113L,115L,118L,119L,122L,123L,126L,127L,128L,130L,133L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277736Inst : IEnumerable<long>
{
public static readonly long[] Value=A277736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277736.Bytes);
public long this[int i]=>Value[i];

public static A277736Inst Instance=new A277736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277737
{
public static readonly long[] Value={ 2L,7L,9L,11L,15L,19L,24L,26L,31L,33L,38L,40L,42L,46L,51L,53L,55L,59L,64L,66L,68L,72L,76L,81L,83L,88L,90L,92L,96L,100L,105L,107L,112L,114L,116L,120L,124L,129L,131L,136L,138L,143L,145L,147L,151L,156L,158L,160L,164L,168L,173L,175L,180L,182L,187L,189L,191L,195L,200L,202L,204L,208L,212L,217L,219L,224L,226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277737Inst : IEnumerable<long>
{
public static readonly long[] Value=A277737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277737.Bytes);
public long this[int i]=>Value[i];

public static A277737Inst Instance=new A277737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277738
{
public static readonly long[] Value={ 3L,12L,16L,20L,27L,34L,43L,47L,56L,60L,69L,73L,77L,84L,93L,97L,101L,108L,117L,121L,125L,132L,139L,148L,152L,161L,165L,169L,176L,183L,192L,196L,205L,209L,213L,220L,227L,236L,240L,249L,253L,262L,266L,270L,277L,286L,290L,294L,301L,308L,317L,321L,330L,334L,343L,347L,351L,358L,367L,371L,375L,382L,389L,398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277738Inst : IEnumerable<long>
{
public static readonly long[] Value=A277738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277738.Bytes);
public long this[int i]=>Value[i];

public static A277738Inst Instance=new A277738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277739
{
public static readonly long[] Value={ 1L,3L,7L,30L,124L,733L,4586L,33373L,259434L,2152298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277739Inst : IEnumerable<long>
{
public static readonly long[] Value=A277739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277739.Bytes);
public long this[int i]=>Value[i];

public static A277739Inst Instance=new A277739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277740
{
public static readonly long[] Value={ 36L,276L,2936L,35872L,484088L,6967942L,105555336L,1664142836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277740Inst : IEnumerable<long>
{
public static readonly long[] Value=A277740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277740.Bytes);
public long this[int i]=>Value[i];

public static A277740Inst Instance=new A277740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277741
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,5L,5L,2L,3L,13L,20L,13L,3L,6L,35L,83L,83L,35L,6L,12L,104L,340L,504L,340L,12L,27L,315L,1401L,2843L,2843L,1401L,316L,27L,65L,1021L,5809L,15578L,21420L,15578L,5809L,1021L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277741Inst : IEnumerable<long>
{
public static readonly long[] Value=A277741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277741.Bytes);
public long this[int i]=>Value[i];

public static A277741Inst Instance=new A277741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277742
{
public static readonly long[] Value={ 0L,6L,32L,172L,1071L,7370L,55766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277742Inst : IEnumerable<long>
{
public static readonly long[] Value=A277742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277742.Bytes);
public long this[int i]=>Value[i];

public static A277742Inst Instance=new A277742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277743
{
public static readonly long[] Value={ 3L,2L,4L,10L,33L,114L,474L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277743Inst : IEnumerable<long>
{
public static readonly long[] Value=A277743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277743.Bytes);
public long this[int i]=>Value[i];

public static A277743Inst Instance=new A277743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277744
{
public static readonly long[] Value={ 1L,4L,2L,1L,6L,3L,5L,4L,2L,3L,5L,6L,1L,4L,2L,1L,6L,3L,5L,6L,1L,4L,2L,3L,5L,4L,2L,1L,6L,3L,5L,4L,2L,3L,5L,6L,1L,4L,2L,3L,5L,4L,2L,1L,6L,3L,5L,6L,1L,4L,2L,1L,6L,3L,5L,4L,2L,3L,5L,6L,1L,4L,2L,1L,6L,3L,5L,6L,1L,4L,2L,3L,5L,4L,2L,1L,6L,3L,5L,6L,1L,4L,2L,1L,6L,3L,5L,4L,2L,3L,5L,6L,1L,4L,2L,3L,5L,4L,2L,1L,6L,3L,5L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277744Inst : IEnumerable<long>
{
public static readonly long[] Value=A277744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277744.Bytes);
public long this[int i]=>Value[i];

public static A277744Inst Instance=new A277744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277745
{
public static readonly long[] Value={ 1L,2L,3L,2L,1L,2L,3L,2L,2L,3L,2L,1L,2L,3L,2L,3L,2L,1L,2L,3L,2L,2L,3L,2L,1L,2L,3L,2L,1L,2L,3L,2L,2L,3L,2L,1L,2L,3L,2L,3L,2L,1L,2L,3L,2L,2L,3L,2L,1L,2L,3L,2L,2L,3L,2L,1L,2L,3L,2L,3L,2L,1L,2L,3L,2L,2L,3L,2L,1L,2L,3L,2L,1L,2L,3L,2L,2L,3L,2L,1L,2L,3L,2L,3L,2L,1L,2L,3L,2L,2L,3L,2L,1L,2L,3L,2L,3L,2L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277745Inst : IEnumerable<long>
{
public static readonly long[] Value=A277745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277745.Bytes);
public long this[int i]=>Value[i];

public static A277745Inst Instance=new A277745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277746
{
public static readonly long[] Value={ 1L,3L,10L,47L,314L,3360L,59744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277746Inst : IEnumerable<long>
{
public static readonly long[] Value=A277746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277746.Bytes);
public long this[int i]=>Value[i];

public static A277746Inst Instance=new A277746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277747
{
public static readonly long[] Value={ 1L,6L,16L,66L,311L,1688L,10125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277747Inst : IEnumerable<long>
{
public static readonly long[] Value=A277747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277747.Bytes);
public long this[int i]=>Value[i];

public static A277747Inst Instance=new A277747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277780
{
public static readonly long[] Value={ 8L,16L,24L,32L,40L,48L,56L,27L,72L,80L,88L,96L,104L,112L,120L,54L,136L,144L,152L,160L,168L,176L,184L,81L,200L,208L,64L,224L,232L,240L,248L,108L,264L,272L,280L,288L,296L,304L,312L,135L,328L,336L,344L,352L,360L,368L,376L,162L,392L,400L,408L,416L,424L,128L,440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277780Inst : IEnumerable<long>
{
public static readonly long[] Value=A277780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277780.Bytes);
public long this[int i]=>Value[i];

public static A277780Inst Instance=new A277780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277781
{
public static readonly long[] Value={ 8L,4L,9L,16L,25L,36L,49L,27L,24L,80L,88L,18L,104L,112L,120L,32L,136L,96L,152L,50L,168L,176L,184L,72L,40L,208L,64L,98L,232L,240L,248L,54L,264L,272L,280L,48L,296L,304L,312L,135L,328L,336L,344L,242L,75L,368L,376L,162L,56L,160L,408L,338L,424L,108L,440L,189L,456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277781Inst : IEnumerable<long>
{
public static readonly long[] Value=A277781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277781.Bytes);
public long this[int i]=>Value[i];

public static A277781Inst Instance=new A277781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277782
{
public static readonly long[] Value={ 0L,3L,12L,84L,498L,3090L,18930L,116382L,714810L,4391526L,26977818L,165732438L,1018135578L,6254670486L,38424042426L,236048762550L,1450108129242L,8908386492054L,54726504918906L,336198967755510L,2065356559176474L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277782Inst : IEnumerable<long>
{
public static readonly long[] Value=A277782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277782.Bytes);
public long this[int i]=>Value[i];

public static A277782Inst Instance=new A277782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277783
{
public static readonly long[] Value={ 0L,12L,80L,1434L,20663L,309612L,4604554L,68632481L,1022176517L,15228316440L,226848548570L,3379346295547L,50341485804399L,749929176699858L,11171570766745821L,166421064692483298L,2479147307681739840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277783Inst : IEnumerable<long>
{
public static readonly long[] Value=A277783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277783.Bytes);
public long this[int i]=>Value[i];

public static A277783Inst Instance=new A277783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277784
{
public static readonly BigInteger[] Value={ 0L,84L,1434L,79092L,3182256L,137510661L,5841628899L,249237125709L,10621140577245L,452773767226254L,19299515119524711L,822668369531493813L,BigInteger.Parse("35067058171919508894"),BigInteger.Parse("1494772106584270234932"),BigInteger.Parse("63716265812296128694056") };
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
public class A277784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277784Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277784.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277784Inst Instance=new A277784Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277785
{
public static readonly BigInteger[] Value={ 0L,498L,20663L,3182256L,352957610L,42007318111L,4917756016412L,578187054139243L,67894823921434433L,7975637730610293845L,BigInteger.Parse("936797683441112730176"),BigInteger.Parse("110037452200711077976009"),BigInteger.Parse("12925015739480417486637641") };
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
public class A277785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277785Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277785.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277785Inst Instance=new A277785Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277786
{
public static readonly BigInteger[] Value={ 0L,3090L,309612L,137510661L,42007318111L,13899171401510L,4515609963711003L,1473737617518590407L,BigInteger.Parse("480374435720722263006"),BigInteger.Parse("156638672145036363867108"),BigInteger.Parse("51070564234004691535574722"),BigInteger.Parse("16651612907609136712725059664") };
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
public class A277786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277786Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277786.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277786Inst Instance=new A277786Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277787
{
public static readonly BigInteger[] Value={ 0L,18930L,4604554L,5841628899L,4917756016412L,4515609963711003L,4064896184452097744L,BigInteger.Parse("3677191006496347808276"),BigInteger.Parse("3322023493506438374911424"),BigInteger.Parse("3002319024317622656410038946"),BigInteger.Parse("2713074413212233626315688367138") };
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
public class A277787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277787Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277787.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277787Inst Instance=new A277787Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277788
{
public static readonly long[] Value={ 0L,0L,0L,0L,3L,0L,0L,12L,12L,0L,0L,84L,80L,84L,0L,0L,498L,1434L,1434L,498L,0L,0L,3090L,20663L,79092L,20663L,3090L,0L,0L,18930L,309612L,3182256L,3182256L,309612L,18930L,0L,0L,116382L,4604554L,137510661L,352957610L,137510661L,4604554L,116382L,0L,0L,714810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277788Inst : IEnumerable<long>
{
public static readonly long[] Value=A277788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277788.Bytes);
public long this[int i]=>Value[i];

public static A277788Inst Instance=new A277788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277789
{
public static readonly long[] Value={ 1L,-1L,4L,-10L,23L,-59L,138L,-340L,813L,-1973L,4752L,-11486L,27715L,-66927L,161558L,-390056L,941657L,-2273385L,5488412L,-13250226L,31988847L,-77227939L,186444706L,-450117372L,1086679429L,-2623476253L,6333631912L,-15290740102L,36915112091L,-89120964311L,215157040686L,-519435045712L,1254027132081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277789Inst : IEnumerable<long>
{
public static readonly long[] Value=A277789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277789.Bytes);
public long this[int i]=>Value[i];

public static A277789Inst Instance=new A277789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277790
{
public static readonly long[] Value={ 0L,1L,1L,3L,1L,11L,1L,7L,4L,17L,1L,9L,1L,23L,23L,15L,1L,19L,1L,41L,31L,35L,1L,59L,6L,41L,13L,55L,1L,71L,1L,31L,47L,53L,47L,5L,1L,59L,55L,89L,1L,95L,1L,83L,77L,71L,1L,41L,8L,46L,71L,97L,1L,119L,71L,17L,79L,89L,1L,167L,1L,95L,103L,63L,83L,13L,1L,125L,95L,143L,1L,97L,1L,113L,41L,139L,95L,167L,1L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277790Inst : IEnumerable<long>
{
public static readonly long[] Value=A277790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277790.Bytes);
public long this[int i]=>Value[i];

public static A277790Inst Instance=new A277790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277791
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,6L,1L,4L,3L,10L,1L,4L,1L,14L,15L,8L,1L,9L,1L,20L,21L,22L,1L,24L,5L,26L,9L,28L,1L,30L,1L,16L,33L,34L,35L,2L,1L,38L,39L,40L,1L,42L,1L,44L,45L,46L,1L,16L,7L,25L,51L,52L,1L,54L,55L,8L,57L,58L,1L,60L,1L,62L,63L,32L,65L,6L,1L,68L,69L,70L,1L,36L,1L,74L,25L,76L,77L,78L,1L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277791Inst : IEnumerable<long>
{
public static readonly long[] Value=A277791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277791.Bytes);
public long this[int i]=>Value[i];

public static A277791Inst Instance=new A277791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277792
{
public static readonly long[] Value={ 0L,1L,196L,2601L,15376L,60025L,181476L,461041L,1032256L,2099601L,3960100L,7027801L,11861136L,19193161L,29964676L,45360225L,66846976L,96216481L,135629316L,187662601L,255360400L,342287001L,452583076L,591024721L,763085376L,975000625L,1233835876L,1547556921L,1925103376L,2376465001L,2912760900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277792Inst : IEnumerable<long>
{
public static readonly long[] Value=A277792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277792.Bytes);
public long this[int i]=>Value[i];

public static A277792Inst Instance=new A277792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277793
{
public static readonly long[] Value={ 1L,49L,169L,361L,961L,1369L,1849L,3721L,4489L,5329L,6241L,8281L,9409L,10609L,11881L,14641L,16129L,17689L,19321L,22801L,24649L,26569L,32761L,37249L,39601L,44521L,47089L,49729L,52441L,58081L,61009L,67081L,73441L,76729L,80089L,87616L,90601L,94249L,97969L,109561L,113569L,121801L,134689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277793Inst : IEnumerable<long>
{
public static readonly long[] Value=A277793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277793.Bytes);
public long this[int i]=>Value[i];

public static A277793Inst Instance=new A277793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277794
{
public static readonly long[] Value={ 4L,21L,85L,129L,201L,237L,324L,325L,517L,549L,669L,837L,865L,1081L,1137L,1161L,1165L,1309L,1389L,1677L,1765L,2169L,2233L,2304L,2305L,2469L,2709L,2737L,2761L,3265L,3297L,3745L,3961L,4161L,4285L,4693L,4705L,4741L,4989L,5061L,5221L,5349L,5817L,5949L,6249L,6457L,6517L,6685L,6789L,6813L,6853L,6921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277794Inst : IEnumerable<long>
{
public static readonly long[] Value=A277794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277794.Bytes);
public long this[int i]=>Value[i];

public static A277794Inst Instance=new A277794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277795
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,6L,11L,23L,47L,103L,223L,503L,1132L,2602L,5986L,13922L,32433L,75994L,178354L,419945L,990134L,2339033L,5531459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277795Inst : IEnumerable<long>
{
public static readonly long[] Value=A277795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277795.Bytes);
public long this[int i]=>Value[i];

public static A277795Inst Instance=new A277795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277844
{
public static readonly BigInteger[] Value={ 1L,81L,11328242L,29902254119865429L,BigInteger.Parse("817701868164546859278494745163"),BigInteger.Parse("285033249600409431428643990739291312182972084132"),BigInteger.Parse("1892438067444572851650149500498661434054764424790064535313952779756847"),BigInteger.Parse("339676614862729029614552301296020122485910436927008569295805654935518977116532247635480871741432") };
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
public class A277844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277844Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277844.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277844Inst Instance=new A277844Inst();

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