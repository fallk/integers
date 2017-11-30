using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A291343
{
public static readonly long[] Value={ 3L,5L,7L,9L,11L,13L,19L,23L,25L,33L,39L,41L,63L,67L,71L,85L,87L,91L,133L,171L,243L,291L,1239L,1543L,1879L,2169L,2421L,3149L,3323L,3377L,3501L,3529L,5433L,5599L,7299L,11227L,11275L,13939L,27147L,32435L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291343Inst : IEnumerable<long>
{
public static readonly long[] Value=A291343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291343.Bytes);
public long this[int i]=>Value[i];

public static A291343Inst Instance=new A291343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291344
{
public static readonly long[] Value={ 0L,1L,3L,7L,9L,13L,19L,27L,35L,37L,65L,67L,75L,83L,89L,101L,111L,229L,363L,633L,1605L,1663L,1769L,1863L,1947L,2695L,3003L,5309L,7835L,9495L,9945L,11041L,18833L,21119L,21465L,21889L,24509L,26757L,27595L,33657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291344Inst : IEnumerable<long>
{
public static readonly long[] Value=A291344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291344.Bytes);
public long this[int i]=>Value[i];

public static A291344Inst Instance=new A291344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291345
{
public static readonly long[] Value={ 5L,7L,11L,13L,19L,21L,25L,27L,35L,37L,51L,55L,65L,71L,105L,107L,129L,223L,229L,273L,307L,337L,345L,479L,509L,517L,519L,921L,963L,993L,1309L,1697L,1855L,1871L,2451L,2573L,2755L,3059L,3271L,4005L,4823L,17079L,20209L,20559L,37845L,38343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291345Inst : IEnumerable<long>
{
public static readonly long[] Value=A291345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291345.Bytes);
public long this[int i]=>Value[i];

public static A291345Inst Instance=new A291345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291346
{
public static readonly long[] Value={ 1000L,1011L,1101L,1110L,1112L,1113L,1114L,1115L,1116L,1117L,1118L,1119L,1121L,1131L,1141L,1151L,1161L,1171L,1181L,1191L,1211L,1222L,1311L,1333L,1411L,1444L,1511L,1555L,1611L,1666L,1711L,1777L,1811L,1888L,1911L,1999L,2000L,2022L,2111L,2122L,2202L,2212L,2220L,2221L,2223L,2224L,2225L,2226L,2227L,2228L,2229L,2232L,2242L,2252L,2262L,2272L,2282L,2292L,2322L,2333L,2422L,2444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291346Inst : IEnumerable<long>
{
public static readonly long[] Value=A291346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291346.Bytes);
public long this[int i]=>Value[i];

public static A291346Inst Instance=new A291346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291456
{
public static readonly BigInteger[] Value={ 0L,1L,65L,47449L,194397760L,3037656102976L,141727869124448256L,BigInteger.Parse("16674281388691716870144"),BigInteger.Parse("4371079210518164503303028736"),BigInteger.Parse("2322975003299339366419974718488576"),BigInteger.Parse("2322977286679362958150790503464960000000") };
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
public class A291456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291456Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291456.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291456Inst Instance=new A291456Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291457
{
public static readonly long[] Value={ 180L,240L,360L,420L,480L,540L,600L,660L,780L,840L,1080L,1320L,1560L,1890L,1920L,2016L,2040L,2184L,2280L,2352L,2376L,2688L,2760L,2856L,3000L,3192L,3360L,3480L,3720L,3744L,4284L,4320L,4440L,4680L,4704L,4896L,4920L,5160L,5292L,5640L,5796L,6048L,6360L,6552L,7080L,7128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291457Inst : IEnumerable<long>
{
public static readonly long[] Value=A291457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291457.Bytes);
public long this[int i]=>Value[i];

public static A291457Inst Instance=new A291457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291458
{
public static readonly long[] Value={ 27720L,60480L,65520L,90720L,98280L,105840L,115920L,120120L,120960L,128520L,131040L,143640L,151200L,163800L,180180L,191520L,205920L,207900L,211680L,218400L,229320L,235620L,241920L,249480L,264600L,272160L,289800L,292320L,312480L,332640L,360360L,372960L,393120L,414960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291458Inst : IEnumerable<long>
{
public static readonly long[] Value=A291458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291458.Bytes);
public long this[int i]=>Value[i];

public static A291458Inst Instance=new A291458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291459
{
public static readonly long[] Value={ 294053760L,575134560L,739458720L,882161280L,1193512320L,1314593280L,1725403680L,2539555200L,2588105520L,2646483840L,2711348640L,3008396160L,3891888000L,4053329280L,4214770560L,4648644000L,4802878080L,5176211040L,5194949760L,5258373120L,6470263800L,6768891360L,7900532640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291459Inst : IEnumerable<long>
{
public static readonly long[] Value=A291459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291459.Bytes);
public long this[int i]=>Value[i];

public static A291459Inst Instance=new A291459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291460
{
public static readonly long[] Value={ 16L,128L,384L,512L,1024L,1536L,1792L,2176L,2560L,2912L,3072L,5120L,7168L,8192L,9216L,11264L,13312L,15360L,15616L,16384L,17408L,19456L,21504L,23552L,25600L,27648L,28672L,29696L,31744L,33792L,35840L,37376L,37888L,39936L,41984L,43392L,57344L,66560L,90112L,98304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291460Inst : IEnumerable<long>
{
public static readonly long[] Value=A291460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291460.Bytes);
public long this[int i]=>Value[i];

public static A291460Inst Instance=new A291460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291461
{
public static readonly long[] Value={ 1L,512L,91125L,26198073L,12519490248L,20301732352L,87824421125L,93824221184L,121213882349L,128711132649L,162324571375L,171323771464L,368910352448L,19902511000000L,87782935806307L,171471879319616L,220721185826504L,470511577514952L,2977097087043793L,9063181647017784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291461Inst : IEnumerable<long>
{
public static readonly long[] Value=A291461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291461.Bytes);
public long this[int i]=>Value[i];

public static A291461Inst Instance=new A291461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291465
{
public static readonly long[] Value={ 1L,2L,4L,9L,14L,25L,36L,45L,52L,61L,62L,89L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291465Inst : IEnumerable<long>
{
public static readonly long[] Value=A291465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291465.Bytes);
public long this[int i]=>Value[i];

public static A291465Inst Instance=new A291465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291467
{
public static readonly long[] Value={ 11L,10L,9L,10L,11L,6L,7L,8L,9L,10L,11L,6L,11L,7L,9L,8L,11L,6L,11L,10L,7L,10L,11L,6L,11L,10L,9L,7L,11L,6L,11L,8L,9L,10L,7L,6L,11L,10L,9L,8L,11L,6L,11L,10L,9L,10L,11L,6L,7L,10L,9L,10L,11L,6L,11L,7L,9L,10L,11L,6L,11L,10L,7L,8L,11L,6L,11L,10L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291467Inst : IEnumerable<long>
{
public static readonly long[] Value=A291467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291467.Bytes);
public long this[int i]=>Value[i];

public static A291467Inst Instance=new A291467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291468
{
public static readonly long[] Value={ 16L,14L,12L,14L,16L,6L,7L,8L,9L,10L,11L,6L,13L,7L,12L,8L,16L,6L,16L,10L,7L,11L,16L,6L,16L,13L,9L,7L,16L,6L,16L,8L,11L,14L,7L,6L,16L,14L,12L,8L,16L,6L,16L,11L,9L,14L,16L,6L,7L,10L,12L,13L,16L,6L,11L,7L,12L,14L,16L,6L,16L,14L,7L,8L,13L,6L,16L,14L,12L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291468Inst : IEnumerable<long>
{
public static readonly long[] Value=A291468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291468.Bytes);
public long this[int i]=>Value[i];

public static A291468Inst Instance=new A291468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291469
{
public static readonly long[] Value={ 21L,18L,15L,18L,21L,6L,7L,8L,9L,10L,11L,6L,13L,7L,15L,8L,17L,6L,19L,10L,7L,11L,21L,6L,21L,13L,9L,7L,21L,6L,21L,8L,11L,17L,7L,6L,21L,18L,13L,8L,21L,6L,21L,11L,9L,18L,21L,6L,7L,10L,15L,13L,21L,6L,11L,7L,15L,18L,21L,6L,21L,18L,7L,8L,13L,6L,21L,17L,15L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291469Inst : IEnumerable<long>
{
public static readonly long[] Value=A291469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291469.Bytes);
public long this[int i]=>Value[i];

public static A291469Inst Instance=new A291469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291470
{
public static readonly long[] Value={ 26L,22L,18L,22L,26L,6L,7L,8L,9L,10L,11L,6L,13L,7L,15L,8L,17L,6L,19L,10L,7L,11L,23L,6L,25L,13L,9L,7L,26L,6L,26L,8L,11L,17L,7L,6L,26L,19L,13L,8L,26L,6L,26L,11L,9L,22L,26L,6L,7L,10L,17L,13L,26L,6L,11L,7L,18L,22L,26L,6L,26L,22L,7L,8L,13L,6L,26L,17L,18L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291470Inst : IEnumerable<long>
{
public static readonly long[] Value=A291470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291470.Bytes);
public long this[int i]=>Value[i];

public static A291470Inst Instance=new A291470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291471
{
public static readonly long[] Value={ 31L,26L,21L,26L,31L,6L,7L,8L,9L,10L,11L,6L,13L,7L,15L,8L,17L,6L,19L,10L,7L,11L,23L,6L,25L,13L,9L,7L,29L,6L,31L,8L,11L,17L,7L,6L,31L,19L,13L,8L,31L,6L,31L,11L,9L,23L,31L,6L,7L,10L,17L,13L,31L,6L,11L,7L,19L,26L,31L,6L,31L,26L,7L,8L,13L,6L,31L,17L,21L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291471Inst : IEnumerable<long>
{
public static readonly long[] Value=A291471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291471.Bytes);
public long this[int i]=>Value[i];

public static A291471Inst Instance=new A291471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291472
{
public static readonly long[] Value={ 36L,30L,24L,30L,36L,6L,7L,8L,9L,10L,11L,6L,13L,7L,15L,8L,17L,6L,19L,10L,7L,11L,23L,6L,25L,13L,9L,7L,29L,6L,31L,8L,11L,17L,7L,6L,36L,19L,13L,8L,36L,6L,36L,11L,9L,23L,36L,6L,7L,10L,17L,13L,36L,6L,11L,7L,19L,29L,36L,6L,36L,30L,7L,8L,13L,6L,36L,17L,23L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291472Inst : IEnumerable<long>
{
public static readonly long[] Value=A291472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291472.Bytes);
public long this[int i]=>Value[i];

public static A291472Inst Instance=new A291472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291473
{
public static readonly long[] Value={ 41L,34L,27L,34L,41L,6L,7L,8L,9L,10L,11L,6L,13L,7L,15L,8L,17L,6L,19L,10L,7L,11L,23L,6L,25L,13L,9L,7L,29L,6L,31L,8L,11L,17L,7L,6L,37L,19L,13L,8L,41L,6L,41L,11L,9L,23L,41L,6L,7L,10L,17L,13L,41L,6L,11L,7L,19L,29L,41L,6L,41L,31L,7L,8L,13L,6L,41L,17L,23L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291473Inst : IEnumerable<long>
{
public static readonly long[] Value=A291473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291473.Bytes);
public long this[int i]=>Value[i];

public static A291473Inst Instance=new A291473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291474
{
public static readonly long[] Value={ 13L,13L,13L,12L,13L,13L,7L,8L,9L,10L,11L,12L,13L,7L,13L,8L,13L,9L,13L,10L,7L,11L,13L,8L,13L,13L,9L,7L,13L,10L,13L,8L,11L,13L,7L,9L,13L,13L,13L,8L,13L,7L,13L,11L,9L,13L,13L,8L,7L,10L,13L,12L,13L,9L,11L,7L,13L,13L,13L,10L,13L,13L,7L,8L,13L,11L,13L,12L,13L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291474Inst : IEnumerable<long>
{
public static readonly long[] Value=A291474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291474.Bytes);
public long this[int i]=>Value[i];

public static A291474Inst Instance=new A291474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291475
{
public static readonly long[] Value={ 19L,19L,19L,16L,19L,19L,7L,8L,9L,10L,11L,12L,13L,7L,15L,8L,17L,9L,19L,10L,7L,11L,19L,8L,19L,13L,9L,7L,19L,10L,19L,8L,11L,17L,7L,9L,19L,19L,13L,8L,19L,7L,19L,11L,9L,19L,19L,8L,7L,10L,17L,13L,19L,9L,11L,7L,19L,19L,19L,10L,19L,19L,7L,8L,13L,11L,19L,16L,19L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291475Inst : IEnumerable<long>
{
public static readonly long[] Value=A291475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291475.Bytes);
public long this[int i]=>Value[i];

public static A291475Inst Instance=new A291475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291494
{
public static readonly long[] Value={ 43L,38L,39L,28L,35L,38L,43L,8L,9L,10L,11L,12L,13L,14L,15L,8L,17L,9L,19L,10L,21L,11L,23L,8L,25L,13L,9L,14L,29L,10L,31L,8L,11L,17L,35L,9L,37L,19L,13L,8L,41L,14L,43L,11L,9L,23L,43L,8L,43L,10L,17L,13L,43L,9L,11L,8L,19L,29L,43L,10L,43L,31L,9L,8L,13L,11L,43L,17L,23L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291494Inst : IEnumerable<long>
{
public static readonly long[] Value=A291494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291494.Bytes);
public long this[int i]=>Value[i];

public static A291494Inst Instance=new A291494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291495
{
public static readonly long[] Value={ 50L,44L,45L,32L,40L,44L,50L,8L,9L,10L,11L,12L,13L,14L,15L,8L,17L,9L,19L,10L,21L,11L,23L,8L,25L,13L,9L,14L,29L,10L,31L,8L,11L,17L,35L,9L,37L,19L,13L,8L,41L,14L,43L,11L,9L,23L,47L,8L,49L,10L,17L,13L,50L,9L,11L,8L,19L,29L,50L,10L,50L,31L,9L,8L,13L,11L,50L,17L,23L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291495Inst : IEnumerable<long>
{
public static readonly long[] Value=A291495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291495.Bytes);
public long this[int i]=>Value[i];

public static A291495Inst Instance=new A291495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291496
{
public static readonly long[] Value={ 57L,50L,51L,36L,45L,50L,57L,8L,9L,10L,11L,12L,13L,14L,15L,8L,17L,9L,19L,10L,21L,11L,23L,8L,25L,13L,9L,14L,29L,10L,31L,8L,11L,17L,35L,9L,37L,19L,13L,8L,41L,14L,43L,11L,9L,23L,47L,8L,49L,10L,17L,13L,53L,9L,11L,8L,19L,29L,57L,10L,57L,31L,9L,8L,13L,11L,57L,17L,23L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291496Inst : IEnumerable<long>
{
public static readonly long[] Value=A291496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291496.Bytes);
public long this[int i]=>Value[i];

public static A291496Inst Instance=new A291496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291497
{
public static readonly long[] Value={ -5L,-5L,-5L,-5L,-5L,-6L,-7L,-8L,-9L,-10L,-11L,-12L,-13L,-14L,-15L,-16L,-17L,-18L,-19L,-20L,-21L,-22L,-23L,-24L,-25L,-26L,-27L,-28L,-29L,-30L,-31L,-32L,-33L,-34L,-35L,-36L,-37L,-38L,-39L,-40L,-41L,-42L,-43L,-44L,-45L,-46L,-47L,-48L,-49L,-50L,-51L,-52L,-53L,-54L,-55L,-56L,-57L,-58L,-59L,-60L,-61L,-62L,-63L,-64L,-65L,-66L,-67L,-68L,-69L,-70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291497Inst : IEnumerable<long>
{
public static readonly long[] Value=A291497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291497.Bytes);
public long this[int i]=>Value[i];

public static A291497Inst Instance=new A291497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291498
{
public static readonly long[] Value={ -11L,-11L,-11L,-11L,-11L,-12L,-14L,-16L,-18L,-20L,-22L,-24L,-26L,-28L,-30L,-32L,-34L,-36L,-38L,-40L,-42L,-44L,-46L,-48L,-50L,-52L,-54L,-56L,-58L,-60L,-62L,-64L,-66L,-68L,-70L,-72L,-74L,-76L,-78L,-80L,-82L,-84L,-86L,-88L,-90L,-92L,-94L,-96L,-98L,-100L,-102L,-104L,-106L,-108L,-110L,-112L,-114L,-116L,-118L,-120L,-122L,-124L,-126L,-128L,-130L,-132L,-134L,-136L,-138L,-140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291498Inst : IEnumerable<long>
{
public static readonly long[] Value=A291498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291498.Bytes);
public long this[int i]=>Value[i];

public static A291498Inst Instance=new A291498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291499
{
public static readonly long[] Value={ -19L,-19L,-19L,-19L,-19L,-19L,-21L,-24L,-27L,-30L,-33L,-36L,-39L,-42L,-45L,-48L,-51L,-54L,-57L,-60L,-63L,-66L,-69L,-72L,-75L,-78L,-81L,-84L,-87L,-90L,-93L,-96L,-99L,-102L,-105L,-108L,-111L,-114L,-117L,-120L,-123L,-126L,-129L,-132L,-135L,-138L,-141L,-144L,-147L,-150L,-153L,-156L,-159L,-162L,-165L,-168L,-171L,-174L,-177L,-180L,-183L,-186L,-189L,-192L,-195L,-198L,-201L,-204L,-207L,-210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291499Inst : IEnumerable<long>
{
public static readonly long[] Value=A291499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291499.Bytes);
public long this[int i]=>Value[i];

public static A291499Inst Instance=new A291499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291500
{
public static readonly long[] Value={ -29L,-29L,-29L,-29L,-29L,-29L,-29L,-32L,-36L,-40L,-44L,-48L,-52L,-56L,-60L,-64L,-68L,-72L,-76L,-80L,-84L,-88L,-92L,-96L,-100L,-104L,-108L,-112L,-116L,-120L,-124L,-128L,-132L,-136L,-140L,-144L,-148L,-152L,-156L,-160L,-164L,-168L,-172L,-176L,-180L,-184L,-188L,-192L,-196L,-200L,-204L,-208L,-212L,-216L,-220L,-224L,-228L,-232L,-236L,-240L,-244L,-248L,-252L,-256L,-260L,-264L,-268L,-272L,-276L,-280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291500Inst : IEnumerable<long>
{
public static readonly long[] Value=A291500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291500.Bytes);
public long this[int i]=>Value[i];

public static A291500Inst Instance=new A291500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291501
{
public static readonly long[] Value={ -41L,-41L,-41L,-41L,-41L,-41L,-41L,-41L,-45L,-50L,-55L,-60L,-65L,-70L,-75L,-80L,-85L,-90L,-95L,-100L,-105L,-110L,-115L,-120L,-125L,-130L,-135L,-140L,-145L,-150L,-155L,-160L,-165L,-170L,-175L,-180L,-185L,-190L,-195L,-200L,-205L,-210L,-215L,-220L,-225L,-230L,-235L,-240L,-245L,-250L,-255L,-260L,-265L,-270L,-275L,-280L,-285L,-290L,-295L,-300L,-305L,-310L,-315L,-320L,-325L,-330L,-335L,-340L,-345L,-350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291501Inst : IEnumerable<long>
{
public static readonly long[] Value=A291501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291501.Bytes);
public long this[int i]=>Value[i];

public static A291501Inst Instance=new A291501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291502
{
public static readonly long[] Value={ -55L,-55L,-55L,-55L,-55L,-55L,-55L,-55L,-55L,-60L,-66L,-72L,-78L,-84L,-90L,-96L,-102L,-108L,-114L,-120L,-126L,-132L,-138L,-144L,-150L,-156L,-162L,-168L,-174L,-180L,-186L,-192L,-198L,-204L,-210L,-216L,-222L,-228L,-234L,-240L,-246L,-252L,-258L,-264L,-270L,-276L,-282L,-288L,-294L,-300L,-306L,-312L,-318L,-324L,-330L,-336L,-342L,-348L,-354L,-360L,-366L,-372L,-378L,-384L,-390L,-396L,-402L,-408L,-414L,-420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291502Inst : IEnumerable<long>
{
public static readonly long[] Value=A291502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291502.Bytes);
public long this[int i]=>Value[i];

public static A291502Inst Instance=new A291502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291503
{
public static readonly long[] Value={ 1L,1L,0L,0L,3L,0L,5L,3L,5L,3L,0L,3L,6L,5L,7L,7L,0L,5L,10L,7L,6L,0L,0L,7L,19L,6L,10L,6L,12L,7L,29L,0L,19L,0L,14L,6L,22L,10L,14L,0L,27L,6L,20L,19L,14L,0L,0L,0L,20L,19L,21L,14L,0L,10L,27L,14L,22L,12L,0L,0L,24L,29L,22L,21L,33L,19L,0L,21L,43L,14L,0L,14L,30L,22L,27L,22L,24L,14L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291503Inst : IEnumerable<long>
{
public static readonly long[] Value=A291503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291503.Bytes);
public long this[int i]=>Value[i];

public static A291503Inst Instance=new A291503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291504
{
public static readonly BigInteger[] Value={ 1L,1L,0L,1L,3L,8L,48L,206L,1838L,13336L,133764L,1081556L,11046816L,108196128L,1555323224L,16279258144L,289771660328L,3495882548784L,66923393467216L,942785369844048L,15625264115770992L,315553823251866304L,5974132307015712032L,BigInteger.Parse("104979988889030774848") };
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
public class A291504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291504Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291504.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291504Inst Instance=new A291504Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291505
{
public static readonly BigInteger[] Value={ 0L,1L,129L,282251L,4624680320L,361307736471424L,BigInteger.Parse("101143400834944548864"),BigInteger.Parse("83296040059942781485105152"),BigInteger.Parse("174684539610200377980575079727104"),BigInteger.Parse("835510910973061065615656036610946891776"),BigInteger.Parse("8355109938323553617123838798161699143680000000") };
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
public class A291505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291505Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291505.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291505Inst Instance=new A291505Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291506
{
public static readonly BigInteger[] Value={ 0L,1L,257L,1686433L,110523752704L,43173450975314176L,BigInteger.Parse("72514862031522895036416"),BigInteger.Parse("418033821374598847702425993216"),BigInteger.Parse("7013444132843374500928464765799366656"),BigInteger.Parse("301905779820559925981495987360836056017534976") };
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
public class A291506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291506Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291506.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291506Inst Instance=new A291506Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291507
{
public static readonly BigInteger[] Value={ 0L,1L,513L,10097891L,2647111616000L,5170142516807540224L,BigInteger.Parse("52103129720841632885243904"),BigInteger.Parse("2102549272223560776918400601161728"),BigInteger.Parse("282199388424234851655058321255905292713984"),BigInteger.Parse("109329825340451764123791003609208862665771818418176") };
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
public class A291507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291507Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291507.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291507Inst Instance=new A291507Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291508
{
public static readonly BigInteger[] Value={ 0L,1L,1025L,60526249L,63466432537600L,BigInteger.Parse("619789443653380965376"),BigInteger.Parse("37476298202061058687475122176"),BigInteger.Parse("10586126703664512292193022557971021824"),BigInteger.Parse("11366767006463449393869821987386636472445566976"),BigInteger.Parse("39633465899293694663690352980684333029782095493517541376") };
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
public class A291508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291508Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291508.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291508Inst Instance=new A291508Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291509
{
public static readonly long[] Value={ -7L,-8L,-7L,-8L,-7L,-8L,-7L,-8L,-9L,-10L,-11L,-12L,-13L,-14L,-15L,-16L,-17L,-18L,-19L,-20L,-21L,-22L,-23L,-24L,-25L,-26L,-27L,-28L,-29L,-30L,-31L,-32L,-33L,-34L,-35L,-36L,-37L,-38L,-39L,-40L,-41L,-42L,-43L,-44L,-45L,-46L,-47L,-48L,-49L,-50L,-51L,-52L,-53L,-54L,-55L,-56L,-57L,-58L,-59L,-60L,-61L,-62L,-63L,-64L,-65L,-66L,-67L,-68L,-69L,-70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291509Inst : IEnumerable<long>
{
public static readonly long[] Value=A291509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291509.Bytes);
public long this[int i]=>Value[i];

public static A291509Inst Instance=new A291509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291570
{
public static readonly long[] Value={ -23L,-23L,-23L,-23L,-25L,-24L,-23L,-23L,-23L,-25L,-23L,-24L,-26L,-28L,-30L,-32L,-34L,-36L,-38L,-40L,-42L,-44L,-46L,-48L,-50L,-52L,-54L,-56L,-58L,-60L,-62L,-64L,-66L,-68L,-70L,-72L,-74L,-76L,-78L,-80L,-82L,-84L,-86L,-88L,-90L,-92L,-94L,-96L,-98L,-100L,-102L,-104L,-106L,-108L,-110L,-112L,-114L,-116L,-118L,-120L,-122L,-124L,-126L,-128L,-130L,-132L,-134L,-136L,-138L,-140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291570Inst : IEnumerable<long>
{
public static readonly long[] Value=A291570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291570.Bytes);
public long this[int i]=>Value[i];

public static A291570Inst Instance=new A291570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291571
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,8L,9L,6L,9L,7L,9L,8L,9L,6L,9L,8L,7L,8L,9L,6L,9L,8L,9L,7L,9L,6L,9L,8L,9L,8L,7L,6L,9L,8L,9L,8L,9L,6L,9L,8L,9L,8L,9L,6L,7L,8L,9L,8L,9L,6L,9L,7L,9L,8L,9L,6L,9L,8L,7L,8L,9L,6L,9L,8L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291571Inst : IEnumerable<long>
{
public static readonly long[] Value=A291571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291571.Bytes);
public long this[int i]=>Value[i];

public static A291571Inst Instance=new A291571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291572
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,8L,10L,10L,6L,10L,7L,8L,8L,10L,6L,10L,10L,7L,10L,10L,6L,10L,10L,8L,7L,10L,6L,10L,8L,8L,10L,7L,6L,10L,10L,8L,8L,10L,6L,10L,10L,8L,10L,10L,6L,7L,10L,8L,10L,10L,6L,10L,7L,8L,10L,10L,6L,10L,10L,7L,8L,10L,6L,10L,10L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291572Inst : IEnumerable<long>
{
public static readonly long[] Value=A291572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291572.Bytes);
public long this[int i]=>Value[i];

public static A291572Inst Instance=new A291572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291573
{
public static readonly long[] Value={ 2L,2L,5L,14L,73L,1460L,138536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291573Inst : IEnumerable<long>
{
public static readonly long[] Value=A291573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291573.Bytes);
public long this[int i]=>Value[i];

public static A291573Inst Instance=new A291573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291574
{
public static readonly long[] Value={ 1L,0L,-1L,0L,1L,-4L,1L,0L,-1L,0L,1L,-4L,1L,0L,-1L,0L,1L,-4L,1L,0L,-1L,0L,1L,-4L,1L,0L,-1L,0L,1L,-4L,1L,0L,-1L,0L,1L,-4L,1L,0L,-1L,0L,1L,-4L,1L,0L,-1L,0L,1L,-4L,1L,0L,-1L,0L,1L,-4L,1L,0L,-1L,0L,1L,-4L,1L,0L,-1L,0L,1L,-4L,1L,0L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291574Inst : IEnumerable<long>
{
public static readonly long[] Value=A291574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291574.Bytes);
public long this[int i]=>Value[i];

public static A291574Inst Instance=new A291574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291575
{
public static readonly long[] Value={ -15L,-16L,-15L,-16L,-15L,-18L,-15L,-16L,-15L,-16L,-15L,-18L,-15L,-16L,-15L,-16L,-17L,-18L,-19L,-20L,-21L,-22L,-23L,-24L,-25L,-26L,-27L,-28L,-29L,-30L,-31L,-32L,-33L,-34L,-35L,-36L,-37L,-38L,-39L,-40L,-41L,-42L,-43L,-44L,-45L,-46L,-47L,-48L,-49L,-50L,-51L,-52L,-53L,-54L,-55L,-56L,-57L,-58L,-59L,-60L,-61L,-62L,-63L,-64L,-65L,-66L,-67L,-68L,-69L,-70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291575Inst : IEnumerable<long>
{
public static readonly long[] Value=A291575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291575.Bytes);
public long this[int i]=>Value[i];

public static A291575Inst Instance=new A291575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291576
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,11L,11L,7L,11L,8L,11L,9L,11L,10L,7L,11L,11L,8L,11L,11L,9L,7L,11L,10L,11L,8L,11L,11L,7L,9L,11L,11L,11L,8L,11L,7L,11L,11L,9L,11L,11L,8L,7L,10L,11L,11L,11L,9L,11L,7L,11L,11L,11L,10L,11L,11L,7L,8L,11L,11L,11L,11L,11L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291576Inst : IEnumerable<long>
{
public static readonly long[] Value=A291576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291576.Bytes);
public long this[int i]=>Value[i];

public static A291576Inst Instance=new A291576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291578
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,-5L,1L,1L,1L,1L,1L,1L,-5L,1L,1L,1L,1L,1L,1L,-5L,1L,1L,1L,1L,1L,1L,-5L,1L,1L,1L,1L,1L,1L,-5L,1L,1L,1L,1L,1L,1L,-5L,1L,1L,1L,1L,1L,1L,-5L,1L,1L,1L,1L,1L,1L,-5L,1L,1L,1L,1L,1L,1L,-5L,1L,1L,1L,1L,1L,1L,-5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291578Inst : IEnumerable<long>
{
public static readonly long[] Value=A291578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291578.Bytes);
public long this[int i]=>Value[i];

public static A291578Inst Instance=new A291578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291579
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,12L,13L,8L,13L,9L,13L,10L,13L,11L,13L,8L,13L,12L,9L,12L,13L,10L,13L,8L,11L,12L,13L,9L,13L,12L,13L,8L,13L,12L,13L,11L,9L,12L,13L,8L,13L,10L,13L,12L,13L,9L,11L,8L,13L,12L,13L,10L,13L,12L,9L,8L,13L,11L,13L,12L,13L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291579Inst : IEnumerable<long>
{
public static readonly long[] Value=A291579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291579.Bytes);
public long this[int i]=>Value[i];

public static A291579Inst Instance=new A291579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291580
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,8L,16L,9L,16L,10L,14L,11L,16L,8L,16L,13L,9L,14L,16L,10L,16L,8L,11L,16L,14L,9L,16L,16L,13L,8L,16L,14L,16L,11L,9L,16L,16L,8L,14L,10L,16L,13L,16L,9L,11L,8L,16L,16L,16L,10L,16L,16L,9L,8L,13L,11L,16L,16L,16L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291580Inst : IEnumerable<long>
{
public static readonly long[] Value=A291580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291580.Bytes);
public long this[int i]=>Value[i];

public static A291580Inst Instance=new A291580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291581
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,8L,17L,9L,17L,10L,14L,11L,17L,8L,17L,13L,9L,14L,17L,10L,17L,8L,11L,16L,14L,9L,17L,16L,13L,8L,17L,14L,17L,11L,9L,16L,17L,8L,14L,10L,17L,13L,17L,9L,11L,8L,17L,16L,17L,10L,17L,16L,9L,8L,13L,11L,17L,14L,17L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291581Inst : IEnumerable<long>
{
public static readonly long[] Value=A291581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291581.Bytes);
public long this[int i]=>Value[i];

public static A291581Inst Instance=new A291581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291582
{
public static readonly long[] Value={ 30L,132L,306L,552L,870L,1260L,1722L,2256L,2862L,3540L,4290L,5112L,6006L,6972L,8010L,9120L,10302L,11556L,12882L,14280L,15750L,17292L,18906L,20592L,22350L,24180L,26082L,28056L,30102L,32220L,34410L,36672L,39006L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291582Inst : IEnumerable<long>
{
public static readonly long[] Value=A291582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291582.Bytes);
public long this[int i]=>Value[i];

public static A291582Inst Instance=new A291582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291583
{
public static readonly long[] Value={ 1L,2L,4L,8L,18L,36L,72L,144L,292L,586L,1172L,2344L,4696L,9396L,18792L,37584L,75186L,150380L,300764L,601528L,1203092L,2406200L,4812408L,9624816L,19249704L,38499446L,76998908L,153997824L,307995792L,615991660L,1231983352L,2463966720L,4927933732L,9855867616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291583Inst : IEnumerable<long>
{
public static readonly long[] Value=A291583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291583.Bytes);
public long this[int i]=>Value[i];

public static A291583Inst Instance=new A291583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291584
{
public static readonly long[] Value={ 1L,0L,1L,-2L,1L,0L,1L,-6L,1L,0L,1L,-2L,1L,0L,1L,-6L,1L,0L,1L,-2L,1L,0L,1L,-6L,1L,0L,1L,-2L,1L,0L,1L,-6L,1L,0L,1L,-2L,1L,0L,1L,-6L,1L,0L,1L,-2L,1L,0L,1L,-6L,1L,0L,1L,-2L,1L,0L,1L,-6L,1L,0L,1L,-2L,1L,0L,1L,-6L,1L,0L,1L,-2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291584Inst : IEnumerable<long>
{
public static readonly long[] Value=A291584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291584.Bytes);
public long this[int i]=>Value[i];

public static A291584Inst Instance=new A291584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291585
{
public static readonly BigInteger[] Value={ 0L,1L,28L,3527L,1213136L,885533769L,1179489355164L,2592461355675183L,8752024838912328000L,BigInteger.Parse("43007026735417743104625"),BigInteger.Parse("295026115290377469777013500"),BigInteger.Parse("2732517516522603185416699320375"),BigInteger.Parse("33249139841891876848539850177362000"),BigInteger.Parse("519549434719363290227226596791835765625") };
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
public class A291585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291585Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291585.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291585Inst Instance=new A291585Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291586
{
public static readonly BigInteger[] Value={ 0L,1L,82L,51331L,123296356L,809068942341L,11846375878465206L,BigInteger.Parse("338356017569383549191"),BigInteger.Parse("17129606870671774862445000"),BigInteger.Parse("1430698777932227525446706735625"),BigInteger.Parse("186451505481090040331197201556276250"),BigInteger.Parse("36261458995575361475673937929555130516875") };
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
public class A291586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291586Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291586.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291586Inst Instance=new A291586Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291638
{
public static readonly long[] Value={ 370440L,1704024L,3926664L,11039112L,13854456L,21707784L,25264008L,28375704L,40822488L,44378712L,57862728L,59196312L,63937944L,75051144L,79051896L,79940952L,103500936L,107946216L,128394504L,134766072L,162178632L,169735608L,177737112L,191517480L,193530168L,195221880L,196407288L,215077464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291638Inst : IEnumerable<long>
{
public static readonly long[] Value=A291638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291638.Bytes);
public long this[int i]=>Value[i];

public static A291638Inst Instance=new A291638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291639
{
public static readonly long[] Value={ 10L,16L,20L,22L,30L,34L,37L,40L,42L,43L,47L,48L,50L,52L,59L,60L,63L,67L,69L,70L,73L,74L,79L,80L,84L,86L,87L,89L,90L,93L,94L,99L,100L,101L,102L,103L,106L,107L,109L,110L,112L,115L,116L,117L,118L,120L,123L,124L,126L,127L,128L,130L,131L,134L,135L,138L,140L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291639Inst : IEnumerable<long>
{
public static readonly long[] Value=A291639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291639.Bytes);
public long this[int i]=>Value[i];

public static A291639Inst Instance=new A291639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291640
{
public static readonly long[] Value={ 1L,5L,6L,8L,11L,12L,13L,17L,21L,23L,24L,25L,26L,27L,28L,31L,39L,41L,44L,45L,49L,51L,53L,54L,55L,56L,57L,58L,61L,64L,68L,71L,75L,81L,82L,83L,85L,88L,91L,97L,98L,104L,105L,108L,111L,113L,114L,119L,121L,122L,125L,129L,136L,137L,139L,146L,147L,148L,151L,153L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291640Inst : IEnumerable<long>
{
public static readonly long[] Value=A291640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291640.Bytes);
public long this[int i]=>Value[i];

public static A291640Inst Instance=new A291640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291641
{
public static readonly long[] Value={ 3L,9L,14L,18L,29L,32L,35L,38L,62L,65L,66L,72L,78L,132L,133L,142L,144L,154L,155L,166L,177L,178L,188L,196L,198L,203L,282L,286L,288L,295L,296L,298L,305L,307L,322L,323L,328L,337L,357L,359L,362L,364L,375L,377L,382L,404L,412L,425L,444L,453L,463L,607L,609L,616L,632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291641Inst : IEnumerable<long>
{
public static readonly long[] Value=A291641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291641.Bytes);
public long this[int i]=>Value[i];

public static A291641Inst Instance=new A291641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291642
{
public static readonly long[] Value={ 7L,15L,33L,46L,76L,77L,95L,96L,157L,167L,175L,179L,186L,197L,207L,213L,215L,326L,327L,332L,335L,353L,355L,379L,389L,427L,429L,437L,454L,457L,464L,714L,764L,775L,813L,816L,826L,859L,883L,922L,927L,942L,957L,1526L,1529L,1553L,1557L,1636L,1692L,1695L,1753L,1782L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291642Inst : IEnumerable<long>
{
public static readonly long[] Value=A291642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291642.Bytes);
public long this[int i]=>Value[i];

public static A291642Inst Instance=new A291642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291643
{
public static readonly long[] Value={ 4L,36L,204L,786L,842L,1682L,2114L,3795L,3859L,3863L,4429L,4459L,4559L,4635L,7644L,7913L,7914L,8183L,8286L,8372L,8744L,8864L,9144L,9263L,9599L,16592L,17094L,17863L,18923L,19035L,19563L,19829L,20364L,20635L,20776L,36264L,38183L,38389L,38432L,40186L,44216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291643Inst : IEnumerable<long>
{
public static readonly long[] Value=A291643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291643.Bytes);
public long this[int i]=>Value[i];

public static A291643Inst Instance=new A291643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291644
{
public static readonly long[] Value={ 19L,423L,1786L,1966L,4053L,4235L,40326L,45882L,198823L,204782L,442693L,2131842L,3911966L,4061115L,4081435L,4603475L,8789299L,18027632L,40987223L,42647176L,44100092L,46097753L,88776682L,96439993L,96540315L,98954326L,190349299L,197967719L,423185632L,428896755L,463968436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291644Inst : IEnumerable<long>
{
public static readonly long[] Value=A291644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291644.Bytes);
public long this[int i]=>Value[i];

public static A291644Inst Instance=new A291644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291645
{
public static readonly long[] Value={ 1L,0L,0L,-1L,-1L,0L,4L,9L,4L,-23L,-78L,-78L,132L,694L,1088L,-443L,-6169L,-13452L,-4646L,52247L,155891L,143796L,-391672L,-1715015L,-2481013L,2107735L,17836000L,35704800L,3037215L,-172386166L,-465009936L,-338007604L,1487272659L,5624864403L,7125599375L,-10208041482L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291645Inst : IEnumerable<long>
{
public static readonly long[] Value=A291645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291645.Bytes);
public long this[int i]=>Value[i];

public static A291645Inst Instance=new A291645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291646
{
public static readonly long[] Value={ 1L,0L,-1L,-1L,2L,6L,-1L,-29L,-32L,108L,311L,-185L,-1991L,-1590L,9468L,22163L,-26645L,-170511L,-70359L,955734L,1755790L,-3561052L,-16020532L,309754L,102695477L,141637053L,-463468990L,-1567907433L,806541136L,11367276801L,10768399120L,-59447130815L,-155142592628L,172852194214L,1273466836673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291646Inst : IEnumerable<long>
{
public static readonly long[] Value=A291646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291646.Bytes);
public long this[int i]=>Value[i];

public static A291646Inst Instance=new A291646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291647
{
public static readonly long[] Value={ 1L,0L,2L,3L,1L,11L,3L,20L,21L,20L,64L,35L,112L,117L,160L,269L,284L,477L,598L,819L,1116L,1495L,1899L,2718L,3389L,4596L,6121L,7627L,10460L,13128L,17350L,22506L,28696L,37063L,47779L,60249L,78642L,98783L,126058L,160758L,200795L,257750L,321768L,407930L,511526L,640636L,802816L,1005618L,1252820L,1567454L,1946162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291647Inst : IEnumerable<long>
{
public static readonly long[] Value=A291647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291647.Bytes);
public long this[int i]=>Value[i];

public static A291647Inst Instance=new A291647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291649
{
public static readonly long[] Value={ 1L,1L,0L,0L,4L,4L,0L,0L,6L,15L,9L,0L,4L,40L,36L,0L,17L,71L,90L,36L,64L,100L,180L,144L,96L,274L,394L,300L,148L,740L,820L,480L,472L,1150L,1851L,1341L,1146L,1318L,3880L,3540L,1704L,3017L,6455L,7134L,3780L,7822L,9574L,12180L,10304L,12057L,19750L,22485L,20558L,15910L,43076L,43236L,31104L,33742L,66895L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291649Inst : IEnumerable<long>
{
public static readonly long[] Value=A291649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291649.Bytes);
public long this[int i]=>Value[i];

public static A291649Inst Instance=new A291649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291650
{
public static readonly long[] Value={ 1L,1L,2L,5L,4L,12L,14L,16L,42L,35L,65L,100L,84L,205L,201L,254L,490L,386L,749L,917L,851L,1816L,1566L,2260L,3513L,2784L,5566L,5748L,6116L,11366L,9048L,14740L,19037L,16095L,31576L,28505L,35218L,56334L,43671L,77512L,85163L,80577L,147756L,121016L,172408L,236022L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291650Inst : IEnumerable<long>
{
public static readonly long[] Value=A291650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291650.Bytes);
public long this[int i]=>Value[i];

public static A291650Inst Instance=new A291650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291651
{
public static readonly long[] Value={ 1L,-1L,3L,-7L,15L,-26L,15L,153L,-1049L,4790L,-18522L,64481L,-206181L,606384L,-1615121L,3715993L,-6289929L,550850L,61250694L,-382787092L,1726745790L,-6691501530L,23413714107L,-75179994017L,221304346963L,-586004040651L,1318720868416L,-2044320913276L,-1137686341077L,28530838758784L,-165361803129585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291651Inst : IEnumerable<long>
{
public static readonly long[] Value=A291651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291651.Bytes);
public long this[int i]=>Value[i];

public static A291651Inst Instance=new A291651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291652
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,3L,3L,2L,0L,1L,4L,6L,6L,3L,0L,1L,5L,10L,13L,11L,5L,0L,1L,6L,15L,24L,27L,20L,9L,0L,1L,7L,21L,40L,55L,54L,38L,15L,0L,1L,8L,28L,62L,100L,120L,109L,70L,26L,0L,1L,9L,36L,91L,168L,236L,258L,216L,129L,45L,0L,1L,10L,45L,128L,266L,426L,540L,544L,423L,238L,78L,0L,1L,11L,55L,174L,402L,721L,1035L,1205L,1127L,824L,437L,135L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291652Inst : IEnumerable<long>
{
public static readonly long[] Value=A291652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291652.Bytes);
public long this[int i]=>Value[i];

public static A291652Inst Instance=new A291652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291653
{
public static readonly long[] Value={ 1L,1L,3L,13L,55L,236L,1035L,4593L,20551L,92578L,419338L,1907951L,8713555L,39921038L,183396671L,844515563L,3896933367L,18014916576L,83415684654L,386807933378L,1796024496430L,8349190182990L,38854827380075L,180997895984903L,843906670596499L,3938005827167461L,18390418912425940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291653Inst : IEnumerable<long>
{
public static readonly long[] Value=A291653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291653.Bytes);
public long this[int i]=>Value[i];

public static A291653Inst Instance=new A291653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291654
{
public static readonly long[] Value={ 35L,35L,34L,22L,12L,11L,5L,7L,10L,5L,10L,10L,6L,6L,7L,7L,4L,3L,5L,13L,14L,6L,1L,5L,5L,3L,4L,3L,2L,2L,4L,3L,2L,2L,3L,3L,1L,4L,6L,3L,3L,3L,1L,3L,7L,6L,2L,2L,2L,6L,6L,1L,6L,9L,5L,5L,5L,2L,4L,5L,2L,2L,2L,7L,8L,7L,6L,2L,3L,4L,5L,3L,1L,1L,4L,5L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291654Inst : IEnumerable<long>
{
public static readonly long[] Value=A291654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291654.Bytes);
public long this[int i]=>Value[i];

public static A291654Inst Instance=new A291654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291693
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,8L,11L,13L,16L,19L,22L,26L,30L,34L,38L,44L,49L,54L,62L,67L,74L,83L,89L,98L,107L,115L,124L,134L,145L,155L,168L,178L,189L,206L,217L,231L,247L,259L,277L,294L,310L,327L,345L,365L,382L,404L,424L,444L,470L,489L,513L,539L,561L,588L,613L,641L,670L,699L,729L,756L,791L,824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291693Inst : IEnumerable<long>
{
public static readonly long[] Value=A291693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291693.Bytes);
public long this[int i]=>Value[i];

public static A291693Inst Instance=new A291693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291694
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,2L,5L,1L,5L,13L,2L,5L,29L,1L,13L,34L,1L,34L,89L,2L,29L,169L,5L,13L,194L,1L,89L,233L,5L,29L,433L,1L,233L,610L,2L,169L,985L,13L,34L,1325L,1L,610L,1597L,5L,194L,2897L,1L,1597L,4181L,2L,985L,5741L,5L,433L,6466L,13L,194L,7561L,34L,89L,9077L,1L,4181L,10946L,29L,169L,14701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291694Inst : IEnumerable<long>
{
public static readonly long[] Value=A291694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291694.Bytes);
public long this[int i]=>Value[i];

public static A291694Inst Instance=new A291694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291695
{
public static readonly long[] Value={ 1L,-3L,12L,-57L,304L,-1757L,10746L,-68450L,449274L,-3016645L,20618317L,-142946735L,1002722249L,-7103064540L,50738237140L,-365049115546L,2642981328372L,-19241453032254L,140770867457795L,-1034409857616986L,7631075823632553L,-56497364856268721L,419641611512419630L,-3126180409889288924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291695Inst : IEnumerable<long>
{
public static readonly long[] Value=A291695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291695.Bytes);
public long this[int i]=>Value[i];

public static A291695Inst Instance=new A291695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291696
{
public static readonly long[] Value={ 1L,-1L,0L,0L,-4L,4L,0L,0L,6L,-15L,9L,0L,-4L,40L,-36L,0L,-15L,-39L,90L,-36L,64L,-28L,-180L,144L,-96L,206L,106L,-300L,148L,-540L,332L,480L,-232L,610L,-1029L,-189L,114L,-86L,1880L,-1068L,24L,-921L,-1545L,2466L,-300L,2858L,-1514L,-3180L,976L,-4121L,5590L,1995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291696Inst : IEnumerable<long>
{
public static readonly long[] Value=A291696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291696.Bytes);
public long this[int i]=>Value[i];

public static A291696Inst Instance=new A291696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291697
{
public static readonly long[] Value={ 1L,2L,8L,44L,256L,1512L,9056L,54896L,335872L,2069774L,12827888L,79875996L,499305472L,3131436856L,19694403520L,124165133424L,784478240768L,4965659813668L,31484486937512L,199923173603596L,1271192603065856L,8092551782518688L,51574780342740256L,329022223268286288L,2100934234342260736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291697Inst : IEnumerable<long>
{
public static readonly long[] Value=A291697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291697.Bytes);
public long this[int i]=>Value[i];

public static A291697Inst Instance=new A291697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291698
{
public static readonly long[] Value={ 1L,1L,2L,12L,20L,55L,294L,497L,1224L,2520L,14410L,21912L,54300L,104286L,220710L,1105215L,1697552L,3839382L,7356762L,14873580L,26275620L,132112596L,188666126L,423247104L,772560600L,1535398150L,2632049290L,4975242048L,21273166572L,30649985160L,64824339630L,116604788800L,223181224992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291698Inst : IEnumerable<long>
{
public static readonly long[] Value=A291698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291698.Bytes);
public long this[int i]=>Value[i];

public static A291698Inst Instance=new A291698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291699
{
public static readonly BigInteger[] Value={ 1L,1L,8L,135L,3584L,131250L,6158592L,353299947L,23991418880L,1883638417518L,167960000000000L,16772331868538246L,1854655886442627072L,BigInteger.Parse("225005916687384753700"),BigInteger.Parse("29718395534545380311040"),BigInteger.Parse("4245313393689422607421875"),BigInteger.Parse("652233889532678001886494720"),BigInteger.Parse("107247390031799133661006687830") };
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
public class A291699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291699Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291699.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291699Inst Instance=new A291699Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291700
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,9L,73L,361L,1321L,3961L,10297L,24025L,51481L,103081L,196521L,368425L,720937L,1589161L,4069801L,11511721L,33341353L,94142313L,253860201L,650564201L,1588228228L,3716917597L,8418378043L,18699454621L,41451042556L,93508305513L,218218347865L,530189399785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291700Inst : IEnumerable<long>
{
public static readonly long[] Value=A291700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291700.Bytes);
public long this[int i]=>Value[i];

public static A291700Inst Instance=new A291700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291701
{
public static readonly long[] Value={ 1L,1L,0L,1L,-1L,0L,1L,-2L,0L,0L,1L,-3L,1L,-1L,0L,1L,-4L,3L,-2L,0L,0L,1L,-5L,6L,-4L,2L,-1L,0L,1L,-6L,10L,-8L,6L,-2L,-1L,0L,1L,-7L,15L,-15L,13L,-6L,1L,-1L,0L,1L,-8L,21L,-26L,25L,-16L,6L,0L,-2L,0L,1L,-9L,28L,-42L,45L,-36L,18L,-3L,0L,-2L,0L,1L,-10L,36L,-64L,77L,-72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291701Inst : IEnumerable<long>
{
public static readonly long[] Value=A291701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291701.Bytes);
public long this[int i]=>Value[i];

public static A291701Inst Instance=new A291701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291702
{
public static readonly long[] Value={ 1L,-1L,1L,-4L,13L,-36L,100L,-281L,797L,-2281L,6546L,-18778L,53872L,-154662L,444263L,-1276284L,3665773L,-10524939L,30203731L,-86624174L,248257298L,-710882708L,2033663952L,-5811660425L,16588828304L,-47291077636L,134630218334L,-382697080366L,1086083438999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291702Inst : IEnumerable<long>
{
public static readonly long[] Value=A291702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291702.Bytes);
public long this[int i]=>Value[i];

public static A291702Inst Instance=new A291702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291703
{
public static readonly long[] Value={ 7L,54L,490L,4050L,32674L,261954L,2096770L,16776450L,134216194L,1073738754L,8589928450L,68719464450L,549755789314L,4398046461954L,35184371990530L,281474976514050L,2251799813292034L,18014398508695554L,144115188074283010L,1152921504603701250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291703Inst : IEnumerable<long>
{
public static readonly long[] Value=A291703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291703.Bytes);
public long this[int i]=>Value[i];

public static A291703Inst Instance=new A291703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291704
{
public static readonly long[] Value={ 1L,3L,9L,115L,28853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291704Inst : IEnumerable<long>
{
public static readonly long[] Value=A291704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291704.Bytes);
public long this[int i]=>Value[i];

public static A291704Inst Instance=new A291704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291705
{
public static readonly long[] Value={ 1L,0L,0L,11140L,6635521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291705Inst : IEnumerable<long>
{
public static readonly long[] Value=A291705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291705.Bytes);
public long this[int i]=>Value[i];

public static A291705Inst Instance=new A291705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291706
{
public static readonly long[] Value={ 3L,9L,24L,56L,136L,328L,792L,1912L,4616L,11144L,26904L,64952L,156808L,378568L,913944L,2206456L,5326856L,12860168L,31047192L,74954552L,180956296L,436867144L,1054690584L,2546248312L,6147187208L,14840622728L,35828432664L,86497488056L,208823408776L,504144305608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291706Inst : IEnumerable<long>
{
public static readonly long[] Value=A291706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291706.Bytes);
public long this[int i]=>Value[i];

public static A291706Inst Instance=new A291706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291707
{
public static readonly long[] Value={ 1L,3L,49L,12549640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291707Inst : IEnumerable<long>
{
public static readonly long[] Value=A291707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291707.Bytes);
public long this[int i]=>Value[i];

public static A291707Inst Instance=new A291707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291710
{
public static readonly long[] Value={ 1L,3L,4L,7L,16L,33L,37L,226L,295L,313L,429L,607L,2113L,2317L,2721L,2887L,2907L,2953L,6058L,11971L,30865L,58923L,98199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291710Inst : IEnumerable<long>
{
public static readonly long[] Value=A291710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291710.Bytes);
public long this[int i]=>Value[i];

public static A291710Inst Instance=new A291710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145789
{
public static readonly long[] Value={ 1L,1L,1L,15L,89L,904L,10469L,202299L,6253788L,295345323L,20297903190L,2062672356086L,313264131593508L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145789Inst : IEnumerable<long>
{
public static readonly long[] Value=A145789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145789.Bytes);
public long this[int i]=>Value[i];

public static A145789Inst Instance=new A145789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145790
{
public static readonly BigInteger[] Value={ 1L,1L,1L,9L,11L,36L,65L,515L,2420L,18065L,172108L,1981958L,24609296L,431265080L,7420809238L,183434050306L,4983211868325L,173511007323269L,7989094384834315L,376330135051842303L,BigInteger.Parse("28830157229045747299"),BigInteger.Parse("1923394214566012353119") };
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
public class A145790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145790Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A145790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145790.Bytes);
public BigInteger this[int i]=>Value[i];

public static A145790Inst Instance=new A145790Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145791
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,6L,1L,17L,26L,113L,318L,1310L,4072L,21570L,65328L,442636L,1558383L,13750703L,69409037L,646392443L,4686057331L,48049954607L,457665821401L,5254108049909L,63960030819910L,855193502729867L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145791Inst : IEnumerable<long>
{
public static readonly long[] Value=A145791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145791.Bytes);
public long this[int i]=>Value[i];

public static A145791Inst Instance=new A145791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145792
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,3L,8L,27L,89L,350L,1943L,13578L,114816L,1134812L,13374912L,197153652L,3619365346L,81478825413L,2227027591689L,73860566227987L,3001388762491543L,149854380038852307L,9172310473214513455L,BigInteger.Parse("686434022927867658469") };
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
public class A145792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145792Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A145792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145792.Bytes);
public BigInteger this[int i]=>Value[i];

public static A145792Inst Instance=new A145792Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145793
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,3L,5L,8L,17L,40L,108L,294L,944L,3040L,12114L,49757L,243775L,1210271L,7153531L,43484383L,316861269L,2366046579L,21108349931L,192219307524L,2092034177623L,23326966046445L,311290850669433L,4251413939111348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145793Inst : IEnumerable<long>
{
public static readonly long[] Value=A145793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145793.Bytes);
public long this[int i]=>Value[i];

public static A145793Inst Instance=new A145793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145794
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,3L,2L,5L,6L,12L,20L,34L,68L,154L,265L,709L,1281L,3847L,8603L,25073L,71217L,206107L,695670L,2185029L,7989257L,27851353L,111404338L,424685942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145794Inst : IEnumerable<long>
{
public static readonly long[] Value=A145794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145794.Bytes);
public long this[int i]=>Value[i];

public static A145794Inst Instance=new A145794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145795
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,4L,7L,15L,34L,91L,268L,848L,2982L,11440L,47890L,231566L,1214519L,7161065L,45785181L,328548555L,2571260385L,22573158713L,216461088819L,2326997861375L,27251383779874L,358326282799095L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145795Inst : IEnumerable<long>
{
public static readonly long[] Value=A145795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145795.Bytes);
public long this[int i]=>Value[i];

public static A145795Inst Instance=new A145795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145796
{
public static readonly long[] Value={ 1L,1L,1L,3L,9L,16L,93L,367L,2220L,13167L,126326L,1163166L,15908600L,209043350L,4432902382L,88370483688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145796Inst : IEnumerable<long>
{
public static readonly long[] Value=A145796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145796.Bytes);
public long this[int i]=>Value[i];

public static A145796Inst Instance=new A145796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145797
{
public static readonly long[] Value={ 2L,11L,2137L,8929L,1801L,44111L,6637L,57241L,16931L,151477L,54083L,3889L,127717L,457511L,571019L,765983L,38557L,1662229L,2437751L,16139L,2305883L,2747449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145797Inst : IEnumerable<long>
{
public static readonly long[] Value=A145797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145797.Bytes);
public long this[int i]=>Value[i];

public static A145797Inst Instance=new A145797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145798
{
public static readonly long[] Value={ 2L,37L,8663L,28703L,56999L,48817L,86291L,87959L,133597L,246011L,334717L,367823L,552011L,786697L,735781L,1154017L,1586531L,1915163L,2446777L,3882661L,3811669L,4074743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145798Inst : IEnumerable<long>
{
public static readonly long[] Value=A145798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145798.Bytes);
public long this[int i]=>Value[i];

public static A145798Inst Instance=new A145798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145799
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,3L,7L,1L,9L,5L,5L,3L,5L,7L,15L,1L,17L,9L,9L,5L,21L,5L,7L,3L,9L,5L,27L,7L,7L,15L,31L,1L,33L,17L,17L,9L,9L,9L,9L,5L,9L,21L,21L,5L,45L,7L,15L,3L,17L,9L,51L,5L,21L,27L,27L,7L,9L,7L,27L,15L,15L,31L,63L,1L,65L,33L,33L,17L,17L,17L,17L,9L,73L,9L,9L,9L,9L,9L,15L,5L,17L,9L,9L,21L,85L,21L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145799Inst : IEnumerable<long>
{
public static readonly long[] Value=A145799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145799.Bytes);
public long this[int i]=>Value[i];

public static A145799Inst Instance=new A145799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145800
{
public static readonly long[] Value={ 1L,5L,3L,9L,5L,27L,7L,17L,9L,21L,27L,51L,27L,93L,15L,33L,17L,73L,51L,165L,21L,45L,93L,99L,51L,107L,27L,231L,93L,189L,31L,65L,33L,273L,99L,73L,165L,153L,231L,325L,165L,85L,107L,717L,45L,93L,189L,195L,99L,403L,51L,843L,107L,219L,119L,455L,231L,471L,119L,633L,189L,381L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145800Inst : IEnumerable<long>
{
public static readonly long[] Value=A145800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145800.Bytes);
public long this[int i]=>Value[i];

public static A145800Inst Instance=new A145800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145801
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,9L,12L,16L,19L,25L,29L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145801Inst : IEnumerable<long>
{
public static readonly long[] Value=A145801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145801.Bytes);
public long this[int i]=>Value[i];

public static A145801Inst Instance=new A145801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145802
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,9L,12L,15L,19L,25L,28L,33L,40L,49L,53L,60L,69L,81L,86L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145802Inst : IEnumerable<long>
{
public static readonly long[] Value=A145802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145802.Bytes);
public long this[int i]=>Value[i];

public static A145802Inst Instance=new A145802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145803
{
public static readonly long[] Value={ 0L,0L,0L,2L,3L,4L,6L,7L,9L,12L,14L,16L,20L,23L,25L,30L,34L,38L,42L,46L,53L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145803Inst : IEnumerable<long>
{
public static readonly long[] Value=A145803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145803.Bytes);
public long this[int i]=>Value[i];

public static A145803Inst Instance=new A145803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A145804
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,4L,6L,7L,9L,12L,13L,16L,20L,22L,25L,30L,32L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A145804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A145804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A145804Inst : IEnumerable<long>
{
public static readonly long[] Value=A145804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A145804.Bytes);
public long this[int i]=>Value[i];

public static A145804Inst Instance=new A145804Inst();

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