using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A108141
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108141Inst : IEnumerable<long>
{
public static readonly long[] Value=A108141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108141.Bytes);
public long this[int i]=>Value[i];

public static A108141Inst Instance=new A108141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108142
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,3L,27L,151L,759L,3679L,17599L,83767L,397943L,1889059L,8964891L,42539855L,201849743L,957752095L,4544385823L,21562354767L,102309686479L,485441784803L,2303337053819L,10928934112423L,51855892302151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108142Inst : IEnumerable<long>
{
public static readonly long[] Value=A108142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108142.Bytes);
public long this[int i]=>Value[i];

public static A108142Inst Instance=new A108142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108143
{
public static readonly long[] Value={ 1L,1L,1L,3L,13L,61L,289L,1371L,6505L,30865L,146449L,694875L,3297061L,15643981L,74227969L,352198803L,1671122065L,7929183553L,37622596897L,178512678867L,847011613885L,4018922793661L,19069089675553L,90479513970219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108143Inst : IEnumerable<long>
{
public static readonly long[] Value=A108143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108143.Bytes);
public long this[int i]=>Value[i];

public static A108143Inst Instance=new A108143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108144
{
public static readonly long[] Value={ 5L,7L,9L,11L,13L,15L,17L,21L,23L,25L,27L,29L,33L,35L,39L,41L,45L,47L,49L,53L,57L,59L,63L,65L,69L,75L,77L,81L,83L,87L,89L,93L,95L,97L,105L,107L,113L,117L,119L,123L,125L,129L,135L,137L,143L,147L,149L,153L,159L,161L,165L,167L,173L,177L,179L,185L,189L,193L,195L,203L,207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108144Inst : IEnumerable<long>
{
public static readonly long[] Value=A108144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108144.Bytes);
public long this[int i]=>Value[i];

public static A108144Inst Instance=new A108144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108145
{
public static readonly BigInteger[] Value={ 19L,439L,0L,262524239L,765439L,0L,109876549L,1098765439L,0L,BigInteger.Parse("504948474645444342419"),BigInteger.Parse("27262524232221201918179"),0L,BigInteger.Parse("2019181716151413121110989"),BigInteger.Parse("64636261605958575655545352519"),0L };
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
public class A108145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108145Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A108145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108145.Bytes);
public BigInteger this[int i]=>Value[i];

public static A108145Inst Instance=new A108145Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108146
{
public static readonly long[] Value={ 1L,1L,1L,2L,6L,21L,76L,277L,1011L,3691L,13476L,49202L,179641L,655886L,2394701L,8743277L,31922521L,116552106L,425542626L,1553695877L,5672688776L,20711516601L,75619681751L,276094521627L,1008046888156L,3680473349246L,13437751987201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108146Inst : IEnumerable<long>
{
public static readonly long[] Value=A108146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108146.Bytes);
public long this[int i]=>Value[i];

public static A108146Inst Instance=new A108146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108147
{
public static readonly long[] Value={ 69L,1001L,7473L,7473L,7473L,14829435L,84035956L,716775953L,3316942462L,146929181584L,1688027116985L,16733341988266L,77526253572913L,802588763337245L,1898549198977876L,126616052986910920L,126616052986910920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108147Inst : IEnumerable<long>
{
public static readonly long[] Value=A108147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108147.Bytes);
public long this[int i]=>Value[i];

public static A108147Inst Instance=new A108147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108148
{
public static readonly long[] Value={ 4L,58L,433L,433L,433L,859246L,4869205L,41531378L,192190029L,8513359515L,97807539408L,969562034565L,4492020314834L,46503537359479L,110005593943729L,7336377755780301L,7336377755780301L,399887590486998269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108148Inst : IEnumerable<long>
{
public static readonly long[] Value=A108148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108148.Bytes);
public long this[int i]=>Value[i];

public static A108148Inst Instance=new A108148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108149
{
public static readonly long[] Value={ 1L,-1L,1L,0L,0L,1L,0L,1L,-1L,1L,1L,0L,1L,0L,1L,-1L,2L,-1L,2L,-1L,1L,1L,0L,3L,0L,2L,0L,1L,-1L,4L,-3L,5L,-2L,3L,-1L,1L,3L,0L,6L,0L,6L,0L,3L,0L,1L,-3L,9L,-6L,12L,-6L,9L,-3L,4L,-1L,1L,6L,0L,15L,0L,15L,0L,10L,0L,4L,0L,1L,-6L,21L,-15L,30L,-15L,25L,-10L,14L,-4L,5L,-1L,1L,15L,0L,36L,0L,40L,0L,29L,0L,15L,0L,5L,0L,1L,-15L,51L,-36L,76L,-40L,69L,-29L,44L,-15L,20L,-5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108149Inst : IEnumerable<long>
{
public static readonly long[] Value=A108149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108149.Bytes);
public long this[int i]=>Value[i];

public static A108149Inst Instance=new A108149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108150
{
public static readonly long[] Value={ 2L,2L,3L,4L,6L,10L,22L,46L,114L,294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108150Inst : IEnumerable<long>
{
public static readonly long[] Value=A108150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108150.Bytes);
public long this[int i]=>Value[i];

public static A108150Inst Instance=new A108150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108151
{
public static readonly long[] Value={ 5L,11L,19L,29L,41L,0L,71L,89L,109L,131L,0L,181L,0L,239L,271L,0L,0L,379L,419L,461L,0L,0L,599L,0L,701L,0L,811L,0L,929L,991L,0L,0L,0L,1259L,0L,0L,1481L,1559L,0L,1721L,0L,0L,1979L,2069L,2161L,0L,2351L,0L,2549L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108151Inst : IEnumerable<long>
{
public static readonly long[] Value=A108151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108151.Bytes);
public long this[int i]=>Value[i];

public static A108151Inst Instance=new A108151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108152
{
public static readonly long[] Value={ 1L,0L,2L,7L,25L,91L,330L,1197L,4342L,15750L,57131L,207235L,751717L,2726752L,9890925L,35877996L,130142590L,472074687L,1712387237L,6211453675L,22531210186L,81728925145L,296460649482L,1075371008922L,3900763250875L,14149492419951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108152Inst : IEnumerable<long>
{
public static readonly long[] Value=A108152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108152.Bytes);
public long this[int i]=>Value[i];

public static A108152Inst Instance=new A108152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108153
{
public static readonly long[] Value={ 0L,1L,3L,11L,40L,145L,526L,1908L,6921L,25105L,91065L,330326L,1198213L,4346356L,15765820L,57188385L,207443151L,752472043L,2729490816L,9900859685L,35914032730L,130273308376L,472548850273L,1714107200301L,6217692609825L,22553841080350L,81811015661001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108153Inst : IEnumerable<long>
{
public static readonly long[] Value=A108153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108153.Bytes);
public long this[int i]=>Value[i];

public static A108153Inst Instance=new A108153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108154
{
public static readonly long[] Value={ 0L,3L,7L,13L,0L,31L,43L,0L,73L,0L,0L,0L,157L,0L,211L,241L,0L,307L,0L,0L,421L,463L,0L,0L,601L,0L,0L,757L,0L,0L,0L,0L,0L,1123L,0L,0L,0L,0L,1483L,0L,0L,1723L,0L,0L,0L,0L,0L,0L,0L,0L,2551L,0L,0L,0L,2971L,0L,0L,3307L,0L,3541L,0L,0L,3907L,0L,0L,0L,4423L,0L,0L,4831L,0L,5113L,0L,0L,0L,5701L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108154Inst : IEnumerable<long>
{
public static readonly long[] Value=A108154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108154.Bytes);
public long this[int i]=>Value[i];

public static A108154Inst Instance=new A108154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108155
{
public static readonly long[] Value={ -1L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,14L,15L,16L,17L,18L,30L,31L,32L,33L,34L,62L,63L,64L,65L,66L,126L,127L,128L,129L,130L,254L,255L,256L,257L,258L,510L,511L,512L,513L,514L,1022L,1023L,1024L,1025L,1026L,2046L,2047L,2048L,2049L,2050L,4094L,4095L,4096L,4097L,4098L,8190L,8191L,8192L,8193L,8194L,16382L,16383L,16384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108155Inst : IEnumerable<long>
{
public static readonly long[] Value=A108155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108155.Bytes);
public long this[int i]=>Value[i];

public static A108155Inst Instance=new A108155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108156
{
public static readonly long[] Value={ 138L,163L,190L,523L,1855L,3228L,3579L,6468L,7170L,10230L,12783L,17259L,60139L,91315L,97923L,101823L,156075L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108156Inst : IEnumerable<long>
{
public static readonly long[] Value=A108156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108156.Bytes);
public long this[int i]=>Value[i];

public static A108156Inst Instance=new A108156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108157
{
public static readonly long[] Value={ 497L,623L,875L,1017L,1107L,1199L,1397L,1617L,1991L,2093L,2277L,2737L,2795L,2873L,3077L,3215L,3383L,3629L,3743L,3885L,4097L,4427L,5453L,5733L,6233L,6275L,6327L,6443L,7049L,8381L,8759L,8903L,9947L,10013L,10127L,10991L,11225L,11397L,11613L,11687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108157Inst : IEnumerable<long>
{
public static readonly long[] Value=A108157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108157.Bytes);
public long this[int i]=>Value[i];

public static A108157Inst Instance=new A108157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108158
{
public static readonly long[] Value={ 1L,6L,36L,91L,2775L,3916L,8911L,394716L,785631L,889111L,961191L,1456071L,5539456L,7704775L,13825911L,39502716L,56440000L,76156311L,88891111L,1507087351L,1764981991L,2530200816L,2743515775L,3950582716L,5119859836L,5468017600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108158Inst : IEnumerable<long>
{
public static readonly long[] Value=A108158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108158.Bytes);
public long this[int i]=>Value[i];

public static A108158Inst Instance=new A108158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108159
{
public static readonly long[] Value={ 3L,160L,812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108159Inst : IEnumerable<long>
{
public static readonly long[] Value=A108159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108159.Bytes);
public long this[int i]=>Value[i];

public static A108159Inst Instance=new A108159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108160
{
public static readonly long[] Value={ 37L,101L,141L,197L,269L,349L,373L,381L,389L,485L,557L,573L,677L,701L,709L,757L,781L,813L,829L,877L,885L,901L,933L,973L,997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108160Inst : IEnumerable<long>
{
public static readonly long[] Value=A108160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108160.Bytes);
public long this[int i]=>Value[i];

public static A108160Inst Instance=new A108160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108161
{
public static readonly long[] Value={ 0L,1L,3L,6L,8L,13L,19L,26L,34L,37L,47L,58L,70L,83L,97L,112L,116L,133L,151L,170L,190L,211L,233L,256L,280L,285L,311L,338L,366L,395L,425L,456L,488L,521L,555L,590L,596L,633L,671L,710L,750L,791L,833L,876L,920L,965L,1011L,1058L,1106L,1113L,1163L,1214L,1266L,1319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108161Inst : IEnumerable<long>
{
public static readonly long[] Value=A108161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108161.Bytes);
public long this[int i]=>Value[i];

public static A108161Inst Instance=new A108161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108162
{
public static readonly long[] Value={ 161038L,286L,124L,16806L,70L,244L,1228L,906L,154L,52L,66L,66L,344L,526974L,506L,286L,946L,130L,154L,370L,276L,2626L,1558L,19126L,176L,190L,946L,742L,186L,176L,3486L,190L,148L,246L,412L,10930L,186L,186L,3818L,14444L,1246L,316L,286L,276L,532L,426L,310L,246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108162Inst : IEnumerable<long>
{
public static readonly long[] Value=A108162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108162.Bytes);
public long this[int i]=>Value[i];

public static A108162Inst Instance=new A108162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108163
{
public static readonly long[] Value={ 0L,1L,3L,27L,41L,19L,29L,81L,23L,21L,63L,77L,523L,127L,77L,481L,371L,107L,113L,451L,121L,173L,441L,501L,247L,407L,319L,351L,113L,1977L,707L,767L,677L,1591L,1579L,3427L,439L,43L,1291L,481L,129L,3923L,2757L,1779L,961L,2379L,2731L,2831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108163Inst : IEnumerable<long>
{
public static readonly long[] Value=A108163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108163.Bytes);
public long this[int i]=>Value[i];

public static A108163Inst Instance=new A108163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108164
{
public static readonly long[] Value={ 49L,91L,133L,169L,217L,247L,259L,301L,361L,403L,427L,469L,481L,511L,553L,559L,589L,679L,703L,721L,763L,793L,817L,871L,889L,949L,961L,973L,1027L,1057L,1099L,1141L,1147L,1159L,1261L,1267L,1273L,1333L,1339L,1351L,1369L,1387L,1393L,1417L,1477L,1501L,1561L,1591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108164Inst : IEnumerable<long>
{
public static readonly long[] Value=A108164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108164.Bytes);
public long this[int i]=>Value[i];

public static A108164Inst Instance=new A108164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108165
{
public static readonly long[] Value={ 2L,5L,9L,12L,15L,19L,22L,26L,29L,32L,36L,39L,42L,46L,49L,53L,56L,59L,63L,66L,70L,73L,76L,80L,83L,86L,90L,93L,97L,100L,103L,107L,110L,114L,117L,120L,124L,127L,130L,134L,137L,141L,144L,147L,151L,154L,157L,161L,164L,168L,171L,174L,178L,181L,185L,188L,191L,195L,198L,201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108165Inst : IEnumerable<long>
{
public static readonly long[] Value=A108165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108165.Bytes);
public long this[int i]=>Value[i];

public static A108165Inst Instance=new A108165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108166
{
public static readonly long[] Value={ 25L,55L,85L,115L,121L,145L,187L,205L,235L,253L,265L,289L,295L,319L,355L,391L,415L,445L,451L,493L,505L,517L,529L,535L,565L,583L,649L,655L,667L,685L,697L,745L,781L,799L,835L,841L,865L,895L,901L,913L,943L,955L,979L,985L,1003L,1081L,1111L,1135L,1165L,1177L,1189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108166Inst : IEnumerable<long>
{
public static readonly long[] Value=A108166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108166.Bytes);
public long this[int i]=>Value[i];

public static A108166Inst Instance=new A108166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108167
{
public static readonly long[] Value={ 0L,-1L,1L,4L,2L,7L,13L,20L,28L,25L,35L,46L,58L,71L,85L,100L,96L,113L,131L,150L,170L,191L,213L,236L,260L,255L,281L,308L,336L,365L,395L,426L,458L,491L,525L,560L,554L,591L,629L,668L,708L,749L,791L,834L,878L,923L,969L,1016L,1064L,1057L,1107L,1158L,1210L,1263L,1317L,1372L,1428L,1485L,1543L,1602L,1662L,1723L,1785L,1848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108167Inst : IEnumerable<long>
{
public static readonly long[] Value=A108167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108167.Bytes);
public long this[int i]=>Value[i];

public static A108167Inst Instance=new A108167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108168
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,9L,12L,21L,37L,65L,114L,200L,265L,465L,816L,1432L,2513L,4410L,5842L,10252L,17991L,31572L,55405L,97229L,128801L,226030L,396655L,696081L,1221537L,2143648L,3761840L,4983377L,8745217L,15346786L,26931732L,47261895L,82938844L,109870576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108168Inst : IEnumerable<long>
{
public static readonly long[] Value=A108168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108168.Bytes);
public long this[int i]=>Value[i];

public static A108168Inst Instance=new A108168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108169
{
public static readonly long[] Value={ 1L,1L,1L,3L,18L,33L,111L,690L,1269L,4292L,26705L,49118L,166165L,1033922L,1901679L,6433333L,40029886L,73626439L,249076459L,1549819116L,2850561773L,9643381402L,60003650693L,110363919984L,373358466957L,2323134396636L,4272910326315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108169Inst : IEnumerable<long>
{
public static readonly long[] Value=A108169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108169.Bytes);
public long this[int i]=>Value[i];

public static A108169Inst Instance=new A108169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108170
{
public static readonly long[] Value={ 5L,1L,4L,1L,3L,1L,0L,5L,3L,0L,8L,6L,2L,7L,3L,1L,0L,4L,8L,9L,0L,6L,8L,0L,8L,9L,8L,6L,1L,2L,9L,1L,8L,2L,2L,3L,6L,9L,5L,5L,6L,6L,3L,2L,9L,5L,2L,0L,3L,1L,8L,3L,5L,0L,9L,9L,4L,7L,9L,8L,4L,0L,5L,2L,7L,3L,4L,1L,6L,1L,6L,2L,2L,0L,8L,6L,9L,1L,3L,1L,6L,8L,6L,8L,1L,4L,8L,4L,1L,7L,6L,7L,3L,1L,2L,2L,4L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108170Inst : IEnumerable<long>
{
public static readonly long[] Value=A108170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108170.Bytes);
public long this[int i]=>Value[i];

public static A108170Inst Instance=new A108170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108171
{
public static readonly long[] Value={ 4L,3L,4L,3L,3L,4L,3L,4L,3L,3L,4L,3L,3L,4L,3L,4L,3L,3L,4L,3L,4L,3L,3L,4L,3L,3L,4L,3L,4L,3L,3L,4L,3L,4L,3L,3L,4L,3L,3L,4L,3L,4L,3L,3L,4L,3L,3L,4L,3L,4L,3L,3L,4L,3L,4L,3L,3L,4L,3L,3L,4L,3L,4L,3L,3L,4L,3L,4L,3L,3L,4L,3L,3L,4L,3L,4L,3L,3L,4L,3L,4L,3L,3L,4L,3L,3L,4L,3L,4L,3L,3L,4L,3L,3L,4L,3L,4L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108171Inst : IEnumerable<long>
{
public static readonly long[] Value=A108171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108171.Bytes);
public long this[int i]=>Value[i];

public static A108171Inst Instance=new A108171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108172
{
public static readonly long[] Value={ 35L,65L,77L,95L,119L,143L,155L,161L,185L,203L,209L,215L,221L,287L,299L,305L,323L,329L,335L,341L,365L,371L,377L,395L,407L,413L,437L,473L,485L,497L,515L,527L,533L,545L,551L,581L,611L,623L,629L,635L,671L,689L,695L,707L,713L,731L,737L,749L,755L,767L,779L,785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108172Inst : IEnumerable<long>
{
public static readonly long[] Value=A108172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108172.Bytes);
public long this[int i]=>Value[i];

public static A108172Inst Instance=new A108172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108173
{
public static readonly long[] Value={ 1L,5L,8L,12L,15L,18L,22L,25L,29L,32L,35L,39L,42L,45L,49L,52L,56L,59L,62L,66L,69L,73L,76L,79L,83L,86L,89L,93L,96L,100L,103L,106L,110L,113L,117L,120L,123L,127L,130L,133L,137L,140L,144L,147L,150L,154L,157L,160L,164L,167L,171L,174L,177L,181L,184L,188L,191L,194L,198L,201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108173Inst : IEnumerable<long>
{
public static readonly long[] Value=A108173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108173.Bytes);
public long this[int i]=>Value[i];

public static A108173Inst Instance=new A108173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108174
{
public static readonly long[] Value={ 0L,-1L,1L,4L,0L,5L,11L,18L,26L,17L,27L,38L,50L,63L,77L,92L,76L,93L,111L,130L,150L,171L,193L,216L,240L,215L,241L,268L,296L,325L,355L,386L,418L,451L,485L,520L,484L,521L,559L,598L,638L,679L,721L,764L,808L,853L,899L,946L,994L,945L,995L,1046L,1098L,1151L,1205L,1260L,1316L,1373L,1431L,1490L,1550L,1611L,1673L,1736L,1672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108174Inst : IEnumerable<long>
{
public static readonly long[] Value=A108174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108174.Bytes);
public long this[int i]=>Value[i];

public static A108174Inst Instance=new A108174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108175
{
public static readonly long[] Value={ 3L,6L,11L,16L,20L,24L,28L,31L,36L,41L,46L,51L,56L,60L,65L,70L,75L,79L,84L,89L,94L,99L,103L,108L,113L,118L,122L,127L,132L,137L,142L,146L,149L,154L,158L,161L,165L,168L,172L,177L,180L,185L,190L,195L,199L,202L,206L,211L,216L,220L,224L,227L,230L,235L,238L,241L,246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108175Inst : IEnumerable<long>
{
public static readonly long[] Value=A108175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108175.Bytes);
public long this[int i]=>Value[i];

public static A108175Inst Instance=new A108175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108176
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,3L,7L,23L,164L,3786L,620973L,2351006074L,1459911295051236L,BigInteger.Parse("3432260322166663402961472"),BigInteger.Parse("5010795611887306064313121202903094714708"),BigInteger.Parse("17198354961167628388233455836547370709483687001035342768448084064") };
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
public class A108176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108176Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A108176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108176.Bytes);
public BigInteger this[int i]=>Value[i];

public static A108176Inst Instance=new A108176Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108177
{
public static readonly long[] Value={ -1L,0L,1L,7L,8L,9L,15L,16L,17L,127L,128L,129L,255L,256L,257L,2047L,2048L,2049L,4095L,4096L,4097L,32767L,32768L,32769L,65535L,65536L,65537L,524287L,524288L,524289L,1048575L,1048576L,1048577L,8388607L,8388608L,8388609L,16777215L,16777216L,16777217L,134217727L,134217728L,134217729L,268435455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108177Inst : IEnumerable<long>
{
public static readonly long[] Value=A108177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108177.Bytes);
public long this[int i]=>Value[i];

public static A108177Inst Instance=new A108177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108178
{
public static readonly long[] Value={ 1L,25L,235L,1330L,5488L,18228L,51660L,129690L,295845L,624481L,1236235L,2318680L,4153240L,7149520L,11888304L,19174572L,30101985L,46130385L,69177955L,101729782L,146964664L,208902100L,292571500L,404205750L,551461365L,743667561L,992106675L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108178Inst : IEnumerable<long>
{
public static readonly long[] Value=A108178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108178.Bytes);
public long this[int i]=>Value[i];

public static A108178Inst Instance=new A108178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108179
{
public static readonly BigInteger[] Value={ 1L,0L,0L,0L,3765L,46080L,540192L,3671040L,10116843L,-117737472L,-2967722688L,-38504810496L,-352908803937L,-2005760280576L,4395641418816L,308184833882112L,5087187099026592L,56699475952908288L,430959984272770368L,1056305892595267584L,BigInteger.Parse("-33732505743354837600") };
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
public class A108179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108179Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A108179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108179.Bytes);
public BigInteger this[int i]=>Value[i];

public static A108179Inst Instance=new A108179Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108180
{
public static readonly long[] Value={ 1L,2L,8L,20L,23L,55L,57L,58L,181L,741L,939L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108180Inst : IEnumerable<long>
{
public static readonly long[] Value=A108180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108180.Bytes);
public long this[int i]=>Value[i];

public static A108180Inst Instance=new A108180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108181
{
public static readonly long[] Value={ 9L,21L,25L,33L,49L,57L,65L,69L,77L,85L,93L,121L,129L,133L,141L,145L,161L,169L,177L,185L,201L,205L,209L,213L,217L,221L,237L,249L,253L,265L,289L,301L,305L,309L,321L,329L,341L,361L,365L,377L,381L,393L,413L,417L,437L,445L,453L,469L,473L,481L,485L,489L,493L,497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108181Inst : IEnumerable<long>
{
public static readonly long[] Value=A108181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108181.Bytes);
public long this[int i]=>Value[i];

public static A108181Inst Instance=new A108181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108182
{
public static readonly long[] Value={ 6L,16L,31L,52L,74L,98L,124L,157L,192L,230L,270L,312L,363L,417L,474L,532L,592L,657L,723L,792L,862L,936L,1013L,1091L,1175L,1260L,1346L,1433L,1521L,1611L,1702L,1795L,1891L,1993L,2097L,2202L,2308L,2418L,2532L,2647L,2765L,2884L,3006L,3129L,3258L,3390L,3523L,3657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108182Inst : IEnumerable<long>
{
public static readonly long[] Value=A108182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108182.Bytes);
public long this[int i]=>Value[i];

public static A108182Inst Instance=new A108182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108183
{
public static readonly long[] Value={ 19L,29L,43L,47L,59L,67L,73L,127L,151L,167L,173L,233L,283L,313L,317L,461L,521L,541L,593L,653L,701L,719L,727L,787L,839L,907L,967L,1249L,1409L,1439L,1471L,1549L,1601L,1831L,1867L,1873L,1913L,1993L,2029L,2083L,2089L,2287L,2311L,2351L,2393L,2579L,2593L,2693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108183Inst : IEnumerable<long>
{
public static readonly long[] Value=A108183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108183.Bytes);
public long this[int i]=>Value[i];

public static A108183Inst Instance=new A108183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108184
{
public static readonly long[] Value={ 2L,3L,7L,11L,23L,31L,41L,47L,67L,71L,83L,109L,113L,131L,139L,149L,167L,193L,197L,233L,241L,251L,263L,271L,283L,317L,331L,347L,353L,373L,379L,401L,439L,443L,479L,487L,491L,503L,523L,541L,563L,571L,577L,587L,613L,619L,641L,727L,733L,761L,787L,809L,863L,877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108184Inst : IEnumerable<long>
{
public static readonly long[] Value=A108184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108184.Bytes);
public long this[int i]=>Value[i];

public static A108184Inst Instance=new A108184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108185
{
public static readonly BigInteger[] Value={ 0L,4L,24L,1744L,88480L,20785984L,4774925568L,3557583518976L,2784648830636544L,7054995406469377024L,BigInteger.Parse("16660711592693252288512") };
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
public class A108185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108185Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A108185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108185.Bytes);
public BigInteger this[int i]=>Value[i];

public static A108185Inst Instance=new A108185Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108186
{
public static readonly long[] Value={ 7L,7L,8L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,11L,12L,12L,12L,12L,12L,13L,13L,13L,13L,14L,14L,14L,14L,15L,15L,15L,15L,16L,16L,16L,16L,16L,17L,17L,17L,17L,18L,18L,18L,18L,18L,19L,19L,19L,19L,20L,20L,20L,20L,20L,21L,21L,21L,21L,21L,22L,22L,22L,22L,23L,23L,23L,23L,23L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108186Inst : IEnumerable<long>
{
public static readonly long[] Value=A108186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108186.Bytes);
public long this[int i]=>Value[i];

public static A108186Inst Instance=new A108186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108187
{
public static readonly long[] Value={ 2L,6L,8L,12L,14L,18L,26L,32L,42L,44L,48L,62L,68L,72L,74L,78L,84L,86L,96L,102L,114L,126L,132L,144L,146L,152L,158L,162L,176L,182L,188L,194L,204L,216L,218L,222L,224L,228L,236L,242L,252L,254L,258L,284L,288L,294L,296L,306L,314L,324L,326L,336L,344L,348L,354L,356L,366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108187Inst : IEnumerable<long>
{
public static readonly long[] Value=A108187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108187.Bytes);
public long this[int i]=>Value[i];

public static A108187Inst Instance=new A108187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108188
{
public static readonly long[] Value={ 0L,1L,1L,6L,32L,195L,1398L,11375L,103744L,1048653L,11637720L,140691287L,1840531920L,25907192051L,390437813612L,6272783063745L,107026049110528L,1932717589794045L,36828295595429724L,738492745452351643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108188Inst : IEnumerable<long>
{
public static readonly long[] Value=A108188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108188.Bytes);
public long this[int i]=>Value[i];

public static A108188Inst Instance=new A108188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108189
{
public static readonly long[] Value={ 0L,1L,1L,3L,8L,20L,66L,196L,688L,2358L,8840L,33506L,134376L,550498L,2350348L,10273110L,46413536L,214598786L,1020359628L,4959234118L,24699168280L,125571468666L,652484852756L,3456224649758L,18673351714128L,102717737562850L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108189Inst : IEnumerable<long>
{
public static readonly long[] Value=A108189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108189.Bytes);
public long this[int i]=>Value[i];

public static A108189Inst Instance=new A108189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108190
{
public static readonly long[] Value={ 24L,36L,100L,184L,189L,372L,472L,484L,513L,532L,580L,644L,748L,824L,904L,940L,1016L,1029L,1036L,1062L,1068L,1096L,1107L,1164L,1180L,1208L,1225L,1236L,1269L,1284L,1304L,1336L,1340L,1395L,1420L,1430L,1444L,1482L,1508L,1521L,1580L,1593L,1610L,1628L,1666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108190Inst : IEnumerable<long>
{
public static readonly long[] Value=A108190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108190.Bytes);
public long this[int i]=>Value[i];

public static A108190Inst Instance=new A108190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108191
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,19L,20L,30L,40L,50L,60L,70L,80L,90L,91L,100L,109L,118L,119L,127L,128L,129L,136L,137L,138L,139L,145L,146L,147L,148L,149L,154L,155L,156L,157L,158L,159L,163L,164L,165L,166L,167L,168L,169L,172L,173L,174L,175L,176L,177L,178L,179L,181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108191Inst : IEnumerable<long>
{
public static readonly long[] Value=A108191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108191.Bytes);
public long this[int i]=>Value[i];

public static A108191Inst Instance=new A108191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108192
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,26L,30L,31L,35L,40L,41L,46L,50L,51L,53L,55L,57L,59L,60L,61L,62L,64L,66L,68L,70L,71L,75L,80L,81L,86L,90L,91L,95L,100L,101L,102L,103L,104L,105L,106L,107L,108L,109L,110L,111L,112L,113L,114L,115L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108192Inst : IEnumerable<long>
{
public static readonly long[] Value=A108192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108192.Bytes);
public long this[int i]=>Value[i];

public static A108192Inst Instance=new A108192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108193
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,19L,20L,30L,40L,50L,60L,70L,80L,90L,91L,100L,109L,118L,119L,127L,128L,129L,136L,137L,146L,155L,157L,159L,163L,164L,166L,168L,172L,173L,175L,181L,182L,186L,190L,191L,192L,195L,199L,200L,208L,217L,218L,219L,228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108193Inst : IEnumerable<long>
{
public static readonly long[] Value=A108193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108193.Bytes);
public long this[int i]=>Value[i];

public static A108193Inst Instance=new A108193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108194
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,22L,28L,29L,37L,39L,48L,49L,59L,68L,69L,73L,77L,78L,79L,82L,84L,86L,87L,88L,89L,92L,93L,94L,95L,96L,97L,98L,99L,109L,123L,127L,128L,129L,132L,136L,137L,138L,145L,147L,148L,154L,157L,158L,159L,163L,166L,167L,172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108194Inst : IEnumerable<long>
{
public static readonly long[] Value=A108194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108194.Bytes);
public long this[int i]=>Value[i];

public static A108194Inst Instance=new A108194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108195
{
public static readonly long[] Value={ 5L,13L,23L,35L,49L,65L,83L,103L,125L,149L,175L,203L,233L,265L,299L,335L,373L,413L,455L,499L,545L,593L,643L,695L,749L,805L,863L,923L,985L,1049L,1115L,1183L,1253L,1325L,1399L,1475L,1553L,1633L,1715L,1799L,1885L,1973L,2063L,2155L,2249L,2345L,2443L,2543L,2645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108195Inst : IEnumerable<long>
{
public static readonly long[] Value=A108195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108195.Bytes);
public long this[int i]=>Value[i];

public static A108195Inst Instance=new A108195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108196
{
public static readonly long[] Value={ -1L,-3L,0L,21L,55L,0L,-377L,-987L,0L,6765L,17711L,0L,-121393L,-317811L,0L,2178309L,5702887L,0L,-39088169L,-102334155L,0L,701408733L,1836311903L,0L,-12586269025L,-32951280099L,0L,225851433717L,591286729879L,0L,-4052739537881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108196Inst : IEnumerable<long>
{
public static readonly long[] Value=A108196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108196.Bytes);
public long this[int i]=>Value[i];

public static A108196Inst Instance=new A108196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108197
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,3L,0L,1L,0L,4L,0L,0L,1L,0L,4L,1L,1L,2L,1L,0L,1L,2L,2L,2L,2L,3L,1L,0L,0L,2L,1L,0L,0L,7L,2L,2L,2L,0L,1L,0L,0L,4L,2L,0L,4L,0L,0L,1L,0L,6L,1L,0L,1L,3L,1L,6L,0L,2L,1L,1L,4L,4L,0L,0L,1L,0L,2L,2L,0L,0L,1L,0L,0L,1L,3L,5L,1L,7L,1L,2L,0L,3L,2L,1L,1L,4L,2L,6L,1L,1L,2L,2L,0L,1L,0L,0L,1L,2L,2L,3L,1L,1L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108197Inst : IEnumerable<long>
{
public static readonly long[] Value=A108197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108197.Bytes);
public long this[int i]=>Value[i];

public static A108197Inst Instance=new A108197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108198
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,5L,1L,6L,15L,14L,1L,8L,30L,56L,42L,1L,10L,50L,140L,210L,132L,1L,12L,75L,280L,630L,792L,429L,1L,14L,105L,490L,1470L,2772L,3003L,1430L,1L,16L,140L,784L,2940L,7392L,12012L,11440L,4862L,1L,18L,180L,1176L,5292L,16632L,36036L,51480L,43758L,16796L,1L,20L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108198Inst : IEnumerable<long>
{
public static readonly long[] Value=A108198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108198.Bytes);
public long this[int i]=>Value[i];

public static A108198Inst Instance=new A108198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108199
{
public static readonly long[] Value={ 2L,11L,12L,13L,14L,15L,16L,17L,18L,19L,21L,23L,25L,27L,29L,32L,35L,38L,42L,46L,51L,56L,62L,68L,75L,83L,92L,102L,103L,104L,105L,106L,107L,108L,109L,110L,111L,112L,113L,114L,115L,116L,117L,118L,119L,120L,121L,122L,123L,124L,125L,126L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108199Inst : IEnumerable<long>
{
public static readonly long[] Value=A108199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108199.Bytes);
public long this[int i]=>Value[i];

public static A108199Inst Instance=new A108199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108200
{
public static readonly long[] Value={ 5L,7L,62L,19L,1L,31L,2L,1254L,1692L,85L,912L,49L,20796L,1L,1234L,627L,50L,846L,4L,860L,28L,456L,4076L,418L,34L,10398L,564L,21L,91250L,617L,6L,47670L,304L,25L,6218L,423L,352018L,2L,6932L,430L,9348L,14L,400L,228L,2874L,2038L,324L,209L,12L,17L,5562L,5199L,25784L,282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108200Inst : IEnumerable<long>
{
public static readonly long[] Value=A108200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108200.Bytes);
public long this[int i]=>Value[i];

public static A108200Inst Instance=new A108200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108201
{
public static readonly long[] Value={ 1L,5L,12L,25L,60L,125L,144L,300L,625L,720L,1500L,1728L,3125L,3600L,7500L,8640L,15625L,18000L,20736L,37500L,43200L,78125L,90000L,103680L,187500L,216000L,248832L,390625L,450000L,518400L,937500L,1080000L,1244160L,1953125L,2250000L,2592000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108201Inst : IEnumerable<long>
{
public static readonly long[] Value=A108201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108201.Bytes);
public long this[int i]=>Value[i];

public static A108201Inst Instance=new A108201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108202
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,1L,3L,0L,4L,2L,5L,1L,6L,3L,7L,0L,8L,4L,9L,2L,1L,5L,0L,1L,1L,6L,1L,3L,1L,7L,2L,0L,1L,8L,3L,4L,1L,9L,4L,2L,1L,1L,5L,5L,1L,0L,6L,1L,1L,1L,7L,6L,1L,1L,8L,3L,1L,1L,9L,7L,2L,2L,0L,0L,2L,1L,1L,8L,2L,3L,2L,4L,2L,1L,3L,9L,2L,4L,4L,2L,2L,1L,5L,1L,2L,5L,6L,5L,2L,1L,7L,0L,2L,6L,8L,1L,2L,1L,9L,1L,3L,7L,0L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108202Inst : IEnumerable<long>
{
public static readonly long[] Value=A108202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108202.Bytes);
public long this[int i]=>Value[i];

public static A108202Inst Instance=new A108202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108203
{
public static readonly long[] Value={ 11L,22L,33L,44L,55L,66L,77L,88L,99L,101L,112L,123L,134L,145L,156L,167L,178L,189L,202L,213L,224L,235L,246L,257L,268L,279L,303L,314L,325L,336L,347L,358L,369L,404L,415L,426L,437L,448L,459L,505L,516L,527L,538L,549L,606L,617L,628L,639L,707L,718L,729L,808L,819L,909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108203Inst : IEnumerable<long>
{
public static readonly long[] Value=A108203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108203.Bytes);
public long this[int i]=>Value[i];

public static A108203Inst Instance=new A108203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108204
{
public static readonly ulong[] Value={ 0L,1L,2L,6L,30L,216L,2010L,22824L,305466L,4704864L,81938358L,1591718520L,34116485502L,799695029808L,20348556463482L,558563850560184L,16451687169853290L,517516967826342336L,17315898224208133494UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108204Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A108204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108204.Bytes);
public ulong this[int i]=>Value[i];

public static A108204Inst Instance=new A108204Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108205
{
public static readonly BigInteger[] Value={ 0L,1L,2L,10L,66L,568L,6010L,75528L,1099462L,18195616L,337416246L,6930281080L,156177762466L,3831429672144L,101647482387802L,2899769522268472L,88517797903871190L,2878965845280173632L,BigInteger.Parse("99389641303891713718") };
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
public class A108205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108205Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A108205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108205.Bytes);
public BigInteger this[int i]=>Value[i];

public static A108205Inst Instance=new A108205Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108206
{
public static readonly BigInteger[] Value={ 0L,1L,3L,20L,189L,2348L,36165L,665058L,14219373L,346585416L,9485780589L,288039271830L,9609639556869L,349403495309244L,13751661631299813L,582461437448921562L,BigInteger.Parse("26417039609670967485"),BigInteger.Parse("1277337284263389184272") };
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
public class A108206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108206Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A108206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108206.Bytes);
public BigInteger this[int i]=>Value[i];

public static A108206Inst Instance=new A108206Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108207
{
public static readonly BigInteger[] Value={ 0L,1L,5L,48L,705L,13908L,344175L,10241802L,356053845L,14160219384L,634005387675L,31558667189910L,1728752636180625L,103346454164558580L,6695045736425959575L,BigInteger.Parse("467206351191513350130"),BigInteger.Parse("34940050653317111866125") };
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
public class A108207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108207Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A108207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108207.Bytes);
public BigInteger this[int i]=>Value[i];

public static A108207Inst Instance=new A108207Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108208
{
public static readonly BigInteger[] Value={ 0L,2L,8L,56L,624L,9536L,184480L,4313088L,118183744L,3712870400L,131536027008L,5187183672320L,225342288987904L,10691937463283712L,550121848577067520L,BigInteger.Parse("30507449271343837184"),BigInteger.Parse("1813943300823318205440"),BigInteger.Parse("115116132876009362358272") };
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
public class A108208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108208Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A108208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108208.Bytes);
public BigInteger this[int i]=>Value[i];

public static A108208Inst Instance=new A108208Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108209
{
public static readonly BigInteger[] Value={ 0L,2L,10L,92L,1320L,25664L,628400L,18544032L,640243520L,25313036288L,1127562249600L,55871851754240L,3048145476992000L,181547804177418240L,11721355489130393600UL,BigInteger.Parse("815411545722159841280"),BigInteger.Parse("60804225264488076288000") };
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
public class A108209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108209Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A108209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108209.Bytes);
public BigInteger this[int i]=>Value[i];

public static A108209Inst Instance=new A108209Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108210
{
public static readonly BigInteger[] Value={ 0L,3L,15L,132L,1845L,35316L,855225L,25021062L,857777445L,33710592312L,1493816663025L,73679515381890L,4003077396124125L,237532181213699460L,15283471760441624025UL,BigInteger.Parse("1059866671619938304430"),BigInteger.Parse("78802244142275499751125") };
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
public class A108210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108210Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A108210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108210.Bytes);
public BigInteger this[int i]=>Value[i];

public static A108210Inst Instance=new A108210Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108211
{
public static readonly long[] Value={ 17L,65L,145L,257L,401L,577L,785L,1025L,1297L,1601L,1937L,2305L,2705L,3137L,3601L,4097L,4625L,5185L,5777L,6401L,7057L,7745L,8465L,9217L,10001L,10817L,11665L,12545L,13457L,14401L,15377L,16385L,17425L,18497L,19601L,20737L,21905L,23105L,24337L,25601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108211Inst : IEnumerable<long>
{
public static readonly long[] Value=A108211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108211.Bytes);
public long this[int i]=>Value[i];

public static A108211Inst Instance=new A108211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108212
{
public static readonly long[] Value={ 399404041L,156868L,13421L,3518L,1478L,800L,505L,353L,265L,209L,172L,146L,127L,113L,102L,93L,86L,80L,76L,72L,68L,65L,63L,61L,59L,57L,56L,55L,54L,53L,52L,51L,50L,50L,49L,49L,49L,48L,48L,48L,47L,47L,47L,47L,47L,47L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108212Inst : IEnumerable<long>
{
public static readonly long[] Value=A108212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108212.Bytes);
public long this[int i]=>Value[i];

public static A108212Inst Instance=new A108212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108213
{
public static readonly long[] Value={ 44L,22L,88L,44L,176L,88L,352L,176L,704L,352L,1408L,704L,2816L,1408L,5632L,2816L,11264L,5632L,22528L,11264L,45056L,22528L,90112L,45056L,180224L,90112L,360448L,180224L,720896L,360448L,1441792L,720896L,2883584L,1441792L,5767168L,2883584L,11534336L,5767168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108213Inst : IEnumerable<long>
{
public static readonly long[] Value=A108213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108213.Bytes);
public long this[int i]=>Value[i];

public static A108213Inst Instance=new A108213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108214
{
public static readonly BigInteger[] Value={ 8L,48L,576L,11520L,345600L,14515200L,812851200L,58525286400L,5267275776000L,579400335360000L,76480844267520000L,11931011705733120000UL,BigInteger.Parse("2171444130443427840000"),BigInteger.Parse("456003267393119846400000") };
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
public class A108214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108214Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A108214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108214.Bytes);
public BigInteger this[int i]=>Value[i];

public static A108214Inst Instance=new A108214Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108215
{
public static readonly long[] Value={ 24L,54L,90L,140L,210L,315L,462L,550L,650L,858L,1122L,1190L,1330L,1482L,1794L,2254L,2499L,2805L,3135L,3306L,3596L,4030L,4485L,5106L,5698L,6314L,6970L,7310L,7482L,7917L,8463L,8742L,8930L,10070L,11766L,12765L,13570L,14042L,14399L,14762L,15006L,15867L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108215Inst : IEnumerable<long>
{
public static readonly long[] Value=A108215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108215.Bytes);
public long this[int i]=>Value[i];

public static A108215Inst Instance=new A108215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108216
{
public static readonly long[] Value={ 3L,3L,4L,5L,2L,4L,3L,2L,4L,4L,1L,4L,4L,2L,5L,3L,3L,2L,3L,1L,6L,6L,2L,2L,2L,3L,3L,2L,2L,4L,5L,2L,5L,3L,2L,2L,3L,2L,3L,5L,2L,4L,2L,1L,3L,4L,2L,3L,4L,2L,3L,5L,3L,4L,3L,4L,3L,2L,4L,2L,0L,2L,4L,3L,1L,1L,3L,3L,4L,5L,3L,3L,2L,3L,3L,3L,3L,3L,3L,4L,3L,4L,0L,3L,4L,1L,4L,3L,2L,4L,2L,3L,4L,3L,2L,4L,2L,3L,3L,3L,3L,2L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108216Inst : IEnumerable<long>
{
public static readonly long[] Value=A108216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108216.Bytes);
public long this[int i]=>Value[i];

public static A108216Inst Instance=new A108216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108217
{
public static readonly long[] Value={ 1L,1L,3L,7L,26L,126L,744L,5160L,41040L,367920L,3669120L,40279680L,482630400L,6266937600L,87657292800L,1313901388800L,21009968179200L,356995102464000L,6423296495616000L,122000787836928000L,2439304381882368000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108217Inst : IEnumerable<long>
{
public static readonly long[] Value=A108217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108217.Bytes);
public long this[int i]=>Value[i];

public static A108217Inst Instance=new A108217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108218
{
public static readonly long[] Value={ 1L,11L,12L,121L,132L,144L,1331L,1452L,1584L,1728L,14641L,15972L,17424L,19008L,20736L,161051L,175692L,191664L,209088L,228096L,248832L,1771561L,1932612L,2108304L,2299968L,2509056L,2737152L,2985984L,19487171L,21258732L,23191344L,25299648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108218Inst : IEnumerable<long>
{
public static readonly long[] Value=A108218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108218.Bytes);
public long this[int i]=>Value[i];

public static A108218Inst Instance=new A108218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108219
{
public static readonly long[] Value={ 8L,9L,26L,44L,105L,112L,125L,126L,150L,160L,180L,192L,216L,243L,292L,568L,639L,1174L,1407L,1448L,1629L,1675L,2010L,2144L,2379L,2412L,2685L,2722L,2864L,3222L,3355L,3835L,3999L,4026L,4107L,4543L,4602L,5035L,5709L,5978L,6042L,6235L,6307L,6355L,6490L,7482L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108219Inst : IEnumerable<long>
{
public static readonly long[] Value=A108219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108219.Bytes);
public long this[int i]=>Value[i];

public static A108219Inst Instance=new A108219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108220
{
public static readonly long[] Value={ 3L,102L,122L,202L,1102L,15031L,244134L,244233L,434412L,495918L,1267396L,1300035L,1324340L,1635150L,3442657L,3878374L,5064314L,6175125L,6181308L,10320734L,10560355L,10586434L,10730603L,10804230L,11544642L,16224135L,17523855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108220Inst : IEnumerable<long>
{
public static readonly long[] Value=A108220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108220.Bytes);
public long this[int i]=>Value[i];

public static A108220Inst Instance=new A108220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108221
{
public static readonly long[] Value={ 2L,2L,3L,3L,5L,5L,5L,7L,7L,7L,7L,11L,11L,11L,11L,11L,13L,13L,13L,13L,13L,17L,17L,17L,17L,17L,17L,17L,19L,19L,19L,19L,19L,19L,23L,23L,23L,23L,23L,23L,23L,29L,29L,29L,29L,29L,29L,29L,29L,29L,31L,31L,31L,31L,31L,31L,31L,31L,37L,37L,37L,37L,37L,37L,37L,37L,37L,41L,41L,41L,41L,41L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108221Inst : IEnumerable<long>
{
public static readonly long[] Value=A108221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108221.Bytes);
public long this[int i]=>Value[i];

public static A108221Inst Instance=new A108221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108222
{
public static readonly long[] Value={ 2L,3L,5L,7L,17L,19L,23L,37L,41L,43L,47L,101L,103L,107L,109L,113L,149L,151L,157L,163L,167L,257L,263L,269L,271L,277L,281L,283L,331L,337L,347L,349L,353L,359L,487L,491L,499L,503L,509L,521L,523L,787L,797L,809L,811L,821L,823L,827L,829L,839L,907L,911L,919L,929L,937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108222Inst : IEnumerable<long>
{
public static readonly long[] Value=A108222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108222.Bytes);
public long this[int i]=>Value[i];

public static A108222Inst Instance=new A108222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108223
{
public static readonly BigInteger[] Value={ 1L,13L,703L,61681L,9762501L,2140365529L,678222249307L,280379743338241L,150087010086914941L,BigInteger.Parse("99902428887422922553") };
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
public class A108223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108223Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A108223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108223.Bytes);
public BigInteger this[int i]=>Value[i];

public static A108223Inst Instance=new A108223Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108224
{
public static readonly long[] Value={ 99464L,99496L,99505L,99644L,99673L,99690L,99734L,99745L,99902L,99946L,99960L,99992L,100000L,100001L,100003L,100036L,100045L,100047L,100082L,100090L,100091L,100093L,100099L,100100L,100101L,100102L,100104L,100110L,100130L,100137L,100237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108224Inst : IEnumerable<long>
{
public static readonly long[] Value=A108224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108224.Bytes);
public long this[int i]=>Value[i];

public static A108224Inst Instance=new A108224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108225
{
public static readonly BigInteger[] Value={ 0L,2L,3L,5L,12L,68L,2280L,2598062L,3374961778893L,BigInteger.Parse("5695183504492614029263280"),BigInteger.Parse("16217557574922386301420536972254869595782763547562") };
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
public class A108225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108225Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A108225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108225.Bytes);
public BigInteger this[int i]=>Value[i];

public static A108225Inst Instance=new A108225Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108226
{
public static readonly long[] Value={ 13L,41L,47L,79L,83L,97L,139L,167L,181L,223L,251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108226Inst : IEnumerable<long>
{
public static readonly long[] Value=A108226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108226.Bytes);
public long this[int i]=>Value[i];

public static A108226Inst Instance=new A108226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108227
{
public static readonly long[] Value={ 3L,5L,9L,18L,31L,46L,67L,91L,122L,157L,194L,238L,284L,334L,392L,455L,522L,591L,668L,748L,834L,929L,1028L,1133L,1241L,1352L,1469L,1594L,1727L,1869L,2019L,2163L,2315L,2471L,2636L,2802L,2977L,3156L,3341L,3534L,3731L,3933L,4145L,4358L,4581L,4811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108227Inst : IEnumerable<long>
{
public static readonly long[] Value=A108227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108227.Bytes);
public long this[int i]=>Value[i];

public static A108227Inst Instance=new A108227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108228
{
public static readonly long[] Value={ 0L,1L,2L,4L,3L,7L,5L,13L,12L,10L,6L,22L,8L,16L,17L,40L,9L,37L,11L,31L,27L,19L,14L,67L,24L,25L,62L,49L,15L,52L,18L,121L,32L,28L,38L,112L,20L,34L,42L,94L,21L,82L,23L,58L,87L,43L,26L,202L,60L,73L,47L,76L,29L,187L,45L,148L,57L,46L,30L,157L,33L,55L,137L,364L,59L,97L,35L,85L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108228Inst : IEnumerable<long>
{
public static readonly long[] Value=A108228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108228.Bytes);
public long this[int i]=>Value[i];

public static A108228Inst Instance=new A108228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108229
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108229Inst : IEnumerable<long>
{
public static readonly long[] Value=A108229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108229.Bytes);
public long this[int i]=>Value[i];

public static A108229Inst Instance=new A108229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108230
{
public static readonly long[] Value={ 0L,1L,2L,1L,3L,2L,4L,1L,2L,3L,5L,1L,6L,4L,3L,1L,7L,2L,8L,3L,4L,5L,9L,1L,3L,6L,2L,4L,10L,3L,11L,1L,5L,7L,4L,2L,12L,8L,6L,1L,13L,4L,14L,5L,2L,9L,15L,1L,4L,3L,7L,6L,16L,2L,5L,1L,8L,10L,17L,3L,18L,11L,2L,1L,6L,5L,19L,7L,9L,4L,20L,2L,21L,12L,3L,8L,5L,6L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108230Inst : IEnumerable<long>
{
public static readonly long[] Value=A108230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108230.Bytes);
public long this[int i]=>Value[i];

public static A108230Inst Instance=new A108230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108231
{
public static readonly long[] Value={ 3L,71L,7L,463L,31L,43L,5L,7L,499L,821L,109L,97L,271L,263L,179L,97L,181L,47L,233L,1931L,359L,227L,1787L,443L,29L,131L,1061L,229L,599L,1931L,7L,317L,53L,2207L,811L,11549L,2411L,2879L,5531L,937L,2371L,293L,21001L,659L,643L,1187L,2927L,4567L,131L,263L,8419L,349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108231Inst : IEnumerable<long>
{
public static readonly long[] Value=A108231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108231.Bytes);
public long this[int i]=>Value[i];

public static A108231Inst Instance=new A108231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108232
{
public static readonly long[] Value={ 4L,6L,10L,18L,24L,34L,36L,40L,46L,48L,54L,58L,60L,66L,76L,90L,96L,100L,108L,118L,130L,136L,138L,148L,156L,160L,174L,178L,180L,184L,186L,190L,204L,208L,214L,240L,244L,246L,264L,270L,298L,306L,316L,318L,324L,330L,340L,348L,358L,366L,376L,384L,388L,390L,394L,396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108232Inst : IEnumerable<long>
{
public static readonly long[] Value=A108232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108232.Bytes);
public long this[int i]=>Value[i];

public static A108232Inst Instance=new A108232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108233
{
public static readonly long[] Value={ 0L,6L,12L,16L,24L,28L,34L,36L,42L,52L,54L,58L,64L,72L,78L,82L,84L,94L,96L,106L,108L,112L,114L,118L,138L,142L,154L,156L,162L,166L,184L,196L,208L,216L,222L,232L,234L,244L,246L,252L,258L,262L,264L,268L,274L,276L,292L,306L,322L,328L,336L,342L,348L,352L,358L,384L,388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108233Inst : IEnumerable<long>
{
public static readonly long[] Value=A108233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108233.Bytes);
public long this[int i]=>Value[i];

public static A108233Inst Instance=new A108233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108234
{
public static readonly long[] Value={ 1L,0L,0L,2L,0L,1L,0L,1L,1L,2L,0L,3L,0L,1L,1L,2L,0L,1L,0L,1L,1L,2L,0L,2L,2L,1L,2L,2L,0L,1L,0L,2L,1L,2L,1L,1L,0L,3L,1L,2L,0L,3L,0L,1L,2L,3L,0L,1L,2L,1L,1L,2L,0L,1L,2L,1L,2L,2L,0L,2L,0L,2L,1L,2L,1L,4L,0L,1L,1L,2L,0L,3L,0L,1L,1L,2L,2L,1L,0L,3L,1L,2L,0L,2L,3L,1L,2L,2L,0L,1L,2L,3L,2L,2L,1L,1L,0L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108234Inst : IEnumerable<long>
{
public static readonly long[] Value=A108234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108234.Bytes);
public long this[int i]=>Value[i];

public static A108234Inst Instance=new A108234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108235
{
public static readonly long[] Value={ 1L,1L,0L,0L,8L,21L,0L,0L,3040L,20505L,0L,0L,10567748L,103372655L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108235Inst : IEnumerable<long>
{
public static readonly long[] Value=A108235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108235.Bytes);
public long this[int i]=>Value[i];

public static A108235Inst Instance=new A108235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108236
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,4L,6L,3L,10L,25L,12L,42L,8L,40L,202L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108236Inst : IEnumerable<long>
{
public static readonly long[] Value=A108236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108236.Bytes);
public long this[int i]=>Value[i];

public static A108236Inst Instance=new A108236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108237
{
public static readonly long[] Value={ 11L,21L,22L,31L,32L,42L,43L,51L,53L,62L,64L,72L,74L,83L,85L,91L,95L,131L,612L,1614L,1712L,1714L,1813L,1815L,1911L,1915L,2113L,2116L,2122L,2126L,2134L,2137L,2142L,2147L,2154L,2158L,2163L,2168L,2175L,2179L,2181L,2189L,2195L,2211L,3113L,3211L,4116L,4211L,4212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108237Inst : IEnumerable<long>
{
public static readonly long[] Value=A108237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108237.Bytes);
public long this[int i]=>Value[i];

public static A108237Inst Instance=new A108237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108238
{
public static readonly long[] Value={ 1L,7L,12L,49L,84L,144L,343L,588L,1008L,1728L,2401L,4116L,7056L,12096L,16807L,20736L,28812L,49392L,84672L,117649L,145152L,201684L,248832L,345744L,592704L,823543L,1016064L,1411788L,1741824L,2420208L,2985984L,4148928L,5764801L,7112448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108238Inst : IEnumerable<long>
{
public static readonly long[] Value=A108238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108238.Bytes);
public long this[int i]=>Value[i];

public static A108238Inst Instance=new A108238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108239
{
public static readonly long[] Value={ 1L,1L,3L,9L,43L,655L,42426L,11590894L,12561206794L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108239Inst : IEnumerable<long>
{
public static readonly long[] Value=A108239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108239.Bytes);
public long this[int i]=>Value[i];

public static A108239Inst Instance=new A108239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108240
{
public static readonly long[] Value={ 0L,1L,2L,7L,45L,54L,60L,99L,195L,271L,476L,1491L,2713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A108240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108240Inst : IEnumerable<long>
{
public static readonly long[] Value=A108240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108240.Bytes);
public long this[int i]=>Value[i];

public static A108240Inst Instance=new A108240Inst();

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