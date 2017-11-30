using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A257782
{
public static readonly long[] Value={ 14L,15L,16L,19L,23L,25L,28L,29L,32L,34L,37L,38L,41L,43L,46L,47L,49L,51L,52L,56L,57L,58L,59L,61L,64L,65L,67L,68L,69L,73L,74L,75L,76L,78L,79L,82L,83L,85L,86L,87L,89L,91L,92L,94L,95L,96L,97L,98L,103L,104L,105L,107L,109L,113L,115L,116L,118L,119L,122L,124L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257782Inst : IEnumerable<long>
{
public static readonly long[] Value=A257782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257782.Bytes);
public long this[int i]=>Value[i];

public static A257782Inst Instance=new A257782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257783
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,2L,0L,1L,3L,6L,0L,1L,7L,12L,24L,0L,1L,12L,35L,60L,120L,0L,1L,25L,87L,210L,360L,720L,0L,1L,44L,232L,609L,1470L,2520L,5040L,0L,1L,89L,599L,1961L,4872L,11760L,20160L,40320L,0L,1L,160L,1591L,5952L,17649L,43848L,105840L,181440L,362880L,0L,1L,321L,4202L,19255L,60465L,176490L,438480L,1058400L,1814400L,3628800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257783Inst : IEnumerable<long>
{
public static readonly long[] Value=A257783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257783.Bytes);
public long this[int i]=>Value[i];

public static A257783Inst Instance=new A257783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257784
{
public static readonly long[] Value={ 0L,1L,512L,2511L,4913L,5832L,17576L,19683L,24624L,32144L,37000L,111616L,382360L,415000L,420224L,2219400L,14041600L,16328000L,19300032L,30681423L,39203125L,62025728L,78535423L,186836625L,214292000L,432265248L,1120141312L,3479669440L,18529084125L,25342447725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257784Inst : IEnumerable<long>
{
public static readonly long[] Value=A257784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257784.Bytes);
public long this[int i]=>Value[i];

public static A257784Inst Instance=new A257784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257785
{
public static readonly long[] Value={ 0L,47L,49L,59L,65L,68L,76L,78L,79L,85L,87L,89L,95L,96L,98L,167L,177L,187L,193L,194L,239L,267L,268L,269L,286L,287L,293L,298L,299L,338L,349L,359L,367L,379L,394L,397L,398L,418L,437L,438L,458L,478L,479L,492L,497L,498L,499L,507L,528L,529L,536L,547L,548L,560L,568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257785Inst : IEnumerable<long>
{
public static readonly long[] Value=A257785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257785.Bytes);
public long this[int i]=>Value[i];

public static A257785Inst Instance=new A257785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257786
{
public static readonly BigInteger[] Value={ 0L,1L,27L,376L,13131L,234595324075L,BigInteger.Parse("54377519037479592374299"),BigInteger.Parse("8326623359858152426050700"),BigInteger.Parse("1513868951125582592290131113769528") };
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
public class A257786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257786Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257786.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257786Inst Instance=new A257786Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257787
{
public static readonly BigInteger[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,37L,48L,415L,231591L,3829377463694454L,BigInteger.Parse("56407086228259246207394322684") };
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
public class A257787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257787Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257787.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257787Inst Instance=new A257787Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257788
{
public static readonly long[] Value={ 2L,66L,228L,696L,1416L,2172L,3000L,3384L,3732L,4314L,4524L,4554L,5070L,5220L,5412L,5826L,5844L,6636L,7422L,7662L,7932L,8148L,8832L,9528L,10092L,10242L,10746L,11670L,11682L,11820L,12918L,13266L,14430L,14580L,15216L,15300L,15534L,15864L,16542L,16782L,16932L,17670L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257788Inst : IEnumerable<long>
{
public static readonly long[] Value=A257788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257788.Bytes);
public long this[int i]=>Value[i];

public static A257788Inst Instance=new A257788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257789
{
public static readonly long[] Value={ 1L,2L,3L,24L,30L,33L,54L,90L,156L,168L,189L,225L,294L,300L,402L,576L,741L,780L,825L,849L,918L,948L,978L,1014L,1245L,1542L,1551L,1608L,1614L,1617L,1770L,1773L,1908L,1914L,1920L,1947L,2025L,2286L,2361L,2370L,2598L,2760L,2865L,2970L,3081L,3516L,3744L,3759L,3948L,4023L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257789Inst : IEnumerable<long>
{
public static readonly long[] Value=A257789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257789.Bytes);
public long this[int i]=>Value[i];

public static A257789Inst Instance=new A257789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257790
{
public static readonly long[] Value={ 0L,1L,2L,5L,11L,28L,65L,72L,361L,479L,494L,599L,1062L,1094L,1193L,2827L,3271L,3388L,3990L,4418L,11178L,16294L,25176L,42500L,68320L,85698L,145259L,159119L,169771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257790Inst : IEnumerable<long>
{
public static readonly long[] Value=A257790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257790.Bytes);
public long this[int i]=>Value[i];

public static A257790Inst Instance=new A257790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257791
{
public static readonly long[] Value={ 4L,8L,12L,16L,24L,20L,32L,48L,40L,28L,64L,96L,80L,56L,36L,128L,192L,160L,112L,72L,44L,256L,384L,320L,224L,144L,88L,52L,512L,768L,640L,448L,288L,176L,104L,60L,1024L,1536L,1280L,896L,576L,352L,208L,120L,68L,2048L,3072L,2560L,1792L,1152L,704L,416L,240L,136L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257791Inst : IEnumerable<long>
{
public static readonly long[] Value=A257791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257791.Bytes);
public long this[int i]=>Value[i];

public static A257791Inst Instance=new A257791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257792
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,14L,26L,49L,92L,174L,328L,618L,1166L,2197L,4143L,7811L,14726L,27764L,52344L,98687L,186058L,350784L,661347L,1246865L,2350768L,4432000L,8355837L,15753609L,29700940L,55996428L,105572414L,199040101L,375258649L,707490872L,1333862213L,2514786376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257792Inst : IEnumerable<long>
{
public static readonly long[] Value=A257792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257792.Bytes);
public long this[int i]=>Value[i];

public static A257792Inst Instance=new A257792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257793
{
public static readonly long[] Value={ 1L,3L,2L,5L,6L,7L,10L,9L,8L,13L,12L,11L,16L,15L,14L,21L,18L,19L,22L,23L,20L,25L,24L,29L,28L,27L,26L,31L,30L,37L,36L,33L,34L,39L,38L,35L,42L,41L,40L,43L,48L,47L,46L,45L,44L,51L,50L,49L,52L,53L,56L,55L,54L,59L,58L,57L,70L,69L,68L,61L,66L,63L,64L,67L,71L,73L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257793Inst : IEnumerable<long>
{
public static readonly long[] Value=A257793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257793.Bytes);
public long this[int i]=>Value[i];

public static A257793Inst Instance=new A257793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257794
{
public static readonly long[] Value={ 2L,4L,1L,8L,6L,12L,9L,16L,18L,11L,22L,24L,14L,28L,17L,32L,34L,36L,20L,40L,23L,44L,46L,48L,26L,52L,29L,56L,58L,31L,62L,64L,35L,68L,70L,72L,38L,76L,41L,80L,82L,43L,86L,88L,47L,92L,94L,96L,50L,100L,53L,104L,106L,55L,110L,112L,59L,116L,118L,61L,122L,124L,65L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257794Inst : IEnumerable<long>
{
public static readonly long[] Value=A257794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257794.Bytes);
public long this[int i]=>Value[i];

public static A257794Inst Instance=new A257794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257795
{
public static readonly long[] Value={ 1L,10L,100L,103L,301L,367L,608L,806L,1000L,1030L,1826L,2363L,2618L,2896L,3010L,3056L,3640L,4036L,4498L,4596L,5294L,5630L,6080L,6323L,6703L,6791L,8060L,8484L,9167L,9452L,9628L,9645L,9844L,10000L,10003L,10275L,10300L,10451L,10979L,11241L,11540L,12336L,12770L,12939L,13623L,13929L,14015L,14112L,15104L,15161L,16151L,16286L,17027L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257795Inst : IEnumerable<long>
{
public static readonly long[] Value=A257795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257795.Bytes);
public long this[int i]=>Value[i];

public static A257795Inst Instance=new A257795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257796
{
public static readonly long[] Value={ 1L,16L,9L,16L,9L,9L,0L,16L,9L,1L,0L,9L,16L,9L,9L,16L,48L,9L,16L,16L,9L,0L,9L,9L,9L,9L,9L,9L,0L,9L,16L,9L,0L,0L,16L,9L,16L,0L,9L,16L,9L,9L,0L,0L,9L,16L,0L,48L,0L,9L,9L,9L,16L,9L,0L,0L,9L,9L,0L,9L,16L,9L,9L,16L,0L,0L,16L,9L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257796Inst : IEnumerable<long>
{
public static readonly long[] Value=A257796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257796.Bytes);
public long this[int i]=>Value[i];

public static A257796Inst Instance=new A257796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257797
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,8L,12L,10L,7L,16L,24L,20L,14L,9L,32L,48L,40L,28L,18L,13L,64L,96L,80L,56L,36L,26L,11L,128L,192L,160L,112L,72L,52L,22L,17L,256L,384L,320L,224L,144L,104L,44L,34L,25L,512L,768L,640L,448L,288L,208L,88L,68L,50L,21L,1024L,1536L,1280L,896L,576L,416L,176L,136L,100L,42L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257797Inst : IEnumerable<long>
{
public static readonly long[] Value=A257797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257797.Bytes);
public long this[int i]=>Value[i];

public static A257797Inst Instance=new A257797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257798
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,10L,7L,15L,9L,28L,8L,21L,14L,66L,11L,36L,20L,136L,13L,55L,35L,435L,12L,45L,27L,253L,19L,120L,77L,2278L,16L,78L,44L,703L,26L,231L,152L,9453L,18L,105L,65L,1596L,43L,666L,464L,95266L,17L,91L,54L,1081L,34L,406L,275L,32385L,25L,210L,135L,7381L,89L,3081L,2345L,2598060L,22L,153L,90L,3160L,53L,1035L,740L,248160L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257798Inst : IEnumerable<long>
{
public static readonly long[] Value=A257798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257798.Bytes);
public long this[int i]=>Value[i];

public static A257798Inst Instance=new A257798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257799
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257799Inst : IEnumerable<long>
{
public static readonly long[] Value=A257799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257799.Bytes);
public long this[int i]=>Value[i];

public static A257799Inst Instance=new A257799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257800
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257800Inst : IEnumerable<long>
{
public static readonly long[] Value=A257800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257800.Bytes);
public long this[int i]=>Value[i];

public static A257800Inst Instance=new A257800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257801
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,5L,9L,6L,11L,8L,13L,14L,25L,10L,17L,12L,15L,19L,33L,20L,35L,16L,21L,24L,18L,22L,27L,45L,43L,28L,31L,47L,23L,29L,34L,26L,51L,30L,38L,59L,63L,57L,115L,39L,42L,61L,37L,32L,40L,46L,36L,66L,73L,41L,52L,78L,83L,76L,49L,146L,67L,53L,56L,81L,50L,44L,79L,54L,60L,48L,163L,86L,87L,95L,55L,68L,101L,107L,171L,98L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257801Inst : IEnumerable<long>
{
public static readonly long[] Value=A257801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257801.Bytes);
public long this[int i]=>Value[i];

public static A257801Inst Instance=new A257801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257802
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,5L,10L,7L,14L,9L,16L,11L,12L,17L,22L,15L,25L,18L,20L,23L,26L,33L,24L,13L,36L,27L,30L,34L,38L,31L,48L,19L,35L,21L,51L,47L,39L,44L,49L,54L,45L,29L,66L,28L,50L,32L,70L,59L,65L,37L,55L,62L,68L,75L,63L,42L,90L,40L,69L,46L,94L,41L,81L,88L,52L,61L,76L,83L,85L,92L,100L,53L,86L,101L,58L,120L,56L,67L,93L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257802Inst : IEnumerable<long>
{
public static readonly long[] Value=A257802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257802.Bytes);
public long this[int i]=>Value[i];

public static A257802Inst Instance=new A257802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257803
{
public static readonly long[] Value={ 1L,4L,7L,9L,12L,17L,18L,21L,23L,24L,25L,27L,30L,34L,35L,38L,41L,42L,49L,52L,53L,54L,55L,57L,60L,64L,65L,68L,70L,73L,74L,75L,76L,77L,81L,82L,83L,90L,93L,95L,96L,103L,106L,107L,108L,109L,111L,114L,118L,119L,122L,127L,128L,131L,132L,134L,136L,137L,138L,139L,140L,145L,147L,148L,149L,150L,151L,155L,156L,157L,164L,167L,168L,171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257803Inst : IEnumerable<long>
{
public static readonly long[] Value=A257803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257803.Bytes);
public long this[int i]=>Value[i];

public static A257803Inst Instance=new A257803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257804
{
public static readonly long[] Value={ 0L,2L,3L,5L,6L,8L,10L,11L,13L,14L,15L,16L,19L,20L,22L,26L,28L,29L,31L,32L,33L,36L,37L,39L,40L,43L,44L,45L,46L,47L,48L,50L,51L,56L,58L,59L,61L,62L,63L,66L,67L,69L,71L,72L,78L,79L,80L,84L,85L,86L,87L,88L,89L,91L,92L,94L,97L,98L,99L,100L,101L,102L,104L,105L,110L,112L,113L,115L,116L,117L,120L,121L,123L,124L,125L,126L,129L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257804Inst : IEnumerable<long>
{
public static readonly long[] Value=A257804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257804.Bytes);
public long this[int i]=>Value[i];

public static A257804Inst Instance=new A257804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257805
{
public static readonly long[] Value={ 1L,0L,0L,-1L,-2L,-5L,-6L,-12L,-20L,-30L,-37L,-41L,-39L,-37L,-51L,-141L,-459L,-1355L,-3521L,-8212L,-17510L,-34685L,-64692L,-114953L,-196617L,-326254L,-527227L,-828432L,-1254932L,-1800115L,-2361626L,-2613748L,-1777205L,1765725L,11078200L,31587185L,72445272L,148564309L,283768148L,516004565L,906713910L,1559424960L,2660917133L,4581930804L,8140743021L,15311144248L,31111188060L,68512065476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257805Inst : IEnumerable<long>
{
public static readonly long[] Value=A257805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257805.Bytes);
public long this[int i]=>Value[i];

public static A257805Inst Instance=new A257805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257806
{
public static readonly long[] Value={ 0L,-1L,0L,1L,0L,1L,2L,1L,2L,1L,2L,3L,2L,3L,4L,5L,6L,5L,4L,5L,6L,5L,6L,5L,4L,3L,4L,3L,4L,5L,4L,5L,6L,7L,6L,5L,6L,7L,6L,7L,8L,7L,6L,7L,8L,9L,10L,11L,12L,11L,12L,13L,12L,11L,10L,9L,10L,9L,10L,11L,10L,11L,12L,13L,12L,11L,12L,13L,12L,13L,12L,13L,14L,13L,12L,11L,10L,9L,10L,11L,12L,11L,10L,9L,10L,11L,12L,13L,14L,15L,14L,15L,16L,15L,16L,15L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257806Inst : IEnumerable<long>
{
public static readonly long[] Value=A257806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257806.Bytes);
public long this[int i]=>Value[i];

public static A257806Inst Instance=new A257806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257807
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,2L,3L,3L,4L,4L,4L,5L,5L,5L,5L,5L,6L,7L,7L,7L,8L,8L,9L,10L,11L,11L,12L,12L,12L,13L,13L,13L,13L,14L,15L,15L,15L,16L,16L,16L,17L,18L,18L,18L,18L,18L,18L,18L,19L,19L,19L,20L,21L,22L,23L,23L,24L,24L,24L,25L,25L,25L,25L,26L,27L,27L,27L,28L,28L,29L,29L,29L,30L,31L,32L,33L,34L,34L,34L,34L,35L,36L,37L,37L,37L,37L,37L,37L,37L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257807Inst : IEnumerable<long>
{
public static readonly long[] Value=A257807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257807.Bytes);
public long this[int i]=>Value[i];

public static A257807Inst Instance=new A257807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257808
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,3L,4L,4L,5L,5L,6L,7L,7L,8L,9L,10L,11L,11L,11L,12L,13L,13L,14L,14L,14L,14L,15L,15L,16L,17L,17L,18L,19L,20L,20L,20L,21L,22L,22L,23L,24L,24L,24L,25L,26L,27L,28L,29L,30L,30L,31L,32L,32L,32L,32L,32L,33L,33L,34L,35L,35L,36L,37L,38L,38L,38L,39L,40L,40L,41L,41L,42L,43L,43L,43L,43L,43L,43L,44L,45L,46L,46L,46L,46L,47L,48L,49L,50L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257808Inst : IEnumerable<long>
{
public static readonly long[] Value=A257808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257808.Bytes);
public long this[int i]=>Value[i];

public static A257808Inst Instance=new A257808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257809
{
public static readonly long[] Value={ 13L,67L,97L,139L,293L,661L,1163L,1657L,2039L,3203L,3469L,5171L,6361L,6661L,7393L,7901L,8969L,9103L,9137L,11971L,12301L,13487L,14083L,14699L,15473L,19141L,21247L,28099L,31039L,35423L,39047L,49223L,58427L,61493L,62171L,67699L,71971L,75869L,78857L,81533L,88007L,93199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257809Inst : IEnumerable<long>
{
public static readonly long[] Value=A257809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257809.Bytes);
public long this[int i]=>Value[i];

public static A257809Inst Instance=new A257809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257810
{
public static readonly long[] Value={ 1L,37L,37L,37L,41L,41L,41L,41L,37L,1L,41L,41L,41L,41L,37L,37L,41L,41L,37L,37L,1268L,41L,41L,41L,41L,41L,41L,1946L,37L,37L,41L,41L,37L,37L,41L,41L,37L,37L,41L,37L,41L,41L,1946L,41L,37L,41L,1946L,37L,41L,41L,5965L,41L,41L,41L,41L,37L,1781L,41L,37L,41L,41L,41L,1268L,41L,41L,37L,37L,41L,37L,41L,41L,41L,41L,5965L,37L,37L,41L,41L,41L,41L,37L,37L,41L,37L,41L,41L,37L,41L,41L,37L,41L,41L,41L,41L,37L,41L,41L,41L,41L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257810Inst : IEnumerable<long>
{
public static readonly long[] Value=A257810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257810.Bytes);
public long this[int i]=>Value[i];

public static A257810Inst Instance=new A257810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257811
{
public static readonly long[] Value={ 1L,8L,3L,10L,5L,12L,7L,2L,9L,4L,11L,6L,1L,8L,3L,10L,5L,12L,7L,2L,9L,4L,11L,6L,1L,8L,3L,10L,5L,12L,7L,2L,9L,4L,11L,6L,1L,8L,3L,10L,5L,12L,7L,2L,9L,4L,11L,6L,1L,8L,3L,10L,5L,12L,7L,2L,9L,4L,11L,6L,1L,8L,3L,10L,5L,12L,7L,2L,9L,4L,11L,6L,1L,8L,3L,10L,5L,12L,7L,2L,9L,4L,11L,6L,1L,8L,3L,10L,5L,12L,7L,2L,9L,4L,11L,6L,1L,8L,3L,10L,5L,12L,7L,2L,9L,4L,11L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257811Inst : IEnumerable<long>
{
public static readonly long[] Value=A257811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257811.Bytes);
public long this[int i]=>Value[i];

public static A257811Inst Instance=new A257811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257812
{
public static readonly long[] Value={ 5L,2L,6L,4L,1L,2L,2L,4L,6L,5L,3L,3L,3L,1L,0L,4L,1L,0L,9L,3L,0L,6L,9L,6L,5L,0L,1L,4L,1L,1L,1L,3L,1L,4L,1L,3L,7L,2L,1L,7L,9L,0L,5L,9L,7L,8L,8L,7L,5L,5L,8L,5L,4L,0L,7L,4L,6L,9L,9L,5L,7L,0L,0L,8L,3L,3L,7L,8L,3L,2L,2L,3L,1L,3L,0L,2L,0L,8L,4L,4L,6L,9L,8L,4L,6L,3L,6L,2L,2L,7L,2L,9L,7L,3L,4L,6L,1L,5L,1L,7L,8L,8L,7L,6L,4L,9L,5L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257812Inst : IEnumerable<long>
{
public static readonly long[] Value=A257812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257812.Bytes);
public long this[int i]=>Value[i];

public static A257812Inst Instance=new A257812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257813
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,0L,0L,4L,5L,0L,0L,8L,38L,14L,0L,0L,16L,184L,262L,42L,0L,0L,32L,720L,2460L,1602L,132L,0L,0L,64L,2480L,16360L,25837L,9260L,429L,0L,0L,128L,7840L,87920L,268134L,237870L,52040L,1430L,0L,0L,256L,23296L,408128L,2109040L,3638386L,2023992L,288494L,4862L,0L,0L,512L,66048L,1701504L,13676128L,40049492L,43815744L,16394336L,1590638L,16796L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257813Inst : IEnumerable<long>
{
public static readonly long[] Value=A257813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257813.Bytes);
public long this[int i]=>Value[i];

public static A257813Inst Instance=new A257813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257814
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,50L,298L,130004L,484950L,3242940L,4264064L,5560625L,36550290L,47746195L,111971979L,129833998L,9865843497L,46793077740L,767609367921L,4432743262896L,42744572298532L,77186414790914L,99320211963544L,99335229415136L,456385296642870L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257814Inst : IEnumerable<long>
{
public static readonly long[] Value=A257814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257814.Bytes);
public long this[int i]=>Value[i];

public static A257814Inst Instance=new A257814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257815
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,9L,7L,8L,10L,24L,11L,37L,15L,12L,13L,82L,14L,118L,16L,19L,38L,232L,17L,20L,56L,18L,25L,574L,21L,759L,22L,46L,119L,30L,23L,1663L,167L,68L,26L,2700L,31L,3408L,57L,27L,318L,5338L,28L,47L,32L,141L,83L,10078L,29L,69L,39L,197L,760L,18312L,33L,22180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257815Inst : IEnumerable<long>
{
public static readonly long[] Value=A257815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257815.Bytes);
public long this[int i]=>Value[i];

public static A257815Inst Instance=new A257815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257816
{
public static readonly long[] Value={ 4L,5L,6L,8L,8L,9L,10L,10L,11L,12L,15L,15L,13L,14L,18L,20L,17L,21L,24L,25L,22L,25L,27L,23L,23L,24L,28L,30L,30L,25L,26L,27L,32L,36L,28L,30L,33L,35L,40L,38L,32L,42L,35L,33L,45L,45L,44L,45L,37L,45L,46L,42L,39L,40L,43L,51L,55L,45L,49L,56L,43L,44L,45L,48L,54L,53L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257816Inst : IEnumerable<long>
{
public static readonly long[] Value=A257816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257816.Bytes);
public long this[int i]=>Value[i];

public static A257816Inst Instance=new A257816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257817
{
public static readonly long[] Value={ 4L,7L,2L,0L,0L,0L,6L,5L,1L,4L,3L,9L,5L,6L,8L,6L,5L,0L,7L,7L,7L,6L,0L,6L,1L,0L,7L,6L,1L,4L,1L,2L,7L,8L,3L,6L,5L,0L,7L,3L,3L,0L,5L,4L,3L,0L,1L,8L,3L,6L,1L,8L,8L,1L,8L,6L,8L,3L,8L,3L,7L,1L,8L,9L,9L,3L,8L,5L,8L,0L,3L,7L,7L,6L,9L,5L,3L,1L,3L,0L,8L,5L,0L,9L,3L,3L,7L,9L,7L,0L,7L,6L,0L,4L,9L,2L,9L,2L,1L,2L,0L,0L,1L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257817Inst : IEnumerable<long>
{
public static readonly long[] Value=A257817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257817.Bytes);
public long this[int i]=>Value[i];

public static A257817Inst Instance=new A257817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257818
{
public static readonly long[] Value={ 2L,9L,4L,1L,5L,5L,8L,4L,9L,4L,9L,4L,9L,3L,8L,5L,0L,9L,9L,3L,0L,0L,9L,9L,9L,9L,8L,0L,0L,2L,1L,3L,2L,6L,7L,7L,2L,0L,8L,9L,4L,4L,6L,0L,3L,5L,2L,5L,1L,9L,2L,1L,5L,9L,0L,1L,2L,2L,7L,0L,4L,4L,3L,9L,2L,8L,3L,9L,4L,3L,5L,6L,4L,2L,1L,1L,0L,6L,0L,7L,2L,5L,0L,3L,4L,0L,8L,2L,6L,5L,3L,4L,8L,4L,9L,5L,9L,0L,9L,4L,9L,3L,4L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257818Inst : IEnumerable<long>
{
public static readonly long[] Value=A257818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257818.Bytes);
public long this[int i]=>Value[i];

public static A257818Inst Instance=new A257818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257819
{
public static readonly long[] Value={ 7L,3L,6L,6L,7L,9L,1L,2L,0L,4L,6L,4L,2L,5L,4L,8L,5L,9L,9L,0L,1L,0L,0L,9L,6L,5L,2L,3L,0L,1L,4L,9L,6L,7L,1L,8L,6L,9L,8L,7L,7L,4L,6L,2L,3L,2L,8L,6L,1L,8L,0L,5L,0L,2L,6L,5L,9L,5L,5L,0L,3L,4L,0L,6L,9L,2L,3L,1L,7L,5L,8L,4L,3L,1L,4L,3L,0L,5L,7L,1L,3L,8L,3L,6L,5L,8L,4L,4L,2L,7L,8L,3L,2L,6L,0L,8L,8L,2L,4L,3L,3L,5L,9L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257819Inst : IEnumerable<long>
{
public static readonly long[] Value=A257819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257819.Bytes);
public long this[int i]=>Value[i];

public static A257819Inst Instance=new A257819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257820
{
public static readonly long[] Value={ 3L,4L,2L,2L,7L,3L,3L,3L,7L,8L,7L,7L,7L,3L,6L,2L,7L,8L,9L,5L,9L,2L,3L,7L,5L,0L,6L,1L,7L,9L,7L,7L,4L,2L,8L,0L,5L,4L,4L,4L,3L,9L,4L,4L,2L,8L,6L,6L,8L,7L,0L,7L,8L,2L,0L,2L,9L,2L,2L,5L,6L,0L,7L,8L,0L,3L,0L,8L,9L,0L,0L,9L,3L,3L,0L,9L,4L,5L,2L,8L,5L,7L,8L,4L,6L,7L,2L,7L,7L,4L,9L,1L,7L,4L,0L,1L,3L,2L,9L,1L,6L,9L,2L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257820Inst : IEnumerable<long>
{
public static readonly long[] Value=A257820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257820.Bytes);
public long this[int i]=>Value[i];

public static A257820Inst Instance=new A257820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257821
{
public static readonly long[] Value={ 2L,4L,6L,6L,4L,0L,8L,2L,6L,2L,4L,1L,2L,6L,7L,8L,0L,7L,5L,1L,9L,7L,1L,0L,3L,3L,5L,0L,7L,7L,5L,9L,3L,2L,9L,5L,0L,2L,9L,0L,7L,8L,0L,8L,7L,8L,2L,7L,7L,4L,0L,9L,9L,8L,2L,3L,7L,8L,6L,0L,8L,9L,8L,8L,1L,6L,1L,2L,2L,4L,0L,9L,4L,1L,5L,0L,0L,9L,1L,5L,0L,7L,1L,7L,1L,6L,2L,7L,8L,1L,5L,8L,0L,4L,6L,5L,5L,8L,4L,7L,2L,9L,3L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257821Inst : IEnumerable<long>
{
public static readonly long[] Value=A257821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257821.Bytes);
public long this[int i]=>Value[i];

public static A257821Inst Instance=new A257821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257822
{
public static readonly long[] Value={ 3L,8L,7L,4L,5L,0L,1L,0L,4L,9L,3L,1L,2L,8L,7L,3L,6L,2L,2L,3L,7L,0L,9L,6L,9L,7L,1L,3L,5L,0L,6L,3L,3L,9L,0L,1L,2L,3L,8L,4L,0L,5L,8L,0L,4L,0L,5L,4L,5L,0L,4L,8L,4L,6L,3L,7L,7L,3L,4L,0L,2L,1L,4L,5L,6L,4L,6L,0L,3L,2L,4L,7L,8L,2L,1L,6L,8L,6L,5L,4L,3L,7L,2L,6L,5L,3L,3L,8L,6L,7L,8L,2L,3L,8L,9L,5L,3L,1L,1L,4L,8L,4L,6L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257822Inst : IEnumerable<long>
{
public static readonly long[] Value=A257822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257822.Bytes);
public long this[int i]=>Value[i];

public static A257822Inst Instance=new A257822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257823
{
public static readonly long[] Value={ 413L,531L,8673L,11269L,426511L,554187L,9192849L,11944727L,452101247L,587437689L,9744411267L,12661399351L,479226895309L,622683396153L,10329066750171L,13421071367333L,507980056926293L,660043812484491L,10948801010769993L,14226322987973629L,538458381114975271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257823Inst : IEnumerable<long>
{
public static readonly long[] Value=A257823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257823.Bytes);
public long this[int i]=>Value[i];

public static A257823Inst Instance=new A257823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257824
{
public static readonly BigInteger[] Value={ 4088L,23360L,1582640L,9047912L,18642443912L,106578370640L,7220791811360L,41281080400088L,85056113063608088L,486263602888235360L,BigInteger.Parse("32944848197744794640"),BigInteger.Parse("188344846763231651912"),BigInteger.Parse("388068345740467131839912"),BigInteger.Parse("2218576715650261475158640"),BigInteger.Parse("150310804012507009263599360") };
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
public class A257824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257824Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257824.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257824Inst Instance=new A257824Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257825
{
public static readonly long[] Value={ 2257L,2849L,21941L,27713L,604765L,763865L,16669573L,21054961L,162316669L,205018517L,4474051285L,5651073085L,123321498797L,155764598629L,1200818695321L,1516726961053L,33099030801665L,41806637918965L,912332431430633L,1152346479602381L,8883656545668089L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257825Inst : IEnumerable<long>
{
public static readonly long[] Value=A257825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257825.Bytes);
public long this[int i]=>Value[i];

public static A257825Inst Instance=new A257825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257826
{
public static readonly long[] Value={ 2222L,2530L,39358L,55990L,872938L,994598L,15506810L,22059818L,343935350L,391869082L,6109643782L,8691512302L,135509654962L,154395423710L,2407184143298L,3424433787170L,53390460119678L,60831405072658L,948424442815630L,1349218220632678L,21035705777498170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257826Inst : IEnumerable<long>
{
public static readonly long[] Value=A257826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257826.Bytes);
public long this[int i]=>Value[i];

public static A257826Inst Instance=new A257826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257827
{
public static readonly long[] Value={ 652L,724L,788L,1012L,1828L,2372L,2596L,2908L,6164L,6908L,7564L,9836L,17996L,23404L,25628L,28724L,60988L,68356L,74852L,97348L,178132L,231668L,253684L,284332L,603716L,676652L,740956L,963644L,1763324L,2293276L,2511212L,2814596L,5976172L,6698164L,7334708L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257827Inst : IEnumerable<long>
{
public static readonly long[] Value=A257827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257827.Bytes);
public long this[int i]=>Value[i];

public static A257827Inst Instance=new A257827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257828
{
public static readonly BigInteger[] Value={ 679L,1545404L,3675742735L,81619738879L,194132514608060L,461744104375531831L,10253011689091642135UL,BigInteger.Parse("24386783991798773338556"),BigInteger.Parse("58003955471481693294113311"),BigInteger.Parse("1287975802673112210113634031"),BigInteger.Parse("3063449905150311732357259611836"),BigInteger.Parse("7286414311424213782299531873117895") };
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
public class A257828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257828Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257828.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257828Inst Instance=new A257828Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257829
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,45L,566L,1500L,2250L,3750L,18000L,383333L,4428571L,11250000L,788888888L,1000000000L,2000000000L,3000000000L,4000000000L,5000000000L,6000000000L,7000000000L,8000000000L,9000000000L,44545454545L,358333333333L,4461538461538L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257829Inst : IEnumerable<long>
{
public static readonly long[] Value=A257829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257829.Bytes);
public long this[int i]=>Value[i];

public static A257829Inst Instance=new A257829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257830
{
public static readonly BigInteger[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,34L,79L,215L,437L,2514L,3833L,32453L,35194L,49672L,5695449L,357129525L,44683966971145538L,383375167535817138L,BigInteger.Parse("4377829714163336859592836") };
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
public class A257830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257830Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257830.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257830Inst Instance=new A257830Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257831
{
public static readonly long[] Value={ 0L,1L,10L,11L,100L,101L,110L,111L,1000L,1001L,10L,11L,110L,111L,1100L,1101L,1110L,1111L,11000L,11001L,100L,101L,1010L,1011L,10100L,10101L,10110L,10111L,101000L,101001L,110L,111L,1110L,1111L,11100L,11101L,11110L,11111L,111000L,111001L,1000L,1001L,10010L,10011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257831Inst : IEnumerable<long>
{
public static readonly long[] Value=A257831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257831.Bytes);
public long this[int i]=>Value[i];

public static A257831Inst Instance=new A257831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257832
{
public static readonly long[] Value={ 1L,30L,42L,70L,165L,247L,330L,442L,570L,805L,1247L,1457L,1749L,1870L,1995L,2183L,2318L,2418L,2706L,2814L,2967L,3358L,3478L,4182L,4505L,4785L,5187L,5394L,5546L,5917L,6262L,7169L,7590L,7770L,8023L,8395L,9471L,9906L,10191L,10906L,11122L,11730L,11954L,12727L,13286L,14043L,15326L,16665L,17201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257832Inst : IEnumerable<long>
{
public static readonly long[] Value=A257832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257832.Bytes);
public long this[int i]=>Value[i];

public static A257832Inst Instance=new A257832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257833
{
public static readonly long[] Value={ 5L,8L,9L,7L,26L,17L,18L,57L,80L,33L,3L,18L,182L,242L,65L,19L,124L,1047L,1068L,728L,129L,38L,239L,1963L,1353L,1068L,2186L,257L,28L,158L,239L,27216L,34967L,32318L,6560L,513L,28L,333L,4260L,109193L,284995L,82681L,110443L,19682L,1025L,14L,42L,2819L,15541L,861642L,758546L,2387947L,280182L,59048L,2049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257833Inst : IEnumerable<long>
{
public static readonly long[] Value=A257833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257833.Bytes);
public long this[int i]=>Value[i];

public static A257833Inst Instance=new A257833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257834
{
public static readonly long[] Value={ 0L,0L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,-1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,1L,-1L,1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257834Inst : IEnumerable<long>
{
public static readonly long[] Value=A257834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257834.Bytes);
public long this[int i]=>Value[i];

public static A257834Inst Instance=new A257834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257835
{
public static readonly long[] Value={ 28L,2L,2L,5L,6L,9L,24L,9L,9L,57L,9L,6L,6L,3L,5L,2L,6L,27L,6L,3L,0L,99L,7L,35L,6L,0L,0L,59L,30L,28L,4L,6L,33L,75L,25L,4L,0L,40L,7L,6L,8L,4L,5L,4L,7L,5L,5L,70L,0L,4L,75L,49L,2L,3L,9L,7L,3L,4L,15L,6L,25L,9L,44L,5L,0L,4L,6L,6L,9L,3L,2L,99L,35L,2L,33L,5L,69L,8L,62L,30L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257835Inst : IEnumerable<long>
{
public static readonly long[] Value=A257835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257835.Bytes);
public long this[int i]=>Value[i];

public static A257835Inst Instance=new A257835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257836
{
public static readonly long[] Value={ 15L,35L,63L,99L,105L,143L,195L,255L,315L,323L,399L,483L,575L,675L,693L,783L,899L,945L,1023L,1155L,1287L,1295L,1443L,1599L,1763L,1935L,2115L,2145L,2303L,2499L,2703L,2915L,3135L,3315L,3363L,3465L,3599L,3843L,4095L,4355L,4623L,4845L,4899L,5183L,5475L,5775L,6083L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257836Inst : IEnumerable<long>
{
public static readonly long[] Value=A257836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257836.Bytes);
public long this[int i]=>Value[i];

public static A257836Inst Instance=new A257836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257837
{
public static readonly long[] Value={ 5L,6L,3L,9L,9L,1L,4L,3L,9L,8L,2L,4L,2L,3L,5L,9L,1L,0L,8L,5L,8L,4L,2L,5L,4L,6L,3L,5L,8L,3L,0L,5L,1L,2L,7L,3L,6L,9L,6L,8L,9L,9L,5L,5L,4L,5L,2L,6L,8L,5L,4L,8L,1L,8L,4L,2L,7L,5L,3L,0L,7L,5L,2L,5L,5L,3L,6L,9L,2L,7L,6L,0L,5L,0L,0L,8L,9L,4L,9L,9L,3L,4L,9L,0L,9L,6L,7L,1L,0L,1L,2L,6L,9L,9L,3L,8L,2L,9L,2L,1L,4L,2L,8L,7L,8L,3L,9L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257837Inst : IEnumerable<long>
{
public static readonly long[] Value=A257837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257837.Bytes);
public long this[int i]=>Value[i];

public static A257837Inst Instance=new A257837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257838
{
public static readonly long[] Value={ 0L,1L,4L,16L,63L,247L,967L,3785L,14820L,58060L,227612L,892926L,3505386L,13770404L,54129602L,212904952L,837885495L,3299264407L,12997784803L,51230474669L,202014314769L,796928589755L,3145066003589L,12416625685891L,49037912997003L,193734379979677L,765632076098287L,3026670770970925L,11968378998073935L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257838Inst : IEnumerable<long>
{
public static readonly long[] Value=A257838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257838.Bytes);
public long this[int i]=>Value[i];

public static A257838Inst Instance=new A257838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257839
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,2L,2L,3L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,5L,6L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,11L,12L,12L,12L,12L,13L,14L,13L,13L,14L,14L,14L,14L,15L,15L,15L,15L,16L,16L,16L,16L,17L,17L,17L,17L,18L,18L,18L,18L,19L,20L,19L,19L,20L,20L,20L,20L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257839Inst : IEnumerable<long>
{
public static readonly long[] Value=A257839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257839.Bytes);
public long this[int i]=>Value[i];

public static A257839Inst Instance=new A257839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257840
{
public static readonly long[] Value={ 0L,0L,4L,3L,4L,7L,15L,7L,10L,16L,34L,13L,18L,29L,61L,21L,30L,46L,96L,31L,43L,67L,139L,43L,60L,92L,190L,57L,78L,121L,249L,73L,100L,154L,316L,91L,124L,191L,391L,111L,154L,232L,474L,133L,181L,277L,565L,157L,99L,326L,664L,183L,248L,379L,771L,211L,286L,436L,886L,241L,326L,497L,1009L,273L,370L,562L,1140L,307L,415L,631L,1279L,343L,210L,704L,1426L,381L,514L,781L,1581L,421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257840Inst : IEnumerable<long>
{
public static readonly long[] Value=A257840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257840.Bytes);
public long this[int i]=>Value[i];

public static A257840Inst Instance=new A257840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257841
{
public static readonly long[] Value={ 0L,0L,12L,6L,20L,42L,210L,42L,90L,240L,1122L,156L,468L,812L,3660L,420L,510L,2070L,9120L,930L,1806L,4422L,19182L,1806L,2100L,8372L,35910L,3192L,9048L,14520L,61752L,5256L,9900L,23562L,99540L,8190L,22940L,36290L,152490L,12210L,6314L,53592L,224202L,17556L,32580L,76452L,318660L,24492L,9702L,105950L,440232L,33306L,92008L,143262L,593670L,44310L,81510L,189660L,784110L,57840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257841Inst : IEnumerable<long>
{
public static readonly long[] Value=A257841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257841.Bytes);
public long this[int i]=>Value[i];

public static A257841Inst Instance=new A257841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257842
{
public static readonly long[] Value={ 4L,6L,9L,22L,26L,33L,39L,46L,55L,62L,69L,77L,82L,86L,93L,121L,143L,169L,187L,202L,206L,226L,253L,262L,299L,303L,309L,339L,341L,393L,422L,446L,451L,466L,473L,482L,505L,583L,622L,626L,633L,662L,669L,671L,699L,707L,781L,802L,842L,862L,866L,886L,933L,939L,961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257842Inst : IEnumerable<long>
{
public static readonly long[] Value=A257842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257842.Bytes);
public long this[int i]=>Value[i];

public static A257842Inst Instance=new A257842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257843
{
public static readonly long[] Value={ 89L,113L,161L,233L,281L,329L,353L,401L,409L,449L,473L,521L,593L,641L,689L,713L,761L,769L,809L,929L,953L,1049L,1073L,1121L,1129L,1169L,1193L,1241L,1249L,1313L,1321L,1361L,1369L,1409L,1433L,1481L,1513L,1529L,1553L,1561L,1601L,1609L,1649L,1673L,1721L,1769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257843Inst : IEnumerable<long>
{
public static readonly long[] Value=A257843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257843.Bytes);
public long this[int i]=>Value[i];

public static A257843Inst Instance=new A257843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257844
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,2L,3L,0L,2L,4L,6L,0L,3L,6L,9L,0L,4L,8L,12L,0L,5L,10L,15L,0L,6L,12L,18L,0L,7L,14L,21L,0L,8L,16L,24L,0L,9L,18L,27L,0L,10L,20L,30L,0L,11L,22L,33L,0L,12L,24L,36L,0L,13L,26L,39L,0L,14L,28L,42L,0L,15L,30L,45L,0L,16L,32L,48L,0L,17L,34L,51L,0L,18L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257844Inst : IEnumerable<long>
{
public static readonly long[] Value=A257844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257844.Bytes);
public long this[int i]=>Value[i];

public static A257844Inst Instance=new A257844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257845
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,2L,3L,4L,0L,2L,4L,6L,8L,0L,3L,6L,9L,12L,0L,4L,8L,12L,16L,0L,5L,10L,15L,20L,0L,6L,12L,18L,24L,0L,7L,14L,21L,28L,0L,8L,16L,24L,32L,0L,9L,18L,27L,36L,0L,10L,20L,30L,40L,0L,11L,22L,33L,44L,0L,12L,24L,36L,48L,0L,13L,26L,39L,52L,0L,14L,28L,42L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257845Inst : IEnumerable<long>
{
public static readonly long[] Value=A257845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257845.Bytes);
public long this[int i]=>Value[i];

public static A257845Inst Instance=new A257845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257846
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,2L,3L,4L,5L,0L,2L,4L,6L,8L,10L,0L,3L,6L,9L,12L,15L,0L,4L,8L,12L,16L,20L,0L,5L,10L,15L,20L,25L,0L,6L,12L,18L,24L,30L,0L,7L,14L,21L,28L,35L,0L,8L,16L,24L,32L,40L,0L,9L,18L,27L,36L,45L,0L,10L,20L,30L,40L,50L,0L,11L,22L,33L,44L,55L,0L,12L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257846Inst : IEnumerable<long>
{
public static readonly long[] Value=A257846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257846.Bytes);
public long this[int i]=>Value[i];

public static A257846Inst Instance=new A257846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257847
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,3L,4L,5L,6L,0L,2L,4L,6L,8L,10L,12L,0L,3L,6L,9L,12L,15L,18L,0L,4L,8L,12L,16L,20L,24L,0L,5L,10L,15L,20L,25L,30L,0L,6L,12L,18L,24L,30L,36L,0L,7L,14L,21L,28L,35L,42L,0L,8L,16L,24L,32L,40L,48L,0L,9L,18L,27L,36L,45L,54L,0L,10L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257847Inst : IEnumerable<long>
{
public static readonly long[] Value=A257847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257847.Bytes);
public long this[int i]=>Value[i];

public static A257847Inst Instance=new A257847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257848
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,3L,4L,5L,6L,7L,0L,2L,4L,6L,8L,10L,12L,14L,0L,3L,6L,9L,12L,15L,18L,21L,0L,4L,8L,12L,16L,20L,24L,28L,0L,5L,10L,15L,20L,25L,30L,35L,0L,6L,12L,18L,24L,30L,36L,42L,0L,7L,14L,21L,28L,35L,42L,49L,0L,8L,16L,24L,32L,40L,48L,56L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257848Inst : IEnumerable<long>
{
public static readonly long[] Value=A257848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257848.Bytes);
public long this[int i]=>Value[i];

public static A257848Inst Instance=new A257848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257849
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,3L,4L,5L,6L,7L,8L,0L,2L,4L,6L,8L,10L,12L,14L,16L,0L,3L,6L,9L,12L,15L,18L,21L,24L,0L,4L,8L,12L,16L,20L,24L,28L,32L,0L,5L,10L,15L,20L,25L,30L,35L,40L,0L,6L,12L,18L,24L,30L,36L,42L,48L,0L,7L,14L,21L,28L,35L,42L,49L,56L,0L,8L,16L,24L,32L,40L,48L,56L,64L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257849Inst : IEnumerable<long>
{
public static readonly long[] Value=A257849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257849.Bytes);
public long this[int i]=>Value[i];

public static A257849Inst Instance=new A257849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257850
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,2L,4L,6L,8L,10L,12L,14L,16L,18L,0L,3L,6L,9L,12L,15L,18L,21L,24L,27L,0L,4L,8L,12L,16L,20L,24L,28L,32L,36L,0L,5L,10L,15L,20L,25L,30L,35L,40L,45L,0L,6L,12L,18L,24L,30L,36L,42L,48L,54L,0L,7L,14L,21L,28L,35L,42L,49L,56L,63L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257850Inst : IEnumerable<long>
{
public static readonly long[] Value=A257850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257850.Bytes);
public long this[int i]=>Value[i];

public static A257850Inst Instance=new A257850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257851
{
public static readonly long[] Value={ 1L,4L,9L,8L,24L,27L,16L,48L,72L,80L,32L,96L,144L,160L,216L,64L,192L,288L,320L,432L,448L,128L,384L,576L,640L,864L,896L,1296L,256L,768L,1152L,1280L,1728L,1792L,2592L,2816L,512L,1536L,2304L,2560L,3456L,3584L,5184L,5632L,6400L,1024L,3072L,4608L,5120L,6912L,7168L,10368L,11264L,12800L,13312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257851Inst : IEnumerable<long>
{
public static readonly long[] Value=A257851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257851.Bytes);
public long this[int i]=>Value[i];

public static A257851Inst Instance=new A257851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257852
{
public static readonly long[] Value={ 3L,1L,7L,13L,9L,11L,5L,29L,17L,15L,53L,37L,45L,25L,19L,21L,117L,69L,61L,33L,23L,213L,149L,181L,101L,77L,41L,27L,85L,469L,277L,245L,133L,93L,49L,31L,853L,597L,725L,405L,309L,165L,109L,57L,35L,341L,1877L,1109L,981L,533L,373L,197L,125L,65L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257852Inst : IEnumerable<long>
{
public static readonly long[] Value=A257852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257852.Bytes);
public long this[int i]=>Value[i];

public static A257852Inst Instance=new A257852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257853
{
public static readonly long[] Value={ 0L,1L,8L,27L,3L,34L,89L,174L,24L,127L,272L,465L,81L,298L,575L,918L,192L,565L,1016L,1551L,375L,946L,1613L,2382L,648L,1459L,2384L,62L,1029L,2122L,3347L,263L,1536L,2953L,4520L,566L,2187L,3970L,5921L,989L,3000L,5191L,7568L,1550L,3993L,6634L,9479L,2267L,5184L,8317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257853Inst : IEnumerable<long>
{
public static readonly long[] Value=A257853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257853.Bytes);
public long this[int i]=>Value[i];

public static A257853Inst Instance=new A257853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257854
{
public static readonly long[] Value={ 0L,1L,16L,81L,256L,625L,191L,706L,1631L,3122L,5359L,721L,3056L,6497L,11296L,17729L,751L,7042L,15471L,26386L,40159L,57186L,11536L,28241L,48896L,73969L,103952L,14306L,43391L,78226L,119375L,167426L,12016L,58401L,112672L,175489L,247536L,226L,69647L,149426L,240319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257854Inst : IEnumerable<long>
{
public static readonly long[] Value=A257854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257854.Bytes);
public long this[int i]=>Value[i];

public static A257854Inst Instance=new A257854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257855
{
public static readonly long[] Value={ 0L,1L,32L,243L,1024L,3125L,7776L,846L,6487L,18098L,38949L,73270L,126371L,204762L,27072L,98893L,207584L,363615L,579136L,868097L,1246368L,205578L,541639L,991310L,1576341L,2320882L,3251603L,68663L,866304L,1886905L,3164576L,4736427L,6642688L,8926829L,646649L,2643750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257855Inst : IEnumerable<long>
{
public static readonly long[] Value=A257855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257855.Bytes);
public long this[int i]=>Value[i];

public static A257855Inst Instance=new A257855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257856
{
public static readonly long[] Value={ 1L,1L,5L,2L,1L,291L,4L,31L,4L,131L,66L,8L,113L,4L,1770L,19L,122L,27L,509L,61L,138L,1484L,1L,508L,118L,1033L,48L,314L,78L,1522L,4L,8L,169L,341L,650L,37L,3456L,1172L,221L,21L,119L,105L,34L,670L,196L,19L,30L,4L,1L,88L,496L,30L,1460L,90L,12L,1270L,812L,2096L,311L,131L,95L,241L,198L,34L,19L,63L,8L,75L,2L,10413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257856Inst : IEnumerable<long>
{
public static readonly long[] Value=A257856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257856.Bytes);
public long this[int i]=>Value[i];

public static A257856Inst Instance=new A257856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257857
{
public static readonly long[] Value={ 2L,1L,1L,0L,2L,0L,1L,1L,1L,1L,2L,0L,2L,0L,2L,1L,1L,1L,1L,1L,1L,0L,2L,0L,2L,0L,2L,0L,1L,1L,1L,1L,1L,1L,1L,1L,2L,0L,2L,0L,2L,0L,2L,0L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,0L,2L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257857Inst : IEnumerable<long>
{
public static readonly long[] Value=A257857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257857.Bytes);
public long this[int i]=>Value[i];

public static A257857Inst Instance=new A257857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257858
{
public static readonly long[] Value={ 6L,10L,19L,27L,29L,32L,42L,45L,56L,67L,75L,94L,109L,122L,138L,144L,151L,152L,172L,181L,194L,204L,205L,232L,256L,290L,316L,325L,346L,380L,412L,446L,478L,511L,520L,533L,580L,584L,617L,623L,654L,658L,661L,682L,734L,773L,823L,836L,865L,903L,954L,979L,997L,1008L,1059L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257858Inst : IEnumerable<long>
{
public static readonly long[] Value=A257858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257858.Bytes);
public long this[int i]=>Value[i];

public static A257858Inst Instance=new A257858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257859
{
public static readonly BigInteger[] Value={ 2L,1L,1L,4L,27L,239L,2602L,33587L,501203L,8486864L,160749213L,3367246609L,77285922794L,1928780823241L,51999796304713L,1506065312013436L,46636024876111803L,1537482755599676063L,BigInteger.Parse("53765260421112550402"),BigInteger.Parse("1987777152825564688811"),BigInteger.Parse("77469543699775910313227") };
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
public class A257859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257859Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257859.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257859Inst Instance=new A257859Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257860
{
public static readonly long[] Value={ 1L,89L,132L,264L,518L,739L,2407L,6579L,8200L,8201L,8202L,8203L,8204L,8205L,8206L,8207L,8208L,8209L,32780L,32781L,32782L,32783L,32784L,32785L,32786L,32787L,32788L,32789L,59060L,59061L,59062L,59063L,59064L,59065L,59066L,59067L,59068L,59069L,78145L,524300L,524301L,524302L,524303L,524304L,524305L,524306L,524307L,524308L,524309L,531459L,823567L,2097178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257860Inst : IEnumerable<long>
{
public static readonly long[] Value=A257860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257860.Bytes);
public long this[int i]=>Value[i];

public static A257860Inst Instance=new A257860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257861
{
public static readonly long[] Value={ 24L,48L,64L,72L,80L,96L,112L,128L,144L,160L,192L,224L,240L,288L,320L,336L,352L,384L,416L,448L,480L,576L,672L,800L,864L,960L,1056L,1440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257861Inst : IEnumerable<long>
{
public static readonly long[] Value=A257861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257861.Bytes);
public long this[int i]=>Value[i];

public static A257861Inst Instance=new A257861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257862
{
public static readonly long[] Value={ 1L,2L,3L,4L,9L,8L,15L,14L,5L,7L,10L,21L,16L,27L,20L,33L,25L,11L,30L,77L,6L,49L,12L,35L,18L,125L,24L,55L,32L,121L,26L,99L,13L,66L,65L,22L,169L,44L,39L,64L,81L,28L,45L,56L,75L,98L,135L,112L,165L,128L,225L,34L,105L,17L,63L,68L,147L,136L,189L,170L,231L,40L,243L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257862Inst : IEnumerable<long>
{
public static readonly long[] Value=A257862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257862.Bytes);
public long this[int i]=>Value[i];

public static A257862Inst Instance=new A257862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257863
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,12L,18L,29L,45L,72L,112L,178L,279L,441L,693L,1094L,1721L,2714L,4273L,6735L,10607L,16715L,26329L,41485L,65352L,102965L,162209L,255560L,402613L,634306L,999306L,1574368L,2480323L,3907638L,6156268L,9698906L,15280112L,24073063L,37925860L,59750293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257863Inst : IEnumerable<long>
{
public static readonly long[] Value=A257863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257863.Bytes);
public long this[int i]=>Value[i];

public static A257863Inst Instance=new A257863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257864
{
public static readonly long[] Value={ 11L,13L,21L,47L,59L,77L,109L,129L,155L,163L,245L,337L,511L,1417L,3013L,3757L,4989L,8977L,12479L,12869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257864Inst : IEnumerable<long>
{
public static readonly long[] Value=A257864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257864.Bytes);
public long this[int i]=>Value[i];

public static A257864Inst Instance=new A257864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257865
{
public static readonly long[] Value={ 1L,5L,119L,629L,17907119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257865Inst : IEnumerable<long>
{
public static readonly long[] Value=A257865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257865.Bytes);
public long this[int i]=>Value[i];

public static A257865Inst Instance=new A257865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257866
{
public static readonly long[] Value={ 1L,1L,3L,5L,19L,74L,209L,572L,1479L,4304L,13002L,38315L,109651L,308982L,884120L,2560952L,7428183L,21413028L,61433280L,176415916L,507985116L,1464725431L,4220293147L,12145885239L,34945690653L,100586823613L,289649303130L,834087280681L,2401368817168L,6912685066843L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257866Inst : IEnumerable<long>
{
public static readonly long[] Value=A257866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257866.Bytes);
public long this[int i]=>Value[i];

public static A257866Inst Instance=new A257866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257867
{
public static readonly long[] Value={ 314L,942L,2824L,2826L,2854L,3074L,3130L,3212L,8066L,8090L,8096L,8170L,8224L,8324L,8426L,8450L,8472L,8478L,8480L,8512L,8534L,8562L,8578L,8588L,8656L,9222L,9224L,9390L,9404L,9636L,9638L,24198L,24206L,24270L,24288L,24510L,24670L,24672L,24674L,24676L,24802L,24972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257867Inst : IEnumerable<long>
{
public static readonly long[] Value=A257867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257867.Bytes);
public long this[int i]=>Value[i];

public static A257867Inst Instance=new A257867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257868
{
public static readonly long[] Value={ -314L,-898L,-942L,-2694L,-2824L,-2826L,-2962L,-3014L,-3070L,-3074L,-8066L,-8082L,-8090L,-8096L,-8132L,-8170L,-8224L,-8336L,-8426L,-8434L,-8450L,-8472L,-8478L,-8480L,-8618L,-8656L,-8870L,-8886L,-8918L,-9008L,-9042L,-9210L,-9222L,-9224L,-24198L,-24226L,-24246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257868Inst : IEnumerable<long>
{
public static readonly long[] Value=A257868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257868.Bytes);
public long this[int i]=>Value[i];

public static A257868Inst Instance=new A257868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257869
{
public static readonly long[] Value={ 6L,8L,136L,138L,144L,154L,156L,160L,164L,168L,170L,180L,186L,188L,208L,210L,214L,218L,222L,224L,232L,236L,248L,258L,260L,266L,288L,294L,296L,312L,314L,320L,3406L,3412L,3414L,3430L,3432L,3438L,3484L,3486L,3492L,3510L,3568L,3574L,3576L,3592L,3594L,3600L,3622L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257869Inst : IEnumerable<long>
{
public static readonly long[] Value=A257869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257869.Bytes);
public long this[int i]=>Value[i];

public static A257869Inst Instance=new A257869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257870
{
public static readonly long[] Value={ 1L,0L,5L,8L,9L,3L,5L,1L,5L,5L,3L,3L,1L,3L,1L,5L,2L,0L,7L,6L,1L,3L,7L,2L,2L,1L,0L,6L,0L,8L,5L,3L,5L,1L,4L,5L,4L,4L,6L,5L,2L,7L,0L,6L,6L,5L,5L,0L,2L,9L,7L,5L,8L,9L,8L,9L,7L,6L,7L,6L,5L,1L,8L,8L,7L,4L,2L,5L,9L,0L,3L,1L,1L,5L,8L,9L,9L,0L,2L,2L,3L,3L,8L,3L,2L,1L,0L,5L,7L,1L,8L,2L,7L,9L,6L,7L,6L,7L,0L,7L,2L,6L,5L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257870Inst : IEnumerable<long>
{
public static readonly long[] Value=A257870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257870.Bytes);
public long this[int i]=>Value[i];

public static A257870Inst Instance=new A257870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257871
{
public static readonly long[] Value={ 6L,9L,1L,3L,0L,3L,9L,5L,7L,7L,0L,0L,9L,1L,6L,1L,1L,0L,7L,8L,5L,0L,1L,8L,7L,8L,1L,4L,2L,6L,9L,7L,7L,9L,1L,2L,3L,0L,2L,1L,0L,0L,8L,9L,5L,0L,6L,9L,1L,5L,9L,4L,3L,2L,7L,1L,3L,9L,7L,9L,8L,3L,2L,9L,8L,2L,7L,1L,8L,9L,0L,5L,2L,7L,2L,9L,5L,2L,7L,5L,9L,6L,8L,2L,3L,2L,9L,4L,6L,9L,1L,1L,5L,5L,7L,3L,2L,7L,1L,9L,6L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257871Inst : IEnumerable<long>
{
public static readonly long[] Value=A257871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257871.Bytes);
public long this[int i]=>Value[i];

public static A257871Inst Instance=new A257871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257872
{
public static readonly long[] Value={ 5L,5L,4L,5L,1L,7L,7L,4L,4L,4L,4L,7L,9L,5L,6L,2L,4L,7L,5L,3L,3L,7L,8L,5L,6L,9L,7L,1L,6L,6L,5L,4L,1L,2L,5L,4L,4L,6L,0L,4L,0L,0L,1L,0L,7L,4L,8L,8L,2L,0L,4L,2L,0L,3L,2L,9L,6L,5L,4L,4L,0L,0L,7L,5L,9L,4L,7L,1L,4L,8L,9L,7L,5L,7L,5L,7L,5L,5L,7L,7L,2L,4L,8L,4L,6L,9L,0L,6L,6L,1L,5L,9L,7L,1L,3L,4L,9L,5L,0L,0L,3L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257872Inst : IEnumerable<long>
{
public static readonly long[] Value=A257872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257872.Bytes);
public long this[int i]=>Value[i];

public static A257872Inst Instance=new A257872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257873
{
public static readonly long[] Value={ 1L,-2L,-1L,2L,0L,4L,0L,-4L,-4L,-2L,3L,4L,0L,4L,0L,-8L,5L,-6L,0L,6L,0L,4L,0L,-4L,-4L,-8L,-4L,10L,0L,8L,0L,-4L,9L,-6L,-4L,6L,0L,8L,0L,-8L,-12L,-12L,3L,6L,0L,12L,0L,-12L,8L,-6L,12L,8L,0L,8L,0L,-12L,-8L,-10L,-4L,6L,0L,12L,0L,-8L,8L,-10L,-5L,16L,0L,8L,0L,-12L,-12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257873Inst : IEnumerable<long>
{
public static readonly long[] Value=A257873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257873.Bytes);
public long this[int i]=>Value[i];

public static A257873Inst Instance=new A257873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257874
{
public static readonly long[] Value={ 3L,6L,8L,10L,12L,15L,17L,21L,24L,27L,31L,33L,38L,41L,43L,48L,50L,52L,54L,57L,59L,62L,66L,69L,71L,73L,75L,78L,80L,82L,85L,90L,93L,95L,97L,99L,101L,103L,105L,111L,115L,117L,119L,124L,127L,131L,133L,136L,138L,141L,143L,145L,147L,150L,153L,155L,157L,162L,164L,168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257874Inst : IEnumerable<long>
{
public static readonly long[] Value=A257874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257874.Bytes);
public long this[int i]=>Value[i];

public static A257874Inst Instance=new A257874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257875
{
public static readonly BigInteger[] Value={ 0L,1L,1L,48L,1L,9182736455463727L,4L,1L,2L,1L,3L,1L,BigInteger.Parse("16413861141941053151166388889231063606316227031696978138434"),9L,9L,2L,1L,3L,8L,1L,1L,19L,1L,1L,2L,3L,1L,7L,1L,1L,4L,1L,1L,1L,3L,3L,1L,1L,2L,2L,2L,1L,5L,2L,1L,1L,1L,1L,5L,1L,78L,1L,21L,1L,1L,5L,3L,2L };
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
public class A257875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257875Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257875.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257875Inst Instance=new A257875Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257876
{
public static readonly long[] Value={ 0L,1L,4L,3L,7L,5L,2L,8L,13L,9L,16L,11L,19L,12L,6L,15L,25L,17L,28L,18L,30L,21L,10L,23L,37L,24L,39L,27L,43L,29L,14L,31L,49L,33L,52L,35L,55L,36L,57L,34L,56L,38L,61L,41L,20L,44L,22L,47L,73L,48L,75L,51L,79L,53L,26L,58L,87L,59L,89L,60L,91L,54L,88L,50L,83L,42L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257876Inst : IEnumerable<long>
{
public static readonly long[] Value=A257876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257876.Bytes);
public long this[int i]=>Value[i];

public static A257876Inst Instance=new A257876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257877
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,4L,9L,5L,11L,8L,15L,10L,18L,12L,21L,14L,24L,16L,7L,19L,30L,20L,33L,22L,36L,23L,38L,26L,42L,28L,13L,31L,48L,32L,51L,34L,54L,35L,17L,39L,60L,40L,63L,41L,65L,44L,69L,46L,72L,47L,74L,50L,78L,52L,25L,55L,27L,56L,87L,58L,90L,59L,29L,62L,96L,64L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257877Inst : IEnumerable<long>
{
public static readonly long[] Value=A257877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257877.Bytes);
public long this[int i]=>Value[i];

public static A257877Inst Instance=new A257877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257878
{
public static readonly long[] Value={ 1L,3L,2L,5L,9L,7L,4L,10L,6L,11L,18L,13L,21L,15L,8L,17L,27L,19L,30L,20L,32L,23L,12L,25L,39L,26L,14L,29L,45L,31L,16L,33L,51L,35L,54L,37L,57L,38L,59L,41L,63L,43L,22L,46L,24L,47L,72L,49L,75L,50L,77L,53L,81L,55L,28L,58L,87L,56L,88L,60L,91L,62L,95L,65L,99L,67L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257878Inst : IEnumerable<long>
{
public static readonly long[] Value=A257878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257878.Bytes);
public long this[int i]=>Value[i];

public static A257878Inst Instance=new A257878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257879
{
public static readonly long[] Value={ 2L,1L,3L,4L,7L,5L,9L,6L,11L,17L,13L,8L,15L,23L,16L,10L,19L,29L,21L,12L,24L,14L,25L,38L,27L,41L,28L,43L,31L,47L,33L,18L,35L,53L,37L,20L,39L,59L,40L,22L,44L,65L,45L,68L,46L,70L,49L,26L,51L,77L,52L,79L,55L,83L,57L,30L,60L,32L,61L,92L,63L,95L,64L,34L,67L,101L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257879Inst : IEnumerable<long>
{
public static readonly long[] Value=A257879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257879.Bytes);
public long this[int i]=>Value[i];

public static A257879Inst Instance=new A257879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257880
{
public static readonly long[] Value={ 0L,-1L,2L,1L,3L,-2L,4L,-3L,5L,6L,-4L,-5L,7L,8L,-7L,-6L,9L,10L,-8L,-9L,12L,-10L,11L,13L,-11L,14L,-13L,15L,-12L,16L,-14L,-15L,17L,18L,-16L,-17L,19L,20L,-19L,-18L,22L,21L,-20L,23L,-22L,24L,-21L,-23L,25L,26L,-25L,27L,-24L,28L,-26L,-27L,30L,-28L,29L,31L,-29L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257880Inst : IEnumerable<long>
{
public static readonly long[] Value=A257880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257880.Bytes);
public long this[int i]=>Value[i];

public static A257880Inst Instance=new A257880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257881
{
public static readonly long[] Value={ 2L,1L,3L,6L,4L,8L,5L,10L,16L,12L,7L,14L,22L,15L,9L,18L,28L,20L,11L,23L,13L,24L,37L,26L,40L,27L,42L,30L,46L,32L,17L,34L,52L,36L,19L,38L,58L,39L,21L,43L,64L,44L,67L,45L,69L,48L,25L,50L,76L,51L,78L,54L,82L,56L,29L,59L,31L,60L,91L,62L,94L,63L,33L,66L,100L,68L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257881Inst : IEnumerable<long>
{
public static readonly long[] Value=A257881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257881.Bytes);
public long this[int i]=>Value[i];

public static A257881Inst Instance=new A257881Inst();

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