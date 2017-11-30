using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A190259
{
public static readonly long[] Value={ 2L,11L,32L,1L,4L,10L,2L,1L,1L,3L,1L,1L,5L,2L,3L,2L,1L,4L,2L,3L,2L,41L,1L,2L,1L,1L,3L,4L,1L,35L,1L,5L,1L,29661L,2L,1L,1L,2L,1L,1L,1L,1L,1L,2L,5L,2L,2L,2L,1L,1L,1L,5L,15L,2L,1L,1L,1L,2L,7L,1L,1L,1L,13L,1L,1L,1L,1L,20L,2L,1L,2L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,3L,14L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190259Inst : IEnumerable<long>
{
public static readonly long[] Value=A190259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190259.Bytes);
public long this[int i]=>Value[i];

public static A190259Inst Instance=new A190259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190258
{
public static readonly long[] Value={ 2L,0L,9L,0L,6L,5L,7L,8L,5L,0L,8L,5L,2L,2L,4L,4L,7L,7L,5L,7L,1L,0L,0L,8L,9L,6L,3L,5L,0L,0L,5L,2L,2L,1L,3L,2L,8L,0L,9L,5L,8L,8L,0L,1L,7L,1L,5L,3L,5L,0L,8L,9L,6L,1L,5L,2L,7L,0L,1L,5L,4L,0L,8L,0L,1L,3L,6L,5L,3L,8L,6L,8L,6L,5L,8L,2L,3L,0L,1L,7L,6L,3L,7L,1L,1L,4L,3L,1L,5L,0L,4L,0L,4L,6L,0L,4L,2L,6L,3L,8L,4L,6L,7L,1L,8L,0L,8L,3L,2L,7L,8L,0L,6L,7L,6L,9L,3L,2L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190258Inst : IEnumerable<long>
{
public static readonly long[] Value=A190258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190258.Bytes);
public long this[int i]=>Value[i];

public static A190258Inst Instance=new A190258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190257
{
public static readonly long[] Value={ 2L,3L,1L,2L,5L,2L,1L,5L,95L,1L,1L,2L,1L,9L,3L,1L,1L,53L,1L,1L,1L,2L,3L,1L,7L,5L,1L,3L,8L,1L,5L,4L,1L,18L,1L,1L,6L,2L,25L,3L,5L,1L,5L,2L,4L,2L,1L,1L,43L,1L,1L,8L,1L,24L,3L,21L,1L,7L,4L,1L,13L,2L,1L,2L,1L,1811L,1L,3L,9L,1L,9L,2L,1L,1L,1L,2L,2L,23L,1L,1L,2L,1L,8L,6L,6L,2L,2L,2L,1L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190257Inst : IEnumerable<long>
{
public static readonly long[] Value=A190257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190257.Bytes);
public long this[int i]=>Value[i];

public static A190257Inst Instance=new A190257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190256
{
public static readonly long[] Value={ 2L,2L,7L,1L,2L,8L,1L,5L,6L,2L,4L,2L,2L,9L,9L,4L,1L,4L,2L,3L,1L,3L,0L,5L,8L,0L,6L,8L,7L,5L,9L,7L,2L,6L,8L,5L,5L,4L,5L,5L,8L,4L,9L,2L,6L,9L,1L,0L,2L,1L,4L,3L,4L,3L,2L,8L,7L,4L,9L,0L,8L,2L,8L,2L,6L,5L,9L,1L,6L,4L,3L,9L,1L,5L,4L,3L,9L,2L,2L,1L,2L,3L,6L,1L,6L,7L,1L,5L,1L,8L,5L,5L,1L,0L,2L,9L,6L,0L,3L,1L,3L,7L,3L,1L,9L,7L,0L,3L,3L,5L,9L,4L,8L,5L,3L,0L,0L,5L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190256Inst : IEnumerable<long>
{
public static readonly long[] Value=A190256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190256.Bytes);
public long this[int i]=>Value[i];

public static A190256Inst Instance=new A190256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190255
{
public static readonly long[] Value={ 1L,1L,3L,7L,18L,48L,131L,365L,1034L,2968L,8615L,25243L,74565L,221807L,663869L,1997765L,6040894L,18345668L,55931289L,171121717L,525225943L,1616805005L,4990386995L,15441275375L,47887524320L,148826022290L,463433496815L,1445737785557L,4517857601552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190255Inst : IEnumerable<long>
{
public static readonly long[] Value=A190255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190255.Bytes);
public long this[int i]=>Value[i];

public static A190255Inst Instance=new A190255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190254
{
public static readonly long[] Value={ 1L,2L,5L,14L,40L,117L,348L,1047L,3179L,9723L,29915L,92498L,287211L,895030L,2797928L,8770635L,27560288L,86792100L,273857035L,865630975L,2740541714L,8689081394L,27586212293L,87688882320L,279055280258L,888981785349L,2834784312290L,9047795153319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190254Inst : IEnumerable<long>
{
public static readonly long[] Value=A190254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190254.Bytes);
public long this[int i]=>Value[i];

public static A190254Inst Instance=new A190254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190253
{
public static readonly long[] Value={ 1L,2L,9L,48L,265L,1512L,8813L,52112L,311427L,1876290L,11376893L,69341868L,424445996L,2607388252L,16066200465L,99256947520L,614611513599L,3813391239444L,23702418040232L,147557273500400L,919907826138042L,5742264749678028L,35886019625941713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190253Inst : IEnumerable<long>
{
public static readonly long[] Value=A190253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190253.Bytes);
public long this[int i]=>Value[i];

public static A190253Inst Instance=new A190253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190252
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,5L,5L,3L,1L,12L,14L,9L,4L,1L,31L,38L,28L,14L,5L,1L,83L,106L,84L,48L,20L,6L,1L,227L,301L,252L,157L,75L,27L,7L,1L,634L,864L,758L,504L,265L,110L,35L,8L,1L,1799L,2508L,2283L,1602L,906L,417L,154L,44L,9L,1L,5171L,7348L,6897L,5056L,3035L,1512L,623L,208L,54L,10L,1L,15027L,21699L,20903L,15894L,10020L,5324L,2387L,894L,273L,65L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190252Inst : IEnumerable<long>
{
public static readonly long[] Value=A190252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190252.Bytes);
public long this[int i]=>Value[i];

public static A190252Inst Instance=new A190252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
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

public static class A190179
{
public static readonly long[] Value={ 1L,3L,1L,4L,9L,9L,2L,9L,8L,3L,0L,2L,0L,7L,7L,1L,1L,9L,7L,1L,1L,9L,1L,6L,4L,2L,0L,3L,6L,3L,8L,2L,6L,3L,0L,4L,4L,5L,6L,4L,9L,0L,9L,3L,4L,6L,6L,3L,3L,7L,5L,6L,0L,0L,3L,2L,0L,8L,0L,0L,3L,1L,7L,2L,6L,0L,5L,6L,0L,2L,8L,8L,6L,5L,3L,6L,0L,3L,8L,8L,6L,6L,1L,9L,2L,6L,2L,4L,0L,6L,2L,5L,8L,0L,8L,8L,0L,9L,3L,2L,4L,8L,0L,9L,9L,1L,8L,4L,8L,1L,5L,5L,0L,8L,9L,5L,5L,3L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190179Inst : IEnumerable<long>
{
public static readonly long[] Value=A190179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190179.Bytes);
public long this[int i]=>Value[i];

public static A190179Inst Instance=new A190179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190178
{
public static readonly long[] Value={ 3L,5L,1L,2L,1L,1L,1L,2L,1L,12L,1L,5L,1L,1L,2L,1L,14L,2L,9L,11L,1L,12L,1L,2L,1L,832L,1L,2L,2L,5L,1L,1L,17L,1L,2L,1L,9L,1L,12L,1L,1L,1L,6L,3L,2L,1L,1L,6L,3L,1L,1L,1L,2L,2L,1L,3L,1L,3L,3L,1L,2L,1L,45L,1L,1L,1L,1L,62L,9L,1L,1L,2L,3L,1L,6L,1L,3L,5L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190178Inst : IEnumerable<long>
{
public static readonly long[] Value=A190178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190178.Bytes);
public long this[int i]=>Value[i];

public static A190178Inst Instance=new A190178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190177
{
public static readonly long[] Value={ 3L,1L,7L,4L,6L,7L,3L,8L,9L,4L,0L,3L,4L,1L,9L,8L,9L,2L,2L,9L,5L,8L,0L,7L,4L,4L,1L,2L,2L,1L,7L,2L,4L,3L,6L,4L,2L,9L,7L,4L,7L,8L,6L,1L,5L,8L,4L,1L,2L,1L,9L,6L,8L,7L,2L,9L,8L,3L,9L,9L,1L,1L,8L,5L,4L,1L,0L,0L,5L,5L,6L,5L,1L,4L,4L,6L,7L,5L,0L,7L,8L,7L,0L,3L,2L,2L,7L,3L,6L,2L,7L,3L,8L,2L,3L,0L,1L,0L,0L,7L,3L,9L,0L,6L,8L,1L,8L,5L,8L,2L,5L,9L,5L,1L,7L,6L,4L,3L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190177Inst : IEnumerable<long>
{
public static readonly long[] Value=A190177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190177.Bytes);
public long this[int i]=>Value[i];

public static A190177Inst Instance=new A190177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190176
{
public static readonly long[] Value={ 32L,98L,288L,722L,1568L,3042L,5408L,8978L,14112L,21218L,30752L,43218L,59168L,79202L,103968L,134162L,170528L,213858L,264992L,324818L,394272L,474338L,566048L,670482L,788768L,922082L,1071648L,1238738L,1424672L,1630818L,1858592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190176Inst : IEnumerable<long>
{
public static readonly long[] Value=A190176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190176.Bytes);
public long this[int i]=>Value[i];

public static A190176Inst Instance=new A190176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190175
{
public static readonly long[] Value={ 2L,7L,8L,28L,32L,43L,53L,98L,112L,128L,172L,212L,227L,263L,311L,343L,392L,443L,448L,512L,577L,602L,688L,742L,848L,908L,1052L,1193L,1244L,1372L,1423L,1568L,1619L,1772L,1792L,1993L,2048L,2107L,2308L,2311L,2408L,2539L,2597L,2752L,2939L,2968L,3178L,3209L,3392L,3632L,3682L,3698L,3779L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190175Inst : IEnumerable<long>
{
public static readonly long[] Value=A190175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190175.Bytes);
public long this[int i]=>Value[i];

public static A190175Inst Instance=new A190175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190174
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,0L,0L,3L,3L,3L,1L,1L,1L,4L,1L,1L,2L,1L,2L,2L,4L,2L,2L,5L,2L,3L,0L,2L,3L,4L,0L,5L,2L,3L,3L,2L,2L,3L,3L,2L,1L,0L,3L,4L,3L,3L,1L,1L,4L,3L,1L,0L,4L,6L,1L,3L,3L,2L,4L,3L,5L,2L,1L,4L,4L,2L,1L,4L,2L,3L,2L,1L,3L,5L,1L,4L,2L,3L,2L,5L,3L,3L,2L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190174Inst : IEnumerable<long>
{
public static readonly long[] Value=A190174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190174.Bytes);
public long this[int i]=>Value[i];

public static A190174Inst Instance=new A190174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190173
{
public static readonly long[] Value={ 0L,1L,5L,17L,52L,148L,408L,1101L,2937L,7777L,20504L,53912L,141520L,371113L,972573L,2547825L,6672876L,17473996L,45754280L,119797205L,313650865L,821177281L,2149916400L,5628629232L,14736064032L,38579712913L,101003317493L,264430632401L,692289215332L,1812438042052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190173Inst : IEnumerable<long>
{
public static readonly long[] Value=A190173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190173.Bytes);
public long this[int i]=>Value[i];

public static A190173Inst Instance=new A190173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190172
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,4L,4L,8L,8L,1L,16L,18L,3L,33L,40L,9L,69L,90L,25L,1L,146L,204L,69L,4L,312L,467L,183L,16L,673L,1074L,479L,56L,1L,1463L,2481L,1239L,185L,5L,3202L,5752L,3180L,576L,25L,7050L,13378L,8104L,1734L,105L,1L,15605L,31196L,20544L,5076L,405L,6L,34705L,72912L,51852L,14546L,1451L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190172Inst : IEnumerable<long>
{
public static readonly long[] Value=A190172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190172.Bytes);
public long this[int i]=>Value[i];

public static A190172Inst Instance=new A190172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189531
{
public static readonly long[] Value={ 2L,5L,8L,12L,14L,17L,20L,24L,27L,29L,32L,36L,39L,42L,44L,48L,51L,54L,57L,60L,63L,66L,69L,73L,75L,78L,82L,85L,88L,90L,94L,97L,100L,102L,106L,109L,112L,115L,118L,121L,124L,127L,131L,133L,136L,139L,143L,146L,148L,151L,155L,158L,161L,164L,167L,170L,173L,177L,179L,182L,185L,189L,192L,194L,197L,201L,204L,206L,209L,213L,216L,219L,221L,225L,228L,231L,235L,237L,240L,243L,247L,250L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189531Inst : IEnumerable<long>
{
public static readonly long[] Value=A189531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189531.Bytes);
public long this[int i]=>Value[i];

public static A189531Inst Instance=new A189531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189530
{
public static readonly long[] Value={ 3L,7L,10L,15L,18L,22L,26L,30L,34L,37L,41L,46L,49L,53L,56L,61L,64L,68L,72L,76L,80L,83L,87L,92L,95L,99L,103L,107L,111L,114L,119L,122L,126L,129L,134L,138L,141L,145L,149L,153L,157L,160L,165L,168L,172L,176L,180L,184L,187L,191L,195L,199L,203L,207L,211L,214L,218L,223L,226L,230L,233L,238L,242L,245L,249L,253L,257L,260L,264L,269L,272L,276L,279L,284L,288L,291L,296L,299L,303L,306L,311L,315L,318L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189530Inst : IEnumerable<long>
{
public static readonly long[] Value=A189530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189530.Bytes);
public long this[int i]=>Value[i];

public static A189530Inst Instance=new A189530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189529
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,9L,10L,11L,14L,15L,16L,18L,19L,20L,22L,23L,24L,26L,28L,29L,30L,32L,33L,34L,36L,37L,38L,40L,42L,43L,45L,46L,47L,49L,50L,51L,53L,54L,56L,58L,59L,60L,61L,63L,64L,65L,67L,68L,70L,72L,73L,74L,76L,77L,78L,80L,81L,82L,85L,86L,87L,89L,90L,91L,92L,94L,95L,96L,99L,100L,101L,103L,104L,105L,107L,108L,109L,111L,113L,114L,116L,117L,118L,120L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189529Inst : IEnumerable<long>
{
public static readonly long[] Value=A189529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189529.Bytes);
public long this[int i]=>Value[i];

public static A189529Inst Instance=new A189529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189528
{
public static readonly long[] Value={ 13L,27L,41L,55L,69L,83L,98L,112L,126L,139L,153L,167L,181L,196L,210L,224L,238L,252L,266L,279L,294L,308L,322L,336L,350L,364L,378L,393L,407L,420L,434L,448L,462L,476L,491L,505L,519L,533L,547L,560L,574L,589L,603L,617L,631L,645L,659L,674L,688L,701L,715L,729L,743L,757L,772L,786L,800L,814L,828L,841L,855L,870L,884L,898L,912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189528Inst : IEnumerable<long>
{
public static readonly long[] Value=A189528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189528.Bytes);
public long this[int i]=>Value[i];

public static A189528Inst Instance=new A189528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189527
{
public static readonly long[] Value={ 4L,8L,12L,17L,21L,25L,31L,35L,39L,44L,48L,52L,57L,62L,66L,71L,75L,79L,84L,88L,93L,97L,102L,106L,110L,115L,119L,124L,129L,133L,137L,142L,146L,150L,156L,160L,164L,169L,173L,177L,182L,187L,191L,195L,200L,204L,208L,214L,218L,222L,227L,231L,235L,240L,245L,249L,254L,258L,262L,267L,271L,276L,281L,285L,289L,293L,298L,302L,307L,312L,316L,320L,325L,329L,333L,339L,343L,347L,352L,356L,360L,365L,370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189527Inst : IEnumerable<long>
{
public static readonly long[] Value=A189527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189527.Bytes);
public long this[int i]=>Value[i];

public static A189527Inst Instance=new A189527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189526
{
public static readonly long[] Value={ 1L,4L,7L,9L,12L,15L,18L,20L,22L,25L,28L,30L,33L,36L,38L,41L,44L,46L,48L,51L,54L,57L,59L,62L,65L,67L,69L,72L,75L,77L,80L,83L,86L,88L,90L,93L,96L,98L,101L,104L,107L,109L,111L,114L,116L,119L,122L,125L,127L,130L,133L,135L,137L,140L,143L,145L,148L,151L,154L,156L,158L,161L,164L,166L,169L,172L,175L,177L,179L,182L,184L,187L,190L,193L,195L,198L,201L,203L,205L,208L,211L,214L,216L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189526Inst : IEnumerable<long>
{
public static readonly long[] Value=A189526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189526.Bytes);
public long this[int i]=>Value[i];

public static A189526Inst Instance=new A189526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189525
{
public static readonly long[] Value={ 2L,5L,8L,11L,14L,16L,19L,23L,26L,29L,32L,34L,37L,40L,43L,47L,50L,52L,55L,58L,61L,64L,68L,70L,73L,76L,79L,82L,85L,87L,91L,94L,97L,100L,102L,105L,108L,112L,115L,118L,120L,123L,126L,129L,132L,136L,138L,141L,144L,147L,150L,153L,155L,159L,162L,165L,168L,171L,173L,176L,180L,183L,186L,189L,191L,194L,197L,200L,204L,206L,209L,212L,215L,218L,221L,224L,227L,230L,233L,236L,239L,241L,244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189525Inst : IEnumerable<long>
{
public static readonly long[] Value=A189525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189525.Bytes);
public long this[int i]=>Value[i];

public static A189525Inst Instance=new A189525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189524
{
public static readonly long[] Value={ 3L,6L,10L,13L,17L,21L,24L,27L,31L,35L,39L,42L,45L,49L,53L,56L,60L,63L,66L,71L,74L,78L,81L,84L,89L,92L,95L,99L,103L,106L,110L,113L,117L,121L,124L,128L,131L,134L,139L,142L,146L,149L,152L,157L,160L,163L,167L,170L,174L,178L,181L,185L,188L,192L,196L,199L,202L,207L,210L,213L,217L,220L,225L,228L,231L,235L,238L,242L,246L,249L,252L,256L,260L,264L,267L,270L,274L,278L,281L,285L,288L,292L,296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189524Inst : IEnumerable<long>
{
public static readonly long[] Value=A189524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189524.Bytes);
public long this[int i]=>Value[i];

public static A189524Inst Instance=new A189524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189523
{
public static readonly long[] Value={ 6L,13L,20L,26L,33L,40L,48L,54L,61L,68L,74L,81L,89L,96L,102L,109L,116L,122L,130L,137L,144L,150L,157L,164L,171L,178L,185L,192L,198L,205L,213L,219L,226L,233L,240L,246L,254L,261L,268L,274L,281L,288L,295L,302L,309L,316L,322L,329L,337L,343L,350L,357L,364L,370L,378L,385L,391L,398L,405L,412L,419L,426L,433L,439L,446L,453L,460L,467L,474L,481L,487L,494L,501L,509L,515L,522L,529L,536L,542L,550L,557L,563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189523Inst : IEnumerable<long>
{
public static readonly long[] Value=A189523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189523.Bytes);
public long this[int i]=>Value[i];

public static A189523Inst Instance=new A189523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189522
{
public static readonly long[] Value={ 2L,5L,9L,11L,15L,18L,22L,24L,28L,31L,34L,37L,41L,44L,46L,50L,53L,56L,59L,63L,66L,69L,72L,76L,78L,82L,85L,88L,91L,94L,98L,100L,104L,107L,111L,113L,117L,120L,124L,126L,129L,133L,135L,139L,142L,146L,148L,152L,155L,158L,161L,165L,168L,170L,174L,177L,180L,183L,187L,190L,193L,196L,200L,202L,206L,209L,212L,215L,218L,222L,224L,228L,231L,235L,237L,241L,244L,248L,250L,253L,257L,259L,263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189522Inst : IEnumerable<long>
{
public static readonly long[] Value=A189522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189522.Bytes);
public long this[int i]=>Value[i];

public static A189522Inst Instance=new A189522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189521
{
public static readonly long[] Value={ 1L,3L,4L,7L,8L,10L,12L,14L,16L,17L,19L,21L,23L,25L,27L,29L,30L,32L,35L,36L,38L,39L,42L,43L,45L,47L,49L,51L,52L,55L,57L,58L,60L,62L,64L,65L,67L,70L,71L,73L,75L,77L,79L,80L,83L,84L,86L,87L,90L,92L,93L,95L,97L,99L,101L,103L,105L,106L,108L,110L,112L,114L,115L,118L,119L,121L,123L,125L,127L,128L,131L,132L,134L,136L,138L,140L,141L,143L,145L,147L,149L,151L,153L,154L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189521Inst : IEnumerable<long>
{
public static readonly long[] Value=A189521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189521.Bytes);
public long this[int i]=>Value[i];

public static A189521Inst Instance=new A189521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189520
{
public static readonly long[] Value={ 5L,11L,18L,23L,29L,36L,42L,47L,54L,60L,66L,72L,78L,85L,90L,96L,103L,108L,114L,121L,127L,133L,139L,145L,151L,157L,163L,170L,175L,182L,188L,193L,200L,206L,212L,218L,224L,230L,237L,242L,249L,255L,260L,267L,273L,279L,285L,291L,298L,303L,309L,316L,322L,327L,334L,340L,345L,352L,358L,365L,370L,376L,383L,388L,394L,401L,407L,413L,419L,425L,431L,437L,443L,450L,455L,461L,468L,474L,480L,486L,492L,498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189520Inst : IEnumerable<long>
{
public static readonly long[] Value=A189520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189520.Bytes);
public long this[int i]=>Value[i];

public static A189520Inst Instance=new A189520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189519
{
public static readonly long[] Value={ 3L,8L,13L,16L,21L,26L,31L,34L,39L,44L,48L,52L,57L,62L,65L,70L,75L,79L,83L,88L,93L,97L,101L,106L,110L,115L,119L,124L,128L,132L,137L,141L,146L,150L,155L,159L,164L,168L,173L,177L,181L,186L,190L,195L,199L,204L,208L,213L,217L,221L,226L,231L,235L,239L,244L,248L,252L,257L,262L,266L,270L,275L,280L,283L,288L,293L,297L,301L,306L,311L,314L,319L,324L,329L,332L,337L,342L,347L,350L,355L,360L,363L,368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189519Inst : IEnumerable<long>
{
public static readonly long[] Value=A189519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189519.Bytes);
public long this[int i]=>Value[i];

public static A189519Inst Instance=new A189519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189518
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,9L,10L,12L,14L,15L,17L,19L,20L,22L,24L,25L,27L,28L,30L,32L,33L,35L,37L,38L,40L,41L,43L,45L,46L,49L,50L,51L,53L,55L,56L,58L,59L,61L,63L,64L,67L,68L,69L,71L,73L,74L,76L,77L,80L,81L,82L,84L,86L,87L,89L,91L,92L,94L,95L,98L,99L,100L,102L,104L,105L,107L,109L,111L,112L,113L,116L,117L,118L,120L,122L,123L,125L,126L,129L,130L,131L,134L,135L,136L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189518Inst : IEnumerable<long>
{
public static readonly long[] Value=A189518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189518.Bytes);
public long this[int i]=>Value[i];

public static A189518Inst Instance=new A189518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189517
{
public static readonly long[] Value={ 4L,9L,14L,19L,24L,29L,34L,39L,45L,49L,55L,59L,65L,69L,75L,80L,84L,90L,94L,100L,104L,110L,115L,120L,125L,130L,135L,140L,145L,151L,155L,160L,165L,170L,175L,180L,186L,190L,196L,200L,206L,210L,216L,221L,226L,231L,235L,241L,245L,251L,256L,261L,266L,271L,276L,281L,286L,292L,296L,302L,306L,311L,316L,321L,327L,331L,337L,341L,347L,351L,357L,362L,367L,372L,377L,382L,386L,392L,397L,402L,407L,412L,417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189517Inst : IEnumerable<long>
{
public static readonly long[] Value=A189517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189517.Bytes);
public long this[int i]=>Value[i];

public static A189517Inst Instance=new A189517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189516
{
public static readonly long[] Value={ 1L,3L,5L,7L,10L,11L,13L,16L,17L,20L,22L,23L,26L,27L,30L,32L,33L,36L,38L,40L,42L,44L,46L,48L,50L,52L,54L,56L,58L,61L,62L,64L,67L,68L,71L,72L,74L,77L,78L,81L,83L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,106L,107L,109L,112L,113L,116L,117L,119L,122L,123L,126L,128L,129L,132L,134L,136L,138L,139L,142L,144L,146L,148L,150L,152L,154L,157L,158L,161L,162L,164L,167L,168L,171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189516Inst : IEnumerable<long>
{
public static readonly long[] Value=A189516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189516.Bytes);
public long this[int i]=>Value[i];

public static A189516Inst Instance=new A189516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189451
{
public static readonly long[] Value={ 1L,13L,80L,666L,5080L,40106L,313136L,2455013L,19221095L,150562121L,1179185280L,9235771513L,72336253737L,566554489205L,4437377818704L,34754532606346L,272205182385544L,2131971340412858L,16698071766102576L,130782997877002493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189451Inst : IEnumerable<long>
{
public static readonly long[] Value=A189451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189451.Bytes);
public long this[int i]=>Value[i];

public static A189451Inst Instance=new A189451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189450
{
public static readonly long[] Value={ 1L,5L,16L,61L,225L,841L,3136L,11705L,43681L,163021L,608400L,2270581L,8473921L,31625105L,118026496L,440480881L,1643897025L,6135107221L,22896531856L,85451020205L,318907548961L,1190179175641L,4441809153600L,16577057438761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189450Inst : IEnumerable<long>
{
public static readonly long[] Value=A189450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189450.Bytes);
public long this[int i]=>Value[i];

public static A189450Inst Instance=new A189450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189449
{
public static readonly long[] Value={ 1L,2L,1L,3L,5L,1L,5L,16L,13L,1L,8L,61L,80L,34L,1L,13L,225L,666L,400L,89L,1L,21L,841L,5080L,7300L,2000L,233L,1L,34L,3136L,40106L,118128L,80282L,10000L,610L,1L,55L,11705L,313136L,2008890L,2735828L,883049L,50000L,1597L,1L,89L,43681L,2455013L,33735505L,100047288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189449Inst : IEnumerable<long>
{
public static readonly long[] Value=A189449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189449.Bytes);
public long this[int i]=>Value[i];

public static A189449Inst Instance=new A189449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189448
{
public static readonly BigInteger[] Value={ 34L,11705L,2455013L,569476049L,129699382789L,29628810704689L,6765736745152657L,1544933702911323688L,BigInteger.Parse("352785827356726984192"),BigInteger.Parse("80558653487951364549221"),BigInteger.Parse("18395575161567635569195834"),BigInteger.Parse("4200631099715909550808300301") };
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
public class A189448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189448Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189448.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189448Inst Instance=new A189448Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189447
{
public static readonly BigInteger[] Value={ 21L,3136L,313136L,33735505L,3586575040L,381987110556L,40668908306516L,4329976369716644L,461007230769131204L,BigInteger.Parse("49082883213353553796"),BigInteger.Parse("5225795314666113134276"),BigInteger.Parse("556384119909347581932164") };
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
public class A189447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189447Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189447.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189447Inst Instance=new A189447Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189446
{
public static readonly BigInteger[] Value={ 13L,841L,40106L,2008890L,100047288L,4982424404L,248187289625L,12362821462925L,615823316590381L,30675714678416140L,1528034812741010509L,BigInteger.Parse("76115272823689573050"),BigInteger.Parse("3791493955944999761482"),BigInteger.Parse("188863888740455537178552") };
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
public class A189446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189446Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189446.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189446Inst Instance=new A189446Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189445
{
public static readonly BigInteger[] Value={ 8L,225L,5080L,118128L,2735828L,63367633L,1467726607L,33995627281L,787410049440L,18238068717816L,422431934648884L,9784409861152809L,226627459902104327L,5249167431711452449L,BigInteger.Parse("121581730378315708936"),BigInteger.Parse("2816087951868941718112") };
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
public class A189445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189445Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189445.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189445Inst Instance=new A189445Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189444
{
public static readonly long[] Value={ 5L,61L,666L,7300L,80282L,883049L,9712873L,106834338L,1175098084L,12925203122L,142167601085L,1563737653381L,17199948722346L,189186616701220L,2080911781577162L,22888478678939969L,251756206521753553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189444Inst : IEnumerable<long>
{
public static readonly long[] Value=A189444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189444.Bytes);
public long this[int i]=>Value[i];

public static A189444Inst Instance=new A189444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189443
{
public static readonly BigInteger[] Value={ 1L,5L,80L,7300L,2735828L,4982424404L,40668908306516L,1544933702911323688L,BigInteger.Parse("268632319882770483171376"),BigInteger.Parse("215429706055786434110682479345"),BigInteger.Parse("794334848116480290212387125594468856") };
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
public class A189443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189443Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189443.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189443Inst Instance=new A189443Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189442
{
public static readonly long[] Value={ 1L,3L,1L,-3L,-5L,-7L,-1L,7L,9L,11L,1L,-11L,-13L,-15L,-1L,15L,17L,19L,1L,-19L,-21L,-23L,-1L,23L,25L,27L,1L,-27L,-29L,-31L,-1L,31L,33L,35L,1L,-35L,-37L,-39L,-1L,39L,41L,43L,1L,-43L,-45L,-47L,-1L,47L,49L,51L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189442Inst : IEnumerable<long>
{
public static readonly long[] Value=A189442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189442.Bytes);
public long this[int i]=>Value[i];

public static A189442Inst Instance=new A189442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189441
{
public static readonly long[] Value={ 5L,7L,13L,19L,31L,41L,43L,59L,61L,71L,73L,101L,103L,109L,113L,131L,139L,151L,167L,181L,191L,193L,199L,211L,227L,229L,239L,241L,251L,263L,269L,271L,281L,283L,293L,311L,313L,331L,347L,349L,359L,383L,401L,419L,421L,431L,433L,439L,461L,463L,467L,479L,487L,491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189441Inst : IEnumerable<long>
{
public static readonly long[] Value=A189441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189441.Bytes);
public long this[int i]=>Value[i];

public static A189441Inst Instance=new A189441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189440
{
public static readonly BigInteger[] Value={ 1L,178L,4247L,151081L,4681376L,150278792L,4742833745L,150293731826L,4749894184013L,150188217692849L,4746661471100000L,150023910675120177L,4741289321059094672L,BigInteger.Parse("149841677173229096314"),BigInteger.Parse("4735456640427554680211") };
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
public class A189440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189440Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189440.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189440Inst Instance=new A189440Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189439
{
public static readonly BigInteger[] Value={ 1L,85L,1245L,26589L,493941L,9557077L,181540773L,3467525301L,66045131269L,1258981901653L,23988387057381L,457127606313333L,8710469146675973L,165979359956189589L,3162723963901817637L,BigInteger.Parse("60265641669988070325") };
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
public class A189439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189439Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189439.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189439Inst Instance=new A189439Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189438
{
public static readonly long[] Value={ 1L,41L,367L,4653L,52241L,606201L,6944573L,79826592L,916320775L,10522129613L,120807652475L,1387081546065L,15925843986549L,182854110096077L,2099453348053203L,24105043866210197L,276763962980421232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189438Inst : IEnumerable<long>
{
public static readonly long[] Value=A189438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189438.Bytes);
public long this[int i]=>Value[i];

public static A189438Inst Instance=new A189438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189437
{
public static readonly long[] Value={ 1L,20L,109L,841L,5680L,40065L,278105L,1940868L,13518605L,94223329L,656569824L,4575509121L,31884910129L,222195588532L,1548403370477L,10790295445561L,75193858910224L,524000231073025L,3651577819301001L,25446593414689700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189437Inst : IEnumerable<long>
{
public static readonly long[] Value=A189437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189437.Bytes);
public long this[int i]=>Value[i];

public static A189437Inst Instance=new A189437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189436
{
public static readonly long[] Value={ 1L,9L,31L,140L,571L,2413L,10069L,42205L,176624L,739573L,3096173L,12962845L,54270579L,227212636L,951259751L,3982596009L,16673747193L,69807202249L,292258553696L,1223585260409L,5122727328297L,21447083573633L,89791504401207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189436Inst : IEnumerable<long>
{
public static readonly long[] Value=A189436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189436.Bytes);
public long this[int i]=>Value[i];

public static A189436Inst Instance=new A189436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189259
{
public static readonly long[] Value={ 12L,144L,1156L,8900L,65760L,481552L,3510380L,25556548L,185975588L,1353139492L,9844797788L,71624858188L,521097138012L,3791166287372L,27582062117196L,200669125155708L,1459937829727116L,10621556383444668L,77275523001250188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189259Inst : IEnumerable<long>
{
public static readonly long[] Value=A189259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189259.Bytes);
public long this[int i]=>Value[i];

public static A189259Inst Instance=new A189259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189258
{
public static readonly long[] Value={ 7L,49L,280L,1600L,8985L,50397L,282332L,1581428L,8857677L,49611209L,277868792L,1556321080L,8716833601L,48822302485L,273449899316L,1531571519964L,8578212427349L,48045897623297L,269101318957392L,1507215463960672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189258Inst : IEnumerable<long>
{
public static readonly long[] Value=A189258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189258.Bytes);
public long this[int i]=>Value[i];

public static A189258Inst Instance=new A189258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189257
{
public static readonly BigInteger[] Value={ 2L,16L,280L,8900L,552752L,68635317L,17747766886L,9421503162646L,10606582683139102L,BigInteger.Parse("24593238398265693575"),BigInteger.Parse("121227430181311808878846"),BigInteger.Parse("1234571538047080619811567488"),BigInteger.Parse("26705899629138438568650919545084") };
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
public class A189257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189257Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189257.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189257Inst Instance=new A189257Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189256
{
public static readonly ulong[] Value={ 1L,2L,6L,24L,120L,672L,4128L,28992L,231936L,2088960L,20434944L,221871360L,2645370624L,34344038400L,482103767040L,7269498483456L,117240911729664L,2013265377314688L,36665783917283328L,705762463906133760L,14313891805008665856UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189256Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A189256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189256.Bytes);
public ulong this[int i]=>Value[i];

public static A189256Inst Instance=new A189256Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189255
{
public static readonly ulong[] Value={ 1L,2L,6L,24L,108L,544L,3264L,23040L,176832L,1563392L,15536160L,171172224L,2066033472L,27146652480L,385447394880L,5878028516736L,95776238793504L,1660164417866304L,30496085473606944L,591661117634375040L,12087628978334638752UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189255Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A189255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189255.Bytes);
public ulong this[int i]=>Value[i];

public static A189255Inst Instance=new A189255Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189254
{
public static readonly long[] Value={ 1L,2L,2L,3L,24L,3L,5L,152L,152L,5L,8L,1168L,2961L,1168L,8L,13L,8448L,76629L,76629L,8448L,13L,21L,62272L,1818336L,7396009L,1818336L,62272L,21L,34L,456320L,44308389L,637586496L,637586496L,44308389L,456320L,34L,55L,3350016L,1070959431L,56892084785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189254Inst : IEnumerable<long>
{
public static readonly long[] Value=A189254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189254.Bytes);
public long this[int i]=>Value[i];

public static A189254Inst Instance=new A189254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189253
{
public static readonly BigInteger[] Value={ 34L,3350016L,25950094568L,445205174822288L,6188469597764755456L,BigInteger.Parse("92340416748367645903936"),BigInteger.Parse("1355117057188899341581651072"),BigInteger.Parse("20019535342827950668977079681024"),BigInteger.Parse("295422965429980829725911541023975936") };
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
public class A189253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189253Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189253.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189253Inst Instance=new A189253Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189252
{
public static readonly BigInteger[] Value={ 21L,456320L,1070959431L,5025023852501L,19568579061640704L,BigInteger.Parse("81032653651506521333"),BigInteger.Parse("330453235652954061843137"),BigInteger.Parse("1355117057188899341581651072"),BigInteger.Parse("5550437831744113835993347187363") };
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
public class A189252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189252Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189252.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189252Inst Instance=new A189252Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189251
{
public static readonly BigInteger[] Value={ 13L,62272L,44308389L,56892084785L,62111749014784L,71437033921822425L,BigInteger.Parse("81032653651506521333"),BigInteger.Parse("92340416748367645903936"),BigInteger.Parse("105103003634568916624818957"),BigInteger.Parse("119678361478200246096700911625") };
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
public class A189251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189251Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189251.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189251Inst Instance=new A189251Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189250
{
public static readonly BigInteger[] Value={ 8L,8448L,1818336L,637586496L,194762146816L,62111749014784L,19568579061640704L,6188469597764755456L,BigInteger.Parse("1954975627547701307392"),BigInteger.Parse("617793023145579401433088"),BigInteger.Parse("195210690041588272450666496"),BigInteger.Parse("61684603710077597393322917888") };
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
public class A189250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189250Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189250.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189250Inst Instance=new A189250Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189249
{
public static readonly BigInteger[] Value={ 5L,1168L,76629L,7396009L,637586496L,56892084785L,5025023852501L,445205174822288L,39407984363284853L,3489215319159283593L,BigInteger.Parse("308912577758497124608"),BigInteger.Parse("27349797876932219710785"),BigInteger.Parse("2421416215254898335806661") };
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
public class A189249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189249Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189249.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189249Inst Instance=new A189249Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189248
{
public static readonly BigInteger[] Value={ 3L,152L,2961L,76629L,1818336L,44308389L,1070959431L,25950094568L,628311228261L,15216392096673L,368483172355520L,8923455937553017L,216095445904425947L,5233099961163002488L,BigInteger.Parse("126727881793625193513"),BigInteger.Parse("3068918844981224041565") };
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
public class A189248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189248Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189248.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189248Inst Instance=new A189248Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189247
{
public static readonly long[] Value={ 2L,24L,152L,1168L,8448L,62272L,456320L,3350016L,24579584L,180376576L,1323614208L,9712930816L,71274930176L,523026923520L,3838053810176L,28164247060480L,206673697308672L,1516604287614976L,11129082140426240L,81666965136998400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189247Inst : IEnumerable<long>
{
public static readonly long[] Value=A189247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189247.Bytes);
public long this[int i]=>Value[i];

public static A189247Inst Instance=new A189247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189246
{
public static readonly BigInteger[] Value={ 1L,24L,2961L,7396009L,194762146816L,71437033921822425L,BigInteger.Parse("330453235652954061843137"),BigInteger.Parse("20019535342827950668977079681024") };
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
public class A189246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189246Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189246.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189246Inst Instance=new A189246Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189245
{
public static readonly long[] Value={ 0L,1L,1L,0L,4L,0L,1L,9L,9L,1L,0L,25L,0L,25L,0L,1L,64L,121L,121L,64L,1L,0L,169L,0L,1296L,0L,169L,0L,1L,441L,1681L,9025L,9025L,1681L,441L,1L,0L,1156L,0L,78961L,0L,78961L,0L,1156L,0L,1L,3025L,23409L,609961L,1399489L,1399489L,609961L,23409L,3025L,1L,0L,7921L,0L,5040025L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189245Inst : IEnumerable<long>
{
public static readonly long[] Value=A189245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189245.Bytes);
public long this[int i]=>Value[i];

public static A189245Inst Instance=new A189245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189244
{
public static readonly BigInteger[] Value={ 1L,3L,-7L,9L,177L,-3897L,65649L,-1057851L,16606977L,-238404789L,2305262889L,33442089057L,-3560906733903L,182521828278351L,-8055082800686367L,338022326927690397L,BigInteger.Parse("-13915405899740874879"),BigInteger.Parse("566988435851123595411"),BigInteger.Parse("-22784764731442383689127"),BigInteger.Parse("888283409438427072329529") };
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
public class A189244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189244Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189244.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189244Inst Instance=new A189244Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189211
{
public static readonly long[] Value={ 1L,3L,6L,7L,8L,14L,15L,16L,17L,18L,19L,20L,23L,30L,32L,34L,35L,36L,38L,39L,40L,44L,46L,47L,51L,53L,56L,57L,58L,59L,61L,62L,65L,66L,67L,68L,70L,71L,73L,74L,75L,81L,85L,86L,89L,92L,95L,100L,102L,104L,105L,106L,110L,111L,112L,116L,117L,119L,120L,122L,123L,125L,126L,127L,128L,129L,132L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189211Inst : IEnumerable<long>
{
public static readonly long[] Value=A189211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189211.Bytes);
public long this[int i]=>Value[i];

public static A189211Inst Instance=new A189211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189210
{
public static readonly long[] Value={ 2L,4L,5L,9L,10L,11L,12L,13L,21L,22L,24L,25L,26L,27L,28L,29L,31L,33L,37L,41L,42L,43L,45L,48L,49L,50L,52L,54L,55L,60L,63L,64L,69L,72L,76L,77L,78L,79L,80L,82L,83L,84L,87L,88L,90L,91L,93L,94L,96L,97L,98L,99L,101L,103L,107L,108L,109L,113L,114L,115L,118L,121L,124L,130L,131L,133L,135L,136L,138L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189210Inst : IEnumerable<long>
{
public static readonly long[] Value=A189210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189210.Bytes);
public long this[int i]=>Value[i];

public static A189210Inst Instance=new A189210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189209
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189209Inst : IEnumerable<long>
{
public static readonly long[] Value=A189209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189209.Bytes);
public long this[int i]=>Value[i];

public static A189209Inst Instance=new A189209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189208
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,12L,13L,14L,15L,16L,17L,19L,26L,28L,30L,32L,33L,34L,35L,38L,40L,41L,43L,44L,47L,50L,51L,53L,54L,57L,59L,61L,62L,63L,65L,66L,70L,71L,75L,76L,78L,81L,86L,90L,91L,92L,95L,96L,98L,102L,103L,105L,106L,109L,110L,111L,112L,114L,116L,117L,118L,122L,123L,126L,127L,129L,130L,132L,135L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189208Inst : IEnumerable<long>
{
public static readonly long[] Value=A189208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189208.Bytes);
public long this[int i]=>Value[i];

public static A189208Inst Instance=new A189208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189207
{
public static readonly long[] Value={ 4L,8L,9L,10L,11L,18L,20L,21L,22L,23L,24L,25L,27L,29L,31L,36L,37L,39L,42L,45L,46L,48L,49L,52L,55L,56L,58L,60L,64L,67L,68L,69L,72L,73L,74L,77L,79L,80L,82L,83L,84L,85L,87L,88L,89L,93L,94L,97L,99L,100L,101L,104L,107L,108L,113L,115L,119L,120L,121L,124L,125L,128L,131L,133L,134L,136L,138L,142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189207Inst : IEnumerable<long>
{
public static readonly long[] Value=A189207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189207.Bytes);
public long this[int i]=>Value[i];

public static A189207Inst Instance=new A189207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189206
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189206Inst : IEnumerable<long>
{
public static readonly long[] Value=A189206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189206.Bytes);
public long this[int i]=>Value[i];

public static A189206Inst Instance=new A189206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189205
{
public static readonly long[] Value={ 2L,4L,5L,8L,9L,12L,13L,17L,18L,19L,23L,24L,25L,29L,30L,31L,32L,37L,38L,39L,40L,45L,46L,47L,48L,53L,54L,55L,56L,57L,63L,64L,65L,66L,67L,73L,74L,75L,76L,77L,83L,84L,85L,86L,87L,94L,95L,96L,97L,98L,99L,106L,107L,108L,109L,110L,111L,118L,119L,120L,121L,122L,123L,130L,131L,132L,133L,134L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189205Inst : IEnumerable<long>
{
public static readonly long[] Value=A189205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189205.Bytes);
public long this[int i]=>Value[i];

public static A189205Inst Instance=new A189205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189204
{
public static readonly long[] Value={ 1L,3L,6L,7L,10L,11L,14L,15L,16L,20L,21L,22L,26L,27L,28L,33L,34L,35L,36L,41L,42L,43L,44L,49L,50L,51L,52L,58L,59L,60L,61L,62L,68L,69L,70L,71L,72L,78L,79L,80L,81L,82L,88L,89L,90L,91L,92L,93L,100L,101L,102L,103L,104L,105L,112L,113L,114L,115L,116L,117L,124L,125L,126L,127L,128L,129L,136L,137L,138L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189204Inst : IEnumerable<long>
{
public static readonly long[] Value=A189204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189204.Bytes);
public long this[int i]=>Value[i];

public static A189204Inst Instance=new A189204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189203
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189203Inst : IEnumerable<long>
{
public static readonly long[] Value=A189203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189203.Bytes);
public long this[int i]=>Value[i];

public static A189203Inst Instance=new A189203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189202
{
public static readonly long[] Value={ 3L,5L,5L,3L,13L,4L,9L,5L,11L,6L,19L,20L,15L,47L,17L,9L,19L,10L,21L,32L,23L,12L,37L,13L,40L,41L,29L,15L,46L,16L,33L,17L,35L,18L,37L,56L,39L,20L,41L,21L,85L,22L,45L,68L,47L,72L,73L,25L,51L,26L,79L,80L,109L,28L,57L,87L,59L,30L,91L,153L,63L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189202Inst : IEnumerable<long>
{
public static readonly long[] Value=A189202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189202.Bytes);
public long this[int i]=>Value[i];

public static A189202Inst Instance=new A189202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189201
{
public static readonly BigInteger[] Value={ 88L,7744L,455376L,25421672L,1372985912L,73539558380L,3925306136096L,209311662962608L,11157624191092952L,594711699220463696L,BigInteger.Parse("31697676855899289808"),BigInteger.Parse("1689445004590812894576"),BigInteger.Parse("90044940251851683056384") };
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
public class A189201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189201Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189201.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189201Inst Instance=new A189201Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189200
{
public static readonly BigInteger[] Value={ 54L,2916L,111778L,4109278L,146936454L,5218915180L,184841938568L,6541724250668L,231454020188296L,8188468500199960L,289687090181612928L,10248307021638957576UL,BigInteger.Parse("362555088540779428652"),BigInteger.Parse("12826127140789117054224") };
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
public class A189200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189200Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189200.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189200Inst Instance=new A189200Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189199
{
public static readonly BigInteger[] Value={ 33L,1089L,27170L,657028L,15564047L,367115337L,8646366042L,203562575017L,4791913469442L,112799071668131L,2655202148877722L,62501206566986486L,1471224094156225703L,BigInteger.Parse("34631328118629702199"),BigInteger.Parse("815191106000869861143") };
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
public class A189199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189199Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189199.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189199Inst Instance=new A189199Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189198
{
public static readonly BigInteger[] Value={ 20L,400L,6446L,101628L,1579664L,24496092L,379515360L,5878642448L,91053926856L,1410308064720L,21843768123936L,338330131913680L,5240270191277760L,81164599671831296L,1257128330483644640L,BigInteger.Parse("19471193573584406720") };
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
public class A189198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189198Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189198.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189198Inst Instance=new A189198Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189197
{
public static readonly long[] Value={ 12L,144L,1494L,15326L,156564L,1598444L,16316636L,166552852L,1700084336L,17353550112L,177135689224L,1808105575848L,18456166259888L,188390587782160L,1922989479244368L,19628839107258224L,200360599393734848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189197Inst : IEnumerable<long>
{
public static readonly long[] Value=A189197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189197.Bytes);
public long this[int i]=>Value[i];

public static A189197Inst Instance=new A189197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189196
{
public static readonly long[] Value={ 2L,4L,4L,8L,16L,7L,16L,64L,49L,12L,32L,256L,316L,144L,20L,64L,1024L,2032L,1494L,400L,33L,128L,4096L,13045L,15326L,6446L,1089L,54L,256L,16384L,83737L,156564L,101628L,27170L,2916L,88L,512L,65536L,537496L,1598444L,1579664L,657028L,111778L,7744L,143L,1024L,262144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189196Inst : IEnumerable<long>
{
public static readonly long[] Value=A189196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189196.Bytes);
public long this[int i]=>Value[i];

public static A189196Inst Instance=new A189196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189179
{
public static readonly long[] Value={ 1L,9L,33L,185L,913L,4777L,24577L,127385L,658801L,3410313L,17648609L,91343481L,472746833L,2446730345L,12663143361L,65538688857L,339198332209L,1755536122697L,9085854920609L,47024245778489L,243376070611729L,1259603657442857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189179Inst : IEnumerable<long>
{
public static readonly long[] Value=A189179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189179.Bytes);
public long this[int i]=>Value[i];

public static A189179Inst Instance=new A189179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189178
{
public static readonly BigInteger[] Value={ 0L,9L,192L,251720L,1339732352L,108943637068673L,BigInteger.Parse("76260881288534294528"),BigInteger.Parse("594579828469677562655346609") };
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
public class A189178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189178Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189178.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189178Inst Instance=new A189178Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189177
{
public static readonly long[] Value={ 1L,1L,3L,8L,26L,88L,311L,1125L,4139L,15411L,57901L,219070L,833509L,3185834L,12223298L,47048989L,181596815L,702589992L,2723964698L,10580344863L,41163089721L,160380285133L,625698670720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189177Inst : IEnumerable<long>
{
public static readonly long[] Value=A189177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189177.Bytes);
public long this[int i]=>Value[i];

public static A189177Inst Instance=new A189177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189176
{
public static readonly long[] Value={ 1L,2L,5L,15L,49L,168L,594L,2145L,7865L,29172L,109174L,411502L,1560090L,5943200L,22732740L,87253605L,335897865L,1296447900L,5015206350L,19439895090L,75487384830L,293595204240L,1143532045500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189176Inst : IEnumerable<long>
{
public static readonly long[] Value=A189176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189176.Bytes);
public long this[int i]=>Value[i];

public static A189176Inst Instance=new A189176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189175
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,6L,5L,3L,1L,20L,15L,9L,4L,1L,70L,49L,29L,14L,5L,1L,252L,168L,98L,49L,20L,6L,1L,924L,594L,342L,174L,76L,27L,7L,1L,3432L,2145L,1221L,627L,285L,111L,35L,8L,1L,12870L,7865L,4433L,2288L,1067L,440L,155L,44L,9L,1L,48620L,29172L,16302L,8437L,4004L,1716L,649L,209L,54L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189175Inst : IEnumerable<long>
{
public static readonly long[] Value=A189175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189175.Bytes);
public long this[int i]=>Value[i];

public static A189175Inst Instance=new A189175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189174
{
public static readonly long[] Value={ 61L,367L,88L,1251L,562L,162L,3335L,2049L,1203L,309L,7147L,5879L,4810L,3186L,449L,13411L,13342L,15061L,16762L,4875L,673L,23215L,26982L,36032L,64680L,25633L,9834L,945L,38239L,49867L,75899L,187120L,100789L,67714L,14883L,1493L,59909L,87001L,144828L,464292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189174Inst : IEnumerable<long>
{
public static readonly long[] Value=A189174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189174.Bytes);
public long this[int i]=>Value[i];

public static A189174Inst Instance=new A189174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189173
{
public static readonly BigInteger[] Value={ 0L,1L,47L,2161L,99359L,4568353L,210044879L,9657496081L,444034774847L,20415942146881L,938689303981679L,43159292041010353L,1984388744582494559L,BigInteger.Parse("91238722958753739361"),BigInteger.Parse("4194996867358089516047"),BigInteger.Parse("192878617175513363998801"),BigInteger.Parse("8868221393206256654428799"),BigInteger.Parse("407745305470312292739725953"),BigInteger.Parse("18747415830241159209372965039") };
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
public class A189173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189173Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A189173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189173.Bytes);
public BigInteger this[int i]=>Value[i];

public static A189173Inst Instance=new A189173Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189172
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,2L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,3L,3L,2L,3L,3L,3L,2L,5L,3L,3L,2L,5L,3L,5L,2L,3L,3L,5L,3L,5L,3L,3L,2L,5L,3L,5L,3L,3L,3L,5L,2L,7L,5L,3L,3L,7L,3L,5L,2L,3L,5L,7L,3L,7L,5L,3L,2L,5L,3L,7L,3L,3L,5L,7L,3L,7L,5L,5L,3L,7L,3L,7L,2L,3L,5L,7L,3L,5L,5L,5L,3L,7L,3L,7L,3L,5L,5L,5L,2L,7L,7L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189172Inst : IEnumerable<long>
{
public static readonly long[] Value=A189172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189172.Bytes);
public long this[int i]=>Value[i];

public static A189172Inst Instance=new A189172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189171
{
public static readonly long[] Value={ 1L,3L,5L,7L,10L,11L,14L,15L,16L,20L,21L,22L,27L,28L,29L,30L,35L,36L,37L,38L,39L,45L,46L,47L,49L,50L,54L,57L,58L,59L,61L,62L,63L,67L,71L,72L,73L,75L,76L,77L,82L,86L,87L,88L,89L,91L,92L,93L,98L,103L,104L,105L,106L,108L,109L,110L,111L,116L,120L,122L,123L,124L,125L,127L,128L,129L,131L,136L,140L,142L,143L,144L,145L,146L,148L,149L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189171Inst : IEnumerable<long>
{
public static readonly long[] Value=A189171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189171.Bytes);
public long this[int i]=>Value[i];

public static A189171Inst Instance=new A189171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189170
{
public static readonly long[] Value={ 2L,4L,6L,8L,9L,12L,13L,17L,18L,19L,23L,24L,25L,26L,31L,32L,33L,34L,40L,41L,42L,43L,44L,48L,51L,52L,53L,55L,56L,60L,64L,65L,66L,68L,69L,70L,74L,78L,79L,80L,81L,83L,84L,85L,90L,94L,95L,96L,97L,99L,100L,101L,102L,107L,112L,113L,114L,115L,117L,118L,119L,121L,126L,130L,132L,133L,134L,135L,137L,138L,139L,141L,147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189170Inst : IEnumerable<long>
{
public static readonly long[] Value=A189170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189170.Bytes);
public long this[int i]=>Value[i];

public static A189170Inst Instance=new A189170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189169
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189169Inst : IEnumerable<long>
{
public static readonly long[] Value=A189169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189169.Bytes);
public long this[int i]=>Value[i];

public static A189169Inst Instance=new A189169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A189168
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,8L,11L,12L,15L,16L,17L,21L,22L,23L,28L,29L,30L,31L,35L,37L,38L,39L,41L,45L,47L,49L,50L,52L,54L,57L,59L,61L,62L,63L,65L,67L,71L,73L,75L,76L,77L,79L,80L,82L,86L,89L,91L,92L,93L,95L,96L,98L,103L,106L,108L,109L,110L,111L,113L,114L,116L,122L,125L,127L,128L,129L,130L,131L,133L,134L,136L,142L,143L,146L,148L,149L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A189168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A189168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A189168Inst : IEnumerable<long>
{
public static readonly long[] Value=A189168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A189168.Bytes);
public long this[int i]=>Value[i];

public static A189168Inst Instance=new A189168Inst();

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