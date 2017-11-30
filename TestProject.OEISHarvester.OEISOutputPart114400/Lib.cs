using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A277232
{
public static readonly BigInteger[] Value={ 1L,9L,603L,4949L,2576763L,20864151L,1347632055L,10860010029L,44749069441659L,359788384157147L,23124997294306677L,185685617347012755L,BigInteger.Parse("95380005326947177879"),BigInteger.Parse("765237422887515344907"),BigInteger.Parse("49101291379356533433423"),BigInteger.Parse("393721549706169405868509"),BigInteger.Parse("12928613856208967961607217787") };
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
public class A277232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277232Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277232.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277232Inst Instance=new A277232Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277233
{
public static readonly BigInteger[] Value={ 1L,5L,89L,381L,25609L,106405L,1755841L,7207405L,1886504905L,7693763645L,125233642041L,508710104205L,33014475398641L,133748096600189L,2165115508033649L,8754452051708621L,9054883309760265929L,BigInteger.Parse("36559890613417481741"),BigInteger.Parse("590105629859261338481"),BigInteger.Parse("2379942639329101454549") };
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
public class A277233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277233Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277233.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277233Inst Instance=new A277233Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277234
{
public static readonly BigInteger[] Value={ 1L,3L,435L,1855L,1678635L,8178093L,831557727L,4362807735L,26663516457435L,146862472576105L,13439367283090749L,76661183599555737L,BigInteger.Parse("54390019021528255975"),BigInteger.Parse("318658997759516188425"),BigInteger.Parse("27581665786275463543575"),BigInteger.Parse("165068987339858265879975"),BigInteger.Parse("7173478080571052213369487675") };
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
public class A277234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277234Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277234.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277234Inst Instance=new A277234Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277235
{
public static readonly long[] Value={ 8L,8L,6L,9L,4L,1L,1L,6L,8L,5L,7L,8L,1L,1L,5L,4L,0L,5L,4L,1L,1L,5L,2L,5L,3L,6L,1L,3L,5L,4L,5L,2L,1L,5L,3L,8L,6L,8L,6L,4L,9L,9L,9L,1L,9L,6L,4L,2L,5L,9L,8L,3L,4L,8L,3L,0L,9L,8L,6L,0L,9L,8L,9L,8L,1L,3L,1L,7L,8L,2L,5L,5L,9L,4L,8L,1L,9L,2L,7L,9L,7L,0L,6L,9L,1L,5L,2L,6L,4L,7L,7L,9L,4L,9L,8L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277235Inst : IEnumerable<long>
{
public static readonly long[] Value=A277235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277235.Bytes);
public long this[int i]=>Value[i];

public static A277235Inst Instance=new A277235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277268
{
public static readonly long[] Value={ 11L,13L,15L,17L,19L,21L,23L,25L,27L,29L,31L,33L,35L,37L,39L,41L,45L,49L,53L,55L,57L,59L,61L,67L,73L,75L,77L,79L,81L,89L,97L,99L,101L,103L,105L,107L,109L,111L,114L,119L,122L,125L,128L,137L,140L,144L,151L,154L,159L,162L,169L,176L,183L,192L,195L,198L,207L,209L,211L,214L,219L,222L,225L,228L,237L,240L,244L,251L,254L,259L,262L,269L,276L,283L,292L,295L,298L,307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277268Inst : IEnumerable<long>
{
public static readonly long[] Value=A277268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277268.Bytes);
public long this[int i]=>Value[i];

public static A277268Inst Instance=new A277268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277269
{
public static readonly long[] Value={ 5L,10L,13L,17L,10L,25L,26L,29L,34L,41L,37L,20L,15L,26L,61L,50L,53L,58L,65L,74L,85L,65L,34L,73L,20L,89L,50L,113L,82L,85L,30L,97L,106L,39L,130L,145L,101L,52L,109L,58L,25L,68L,149L,82L,181L,122L,125L,130L,137L,146L,157L,170L,185L,202L,221L,145L,74L,51L,40L,169L,30L,75L,122L,265L,170L,173L,178L,185L,194L,205L,218L,233L,250L,269L,290L,313L,197L,100L,205L,106L,221L,116L,35L,130L,277L,148L,317L,170L,365L,226L,229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277269Inst : IEnumerable<long>
{
public static readonly long[] Value=A277269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277269.Bytes);
public long this[int i]=>Value[i];

public static A277269Inst Instance=new A277269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277270
{
public static readonly long[] Value={ 27L,18L,28L,35L,66L,66L,66L,74L,7L,74L,74L,93L,93L,93L,93L,93L,93L,93L,93L,93L,93L,93L,93L,93L,25L,25L,25L,25L,44L,25L,44L,44L,44L,44L,96L,96L,63L,63L,25L,96L,25L,96L,63L,63L,63L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277270Inst : IEnumerable<long>
{
public static readonly long[] Value=A277270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277270.Bytes);
public long this[int i]=>Value[i];

public static A277270Inst Instance=new A277270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277271
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,11L,19L,30L,55L,90L,166L,285L,519L,902L,1656L,2929L,5424L,9673L,18012L,32467L,60981L,110599L,208445L,381301L,722552L,1327869L,2522994L,4665786L,8902311L,16524759L,31594853L,58935171L,113038371L,211499060L,406350261L,763246536L,1470080699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277271Inst : IEnumerable<long>
{
public static readonly long[] Value=A277271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277271.Bytes);
public long this[int i]=>Value[i];

public static A277271Inst Instance=new A277271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277272
{
public static readonly long[] Value={ 2L,4L,8L,3L,9L,14L,20L,24L,26L,5L,6L,21L,15L,16L,18L,25L,30L,32L,33L,7L,10L,12L,38L,27L,35L,36L,39L,42L,44L,46L,51L,49L,50L,55L,57L,11L,28L,40L,45L,48L,54L,62L,60L,64L,65L,66L,69L,13L,22L,56L,63L,74L,68L,70L,72L,77L,78L,81L,84L,85L,87L,91L,86L,92L,95L,93L,17L,52L,88L,99L,145L,98L,100L,94L,115L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277272Inst : IEnumerable<long>
{
public static readonly long[] Value=A277272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277272.Bytes);
public long this[int i]=>Value[i];

public static A277272Inst Instance=new A277272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277273
{
public static readonly long[] Value={ 55L,110L,119L,188L,238L,280L,323L,352L,646L,748L,1007L,1780L,2014L,2016L,2508L,2589L,2684L,4187L,5178L,5963L,6900L,8183L,8374L,11663L,11926L,12371L,16366L,23326L,24742L,28780L,30092L,31660L,33512L,33592L,34804L,35728L,36252L,36685L,39917L,40068L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277273Inst : IEnumerable<long>
{
public static readonly long[] Value=A277273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277273.Bytes);
public long this[int i]=>Value[i];

public static A277273Inst Instance=new A277273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277274
{
public static readonly long[] Value={ 1L,2L,1162L,1692934L,3851999L,274422823L,14543645261L,492230729674L,773046873382L,13010754158393L,31446154470014L,583396812890467L,598371102650063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277274Inst : IEnumerable<long>
{
public static readonly long[] Value=A277274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277274.Bytes);
public long this[int i]=>Value[i];

public static A277274Inst Instance=new A277274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277275
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,6L,2L,20L,6L,127L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277275Inst : IEnumerable<long>
{
public static readonly long[] Value=A277275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277275.Bytes);
public long this[int i]=>Value[i];

public static A277275Inst Instance=new A277275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277276
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,8L,14L,26L,63L,215L,527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277276Inst : IEnumerable<long>
{
public static readonly long[] Value=A277276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277276.Bytes);
public long this[int i]=>Value[i];

public static A277276Inst Instance=new A277276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277277
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,14L,20L,28L,36L,44L,56L,72L,92L,116L,148L,188L,240L,304L,388L,492L,628L,796L,1016L,1288L,1644L,2084L,2660L,3372L,4304L,5456L,6964L,8828L,11268L,14284L,18232L,23112L,29500L,37396L,47732L,60508L,77232L,97904L,124964L,158412L,202196L,256316L,327160L,414728L,529356L,671044L,856516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277277Inst : IEnumerable<long>
{
public static readonly long[] Value=A277277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277277.Bytes);
public long this[int i]=>Value[i];

public static A277277Inst Instance=new A277277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277278
{
public static readonly long[] Value={ 0L,1L,4L,6L,4L,10L,10L,9L,14L,9L,14L,13L,13L,18L,18L,18L,16L,19L,22L,23L,23L,27L,27L,26L,25L,25L,28L,33L,32L,35L,34L,33L,35L,38L,38L,40L,36L,42L,42L,42L,41L,48L,48L,47L,51L,50L,50L,49L,52L,49L,57L,57L,59L,59L,58L,58L,63L,63L,63L,62L,61L,66L,66L,67L,64L,73L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277278Inst : IEnumerable<long>
{
public static readonly long[] Value=A277278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277278.Bytes);
public long this[int i]=>Value[i];

public static A277278Inst Instance=new A277278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277279
{
public static readonly BigInteger[] Value={ 1L,1L,2L,-1L,-5L,-11L,-7L,86L,199L,799L,-4159L,-17047L,-155366L,445015L,7627979L,81138437L,142104721L,-12357952274L,-134098256401L,-2117060496481L,57564521075233L,987319483194481L,40297982292465650L,-635283824578537969L,BigInteger.Parse("-39106648195100243333") };
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
public class A277279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277279Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277279.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277279Inst Instance=new A277279Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277280
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,120L,720L,3360L,13440L,48384L,302400L,2217600L,13305600L,69189120L,322882560L,2421619200L,19372953600L,131736084480L,790416506880L,4290832465920L,40226554368000L,337903056691200L,2477955749068800L,16283709208166400L,113985964457164800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277280Inst : IEnumerable<long>
{
public static readonly long[] Value=A277280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277280.Bytes);
public long this[int i]=>Value[i];

public static A277280Inst Instance=new A277280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277281
{
public static readonly long[] Value={ 1L,2L,4L,12L,48L,160L,720L,3360L,13440L,80640L,403200L,2217600L,13305600L,69189120L,484323840L,2905943040L,19372953600L,131736084480L,846874828800L,6436248698880L,42908324659200L,337903056691200L,2477955749068800L,18997660742860800L,151981285942886400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277281Inst : IEnumerable<long>
{
public static readonly long[] Value=A277281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277281.Bytes);
public long this[int i]=>Value[i];

public static A277281Inst Instance=new A277281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277282
{
public static readonly long[] Value={ 2L,1L,2L,3L,4L,5L,9L,14L,20L,30L,50L,77L,112L,182L,294L,450L,672L,1122L,1782L,2717L,4290L,7007L,11011L,16744L,27456L,44200L,68952L,107406L,176358L,281010L,436050L,700910L,1136960L,1797818L,2778446L,4576264L,7354710L,11560835L,18349630L,29910465L,47720400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277282Inst : IEnumerable<long>
{
public static readonly long[] Value=A277282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277282.Bytes);
public long this[int i]=>Value[i];

public static A277282Inst Instance=new A277282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277283
{
public static readonly long[] Value={ 1L,6L,27L,98L,315L,918L,2491L,6366L,15498L,36182L,81501L,177876L,377558L,781626L,1582173L,3137832L,6108051L,11687598L,22012816L,40855674L,74799828L,135210868L,241511115L,426570624L,745516240L,1290006276L,2211202692L,3756468658L,6327617862L,10572763842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277283Inst : IEnumerable<long>
{
public static readonly long[] Value=A277283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277283.Bytes);
public long this[int i]=>Value[i];

public static A277283Inst Instance=new A277283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277332
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,7L,25L,15L,11L,49L,35L,21L,75L,13L,121L,77L,55L,245L,33L,147L,105L,17L,169L,143L,91L,847L,65L,605L,385L,39L,363L,231L,165L,735L,19L,289L,221L,187L,1859L,119L,1183L,1001L,85L,845L,715L,455L,4235L,51L,507L,429L,273L,2541L,195L,1815L,1155L,23L,361L,323L,247L,3757L,209L,3179L,2431L,133L,2023L,1547L,1309L,13013L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277332Inst : IEnumerable<long>
{
public static readonly long[] Value=A277332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277332.Bytes);
public long this[int i]=>Value[i];

public static A277332Inst Instance=new A277332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277333
{
public static readonly long[] Value={ 0L,1L,2L,0L,4L,3L,8L,0L,0L,0L,16L,0L,32L,0L,6L,0L,64L,5L,128L,0L,0L,0L,256L,0L,0L,0L,0L,0L,512L,7L,1024L,0L,0L,0L,12L,0L,2048L,0L,0L,0L,4096L,0L,8192L,0L,0L,0L,16384L,0L,0L,0L,0L,0L,32768L,0L,0L,0L,0L,0L,65536L,0L,131072L,0L,0L,0L,0L,0L,262144L,0L,0L,0L,524288L,0L,1048576L,0L,10L,0L,24L,0L,2097152L,0L,0L,0L,4194304L,0L,0L,0L,0L,0L,8388608L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277333Inst : IEnumerable<long>
{
public static readonly long[] Value=A277333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277333.Bytes);
public long this[int i]=>Value[i];

public static A277333Inst Instance=new A277333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277334
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,9L,11L,13L,15L,17L,19L,21L,23L,25L,29L,31L,33L,35L,37L,39L,41L,43L,47L,49L,51L,53L,55L,57L,59L,61L,65L,67L,69L,71L,73L,75L,77L,79L,83L,85L,87L,89L,91L,93L,95L,97L,101L,103L,105L,107L,109L,111L,113L,115L,119L,121L,123L,127L,129L,131L,133L,137L,139L,141L,143L,145L,147L,149L,151L,155L,157L,159L,161L,163L,165L,167L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277334Inst : IEnumerable<long>
{
public static readonly long[] Value=A277334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277334.Bytes);
public long this[int i]=>Value[i];

public static A277334Inst Instance=new A277334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277335
{
public static readonly long[] Value={ 0L,3L,6L,12L,15L,24L,27L,30L,48L,51L,54L,60L,63L,96L,99L,102L,108L,111L,120L,123L,126L,192L,195L,198L,204L,207L,216L,219L,222L,240L,243L,246L,252L,255L,384L,387L,390L,396L,399L,408L,411L,414L,432L,435L,438L,444L,447L,480L,483L,486L,492L,495L,504L,507L,510L,768L,771L,774L,780L,783L,792L,795L,798L,816L,819L,822L,828L,831L,864L,867L,870L,876L,879L,888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277335Inst : IEnumerable<long>
{
public static readonly long[] Value=A277335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277335.Bytes);
public long this[int i]=>Value[i];

public static A277335Inst Instance=new A277335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277336
{
public static readonly long[] Value={ 6L,12L,24L,35L,61L,76L,96L,118L,146L,162L,230L,245L,338L,362L,384L,426L,444L,460L,472L,580L,584L,605L,642L,645L,664L,697L,718L,740L,790L,804L,812L,814L,830L,852L,877L,920L,926L,954L,979L,1098L,1178L,1192L,1216L,1332L,1334L,1406L,1415L,1446L,1452L,1454L,1459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277336Inst : IEnumerable<long>
{
public static readonly long[] Value=A277336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277336.Bytes);
public long this[int i]=>Value[i];

public static A277336Inst Instance=new A277336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277337
{
public static readonly BigInteger[] Value={ 1L,1L,6L,87L,2056L,71145L,3355956L,203899087L,15451934016L,1419181414929L,154796303577700L,19713331210664751L,2891162097251141616L,BigInteger.Parse("482733064744447450297"),BigInteger.Parse("90871916094948544512516"),BigInteger.Parse("19125402877558442317308975"),BigInteger.Parse("4467829768503489097383022336"),BigInteger.Parse("1151133088512781095709101702177"),BigInteger.Parse("325279313240363190497696752254276") };
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
public class A277337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277337Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277337.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277337Inst Instance=new A277337Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277338
{
public static readonly long[] Value={ 295L,887L,1675L,7436L,13783L,52514L,94039L,187088L,1067869L,10755470L,18211171L,35322452L,60744805L,111589511L,227574622L,454050344L,897100798L,1794102596L,8746117567L,16403234045L,70446464506L,130992928913L,450822227944L,900544455998L,1800098901007L,8801197801088L,17602285712176L,84724043932847L,159547977975595L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277338Inst : IEnumerable<long>
{
public static readonly long[] Value=A277338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277338.Bytes);
public long this[int i]=>Value[i];

public static A277338Inst Instance=new A277338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277339
{
public static readonly BigInteger[] Value={ 1L,1L,2L,4L,7L,11L,26L,92L,64L,-1328L,2272L,86912L,-157706L,-7271042L,17815604L,853696664L,-2615703541L,-133125019397L,490820087366L,26636670621548L,-114924854384183L,-6653655394184683L,32904766004185814L,2029701686588972068L,BigInteger.Parse("-11322597283993315976") };
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
public class A277339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277339Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277339.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277339Inst Instance=new A277339Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277340
{
public static readonly long[] Value={ 1L,2L,4L,7L,10L,92L,1099L,29530L,281473L,657892L,3313964L,9816013L,18669155396L,94849225930L,358676424226L,957439868543L,1586504109310L,41431374800470L,241469610359708L,256165266592379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277340Inst : IEnumerable<long>
{
public static readonly long[] Value=A277340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277340.Bytes);
public long this[int i]=>Value[i];

public static A277340Inst Instance=new A277340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277341
{
public static readonly BigInteger[] Value={ 1L,2L,5L,101L,19L,873L,44L,3455L,716066L,122L,3682385L,42002L,239L,74612L,38038256L,75356321L,487L,168475200L,414001L,701L,473945370L,786827L,996734911L,1854156102515L,1757001L,1408L,2223586L,1578L,2777435L,BigInteger.Parse("102598699146418244788937"),5067957L,14314401926L,2577L,172311367283303079L,3045L };
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
public class A277341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277341Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277341.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277341Inst Instance=new A277341Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277342
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,49L,64L,81L,1L,22L,45L,70L,97L,27L,58L,91L,27L,64L,4L,45L,88L,34L,81L,31L,82L,36L,91L,49L,9L,70L,34L,99L,67L,37L,9L,82L,58L,36L,16L,97L,81L,67L,55L,45L,37L,31L,27L,25L,25L,27L,31L,37L,45L,55L,67L,81L,97L,16L,36L,58L,82L,9L,37L,67L,99L,34L,70L,9L,49L,91L,36L,82L,31L,81L,34L,88L,45L,4L,64L,27L,91L,58L,27L,97L,70L,45L,22L,1L,81L,64L,49L,36L,25L,16L,9L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277342Inst : IEnumerable<long>
{
public static readonly long[] Value=A277342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277342.Bytes);
public long this[int i]=>Value[i];

public static A277342Inst Instance=new A277342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277343
{
public static readonly long[] Value={ 4L,6L,10L,21L,46L,106L,247L,579L,1363L,3214L,7586L,17915L,42311L,99931L,236023L,557455L,1316638L,3109733L,7344803L,17347513L,40972678L,96772393L,228564417L,539840885L,1275037411L,3011480697L,7112745019L,16799424206L,39678162637L,93714913738L,221343037931L,522784885426L,1234753254431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277343Inst : IEnumerable<long>
{
public static readonly long[] Value=A277343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277343.Bytes);
public long this[int i]=>Value[i];

public static A277343Inst Instance=new A277343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277344
{
public static readonly long[] Value={ 50963L,5834755L,9835843L,155627923L,245056003L,332852435L,556268443L,724014203L,795650963L,831912763L,2440444163L,4080848203L,5067702643L,5140068643L,5555216803L,7461332483L,8438160643L,11766788323L,11951765003L,13058213003L,13483943203L,14528402983L,16644521435L,17847852803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277344Inst : IEnumerable<long>
{
public static readonly long[] Value=A277344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277344.Bytes);
public long this[int i]=>Value[i];

public static A277344Inst Instance=new A277344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277345
{
public static readonly BigInteger[] Value={ 2L,3L,9L,31L,131L,666L,4014L,28127L,225063L,2025643L,20256553L,222822282L,2673867706L,34760280699L,486643930629L,7299658960799L,116794543374991L,1985507237378418L,35739130272817302L,679043475183538087L,13580869503670776867UL,BigInteger.Parse("285198259577086338683") };
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
public class A277345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277345Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277345.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277345Inst Instance=new A277345Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277346
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,16L,48L,119L,390L,1070L,3656L,10762L,37834L,116546L,417540L,1330923L,4836452L,15823388L,58130756L,194168612L,719541996L,2444224858L,9121965276L,31422225930L,117959864244L,411141476444L,1551101290792L,5460849893348L,20689450250926L,73474839110524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277346Inst : IEnumerable<long>
{
public static readonly long[] Value=A277346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277346.Bytes);
public long this[int i]=>Value[i];

public static A277346Inst Instance=new A277346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277347
{
public static readonly BigInteger[] Value={ 1L,5L,65L,1625L,66625L,4064125L,345450625L,39035920625L,5660208490625L,1024497736803125L,226413999833490625L,BigInteger.Parse("59999709955875015625"),BigInteger.Parse("18779909216188879890625"),BigInteger.Parse("6854666863908941160078125"),BigInteger.Parse("2885814749705664228392890625"),BigInteger.Parse("1388076894608424493856980390625"),BigInteger.Parse("756501907561591349152054312890625") };
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
public class A277347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277347Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277347.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277347Inst Instance=new A277347Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277412
{
public static readonly BigInteger[] Value={ 1L,13L,165L,2310L,36330L,640710L,12588345L,273544425L,6529047525L,170116046100L,4812116809500L,147071309685300L,4835838768886125L,170422360844360625L,6415409821472276625L,BigInteger.Parse("257182138353489599250"),BigInteger.Parse("10948868951071241940750"),BigInteger.Parse("493742086990731259931250"),BigInteger.Parse("23529007012831307040178125"),BigInteger.Parse("1182267810558397149214753125"),BigInteger.Parse("62507026744534189248771965625"),BigInteger.Parse("3470421725511913171914539625000"),BigInteger.Parse("201956614461150241288627906875000") };
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
public class A277412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277412Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277412.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277412Inst Instance=new A277412Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277413
{
public static readonly BigInteger[] Value={ 1L,3L,70L,4620L,599256L,128648520L,41281606080L,18507916627200L,11049593741746560L,8474451191616009600L,BigInteger.Parse("8119493428719228192000"),BigInteger.Parse("9504049395027168805824000"),BigInteger.Parse("13345312208487981260926464000"),BigInteger.Parse("22140681034117932250214874624000"),BigInteger.Parse("42846437958647788197412779939840000"),BigInteger.Parse("95657301566159892238019686222356480000"),BigInteger.Parse("244038306493164073323605513327887380480000") };
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
public class A277413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277413Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277413.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277413Inst Instance=new A277413Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277414
{
public static readonly BigInteger[] Value={ 1L,2L,20L,504L,23968L,1851520L,211575936L,33566973440L,7062343608320L,1903365244784640L,639521861269258240L,BigInteger.Parse("262112584945787699200"),BigInteger.Parse("128722417690687207833600"),BigInteger.Parse("74622047155540651999232000"),BigInteger.Parse("50422787106606997974155264000"),BigInteger.Parse("39283625022760603948312795545600"),BigInteger.Parse("34956170646455883939814603698995200"),BigInteger.Parse("35235028408984566235493250881290240000"),BigInteger.Parse("39938723513704723231184585043746173747200") };
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
public class A277414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277414Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277414.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277414Inst Instance=new A277414Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277415
{
public static readonly long[] Value={ 0L,1L,2L,4L,3L,8L,16L,32L,6L,64L,5L,128L,256L,512L,7L,1024L,12L,2048L,4096L,8192L,16384L,32768L,65536L,131072L,262144L,524288L,1048576L,10L,24L,2097152L,4194304L,8388608L,9L,16777216L,33554432L,67108864L,14L,134217728L,268435456L,536870912L,1073741824L,2147483648L,4294967296L,8589934592L,48L,17179869184L,34359738368L,68719476736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277415Inst : IEnumerable<long>
{
public static readonly long[] Value=A277415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277415.Bytes);
public long this[int i]=>Value[i];

public static A277415Inst Instance=new A277415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277416
{
public static readonly long[] Value={ 0L,1L,2L,4L,3L,10L,8L,14L,5L,32L,27L,71L,16L,105L,36L,57L,6L,134L,118L,918L,66L,2361L,415L,1224L,28L,1902L,551L,4969L,92L,2545L,217L,374L,7L,940L,803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277416Inst : IEnumerable<long>
{
public static readonly long[] Value=A277416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277416.Bytes);
public long this[int i]=>Value[i];

public static A277416Inst Instance=new A277416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277417
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,11L,13L,15L,16L,17L,19L,23L,25L,29L,30L,31L,35L,36L,37L,41L,43L,47L,49L,53L,59L,61L,64L,67L,71L,73L,77L,79L,81L,83L,89L,97L,100L,101L,103L,105L,107L,109L,113L,121L,127L,131L,137L,139L,143L,144L,149L,151L,157L,163L,167L,169L,173L,179L,181L,191L,193L,196L,197L,199L,210L,211L,221L,223L,225L,227L,229L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277417Inst : IEnumerable<long>
{
public static readonly long[] Value=A277417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277417.Bytes);
public long this[int i]=>Value[i];

public static A277417Inst Instance=new A277417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277418
{
public static readonly BigInteger[] Value={ 1L,5L,98L,3246L,151064L,9052120L,663449040L,57490690544L,5749754436992L,651830574374784L,82599621627948800L,11569798584488362240UL,BigInteger.Parse("1775052172071446510592"),BigInteger.Parse("296026752508667034942464"),BigInteger.Parse("53320241823337034415908864"),BigInteger.Parse("10315767337287172256717568000") };
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
public class A277418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277418Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277418.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277418Inst Instance=new A277418Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277419
{
public static readonly BigInteger[] Value={ 1L,6L,142L,5676L,318744L,23046370L,2038090320L,213094791840L,25714702990720L,3517403388684030L,537798502938028800L,BigInteger.Parse("90890936781714193300"),BigInteger.Parse("16825134146527678233600"),BigInteger.Parse("3385560150770468257273050"),BigInteger.Parse("735772370353606135149107200"),BigInteger.Parse("171753027520961356975091493000") };
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
public class A277419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277419Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277419.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277419Inst Instance=new A277419Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277420
{
public static readonly BigInteger[] Value={ 1L,7L,194L,9078L,596760L,50508120L,5228520912L,639915545808L,90390815432064L,14472947716917120L,2590274418097708800L,BigInteger.Parse("512433683486806447872"),BigInteger.Parse("111036605823697437490176"),BigInteger.Parse("26153418409614396515976192"),BigInteger.Parse("6653213794092052464421939200"),BigInteger.Parse("1817951594633556391548903168000") };
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
public class A277420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277420Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277420.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277420Inst Instance=new A277420Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277421
{
public static readonly BigInteger[] Value={ 1L,8L,254L,13614L,1025048L,99368620L,11781698256L,1651548277946L,267197019684224L,49000715036948304L,10044513851042988800UL,BigInteger.Parse("2275926588768085912582"),BigInteger.Parse("564838094735322988575744"),BigInteger.Parse("152378369304839730672573044"),BigInteger.Parse("44397985962782115253758973952") };
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
public class A277421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277421Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277421.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277421Inst Instance=new A277421Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277422
{
public static readonly BigInteger[] Value={ 1L,9L,322L,19446L,1649688L,180184120L,24070390992L,3801662863152L,692979602529664L,143184960501077376L,BigInteger.Parse("33069665092749868800"),BigInteger.Parse("8442378658666161822976"),BigInteger.Parse("2360674573114695421197312"),BigInteger.Parse("717531421372546588398529536"),BigInteger.Parse("235551703250624390582942574592") };
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
public class A277422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277422Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277422.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277422Inst Instance=new A277422Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277423
{
public static readonly BigInteger[] Value={ 1L,0L,-2L,6L,24L,-380L,720L,31794L,-361088L,-2104056L,101548800L,-612792290L,-25534891008L,593660731404L,2831189530624L,-361541172525750L,4481749181890560L,169464194149739536L,-6805365045197340672L,BigInteger.Parse("-9663483091971306186"),BigInteger.Parse("6883830206467440640000") };
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
public class A277423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277423Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277423.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277423Inst Instance=new A277423Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277424
{
public static readonly BigInteger[] Value={ 1L,5L,39L,379L,4457L,61503L,974107L,17412317L,346662981L,7605810685L,182298744203L,4738700778123L,132767583248917L,3988244997744743L,127859570155253607L,4357113615504651565L,BigInteger.Parse("157266354405499307369"),BigInteger.Parse("5993377455733610208885"),BigInteger.Parse("240479249123008267155343") };
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
public class A277424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277424Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277424.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277424Inst Instance=new A277424Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277425
{
public static readonly long[] Value={ 0L,2L,3L,4L,4L,5L,6L,7L,8L,6L,7L,8L,9L,10L,11L,12L,8L,9L,10L,11L,12L,13L,14L,15L,16L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277425Inst : IEnumerable<long>
{
public static readonly long[] Value=A277425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277425.Bytes);
public long this[int i]=>Value[i];

public static A277425Inst Instance=new A277425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277426
{
public static readonly BigInteger[] Value={ 32L,2048L,131072L,8388608L,536870912L,34359738368L,2199023255552L,140737488355328L,9007199254740992L,576460752303423488L,BigInteger.Parse("36893488147419103232"),BigInteger.Parse("2361183241434822606848"),BigInteger.Parse("151115727451828646838272"),BigInteger.Parse("9671406556917033397649408"),BigInteger.Parse("618970019642690137449562112"),BigInteger.Parse("39614081257132168796771975168") };
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
public class A277426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277426Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277426.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277426Inst Instance=new A277426Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277427
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,2L,3L,2L,1L,4L,1L,2L,3L,4L,1L,3L,2L,4L,2L,1L,3L,4L,2L,3L,1L,4L,3L,1L,2L,4L,3L,2L,1L,5L,1L,2L,3L,4L,5L,1L,2L,4L,3L,5L,1L,3L,2L,4L,5L,1L,3L,4L,2L,5L,1L,4L,2L,3L,5L,1L,4L,3L,2L,5L,2L,1L,3L,4L,5L,2L,1L,4L,3L,5L,2L,3L,1L,4L,5L,2L,3L,4L,1L,5L,2L,4L,1L,3L,5L,2L,4L,3L,1L,5L,3L,1L,2L,4L,5L,3L,1L,4L,2L,5L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277427Inst : IEnumerable<long>
{
public static readonly long[] Value=A277427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277427.Bytes);
public long this[int i]=>Value[i];

public static A277427Inst Instance=new A277427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277492
{
public static readonly long[] Value={ 3L,13L,96L,780L,6684L,58812L,523932L,4693884L,42158940L,379086396L,3410401308L,30688106748L,276170940636L,2485450385340L,22368701146524L,201316901032572L,1811846472148572L,16306595700758844L,146759271112516380L,1320833079235394556L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277492Inst : IEnumerable<long>
{
public static readonly long[] Value=A277492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277492.Bytes);
public long this[int i]=>Value[i];

public static A277492Inst Instance=new A277492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277493
{
public static readonly long[] Value={ 1L,2L,10L,66L,504L,4216L,37548L,350090L,3380520L,33558024L,340670720L,3522993656L,37003723200L,393856445664L,4240313009272L,46109094112170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277493Inst : IEnumerable<long>
{
public static readonly long[] Value=A277493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277493.Bytes);
public long this[int i]=>Value[i];

public static A277493Inst Instance=new A277493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277494
{
public static readonly long[] Value={ 0L,1L,4L,6L,9L,10L,12L,14L,8L,16L,15L,22L,18L,26L,21L,20L,24L,34L,25L,38L,28L,30L,33L,46L,32L,35L,39L,27L,36L,58L,40L,62L,45L,44L,51L,42L,48L,74L,57L,52L,50L,82L,49L,86L,55L,54L,69L,94L,60L,56L,63L,68L,65L,106L,70L,66L,72L,76L,87L,118L,75L,122L,93L,77L,64L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277494Inst : IEnumerable<long>
{
public static readonly long[] Value=A277494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277494.Bytes);
public long this[int i]=>Value[i];

public static A277494Inst Instance=new A277494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277495
{
public static readonly long[] Value={ 1L,2L,2L,1L,5L,2L,3L,4L,3L,2L,3L,2L,3L,4L,6L,6L,7L,6L,4L,2L,3L,4L,5L,8L,4L,5L,3L,2L,4L,6L,6L,7L,9L,10L,8L,8L,9L,6L,4L,4L,5L,6L,3L,6L,5L,6L,7L,12L,5L,2L,4L,4L,5L,6L,5L,4L,6L,8L,10L,6L,6L,7L,3L,4L,2L,2L,3L,6L,9L,14L,6L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277495Inst : IEnumerable<long>
{
public static readonly long[] Value=A277495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277495.Bytes);
public long this[int i]=>Value[i];

public static A277495Inst Instance=new A277495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277496
{
public static readonly long[] Value={ 3L,43L,909L,25264L,946088L,49916876L,3402999604L,295506405205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277496Inst : IEnumerable<long>
{
public static readonly long[] Value=A277496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277496.Bytes);
public long this[int i]=>Value[i];

public static A277496Inst Instance=new A277496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277497
{
public static readonly long[] Value={ 3L,49L,1020L,28666L,1099824L,57520786L,3882860433L,331811494082L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277497Inst : IEnumerable<long>
{
public static readonly long[] Value=A277497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277497.Bytes);
public long this[int i]=>Value[i];

public static A277497Inst Instance=new A277497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277498
{
public static readonly BigInteger[] Value={ 0L,1L,2L,8L,56L,536L,6528L,96592L,1683072L,33760576L,766283264L,19417068032L,543351873536L,16642224306176L,553782090473472L,19893884376859648L,767355755629215744L,BigInteger.Parse("31631864049541107712"),BigInteger.Parse("1387750771948607504384"),BigInteger.Parse("64561526675221208563712") };
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
public class A277498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277498Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277498.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277498Inst Instance=new A277498Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277499
{
public static readonly BigInteger[] Value={ 0L,1L,2L,8L,52L,476L,5646L,82368L,1426888L,28623376L,652516090L,16660233600L,470930272572L,14598765522368L,492441140292934L,17955574113204224L,703714660937658128L,BigInteger.Parse("29500170665998713088"),BigInteger.Parse("1317136516654501334898"),BigInteger.Parse("62399954043306802391040") };
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
public class A277499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277499Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277499.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277499Inst Instance=new A277499Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277500
{
public static readonly BigInteger[] Value={ 0L,1L,2L,11L,80L,821L,10608L,167215L,3105024L,66433129L,1609025024L,43521156755L,1300287942656L,42528924900125L,1511407185512448L,57992816331075511L,2389444376908726272L,BigInteger.Parse("105219795048784564945"),BigInteger.Parse("4931495123285481881600"),BigInteger.Parse("245105773365008603770907") };
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
public class A277500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277500Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277500.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277500Inst Instance=new A277500Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277501
{
public static readonly BigInteger[] Value={ 0L,1L,2L,7L,48L,461L,5488L,79171L,1347328L,26396185L,585025024L,14473813311L,395433660416L,11824374817893L,384118189803520L,13470784014801787L,507233444671848448L,BigInteger.Parse("20411081546839908401"),BigInteger.Parse("874130806090067607552"),BigInteger.Parse("39696948293418345150327") };
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
public class A277501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277501Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277501.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277501Inst Instance=new A277501Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277502
{
public static readonly BigInteger[] Value={ 0L,1L,2L,10L,72L,724L,9184L,142080L,2587392L,54290256L,1289277440L,34191270752L,1001513996288L,32113767783616L,1118831623585792L,42084750888906240L,1699836383279448064L,BigInteger.Parse("73377208318764134656"),BigInteger.Parse("3371248736937012363264"),BigInteger.Parse("164251735270613613412864") };
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
public class A277502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277502Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277502.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277502Inst Instance=new A277502Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277503
{
public static readonly BigInteger[] Value={ 0L,1L,2L,7L,48L,469L,5584L,80235L,1367040L,26840841L,595623680L,14752565807L,403579762688L,12084385256605L,393093330282496L,13804177426246995L,520496287836012544L,BigInteger.Parse("20973496057176404881"),BigInteger.Parse("899452315670554017792"),BigInteger.Parse("40903215737685386469847") };
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
public class A277503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277503Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277503.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277503Inst Instance=new A277503Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277504
{
public static readonly long[] Value={ 1L,2L,1L,3L,3L,1L,4L,6L,6L,1L,5L,10L,18L,10L,1L,6L,15L,40L,45L,20L,1L,7L,21L,75L,136L,135L,36L,1L,8L,28L,126L,325L,544L,378L,72L,1L,9L,36L,196L,666L,1625L,2080L,1134L,136L,1L,10L,45L,288L,1225L,3996L,7875L,8320L,3321L,272L,1L,11L,55L,405L,2080L,8575L,23436L,39375L,32896L,9963L,528L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277504Inst : IEnumerable<long>
{
public static readonly long[] Value=A277504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277504.Bytes);
public long this[int i]=>Value[i];

public static A277504Inst Instance=new A277504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277505
{
public static readonly BigInteger[] Value={ 0L,1L,4L,21L,148L,1365L,15966L,229411L,3932440L,78438681L,1784386810L,45565679511L,1289796524820L,40065439945141L,1354630932486118L,49512390012682395L,1945119744809765296L,BigInteger.Parse("81728227537432878513"),BigInteger.Parse("3657019655412488345202"),BigInteger.Parse("173610723750748520091679") };
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
public class A277505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277505Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277505.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277505Inst Instance=new A277505Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277506
{
public static readonly BigInteger[] Value={ 1L,2L,8L,51L,460L,5425L,79206L,1377985L,27801096L,637630353L,16376303530L,465451009441L,14501512561548L,491394769892377L,17991533604051294L,707766894441628785L,BigInteger.Parse("29771014384775612176"),BigInteger.Parse("1333347506427522171169"),BigInteger.Parse("63346663190991936656466"),BigInteger.Parse("3182006256289160385596833") };
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
public class A277506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277506Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277506.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277506Inst Instance=new A277506Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277507
{
public static readonly BigInteger[] Value={ -1L,0L,0L,3L,28L,305L,3846L,57337L,998600L,20036529L,456403690L,11647754921L,329290975212L,10214585950153L,344897398385918L,12590837785019145L,494101941398352016L,BigInteger.Parse("20740772742716097377"),BigInteger.Parse("927276395603713539282"),BigInteger.Parse("43987299891665164562377"),BigInteger.Parse("2206610456287703987567540") };
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
public class A277507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277507Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277507.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277507Inst Instance=new A277507Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277556
{
public static readonly long[] Value={ 1L,0L,2L,2L,14L,42L,244L,1208L,7930L,52710L,405850L,3310702L,29742388L,285103536L,2943395390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277556Inst : IEnumerable<long>
{
public static readonly long[] Value=A277556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277556.Bytes);
public long this[int i]=>Value[i];

public static A277556Inst Instance=new A277556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277557
{
public static readonly long[] Value={ 8L,18L,19L,32L,33L,34L,50L,52L,53L,72L,73L,74L,75L,76L,98L,99L,100L,101L,102L,103L,128L,131L,133L,134L,162L,163L,164L,165L,166L,167L,168L,169L,200L,201L,202L,203L,204L,205L,206L,207L,208L,242L,244L,247L,248L,250L,251L,288L,289L,290L,291L,292L,293L,294L,295L,296L,297L,298L,338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277557Inst : IEnumerable<long>
{
public static readonly long[] Value=A277557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277557.Bytes);
public long this[int i]=>Value[i];

public static A277557Inst Instance=new A277557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277558
{
public static readonly long[] Value={ 0L,1L,3L,6L,2L,7L,13L,20L,12L,21L,11L,22L,10L,23L,9L,24L,8L,25L,43L,62L,42L,63L,41L,18L,40L,15L,39L,66L,38L,67L,37L,68L,36L,69L,35L,70L,34L,71L,33L,72L,32L,73L,31L,74L,30L,75L,29L,76L,28L,77L,27L,78L,26L,79L,133L,188L,132L,189L,131L,190L,130L,191L,129L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277558Inst : IEnumerable<long>
{
public static readonly long[] Value=A277558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277558.Bytes);
public long this[int i]=>Value[i];

public static A277558Inst Instance=new A277558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277559
{
public static readonly long[] Value={ 9L,2L,1L,7L,5L,3L,6L,7L,0L,0L,1L,9L,2L,3L,1L,5L,4L,4L,7L,0L,5L,1L,3L,1L,3L,6L,3L,2L,6L,5L,2L,4L,7L,9L,1L,9L,6L,0L,8L,2L,3L,9L,7L,9L,9L,6L,0L,3L,7L,9L,5L,4L,2L,9L,0L,3L,1L,1L,2L,0L,8L,4L,1L,2L,7L,3L,3L,3L,2L,2L,5L,3L,6L,7L,3L,5L,0L,3L,0L,2L,9L,0L,7L,5L,7L,4L,5L,7L,5L,1L,5L,2L,2L,5L,4L,3L,0L,7L,9L,3L,2L,4L,2L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277559Inst : IEnumerable<long>
{
public static readonly long[] Value=A277559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277559.Bytes);
public long this[int i]=>Value[i];

public static A277559Inst Instance=new A277559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277560
{
public static readonly BigInteger[] Value={ 1L,11L,0L,1111L,0L,111111L,0L,11111111L,0L,1111111111L,0L,111111111111L,0L,11111111111111L,0L,1111111111111111L,0L,111111111111111111L,0L,11111111111111111111UL,0L,BigInteger.Parse("1111111111111111111111"),0L,BigInteger.Parse("111111111111111111111111"),0L,BigInteger.Parse("11111111111111111111111111"),0L };
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
public class A277560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277560Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277560.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277560Inst Instance=new A277560Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277561
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,4L,2L,2L,2L,4L,4L,4L,2L,4L,2L,2L,2L,4L,4L,4L,4L,8L,4L,4L,2L,4L,4L,4L,2L,4L,2L,2L,2L,4L,4L,4L,4L,8L,4L,4L,4L,8L,8L,8L,4L,8L,4L,4L,2L,4L,4L,4L,4L,8L,4L,4L,2L,4L,4L,4L,2L,4L,2L,2L,2L,4L,4L,4L,4L,8L,4L,4L,4L,8L,8L,8L,4L,8L,4L,4L,4L,8L,8L,8L,8L,16L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277561Inst : IEnumerable<long>
{
public static readonly long[] Value=A277561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277561.Bytes);
public long this[int i]=>Value[i];

public static A277561Inst Instance=new A277561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277562
{
public static readonly long[] Value={ 16L,81L,256L,512L,625L,1296L,2401L,6561L,10000L,14641L,19683L,20736L,28561L,38416L,50625L,65536L,83521L,104976L,130321L,160000L,194481L,234256L,279841L,331776L,390625L,456976L,614656L,707281L,810000L,923521L,1185921L,1336336L,1500625L,1679616L,1874161L,1953125L,2085136L,2313441L,2560000L,2825761L,3111696L,3418801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277562Inst : IEnumerable<long>
{
public static readonly long[] Value=A277562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277562.Bytes);
public long this[int i]=>Value[i];

public static A277562Inst Instance=new A277562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277563
{
public static readonly BigInteger[] Value={ 0L,0L,0L,24L,96L,504L,3216L,24024L,205056L,1965624L,20886576L,243511704L,3089233056L,42351635064L,623815221456L,9823096307544L,164655323578176L,2926840752827064L,54988308080981616L,1088680464831056664L,BigInteger.Parse("22653422225916839136"),BigInteger.Parse("494229434646381585144"),BigInteger.Parse("11280809162286897977616") };
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
public class A277563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277563Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277563.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277563Inst Instance=new A277563Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277564
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,4L,1L,1L,5L,3L,6L,4L,7L,5L,8L,1L,2L,9L,2L,1L,10L,6L,11L,7L,12L,8L,13L,9L,14L,10L,15L,11L,16L,1L,1L,1L,17L,12L,18L,13L,19L,14L,20L,15L,21L,16L,22L,17L,23L,18L,24L,19L,25L,3L,1L,26L,20L,27L,2L,2L,28L,21L,29L,22L,30L,23L,31L,24L,32L,1L,3L,33L,25L,34L,26L,35L,27L,36L,4L,1L,37L,28L,38L,29L,39L,30L,40L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277564Inst : IEnumerable<long>
{
public static readonly long[] Value=A277564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277564.Bytes);
public long this[int i]=>Value[i];

public static A277564Inst Instance=new A277564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277565
{
public static readonly long[] Value={ 1L,2L,7L,40L,281L,2538L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277565Inst : IEnumerable<long>
{
public static readonly long[] Value=A277565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277565.Bytes);
public long this[int i]=>Value[i];

public static A277565Inst Instance=new A277565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277566
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,6L,1L,2L,3L,4L,6L,8L,12L,24L,1L,2L,3L,4L,5L,6L,8L,10L,12L,20L,24L,60L,120L,1L,2L,3L,4L,5L,6L,8L,9L,10L,12L,16L,18L,20L,24L,36L,48L,60L,72L,120L,360L,720L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,14L,16L,18L,20L,21L,24L,36L,40L,42L,48L,60L,72L,120L,144L,168L,240L,360L,720L,2520L,5040L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,14L,15L,16L,18L,20L,21L,24L,30L,32L,36L,40L,42L,48L,56L,60L,64L,72L,96L,120L,128L,144L,168L,180L,192L,240L,288L,336L,360L,384L,576L,720L,1152L,1344L,1440L,2520L,5040L,20160L,40320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277566Inst : IEnumerable<long>
{
public static readonly long[] Value=A277566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277566.Bytes);
public long this[int i]=>Value[i];

public static A277566Inst Instance=new A277566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277567
{
public static readonly long[] Value={ 1L,6L,7L,13L,19L,25L,31L,36L,37L,42L,43L,49L,55L,61L,67L,73L,78L,79L,85L,91L,97L,103L,109L,114L,115L,121L,127L,133L,139L,145L,150L,151L,157L,163L,169L,175L,181L,186L,187L,193L,199L,205L,211L,216L,217L,222L,223L,229L,235L,241L,247L,252L,253L,258L,259L,265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277567Inst : IEnumerable<long>
{
public static readonly long[] Value=A277567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277567.Bytes);
public long this[int i]=>Value[i];

public static A277567Inst Instance=new A277567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277568
{
public static readonly long[] Value={ 2L,8L,12L,14L,20L,26L,32L,38L,44L,48L,50L,56L,62L,68L,72L,74L,80L,84L,86L,92L,98L,104L,110L,116L,120L,122L,128L,134L,140L,146L,152L,156L,158L,164L,170L,176L,182L,188L,192L,194L,200L,206L,212L,218L,224L,228L,230L,236L,242L,248L,254L,260L,264L,266L,272L,278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277568Inst : IEnumerable<long>
{
public static readonly long[] Value=A277568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277568.Bytes);
public long this[int i]=>Value[i];

public static A277568Inst Instance=new A277568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277569
{
public static readonly long[] Value={ 3L,9L,15L,18L,21L,27L,33L,39L,45L,51L,54L,57L,63L,69L,75L,81L,87L,90L,93L,99L,105L,108L,111L,117L,123L,126L,129L,135L,141L,147L,153L,159L,162L,165L,171L,177L,183L,189L,195L,198L,201L,207L,213L,219L,225L,231L,234L,237L,243L,249L,255L,261L,267L,270L,273L,279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277569Inst : IEnumerable<long>
{
public static readonly long[] Value=A277569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277569.Bytes);
public long this[int i]=>Value[i];

public static A277569Inst Instance=new A277569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277570
{
public static readonly long[] Value={ 4L,10L,16L,22L,24L,28L,34L,40L,46L,52L,58L,60L,64L,70L,76L,82L,88L,94L,96L,100L,106L,112L,118L,124L,130L,132L,136L,142L,144L,148L,154L,160L,166L,168L,172L,178L,184L,190L,196L,202L,204L,208L,214L,220L,226L,232L,238L,240L,244L,250L,256L,262L,268L,274L,276L,280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277570Inst : IEnumerable<long>
{
public static readonly long[] Value=A277570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277570.Bytes);
public long this[int i]=>Value[i];

public static A277570Inst Instance=new A277570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277571
{
public static readonly long[] Value={ 5L,11L,17L,23L,29L,30L,35L,41L,47L,53L,59L,65L,66L,71L,77L,83L,89L,95L,101L,102L,107L,113L,119L,125L,131L,137L,138L,143L,149L,155L,161L,167L,173L,174L,179L,180L,185L,191L,197L,203L,209L,210L,215L,221L,227L,233L,239L,245L,246L,251L,257L,263L,269L,275L,281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277571Inst : IEnumerable<long>
{
public static readonly long[] Value=A277571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277571.Bytes);
public long this[int i]=>Value[i];

public static A277571Inst Instance=new A277571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278132
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,6L,5L,1L,1L,11L,15L,7L,1L,1L,20L,38L,28L,9L,1L,1L,36L,92L,89L,45L,11L,1L,1L,64L,219L,258L,172L,66L,13L,1L,1L,113L,513L,721L,577L,295L,91L,15L,1L,1L,199L,1184L,1975L,1817L,1125L,466L,120L,17L,1L,1L,350L,2702L,5326L,5534L,3932L,1994L,693L,153L,19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278132Inst : IEnumerable<long>
{
public static readonly long[] Value=A278132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278132.Bytes);
public long this[int i]=>Value[i];

public static A278132Inst Instance=new A278132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278133
{
public static readonly long[] Value={ 1L,3L,10L,32L,101L,318L,1003L,3173L,10071L,32071L,102453L,328260L,1054620L,3396757L,10965653L,35475159L,114989969L,373400210L,1214529314L,3956450250L,12906762704L,42159475998L,137877383739L,451403471067L,1479329370617L,4852295325254L,15928202158814L,52321416289743L,171966242037941L,565480887258368L,1860228812665716L,6121446895971437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278133Inst : IEnumerable<long>
{
public static readonly long[] Value=A278133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278133.Bytes);
public long this[int i]=>Value[i];

public static A278133Inst Instance=new A278133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278134
{
public static readonly long[] Value={ 1L,2L,5L,13L,34L,1L,89L,7L,1L,233L,34L,7L,1L,610L,141L,35L,7L,1L,1597L,534L,152L,36L,7L,1L,4181L,1905L,611L,163L,37L,7L,1L,10946L,6512L,2338L,689L,174L,38L,7L,1L,28657L,21557L,8641L,2787L,768L,185L,39L,7L,1L,75025L,69593L,31104L,10921L,3252L,848L,196L,40L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278134Inst : IEnumerable<long>
{
public static readonly long[] Value=A278134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278134.Bytes);
public long this[int i]=>Value[i];

public static A278134Inst Instance=new A278134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278135
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,9L,51L,236L,979L,3805L,14190L,51488L,183333L,644121L,2241127L,7741378L,26593899L,90971184L,310159487L,1054693058L,3578948942L,12124108632L,41015411703L,138597840864L,467913141789L,1578497031981L,5321685955902L,17931990439148L,60397664457791L,203355625940891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278135Inst : IEnumerable<long>
{
public static readonly long[] Value=A278135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278135.Bytes);
public long this[int i]=>Value[i];

public static A278135Inst Instance=new A278135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278136
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,5L,2L,1L,8L,4L,1L,13L,6L,2L,1L,21L,10L,5L,1L,34L,17L,7L,2L,1L,55L,27L,12L,6L,1L,89L,44L,22L,8L,2L,1L,144L,72L,34L,14L,7L,1L,233L,116L,56L,28L,9L,2L,1L,377L,188L,94L,42L,16L,8L,1L,610L,305L,150L,70L,35L,10L,2L,1L,987L,493L,244L,122L,51L,18L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278136Inst : IEnumerable<long>
{
public static readonly long[] Value=A278136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278136.Bytes);
public long this[int i]=>Value[i];

public static A278136Inst Instance=new A278136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278137
{
public static readonly long[] Value={ 1L,3L,4L,8L,13L,22L,37L,61L,101L,166L,272L,445L,726L,1183L,1925L,3129L,5082L,8248L,13379L,21692L,35157L,56963L,92271L,149434L,241970L,391755L,634190L,1026561L,1661567L,2689209L,4352208L,7043314L,11398035L,18444678L,29847123L,48297643L,78152505L,126460400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278137Inst : IEnumerable<long>
{
public static readonly long[] Value=A278137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278137.Bytes);
public long this[int i]=>Value[i];

public static A278137Inst Instance=new A278137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278138
{
public static readonly long[] Value={ 3L,5L,17L,197L,1427L,1667L,2087L,4157L,4217L,8387L,8597L,10037L,11117L,11717L,15287L,17417L,20147L,25847L,29207L,33347L,33827L,34847L,35897L,36527L,47657L,56237L,57527L,60257L,63197L,63587L,69497L,75167L,77477L,89657L,93887L,96797L,99347L,99527L,100547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278138Inst : IEnumerable<long>
{
public static readonly long[] Value=A278138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278138.Bytes);
public long this[int i]=>Value[i];

public static A278138Inst Instance=new A278138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278139
{
public static readonly long[] Value={ 2L,3L,13L,41L,107L,227L,503L,881L,1409L,2039L,2819L,3947L,5273L,6869L,8699L,11549L,15377L,19937L,24593L,30809L,38069L,47939L,58379L,69257L,82787L,98897L,115733L,133499L,152027L,172127L,192833L,218711L,247391L,279269L,315047L,355517L,399473L,444623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278139Inst : IEnumerable<long>
{
public static readonly long[] Value=A278139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278139.Bytes);
public long this[int i]=>Value[i];

public static A278139Inst Instance=new A278139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278140
{
public static readonly BigInteger[] Value={ 1L,27L,29835L,914095L,30845936835L,966228811317L,1005862016542383L,31766194302634935L,BigInteger.Parse("33673399154070922824435"),BigInteger.Parse("1067731823813513897297545"),BigInteger.Parse("1101976780048026596318593989"),BigInteger.Parse("35023352480137647877041347193"),BigInteger.Parse("1154564397329013014999165944225975") };
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
public class A278140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278140Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278140.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278140Inst Instance=new A278140Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278141
{
public static readonly BigInteger[] Value={ 1L,265L,1096065L,281858265L,18519577975665L,4748934018906441L,BigInteger.Parse("19474365987782658225"),BigInteger.Parse("4989739877102195271225"),BigInteger.Parse("5235591401647346852339166225"),BigInteger.Parse("1341015791319444602368386319225"),BigInteger.Parse("5495144390631448939048252704196225"),BigInteger.Parse("1407253983507773608409169421000239225"),BigInteger.Parse("92253220393640211712365553562313715740225") };
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
public class A278141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278141Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278141.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278141Inst Instance=new A278141Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278142
{
public static readonly BigInteger[] Value={ 1L,256L,1048576L,268435456L,17592186044416L,4503599627370496L,BigInteger.Parse("18446744073709551616"),BigInteger.Parse("4722366482869645213696"),BigInteger.Parse("4951760157141521099596496896"),BigInteger.Parse("1267650600228229401496703205376"),BigInteger.Parse("5192296858534827628530496329220096"),BigInteger.Parse("1329227995784915872903807060280344576"),BigInteger.Parse("87112285931760246646623899502532662132736") };
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
public class A278142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278142Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278142.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278142Inst Instance=new A278142Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278143
{
public static readonly BigInteger[] Value={ 1L,7L,475L,3675L,1924475L,15145753L,981654583L,7774283075L,32109931838075L,255083626080725L,16423892777415669L,130705503226766013L,BigInteger.Parse("67230186897380845975"),BigInteger.Parse("535644114907108845925"),BigInteger.Parse("34407319668610517498575"),BigInteger.Parse("274347338677567001587475") };
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
public class A278143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278143Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278143.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278143Inst Instance=new A278143Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278144
{
public static readonly long[] Value={ 9L,0L,9L,1L,7L,2L,7L,9L,4L,5L,4L,6L,9L,2L,9L,7L,0L,0L,7L,3L,9L,7L,7L,8L,8L,5L,4L,2L,8L,2L,6L,5L,1L,2L,2L,5L,7L,2L,0L,5L,2L,7L,2L,9L,9L,5L,9L,2L,2L,0L,5L,2L,2L,8L,3L,8L,6L,4L,1L,4L,0L,2L,1L,8L,3L,7L,2L,2L,3L,6L,4L,8L,1L,1L,1L,2L,7L,1L,8L,9L,9L,3L,2L,3L,2L,5L,6L,7L,4L,0L,5L,7L,0L,5L,1L,3L,7L,9L,5L,3L,3L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278144Inst : IEnumerable<long>
{
public static readonly long[] Value=A278144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278144.Bytes);
public long this[int i]=>Value[i];

public static A278144Inst Instance=new A278144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278145
{
public static readonly BigInteger[] Value={ 1L,8L,64L,1024L,16384L,131072L,1048576L,33554432L,1073741824L,8589934592L,68719476736L,1099511627776L,17592186044416L,140737488355328L,1125899906842624L,72057594037927936L,4611686018427387904L,BigInteger.Parse("36893488147419103232"),BigInteger.Parse("295147905179352825856"),BigInteger.Parse("4722366482869645213696") };
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
public class A278145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278145Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278145.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278145Inst Instance=new A278145Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278146
{
public static readonly long[] Value={ 1L,0L,6L,2L,6L,7L,9L,8L,9L,9L,9L,1L,6L,8L,4L,3L,6L,5L,1L,1L,8L,2L,4L,9L,0L,1L,9L,5L,1L,0L,4L,5L,1L,2L,0L,9L,1L,0L,6L,2L,5L,4L,9L,9L,1L,8L,3L,2L,6L,0L,2L,0L,6L,9L,4L,2L,4L,1L,0L,5L,4L,8L,7L,4L,0L,7L,3L,3L,9L,6L,1L,1L,1L,2L,7L,1L,8L,2L,2L,8L,3L,6L,7L,4L,0L,2L,9L,9L,0L,9L,3L,7L,2L,0L,4L,0L,6L,3L,7L,4L,5L,8L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278146Inst : IEnumerable<long>
{
public static readonly long[] Value=A278146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278146.Bytes);
public long this[int i]=>Value[i];

public static A278146Inst Instance=new A278146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278147
{
public static readonly long[] Value={ 8L,0L,18L,19L,0L,32L,0L,33L,0L,50L,34L,0L,0L,0L,72L,0L,52L,0L,73L,0L,98L,53L,0L,74L,0L,99L,0L,128L,0L,75L,0L,100L,0L,0L,0L,162L,76L,0L,101L,0L,0L,0L,163L,0L,200L,0L,102L,0L,131L,0L,164L,0L,201L,0L,242L,103L,0L,0L,0L,165L,0L,202L,0L,0L,0L,288L,0L,133L,0L,166L,0L,203L,0L,244L,0L,289L,0L,338L,134L,0L,167L,0L,204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278147Inst : IEnumerable<long>
{
public static readonly long[] Value=A278147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278147.Bytes);
public long this[int i]=>Value[i];

public static A278147Inst Instance=new A278147Inst();

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