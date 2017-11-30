using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A190180
{
public static readonly long[] Value={ 1L,3L,5L,1L,2L,1L,1L,1L,2L,1L,12L,1L,5L,1L,1L,2L,1L,14L,2L,9L,11L,1L,12L,1L,2L,1L,832L,1L,2L,2L,5L,1L,1L,17L,1L,2L,1L,9L,1L,12L,1L,1L,1L,6L,3L,2L,1L,1L,6L,3L,1L,1L,1L,2L,2L,1L,3L,1L,3L,3L,1L,2L,1L,45L,1L,1L,1L,1L,62L,9L,1L,1L,2L,3L,1L,6L,1L,3L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190180Inst : IEnumerable<long>
{
public static readonly long[] Value=A190180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190180.Bytes);
public long this[int i]=>Value[i];

public static A190180Inst Instance=new A190180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190181
{
public static readonly long[] Value={ 3L,0L,4L,6L,9L,8L,8L,2L,2L,1L,0L,7L,0L,6L,5L,2L,0L,5L,6L,2L,2L,7L,8L,2L,8L,4L,8L,3L,2L,5L,0L,0L,9L,8L,7L,2L,9L,8L,0L,7L,0L,8L,8L,3L,6L,0L,9L,7L,5L,6L,5L,8L,1L,6L,9L,6L,1L,0L,9L,4L,1L,7L,1L,0L,4L,7L,6L,3L,1L,1L,1L,7L,8L,1L,0L,5L,7L,1L,6L,9L,9L,8L,9L,2L,9L,5L,0L,4L,3L,6L,8L,7L,8L,2L,3L,8L,3L,4L,1L,4L,2L,6L,6L,9L,7L,3L,2L,7L,0L,4L,4L,1L,3L,0L,0L,1L,0L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190181Inst : IEnumerable<long>
{
public static readonly long[] Value=A190181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190181.Bytes);
public long this[int i]=>Value[i];

public static A190181Inst Instance=new A190181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190182
{
public static readonly long[] Value={ 2L,2L,1L,0L,2L,7L,5L,5L,3L,2L,8L,1L,9L,0L,2L,0L,9L,6L,8L,7L,7L,8L,9L,7L,1L,3L,5L,2L,5L,0L,4L,8L,8L,7L,0L,5L,3L,3L,0L,4L,0L,8L,6L,3L,2L,9L,6L,7L,8L,3L,7L,4L,2L,9L,4L,7L,2L,8L,5L,6L,9L,4L,9L,7L,7L,4L,3L,9L,8L,4L,2L,5L,8L,6L,2L,0L,8L,9L,5L,9L,9L,2L,5L,0L,3L,7L,1L,1L,9L,9L,2L,9L,9L,8L,6L,7L,6L,0L,9L,2L,1L,4L,0L,3L,5L,9L,1L,3L,1L,1L,0L,6L,7L,8L,2L,5L,3L,3L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190182Inst : IEnumerable<long>
{
public static readonly long[] Value=A190182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190182.Bytes);
public long this[int i]=>Value[i];

public static A190182Inst Instance=new A190182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190183
{
public static readonly long[] Value={ 2L,4L,1L,3L,10L,1L,3L,1L,1L,2L,66L,1L,4L,2L,1L,1L,48L,5L,1L,1L,2L,1L,1L,1L,8L,2L,1L,1L,4L,16L,2L,2L,1L,4L,1L,3L,1L,3L,1L,11L,1L,1L,8L,16L,1L,1L,1L,10L,1L,2L,4L,1L,1L,1L,3L,1L,1L,1L,1L,30L,1L,1L,2L,1L,1L,8L,13L,1L,1L,6L,6L,1L,6L,1L,1L,2L,2L,10L,1L,2L,7L,9L,2L,4L,7L,3L,1L,2L,2L,1L,2L,5L,4L,2L,3L,2L,3L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190183Inst : IEnumerable<long>
{
public static readonly long[] Value=A190183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190183.Bytes);
public long this[int i]=>Value[i];

public static A190183Inst Instance=new A190183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190184
{
public static readonly long[] Value={ 1L,8L,5L,4L,4L,9L,3L,6L,3L,0L,0L,4L,2L,5L,5L,8L,2L,6L,3L,6L,8L,3L,6L,4L,0L,1L,3L,2L,4L,5L,2L,7L,7L,8L,4L,7L,7L,7L,7L,8L,2L,7L,6L,9L,5L,4L,6L,6L,9L,8L,2L,5L,0L,1L,4L,1L,6L,9L,0L,5L,0L,1L,9L,7L,0L,4L,8L,4L,8L,9L,4L,1L,7L,1L,3L,9L,8L,0L,4L,0L,1L,8L,3L,1L,9L,4L,2L,0L,4L,5L,9L,9L,1L,9L,9L,8L,5L,0L,0L,8L,7L,1L,8L,7L,1L,6L,4L,7L,1L,6L,8L,8L,3L,4L,6L,2L,2L,8L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190184Inst : IEnumerable<long>
{
public static readonly long[] Value=A190184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190184.Bytes);
public long this[int i]=>Value[i];

public static A190184Inst Instance=new A190184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190185
{
public static readonly long[] Value={ 1L,1L,5L,1L,6L,1L,5L,1L,1L,40L,1L,1L,1L,1L,1L,1L,1L,13L,1L,1L,1L,5L,1L,15L,1L,3L,1L,2L,2L,5L,1L,1L,1L,1L,4L,5L,65L,1L,13L,1L,3L,4L,1L,1L,1L,4L,13L,1L,1L,2L,1L,3L,2L,2L,1L,10L,1L,20L,4L,15L,6L,1L,3L,10L,1L,78L,1L,1L,11L,15L,1L,11L,179L,2L,1L,2L,1L,1L,1L,6L,1L,1L,1L,2L,3L,2L,6L,1L,1L,7L,5L,1L,4L,1L,9L,1L,1L,2L,10L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190185Inst : IEnumerable<long>
{
public static readonly long[] Value=A190185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190185.Bytes);
public long this[int i]=>Value[i];

public static A190185Inst Instance=new A190185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190186
{
public static readonly BigInteger[] Value={ 1L,2L,10L,29L,97L,739L,6331L,8617L,633127L,1037497L,90414391L,1214394319L,17506484887L,38519714137L,4419404086711L,10972377997177L,1410921315134167L,27316952872520239L,555986170009834231L,154130283599461067L,BigInteger.Parse("265123004099257677847"),BigInteger.Parse("883735015159907270617"),BigInteger.Parse("150492959376114678237751"),BigInteger.Parse("293138621437723505079883"),BigInteger.Parse("100289605416287509517021527") };
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
public class A190186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190186Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190186.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190186Inst Instance=new A190186Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190187
{
public static readonly BigInteger[] Value={ 1L,1L,3L,6L,15L,90L,630L,720L,45360L,64800L,4989600L,59875200L,778377600L,1556755200L,163459296000L,373621248000L,44460928512000L,800296713216000L,15205637551104000L,3949516247040000L,6386367771463680000L,BigInteger.Parse("20071441567457280000"),BigInteger.Parse("3231502092360622080000"),BigInteger.Parse("5965850016665763840000"),BigInteger.Parse("1938901255416373248000000"),BigInteger.Parse("7201633234403672064000000") };
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
public class A190187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190187Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190187.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190187Inst Instance=new A190187Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190268
{
public static readonly long[] Value={ 1L,1L,3L,3L,3L,3L,5L,5L,5L,3L,3L,13L,3L,5L,1L,3L,7L,9L,5L,7L,1L,15L,5L,7L,3L,9L,9L,3L,7L,13L,11L,3L,3L,7L,9L,13L,3L,23L,13L,15L,7L,13L,5L,21L,11L,9L,9L,13L,9L,5L,3L,15L,3L,9L,11L,9L,9L,9L,17L,15L,5L,7L,9L,7L,7L,21L,19L,7L,11L,43L,35L,11L,25L,11L,5L,7L,7L,37L,27L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190268Inst : IEnumerable<long>
{
public static readonly long[] Value=A190268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190268.Bytes);
public long this[int i]=>Value[i];

public static A190268Inst Instance=new A190268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190269
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,7L,9L,12L,15L,18L,21L,25L,29L,33L,37L,42L,47L,52L,57L,63L,69L,76L,83L,90L,97L,106L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190269Inst : IEnumerable<long>
{
public static readonly long[] Value=A190269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190269.Bytes);
public long this[int i]=>Value[i];

public static A190269Inst Instance=new A190269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190270
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,49L,169L,605L,2226L,8364L,31956L,123770L,484862L,1917800L,7648470L,30722318L,124180334L,504720369L,2061489396L,8457050387L,34831589583L,143972841512L,597034531410L,2483173470124L,10356092457386L,43298360910159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190270Inst : IEnumerable<long>
{
public static readonly long[] Value=A190270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190270.Bytes);
public long this[int i]=>Value[i];

public static A190270Inst Instance=new A190270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190271
{
public static readonly long[] Value={ 1L,1L,4L,22L,141L,986L,7295L,56145L,444900L,3605429L,29742671L,248933630L,2108590305L,18042013096L,155711676129L,1353913728412L,11849013783676L,104293377329508L,922643326714355L,8199321046129671L,73162599757076951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190271Inst : IEnumerable<long>
{
public static readonly long[] Value=A190271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190271.Bytes);
public long this[int i]=>Value[i];

public static A190271Inst Instance=new A190271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190272
{
public static readonly long[] Value={ 6L,14L,15L,22L,33L,38L,46L,51L,62L,86L,87L,91L,95L,118L,141L,142L,145L,158L,159L,166L,206L,249L,262L,267L,278L,287L,295L,321L,326L,382L,395L,398L,411L,422L,445L,446L,473L,502L,519L,537L,542L,545L,581L,591L,622L,662L,695L,699L,703L,718L,745L,758L,766L,789L,838L,886L,895L,926L,951L,958L,995L,998L,1046L,1126L,1139L,1145L,1167L,1199L,1238L,1262L,1318L,1329L,1347L,1382L,1401L,1441L,1486L,1678L,1707L,1717L,1718L,1726L,1745L,1757L,1761L,1766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190272Inst : IEnumerable<long>
{
public static readonly long[] Value=A190272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190272.Bytes);
public long this[int i]=>Value[i];

public static A190272Inst Instance=new A190272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190273
{
public static readonly long[] Value={ 6L,10L,21L,26L,39L,55L,57L,74L,93L,111L,122L,146L,155L,201L,203L,253L,301L,305L,314L,327L,381L,386L,417L,471L,497L,543L,554L,597L,626L,633L,689L,737L,755L,791L,794L,842L,889L,905L,914L,921L,1011L,1027L,1055L,1081L,1082L,1137L,1226L,1227L,1322L,1346L,1379L,1461L,1466L,1477L,1497L,1514L,1623L,1655L,1703L,1711L,1713L,1731L,1751L,1754L,1893L,1967L,1994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190273Inst : IEnumerable<long>
{
public static readonly long[] Value=A190273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190273.Bytes);
public long this[int i]=>Value[i];

public static A190273Inst Instance=new A190273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190274
{
public static readonly long[] Value={ 15L,95L,287L,1199L,4607L,23519L,28799L,101567L,223199L,296207L,352799L,903167L,1019999L,2032127L,2230799L,2666159L,3285599L,5896799L,7606367L,13939199L,19392479L,28839887L,36154799L,46139039L,54295919L,62412767L,68250239L,73384079L,74440799L,90316799L,95234687L,109672319L,115263647L,118129199L,214562399L,223279487L,234503807L,236792879L,262963199L,270420767L,309829727L,355897439L,422999999L,486823247L,589884959L,628687487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190274Inst : IEnumerable<long>
{
public static readonly long[] Value=A190274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190274.Bytes);
public long this[int i]=>Value[i];

public static A190274Inst Instance=new A190274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190275
{
public static readonly long[] Value={ 6L,21L,301L,2041L,296341L,486877L,2666437L,3420301L,4304341L,7152001L,38159521L,42387097L,54296677L,95235601L,158048281L,229971241L,265434901L,383712781L,454166017L,775307917L,972261181L,1063290841L,1304557801L,1392422041L,1730882401L,1863895261L,2631883561L,2879450461L,3714274297L,3845297341L,4070454361L,4256780041L,4849695001L,5328809461L,5722533337L,5838483601L,7218898681L,7841065621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190275Inst : IEnumerable<long>
{
public static readonly long[] Value=A190275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190275.Bytes);
public long this[int i]=>Value[i];

public static A190275Inst Instance=new A190275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190276
{
public static readonly long[] Value={ 2L,3L,6L,9L,15L,17L,21L,28L,30L,36L,43L,46L,47L,51L,54L,62L,69L,71L,72L,75L,80L,90L,92L,93L,96L,99L,101L,102L,107L,108L,109L,110L,114L,118L,120L,122L,124L,133L,135L,141L,150L,151L,152L,156L,160L,161L,164L,170L,171L,174L,196L,197L,206L,207L,208L,210L,212L,216L,223L,226L,231L,235L,236L,238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190276Inst : IEnumerable<long>
{
public static readonly long[] Value=A190276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190276.Bytes);
public long this[int i]=>Value[i];

public static A190276Inst Instance=new A190276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190277
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,23L,62L,174L,497L,1433L,4150L,12044L,34989L,101695L,295642L,859566L,2499277L,7267081L,21130538L,61441732L,178655937L,519483767L,1510520966L,4392195390L,12771343961L,37135696841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190277Inst : IEnumerable<long>
{
public static readonly long[] Value=A190277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190277.Bytes);
public long this[int i]=>Value[i];

public static A190277Inst Instance=new A190277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190278
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,4L,5L,6L,7L,9L,10L,12L,13L,15L,17L,20L,21L,25L,27L,29L,31L,36L,38L,42L,44L,48L,51L,56L,58L,64L,67L,72L,75L,80L,83L,90L,94L,99L,103L,111L,113L,122L,126L,131L,136L,145L,149L,157L,162L,168L,173L,184L,188L,196L,201L,209L,215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190278Inst : IEnumerable<long>
{
public static readonly long[] Value=A190278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190278.Bytes);
public long this[int i]=>Value[i];

public static A190278Inst Instance=new A190278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190279
{
public static readonly long[] Value={ 2L,4L,7L,10L,13L,15L,18L,21L,23L,27L,29L,32L,35L,37L,40L,43L,46L,48L,51L,54L,56L,59L,62L,65L,67L,71L,73L,75L,79L,81L,84L,87L,90L,92L,94L,98L,100L,103L,106L,109L,111L,114L,117L,119L,123L,125L,127L,131L,133L,136L,138L,142L,144L,146L,150L,152L,155L,158L,161L,163L,166L,169L,171L,175L,177L,180L,182L,185L,188L,190L,194L,196L,199L,202L,204L,207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190279Inst : IEnumerable<long>
{
public static readonly long[] Value=A190279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190279.Bytes);
public long this[int i]=>Value[i];

public static A190279Inst Instance=new A190279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190280
{
public static readonly long[] Value={ 1L,3L,5L,8L,9L,11L,14L,16L,17L,20L,22L,24L,26L,28L,30L,33L,34L,36L,39L,41L,42L,45L,47L,49L,52L,53L,55L,58L,60L,61L,64L,66L,68L,70L,72L,74L,76L,78L,80L,82L,85L,86L,88L,91L,93L,95L,97L,99L,101L,104L,105L,107L,110L,112L,113L,116L,118L,120L,122L,124L,126L,129L,130L,132L,135L,137L,139L,141L,143L,145L,148L,149L,151L,153L,156L,157L,159L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190280Inst : IEnumerable<long>
{
public static readonly long[] Value=A190280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190280.Bytes);
public long this[int i]=>Value[i];

public static A190280Inst Instance=new A190280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190281
{
public static readonly long[] Value={ 1L,8L,0L,5L,7L,9L,0L,8L,9L,4L,6L,5L,4L,3L,5L,7L,4L,9L,0L,4L,4L,0L,6L,4L,5L,5L,5L,7L,3L,4L,5L,5L,2L,7L,4L,1L,7L,8L,2L,9L,2L,2L,9L,0L,5L,8L,6L,1L,5L,6L,3L,1L,7L,8L,0L,3L,3L,2L,7L,5L,1L,4L,4L,7L,8L,3L,8L,2L,4L,1L,2L,9L,2L,7L,8L,6L,3L,3L,8L,3L,3L,0L,5L,6L,1L,7L,2L,9L,8L,3L,3L,5L,2L,0L,2L,3L,6L,7L,1L,1L,8L,6L,6L,4L,1L,2L,8L,4L,3L,8L,9L,2L,1L,9L,0L,2L,6L,9L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190281Inst : IEnumerable<long>
{
public static readonly long[] Value=A190281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190281.Bytes);
public long this[int i]=>Value[i];

public static A190281Inst Instance=new A190281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190282
{
public static readonly long[] Value={ 1L,1L,4L,6L,1L,2L,2L,2L,1L,1L,6L,1L,179L,46L,1L,1L,3L,2L,1L,1L,3L,6L,3L,1L,1L,1L,1L,2L,1L,1L,56L,1L,1L,1L,1L,66L,1L,1L,2L,17L,8L,2L,7L,12L,1L,1L,8L,1L,2L,2L,1L,1L,2L,1L,12L,1L,2L,2L,2L,2L,1L,1L,1L,8L,1L,1L,1L,1L,2L,1L,2L,5L,1L,6L,8L,1L,1L,1L,2L,7L,1L,9L,1L,2L,5L,7L,1L,6L,1L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190282Inst : IEnumerable<long>
{
public static readonly long[] Value=A190282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190282.Bytes);
public long this[int i]=>Value[i];

public static A190282Inst Instance=new A190282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190283
{
public static readonly long[] Value={ 2L,5L,5L,3L,7L,7L,3L,9L,7L,4L,0L,3L,0L,0L,3L,7L,3L,0L,7L,3L,4L,4L,1L,5L,8L,9L,5L,3L,0L,6L,3L,1L,4L,6L,9L,4L,8L,1L,6L,4L,5L,8L,3L,4L,9L,9L,4L,1L,0L,3L,0L,7L,8L,3L,6L,3L,3L,2L,6L,7L,1L,1L,4L,8L,3L,3L,3L,6L,7L,5L,2L,5L,6L,7L,8L,8L,7L,3L,3L,1L,0L,2L,7L,2L,7L,9L,3L,7L,8L,8L,6L,1L,1L,7L,4L,3L,6L,7L,7L,4L,4L,9L,2L,8L,8L,3L,7L,3L,3L,5L,4L,3L,6L,6L,6L,6L,6L,6L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190283Inst : IEnumerable<long>
{
public static readonly long[] Value=A190283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190283.Bytes);
public long this[int i]=>Value[i];

public static A190283Inst Instance=new A190283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190364
{
public static readonly long[] Value={ 2L,5L,8L,11L,15L,18L,20L,24L,27L,31L,33L,36L,39L,43L,46L,49L,51L,56L,58L,62L,64L,67L,71L,74L,77L,80L,84L,87L,89L,93L,95L,100L,102L,105L,108L,112L,115L,118L,120L,124L,127L,131L,133L,136L,140L,143L,146L,149L,153L,156L,158L,162L,164L,169L,171L,174L,177L,181L,184L,187L,189L,193L,196L,200L,202L,205L,209L,212L,215L,218L,220L,225L,227L,231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190364Inst : IEnumerable<long>
{
public static readonly long[] Value=A190364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190364.Bytes);
public long this[int i]=>Value[i];

public static A190364Inst Instance=new A190364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190365
{
public static readonly long[] Value={ 5L,11L,18L,24L,31L,36L,43L,49L,56L,62L,67L,74L,80L,87L,93L,100L,105L,112L,118L,124L,131L,136L,143L,149L,156L,162L,169L,174L,181L,187L,193L,200L,205L,212L,218L,225L,231L,238L,243L,249L,256L,262L,269L,274L,281L,287L,294L,300L,307L,312L,318L,325L,331L,338L,343L,350L,356L,363L,369L,374L,381L,387L,394L,400L,407L,412L,419L,425L,432L,438L,443L,450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190365Inst : IEnumerable<long>
{
public static readonly long[] Value=A190365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190365.Bytes);
public long this[int i]=>Value[i];

public static A190365Inst Instance=new A190365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190366
{
public static readonly long[] Value={ 1L,3L,7L,9L,12L,14L,16L,19L,22L,25L,26L,29L,32L,34L,38L,40L,41L,45L,47L,50L,53L,54L,57L,60L,63L,65L,69L,70L,72L,76L,78L,81L,83L,85L,88L,91L,94L,96L,98L,101L,103L,107L,109L,110L,114L,116L,119L,122L,125L,126L,129L,132L,134L,138L,139L,141L,145L,147L,150L,152L,154L,157L,160L,163L,165L,167L,170L,172L,176L,178L,179L,183L,185L,188L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190366Inst : IEnumerable<long>
{
public static readonly long[] Value=A190366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190366.Bytes);
public long this[int i]=>Value[i];

public static A190366Inst Instance=new A190366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190367
{
public static readonly long[] Value={ 7L,14L,22L,29L,38L,45L,53L,60L,69L,76L,83L,91L,98L,107L,114L,122L,129L,138L,145L,152L,160L,167L,176L,183L,191L,198L,207L,214L,222L,229L,236L,245L,252L,260L,267L,276L,283L,291L,298L,305L,314L,321L,329L,336L,345L,352L,360L,367L,376L,383L,390L,398L,405L,414L,421L,429L,436L,445L,452L,459L,467L,474L,483L,490L,498L,505L,514L,521L,529L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190367Inst : IEnumerable<long>
{
public static readonly long[] Value=A190367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190367.Bytes);
public long this[int i]=>Value[i];

public static A190367Inst Instance=new A190367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190368
{
public static readonly long[] Value={ 3L,8L,12L,17L,21L,26L,30L,35L,39L,44L,48L,53L,57L,62L,66L,71L,75L,80L,84L,89L,93L,98L,103L,107L,112L,116L,121L,125L,129L,134L,139L,143L,148L,152L,157L,161L,165L,170L,175L,180L,184L,188L,193L,198L,201L,207L,211L,216L,220L,224L,229L,234L,237L,243L,246L,252L,256L,260L,266L,270L,274L,279L,283L,288L,293L,296L,302L,306L,310L,315L,319L,324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190368Inst : IEnumerable<long>
{
public static readonly long[] Value=A190368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190368.Bytes);
public long this[int i]=>Value[i];

public static A190368Inst Instance=new A190368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190369
{
public static readonly long[] Value={ 2L,5L,9L,11L,14L,19L,22L,25L,28L,31L,34L,38L,41L,45L,47L,51L,54L,58L,61L,64L,68L,70L,74L,78L,81L,83L,87L,90L,95L,97L,100L,104L,106L,109L,114L,117L,120L,123L,126L,131L,133L,137L,140L,142L,146L,150L,153L,156L,159L,163L,166L,169L,173L,176L,179L,182L,186L,190L,192L,195L,199L,202L,206L,209L,212L,215L,218L,221L,226L,228L,232L,235L,238L,241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190369Inst : IEnumerable<long>
{
public static readonly long[] Value=A190369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190369.Bytes);
public long this[int i]=>Value[i];

public static A190369Inst Instance=new A190369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190370
{
public static readonly long[] Value={ 1L,4L,6L,10L,13L,15L,18L,20L,23L,27L,29L,32L,36L,37L,40L,43L,46L,49L,52L,55L,56L,60L,63L,65L,69L,72L,73L,77L,79L,82L,86L,88L,91L,94L,96L,99L,102L,105L,108L,110L,113L,115L,118L,122L,124L,127L,130L,132L,135L,138L,141L,144L,147L,149L,151L,155L,158L,160L,164L,167L,168L,172L,174L,177L,181L,183L,185L,189L,191L,194L,197L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190370Inst : IEnumerable<long>
{
public static readonly long[] Value=A190370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190370.Bytes);
public long this[int i]=>Value[i];

public static A190370Inst Instance=new A190370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190371
{
public static readonly long[] Value={ 7L,16L,24L,33L,42L,50L,59L,67L,76L,85L,92L,101L,111L,119L,128L,136L,145L,154L,162L,171L,178L,187L,196L,204L,213L,223L,231L,240L,248L,257L,265L,273L,282L,291L,299L,308L,316L,325L,335L,343L,351L,359L,368L,377L,385L,394L,403L,411L,420L,428L,437L,446L,454L,463L,471L,480L,489L,497L,506L,515L,523L,531L,539L,548L,558L,566L,575L,584L,592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190371Inst : IEnumerable<long>
{
public static readonly long[] Value=A190371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190371.Bytes);
public long this[int i]=>Value[i];

public static A190371Inst Instance=new A190371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190372
{
public static readonly long[] Value={ 5L,13L,20L,28L,35L,42L,50L,57L,65L,71L,78L,86L,94L,101L,108L,115L,123L,131L,136L,144L,151L,159L,167L,173L,181L,189L,196L,204L,209L,217L,225L,232L,240L,247L,254L,262L,269L,275L,283L,290L,298L,305L,312L,320L,327L,335L,343L,348L,356L,363L,371L,379L,385L,393L,400L,408L,414L,421L,429L,437L,444L,451L,458L,466L,474L,481L,487L,495L,502L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190372Inst : IEnumerable<long>
{
public static readonly long[] Value=A190372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190372.Bytes);
public long this[int i]=>Value[i];

public static A190372Inst Instance=new A190372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190373
{
public static readonly long[] Value={ 1L,4L,6L,9L,11L,14L,16L,18L,22L,24L,26L,29L,32L,33L,37L,38L,41L,45L,46L,49L,51L,54L,56L,59L,61L,64L,67L,69L,72L,74L,77L,79L,82L,85L,87L,90L,91L,95L,97L,99L,102L,104L,107L,110L,112L,114L,118L,119L,122L,124L,127L,130L,132L,135L,137L,140L,142L,145L,147L,150L,153L,155L,157L,160L,163L,164L,168L,171L,172L,176L,177L,180L,183L,185L,187L,190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190373Inst : IEnumerable<long>
{
public static readonly long[] Value=A190373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190373.Bytes);
public long this[int i]=>Value[i];

public static A190373Inst Instance=new A190373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190374
{
public static readonly long[] Value={ 3L,8L,12L,17L,21L,25L,30L,34L,39L,44L,48L,53L,58L,62L,66L,70L,75L,80L,84L,89L,93L,98L,103L,106L,111L,116L,120L,125L,129L,134L,139L,143L,148L,152L,156L,161L,165L,170L,175L,179L,184L,188L,192L,197L,201L,206L,211L,215L,220L,224L,229L,234L,237L,242L,246L,251L,256L,260L,265L,270L,274L,278L,282L,287L,292L,296L,301L,306L,310L,315L,319L,323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190374Inst : IEnumerable<long>
{
public static readonly long[] Value=A190374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190374.Bytes);
public long this[int i]=>Value[i];

public static A190374Inst Instance=new A190374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190375
{
public static readonly long[] Value={ 2L,7L,10L,15L,19L,23L,27L,31L,36L,40L,43L,47L,52L,55L,60L,63L,68L,73L,76L,81L,83L,88L,92L,96L,100L,105L,109L,113L,117L,121L,126L,128L,133L,138L,141L,146L,149L,154L,158L,162L,166L,169L,174L,178L,182L,186L,191L,194L,199L,202L,207L,212L,214L,219L,222L,227L,231L,235L,239L,244L,248L,252L,255L,259L,264L,267L,272L,277L,280L,285L,288L,293L,297L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190375Inst : IEnumerable<long>
{
public static readonly long[] Value=A190375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190375.Bytes);
public long this[int i]=>Value[i];

public static A190375Inst Instance=new A190375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190376
{
public static readonly long[] Value={ 1L,4L,12L,31L,75L,175L,393L,864L,1868L,3978L,8394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190376Inst : IEnumerable<long>
{
public static readonly long[] Value=A190376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190376.Bytes);
public long this[int i]=>Value[i];

public static A190376Inst Instance=new A190376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190377
{
public static readonly long[] Value={ 44100L,108900L,152100L,213444L,260100L,298116L,324900L,476100L,509796L,592900L,636804L,736164L,756900L,828100L,864900L,933156L,1232100L,1258884L,1334025L,1416100L,1483524L,1512900L,1572516L,1664100L,1695204L,1758276L,1768900L,1863225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190377Inst : IEnumerable<long>
{
public static readonly long[] Value=A190377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190377.Bytes);
public long this[int i]=>Value[i];

public static A190377Inst Instance=new A190377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190378
{
public static readonly long[] Value={ 120120L,157080L,175560L,185640L,207480L,212520L,251160L,267960L,270270L,271320L,286440L,291720L,316680L,326040L,328440L,338520L,341880L,353430L,367080L,378840L,394680L,395010L,397320L,404040L,408408L,414120L,417690L,426360L,434280L,442680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190378Inst : IEnumerable<long>
{
public static readonly long[] Value=A190378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190378.Bytes);
public long this[int i]=>Value[i];

public static A190378Inst Instance=new A190378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190379
{
public static readonly long[] Value={ 69300L,81900L,97020L,107100L,114660L,119700L,128700L,144900L,149940L,152460L,161700L,167580L,168300L,182700L,188100L,191100L,195300L,198900L,202860L,212940L,222300L,227700L,233100L,242550L,249900L,252252L,254100L,255780L,258300L,269100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190379Inst : IEnumerable<long>
{
public static readonly long[] Value=A190379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190379.Bytes);
public long this[int i]=>Value[i];

public static A190379Inst Instance=new A190379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190444
{
public static readonly BigInteger[] Value={ 1L,1L,3L,7L,49L,201L,1411L,7183L,68097L,453169L,4523491L,34273911L,403454833L,3618761017L,45157828899L,445900023871L,6206361667201L,69111310499553L,1017103374816067L,12237616620289639L,195222691795726641L,2575612811875082281L,BigInteger.Parse("43240905591424459843"),BigInteger.Parse("608870179599833137647") };
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
public class A190444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190444Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190444.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190444Inst Instance=new A190444Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190445
{
public static readonly long[] Value={ 3L,1L,4L,2L,0L,3L,1L,4L,2L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,2L,4L,3L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,1L,4L,2L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,2L,4L,3L,1L,4L,2L,0L,3L,1L,4L,2L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,2L,4L,2L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,2L,0L,3L,1L,4L,2L,0L,3L,1L,4L,2L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,2L,4L,3L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,1L,4L,2L,1L,3L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190445Inst : IEnumerable<long>
{
public static readonly long[] Value=A190445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190445.Bytes);
public long this[int i]=>Value[i];

public static A190445Inst Instance=new A190445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190446
{
public static readonly long[] Value={ 5L,13L,26L,34L,47L,60L,68L,81L,89L,94L,102L,115L,123L,136L,149L,157L,170L,178L,191L,204L,212L,225L,233L,238L,246L,259L,267L,280L,293L,301L,314L,322L,335L,348L,356L,369L,382L,390L,403L,411L,424L,437L,445L,458L,466L,471L,479L,492L,500L,513L,526L,534L,547L,555L,568L,581L,589L,602L,610L,615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190446Inst : IEnumerable<long>
{
public static readonly long[] Value=A190446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190446.Bytes);
public long this[int i]=>Value[i];

public static A190446Inst Instance=new A190446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190447
{
public static readonly long[] Value={ 2L,7L,10L,15L,18L,23L,28L,31L,36L,39L,41L,44L,49L,52L,57L,62L,65L,70L,73L,78L,83L,86L,91L,96L,99L,104L,107L,112L,117L,120L,125L,128L,130L,133L,138L,141L,146L,151L,154L,159L,162L,167L,172L,175L,180L,183L,185L,188L,193L,196L,201L,206L,209L,214L,217L,222L,227L,230L,235L,240L,243L,248L,251L,256L,261L,264L,269L,272L,274L,277L,282L,285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190447Inst : IEnumerable<long>
{
public static readonly long[] Value=A190447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190447.Bytes);
public long this[int i]=>Value[i];

public static A190447Inst Instance=new A190447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190448
{
public static readonly long[] Value={ 4L,9L,12L,17L,20L,25L,30L,33L,38L,43L,46L,51L,54L,59L,64L,67L,72L,75L,77L,80L,85L,88L,93L,98L,101L,106L,109L,114L,119L,122L,127L,132L,135L,140L,143L,148L,153L,156L,161L,164L,166L,169L,174L,177L,182L,187L,190L,195L,198L,203L,208L,211L,216L,219L,221L,224L,229L,232L,237L,242L,245L,250L,253L,258L,263L,266L,271L,276L,279L,284L,287L,292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190448Inst : IEnumerable<long>
{
public static readonly long[] Value=A190448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190448.Bytes);
public long this[int i]=>Value[i];

public static A190448Inst Instance=new A190448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190449
{
public static readonly long[] Value={ 1L,6L,11L,14L,19L,22L,24L,27L,32L,35L,40L,45L,48L,53L,56L,61L,66L,69L,74L,79L,82L,87L,90L,95L,100L,103L,108L,111L,113L,116L,121L,124L,129L,134L,137L,142L,145L,150L,155L,158L,163L,168L,171L,176L,179L,184L,189L,192L,197L,200L,202L,205L,210L,213L,218L,223L,226L,231L,234L,239L,244L,247L,252L,255L,257L,260L,265L,268L,273L,278L,281L,286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190449Inst : IEnumerable<long>
{
public static readonly long[] Value=A190449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190449.Bytes);
public long this[int i]=>Value[i];

public static A190449Inst Instance=new A190449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190450
{
public static readonly long[] Value={ 3L,8L,16L,21L,29L,37L,42L,50L,55L,58L,63L,71L,76L,84L,92L,97L,105L,110L,118L,126L,131L,139L,144L,147L,152L,160L,165L,173L,181L,186L,194L,199L,207L,215L,220L,228L,236L,241L,249L,254L,262L,270L,275L,283L,288L,291L,296L,304L,309L,317L,325L,330L,338L,343L,351L,359L,364L,372L,377L,380L,385L,393L,398L,406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190450Inst : IEnumerable<long>
{
public static readonly long[] Value=A190450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190450.Bytes);
public long this[int i]=>Value[i];

public static A190450Inst Instance=new A190450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190451
{
public static readonly long[] Value={ 2L,1L,3L,2L,0L,3L,1L,4L,2L,0L,3L,1L,0L,2L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,2L,0L,2L,1L,3L,2L,0L,3L,1L,0L,2L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,1L,0L,2L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,2L,0L,3L,1L,3L,2L,0L,3L,1L,0L,2L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,2L,0L,2L,1L,3L,2L,0L,3L,1L,0L,2L,1L,3L,2L,0L,3L,1L,4L,2L,0L,3L,1L,0L,2L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,2L,0L,3L,1L,3L,2L,0L,3L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190451Inst : IEnumerable<long>
{
public static readonly long[] Value=A190451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190451.Bytes);
public long this[int i]=>Value[i];

public static A190451Inst Instance=new A190451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190452
{
public static readonly long[] Value={ 1L,1L,2L,4L,11L,31L,106L,372L,1499L,6211L,28606L,135356L,697357L,3688049L,20935006L,121837276L,753159801L,4767863657L,31807384354L,217048147396L,1551200297291L,11327527814191L,86206555248122L,669666314150164L,5399592811359331L,44398500646885851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190452Inst : IEnumerable<long>
{
public static readonly long[] Value=A190452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190452.Bytes);
public long this[int i]=>Value[i];

public static A190452Inst Instance=new A190452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190453
{
public static readonly long[] Value={ 2L,7L,12L,15L,20L,23L,28L,33L,36L,41L,44L,46L,49L,54L,57L,62L,67L,70L,75L,78L,83L,88L,91L,96L,101L,104L,109L,112L,117L,122L,125L,130L,133L,135L,138L,143L,146L,151L,156L,159L,164L,167L,172L,177L,180L,185L,190L,193L,198L,201L,206L,211L,214L,219L,222L,224L,227L,232L,235L,240L,245L,248L,253L,256L,261L,266L,269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190453Inst : IEnumerable<long>
{
public static readonly long[] Value=A190453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190453.Bytes);
public long this[int i]=>Value[i];

public static A190453Inst Instance=new A190453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190454
{
public static readonly long[] Value={ 1L,4L,9L,14L,17L,22L,25L,27L,30L,35L,38L,43L,48L,51L,56L,59L,64L,69L,72L,77L,80L,82L,85L,90L,93L,98L,103L,106L,111L,114L,119L,124L,127L,132L,137L,140L,145L,148L,153L,158L,161L,166L,169L,171L,174L,179L,182L,187L,192L,195L,200L,203L,208L,213L,216L,221L,226L,229L,234L,237L,242L,247L,250L,255L,258L,260L,263L,268L,271L,276L,281L,284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190454Inst : IEnumerable<long>
{
public static readonly long[] Value=A190454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190454.Bytes);
public long this[int i]=>Value[i];

public static A190454Inst Instance=new A190454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190455
{
public static readonly long[] Value={ 6L,11L,16L,19L,24L,29L,32L,37L,40L,45L,50L,53L,58L,61L,63L,66L,71L,74L,79L,84L,87L,92L,95L,100L,105L,108L,113L,116L,118L,121L,126L,129L,134L,139L,142L,147L,150L,155L,160L,163L,168L,173L,176L,181L,184L,189L,194L,197L,202L,205L,207L,210L,215L,218L,223L,228L,231L,236L,239L,244L,249L,252L,257L,262L,265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190455Inst : IEnumerable<long>
{
public static readonly long[] Value=A190455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190455.Bytes);
public long this[int i]=>Value[i];

public static A190455Inst Instance=new A190455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190456
{
public static readonly long[] Value={ 8L,21L,42L,55L,76L,97L,110L,131L,144L,152L,165L,186L,199L,220L,241L,254L,275L,288L,309L,330L,343L,364L,377L,385L,398L,419L,432L,453L,474L,487L,508L,521L,542L,563L,576L,597L,618L,631L,652L,665L,686L,707L,720L,741L,754L,762L,775L,796L,809L,830L,851L,864L,885L,898L,919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190456Inst : IEnumerable<long>
{
public static readonly long[] Value=A190456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190456.Bytes);
public long this[int i]=>Value[i];

public static A190456Inst Instance=new A190456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190457
{
public static readonly long[] Value={ 3L,1L,4L,2L,1L,3L,2L,4L,3L,1L,4L,2L,0L,3L,1L,4L,2L,1L,3L,2L,4L,3L,1L,4L,2L,1L,3L,2L,4L,3L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,2L,4L,3L,1L,4L,2L,1L,3L,1L,4L,2L,1L,3L,2L,4L,3L,1L,4L,2L,1L,3L,2L,4L,3L,1L,4L,2L,0L,3L,1L,4L,2L,1L,3L,2L,4L,3L,1L,4L,2L,1L,3L,2L,4L,2L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,2L,4L,3L,1L,4L,2L,1L,3L,1L,4L,2L,1L,3L,2L,4L,3L,1L,4L,2L,1L,3L,2L,4L,3L,1L,3L,2L,0L,3L,1L,4L,2L,1L,3L,2L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190457Inst : IEnumerable<long>
{
public static readonly long[] Value=A190457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190457.Bytes);
public long this[int i]=>Value[i];

public static A190457Inst Instance=new A190457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190458
{
public static readonly long[] Value={ 13L,34L,68L,89L,123L,157L,178L,212L,233L,246L,267L,301L,322L,356L,390L,411L,445L,466L,500L,534L,555L,589L,610L,623L,644L,678L,699L,733L,767L,788L,822L,843L,877L,911L,932L,966L,1000L,1021L,1055L,1076L,1110L,1144L,1165L,1199L,1220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190458Inst : IEnumerable<long>
{
public static readonly long[] Value=A190458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190458.Bytes);
public long this[int i]=>Value[i];

public static A190458Inst Instance=new A190458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190459
{
public static readonly long[] Value={ 2L,5L,10L,15L,18L,23L,26L,31L,36L,39L,44L,47L,49L,52L,57L,60L,65L,70L,73L,78L,81L,86L,91L,94L,99L,102L,104L,107L,112L,115L,120L,125L,128L,133L,136L,141L,146L,149L,154L,159L,162L,167L,170L,175L,180L,183L,188L,191L,193L,196L,201L,204L,209L,214L,217L,222L,225L,230L,235L,238L,243L,248L,251L,256L,259L,264L,269L,272L,277L,280L,282L,285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190459Inst : IEnumerable<long>
{
public static readonly long[] Value=A190459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190459.Bytes);
public long this[int i]=>Value[i];

public static A190459Inst Instance=new A190459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190556
{
public static readonly long[] Value={ 17L,29L,58L,87L,99L,128L,157L,169L,198L,227L,256L,268L,297L,326L,338L,367L,396L,425L,437L,466L,495L,507L,536L,565L,577L,594L,606L,635L,664L,676L,705L,734L,746L,775L,804L,833L,845L,874L,903L,915L,944L,973L,985L,1002L,1014L,1043L,1072L,1084L,1113L,1142L,1154L,1183L,1212L,1241L,1253L,1282L,1311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190556Inst : IEnumerable<long>
{
public static readonly long[] Value=A190556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190556.Bytes);
public long this[int i]=>Value[i];

public static A190556Inst Instance=new A190556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190557
{
public static readonly long[] Value={ 3L,5L,10L,15L,20L,22L,27L,32L,34L,39L,44L,46L,51L,56L,61L,63L,68L,73L,75L,80L,85L,90L,92L,97L,102L,104L,109L,114L,116L,119L,121L,126L,131L,133L,138L,143L,145L,150L,155L,160L,162L,167L,172L,174L,179L,184L,186L,189L,191L,196L,201L,203L,208L,213L,215L,220L,225L,230L,232L,237L,242L,244L,249L,254L,259L,261L,266L,271L,273L,278L,283L,285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190557Inst : IEnumerable<long>
{
public static readonly long[] Value=A190557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190557.Bytes);
public long this[int i]=>Value[i];

public static A190557Inst Instance=new A190557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190558
{
public static readonly long[] Value={ 1L,6L,8L,13L,18L,23L,25L,30L,35L,37L,42L,47L,49L,52L,54L,59L,64L,66L,71L,76L,78L,83L,88L,93L,95L,100L,105L,107L,112L,117L,122L,124L,129L,134L,136L,141L,146L,148L,153L,158L,163L,165L,170L,175L,177L,182L,187L,192L,194L,199L,204L,206L,211L,216L,218L,221L,223L,228L,233L,235L,240L,245L,247L,252L,257L,262L,264L,269L,274L,276L,281L,286L,288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190558Inst : IEnumerable<long>
{
public static readonly long[] Value=A190558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190558.Bytes);
public long this[int i]=>Value[i];

public static A190558Inst Instance=new A190558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190559
{
public static readonly long[] Value={ 4L,9L,11L,16L,21L,26L,28L,33L,38L,40L,45L,50L,55L,57L,62L,67L,69L,74L,79L,81L,86L,91L,96L,98L,103L,108L,110L,115L,120L,125L,127L,132L,137L,139L,144L,149L,151L,154L,156L,161L,166L,168L,173L,178L,180L,185L,190L,195L,197L,202L,207L,209L,214L,219L,224L,226L,231L,236L,238L,243L,248L,250L,255L,260L,265L,267L,272L,277L,279L,284L,289L,294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190559Inst : IEnumerable<long>
{
public static readonly long[] Value=A190559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190559.Bytes);
public long this[int i]=>Value[i];

public static A190559Inst Instance=new A190559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190560
{
public static readonly long[] Value={ 0L,1L,8L,70L,608L,5284L,45920L,399064L,3468032L,30138640L,261917312L,2276170336L,19780866560L,171903954496L,1493916835328L,12982758409600L,112825568288768L,980501096767744L,8520962183874560L,74050704051602944L,643531405516070912L,5592555468438184960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190560Inst : IEnumerable<long>
{
public static readonly long[] Value=A190560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190560.Bytes);
public long this[int i]=>Value[i];

public static A190560Inst Instance=new A190560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190561
{
public static readonly long[] Value={ 1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,0L,2L,0L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,0L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,3L,1L,3L,0L,2L,0L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,0L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190561Inst : IEnumerable<long>
{
public static readonly long[] Value=A190561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190561.Bytes);
public long this[int i]=>Value[i];

public static A190561Inst Instance=new A190561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190562
{
public static readonly long[] Value={ 5L,10L,17L,22L,27L,29L,34L,39L,46L,51L,58L,63L,68L,75L,80L,87L,92L,97L,99L,104L,109L,116L,121L,128L,133L,138L,145L,150L,157L,162L,167L,169L,174L,179L,186L,191L,196L,198L,203L,208L,215L,220L,227L,232L,237L,244L,249L,256L,261L,266L,268L,273L,278L,285L,290L,297L,302L,307L,314L,319L,326L,331L,336L,338L,343L,348L,355L,360L,365L,367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190562Inst : IEnumerable<long>
{
public static readonly long[] Value=A190562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190562.Bytes);
public long this[int i]=>Value[i];

public static A190562Inst Instance=new A190562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190563
{
public static readonly long[] Value={ 1L,3L,8L,13L,15L,20L,25L,30L,32L,37L,42L,44L,49L,54L,56L,59L,61L,66L,71L,73L,78L,83L,85L,90L,95L,100L,102L,107L,112L,114L,119L,124L,126L,129L,131L,136L,141L,143L,148L,153L,155L,160L,165L,170L,172L,177L,182L,184L,189L,194L,199L,201L,206L,211L,213L,218L,223L,225L,230L,235L,240L,242L,247L,252L,254L,259L,264L,269L,271L,276L,281L,283L,288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190563Inst : IEnumerable<long>
{
public static readonly long[] Value=A190563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190563.Bytes);
public long this[int i]=>Value[i];

public static A190563Inst Instance=new A190563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190564
{
public static readonly long[] Value={ 4L,6L,11L,16L,18L,23L,28L,33L,35L,40L,45L,47L,52L,57L,62L,64L,69L,74L,76L,81L,86L,88L,93L,98L,103L,105L,110L,115L,117L,122L,127L,132L,134L,139L,144L,146L,151L,156L,158L,161L,163L,168L,173L,175L,180L,185L,187L,192L,197L,202L,204L,209L,214L,216L,221L,226L,228L,231L,233L,238L,243L,245L,250L,255L,257L,262L,267L,272L,274L,279L,284L,286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190564Inst : IEnumerable<long>
{
public static readonly long[] Value=A190564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190564.Bytes);
public long this[int i]=>Value[i];

public static A190564Inst Instance=new A190564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190565
{
public static readonly long[] Value={ 2L,7L,9L,14L,19L,21L,26L,31L,36L,38L,43L,48L,50L,55L,60L,65L,67L,72L,77L,79L,84L,89L,91L,94L,96L,101L,106L,108L,113L,118L,120L,125L,130L,135L,137L,142L,147L,149L,154L,159L,164L,166L,171L,176L,178L,183L,188L,190L,195L,200L,205L,207L,212L,217L,219L,224L,229L,234L,236L,241L,246L,248L,253L,258L,260L,263L,265L,270L,275L,277L,282L,287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190565Inst : IEnumerable<long>
{
public static readonly long[] Value=A190565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190565.Bytes);
public long this[int i]=>Value[i];

public static A190565Inst Instance=new A190565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190566
{
public static readonly long[] Value={ 12L,24L,41L,53L,70L,82L,111L,123L,140L,152L,181L,193L,210L,222L,239L,251L,280L,292L,309L,321L,350L,362L,379L,391L,408L,420L,432L,449L,461L,478L,490L,519L,531L,548L,560L,589L,601L,618L,630L,647L,659L,688L,700L,717L,729L,758L,770L,787L,799L,816L,828L,840L,857L,869L,886L,898L,927L,939L,956L,968L,997L,1009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190566Inst : IEnumerable<long>
{
public static readonly long[] Value=A190566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190566.Bytes);
public long this[int i]=>Value[i];

public static A190566Inst Instance=new A190566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190567
{
public static readonly long[] Value={ 311L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190567Inst : IEnumerable<long>
{
public static readonly long[] Value=A190567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190567.Bytes);
public long this[int i]=>Value[i];

public static A190567Inst Instance=new A190567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190568
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,3L,3L,5L,6L,10L,13L,19L,26L,38L,53L,75L,106L,150L,212L,300L,424L,600L,848L,1200L,1696L,2400L,3393L,4799L,6786L,9598L,13572L,19196L,27145L,38391L,54291L,76781L,108583L,153561L,217167L,307121L,434334L,614242L,868668L,1228484L,1737337L,2456967L,3474675L,4913933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190568Inst : IEnumerable<long>
{
public static readonly long[] Value=A190568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190568.Bytes);
public long this[int i]=>Value[i];

public static A190568Inst Instance=new A190568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190569
{
public static readonly long[] Value={ 1L,3L,7L,13L,25L,51L,103L,205L,409L,819L,1639L,3277L,6553L,13107L,26215L,52429L,104857L,209715L,419431L,838861L,1677721L,3355443L,6710887L,13421773L,26843545L,53687091L,107374183L,214748365L,429496729L,858993459L,1717986919L,3435973837L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190569Inst : IEnumerable<long>
{
public static readonly long[] Value=A190569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190569.Bytes);
public long this[int i]=>Value[i];

public static A190569Inst Instance=new A190569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190570
{
public static readonly long[] Value={ 1L,3L,5L,13L,27L,63L,137L,309L,683L,1527L,3393L,7565L,16835L,37503L,83497L,185957L,414075L,922119L,2053393L,4572669L,10182643L,22675407L,50494905L,112445269L,250399915L,557606103L,1241711393L,2765119597L,6157538211L,13711985439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190570Inst : IEnumerable<long>
{
public static readonly long[] Value=A190570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190570.Bytes);
public long this[int i]=>Value[i];

public static A190570Inst Instance=new A190570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190571
{
public static readonly long[] Value={ 1L,3L,7L,15L,37L,85L,199L,467L,1089L,2549L,5959L,13931L,32577L,76165L,178087L,416395L,973585L,2276389L,5322519L,12444811L,29097761L,68034725L,159074951L,371940043L,869649137L,2033364389L,4754297463L,11116229131L,25991337537L,60771473701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190571Inst : IEnumerable<long>
{
public static readonly long[] Value=A190571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190571.Bytes);
public long this[int i]=>Value[i];

public static A190571Inst Instance=new A190571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190604
{
public static readonly BigInteger[] Value={ 56L,672L,14112L,522144L,33939360L,3869087040L,773817408000L,271609910208000L,167311704688128000L,BigInteger.Parse("180863952767866368000"),BigInteger.Parse("343098918400642500096000"),BigInteger.Parse("1142176299355738882819584000"),BigInteger.Parse("6672593940836226553432009728000") };
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
public class A190604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190604Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190604.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190604Inst Instance=new A190604Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190605
{
public static readonly BigInteger[] Value={ 44L,392L,5328L,119883L,4524432L,264917871L,24691633610L,3695710760736L,889996573057683L,344208553873787552L,BigInteger.Parse("212232817711368447264"),BigInteger.Parse("209378526541030232270145"),BigInteger.Parse("331234853208637544240698701") };
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
public class A190605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190605Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190605.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190605Inst Instance=new A190605Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190606
{
public static readonly BigInteger[] Value={ 39L,240L,2271L,35661L,836514L,27940563L,1374170474L,102369944843L,11464683896495L,1905358977494462L,469934471799881606L,BigInteger.Parse("172863979596481949179"),BigInteger.Parse("94947989820190085424440") };
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
public class A190606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190606Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190606.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190606Inst Instance=new A190606Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190607
{
public static readonly BigInteger[] Value={ 34L,168L,1135L,12814L,224705L,5127157L,154820497L,6857389175L,450847078335L,41610167180266L,5282145722452860L,946058243422221058L,BigInteger.Parse("244167133066656271715"),BigInteger.Parse("89943772503552797451562") };
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
public class A190607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190607Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190607.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190607Inst Instance=new A190607Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190608
{
public static readonly long[] Value={ 1L,1L,0L,0L,-2L,0L,0L,0L,-4L,0L,4L,0L,0L,0L,0L,0L,-8L,0L,8L,0L,8L,0L,-8L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-16L,0L,16L,0L,16L,0L,-16L,0L,16L,0L,-16L,0L,-16L,0L,16L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-32L,0L,32L,0L,32L,0L,-32L,0L,32L,0L,-32L,0L,-32L,0L,32L,0L,32L,0L,-32L,0L,-32L,0L,32L,0L,-32L,0L,32L,0L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190608Inst : IEnumerable<long>
{
public static readonly long[] Value=A190608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190608.Bytes);
public long this[int i]=>Value[i];

public static A190608Inst Instance=new A190608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190609
{
public static readonly long[] Value={ 1L,1L,0L,0L,-3L,0L,0L,0L,-9L,0L,9L,0L,0L,0L,0L,0L,-27L,0L,27L,0L,27L,0L,-27L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-81L,0L,81L,0L,81L,0L,-81L,0L,81L,0L,-81L,0L,-81L,0L,81L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-243L,0L,243L,0L,243L,0L,-243L,0L,243L,0L,-243L,0L,-243L,0L,243L,0L,243L,0L,-243L,0L,-243L,0L,243L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190609Inst : IEnumerable<long>
{
public static readonly long[] Value=A190609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190609.Bytes);
public long this[int i]=>Value[i];

public static A190609Inst Instance=new A190609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190610
{
public static readonly long[] Value={ 1L,1L,0L,0L,-1L,0L,0L,0L,-1L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,-1L,0L,1L,0L,-1L,0L,1L,0L,1L,0L,-1L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190610Inst : IEnumerable<long>
{
public static readonly long[] Value=A190610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190610.Bytes);
public long this[int i]=>Value[i];

public static A190610Inst Instance=new A190610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190611
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,1L,-2L,1L,-2L,1L,-1L,2L,-2L,1L,0L,2L,-2L,1L,0L,1L,0L,2L,-2L,2L,0L,1L,-3L,0L,-1L,2L,-2L,2L,-2L,1L,-2L,0L,-4L,1L,0L,0L,0L,2L,0L,2L,0L,2L,-2L,0L,0L,1L,-3L,3L,0L,0L,-2L,1L,-4L,2L,0L,2L,-2L,2L,0L,2L,-2L,1L,0L,2L,0L,0L,0L,4L,0L,1L,-2L,0L,-3L,0L,-4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190611Inst : IEnumerable<long>
{
public static readonly long[] Value=A190611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190611.Bytes);
public long this[int i]=>Value[i];

public static A190611Inst Instance=new A190611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190612
{
public static readonly long[] Value={ 6L,7L,11L,13L,19L,20L,23L,25L,28L,29L,31L,32L,34L,39L,41L,43L,46L,47L,51L,52L,53L,55L,56L,57L,59L,61L,62L,67L,68L,71L,73L,74L,79L,83L,85L,86L,87L,89L,94L,95L,97L,103L,107L,109L,113L,119L,127L,129L,131L,133L,134L,137L,139L,141L,142L,149L,151L,152L,155L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190612Inst : IEnumerable<long>
{
public static readonly long[] Value=A190612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190612.Bytes);
public long this[int i]=>Value[i];

public static A190612Inst Instance=new A190612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190613
{
public static readonly long[] Value={ 0L,1L,1L,5L,4L,6L,2L,12L,12L,11L,1L,21L,17L,9L,7L,37L,18L,16L,10L,28L,30L,30L,-6L,52L,48L,11L,17L,59L,19L,39L,9L,53L,65L,27L,9L,83L,44L,30L,10L,98L,54L,28L,36L,50L,68L,82L,-34L,128L,98L,13L,49L,91L,47L,59L,21L,119L,85L,71L,-11L,129L,107L,15L,49L,153L,92L,72L,24L,110L,68L,120L,-24L,166L,166L,-20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190613Inst : IEnumerable<long>
{
public static readonly long[] Value=A190613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190613.Bytes);
public long this[int i]=>Value[i];

public static A190613Inst Instance=new A190613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190614
{
public static readonly long[] Value={ 22L,46L,58L,70L,73L,78L,94L,106L,118L,126L,142L,145L,154L,166L,178L,190L,193L,214L,238L,241L,250L,262L,278L,286L,289L,298L,310L,313L,318L,334L,337L,346L,358L,361L,382L,406L,414L,418L,421L,430L,433L,438L,442L,446L,466L,478L,481L,498L,502L,505L,526L,538L,550L,558L,570L,574L,577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190614Inst : IEnumerable<long>
{
public static readonly long[] Value=A190614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190614.Bytes);
public long this[int i]=>Value[i];

public static A190614Inst Instance=new A190614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190615
{
public static readonly long[] Value={ 1L,-1L,2L,-2L,1L,-2L,0L,-2L,0L,0L,2L,0L,3L,-1L,2L,-2L,2L,-4L,0L,0L,0L,0L,2L,0L,3L,0L,2L,-4L,0L,-2L,0L,-2L,0L,0L,0L,0L,2L,-3L,4L,-2L,1L,-2L,0L,-2L,0L,0L,2L,0L,2L,-2L,2L,-2L,4L,-2L,0L,0L,0L,0L,0L,0L,3L,0L,4L,-2L,0L,-2L,0L,-2L,0L,0L,0L,0L,4L,-3L,2L,-2L,0L,-4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190615Inst : IEnumerable<long>
{
public static readonly long[] Value=A190615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190615.Bytes);
public long this[int i]=>Value[i];

public static A190615Inst Instance=new A190615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190616
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,4L,1L,0L,3L,8L,3L,16L,5L,16L,15L,0L,17L,48L,27L,128L,63L,192L,89L,0L,205L,637L,171L,1011L,565L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190616Inst : IEnumerable<long>
{
public static readonly long[] Value=A190616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190616.Bytes);
public long this[int i]=>Value[i];

public static A190616Inst Instance=new A190616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190617
{
public static readonly long[] Value={ 2L,2L,2L,2L,2L,3L,0L,19L,13L,13L,2L,11L,0L,3L,0L,7L,3L,2L,0L,0L,3L,0L,2L,0L,7L,2L,0L,0L,7L,2L,0L,0L,5L,13L,17L,5L,0L,29L,73L,53L,0L,41L,17L,0L,61L,113L,67L,0L,23L,7L,31L,53L,3L,0L,0L,109L,13L,43L,101L,67L,113L,0L,181L,37L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190617Inst : IEnumerable<long>
{
public static readonly long[] Value=A190617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190617.Bytes);
public long this[int i]=>Value[i];

public static A190617Inst Instance=new A190617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190618
{
public static readonly long[] Value={ 5L,13L,25L,29L,34L,35L,36L,41L,52L,60L,65L,76L,81L,88L,93L,94L,95L,100L,111L,123L,128L,147L,152L,167L,172L,183L,188L,195L,200L,201L,202L,207L,218L,222L,227L,228L,229L,234L,245L,250L,261L,266L,267L,268L,273L,274L,275L,280L,281L,282L,287L,298L,303L,314L,319L,320L,321L,326L,337L,342L,361L,366L,381L,386L,397L,402L,409L,414L,415L,416L,421L,432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190618Inst : IEnumerable<long>
{
public static readonly long[] Value=A190618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190618.Bytes);
public long this[int i]=>Value[i];

public static A190618Inst Instance=new A190618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190619
{
public static readonly long[] Value={ 101L,1011L,1101L,10111L,11011L,11101L,101111L,110111L,111011L,111101L,1011111L,1101111L,1110111L,1111011L,1111101L,10111111L,11011111L,11101111L,11110111L,11111011L,11111101L,101111111L,110111111L,111011111L,111101111L,111110111L,111111011L,111111101L,1011111111L,1101111111L,1110111111L,1111011111L,1111101111L,1111110111L,1111111011L,1111111101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190619Inst : IEnumerable<long>
{
public static readonly long[] Value=A190619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190619.Bytes);
public long this[int i]=>Value[i];

public static A190619Inst Instance=new A190619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190652
{
public static readonly long[] Value={ 1901L,1905L,1906L,1907L,1908L,1911L,1912L,1917L,1918L,1920L,1922L,1923L,1929L,1933L,1934L,1935L,1936L,1939L,1940L,1945L,1946L,1948L,1950L,1951L,1957L,1961L,1962L,1963L,1964L,1967L,1968L,1973L,1974L,1976L,1978L,1979L,1985L,1989L,1990L,1991L,1992L,1995L,1996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190652Inst : IEnumerable<long>
{
public static readonly long[] Value=A190652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190652.Bytes);
public long this[int i]=>Value[i];

public static A190652Inst Instance=new A190652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190653
{
public static readonly long[] Value={ 1903L,1914L,1925L,1928L,1931L,1942L,1953L,1956L,1959L,1970L,1981L,1984L,1987L,1998L,2009L,2012L,2015L,2026L,2037L,2040L,2043L,2054L,2065L,2068L,2071L,2082L,2093L,2096L,2099L,2105L,2108L,2111L,2122L,2133L,2136L,2139L,2150L,2161L,2164L,2167L,2178L,2189L,2192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190653Inst : IEnumerable<long>
{
public static readonly long[] Value=A190653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190653.Bytes);
public long this[int i]=>Value[i];

public static A190653Inst Instance=new A190653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190654
{
public static readonly long[] Value={ 149L,151L,179L,181L,227L,229L,239L,241L,347L,349L,431L,433L,569L,571L,599L,601L,641L,643L,821L,823L,1019L,1021L,1049L,1051L,1061L,1063L,1427L,1429L,1487L,1489L,1607L,1609L,1787L,1789L,1997L,1999L,2081L,2083L,2129L,2131L,2237L,2239L,2267L,2269L,2657L,2659L,2687L,2689L,2711L,2713L,2789L,2791L,2999L,3001L,3167L,3169L,3257L,3259L,3299L,3301L,3359L,3361L,3527L,3529L,3539L,3541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190654Inst : IEnumerable<long>
{
public static readonly long[] Value=A190654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190654.Bytes);
public long this[int i]=>Value[i];

public static A190654Inst Instance=new A190654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190655
{
public static readonly BigInteger[] Value={ 1L,2L,4L,24L,224L,2862L,53010L,1527552L,65195940L,4097065492L,385902826186L,54089022594864L,11269850153217786L,3491854976674289164L,BigInteger.Parse("1609153719436211880868"),BigInteger.Parse("1102542409006001885651456") };
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
public class A190655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190655Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190655.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190655Inst Instance=new A190655Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190656
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,20L,86L,486L,3495L,31938L,368832L,5412981L,100924470L,2390092072L,71686035608L,2726514241955L,131508854502755L,8039052200861454L,622678408143680652L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190656Inst : IEnumerable<long>
{
public static readonly long[] Value=A190656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190656.Bytes);
public long this[int i]=>Value[i];

public static A190656Inst Instance=new A190656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190657
{
public static readonly BigInteger[] Value={ 1L,1L,3L,10L,42L,244L,2031L,22714L,342292L,6943430L,188479666L,6843502049L,331910774405L,21483424837024L,1854744805774187L,213498320443922663L,BigInteger.Parse("32758157589935274374") };
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
public class A190657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190657Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190657.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190657Inst Instance=new A190657Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190658
{
public static readonly BigInteger[] Value={ 1L,1L,3L,8L,38L,252L,2107L,22478L,331824L,6625044L,173531500L,6026107049L,280634679581L,17440962165250L,1440182982082321L,158309818157320775L,BigInteger.Parse("23213155114911168104"),BigInteger.Parse("4535580909418217659991"),BigInteger.Parse("1179764335891702406715256") };
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
public class A190658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190658Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190658.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190658Inst Instance=new A190658Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190659
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,8L,20L,53L,141L,552L,2419L,12788L,78700L,561036L,4750312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190659Inst : IEnumerable<long>
{
public static readonly long[] Value=A190659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190659.Bytes);
public long this[int i]=>Value[i];

public static A190659Inst Instance=new A190659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190660
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,3L,5L,7L,9L,13L,19L,27L,37L,53L,75L,106L,150L,212L,300L,424L,600L,848L,1200L,1697L,2399L,3393L,4799L,6786L,9598L,13573L,19195L,27146L,38390L,54292L,76780L,108584L,153560L,217167L,307121L,434334L,614242L,868669L,1228483L,1737338L,2456966L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190660Inst : IEnumerable<long>
{
public static readonly long[] Value=A190660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190660.Bytes);
public long this[int i]=>Value[i];

public static A190660Inst Instance=new A190660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190661
{
public static readonly long[] Value={ 1L,7L,16L,33L,52L,66L,79L,72L,109L,93L,121L,119L,130L,153L,169L,194L,180L,222L,235L,275L,294L,267L,256L,296L,329L,339L,333L,420L,383L,373L,372L,454L,396L,443L,449L,504L,463L,574L,559L,512L,592L,602L,596L,541L,652L,585L,683L,656L,687L,689L,708L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190661Inst : IEnumerable<long>
{
public static readonly long[] Value=A190661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190661.Bytes);
public long this[int i]=>Value[i];

public static A190661Inst Instance=new A190661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190662
{
public static readonly long[] Value={ 15L,21L,85L,265L,2761L,10129L,111001L,887161L,21047881L,210471241L,1037836969L,68018232241L,361167207241L,3312775065961L,49691625984361L,1548286451713369L,16361621692416529L,294509190463488529L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190662Inst : IEnumerable<long>
{
public static readonly long[] Value=A190662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190662.Bytes);
public long this[int i]=>Value[i];

public static A190662Inst Instance=new A190662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190663
{
public static readonly long[] Value={ 5L,7L,17L,53L,251L,1447L,10091L,80651L,725789L,7257629L,79833613L,958003271L,12454041629L,174356582419L,2615348736019L,41845579776037L,711374856192023L,12804747411456023L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190663Inst : IEnumerable<long>
{
public static readonly long[] Value=A190663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190663.Bytes);
public long this[int i]=>Value[i];

public static A190663Inst Instance=new A190663Inst();

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