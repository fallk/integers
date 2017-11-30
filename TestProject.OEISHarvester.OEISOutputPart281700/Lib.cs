using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A128083
{
public static readonly BigInteger[] Value={ 1L,1L,3L,37L,1159L,66953L,6158021L,825889193L,152147002939L,36866098462221L,11368538145120143L,4347671960639941039L,BigInteger.Parse("2019396728684584627337"),BigInteger.Parse("1119792551093682455434255"),BigInteger.Parse("730724550040451849614251167") };
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
public class A128083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128083Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A128083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128083.Bytes);
public BigInteger this[int i]=>Value[i];

public static A128083Inst Instance=new A128083Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128084
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,1L,1L,3L,5L,7L,8L,8L,7L,5L,3L,1L,1L,4L,9L,16L,24L,32L,39L,44L,46L,44L,39L,32L,24L,16L,9L,4L,1L,1L,5L,14L,30L,54L,86L,125L,169L,215L,259L,297L,325L,340L,340L,325L,297L,259L,215L,169L,125L,86L,54L,30L,14L,5L,1L,1L,6L,20L,50L,104L,190L,315L,484L,699L,958L,1255L,1580L,1919L,2254L,2565L,2832L,3037L,3166L,3210L,3166L,3037L,2832L,2565L,2254L,1919L,1580L,1255L,958L,699L,484L,315L,190L,104L,50L,20L,6L,1L,1L,7L,27L,77L,181L,371L,686L,1170L,1869L,2827L,4082L,5662L,7581L,9835L,12399L,15225L,18242L,21358L,24464L,27440L,30162L,32510L,34376L,35672L,36336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128084Inst : IEnumerable<long>
{
public static readonly long[] Value=A128084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128084.Bytes);
public long this[int i]=>Value[i];

public static A128084Inst Instance=new A128084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128085
{
public static readonly BigInteger[] Value={ 1L,1L,2L,8L,46L,340L,3210L,36336L,484636L,7394458L,127707302L,2454109404L,52091631896L,1207854671388L,30431260261770L,826657521349952L,24114046688034516L,751085176539860458L,BigInteger.Parse("24899882719111953556") };
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
public class A128085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128085Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A128085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128085.Bytes);
public BigInteger this[int i]=>Value[i];

public static A128085Inst Instance=new A128085Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128086
{
public static readonly long[] Value={ 1L,1L,2L,7L,24L,86L,315L,1170L,4389L,16588L,63064L,240901L,923858L,3554747L,13716315L,53054703L,205651975L,798645126L,3106669575L,12102626404L,47210910670L,184385864445L,720920510115L,2821499709615L,11052719207369L,43333403693711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128086Inst : IEnumerable<long>
{
public static readonly long[] Value=A128086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128086.Bytes);
public long this[int i]=>Value[i];

public static A128086Inst Instance=new A128086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128087
{
public static readonly BigInteger[] Value={ 1L,2L,14L,296L,12938L,956720L,107245250L,16966970200L,3601980861720L,988252809411908L,340375635448973106L,BigInteger.Parse("143798619953044471444"),BigInteger.Parse("73123320014581106403732"),BigInteger.Parse("44060303354020797873285800") };
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
public class A128087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128087Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A128087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128087.Bytes);
public BigInteger this[int i]=>Value[i];

public static A128087Inst Instance=new A128087Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128136
{
public static readonly long[] Value={ 1L,1L,4L,2L,4L,9L,3L,6L,9L,16L,4L,8L,12L,16L,25L,5L,10L,15L,20L,25L,36L,6L,12L,18L,24L,30L,36L,49L,7L,14L,21L,28L,35L,42L,49L,64L,8L,16L,24L,32L,40L,48L,56L,64L,81L,9L,18L,27L,36L,45L,54L,63L,72L,81L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128136Inst : IEnumerable<long>
{
public static readonly long[] Value=A128136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128136.Bytes);
public long this[int i]=>Value[i];

public static A128136Inst Instance=new A128136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128137
{
public static readonly long[] Value={ 1L,-1L,4L,-1L,1L,9L,-1L,1L,5L,16L,-1L,1L,5L,11L,25L,-1L,1L,5L,11L,19L,36L,-1L,1L,5L,11L,19L,29L,49L,-1L,1L,5L,11L,19L,29L,41L,64L,-1L,1L,5L,11L,19L,29L,41L,55L,81L,-1L,1L,5L,11L,19L,29L,41L,55L,71L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128137Inst : IEnumerable<long>
{
public static readonly long[] Value=A128137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128137.Bytes);
public long this[int i]=>Value[i];

public static A128137Inst Instance=new A128137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128138
{
public static readonly long[] Value={ 1L,0L,2L,0L,1L,3L,0L,1L,2L,4L,0L,1L,2L,3L,5L,0L,1L,2L,3L,4L,6L,0L,1L,2L,3L,4L,5L,7L,0L,1L,2L,3L,4L,5L,6L,8L,0L,1L,2L,3L,4L,5L,6L,7L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,10L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,0L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128138Inst : IEnumerable<long>
{
public static readonly long[] Value=A128138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128138.Bytes);
public long this[int i]=>Value[i];

public static A128138Inst Instance=new A128138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128139
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,3L,1L,4L,5L,4L,1L,5L,7L,7L,5L,1L,6L,9L,10L,9L,6L,1L,7L,11L,13L,13L,11L,7L,1L,8L,13L,16L,17L,16L,13L,8L,1L,9L,15L,19L,21L,21L,19L,15L,9L,1L,10L,17L,22L,25L,26L,25L,22L,17L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128139Inst : IEnumerable<long>
{
public static readonly long[] Value=A128139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128139.Bytes);
public long this[int i]=>Value[i];

public static A128139Inst Instance=new A128139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128140
{
public static readonly long[] Value={ 1L,3L,2L,7L,5L,3L,13L,10L,7L,4L,21L,17L,13L,9L,5L,31L,26L,21L,16L,11L,6L,43L,37L,31L,25L,19L,13L,7L,57L,50L,43L,36L,29L,22L,15L,8L,73L,65L,57L,49L,41L,33L,25L,17L,9L,91L,82L,73L,64L,55L,46L,37L,28L,19L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128140Inst : IEnumerable<long>
{
public static readonly long[] Value=A128140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128140.Bytes);
public long this[int i]=>Value[i];

public static A128140Inst Instance=new A128140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128141
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,3L,4L,9L,8L,4L,5L,14L,15L,11L,5L,6L,20L,24L,21L,14L,6L,7L,27L,35L,34L,27L,17L,7L,8L,35L,48L,50L,44L,33L,20L,8L,9L,44L,63L,69L,65L,54L,39L,23L,9L,10L,54L,80L,91L,90L,80L,64L,45L,26L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128141Inst : IEnumerable<long>
{
public static readonly long[] Value=A128141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128141.Bytes);
public long this[int i]=>Value[i];

public static A128141Inst Instance=new A128141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128142
{
public static readonly long[] Value={ 1L,5L,2L,15L,8L,3L,34L,21L,11L,4L,65L,44L,27L,14L,5L,111L,80L,54L,33L,17L,6L,175L,132L,95L,64L,39L,20L,7L,260L,203L,153L,110L,74L,45L,23L,8L,369L,296L,231L,174L,125L,84L,51L,26L,9L,505L,414L,332L,259L,195L,140L,94L,57L,29L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128142Inst : IEnumerable<long>
{
public static readonly long[] Value=A128142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128142.Bytes);
public long this[int i]=>Value[i];

public static A128142Inst Instance=new A128142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128143
{
public static readonly long[] Value={ 1L,1L,-1L,0L,1L,0L,-1L,-1L,2L,0L,-3L,0L,2L,0L,-3L,0L,5L,0L,-4L,2L,4L,0L,-5L,0L,7L,-2L,-7L,0L,5L,0L,-10L,-1L,12L,0L,-10L,0L,14L,4L,-17L,0L,21L,0L,-22L,-4L,24L,0L,-34L,0L,33L,-1L,-36L,0L,45L,0L,-45L,8L,52L,0L,-55L,0L,62L,-8L,-71L,0L,70L,0L,-88L,-2L,96L,0L,-98L,0L,122L,14L,-133L,0L,148L,0L,-163L,-14L,182L,0L,-217L,0L,216L,-4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128143Inst : IEnumerable<long>
{
public static readonly long[] Value=A128143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128143.Bytes);
public long this[int i]=>Value[i];

public static A128143Inst Instance=new A128143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128144
{
public static readonly long[] Value={ 1L,-1L,-1L,1L,0L,-1L,0L,1L,1L,-2L,0L,3L,0L,-2L,0L,3L,0L,-5L,0L,4L,-2L,-4L,0L,5L,0L,-7L,2L,7L,0L,-5L,0L,10L,1L,-12L,0L,10L,0L,-14L,-4L,17L,0L,-21L,0L,22L,4L,-24L,0L,34L,0L,-33L,1L,36L,0L,-45L,0L,45L,-8L,-52L,0L,55L,0L,-62L,8L,71L,0L,-70L,0L,88L,2L,-96L,0L,98L,0L,-122L,-14L,133L,0L,-148L,0L,163L,14L,-182L,0L,217L,0L,-216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128144Inst : IEnumerable<long>
{
public static readonly long[] Value=A128144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128144.Bytes);
public long this[int i]=>Value[i];

public static A128144Inst Instance=new A128144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128145
{
public static readonly long[] Value={ 1L,1L,1L,-1L,0L,1L,0L,-1L,-1L,2L,0L,-3L,0L,2L,0L,-3L,0L,5L,0L,-4L,2L,4L,0L,-5L,0L,7L,-2L,-7L,0L,5L,0L,-10L,-1L,12L,0L,-10L,0L,14L,4L,-17L,0L,21L,0L,-22L,-4L,24L,0L,-34L,0L,33L,-1L,-36L,0L,45L,0L,-45L,8L,52L,0L,-55L,0L,62L,-8L,-71L,0L,70L,0L,-88L,-2L,96L,0L,-98L,0L,122L,14L,-133L,0L,148L,0L,-163L,-14L,182L,0L,-217L,0L,216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128145Inst : IEnumerable<long>
{
public static readonly long[] Value=A128145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128145.Bytes);
public long this[int i]=>Value[i];

public static A128145Inst Instance=new A128145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128146
{
public static readonly BigInteger[] Value={ 1L,-2L,-32L,16384L,1073741824L,-36028797018963968L,BigInteger.Parse("-2475880078570760549798248448"),BigInteger.Parse("1393796574908163946345982392040522594123776"),BigInteger.Parse("25711008708143844408671393477458601640355247900524685364822016") };
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
public class A128146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128146Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A128146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128146.Bytes);
public BigInteger this[int i]=>Value[i];

public static A128146Inst Instance=new A128146Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128147
{
public static readonly BigInteger[] Value={ 1L,3L,7425L,47324536875L,BigInteger.Parse("25638858602403023525625"),BigInteger.Parse("12884448481414473203775367576406984041875"),BigInteger.Parse("115708032002378912987246508786002888051981871843289603877158640625") };
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
public class A128147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128147Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A128147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128147.Bytes);
public BigInteger this[int i]=>Value[i];

public static A128147Inst Instance=new A128147Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128148
{
public static readonly long[] Value={ 2L,2929L,41459L,2352527L,144937L,1055L,1829903L,7316185805L,114491L,3146746271L,5028467L,20299L,69609309001L,129433L,15307006153L,2149705L,66469L,559182815L,18429503L,4529951L,7094711L,83591212702535L,1251548749L,38088889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128148Inst : IEnumerable<long>
{
public static readonly long[] Value=A128148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128148.Bytes);
public long this[int i]=>Value[i];

public static A128148Inst Instance=new A128148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128149
{
public static readonly long[] Value={ 2929L,137243L,4769L,4021227877L,387497L,7342733L,2592842671511L,22963573117L,18659L,120593747L,13757837L,17651L,17149L,16584420001L,613024059983L,407L,39959L,559L,581831L,305197L,235L,459207143L,855782591L,106709L,17678421233L,240055L,11227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128149Inst : IEnumerable<long>
{
public static readonly long[] Value=A128149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128149.Bytes);
public long this[int i]=>Value[i];

public static A128149Inst Instance=new A128149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128150
{
public static readonly long[] Value={ 0L,41459L,35L,9569200211L,2673413L,10596486211L,1885511821439L,235L,12722173L,1971782729L,133617287L,14873L,1465L,1606870609L,4247L,129015968122421L,526673L,835L,1079115301L,12148589879L,12351683L,36947690849L,6385L,5809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128150Inst : IEnumerable<long>
{
public static readonly long[] Value=A128150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128150.Bytes);
public long this[int i]=>Value[i];

public static A128150Inst Instance=new A128150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128151
{
public static readonly long[] Value={ 1L,3L,2L,3L,5L,3L,3L,5L,7L,4L,3L,5L,7L,9L,5L,3L,5L,7L,9L,11L,6L,3L,5L,7L,9L,11L,13L,7L,3L,5L,7L,9L,11L,13L,15L,8L,3L,5L,7L,9L,11L,13L,15L,17L,9L,3L,5L,7L,9L,11L,13L,15L,17L,19L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128151Inst : IEnumerable<long>
{
public static readonly long[] Value=A128151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128151.Bytes);
public long this[int i]=>Value[i];

public static A128151Inst Instance=new A128151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128568
{
public static readonly long[] Value={ 1L,6L,31L,133L,587L,2531L,10950L,47185L,203704L,879711L,3804530L,16464710L,71312805L,309083291L,1340546867L,5817555402L,25258769216L,109711224970L,476675868834L,2071569641859L,9004430215111L,39144480326143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128568Inst : IEnumerable<long>
{
public static readonly long[] Value=A128568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128568.Bytes);
public long this[int i]=>Value[i];

public static A128568Inst Instance=new A128568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128569
{
public static readonly long[] Value={ 1L,14L,117L,813L,4871L,27743L,151208L,804065L,4185683L,21472005L,108766010L,545507633L,2712801330L,13394412999L,65722444172L,320721839860L,1557502222385L,7530671086667L,36267851679585L,174038009185816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128569Inst : IEnumerable<long>
{
public static readonly long[] Value=A128569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128569.Bytes);
public long this[int i]=>Value[i];

public static A128569Inst Instance=new A128569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128570
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,4L,1L,3L,12L,28L,1L,4L,24L,114L,276L,1L,5L,40L,288L,1440L,3480L,1L,6L,60L,580L,4440L,22368L,53232L,1L,7L,84L,1020L,10560L,82080L,409248L,955524L,1L,8L,112L,1638L,21420L,226560L,1752000L,8585088L,19672320L,1L,9L,144L,2464L,38976L,523320L,5532960L,42178800L,202733760L,456803328L,1L,10L,180L,3528L,65520L,1068480L,14399280L,150570240L,1127335680L,5317663680L,11810032896L,1L,11L,220L,4860L,103680L,1991808L,32716992L,437433780L,4501422240L,33073099200L,153345634560L,336463895808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128570Inst : IEnumerable<long>
{
public static readonly long[] Value=A128570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128570.Bytes);
public long this[int i]=>Value[i];

public static A128570Inst Instance=new A128570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128571
{
public static readonly BigInteger[] Value={ 1L,2L,12L,114L,1440L,22368L,409248L,8585088L,202733760L,5317663680L,153345634560L,4821848409600L,164211751261440L,6022162697840640L,236652023784960000L,9921992082873223680UL,BigInteger.Parse("442138176056374548480"),BigInteger.Parse("20869300232695599552000"),BigInteger.Parse("1040210006521640127367680"),BigInteger.Parse("54600929159270409876879360") };
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
public class A128571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128571Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A128571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128571.Bytes);
public BigInteger this[int i]=>Value[i];

public static A128571Inst Instance=new A128571Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128572
{
public static readonly BigInteger[] Value={ 1L,3L,24L,288L,4440L,82080L,1752000L,42178800L,1127335680L,33073099200L,1055891810880L,36435757294080L,1351364788224000L,53617083034314240L,2266453101278568960L,BigInteger.Parse("101705245560225146880"),BigInteger.Parse("4829501671573344393600") };
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
public class A128572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128572Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A128572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128572.Bytes);
public BigInteger this[int i]=>Value[i];

public static A128572Inst Instance=new A128572Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128573
{
public static readonly BigInteger[] Value={ 1L,4L,40L,580L,10560L,226560L,5532960L,150570240L,4501422240L,146351879520L,5135738294400L,193376042294400L,7775407679034240L,332528365742227200L,15073953619379719680UL,BigInteger.Parse("722117116504240994880"),BigInteger.Parse("36458486578829035929600") };
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
public class A128573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128573Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A128573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128573.Bytes);
public BigInteger this[int i]=>Value[i];

public static A128573Inst Instance=new A128573Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128574
{
public static readonly BigInteger[] Value={ 1L,5L,60L,1020L,21420L,523320L,14399280L,437433780L,14479664640L,517426156800L,19824547680000L,810083131361280L,35155640625638400L,1614680474921256960L,BigInteger.Parse("78256021787814850560"),BigInteger.Parse("3991780109967777792000"),BigInteger.Parse("213813097136418588641280") };
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
public class A128574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128574Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A128574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128574.Bytes);
public BigInteger this[int i]=>Value[i];

public static A128574Inst Instance=new A128574Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128575
{
public static readonly BigInteger[] Value={ 1L,6L,84L,1638L,38976L,1068480L,32716992L,1098069504L,39896236800L,1555603999488L,64678765165056L,2853714891138048L,133101200708356608L,6542154022577467392L,BigInteger.Parse("337978986519657627648"),BigInteger.Parse("18310837206705702672384") };
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
public class A128575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128575Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A128575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128575.Bytes);
public BigInteger this[int i]=>Value[i];

public static A128575Inst Instance=new A128575Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128576
{
public static readonly BigInteger[] Value={ 1L,7L,112L,2464L,65520L,1991808L,67189248L,2469837888L,97765355520L,4132860197760L,185458263419520L,8794132843507200L,439083652465543680L,BigInteger.Parse("23017956568726049280"),BigInteger.Parse("1263929372436815078400"),BigInteger.Parse("72550400791147384412160") };
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
public class A128576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128576Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A128576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128576.Bytes);
public BigInteger this[int i]=>Value[i];

public static A128576Inst Instance=new A128576Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128577
{
public static readonly BigInteger[] Value={ 1L,2L,9L,64L,624L,7736L,116416L,2060808L,41952600L,965497440L,24786054816L,702201877920L,21761251764672L,732269872931712L,26589359234860560L,1036241806935453696L,BigInteger.Parse("43142510740036313088"),BigInteger.Parse("1911022260200150482944"),BigInteger.Parse("89737455913330610995200"),BigInteger.Parse("4452805047268938247981056"),BigInteger.Parse("232806644343118618035904512"),BigInteger.Parse("12791828071344703747110764544"),BigInteger.Parse("736928909474399720669590216704"),BigInteger.Parse("44416721474748725213260027514880") };
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
public class A128577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128577Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A128577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128577.Bytes);
public BigInteger this[int i]=>Value[i];

public static A128577Inst Instance=new A128577Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128578
{
public static readonly BigInteger[] Value={ 1L,2L,24L,580L,21420L,1068480L,67189248L,5098406400L,453030209280L,46120247659200L,5290918350734016L,675157532791996800L,BigInteger.Parse("94836990558591590400"),BigInteger.Parse("14538639675855504384000"),BigInteger.Parse("2415072877848471727687680") };
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
public class A128578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128578Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A128578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128578.Bytes);
public BigInteger this[int i]=>Value[i];

public static A128578Inst Instance=new A128578Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128579
{
public static readonly BigInteger[] Value={ 1L,2L,7L,44L,419L,5254L,80687L,1458524L,30259147L,707813762L,18421139495L,527856303160L,16513700403347L,560082210938174L,20471657576850655L,802275966701866964L,BigInteger.Parse("33560323690860843995"),BigInteger.Parse("1492638035099491033402") };
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
public class A128579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128579Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A128579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128579.Bytes);
public BigInteger this[int i]=>Value[i];

public static A128579Inst Instance=new A128579Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128580
{
public static readonly long[] Value={ 1L,-1L,-2L,2L,1L,-2L,0L,2L,0L,0L,-2L,0L,3L,-1L,-2L,2L,2L,-4L,0L,0L,0L,0L,-2L,0L,3L,0L,-2L,4L,0L,-2L,0L,2L,0L,0L,0L,0L,2L,-3L,-4L,2L,1L,-2L,0L,2L,0L,0L,-2L,0L,2L,-2L,-2L,2L,4L,-2L,0L,0L,0L,0L,0L,0L,3L,0L,-4L,2L,0L,-2L,0L,2L,0L,0L,0L,0L,4L,-3L,-2L,2L,0L,-4L,0L,2L,0L,0L,-4L,0L,1L,0L,-2L,6L,2L,-2L,0L,0L,0L,0L,-2L,0L,2L,0L,-2L,2L,0L,-4L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128580Inst : IEnumerable<long>
{
public static readonly long[] Value=A128580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128580.Bytes);
public long this[int i]=>Value[i];

public static A128580Inst Instance=new A128580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128581
{
public static readonly long[] Value={ 1L,1L,-1L,-1L,-2L,-1L,2L,1L,1L,-2L,-2L,1L,0L,2L,2L,-1L,0L,1L,0L,2L,-2L,-2L,0L,-1L,3L,0L,-1L,-2L,-2L,2L,2L,1L,2L,0L,-4L,-1L,0L,0L,0L,-2L,0L,-2L,0L,2L,-2L,0L,0L,1L,3L,3L,0L,0L,-2L,-1L,4L,2L,0L,-2L,-2L,-2L,0L,2L,2L,-1L,0L,2L,0L,0L,0L,-4L,0L,1L,2L,0L,-3L,0L,-4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128581Inst : IEnumerable<long>
{
public static readonly long[] Value=A128581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128581.Bytes);
public long this[int i]=>Value[i];

public static A128581Inst Instance=new A128581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128582
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,2L,0L,0L,1L,1L,0L,0L,2L,1L,0L,0L,1L,1L,0L,0L,2L,1L,0L,0L,1L,2L,0L,0L,1L,1L,0L,0L,1L,2L,0L,0L,0L,1L,0L,0L,3L,1L,0L,0L,1L,3L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,2L,1L,0L,0L,2L,2L,0L,0L,1L,2L,0L,0L,2L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,2L,1L,0L,0L,1L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128582Inst : IEnumerable<long>
{
public static readonly long[] Value=A128582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128582.Bytes);
public long this[int i]=>Value[i];

public static A128582Inst Instance=new A128582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128583
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,1L,1L,0L,3L,1L,1L,1L,2L,2L,1L,2L,0L,1L,2L,1L,0L,1L,2L,3L,0L,1L,1L,1L,3L,2L,1L,1L,1L,1L,2L,0L,2L,1L,2L,0L,1L,0L,1L,4L,1L,2L,0L,1L,2L,1L,2L,1L,1L,3L,0L,1L,2L,3L,1L,0L,1L,0L,0L,2L,2L,1L,1L,2L,2L,1L,1L,2L,0L,1L,2L,0L,1L,1L,6L,1L,1L,1L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128583Inst : IEnumerable<long>
{
public static readonly long[] Value=A128583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128583.Bytes);
public long this[int i]=>Value[i];

public static A128583Inst Instance=new A128583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128616
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,2L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,2L,0L,0L,2L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,2L,0L,0L,1L,0L,2L,0L,0L,1L,0L,0L,0L,0L,0L,1L,2L,0L,0L,1L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,2L,0L,0L,2L,0L,1L,0L,0L,0L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128616Inst : IEnumerable<long>
{
public static readonly long[] Value=A128616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128616.Bytes);
public long this[int i]=>Value[i];

public static A128616Inst Instance=new A128616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128617
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,2L,1L,0L,1L,0L,0L,2L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,1L,0L,2L,1L,0L,1L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,2L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128617Inst : IEnumerable<long>
{
public static readonly long[] Value=A128617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128617.Bytes);
public long this[int i]=>Value[i];

public static A128617Inst Instance=new A128617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128618
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,1L,0L,3L,1L,0L,2L,0L,5L,0L,1L,0L,3L,0L,8L,1L,0L,2L,0L,5L,0L,13L,0L,1L,0L,3L,0L,8L,0L,21L,1L,0L,2L,0L,5L,0L,13L,0L,34L,0L,1L,0L,3L,0L,8L,0L,21L,0L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128618Inst : IEnumerable<long>
{
public static readonly long[] Value=A128618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128618.Bytes);
public long this[int i]=>Value[i];

public static A128618Inst Instance=new A128618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128619
{
public static readonly long[] Value={ 1L,0L,1L,2L,0L,2L,0L,3L,0L,3L,5L,0L,5L,0L,5L,0L,8L,0L,8L,0L,8L,13L,0L,13L,0L,13L,0L,13L,0L,21L,0L,21L,0L,21L,0L,21L,34L,0L,34L,0L,34L,0L,34L,0L,34L,0L,55L,0L,55L,0L,55L,0L,55L,0L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128619Inst : IEnumerable<long>
{
public static readonly long[] Value=A128619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128619.Bytes);
public long this[int i]=>Value[i];

public static A128619Inst Instance=new A128619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128620
{
public static readonly long[] Value={ 1L,1L,4L,6L,15L,24L,52L,84L,170L,275L,534L,864L,1631L,2639L,4880L,7896L,14373L,23256L,41810L,67650L,120406L,194821L,343884L,556416L,975325L,1578109L,2749852L,4449354L,7713435L,12480600L,21540304L,34852944L,59917826L,96949079L,166094370L,268746336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128620Inst : IEnumerable<long>
{
public static readonly long[] Value=A128620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128620.Bytes);
public long this[int i]=>Value[i];

public static A128620Inst Instance=new A128620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128621
{
public static readonly long[] Value={ 1L,0L,2L,3L,0L,3L,0L,4L,0L,4L,5L,0L,5L,0L,5L,0L,6L,0L,6L,0L,6L,7L,0L,7L,0L,7L,0L,7L,0L,8L,0L,8L,0L,8L,0L,8L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,10L,0L,10L,0L,10L,0L,10L,0L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128621Inst : IEnumerable<long>
{
public static readonly long[] Value=A128621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128621.Bytes);
public long this[int i]=>Value[i];

public static A128621Inst Instance=new A128621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128622
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,3L,3L,4L,3L,4L,5L,4L,5L,4L,5L,5L,6L,5L,6L,5L,6L,7L,6L,7L,6L,7L,6L,7L,8L,7L,8L,7L,8L,7L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,9L,10L,9L,10L,9L,10L,9L,10L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128622Inst : IEnumerable<long>
{
public static readonly long[] Value=A128622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128622.Bytes);
public long this[int i]=>Value[i];

public static A128622Inst Instance=new A128622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128623
{
public static readonly long[] Value={ 1L,2L,2L,6L,3L,3L,8L,8L,4L,4L,15L,10L,10L,5L,5L,18L,18L,12L,12L,6L,6L,28L,21L,21L,14L,14L,7L,7L,32L,32L,24L,24L,16L,16L,8L,8L,45L,36L,36L,27L,18L,18L,9L,9L,50L,50L,40L,40L,30L,30L,20L,20L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128623Inst : IEnumerable<long>
{
public static readonly long[] Value=A128623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128623.Bytes);
public long this[int i]=>Value[i];

public static A128623Inst Instance=new A128623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128624
{
public static readonly long[] Value={ 1L,4L,12L,24L,45L,72L,112L,160L,225L,300L,396L,504L,637L,784L,960L,1152L,1377L,1620L,1900L,2200L,2541L,2904L,3312L,3744L,4225L,4732L,5292L,5880L,6525L,7200L,7936L,8704L,9537L,10404L,11340L,12312L,13357L,14440L,15600L,16800L,18081L,19404L,20812L,22264L,23805L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128624Inst : IEnumerable<long>
{
public static readonly long[] Value=A128624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128624.Bytes);
public long this[int i]=>Value[i];

public static A128624Inst Instance=new A128624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128625
{
public static readonly long[] Value={ 1L,8L,40L,200L,1000L,5000L,25000L,125000L,625000L,3125000L,15625000L,78125000L,390625000L,1953125000L,9765625000L,48828125000L,244140625000L,1220703125000L,6103515625000L,30517578125000L,152587890625000L,762939453125000L,3814697265625000L,19073486328125000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128625Inst : IEnumerable<long>
{
public static readonly long[] Value=A128625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128625.Bytes);
public long this[int i]=>Value[i];

public static A128625Inst Instance=new A128625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128626
{
public static readonly long[] Value={ 1L,4L,1L,9L,20L,1L,16L,140L,74L,1L,25L,572L,1136L,224L,1L,36L,1785L,8866L,6685L,604L,1L,49L,4600L,47152L,88380L,31851L,1492L,1L,64L,10416L,194282L,737059L,665542L,130808L,3458L,1L,81L,21320L,665769L,4512584L,8211274L,4105870L,479826L,7602L,1L,100L,40425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128626Inst : IEnumerable<long>
{
public static readonly long[] Value=A128626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128626.Bytes);
public long this[int i]=>Value[i];

public static A128626Inst Instance=new A128626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128627
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,2L,0L,1L,2L,2L,3L,0L,1L,2L,5L,3L,4L,0L,1L,4L,6L,9L,4L,5L,0L,1L,4L,13L,12L,14L,5L,6L,0L,1L,7L,16L,28L,20L,20L,6L,7L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128627Inst : IEnumerable<long>
{
public static readonly long[] Value=A128627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128627.Bytes);
public long this[int i]=>Value[i];

public static A128627Inst Instance=new A128627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128628
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,2L,3L,4L,1L,2L,2L,3L,3L,4L,5L,1L,2L,2L,3L,2L,3L,4L,3L,4L,5L,6L,1L,2L,2L,3L,2L,3L,4L,3L,3L,4L,5L,4L,5L,6L,7L,1L,2L,2L,3L,2L,3L,4L,2L,3L,3L,4L,5L,3L,4L,4L,5L,6L,4L,5L,6L,7L,8L,1L,2L,2L,3L,2L,3L,4L,2L,3L,3L,4L,5L,3L,3L,4L,4L,5L,6L,3L,4L,5L,4L,5L,6L,7L,5L,6L,7L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128628Inst : IEnumerable<long>
{
public static readonly long[] Value=A128628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128628.Bytes);
public long this[int i]=>Value[i];

public static A128628Inst Instance=new A128628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128629
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,6L,4L,1L,1L,4L,9L,10L,5L,1L,1L,6L,10L,16L,15L,6L,1L,1L,5L,18L,20L,25L,21L,7L,1L,1L,8L,15L,40L,35L,36L,28L,8L,1L,1L,9L,27L,35L,75L,56L,49L,36L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128629Inst : IEnumerable<long>
{
public static readonly long[] Value=A128629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128629.Bytes);
public long this[int i]=>Value[i];

public static A128629Inst Instance=new A128629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128630
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,3L,3L,4L,2L,3L,4L,5L,3L,4L,5L,5L,2L,3L,3L,4L,4L,5L,5L,6L,3L,4L,5L,3L,4L,5L,5L,5L,2L,3L,4L,5L,3L,4L,5L,6L,4L,5L,6L,5L,5L,5L,6L,7L,3L,4L,5L,6L,5L,6L,3L,4L,5L,6L,5L,5L,5L,6L,5L,6L,2L,3L,4L,5L,4L,5L,5L,6L,3L,4L,5L,5L,5L,6L,6L,7L,4L,3L,4L,5L,6L,5L,5L,6L,5L,5L,5L,5L,6L,6L,7L,7L,3L,4L,5L,6L,5L,6L,6L,7L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128630Inst : IEnumerable<long>
{
public static readonly long[] Value=A128630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128630.Bytes);
public long this[int i]=>Value[i];

public static A128630Inst Instance=new A128630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128631
{
public static readonly long[] Value={ 0L,1L,2L,3L,7L,11L,23L,47L,185L,431L,1438L,6063L,31067L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128631Inst : IEnumerable<long>
{
public static readonly long[] Value=A128631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128631.Bytes);
public long this[int i]=>Value[i];

public static A128631Inst Instance=new A128631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128856
{
public static readonly long[] Value={ 0L,1L,71L,21L,45L,12L,64L,6L,5L,280L,11L,121L,638185L,62L,8L,76L,9L,7L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128856Inst : IEnumerable<long>
{
public static readonly long[] Value=A128856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128856.Bytes);
public long this[int i]=>Value[i];

public static A128856Inst Instance=new A128856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128857
{
public static readonly BigInteger[] Value={ 1L,105263157894736842L,BigInteger.Parse("1034482758620689655172413793"),102564L,BigInteger.Parse("102040816326530612244897959183673469387755"),BigInteger.Parse("1016949152542372881355932203389830508474576271186440677966") };
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
public class A128857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128857Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A128857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128857.Bytes);
public BigInteger this[int i]=>Value[i];

public static A128857Inst Instance=new A128857Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128858
{
public static readonly long[] Value={ 1L,18L,28L,6L,42L,58L,22L,13L,44L,2L,108L,48L,21L,46L,148L,13L,78L,178L,6L,99L,18L,8L,228L,7L,41L,6L,268L,15L,272L,66L,34L,28L,138L,112L,116L,179L,5L,378L,388L,18L,204L,418L,6L,219L,32L,48L,66L,239L,81L,498L,508L,43L,506L,42L,60L,42L,284L,192L,90L,299L,84L,618L,48L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128858Inst : IEnumerable<long>
{
public static readonly long[] Value=A128858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128858.Bytes);
public long this[int i]=>Value[i];

public static A128858Inst Instance=new A128858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128859
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,4L,2L,4L,6L,4L,6L,8L,6L,9L,12L,10L,8L,10L,9L,12L,10L,16L,20L,16L,20L,13L,22L,18L,24L,17L,18L,32L,18L,36L,16L,24L,26L,36L,42L,37L,24L,29L,32L,42L,23L,16L,38L,49L,36L,56L,44L,32L,44L,64L,59L,66L,33L,44L,48L,40L,72L,48L,55L,48L,78L,35L,48L,79L,56L,80L,80L,60L,60L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128859Inst : IEnumerable<long>
{
public static readonly long[] Value=A128859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128859.Bytes);
public long this[int i]=>Value[i];

public static A128859Inst Instance=new A128859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128860
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,4L,1L,6L,5L,3L,5L,6L,3L,13L,11L,10L,5L,5L,10L,8L,9L,16L,19L,11L,16L,10L,22L,13L,23L,12L,15L,30L,9L,35L,8L,17L,15L,46L,41L,37L,14L,34L,20L,36L,16L,10L,21L,49L,26L,54L,43L,17L,38L,64L,71L,65L,23L,32L,33L,22L,71L,30L,56L,28L,77L,16L,26L,79L,38L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128860Inst : IEnumerable<long>
{
public static readonly long[] Value=A128860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128860.Bytes);
public long this[int i]=>Value[i];

public static A128860Inst Instance=new A128860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128861
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,4L,2L,5L,5L,2L,4L,6L,3L,11L,11L,14L,4L,6L,8L,8L,7L,20L,18L,11L,16L,10L,26L,12L,21L,10L,18L,30L,14L,35L,11L,15L,18L,41L,41L,44L,13L,27L,21L,36L,18L,11L,23L,56L,23L,54L,39L,17L,40L,64L,65L,65L,19L,28L,33L,30L,71L,30L,46L,30L,77L,19L,27L,86L,36L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128861Inst : IEnumerable<long>
{
public static readonly long[] Value=A128861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128861.Bytes);
public long this[int i]=>Value[i];

public static A128861Inst Instance=new A128861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128862
{
public static readonly long[] Value={ 1L,10L,136L,1891L,26335L,366796L,5108806L,71156485L,991081981L,13803991246L,192264795460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128862Inst : IEnumerable<long>
{
public static readonly long[] Value=A128862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128862.Bytes);
public long this[int i]=>Value[i];

public static A128862Inst Instance=new A128862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128863
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,3L,3L,4L,6L,4L,4L,4L,5L,6L,6L,4L,6L,2L,6L,3L,2L,2L,8L,2L,4L,2L,6L,4L,6L,4L,4L,4L,9L,8L,8L,2L,4L,2L,8L,2L,8L,3L,6L,3L,2L,2L,10L,4L,6L,4L,8L,2L,8L,2L,8L,6L,4L,2L,12L,2L,4L,4L,8L,2L,8L,2L,6L,2L,8L,4L,4L,6L,8L,5L,2L,4L,10L,4L,4L,2L,4L,4L,4L,4L,8L,4L,12L,6L,4L,4L,4L,4L,12L,8L,8L,2L,6L,2L,9L,12L,10L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128863Inst : IEnumerable<long>
{
public static readonly long[] Value=A128863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128863.Bytes);
public long this[int i]=>Value[i];

public static A128863Inst Instance=new A128863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128864
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,2L,2L,1L,1L,2L,2L,2L,2L,2L,4L,1L,2L,2L,2L,2L,4L,2L,2L,2L,3L,4L,4L,2L,2L,4L,2L,1L,2L,4L,4L,3L,2L,4L,2L,2L,2L,4L,2L,2L,6L,2L,2L,2L,3L,2L,4L,2L,2L,4L,4L,2L,2L,2L,2L,4L,2L,2L,6L,1L,4L,8L,2L,2L,4L,4L,2L,1L,2L,4L,3L,6L,4L,4L,2L,2L,5L,4L,2L,2L,4L,2L,2L,2L,2L,6L,4L,2L,2L,2L,4L,1L,2L,6L,6L,3L,2L,8L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128864Inst : IEnumerable<long>
{
public static readonly long[] Value=A128864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128864.Bytes);
public long this[int i]=>Value[i];

public static A128864Inst Instance=new A128864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128865
{
public static readonly long[] Value={ 4L,108L,1372L,13500L,119164L,1000188L,8193532L,66325500L,533731324L,4282396668L,34309431292L,274676629500L,2198218047484L,17588965015548L,140724603846652L,1125848368021500L,9006993097883644L,72056769407352828L,576457453774831612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128865Inst : IEnumerable<long>
{
public static readonly long[] Value=A128865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128865.Bytes);
public long this[int i]=>Value[i];

public static A128865Inst Instance=new A128865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128866
{
public static readonly long[] Value={ 5L,405L,12005L,253125L,4617605L,78764805L,1300723205L,21141253125L,340920883205L,5476114739205L,87789257318405L,1406000997253125L,22507005033676805L,360200017312153605L,5763903867804057605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128866Inst : IEnumerable<long>
{
public static readonly long[] Value=A128866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128866.Bytes);
public long this[int i]=>Value[i];

public static A128866Inst Instance=new A128866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128867
{
public static readonly long[] Value={ 4L,5L,31L,106L,53L,582L,318L,9528L,11201L,19174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128867Inst : IEnumerable<long>
{
public static readonly long[] Value=A128867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128867.Bytes);
public long this[int i]=>Value[i];

public static A128867Inst Instance=new A128867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128868
{
public static readonly long[] Value={ 2L,4L,3L,2L,5L,4L,1L,3L,5L,5L,2L,1L,4L,7L,6L,2L,3L,1L,4L,9L,4L,1L,2L,3L,1L,5L,5L,5L,2L,1L,3L,3L,1L,4L,7L,6L,1L,2L,1L,4L,4L,2L,4L,9L,5L,1L,1L,2L,1L,4L,3L,2L,5L,7L,7L,1L,1L,1L,3L,1L,3L,3L,3L,4L,9L,8L,0L,1L,2L,1L,3L,1L,4L,4L,3L,6L,9L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128868Inst : IEnumerable<long>
{
public static readonly long[] Value=A128868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128868.Bytes);
public long this[int i]=>Value[i];

public static A128868Inst Instance=new A128868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128869
{
public static readonly long[] Value={ 6L,68L,683L,6837L,68377L,683772L,6837722L,68377223L,683772233L,6837722339L,68377223398L,683772233983L,6837722339831L,68377223398316L,683772233983162L,6837722339831620L,68377223398316206L,683772233983162066L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128869Inst : IEnumerable<long>
{
public static readonly long[] Value=A128869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128869.Bytes);
public long this[int i]=>Value[i];

public static A128869Inst Instance=new A128869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128870
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,14L,111L,112L,128L,216L,512L,1111L,1116L,1127L,1211L,1274L,5187L,8151L,11111L,15125L,41111L,111111L,111188L,111511L,141151L,1111111L,1111121L,1112111L,1211111L,11111111L,11111175L,11211291L,71111117L,111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128870Inst : IEnumerable<long>
{
public static readonly long[] Value=A128870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128870.Bytes);
public long this[int i]=>Value[i];

public static A128870Inst Instance=new A128870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A128871
{
public static readonly long[] Value={ 0L,1L,890L,24031L,24921L,2017711L,2042632L,4060343L,6102975L,10163318L,26429611L,36592929L,282580114L,884333271L,1166913385L,2051246656L,7320653353L,16692553362L,24013206715L,136758586937L,434288967526L,571047554463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A128871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A128871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A128871Inst : IEnumerable<long>
{
public static readonly long[] Value=A128871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A128871.Bytes);
public long this[int i]=>Value[i];

public static A128871Inst Instance=new A128871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129000
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129000Inst : IEnumerable<long>
{
public static readonly long[] Value=A129000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129000.Bytes);
public long this[int i]=>Value[i];

public static A129000Inst Instance=new A129000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129001
{
public static readonly long[] Value={ 1L,3L,2L,2L,3L,4L,2L,1L,2L,2L,3L,2L,1L,2L,2L,3L,4L,3L,2L,1L,2L,3L,4L,6L,5L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129001Inst : IEnumerable<long>
{
public static readonly long[] Value=A129001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129001.Bytes);
public long this[int i]=>Value[i];

public static A129001Inst Instance=new A129001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129002
{
public static readonly long[] Value={ 4L,48L,288L,1280L,4800L,16128L,50176L,147456L,414720L,1126400L,2973696L,7667712L,19382272L,48168960L,117964800L,285212672L,681836544L,1613758464L,3785359360L,8808038400L,20346568704L,46690992128L,106501767168L,241591910400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129002Inst : IEnumerable<long>
{
public static readonly long[] Value=A129002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129002.Bytes);
public long this[int i]=>Value[i];

public static A129002Inst Instance=new A129002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129003
{
public static readonly long[] Value={ 6L,108L,972L,6480L,36450L,183708L,857304L,3779136L,15943230L,64953900L,257217444L,994857552L,3772168218L,14061928860L,51656065200L,187339329792L,671787127926L,2384960530284L,8391527791740L,29288988968400L,101486346775506L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129003Inst : IEnumerable<long>
{
public static readonly long[] Value=A129003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129003.Bytes);
public long this[int i]=>Value[i];

public static A129003Inst Instance=new A129003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129004
{
public static readonly long[] Value={ 8L,192L,2304L,20480L,153600L,1032192L,6422528L,37748736L,212336640L,1153433600L,6090129408L,31406948352L,158779572224L,789200240640L,3865470566400L,18691697672192L,89369679495168L,423037098786816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129004Inst : IEnumerable<long>
{
public static readonly long[] Value=A129004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129004.Bytes);
public long this[int i]=>Value[i];

public static A129004Inst Instance=new A129004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129005
{
public static readonly long[] Value={ 0L,10L,300L,4500L,50000L,468750L,3937500L,30625000L,225000000L,1582031250L,10742187500L,70898437500L,457031250000L,2888183593750L,17944335937500L,109863281250000L,664062500000000L,3968811035156250L,23483276367187500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129005Inst : IEnumerable<long>
{
public static readonly long[] Value=A129005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129005.Bytes);
public long this[int i]=>Value[i];

public static A129005Inst Instance=new A129005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129006
{
public static readonly long[] Value={ 12L,432L,7776L,103680L,1166400L,11757312L,109734912L,967458816L,8162933760L,66512793600L,526781325312L,4074936532992L,30901602041856L,230390642442240L,1692665944473600L,12277470317248512L,88052482431516672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129006Inst : IEnumerable<long>
{
public static readonly long[] Value=A129006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129006.Bytes);
public long this[int i]=>Value[i];

public static A129006Inst Instance=new A129006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129007
{
public static readonly long[] Value={ 14L,588L,12348L,192080L,2521050L,29647548L,322828856L,3320525376L,32686421670L,310722773900L,2871078430836L,25910889640272L,229239398622962L,1993975834176060L,17091221435794800L,144629713838903552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129007Inst : IEnumerable<long>
{
public static readonly long[] Value=A129007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129007.Bytes);
public long this[int i]=>Value[i];

public static A129007Inst Instance=new A129007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129008
{
public static readonly long[] Value={ 16L,768L,18432L,327680L,4915200L,66060288L,822083584L,9663676416L,108716359680L,1181116006400L,12472585027584L,128642860449792L,1300722255659008L,12930256742645760L,126663739519795200L,1224979098644774912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129008Inst : IEnumerable<long>
{
public static readonly long[] Value=A129008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129008.Bytes);
public long this[int i]=>Value[i];

public static A129008Inst Instance=new A129008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129009
{
public static readonly long[] Value={ 18L,972L,26244L,524880L,8857350L,133923132L,1874923848L,24794911296L,313810596090L,3835462841100L,45565298552268L,528708092292432L,6014054549826414L,67257769817585340L,741208075540736400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129009Inst : IEnumerable<long>
{
public static readonly long[] Value=A129009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129009.Bytes);
public long this[int i]=>Value[i];

public static A129009Inst Instance=new A129009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129010
{
public static readonly long[] Value={ 0L,124L,168L,187L,343L,399L,595L,624L,915L,952L,1260L,1372L,1768L,1827L,1975L,2499L,3135L,3367L,3468L,4312L,4620L,5712L,5875L,7524L,7735L,9499L,10143L,12427L,12768L,13624L,16660L,20352L,21700L,22287L,27195L,28987L,35343L,36292L,45895L,47124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129010Inst : IEnumerable<long>
{
public static readonly long[] Value=A129010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129010.Bytes);
public long this[int i]=>Value[i];

public static A129010Inst Instance=new A129010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129011
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,8L,10L,13L,16L,18L,21L,24L,27L,30L,33L,36L,40L,43L,47L,50L,54L,57L,61L,65L,69L,73L,77L,81L,85L,89L,93L,97L,101L,105L,110L,114L,118L,123L,127L,132L,136L,141L,145L,150L,155L,160L,164L,169L,174L,179L,184L,189L,194L,199L,204L,209L,214L,219L,224L,229L,234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129011Inst : IEnumerable<long>
{
public static readonly long[] Value=A129011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129011.Bytes);
public long this[int i]=>Value[i];

public static A129011Inst Instance=new A129011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129012
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,3L,7L,12L,12L,27L,38L,38L,86L,128L,128L,264L,373L,373L,749L,1055L,1055L,2022L,2765L,2765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129012Inst : IEnumerable<long>
{
public static readonly long[] Value=A129012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129012.Bytes);
public long this[int i]=>Value[i];

public static A129012Inst Instance=new A129012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129013
{
public static readonly long[] Value={ 1L,2L,7L,27L,86L,264L,749L,2022L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129013Inst : IEnumerable<long>
{
public static readonly long[] Value=A129013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129013.Bytes);
public long this[int i]=>Value[i];

public static A129013Inst Instance=new A129013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129014
{
public static readonly long[] Value={ 1L,3L,12L,38L,128L,373L,1055L,2765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129014Inst : IEnumerable<long>
{
public static readonly long[] Value=A129014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129014.Bytes);
public long this[int i]=>Value[i];

public static A129014Inst Instance=new A129014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129015
{
public static readonly long[] Value={ 0L,1L,5L,11L,42L,109L,306L,743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129015Inst : IEnumerable<long>
{
public static readonly long[] Value=A129015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129015.Bytes);
public long this[int i]=>Value[i];

public static A129015Inst Instance=new A129015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129112
{
public static readonly long[] Value={ 4L,6L,9L,1L,0L,1L,4L,1L,5L,2L,1L,2L,2L,2L,5L,2L,6L,3L,3L,3L,4L,3L,5L,3L,8L,3L,9L,4L,6L,4L,9L,5L,1L,5L,5L,5L,7L,5L,8L,6L,2L,6L,5L,6L,9L,7L,4L,7L,7L,8L,2L,8L,5L,8L,6L,8L,7L,9L,1L,9L,3L,9L,4L,9L,5L,1L,0L,6L,1L,1L,1L,1L,1L,5L,1L,1L,8L,1L,1L,9L,1L,2L,1L,1L,2L,2L,1L,2L,3L,1L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129112Inst : IEnumerable<long>
{
public static readonly long[] Value=A129112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129112.Bytes);
public long this[int i]=>Value[i];

public static A129112Inst Instance=new A129112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129113
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,6L,12L,42L,107L,323L,888L,2568L,7224L,20629L,58429L,166230L,471780L,1340730L,3807431L,10816631L,30722736L,87272592L,247895472L,704164537L,2000191753L,5681637318L,16138865148L,45843078954L,130218850259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129113Inst : IEnumerable<long>
{
public static readonly long[] Value=A129113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129113.Bytes);
public long this[int i]=>Value[i];

public static A129113Inst Instance=new A129113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129114
{
public static readonly BigInteger[] Value={ 3L,11L,81L,1228L,28174L,843186L,30551755L,1291861997L,62352938720L,3381736322813L,203604398647922L,13475238697911184L,972429507963453210L,BigInteger.Parse("75993857157285258473"),BigInteger.Parse("6393779463050776636807"),BigInteger.Parse("576237114190853665462712") };
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
public class A129114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129114Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A129114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129114.Bytes);
public BigInteger this[int i]=>Value[i];

public static A129114Inst Instance=new A129114Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129115
{
public static readonly BigInteger[] Value={ 1L,3L,17L,124L,1618L,33564L,956263L,33736198L,1402665692L,66902717187L,3596481426812L,215049652739982L,14154852098315796L,1016911004448831247L,BigInteger.Parse("79174846391508487198"),BigInteger.Parse("6640511488761139957873"),BigInteger.Parse("596865894849670793348763") };
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
public class A129115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129115Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A129115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129115.Bytes);
public BigInteger this[int i]=>Value[i];

public static A129115Inst Instance=new A129115Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129116
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,6L,1L,2L,3L,24L,1L,2L,3L,8L,120L,1L,2L,3L,4L,15L,720L,1L,2L,3L,4L,10L,48L,5040L,1L,2L,3L,4L,5L,18L,105L,40320L,1L,2L,3L,4L,5L,12L,28L,384L,362880L,1L,2L,3L,4L,5L,6L,21L,80L,945L,3628800L,1L,2L,3L,4L,5L,6L,14L,32L,162L,3840L,39916800L,1L,2L,3L,4L,5L,6L,7L,24L,45L,280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129116Inst : IEnumerable<long>
{
public static readonly long[] Value=A129116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129116.Bytes);
public long this[int i]=>Value[i];

public static A129116Inst Instance=new A129116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129117
{
public static readonly long[] Value={ 727L,2181L,3635L,5089L,6543L,7997L,9451L,10905L,12358L,13812L,15266L,16720L,18174L,19628L,21082L,22536L,23989L,25443L,26897L,28351L,29805L,31259L,32713L,34167L,35620L,37074L,38528L,39982L,41436L,42890L,44344L,45798L,47250L,48704L,50158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129117Inst : IEnumerable<long>
{
public static readonly long[] Value=A129117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129117.Bytes);
public long this[int i]=>Value[i];

public static A129117Inst Instance=new A129117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129118
{
public static readonly long[] Value={ 0L,1L,2L,10L,48L,295L,2068L,16654L,150382L,1508500L,16631696L,199966907L,2603709640L,36501212971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129118Inst : IEnumerable<long>
{
public static readonly long[] Value=A129118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129118.Bytes);
public long this[int i]=>Value[i];

public static A129118Inst Instance=new A129118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129119
{
public static readonly long[] Value={ 6L,10L,14L,26L,34L,74L,94L,134L,146L,194L,206L,274L,326L,334L,386L,466L,554L,586L,614L,626L,634L,694L,746L,926L,974L,1006L,1094L,1154L,1186L,1214L,1226L,1354L,1486L,1574L,1646L,1654L,1706L,1766L,1906L,1934L,1966L,1994L,2174L,2234L,2246L,2474L,2734L,2846L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129119Inst : IEnumerable<long>
{
public static readonly long[] Value=A129119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129119.Bytes);
public long this[int i]=>Value[i];

public static A129119Inst Instance=new A129119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129120
{
public static readonly long[] Value={ 10L,12L,18L,20L,21L,24L,27L,30L,36L,40L,42L,45L,48L,50L,54L,60L,63L,70L,72L,80L,81L,84L,90L,171L,252L,414L,828L,1010L,1212L,1818L,2020L,2424L,3030L,3636L,4040L,4848L,5050L,5454L,6060L,7070L,7272L,8080L,9090L,10101L,13131L,20202L,23232L,26262L,30303L,39393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129120Inst : IEnumerable<long>
{
public static readonly long[] Value=A129120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129120.Bytes);
public long this[int i]=>Value[i];

public static A129120Inst Instance=new A129120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129121
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,12L,13L,16L,17L,20L,25L,33L,34L,36L,37L,39L,40L,42L,48L,50L,52L,59L,60L,62L,66L,67L,69L,71L,76L,80L,81L,83L,86L,89L,95L,99L,101L,103L,104L,107L,109L,117L,118L,120L,121L,122L,125L,126L,132L,133L,134L,135L,136L,137L,139L,142L,143L,145L,149L,152L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129121Inst : IEnumerable<long>
{
public static readonly long[] Value=A129121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129121.Bytes);
public long this[int i]=>Value[i];

public static A129121Inst Instance=new A129121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129122
{
public static readonly long[] Value={ 3L,38L,60L,62L,75L,107L,119L,132L,156L,164L,188L,213L,245L,300L,332L,357L,381L,389L,413L,426L,438L,470L,483L,485L,507L,542L,564L,566L,623L,651L,708L,710L,732L,767L,789L,791L,804L,836L,848L,861L,885L,893L,917L,942L,974L,1029L,1061L,1086L,1110L,1118L,1142L,1155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129122Inst : IEnumerable<long>
{
public static readonly long[] Value=A129122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129122.Bytes);
public long this[int i]=>Value[i];

public static A129122Inst Instance=new A129122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129123
{
public static readonly long[] Value={ 1L,1L,2L,17L,98L,882L,7812L,78129L,815474L,8955650L,101869508L,1194964498L,14374530436L,176681194276L,2212121332488L,28145258688369L,363177582488274L,4745064935840178L,62687665026816228L,836447728509168930L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129123Inst : IEnumerable<long>
{
public static readonly long[] Value=A129123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129123.Bytes);
public long this[int i]=>Value[i];

public static A129123Inst Instance=new A129123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129124
{
public static readonly long[] Value={ 238L,257L,277L,337L,525L,699L,911L,1135L,1147L,1257L,1349L,1466L,1504L,1544L,1664L,1992L,2024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129124Inst : IEnumerable<long>
{
public static readonly long[] Value=A129124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129124.Bytes);
public long this[int i]=>Value[i];

public static A129124Inst Instance=new A129124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129125
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,10L,9L,11L,14L,15L,18L,13L,22L,21L,25L,30L,27L,17L,26L,33L,35L,42L,50L,45L,54L,19L,34L,39L,55L,66L,49L,70L,63L,75L,90L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129125Inst : IEnumerable<long>
{
public static readonly long[] Value=A129125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129125.Bytes);
public long this[int i]=>Value[i];

public static A129125Inst Instance=new A129125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129126
{
public static readonly long[] Value={ 22L,185L,810L,2580L,6765L,15525L,32305L,62337L,113265L,195910L,325193L,521235L,810654L,1228080L,1817910L,2636326L,3753600L,5256711L,7252300L,9869990L,13266099L,17627775L,23177583L,30178575L,38939875L,49822812L,63247635L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129126Inst : IEnumerable<long>
{
public static readonly long[] Value=A129126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129126.Bytes);
public long this[int i]=>Value[i];

public static A129126Inst Instance=new A129126Inst();

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