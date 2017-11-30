using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A277262
{
public static readonly BigInteger[] Value={ 0L,1L,12L,456L,54216L,6932916L,1069256400L,170663949024L,29130191148240L,5115288488816760L,927446504770571520L,BigInteger.Parse("171486284915686699620"),BigInteger.Parse("32295496327107026335392"),BigInteger.Parse("6164943698859825359296740"),BigInteger.Parse("1190940852937573264531168944"),BigInteger.Parse("232287567721717805821704554232") };
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
public class A277262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277262Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277262.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277262Inst Instance=new A277262Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277263
{
public static readonly long[] Value={ 2L,5L,8L,19L,36L,73L,144L,293L,576L,1153L,2304L,4613L,9216L,18437L,36870L,73741L,147468L,294949L,589896L,1179799L,2359596L,4719199L,9438390L,18876787L,37753544L,75507097L,151014174L,302028365L,604056726L,1208113469L,2416226932L,4832453865L,9664907704L,19329815417L,38659630806L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277263Inst : IEnumerable<long>
{
public static readonly long[] Value=A277263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277263.Bytes);
public long this[int i]=>Value[i];

public static A277263Inst Instance=new A277263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277264
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,2L,1L,1L,0L,1L,2L,2L,1L,1L,1L,3L,3L,2L,1L,2L,3L,4L,3L,2L,2L,5L,5L,5L,3L,3L,5L,8L,6L,5L,4L,7L,9L,10L,7L,6L,8L,12L,12L,11L,8L,11L,15L,17L,14L,13L,13L,19L,21L,20L,16L,19L,23L,28L,26L,23L,23L,31L,34L,35L,30L,31L,37L,46L,44L,41L,39L,48L,55L,59L,52L,52L,59L,71L,73L,71L,65L,75L,87L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277264Inst : IEnumerable<long>
{
public static readonly long[] Value=A277264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277264.Bytes);
public long this[int i]=>Value[i];

public static A277264Inst Instance=new A277264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277265
{
public static readonly BigInteger[] Value={ 0L,1L,0L,2L,12L,2L,9L,1200L,3280L,12L,44L,498960L,97193600L,5972400L,312L,265L,415981440L,14591060915200L,73866846715200L,31918489344L,9600L,1854L,615853022400L,7390721380256614400L,BigInteger.Parse("9022243072072662432000"),BigInteger.Parse("287350869074488547328"),393956489203200L,416880L,14833L,1477095102362880L };
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
public class A277265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277265Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277265.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277265Inst Instance=new A277265Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277266
{
public static readonly long[] Value={ 1L,2L,5L,7L,8L,11L,13L,12L,18L,17L,20L,20L,23L,26L,26L,29L,31L,30L,35L,33L,38L,42L,39L,42L,46L,45L,50L,48L,51L,53L,56L,55L,59L,60L,65L,63L,66L,66L,69L,72L,74L,73L,79L,76L,79L,83L,82L,85L,89L,86L,92L,91L,94L,96L,97L,103L,102L,101L,105L,104L,111L,109L,110L,116L,115L,118L,120L,117L,126L,124L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277266Inst : IEnumerable<long>
{
public static readonly long[] Value=A277266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277266.Bytes);
public long this[int i]=>Value[i];

public static A277266Inst Instance=new A277266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277267
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,3L,3L,3L,3L,3L,4L,5L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,9L,10L,11L,12L,13L,14L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,31L,31L,31L,31L,31L,31L,31L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277267Inst : IEnumerable<long>
{
public static readonly long[] Value=A277267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277267.Bytes);
public long this[int i]=>Value[i];

public static A277267Inst Instance=new A277267Inst();

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

public static class A277284
{
public static readonly long[] Value={ 3L,5L,11L,17L,83L,431L,509L,130021L,148091L,433781L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277284Inst : IEnumerable<long>
{
public static readonly long[] Value=A277284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277284.Bytes);
public long this[int i]=>Value[i];

public static A277284Inst Instance=new A277284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277285
{
public static readonly long[] Value={ 1L,4L,16L,36L,144L,324L,400L,576L,729L,784L,900L,1764L,1936L,2304L,2500L,2704L,2916L,3600L,4356L,4624L,5184L,5776L,6084L,7056L,8100L,8464L,9604L,10000L,10404L,11664L,12996L,13456L,14400L,15376L,15876L,16384L,17424L,19044L,20736L,21904L,22500L,24336L,25600L,26244L,26896L,28224L,29584L,30276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277285Inst : IEnumerable<long>
{
public static readonly long[] Value=A277285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277285.Bytes);
public long this[int i]=>Value[i];

public static A277285Inst Instance=new A277285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277286
{
public static readonly long[] Value={ 7381L,13357L,18421L,69121L,70021L,129961L,192589L,241501L,271921L,313501L,342793L,399421L,423613L,625681L,780913L,1265641L,1362097L,1501489L,1566181L,1673101L,1691521L,1728001L,2228941L,2381401L,2472301L,2642221L,3156661L,3171961L,3383281L,3557521L,3730321L,4033861L,4233061L,4831201L,5387041L,6720961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277286Inst : IEnumerable<long>
{
public static readonly long[] Value=A277286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277286.Bytes);
public long this[int i]=>Value[i];

public static A277286Inst Instance=new A277286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277287
{
public static readonly long[] Value={ 1L,3L,10L,36L,133L,499L,1891L,7217L,27690L,106680L,412368L,1598358L,6209542L,24171004L,94246202L,368022472L,1438965885L,5632870627L,22072920103L,86575738469L,339860843589L,1335186464195L,5249164967309L,20650056413491L,81285516680103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277287Inst : IEnumerable<long>
{
public static readonly long[] Value=A277287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277287.Bytes);
public long this[int i]=>Value[i];

public static A277287Inst Instance=new A277287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277288
{
public static readonly long[] Value={ 1L,2L,14L,1978L,38209L,4782974L,9581014L,244330711L,365496202L,1661392258L,116084432414L,288504187458218L,490179448388654L,802245996685561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277288Inst : IEnumerable<long>
{
public static readonly long[] Value=A277288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277288.Bytes);
public long this[int i]=>Value[i];

public static A277288Inst Instance=new A277288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277289
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,25L,44L,4664L,6568L,1353025L,2919526L,5709589L,7827725L,64661225L,85132756L,153872408L,743947534L,34304296003L,38832409867L,40263727492L,1946603375348L,2469908330348L,64471909888247L,274267749806485L,888906849689897L,896501949422459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277289Inst : IEnumerable<long>
{
public static readonly long[] Value=A277289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277289.Bytes);
public long this[int i]=>Value[i];

public static A277289Inst Instance=new A277289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277290
{
public static readonly long[] Value={ 5L,11L,17L,31L,41L,353L,617L,4787L,5851L,148091L,637751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277290Inst : IEnumerable<long>
{
public static readonly long[] Value=A277290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277290.Bytes);
public long this[int i]=>Value[i];

public static A277290Inst Instance=new A277290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277291
{
public static readonly long[] Value={ 0L,4L,8L,24L,16L,20L,48L,42L,64L,99L,40L,88L,96L,117L,112L,120L,0L,102L,144L,76L,80L,189L,0L,184L,192L,100L,208L,324L,0L,348L,240L,372L,128L,363L,272L,210L,288L,444L,304L,624L,320L,574L,336L,258L,352L,495L,0L,564L,384L,588L,200L,612L,416L,583L,432L,440L,0L,570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277291Inst : IEnumerable<long>
{
public static readonly long[] Value=A277291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277291.Bytes);
public long this[int i]=>Value[i];

public static A277291Inst Instance=new A277291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277292
{
public static readonly BigInteger[] Value={ 1L,1L,4L,21L,122L,758L,4958L,33509L,233810L,1641150L,12364368L,71807506L,1354944972L,-33794258600L,2524565441138L,-186642439700891L,16196862324254354L,-1602823227559245434L,BigInteger.Parse("179707702260054046760"),BigInteger.Parse("-22656977557634759678794"),BigInteger.Parse("3191199098536326709613676"),BigInteger.Parse("-499206960572108744520132444"),BigInteger.Parse("86277300996554233583925645468"),BigInteger.Parse("-16395890677314419248813441481150") };
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
public class A277292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277292Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277292.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277292Inst Instance=new A277292Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277293
{
public static readonly BigInteger[] Value={ 1L,6L,230L,11676L,663174L,41413812L,2680851420L,188202575736L,11594488853190L,1403241101718852L,-168694608332762892L,BigInteger.Parse("147980852726994346248"),BigInteger.Parse("-105389748185249598629220"),BigInteger.Parse("93603955226272690108355208"),BigInteger.Parse("-97621599698823169573607867400"),BigInteger.Parse("118585871916859034002263802974192"),BigInteger.Parse("-165925215611130932978517186291637434"),BigInteger.Parse("264930310299987157013624532678164003556"),BigInteger.Parse("-478773962141712793295304310624498264046460") };
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
public class A277293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277293Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277293.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277293Inst Instance=new A277293Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277294
{
public static readonly BigInteger[] Value={ 1L,2L,35L,812L,21359L,623244L,18568947L,638475040L,13249877870L,2024051330358L,-355660668390645L,130426094235366208L,BigInteger.Parse("-54120354853298252400"),BigInteger.Parse("27045033537893084984896"),BigInteger.Parse("-15918675371944450999486319"),BigInteger.Parse("10905983125914263654567255488"),BigInteger.Parse("-8603776324190250513027830925715"),BigInteger.Parse("7743542274281960968631431340349870"),BigInteger.Parse("-7886327135586560316787947739703112447"),BigInteger.Parse("9023297352140462809043434127286176617288"),BigInteger.Parse("-11524615288427474577090651960651636283169590") };
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
public class A277294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277294Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277294.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277294Inst Instance=new A277294Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277295
{
public static readonly long[] Value={ 1L,1L,0L,2L,2L,0L,5L,14L,5L,0L,14L,74L,76L,14L,0L,42L,352L,698L,378L,42L,0L,132L,1588L,5088L,5404L,1808L,132L,0L,429L,6946L,32461L,56410L,37546L,8484L,429L,0L,1430L,29786L,189940L,486550L,535410L,244220L,39446L,1430L,0L,4862L,126008L,1046190L,3690410L,6036632L,4597402L,1522466L,182732L,4862L,0L,16796L,527900L,5511440L,25518020L,57890956L,66031704L,36873036L,9227504L,846248L,16796L,0L,58786L,2195580L,28061890L,164565240L,493085566L,784844330L,661152388L,281873618L,54885974L,3926338L,58786L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277295Inst : IEnumerable<long>
{
public static readonly long[] Value=A277295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277295.Bytes);
public long this[int i]=>Value[i];

public static A277295Inst Instance=new A277295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277296
{
public static readonly long[] Value={ 0L,5L,76L,698L,5088L,32461L,189940L,1046190L,5511440L,28061890L,139089880L,674600980L,3213923072L,15084364221L,69904629316L,320443984742L,1455102018480L,6553035703798L,29296998868904L,130133568013164L,574698326054848L,2524813186117010L,11040163152179976L,48069234287414668L,208481908639356448L,900995206054983396L,3881108155492099760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277296Inst : IEnumerable<long>
{
public static readonly long[] Value=A277296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277296.Bytes);
public long this[int i]=>Value[i];

public static A277296Inst Instance=new A277296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277297
{
public static readonly long[] Value={ 2L,14L,76L,378L,1808L,8484L,39446L,182732L,846248L,3926338L,18276832L,85436832L,401313288L,1894847846L,8994916236L,42931067910L,206002472336L,993664391720L,4817140123620L,23464959242520L,114820471485840L,564248307992850L,2783898831160512L,13786409317705920L,68509284536815640L,341538385855855064L,1707729163812908528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277297Inst : IEnumerable<long>
{
public static readonly long[] Value=A277297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277297.Bytes);
public long this[int i]=>Value[i];

public static A277297Inst Instance=new A277297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277298
{
public static readonly BigInteger[] Value={ 1L,2L,76L,5404L,535410L,66031704L,9583782716L,1584902128648L,292586323812088L,59462699504146980L,13171171610678351360UL,BigInteger.Parse("3155802303880338506184"),BigInteger.Parse("813045290972961285049576"),BigInteger.Parse("224143228528852050484555760"),BigInteger.Parse("65850557807967931843625040120"),BigInteger.Parse("20543425063284611418233827507248"),BigInteger.Parse("6784261706348459523065200262509390") };
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
public class A277298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277298Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277298.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277298Inst Instance=new A277298Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277299
{
public static readonly BigInteger[] Value={ 1L,14L,698L,56410L,6036632L,784844330L,118467338692L,20204403241014L,3825143045741850L,794096638401382028L,BigInteger.Parse("179152196191253429864"),BigInteger.Parse("43621984527307144281094"),BigInteger.Parse("11400895235718650585287660"),BigInteger.Parse("3183846191638117842792003252"),BigInteger.Parse("946381984098376099573619213864"),BigInteger.Parse("298412976572690317096982653746772") };
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
public class A277299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277299Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277299.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277299Inst Instance=new A277299Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277300
{
public static readonly BigInteger[] Value={ 1L,5L,60L,1000L,19970L,448160L,10926360L,283651245L,7740058300L,220046970860L,6476695275680L,196438030797880L,6117627849485360L,195082685133612800L,6355848358118392400L,BigInteger.Parse("211189970909192038500"),BigInteger.Parse("7146354688384980282000"),BigInteger.Parse("245970478274041025623200"),BigInteger.Parse("8602606263466490521359400"),BigInteger.Parse("305460999044315834902424200"),BigInteger.Parse("11003870605124169641012461600") };
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
public class A277300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277300Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277300.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277300Inst Instance=new A277300Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277301
{
public static readonly BigInteger[] Value={ 1L,5L,70L,1425L,35410L,999210L,30855820L,1020407105L,35642665050L,1302725802510L,49490450201460L,1944619121474970L,78734794663758580L,3275324221277662900L,BigInteger.Parse("139667810517388712600"),BigInteger.Parse("6093781146211490413825"),BigInteger.Parse("271623891311306597652650"),BigInteger.Parse("12353670814537544856558950"),BigInteger.Parse("572686428900679117724156900"),BigInteger.Parse("27036308383662996662940155550"),BigInteger.Parse("1298856469077709523772645582300") };
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
public class A277301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277301Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277301.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277301Inst Instance=new A277301Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277302
{
public static readonly BigInteger[] Value={ 1L,5L,80L,1900L,55490L,1848660L,67630080L,2657251005L,110560510400L,4824793769260L,219334788340040L,10334817935549420L,502814686712631520L,BigInteger.Parse("25184673137026274600"),BigInteger.Parse("1295595210394570426800"),BigInteger.Parse("68326193725188929358600"),BigInteger.Parse("3688253200687778850553800"),BigInteger.Parse("203524353764195058692833200"),BigInteger.Parse("11468618360097679305600299400"),BigInteger.Parse("659345494779348103800864088800"),BigInteger.Parse("38644445208422874351089132287200") };
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
public class A277302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277302Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277302.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277302Inst Instance=new A277302Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277303
{
public static readonly BigInteger[] Value={ 1L,5L,90L,2425L,80630L,3065810L,128271540L,5774538945L,275743894750L,13832116773110L,723891526915820L,39323723086794730L,2208811824884144540L,BigInteger.Parse("127904686371063157700"),BigInteger.Parse("7617441454740093233000"),BigInteger.Parse("465691699545009287055825"),BigInteger.Parse("29179499379365501297165550"),BigInteger.Parse("1871486497257264286902367950"),BigInteger.Parse("122731222232573572625823907900"),BigInteger.Parse("8222122259910817121846641763950"),BigInteger.Parse("562251437460415648354364719018900") };
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
public class A277303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277303Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277303.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277303Inst Instance=new A277303Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277304
{
public static readonly BigInteger[] Value={ 1L,6L,84L,1614L,36948L,947412L,26334072L,778107150L,24133349532L,778923367284L,26000354998920L,893459845502916L,31496296778304936L,1135911643635146712L,BigInteger.Parse("41820127450763818896"),BigInteger.Parse("1568983653501973667262"),BigInteger.Parse("59898843849911992994340"),BigInteger.Parse("2324166762372316001442540"),BigInteger.Parse("91565378725229449617874824"),BigInteger.Parse("3659689884915567083966937156"),BigInteger.Parse("148284110214725433666804447912") };
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
public class A277304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277304Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277304.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277304Inst Instance=new A277304Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277305
{
public static readonly BigInteger[] Value={ 1L,6L,132L,4350L,176964L,8235252L,421814232L,23252672574L,1359954622860L,83572511671092L,5359130778285096L,356786692299782916L,BigInteger.Parse("24565803644793789192"),BigInteger.Parse("1744056102774572824920"),BigInteger.Parse("127369971591949093219920"),BigInteger.Parse("9550397045409732902387790"),BigInteger.Parse("734084078724419876468356500"),BigInteger.Parse("57766855968717521513179054860"),BigInteger.Parse("4648888743682938087701732224680") };
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
public class A277305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277305Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277305.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277305Inst Instance=new A277305Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277306
{
public static readonly BigInteger[] Value={ 1L,1L,0L,-4L,2L,52L,-96L,-975L,4240L,18460L,-183448L,-101716L,7373216L,-23650520L,-230147920L,2198499720L,664806792L,-124144328784L,703989911368L,3189500786336L,-68800373946656L,284782780974128L,2913071885553608L,-47063844278787824L,170357147598919640L,2621783446017272624L,BigInteger.Parse("-41775596442709927664"),BigInteger.Parse("166446909354828214608") };
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
public class A277306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277306Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277306.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277306Inst Instance=new A277306Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277307
{
public static readonly BigInteger[] Value={ 1L,1L,8L,92L,1298L,20988L,375120L,7252065L,149534312L,3256987724L,74418884792L,1774657501252L,43995940957120L,1130453689908568L,30031716838365552L,823263454676130312L,BigInteger.Parse("23249951990747403528"),BigInteger.Parse("675517165191231019920"),BigInteger.Parse("20168579968950108809736"),BigInteger.Parse("618158189347428262782816"),BigInteger.Parse("19432224179107494743506272"),BigInteger.Parse("626034612821085407187912624") };
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
public class A277307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277307Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277307.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277307Inst Instance=new A277307Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277308
{
public static readonly BigInteger[] Value={ 1L,2L,20L,298L,5492L,116124L,2710776L,68308170L,1831522940L,51744512380L,1529687560328L,47075470016012L,1502258036769256L,49560341916549320L,1686236991420431760L,BigInteger.Parse("59054595629732284890"),BigInteger.Parse("2125432920387784135812"),BigInteger.Parse("78509698415432235272292"),BigInteger.Parse("2972996232264052816975752"),BigInteger.Parse("115303660044380692013332428") };
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
public class A277308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277308Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277308.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277308Inst Instance=new A277308Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277309
{
public static readonly BigInteger[] Value={ 1L,2L,28L,570L,14284L,410604L,13046728L,448252682L,16417945620L,634848045084L,25737059674104L,1088311917852828L,47813839403065432L,2175881570186952520L,BigInteger.Parse("102316326149365110320"),BigInteger.Parse("4961686220242926811690"),BigInteger.Parse("247733650768933667153660"),BigInteger.Parse("12718117037478356041212500"),BigInteger.Parse("670565414769224589112024760"),BigInteger.Parse("36274908884974158393988101900"),BigInteger.Parse("2011581759381610503724213971960") };
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
public class A277309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277309Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277309.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277309Inst Instance=new A277309Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277310
{
public static readonly BigInteger[] Value={ 1L,1L,10L,141L,2422L,47562L,1031764L,24214405L,606444990L,16055089470L,446238074892L,12955112773554L,391332183548956L,12261884937532340L,397576302315045800L,13313017677172350965UL,BigInteger.Parse("459635990935574444942"),BigInteger.Parse("16339309997761322057206"),BigInteger.Parse("597340515437542895494748"),BigInteger.Parse("22435278085988347895795526"),BigInteger.Parse("864900964565994975048855444"),BigInteger.Parse("34195693888939483596581262668"),BigInteger.Parse("1385553440866978431053220575128") };
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
public class A277310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277310Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277310.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277310Inst Instance=new A277310Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277311
{
public static readonly BigInteger[] Value={ 1L,1L,12L,200L,4034L,92752L,2353272L,64579809L,1891598860L,58591554652L,1906271367296L,64816527248936L,2294331974613872L,84290267670946720L,3206227129084419920L,BigInteger.Parse("126022120854865417140"),BigInteger.Parse("5110001578581607976400"),BigInteger.Parse("213458728365617240931360"),BigInteger.Parse("9175021814527973211291880"),BigInteger.Parse("405366362599820848509766760"),BigInteger.Parse("18392202994173383123235536800"),BigInteger.Parse("856255190568423353781484124240") };
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
public class A277311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277311Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277311.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277311Inst Instance=new A277311Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277312
{
public static readonly long[] Value={ 4L,9L,25L,49L,15L,169L,289L,361L,33L,841L,961L,1369L,1681L,1849L,69L,65L,87L,3721L,4489L,115L,5329L,91L,123L,7921L,9409L,10201L,10609L,159L,11881L,12769L,16129L,215L,18769L,19321L,185L,22801L,24649L,26569L,249L,221L,267L,32761L,329L,37249L,38809L,39601L,247L,259L,339L,52441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277312Inst : IEnumerable<long>
{
public static readonly long[] Value=A277312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277312.Bytes);
public long this[int i]=>Value[i];

public static A277312Inst Instance=new A277312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277313
{
public static readonly long[] Value={ 8L,2L,0L,3L,5L,9L,8L,6L,2L,2L,0L,8L,7L,8L,9L,7L,8L,8L,4L,7L,3L,4L,6L,6L,7L,9L,4L,9L,4L,0L,6L,3L,9L,1L,5L,8L,4L,1L,5L,9L,0L,9L,7L,5L,3L,4L,1L,3L,1L,6L,1L,9L,3L,7L,6L,5L,4L,6L,8L,7L,6L,7L,4L,9L,4L,8L,5L,0L,2L,4L,0L,7L,0L,1L,9L,2L,2L,9L,3L,8L,4L,6L,3L,2L,4L,5L,1L,7L,7L,4L,5L,4L,4L,7L,9L,2L,9L,9L,2L,8L,8L,2L,9L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277313Inst : IEnumerable<long>
{
public static readonly long[] Value=A277313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277313.Bytes);
public long this[int i]=>Value[i];

public static A277313Inst Instance=new A277313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277314
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,2L,3L,1L,3L,2L,3L,2L,3L,3L,4L,1L,4L,3L,3L,2L,3L,3L,4L,2L,4L,3L,4L,3L,4L,4L,5L,1L,5L,4L,4L,3L,4L,3L,4L,2L,4L,3L,4L,3L,4L,4L,5L,2L,5L,4L,4L,3L,4L,4L,5L,3L,5L,4L,5L,4L,5L,5L,6L,1L,6L,5L,5L,4L,5L,4L,5L,3L,5L,4L,4L,3L,4L,4L,5L,2L,5L,4L,4L,3L,4L,4L,5L,3L,5L,4L,5L,4L,5L,5L,6L,2L,6L,5L,5L,4L,5L,4L,5L,3L,5L,4L,5L,4L,5L,5L,6L,3L,6L,5L,5L,4L,5L,5L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277314Inst : IEnumerable<long>
{
public static readonly long[] Value=A277314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277314.Bytes);
public long this[int i]=>Value[i];

public static A277314Inst Instance=new A277314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277315
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,1L,1L,2L,2L,3L,1L,2L,1L,1L,1L,2L,2L,3L,2L,4L,3L,3L,1L,3L,2L,3L,1L,2L,1L,1L,1L,2L,2L,3L,2L,5L,3L,4L,2L,4L,4L,6L,3L,5L,3L,3L,1L,3L,3L,5L,2L,5L,3L,4L,1L,3L,2L,3L,1L,2L,1L,1L,1L,2L,2L,3L,2L,5L,3L,4L,2L,6L,5L,8L,3L,7L,4L,4L,2L,4L,4L,8L,4L,10L,6L,7L,3L,6L,5L,8L,3L,5L,3L,3L,1L,3L,3L,5L,3L,7L,5L,6L,2L,6L,5L,8L,3L,7L,4L,4L,1L,4L,3L,5L,2L,5L,3L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277315Inst : IEnumerable<long>
{
public static readonly long[] Value=A277315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277315.Bytes);
public long this[int i]=>Value[i];

public static A277315Inst Instance=new A277315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277316
{
public static readonly long[] Value={ 3L,6L,18L,30L,270L,450L,630L,6750L,9450L,22050L,2310L,3543750L,4961250L,53156250L,727650L,173643750L,25467750L,2668050L,40020750L,891371250L,9550406250L,1400726250L,3190703906250L,467969906250L,173423250L,16378946718750L,1715889656250L,245684200781250L,25738344843750L,8497739250L,510510L,6763506750L,66919696593750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277316Inst : IEnumerable<long>
{
public static readonly long[] Value=A277316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277316.Bytes);
public long this[int i]=>Value[i];

public static A277316Inst Instance=new A277316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277317
{
public static readonly long[] Value={ 3L,6L,18L,30L,270L,450L,630L,2310L,6750L,9450L,22050L,510510L,727650L,2668050L,3543750L,4961250L,25467750L,29099070L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277317Inst : IEnumerable<long>
{
public static readonly long[] Value=A277317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277317.Bytes);
public long this[int i]=>Value[i];

public static A277317Inst Instance=new A277317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277318
{
public static readonly long[] Value={ 3L,6L,18L,30L,270L,450L,630L,6750L,9450L,15750L,22050L,2310L,3543750L,4961250L,53156250L,727650L,173643750L,18191250L,25467750L,2668050L,90090L,40020750L,891371250L,9550406250L,212713593750L,1400726250L,3190703906250L,467969906250L,5013963281250L,104053950L,173423250L,16378946718750L,1715889656250L,245684200781250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277318Inst : IEnumerable<long>
{
public static readonly long[] Value=A277318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277318.Bytes);
public long this[int i]=>Value[i];

public static A277318Inst Instance=new A277318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277319
{
public static readonly long[] Value={ 3L,4L,6L,8L,10L,18L,22L,24L,30L,32L,40L,42L,46L,54L,56L,66L,70L,72L,88L,96L,98L,102L,114L,118L,126L,128L,130L,136L,150L,152L,168L,182L,200L,224L,234L,238L,246L,250L,266L,270L,294L,312L,318L,328L,330L,350L,354L,360L,370L,392L,402L,406L,416L,424L,434L,440L,442L,450L,472L,480L,486L,510L,536L,546L,594L,600L,630L,640L,646L,648L,650L,654L,666L,680L,690L,722L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277319Inst : IEnumerable<long>
{
public static readonly long[] Value=A277319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277319.Bytes);
public long this[int i]=>Value[i];

public static A277319Inst Instance=new A277319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277320
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,7L,4L,6L,14L,4L,5L,8L,9L,8L,13L,6L,10L,28L,12L,26L,14L,7L,12L,27L,16L,23L,28L,11L,8L,14L,18L,20L,52L,18L,22L,8L,9L,16L,21L,24L,57L,56L,29L,16L,25L,10L,18L,56L,28L,46L,54L,44L,24L,50L,26L,11L,20L,63L,32L,35L,36L,39L,32L,43L,52L,31L,12L,22L,54L,36L,104L,42L,58L,40L,100L,46L,62L,28L,13L,24L,49L,40L,101L,112L,49L,48L,125L,104L,33L,56L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277320Inst : IEnumerable<long>
{
public static readonly long[] Value=A277320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277320.Bytes);
public long this[int i]=>Value[i];

public static A277320Inst Instance=new A277320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277321
{
public static readonly long[] Value={ 2L,2L,3L,3L,5L,5L,17L,5L,7L,5L,7L,11L,257L,7L,11L,19L,13L,7L,19L,7L,17L,67L,131L,65537L,13L,7L,37L,67L,11L,131L,13L,41L,11L,13L,37L,73L,4099L,13L,137L,11L,19L,37L,32771L,4099L,23L,17L,65539L,11L,2053L,19L,262147L,521L,37L,32771L,1033L,23L,97L,13L,65539L,11L,11L,71L,262147L,43L,23L,13L,17L,11L,193L,11L,41L,268435459L,2053L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277321Inst : IEnumerable<long>
{
public static readonly long[] Value=A277321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277321.Bytes);
public long this[int i]=>Value[i];

public static A277321Inst Instance=new A277321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277322
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,1L,3L,0L,1L,1L,4L,1L,5L,2L,2L,0L,6L,1L,7L,1L,2L,1L,8L,1L,2L,2L,1L,1L,9L,1L,10L,0L,3L,2L,3L,1L,11L,2L,2L,1L,12L,1L,13L,1L,2L,1L,14L,1L,3L,1L,3L,1L,15L,1L,3L,1L,3L,3L,16L,1L,17L,2L,2L,0L,4L,1L,18L,1L,3L,1L,19L,1L,20L,2L,2L,1L,4L,2L,21L,1L,1L,2L,22L,2L,3L,2L,2L,1L,23L,2L,4L,1L,4L,2L,4L,1L,24L,1L,2L,1L,25L,1L,26L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277322Inst : IEnumerable<long>
{
public static readonly long[] Value=A277322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277322.Bytes);
public long this[int i]=>Value[i];

public static A277322Inst Instance=new A277322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277323
{
public static readonly long[] Value={ 1L,3L,5L,15L,7L,75L,35L,105L,11L,525L,245L,2625L,77L,3675L,385L,1155L,13L,5775L,2695L,128625L,847L,643125L,18865L,202125L,143L,282975L,29645L,1414875L,1001L,444675L,5005L,15015L,17L,75075L,35035L,15563625L,11011L,346644375L,2282665L,108945375L,1859L,544726875L,15978655L,12132553125L,121121L,3813088125L,2697695L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277323Inst : IEnumerable<long>
{
public static readonly long[] Value=A277323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277323.Bytes);
public long this[int i]=>Value[i];

public static A277323Inst Instance=new A277323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277324
{
public static readonly long[] Value={ 2L,6L,18L,30L,90L,270L,450L,210L,630L,6750L,20250L,9450L,15750L,47250L,22050L,2310L,6930L,330750L,3543750L,1653750L,4961250L,53156250L,24806250L,727650L,1212750L,57881250L,173643750L,18191250L,8489250L,25467750L,2668050L,30030L,90090L,40020750L,1910081250L,891371250L,9550406250L,455814843750L,212713593750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277324Inst : IEnumerable<long>
{
public static readonly long[] Value=A277324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277324.Bytes);
public long this[int i]=>Value[i];

public static A277324Inst Instance=new A277324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277325
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,2L,3L,1L,4L,1L,1L,1L,2L,2L,9L,2L,12L,3L,6L,1L,6L,4L,9L,1L,8L,1L,1L,1L,2L,2L,18L,2L,20L,9L,24L,2L,32L,12L,30L,3L,40L,6L,12L,1L,12L,6L,45L,4L,60L,9L,24L,1L,18L,8L,27L,1L,16L,1L,1L,1L,2L,2L,36L,2L,60L,18L,48L,2L,72L,20L,160L,9L,140L,24L,72L,2L,96L,32L,200L,12L,240L,30L,140L,3L,120L,40L,160L,6L,160L,12L,24L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277325Inst : IEnumerable<long>
{
public static readonly long[] Value=A277325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277325.Bytes);
public long this[int i]=>Value[i];

public static A277325Inst Instance=new A277325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277326
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,2L,3L,1L,2L,1L,1L,1L,2L,2L,3L,2L,12L,3L,6L,1L,6L,2L,3L,1L,2L,1L,1L,1L,2L,2L,6L,2L,20L,3L,12L,2L,4L,12L,30L,3L,20L,6L,6L,1L,6L,6L,15L,2L,60L,3L,12L,1L,6L,2L,3L,1L,2L,1L,1L,1L,2L,2L,6L,2L,60L,6L,12L,2L,12L,20L,40L,3L,140L,12L,12L,2L,12L,4L,40L,12L,60L,30L,140L,3L,60L,20L,40L,6L,20L,6L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277326Inst : IEnumerable<long>
{
public static readonly long[] Value=A277326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277326.Bytes);
public long this[int i]=>Value[i];

public static A277326Inst Instance=new A277326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277327
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,2L,0L,0L,2L,2L,1L,1L,2L,3L,0L,0L,3L,2L,1L,1L,2L,3L,1L,1L,3L,3L,2L,2L,3L,4L,0L,0L,4L,3L,2L,2L,3L,3L,1L,1L,3L,3L,2L,2L,3L,4L,1L,1L,4L,3L,2L,2L,3L,4L,2L,2L,4L,4L,3L,3L,4L,5L,0L,0L,5L,4L,3L,3L,4L,4L,2L,2L,4L,3L,2L,2L,3L,4L,1L,1L,4L,3L,2L,2L,3L,4L,2L,2L,4L,4L,3L,3L,4L,5L,1L,1L,5L,4L,3L,3L,4L,4L,2L,2L,4L,4L,3L,3L,4L,5L,2L,2L,5L,4L,3L,3L,4L,5L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277327Inst : IEnumerable<long>
{
public static readonly long[] Value=A277327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277327.Bytes);
public long this[int i]=>Value[i];

public static A277327Inst Instance=new A277327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277328
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,2L,0L,0L,2L,2L,1L,1L,2L,3L,0L,0L,3L,3L,1L,1L,4L,4L,1L,1L,4L,4L,2L,2L,3L,4L,0L,0L,4L,4L,3L,2L,5L,6L,1L,1L,7L,6L,2L,3L,6L,6L,1L,1L,6L,6L,3L,3L,7L,7L,2L,2L,6L,6L,3L,3L,4L,5L,0L,0L,5L,5L,4L,4L,8L,8L,2L,2L,9L,9L,4L,4L,8L,9L,1L,1L,10L,9L,5L,5L,10L,11L,2L,2L,11L,10L,5L,6L,8L,8L,1L,1L,8L,8L,5L,4L,10L,11L,3L,3L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277328Inst : IEnumerable<long>
{
public static readonly long[] Value=A277328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277328.Bytes);
public long this[int i]=>Value[i];

public static A277328Inst Instance=new A277328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277329
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,2L,3L,3L,4L,3L,3L,3L,4L,3L,4L,4L,5L,4L,4L,3L,4L,3L,4L,4L,5L,4L,4L,4L,5L,4L,5L,5L,6L,5L,5L,4L,5L,4L,4L,4L,5L,4L,4L,4L,5L,4L,5L,5L,6L,5L,5L,4L,5L,4L,5L,5L,6L,5L,5L,5L,6L,5L,6L,6L,7L,6L,6L,5L,6L,5L,5L,5L,6L,5L,5L,4L,5L,4L,5L,5L,6L,5L,5L,4L,5L,4L,5L,5L,6L,5L,5L,5L,6L,5L,6L,6L,7L,6L,6L,5L,6L,5L,5L,5L,6L,5L,5L,5L,6L,5L,6L,6L,7L,6L,6L,5L,6L,5L,6L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277329Inst : IEnumerable<long>
{
public static readonly long[] Value=A277329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277329.Bytes);
public long this[int i]=>Value[i];

public static A277329Inst Instance=new A277329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277330
{
public static readonly long[] Value={ 1L,2L,3L,6L,5L,2L,15L,30L,7L,10L,3L,30L,35L,2L,105L,210L,11L,70L,21L,30L,5L,10L,105L,42L,77L,70L,3L,210L,385L,2L,1155L,2310L,13L,770L,231L,30L,55L,70L,105L,6L,7L,2L,21L,42L,385L,10L,165L,66L,143L,110L,231L,210L,5L,70L,1155L,66L,1001L,770L,3L,2310L,5005L,2L,15015L,30030L,17L,10010L,3003L,30L,715L,770L,105L,66L,91L,154L,231L,6L,385L,70L,15L,42L,11L,14L,3L,42L,55L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277330Inst : IEnumerable<long>
{
public static readonly long[] Value=A277330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277330.Bytes);
public long this[int i]=>Value[i];

public static A277330Inst Instance=new A277330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277331
{
public static readonly long[] Value={ 1L,2L,4L,8L,6L,16L,12L,18L,32L,24L,36L,54L,30L,64L,48L,72L,108L,60L,162L,90L,150L,128L,96L,144L,216L,120L,324L,180L,300L,486L,270L,450L,750L,210L,256L,192L,288L,432L,240L,648L,360L,600L,972L,540L,900L,1500L,420L,1458L,810L,1350L,2250L,630L,3750L,1050L,1470L,512L,384L,576L,864L,480L,1296L,720L,1200L,1944L,1080L,1800L,3000L,840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277331Inst : IEnumerable<long>
{
public static readonly long[] Value=A277331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277331.Bytes);
public long this[int i]=>Value[i];

public static A277331Inst Instance=new A277331Inst();

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

public static class A277348
{
public static readonly long[] Value={ 1L,11L,341L,581337017L,7202608727L,27146455379L,1358496201131L,9843739213499L,172392038905691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277348Inst : IEnumerable<long>
{
public static readonly long[] Value=A277348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277348.Bytes);
public long this[int i]=>Value[i];

public static A277348Inst Instance=new A277348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277349
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,2L,1L,1L,0L,0L,1L,2L,2L,1L,1L,0L,1L,3L,3L,2L,1L,1L,1L,3L,4L,3L,2L,1L,2L,4L,5L,5L,3L,2L,2L,5L,7L,6L,5L,3L,3L,6L,9L,9L,7L,5L,4L,7L,11L,12L,10L,7L,6L,9L,14L,16L,14L,11L,8L,11L,17L,20L,19L,15L,12L,14L,21L,26L,25L,21L,17L,18L,26L,32L,33L,28L,23L,24L,32L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277349Inst : IEnumerable<long>
{
public static readonly long[] Value=A277349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277349.Bytes);
public long this[int i]=>Value[i];

public static A277349Inst Instance=new A277349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277350
{
public static readonly long[] Value={ 1L,15853L,5520343L,111966563L,2232207889L,5551501871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277350Inst : IEnumerable<long>
{
public static readonly long[] Value=A277350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277350.Bytes);
public long this[int i]=>Value[i];

public static A277350Inst Instance=new A277350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277351
{
public static readonly long[] Value={ 5L,14L,19L,44L,53L,62L,71L,152L,169L,186L,203L,220L,237L,254L,271L,560L,593L,626L,659L,692L,725L,758L,791L,824L,857L,890L,923L,956L,989L,1022L,1055L,2144L,2209L,2274L,2339L,2404L,2469L,2534L,2599L,2664L,2729L,2794L,2859L,2924L,2989L,3054L,3119L,3184L,3249L,3314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277351Inst : IEnumerable<long>
{
public static readonly long[] Value=A277351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277351.Bytes);
public long this[int i]=>Value[i];

public static A277351Inst Instance=new A277351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277352
{
public static readonly BigInteger[] Value={ 1L,3L,27L,513L,16929L,863379L,63026667L,6239640033L,804913564257L,131200910973891L,26371383105752091L,6408246094697758113L,BigInteger.Parse("1851983121367652094657"),BigInteger.Parse("627822278143634060088723"),BigInteger.Parse("246734155310448185614868139"),BigInteger.Parse("111277104045012131712305530689") };
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
public class A277352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277352Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277352.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277352Inst Instance=new A277352Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277353
{
public static readonly BigInteger[] Value={ 1L,4L,52L,1456L,71344L,5422144L,591013696L,87470027008L,16881715212544L,4119138511860736L,1239860692070081536L,BigInteger.Parse("451309291913509679104"),BigInteger.Parse("195416923398549691052032"),BigInteger.Parse("99271797086463243054432256"),BigInteger.Parse("58471088483926850159060598784"),BigInteger.Parse("39526455815134550707524964777984") };
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
public class A277353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277353Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277353.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277353Inst Instance=new A277353Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277354
{
public static readonly BigInteger[] Value={ 1L,5L,85L,3145L,204425L,20646925L,2993804125L,589779412625L,151573309044625L,49261325439503125L,BigInteger.Parse("19753791501240753125"),BigInteger.Parse("9580588878101765265625"),BigInteger.Parse("5527999782664718558265625"),BigInteger.Parse("3742455852864014463945828125"),BigInteger.Parse("2937827844498251354197475078125") };
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
public class A277354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277354Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277354.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277354Inst Instance=new A277354Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277355
{
public static readonly BigInteger[] Value={ 1L,3L,18L,198L,3960L,146520L,10256400L,1384614000L,365538096000L,190445348016000L,196920489848544000L,BigInteger.Parse("405459288598152096000"),BigInteger.Parse("1665626757561208810368000"),BigInteger.Parse("13666467545789718289069440000"),BigInteger.Parse("224102734815859800504160677120000"),BigInteger.Parse("7346759955468331839927899478024960000") };
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
public class A277355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277355Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277355.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277355Inst Instance=new A277355Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277356
{
public static readonly BigInteger[] Value={ 21L,85L,341L,5461L,22369621L,178956971L,5726623061L,45812984491L,91625968981L,733007751851L,46912496118443L,187649984473771L,3002399751580331L,1537228672809129301L,BigInteger.Parse("49191317529892137643"),BigInteger.Parse("787061080478274202283"),BigInteger.Parse("3148244321913096809131") };
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
public class A277356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277356Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277356.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277356Inst Instance=new A277356Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277357
{
public static readonly BigInteger[] Value={ 1L,4L,29L,436L,13517L,851572L,108149645L,27578159476L,14092439492237L,14416565600558452L,BigInteger.Parse("29510709784343151245"),BigInteger.Parse("120846356566885204348276"),BigInteger.Parse("989852506639356708816728717"),BigInteger.Parse("16216753616272580960544466570612"),BigInteger.Parse("531374365744403660334160536119243405") };
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
public class A277357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277357Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277357.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277357Inst Instance=new A277357Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277358
{
public static readonly BigInteger[] Value={ 1L,2L,9L,58L,491L,5142L,64159L,929078L,15314361L,283091122L,5799651689L,130423248378L,3193954129651L,84607886351462L,2410542221526399L,73500777054712438L,2388182999073694001L,BigInteger.Parse("82374234401380995042"),BigInteger.Parse("3006071549433968619529"),BigInteger.Parse("115713455097715665452858") };
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
public class A277358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277358Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277358.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277358Inst Instance=new A277358Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277359
{
public static readonly BigInteger[] Value={ 1L,2L,7L,32L,176L,1126L,8227L,67768L,622706L,6323932L,70400734L,852952952L,11176241098L,157506733030L,2375966883371L,38200984291800L,652179787654530L,11783182484950980L,224623760504277810L,4505795627243046240L,BigInteger.Parse("94873821120923655336"),BigInteger.Parse("2092249161797280567516") };
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
public class A277359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277359Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277359.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277359Inst Instance=new A277359Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277360
{
public static readonly BigInteger[] Value={ 1L,9L,491L,64159L,15314361L,5799651689L,3193954129651L,2410542221526399L,2388182999073694001L,BigInteger.Parse("3006071549433968619529"),BigInteger.Parse("4685653563347872021885371"),BigInteger.Parse("8859314350383162594502273439"),BigInteger.Parse("19975392290718104323103596377961"),BigInteger.Parse("52949467092712165429316121638458089") };
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
public class A277360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277360Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277360.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277360Inst Instance=new A277360Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277361
{
public static readonly long[] Value={ 0L,0L,1L,2L,11L,28L,80L,194L,461L,1036L,2263L,4800L,9960L,20268L,40577L,80086L,156115L,301004L,574744L,1087918L,2043229L,3810320L,7060079L,13004832L,23826480L,43437240L,78827425L,142446698L,256400411L,459826588L,821834624L,1464149690L,2600662157L,4606368148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277361Inst : IEnumerable<long>
{
public static readonly long[] Value=A277361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277361.Bytes);
public long this[int i]=>Value[i];

public static A277361Inst Instance=new A277361Inst();

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