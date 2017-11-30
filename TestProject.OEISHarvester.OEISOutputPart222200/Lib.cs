using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A260582
{
public static readonly BigInteger[] Value={ 1L,72L,2438L,48965L,727982L,9002669L,98831244L,1001534339L,9604385112L,88600727292L,795108048465L,6995452987296L,60672964077315L,520801298224219L,4436874672072459L,37592602817393616L,317246106027904761L,2669508900483670024L,BigInteger.Parse("22415690107381454687") };
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
public class A260582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260582Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260582.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260582Inst Instance=new A260582Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260583
{
public static readonly BigInteger[] Value={ 11L,595L,14679L,253247L,3564803L,44226950L,505572550L,5473391465L,57122380066L,581477852342L,5819301681925L,57564437594318L,564911137682637L,5513703983635512L,53616132982114742L,520057429817203110L,5035740328012627416L,BigInteger.Parse("48704838658567681135") };
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
public class A260583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260583Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260583.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260583Inst Instance=new A260583Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260584
{
public static readonly long[] Value={ 1L,42L,1152L,22785L,358784L,4848569L,59160195L,674020718L,7332379979L,77311947872L,798116114567L,8122264310217L,81865063934240L,819786478839348L,8173571362926773L,81256681626746819L,806240597786756436L,7989356540290573170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260584Inst : IEnumerable<long>
{
public static readonly long[] Value=A260584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260584.Bytes);
public long this[int i]=>Value[i];

public static A260584Inst Instance=new A260584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260585
{
public static readonly long[] Value={ 1L,11L,72L,367L,1630L,6680L,26082L,98870L,368045L,1354850L,4953503L,18035279L,65499031L,237511321L,860471110L,3115667369L,11277816388L,40814611818L,147692103728L,534404499040L,1933597628291L,6996040095316L,25312367524557L,91581960107817L,331348634005165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260585Inst : IEnumerable<long>
{
public static readonly long[] Value=A260585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260585.Bytes);
public long this[int i]=>Value[i];

public static A260585Inst Instance=new A260585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260586
{
public static readonly BigInteger[] Value={ 0L,0L,3L,35L,357L,3579L,357911L,35791113L,3579111315L,357911131517L,357911131517101L,35791113151710112L,3579111315171011223L,BigInteger.Parse("357911131517101122334"),BigInteger.Parse("35791113151710112233445"),BigInteger.Parse("3579111315171011223344556"),BigInteger.Parse("357911131517101122334455667"),BigInteger.Parse("35791113151710112233445566778") };
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
public class A260586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260586Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260586.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260586Inst Instance=new A260586Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260587
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,5L,2L,4L,3L,1L,2L,3L,3L,6L,6L,4L,4L,4L,6L,2L,5L,3L,4L,8L,2L,6L,8L,2L,4L,9L,4L,9L,6L,6L,6L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260587Inst : IEnumerable<long>
{
public static readonly long[] Value=A260587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260587.Bytes);
public long this[int i]=>Value[i];

public static A260587Inst Instance=new A260587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260588
{
public static readonly long[] Value={ 0L,2L,4L,4L,4L,10L,4L,8L,8L,1L,2L,5L,3L,6L,7L,4L,5L,8L,6L,2L,6L,3L,4L,9L,2L,6L,11L,2L,4L,10L,4L,9L,8L,6L,6L,12L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260588Inst : IEnumerable<long>
{
public static readonly long[] Value=A260588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260588.Bytes);
public long this[int i]=>Value[i];

public static A260588Inst Instance=new A260588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260589
{
public static readonly BigInteger[] Value={ 11L,11L,3L,3L,37L,37L,11L,11L,101L,101L,41L,41L,271L,271L,3L,3L,7L,7L,11L,11L,13L,13L,37L,37L,239L,239L,4649L,4649L,11L,11L,73L,73L,101L,101L,137L,137L,3L,3L,3L,3L,37L,37L,333667L,333667L,12345678910987654321UL,7L,BigInteger.Parse("17636684157301569664903"),3L,3L,7L,7L,BigInteger.Parse("2799473675762179389994681"),1109L,4729L };
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
public class A260589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260589Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260589.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260589Inst Instance=new A260589Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260590
{
public static readonly long[] Value={ 4L,2L,7L,2L,5L,2L,7L,2L,4L,2L,5L,2L,59L,2L,56L,2L,4L,2L,8L,2L,5L,2L,54L,2L,4L,2L,5L,2L,7L,2L,54L,2L,4L,2L,51L,2L,5L,2L,8L,2L,4L,2L,5L,2L,45L,2L,8L,2L,4L,2L,42L,2L,5L,2L,31L,2L,4L,2L,5L,2L,8L,2L,15L,2L,4L,2L,7L,2L,5L,2L,7L,2L,4L,2L,5L,2L,40L,2L,21L,2L,4L,2L,29L,2L,5L,2L,8L,2L,4L,2L,5L,2L,7L,2L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260590Inst : IEnumerable<long>
{
public static readonly long[] Value=A260590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260590.Bytes);
public long this[int i]=>Value[i];

public static A260590Inst Instance=new A260590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260591
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,0L,3L,7L,0L,12L,0L,30L,85L,0L,173L,476L,0L,961L,0L,2652L,8045L,0L,17637L,51033L,0L,108950L,312455L,0L,663535L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260591Inst : IEnumerable<long>
{
public static readonly long[] Value=A260591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260591.Bytes);
public long this[int i]=>Value[i];

public static A260591Inst Instance=new A260591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260592
{
public static readonly BigInteger[] Value={ 1100L,10L,1110100L,10L,11010L,10L,1111000L,10L,1100L,10L,11100L,10L,BigInteger.Parse("11011111010110111011110100111011011111100111100010101000100"),10L,BigInteger.Parse("11111010110111011110100111011011111100111100010101000100"),10L,1100L,10L,11101100L,10L,11010L,10L };
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
public class A260592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260592Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260592.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260592Inst Instance=new A260592Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260593
{
public static readonly long[] Value={ 4L,2L,7L,5L,59L,56L,8L,54L,51L,45L,42L,31L,15L,40L,21L,29L,13L,12L,20L,27L,24L,10L,16L,18L,23L,39L,81L,35L,37L,26L,80L,34L,78L,43L,32L,61L,58L,50L,48L,46L,70L,65L,69L,53L,64L,77L,73L,72L,105L,75L,67L,83L,62L,92L,135L,126L,86L,111L,129L,124L,123L,127L,88L,119L,108L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260593Inst : IEnumerable<long>
{
public static readonly long[] Value=A260593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260593.Bytes);
public long this[int i]=>Value[i];

public static A260593Inst Instance=new A260593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260594
{
public static readonly long[] Value={ 1L,2L,3L,5L,13L,15L,19L,23L,35L,45L,51L,55L,63L,77L,79L,83L,95L,115L,119L,125L,141L,143L,179L,255L,319L,335L,351L,435L,463L,495L,527L,653L,791L,819L,847L,909L,1023L,1143L,1699L,1715L,2127L,2295L,3191L,3197L,3443L,3639L,3763L,3981L,5043L,6199L,6719L,7519L,8845L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260594Inst : IEnumerable<long>
{
public static readonly long[] Value=A260594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260594.Bytes);
public long this[int i]=>Value[i];

public static A260594Inst Instance=new A260594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260595
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260595Inst : IEnumerable<long>
{
public static readonly long[] Value=A260595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260595.Bytes);
public long this[int i]=>Value[i];

public static A260595Inst Instance=new A260595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260596
{
public static readonly long[] Value={ 1L,3L,2L,4L,10L,6L,5L,14L,38L,22L,7L,18L,54L,150L,86L,8L,26L,70L,214L,598L,342L,9L,30L,102L,278L,854L,2390L,1366L,11L,34L,118L,406L,1110L,3414L,9558L,5462L,12L,42L,134L,470L,1622L,4438L,13654L,38230L,21846L,13L,46L,166L,534L,1878L,6486L,17750L,54614L,152918L,87382L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260596Inst : IEnumerable<long>
{
public static readonly long[] Value=A260596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260596.Bytes);
public long this[int i]=>Value[i];

public static A260596Inst Instance=new A260596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260597
{
public static readonly BigInteger[] Value={ 11L,3L,37L,101L,41L,271L,7L,13L,239L,4649L,73L,137L,333667L,12345678910987654321UL,BigInteger.Parse("17636684157301569664903"),BigInteger.Parse("2799473675762179389994681"),1109L,4729L,BigInteger.Parse("2354041513534224607850261"),571L,3167L,10723L,439781L,2068140300159522133L,75401L,687437L,759077450603L };
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
public class A260597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260597Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260597.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260597Inst Instance=new A260597Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260598
{
public static readonly long[] Value={ 1L,510L,11235L,12243L,14223L,136374L,142494L,145266L,148614L,163158L,171465L,181815L,214863L,240963L,246507L,323976L,397182L,404994L,1548798L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260598Inst : IEnumerable<long>
{
public static readonly long[] Value=A260598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260598.Bytes);
public long this[int i]=>Value[i];

public static A260598Inst Instance=new A260598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260599
{
public static readonly long[] Value={ 1L,2L,3L,6L,10L,16L,25L,38L,55L,80L,115L,160L,223L,306L,415L,560L,747L,988L,1301L,1700L,2206L,2850L,3661L,4676L,5950L,7536L,9500L,11936L,14936L,18620L,23141L,28662L,35386L,43566L,53480L,65466L,79937L,97356L,118277L,143370L,173391L,209232L,251966L,302806L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260599Inst : IEnumerable<long>
{
public static readonly long[] Value=A260599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260599.Bytes);
public long this[int i]=>Value[i];

public static A260599Inst Instance=new A260599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260600
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,6L,9L,14L,20L,29L,42L,58L,80L,111L,149L,200L,268L,353L,463L,606L,784L,1011L,1299L,1656L,2104L,2664L,3354L,4208L,5264L,6555L,8138L,10076L,12428L,15288L,18758L,22944L,27996L,34081L,41377L,50124L,60592L,73075L,87951L,105652L,126652L,151547L,181015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260600Inst : IEnumerable<long>
{
public static readonly long[] Value=A260600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260600.Bytes);
public long this[int i]=>Value[i];

public static A260600Inst Instance=new A260600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260601
{
public static readonly BigInteger[] Value={ 40L,118L,610L,3388L,26148L,228678L,2707758L,34290074L,611554908L,11693188136L,307867992364L,8702002242846L,342462331784712L,14413275071964342L,841342111382685118L,BigInteger.Parse("52702190659812715690") };
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
public class A260601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260601Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260601.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260601Inst Instance=new A260601Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260602
{
public static readonly long[] Value={ 40L,58L,125L,241L,525L,1029L,2246L,4407L,9592L,18930L,41027L,81192L,175502L,348438L,750714L,1494859L,3211981L,6412772L,13742956L,27507848L,58807987L,117983491L,251666242L,506004675L,1077074116L,2169965427L,4609962160L,9305093538L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260602Inst : IEnumerable<long>
{
public static readonly long[] Value=A260602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260602.Bytes);
public long this[int i]=>Value[i];

public static A260602Inst Instance=new A260602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260603
{
public static readonly long[] Value={ 58L,118L,250L,532L,1136L,2480L,5418L,11776L,25694L,56138L,122376L,266782L,582226L,1270070L,2769414L,6041044L,13178442L,28742456L,62690698L,136748242L,298274638L,650578696L,1419055920L,3095272272L,6751343236L,14725993444L,32120472836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260603Inst : IEnumerable<long>
{
public static readonly long[] Value=A260603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260603.Bytes);
public long this[int i]=>Value[i];

public static A260603Inst Instance=new A260603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260604
{
public static readonly long[] Value={ 125L,250L,610L,1334L,3343L,7516L,19069L,42696L,108592L,244492L,620922L,1394188L,3543940L,7964144L,20236020L,45470332L,115549194L,259609220L,659718394L,1482402604L,3766971094L,8463829616L,21508165126L,48327274404L,122806995718L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260604Inst : IEnumerable<long>
{
public static readonly long[] Value=A260604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260604.Bytes);
public long this[int i]=>Value[i];

public static A260604Inst Instance=new A260604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260605
{
public static readonly long[] Value={ 241L,532L,1334L,3388L,8736L,22944L,59758L,156228L,410004L,1074706L,2810634L,7356614L,19275408L,50484816L,132179260L,346084882L,906235472L,2373216196L,6214897284L,16273805984L,42611987122L,111584761940L,292206789126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260605Inst : IEnumerable<long>
{
public static readonly long[] Value=A260605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260605.Bytes);
public long this[int i]=>Value[i];

public static A260605Inst Instance=new A260605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260606
{
public static readonly long[] Value={ 525L,1136L,3343L,8736L,26148L,70906L,217376L,587980L,1803868L,4887108L,15001422L,40649252L,124739782L,337833308L,1037043054L,2809741952L,8622275444L,23356067132L,71689360248L,194209294956L,596026346284L,1614617758884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260606Inst : IEnumerable<long>
{
public static readonly long[] Value=A260606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260606.Bytes);
public long this[int i]=>Value[i];

public static A260606Inst Instance=new A260606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260607
{
public static readonly long[] Value={ 1029L,2480L,7516L,22944L,70906L,228678L,727342L,2311370L,7375562L,23635422L,75483274L,240680882L,768878776L,2457889646L,7849301394L,25058672956L,80049377842L,255735233668L,816674565798L,2608176143032L,8331534566166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260607Inst : IEnumerable<long>
{
public static readonly long[] Value=A260607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260607.Bytes);
public long this[int i]=>Value[i];

public static A260607Inst Instance=new A260607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260608
{
public static readonly long[] Value={ 2246L,5418L,19069L,59758L,217376L,727342L,2707758L,8855024L,33286034L,110210856L,412748296L,1357891144L,5097313270L,16821243128L,63055195644L,207867167400L,779656269748L,2570612995104L,9639618875124L,31789508626272L,119214975682522L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260608Inst : IEnumerable<long>
{
public static readonly long[] Value=A260608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260608.Bytes);
public long this[int i]=>Value[i];

public static A260608Inst Instance=new A260608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260609
{
public static readonly long[] Value={ 40L,58L,58L,125L,118L,125L,241L,250L,250L,241L,525L,532L,610L,532L,525L,1029L,1136L,1334L,1334L,1136L,1029L,2246L,2480L,3343L,3388L,3343L,2480L,2246L,4407L,5418L,7516L,8736L,8736L,7516L,5418L,4407L,9592L,11776L,19069L,22944L,26148L,22944L,19069L,11776L,9592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260609Inst : IEnumerable<long>
{
public static readonly long[] Value=A260609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260609.Bytes);
public long this[int i]=>Value[i];

public static A260609Inst Instance=new A260609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260610
{
public static readonly BigInteger[] Value={ 1L,1L,2L,18L,1728L,4320000L,699840000000L,BigInteger.Parse("18525482136000000000"),BigInteger.Parse("204051433560311070720000000000"),BigInteger.Parse("2399547398533110254947300351672320000000000"),BigInteger.Parse("77759951835586717141477466390085274435584000000000000000000"),BigInteger.Parse("18011357710498321908881994832212360081640749122627567616000000000000000000000000") };
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
public class A260610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260610Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260610.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260610Inst Instance=new A260610Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260611
{
public static readonly long[] Value={ 1L,2L,3L,6L,1L,8L,13L,1L,1L,17L,1L,6L,9L,1L,46L,30L,58L,50L,1L,1L,27L,78L,82L,34L,22L,10L,102L,106L,76L,15L,126L,1L,37L,138L,105L,1L,28L,1L,1L,93L,1L,19L,190L,81L,14L,198L,210L,1L,1L,107L,144L,1L,64L,250L,16L,262L,82L,1L,60L,53L,282L,155L,306L,1L,288L,203L,330L,189L,1L,136L,42L,1L,366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260611Inst : IEnumerable<long>
{
public static readonly long[] Value=A260611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260611.Bytes);
public long this[int i]=>Value[i];

public static A260611Inst Instance=new A260611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260612
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,-1L,1L,2L,-1L,-2L,1L,-4L,-13L,4L,12L,1L,20L,-109L,-308L,108L,288L,1L,-100L,-2509L,12772L,37068L,-12672L,-34560L,1L,620L,-74509L,-1793708L,9232908L,26676288L,-9158400L,-24883200L,1L,-4420L,-3199309L,373731652L,9049521228L,-46507180032L,-134457649920L,46133452800L,125411328000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260612Inst : IEnumerable<long>
{
public static readonly long[] Value=A260612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260612.Bytes);
public long this[int i]=>Value[i];

public static A260612Inst Instance=new A260612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260613
{
public static readonly long[] Value={ 1L,1L,2L,1L,5L,6L,1L,10L,31L,30L,1L,17L,101L,247L,210L,1L,28L,288L,1358L,2927L,2310L,1L,41L,652L,5102L,20581L,40361L,30030L,1L,58L,1349L,16186L,107315L,390238L,716167L,510510L,1L,77L,2451L,41817L,414849L,2429223L,8130689L,14117683L,9699690L,1L,100L,4222L,98190L,1376640L,11970750L,64002818L,201123530L,334406399L,223092870L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260613Inst : IEnumerable<long>
{
public static readonly long[] Value=A260613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260613.Bytes);
public long this[int i]=>Value[i];

public static A260613Inst Instance=new A260613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260614
{
public static readonly BigInteger[] Value={ 1L,1L,4L,186624L,BigInteger.Parse("248907105618907424441185380787996852224") };
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
public class A260614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260614Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260614.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260614Inst Instance=new A260614Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260615
{
public static readonly long[] Value={ 0L,2L,0L,1L,5L,1L,30L,1L,5L,1L,2L,12L,1L,3L,1L,2L,1L,9L,1L,1L,7L,1L,2L,1L,9L,1L,2L,1L,2L,12L,7L,1L,2L,2L,13L,1L,1L,1L,8L,13L,5L,4L,1L,2L,5L,8L,1L,2L,6L,1L,1L,4L,10L,1L,2L,3L,1L,3L,1L,2L,238L,1L,28L,1L,42L,2L,2L,7L,1L,1L,4L,1L,1L,1L,6L,1L,41L,3L,1L,1L,51L,1L,9L,2L,3L,2L,5L,1L,2L,1L,6L,1L,1L,1L,3L,3L,3L,1L,1L,1L,3L,3L,1L,2L,19L,1L,13L,1L,1L,3L,4L,7L,1L,1L,3L,2L,1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260615Inst : IEnumerable<long>
{
public static readonly long[] Value=A260615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260615.Bytes);
public long this[int i]=>Value[i];

public static A260615Inst Instance=new A260615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260616
{
public static readonly long[] Value={ 1L,0L,2L,1L,0L,3L,0L,1L,2L,1L,0L,4L,0L,2L,0L,1L,3L,1L,0L,5L,0L,2L,2L,0L,1L,1L,2L,0L,1L,4L,1L,0L,6L,0L,3L,0L,2L,0L,1L,2L,0L,1L,5L,1L,0L,7L,0L,3L,2L,0L,2L,3L,0L,1L,1L,3L,0L,1L,2L,2L,0L,1L,6L,1L,0L,8L,0L,4L,0L,2L,1L,2L,0L,2L,0L,1L,1L,1L,2L,0L,1L,3L,0L,1L,7L,1L,0L,9L,0L,4L,2L,0L,3L,0L,2L,4L,0L,1L,1L,4L,0L,1L,2L,0L,1L,3L,2L,0L,1L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260616Inst : IEnumerable<long>
{
public static readonly long[] Value=A260616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260616.Bytes);
public long this[int i]=>Value[i];

public static A260616Inst Instance=new A260616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260617
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,2L,3L,2L,3L,2L,3L,4L,3L,4L,3L,4L,5L,2L,3L,4L,3L,4L,5L,4L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260617Inst : IEnumerable<long>
{
public static readonly long[] Value=A260617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260617.Bytes);
public long this[int i]=>Value[i];

public static A260617Inst Instance=new A260617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260618
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,6L,1L,4L,2L,2L,4L,1L,5L,3L,15L,2L,10L,2L,4L,20L,1L,6L,3L,2L,2L,6L,2L,3L,1L,7L,4L,28L,3L,11L,231L,2L,14L,2L,5L,70L,2L,3L,42L,1L,8L,4L,3L,24L,2L,2L,8L,2L,4L,2L,3L,24L,1L,9L,5L,45L,3L,3L,9L,2L,18L,2L,6L,2L,4L,36L,2L,3L,18L,1L,10L,5L,4L,20L,3L,15L,2L,2L,10L,2L,5L,2L,4L,20L,2L,3L,15L,1L,11L,6L,66L,4L,44L,3L,33L,3L,9L,99L,2L,22L,2L,8L,88L,2L,5L,37L,4070L,2L,4L,15L,660L,2L,3L,14L,231L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260618Inst : IEnumerable<long>
{
public static readonly long[] Value=A260618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260618.Bytes);
public long this[int i]=>Value[i];

public static A260618Inst Instance=new A260618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260619
{
public static readonly BigInteger[] Value={ 0L,0L,4L,216L,165888L,604800000L,48372940800000L,BigInteger.Parse("43156963184025600000"),BigInteger.Parse("1392410948543163924480000000"),BigInteger.Parse("668916177911197542484208831692800000"),BigInteger.Parse("8199617664717905359483850194944000000000000000"),BigInteger.Parse("2401010998878767104110478543683244630474752000000000000000") };
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
public class A260619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260619Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260619.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260619Inst Instance=new A260619Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260620
{
public static readonly BigInteger[] Value={ 0L,0L,1L,16L,912L,179712L,200724480L,1389079756800L,78810485096448000L,BigInteger.Parse("38096713995308236800000"),BigInteger.Parse("177372596340389981454336000000"),BigInteger.Parse("8666143442523657424202209689600000000"),BigInteger.Parse("5080543621153782266150614213475696640000000000") };
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
public class A260620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260620Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260620.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260620Inst Instance=new A260620Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260621
{
public static readonly long[] Value={ 1L,1L,12L,2L,1L,1L,3L,11L,1L,1L,7L,9L,1L,2L,10L,4L,2L,1L,1L,6L,8L,3L,3L,1L,9L,3L,1L,1L,18L,3L,1L,5L,7L,2L,2L,1L,4L,8L,2L,14L,1L,1L,6L,17L,2L,6L,1L,4L,6L,1L,1L,2L,2L,3L,7L,1L,13L,6L,1L,4L,16L,5L,16L,1L,5L,31L,35L,3L,5L,2L,1L,2L,3L,1L,1L,2L,6L,1L,1L,12L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260621Inst : IEnumerable<long>
{
public static readonly long[] Value=A260621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260621.Bytes);
public long this[int i]=>Value[i];

public static A260621Inst Instance=new A260621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260622
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,72L,744L,10416L,270816L,9906624L,614210688L,55278961920L,8354817757440L,1955027355240960L,766650012876633600L,BigInteger.Parse("478623425047744204800"),BigInteger.Parse("492420437498707277414400"),BigInteger.Parse("786887859122934229308211200"),BigInteger.Parse("2148247421904894243053912064000") };
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
public class A260622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260622Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260622.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260622Inst Instance=new A260622Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260623
{
public static readonly long[] Value={ 1L,4L,2L,5L,7L,1L,0L,4L,1L,1L,6L,1L,3L,1L,8L,1L,6L,5L,1L,7L,8L,2L,3L,6L,8L,3L,6L,7L,5L,4L,8L,5L,5L,0L,5L,6L,9L,3L,3L,9L,1L,8L,6L,2L,0L,5L,3L,4L,6L,2L,4L,7L,3L,5L,9L,4L,9L,4L,9L,4L,7L,6L,7L,4L,3L,6L,6L,8L,7L,3L,0L,4L,5L,6L,7L,5L,6L,1L,7L,5L,0L,1L,6L,7L,7L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260623Inst : IEnumerable<long>
{
public static readonly long[] Value=A260623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260623.Bytes);
public long this[int i]=>Value[i];

public static A260623Inst Instance=new A260623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260624
{
public static readonly long[] Value={ 4L,5L,12L,6L,7L,16L,9L,8L,32L,21L,24L,10L,13L,44L,10L,15L,27L,32L,31L,80L,14L,19L,12L,60L,21L,16L,68L,41L,48L,39L,25L,112L,14L,45L,20L,56L,81L,16L,92L,22L,31L,92L,33L,51L,192L,18L,61L,72L,26L,59L,156L,39L,55L,80L,18L,71L,176L,108L,43L,124L,22L,45L,32L,140L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260624Inst : IEnumerable<long>
{
public static readonly long[] Value=A260624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260624.Bytes);
public long this[int i]=>Value[i];

public static A260624Inst Instance=new A260624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260625
{
public static readonly long[] Value={ 1L,2L,1L,1L,4L,4L,1L,2L,4L,5L,3L,1L,4L,7L,2L,1L,7L,6L,5L,6L,6L,5L,4L,4L,6L,11L,4L,3L,10L,7L,2L,2L,7L,7L,8L,4L,4L,10L,1L,5L,13L,7L,3L,5L,10L,6L,1L,1L,8L,13L,7L,5L,10L,13L,5L,7L,7L,6L,9L,3L,10L,13L,3L,1L,15L,13L,5L,10L,12L,8L,3L,6L,8L,16L,8L,8L,14L,8L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260625Inst : IEnumerable<long>
{
public static readonly long[] Value=A260625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260625.Bytes);
public long this[int i]=>Value[i];

public static A260625Inst Instance=new A260625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260626
{
public static readonly long[] Value={ 1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,9L,5L,7L,1L,3L,1L,1L,1L,1L,3L,1L,1L,1L,1L,9L,1L,1L,5L,21L,1L,1L,1L,3L,1L,1L,1L,1L,27L,1L,1L,1L,1L,15L,1L,7L,1L,1L,3L,1L,1L,1L,9L,1L,1L,1L,1L,3L,5L,1L,1L,21L,1L,1L,1L,1L,9L,1L,1L,1L,1L,1L,3L,1L,1L,25L,3L,1L,7L,1L,27L,11L,1L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260626Inst : IEnumerable<long>
{
public static readonly long[] Value=A260626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260626.Bytes);
public long this[int i]=>Value[i];

public static A260626Inst Instance=new A260626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260627
{
public static readonly long[] Value={ 8L,96L,997L,9997L,99997L,999997L,9999997L,99999992L,999999998L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260627Inst : IEnumerable<long>
{
public static readonly long[] Value=A260627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260627.Bytes);
public long this[int i]=>Value[i];

public static A260627Inst Instance=new A260627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260628
{
public static readonly long[] Value={ 0L,7L,8L,12L,13L,18L,22L,24L,29L,31L,36L,47L,52L,54L,55L,56L,57L,60L,61L,63L,66L,68L,72L,73L,76L,77L,85L,87L,90L,91L,96L,103L,106L,107L,108L,114L,123L,124L,125L,126L,131L,135L,140L,143L,144L,149L,150L,154L,156L,157L,158L,161L,162L,163L,166L,167L,168L,175L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260628Inst : IEnumerable<long>
{
public static readonly long[] Value=A260628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260628.Bytes);
public long this[int i]=>Value[i];

public static A260628Inst Instance=new A260628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260629
{
public static readonly long[] Value={ 3L,1L,5L,4L,4L,2L,8L,0L,7L,0L,0L,1L,9L,7L,5L,4L,3L,9L,6L,0L,5L,4L,6L,3L,0L,3L,1L,1L,7L,4L,0L,5L,7L,0L,7L,8L,9L,0L,5L,5L,1L,2L,5L,4L,7L,9L,8L,2L,8L,1L,3L,8L,4L,6L,6L,9L,3L,9L,9L,8L,3L,1L,3L,8L,8L,0L,3L,3L,0L,4L,0L,3L,3L,2L,2L,3L,6L,6L,8L,7L,3L,3L,9L,4L,9L,3L,4L,9L,3L,0L,7L,7L,8L,6L,9L,3L,0L,8L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260629Inst : IEnumerable<long>
{
public static readonly long[] Value=A260629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260629.Bytes);
public long this[int i]=>Value[i];

public static A260629Inst Instance=new A260629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260630
{
public static readonly long[] Value={ -1L,1L,5L,59L,449L,1417L,16127L,429697L,437705L,7549093L,145103527L,146489197L,3396112211L,2442184933L,7369048679L,429556076057L,13374954901367L,13427048535167L,94315062045929L,3500487562166393L,3510273150915593L,144285489968702713L,6218562602767668259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260630Inst : IEnumerable<long>
{
public static readonly long[] Value=A260630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260630.Bytes);
public long this[int i]=>Value[i];

public static A260630Inst Instance=new A260630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260631
{
public static readonly long[] Value={ 1L,2L,3L,12L,30L,30L,105L,840L,252L,1260L,6930L,1980L,12870L,2574L,2145L,34320L,291720L,79560L,151164L,1511640L,406980L,4476780L,51482970L,13728792L,171609900L,318704100L,84362850L,1181079900L,311375610L,81940950L,1270084725L,40642711200L,10644519600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260631Inst : IEnumerable<long>
{
public static readonly long[] Value=A260631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260631.Bytes);
public long this[int i]=>Value[i];

public static A260631Inst Instance=new A260631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260632
{
public static readonly long[] Value={ 0L,6L,1L,7L,4L,4L,6L,8L,7L,9L,0L,8L,0L,6L,0L,7L,0L,6L,7L,3L,5L,9L,1L,0L,2L,2L,9L,1L,2L,2L,6L,2L,3L,6L,0L,5L,9L,2L,8L,3L,7L,9L,5L,3L,1L,4L,9L,9L,0L,6L,3L,6L,7L,1L,5L,2L,0L,7L,9L,3L,3L,9L,2L,8L,1L,7L,1L,8L,9L,6L,4L,7L,7L,1L,8L,3L,2L,3L,1L,6L,3L,4L,7L,8L,2L,8L,5L,3L,4L,1L,4L,8L,4L,8L,2L,5L,7L,1L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260632Inst : IEnumerable<long>
{
public static readonly long[] Value=A260632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260632.Bytes);
public long this[int i]=>Value[i];

public static A260632Inst Instance=new A260632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260633
{
public static readonly long[] Value={ 1L,6L,12L,24L,30L,60L,120L,180L,360L,720L,840L,1080L,1260L,1680L,2160L,2520L,4320L,5040L,7560L,10080L,12600L,15120L,25200L,30240L,45360L,50400L,60480L,75600L,90720L,110880L,120960L,151200L,226800L,277200L,302400L,453600L,604800L,665280L,831600L,907200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260633Inst : IEnumerable<long>
{
public static readonly long[] Value=A260633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260633.Bytes);
public long this[int i]=>Value[i];

public static A260633Inst Instance=new A260633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260634
{
public static readonly long[] Value={ 7L,7L,8L,8L,0L,2L,3L,3L,6L,4L,8L,3L,8L,8L,1L,1L,5L,1L,0L,7L,0L,2L,0L,8L,3L,4L,7L,7L,8L,5L,9L,7L,6L,5L,9L,7L,9L,6L,3L,2L,1L,8L,9L,8L,7L,6L,9L,2L,0L,0L,5L,0L,8L,7L,4L,6L,4L,0L,5L,9L,1L,9L,9L,8L,3L,1L,4L,9L,0L,0L,1L,4L,6L,7L,7L,8L,4L,4L,2L,1L,4L,4L,7L,8L,0L,5L,7L,7L,5L,1L,9L,1L,7L,0L,3L,8L,4L,3L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260634Inst : IEnumerable<long>
{
public static readonly long[] Value=A260634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260634.Bytes);
public long this[int i]=>Value[i];

public static A260634Inst Instance=new A260634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260635
{
public static readonly long[] Value={ 1L,5L,6L,9L,9L,2L,5L,4L,5L,3L,0L,8L,8L,6L,5L,9L,0L,7L,5L,7L,8L,4L,5L,9L,1L,9L,8L,8L,3L,2L,6L,4L,8L,9L,1L,3L,1L,3L,9L,1L,4L,1L,4L,7L,4L,6L,4L,4L,7L,2L,6L,4L,5L,9L,4L,6L,9L,0L,5L,9L,7L,1L,1L,8L,6L,3L,3L,7L,8L,4L,6L,5L,2L,5L,5L,2L,3L,0L,1L,7L,9L,4L,4L,9L,0L,8L,4L,1L,8L,9L,6L,2L,6L,0L,5L,3L,0L,7L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260635Inst : IEnumerable<long>
{
public static readonly long[] Value=A260635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260635.Bytes);
public long this[int i]=>Value[i];

public static A260635Inst Instance=new A260635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260636
{
public static readonly long[] Value={ 0L,1L,0L,3L,3L,0L,3L,7L,3L,5L,3L,0L,3L,8L,9L,15L,3L,15L,3L,15L,0L,4L,3L,12L,3L,2L,3L,12L,3L,24L,3L,15L,18L,15L,0L,9L,3L,34L,6L,31L,3L,21L,3L,0L,15L,38L,3L,36L,3L,40L,33L,40L,3L,42L,0L,16L,27L,44L,3L,0L,3L,46L,45L,47L,39L,51L,3L,53L,15L,0L,3L,45L,3L,15L,9L,20L,76L,0L,3L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260636Inst : IEnumerable<long>
{
public static readonly long[] Value=A260636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260636.Bytes);
public long this[int i]=>Value[i];

public static A260636Inst Instance=new A260636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260637
{
public static readonly long[] Value={ 28L,35L,56L,91L,140L,203L,280L,371L,476L,595L,728L,875L,1036L,1211L,1400L,1603L,1820L,2051L,2296L,2555L,2828L,3115L,3416L,3731L,4060L,4403L,4760L,5131L,5516L,5915L,6328L,6755L,7196L,7651L,8120L,8603L,9100L,9611L,10136L,10675L,11228L,11795L,12376L,12971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260637Inst : IEnumerable<long>
{
public static readonly long[] Value=A260637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260637.Bytes);
public long this[int i]=>Value[i];

public static A260637Inst Instance=new A260637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260638
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,1L,1L,3L,7L,1L,7L,35L,1L,1L,1L,1L,1L,3L,7L,15L,1L,7L,35L,155L,1L,15L,155L,1395L,1L,1L,1L,1L,1L,1L,3L,7L,15L,31L,1L,7L,35L,155L,651L,1L,15L,155L,1395L,11811L,1L,31L,651L,11811L,200787L,1L,1L,1L,1L,1L,1L,1L,3L,7L,15L,31L,63L,1L,7L,35L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260638Inst : IEnumerable<long>
{
public static readonly long[] Value=A260638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260638.Bytes);
public long this[int i]=>Value[i];

public static A260638Inst Instance=new A260638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260639
{
public static readonly BigInteger[] Value={ 1L,4L,206L,433284L,131782705528L,BigInteger.Parse("21826979750768842816"),BigInteger.Parse("7637711141088259236341772556400"),BigInteger.Parse("22237835372502772582455643527946875785037270496"),BigInteger.Parse("2138255561398515897400115384129197209090292453675665760256378885504") };
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
public class A260639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260639Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260639.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260639Inst Instance=new A260639Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260640
{
public static readonly long[] Value={ 1L,3L,6L,12L,21L,35L,44L,55L,60L,70L,78L,88L,90L,99L,102L,110L,117L,119L,120L,133L,156L,171L,176L,180L,184L,204L,207L,220L,225L,230L,231L,234L,238L,240L,247L,252L,255L,285L,286L,300L,312L,341L,342L,348L,360L,368L,372L,391L,403L,408L,414L,425L,434L,460L,462L,465L,468L,481L,483L,494L,495L,504L,506L,510L,550L,555L,561L,572L,574L,585L,600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260640Inst : IEnumerable<long>
{
public static readonly long[] Value=A260640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260640.Bytes);
public long this[int i]=>Value[i];

public static A260640Inst Instance=new A260640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260641
{
public static readonly long[] Value={ 2L,3L,7L,9L,12L,13L,17L,23L,25L,26L,31L,33L,37L,41L,44L,45L,46L,48L,49L,55L,56L,57L,61L,65L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260641Inst : IEnumerable<long>
{
public static readonly long[] Value=A260641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260641.Bytes);
public long this[int i]=>Value[i];

public static A260641Inst Instance=new A260641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260642
{
public static readonly long[] Value={ 3L,7L,127L,511L,4095L,8191L,131071L,8388607L,33554431L,67108863L,2147483647L,8589934591L,137438953471L,2199023255551L,17592186044415L,35184372088831L,70368744177663L,281474976710655L,562949953421311L,36028797018963967L,72057594037927935L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260642Inst : IEnumerable<long>
{
public static readonly long[] Value=A260642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260642.Bytes);
public long this[int i]=>Value[i];

public static A260642Inst Instance=new A260642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260643
{
public static readonly long[] Value={ 1L,2L,3L,4L,2L,5L,3L,6L,7L,1L,8L,7L,4L,8L,5L,6L,4L,9L,7L,10L,1L,9L,8L,11L,3L,12L,11L,10L,12L,13L,1L,12L,14L,9L,10L,14L,1L,15L,6L,13L,2L,16L,3L,17L,11L,13L,5L,14L,2L,11L,6L,14L,13L,9L,15L,18L,2L,19L,5L,15L,16L,4L,17L,20L,2L,21L,3L,18L,16L,17L,5L,20L,4L,19L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260643Inst : IEnumerable<long>
{
public static readonly long[] Value=A260643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260643.Bytes);
public long this[int i]=>Value[i];

public static A260643Inst Instance=new A260643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260644
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,3L,2L,1L,2L,3L,4L,5L,4L,3L,2L,3L,4L,5L,6L,5L,4L,3L,4L,5L,6L,7L,6L,5L,4L,5L,6L,7L,8L,7L,6L,5L,6L,7L,8L,9L,8L,7L,6L,7L,8L,9L,10L,9L,8L,7L,8L,9L,10L,11L,10L,9L,8L,9L,10L,11L,12L,11L,10L,9L,10L,11L,12L,13L,12L,11L,10L,11L,12L,13L,14L,13L,12L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260644Inst : IEnumerable<long>
{
public static readonly long[] Value=A260644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260644.Bytes);
public long this[int i]=>Value[i];

public static A260644Inst Instance=new A260644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260645
{
public static readonly long[] Value={ 1L,1L,5L,19L,19L,5L,41L,385L,231L,19L,109L,95L,155L,41L,95L,41387L,271L,231L,341L,361L,205L,109L,505L,1925L,3337L,155L,36118L,779L,811L,95L,929L,19823665L,545L,271L,779L,4389L,1331L,341L,775L,7315L,1639L,205L,1805L,2071L,4389L,505L,2161L,206935L,18099L,3337L,1355L,2945L,2755L,36118L,2071L,15785L,1705L,811L,3421L,1805L,3659L,929L,9471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260645Inst : IEnumerable<long>
{
public static readonly long[] Value=A260645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260645.Bytes);
public long this[int i]=>Value[i];

public static A260645Inst Instance=new A260645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260646
{
public static readonly long[] Value={ 0L,0L,1L,9L,2L,9L,5L,7L,4L,3L,0L,9L,4L,0L,3L,9L,2L,3L,0L,4L,7L,9L,0L,3L,3L,4L,5L,5L,6L,3L,6L,8L,5L,9L,5L,7L,6L,4L,0L,1L,6L,8L,4L,7L,1L,8L,1L,5L,0L,0L,0L,3L,0L,3L,3L,5L,2L,2L,3L,4L,6L,4L,7L,6L,1L,7L,3L,3L,1L,4L,9L,5L,6L,3L,4L,2L,5L,0L,9L,8L,5L,5L,3L,1L,4L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260646Inst : IEnumerable<long>
{
public static readonly long[] Value=A260646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260646.Bytes);
public long this[int i]=>Value[i];

public static A260646Inst Instance=new A260646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260647
{
public static readonly long[] Value={ 4L,7L,9L,11L,13L,16L,18L,21L,22L,24L,25L,27L,29L,31L,34L,36L,37L,38L,39L,42L,43L,46L,48L,49L,51L,55L,56L,57L,58L,60L,61L,64L,65L,66L,67L,69L,70L,72L,73L,76L,79L,81L,83L,84L,87L,88L,91L,92L,93L,94L,97L,99L,100L,101L,102L,106L,108L,111L,112L,114L,115L,119L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260647Inst : IEnumerable<long>
{
public static readonly long[] Value=A260647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260647.Bytes);
public long this[int i]=>Value[i];

public static A260647Inst Instance=new A260647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260648
{
public static readonly long[] Value={ 1L,2L,0L,1L,2L,1L,1L,2L,0L,1L,1L,2L,1L,0L,1L,1L,1L,1L,2L,0L,1L,2L,2L,0L,1L,2L,0L,1L,1L,1L,1L,0L,1L,1L,2L,1L,0L,2L,1L,2L,1L,0L,1L,1L,0L,2L,2L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,0L,1L,1L,2L,1L,1L,1L,0L,2L,1L,1L,1L,2L,0L,0L,2L,0L,1L,1L,2L,1L,0L,1L,2L,1L,1L,1L,1L,1L,1L,2L,0L,1L,1L,1L,1L,1L,0L,0L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260648Inst : IEnumerable<long>
{
public static readonly long[] Value=A260648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260648.Bytes);
public long this[int i]=>Value[i];

public static A260648Inst Instance=new A260648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260649
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,0L,0L,2L,1L,0L,0L,1L,0L,0L,1L,3L,2L,0L,2L,1L,0L,0L,2L,2L,1L,0L,1L,0L,0L,0L,2L,4L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,0L,1L,0L,2L,3L,1L,0L,2L,0L,2L,0L,0L,0L,2L,0L,0L,1L,2L,0L,0L,5L,0L,0L,0L,2L,2L,0L,0L,2L,0L,0L,1L,2L,0L,0L,2L,3L,1L,0L,2L,0L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260649Inst : IEnumerable<long>
{
public static readonly long[] Value=A260649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260649.Bytes);
public long this[int i]=>Value[i];

public static A260649Inst Instance=new A260649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260650
{
public static readonly long[] Value={ 1L,4L,18L,88L,455L,2444L,13486L,75912L,433935L,2511388L,14684422L,86611848L,514704064L,3078845696L,18523994024L,112026315616L,680626958899L,4152411174284L,25428402204982L,156247439709832L,963048223399984L,5952595420121536L,36887847899094888L,229132114803540320L,1426367728966653535L,8897049258366111004L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260650Inst : IEnumerable<long>
{
public static readonly long[] Value=A260650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260650.Bytes);
public long this[int i]=>Value[i];

public static A260650Inst Instance=new A260650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260651
{
public static readonly long[] Value={ 2L,2L,3L,3L,4L,2L,2L,3L,4L,5L,2L,3L,3L,4L,3L,5L,2L,2L,2L,3L,2L,3L,4L,2L,4L,4L,3L,2L,3L,2L,4L,2L,6L,3L,3L,3L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260651Inst : IEnumerable<long>
{
public static readonly long[] Value=A260651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260651.Bytes);
public long this[int i]=>Value[i];

public static A260651Inst Instance=new A260651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260652
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,8L,12L,14L,18L,20L,24L,30L,32L,36L,38L,42L,48L,50L,56L,60L,62L,68L,72L,78L,84L,86L,90L,94L,98L,102L,108L,114L,120L,126L,130L,136L,140L,146L,150L,156L,158L,162L,168L,174L,180L,182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260652Inst : IEnumerable<long>
{
public static readonly long[] Value=A260652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260652.Bytes);
public long this[int i]=>Value[i];

public static A260652Inst Instance=new A260652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260653
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,12L,15L,16L,18L,20L,24L,30L,32L,36L,40L,42L,48L,54L,56L,60L,64L,72L,80L,84L,90L,96L,100L,105L,108L,112L,120L,126L,128L,132L,140L,144L,150L,156L,160L,162L,165L,168L,176L,180L,192L,195L,198L,200L,208L,210L,216L,220L,224L,234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260653Inst : IEnumerable<long>
{
public static readonly long[] Value=A260653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260653.Bytes);
public long this[int i]=>Value[i];

public static A260653Inst Instance=new A260653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260654
{
public static readonly long[] Value={ 1L,2L,5L,56L,59L,60L,75L,122L,743L,2835L,3951L,5712L,6866L,7884L,14754L,18751L,215002L,521775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260654Inst : IEnumerable<long>
{
public static readonly long[] Value=A260654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260654.Bytes);
public long this[int i]=>Value[i];

public static A260654Inst Instance=new A260654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260655
{
public static readonly BigInteger[] Value={ 1L,18L,405L,10206L,275562L,7794468L,227988189L,6839645670L,209293157502L,6507114533244L,204974107797186L,6527636971387308L,209816902651734900L,6798067645916210760L,BigInteger.Parse("221786956948016376045"),BigInteger.Parse("7279830704529008107830"),BigInteger.Parse("240234413249457267558390"),BigInteger.Parse("7965667386692530450620300") };
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
public class A260655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260655Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260655.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260655Inst Instance=new A260655Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260656
{
public static readonly BigInteger[] Value={ 1L,2L,18L,396L,104940L,10808820L,160327227060L,486432806900040L,BigInteger.Parse("72152091814676033160"),BigInteger.Parse("105952244289903723626034120"),BigInteger.Parse("1697305261921685687642685992397720"),BigInteger.Parse("108004858262683508632706244802225075247640"),BigInteger.Parse("266448824855803491635798907952730108331437779905720") };
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
public class A260656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260656Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260656.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260656Inst Instance=new A260656Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260657
{
public static readonly BigInteger[] Value={ 1L,0L,0L,0L,0L,2L,10L,60L,418L,3343L,30104L,301175L,3314114L,39781325L,517289459L,7243645801L,108675472777L,1739099429899L,29569079533691L,532313816538037L,10115161415506606L,202324846199795597L,4249233149373416698L,BigInteger.Parse("93491368355657653179"),BigInteger.Parse("2150474710445177712523") };
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
public class A260657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260657Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260657.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260657Inst Instance=new A260657Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260658
{
public static readonly long[] Value={ 5L,-7L,23L,-1L,41L,-25L,59L,-17L,77L,-43L,95L,-13L,113L,-61L,131L,-35L,149L,-79L,167L,-11L,185L,-97L,203L,-53L,221L,-115L,239L,-31L,257L,-133L,275L,-71L,293L,-151L,311L,-5L,329L,-169L,347L,-89L,365L,-187L,383L,-49L,401L,-205L,419L,-107L,437L,-223L,455L,-29L,473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260658Inst : IEnumerable<long>
{
public static readonly long[] Value=A260658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260658.Bytes);
public long this[int i]=>Value[i];

public static A260658Inst Instance=new A260658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260659
{
public static readonly BigInteger[] Value={ 2L,80L,3584L,1760L,745472L,4456448L,99614720L,265289728L,10905190400L,54492397568L,1065151889408L,1277752770560L,96619584290816L,450799767388160L,8321103999008768L,19017153114013696L,689613692941107200L,3102980143258271744L,BigInteger.Parse("55484347409204510720"),BigInteger.Parse("30822635849723674624") };
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
public class A260659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260659Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260659.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260659Inst Instance=new A260659Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260660
{
public static readonly long[] Value={ 0L,6L,3L,7L,4L,9L,8L,7L,3L,7L,4L,4L,5L,7L,6L,8L,8L,0L,2L,8L,6L,0L,3L,8L,6L,8L,1L,4L,7L,3L,3L,3L,5L,0L,5L,5L,6L,4L,8L,8L,2L,7L,3L,5L,5L,3L,1L,2L,7L,5L,8L,4L,9L,1L,3L,8L,5L,1L,0L,0L,8L,8L,5L,8L,8L,7L,7L,3L,7L,0L,6L,4L,2L,0L,1L,5L,6L,6L,6L,8L,7L,0L,9L,4L,7L,0L,9L,2L,6L,7L,8L,1L,5L,3L,5L,8L,2L,6L,3L,1L,8L,7L,8L,2L,4L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260660Inst : IEnumerable<long>
{
public static readonly long[] Value=A260660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260660.Bytes);
public long this[int i]=>Value[i];

public static A260660Inst Instance=new A260660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260661
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,1L,3L,8L,22L,68L,235L,896L,3700L,16388L,77424L,388337L,2058898L,11494391L,67345463L,412884769L,2641957682L,17603708949L,121891857559L,875463364581L,6511352351724L,50074591410942L,397627804820554L,3256109939552809L,27464891261741533L,238366531369343096L,2126510299723649140L,BigInteger.Parse("19482346640311421722"),BigInteger.Parse("183143139819128271540"),BigInteger.Parse("1765079515780983078401") };
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
public class A260661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260661Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260661.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260661Inst Instance=new A260661Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260662
{
public static readonly long[] Value={ 1L,2L,2L,2L,9L,4L,4L,2L,5L,1L,8L,0L,8L,1L,3L,3L,8L,7L,2L,6L,4L,7L,8L,9L,9L,9L,6L,0L,7L,2L,7L,7L,1L,7L,9L,8L,8L,5L,6L,1L,2L,6L,5L,8L,0L,3L,1L,2L,9L,5L,3L,2L,9L,5L,0L,1L,0L,8L,3L,7L,2L,8L,1L,0L,3L,4L,4L,6L,0L,6L,4L,2L,2L,7L,6L,8L,6L,6L,2L,0L,3L,0L,3L,0L,0L,1L,2L,6L,4L,2L,6L,9L,2L,1L,7L,5L,1L,1L,4L,2L,6L,1L,2L,4L,4L,9L,1L,8L,3L,6L,0L,0L,2L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260662Inst : IEnumerable<long>
{
public static readonly long[] Value=A260662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260662.Bytes);
public long this[int i]=>Value[i];

public static A260662Inst Instance=new A260662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260663
{
public static readonly long[] Value={ 2L,0L,1L,2L,6L,1L,2L,7L,2L,5L,1L,6L,5L,6L,9L,3L,8L,0L,8L,6L,0L,2L,2L,2L,4L,6L,4L,7L,8L,7L,8L,1L,1L,2L,0L,5L,4L,9L,7L,4L,3L,3L,7L,9L,0L,9L,4L,8L,3L,8L,7L,7L,6L,9L,7L,6L,1L,1L,6L,0L,2L,6L,0L,3L,7L,3L,4L,0L,9L,1L,9L,6L,9L,4L,4L,6L,9L,4L,4L,5L,9L,1L,6L,6L,4L,3L,6L,9L,9L,3L,3L,3L,0L,9L,0L,2L,8L,8L,3L,0L,7L,3L,3L,2L,1L,8L,8L,5L,7L,5L,3L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260663Inst : IEnumerable<long>
{
public static readonly long[] Value=A260663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260663.Bytes);
public long this[int i]=>Value[i];

public static A260663Inst Instance=new A260663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260664
{
public static readonly long[] Value={ 1L,0L,6L,18L,90L,192L,864L,1710L,5970L,13110L,36810L,75984L,210546L,410130L,1003908L,2045808L,4616730L,8950176L,19746720L,37297710L,78247344L,147410640L,294299424L,543058032L,1067679540L,1925323308L,3653769792L,6555529158L,12129597486L,21348640230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260664Inst : IEnumerable<long>
{
public static readonly long[] Value=A260664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260664.Bytes);
public long this[int i]=>Value[i];

public static A260664Inst Instance=new A260664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260665
{
public static readonly long[] Value={ 1L,1L,2L,5L,1L,15L,7L,1L,1L,52L,39L,13L,12L,2L,1L,1L,203L,211L,112L,103L,41L,24L,17L,5L,2L,1L,1L,877L,1168L,843L,811L,492L,337L,238L,122L,68L,39L,28L,8L,5L,2L,1L,1L,4140L,6728L,6089L,6273L,4851L,3798L,2956L,1960L,1303L,859L,594L,314L,204L,110L,64L,43L,17L,8L,5L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260665Inst : IEnumerable<long>
{
public static readonly long[] Value=A260665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260665.Bytes);
public long this[int i]=>Value[i];

public static A260665Inst Instance=new A260665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260666
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,3L,6L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260666Inst : IEnumerable<long>
{
public static readonly long[] Value=A260666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260666.Bytes);
public long this[int i]=>Value[i];

public static A260666Inst Instance=new A260666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260667
{
public static readonly BigInteger[] Value={ 1L,37L,1737L,102501L,6979833L,523680739L,42129659113L,3572184623653L,315561396741609L,28807571694394593L,2701627814373536601L,BigInteger.Parse("259121323945378645947"),BigInteger.Parse("25330657454041707496017"),BigInteger.Parse("2516984276442279642274311"),BigInteger.Parse("253667099464270541534450025"),BigInteger.Parse("25884030861250181046253181349"),BigInteger.Parse("2670255662315910532447096232073") };
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
public class A260667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260667Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260667.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260667Inst Instance=new A260667Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260668
{
public static readonly long[] Value={ 1L,2L,4L,7L,13L,24L,45L,84L,158L,298L,566L,1079L,2066L,3966L,7635L,14730L,28484L,55188L,107130L,208294L,405594L,790812L,1543766L,3016923L,5901858L,11556244L,22647431L,44418613L,87182680L,171234318L,336532357L,661788956L,1302124526L,2563365624L,5048704640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260668Inst : IEnumerable<long>
{
public static readonly long[] Value=A260668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260668.Bytes);
public long this[int i]=>Value[i];

public static A260668Inst Instance=new A260668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260669
{
public static readonly long[] Value={ 0L,1L,2L,6L,8L,24L,30L,74L,110L,219L,309L,651L,870L,1608L,2394L,4085L,5756L,9931L,13785L,22724L,32300L,50404L,70862L,111540L,153756L,232868L,326259L,484090L,667015L,986082L,1345566L,1951216L,2673588L,3805742L,5179213L,7348514L,9895254L,13845750L,18681896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260669Inst : IEnumerable<long>
{
public static readonly long[] Value=A260669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260669.Bytes);
public long this[int i]=>Value[i];

public static A260669Inst Instance=new A260669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260670
{
public static readonly long[] Value={ 1L,1L,2L,5L,1L,15L,6L,3L,52L,32L,23L,10L,3L,203L,171L,152L,98L,62L,22L,11L,1L,877L,944L,984L,791L,624L,392L,240L,111L,55L,18L,4L,4140L,5444L,6460L,6082L,5513L,4302L,3328L,2141L,1393L,780L,432L,187L,88L,24L,6L,21147L,32919L,43626L,46508L,46880L,41979L,36774L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260670Inst : IEnumerable<long>
{
public static readonly long[] Value=A260670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260670.Bytes);
public long this[int i]=>Value[i];

public static A260670Inst Instance=new A260670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260671
{
public static readonly long[] Value={ 1L,2L,0L,0L,2L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,6L,0L,0L,4L,0L,0L,0L,0L,4L,2L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,2L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,4L,0L,0L,0L,0L,0L,0L,0L,0L,2L,4L,0L,0L,10L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,4L,0L,0L,4L,0L,2L,0L,0L,0L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260671Inst : IEnumerable<long>
{
public static readonly long[] Value=A260671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260671.Bytes);
public long this[int i]=>Value[i];

public static A260671Inst Instance=new A260671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260672
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,3L,2L,1L,4L,3L,2L,5L,4L,3L,0L,6L,5L,4L,1L,7L,6L,5L,2L,0L,8L,7L,6L,3L,1L,9L,8L,7L,4L,2L,10L,9L,8L,5L,3L,11L,10L,9L,6L,4L,12L,11L,10L,7L,5L,0L,13L,12L,11L,8L,6L,1L,14L,13L,12L,9L,7L,2L,15L,14L,13L,10L,8L,3L,0L,16L,15L,14L,11L,9L,4L,1L,17L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260672Inst : IEnumerable<long>
{
public static readonly long[] Value=A260672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260672.Bytes);
public long this[int i]=>Value[i];

public static A260672Inst Instance=new A260672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260673
{
public static readonly long[] Value={ 31L,37L,1229L,4931L,12553L,3259909L,3324329L,9291521L,24066643L,26025107L,46330021L,95979511L,99268649L,116923057L,170995151L,204041417L,213084871L,218568971L,229981399L,232850557L,254042641L,255432869L,256714219L,300222341L,375303157L,383432249L,421514827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260673Inst : IEnumerable<long>
{
public static readonly long[] Value=A260673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260673.Bytes);
public long this[int i]=>Value[i];

public static A260673Inst Instance=new A260673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260674
{
public static readonly long[] Value={ 2L,83L,107L,367L,569L,887L,1327L,1451L,1621L,1987L,2027L,3307L,3547L,3631L,3691L,4421L,4547L,4967L,5669L,5843L,5927L,6011L,6911L,6991L,7207L,7949L,8167L,8431L,10771L,10889L,11287L,11621L,12007L,12227L,12487L,12763L,12983L,15391L,15767L,16127L,17107L,17183L,17231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260674Inst : IEnumerable<long>
{
public static readonly long[] Value=A260674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260674.Bytes);
public long this[int i]=>Value[i];

public static A260674Inst Instance=new A260674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260675
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,2L,0L,2L,0L,0L,1L,2L,0L,0L,0L,0L,0L,2L,0L,0L,1L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,1L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,0L,0L,2L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,2L,3L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260675Inst : IEnumerable<long>
{
public static readonly long[] Value=A260675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260675.Bytes);
public long this[int i]=>Value[i];

public static A260675Inst Instance=new A260675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260676
{
public static readonly long[] Value={ 1L,2L,0L,0L,2L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,1L,2L,0L,0L,2L,0L,2L,0L,0L,2L,0L,0L,0L,0L,0L,0L,2L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,2L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260676Inst : IEnumerable<long>
{
public static readonly long[] Value=A260676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260676.Bytes);
public long this[int i]=>Value[i];

public static A260676Inst Instance=new A260676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260677
{
public static readonly long[] Value={ 1L,1L,1L,3L,7L,17L,35L,74L,150L,304L,612L,1228L,2460L,4926L,9857L,19721L,39449L,78905L,157818L,315644L,631296L,1262601L,2525212L,5050435L,10100879L,20201769L,40403550L,80807112L,161614235L,323228483L,646456979L,1292913972L,2585827958L,5171655931L,10343311876L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260677Inst : IEnumerable<long>
{
public static readonly long[] Value=A260677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260677.Bytes);
public long this[int i]=>Value[i];

public static A260677Inst Instance=new A260677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260678
{
public static readonly long[] Value={ 33L,34L,37L,42L,49L,50L,51L,53L,56L,58L,60L,65L,67L,68L,69L,71L,72L,75L,78L,82L,83L,84L,85L,86L,88L,91L,94L,95L,97L,100L,101L,102L,105L,106L,107L,110L,111L,113L,114L,116L,117L,118L,119L,122L,123L,124L,128L,129L,132L,133L,134L,135L,136L,139L,141L,143L,148L,151L,152L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260678Inst : IEnumerable<long>
{
public static readonly long[] Value=A260678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260678.Bytes);
public long this[int i]=>Value[i];

public static A260678Inst Instance=new A260678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260679
{
public static readonly long[] Value={ 257L,227L,199L,173L,149L,127L,107L,89L,73L,59L,47L,37L,29L,23L,19L,17L,17L,19L,23L,29L,37L,47L,59L,73L,89L,107L,127L,149L,173L,199L,227L,257L,289L,323L,359L,397L,437L,479L,523L,569L,617L,667L,719L,773L,829L,887L,947L,1009L,1073L,1139L,1207L,1277L,1349L,1423L,1499L,1577L,1657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260679Inst : IEnumerable<long>
{
public static readonly long[] Value=A260679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260679.Bytes);
public long this[int i]=>Value[i];

public static A260679Inst Instance=new A260679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260680
{
public static readonly long[] Value={ 1L,1L,1L,8L,3L,34L,19L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A260680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260680Inst : IEnumerable<long>
{
public static readonly long[] Value=A260680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260680.Bytes);
public long this[int i]=>Value[i];

public static A260680Inst Instance=new A260680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A260681
{
public static readonly BigInteger[] Value={ 1L,1L,3L,5L,7L,9L,62L,105L,4612L,477839L,5221660L,120695273L,13517914794489425446UL,BigInteger.Parse("949763730038903507583"),BigInteger.Parse("805993247839619614799176726719363512"),BigInteger.Parse("2572332284084802308827712032135882716710570503279953274299454873") };
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
public class A260681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A260681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A260681Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A260681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A260681.Bytes);
public BigInteger this[int i]=>Value[i];

public static A260681Inst Instance=new A260681Inst();

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