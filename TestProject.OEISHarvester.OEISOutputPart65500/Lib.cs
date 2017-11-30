using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A092293
{
public static readonly long[] Value={ 2L,3L,7L,9L,13L,17L,19L,23L,24L,27L,31L,35L,37L,41L,42L,47L,48L,52L,55L,59L,60L,65L,66L,70L,72L,76L,80L,81L,85L,89L,91L,95L,96L,101L,102L,106L,109L,113L,114L,119L,120L,124L,126L,130L,134L,137L,138L,142L,144L,148L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092293Inst : IEnumerable<long>
{
public static readonly long[] Value=A092293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092293.Bytes);
public long this[int i]=>Value[i];

public static A092293Inst Instance=new A092293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092294
{
public static readonly long[] Value={ 6L,8L,7L,2L,9L,8L,3L,3L,4L,6L,2L,0L,7L,4L,1L,6L,8L,8L,5L,1L,7L,9L,2L,6L,5L,3L,9L,9L,7L,8L,2L,3L,9L,9L,6L,1L,0L,8L,3L,2L,9L,2L,1L,7L,0L,5L,2L,9L,1L,5L,9L,0L,8L,2L,6L,5L,8L,7L,5L,7L,3L,7L,6L,6L,1L,1L,3L,4L,8L,3L,0L,9L,1L,9L,3L,6L,9L,7L,9L,0L,3L,3L,5L,1L,9L,2L,8L,7L,3L,7L,6L,8L,5L,8L,6L,7L,3L,5L,1L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092294Inst : IEnumerable<long>
{
public static readonly long[] Value=A092294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092294.Bytes);
public long this[int i]=>Value[i];

public static A092294Inst Instance=new A092294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092295
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,5L,7L,10L,15L,20L,27L,36L,50L,65L,85L,111L,146L,186L,239L,304L,388L,488L,614L,767L,961L,1191L,1475L,1819L,2243L,2746L,3361L,4096L,4988L,6047L,7322L,8836L,10655L,12801L,15360L,18384L,21978L,26199L,31196L,37062L,43979L,52072L,61579L,72682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092295Inst : IEnumerable<long>
{
public static readonly long[] Value=A092295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092295.Bytes);
public long this[int i]=>Value[i];

public static A092295Inst Instance=new A092295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092296
{
public static readonly long[] Value={ 1L,5L,6L,11L,12L,16L,18L,22L,26L,29L,30L,34L,36L,40L,44L,46L,50L,51L,54L,58L,62L,64L,68L,69L,74L,75L,79L,83L,84L,88L,90L,94L,98L,100L,104L,105L,108L,112L,116L,118L,122L,123L,128L,129L,133L,136L,140L,141L,146L,147L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092296Inst : IEnumerable<long>
{
public static readonly long[] Value=A092296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092296.Bytes);
public long this[int i]=>Value[i];

public static A092296Inst Instance=new A092296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092297
{
public static readonly long[] Value={ 0L,6L,6L,18L,30L,66L,126L,258L,510L,1026L,2046L,4098L,8190L,16386L,32766L,65538L,131070L,262146L,524286L,1048578L,2097150L,4194306L,8388606L,16777218L,33554430L,67108866L,134217726L,268435458L,536870910L,1073741826L,2147483646L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092297Inst : IEnumerable<long>
{
public static readonly long[] Value=A092297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092297.Bytes);
public long this[int i]=>Value[i];

public static A092297Inst Instance=new A092297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092298
{
public static readonly long[] Value={ 1L,2L,5L,11L,37L,71L,201L,352L,887L,3015L,4802L,14552L,30366L,45326L,90316L,234343L,582691L,819205L,1938560L,3449498L,4698053L,10457616L,17852459L,38120211L,99889551L,163116820L,211767528L,340543921L,437493270L,693911423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092298Inst : IEnumerable<long>
{
public static readonly long[] Value=A092298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092298.Bytes);
public long this[int i]=>Value[i];

public static A092298Inst Instance=new A092298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092299
{
public static readonly BigInteger[] Value={ 12L,2592L,50388480L,80225312993280L,BigInteger.Parse("10358730921842550374400"),BigInteger.Parse("108354149159204252828272715366400"),BigInteger.Parse("91807063616969429053277006948134413139968000"),BigInteger.Parse("6300752103463414524173850924959140409591369032708128768000"),BigInteger.Parse("35026261744325078751960598643637064012678383486922588643915999981076480000") };
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
public class A092299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092299Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092299.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092299Inst Instance=new A092299Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092300
{
public static readonly BigInteger[] Value={ 10L,30000L,58500000000L,BigInteger.Parse("71406562500000000000"),BigInteger.Parse("54478744277343750000000000000000"),BigInteger.Parse("25977486943588417053222656250000000000000000000"),BigInteger.Parse("7741894375438878098811060190200805664062500000000000000000000000"),BigInteger.Parse("1442040200190701731357565969692841463256627321243286132812500000000000000000000000000") };
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
public class A092300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092300Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092300.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092300Inst Instance=new A092300Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092301
{
public static readonly BigInteger[] Value={ 3L,648L,12597120L,20056328248320L,BigInteger.Parse("2589682730460637593600"),BigInteger.Parse("27088537289801063207068178841600"),BigInteger.Parse("22951765904242357263319251737033603284992000"),BigInteger.Parse("1575188025865853631043462731239785102397842258177032192000"),BigInteger.Parse("8756565436081269687990149660909266003169595871730647160978999995269120000") };
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
public class A092301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092301Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092301.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092301Inst Instance=new A092301Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092302
{
public static readonly long[] Value={ 0L,0L,0L,5L,4L,9L,5L,1L,1L,0L,55L,55L,1L,5L,1L,9L,5L,1L,1L,0L,0L,0L,0L,5L,4L,9L,5L,1L,1L,1L,1L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092302Inst : IEnumerable<long>
{
public static readonly long[] Value=A092302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092302.Bytes);
public long this[int i]=>Value[i];

public static A092302Inst Instance=new A092302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092303
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,-1L,2L,0L,0L,-1L,0L,2L,0L,0L,0L,0L,0L,-4L,5L,0L,0L,0L,0L,0L,1L,0L,-5L,0L,5L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,-14L,14L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,7L,0L,-20L,0L,14L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,8L,0L,0L,0L,-48L,42L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092303Inst : IEnumerable<long>
{
public static readonly long[] Value=A092303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092303.Bytes);
public long this[int i]=>Value[i];

public static A092303Inst Instance=new A092303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092304
{
public static readonly long[] Value={ 1L,4L,16L,82L,312L,1221L,4439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092304Inst : IEnumerable<long>
{
public static readonly long[] Value=A092304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092304.Bytes);
public long this[int i]=>Value[i];

public static A092304Inst Instance=new A092304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092305
{
public static readonly long[] Value={ 1L,3L,10L,21L,9L,55L,78L,30L,136L,171L,63L,253L,50L,27L,406L,465L,165L,210L,666L,234L,820L,903L,90L,1081L,147L,408L,1378L,550L,513L,1711L,1830L,189L,780L,2211L,759L,2485L,2628L,150L,1155L,3081L,81L,3403L,1360L,1218L,3916L,1638L,1395L,1710L,4656L,495L,5050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092305Inst : IEnumerable<long>
{
public static readonly long[] Value=A092305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092305.Bytes);
public long this[int i]=>Value[i];

public static A092305Inst Instance=new A092305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092306
{
public static readonly long[] Value={ 1L,0L,0L,1L,2L,5L,6L,11L,13L,17L,23L,29L,34L,47L,64L,74L,107L,136L,185L,233L,308L,392L,518L,637L,814L,1002L,1272L,1560L,1912L,2339L,2863L,3475L,4212L,5123L,6147L,7398L,8935L,10734L,12843L,15464L,18382L,22041L,26249L,31326L,37213L,44273L,52375L,62103L,73376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092306Inst : IEnumerable<long>
{
public static readonly long[] Value=A092306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092306.Bytes);
public long this[int i]=>Value[i];

public static A092306Inst Instance=new A092306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092307
{
public static readonly long[] Value={ 5L,7L,11L,23L,47L,59L,83L,107L,167L,179L,227L,239L,263L,347L,359L,383L,443L,467L,479L,503L,563L,587L,647L,659L,719L,827L,839L,863L,887L,983L,1019L,1187L,1223L,1259L,1283L,1307L,1319L,1367L,1439L,1487L,1499L,1523L,1619L,1787L,1823L,1847L,1907L,2027L,2039L,2063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092307Inst : IEnumerable<long>
{
public static readonly long[] Value=A092307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092307.Bytes);
public long this[int i]=>Value[i];

public static A092307Inst Instance=new A092307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092324
{
public static readonly BigInteger[] Value={ 0L,227L,22945L,273604248L,1506633655224L,980847385203985367L,BigInteger.Parse("294892816889532972106622"),BigInteger.Parse("10481800650337122455198767414397"),BigInteger.Parse("172058676801196585230804191607100491062") };
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
public class A092324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092324Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092324.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092324Inst Instance=new A092324Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092325
{
public static readonly long[] Value={ 3L,10L,29L,69L,148L,258L,430L,658L,985L,1401L,1876L,2490L,3181L,3994L,4992L,6152L,7436L,8846L,10495L,12298L,14315L,16634L,19146L,21929L,24928L,28081L,31520L,35347L,39514L,44131L,49146L,54134L,59500L,65176L,71349L,77684L,84540L,91757L,99341L,107404L,115863L,124728L,134223L,143944L,154316L,165265L,176936L,188764L,200743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092325Inst : IEnumerable<long>
{
public static readonly long[] Value=A092325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092325.Bytes);
public long this[int i]=>Value[i];

public static A092325Inst Instance=new A092325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092326
{
public static readonly BigInteger[] Value={ 1L,7L,647L,878769L,18203480001L,5850859031888599L,BigInteger.Parse("29453515169174062608487"),BigInteger.Parse("2335404534493957255219087217249"),BigInteger.Parse("2927451248337363113001580852250754885313") };
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
public class A092326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092326Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092326.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092326Inst Instance=new A092326Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092327
{
public static readonly long[] Value={ 0L,19L,61L,137L,260L,445L,709L,1071L,1552L,2175L,2965L,3949L,5156L,6617L,8365L,10435L,12864L,15691L,18957L,22705L,26980L,31829L,37301L,43447L,50320L,57975L,66469L,75861L,86212L,97585L,110045L,123659L,138496L,154627L,172125L,191065L,211524L,233581L,257317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092327Inst : IEnumerable<long>
{
public static readonly long[] Value=A092327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092327.Bytes);
public long this[int i]=>Value[i];

public static A092327Inst Instance=new A092327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092328
{
public static readonly long[] Value={ 0L,22L,44L,355L,710L,1065L,1420L,1775L,2130L,2485L,2840L,3195L,312689L,1146408L,5419351L,10838702L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092328Inst : IEnumerable<long>
{
public static readonly long[] Value=A092328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092328.Bytes);
public long this[int i]=>Value[i];

public static A092328Inst Instance=new A092328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092329
{
public static readonly long[] Value={ 1L,2L,4L,9L,31L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092329Inst : IEnumerable<long>
{
public static readonly long[] Value=A092329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092329.Bytes);
public long this[int i]=>Value[i];

public static A092329Inst Instance=new A092329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092330
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,29L,152L,136L,2016L,10959L,26840L,1056437L,2495955L,16311831L,102287808L,1627690024L,10021808981L,25377192720L,1085424779823L,2681584376185L,17876295136009L,113220181313816L,1933742696582736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092330Inst : IEnumerable<long>
{
public static readonly long[] Value=A092330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092330.Bytes);
public long this[int i]=>Value[i];

public static A092330Inst Instance=new A092330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092331
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,1L,2L,2L,3L,2L,3L,2L,4L,3L,3L,3L,4L,1L,3L,2L,2L,3L,3L,3L,3L,4L,2L,3L,3L,4L,2L,5L,2L,2L,4L,3L,2L,5L,2L,3L,3L,2L,4L,2L,3L,3L,2L,3L,3L,3L,3L,4L,2L,3L,3L,4L,4L,4L,3L,3L,4L,4L,4L,3L,3L,3L,3L,4L,4L,4L,4L,4L,5L,3L,4L,3L,2L,3L,3L,2L,3L,4L,4L,3L,3L,5L,3L,3L,3L,4L,5L,3L,3L,3L,4L,3L,3L,5L,3L,6L,3L,3L,4L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092331Inst : IEnumerable<long>
{
public static readonly long[] Value=A092331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092331.Bytes);
public long this[int i]=>Value[i];

public static A092331Inst Instance=new A092331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092332
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,2L,3L,1L,1L,2L,1L,1L,2L,2L,3L,2L,2L,2L,3L,3L,2L,2L,4L,2L,2L,3L,2L,1L,1L,2L,2L,3L,3L,2L,2L,3L,3L,2L,4L,2L,2L,2L,3L,2L,3L,3L,2L,3L,2L,4L,4L,3L,2L,2L,2L,3L,3L,2L,2L,2L,3L,3L,2L,2L,2L,3L,3L,3L,3L,4L,4L,2L,3L,2L,2L,2L,3L,3L,3L,3L,4L,2L,2L,3L,4L,3L,3L,2L,2L,4L,3L,5L,1L,1L,2L,1L,1L,2L,2L,3L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092332Inst : IEnumerable<long>
{
public static readonly long[] Value=A092332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092332.Bytes);
public long this[int i]=>Value[i];

public static A092332Inst Instance=new A092332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092333
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,2L,3L,3L,4L,3L,4L,4L,5L,4L,5L,4L,5L,5L,6L,5L,6L,6L,7L,5L,6L,6L,7L,7L,8L,7L,8L,6L,7L,7L,8L,8L,9L,8L,9L,8L,9L,9L,10L,9L,10L,8L,9L,9L,10L,10L,11L,9L,10L,10L,11L,11L,12L,10L,11L,11L,12L,12L,13L,11L,12L,12L,13L,13L,14L,10L,11L,11L,12L,12L,13L,11L,12L,12L,13L,13L,14L,13L,14L,13L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092333Inst : IEnumerable<long>
{
public static readonly long[] Value=A092333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092333.Bytes);
public long this[int i]=>Value[i];

public static A092333Inst Instance=new A092333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092334
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,2L,3L,1L,1L,2L,1L,1L,2L,2L,3L,2L,2L,2L,3L,3L,4L,1L,1L,2L,1L,1L,2L,2L,3L,1L,1L,2L,1L,1L,2L,2L,3L,2L,2L,2L,3L,3L,4L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,3L,4L,3L,3L,3L,3L,4L,4L,5L,1L,1L,2L,1L,1L,2L,2L,3L,1L,1L,2L,1L,1L,2L,2L,3L,2L,2L,2L,3L,3L,4L,1L,1L,2L,1L,1L,2L,2L,3L,1L,1L,2L,1L,1L,2L,2L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092334Inst : IEnumerable<long>
{
public static readonly long[] Value=A092334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092334.Bytes);
public long this[int i]=>Value[i];

public static A092334Inst Instance=new A092334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092335
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,2L,2L,3L,2L,1L,3L,2L,1L,2L,1L,2L,2L,3L,2L,2L,2L,3L,3L,2L,2L,2L,3L,2L,2L,3L,2L,2L,2L,3L,3L,2L,2L,2L,3L,2L,2L,3L,2L,2L,2L,3L,3L,3L,3L,4L,2L,1L,1L,2L,1L,1L,2L,2L,2L,3L,2L,1L,3L,2L,1L,2L,1L,2L,2L,3L,2L,2L,2L,3L,3L,2L,2L,2L,3L,2L,2L,3L,2L,2L,2L,3L,3L,2L,2L,2L,3L,2L,2L,3L,2L,2L,2L,3L,3L,3L,3L,4L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092335Inst : IEnumerable<long>
{
public static readonly long[] Value=A092335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092335.Bytes);
public long this[int i]=>Value[i];

public static A092335Inst Instance=new A092335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092336
{
public static readonly BigInteger[] Value={ 6L,34L,530L,8658L,33558994L,8623428050L,146062119378L,2305843154202071506L,BigInteger.Parse("2658455991569831746960535770155913682"),BigInteger.Parse("191561942608236109953249369654135385091533091704082898") };
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
public class A092336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092336Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092336.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092336Inst Instance=new A092336Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092337
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,4L,6L,6L,6L,4L,2L,1L,1L,1L,1L,3L,7L,21L,43L,94L,161L,249L,312L,352L,312L,249L,161L,94L,43L,21L,7L,3L,1L,1L,1L,1L,3L,10L,38L,137L,509L,1760L,5557L,15709L,39433L,87659L,172933L,303277L,473827L,660950L,824410L,920446L,920446L,824410L,660950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092337Inst : IEnumerable<long>
{
public static readonly long[] Value=A092337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092337.Bytes);
public long this[int i]=>Value[i];

public static A092337Inst Instance=new A092337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092338
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,5L,5L,5L,6L,6L,5L,7L,7L,5L,7L,8L,6L,7L,7L,7L,9L,7L,5L,9L,10L,6L,7L,9L,7L,9L,9L,7L,9L,7L,7L,12L,10L,5L,7L,11L,9L,9L,9L,7L,11L,9L,5L,11L,12L,8L,9L,9L,7L,9L,11L,11L,11L,7L,5L,13L,13L,5L,9L,12L,10L,11L,9L,7L,9L,11L,9L,13L,13L,5L,9L,11L,9L,11L,9L,11L,14L,8L,5L,13L,15L,7L,7L,11L,9L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092338Inst : IEnumerable<long>
{
public static readonly long[] Value=A092338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092338.Bytes);
public long this[int i]=>Value[i];

public static A092338Inst Instance=new A092338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092339
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,0L,1L,2L,2L,1L,0L,1L,2L,1L,2L,3L,3L,2L,1L,2L,1L,0L,1L,2L,3L,2L,1L,2L,3L,2L,3L,4L,4L,3L,2L,3L,2L,1L,2L,3L,2L,1L,0L,1L,2L,1L,2L,3L,4L,3L,2L,3L,2L,1L,2L,3L,4L,3L,2L,3L,4L,3L,4L,5L,5L,4L,3L,4L,3L,2L,3L,4L,3L,2L,1L,2L,3L,2L,3L,4L,3L,2L,1L,2L,1L,0L,1L,2L,3L,2L,1L,2L,3L,2L,3L,4L,5L,4L,3L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092339Inst : IEnumerable<long>
{
public static readonly long[] Value=A092339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092339.Bytes);
public long this[int i]=>Value[i];

public static A092339Inst Instance=new A092339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092388
{
public static readonly BigInteger[] Value={ 2L,3L,23L,601L,1800857L,15150670259532L,BigInteger.Parse("428274542923473692585258931"),BigInteger.Parse("684206983591194904989689062059991542510707643860720258"),BigInteger.Parse("792823608217999404644552059785470357855585023133283985498107007444338827113094578293029854179197929809783961") };
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
public class A092388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092388Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092388.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092388Inst Instance=new A092388Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092389
{
public static readonly BigInteger[] Value={ 2L,4L,53L,8161L,95179274L,201183145328633251L,BigInteger.Parse("185888177135331365526661328509496304"),BigInteger.Parse("999276311297022575258979594170618811616720633706868379409096128081691360") };
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
public class A092389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092389Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092389.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092389Inst Instance=new A092389Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092390
{
public static readonly long[] Value={ 5L,10L,18L,26L,40L,50L,60L,72L,84L,100L,110L,126L,142L,150L,160L,184L,198L,212L,230L,244L,254L,272L,282L,312L,326L,340L,354L,370L,380L,394L,420L,442L,454L,476L,498L,510L,530L,546L,564L,582L,600L,614L,634L,650L,660L,678L,702L,726L,748L,770L,790L,808L,818L,844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092390Inst : IEnumerable<long>
{
public static readonly long[] Value=A092390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092390.Bytes);
public long this[int i]=>Value[i];

public static A092390Inst Instance=new A092390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092391
{
public static readonly long[] Value={ 0L,2L,3L,5L,5L,7L,8L,10L,9L,11L,12L,14L,14L,16L,17L,19L,17L,19L,20L,22L,22L,24L,25L,27L,26L,28L,29L,31L,31L,33L,34L,36L,33L,35L,36L,38L,38L,40L,41L,43L,42L,44L,45L,47L,47L,49L,50L,52L,50L,52L,53L,55L,55L,57L,58L,60L,59L,61L,62L,64L,64L,66L,67L,69L,65L,67L,68L,70L,70L,72L,73L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092391Inst : IEnumerable<long>
{
public static readonly long[] Value=A092391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092391.Bytes);
public long this[int i]=>Value[i];

public static A092391Inst Instance=new A092391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092392
{
public static readonly long[] Value={ 1L,2L,1L,6L,3L,1L,20L,10L,4L,1L,70L,35L,15L,5L,1L,252L,126L,56L,21L,6L,1L,924L,462L,210L,84L,28L,7L,1L,3432L,1716L,792L,330L,120L,36L,8L,1L,12870L,6435L,3003L,1287L,495L,165L,45L,9L,1L,48620L,24310L,11440L,5005L,2002L,715L,220L,55L,10L,1L,184756L,92378L,43758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092392Inst : IEnumerable<long>
{
public static readonly long[] Value=A092392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092392.Bytes);
public long this[int i]=>Value[i];

public static A092392Inst Instance=new A092392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092393
{
public static readonly long[] Value={ 1L,2L,6L,3L,12L,15L,4L,20L,36L,28L,5L,30L,70L,80L,45L,6L,42L,120L,180L,150L,66L,7L,56L,189L,350L,385L,252L,91L,8L,72L,280L,616L,840L,728L,392L,120L,9L,90L,396L,1008L,1638L,1764L,1260L,576L,153L,10L,110L,540L,1560L,2940L,3780L,3360L,2040L,810L,190L,11L,132L,715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092393Inst : IEnumerable<long>
{
public static readonly long[] Value=A092393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092393.Bytes);
public long this[int i]=>Value[i];

public static A092393Inst Instance=new A092393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092394
{
public static readonly long[] Value={ 1L,1L,2L,5L,5L,7L,28L,42L,42L,165L,132L,429L,1001L,1001L,1430L,6188L,4862L,25194L,41990L,58786L,58786L,245157L,653752L,742900L,1931540L,4345965L,2674440L,17298645L,9694845L,29464725L,94287120L,129644790L,927983760L,811985790L,477638700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092394Inst : IEnumerable<long>
{
public static readonly long[] Value=A092394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092394.Bytes);
public long this[int i]=>Value[i];

public static A092394Inst Instance=new A092394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092395
{
public static readonly long[] Value={ 2L,5L,13L,37L,73L,89L,113L,149L,157L,193L,233L,269L,277L,313L,353L,389L,397L,457L,557L,613L,673L,677L,733L,757L,877L,953L,977L,997L,1069L,1093L,1153L,1213L,1237L,1453L,1597L,1657L,1753L,1873L,1877L,1933L,1949L,1993L,2017L,2137L,2221L,2237L,2309L,2333L,2417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092395Inst : IEnumerable<long>
{
public static readonly long[] Value=A092395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092395.Bytes);
public long this[int i]=>Value[i];

public static A092395Inst Instance=new A092395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092396
{
public static readonly BigInteger[] Value={ 1L,-1L,-4L,9L,64L,-225L,-2304L,11025L,147456L,-893025L,-14745600L,108056025L,2123366400L,-18261468225L,-416179814400L,4108830350625L,106542032486400L,-1187451971330625L,-34519618525593600L,428670161650355625L,13807847410237440000UL,BigInteger.Parse("-189043541287806830625"),BigInteger.Parse("-6682998146554920960000") };
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
public class A092396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092396Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092396.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092396Inst Instance=new A092396Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092397
{
public static readonly long[] Value={ 1L,1L,-2L,-9L,-8L,40L,324L,280L,-2240L,-26244L,-22400L,246400L,3779136L,3203200L,-44844800L,-850305600L,-717516800L,12197785600L,275499014400L,231757926400L,-4635158528000L,-121495065350400L,-101973487616000L,2345390215168000L,69981157641830400L,58634755379200000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092397Inst : IEnumerable<long>
{
public static readonly long[] Value=A092397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092397.Bytes);
public long this[int i]=>Value[i];

public static A092397Inst Instance=new A092397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092398
{
public static readonly long[] Value={ 1L,1L,-4L,-3L,-16L,-15L,144L,105L,1024L,945L,-14400L,-10395L,-147456L,-135135L,2822400L,2027025L,37748736L,34459425L,-914457600L,-654729075L,-15099494400L,-13749310575L,442597478400L,316234143225L,8697308774400L,7905853580625L,-299195895398400L,-213458046676875L,-6818690079129600L,-6190283353629375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092398Inst : IEnumerable<long>
{
public static readonly long[] Value=A092398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092398.Bytes);
public long this[int i]=>Value[i];

public static A092398Inst Instance=new A092398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092399
{
public static readonly long[] Value={ 1L,1L,2L,-6L,-4L,-25L,-24L,-42L,336L,216L,2500L,2376L,4032L,-52416L,-33264L,-562500L,-532224L,-891072L,16039296L,10112256L,225000000L,212357376L,352864512L,-8115883776L,-5096577024L,-140625000000L,-132511002624L,-219128861952L,6135608134656L,3842819076096L,126562500000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092399Inst : IEnumerable<long>
{
public static readonly long[] Value=A092399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092399.Bytes);
public long this[int i]=>Value[i];

public static A092399Inst Instance=new A092399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092400
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092400Inst : IEnumerable<long>
{
public static readonly long[] Value=A092400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092400.Bytes);
public long this[int i]=>Value[i];

public static A092400Inst Instance=new A092400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092401
{
public static readonly long[] Value={ 1L,3L,2L,6L,4L,12L,5L,15L,7L,21L,8L,24L,9L,27L,10L,30L,11L,33L,13L,39L,14L,42L,16L,48L,17L,51L,18L,54L,19L,57L,20L,60L,22L,66L,23L,69L,25L,75L,26L,78L,28L,84L,29L,87L,31L,93L,32L,96L,34L,102L,35L,105L,36L,108L,37L,111L,38L,114L,40L,120L,41L,123L,43L,129L,44L,132L,45L,135L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092401Inst : IEnumerable<long>
{
public static readonly long[] Value=A092401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092401.Bytes);
public long this[int i]=>Value[i];

public static A092401Inst Instance=new A092401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092402
{
public static readonly long[] Value={ 11L,13L,19L,31L,37L,61L,67L,79L,97L,109L,139L,157L,181L,199L,241L,271L,277L,367L,397L,409L,439L,457L,487L,499L,571L,577L,601L,607L,661L,691L,709L,727L,751L,769L,829L,919L,937L,991L,1021L,1039L,1069L,1117L,1171L,1201L,1231L,1237L,1291L,1297L,1327L,1381L,1447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092402Inst : IEnumerable<long>
{
public static readonly long[] Value=A092402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092402.Bytes);
public long this[int i]=>Value[i];

public static A092402Inst Instance=new A092402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092403
{
public static readonly long[] Value={ 4L,7L,11L,13L,18L,20L,23L,28L,31L,30L,40L,42L,38L,48L,55L,49L,57L,59L,62L,74L,68L,60L,84L,91L,73L,82L,96L,86L,102L,104L,95L,111L,102L,102L,139L,129L,98L,116L,146L,132L,138L,140L,128L,162L,150L,120L,172L,181L,150L,165L,170L,152L,174L,192L,192L,200L,170L,150L,228L,230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092403Inst : IEnumerable<long>
{
public static readonly long[] Value=A092403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092403.Bytes);
public long this[int i]=>Value[i];

public static A092403Inst Instance=new A092403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092404
{
public static readonly long[] Value={ 2L,3L,4L,6L,6L,8L,10L,10L,10L,14L,14L,16L,18L,14L,16L,24L,22L,24L,26L,20L,22L,32L,30L,28L,32L,30L,30L,40L,36L,38L,46L,36L,36L,40L,36L,48L,54L,42L,40L,56L,52L,54L,62L,44L,46L,68L,62L,58L,62L,52L,56L,76L,70L,58L,64L,60L,64L,86L,74L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092404Inst : IEnumerable<long>
{
public static readonly long[] Value=A092404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092404.Bytes);
public long this[int i]=>Value[i];

public static A092404Inst Instance=new A092404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092405
{
public static readonly long[] Value={ 3L,4L,5L,5L,6L,6L,6L,7L,7L,6L,8L,8L,6L,8L,9L,7L,8L,8L,8L,10L,8L,6L,10L,11L,7L,8L,10L,8L,10L,10L,8L,10L,8L,8L,13L,11L,6L,8L,12L,10L,10L,10L,8L,12L,10L,6L,12L,13L,9L,10L,10L,8L,10L,12L,12L,12L,8L,6L,14L,14L,6L,10L,13L,11L,12L,10L,8L,10L,12L,10L,14L,14L,6L,10L,12L,10L,12L,10L,12L,15L,9L,6L,14L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092405Inst : IEnumerable<long>
{
public static readonly long[] Value=A092405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092405.Bytes);
public long this[int i]=>Value[i];

public static A092405Inst Instance=new A092405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092406
{
public static readonly long[] Value={ 1L,3L,4L,7L,13L,25L,33L,48L,61L,79L,91L,119L,133L,157L,181L,212L,230L,269L,289L,331L,363L,399L,423L,483L,514L,556L,596L,652L,682L,754L,786L,849L,897L,951L,999L,1090L,1128L,1188L,1244L,1334L,1376L,1472L,1516L,1600L,1678L,1750L,1798L,1922L,1979L,2072L,2144L,2242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092406Inst : IEnumerable<long>
{
public static readonly long[] Value=A092406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092406.Bytes);
public long this[int i]=>Value[i];

public static A092406Inst Instance=new A092406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092407
{
public static readonly long[] Value={ 1L,5L,10L,20L,50L,100L,200L,500L,1000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092407Inst : IEnumerable<long>
{
public static readonly long[] Value=A092407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092407.Bytes);
public long this[int i]=>Value[i];

public static A092407Inst Instance=new A092407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092408
{
public static readonly long[] Value={ 1L,2L,34L,386L,578L,6562L,9826L,74498L,111554L,167042L,1100546L,1192354L,1266466L,1896418L,2839714L,14378114L,18709282L,20270018L,21529922L,32239106L,35759426L,48275138L,191812802L,212405378L,230124322L,244427938L,318057794L,344590306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092408Inst : IEnumerable<long>
{
public static readonly long[] Value=A092408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092408.Bytes);
public long this[int i]=>Value[i];

public static A092408Inst Instance=new A092408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092409
{
public static readonly long[] Value={ 7L,13L,19L,23L,25L,31L,33L,37L,43L,47L,49L,53L,55L,61L,63L,67L,73L,75L,79L,83L,85L,91L,93L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092409Inst : IEnumerable<long>
{
public static readonly long[] Value=A092409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092409.Bytes);
public long this[int i]=>Value[i];

public static A092409Inst Instance=new A092409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092410
{
public static readonly long[] Value={ 0L,-2L,-1L,-1L,0L,0L,-1L,0L,1L,0L,-1L,-1L,0L,2L,1L,-1L,-1L,-1L,-1L,1L,2L,0L,-1L,0L,1L,1L,0L,-1L,-2L,-2L,-1L,1L,2L,2L,1L,-1L,0L,2L,1L,-1L,-2L,-2L,-1L,0L,1L,0L,-1L,0L,0L,1L,1L,-1L,-1L,1L,1L,1L,2L,0L,-1L,-1L,0L,1L,0L,1L,0L,-2L,-1L,1L,0L,-2L,-1L,-1L,0L,1L,0L,1L,0L,-2L,-1L,0L,1L,0L,-1L,1L,2L,2L,1L,-1L,-1L,1L,1L,1L,2L,2L,1L,-1L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092410Inst : IEnumerable<long>
{
public static readonly long[] Value=A092410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092410.Bytes);
public long this[int i]=>Value[i];

public static A092410Inst Instance=new A092410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092411
{
public static readonly long[] Value={ 6L,15L,31L,47L,76L,100L,135L,176L,221L,252L,332L,380L,420L,510L,601L,631L,745L,817L,908L,1046L,1110L,1140L,1380L,1501L,1501L,1670L,1870L,1892L,2142L,2262L,2327L,2585L,2670L,2750L,3211L,3281L,3180L,3510L,3910L,3892L,4182L,4350L,4412L,4928L,5016L,4860L,5620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092411Inst : IEnumerable<long>
{
public static readonly long[] Value=A092411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092411.Bytes);
public long this[int i]=>Value[i];

public static A092411Inst Instance=new A092411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092412
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,2L,1L,0L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,1L,3L,1L,2L,1L,0L,1L,2L,1L,3L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,1L,0L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,1L,3L,1L,2L,1L,0L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L,0L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,1L,3L,1L,2L,1L,0L,1L,2L,1L,3L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092412Inst : IEnumerable<long>
{
public static readonly long[] Value=A092412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092412.Bytes);
public long this[int i]=>Value[i];

public static A092412Inst Instance=new A092412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092413
{
public static readonly long[] Value={ 1L,-1L,2L,-6L,20L,-70L,256L,-970L,3772L,-14960L,60280L,-246090L,1015700L,-4231216L,17767456L,-75126078L,319588340L,-1366846548L,5873832384L,-25350152100L,109828012448L,-477486940848L,2082520454864L,-9109146150050L,39950535931956L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092413Inst : IEnumerable<long>
{
public static readonly long[] Value=A092413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092413.Bytes);
public long this[int i]=>Value[i];

public static A092413Inst Instance=new A092413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092414
{
public static readonly BigInteger[] Value={ 0L,0L,8L,2016L,301856L,35402880L,3596797568L,332433378816L,28736957620736L,2363831961200640L,187161691763222528L,14378930653933756416UL,BigInteger.Parse("1078142718948065878016"),BigInteger.Parse("79242945178480535961600") };
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
public class A092414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092414Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092414.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092414Inst Instance=new A092414Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092415
{
public static readonly BigInteger[] Value={ 1L,2L,-17L,-2016L,6941952L,1183818240000L,BigInteger.Parse("-15226366699929600000"),BigInteger.Parse("-20905103969704791244800000000"),BigInteger.Parse("4118415008134762062658292598964224000000"),BigInteger.Parse("150638206504104123857462570135784635511078912000000000") };
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
public class A092415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092415Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092415.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092415Inst Instance=new A092415Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092416
{
public static readonly BigInteger[] Value={ 1L,1L,3L,78L,19656L,61405344L,2863085569344L,2357871215948696448L,BigInteger.Parse("39557911075122642360238080"),BigInteger.Parse("15325544184478930809864207383592960"),BigInteger.Parse("153255393906487099048546500580688904121221120") };
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
public class A092416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092416Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092416.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092416Inst Instance=new A092416Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092417
{
public static readonly long[] Value={ 1L,3L,-4L,12L,144L,576L,-7104L,45248L,450432L,2240512L,5292544L,-88076288L,-62210048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092417Inst : IEnumerable<long>
{
public static readonly long[] Value=A092417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092417.Bytes);
public long this[int i]=>Value[i];

public static A092417Inst Instance=new A092417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092418
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,9L,10L,11L,13L,14L,15L,17L,18L,19L,22L,23L,25L,26L,27L,29L,30L,31L,33L,34L,35L,37L,38L,39L,41L,43L,45L,46L,47L,49L,50L,51L,53L,54L,55L,57L,58L,59L,61L,62L,65L,66L,67L,69L,70L,71L,73L,74L,75L,77L,78L,79L,81L,82L,83L,86L,87L,89L,91L,93L,94L,95L,97L,98L,99L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092418Inst : IEnumerable<long>
{
public static readonly long[] Value=A092418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092418.Bytes);
public long this[int i]=>Value[i];

public static A092418Inst Instance=new A092418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092419
{
public static readonly long[] Value={ 3L,2L,2L,7L,5L,3L,7L,2L,5L,2L,3L,13L,3L,5L,2L,3L,2L,5L,3L,7L,3L,2L,5L,2L,11L,7L,3L,5L,7L,2L,2L,3L,11L,7L,3L,5L,2L,3L,2L,11L,3L,5L,3L,2L,5L,2L,7L,7L,3L,5L,5L,2L,13L,2L,3L,5L,3L,7L,2L,3L,2L,13L,3L,5L,5L,3L,2L,7L,2L,5L,11L,3L,5L,2L,11L,2L,3L,5L,5L,3L,7L,2L,3L,2L,7L,3L,7L,5L,3L,2L,2L,5L,5L,3L,11L,11L,2L,5L,2L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092419Inst : IEnumerable<long>
{
public static readonly long[] Value=A092419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092419.Bytes);
public long this[int i]=>Value[i];

public static A092419Inst Instance=new A092419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092452
{
public static readonly long[] Value={ 0L,3L,6L,9L,12L,13L,15L,18L,21L,23L,24L,27L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,42L,43L,45L,48L,51L,53L,54L,57L,60L,63L,66L,69L,72L,73L,75L,78L,81L,83L,84L,87L,90L,93L,96L,99L,102L,103L,105L,108L,111L,113L,114L,117L,120L,123L,126L,129L,130L,131L,132L,133L,134L,135L,136L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092452Inst : IEnumerable<long>
{
public static readonly long[] Value=A092452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092452.Bytes);
public long this[int i]=>Value[i];

public static A092452Inst Instance=new A092452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092453
{
public static readonly long[] Value={ 0L,4L,8L,12L,14L,16L,20L,24L,28L,32L,34L,36L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,52L,54L,56L,60L,64L,68L,72L,74L,76L,80L,84L,88L,92L,94L,96L,100L,104L,108L,112L,114L,116L,120L,124L,128L,132L,134L,136L,140L,141L,142L,143L,144L,145L,146L,147L,148L,149L,152L,154L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092453Inst : IEnumerable<long>
{
public static readonly long[] Value=A092453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092453.Bytes);
public long this[int i]=>Value[i];

public static A092453Inst Instance=new A092453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092454
{
public static readonly long[] Value={ 0L,5L,10L,15L,20L,25L,30L,35L,40L,45L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,65L,70L,75L,80L,85L,90L,95L,100L,105L,110L,115L,120L,125L,130L,135L,140L,145L,150L,151L,152L,153L,154L,155L,156L,157L,158L,159L,160L,165L,170L,175L,180L,185L,190L,195L,200L,205L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092454Inst : IEnumerable<long>
{
public static readonly long[] Value=A092454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092454.Bytes);
public long this[int i]=>Value[i];

public static A092454Inst Instance=new A092454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092455
{
public static readonly long[] Value={ 0L,6L,12L,16L,18L,24L,26L,30L,36L,42L,46L,48L,54L,56L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,72L,76L,78L,84L,86L,90L,96L,102L,106L,108L,114L,116L,120L,126L,132L,136L,138L,144L,146L,150L,156L,160L,161L,162L,163L,164L,165L,166L,167L,168L,169L,174L,176L,180L,186L,192L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092455Inst : IEnumerable<long>
{
public static readonly long[] Value=A092455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092455.Bytes);
public long this[int i]=>Value[i];

public static A092455Inst Instance=new A092455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092456
{
public static readonly long[] Value={ 0L,8L,16L,18L,24L,28L,32L,38L,40L,48L,56L,58L,64L,68L,72L,78L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,96L,98L,104L,108L,112L,118L,120L,128L,136L,138L,144L,148L,152L,158L,160L,168L,176L,178L,180L,181L,182L,183L,184L,185L,186L,187L,188L,189L,192L,198L,200L,208L,216L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092456Inst : IEnumerable<long>
{
public static readonly long[] Value=A092456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092456.Bytes);
public long this[int i]=>Value[i];

public static A092456Inst Instance=new A092456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092457
{
public static readonly long[] Value={ 0L,9L,18L,19L,27L,29L,36L,39L,45L,49L,54L,59L,63L,69L,72L,79L,81L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L,108L,109L,117L,119L,126L,129L,135L,139L,144L,149L,153L,159L,162L,169L,171L,179L,180L,189L,190L,191L,192L,193L,194L,195L,196L,197L,198L,199L,207L,209L,216L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092457Inst : IEnumerable<long>
{
public static readonly long[] Value=A092457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092457.Bytes);
public long this[int i]=>Value[i];

public static A092457Inst Instance=new A092457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092458
{
public static readonly long[] Value={ 1L,2L,4L,21L,55L,151L,447L,1389L,4502L,15046L,51505L,179463L,634086L,2265014L,8163125L,29637903L,108282989L,397761507L,1468063369L,5441174511L,20242989728L,75566702558L,282959337159L,1062523000005L,4000108867555L,15095081362907L,57088782570433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092458Inst : IEnumerable<long>
{
public static readonly long[] Value=A092458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092458.Bytes);
public long this[int i]=>Value[i];

public static A092458Inst Instance=new A092458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092459
{
public static readonly long[] Value={ 0L,3L,4L,6L,7L,8L,9L,10L,11L,12L,13L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092459Inst : IEnumerable<long>
{
public static readonly long[] Value=A092459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092459.Bytes);
public long this[int i]=>Value[i];

public static A092459Inst Instance=new A092459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092460
{
public static readonly long[] Value={ 0L,3L,4L,6L,7L,8L,9L,10L,11L,12L,13L,14L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092460Inst : IEnumerable<long>
{
public static readonly long[] Value=A092460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092460.Bytes);
public long this[int i]=>Value[i];

public static A092460Inst Instance=new A092460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092461
{
public static readonly long[] Value={ 6L,12L,10L,30L,7L,28L,6L,30L,11L,66L,13L,91L,6L,12L,34L,102L,19L,38L,12L,22L,23L,46L,15L,65L,6L,12L,29L,435L,62L,124L,6L,34L,10L,36L,37L,703L,6L,24L,41L,82L,86L,43L,20L,46L,47L,94L,21L,70L,6L,12L,53L,159L,10L,35L,21L,58L,59L,177L,61L,1891L,14L,28L,10L,30L,67L,134L,12L,14L,142L,142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092461Inst : IEnumerable<long>
{
public static readonly long[] Value=A092461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092461.Bytes);
public long this[int i]=>Value[i];

public static A092461Inst Instance=new A092461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092462
{
public static readonly long[] Value={ 0L,1L,1L,-2L,5L,-4L,-2L,8L,-3L,-2L,6L,-10L,2L,14L,-20L,8L,29L,-50L,34L,20L,-90L,110L,-32L,-114L,210L,-154L,-64L,322L,-380L,88L,408L,-712L,477L,350L,-1206L,1228L,-34L,-1738L,2604L,-1276L,-1978L,4798L,-4160L,-902L,7452L,-9712L,3428L,9166L,-18574L,14022L,6456L,-29990L,34780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092462Inst : IEnumerable<long>
{
public static readonly long[] Value=A092462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092462.Bytes);
public long this[int i]=>Value[i];

public static A092462Inst Instance=new A092462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092463
{
public static readonly long[] Value={ 1L,3L,7L,13L,25L,41L,64L,97L,128L,173L,233L,283L,359L,439L,523L,619L,729L,841L,971L,1093L,1249L,1423L,1567L,1733L,1931L,2113L,2309L,2531L,2731L,2969L,3251L,3499L,3733L,4019L,4289L,4621L,4937L,5237L,5569L,5881L,6269L,6637L,6977L,7417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092463Inst : IEnumerable<long>
{
public static readonly long[] Value=A092463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092463.Bytes);
public long this[int i]=>Value[i];

public static A092463Inst Instance=new A092463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092464
{
public static readonly long[] Value={ 4L,9L,17L,22L,30L,35L,43L,48L,56L,61L,69L,74L,82L,87L,95L,100L,108L,113L,121L,126L,134L,139L,147L,152L,160L,165L,173L,178L,186L,191L,199L,204L,212L,217L,225L,230L,238L,243L,251L,256L,264L,269L,277L,282L,290L,295L,303L,308L,316L,321L,329L,334L,342L,347L,355L,360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092464Inst : IEnumerable<long>
{
public static readonly long[] Value=A092464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092464.Bytes);
public long this[int i]=>Value[i];

public static A092464Inst Instance=new A092464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092465
{
public static readonly long[] Value={ 1L,2L,7L,28L,104L,415L,1631L,6438L,25557L,101320L,402620L,1600973L,6369850L,25362023L,101021833L,402558824L,1604694342L,6398518221L,25519847999L,101805661146L,406209454697L,1621073551580L,6470257616586L,25828532256195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092465Inst : IEnumerable<long>
{
public static readonly long[] Value=A092465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092465.Bytes);
public long this[int i]=>Value[i];

public static A092465Inst Instance=new A092465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092466
{
public static readonly long[] Value={ 1L,1L,3L,16L,41L,166L,777L,2472L,9781L,44506L,150953L,597334L,2661881L,9337511L,37044451L,162468924L,582650861L,2315651686L,10035973071L,36558456606L,145470310301L,624753156831L,2302445024223L,9169599427426L,39098606269531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092466Inst : IEnumerable<long>
{
public static readonly long[] Value=A092466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092466.Bytes);
public long this[int i]=>Value[i];

public static A092466Inst Instance=new A092466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092467
{
public static readonly long[] Value={ 1L,3L,13L,63L,309L,1511L,7373L,35951L,175269L,854455L,4165565L,20307647L,99002389L,482649479L,2352978861L,11471077391L,55922991237L,272631840855L,1329115610269L,6479611111519L,31588945184245L,154000207833639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092467Inst : IEnumerable<long>
{
public static readonly long[] Value=A092467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092467.Bytes);
public long this[int i]=>Value[i];

public static A092467Inst Instance=new A092467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092500
{
public static readonly BigInteger[] Value={ 0L,10L,110L,12110L,146652110L,21506841367452110L,BigInteger.Parse("462544225604749344790073143452110"),BigInteger.Parse("213947160640297259376086109686762856183078407835978386567863452110") };
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
public class A092500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092500Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092500.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092500Inst Instance=new A092500Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092501
{
public static readonly BigInteger[] Value={ 0L,1L,10L,110L,12110L,146652110L,21506841367452110L,BigInteger.Parse("462544225604749344790073143452110"),BigInteger.Parse("213947160640297259376086109686762856183078407835978386567863452110") };
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
public class A092501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092501Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092501.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092501Inst Instance=new A092501Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092502
{
public static readonly long[] Value={ 1L,1L,3L,2L,10L,1L,21L,4L,9L,2L,55L,2L,78L,3L,4L,8L,136L,3L,171L,4L,6L,5L,253L,4L,50L,6L,27L,6L,406L,4L,465L,16L,10L,8L,12L,6L,666L,9L,12L,8L,820L,6L,903L,10L,12L,11L,1081L,8L,147L,10L,16L,12L,1378L,9L,20L,12L,18L,14L,1711L,8L,1830L,15L,18L,32L,24L,10L,2211L,16L,22L,12L,2485L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092502Inst : IEnumerable<long>
{
public static readonly long[] Value=A092502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092502.Bytes);
public long this[int i]=>Value[i];

public static A092502Inst Instance=new A092502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092503
{
public static readonly long[] Value={ 1L,1L,2L,3L,16L,25L,216L,343L,4096L,6561L,100000L,161051L,2985984L,4826809L,105413504L,170859375L,4294967296L,6975757441L,198359290368L,322687697779L,10240000000000L,16679880978201L,584318301411328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092503Inst : IEnumerable<long>
{
public static readonly long[] Value=A092503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092503.Bytes);
public long this[int i]=>Value[i];

public static A092503Inst Instance=new A092503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092504
{
public static readonly long[] Value={ 4L,10L,28L,60L,108L,164L,244L,330L,442L,570L,692L,864L,1050L,1236L,1474L,1672L,1938L,2204L,2504L,2812L,3156L,3540L,3886L,4300L,4734L,5152L,5622L,6114L,6590L,7110L,7700L,8292L,8874L,9480L,10080L,10778L,11478L,12212L,12910L,13672L,14506L,15282L,16068L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092504Inst : IEnumerable<long>
{
public static readonly long[] Value=A092504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092504.Bytes);
public long this[int i]=>Value[i];

public static A092504Inst Instance=new A092504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092505
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,4L,2L,1L,2L,2L,2L,2L,2L,4L,2L,2L,2L,4L,2L,4L,2L,4L,2L,1L,2L,2L,2L,2L,2L,4L,2L,2L,2L,4L,2L,4L,2L,4L,2L,2L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,8L,2L,4L,2L,1L,2L,2L,2L,2L,2L,4L,2L,2L,2L,4L,2L,4L,2L,4L,2L,2L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,8L,2L,4L,2L,2L,2L,4L,2L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092505Inst : IEnumerable<long>
{
public static readonly long[] Value=A092505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092505.Bytes);
public long this[int i]=>Value[i];

public static A092505Inst Instance=new A092505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092506
{
public static readonly long[] Value={ 2L,3L,5L,17L,257L,65537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092506Inst : IEnumerable<long>
{
public static readonly long[] Value=A092506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092506.Bytes);
public long this[int i]=>Value[i];

public static A092506Inst Instance=new A092506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092507
{
public static readonly long[] Value={ 2L,4L,8L,18L,30L,68L,128L,258L,508L,1030L,2052L,4092L,8192L,16400L,32792L,65520L,131058L,262172L,524286L,1048596L,2097156L,4194312L,8388620L,16777210L,33554472L,67108860L,134217738L,268435446L,536870858L,1073741832L,2147483616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092507Inst : IEnumerable<long>
{
public static readonly long[] Value=A092507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092507.Bytes);
public long this[int i]=>Value[i];

public static A092507Inst Instance=new A092507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092508
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,2L,4L,4L,4L,4L,7L,7L,7L,7L,11L,11L,12L,12L,17L,17L,18L,18L,25L,25L,27L,27L,35L,35L,38L,38L,48L,48L,52L,52L,64L,64L,69L,69L,83L,83L,90L,90L,106L,106L,114L,114L,133L,133L,143L,143L,164L,164L,176L,176L,200L,200L,214L,214L,241L,241L,257L,257L,287L,287L,306L,306L,339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092508Inst : IEnumerable<long>
{
public static readonly long[] Value=A092508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092508.Bytes);
public long this[int i]=>Value[i];

public static A092508Inst Instance=new A092508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092509
{
public static readonly long[] Value={ 0L,2L,3L,2L,5L,0L,7L,4L,6L,0L,11L,0L,13L,0L,0L,8L,17L,0L,19L,0L,0L,0L,23L,0L,20L,0L,18L,0L,29L,0L,31L,16L,0L,0L,0L,0L,37L,0L,0L,0L,41L,0L,43L,0L,0L,0L,47L,0L,42L,0L,0L,0L,53L,0L,0L,0L,0L,0L,59L,0L,61L,0L,0L,32L,0L,0L,67L,0L,0L,0L,71L,0L,73L,0L,0L,0L,0L,0L,79L,0L,54L,0L,83L,0L,0L,0L,0L,0L,89L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092509Inst : IEnumerable<long>
{
public static readonly long[] Value=A092509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092509.Bytes);
public long this[int i]=>Value[i];

public static A092509Inst Instance=new A092509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092510
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,3L,0L,1L,1L,1L,2L,0L,0L,0L,2L,1L,0L,0L,2L,1L,1L,1L,0L,3L,0L,1L,3L,0L,3L,0L,0L,1L,4L,0L,2L,0L,0L,1L,4L,1L,0L,3L,4L,0L,1L,1L,0L,0L,3L,1L,5L,1L,0L,7L,0L,0L,1L,1L,5L,6L,0L,1L,5L,0L,0L,0L,2L,1L,6L,0L,0L,0L,0L,0L,7L,1L,5L,3L,6L,1L,1L,1L,2L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092510Inst : IEnumerable<long>
{
public static readonly long[] Value=A092510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092510.Bytes);
public long this[int i]=>Value[i];

public static A092510Inst Instance=new A092510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092511
{
public static readonly long[] Value={ 1L,4L,8L,4L,1L,3L,1L,5L,9L,1L,0L,2L,5L,7L,6L,6L,0L,3L,4L,2L,1L,1L,1L,5L,5L,8L,0L,0L,4L,0L,5L,5L,2L,2L,7L,9L,6L,2L,3L,4L,8L,7L,6L,6L,7L,5L,9L,3L,8L,7L,8L,9L,8L,9L,0L,4L,6L,7L,5L,2L,8L,4L,5L,1L,1L,0L,9L,1L,2L,0L,6L,4L,8L,2L,0L,9L,5L,8L,5L,7L,6L,0L,7L,9L,6L,8L,8L,4L,0L,9L,4L,5L,9L,8L,9L,9L,0L,2L,1L,1L,4L,1L,2L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092511Inst : IEnumerable<long>
{
public static readonly long[] Value=A092511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092511.Bytes);
public long this[int i]=>Value[i];

public static A092511Inst Instance=new A092511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092512
{
public static readonly long[] Value={ 4L,0L,3L,4L,2L,8L,7L,9L,3L,4L,9L,2L,7L,3L,5L,1L,2L,2L,6L,0L,8L,3L,8L,7L,1L,8L,0L,5L,4L,3L,3L,8L,8L,2L,7L,9L,6L,0L,5L,8L,9L,9L,8L,9L,7L,3L,5L,7L,1L,2L,9L,2L,0L,2L,6L,1L,3L,9L,6L,7L,1L,8L,8L,3L,2L,5L,1L,5L,1L,1L,8L,0L,6L,3L,3L,9L,9L,3L,4L,9L,8L,3L,0L,5L,1L,7L,8L,8L,8L,6L,6L,5L,1L,2L,1L,2L,6L,6L,4L,7L,6L,8L,3L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092512Inst : IEnumerable<long>
{
public static readonly long[] Value=A092512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092512.Bytes);
public long this[int i]=>Value[i];

public static A092512Inst Instance=new A092512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092513
{
public static readonly long[] Value={ 1L,0L,9L,6L,6L,3L,3L,1L,5L,8L,4L,2L,8L,4L,5L,8L,5L,9L,9L,2L,6L,3L,7L,2L,0L,2L,3L,8L,2L,8L,8L,1L,2L,1L,4L,3L,2L,4L,4L,2L,2L,1L,9L,1L,3L,4L,8L,3L,3L,6L,1L,3L,1L,4L,3L,7L,8L,2L,7L,3L,9L,2L,4L,0L,7L,7L,6L,1L,2L,1L,7L,6L,9L,3L,3L,1L,2L,3L,3L,1L,2L,9L,0L,2L,2L,4L,7L,8L,5L,6L,8L,7L,8L,7L,2L,4L,9L,8L,4L,3L,8L,8L,4L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092513Inst : IEnumerable<long>
{
public static readonly long[] Value=A092513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092513.Bytes);
public long this[int i]=>Value[i];

public static A092513Inst Instance=new A092513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092514
{
public static readonly long[] Value={ 1L,2L,2L,1L,4L,0L,2L,7L,5L,8L,1L,6L,0L,1L,6L,9L,8L,3L,3L,9L,2L,1L,0L,7L,1L,9L,9L,4L,6L,3L,9L,6L,7L,4L,1L,7L,0L,3L,0L,7L,5L,8L,0L,9L,4L,1L,5L,2L,0L,5L,0L,3L,6L,4L,1L,2L,7L,3L,4L,2L,5L,0L,9L,8L,5L,9L,9L,2L,0L,6L,2L,3L,3L,0L,8L,3L,6L,3L,7L,8L,1L,6L,2L,4L,2L,2L,8L,8L,7L,4L,4L,0L,1L,3L,3L,7L,2L,4L,7L,3L,9L,6L,9L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092514Inst : IEnumerable<long>
{
public static readonly long[] Value=A092514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092514.Bytes);
public long this[int i]=>Value[i];

public static A092514Inst Instance=new A092514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092515
{
public static readonly long[] Value={ 1L,1L,8L,1L,3L,6L,0L,4L,1L,2L,8L,6L,5L,6L,4L,5L,9L,8L,0L,3L,0L,5L,1L,1L,2L,1L,5L,2L,5L,0L,7L,1L,8L,4L,3L,2L,7L,8L,3L,0L,1L,8L,9L,3L,1L,0L,8L,3L,8L,9L,6L,3L,7L,9L,7L,8L,5L,6L,1L,9L,4L,2L,8L,0L,2L,2L,6L,4L,5L,5L,2L,8L,5L,5L,9L,2L,2L,9L,7L,4L,5L,6L,6L,2L,3L,6L,6L,9L,7L,3L,8L,5L,0L,4L,4L,2L,7L,6L,3L,1L,9L,1L,7L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092515Inst : IEnumerable<long>
{
public static readonly long[] Value=A092515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092515.Bytes);
public long this[int i]=>Value[i];

public static A092515Inst Instance=new A092515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092548
{
public static readonly long[] Value={ 1L,1L,9L,9L,95L,149L,885L,1605L,6503L,12606L,39246L,76038L,197714L,374388L,855636L,1568124L,3255072L,5763394L,11104514L,19011234L,34512454L,57257488L,98996384L,159553376L,264837633L,415717413L,666507493L,1021374333L,1589253369L,2382741813L,3611920261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092548Inst : IEnumerable<long>
{
public static readonly long[] Value=A092548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092548.Bytes);
public long this[int i]=>Value[i];

public static A092548Inst Instance=new A092548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092549
{
public static readonly long[] Value={ 1L,1L,3L,3L,8L,9L,18L,20L,37L,42L,69L,78L,122L,139L,204L,231L,327L,371L,505L,570L,756L,852L,1100L,1234L,1563L,1749L,2173L,2421L,2964L,3293L,3974L,4398L,5247L,5790L,6831L,7512L,8782L,9631L,11160L,12201L,14033L,15303L,17475L,19004L,21568L,23400L,26400L,28572L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092549Inst : IEnumerable<long>
{
public static readonly long[] Value=A092549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092549.Bytes);
public long this[int i]=>Value[i];

public static A092549Inst Instance=new A092549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092550
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,2L,5L,7L,5L,12L,17L,12L,29L,41L,29L,70L,99L,70L,169L,239L,169L,408L,577L,408L,985L,1393L,985L,2378L,3363L,2378L,5741L,8119L,5741L,13860L,19601L,13860L,33461L,47321L,33461L,80782L,114243L,80782L,195025L,275807L,195025L,470832L,665857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092550Inst : IEnumerable<long>
{
public static readonly long[] Value=A092550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092550.Bytes);
public long this[int i]=>Value[i];

public static A092550Inst Instance=new A092550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092551
{
public static readonly long[] Value={ 5L,7L,13L,17L,19L,23L,29L,37L,43L,47L,59L,73L,79L,83L,89L,103L,107L,113L,127L,139L,149L,157L,167L,173L,199L,227L,233L,239L,257L,269L,283L,293L,307L,313L,349L,359L,373L,397L,409L,419L,433L,439L,443L,463L,467L,479L,499L,523L,547L,563L,569L,577L,593L,607L,617L,619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A092551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092551Inst : IEnumerable<long>
{
public static readonly long[] Value=A092551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092551.Bytes);
public long this[int i]=>Value[i];

public static A092551Inst Instance=new A092551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A092552
{
public static readonly BigInteger[] Value={ 0L,1L,3L,31L,675L,25231L,1441923L,116914351L,12764590275L,1805409270031L,321113303226243L,70146437009397871L,BigInteger.Parse("18462286083671614275"),BigInteger.Parse("5762225835975165678031"),BigInteger.Parse("2104263061425865873128963"),BigInteger.Parse("888881838896989670838028591"),BigInteger.Parse("430058409024841744606172532675") };
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
public class A092552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A092552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A092552Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A092552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A092552.Bytes);
public BigInteger this[int i]=>Value[i];

public static A092552Inst Instance=new A092552Inst();

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