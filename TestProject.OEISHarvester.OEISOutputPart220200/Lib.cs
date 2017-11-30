using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A258582
{
public static readonly long[] Value={ 0L,5L,30L,91L,204L,385L,650L,1015L,1496L,2109L,2870L,3795L,4900L,6201L,7714L,9455L,11440L,13685L,16206L,19019L,22140L,25585L,29370L,33511L,38024L,42925L,48230L,53955L,60116L,66729L,73810L,81375L,89440L,98021L,107134L,116795L,127020L,137825L,149226L,161239L,173880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258582Inst : IEnumerable<long>
{
public static readonly long[] Value=A258582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258582.Bytes);
public long this[int i]=>Value[i];

public static A258582Inst Instance=new A258582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258583
{
public static readonly BigInteger[] Value={ 1L,1L,16L,5471L,75965484L,70692556053053L,BigInteger.Parse("6614511157454872712100"),BigInteger.Parse("87353366195666890516586545068535"),BigInteger.Parse("217757982462900115559339884671224174403391534"),BigInteger.Parse("132100470099008733697710444705793312015509514686031193798241"),BigInteger.Parse("24431421930145927713526351934816506384811205836191828228900485331569907542066") };
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
public class A258583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258583Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258583.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258583Inst Instance=new A258583Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258584
{
public static readonly long[] Value={ 86L,860L,1975L,2160L,3575L,19750L,21600L,35750L,43614L,51884L,65625L,479900L,868688L,967750L,1435575L,1548384L,1696875L,4799000L,8686880L,9677500L,28874200L,34095100L,38748800L,39214560L,47613625L,53415625L,148385715L,156293216L,288742000L,340951000L,387488000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258584Inst : IEnumerable<long>
{
public static readonly long[] Value=A258584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258584.Bytes);
public long this[int i]=>Value[i];

public static A258584Inst Instance=new A258584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258585
{
public static readonly long[] Value={ 2L,4L,8L,16L,32L,64L,126L,247L,480L,926L,1764L,3337L,6208L,11408L,20608L,36649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258585Inst : IEnumerable<long>
{
public static readonly long[] Value=A258585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258585.Bytes);
public long this[int i]=>Value[i];

public static A258585Inst Instance=new A258585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258586
{
public static readonly BigInteger[] Value={ 1L,2L,936L,1825221320L,BigInteger.Parse("70351928759681296000"),BigInteger.Parse("160978956785364112335731878007698260"),BigInteger.Parse("51488321677815455036453939239317069333712945710369620220"),BigInteger.Parse("4648889159675386017282064494039528050991187044317172798976485350954735075040045120") };
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
public class A258586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258586Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258586.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258586Inst Instance=new A258586Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258587
{
public static readonly long[] Value={ 1L,-2L,1L,-2L,2L,0L,2L,0L,0L,-2L,1L,-4L,0L,0L,2L,0L,3L,-2L,2L,-2L,2L,0L,0L,0L,0L,-4L,2L,-2L,0L,0L,0L,0L,3L,-2L,0L,-2L,4L,0L,2L,0L,0L,-4L,1L,-2L,0L,0L,4L,0L,2L,-2L,0L,-4L,2L,0L,0L,0L,0L,-2L,2L,-2L,0L,0L,0L,0L,2L,-2L,3L,-4L,2L,0L,2L,0L,0L,0L,2L,-2L,0L,0L,2L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258587Inst : IEnumerable<long>
{
public static readonly long[] Value=A258587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258587.Bytes);
public long this[int i]=>Value[i];

public static A258587Inst Instance=new A258587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258588
{
public static readonly long[] Value={ 1L,11L,16L,22L,27L,33L,38L,44L,49L,55L,60L,66L,71L,77L,82L,88L,93L,99L,104L,110L,115L,121L,126L,132L,137L,143L,148L,154L,159L,165L,170L,176L,181L,187L,192L,198L,203L,209L,214L,220L,225L,231L,236L,242L,247L,253L,258L,264L,269L,275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258588Inst : IEnumerable<long>
{
public static readonly long[] Value=A258588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258588.Bytes);
public long this[int i]=>Value[i];

public static A258588Inst Instance=new A258588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258589
{
public static readonly long[] Value={ 1L,13L,19L,26L,32L,39L,45L,52L,58L,65L,71L,78L,84L,91L,97L,104L,110L,117L,123L,130L,136L,143L,149L,156L,162L,169L,175L,182L,188L,195L,201L,208L,214L,221L,227L,234L,240L,247L,253L,260L,266L,273L,279L,286L,292L,299L,305L,312L,318L,325L,331L,338L,344L,351L,357L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258589Inst : IEnumerable<long>
{
public static readonly long[] Value=A258589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258589.Bytes);
public long this[int i]=>Value[i];

public static A258589Inst Instance=new A258589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258590
{
public static readonly long[] Value={ 1L,-1L,0L,0L,-1L,0L,0L,0L,0L,2L,0L,0L,1L,-1L,0L,0L,-2L,0L,0L,0L,0L,2L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,3L,-2L,0L,0L,-1L,0L,0L,0L,0L,2L,0L,0L,2L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,-2L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,3L,-1L,0L,0L,-2L,0L,0L,0L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258590Inst : IEnumerable<long>
{
public static readonly long[] Value=A258590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258590.Bytes);
public long this[int i]=>Value[i];

public static A258590Inst Instance=new A258590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258591
{
public static readonly long[] Value={ 1L,12L,80L,400L,1664L,6056L,19904L,60320L,171008L,458428L,1171552L,2872368L,6790656L,15544136L,34568576L,74901984L,158507008L,328277848L,666568592L,1329014992L,2605464320L,5028397952L,9563654976L,17942323424L,33232441344L,60814373780L,110029864416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258591Inst : IEnumerable<long>
{
public static readonly long[] Value=A258591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258591.Bytes);
public long this[int i]=>Value[i];

public static A258591Inst Instance=new A258591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258592
{
public static readonly long[] Value={ 0L,3L,4L,6L,7L,9L,11L,12L,13L,19L,20L,21L,24L,26L,29L,31L,32L,34L,36L,37L,39L,41L,43L,44L,45L,46L,47L,48L,51L,52L,53L,54L,55L,57L,58L,59L,60L,62L,63L,66L,69L,70L,72L,79L,80L,81L,83L,85L,86L,88L,89L,90L,91L,92L,94L,95L,96L,97L,100L,101L,102L,103L,105L,106L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258592Inst : IEnumerable<long>
{
public static readonly long[] Value=A258592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258592.Bytes);
public long this[int i]=>Value[i];

public static A258592Inst Instance=new A258592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258593
{
public static readonly long[] Value={ 1L,8L,46L,208L,805L,2776L,8742L,25584L,70450L,184232L,460832L,1108848L,2578295L,5814992L,12760598L,27317056L,57174768L,117223008L,235818894L,466154416L,906606234L,1736736024L,3280271526L,6114139616L,11255369609L,20478505104L,36849912318L,65619691088L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258593Inst : IEnumerable<long>
{
public static readonly long[] Value=A258593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258593.Bytes);
public long this[int i]=>Value[i];

public static A258593Inst Instance=new A258593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258594
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,2L,1L,2L,3L,2L,3L,2L,3L,2L,3L,5L,2L,2L,4L,6L,3L,1L,4L,2L,2L,3L,7L,3L,8L,4L,4L,4L,7L,9L,4L,3L,5L,8L,2L,3L,6L,3L,4L,4L,11L,10L,4L,4L,8L,3L,2L,3L,11L,3L,3L,3L,4L,5L,9L,9L,3L,3L,10L,3L,7L,4L,5L,14L,3L,1L,6L,10L,4L,4L,2L,6L,3L,2L,7L,10L,5L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258594Inst : IEnumerable<long>
{
public static readonly long[] Value=A258594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258594.Bytes);
public long this[int i]=>Value[i];

public static A258594Inst Instance=new A258594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258595
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,2L,1L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,3L,2L,3L,1L,2L,3L,4L,2L,1L,3L,2L,3L,2L,2L,3L,4L,3L,4L,2L,1L,2L,4L,4L,3L,3L,2L,3L,2L,3L,3L,2L,4L,3L,3L,3L,2L,3L,2L,2L,4L,3L,3L,2L,3L,1L,2L,2L,4L,3L,2L,4L,3L,2L,4L,2L,4L,2L,2L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258595Inst : IEnumerable<long>
{
public static readonly long[] Value=A258595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258595.Bytes);
public long this[int i]=>Value[i];

public static A258595Inst Instance=new A258595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258596
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,3L,2L,4L,4L,4L,6L,4L,6L,4L,4L,6L,4L,4L,8L,7L,6L,2L,8L,4L,4L,8L,14L,8L,9L,8L,12L,16L,14L,10L,12L,6L,16L,24L,4L,8L,36L,8L,16L,8L,12L,27L,16L,16L,28L,8L,4L,8L,22L,8L,8L,6L,16L,16L,42L,32L,6L,8L,20L,6L,48L,12L,16L,28L,8L,2L,12L,20L,16L,12L,4L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258596Inst : IEnumerable<long>
{
public static readonly long[] Value=A258596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258596.Bytes);
public long this[int i]=>Value[i];

public static A258596Inst Instance=new A258596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258597
{
public static readonly long[] Value={ 13L,39L,117L,351L,1053L,3159L,9477L,28431L,85293L,255879L,767637L,2302911L,6908733L,20726199L,62178597L,186535791L,559607373L,1678822119L,5036466357L,15109399071L,45328197213L,135984591639L,407953774917L,1223861324751L,3671583974253L,11014751922759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258597Inst : IEnumerable<long>
{
public static readonly long[] Value=A258597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258597.Bytes);
public long this[int i]=>Value[i];

public static A258597Inst Instance=new A258597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258598
{
public static readonly long[] Value={ 17L,51L,153L,459L,1377L,4131L,12393L,37179L,111537L,334611L,1003833L,3011499L,9034497L,27103491L,81310473L,243931419L,731794257L,2195382771L,6586148313L,19758444939L,59275334817L,177826004451L,533478013353L,1600434040059L,4801302120177L,14403906360531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258598Inst : IEnumerable<long>
{
public static readonly long[] Value=A258598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258598.Bytes);
public long this[int i]=>Value[i];

public static A258598Inst Instance=new A258598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258599
{
public static readonly long[] Value={ 2L,4L,6L,10L,16L,20L,28L,31L,39L,48L,51L,65L,71L,75L,84L,94L,107L,110L,120L,129L,133L,145L,152L,163L,180L,187L,191L,199L,202L,212L,238L,246L,258L,261L,282L,286L,297L,309L,319L,330L,342L,344L,366L,372L,377L,382L,407L,431L,440L,443L,450L,463L,468L,487L,498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258599Inst : IEnumerable<long>
{
public static readonly long[] Value=A258599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258599.Bytes);
public long this[int i]=>Value[i];

public static A258599Inst Instance=new A258599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258600
{
public static readonly long[] Value={ 2L,4L,8L,13L,23L,29L,39L,45L,57L,75L,80L,98L,108L,114L,126L,142L,161L,166L,183L,193L,196L,215L,227L,241L,261L,273L,278L,285L,294L,305L,338L,348L,366L,370L,393L,397L,412L,428L,435L,451L,465L,468L,492L,495L,509L,510L,535L,565L,574L,578L,588L,599L,601L,625L,638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258600Inst : IEnumerable<long>
{
public static readonly long[] Value=A258600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258600.Bytes);
public long this[int i]=>Value[i];

public static A258600Inst Instance=new A258600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258601
{
public static readonly long[] Value={ 2L,5L,10L,16L,28L,37L,55L,61L,80L,105L,112L,140L,160L,165L,183L,209L,236L,244L,265L,283L,289L,316L,335L,360L,389L,408L,414L,430L,435L,452L,505L,520L,542L,549L,589L,598L,613L,637L,651L,675L,697L,701L,737L,743L,754L,765L,806L,844L,866L,870L,880L,899L,908L,940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258601Inst : IEnumerable<long>
{
public static readonly long[] Value=A258601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258601.Bytes);
public long this[int i]=>Value[i];

public static A258601Inst Instance=new A258601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258602
{
public static readonly long[] Value={ 2L,5L,12L,20L,37L,45L,68L,82L,106L,142L,153L,194L,215L,227L,251L,290L,321L,336L,373L,395L,408L,442L,463L,499L,542L,566L,573L,600L,612L,634L,709L,728L,758L,769L,819L,831L,860L,895L,916L,947L,971L,980L,1034L,1043L,1057L,1069L,1131L,1190L,1208L,1219L,1240L,1265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258602Inst : IEnumerable<long>
{
public static readonly long[] Value=A258602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258602.Bytes);
public long this[int i]=>Value[i];

public static A258602Inst Instance=new A258602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258603
{
public static readonly long[] Value={ 2L,6L,13L,22L,45L,58L,87L,102L,135L,181L,198L,249L,281L,298L,331L,379L,430L,444L,488L,525L,539L,584L,620L,663L,720L,755L,767L,794L,810L,847L,944L,969L,1014L,1028L,1099L,1111L,1154L,1196L,1225L,1267L,1306L,1317L,1384L,1399L,1427L,1433L,1516L,1596L,1620L,1633L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258603Inst : IEnumerable<long>
{
public static readonly long[] Value=A258603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258603.Bytes);
public long this[int i]=>Value[i];

public static A258603Inst Instance=new A258603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258604
{
public static readonly long[] Value={ 7500L,567009L,8093970L,26101881L,49848864L,125328025L,298341960L,718508025L,1487084440L,3114086416L,5819271930L,11046430404L,19155054072L,33797513281L,55343787840L,92261025025L,144373839480L,229977793600L,346828695130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258604Inst : IEnumerable<long>
{
public static readonly long[] Value=A258604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258604.Bytes);
public long this[int i]=>Value[i];

public static A258604Inst Instance=new A258604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258605
{
public static readonly long[] Value={ 7500L,76729L,682356L,6056521L,46060932L,354117124L,2476716772L,17477633209L,115323919920L,766785689569L,4857669976665L,30962324784400L,190429804895616L,1176883728336121L,7081348901202170L,42770630476678225L,253149492547824624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258605Inst : IEnumerable<long>
{
public static readonly long[] Value=A258605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258605.Bytes);
public long this[int i]=>Value[i];

public static A258605Inst Instance=new A258605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258606
{
public static readonly long[] Value={ 76729L,567009L,2729104L,16806958L,90782784L,474650022L,2276816656L,10535922971L,45716854225L,193196028123L,780713616400L,3089065462326L,11835781060489L,44551750251450L,163755454109809L,593051074898232L,2109303841956964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258606Inst : IEnumerable<long>
{
public static readonly long[] Value=A258606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258606.Bytes);
public long this[int i]=>Value[i];

public static A258606Inst Instance=new A258606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258607
{
public static readonly long[] Value={ 682356L,2729104L,8093970L,20602521L,65662350L,206037316L,640379355L,1895470369L,5401266011L,14729220496L,39248673390L,101659583281L,259096554060L,646231093225L,1596389208750L,3877382377449L,9367919083092L,22311896261209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258607Inst : IEnumerable<long>
{
public static readonly long[] Value=A258607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258607.Bytes);
public long this[int i]=>Value[i];

public static A258607Inst Instance=new A258607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258608
{
public static readonly long[] Value={ 6056521L,16806958L,20602521L,26101881L,42003361L,87260319L,168065296L,336081087L,600593049L,1104953167L,1878008896L,3265742205L,5334257296L,8852106046L,13973131264L,22289465664L,34154366481L,52671100026L,78627524836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258608Inst : IEnumerable<long>
{
public static readonly long[] Value=A258608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258608.Bytes);
public long this[int i]=>Value[i];

public static A258608Inst Instance=new A258608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258609
{
public static readonly long[] Value={ 46060932L,90782784L,65662350L,42003361L,49848864L,80442961L,140873790L,244766025L,423931910L,720707716L,1218994536L,2017986084L,3322104840L,5349167044L,8565371976L,13422381025L,20921322092L,31951562500L,48551199120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258609Inst : IEnumerable<long>
{
public static readonly long[] Value=A258609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258609.Bytes);
public long this[int i]=>Value[i];

public static A258609Inst Instance=new A258609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258610
{
public static readonly long[] Value={ 354117124L,474650022L,206037316L,87260319L,80442961L,125328025L,194100624L,334357705L,528034441L,897939138L,1418275600L,2358323400L,3691413049L,5979099659L,9224834116L,14543625525L,22054329049L,33871221630L,50424498916L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258610Inst : IEnumerable<long>
{
public static readonly long[] Value=A258610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258610.Bytes);
public long this[int i]=>Value[i];

public static A258610Inst Instance=new A258610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258611
{
public static readonly long[] Value={ 2476716772L,2276816656L,640379355L,168065296L,140873790L,194100624L,298341960L,465437476L,732030024L,1152059364L,1817117950L,2847396321L,4458076344L,6902618724L,10661503972L,16244012304L,24669054520L,36915473956L,55041780794L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258611Inst : IEnumerable<long>
{
public static readonly long[] Value=A258611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258611.Bytes);
public long this[int i]=>Value[i];

public static A258611Inst Instance=new A258611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258612
{
public static readonly long[] Value={ 7500L,76729L,76729L,682356L,567009L,682356L,6056521L,2729104L,2729104L,6056521L,46060932L,16806958L,8093970L,16806958L,46060932L,354117124L,90782784L,20602521L,20602521L,90782784L,354117124L,2476716772L,474650022L,65662350L,26101881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258612Inst : IEnumerable<long>
{
public static readonly long[] Value=A258612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258612.Bytes);
public long this[int i]=>Value[i];

public static A258612Inst Instance=new A258612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258613
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,10L,11L,13L,14L,17L,19L,21L,23L,26L,27L,28L,29L,31L,32L,33L,34L,37L,41L,43L,47L,50L,51L,52L,53L,54L,55L,57L,58L,59L,60L,61L,62L,65L,67L,69L,71L,73L,75L,77L,79L,82L,83L,85L,86L,88L,89L,91L,92L,94L,95L,97L,98L,101L,103L,107L,109L,111L,113L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258613Inst : IEnumerable<long>
{
public static readonly long[] Value=A258613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258613.Bytes);
public long this[int i]=>Value[i];

public static A258613Inst Instance=new A258613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258614
{
public static readonly long[] Value={ 4L,6L,8L,9L,12L,15L,16L,18L,20L,22L,24L,25L,30L,35L,36L,38L,39L,40L,42L,44L,45L,46L,48L,49L,56L,63L,64L,66L,68L,70L,72L,74L,76L,78L,80L,81L,84L,87L,90L,93L,96L,99L,100L,102L,104L,105L,106L,108L,110L,112L,114L,115L,116L,118L,120L,121L,132L,143L,144L,146L,147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258614Inst : IEnumerable<long>
{
public static readonly long[] Value=A258614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258614.Bytes);
public long this[int i]=>Value[i];

public static A258614Inst Instance=new A258614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258615
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,6L,2L,2L,4L,6L,4L,2L,8L,8L,8L,2L,6L,8L,12L,4L,10L,168L,8L,4L,6L,12L,12L,8L,8L,16L,24L,8L,16L,12L,12L,6L,16L,192L,16L,12L,12L,24L,16L,10L,22L,192L,12L,8L,32L,16L,24L,6L,32L,336L,36L,12L,28L,192L,16L,8L,288L,32L,192L,24L,20L,32L,60L,16L,24L,336L,24L,12L,32L,36L,48L,16L,24L,1536L,18L,16L,40L,336L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258615Inst : IEnumerable<long>
{
public static readonly long[] Value=A258615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258615.Bytes);
public long this[int i]=>Value[i];

public static A258615Inst Instance=new A258615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258616
{
public static readonly long[] Value={ 7L,9L,13L,17L,25L,185L,197L,261L,407L,593L,1535L,2129L,2139L,2581L,4133L,4665L,15787L,25337L,27449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258616Inst : IEnumerable<long>
{
public static readonly long[] Value=A258616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258616.Bytes);
public long this[int i]=>Value[i];

public static A258616Inst Instance=new A258616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258617
{
public static readonly long[] Value={ 0L,12L,64L,180L,384L,700L,1152L,1764L,2560L,3564L,4800L,6292L,8064L,10140L,12544L,15300L,18432L,21964L,25920L,30324L,35200L,40572L,46464L,52900L,59904L,67500L,75712L,84564L,94080L,104284L,115200L,126852L,139264L,152460L,166464L,181300L,196992L,213564L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258617Inst : IEnumerable<long>
{
public static readonly long[] Value=A258617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258617.Bytes);
public long this[int i]=>Value[i];

public static A258617Inst Instance=new A258617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258618
{
public static readonly long[] Value={ 0L,13L,68L,189L,400L,725L,1188L,1813L,2624L,3645L,4900L,6413L,8208L,10309L,12740L,15525L,18688L,22253L,26244L,30685L,35600L,41013L,46948L,53429L,60480L,68125L,76388L,85293L,94864L,105125L,116100L,127813L,140288L,153549L,167620L,182525L,198288L,214933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258618Inst : IEnumerable<long>
{
public static readonly long[] Value=A258618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258618.Bytes);
public long this[int i]=>Value[i];

public static A258618Inst Instance=new A258618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258619
{
public static readonly long[] Value={ 2L,2L,5L,6L,9L,5L,6L,5L,0L,1L,6L,0L,8L,8L,5L,1L,4L,9L,5L,0L,2L,8L,4L,5L,7L,6L,3L,7L,0L,7L,7L,6L,5L,4L,8L,5L,1L,5L,6L,7L,6L,6L,3L,5L,1L,4L,3L,7L,5L,5L,7L,5L,9L,2L,4L,9L,8L,8L,4L,6L,7L,5L,4L,0L,5L,5L,8L,2L,8L,8L,8L,2L,8L,4L,3L,1L,7L,8L,8L,7L,2L,9L,6L,3L,7L,4L,3L,3L,2L,8L,5L,7L,3L,7L,9L,5L,5L,4L,4L,9L,7L,2L,4L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258619Inst : IEnumerable<long>
{
public static readonly long[] Value=A258619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258619.Bytes);
public long this[int i]=>Value[i];

public static A258619Inst Instance=new A258619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258620
{
public static readonly BigInteger[] Value={ 1L,1L,2L,13L,114L,1509L,25595L,535753L,13305590L,382728552L,12515198465L,458621603279L,18619063906689L,829607273337513L,40253392454978755L,2112878091130119496L,BigInteger.Parse("119296114546292088543"),BigInteger.Parse("7209829960147215492897"),BigInteger.Parse("464413707136960430809460"),BigInteger.Parse("31762965767675300603026848") };
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
public class A258620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258620Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258620.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258620Inst Instance=new A258620Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258621
{
public static readonly long[] Value={ 2L,2L,5L,6L,9L,4L,7L,4L,5L,8L,5L,2L,6L,5L,9L,7L,9L,5L,5L,4L,6L,2L,7L,3L,6L,7L,2L,4L,4L,4L,2L,3L,4L,2L,2L,1L,0L,5L,5L,9L,2L,3L,6L,5L,0L,8L,8L,9L,3L,6L,9L,5L,9L,5L,3L,3L,4L,6L,0L,0L,4L,9L,6L,0L,9L,2L,6L,7L,5L,4L,9L,2L,8L,1L,7L,5L,2L,2L,0L,0L,6L,7L,7L,6L,1L,4L,8L,9L,6L,2L,1L,3L,3L,1L,7L,7L,7L,7L,7L,7L,2L,8L,5L,6L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258621Inst : IEnumerable<long>
{
public static readonly long[] Value=A258621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258621.Bytes);
public long this[int i]=>Value[i];

public static A258621Inst Instance=new A258621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258622
{
public static readonly BigInteger[] Value={ 2L,8L,44L,704L,124784L,3114359072L,1616538741858202448L,BigInteger.Parse("373313929132642872042128187516973184"),BigInteger.Parse("17420411210556488056172048238850552742971470265342499948186222078482064") };
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
public class A258622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258622Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258622.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258622Inst Instance=new A258622Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258623
{
public static readonly BigInteger[] Value={ 1L,6L,45L,264L,2094L,20462L,290231L,4010997L,78604973L,1349514483L,35927257375L,779039452374L,22813001639693L,625228016584233L,20522243952244064L,592853223364296015L,BigInteger.Parse("23932818802986466719"),BigInteger.Parse("759286889246491909554") };
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
public class A258623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258623Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258623.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258623Inst Instance=new A258623Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258624
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,27L,33L,35L,45L,60L,68L,80L,106L,142L,211L,343L,504L,637L,790L,1130L,1763L,2609L,3568L,4642L,5797L,7056L,8768L,11568L,16417L,24675L,37552L,56272L,83937L,125305L,182162L,252228L,339708L,467272L,669375L,968670L,1362912L,1838792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258624Inst : IEnumerable<long>
{
public static readonly long[] Value=A258624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258624.Bytes);
public long this[int i]=>Value[i];

public static A258624Inst Instance=new A258624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258625
{
public static readonly long[] Value={ 2L,6L,18L,50L,105L,181L,316L,560L,969L,1777L,3699L,8370L,18297L,36978L,73912L,155816L,335928L,697052L,1360137L,2539247L,4757378L,9452951L,20357207L,46362252L,107298090L,244529803L,538892048L,1146917302L,2392827002L,4981802096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258625Inst : IEnumerable<long>
{
public static readonly long[] Value=A258625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258625.Bytes);
public long this[int i]=>Value[i];

public static A258625Inst Instance=new A258625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258626
{
public static readonly long[] Value={ 3L,12L,45L,130L,331L,834L,2115L,5726L,16873L,50003L,142116L,400694L,1157686L,3355089L,9458656L,26092189L,72995360L,213171551L,647222852L,1987679608L,6016219942L,17773719595L,51564943489L,148469880307L,426108755766L,1217647287273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258626Inst : IEnumerable<long>
{
public static readonly long[] Value=A258626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258626.Bytes);
public long this[int i]=>Value[i];

public static A258626Inst Instance=new A258626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258627
{
public static readonly long[] Value={ 4L,20L,80L,264L,809L,2506L,8432L,30362L,109520L,391836L,1408127L,5002188L,17308136L,59463783L,210199210L,774578726L,2918410859L,10951007498L,40430881133L,146973680685L,527988483182L,1880363101497L,6679919969564L,23928818399537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258627Inst : IEnumerable<long>
{
public static readonly long[] Value=A258627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258627.Bytes);
public long this[int i]=>Value[i];

public static A258627Inst Instance=new A258627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258628
{
public static readonly long[] Value={ 5L,28L,125L,511L,2094L,9099L,40789L,182685L,818100L,3633049L,15953405L,70733998L,322727518L,1503364221L,6999445956L,32165622185L,145740232841L,653796230890L,2924195396658L,13163600932253L,60217177382329L,281484384355033L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258628Inst : IEnumerable<long>
{
public static readonly long[] Value=A258628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258628.Bytes);
public long this[int i]=>Value[i];

public static A258628Inst Instance=new A258628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258629
{
public static readonly long[] Value={ 6L,36L,179L,830L,4021L,20462L,105719L,546640L,2789557L,14124297L,72747664L,384855118L,2060047003L,10964114671L,57622430383L,299660342435L,1554362454308L,8134330914022L,43385023307315L,236387936969270L,1304057368544653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258629Inst : IEnumerable<long>
{
public static readonly long[] Value=A258629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258629.Bytes);
public long this[int i]=>Value[i];

public static A258629Inst Instance=new A258629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258630
{
public static readonly long[] Value={ 7L,46L,257L,1408L,8116L,48479L,290231L,1702510L,9898375L,58647747L,356650813L,2191890734L,13394053841L,80981875492L,487503501433L,2957456918572L,18257437602958L,114623886164224L,722845143635980L,4506034402708909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258630Inst : IEnumerable<long>
{
public static readonly long[] Value=A258630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258630.Bytes);
public long this[int i]=>Value[i];

public static A258630Inst Instance=new A258630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258631
{
public static readonly long[] Value={ 1L,2L,2L,3L,6L,4L,4L,12L,18L,8L,5L,20L,45L,50L,16L,6L,28L,80L,130L,105L,27L,7L,36L,125L,264L,331L,181L,33L,8L,46L,179L,511L,809L,834L,316L,35L,9L,56L,257L,830L,2094L,2506L,2115L,560L,45L,9L,67L,345L,1408L,4021L,9099L,8432L,5726L,969L,60L,10L,73L,468L,2150L,8116L,20462L,40789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258631Inst : IEnumerable<long>
{
public static readonly long[] Value=A258631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258631.Bytes);
public long this[int i]=>Value[i];

public static A258631Inst Instance=new A258631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258632
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,9L,10L,10L,11L,12L,13L,13L,14L,14L,15L,16L,17L,17L,18L,19L,20L,21L,22L,22L,23L,23L,24L,25L,26L,27L,28L,28L,29L,30L,31L,31L,32L,32L,33L,34L,35L,35L,36L,37L,38L,39L,40L,40L,41L,42L,43L,44L,45L,45L,46L,46L,47L,48L,49L,50L,51L,51L,52L,53L,54L,54L,55L,55L,56L,57L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258632Inst : IEnumerable<long>
{
public static readonly long[] Value=A258632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258632.Bytes);
public long this[int i]=>Value[i];

public static A258632Inst Instance=new A258632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258633
{
public static readonly long[] Value={ 2L,6L,12L,20L,28L,36L,46L,56L,67L,73L,88L,95L,113L,131L,151L,160L,186L,196L,224L,250L,278L,290L,323L,354L,389L,422L,460L,476L,520L,536L,579L,622L,667L,712L,762L,781L,831L,881L,935L,957L,1018L,1041L,1102L,1160L,1224L,1250L,1321L,1386L,1458L,1525L,1596L,1625L,1702L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258633Inst : IEnumerable<long>
{
public static readonly long[] Value=A258633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258633.Bytes);
public long this[int i]=>Value[i];

public static A258633Inst Instance=new A258633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258634
{
public static readonly long[] Value={ 4L,18L,45L,80L,125L,179L,257L,345L,468L,560L,761L,888L,1153L,1433L,1773L,1990L,2492L,2757L,3339L,3896L,4557L,4956L,5839L,6656L,7629L,8581L,9741L,10412L,11889L,12630L,14121L,15621L,17291L,18979L,21036L,22123L,24235L,26337L,28748L,30115L,33021L,34520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258634Inst : IEnumerable<long>
{
public static readonly long[] Value=A258634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258634.Bytes);
public long this[int i]=>Value[i];

public static A258634Inst Instance=new A258634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258635
{
public static readonly long[] Value={ 8L,50L,130L,264L,511L,830L,1408L,2150L,3370L,4440L,6789L,8523L,12040L,15918L,21093L,25067L,33736L,39265L,50407L,61663L,75967L,86154L,106965L,126656L,151573L,176764L,208836L,230806L,275399L,301753L,349082L,397630L,454178L,512455L,587697L,633984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258635Inst : IEnumerable<long>
{
public static readonly long[] Value=A258635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258635.Bytes);
public long this[int i]=>Value[i];

public static A258635Inst Instance=new A258635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258636
{
public static readonly long[] Value={ 16L,105L,331L,809L,2094L,4021L,8116L,14058L,25047L,35962L,60921L,82097L,125940L,177885L,254541L,320737L,462767L,566354L,770435L,986891L,1278221L,1512371L,1975937L,2434273L,3044409L,3681132L,4523992L,5167464L,6430586L,7262903L,8678872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258636Inst : IEnumerable<long>
{
public static readonly long[] Value=A258636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258636.Bytes);
public long this[int i]=>Value[i];

public static A258636Inst Instance=new A258636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258637
{
public static readonly long[] Value={ 27L,181L,834L,2506L,9099L,20462L,48479L,93595L,186047L,290231L,547112L,796644L,1331817L,2015891L,3105402L,4138454L,6378171L,8209966L,11853247L,15922388L,21715915L,26819170L,36820418L,47145913L,61470774L,76964731L,98287277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258637Inst : IEnumerable<long>
{
public static readonly long[] Value=A258637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258637.Bytes);
public long this[int i]=>Value[i];

public static A258637Inst Instance=new A258637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258638
{
public static readonly long[] Value={ 33L,316L,2115L,8432L,40789L,105719L,290231L,615072L,1376125L,2357746L,4980833L,7842482L,14253622L,23019880L,37955879L,53553640L,88436758L,120061819L,183877123L,258843359L,370889319L,477163075L,687457306L,913900212L,1241075611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258638Inst : IEnumerable<long>
{
public static readonly long[] Value=A258638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258638.Bytes);
public long this[int i]=>Value[i];

public static A258638Inst Instance=new A258638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258639
{
public static readonly long[] Value={ 5L,4L,1L,7L,2L,0L,0L,2L,1L,9L,5L,8L,1L,4L,4L,4L,3L,3L,8L,6L,9L,3L,2L,2L,8L,0L,2L,8L,7L,1L,7L,6L,7L,4L,3L,8L,4L,7L,7L,7L,0L,5L,7L,7L,1L,7L,3L,0L,5L,0L,0L,1L,3L,5L,1L,2L,3L,7L,3L,1L,1L,9L,2L,7L,9L,4L,1L,3L,7L,0L,8L,7L,0L,1L,0L,4L,1L,8L,2L,5L,3L,0L,2L,5L,8L,1L,4L,8L,7L,9L,1L,0L,1L,6L,7L,4L,3L,5L,0L,9L,6L,5L,0L,8L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258639Inst : IEnumerable<long>
{
public static readonly long[] Value=A258639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258639.Bytes);
public long this[int i]=>Value[i];

public static A258639Inst Instance=new A258639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258640
{
public static readonly long[] Value={ 1L,3L,4L,8L,9L,80L,9L,69L,0L,7L,7L,8L,2L,0L,5L,3L,7L,0L,9L,0L,8L,37L,4L,0L,55L,75L,99L,50L,7L,0L,5L,97L,27L,9L,1L,9L,8L,55L,9L,48L,87L,2L,8L,36L,95L,79L,25L,3L,88L,20L,5L,47L,8L,6L,37L,70L,54L,60L,8L,8L,60L,4L,50L,0L,5L,2L,6L,0L,7L,130L,18L,86L,2L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258640Inst : IEnumerable<long>
{
public static readonly long[] Value=A258640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258640.Bytes);
public long this[int i]=>Value[i];

public static A258640Inst Instance=new A258640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258641
{
public static readonly long[] Value={ 12L,8L,36L,16L,8L,12L,40L,8L,36L,36L,12L,28L,8L,72L,60L,24L,108L,60L,60L,48L,60L,60L,24L,76L,8L,72L,12L,48L,40L,8L,12L,120L,72L,88L,20L,60L,60L,60L,60L,84L,36L,12L,72L,156L,60L,72L,60L,48L,12L,60L,48L,288L,12L,60L,252L,168L,12L,120L,60L,88L,8L,12L,60L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258641Inst : IEnumerable<long>
{
public static readonly long[] Value=A258641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258641.Bytes);
public long this[int i]=>Value[i];

public static A258641Inst Instance=new A258641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258642
{
public static readonly long[] Value={ 3L,3L,5L,5L,3L,5L,7L,3L,5L,5L,13L,11L,3L,5L,13L,17L,5L,11L,19L,19L,7L,13L,17L,5L,3L,5L,13L,19L,17L,3L,5L,7L,17L,31L,3L,7L,13L,17L,37L,23L,5L,37L,11L,5L,43L,37L,29L,31L,7L,29L,31L,17L,5L,7L,13L,31L,43L,11L,19L,41L,3L,5L,7L,13L,29L,23L,47L,11L,37L,59L,31L,47L,7L,13L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258642Inst : IEnumerable<long>
{
public static readonly long[] Value=A258642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258642.Bytes);
public long this[int i]=>Value[i];

public static A258642Inst Instance=new A258642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258643
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,2L,9L,7L,4L,4L,5L,2L,25L,11L,40L,8L,33L,3L,16L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258643Inst : IEnumerable<long>
{
public static readonly long[] Value=A258643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258643.Bytes);
public long this[int i]=>Value[i];

public static A258643Inst Instance=new A258643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258644
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,0L,0L,0L,80L,0L,0L,0L,176L,0L,1L,32L,368L,0L,1L,0L,112L,0L,0L,0L,240L,0L,16L,27L,368L,0L,0L,0L,752L,5L,0L,80L,272L,0L,1L,176L,220L,0L,0L,0L,608L,80L,1L,0L,1552L,5L,32L,48L,272L,0L,540L,176L,560L,0L,0L,0L,560L,0L,6L,44L,7168L,7L,0L,0L,284L,12L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258644Inst : IEnumerable<long>
{
public static readonly long[] Value=A258644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258644.Bytes);
public long this[int i]=>Value[i];

public static A258644Inst Instance=new A258644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258645
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,0L,0L,0L,176L,0L,0L,0L,368L,0L,0L,80L,752L,0L,0L,0L,240L,0L,0L,0L,608L,0L,32L,27L,752L,0L,0L,0L,1520L,1L,0L,176L,560L,0L,0L,368L,284L,0L,0L,0L,1552L,176L,0L,0L,3120L,1L,80L,112L,560L,0L,1188L,368L,1312L,0L,0L,0L,1312L,0L,5L,48L,36864L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258645Inst : IEnumerable<long>
{
public static readonly long[] Value=A258645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258645.Bytes);
public long this[int i]=>Value[i];

public static A258645Inst Instance=new A258645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258646
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,0L,0L,0L,368L,0L,0L,0L,752L,0L,0L,176L,1520L,0L,0L,0L,608L,0L,0L,0L,1552L,0L,80L,27L,1520L,0L,0L,0L,3424L,0L,0L,368L,1312L,0L,0L,752L,288L,0L,0L,0L,3120L,368L,0L,0L,8144L,0L,176L,240L,1312L,0L,2484L,752L,3312L,0L,0L,0L,3312L,0L,1L,112L,245760L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258646Inst : IEnumerable<long>
{
public static readonly long[] Value=A258646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258646.Bytes);
public long this[int i]=>Value[i];

public static A258646Inst Instance=new A258646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258647
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,0L,0L,0L,752L,0L,0L,0L,1520L,0L,0L,368L,3424L,0L,0L,0L,1552L,0L,0L,0L,3120L,0L,176L,27L,3424L,0L,0L,0L,8592L,0L,0L,752L,3312L,0L,0L,1520L,912L,0L,0L,0L,8144L,752L,0L,0L,16304L,0L,368L,608L,3312L,0L,5076L,1520L,8976L,0L,0L,0L,8976L,0L,0L,240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258647Inst : IEnumerable<long>
{
public static readonly long[] Value=A258647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258647.Bytes);
public long this[int i]=>Value[i];

public static A258647Inst Instance=new A258647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258648
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,0L,0L,0L,1520L,0L,0L,0L,3424L,0L,0L,752L,8592L,0L,0L,0L,3120L,0L,0L,0L,8144L,0L,368L,27L,8592L,0L,0L,0L,20096L,0L,0L,1520L,8976L,0L,0L,3424L,2176L,0L,0L,0L,16304L,1520L,0L,0L,32624L,0L,752L,1552L,8976L,0L,10260L,3424L,22288L,0L,0L,0L,22288L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258648Inst : IEnumerable<long>
{
public static readonly long[] Value=A258648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258648.Bytes);
public long this[int i]=>Value[i];

public static A258648Inst Instance=new A258648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258649
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,0L,0L,0L,3424L,0L,0L,0L,8592L,0L,0L,1520L,20096L,0L,0L,0L,8144L,0L,0L,0L,16304L,0L,752L,27L,20096L,0L,0L,0L,70464L,0L,0L,3424L,22288L,0L,0L,8592L,7744L,0L,0L,0L,32624L,3424L,0L,0L,65264L,0L,1520L,3120L,22288L,0L,23112L,8592L,47872L,0L,0L,0L,47872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258649Inst : IEnumerable<long>
{
public static readonly long[] Value=A258649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258649.Bytes);
public long this[int i]=>Value[i];

public static A258649Inst Instance=new A258649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258650
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,0L,0L,0L,8592L,0L,0L,0L,20096L,0L,0L,3424L,70464L,0L,0L,0L,16304L,0L,0L,0L,32624L,0L,1520L,27L,70464L,0L,0L,0L,235072L,0L,0L,8592L,47872L,0L,0L,20096L,24640L,0L,0L,0L,65264L,8592L,0L,0L,130544L,0L,3424L,8144L,47872L,0L,57996L,20096L,198656L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258650Inst : IEnumerable<long>
{
public static readonly long[] Value=A258650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258650.Bytes);
public long this[int i]=>Value[i];

public static A258650Inst Instance=new A258650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258651
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,2L,0L,0L,1L,3L,0L,0L,0L,1L,4L,0L,0L,0L,0L,4L,5L,0L,0L,0L,0L,4L,1L,6L,0L,0L,0L,0L,4L,0L,5L,7L,0L,0L,0L,0L,4L,0L,1L,1L,8L,0L,0L,0L,0L,4L,0L,0L,0L,12L,9L,0L,0L,0L,0L,4L,0L,0L,0L,16L,6L,10L,0L,0L,0L,0L,4L,0L,0L,0L,32L,5L,7L,11L,0L,0L,0L,0L,4L,0L,0L,0L,80L,1L,1L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258651Inst : IEnumerable<long>
{
public static readonly long[] Value=A258651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258651.Bytes);
public long this[int i]=>Value[i];

public static A258651Inst Instance=new A258651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258652
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,9L,11L,16L,14L,25L,36L,59L,99L,209L,419L,860L,1730L,3862L,9464L,21868L,74371L,244648L,727345L,3098351L,13469007L,56269849L,281642632L,1406177909L,9597415332L,58891421656L,411673964638L,3406742649805L,24202753250241L,176482943622608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258652Inst : IEnumerable<long>
{
public static readonly long[] Value=A258652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258652.Bytes);
public long this[int i]=>Value[i];

public static A258652Inst Instance=new A258652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258653
{
public static readonly long[] Value={ 5L,7L,7L,11L,13L,13L,13L,17L,17L,19L,17L,19L,23L,23L,23L,23L,29L,31L,29L,31L,37L,37L,37L,41L,43L,43L,43L,41L,43L,47L,47L,47L,47L,41L,53L,53L,53L,53L,43L,53L,59L,47L,59L,61L,47L,53L,59L,59L,67L,61L,61L,67L,73L,73L,73L,71L,67L,79L,79L,71L,83L,83L,83L,83L,79L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258653Inst : IEnumerable<long>
{
public static readonly long[] Value=A258653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258653.Bytes);
public long this[int i]=>Value[i];

public static A258653Inst Instance=new A258653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258654
{
public static readonly long[] Value={ 1L,2L,1L,3L,5L,4L,3L,7L,6L,7L,2L,4L,10L,9L,5L,3L,12L,10L,5L,6L,15L,12L,10L,18L,20L,19L,15L,11L,13L,22L,21L,20L,15L,5L,25L,23L,20L,18L,3L,15L,27L,5L,24L,28L,2L,8L,15L,14L,30L,16L,15L,25L,34L,33L,30L,20L,12L,34L,30L,15L,40L,39L,38L,35L,25L,30L,13L,39L,23L,6L,29L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258654Inst : IEnumerable<long>
{
public static readonly long[] Value=A258654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258654.Bytes);
public long this[int i]=>Value[i];

public static A258654Inst Instance=new A258654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258655
{
public static readonly long[] Value={ 1L,5L,7L,-19L,21L,59L,57L,-115L,61L,145L,111L,-253L,157L,285L,147L,-499L,307L,545L,343L,-599L,399L,643L,553L,-1501L,521L,889L,547L,-1083L,813L,1759L,993L,-2035L,777L,1535L,1197L,-2359L,1333L,1867L,1099L,-3575L,1723L,3363L,1807L,-2549L,1281L,2765L,2257L,-6493L,2801L,3645L,2149L,-3503L,2757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258655Inst : IEnumerable<long>
{
public static readonly long[] Value=A258655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258655.Bytes);
public long this[int i]=>Value[i];

public static A258655Inst Instance=new A258655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258656
{
public static readonly long[] Value={ 1L,1L,3L,5L,2L,10L,13L,23L,43L,57L,66L,96L,183L,229L,375L,509L,619L,883L,1395L,1947L,2487L,3603L,4627L,6273L,8934L,12432L,15637L,20943L,29147L,37613L,50296L,67870L,88542L,113240L,153682L,201900L,257125L,338397L,446354L,570098L,734576L,966634L,1234879L,1574763L,2048746L,2634002L,3322639L,4268611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258656Inst : IEnumerable<long>
{
public static readonly long[] Value=A258656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258656.Bytes);
public long this[int i]=>Value[i];

public static A258656Inst Instance=new A258656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258657
{
public static readonly BigInteger[] Value={ 1L,1L,3L,63L,1449L,79569L,4933467L,538446447L,64308790161L,11702872619361L,2287996769790963L,625623383080392543L,BigInteger.Parse("181555646645074399929"),BigInteger.Parse("69630517380932205676209"),BigInteger.Parse("28096571683140898776853707"),BigInteger.Parse("14391876463069615780007165967"),BigInteger.Parse("7705942233644896318623038389281"),BigInteger.Parse("5082509306223148713110677899062721") };
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
public class A258657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258657Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258657.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258657Inst Instance=new A258657Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258658
{
public static readonly BigInteger[] Value={ 1L,1L,3L,123L,3129L,313929L,23062347L,4461062067L,655619300721L,207299066045841L,51139145307699603L,BigInteger.Parse("23947711418548452843"),BigInteger.Parse("8930007221716001596329"),BigInteger.Parse("5800583064218449362313689"),BigInteger.Parse("3049682921576823757255485147"),BigInteger.Parse("2622347479175212075411836474147"),BigInteger.Parse("1849810669560927151969244969258721") };
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
public class A258658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258658Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258658.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258658Inst Instance=new A258658Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258659
{
public static readonly BigInteger[] Value={ 1L,1L,3L,18L,189L,3024L,68607L,2095632L,82908441L,4124203776L,251944606683L,18542621357568L,1618221395188629L,165230649971380224L,BigInteger.Parse("19514714407120367127"),BigInteger.Parse("2639737292796971845632"),BigInteger.Parse("405452689572115086887601"),BigInteger.Parse("70178277847381981514366976"),BigInteger.Parse("13596354857453497541480646963"),BigInteger.Parse("2930800480466007704630652960768") };
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
public class A258659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258659Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258659.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258659Inst Instance=new A258659Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258660
{
public static readonly long[] Value={ 1L,4L,9L,1521L,3600L,7396L,8100L,103041L,120409L,160801L,11471769L,11655396L,12802084L,15210000L,22724289L,36000000L,42889401L,42928704L,45481536L,45968400L,46009089L,54567769L,61811044L,62236321L,70006689L,73925604L,73960000L,76965529L,79174404L,81000000L,85008400L,97693456L,97713225L,100000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258660Inst : IEnumerable<long>
{
public static readonly long[] Value=A258660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258660.Bytes);
public long this[int i]=>Value[i];

public static A258660Inst Instance=new A258660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258661
{
public static readonly long[] Value={ 1L,2L,1009L,3598L,4354L,9214L,11662L,15051L,15052L,15873L,15874L,19042L,21772L,22497L,22498L,24334L,26242L,46654L,60514L,76173L,76174L,93634L,97341L,97342L,108898L,112893L,112894L,121101L,121102L,133954L,152098L,156813L,156814L,166462L,171393L,171394L,181473L,181474L,202498L,213441L,213442L,224674L,236193L,236194L,254013L,254014L,266253L,266254L,272482L,278781L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258661Inst : IEnumerable<long>
{
public static readonly long[] Value=A258661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258661.Bytes);
public long this[int i]=>Value[i];

public static A258661Inst Instance=new A258661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258662
{
public static readonly BigInteger[] Value={ 1L,1L,4L,40L,760L,23200L,1038400L,64081600L,5214880000L,541085248000L,69718686400000L,10921720817920000L,2044231370959360000L,BigInteger.Parse("450550323286412800000"),BigInteger.Parse("115495483535461427200000"),BigInteger.Parse("34070943029324134912000000"),BigInteger.Parse("11460293146666575236608000000"),BigInteger.Parse("4360020024970859812710400000000"),BigInteger.Parse("1862768688935303816870072320000000") };
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
public class A258662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258662Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258662.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258662Inst Instance=new A258662Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258663
{
public static readonly long[] Value={ 2L,6L,8L,10L,12L,20L,22L,26L,28L,30L,40L,48L,50L,52L,56L,58L,62L,66L,72L,76L,78L,80L,86L,90L,92L,96L,98L,106L,108L,118L,122L,128L,132L,136L,140L,142L,152L,160L,166L,168L,176L,178L,180L,182L,190L,208L,210L,212L,220L,222L,230L,232L,238L,246L,252L,260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258663Inst : IEnumerable<long>
{
public static readonly long[] Value=A258663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258663.Bytes);
public long this[int i]=>Value[i];

public static A258663Inst Instance=new A258663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258664
{
public static readonly BigInteger[] Value={ 0L,0L,1L,1L,4L,20L,115L,787L,6184L,54888L,542805L,5916725L,70463900L,910167596L,12672415015L,189181881575L,3014307220880L,51054940726928L,915987174021609L,17352888926841897L,346144782915314740L,7251738265074465220L,BigInteger.Parse("159193007549552845339"),BigInteger.Parse("3654204694819144118651") };
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
public class A258664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258664Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258664.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258664Inst Instance=new A258664Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258665
{
public static readonly BigInteger[] Value={ 0L,0L,0L,1L,5L,20L,116L,791L,6203L,55000L,543576L,5922813L,70518113L,910704988L,12678282940L,189251856883L,3015212009143L,51067548545968L,916175515710896L,17355891466436025L,346195661281979133L,7252651426282955236L,BigInteger.Parse("159210312386078554436"),BigInteger.Parse("3654549974493252076175") };
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
public class A258665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258665Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258665.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258665Inst Instance=new A258665Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258666
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,4L,20L,117L,791L,6204L,55004L,543595L,5922925L,70518884L,910711076L,12678337153L,189252394275L,3015217877068L,51067618521276L,916176420499159L,17355904074255065L,346195849623668420L,7252654428822549364L,BigInteger.Parse("159210363264445218829"),BigInteger.Parse("3654550887654460566191") };
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
public class A258666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258666Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258666.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258666Inst Instance=new A258666Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258667
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,20L,116L,791L,6205L,55004L,543596L,5922929L,70518903L,910711188L,12678337924L,189252400363L,3015217931281L,51067619058668L,916176426367084L,17355904144230373L,346195850528456683L,7252654441430368404L,BigInteger.Parse("159210363452786908116"),BigInteger.Parse("3654550890657000160319") };
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
public class A258667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258667Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258667.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258667Inst Instance=new A258667Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258668
{
public static readonly BigInteger[] Value={ 0L,1L,1L,2L,9L,333L,436140L,43079658188L,416768277321177570L,BigInteger.Parse("479533252041533318548951081"),BigInteger.Parse("82915824358567616469138110469031459201"),BigInteger.Parse("2733701379858734057121091262990514105871808751388190"),BigInteger.Parse("21440005073020480325389224271234447054906430340227337359088146738881") };
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
public class A258668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258668Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258668.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258668Inst Instance=new A258668Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258669
{
public static readonly BigInteger[] Value={ 0L,1L,3L,19L,1033L,1302311L,74312057469L,291484874476601933L,BigInteger.Parse("109290159404495354765494065"),BigInteger.Parse("5262212497884462986538879797523944401"),BigInteger.Parse("42425405450182072688801993326226988336684453926401"),BigInteger.Parse("72600595215718916449806606426629386781199080157371905867835756161") };
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
public class A258669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258669Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258669.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258669Inst Instance=new A258669Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258670
{
public static readonly BigInteger[] Value={ 0L,1L,13L,43561L,455366036161L,BigInteger.Parse("60209252317216962943201"),BigInteger.Parse("291857679749953126623181556402787323521"),BigInteger.Parse("120972618144269517756284629487432992029777542693069847287041") };
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
public class A258670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258670Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258670.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258670Inst Instance=new A258670Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258671
{
public static readonly BigInteger[] Value={ 0L,1L,3L,127L,1361953L,14961046326601L,BigInteger.Parse("433366367372593816560481"),BigInteger.Parse("74029504174329565838647515081008812321"),BigInteger.Parse("147684970947386323832216294475743896349724799651361817601") };
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
public class A258671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258671Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258671.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258671Inst Instance=new A258671Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258672
{
public static readonly BigInteger[] Value={ 0L,1L,5L,61L,2280L,273052L,110537709L,156456474138L,790541795804221L,14445283925963101577UL,BigInteger.Parse("963056085414756870071490"),BigInteger.Parse("235864774408401842540220265704"),BigInteger.Parse("213426797830699546133563821747980513"),BigInteger.Parse("717147073290996884137625501875655000693923") };
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
public class A258672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258672Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258672.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258672Inst Instance=new A258672Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258673
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,0L,115L,791L,6204L,55004L,543597L,5922929L,70518904L,910711192L,12678337943L,189252400475L,3015217932052L,51067619064756L,916176426421297L,17355904144767765L,346195850534324608L,7252654441500343712L,BigInteger.Parse("159210363453691696379"),BigInteger.Parse("3654550890669607979359") };
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
public class A258673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258673Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258673.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258673Inst Instance=new A258673Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258674
{
public static readonly long[] Value={ 320L,1600L,8320L,43264L,219648L,1115136L,5744640L,29593600L,151101440L,771506176L,3960635392L,20332478464L,104035123200L,532316160000L,2729194291200L,13992627011584L,71652362682368L,366911879643136L,1880261562204160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258674Inst : IEnumerable<long>
{
public static readonly long[] Value=A258674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258674.Bytes);
public long this[int i]=>Value[i];

public static A258674Inst Instance=new A258674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258675
{
public static readonly long[] Value={ 1600L,10000L,67600L,456976L,2944656L,18974736L,125888400L,835210000L,5443488400L,35477982736L,233749042576L,1540071072016L,10079990010000L,65975006250000L,433559848410000L,2849172024948496L,18677605395953296L,122440112521198096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258675Inst : IEnumerable<long>
{
public static readonly long[] Value=A258675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258675.Bytes);
public long this[int i]=>Value[i];

public static A258675Inst Instance=new A258675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258676
{
public static readonly long[] Value={ 8320L,67600L,635440L,5973136L,51939888L,451647504L,4096960560L,37164128400L,329478755760L,2920995464464L,26224710993712L,235445578423696L,2099178946945200L,18715799552490000L,167514610643031600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258676Inst : IEnumerable<long>
{
public static readonly long[] Value=A258676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258676.Bytes);
public long this[int i]=>Value[i];

public static A258676Inst Instance=new A258676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258677
{
public static readonly long[] Value={ 43264L,456976L,5973136L,78074896L,916151824L,10750371856L,133333061904L,1653682833936L,19942405038864L,240493225528336L,2942195865808144L,35994845566901776L,437158394693484304L,5309300791297536016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258677Inst : IEnumerable<long>
{
public static readonly long[] Value=A258677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258677.Bytes);
public long this[int i]=>Value[i];

public static A258677Inst Instance=new A258677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258678
{
public static readonly BigInteger[] Value={ 219648L,2944656L,51939888L,916151824L,14229592160L,221012814400L,3662507469600L,60693136736400L,974804206566960L,15656518879024144L,255586033778653248L,4172333656507842816L,BigInteger.Parse("67553310760796804928") };
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
public class A258678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258678Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258678.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258678Inst Instance=new A258678Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258679
{
public static readonly BigInteger[] Value={ 1115136L,18974736L,451647504L,10750371856L,221012814400L,4543718560000L,100604912040000L,2227547369610000L,47649380267264400L,1019266064026229776L,BigInteger.Parse("22202539749936066816"),BigInteger.Parse("483635027933987475456"),BigInteger.Parse("10438893202415728548096") };
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
public class A258679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258679Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258679.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258679Inst Instance=new A258679Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258680
{
public static readonly BigInteger[] Value={ 5744640L,125888400L,4096960560L,133333061904L,3662507469600L,100604912040000L,3022970884380000L,90834063491610000L,2620890308853171600L,BigInteger.Parse("75622137191681873296"),BigInteger.Parse("2230153722476731923648"),BigInteger.Parse("65768911202153889517824") };
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
public class A258680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258680Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258680.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258680Inst Instance=new A258680Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258681
{
public static readonly long[] Value={ 320L,1600L,1600L,8320L,10000L,8320L,43264L,67600L,67600L,43264L,219648L,456976L,635440L,456976L,219648L,1115136L,2944656L,5973136L,5973136L,2944656L,1115136L,5744640L,18974736L,51939888L,78074896L,51939888L,18974736L,5744640L,29593600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258681Inst : IEnumerable<long>
{
public static readonly long[] Value=A258681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258681.Bytes);
public long this[int i]=>Value[i];

public static A258681Inst Instance=new A258681Inst();

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