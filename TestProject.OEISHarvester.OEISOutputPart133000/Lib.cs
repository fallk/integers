using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A162305
{
public static readonly long[] Value={ 25L,36L,100L,110L,125L,210L,250L,310L,360L,375L,410L,510L,610L,625L,710L,810L,910L,1000L,1010L,1020L,1030L,1040L,1050L,1060L,1070L,1080L,1090L,1100L,1100L,1110L,1210L,1250L,1250L,1310L,1410L,1510L,1610L,1710L,1810L,1910L,2010L,2100L,2100L,2110L,2210L,2310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162305Inst : IEnumerable<long>
{
public static readonly long[] Value=A162305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162305.Bytes);
public long this[int i]=>Value[i];

public static A162305Inst Instance=new A162305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162306
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,2L,4L,1L,5L,1L,2L,3L,4L,6L,1L,7L,1L,2L,4L,8L,1L,3L,9L,1L,2L,4L,5L,8L,10L,1L,11L,1L,2L,3L,4L,6L,8L,9L,12L,1L,13L,1L,2L,4L,7L,8L,14L,1L,3L,5L,9L,15L,1L,2L,4L,8L,16L,1L,17L,1L,2L,3L,4L,6L,8L,9L,12L,16L,18L,1L,19L,1L,2L,4L,5L,8L,10L,16L,20L,1L,3L,7L,9L,21L,1L,2L,4L,8L,11L,16L,22L,1L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162306Inst : IEnumerable<long>
{
public static readonly long[] Value=A162306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162306.Bytes);
public long this[int i]=>Value[i];

public static A162306Inst Instance=new A162306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162307
{
public static readonly long[] Value={ 3L,19L,31L,83L,131L,223L,383L,479L,643L,1279L,1823L,2131L,2239L,2579L,2819L,3331L,4483L,4639L,6163L,6719L,7103L,7699L,8963L,9631L,9859L,10559L,11779L,13331L,14143L,14419L,15263L,17939L,19843L,21503L,22531L,24659L,25759L,28031L,29599L,30803L,35423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162307Inst : IEnumerable<long>
{
public static readonly long[] Value=A162307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162307.Bytes);
public long this[int i]=>Value[i];

public static A162307Inst Instance=new A162307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162308
{
public static readonly long[] Value={ 0L,7L,9L,11L,11L,13L,15L,15L,15L,15L,19L,19L,19L,23L,23L,23L,23L,29L,29L,31L,33L,33L,33L,35L,37L,37L,39L,39L,39L,41L,41L,41L,41L,41L,41L,41L,41L,41L,41L,45L,45L,45L,45L,47L,47L,47L,47L,47L,47L,47L,49L,49L,49L,49L,51L,51L,51L,53L,53L,55L,57L,57L,59L,59L,59L,59L,59L,59L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162308Inst : IEnumerable<long>
{
public static readonly long[] Value=A162308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162308.Bytes);
public long this[int i]=>Value[i];

public static A162308Inst Instance=new A162308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162309
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,5L,6L,10L,10L,13L,13L,17L,17L,17L,19L,20L,23L,24L,26L,29L,39L,39L,43L,50L,54L,57L,59L,60L,62L,80L,80L,80L,82L,84L,101L,101L,102L,102L,104L,110L,119L,122L,123L,124L,125L,133L,136L,138L,138L,153L,154L,158L,159L,160L,167L,174L,174L,178L,178L,182L,185L,189L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162309Inst : IEnumerable<long>
{
public static readonly long[] Value=A162309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162309.Bytes);
public long this[int i]=>Value[i];

public static A162309Inst Instance=new A162309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162310
{
public static readonly long[] Value={ 0L,4L,5L,6L,6L,7L,8L,8L,8L,8L,10L,10L,10L,12L,12L,12L,12L,15L,15L,16L,17L,17L,17L,18L,19L,19L,20L,20L,20L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,23L,23L,23L,23L,24L,24L,24L,24L,24L,24L,24L,25L,25L,25L,25L,26L,26L,26L,27L,27L,28L,29L,29L,30L,30L,30L,30L,30L,30L,30L,30L,30L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162310Inst : IEnumerable<long>
{
public static readonly long[] Value=A162310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162310.Bytes);
public long this[int i]=>Value[i];

public static A162310Inst Instance=new A162310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162311
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,10L,14L,17L,19L,20L,21L,23L,25L,27L,28L,29L,31L,33L,35L,36L,37L,39L,42L,46L,49L,51L,52L,53L,55L,58L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162311Inst : IEnumerable<long>
{
public static readonly long[] Value=A162311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162311.Bytes);
public long this[int i]=>Value[i];

public static A162311Inst Instance=new A162311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162312
{
public static readonly long[] Value={ 1L,-2L,1L,6L,-4L,1L,-26L,18L,-6L,1L,150L,-104L,36L,-8L,1L,-1082L,750L,-260L,60L,-10L,1L,9366L,-6492L,2250L,-520L,90L,-12L,1L,-94586L,65562L,-22722L,5250L,-910L,126L,-14L,1L,1091670L,-756688L,262248L,-60592L,10500L,-1456L,168L,-16L,1L,-14174522L,9825030L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162312Inst : IEnumerable<long>
{
public static readonly long[] Value=A162312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162312.Bytes);
public long this[int i]=>Value[i];

public static A162312Inst Instance=new A162312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162313
{
public static readonly long[] Value={ 1L,3L,1L,17L,6L,1L,147L,51L,9L,1L,1697L,588L,102L,12L,1L,24483L,8485L,1470L,170L,15L,1L,423857L,146898L,25455L,2940L,255L,18L,1L,8560947L,2966999L,514143L,59395L,5145L,357L,21L,1L,197613377L,68487576L,11867996L,1371048L,118790L,8232L,476L,24L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162313Inst : IEnumerable<long>
{
public static readonly long[] Value=A162313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162313.Bytes);
public long this[int i]=>Value[i];

public static A162313Inst Instance=new A162313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162314
{
public static readonly BigInteger[] Value={ 1L,4L,24L,208L,2400L,34624L,599424L,12107008L,279467520L,7257355264L,209403009024L,6646303019008L,230126121738240L,8632047179874304L,348695526455476224L,15091839203924574208UL,BigInteger.Parse("696733490476660162560") };
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
public class A162314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162314Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A162314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162314.Bytes);
public BigInteger this[int i]=>Value[i];

public static A162314Inst Instance=new A162314Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162315
{
public static readonly long[] Value={ 1L,3L,1L,1L,6L,1L,3L,3L,9L,1L,1L,12L,6L,12L,1L,3L,5L,30L,10L,15L,1L,1L,18L,15L,60L,15L,18L,1L,3L,7L,63L,35L,105L,21L,21L,1L,1L,24L,28L,168L,70L,168L,28L,24L,1L,3L,9L,108L,84L,378L,126L,252L,36L,27L,1L,1L,30L,45L,360L,210L,756L,210L,360L,45L,30L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162315Inst : IEnumerable<long>
{
public static readonly long[] Value=A162315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162315.Bytes);
public long this[int i]=>Value[i];

public static A162315Inst Instance=new A162315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162316
{
public static readonly long[] Value={ 1L,26L,61L,106L,161L,226L,301L,386L,481L,586L,701L,826L,961L,1106L,1261L,1426L,1601L,1786L,1981L,2186L,2401L,2626L,2861L,3106L,3361L,3626L,3901L,4186L,4481L,4786L,5101L,5426L,5761L,6106L,6461L,6826L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162316Inst : IEnumerable<long>
{
public static readonly long[] Value=A162316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162316.Bytes);
public long this[int i]=>Value[i];

public static A162316Inst Instance=new A162316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162317
{
public static readonly long[] Value={ 5L,6L,7L,10L,13L,16L,20L,22L,24L,27L,32L,35L,36L,37L,45L,46L,48L,49L,50L,51L,58L,61L,62L,64L,68L,73L,74L,76L,80L,82L,91L,92L,99L,100L,106L,115L,117L,120L,123L,124L,143L,144L,146L,152L,153L,157L,164L,166L,168L,169L,170L,174L,178L,187L,188L,193L,196L,206L,212L,224L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162317Inst : IEnumerable<long>
{
public static readonly long[] Value=A162317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162317.Bytes);
public long this[int i]=>Value[i];

public static A162317Inst Instance=new A162317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162318
{
public static readonly long[] Value={ 5L,6L,7L,10L,13L,20L,22L,27L,32L,37L,45L,46L,50L,51L,58L,61L,62L,68L,73L,74L,76L,82L,91L,92L,106L,115L,117L,123L,124L,146L,152L,153L,157L,164L,166L,170L,174L,178L,187L,188L,193L,206L,212L,226L,235L,236L,245L,261L,262L,267L,272L,274L,277L,278L,284L,291L,313L,325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162318Inst : IEnumerable<long>
{
public static readonly long[] Value=A162318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162318.Bytes);
public long this[int i]=>Value[i];

public static A162318Inst Instance=new A162318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162319
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,1L,2L,4L,1L,1L,2L,3L,5L,1L,1L,1L,2L,3L,6L,1L,1L,1L,2L,2L,3L,7L,1L,1L,1L,1L,2L,2L,3L,8L,1L,1L,1L,1L,2L,2L,2L,4L,9L,1L,1L,1L,1L,1L,2L,2L,2L,4L,10L,1L,1L,1L,1L,1L,2L,2L,2L,3L,4L,11L,1L,1L,1L,1L,1L,1L,2L,2L,2L,3L,4L,12L,1L,1L,1L,1L,1L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162319Inst : IEnumerable<long>
{
public static readonly long[] Value=A162319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162319.Bytes);
public long this[int i]=>Value[i];

public static A162319Inst Instance=new A162319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162320
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,1L,1L,2L,3L,1L,1L,1L,2L,3L,1L,1L,1L,2L,2L,3L,1L,1L,1L,1L,2L,2L,3L,1L,1L,1L,1L,2L,2L,2L,4L,1L,1L,1L,1L,1L,2L,2L,2L,4L,1L,1L,1L,1L,1L,2L,2L,2L,3L,4L,1L,1L,1L,1L,1L,1L,2L,2L,2L,3L,4L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,4L,1L,1L,1L,1L,1L,1L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162320Inst : IEnumerable<long>
{
public static readonly long[] Value=A162320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162320.Bytes);
public long this[int i]=>Value[i];

public static A162320Inst Instance=new A162320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162321
{
public static readonly long[] Value={ 1L,15L,119L,665L,2939L,10933L,35580L,103972L,277950L,689282L,1602727L,3523945L,7376794L,14784390L,28500705L,53054702L,95687240L,167682306L,286218490L,476893794L,777106448L,1240505775L,1942759458L,2988915740L,4522669833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162321Inst : IEnumerable<long>
{
public static readonly long[] Value=A162321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162321.Bytes);
public long this[int i]=>Value[i];

public static A162321Inst Instance=new A162321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162322
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,2L,4L,3L,4L,2L,6L,2L,4L,5L,2L,6L,2L,6L,4L,2L,8L,3L,4L,6L,2L,8L,2L,6L,4L,9L,2L,4L,8L,2L,8L,2L,6L,4L,2L,10L,3L,6L,4L,6L,2L,8L,4L,8L,4L,2L,12L,2L,4L,6L,7L,4L,8L,2L,6L,4L,8L,2L,12L,2L,4L,6L,4L,8L,2L,10L,5L,4L,2L,12L,4L,8L,2L,12L,4L,6L,4L,12L,2L,6L,9L,2L,8L,2L,8L,4L,2L,12L,2L,8L,4L,10L,2L,8L,4L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162322Inst : IEnumerable<long>
{
public static readonly long[] Value=A162322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162322.Bytes);
public long this[int i]=>Value[i];

public static A162322Inst Instance=new A162322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162323
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,6L,7L,2L,3L,5L,11L,6L,13L,14L,11L,2L,17L,6L,19L,5L,7L,11L,23L,6L,5L,13L,3L,14L,29L,11L,31L,2L,11L,17L,23L,6L,37L,19L,13L,5L,41L,14L,43L,11L,11L,23L,47L,6L,7L,5L,35L,13L,53L,6L,11L,14L,19L,29L,59L,11L,61L,62L,7L,2L,13L,11L,67L,17L,23L,23L,71L,6L,73L,37L,11L,19L,23L,13L,79L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162323Inst : IEnumerable<long>
{
public static readonly long[] Value=A162323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162323.Bytes);
public long this[int i]=>Value[i];

public static A162323Inst Instance=new A162323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162324
{
public static readonly BigInteger[] Value={ 1234567891L,11L,1213L,14151617L,181L,BigInteger.Parse("920212223242526272829303132333435363738394041424344454647484950515253"),5L };
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
public class A162324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162324Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A162324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162324.Bytes);
public BigInteger this[int i]=>Value[i];

public static A162324Inst Instance=new A162324Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162325
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,3L,7L,2L,3L,5L,11L,3L,13L,7L,5L,2L,17L,3L,19L,2L,7L,11L,23L,3L,5L,13L,3L,2L,29L,5L,31L,2L,11L,17L,7L,3L,37L,19L,13L,2L,41L,3L,43L,2L,5L,23L,47L,3L,7L,5L,17L,2L,53L,3L,11L,2L,19L,29L,59L,3L,61L,31L,7L,2L,13L,3L,67L,2L,23L,7L,71L,3L,73L,37L,5L,2L,11L,3L,79L,2L,3L,41L,83L,3L,17L,43L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162325Inst : IEnumerable<long>
{
public static readonly long[] Value=A162325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162325.Bytes);
public long this[int i]=>Value[i];

public static A162325Inst Instance=new A162325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162326
{
public static readonly long[] Value={ 1L,1L,3L,13L,71L,441L,2955L,20805L,151695L,1135345L,8671763L,67320573L,529626839L,4213228969L,33833367963L,273892683573L,2232832964895L,18314495896545L,151037687326755L,1251606057754605L,10416531069771111L,87029307323766681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162326Inst : IEnumerable<long>
{
public static readonly long[] Value=A162326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162326.Bytes);
public long this[int i]=>Value[i];

public static A162326Inst Instance=new A162326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162327
{
public static readonly long[] Value={ 1L,16L,135L,800L,3739L,14672L,50252L,154224L,432174L,1121456L,2724183L,6248128L,13624922L,28409312L,56910017L,109964720L,205651974L,373334384L,659553420L,1136449488L,1913563930L,3154094352L,5096922202L,8086011920L,12609093085L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162327Inst : IEnumerable<long>
{
public static readonly long[] Value=A162327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162327.Bytes);
public long this[int i]=>Value[i];

public static A162327Inst Instance=new A162327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162328
{
public static readonly long[] Value={ 1L,17L,152L,952L,4691L,19363L,69615L,223839L,656013L,1777469L,4501652L,10749780L,24374702L,52784014L,109694031L,219658751L,425310726L,798645125L,1458198664L,2594648817L,4508215686L,7662320971L,12759278753L,20845394645L,33454765680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162328Inst : IEnumerable<long>
{
public static readonly long[] Value=A162328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162328.Bytes);
public long this[int i]=>Value[i];

public static A162328Inst Instance=new A162328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162329
{
public static readonly long[] Value={ 0L,1L,5L,13L,29L,54L,97L,161L,257L,402L,604L,896L,1299L,1866L,2616L,3665L,5031L,6891L,9290L,12498L,16600L,22008L,28841L,37740L,48919L,63294L,81230L,104048L,132355L,168048L,212070L,267105L,334671L,418486L,520857L,647081L,800531L,988510L,1216159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162329Inst : IEnumerable<long>
{
public static readonly long[] Value=A162329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162329.Bytes);
public long this[int i]=>Value[i];

public static A162329Inst Instance=new A162329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162330
{
public static readonly long[] Value={ 2L,1L,2L,3L,4L,3L,4L,5L,6L,5L,6L,7L,8L,7L,8L,9L,10L,9L,10L,11L,12L,11L,12L,13L,14L,13L,14L,15L,16L,15L,16L,17L,18L,17L,18L,19L,20L,19L,20L,21L,22L,21L,22L,23L,24L,23L,24L,25L,26L,25L,26L,27L,28L,27L,28L,29L,30L,29L,30L,31L,32L,31L,32L,33L,34L,33L,34L,35L,36L,35L,36L,37L,38L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162330Inst : IEnumerable<long>
{
public static readonly long[] Value=A162330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162330.Bytes);
public long this[int i]=>Value[i];

public static A162330Inst Instance=new A162330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162331
{
public static readonly long[] Value={ 18L,24L,33L,39L,48L,51L,75L,78L,90L,99L,144L,153L,162L,171L,174L,189L,195L,198L,243L,249L,252L,267L,270L,303L,315L,318L,327L,330L,336L,345L,348L,360L,375L,399L,405L,411L,420L,432L,450L,453L,456L,468L,474L,477L,483L,489L,492L,495L,504L,516L,525L,531L,534L,540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162331Inst : IEnumerable<long>
{
public static readonly long[] Value=A162331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162331.Bytes);
public long this[int i]=>Value[i];

public static A162331Inst Instance=new A162331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162332
{
public static readonly long[] Value={ 1L,6L,19L,33L,35L,37L,44L,48L,51L,71L,72L,75L,90L,91L,99L,102L,107L,108L,111L,116L,120L,125L,127L,129L,134L,135L,147L,150L,152L,153L,154L,156L,159L,163L,179L,181L,186L,188L,189L,190L,198L,199L,201L,204L,210L,213L,216L,219L,224L,225L,226L,228L,231L,244L,251L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162332Inst : IEnumerable<long>
{
public static readonly long[] Value=A162332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162332.Bytes);
public long this[int i]=>Value[i];

public static A162332Inst Instance=new A162332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162333
{
public static readonly long[] Value={ 0L,3L,48L,69L,99L,102L,105L,117L,123L,126L,129L,135L,138L,144L,159L,162L,171L,174L,183L,198L,201L,216L,219L,222L,225L,228L,234L,237L,240L,243L,252L,255L,267L,273L,276L,279L,282L,285L,288L,291L,297L,309L,312L,315L,318L,321L,324L,333L,336L,339L,345L,351L,369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162333Inst : IEnumerable<long>
{
public static readonly long[] Value=A162333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162333.Bytes);
public long this[int i]=>Value[i];

public static A162333Inst Instance=new A162333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162334
{
public static readonly long[] Value={ 1L,22L,24L,25L,34L,36L,43L,48L,51L,54L,55L,57L,58L,61L,64L,67L,69L,72L,73L,75L,82L,85L,87L,88L,91L,93L,97L,102L,105L,106L,108L,109L,111L,117L,118L,124L,127L,129L,133L,135L,136L,139L,141L,145L,147L,148L,151L,153L,154L,159L,166L,168L,169L,172L,174L,175L,177L,183L,184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162334Inst : IEnumerable<long>
{
public static readonly long[] Value=A162334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162334.Bytes);
public long this[int i]=>Value[i];

public static A162334Inst Instance=new A162334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162335
{
public static readonly long[] Value={ 3L,6L,15L,20L,21L,33L,35L,39L,42L,63L,66L,71L,72L,80L,81L,92L,110L,111L,117L,119L,126L,135L,150L,155L,156L,158L,159L,164L,167L,174L,176L,197L,201L,203L,204L,210L,213L,215L,225L,237L,242L,245L,248L,249L,260L,264L,279L,303L,317L,320L,323L,326L,329L,330L,333L,335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162335Inst : IEnumerable<long>
{
public static readonly long[] Value=A162335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162335.Bytes);
public long this[int i]=>Value[i];

public static A162335Inst Instance=new A162335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162336
{
public static readonly long[] Value={ 5L,11L,17L,29L,47L,71L,89L,101L,107L,191L,197L,227L,251L,269L,317L,359L,461L,467L,521L,569L,647L,659L,701L,719L,821L,857L,881L,911L,929L,947L,971L,1091L,1109L,1181L,1217L,1259L,1289L,1361L,1367L,1451L,1487L,1559L,1637L,1847L,1889L,1979L,2099L,2141L,2207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162336Inst : IEnumerable<long>
{
public static readonly long[] Value=A162336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162336.Bytes);
public long this[int i]=>Value[i];

public static A162336Inst Instance=new A162336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162337
{
public static readonly long[] Value={ 7L,11L,17L,23L,41L,53L,59L,71L,89L,113L,131L,179L,239L,251L,269L,293L,311L,383L,419L,449L,491L,503L,521L,593L,599L,683L,701L,719L,773L,809L,881L,941L,953L,1013L,1049L,1061L,1103L,1151L,1193L,1229L,1259L,1301L,1319L,1373L,1439L,1499L,1511L,1571L,1709L,1733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162337Inst : IEnumerable<long>
{
public static readonly long[] Value=A162337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162337.Bytes);
public long this[int i]=>Value[i];

public static A162337Inst Instance=new A162337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162338
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,19L,23L,29L,37L,43L,59L,79L,83L,89L,97L,103L,127L,139L,149L,163L,167L,173L,197L,199L,227L,233L,239L,257L,269L,293L,313L,317L,337L,349L,353L,367L,383L,397L,409L,419L,433L,439L,457L,479L,499L,503L,523L,569L,577L,607L,643L,659L,709L,757L,769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162338Inst : IEnumerable<long>
{
public static readonly long[] Value=A162338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162338.Bytes);
public long this[int i]=>Value[i];

public static A162338Inst Instance=new A162338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162339
{
public static readonly long[] Value={ 0L,1L,4L,2L,6L,4L,6L,7L,9L,5L,7L,11L,12L,10L,6L,8L,14L,16L,14L,20L,18L,15L,19L,21L,19L,21L,19L,15L,23L,33L,27L,26L,24L,26L,22L,30L,28L,30L,28L,26L,28L,30L,20L,28L,38L,36L,31L,37L,41L,45L,43L,39L,43L,39L,43L,45L,43L,47L,43L,49L,46L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162339Inst : IEnumerable<long>
{
public static readonly long[] Value=A162339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162339.Bytes);
public long this[int i]=>Value[i];

public static A162339Inst Instance=new A162339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162340
{
public static readonly long[] Value={ 1L,2L,5L,6L,10L,12L,16L,18L,22L,26L,31L,34L,40L,42L,46L,50L,57L,60L,65L,69L,73L,76L,82L,86L,94L,99L,103L,105L,109L,111L,121L,129L,135L,138L,145L,150L,155L,160L,166L,170L,177L,180L,187L,192L,196L,198L,206L,217L,226L,228L,232L,236L,241L,246L,255L,260L,267L,270L,275L,279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162340Inst : IEnumerable<long>
{
public static readonly long[] Value=A162340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162340.Bytes);
public long this[int i]=>Value[i];

public static A162340Inst Instance=new A162340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162341
{
public static readonly long[] Value={ 1L,1L,3L,1L,4L,2L,4L,2L,4L,4L,5L,3L,6L,2L,4L,4L,7L,3L,5L,4L,4L,3L,6L,4L,8L,5L,4L,2L,4L,2L,10L,8L,6L,3L,7L,5L,5L,5L,6L,4L,7L,3L,7L,5L,4L,2L,8L,11L,9L,2L,4L,4L,5L,5L,9L,5L,7L,3L,5L,4L,4L,5L,13L,8L,4L,2L,10L,9L,9L,5L,4L,4L,8L,6L,7L,4L,6L,6L,7L,5L,10L,5L,7L,5L,5L,4L,6L,6L,7L,2L,4L,7L,11L,5L,7L,5L,6L,8L,8L,9L,13L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162341Inst : IEnumerable<long>
{
public static readonly long[] Value=A162341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162341.Bytes);
public long this[int i]=>Value[i];

public static A162341Inst Instance=new A162341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162342
{
public static readonly long[] Value={ 0L,0L,2L,4L,9L,13L,20L,26L,35L,41L,51L,59L,72L,84L,99L,111L,129L,145L,165L,182L,202L,220L,243L,263L,290L,313L,339L,364L,392L,419L,455L,484L,518L,550L,588L,622L,660L,694L,733L,769L,811L,851L,897L,939L,984L,1028L,1079L,1120L,1169L,1217L,1268L,1316L,1368L,1416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162342Inst : IEnumerable<long>
{
public static readonly long[] Value=A162342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162342.Bytes);
public long this[int i]=>Value[i];

public static A162342Inst Instance=new A162342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162343
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,11L,12L,9L,10L,13L,14L,17L,18L,25L,26L,15L,16L,19L,24L,27L,20L,23L,28L,33L,34L,21L,22L,29L,32L,35L,30L,31L,36L,37L,38L,41L,42L,49L,50L,39L,40L,43L,48L,51L,44L,47L,52L,45L,46L,53L,54L,59L,60L,55L,58L,61L,68L,69L,56L,57L,62L,67L,70L,75L,76L,63L,66L,71L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162343Inst : IEnumerable<long>
{
public static readonly long[] Value=A162343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162343.Bytes);
public long this[int i]=>Value[i];

public static A162343Inst Instance=new A162343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162344
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,10L,12L,13L,14L,15L,17L,16L,18L,19L,20L,21L,25L,24L,23L,22L,26L,27L,28L,29L,30L,33L,32L,31L,34L,35L,36L,37L,38L,39L,41L,40L,42L,43L,44L,45L,49L,48L,47L,46L,50L,51L,52L,53L,54L,55L,56L,59L,58L,57L,60L,61L,62L,63L,64L,68L,67L,66L,65L,69L,70L,71L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162344Inst : IEnumerable<long>
{
public static readonly long[] Value=A162344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162344.Bytes);
public long this[int i]=>Value[i];

public static A162344Inst Instance=new A162344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162345
{
public static readonly long[] Value={ 2L,2L,2L,3L,3L,3L,3L,3L,5L,4L,4L,5L,3L,3L,5L,6L,4L,4L,5L,3L,4L,5L,5L,7L,6L,3L,3L,3L,3L,9L,9L,5L,4L,6L,6L,4L,6L,5L,5L,6L,4L,6L,6L,3L,3L,7L,12L,8L,3L,3L,5L,4L,6L,8L,6L,6L,4L,4L,5L,3L,6L,12L,9L,3L,3L,9L,10L,8L,6L,3L,5L,7L,7L,6L,5L,5L,7L,6L,6L,9L,6L,6L,6L,4L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162345Inst : IEnumerable<long>
{
public static readonly long[] Value=A162345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162345.Bytes);
public long this[int i]=>Value[i];

public static A162345Inst Instance=new A162345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162346
{
public static readonly long[] Value={ 1L,18L,170L,1122L,5813L,25176L,94791L,318630L,974643L,2752112L,7253764L,18003544L,42378246L,95162260L,204856291L,424515042L,849825768L,1648470894L,3106669574L,5701318526L,10209535012L,17871859722L,30631153147L,51476598044L,84931517948L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162346Inst : IEnumerable<long>
{
public static readonly long[] Value=A162346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162346.Bytes);
public long this[int i]=>Value[i];

public static A162346Inst Instance=new A162346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162347
{
public static readonly long[] Value={ 1L,19L,189L,1311L,7124L,32300L,127091L,445721L,1420364L,4172476L,11426240L,29429784L,71808030L,166970290L,371826581L,796341623L,1646167391L,3294638285L,6401307860L,12102626403L,22312161567L,40184022241L,70815180079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162347Inst : IEnumerable<long>
{
public static readonly long[] Value=A162347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162347.Bytes);
public long this[int i]=>Value[i];

public static A162347Inst Instance=new A162347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162348
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,3L,2L,2L,1L,5L,2L,3L,1L,7L,2L,4L,3L,3L,2L,5L,1L,11L,3L,4L,1L,13L,2L,7L,3L,5L,4L,4L,1L,17L,3L,6L,1L,19L,4L,5L,3L,7L,2L,11L,1L,23L,4L,6L,5L,5L,2L,13L,3L,9L,4L,7L,1L,29L,5L,6L,1L,31L,4L,8L,3L,11L,2L,17L,5L,7L,6L,6L,1L,37L,2L,19L,3L,13L,5L,8L,1L,41L,6L,7L,1L,43L,4L,11L,5L,9L,2L,23L,1L,47L,6L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162348Inst : IEnumerable<long>
{
public static readonly long[] Value=A162348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162348.Bytes);
public long this[int i]=>Value[i];

public static A162348Inst Instance=new A162348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162349
{
public static readonly long[] Value={ 3L,9L,9L,27L,9L,27L,27L,81L,9L,27L,27L,81L,27L,81L,81L,243L,9L,27L,27L,81L,27L,81L,81L,243L,27L,81L,81L,243L,81L,243L,243L,729L,9L,27L,27L,81L,27L,81L,81L,243L,27L,81L,81L,243L,81L,243L,243L,729L,27L,81L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162349Inst : IEnumerable<long>
{
public static readonly long[] Value=A162349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162349.Bytes);
public long this[int i]=>Value[i];

public static A162349Inst Instance=new A162349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162350
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,0L,2L,1L,2L,2L,3L,2L,4L,2L,4L,3L,4L,4L,4L,5L,5L,5L,5L,4L,6L,4L,6L,5L,6L,6L,6L,7L,7L,7L,7L,6L,8L,6L,8L,7L,8L,8L,8L,9L,9L,9L,9L,8L,9L,7L,9L,6L,10L,6L,10L,7L,10L,8L,10L,9L,10L,10L,11L,10L,11L,9L,11L,8L,12L,8L,12L,9L,12L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162350Inst : IEnumerable<long>
{
public static readonly long[] Value=A162350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162350.Bytes);
public long this[int i]=>Value[i];

public static A162350Inst Instance=new A162350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162351
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,3L,4L,4L,4L,4L,5L,5L,6L,6L,6L,6L,7L,7L,8L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,10L,10L,11L,11L,11L,12L,12L,12L,12L,12L,12L,13L,13L,14L,14L,14L,14L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,16L,17L,17L,17L,18L,18L,18L,18L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162351Inst : IEnumerable<long>
{
public static readonly long[] Value=A162351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162351.Bytes);
public long this[int i]=>Value[i];

public static A162351Inst Instance=new A162351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162352
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,2L,2L,3L,4L,5L,5L,4L,4L,5L,6L,7L,7L,6L,6L,7L,8L,9L,9L,8L,7L,6L,6L,7L,8L,9L,10L,10L,9L,8L,8L,9L,10L,11L,12L,13L,13L,12L,12L,13L,14L,15L,15L,14L,13L,12L,12L,13L,14L,15L,16L,17L,18L,18L,17L,16L,16L,17L,18L,19L,20L,20L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162352Inst : IEnumerable<long>
{
public static readonly long[] Value=A162352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162352.Bytes);
public long this[int i]=>Value[i];

public static A162352Inst Instance=new A162352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162353
{
public static readonly long[] Value={ 2L,101L,227L,281L,821L,929L,1019L,1091L,1109L,1289L,1307L,1901L,2063L,2243L,2423L,2621L,2657L,2819L,2837L,3089L,3701L,4079L,6203L,6221L,6257L,7013L,7103L,7283L,7823L,8039L,8093L,8219L,8237L,8273L,8291L,9011L,9281L,9803L,10037L,10253L,10271L,10289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162353Inst : IEnumerable<long>
{
public static readonly long[] Value=A162353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162353.Bytes);
public long this[int i]=>Value[i];

public static A162353Inst Instance=new A162353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162354
{
public static readonly long[] Value={ 3L,19L,109L,163L,307L,523L,613L,631L,1063L,1117L,1171L,1567L,1657L,1693L,1783L,1801L,1873L,2017L,2251L,2269L,2287L,2521L,2683L,3061L,3079L,3169L,3187L,3457L,3547L,3691L,3709L,3907L,4051L,4357L,4861L,5077L,5167L,5347L,5437L,5563L,5581L,5653L,5743L,5851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162354Inst : IEnumerable<long>
{
public static readonly long[] Value=A162354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162354.Bytes);
public long this[int i]=>Value[i];

public static A162354Inst Instance=new A162354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162355
{
public static readonly long[] Value={ 0L,1L,2L,7L,20L,21L,22L,27L,70L,73L,78L,134L,141L,142L,147L,150L,153L,158L,165L,166L,169L,184L,194L,200L,201L,202L,207L,220L,221L,222L,227L,270L,273L,278L,305L,306L,309L,310L,317L,318L,325L,326L,329L,330L,333L,338L,371L,372L,377L,380L,383L,388L,390L,393L,398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162355Inst : IEnumerable<long>
{
public static readonly long[] Value=A162355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162355.Bytes);
public long this[int i]=>Value[i];

public static A162355Inst Instance=new A162355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162356
{
public static readonly long[] Value={ 2L,9L,44L,226L,1192L,6372L,34288L,185096L,1000736L,5414544L,29306048L,158644768L,858873472L,4649961024L,25175459584L,136304222336L,737977344512L,3995559643392L,21632794323968L,117124519584256L,634137036138496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162356Inst : IEnumerable<long>
{
public static readonly long[] Value=A162356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162356.Bytes);
public long this[int i]=>Value[i];

public static A162356Inst Instance=new A162356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162357
{
public static readonly long[] Value={ 29L,43L,61L,89L,1021L,1201L,1409L,16111L,18233L,20369L,220447L,24709L,26267L,28123L,30727L,320867L,34549L,360461L,38393L,404557L,421517L,444209L,465841L,481249L,5000423L,521929L,540907L,565667L,58831L,605719L,6217319L,6403063L,6611237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162357Inst : IEnumerable<long>
{
public static readonly long[] Value=A162357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162357.Bytes);
public long this[int i]=>Value[i];

public static A162357Inst Instance=new A162357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162358
{
public static readonly long[] Value={ 3L,5L,7L,13L,17L,19L,23L,29L,43L,47L,53L,61L,83L,89L,97L,103L,113L,127L,139L,167L,173L,179L,227L,233L,263L,313L,389L,397L,419L,421L,443L,449L,487L,523L,557L,563L,587L,599L,617L,647L,653L,691L,787L,809L,811L,821L,857L,967L,991L,1021L,1051L,1103L,1117L,1153L,1181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162358Inst : IEnumerable<long>
{
public static readonly long[] Value=A162358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162358.Bytes);
public long this[int i]=>Value[i];

public static A162358Inst Instance=new A162358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162359
{
public static readonly long[] Value={ 1L,20L,209L,1520L,8644L,40944L,168035L,613756L,2034120L,6206596L,17632836L,47062620L,118870650L,285840940L,657667521L,1454009144L,3100176535L,6394814820L,12796122680L,24898749084L,47210910669L,87394933080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162359Inst : IEnumerable<long>
{
public static readonly long[] Value=A162359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162359.Bytes);
public long this[int i]=>Value[i];

public static A162359Inst Instance=new A162359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162360
{
public static readonly long[] Value={ 1L,21L,230L,1750L,10394L,51338L,219373L,833129L,2867249L,9073845L,26706681L,73769301L,192639951L,478480891L,1136148412L,2590157556L,5690334091L,12085148911L,24881271591L,49780020675L,96990931345L,184385864444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162360Inst : IEnumerable<long>
{
public static readonly long[] Value=A162360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162360.Bytes);
public long this[int i]=>Value[i];

public static A162360Inst Instance=new A162360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162361
{
public static readonly long[] Value={ 2L,2L,3L,2L,3L,2L,3L,3L,2L,3L,5L,2L,3L,3L,2L,5L,5L,2L,3L,2L,7L,3L,3L,5L,5L,3L,2L,3L,2L,5L,5L,3L,7L,2L,3L,7L,2L,5L,5L,3L,2L,3L,5L,7L,3L,2L,5L,5L,3L,2L,3L,5L,7L,2L,7L,11L,2L,7L,3L,5L,3L,3L,7L,2L,7L,5L,3L,3L,2L,5L,11L,5L,2L,5L,2L,3L,7L,5L,2L,3L,13L,7L,5L,3L,2L,7L,11L,3L,3L,5L,11L,7L,3L,2L,7L,3L,2L,7L,5L,2L,11L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162361Inst : IEnumerable<long>
{
public static readonly long[] Value=A162361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162361.Bytes);
public long this[int i]=>Value[i];

public static A162361Inst Instance=new A162361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162362
{
public static readonly long[] Value={ 1L,4L,8L,19L,31L,63L,97L,168L,258L,407L,594L,907L,1285L,1859L,2604L,3660L,4998L,6883L,9246L,12479L,16562L,21967L,28767L,37715L,48847L,63224L,81145L,103980L,132234L,167982L,211935L,267001L,334535L,418343L,520687L,646974L,800336L,988322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162362Inst : IEnumerable<long>
{
public static readonly long[] Value=A162362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162362.Bytes);
public long this[int i]=>Value[i];

public static A162362Inst Instance=new A162362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162363
{
public static readonly long[] Value={ 1L,3L,143L,285L,569L,683L,1138L,1366L,2276L,154203L,308405L,616810L,678491L,1356981L,1480343L,2713962L,2960686L,2212558911L,4425117821L,8850235641L,17700471281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162363Inst : IEnumerable<long>
{
public static readonly long[] Value=A162363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162363.Bytes);
public long this[int i]=>Value[i];

public static A162363Inst Instance=new A162363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162364
{
public static readonly long[] Value={ 1L,22L,252L,2002L,12396L,63734L,283107L,1116236L,3983485L,13057330L,39764011L,113533312L,306173263L,784654154L,1920802566L,4510960122L,10201294213L,22286443124L,47167714715L,96947735390L,193938666735L,378324531180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162364Inst : IEnumerable<long>
{
public static readonly long[] Value=A162364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162364.Bytes);
public long this[int i]=>Value[i];

public static A162364Inst Instance=new A162364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162365
{
public static readonly long[] Value={ 1L,23L,275L,2277L,14673L,78407L,361514L,1477750L,5461235L,18518565L,58282576L,171815888L,477989151L,1262643305L,3183445871L,7694405993L,17895700206L,40182143330L,87349858045L,184297593435L,378236260170L,756560791350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162365Inst : IEnumerable<long>
{
public static readonly long[] Value=A162365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162365.Bytes);
public long this[int i]=>Value[i];

public static A162365Inst Instance=new A162365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162366
{
public static readonly long[] Value={ 1L,24L,299L,2576L,17249L,95656L,457170L,1934920L,7396155L,25914720L,84197296L,256013184L,734002335L,1996645640L,5180091511L,12874497504L,30770197710L,70952341040L,158302199085L,342599792520L,720836052690L,1477396844040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162366Inst : IEnumerable<long>
{
public static readonly long[] Value=A162366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162366.Bytes);
public long this[int i]=>Value[i];

public static A162366Inst Instance=new A162366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162367
{
public static readonly long[] Value={ 1L,25L,324L,2900L,20149L,115805L,572975L,2507895L,9904050L,35818770L,120016066L,376029250L,1110031585L,3106677225L,8286768736L,21161266240L,51931463950L,122883804990L,281186004075L,623785796595L,1344621849285L,2822018693325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162367Inst : IEnumerable<long>
{
public static readonly long[] Value=A162367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162367.Bytes);
public long this[int i]=>Value[i];

public static A162367Inst Instance=new A162367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162368
{
public static readonly long[] Value={ 1L,26L,350L,3250L,23399L,139204L,712179L,3220074L,13124124L,48942894L,168958960L,544988210L,1655019795L,4761697020L,13048465756L,34209731996L,86141195946L,209025000936L,490211005011L,1113996801606L,2458618650891L,5280637344216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162368Inst : IEnumerable<long>
{
public static readonly long[] Value=A162368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162368.Bytes);
public long this[int i]=>Value[i];

public static A162368Inst Instance=new A162368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162369
{
public static readonly long[] Value={ 1L,27L,377L,3627L,27026L,166230L,878409L,4098483L,17222607L,66165501L,235124461L,780112671L,2435132466L,7196829486L,20245295242L,54455027238L,140596223184L,349621224120L,839832229131L,1953829030737L,4412447681628L,9693085025844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162369Inst : IEnumerable<long>
{
public static readonly long[] Value=A162369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162369.Bytes);
public long this[int i]=>Value[i];

public static A162369Inst Instance=new A162369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162370
{
public static readonly long[] Value={ 1L,28L,405L,4032L,31058L,197288L,1075697L,5174180L,22396787L,88562288L,323686749L,1103799420L,3538931886L,10735761372L,30981056614L,85436083852L,226032307036L,575653531156L,1415485760287L,3369314791024L,7781762472652L,17474847498496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162370Inst : IEnumerable<long>
{
public static readonly long[] Value=A162370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162370.Bytes);
public long this[int i]=>Value[i];

public static A162370Inst Instance=new A162370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162371
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,6L,7L,9L,15L,10L,11L,12L,13L,21L,14L,16L,17L,18L,19L,23L,20L,22L,24L,25L,26L,27L,29L,28L,30L,31L,32L,33L,34L,35L,40L,36L,37L,38L,39L,41L,42L,43L,44L,47L,45L,46L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,68L,66L,67L,69L,70L,71L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162371Inst : IEnumerable<long>
{
public static readonly long[] Value=A162371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162371.Bytes);
public long this[int i]=>Value[i];

public static A162371Inst Instance=new A162371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162372
{
public static readonly long[] Value={ 1L,3L,8L,15L,21L,23L,29L,40L,47L,55L,68L,87L,92L,108L,121L,144L,155L,175L,204L,215L,232L,266L,283L,300L,329L,357L,380L,411L,442L,470L,513L,556L,561L,607L,654L,671L,706L,746L,789L,836L,865L,903L,950L,991L,1038L,1124L,1129L,1188L,1277L,1276L,1326L,1399L,1436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162372Inst : IEnumerable<long>
{
public static readonly long[] Value=A162372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162372.Bytes);
public long this[int i]=>Value[i];

public static A162372Inst Instance=new A162372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162373
{
public static readonly long[] Value={ 1L,5L,17L,37L,67L,107L,173L,263L,367L,503L,673L,877L,1097L,1381L,1693L,2063L,2459L,2927L,3449L,4001L,4637L,5347L,6089L,6917L,7829L,8803L,9851L,10993L,12211L,13513L,14923L,16411L,17957L,19681L,21467L,23327L,25343L,27457L,29683L,32027L,34469L,37061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162373Inst : IEnumerable<long>
{
public static readonly long[] Value=A162373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162373.Bytes);
public long this[int i]=>Value[i];

public static A162373Inst Instance=new A162373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162374
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,9L,24L,25L,26L,27L,30L,31L,32L,33L,34L,35L,41L,42L,43L,44L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,69L,70L,71L,72L,73L,74L,75L,76L,77L,88L,89L,90L,93L,94L,95L,96L,97L,98L,99L,100L,101L,102L,103L,104L,109L,110L,111L,112L,113L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162374Inst : IEnumerable<long>
{
public static readonly long[] Value=A162374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162374.Bytes);
public long this[int i]=>Value[i];

public static A162374Inst Instance=new A162374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162375
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,6L,9L,11L,12L,13L,14L,16L,10L,17L,18L,19L,20L,22L,15L,23L,21L,24L,25L,26L,27L,29L,28L,30L,31L,32L,33L,34L,35L,37L,38L,39L,40L,36L,41L,42L,43L,44L,46L,47L,45L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,67L,68L,66L,69L,70L,71L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162375Inst : IEnumerable<long>
{
public static readonly long[] Value=A162375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162375.Bytes);
public long this[int i]=>Value[i];

public static A162375Inst Instance=new A162375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162376
{
public static readonly long[] Value={ 1L,29L,434L,4466L,35524L,232812L,1308509L,6482689L,28879476L,117441764L,441128513L,1544927933L,5083859819L,15819621191L,46800677805L,132236761657L,358269068693L,933922599849L,2349408360136L,5718723151160L,13500485623812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162376Inst : IEnumerable<long>
{
public static readonly long[] Value=A162376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162376.Bytes);
public long this[int i]=>Value[i];

public static A162376Inst Instance=new A162376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162377
{
public static readonly long[] Value={ 1L,30L,464L,4930L,40454L,273266L,1581775L,8064464L,36943940L,154385704L,595514217L,2140442150L,7224301969L,23043923160L,69844600965L,202081362622L,560350431315L,1494273031164L,3843681391300L,9562404542460L,23062890166272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162377Inst : IEnumerable<long>
{
public static readonly long[] Value=A162377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162377.Bytes);
public long this[int i]=>Value[i];

public static A162377Inst Instance=new A162377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162378
{
public static readonly long[] Value={ 1L,31L,495L,5425L,45879L,319145L,1900920L,9965384L,46909324L,201295028L,796809245L,2937251395L,10161553364L,33205476524L,103050077489L,305131440111L,865481871426L,2359754902590L,6203436293890L,15765840836350L,38828731002622L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162378Inst : IEnumerable<long>
{
public static readonly long[] Value=A162378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162378.Bytes);
public long this[int i]=>Value[i];

public static A162378Inst Instance=new A162378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162379
{
public static readonly long[] Value={ 1L,32L,527L,5952L,51831L,370976L,2271896L,12237280L,59146604L,260441632L,1057250877L,3994502272L,14156055636L,47361532160L,150411609649L,455543049760L,1321024921186L,3680779823776L,9884216117666L,25650056954016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162379Inst : IEnumerable<long>
{
public static readonly long[] Value=A162379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162379.Bytes);
public long this[int i]=>Value[i];

public static A162379Inst Instance=new A162379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162380
{
public static readonly long[] Value={ 1L,33L,560L,6512L,58343L,429319L,2701215L,14938495L,74085099L,334526731L,1391777608L,5386279880L,19542335516L,66903867676L,217315477325L,672858527085L,1993883448271L,5674663272047L,15558879389713L,41208936343729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162380Inst : IEnumerable<long>
{
public static readonly long[] Value=A162380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162380.Bytes);
public long this[int i]=>Value[i];

public static A162380Inst Instance=new A162380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162381
{
public static readonly long[] Value={ 1L,34L,594L,7106L,65449L,494768L,3195983L,18134478L,92219577L,426746308L,1818523916L,7204803796L,26747139312L,93651006988L,310966484313L,983825011398L,2977708459669L,8652371731716L,24211251121429L,65420187465158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162381Inst : IEnumerable<long>
{
public static readonly long[] Value=A162381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162381.Bytes);
public long this[int i]=>Value[i];

public static A162381Inst Instance=new A162381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162382
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,5L,7L,3L,1L,14L,30L,15L,4L,1L,42L,143L,91L,26L,5L,1L,132L,728L,612L,204L,40L,6L,1L,429L,3876L,4389L,1771L,385L,57L,7L,1L,1430L,21318L,32890L,16380L,4095L,650L,77L,8L,1L,4862L,120175L,254475L,158224L,46376L,8184L,1015L,100L,9L,1L,16796L,690690L,2017356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162382Inst : IEnumerable<long>
{
public static readonly long[] Value=A162382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162382.Bytes);
public long this[int i]=>Value[i];

public static A162382Inst Instance=new A162382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162383
{
public static readonly long[] Value={ 1L,3L,5L,8L,10L,15L,16L,23L,25L,31L,34L,45L,42L,55L,60L,67L,69L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162383Inst : IEnumerable<long>
{
public static readonly long[] Value=A162383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162383.Bytes);
public long this[int i]=>Value[i];

public static A162383Inst Instance=new A162383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162384
{
public static readonly long[] Value={ 1L,35L,629L,7735L,73184L,567952L,3763935L,21898413L,114117990L,540864298L,2359388214L,9564192010L,36311331322L,129962338310L,440928822623L,1424753834021L,4402462293690L,13054834025406L,37266085146835L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162384Inst : IEnumerable<long>
{
public static readonly long[] Value=A162384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162384.Bytes);
public long this[int i]=>Value[i];

public static A162384Inst Instance=new A162384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162385
{
public static readonly BigInteger[] Value={ 2L,11L,233L,4001L,16771073L,4294868993L,68719083521L,1152921502996234241L,BigInteger.Parse("1329227995784915871174424803370074113"),BigInteger.Parse("95780971304118053647396688732666809244153592049303553") };
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
public class A162385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162385Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A162385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162385.Bytes);
public BigInteger this[int i]=>Value[i];

public static A162385Inst Instance=new A162385Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162386
{
public static readonly long[] Value={ 1931L,389L,11369L,1453L,829L,1307L,3919L,11159L,2713L,619L,1097L,3709L,1721L,179L,409L,887L,3499L,1511L,1439L,10949L,2503L,4759L,1301L,1229L,10739L,2293L,199L,677L,1019L,10529L,2083L,1459L,467L,4549L,1091L,1873L,1249L,257L,4339L,881L,809L,11789L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162386Inst : IEnumerable<long>
{
public static readonly long[] Value=A162386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162386.Bytes);
public long this[int i]=>Value[i];

public static A162386Inst Instance=new A162386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162387
{
public static readonly long[] Value={ 2L,1L,3L,2L,1L,7L,3L,2L,1L,31L,5L,3L,2L,1L,211L,7L,5L,3L,2L,1L,2311L,11L,7L,5L,3L,2L,1L,30031L,13L,11L,7L,5L,3L,2L,1L,510511L,17L,13L,11L,7L,5L,3L,2L,1L,9699691L,19L,17L,13L,11L,7L,5L,3L,2L,1L,223092871L,23L,19L,17L,13L,11L,7L,5L,3L,2L,1L,6469693231L,29L,23L,19L,17L,13L,11L,7L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162387Inst : IEnumerable<long>
{
public static readonly long[] Value=A162387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162387.Bytes);
public long this[int i]=>Value[i];

public static A162387Inst Instance=new A162387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162388
{
public static readonly long[] Value={ 1L,36L,665L,8400L,81584L,649536L,4413471L,26311884L,140429874L,681294172L,3040682386L,12604874396L,48916205718L,178878544028L,619807366651L,2044561200672L,6447023494362L,19501857519768L,56767942666603L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162388Inst : IEnumerable<long>
{
public static readonly long[] Value=A162388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162388.Bytes);
public long this[int i]=>Value[i];

public static A162388Inst Instance=new A162388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162389
{
public static readonly long[] Value={ 1L,37L,702L,9102L,90686L,740222L,5153693L,31465577L,171895451L,853189623L,3893872009L,16498746405L,65414952123L,244293496151L,864100862802L,2908662063474L,9355685557836L,28857543077604L,85625485744207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162389Inst : IEnumerable<long>
{
public static readonly long[] Value=A162389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162389.Bytes);
public long this[int i]=>Value[i];

public static A162389Inst Instance=new A162389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162390
{
public static readonly long[] Value={ 2L,3L,5L,13L,31L,43L,89L,233L,601L,773L,1481L,1579L,1597L,1759L,5179L,5197L,5791L,7159L,7591L,7951L,9157L,11177L,11717L,17117L,25057L,25867L,28657L,40169L,40961L,41609L,46091L,46901L,50527L,52057L,55207L,56827L,60149L,61409L,64019L,64091L,64109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162390Inst : IEnumerable<long>
{
public static readonly long[] Value=A162390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162390.Bytes);
public long this[int i]=>Value[i];

public static A162390Inst Instance=new A162390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162391
{
public static readonly long[] Value={ 1L,12L,21L,192L,294L,2536L,2639L,3903L,4864L,5342L,6242L,7302L,7934L,8023L,9194L,9711L,12166L,20719L,22696L,25964L,51837L,52453L,60985L,69186L,69837L,69984L,76647L,76992L,82887L,83814L,84601L,85257L,87324L,87603L,87778L,89208L,98855L,98918L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162391Inst : IEnumerable<long>
{
public static readonly long[] Value=A162391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162391.Bytes);
public long this[int i]=>Value[i];

public static A162391Inst Instance=new A162391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162392
{
public static readonly long[] Value={ 1L,38L,740L,9842L,100528L,840750L,5994443L,37460020L,209355471L,1062545094L,4956417103L,21455163508L,86870115631L,331163611782L,1195264474584L,4103926538058L,13459612095894L,42317155173498L,127942640917705L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162392Inst : IEnumerable<long>
{
public static readonly long[] Value=A162392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162392.Bytes);
public long this[int i]=>Value[i];

public static A162392Inst Instance=new A162392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162393
{
public static readonly long[] Value={ 2L,21L,6765L,10946L,2178309L,14930352L,102334155L,701408733L,1134903170L,4807526976L,20365011074L,32951280099L,225851433717L,1548008755920L,10610209857723L,72723460248141L,117669030460994L,498454011879264L,2111485077978050L,3416454622906707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162393Inst : IEnumerable<long>
{
public static readonly long[] Value=A162393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162393.Bytes);
public long this[int i]=>Value[i];

public static A162393Inst Instance=new A162393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162394
{
public static readonly long[] Value={ 0L,1L,3L,21L,55L,2584L,28657L,2178309L,5702887L,14930352L,102334155L,267914296L,701408733L,2971215073L,4807526976L,7778742049L,12586269025L,32951280099L,225851433717L,591286729879L,1548008755920L,10610209857723L,27777890035288L,72723460248141L,308061521170129L,498454011879264L,806515533049393L,1304969544928657L,3416454622906707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162394Inst : IEnumerable<long>
{
public static readonly long[] Value=A162394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162394.Bytes);
public long this[int i]=>Value[i];

public static A162394Inst Instance=new A162394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162395
{
public static readonly long[] Value={ 1L,-4L,9L,-16L,25L,-36L,49L,-64L,81L,-100L,121L,-144L,169L,-196L,225L,-256L,289L,-324L,361L,-400L,441L,-484L,529L,-576L,625L,-676L,729L,-784L,841L,-900L,961L,-1024L,1089L,-1156L,1225L,-1296L,1369L,-1444L,1521L,-1600L,1681L,-1764L,1849L,-1936L,2025L,-2116L,2209L,-2304L,2401L,-2500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162395Inst : IEnumerable<long>
{
public static readonly long[] Value=A162395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162395.Bytes);
public long this[int i]=>Value[i];

public static A162395Inst Instance=new A162395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162396
{
public static readonly long[] Value={ 5L,2L,10L,4L,20L,8L,40L,16L,80L,32L,160L,64L,320L,128L,640L,256L,1280L,512L,2560L,1024L,5120L,2048L,10240L,4096L,20480L,8192L,40960L,16384L,81920L,32768L,163840L,65536L,327680L,131072L,655360L,262144L,1310720L,524288L,2621440L,1048576L,5242880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162396Inst : IEnumerable<long>
{
public static readonly long[] Value=A162396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162396.Bytes);
public long this[int i]=>Value[i];

public static A162396Inst Instance=new A162396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162397
{
public static readonly long[] Value={ 1L,-2L,0L,4L,-5L,0L,7L,-8L,0L,10L,-11L,0L,13L,-14L,0L,16L,-17L,0L,19L,-20L,0L,22L,-23L,0L,25L,-26L,0L,28L,-29L,0L,31L,-32L,0L,34L,-35L,0L,37L,-38L,0L,40L,-41L,0L,43L,-44L,0L,46L,-47L,0L,49L,-50L,0L,52L,-53L,0L,55L,-56L,0L,58L,-59L,0L,61L,-62L,0L,64L,-65L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162397Inst : IEnumerable<long>
{
public static readonly long[] Value=A162397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162397.Bytes);
public long this[int i]=>Value[i];

public static A162397Inst Instance=new A162397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162398
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,3L,3L,8L,2L,5L,5L,3L,13L,3L,3L,8L,8L,2L,3L,5L,21L,5L,5L,8L,3L,13L,13L,3L,13L,3L,3L,8L,8L,34L,8L,2L,5L,3L,3L,8L,5L,21L,21L,5L,13L,5L,5L,8L,8L,3L,3L,13L,21L,13L,55L,8L,3L,13L,13L,3L,13L,3L,3L,8L,8L,8L,8L,34L,34L,8L,8L,8L,2L,5L,5L,3L,13L,3L,3L,8L,8L,5L,5L,21L,21L,21L,21L,8L,89L,13L,13L,5L,13L,5L,5L,8L,8L,34L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162398Inst : IEnumerable<long>
{
public static readonly long[] Value=A162398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162398.Bytes);
public long this[int i]=>Value[i];

public static A162398Inst Instance=new A162398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162399
{
public static readonly long[] Value={ 1L,39L,779L,10621L,111149L,951899L,6946342L,44406362L,253761833L,1316306927L,6272724030L,27727887538L,114598003169L,445761614951L,1641026089535L,5744952627593L,19204564723487L,61521719896985L,189464360814690L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162399Inst : IEnumerable<long>
{
public static readonly long[] Value=A162399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162399.Bytes);
public long this[int i]=>Value[i];

public static A162399Inst Instance=new A162399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162400
{
public static readonly long[] Value={ 1L,1L,1L,4L,1L,1L,1L,4L,9L,1L,1L,4L,1L,1L,1L,16L,4L,9L,9L,4L,1L,1L,1L,4L,25L,1L,1L,4L,1L,1L,1L,16L,16L,4L,4L,36L,9L,9L,9L,4L,9L,1L,1L,4L,1L,1L,1L,16L,49L,25L,25L,4L,1L,1L,1L,4L,25L,1L,1L,4L,1L,1L,1L,64L,16L,16L,16L,4L,4L,4L,4L,36L,36L,9L,9L,9L,9L,9L,9L,16L,81L,9L,9L,4L,1L,1L,1L,4L,25L,1L,1L,4L,1L,1L,1L,16L,16L,49L,49L,100L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162400Inst : IEnumerable<long>
{
public static readonly long[] Value=A162400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162400.Bytes);
public long this[int i]=>Value[i];

public static A162400Inst Instance=new A162400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162401
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,2L,3L,1L,1L,2L,1L,1L,1L,4L,2L,3L,3L,2L,1L,1L,1L,2L,5L,1L,1L,2L,1L,1L,1L,4L,4L,2L,2L,6L,3L,3L,3L,2L,3L,1L,1L,2L,1L,1L,1L,4L,7L,5L,5L,2L,1L,1L,1L,2L,5L,1L,1L,2L,1L,1L,1L,8L,4L,4L,4L,2L,2L,2L,2L,6L,6L,3L,3L,3L,3L,3L,3L,4L,9L,3L,3L,2L,1L,1L,1L,2L,5L,1L,1L,2L,1L,1L,1L,4L,4L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162401Inst : IEnumerable<long>
{
public static readonly long[] Value=A162401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162401.Bytes);
public long this[int i]=>Value[i];

public static A162401Inst Instance=new A162401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162402
{
public static readonly long[] Value={ 1L,40L,819L,11440L,122589L,1074488L,8020830L,52427192L,306189025L,1622495952L,7895219982L,35623107520L,150221110689L,595982725640L,2237008815175L,7981961442768L,27186526166255L,88708246063240L,278172606877930L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162402Inst : IEnumerable<long>
{
public static readonly long[] Value=A162402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162402.Bytes);
public long this[int i]=>Value[i];

public static A162402Inst Instance=new A162402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162403
{
public static readonly long[] Value={ 1L,41L,860L,12300L,134889L,1209377L,9230207L,61657399L,367846424L,1990342376L,9885562358L,45508669878L,195729780567L,791712506207L,3028721321382L,11010682764150L,38197208930405L,126905454993645L,405078061871575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162403Inst : IEnumerable<long>
{
public static readonly long[] Value=A162403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162403.Bytes);
public long this[int i]=>Value[i];

public static A162403Inst Instance=new A162403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A162404
{
public static readonly long[] Value={ 1L,2L,3L,5L,10L,13L,16L,18L,20L,30L,35L,38L,51L,54L,57L,73L,75L,93L,96L,116L,126L,131L,136L,139L,142L,155L,168L,171L,184L,214L,217L,233L,249L,251L,286L,304L,322L,360L,363L,383L,403L,413L,423L,428L,441L,446L,451L,467L,470L,488L,539L,559L,572L,626L,639L,642L,699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A162404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A162404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A162404Inst : IEnumerable<long>
{
public static readonly long[] Value=A162404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A162404.Bytes);
public long this[int i]=>Value[i];

public static A162404Inst Instance=new A162404Inst();

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