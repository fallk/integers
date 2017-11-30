using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A116941
{
public static readonly long[] Value={ 0L,1L,3L,2L,4L,6L,5L,7L,9L,11L,8L,10L,12L,14L,16L,13L,15L,17L,19L,21L,23L,18L,20L,22L,24L,26L,28L,30L,25L,27L,29L,31L,33L,35L,37L,39L,32L,34L,36L,38L,40L,42L,44L,46L,48L,41L,43L,45L,47L,49L,51L,53L,55L,57L,59L,50L,52L,54L,56L,58L,60L,62L,64L,66L,68L,70L,61L,63L,65L,67L,69L,71L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116941Inst : IEnumerable<long>
{
public static readonly long[] Value=A116941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116941.Bytes);
public long this[int i]=>Value[i];

public static A116941Inst Instance=new A116941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116942
{
public static readonly long[] Value={ 0L,1L,3L,2L,4L,6L,5L,7L,10L,8L,11L,9L,12L,15L,13L,16L,14L,17L,21L,18L,22L,19L,23L,20L,24L,28L,25L,29L,26L,30L,27L,31L,36L,32L,37L,33L,38L,34L,39L,35L,40L,45L,41L,46L,42L,47L,43L,48L,44L,49L,55L,50L,56L,51L,57L,52L,58L,53L,59L,54L,60L,66L,61L,67L,62L,68L,63L,69L,64L,70L,65L,71L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116942Inst : IEnumerable<long>
{
public static readonly long[] Value=A116942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116942.Bytes);
public long this[int i]=>Value[i];

public static A116942Inst Instance=new A116942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116943
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,3L,2L,2L,2L,1L,1L,3L,4L,5L,3L,3L,1L,4L,4L,7L,2L,7L,7L,4L,6L,9L,9L,6L,5L,5L,7L,4L,9L,4L,7L,7L,7L,10L,8L,6L,8L,6L,9L,8L,9L,8L,10L,11L,11L,8L,13L,5L,11L,15L,13L,10L,10L,8L,12L,9L,14L,11L,8L,11L,12L,10L,13L,13L,13L,10L,10L,12L,6L,10L,15L,8L,17L,17L,16L,16L,12L,16L,15L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116943Inst : IEnumerable<long>
{
public static readonly long[] Value=A116943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116943.Bytes);
public long this[int i]=>Value[i];

public static A116943Inst Instance=new A116943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116944
{
public static readonly BigInteger[] Value={ 1L,4L,125L,252047376L,BigInteger.Parse("1017210679182495207444253709079169646680657") };
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
public class A116944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116944Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A116944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116944.Bytes);
public BigInteger this[int i]=>Value[i];

public static A116944Inst Instance=new A116944Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116945
{
public static readonly long[] Value={ 3L,11L,19L,59L,69L,221L,271L,349L,371L,391L,441L,451L,521L,529L,649L,779L,869L,921L,929L,951L,1001L,1031L,1051L,1171L,1359L,1391L,1421L,1689L,1701L,2199L,2321L,2349L,2381L,2671L,2711L,2719L,2821L,2901L,3001L,3241L,3341L,3399L,3441L,3499L,3691L,4299L,4349L,4479L,4589L,4691L,4801L,4879L,4949L,4999L,5109L,5271L,5539L,5591L,5669L,5739L,5941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116945Inst : IEnumerable<long>
{
public static readonly long[] Value=A116945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116945.Bytes);
public long this[int i]=>Value[i];

public static A116945Inst Instance=new A116945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116946
{
public static readonly long[] Value={ 6L,4L,10L,9L,15L,14L,22L,21L,26L,25L,34L,33L,34L,39L,38L,49L,51L,49L,57L,58L,57L,65L,62L,65L,77L,74L,85L,86L,85L,86L,93L,94L,93L,94L,111L,115L,118L,119L,118L,122L,121L,122L,133L,134L,133L,142L,141L,142L,146L,145L,158L,159L,158L,159L,169L,166L,178L,177L,185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116946Inst : IEnumerable<long>
{
public static readonly long[] Value=A116946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116946.Bytes);
public long this[int i]=>Value[i];

public static A116946Inst Instance=new A116946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116947
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,17L,20L,22L,28L,30L,40L,45L,67L,68L,70L,75L,82L,85L,87L,88L,95L,108L,123L,125L,140L,150L,153L,163L,172L,190L,197L,200L,210L,217L,220L,223L,232L,237L,248L,268L,270L,282L,283L,287L,303L,310L,320L,333L,340L,358L,367L,403L,405L,407L,423L,438L,445L,447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116947Inst : IEnumerable<long>
{
public static readonly long[] Value=A116947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116947.Bytes);
public long this[int i]=>Value[i];

public static A116947Inst Instance=new A116947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116948
{
public static readonly long[] Value={ 1L,0L,1L,2L,0L,1L,1L,2L,0L,1L,0L,1L,2L,0L,1L,2L,0L,1L,2L,0L,1L,1L,2L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,2L,0L,1L,2L,0L,1L,2L,0L,1L,2L,0L,1L,1L,2L,0L,1L,2L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,2L,0L,1L,2L,0L,1L,2L,0L,1L,2L,0L,1L,2L,0L,1L,2L,0L,1L,1L,2L,0L,1L,2L,0L,1L,2L,0L,1L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116948Inst : IEnumerable<long>
{
public static readonly long[] Value=A116948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116948.Bytes);
public long this[int i]=>Value[i];

public static A116948Inst Instance=new A116948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116949
{
public static readonly long[] Value={ 1L,0L,1L,-2L,0L,1L,-1L,-2L,0L,1L,4L,-1L,-2L,0L,1L,2L,4L,-1L,-2L,0L,1L,-8L,2L,4L,-1L,-2L,0L,1L,-4L,-8L,2L,4L,-1L,-2L,0L,1L,16L,-4L,-8L,2L,4L,-1L,-2L,0L,1L,8L,16L,-4L,-8L,2L,4L,-1L,-2L,0L,1L,-32L,8L,16L,-4L,-8L,2L,4L,-1L,-2L,0L,1L,-16L,-32L,8L,16L,-4L,-8L,2L,4L,-1L,-2L,0L,1L,64L,-16L,-32L,8L,16L,-4L,-8L,2L,4L,-1L,-2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116949Inst : IEnumerable<long>
{
public static readonly long[] Value=A116949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116949.Bytes);
public long this[int i]=>Value[i];

public static A116949Inst Instance=new A116949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116950
{
public static readonly long[] Value={ 1L,2L,7L,20L,61L,174L,514L,1478L,4303L,12437L,36084L,104494L,303167L,879283L,2552803L,7413583L,21544347L,62635823L,182199853L,530228946L,1543761513L,4496523995L,13102414665L,38193626823L,111375529695L,324891970936L,948051861938L,2767336312386L,8080206646244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116950Inst : IEnumerable<long>
{
public static readonly long[] Value=A116950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116950.Bytes);
public long this[int i]=>Value[i];

public static A116950Inst Instance=new A116950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116951
{
public static readonly long[] Value={ 0L,1L,6L,39L,84L,543L,3510L,7563L,48888L,316017L,680922L,4401549L,28452060L,61305669L,396286074L,2561633451L,5519552976L,35678951307L,230632366770L,496943684847L,3212294475852L,20764597909653L,44741490295158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116951Inst : IEnumerable<long>
{
public static readonly long[] Value=A116951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116951.Bytes);
public long this[int i]=>Value[i];

public static A116951Inst Instance=new A116951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116952
{
public static readonly long[] Value={ 1L,8L,29L,92L,281L,848L,2549L,7652L,22961L,68888L,206669L,620012L,1860041L,5580128L,16740389L,50221172L,150663521L,451990568L,1355971709L,4067915132L,12203745401L,36611236208L,109833708629L,329501125892L,988503377681L,2965510133048L,8896530399149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116952Inst : IEnumerable<long>
{
public static readonly long[] Value=A116952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116952.Bytes);
public long this[int i]=>Value[i];

public static A116952Inst Instance=new A116952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116953
{
public static readonly long[] Value={ 1L,1L,2L,5L,10L,23L,50L,107L,232L,500L,1078L,2323L,5007L,10789L,23248L,50092L,107934L,232566L,501111L,1079745L,2326528L,5012972L,10801454L,23273900L,50148285L,108054537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116953Inst : IEnumerable<long>
{
public static readonly long[] Value=A116953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116953.Bytes);
public long this[int i]=>Value[i];

public static A116953Inst Instance=new A116953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116954
{
public static readonly long[] Value={ 4L,10L,14L,16L,18L,20L,30L,36L,38L,48L,54L,58L,64L,70L,74L,86L,96L,106L,120L,140L,150L,154L,166L,170L,174L,176L,180L,200L,230L,234L,244L,260L,266L,268L,288L,296L,300L,304L,306L,308L,324L,330L,338L,340L,346L,348L,368L,384L,388L,394L,396L,406L,408L,434L,438L,440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116954Inst : IEnumerable<long>
{
public static readonly long[] Value=A116954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116954.Bytes);
public long this[int i]=>Value[i];

public static A116954Inst Instance=new A116954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116955
{
public static readonly long[] Value={ 1L,10L,14L,30L,66L,130L,230L,374L,570L,826L,1150L,1550L,2034L,2610L,3286L,4070L,4970L,5994L,7150L,8446L,9890L,11490L,13254L,15190L,17306L,19610L,22110L,24814L,27730L,30866L,34230L,37830L,41674L,45770L,50126L,54750L,59650L,64834L,70310L,76086L,82170L,88570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116955Inst : IEnumerable<long>
{
public static readonly long[] Value=A116955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116955.Bytes);
public long this[int i]=>Value[i];

public static A116955Inst Instance=new A116955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116956
{
public static readonly BigInteger[] Value={ 1L,1L,3L,18L,157L,1800L,25551L,432376L,8494809L,190029888L,4768313275L,132626098176L,4049755214517L,134677876657792L,4845193429684167L,187490897290080000L,7765153170076158001L,BigInteger.Parse("342721890859339812864"),BigInteger.Parse("16058392049508837366771"),BigInteger.Parse("796093438190851834236928") };
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
public class A116956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116956Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A116956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116956.Bytes);
public BigInteger this[int i]=>Value[i];

public static A116956Inst Instance=new A116956Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116957
{
public static readonly long[] Value={ 5L,15L,135L,175L,315L,735L,1395L,1935L,3195L,3915L,9135L,9315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116957Inst : IEnumerable<long>
{
public static readonly long[] Value=A116957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116957.Bytes);
public long this[int i]=>Value[i];

public static A116957Inst Instance=new A116957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116958
{
public static readonly long[] Value={ 0L,3L,6L,12L,18L,27L,33L,48L,51L,66L,72L,87L,93L,96L,111L,117L,132L,138L,153L,171L,207L,213L,228L,258L,282L,297L,306L,318L,327L,402L,408L,411L,426L,438L,507L,513L,522L,528L,543L,573L,612L,636L,642L,648L,657L,711L,723L,738L,741L,801L,807L,831L,846L,858L,891L,933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116958Inst : IEnumerable<long>
{
public static readonly long[] Value=A116958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116958.Bytes);
public long this[int i]=>Value[i];

public static A116958Inst Instance=new A116958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116959
{
public static readonly long[] Value={ 3L,5L,7L,11L,17L,19L,23L,29L,31L,37L,43L,47L,53L,59L,67L,71L,73L,79L,83L,97L,101L,103L,107L,109L,125L,127L,131L,139L,149L,151L,163L,167L,169L,179L,181L,191L,193L,197L,211L,223L,229L,233L,239L,241L,251L,257L,263L,271L,277L,281L,283L,293L,307L,311L,313L,331L,337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116959Inst : IEnumerable<long>
{
public static readonly long[] Value=A116959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116959.Bytes);
public long this[int i]=>Value[i];

public static A116959Inst Instance=new A116959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116960
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,24L,36L,48L,248L,264L,324L,384L,396L,432L,624L,648L,672L,728L,735L,784L,824L,864L,936L,2364L,2436L,3264L,3276L,3492L,3624L,3648L,3864L,3924L,4236L,4368L,4392L,4632L,4872L,4896L,4932L,4968L,6324L,6384L,6432L,6984L,8496L,8736L,9324L,9432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116960Inst : IEnumerable<long>
{
public static readonly long[] Value=A116960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116960.Bytes);
public long this[int i]=>Value[i];

public static A116960Inst Instance=new A116960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116961
{
public static readonly BigInteger[] Value={ 0L,1L,2L,3L,4L,7L,8L,15L,16L,127L,128L,255L,256L,32767L,32768L,65535L,65536L,2147483647L,2147483648L,4294967295L,4294967296L,9223372036854775807L,9223372036854775808UL,18446744073709551615UL,BigInteger.Parse("18446744073709551616") };
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
public class A116961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116961Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A116961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116961.Bytes);
public BigInteger this[int i]=>Value[i];

public static A116961Inst Instance=new A116961Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116962
{
public static readonly long[] Value={ 4L,5L,6L,6L,7L,8L,8L,9L,19L,20L,21L,22L,23L,24L,25L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,56L,57L,58L,59L,60L,61L,62L,63L,63L,64L,65L,66L,67L,68L,69L,69L,70L,71L,72L,73L,74L,74L,75L,76L,77L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116962Inst : IEnumerable<long>
{
public static readonly long[] Value=A116962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116962.Bytes);
public long this[int i]=>Value[i];

public static A116962Inst Instance=new A116962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116963
{
public static readonly long[] Value={ 4L,14L,24L,49L,60L,118L,124L,214L,244L,356L,368L,608L,564L,814L,896L,1183L,1144L,1668L,1544L,2162L,2168L,2678L,2604L,3698L,3336L,4228L,4304L,5344L,4964L,6732L,5988L,7728L,7528L,8924L,8616L,11297L,9884L,12214L,12064L,14668L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116963Inst : IEnumerable<long>
{
public static readonly long[] Value=A116963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116963.Bytes);
public long this[int i]=>Value[i];

public static A116963Inst Instance=new A116963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116964
{
public static readonly BigInteger[] Value={ 17L,181L,2008L,22269L,143285L,1692737L,18772741L,208192888L,2308894509L,14856075365L,175506357617L,1946395332181L,21585855011608L,138889450176440L,1640808956134074L,18196850168753057L,201806160812417701L,2238064619105347768L,14400335971854080600UL,BigInteger.Parse("170122354174067662074") };
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
public class A116964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116964Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A116964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116964.Bytes);
public BigInteger this[int i]=>Value[i];

public static A116964Inst Instance=new A116964Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116965
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,9L,10L,11L,16L,17L,18L,23L,30L,49L,50L,51L,56L,63L,96L,106L,107L,108L,113L,120L,153L,210L,385L,386L,387L,392L,399L,432L,489L,768L,946L,947L,948L,953L,960L,993L,1050L,1329L,1890L,3841L,3842L,3843L,3848L,3855L,3888L,3945L,4224L,4785L,7680L,10396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116965Inst : IEnumerable<long>
{
public static readonly long[] Value=A116965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116965.Bytes);
public long this[int i]=>Value[i];

public static A116965Inst Instance=new A116965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116966
{
public static readonly long[] Value={ 1L,3L,2L,4L,5L,7L,6L,8L,9L,11L,10L,12L,13L,15L,14L,16L,17L,19L,18L,20L,21L,23L,22L,24L,25L,27L,26L,28L,29L,31L,30L,32L,33L,35L,34L,36L,37L,39L,38L,40L,41L,43L,42L,44L,45L,47L,46L,48L,49L,51L,50L,52L,53L,55L,54L,56L,57L,59L,58L,60L,61L,63L,62L,64L,65L,67L,66L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116966Inst : IEnumerable<long>
{
public static readonly long[] Value=A116966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116966.Bytes);
public long this[int i]=>Value[i];

public static A116966Inst Instance=new A116966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116967
{
public static readonly long[] Value={ 4L,258L,154800L,132826269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116967Inst : IEnumerable<long>
{
public static readonly long[] Value=A116967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116967.Bytes);
public long this[int i]=>Value[i];

public static A116967Inst Instance=new A116967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116968
{
public static readonly long[] Value={ 2L,7L,29L,37L,71L,113L,163L,179L,199L,227L,283L,439L,463L,503L,541L,547L,647L,733L,761L,823L,839L,887L,953L,1031L,1049L,1051L,1093L,1327L,1399L,1549L,1627L,1741L,1847L,1861L,1901L,1951L,2017L,2053L,2081L,2179L,2221L,2287L,2309L,2399L,2477L,2591L,2689L,2711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116968Inst : IEnumerable<long>
{
public static readonly long[] Value=A116968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116968.Bytes);
public long this[int i]=>Value[i];

public static A116968Inst Instance=new A116968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116969
{
public static readonly long[] Value={ 4L,7L,15L,27L,53L,101L,199L,391L,777L,1545L,3083L,6155L,12301L,24589L,49167L,98319L,196625L,393233L,786451L,1572883L,3145749L,6291477L,12582935L,25165847L,50331673L,100663321L,201326619L,402653211L,805306397L,1610612765L,3221225503L,6442450975L,12884901921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116969Inst : IEnumerable<long>
{
public static readonly long[] Value=A116969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116969.Bytes);
public long this[int i]=>Value[i];

public static A116969Inst Instance=new A116969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116970
{
public static readonly long[] Value={ 1L,10L,37L,118L,361L,1090L,3277L,9838L,29521L,88570L,265717L,797158L,2391481L,7174450L,21523357L,64570078L,193710241L,581130730L,1743392197L,5230176598L,15690529801L,47071589410L,141214768237L,423644304718L,1270932914161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116970Inst : IEnumerable<long>
{
public static readonly long[] Value=A116970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116970.Bytes);
public long this[int i]=>Value[i];

public static A116970Inst Instance=new A116970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116971
{
public static readonly long[] Value={ 10L,56L,242L,988L,3974L,15920L,63706L,254852L,1019438L,4077784L,16311170L,65244716L,260978902L,1043915648L,4175662634L,16702650580L,66810602366L,267242409512L,1068969638098L,4275878552444L,17103514209830L,68414056839376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116971Inst : IEnumerable<long>
{
public static readonly long[] Value=A116971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116971.Bytes);
public long this[int i]=>Value[i];

public static A116971Inst Instance=new A116971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116972
{
public static readonly long[] Value={ 1L,21L,85L,281L,873L,2653L,7997L,24033L,72145L,216485L,649509L,1948585L,5845817L,17537517L,52612621L,157837937L,473513889L,1420541749L,4261625333L,12784876089L,38354628361L,115063885181L,345191655645L,1035574967041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116972Inst : IEnumerable<long>
{
public static readonly long[] Value=A116972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116972.Bytes);
public long this[int i]=>Value[i];

public static A116972Inst Instance=new A116972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116973
{
public static readonly long[] Value={ 1L,10L,28L,91L,271L,820L,2458L,7381L,22141L,66430L,199288L,597871L,1793611L,5380840L,16142518L,48427561L,145282681L,435848050L,1307544148L,3922632451L,11767897351L,35303692060L,105911076178L,317733228541L,953199685621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116973Inst : IEnumerable<long>
{
public static readonly long[] Value=A116973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116973.Bytes);
public long this[int i]=>Value[i];

public static A116973Inst Instance=new A116973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116974
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L,271L,277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116974Inst : IEnumerable<long>
{
public static readonly long[] Value=A116974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116974.Bytes);
public long this[int i]=>Value[i];

public static A116974Inst Instance=new A116974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116975
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,5L,7L,10L,15L,23L,35L,52L,77L,115L,173L,260L,389L,581L,869L,1302L,1951L,2921L,4371L,6542L,9795L,14667L,21959L,32872L,49209L,73671L,110297L,165128L,247209L,370089L,554057L,829482L,1241819L,1859117L,2783263L,4166802L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116975Inst : IEnumerable<long>
{
public static readonly long[] Value=A116975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116975.Bytes);
public long this[int i]=>Value[i];

public static A116975Inst Instance=new A116975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116976
{
public static readonly long[] Value={ 1L,2L,8L,61L,1153L,64310L,11352457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116976Inst : IEnumerable<long>
{
public static readonly long[] Value=A116976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116976.Bytes);
public long this[int i]=>Value[i];

public static A116976Inst Instance=new A116976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116977
{
public static readonly long[] Value={ 1L,5L,28L,256L,4471L,187300L,22290203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116977Inst : IEnumerable<long>
{
public static readonly long[] Value=A116977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116977.Bytes);
public long this[int i]=>Value[i];

public static A116977Inst Instance=new A116977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116978
{
public static readonly long[] Value={ 0L,1L,8L,64L,125L,343L,512L,1000L,4096L,4913L,5832L,6859L,8000L,9261L,10648L,13824L,15625L,17576L,19683L,21952L,27000L,32768L,35937L,39304L,42875L,46656L,50653L,54872L,59319L,64000L,68921L,74088L,79507L,85184L,91125L,97336L,103823L,110592L,117649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116978Inst : IEnumerable<long>
{
public static readonly long[] Value=A116978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116978.Bytes);
public long this[int i]=>Value[i];

public static A116978Inst Instance=new A116978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116979
{
public static readonly long[] Value={ 0L,0L,1L,3L,19L,114L,905L,9493L,124180L,2044847L,43755729L,1043468386L,30309948241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116979Inst : IEnumerable<long>
{
public static readonly long[] Value=A116979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116979.Bytes);
public long this[int i]=>Value[i];

public static A116979Inst Instance=new A116979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116980
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,4L,19L,23L,16L,43L,59L,66L,127L,492L,886L,964L,2595L,11426L,36780L,78070L,131232L,423402L,1302893L,3356226L,6673924L,16604441L,32195439L,69328860L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116980Inst : IEnumerable<long>
{
public static readonly long[] Value=A116980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116980.Bytes);
public long this[int i]=>Value[i];

public static A116980Inst Instance=new A116980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116981
{
public static readonly long[] Value={ 1L,5L,13L,11L,28L,53L,50L,53L,135L,106L,116L,253L,165L,229L,568L,244L,313L,656L,381L,575L,1123L,600L,612L,1297L,956L,871L,1735L,1130L,1102L,3025L,1288L,1314L,3169L,1620L,2671L,3582L,1954L,2149L,4729L,3064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116981Inst : IEnumerable<long>
{
public static readonly long[] Value=A116981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116981.Bytes);
public long this[int i]=>Value[i];

public static A116981Inst Instance=new A116981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116982
{
public static readonly long[] Value={ 2L,4L,2L,4L,4L,6L,6L,6L,6L,4L,4L,6L,6L,6L,2L,6L,4L,2L,6L,4L,6L,6L,8L,8L,4L,4L,2L,4L,14L,14L,14L,4L,6L,6L,10L,10L,10L,6L,6L,6L,4L,6L,6L,6L,2L,10L,10L,2L,4L,12L,12L,12L,12L,12L,12L,4L,2L,4L,6L,2L,10L,10L,6L,6L,6L,6L,6L,6L,6L,4L,10L,10L,10L,14L,14L,14L,4L,2L,4L,14L,14L,14L,6L,6L,10L,10L,2L,4L,6L,8L,8L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116982Inst : IEnumerable<long>
{
public static readonly long[] Value=A116982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116982.Bytes);
public long this[int i]=>Value[i];

public static A116982Inst Instance=new A116982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116983
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,4L,6L,11L,54L,150L,648L,5013L,9849L,19345L,1060707L,10939036L,4343045L,2498014850L,5271260976L,78029366100L,531495923280L,805809810981L,1936900666393L,28724010464057580L,29052364970866225L,75805259574286872L,7466893805506395652L,BigInteger.Parse("80374513001512054041") };
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
public class A116983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116983Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A116983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116983.Bytes);
public BigInteger this[int i]=>Value[i];

public static A116983Inst Instance=new A116983Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116984
{
public static readonly long[] Value={ 1L,3L,28L,59L,146L,643L,4004L,8651L,12655L,21306L,76573L,97879L,1838395L,1936274L,13456039L,15392313L,44240665L,59632978L,103873643L,475127550L,579001193L,24793177656L,149338067129L,174131244785L,845863046269L,1865857337323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116984Inst : IEnumerable<long>
{
public static readonly long[] Value=A116984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116984.Bytes);
public long this[int i]=>Value[i];

public static A116984Inst Instance=new A116984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116985
{
public static readonly long[] Value={ 2L,7L,65L,137L,339L,1493L,9297L,20087L,29384L,49471L,177797L,227268L,4268621L,4495889L,31243955L,35739844L,102723643L,138463487L,241187130L,1103212007L,1344399137L,57567975761L,346752253703L,404320229464L,1964033171559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116985Inst : IEnumerable<long>
{
public static readonly long[] Value=A116985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116985.Bytes);
public long this[int i]=>Value[i];

public static A116985Inst Instance=new A116985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116986
{
public static readonly long[] Value={ 1L,1L,3L,23L,443L,23131L,3732309L,2090705825L,4388282355347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116986Inst : IEnumerable<long>
{
public static readonly long[] Value=A116986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116986.Bytes);
public long this[int i]=>Value[i];

public static A116986Inst Instance=new A116986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116987
{
public static readonly long[] Value={ 2L,2L,2L,3L,1L,7L,2L,4L,1L,9L,6L,9L,14L,8L,5L,0L,14L,11L,19L,3L,20L,7L,18L,25L,5L,2L,24L,12L,5L,27L,9L,18L,0L,8L,0L,10L,26L,12L,3L,30L,21L,19L,24L,37L,27L,39L,17L,14L,36L,35L,24L,3L,32L,17L,42L,1L,47L,56L,44L,0L,11L,49L,21L,2L,55L,55L,17L,5L,61L,69L,55L,3L,14L,14L,59L,38L,22L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116987Inst : IEnumerable<long>
{
public static readonly long[] Value=A116987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116987.Bytes);
public long this[int i]=>Value[i];

public static A116987Inst Instance=new A116987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116988
{
public static readonly long[] Value={ 1L,27L,648L,10539L,149346L,1938780L,23903442L,284222502L,3292100235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116988Inst : IEnumerable<long>
{
public static readonly long[] Value=A116988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116988.Bytes);
public long this[int i]=>Value[i];

public static A116988Inst Instance=new A116988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116989
{
public static readonly BigInteger[] Value={ 1L,925L,1135716L,593223373L,130220375812L,14195655302684L,893936543319276L,36397263567477054L,1025115791220794876L,BigInteger.Parse("21899052879460199956"),BigInteger.Parse("372805053916689840596"),BigInteger.Parse("5076066733212581886566"),BigInteger.Parse("57875038239259949679248") };
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
public class A116989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116989Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A116989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116989.Bytes);
public BigInteger this[int i]=>Value[i];

public static A116989Inst Instance=new A116989Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116990
{
public static readonly long[] Value={ 1L,2L,11L,20L,40L,68L,92L,212L,236L,253L,266L,321L,328L,452L,582L,589L,596L,668L,695L,716L,782L,788L,836L,928L,932L,970L,991L,1012L,1065L,1076L,1173L,1264L,1300L,1336L,1388L,1436L,1490L,1549L,1796L,1854L,1927L,1995L,2159L,2228L,2252L,2468L,2545L,2588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116990Inst : IEnumerable<long>
{
public static readonly long[] Value=A116990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116990.Bytes);
public long this[int i]=>Value[i];

public static A116990Inst Instance=new A116990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116991
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,3L,6L,7L,8L,7L,10L,7L,12L,7L,9L,15L,16L,13L,18L,15L,10L,16L,22L,16L,24L,18L,26L,21L,28L,14L,30L,31L,22L,22L,22L,29L,36L,24L,26L,31L,40L,14L,42L,35L,33L,29L,46L,32L,48L,32L,37L,44L,52L,36L,41L,41L,43L,38L,58L,36L,60L,40L,46L,63L,51L,32L,66L,57L,49L,35L,70L,59L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116991Inst : IEnumerable<long>
{
public static readonly long[] Value=A116991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116991.Bytes);
public long this[int i]=>Value[i];

public static A116991Inst Instance=new A116991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116992
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,3L,1L,4L,1L,3L,0L,4L,3L,0L,4L,9L,6L,6L,0L,4L,10L,0L,6L,4L,9L,11L,6L,10L,0L,2L,15L,17L,6L,16L,0L,5L,0L,19L,2L,13L,14L,25L,5L,3L,13L,0L,12L,23L,23L,15L,0L,24L,28L,12L,12L,20L,20L,3L,31L,22L,31L,27L,7L,0L,32L,32L,7L,6L,37L,36L,34L,40L,14L,20L,0L,33L,0L,19L,0L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116992Inst : IEnumerable<long>
{
public static readonly long[] Value=A116992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116992.Bytes);
public long this[int i]=>Value[i];

public static A116992Inst Instance=new A116992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116993
{
public static readonly long[] Value={ 13L,1L,4L,44L,66L,484L,4444L,7326L,6666L,48884L,73326L,493284L,888888L,666666L,5426124L,4888884L,6672666L,7333326L,44888844L,73399326L,246888642L,67333266L,4073662593L,4893772884L,4533773244L,6800659866L,2715775062L,1481331852L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116993Inst : IEnumerable<long>
{
public static readonly long[] Value=A116993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116993.Bytes);
public long this[int i]=>Value[i];

public static A116993Inst Instance=new A116993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116994
{
public static readonly long[] Value={ 3L,1759L,3323L,469303L,605113L,641969L,1110587L,1426669L,11148289L,18352349L,20473721L,21820391L,24710753L,30048589L,36690923L,40785301L,97060681L,155135369L,160593239L,168132247L,361391623L,377965069L,416572171L,645803201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116994Inst : IEnumerable<long>
{
public static readonly long[] Value=A116994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116994.Bytes);
public long this[int i]=>Value[i];

public static A116994Inst Instance=new A116994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116995
{
public static readonly long[] Value={ 5L,12L,35L,70L,176L,247L,425L,532L,782L,1247L,1426L,2035L,2501L,2752L,3290L,4187L,5192L,5551L,6700L,7526L,7957L,9322L,10292L,11837L,14065L,15251L,15862L,17120L,17767L,19097L,24130L,25676L,28085L,28912L,33227L,34126L,36895L,39772L,41750L,44807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116995Inst : IEnumerable<long>
{
public static readonly long[] Value=A116995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116995.Bytes);
public long this[int i]=>Value[i];

public static A116995Inst Instance=new A116995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116996
{
public static readonly long[] Value={ 0L,1L,4L,6L,10L,15L,22L,28L,36L,45L,56L,66L,78L,91L,106L,120L,136L,153L,172L,190L,210L,231L,254L,276L,300L,325L,352L,378L,406L,435L,466L,496L,528L,561L,596L,630L,666L,703L,742L,780L,820L,861L,904L,946L,990L,1035L,1082L,1128L,1176L,1225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116996Inst : IEnumerable<long>
{
public static readonly long[] Value=A116996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116996.Bytes);
public long this[int i]=>Value[i];

public static A116996Inst Instance=new A116996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116997
{
public static readonly long[] Value={ 2L,2L,2L,3L,2L,3L,4L,5L,6L,2L,2L,2L,3L,2L,3L,3L,4L,5L,2L,6L,2L,7L,2L,8L,2L,2L,2L,3L,3L,2L,2L,4L,5L,2L,5L,2L,2L,2L,3L,2L,3L,2L,4L,2L,5L,2L,2L,2L,3L,3L,2L,4L,4L,3L,2L,3L,4L,3L,5L,4L,2L,5L,2L,2L,2L,3L,2L,3L,2L,4L,2L,3L,2L,4L,3L,4L,2L,2L,4L,4L,2L,5L,2L,2L,6L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116997Inst : IEnumerable<long>
{
public static readonly long[] Value=A116997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116997.Bytes);
public long this[int i]=>Value[i];

public static A116997Inst Instance=new A116997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116998
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,10L,12L,14L,15L,18L,20L,21L,22L,24L,26L,28L,30L,42L,60L,66L,70L,78L,84L,90L,102L,105L,110L,114L,120L,126L,130L,132L,138L,140L,150L,154L,156L,165L,168L,170L,174L,180L,182L,186L,190L,195L,198L,204L,210L,330L,390L,420L,462L,510L,546L,570L,630L,660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116998Inst : IEnumerable<long>
{
public static readonly long[] Value=A116998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116998.Bytes);
public long this[int i]=>Value[i];

public static A116998Inst Instance=new A116998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116999
{
public static readonly long[] Value={ 11L,15L,17L,23L,27L,47L,231L,457L,1249L,1529L,2343L,4693L,5939L,5997L,8367L,19855L,21295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116999Inst : IEnumerable<long>
{
public static readonly long[] Value=A116999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116999.Bytes);
public long this[int i]=>Value[i];

public static A116999Inst Instance=new A116999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117000
{
public static readonly long[] Value={ 1L,1L,-2L,1L,-4L,-2L,8L,1L,7L,-4L,-10L,-2L,-12L,8L,8L,1L,18L,7L,-18L,-4L,-16L,-10L,24L,-2L,21L,-12L,-20L,8L,-28L,8L,32L,1L,20L,18L,-32L,7L,-36L,-18L,24L,-4L,42L,-16L,-42L,-10L,-28L,24L,48L,-2L,57L,21L,-36L,-12L,-52L,-20L,40L,8L,36L,-28L,-58L,8L,-60L,32L,56L,1L,48L,20L,-66L,18L,-48L,-32L,72L,7L,74L,-36L,-42L,-18L,-80L,24L,80L,-4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117000Inst : IEnumerable<long>
{
public static readonly long[] Value=A117000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117000.Bytes);
public long this[int i]=>Value[i];

public static A117000Inst Instance=new A117000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117001
{
public static readonly long[] Value={ 0L,-1L,-4L,-1L,-6L,-4L,6L,-1L,8L,-6L,-12L,2L,-14L,6L,12L,-1L,16L,11L,-20L,-6L,-12L,-12L,22L,2L,24L,-14L,-16L,6L,-30L,22L,30L,-1L,24L,16L,-24L,11L,-38L,-20L,28L,4L,40L,-12L,-44L,-12L,-14L,22L,46L,2L,48L,29L,-32L,-14L,-54L,-16L,48L,-8L,40L,-30L,-60L,22L,-62L,30L,46L,-1L,56L,24L,-68L,16L,-44L,-38L,70L,11L,72L,-38L,-28L,-20L,-96L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117001Inst : IEnumerable<long>
{
public static readonly long[] Value=A117001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117001.Bytes);
public long this[int i]=>Value[i];

public static A117001Inst Instance=new A117001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117002
{
public static readonly long[] Value={ 1L,6L,10L,16L,18L,30L,26L,42L,37L,54L,42L,76L,50L,78L,72L,94L,66L,120L,74L,126L,104L,126L,90L,180L,103L,150L,136L,182L,114L,222L,122L,210L,168L,198L,156L,286L,146L,222L,200L,288L,162L,312L,170L,294L,258L,270L,186L,400L,201L,324L,264L,350L,210L,408L,252L,396L,296L,342L,234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117002Inst : IEnumerable<long>
{
public static readonly long[] Value=A117002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117002.Bytes);
public long this[int i]=>Value[i];

public static A117002Inst Instance=new A117002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117003
{
public static readonly long[] Value={ 1L,4L,6L,10L,10L,18L,14L,24L,21L,30L,22L,44L,26L,42L,40L,52L,34L,66L,38L,70L,56L,66L,46L,100L,55L,78L,72L,98L,58L,122L,62L,112L,88L,102L,84L,156L,74L,114L,104L,156L,82L,168L,86L,154L,138L,138L,94L,216L,105L,170L,136L,182L,106L,216L,132L,212L,152L,174L,118L,294L,122L,186L,186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117003Inst : IEnumerable<long>
{
public static readonly long[] Value=A117003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117003.Bytes);
public long this[int i]=>Value[i];

public static A117003Inst Instance=new A117003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117004
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,6L,2L,6L,5L,6L,2L,12L,2L,6L,8L,10L,2L,12L,2L,14L,8L,6L,2L,20L,7L,6L,8L,14L,2L,22L,2L,14L,8L,6L,12L,26L,2L,6L,8L,24L,2L,24L,2L,14L,18L,6L,2L,32L,9L,16L,8L,14L,2L,24L,12L,28L,8L,6L,2L,42L,2L,6L,22L,22L,12L,24L,2L,14L,8L,30L,2L,48L,2L,6L,18L,14L,16L,24L,2L,40L,17L,6L,2L,46L,12L,6L,8L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117004Inst : IEnumerable<long>
{
public static readonly long[] Value=A117004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117004.Bytes);
public long this[int i]=>Value[i];

public static A117004Inst Instance=new A117004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117005
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,2L,2L,-1L,2L,2L,-4L,2L,2L,-4L,2L,2L,-4L,2L,2L,-4L,2L,2L,-4L,-3L,2L,-4L,2L,2L,-14L,2L,2L,-4L,2L,-8L,-4L,2L,2L,-4L,-8L,2L,-4L,2L,2L,-14L,2L,2L,-4L,9L,-8L,-4L,2L,2L,-4L,-8L,16L,-4L,2L,2L,-14L,2L,2L,10L,2L,-8L,-4L,2L,2L,-4L,6L,2L,-4L,2L,2L,-14L,2L,16L,-4L,2L,-8L,5L,2L,2L,10L,-8L,2L,-4L,2L,2L,4L,16L,2L,-4L,2L,-8L,-4L,2L,16L,14L,-8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117005Inst : IEnumerable<long>
{
public static readonly long[] Value=A117005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117005.Bytes);
public long this[int i]=>Value[i];

public static A117005Inst Instance=new A117005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117006
{
public static readonly long[] Value={ 1L,0L,-6L,0L,-10L,-6L,14L,0L,15L,-10L,-22L,0L,-26L,14L,20L,0L,34L,18L,-38L,-10L,-28L,-22L,46L,0L,45L,-26L,-36L,14L,-58L,30L,62L,0L,44L,34L,-56L,18L,-74L,-38L,52L,0L,82L,-28L,-86L,-22L,-42L,46L,94L,0L,105L,50L,-68L,-26L,-106L,-36L,88L,0L,76L,-58L,-118L,30L,-122L,62L,102L,0L,104L,44L,-134L,34L,-92L,-70L,142L,18L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117006Inst : IEnumerable<long>
{
public static readonly long[] Value=A117006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117006.Bytes);
public long this[int i]=>Value[i];

public static A117006Inst Instance=new A117006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117007
{
public static readonly long[] Value={ 2L,-4L,2L,2L,-4L,2L,-8L,10L,2L,2L,-4L,-8L,2L,-4L,16L,2L,4L,-20L,2L,-4L,2L,6L,-4L,2L,2L,14L,-8L,2L,-12L,2L,-24L,16L,2L,2L,14L,16L,-8L,-4L,2L,-20L,-4L,-8L,16L,-12L,2L,2L,16L,2L,36L,-28L,-20L,-8L,14L,2L,2L,-4L,-20L,2L,-4L,2L,2L,12L,2L,16L,-4L,36L,-8L,-4L,-36L,-24L,-14L,38L,-20L,-4L,2L,2L,16L,16L,2L,14L,2L,-8L,4L,-20L,16L,-4L,-8L,-36L,14L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117007Inst : IEnumerable<long>
{
public static readonly long[] Value=A117007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117007.Bytes);
public long this[int i]=>Value[i];

public static A117007Inst Instance=new A117007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117008
{
public static readonly long[] Value={ 1L,-2L,1L,1L,-2L,1L,-4L,5L,1L,1L,-2L,-4L,1L,-2L,8L,1L,2L,-10L,1L,-2L,1L,3L,-2L,1L,1L,7L,-4L,1L,-6L,1L,-12L,8L,1L,1L,7L,8L,-4L,-2L,1L,-10L,-2L,-4L,8L,-6L,1L,1L,8L,1L,18L,-14L,-10L,-4L,7L,1L,1L,-2L,-10L,1L,-2L,1L,1L,6L,1L,8L,-2L,18L,-4L,-2L,-18L,-12L,-7L,19L,-10L,-2L,1L,1L,8L,8L,1L,7L,1L,-4L,2L,-10L,8L,-2L,-4L,-18L,7L,1L,1L,-6L,1L,1L,10L,-12L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117008Inst : IEnumerable<long>
{
public static readonly long[] Value=A117008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117008.Bytes);
public long this[int i]=>Value[i];

public static A117008Inst Instance=new A117008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117009
{
public static readonly long[] Value={ 1L,-1L,2L,-3L,-4L,2L,9L,-4L,-8L,2L,5L,2L,2L,0L,2L,-9L,-4L,2L,-8L,14L,16L,-11L,-4L,-8L,2L,-4L,-20L,16L,19L,2L,2L,-4L,2L,-8L,-16L,2L,19L,-8L,-8L,2L,-4L,16L,2L,16L,2L,-17L,14L,-24L,-16L,-4L,2L,2L,-4L,26L,2L,7L,2L,2L,16L,-20L,-24L,-4L,16L,-8L,-24L,2L,25L,-4L,-8L,16L,8L,2L,2L,8L,2L,2L,-32L,2L,17L,-4L,2L,-20L,14L,-32L,2L,-4L,-24L,36L,16L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117009Inst : IEnumerable<long>
{
public static readonly long[] Value=A117009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117009.Bytes);
public long this[int i]=>Value[i];

public static A117009Inst Instance=new A117009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117010
{
public static readonly long[] Value={ 0L,1L,3L,5L,11L,23L,29L,59L,119L,179L,209L,359L,419L,839L,1259L,1679L,2519L,4619L,7559L,9239L,13859L,18479L,27719L,55439L,83159L,110879L,120119L,180179L,240239L,360359L,720719L,1081079L,1441439L,1801799L,2042039L,2882879L,3063059L,4084079L,5405399L,6126119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117010Inst : IEnumerable<long>
{
public static readonly long[] Value=A117010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117010.Bytes);
public long this[int i]=>Value[i];

public static A117010Inst Instance=new A117010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117011
{
public static readonly BigInteger[] Value={ 0L,5L,2561L,687463202817L,BigInteger.Parse("25362915524915764560280676204545"),BigInteger.Parse("2157638231708538191934637891565042782652856782390367212752413267066881") };
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
public class A117011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117011Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117011.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117011Inst Instance=new A117011Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117012
{
public static readonly long[] Value={ 3L,17L,47L,107L,173L,269L,503L,641L,809L,983L,1187L,1637L,2441L,2753L,4157L,4547L,4967L,5393L,5849L,6311L,6803L,7829L,8363L,9497L,11981L,12653L,13331L,14753L,15497L,17027L,22943L,26723L,29753L,31859L,32933L,38609L,39791L,42221L,47297L,49943L,58313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117012Inst : IEnumerable<long>
{
public static readonly long[] Value=A117012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117012.Bytes);
public long this[int i]=>Value[i];

public static A117012Inst Instance=new A117012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117013
{
public static readonly long[] Value={ 7L,0L,8L,0L,7L,3L,4L,1L,8L,2L,7L,3L,5L,7L,1L,1L,9L,3L,4L,9L,8L,7L,8L,4L,1L,1L,4L,7L,5L,0L,3L,8L,1L,0L,9L,4L,8L,8L,3L,0L,0L,0L,3L,8L,5L,5L,3L,7L,7L,7L,2L,4L,4L,5L,3L,7L,7L,5L,7L,4L,9L,8L,6L,8L,9L,0L,9L,8L,2L,4L,6L,8L,0L,6L,2L,0L,3L,9L,5L,8L,4L,5L,3L,7L,2L,6L,5L,8L,8L,8L,9L,3L,0L,0L,8L,4L,5L,7L,0L,1L,8L,3L,6L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117013Inst : IEnumerable<long>
{
public static readonly long[] Value=A117013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117013.Bytes);
public long this[int i]=>Value[i];

public static A117013Inst Instance=new A117013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117014
{
public static readonly long[] Value={ 5L,9L,5L,8L,2L,3L,2L,3L,6L,5L,9L,0L,9L,5L,5L,5L,7L,4L,4L,6L,4L,1L,9L,0L,5L,4L,0L,5L,2L,0L,6L,9L,6L,6L,7L,9L,7L,5L,5L,1L,8L,8L,9L,7L,9L,5L,3L,5L,7L,1L,1L,9L,0L,3L,2L,1L,6L,5L,9L,3L,1L,2L,2L,1L,8L,5L,8L,2L,7L,3L,0L,0L,8L,0L,1L,6L,7L,6L,1L,3L,3L,7L,3L,3L,6L,5L,9L,2L,6L,4L,4L,4L,3L,9L,2L,7L,0L,5L,5L,9L,5L,3L,1L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117014Inst : IEnumerable<long>
{
public static readonly long[] Value=A117014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117014.Bytes);
public long this[int i]=>Value[i];

public static A117014Inst Instance=new A117014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117015
{
public static readonly long[] Value={ 5L,0L,1L,3L,6L,7L,9L,6L,5L,6L,6L,5L,6L,1L,9L,7L,0L,4L,1L,6L,8L,8L,8L,8L,0L,9L,1L,8L,6L,3L,1L,6L,2L,2L,9L,7L,2L,0L,4L,9L,8L,3L,6L,8L,5L,9L,5L,6L,9L,9L,5L,1L,6L,4L,5L,0L,1L,6L,9L,8L,7L,0L,1L,4L,0L,9L,3L,9L,0L,2L,6L,1L,0L,8L,5L,7L,1L,4L,1L,6L,2L,0L,4L,9L,6L,1L,2L,0L,5L,8L,2L,2L,4L,3L,1L,2L,2L,1L,2L,9L,0L,4L,3L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117015Inst : IEnumerable<long>
{
public static readonly long[] Value=A117015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117015.Bytes);
public long this[int i]=>Value[i];

public static A117015Inst Instance=new A117015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117016
{
public static readonly long[] Value={ 4L,2L,1L,8L,8L,6L,5L,9L,5L,8L,1L,9L,7L,8L,0L,6L,5L,5L,4L,4L,5L,5L,0L,9L,0L,4L,9L,7L,5L,6L,6L,5L,2L,7L,8L,8L,9L,7L,7L,4L,0L,6L,4L,2L,1L,4L,2L,2L,3L,6L,1L,3L,0L,9L,8L,6L,4L,7L,7L,6L,9L,6L,4L,9L,7L,0L,1L,1L,8L,2L,1L,4L,7L,4L,9L,4L,2L,2L,7L,9L,5L,4L,2L,8L,3L,1L,1L,9L,1L,3L,4L,8L,3L,3L,5L,9L,0L,4L,8L,3L,2L,4L,6L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117016Inst : IEnumerable<long>
{
public static readonly long[] Value=A117016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117016.Bytes);
public long this[int i]=>Value[i];

public static A117016Inst Instance=new A117016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117017
{
public static readonly long[] Value={ 9L,1L,7L,3L,1L,7L,2L,7L,5L,9L,7L,8L,1L,0L,8L,0L,8L,1L,9L,0L,4L,2L,7L,1L,8L,3L,5L,3L,6L,0L,2L,6L,0L,3L,0L,8L,3L,1L,6L,8L,3L,1L,3L,8L,2L,5L,3L,1L,2L,3L,4L,2L,3L,0L,4L,0L,7L,3L,0L,6L,7L,8L,3L,5L,6L,5L,5L,6L,3L,1L,6L,8L,8L,5L,4L,3L,4L,9L,8L,5L,0L,9L,5L,4L,3L,7L,9L,0L,9L,0L,0L,6L,8L,9L,0L,4L,8L,3L,9L,7L,3L,5L,6L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117017Inst : IEnumerable<long>
{
public static readonly long[] Value=A117017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117017.Bytes);
public long this[int i]=>Value[i];

public static A117017Inst Instance=new A117017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117018
{
public static readonly long[] Value={ 9L,4L,4L,0L,8L,9L,2L,4L,1L,2L,4L,3L,0L,6L,4L,7L,7L,2L,7L,9L,6L,4L,8L,9L,9L,0L,5L,7L,9L,1L,4L,2L,1L,7L,0L,7L,9L,8L,6L,1L,7L,7L,2L,7L,1L,6L,6L,4L,9L,5L,9L,5L,5L,3L,6L,9L,8L,0L,7L,8L,5L,2L,2L,8L,7L,1L,5L,7L,0L,0L,6L,4L,4L,1L,1L,9L,3L,4L,5L,7L,9L,1L,1L,8L,7L,4L,5L,9L,3L,6L,2L,5L,0L,7L,8L,7L,8L,7L,6L,7L,4L,2L,8L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117018Inst : IEnumerable<long>
{
public static readonly long[] Value=A117018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117018.Bytes);
public long this[int i]=>Value[i];

public static A117018Inst Instance=new A117018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117019
{
public static readonly long[] Value={ 9L,5L,7L,7L,6L,6L,8L,1L,7L,1L,2L,1L,0L,0L,8L,8L,8L,6L,9L,1L,0L,3L,2L,4L,3L,7L,6L,2L,9L,8L,0L,4L,8L,6L,6L,9L,0L,5L,2L,6L,0L,3L,8L,3L,7L,2L,9L,5L,5L,6L,9L,1L,9L,1L,4L,8L,9L,1L,5L,6L,2L,8L,7L,2L,5L,6L,7L,6L,4L,7L,7L,9L,9L,6L,7L,8L,6L,4L,1L,1L,5L,8L,8L,1L,0L,3L,0L,2L,8L,3L,1L,8L,2L,6L,2L,6L,1L,6L,6L,7L,4L,9L,7L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117019Inst : IEnumerable<long>
{
public static readonly long[] Value=A117019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117019.Bytes);
public long this[int i]=>Value[i];

public static A117019Inst Instance=new A117019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117020
{
public static readonly long[] Value={ 9L,6L,6L,0L,6L,8L,2L,9L,4L,2L,8L,2L,2L,8L,4L,8L,0L,7L,5L,9L,2L,8L,3L,4L,0L,0L,7L,7L,9L,0L,8L,2L,8L,4L,8L,7L,3L,4L,8L,6L,9L,9L,5L,7L,0L,0L,1L,3L,8L,6L,3L,0L,2L,1L,9L,1L,1L,7L,3L,8L,5L,9L,7L,3L,1L,0L,1L,5L,9L,6L,0L,8L,6L,2L,2L,5L,3L,7L,7L,8L,8L,9L,6L,5L,1L,7L,7L,2L,1L,6L,1L,1L,4L,9L,4L,7L,5L,6L,9L,5L,8L,0L,4L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117020Inst : IEnumerable<long>
{
public static readonly long[] Value=A117020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117020.Bytes);
public long this[int i]=>Value[i];

public static A117020Inst Instance=new A117020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117021
{
public static readonly long[] Value={ 1L,4L,1L,2L,2L,8L,2L,9L,2L,7L,4L,3L,7L,3L,9L,1L,9L,1L,4L,6L,0L,9L,3L,3L,5L,0L,0L,4L,5L,4L,1L,6L,2L,4L,9L,0L,2L,3L,7L,2L,2L,9L,5L,1L,1L,4L,3L,5L,0L,8L,1L,7L,2L,0L,8L,0L,5L,3L,2L,7L,2L,6L,0L,6L,4L,9L,9L,2L,7L,9L,0L,2L,9L,7L,5L,1L,1L,2L,6L,3L,5L,4L,5L,5L,4L,8L,7L,1L,9L,1L,4L,7L,0L,4L,6L,8L,4L,7L,7L,9L,9L,6L,5L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117021Inst : IEnumerable<long>
{
public static readonly long[] Value=A117021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117021.Bytes);
public long this[int i]=>Value[i];

public static A117021Inst Instance=new A117021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117022
{
public static readonly long[] Value={ 1L,6L,7L,8L,3L,5L,0L,1L,1L,8L,9L,4L,0L,5L,9L,4L,0L,5L,4L,4L,9L,1L,3L,8L,7L,3L,0L,7L,5L,8L,2L,3L,5L,3L,1L,9L,8L,3L,1L,8L,5L,6L,2L,3L,4L,9L,0L,4L,1L,9L,2L,4L,9L,0L,9L,5L,2L,4L,2L,6L,5L,8L,7L,5L,4L,9L,3L,9L,9L,4L,7L,5L,5L,7L,1L,3L,6L,6L,5L,6L,8L,5L,8L,4L,4L,3L,1L,2L,2L,7L,9L,2L,4L,4L,2L,5L,3L,8L,0L,1L,7L,7L,0L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117022Inst : IEnumerable<long>
{
public static readonly long[] Value=A117022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117022.Bytes);
public long this[int i]=>Value[i];

public static A117022Inst Instance=new A117022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117023
{
public static readonly long[] Value={ 1L,9L,9L,4L,5L,4L,3L,0L,6L,7L,1L,3L,1L,1L,2L,9L,5L,9L,6L,0L,1L,2L,5L,2L,3L,0L,9L,0L,4L,4L,0L,8L,2L,8L,4L,2L,5L,0L,9L,5L,4L,7L,7L,5L,4L,0L,8L,0L,3L,4L,4L,8L,3L,0L,4L,5L,4L,0L,7L,9L,4L,8L,7L,0L,3L,1L,4L,6L,2L,5L,7L,9L,7L,2L,2L,8L,3L,6L,1L,9L,7L,9L,8L,2L,2L,6L,8L,4L,8L,4L,0L,1L,5L,1L,3L,8L,2L,1L,4L,0L,2L,3L,7L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117023Inst : IEnumerable<long>
{
public static readonly long[] Value=A117023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117023.Bytes);
public long this[int i]=>Value[i];

public static A117023Inst Instance=new A117023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117024
{
public static readonly long[] Value={ 2L,3L,7L,0L,3L,0L,5L,2L,1L,9L,2L,4L,2L,3L,1L,7L,0L,8L,2L,3L,0L,4L,1L,2L,5L,5L,2L,6L,1L,8L,1L,1L,6L,6L,8L,3L,2L,7L,2L,1L,5L,1L,7L,7L,4L,1L,8L,4L,2L,1L,2L,1L,7L,7L,6L,8L,6L,0L,3L,2L,4L,3L,3L,9L,9L,9L,3L,2L,9L,4L,6L,0L,0L,3L,2L,9L,7L,0L,2L,0L,4L,7L,0L,6L,7L,9L,7L,8L,7L,7L,0L,1L,0L,6L,5L,1L,5L,2L,0L,6L,4L,3L,4L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117024Inst : IEnumerable<long>
{
public static readonly long[] Value=A117024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117024.Bytes);
public long this[int i]=>Value[i];

public static A117024Inst Instance=new A117024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117025
{
public static readonly long[] Value={ 2L,3L,1L,9L,7L,7L,6L,8L,2L,4L,7L,1L,5L,8L,5L,3L,1L,7L,3L,9L,5L,6L,5L,9L,0L,3L,7L,7L,5L,0L,3L,2L,6L,6L,8L,1L,3L,2L,5L,4L,9L,0L,4L,7L,7L,2L,3L,7L,6L,2L,6L,2L,8L,3L,3L,4L,5L,4L,0L,5L,4L,9L,8L,4L,8L,6L,5L,1L,2L,1L,1L,4L,8L,3L,1L,4L,6L,9L,2L,1L,4L,2L,4L,2L,6L,4L,9L,8L,4L,4L,9L,4L,0L,7L,1L,5L,3L,8L,9L,0L,0L,0L,0L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117025Inst : IEnumerable<long>
{
public static readonly long[] Value=A117025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117025.Bytes);
public long this[int i]=>Value[i];

public static A117025Inst Instance=new A117025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117026
{
public static readonly long[] Value={ 4L,3L,1L,0L,7L,5L,9L,5L,0L,6L,4L,5L,5L,9L,2L,3L,2L,4L,6L,6L,6L,6L,5L,8L,6L,3L,6L,1L,0L,7L,7L,8L,0L,8L,0L,2L,9L,8L,6L,8L,3L,5L,7L,2L,8L,1L,8L,5L,6L,7L,4L,6L,0L,3L,3L,6L,2L,2L,6L,4L,7L,7L,0L,4L,4L,3L,5L,0L,2L,3L,1L,7L,1L,6L,3L,4L,8L,8L,6L,2L,7L,2L,0L,1L,8L,7L,0L,5L,3L,3L,7L,2L,1L,4L,3L,8L,1L,5L,1L,3L,0L,6L,8L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117026Inst : IEnumerable<long>
{
public static readonly long[] Value=A117026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117026.Bytes);
public long this[int i]=>Value[i];

public static A117026Inst Instance=new A117026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117027
{
public static readonly long[] Value={ -1L,-12L,-48L,152L,102L,-60L,-24L,-72L,-24L,-60L,-24L,1942L,896L,-1124L,522L,-1938L,554L,1376L,-806L,-96L,-24L,1716L,4598L,-48L,2886L,-2348L,-96L,2380L,4908L,1246L,-4158L,-180L,-1526L,1442L,-1882L,-4986L,-5214L,-72L,-96L,-5694L,-2014L,-84L,-2058L,8232L,-4324L,-24L,-84L,-14076L,-4844L,-7398L,12274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117027Inst : IEnumerable<long>
{
public static readonly long[] Value=A117027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117027.Bytes);
public long this[int i]=>Value[i];

public static A117027Inst Instance=new A117027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117028
{
public static readonly long[] Value={ 0L,7L,4L,9L,6L,0L,8L,5L,4L,5L,6L,0L,4L,9L,5L,5L,0L,6L,1L,3L,8L,3L,8L,9L,4L,5L,4L,2L,5L,9L,4L,0L,4L,6L,9L,6L,5L,9L,4L,8L,7L,4L,5L,4L,0L,4L,6L,5L,3L,5L,8L,7L,3L,3L,5L,4L,1L,5L,5L,6L,7L,5L,7L,1L,2L,4L,2L,2L,6L,9L,7L,6L,6L,2L,2L,1L,3L,3L,1L,3L,2L,3L,4L,3L,0L,3L,6L,4L,8L,9L,8L,8L,7L,9L,6L,7L,9L,4L,2L,7L,9L,3L,6L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117028Inst : IEnumerable<long>
{
public static readonly long[] Value=A117028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117028.Bytes);
public long this[int i]=>Value[i];

public static A117028Inst Instance=new A117028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117029
{
public static readonly long[] Value={ 1L,7L,2L,6L,0L,3L,7L,4L,6L,2L,6L,9L,0L,9L,1L,6L,7L,8L,5L,1L,3L,4L,1L,0L,9L,7L,5L,8L,6L,3L,9L,0L,9L,0L,6L,9L,8L,4L,0L,1L,0L,8L,4L,0L,8L,8L,9L,6L,4L,0L,4L,8L,0L,4L,9L,0L,8L,5L,3L,6L,3L,1L,5L,6L,6L,7L,9L,1L,5L,2L,2L,6L,8L,2L,1L,6L,4L,8L,2L,8L,4L,2L,2L,5L,0L,7L,0L,8L,6L,9L,0L,0L,0L,5L,7L,1L,4L,6L,8L,9L,8L,6L,2L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117029Inst : IEnumerable<long>
{
public static readonly long[] Value=A117029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117029.Bytes);
public long this[int i]=>Value[i];

public static A117029Inst Instance=new A117029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117030
{
public static readonly BigInteger[] Value={ 1L,1L,1L,0L,-2L,-3L,3L,-10L,-28L,279L,-7803L,-2177000L,16987130758L,-36980983660158439L,BigInteger.Parse("-628200804994572838287982201"),BigInteger.Parse("23231483704802676028750227275477328286998042"),BigInteger.Parse("-14594036764575342428539025427350979161630036659925283421091485142638200") };
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
public class A117030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117030Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117030.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117030Inst Instance=new A117030Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117031
{
public static readonly long[] Value={ 5L,7L,9L,3L,6L,1L,7L,0L,0L,7L,8L,3L,1L,2L,5L,4L,5L,7L,0L,2L,1L,5L,6L,5L,4L,5L,6L,1L,0L,7L,2L,5L,9L,3L,2L,1L,9L,8L,4L,6L,2L,6L,0L,0L,6L,3L,9L,9L,3L,0L,7L,0L,3L,0L,2L,4L,7L,1L,1L,9L,0L,3L,6L,2L,5L,1L,8L,7L,7L,2L,0L,5L,8L,2L,8L,6L,3L,3L,6L,8L,8L,5L,3L,0L,4L,3L,6L,4L,5L,5L,0L,8L,4L,5L,8L,4L,3L,9L,4L,7L,6L,3L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117031Inst : IEnumerable<long>
{
public static readonly long[] Value=A117031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117031.Bytes);
public long this[int i]=>Value[i];

public static A117031Inst Instance=new A117031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117032
{
public static readonly long[] Value={ 1L,3L,3L,4L,0L,2L,9L,6L,1L,5L,6L,7L,4L,9L,0L,1L,4L,0L,0L,6L,5L,2L,3L,3L,2L,1L,8L,2L,1L,0L,3L,0L,6L,6L,0L,8L,1L,2L,5L,3L,8L,4L,2L,8L,5L,0L,7L,0L,0L,9L,7L,8L,2L,2L,1L,7L,2L,5L,6L,7L,1L,6L,0L,0L,5L,0L,2L,0L,7L,5L,7L,3L,7L,4L,5L,8L,7L,4L,7L,6L,2L,5L,7L,9L,5L,5L,3L,4L,7L,4L,2L,3L,8L,6L,9L,1L,0L,2L,8L,4L,2L,8L,3L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117032Inst : IEnumerable<long>
{
public static readonly long[] Value=A117032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117032.Bytes);
public long this[int i]=>Value[i];

public static A117032Inst Instance=new A117032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117033
{
public static readonly long[] Value={ 2L,9L,1L,9L,2L,6L,5L,8L,1L,7L,2L,6L,4L,2L,8L,8L,0L,6L,5L,0L,1L,2L,1L,5L,8L,8L,5L,2L,4L,9L,6L,1L,8L,9L,0L,5L,1L,1L,6L,9L,9L,9L,6L,1L,4L,4L,6L,2L,2L,2L,7L,5L,5L,4L,6L,2L,2L,4L,2L,5L,0L,1L,3L,1L,0L,9L,0L,1L,7L,5L,3L,1L,9L,3L,7L,9L,6L,0L,4L,1L,5L,4L,6L,2L,7L,3L,4L,1L,1L,1L,0L,6L,9L,9L,1L,5L,4L,2L,9L,8L,1L,6L,3L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117033Inst : IEnumerable<long>
{
public static readonly long[] Value=A117033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117033.Bytes);
public long this[int i]=>Value[i];

public static A117033Inst Instance=new A117033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117034
{
public static readonly long[] Value={ 1L,5L,7L,7L,2L,8L,6L,0L,5L,2L,5L,0L,9L,9L,3L,4L,2L,3L,7L,3L,2L,8L,0L,9L,2L,5L,6L,8L,9L,9L,4L,1L,7L,1L,2L,7L,2L,0L,0L,8L,1L,3L,0L,4L,1L,3L,0L,9L,5L,4L,4L,5L,8L,8L,5L,4L,9L,0L,5L,1L,4L,5L,8L,3L,0L,3L,7L,4L,2L,9L,9L,6L,7L,0L,2L,5L,7L,0L,5L,1L,8L,2L,8L,1L,3L,9L,0L,2L,7L,2L,2L,2L,6L,4L,6L,4L,1L,6L,6L,4L,6L,4L,8L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117034Inst : IEnumerable<long>
{
public static readonly long[] Value=A117034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117034.Bytes);
public long this[int i]=>Value[i];

public static A117034Inst Instance=new A117034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117035
{
public static readonly long[] Value={ 0L,8L,5L,2L,2L,1L,1L,2L,9L,1L,1L,8L,4L,7L,7L,3L,1L,7L,1L,7L,1L,3L,1L,9L,8L,6L,2L,3L,6L,2L,4L,0L,0L,1L,0L,7L,4L,3L,8L,9L,8L,2L,9L,1L,4L,8L,8L,1L,4L,5L,0L,2L,7L,3L,7L,4L,6L,5L,4L,8L,7L,2L,7L,6L,2L,7L,4L,2L,5L,3L,2L,4L,9L,6L,1L,6L,3L,4L,9L,9L,2L,9L,7L,5L,0L,8L,0L,2L,8L,0L,3L,6L,4L,1L,4L,3L,0L,7L,2L,5L,3L,7L,0L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117035Inst : IEnumerable<long>
{
public static readonly long[] Value=A117035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117035.Bytes);
public long this[int i]=>Value[i];

public static A117035Inst Instance=new A117035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117036
{
public static readonly long[] Value={ 0L,4L,6L,0L,4L,5L,1L,7L,2L,5L,7L,1L,3L,9L,9L,7L,5L,9L,5L,0L,7L,3L,8L,3L,8L,2L,9L,5L,1L,7L,9L,3L,8L,5L,5L,2L,1L,0L,5L,5L,7L,0L,7L,0L,7L,2L,0L,9L,5L,9L,3L,5L,3L,6L,0L,9L,7L,5L,5L,6L,3L,7L,2L,2L,3L,4L,7L,1L,9L,3L,3L,8L,5L,5L,9L,1L,5L,2L,1L,4L,0L,3L,3L,2L,7L,6L,3L,9L,4L,6L,6L,1L,0L,1L,0L,7L,0L,2L,8L,4L,8L,8L,5L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117036Inst : IEnumerable<long>
{
public static readonly long[] Value=A117036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117036.Bytes);
public long this[int i]=>Value[i];

public static A117036Inst Instance=new A117036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117037
{
public static readonly long[] Value={ 7L,3L,5L,0L,5L,2L,5L,8L,7L,1L,4L,4L,7L,1L,5L,5L,9L,7L,3L,2L,0L,9L,2L,6L,1L,0L,3L,5L,7L,3L,4L,7L,4L,1L,0L,3L,8L,9L,1L,7L,5L,2L,2L,9L,1L,7L,6L,1L,9L,4L,9L,8L,7L,4L,6L,9L,4L,8L,3L,7L,8L,5L,2L,3L,7L,8L,4L,5L,2L,7L,7L,7L,6L,6L,6L,2L,9L,7L,8L,0L,4L,0L,3L,5L,9L,6L,3L,2L,3L,9L,3L,8L,5L,2L,3L,8L,3L,1L,9L,8L,5L,5L,8L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117037Inst : IEnumerable<long>
{
public static readonly long[] Value=A117037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117037.Bytes);
public long this[int i]=>Value[i];

public static A117037Inst Instance=new A117037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117038
{
public static readonly long[] Value={ 8L,1L,4L,4L,7L,7L,2L,1L,6L,6L,9L,9L,5L,1L,2L,1L,2L,5L,4L,4L,5L,8L,2L,8L,7L,6L,3L,0L,1L,7L,8L,6L,2L,8L,9L,7L,1L,0L,6L,7L,2L,0L,7L,4L,7L,1L,6L,0L,7L,2L,7L,8L,3L,4L,3L,2L,5L,9L,0L,6L,3L,7L,4L,3L,0L,8L,1L,5L,9L,6L,2L,8L,0L,8L,5L,6L,2L,6L,1L,5L,7L,2L,0L,9L,2L,0L,8L,8L,9L,3L,0L,3L,1L,2L,6L,8L,0L,8L,3L,7L,4L,3L,0L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117038Inst : IEnumerable<long>
{
public static readonly long[] Value=A117038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117038.Bytes);
public long this[int i]=>Value[i];

public static A117038Inst Instance=new A117038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117039
{
public static readonly long[] Value={ 8L,5L,7L,3L,5L,2L,0L,7L,8L,8L,7L,1L,1L,6L,9L,2L,3L,7L,7L,5L,7L,4L,1L,4L,2L,0L,8L,2L,8L,4L,3L,5L,9L,0L,0L,6L,6L,3L,3L,2L,0L,4L,7L,6L,5L,5L,9L,5L,4L,2L,0L,6L,7L,0L,3L,4L,1L,8L,1L,3L,6L,3L,9L,0L,7L,7L,1L,3L,9L,2L,9L,8L,9L,9L,4L,8L,5L,1L,5L,0L,6L,6L,0L,3L,6L,6L,7L,4L,6L,9L,9L,0L,0L,4L,2L,2L,2L,9L,5L,4L,6L,5L,3L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117039Inst : IEnumerable<long>
{
public static readonly long[] Value=A117039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117039.Bytes);
public long this[int i]=>Value[i];

public static A117039Inst Instance=new A117039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117040
{
public static readonly long[] Value={ 8L,8L,4L,1L,5L,2L,8L,7L,6L,5L,0L,1L,7L,7L,9L,7L,4L,3L,2L,5L,2L,5L,9L,2L,6L,7L,1L,5L,1L,7L,5L,6L,0L,2L,1L,9L,1L,8L,7L,1L,6L,6L,4L,3L,9L,1L,9L,3L,9L,8L,9L,1L,2L,4L,9L,6L,6L,2L,8L,0L,5L,6L,8L,3L,4L,1L,0L,1L,3L,1L,6L,0L,0L,3L,5L,9L,6L,0L,1L,8L,7L,6L,4L,0L,3L,6L,8L,0L,0L,2L,6L,6L,3L,6L,3L,0L,9L,3L,7L,7L,4L,0L,7L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117040Inst : IEnumerable<long>
{
public static readonly long[] Value=A117040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117040.Bytes);
public long this[int i]=>Value[i];

public static A117040Inst Instance=new A117040Inst();

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