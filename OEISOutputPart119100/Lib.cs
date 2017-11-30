using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A153064
{
public static readonly long[] Value={ 2L,4L,15L,-32543L,1059046848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153064Inst : IEnumerable<long>
{
public static readonly long[] Value=A153064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153064.Bytes);
public long this[int i]=>Value[i];

public static A153064Inst Instance=new A153064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153065
{
public static readonly long[] Value={ 3L,5L,11L,19L,23L,31L,43L,47L,53L,59L,61L,73L,101L,103L,149L,151L,157L,167L,173L,179L,181L,211L,223L,227L,251L,269L,307L,313L,331L,347L,359L,373L,379L,389L,401L,409L,419L,421L,431L,433L,439L,479L,487L,503L,509L,571L,577L,593L,601L,659L,691L,709L,773L,811L,839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153065Inst : IEnumerable<long>
{
public static readonly long[] Value=A153065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153065.Bytes);
public long this[int i]=>Value[i];

public static A153065Inst Instance=new A153065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153066
{
public static readonly long[] Value={ 0L,1L,3L,1L,1L,2L,1L,17L,1L,10L,1L,1L,5L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,2L,4L,1L,1L,1L,10L,1L,2L,1L,1L,1L,6L,1L,12L,2L,14L,1L,1L,1L,3L,3L,1L,1L,3L,1L,1L,12L,3L,1L,1L,1L,2L,1L,1L,6L,3L,1L,1L,4L,2L,1L,12L,140L,1L,6L,3L,3L,1L,2L,1100L,4L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153066Inst : IEnumerable<long>
{
public static readonly long[] Value=A153066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153066.Bytes);
public long this[int i]=>Value[i];

public static A153066Inst Instance=new A153066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153067
{
public static readonly long[] Value={ 0L,1L,0L,1L,3L,4L,7L,18L,25L,443L,468L,5123L,5591L,10714L,59161L,69875L,129036L,327947L,456983L,784930L,1241913L,2026843L,5295599L,12618041L,17913640L,30531681L,48445321L,78977002L,206399325L,904574302L,1110973627L,2015547929L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153067Inst : IEnumerable<long>
{
public static readonly long[] Value=A153067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153067.Bytes);
public long this[int i]=>Value[i];

public static A153067Inst Instance=new A153067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153068
{
public static readonly long[] Value={ 1L,0L,1L,1L,4L,5L,9L,23L,32L,567L,599L,6557L,7156L,13713L,75721L,89434L,165155L,419744L,584899L,1004643L,1589542L,2594185L,6777912L,16150009L,22927921L,39077930L,62005851L,101083781L,264173413L,1157777433L,1421950846L,2579728279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153068Inst : IEnumerable<long>
{
public static readonly long[] Value=A153068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153068.Bytes);
public long this[int i]=>Value[i];

public static A153068Inst Instance=new A153068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153069
{
public static readonly long[] Value={ 0L,1L,0L,1L,10L,11L,98L,109L,9690L,38869L,48559L,87428L,660555L,14619638L,15280193L,45180024L,150820265L,3966506914L,4117327179L,49257105883L,53374433062L,583001436503L,636375869565L,6310384262588L,19567528657329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153069Inst : IEnumerable<long>
{
public static readonly long[] Value=A153069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153069.Bytes);
public long this[int i]=>Value[i];

public static A153069Inst Instance=new A153069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153070
{
public static readonly long[] Value={ 1L,0L,1L,1L,11L,12L,107L,119L,10579L,42435L,53014L,95449L,721157L,15960903L,16682060L,49325023L,164657129L,4330410377L,4495067506L,53776152943L,58271220449L,636488357433L,694759577882L,6889324558371L,21362733252995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153070Inst : IEnumerable<long>
{
public static readonly long[] Value=A153070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153070.Bytes);
public long this[int i]=>Value[i];

public static A153070Inst Instance=new A153070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153071
{
public static readonly long[] Value={ 9L,6L,8L,9L,4L,6L,1L,4L,6L,2L,5L,9L,3L,6L,9L,3L,8L,0L,4L,8L,3L,6L,3L,4L,8L,4L,5L,8L,4L,6L,9L,1L,8L,6L,0L,0L,0L,6L,9L,5L,4L,0L,2L,6L,7L,6L,8L,3L,9L,0L,9L,6L,1L,5L,4L,4L,2L,0L,1L,6L,8L,1L,5L,7L,4L,3L,9L,4L,9L,8L,4L,1L,1L,7L,0L,8L,0L,3L,3L,1L,3L,6L,7L,3L,9L,5L,9L,4L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153071Inst : IEnumerable<long>
{
public static readonly long[] Value=A153071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153071.Bytes);
public long this[int i]=>Value[i];

public static A153071Inst Instance=new A153071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153072
{
public static readonly long[] Value={ 0L,1L,31L,4L,1L,18L,21L,1L,1L,2L,1L,2L,1L,3L,6L,3L,28L,1L,3L,2L,1L,2L,21L,1L,1L,32L,1L,1L,1L,5L,3L,1L,2L,1L,27L,11L,1L,2L,1L,5L,1L,3L,4L,3L,1L,4L,1L,1L,2L,1L,9L,8L,1L,2L,2L,1L,14L,2L,1L,7L,2L,2L,1L,20L,2L,1L,5L,10L,1L,4L,2L,2L,1L,2L,106L,4L,1L,1L,1L,1L,1L,10L,9L,3L,3L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153072Inst : IEnumerable<long>
{
public static readonly long[] Value=A153072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153072.Bytes);
public long this[int i]=>Value[i];

public static A153072Inst Instance=new A153072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153073
{
public static readonly long[] Value={ 0L,1L,0L,1L,31L,125L,156L,2933L,61749L,64682L,126431L,317544L,443975L,1205494L,1649469L,6153901L,38572875L,121872526L,3451003603L,3572876129L,14169631990L,31912140109L,46081772099L,124075684307L,2651671142546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153073Inst : IEnumerable<long>
{
public static readonly long[] Value=A153073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153073.Bytes);
public long this[int i]=>Value[i];

public static A153073Inst Instance=new A153073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153074
{
public static readonly long[] Value={ 1L,0L,1L,1L,32L,129L,161L,3027L,63728L,66755L,130483L,327721L,458204L,1244129L,1702333L,6351128L,39809101L,125778431L,3561605169L,3687383600L,14623755969L,32934895538L,47558651507L,128052198552L,2736654821099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153074Inst : IEnumerable<long>
{
public static readonly long[] Value=A153074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153074.Bytes);
public long this[int i]=>Value[i];

public static A153074Inst Instance=new A153074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153075
{
public static readonly long[] Value={ 3L,5L,11L,13L,29L,31L,43L,83L,97L,113L,127L,149L,157L,173L,191L,193L,223L,311L,373L,467L,487L,499L,557L,607L,647L,653L,673L,677L,739L,787L,821L,829L,881L,883L,977L,991L,1051L,1217L,1291L,1373L,1427L,1429L,1471L,1583L,1597L,1607L,1609L,1693L,1811L,1877L,1951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153075Inst : IEnumerable<long>
{
public static readonly long[] Value=A153075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153075.Bytes);
public long this[int i]=>Value[i];

public static A153075Inst Instance=new A153075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153076
{
public static readonly BigInteger[] Value={ 5L,29L,104L,1538L,13842L,188424L,3249576L,101864576L,2388809736L,59720243400L,2571228006912L,85266458294400L,6038197537693842L,227036227417289064L,12129959730964036050UL,BigInteger.Parse("606111287080086323712"),BigInteger.Parse("36186481977293685109248") };
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
public class A153076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153076Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153076.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153076Inst Instance=new A153076Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153077
{
public static readonly BigInteger[] Value={ 5L,29L,116L,2309L,30029L,272264L,6715161L,154448901L,3696967556L,126321788241L,5984466237725L,304250263527209L,7475863618097156L,495878856926202725L,17521052944725830450UL,BigInteger.Parse("1749278213298193453469"),BigInteger.Parse("65483587607609351045025") };
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
public class A153077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153077Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153077.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153077Inst Instance=new A153077Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153078
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,5L,2L,4L,5L,3L,7L,5L,10L,2L,8L,4L,5L,6L,11L,32L,42L,68L,24L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153078Inst : IEnumerable<long>
{
public static readonly long[] Value=A153078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153078.Bytes);
public long this[int i]=>Value[i];

public static A153078Inst Instance=new A153078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153079
{
public static readonly BigInteger[] Value={ 3L,15L,171L,2199L,28563L,371295L,4826811L,62748519L,815730723L,10604499375L,137858491851L,1792160394039L,23298085122483L,302875106592255L,3937376385699291L,51185893014090759L,665416609183179843L,8650415919381337935L,BigInteger.Parse("112455406951957393131") };
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
public class A153079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153079Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153079.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153079Inst Instance=new A153079Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153080
{
public static readonly long[] Value={ 2L,15L,28L,41L,54L,67L,80L,93L,106L,119L,132L,145L,158L,171L,184L,197L,210L,223L,236L,249L,262L,275L,288L,301L,314L,327L,340L,353L,366L,379L,392L,405L,418L,431L,444L,457L,470L,483L,496L,509L,522L,535L,548L,561L,574L,587L,600L,613L,626L,639L,652L,665L,678L,691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153080Inst : IEnumerable<long>
{
public static readonly long[] Value=A153080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153080.Bytes);
public long this[int i]=>Value[i];

public static A153080Inst Instance=new A153080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153081
{
public static readonly long[] Value={ 0L,2L,3L,5L,8L,9L,12L,14L,15L,17L,20L,23L,24L,27L,29L,30L,33L,35L,38L,42L,44L,45L,47L,48L,50L,57L,59L,62L,63L,68L,69L,72L,75L,77L,80L,83L,84L,89L,90L,92L,93L,99L,105L,107L,108L,110L,113L,114L,119L,122L,125L,128L,129L,132L,134L,135L,140L,147L,149L,150L,152L,159L,162L,167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153081Inst : IEnumerable<long>
{
public static readonly long[] Value=A153081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153081.Bytes);
public long this[int i]=>Value[i];

public static A153081Inst Instance=new A153081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153082
{
public static readonly long[] Value={ 1L,4L,6L,7L,10L,11L,13L,16L,18L,19L,21L,22L,25L,26L,28L,31L,32L,34L,36L,37L,39L,40L,41L,43L,46L,49L,51L,52L,53L,54L,55L,56L,58L,60L,61L,64L,65L,66L,67L,70L,71L,73L,74L,76L,78L,79L,81L,82L,85L,86L,87L,88L,91L,94L,95L,96L,97L,98L,100L,101L,102L,103L,104L,106L,109L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153082Inst : IEnumerable<long>
{
public static readonly long[] Value=A153082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153082.Bytes);
public long this[int i]=>Value[i];

public static A153082Inst Instance=new A153082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153083
{
public static readonly long[] Value={ 2L,5L,7L,8L,11L,12L,14L,17L,19L,20L,22L,23L,26L,27L,29L,32L,33L,35L,37L,38L,40L,41L,42L,44L,47L,50L,52L,53L,54L,55L,56L,57L,59L,61L,62L,65L,66L,67L,68L,71L,72L,74L,75L,77L,79L,80L,82L,83L,86L,87L,88L,89L,92L,95L,96L,97L,98L,99L,101L,102L,103L,104L,105L,107L,110L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153083Inst : IEnumerable<long>
{
public static readonly long[] Value=A153083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153083.Bytes);
public long this[int i]=>Value[i];

public static A153083Inst Instance=new A153083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153084
{
public static readonly long[] Value={ 1L,3L,9L,19L,42L,78L,146L,249L,429L,695L,1125L,1749L,2713L,4086L,6123L,8986L,13122L,18852L,26934L,38001L,53328L,74068L,102336L,140208L,191153L,258741L,348606L,466806L,622383L,825342L,1090087L,1432923L,1876542L,2447029L,3179859L,4116282L,5311204L,6829008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153084Inst : IEnumerable<long>
{
public static readonly long[] Value=A153084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153084.Bytes);
public long this[int i]=>Value[i];

public static A153084Inst Instance=new A153084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153085
{
public static readonly long[] Value={ 1L,4L,5L,7L,10L,11L,13L,15L,16L,18L,19L,20L,22L,25L,28L,29L,30L,31L,32L,34L,35L,37L,39L,40L,41L,43L,45L,46L,49L,50L,51L,52L,53L,54L,55L,58L,60L,61L,62L,64L,65L,67L,70L,71L,73L,74L,75L,76L,79L,80L,81L,82L,84L,85L,88L,89L,90L,91L,93L,94L,95L,97L,100L,102L,103L,105L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153085Inst : IEnumerable<long>
{
public static readonly long[] Value=A153085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153085.Bytes);
public long this[int i]=>Value[i];

public static A153085Inst Instance=new A153085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153086
{
public static readonly long[] Value={ 2L,5L,7L,8L,11L,12L,14L,17L,20L,21L,22L,23L,26L,27L,28L,29L,32L,34L,35L,37L,38L,41L,42L,44L,45L,47L,49L,50L,52L,53L,56L,57L,59L,60L,62L,63L,65L,67L,68L,70L,71L,72L,73L,74L,77L,78L,79L,80L,82L,83L,84L,86L,87L,89L,91L,92L,95L,96L,97L,98L,99L,100L,101L,102L,104L,105L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153086Inst : IEnumerable<long>
{
public static readonly long[] Value=A153086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153086.Bytes);
public long this[int i]=>Value[i];

public static A153086Inst Instance=new A153086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153087
{
public static readonly long[] Value={ 6L,66L,114L,162L,5466L,1026L,1926L,606L,5466L,1746L,29154L,522L,3838386L,27066L,4302L,1254L,92886L,3246L,2466L,1578L,113573466L,1026L,129474L,9402L,280201746L,66L,236646L,231006L,6808626L,122826L,545646L,1422L,9003546L,66666L,10242L,2874L,418384938L,3344058L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153087Inst : IEnumerable<long>
{
public static readonly long[] Value=A153087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153087.Bytes);
public long this[int i]=>Value[i];

public static A153087Inst Instance=new A153087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153088
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,8L,9L,10L,11L,13L,14L,15L,17L,19L,20L,21L,23L,24L,25L,26L,27L,29L,31L,32L,33L,34L,35L,37L,38L,39L,41L,42L,43L,44L,45L,47L,49L,50L,51L,52L,53L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,71L,73L,74L,75L,77L,79L,80L,81L,83L,85L,86L,87L,89L,91L,92L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153088Inst : IEnumerable<long>
{
public static readonly long[] Value=A153088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153088.Bytes);
public long this[int i]=>Value[i];

public static A153088Inst Instance=new A153088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153089
{
public static readonly long[] Value={ 2L,7L,117241L,1351781L,3703429L,243729623L,486707171L,568561471L,766634423L,883314979L,1058403331L,1520509423L,1933700891L,1997566367L,2063533819L,2632011079L,3040681037L,3591772153L,4114380107L,7870826569L,8414671219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153089Inst : IEnumerable<long>
{
public static readonly long[] Value=A153089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153089.Bytes);
public long this[int i]=>Value[i];

public static A153089Inst Instance=new A153089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153090
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,14L,5L,5L,5L,1L,7L,6L,5L,7L,12L,1L,5L,1L,6L,29L,23L,20L,8L,6L,23L,9L,2L,15L,18L,19L,13L,57L,1L,1L,9L,10L,15L,16L,22L,12L,26L,5L,5L,6L,39L,41L,6L,9L,50L,6L,32L,20L,4L,8L,2L,79L,28L,23L,33L,78L,31L,35L,19L,32L,46L,7L,6L,116L,39L,18L,20L,6L,35L,8L,25L,39L,31L,26L,117L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153090Inst : IEnumerable<long>
{
public static readonly long[] Value=A153090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153090.Bytes);
public long this[int i]=>Value[i];

public static A153090Inst Instance=new A153090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153091
{
public static readonly long[] Value={ 1L,1L,3L,1L,6L,5L,5L,1L,2L,2L,18L,12L,12L,7L,1L,1L,4L,1L,9L,2L,36L,10L,70L,1L,3L,16L,6L,3L,2L,9L,74L,4L,6L,19L,20L,8L,14L,2L,2L,62L,3L,29L,47L,11L,47L,16L,58L,1L,49L,18L,51L,3L,12L,5L,18L,23L,1L,19L,54L,7L,35L,12L,7L,1L,12L,3L,5L,121L,70L,89L,12L,61L,33L,36L,9L,17L,135L,35L,21L,23L,20L,86L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153091Inst : IEnumerable<long>
{
public static readonly long[] Value=A153091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153091.Bytes);
public long this[int i]=>Value[i];

public static A153091Inst Instance=new A153091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153092
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,3L,2L,20L,4L,5L,2L,9L,2L,27L,7L,12L,3L,3L,2L,3L,6L,6L,1L,18L,8L,2L,17L,2L,14L,55L,1L,18L,4L,59L,18L,30L,26L,32L,3L,14L,59L,42L,35L,40L,22L,7L,17L,26L,6L,28L,3L,15L,11L,6L,32L,30L,18L,14L,4L,85L,3L,1L,65L,13L,64L,7L,18L,40L,8L,68L,5L,5L,6L,107L,7L,88L,25L,6L,3L,1L,21L,8L,12L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153092Inst : IEnumerable<long>
{
public static readonly long[] Value=A153092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153092.Bytes);
public long this[int i]=>Value[i];

public static A153092Inst Instance=new A153092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153093
{
public static readonly long[] Value={ 1L,1L,1L,2L,9L,1L,2L,1L,1L,5L,13L,1L,6L,1L,6L,14L,4L,4L,7L,5L,6L,5L,12L,3L,6L,3L,9L,3L,20L,9L,14L,7L,43L,22L,5L,11L,4L,4L,48L,14L,8L,56L,36L,7L,83L,47L,47L,1L,2L,74L,15L,12L,22L,15L,17L,47L,20L,20L,5L,8L,12L,26L,6L,26L,55L,16L,32L,45L,24L,46L,19L,58L,6L,29L,19L,26L,83L,45L,17L,48L,6L,16L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153093Inst : IEnumerable<long>
{
public static readonly long[] Value=A153093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153093.Bytes);
public long this[int i]=>Value[i];

public static A153093Inst Instance=new A153093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153094
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,4L,1L,2L,1L,1L,1L,4L,1L,1L,1L,3L,5L,2L,1L,1L,3L,2L,2L,2L,9L,6L,1L,6L,4L,1L,1L,4L,1L,2L,2L,3L,6L,6L,5L,1L,5L,5L,1L,2L,1L,10L,3L,5L,1L,3L,2L,1L,4L,5L,2L,2L,3L,1L,1L,2L,3L,5L,5L,6L,1L,12L,3L,5L,6L,1L,2L,9L,3L,4L,1L,1L,5L,2L,3L,4L,7L,2L,2L,16L,8L,5L,1L,5L,5L,6L,3L,2L,11L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153094Inst : IEnumerable<long>
{
public static readonly long[] Value=A153094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153094.Bytes);
public long this[int i]=>Value[i];

public static A153094Inst Instance=new A153094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153095
{
public static readonly long[] Value={ 2L,2L,3L,2L,2L,3L,3L,5L,2L,2L,2L,3L,8L,7L,5L,4L,2L,2L,4L,3L,6L,2L,2L,5L,4L,7L,6L,4L,3L,2L,2L,2L,2L,6L,3L,3L,7L,2L,2L,2L,5L,2L,2L,3L,2L,2L,2L,5L,7L,2L,9L,5L,4L,4L,2L,2L,2L,8L,7L,4L,8L,4L,6L,5L,4L,5L,5L,4L,3L,9L,2L,2L,6L,3L,8L,8L,4L,2L,4L,8L,6L,2L,2L,4L,4L,5L,6L,4L,4L,8L,4L,6L,4L,7L,3L,4L,6L,7L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153095Inst : IEnumerable<long>
{
public static readonly long[] Value=A153095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153095.Bytes);
public long this[int i]=>Value[i];

public static A153095Inst Instance=new A153095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153096
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,-1L,1L,3L,-1L,1L,2L,-1L,1L,2L,-1L,1L,3L,-1L,1L,3L,-1L,1L,5L,1L,1L,2L,-1L,1L,2L,-1L,4L,2L,-1L,1L,3L,1L,2L,8L,1L,1L,7L,-1L,1L,5L,-1L,1L,4L,1L,4L,2L,-1L,1L,2L,-1L,1L,4L,-1L,1L,3L,-1L,3L,6L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153096Inst : IEnumerable<long>
{
public static readonly long[] Value=A153096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153096.Bytes);
public long this[int i]=>Value[i];

public static A153096Inst Instance=new A153096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153097
{
public static readonly long[] Value={ 3L,6L,0L,8L,4L,8L,8L,0L,6L,7L,1L,4L,5L,3L,0L,1L,7L,3L,2L,4L,5L,0L,8L,3L,7L,9L,6L,5L,0L,4L,3L,0L,5L,2L,6L,0L,0L,6L,4L,3L,8L,6L,4L,7L,9L,7L,4L,8L,7L,5L,7L,6L,4L,7L,6L,5L,9L,5L,8L,8L,1L,3L,7L,0L,6L,1L,4L,6L,9L,9L,4L,8L,1L,8L,1L,2L,7L,5L,9L,7L,8L,9L,0L,0L,3L,9L,3L,0L,8L,8L,8L,6L,7L,0L,9L,3L,2L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153097Inst : IEnumerable<long>
{
public static readonly long[] Value=A153097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153097.Bytes);
public long this[int i]=>Value[i];

public static A153097Inst Instance=new A153097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153098
{
public static readonly long[] Value={ 3L,5L,5L,4L,1L,8L,0L,5L,2L,4L,0L,3L,1L,6L,3L,7L,3L,2L,4L,8L,0L,2L,8L,6L,0L,7L,0L,7L,8L,2L,1L,6L,4L,3L,8L,7L,5L,2L,0L,1L,7L,8L,3L,4L,1L,8L,3L,1L,2L,1L,6L,7L,3L,6L,3L,0L,6L,2L,1L,3L,2L,2L,7L,8L,9L,0L,6L,5L,8L,7L,1L,8L,0L,3L,2L,0L,9L,3L,1L,1L,1L,3L,7L,5L,6L,0L,5L,6L,9L,1L,7L,5L,5L,1L,1L,4L,6L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153098Inst : IEnumerable<long>
{
public static readonly long[] Value=A153098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153098.Bytes);
public long this[int i]=>Value[i];

public static A153098Inst Instance=new A153098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153099
{
public static readonly long[] Value={ 3L,5L,0L,3L,7L,9L,3L,0L,6L,4L,2L,2L,2L,1L,0L,9L,7L,7L,4L,0L,6L,6L,2L,3L,4L,0L,8L,6L,4L,3L,9L,7L,1L,4L,3L,1L,8L,5L,6L,4L,9L,9L,8L,5L,2L,5L,1L,5L,1L,3L,8L,3L,4L,1L,9L,9L,4L,1L,2L,5L,6L,6L,9L,6L,3L,5L,1L,1L,8L,8L,0L,8L,8L,5L,6L,1L,7L,6L,9L,0L,8L,7L,1L,9L,4L,7L,8L,2L,6L,9L,9L,0L,6L,9L,4L,4L,6L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153099Inst : IEnumerable<long>
{
public static readonly long[] Value=A153099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153099.Bytes);
public long this[int i]=>Value[i];

public static A153099Inst Instance=new A153099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153100
{
public static readonly long[] Value={ 3L,4L,5L,6L,8L,7L,1L,2L,4L,0L,4L,3L,4L,0L,5L,3L,2L,2L,3L,1L,1L,9L,8L,6L,5L,8L,0L,6L,6L,9L,8L,3L,4L,8L,3L,4L,1L,1L,7L,0L,1L,8L,7L,2L,3L,5L,0L,1L,5L,0L,0L,6L,9L,7L,1L,5L,5L,7L,8L,5L,5L,3L,0L,6L,0L,7L,4L,4L,7L,2L,8L,5L,5L,4L,9L,7L,0L,2L,2L,9L,4L,7L,0L,6L,0L,2L,4L,6L,8L,5L,7L,4L,3L,5L,3L,3L,3L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153100Inst : IEnumerable<long>
{
public static readonly long[] Value=A153100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153100.Bytes);
public long this[int i]=>Value[i];

public static A153100Inst Instance=new A153100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153101
{
public static readonly long[] Value={ 8L,6L,1L,3L,5L,3L,1L,1L,6L,1L,4L,6L,7L,8L,6L,1L,0L,1L,3L,4L,0L,2L,1L,3L,1L,3L,7L,5L,2L,7L,9L,3L,1L,2L,6L,4L,1L,3L,9L,5L,8L,3L,8L,6L,4L,1L,5L,9L,5L,2L,0L,8L,9L,8L,6L,4L,3L,9L,5L,2L,0L,7L,5L,9L,2L,1L,3L,2L,4L,1L,6L,5L,0L,7L,5L,7L,7L,1L,0L,1L,2L,1L,6L,7L,3L,9L,6L,1L,9L,8L,8L,9L,0L,5L,3L,3L,9L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153101Inst : IEnumerable<long>
{
public static readonly long[] Value=A153101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153101.Bytes);
public long this[int i]=>Value[i];

public static A153101Inst Instance=new A153101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153102
{
public static readonly long[] Value={ 7L,7L,3L,7L,0L,5L,6L,1L,4L,4L,6L,9L,0L,8L,3L,1L,7L,3L,7L,4L,0L,4L,9L,2L,2L,7L,6L,9L,3L,5L,6L,4L,1L,7L,5L,2L,9L,3L,0L,2L,8L,3L,7L,1L,8L,9L,1L,4L,2L,0L,6L,8L,5L,6L,7L,7L,8L,9L,8L,9L,8L,5L,7L,6L,5L,3L,2L,8L,4L,0L,3L,7L,0L,8L,1L,4L,4L,5L,6L,0L,7L,6L,6L,3L,3L,0L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153102Inst : IEnumerable<long>
{
public static readonly long[] Value=A153102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153102.Bytes);
public long this[int i]=>Value[i];

public static A153102Inst Instance=new A153102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153103
{
public static readonly long[] Value={ 7L,1L,2L,4L,1L,4L,3L,7L,4L,2L,1L,6L,0L,4L,4L,3L,5L,3L,0L,2L,8L,3L,5L,4L,1L,5L,6L,0L,0L,2L,5L,8L,1L,0L,5L,8L,5L,9L,5L,5L,1L,4L,3L,2L,5L,5L,4L,5L,6L,2L,7L,4L,0L,0L,0L,7L,9L,1L,5L,2L,9L,1L,5L,5L,8L,1L,7L,3L,5L,1L,6L,0L,7L,1L,8L,5L,1L,8L,6L,8L,9L,3L,2L,7L,7L,4L,8L,1L,3L,1L,0L,9L,9L,5L,4L,5L,7L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153103Inst : IEnumerable<long>
{
public static readonly long[] Value=A153103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153103.Bytes);
public long this[int i]=>Value[i];

public static A153103Inst Instance=new A153103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153104
{
public static readonly long[] Value={ 5L,7L,8L,1L,2L,9L,6L,5L,2L,6L,3L,5L,7L,7L,5L,7L,1L,8L,5L,3L,2L,4L,2L,2L,0L,1L,5L,4L,0L,0L,5L,2L,7L,1L,3L,2L,3L,8L,2L,5L,8L,9L,2L,3L,1L,9L,7L,1L,3L,9L,2L,0L,0L,7L,2L,5L,2L,6L,8L,3L,1L,3L,5L,5L,9L,7L,0L,6L,3L,1L,6L,7L,1L,1L,3L,8L,3L,1L,5L,4L,3L,8L,6L,5L,9L,5L,4L,1L,8L,3L,0L,7L,8L,3L,9L,5L,6L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153104Inst : IEnumerable<long>
{
public static readonly long[] Value=A153104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153104.Bytes);
public long this[int i]=>Value[i];

public static A153104Inst Instance=new A153104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153105
{
public static readonly long[] Value={ 5L,5L,7L,8L,8L,5L,8L,9L,1L,3L,0L,2L,2L,5L,9L,6L,8L,6L,3L,8L,2L,0L,8L,8L,1L,6L,2L,0L,7L,5L,7L,7L,1L,2L,0L,6L,2L,0L,9L,5L,8L,8L,6L,7L,5L,1L,9L,2L,9L,4L,6L,1L,3L,5L,9L,4L,5L,3L,9L,2L,0L,0L,6L,8L,1L,6L,5L,5L,3L,0L,1L,0L,4L,8L,0L,9L,3L,5L,1L,1L,8L,1L,6L,1L,3L,9L,4L,4L,3L,4L,7L,0L,0L,7L,2L,6L,2L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153105Inst : IEnumerable<long>
{
public static readonly long[] Value=A153105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153105.Bytes);
public long this[int i]=>Value[i];

public static A153105Inst Instance=new A153105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153106
{
public static readonly long[] Value={ 5L,4L,0L,4L,7L,6L,3L,0L,8L,8L,5L,4L,6L,3L,9L,4L,8L,2L,5L,8L,8L,2L,1L,6L,0L,0L,6L,9L,0L,1L,2L,8L,4L,5L,8L,8L,7L,9L,7L,2L,8L,8L,4L,0L,4L,6L,2L,7L,3L,6L,2L,2L,9L,8L,8L,0L,5L,5L,6L,4L,9L,6L,1L,3L,4L,7L,3L,5L,1L,3L,8L,7L,4L,6L,8L,9L,0L,6L,2L,4L,0L,6L,0L,6L,1L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153106Inst : IEnumerable<long>
{
public static readonly long[] Value=A153106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153106.Bytes);
public long this[int i]=>Value[i];

public static A153106Inst Instance=new A153106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153107
{
public static readonly long[] Value={ 5L,2L,5L,2L,9L,9L,0L,7L,0L,0L,7L,4L,3L,8L,7L,0L,9L,5L,9L,5L,7L,8L,1L,3L,7L,3L,7L,1L,3L,0L,1L,6L,1L,4L,4L,1L,2L,0L,1L,3L,2L,3L,1L,8L,9L,4L,1L,3L,8L,3L,9L,6L,1L,9L,7L,8L,4L,0L,8L,5L,1L,3L,2L,2L,1L,5L,3L,9L,2L,0L,9L,9L,9L,9L,5L,0L,3L,5L,0L,9L,2L,5L,7L,5L,0L,3L,1L,7L,1L,8L,0L,3L,6L,3L,1L,6L,8L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153107Inst : IEnumerable<long>
{
public static readonly long[] Value=A153107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153107.Bytes);
public long this[int i]=>Value[i];

public static A153107Inst Instance=new A153107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153108
{
public static readonly long[] Value={ 5L,1L,1L,9L,1L,6L,0L,4L,9L,6L,1L,9L,6L,3L,0L,9L,7L,8L,7L,7L,5L,3L,5L,5L,3L,5L,7L,7L,2L,9L,6L,0L,4L,5L,4L,0L,8L,0L,9L,8L,8L,3L,7L,5L,9L,5L,1L,7L,8L,0L,2L,2L,8L,4L,5L,3L,7L,0L,3L,0L,8L,6L,1L,8L,5L,9L,2L,3L,8L,4L,3L,9L,5L,4L,4L,3L,4L,4L,9L,8L,9L,0L,2L,9L,4L,5L,5L,1L,6L,7L,7L,0L,5L,9L,0L,5L,5L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153108Inst : IEnumerable<long>
{
public static readonly long[] Value=A153108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153108.Bytes);
public long this[int i]=>Value[i];

public static A153108Inst Instance=new A153108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153109
{
public static readonly long[] Value={ 4L,8L,9L,3L,0L,1L,0L,8L,4L,2L,3L,6L,4L,5L,2L,0L,6L,0L,7L,7L,9L,5L,2L,2L,9L,8L,2L,4L,6L,3L,9L,5L,5L,6L,1L,4L,7L,8L,8L,5L,2L,1L,9L,3L,1L,2L,1L,6L,7L,2L,7L,3L,9L,5L,5L,7L,2L,7L,0L,0L,7L,8L,5L,0L,5L,4L,3L,9L,4L,6L,2L,2L,3L,1L,4L,1L,0L,5L,3L,7L,1L,8L,9L,8L,5L,5L,3L,0L,3L,7L,6L,0L,9L,6L,0L,0L,6L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153109Inst : IEnumerable<long>
{
public static readonly long[] Value=A153109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153109.Bytes);
public long this[int i]=>Value[i];

public static A153109Inst Instance=new A153109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153110
{
public static readonly long[] Value={ 1L,5L,7L,2L,4L,8L,1L,5L,7L,2L,4L,8L,1L,5L,7L,2L,4L,8L,1L,5L,7L,2L,4L,8L,1L,5L,7L,2L,4L,8L,1L,5L,7L,2L,4L,8L,1L,5L,7L,2L,4L,8L,1L,5L,7L,2L,4L,8L,1L,5L,7L,2L,4L,8L,1L,5L,7L,2L,4L,8L,1L,5L,7L,2L,4L,8L,1L,5L,7L,2L,4L,8L,1L,5L,7L,2L,4L,8L,1L,5L,7L,2L,4L,8L,1L,5L,7L,2L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153110Inst : IEnumerable<long>
{
public static readonly long[] Value=A153110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153110.Bytes);
public long this[int i]=>Value[i];

public static A153110Inst Instance=new A153110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153111
{
public static readonly BigInteger[] Value={ 1L,25L,649L,16849L,437425L,11356201L,294823801L,7654062625L,198710804449L,5158826853049L,133930787374825L,3477041644892401L,90269151979827601L,2343520909830625225L,BigInteger.Parse("60841274503616428249"),BigInteger.Parse("1579529616184196509249"),BigInteger.Parse("41006928746285492812225") };
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
public class A153111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153111Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153111.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153111Inst Instance=new A153111Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153112
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,3L,3L,3L,4L,5L,5L,5L,5L,6L,7L,7L,8L,8L,8L,8L,8L,9L,10L,11L,2L,12L,12L,12L,13L,13L,2L,14L,14L,14L,14L,15L,16L,16L,17L,18L,18L,19L,19L,10L,19L,20L,20L,20L,21L,21L,21L,10L,24L,24L,13L,24L,25L,16L,26L,26L,26L,27L,27L,28L,28L,1L,2L,2L,3L,3L,3L,4L,5L,5L,5L,2L,6L,7L,7L,8L,8L,8L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153112Inst : IEnumerable<long>
{
public static readonly long[] Value=A153112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153112.Bytes);
public long this[int i]=>Value[i];

public static A153112Inst Instance=new A153112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153113
{
public static readonly long[] Value={ 4L,7L,9L,6L,2L,4L,9L,3L,3L,1L,3L,6L,2L,6L,2L,8L,8L,9L,4L,7L,1L,3L,6L,8L,3L,2L,9L,8L,2L,1L,0L,4L,6L,1L,2L,3L,5L,3L,6L,3L,5L,5L,8L,6L,0L,0L,3L,8L,1L,4L,1L,1L,3L,1L,9L,5L,7L,2L,8L,9L,8L,0L,1L,4L,2L,9L,8L,2L,5L,8L,1L,1L,4L,8L,6L,3L,7L,9L,0L,8L,9L,7L,0L,1L,3L,1L,1L,2L,8L,2L,9L,6L,0L,2L,8L,2L,2L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153113Inst : IEnumerable<long>
{
public static readonly long[] Value=A153113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153113.Bytes);
public long this[int i]=>Value[i];

public static A153113Inst Instance=new A153113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153114
{
public static readonly long[] Value={ 0L,1L,3L,7L,15L,30L,31L,63L,127L,255L,503L,507L,509L,510L,511L,1003L,1005L,1006L,1015L,1019L,1020L,1021L,1022L,2007L,2015L,2030L,2031L,2039L,2043L,2045L,2046L,3007L,3070L,3071L,4030L,4031L,4063L,4079L,4087L,4090L,4091L,4093L,4094L,8063L,8190L,8191L,16383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153114Inst : IEnumerable<long>
{
public static readonly long[] Value=A153114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153114.Bytes);
public long this[int i]=>Value[i];

public static A153114Inst Instance=new A153114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153115
{
public static readonly long[] Value={ 1L,16L,128L,512L,1024L,1152L,2112L,4112L,8192L,16384L,16416L,16512L,131073L,131074L,131076L,131080L,131081L,131088L,131105L,131106L,131108L,131110L,131111L,131113L,131114L,131116L,131120L,131121L,131137L,131138L,131140L,131141L,131144L,131152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153115Inst : IEnumerable<long>
{
public static readonly long[] Value=A153115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153115.Bytes);
public long this[int i]=>Value[i];

public static A153115Inst Instance=new A153115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153116
{
public static readonly long[] Value={ 5L,7L,13L,19L,29L,41L,61L,97L,113L,139L,191L,379L,383L,401L,491L,719L,953L,1051L,1367L,1553L,1609L,1657L,1667L,1801L,1933L,2129L,2207L,2351L,2473L,3001L,3023L,3061L,3449L,3571L,3863L,3943L,3967L,4073L,4219L,5167L,5209L,5683L,5783L,6257L,6329L,6827L,7187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153116Inst : IEnumerable<long>
{
public static readonly long[] Value=A153116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153116.Bytes);
public long this[int i]=>Value[i];

public static A153116Inst Instance=new A153116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153117
{
public static readonly long[] Value={ 4L,7L,0L,8L,1L,7L,8L,2L,6L,7L,3L,3L,2L,7L,6L,4L,7L,2L,8L,9L,3L,9L,3L,0L,9L,2L,0L,0L,7L,3L,6L,8L,3L,7L,0L,7L,6L,7L,0L,8L,1L,3L,5L,5L,3L,2L,5L,5L,6L,3L,2L,0L,9L,4L,5L,7L,6L,2L,6L,4L,7L,3L,7L,0L,0L,5L,7L,1L,4L,6L,0L,4L,2L,6L,4L,1L,0L,8L,9L,6L,3L,5L,0L,4L,8L,8L,0L,0L,9L,1L,7L,4L,9L,5L,6L,7L,2L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153117Inst : IEnumerable<long>
{
public static readonly long[] Value=A153117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153117.Bytes);
public long this[int i]=>Value[i];

public static A153117Inst Instance=new A153117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153118
{
public static readonly long[] Value={ 5L,7L,11L,17L,29L,41L,43L,59L,71L,83L,223L,283L,311L,347L,389L,433L,479L,601L,619L,881L,907L,967L,983L,991L,1039L,1093L,1151L,1471L,1567L,1723L,1873L,1877L,1907L,1931L,1933L,1987L,2309L,2531L,2953L,3037L,3461L,3539L,3853L,4001L,4003L,4007L,4073L,4091L,4253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153118Inst : IEnumerable<long>
{
public static readonly long[] Value=A153118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153118.Bytes);
public long this[int i]=>Value[i];

public static A153118Inst Instance=new A153118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153119
{
public static readonly long[] Value={ 7L,13L,47L,79L,113L,251L,317L,397L,547L,719L,1013L,1153L,2113L,2141L,2179L,2267L,2309L,2749L,3271L,3557L,3631L,3739L,4243L,4783L,4919L,5399L,5563L,5881L,5927L,6389L,6701L,7229L,7351L,7547L,7691L,7741L,7817L,8191L,8269L,8779L,8807L,9067L,9133L,9277L,10067L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153119Inst : IEnumerable<long>
{
public static readonly long[] Value=A153119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153119.Bytes);
public long this[int i]=>Value[i];

public static A153119Inst Instance=new A153119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153120
{
public static readonly long[] Value={ 5L,11L,13L,23L,53L,89L,101L,103L,109L,181L,197L,307L,313L,457L,467L,571L,691L,769L,863L,907L,1061L,1087L,1223L,1453L,1487L,1607L,1913L,2129L,2161L,2311L,2729L,2741L,2767L,2917L,3313L,3343L,3359L,3433L,4363L,4373L,4547L,4703L,4783L,4787L,4877L,5119L,5237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153120Inst : IEnumerable<long>
{
public static readonly long[] Value=A153120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153120.Bytes);
public long this[int i]=>Value[i];

public static A153120Inst Instance=new A153120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153121
{
public static readonly long[] Value={ 5L,7L,29L,41L,1933L,4073L,43049L,46439L,60353L,72031L,150989L,153929L,158551L,158591L,190051L,199247L,226267L,438479L,545749L,613451L,696737L,714841L,734663L,754627L,788353L,793843L,825259L,948457L,1053191L,1057699L,1154159L,1241827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153121Inst : IEnumerable<long>
{
public static readonly long[] Value=A153121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153121.Bytes);
public long this[int i]=>Value[i];

public static A153121Inst Instance=new A153121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153122
{
public static readonly long[] Value={ 1L,-2L,6L,-15L,38L,-95L,237L,-590L,1468L,-3651L,9079L,-22575L,56131L,-139563L,347004L,-862774L,2145156L,-5333599L,13261165L,-32971820L,81979285L,-203828691L,506788203L,-1260049698L,3132916721L,-7789507968L,19367394583L,-48154000782L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153122Inst : IEnumerable<long>
{
public static readonly long[] Value=A153122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153122.Bytes);
public long this[int i]=>Value[i];

public static A153122Inst Instance=new A153122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153123
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,9L,10L,12L,14L,17L,20L,22L,23L,31L,53L,56L,57L,683L,2983L,2984L,2985L,149411L,811160L,811162L,811163L,75426842L,476823319L,476823329L,476823330L,73727027930L,530824147003L,530824147008L,530824147009L,126824134344110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153123Inst : IEnumerable<long>
{
public static readonly long[] Value=A153123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153123.Bytes);
public long this[int i]=>Value[i];

public static A153123Inst Instance=new A153123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153124
{
public static readonly long[] Value={ 4L,6L,2L,7L,5L,6L,4L,2L,6L,3L,1L,9L,5L,1L,8L,3L,4L,8L,5L,2L,7L,3L,9L,5L,4L,0L,2L,1L,9L,5L,2L,8L,0L,9L,9L,1L,7L,8L,1L,9L,3L,1L,0L,1L,4L,7L,4L,7L,1L,3L,1L,7L,2L,3L,6L,7L,9L,2L,3L,5L,5L,8L,8L,2L,2L,7L,0L,4L,9L,1L,0L,8L,0L,6L,0L,3L,1L,6L,7L,6L,9L,4L,2L,7L,9L,3L,1L,1L,6L,8L,0L,8L,9L,5L,0L,7L,8L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153124Inst : IEnumerable<long>
{
public static readonly long[] Value=A153124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153124.Bytes);
public long this[int i]=>Value[i];

public static A153124Inst Instance=new A153124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153125
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,9L,4L,7L,10L,12L,5L,8L,11L,14L,17L,6L,9L,12L,15L,18L,20L,7L,10L,13L,16L,19L,22L,25L,8L,11L,14L,17L,20L,23L,26L,28L,9L,12L,15L,18L,21L,24L,27L,30L,33L,10L,13L,16L,19L,22L,25L,28L,31L,34L,36L,11L,14L,17L,20L,23L,26L,29L,32L,35L,38L,41L,12L,15L,18L,21L,24L,27L,30L,33L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153125Inst : IEnumerable<long>
{
public static readonly long[] Value=A153125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153125.Bytes);
public long this[int i]=>Value[i];

public static A153125Inst Instance=new A153125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153126
{
public static readonly long[] Value={ 1L,6L,18L,33L,55L,80L,112L,147L,189L,234L,286L,341L,403L,468L,540L,615L,697L,782L,874L,969L,1071L,1176L,1288L,1403L,1525L,1650L,1782L,1917L,2059L,2204L,2356L,2511L,2673L,2838L,3010L,3185L,3367L,3552L,3744L,3939L,4141L,4346L,4558L,4773L,4995L,5220L,5452L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153126Inst : IEnumerable<long>
{
public static readonly long[] Value=A153126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153126.Bytes);
public long this[int i]=>Value[i];

public static A153126Inst Instance=new A153126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153127
{
public static readonly long[] Value={ 6L,33L,80L,147L,234L,341L,468L,615L,782L,969L,1176L,1403L,1650L,1917L,2204L,2511L,2838L,3185L,3552L,3939L,4346L,4773L,5220L,5687L,6174L,6681L,7208L,7755L,8322L,8909L,9516L,10143L,10790L,11457L,12144L,12851L,13578L,14325L,15092L,15879L,16686L,17513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153127Inst : IEnumerable<long>
{
public static readonly long[] Value=A153127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153127.Bytes);
public long this[int i]=>Value[i];

public static A153127Inst Instance=new A153127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153128
{
public static readonly long[] Value={ 11L,31L,41L,67L,131L,3121L,4229L,13159L,14081L,24631L,49877L,64921L,71789L,127051L,154871L,178621L,249677L,260011L,350729L,401473L,487397L,537883L,567767L,718423L,724499L,763621L,1004987L,1016611L,1043951L,1053529L,1090949L,1295113L,1309907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153128Inst : IEnumerable<long>
{
public static readonly long[] Value=A153128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153128.Bytes);
public long this[int i]=>Value[i];

public static A153128Inst Instance=new A153128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153129
{
public static readonly long[] Value={ 2L,5L,8L,9L,10L,11L,14L,15L,16L,17L,20L,23L,25L,26L,27L,29L,30L,31L,32L,35L,37L,38L,40L,41L,42L,44L,45L,47L,50L,51L,53L,54L,55L,56L,58L,59L,60L,61L,62L,64L,65L,66L,68L,70L,71L,72L,73L,74L,75L,77L,78L,79L,80L,83L,85L,86L,89L,90L,92L,93L,95L,97L,98L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153129Inst : IEnumerable<long>
{
public static readonly long[] Value=A153129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153129.Bytes);
public long this[int i]=>Value[i];

public static A153129Inst Instance=new A153129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153130
{
public static readonly long[] Value={ 1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L,1L,2L,4L,8L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153130Inst : IEnumerable<long>
{
public static readonly long[] Value=A153130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153130.Bytes);
public long this[int i]=>Value[i];

public static A153130Inst Instance=new A153130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153131
{
public static readonly long[] Value={ 4L,5L,5L,3L,4L,0L,4L,9L,7L,3L,9L,3L,9L,0L,5L,9L,9L,5L,9L,6L,4L,1L,5L,1L,9L,4L,4L,2L,0L,1L,7L,8L,1L,9L,9L,1L,2L,8L,2L,1L,3L,1L,1L,8L,2L,4L,8L,2L,6L,4L,6L,5L,9L,2L,3L,3L,4L,1L,4L,9L,9L,1L,3L,4L,3L,1L,2L,1L,7L,3L,6L,8L,5L,1L,3L,7L,0L,9L,5L,3L,5L,1L,6L,5L,7L,6L,8L,9L,6L,3L,0L,5L,3L,4L,6L,8L,1L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153131Inst : IEnumerable<long>
{
public static readonly long[] Value=A153131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153131.Bytes);
public long this[int i]=>Value[i];

public static A153131Inst Instance=new A153131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153132
{
public static readonly long[] Value={ 4L,4L,8L,4L,8L,7L,6L,4L,8L,4L,3L,5L,1L,5L,0L,8L,7L,8L,9L,5L,5L,1L,2L,4L,6L,7L,6L,8L,0L,6L,9L,6L,0L,9L,4L,1L,7L,9L,5L,8L,2L,5L,7L,6L,4L,8L,8L,4L,4L,4L,4L,0L,1L,9L,4L,5L,1L,5L,2L,3L,4L,2L,2L,1L,3L,0L,2L,2L,9L,0L,6L,0L,0L,1L,2L,8L,0L,2L,8L,4L,7L,8L,3L,5L,1L,5L,8L,9L,5L,3L,8L,6L,1L,4L,0L,7L,7L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153132Inst : IEnumerable<long>
{
public static readonly long[] Value=A153132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153132.Bytes);
public long this[int i]=>Value[i];

public static A153132Inst Instance=new A153132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153133
{
public static readonly BigInteger[] Value={ 3L,7L,17L,43L,113L,307L,857L,20707L,181243L,539633L,14414443L,129402307L,31389448217L,1853028778786433L,5559077746424707L,50031613818476443L,150094772735952593L,BigInteger.Parse("8862938260389989451257"),BigInteger.Parse("26588814640432479998443") };
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
public class A153133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153133Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153133.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153133Inst Instance=new A153133Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153134
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,8L,9L,10L,11L,13L,15L,16L,18L,19L,20L,23L,24L,26L,29L,30L,31L,33L,34L,39L,40L,41L,43L,44L,45L,46L,48L,50L,53L,54L,59L,60L,61L,65L,66L,68L,71L,73L,75L,76L,78L,79L,81L,83L,85L,86L,88L,94L,95L,96L,99L,100L,101L,104L,108L,109L,110L,111L,114L,115L,118L,121L,125L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153134Inst : IEnumerable<long>
{
public static readonly long[] Value=A153134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153134.Bytes);
public long this[int i]=>Value[i];

public static A153134Inst Instance=new A153134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153135
{
public static readonly long[] Value={ 2L,3L,5L,11L,13L,19L,23L,29L,31L,41L,43L,53L,59L,61L,71L,73L,79L,83L,101L,109L,139L,149L,163L,173L,193L,199L,211L,229L,239L,241L,251L,263L,269L,271L,313L,331L,349L,353L,379L,401L,409L,431L,433L,449L,491L,503L,521L,563L,569L,613L,631L,643L,653L,659L,683L,691L,733L,743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153135Inst : IEnumerable<long>
{
public static readonly long[] Value=A153135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153135.Bytes);
public long this[int i]=>Value[i];

public static A153135Inst Instance=new A153135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153136
{
public static readonly long[] Value={ 2L,7L,13L,43L,103L,1627L,25349L,315743L,7338823L,42939980423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153136Inst : IEnumerable<long>
{
public static readonly long[] Value=A153136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153136.Bytes);
public long this[int i]=>Value[i];

public static A153136Inst Instance=new A153136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153137
{
public static readonly long[] Value={ 1L,3L,5L,113L,181L,661L,10891L,927149L,88070399L,15288362671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153137Inst : IEnumerable<long>
{
public static readonly long[] Value=A153137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153137.Bytes);
public long this[int i]=>Value[i];

public static A153137Inst Instance=new A153137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153138
{
public static readonly long[] Value={ 3L,5L,7L,83L,317L,383L,29567L,423509L,118661483L,52542428123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153138Inst : IEnumerable<long>
{
public static readonly long[] Value=A153138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153138.Bytes);
public long this[int i]=>Value[i];

public static A153138Inst Instance=new A153138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153139
{
public static readonly long[] Value={ 10171L,10371L,10447L,10449L,10451L,11303L,11801L,11827L,12319L,12553L,13387L,13829L,13847L,13903L,13913L,14141L,14549L,15087L,15097L,15153L,15847L,16431L,16841L,16847L,17549L,18363L,18379L,18637L,18697L,18701L,19319L,19337L,19579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153139Inst : IEnumerable<long>
{
public static readonly long[] Value=A153139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153139.Bytes);
public long this[int i]=>Value[i];

public static A153139Inst Instance=new A153139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153140
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,14L,20L,28L,40L,54L,72L,98L,129L,168L,220L,282L,360L,460L,580L,728L,912L,1134L,1404L,1734L,2129L,2604L,3180L,3864L,4680L,5658L,6812L,8182L,9808L,11718L,13968L,16618L,19720L,23350L,27600L,32550L,38313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153140Inst : IEnumerable<long>
{
public static readonly long[] Value=A153140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153140.Bytes);
public long this[int i]=>Value[i];

public static A153140Inst Instance=new A153140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153141
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,6L,4L,5L,15L,14L,12L,13L,8L,9L,10L,11L,31L,30L,28L,29L,24L,25L,26L,27L,16L,17L,18L,19L,20L,21L,22L,23L,63L,62L,60L,61L,56L,57L,58L,59L,48L,49L,50L,51L,52L,53L,54L,55L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,127L,126L,124L,125L,120L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153141Inst : IEnumerable<long>
{
public static readonly long[] Value=A153141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153141.Bytes);
public long this[int i]=>Value[i];

public static A153141Inst Instance=new A153141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153142
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,7L,5L,4L,12L,13L,14L,15L,10L,11L,9L,8L,24L,25L,26L,27L,28L,29L,30L,31L,20L,21L,22L,23L,18L,19L,17L,16L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,40L,41L,42L,43L,44L,45L,46L,47L,36L,37L,38L,39L,34L,35L,33L,32L,96L,97L,98L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153142Inst : IEnumerable<long>
{
public static readonly long[] Value=A153142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153142.Bytes);
public long this[int i]=>Value[i];

public static A153142Inst Instance=new A153142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153143
{
public static readonly long[] Value={ 0L,2L,5L,6L,9L,11L,12L,14L,17L,20L,21L,24L,26L,27L,30L,32L,35L,39L,41L,42L,44L,45L,47L,54L,56L,59L,60L,65L,66L,69L,72L,74L,77L,80L,81L,86L,87L,89L,90L,96L,102L,104L,105L,107L,110L,111L,116L,119L,122L,125L,126L,129L,131L,132L,137L,144L,146L,147L,149L,156L,159L,164L,165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153143Inst : IEnumerable<long>
{
public static readonly long[] Value=A153143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153143.Bytes);
public long this[int i]=>Value[i];

public static A153143Inst Instance=new A153143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153144
{
public static readonly long[] Value={ 1L,3L,4L,7L,8L,10L,13L,15L,16L,18L,19L,22L,23L,25L,28L,29L,31L,33L,34L,36L,37L,38L,40L,43L,46L,48L,49L,50L,51L,52L,53L,55L,57L,58L,61L,62L,63L,64L,67L,68L,70L,71L,73L,75L,76L,78L,79L,82L,83L,84L,85L,88L,91L,92L,93L,94L,95L,97L,98L,99L,100L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153144Inst : IEnumerable<long>
{
public static readonly long[] Value=A153144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153144.Bytes);
public long this[int i]=>Value[i];

public static A153144Inst Instance=new A153144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153145
{
public static readonly long[] Value={ 2L,5L,11L,17L,41L,47L,59L,89L,107L,131L,137L,149L,167L,191L,251L,269L,311L,317L,389L,401L,419L,431L,461L,467L,479L,521L,587L,599L,641L,677L,797L,809L,839L,857L,929L,941L,947L,977L,1031L,1061L,1097L,1109L,1181L,1187L,1229L,1301L,1307L,1319L,1361L,1367L,1409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153145Inst : IEnumerable<long>
{
public static readonly long[] Value=A153145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153145.Bytes);
public long this[int i]=>Value[i];

public static A153145Inst Instance=new A153145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153146
{
public static readonly long[] Value={ 11L,12L,21L,24L,30L,39L,45L,54L,60L,66L,96L,105L,126L,129L,144L,156L,165L,189L,201L,210L,219L,234L,240L,261L,264L,291L,294L,306L,336L,360L,369L,396L,420L,429L,450L,474L,486L,495L,501L,516L,525L,534L,555L,591L,606L,639L,651L,654L,690L,714L,726L,735L,756L,765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153146Inst : IEnumerable<long>
{
public static readonly long[] Value=A153146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153146.Bytes);
public long this[int i]=>Value[i];

public static A153146Inst Instance=new A153146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153147
{
public static readonly long[] Value={ 8L,27L,125L,216L,343L,1000L,1331L,1728L,2197L,2744L,3375L,4913L,5832L,6859L,8000L,9261L,10648L,12167L,13824L,17576L,21952L,24389L,27000L,29791L,35937L,39304L,42875L,50653L,54872L,59319L,64000L,68921L,74088L,79507L,85184L,91125L,97336L,103823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153147Inst : IEnumerable<long>
{
public static readonly long[] Value=A153147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153147.Bytes);
public long this[int i]=>Value[i];

public static A153147Inst Instance=new A153147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153148
{
public static readonly long[] Value={ 1L,1L,1L,-1L,0L,2L,0L,-1L,0L,1L,1L,-2L,0L,3L,0L,-2L,-1L,3L,1L,-4L,0L,4L,1L,-4L,-1L,5L,2L,-6L,-2L,7L,0L,-6L,-1L,7L,3L,-9L,-1L,10L,1L,-10L,-2L,11L,3L,-14L,-3L,15L,2L,-14L,-3L,17L,5L,-19L,-4L,21L,3L,-22L,-5L,23L,7L,-28L,-5L,30L,5L,-30L,-7L,34L,8L,-38L,-7L,41L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153148Inst : IEnumerable<long>
{
public static readonly long[] Value=A153148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153148.Bytes);
public long this[int i]=>Value[i];

public static A153148Inst Instance=new A153148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153149
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,-1L,-1L,1L,2L,0L,-2L,1L,2L,-2L,-2L,2L,3L,-1L,-2L,2L,2L,-3L,-4L,3L,5L,-2L,-4L,3L,5L,-4L,-6L,4L,7L,-4L,-7L,5L,7L,-6L,-9L,7L,11L,-6L,-10L,7L,11L,-9L,-14L,9L,15L,-9L,-14L,11L,16L,-13L,-19L,13L,21L,-12L,-22L,15L,23L,-18L,-26L,19L,30L,-19L,-30L,21L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153149Inst : IEnumerable<long>
{
public static readonly long[] Value=A153149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153149.Bytes);
public long this[int i]=>Value[i];

public static A153149Inst Instance=new A153149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153150
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,4L,6L,7L,11L,9L,10L,8L,12L,14L,13L,15L,23L,19L,21L,17L,22L,18L,20L,16L,24L,28L,26L,30L,25L,29L,27L,31L,47L,39L,43L,35L,45L,37L,41L,33L,46L,38L,42L,34L,44L,36L,40L,32L,48L,56L,52L,60L,50L,58L,54L,62L,49L,57L,53L,61L,51L,59L,55L,63L,95L,79L,87L,71L,91L,75L,83L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153150Inst : IEnumerable<long>
{
public static readonly long[] Value=A153150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153150.Bytes);
public long this[int i]=>Value[i];

public static A153150Inst Instance=new A153150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153151
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,4L,5L,6L,15L,8L,9L,10L,11L,12L,13L,14L,31L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,63L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,127L,64L,65L,66L,67L,68L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153151Inst : IEnumerable<long>
{
public static readonly long[] Value=A153151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153151.Bytes);
public long this[int i]=>Value[i];

public static A153151Inst Instance=new A153151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153152
{
public static readonly long[] Value={ 0L,1L,3L,2L,5L,6L,7L,4L,9L,10L,11L,12L,13L,14L,15L,8L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,16L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,32L,65L,66L,67L,68L,69L,70L,71L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153152Inst : IEnumerable<long>
{
public static readonly long[] Value=A153152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153152.Bytes);
public long this[int i]=>Value[i];

public static A153152Inst Instance=new A153152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153153
{
public static readonly long[] Value={ 0L,1L,3L,2L,5L,6L,7L,4L,9L,10L,15L,12L,13L,14L,11L,8L,17L,18L,23L,20L,29L,30L,27L,24L,25L,26L,31L,28L,21L,22L,19L,16L,33L,34L,39L,36L,45L,46L,43L,40L,57L,58L,63L,60L,53L,54L,51L,48L,49L,50L,55L,52L,61L,62L,59L,56L,41L,42L,47L,44L,37L,38L,35L,32L,65L,66L,71L,68L,77L,78L,75L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153153Inst : IEnumerable<long>
{
public static readonly long[] Value=A153153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153153.Bytes);
public long this[int i]=>Value[i];

public static A153153Inst Instance=new A153153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153154
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,4L,5L,6L,15L,8L,9L,14L,11L,12L,13L,10L,31L,16L,17L,30L,19L,28L,29L,18L,23L,24L,25L,22L,27L,20L,21L,26L,63L,32L,33L,62L,35L,60L,61L,34L,39L,56L,57L,38L,59L,36L,37L,58L,47L,48L,49L,46L,51L,44L,45L,50L,55L,40L,41L,54L,43L,52L,53L,42L,127L,64L,65L,126L,67L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153154Inst : IEnumerable<long>
{
public static readonly long[] Value=A153154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153154.Bytes);
public long this[int i]=>Value[i];

public static A153154Inst Instance=new A153154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153155
{
public static readonly long[] Value={ 0L,0L,1L,-1L,1L,-1L,2L,-2L,3L,-4L,4L,-5L,7L,-7L,9L,-11L,12L,-15L,18L,-20L,24L,-28L,32L,-37L,43L,-48L,56L,-65L,72L,-83L,95L,-106L,122L,-138L,154L,-174L,197L,-220L,247L,-278L,309L,-346L,388L,-430L,480L,-535L,592L,-659L,732L,-808L,896L,-992L,1094L,-1209L,1335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153155Inst : IEnumerable<long>
{
public static readonly long[] Value=A153155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153155.Bytes);
public long this[int i]=>Value[i];

public static A153155Inst Instance=new A153155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153156
{
public static readonly long[] Value={ 1L,-1L,2L,-2L,3L,-4L,5L,-6L,8L,-9L,11L,-14L,17L,-20L,24L,-28L,33L,-39L,46L,-53L,62L,-72L,83L,-96L,110L,-126L,145L,-165L,188L,-214L,243L,-275L,312L,-352L,396L,-447L,502L,-563L,632L,-707L,791L,-884L,986L,-1098L,1223L,-1359L,1509L,-1676L,1857L,-2056L,2276L,-2515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153156Inst : IEnumerable<long>
{
public static readonly long[] Value=A153156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153156.Bytes);
public long this[int i]=>Value[i];

public static A153156Inst Instance=new A153156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153157
{
public static readonly long[] Value={ 16L,81L,625L,1296L,2401L,10000L,14641L,20736L,28561L,38416L,50625L,83521L,104976L,130321L,160000L,194481L,234256L,279841L,331776L,456976L,614656L,707281L,810000L,923521L,1185921L,1336336L,1500625L,1874161L,2085136L,2313441L,2560000L,2825761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153157Inst : IEnumerable<long>
{
public static readonly long[] Value=A153157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153157.Bytes);
public long this[int i]=>Value[i];

public static A153157Inst Instance=new A153157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153158
{
public static readonly long[] Value={ 4L,9L,25L,36L,49L,100L,121L,144L,169L,196L,225L,289L,324L,361L,400L,441L,484L,529L,576L,676L,784L,841L,900L,961L,1089L,1156L,1225L,1369L,1444L,1521L,1600L,1681L,1764L,1849L,1936L,2025L,2116L,2209L,2304L,2500L,2601L,2704L,2809L,2916L,3025L,3136L,3249L,3364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153158Inst : IEnumerable<long>
{
public static readonly long[] Value=A153158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153158.Bytes);
public long this[int i]=>Value[i];

public static A153158Inst Instance=new A153158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153159
{
public static readonly long[] Value={ 32L,243L,3125L,7776L,16807L,100000L,161051L,248832L,371293L,537824L,759375L,1419857L,1889568L,2476099L,3200000L,4084101L,5153632L,6436343L,7962624L,11881376L,17210368L,20511149L,24300000L,28629151L,39135393L,45435424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153159Inst : IEnumerable<long>
{
public static readonly long[] Value=A153159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153159.Bytes);
public long this[int i]=>Value[i];

public static A153159Inst Instance=new A153159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153160
{
public static readonly long[] Value={ 64L,729L,15625L,46656L,117649L,1000000L,1771561L,2985984L,4826809L,7529536L,11390625L,24137569L,34012224L,47045881L,64000000L,85766121L,113379904L,148035889L,191102976L,308915776L,481890304L,594823321L,729000000L,887503681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153160Inst : IEnumerable<long>
{
public static readonly long[] Value=A153160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153160.Bytes);
public long this[int i]=>Value[i];

public static A153160Inst Instance=new A153160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153161
{
public static readonly long[] Value={ 1L,2L,3L,3L,3L,4L,5L,4L,5L,5L,4L,5L,7L,8L,7L,5L,7L,8L,7L,7L,8L,7L,5L,6L,9L,11L,10L,11L,13L,12L,9L,6L,9L,11L,10L,11L,13L,12L,9L,9L,12L,13L,11L,10L,11L,9L,6L,7L,11L,14L,13L,15L,18L,17L,13L,14L,19L,21L,18L,17L,19L,16L,11L,7L,11L,14L,13L,15L,18L,17L,13L,14L,19L,21L,18L,17L,19L,16L,11L,11L,16L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153161Inst : IEnumerable<long>
{
public static readonly long[] Value=A153161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153161.Bytes);
public long this[int i]=>Value[i];

public static A153161Inst Instance=new A153161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153162
{
public static readonly long[] Value={ 2L,5L,5L,8L,7L,7L,8L,11L,13L,12L,9L,9L,12L,13L,11L,14L,19L,21L,18L,17L,19L,16L,11L,11L,16L,19L,17L,18L,21L,19L,14L,17L,25L,30L,27L,29L,34L,31L,23L,22L,29L,31L,26L,23L,25L,20L,13L,13L,20L,25L,23L,26L,31L,29L,22L,23L,31L,34L,29L,27L,30L,25L,17L,20L,31L,39L,36L,41L,49L,46L,35L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153162Inst : IEnumerable<long>
{
public static readonly long[] Value=A153162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153162.Bytes);
public long this[int i]=>Value[i];

public static A153162Inst Instance=new A153162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153163
{
public static readonly long[] Value={ 4L,4L,2L,1L,2L,9L,4L,5L,8L,9L,1L,5L,0L,0L,7L,4L,9L,2L,2L,9L,9L,5L,9L,2L,1L,0L,8L,1L,9L,0L,8L,6L,7L,0L,2L,9L,6L,9L,3L,4L,7L,8L,2L,0L,7L,3L,5L,3L,1L,1L,3L,3L,0L,8L,0L,5L,6L,1L,1L,8L,4L,6L,9L,3L,2L,9L,1L,1L,5L,6L,4L,5L,5L,2L,0L,4L,4L,4L,8L,5L,8L,6L,7L,6L,6L,3L,5L,0L,0L,1L,1L,3L,3L,6L,9L,6L,5L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153163Inst : IEnumerable<long>
{
public static readonly long[] Value=A153163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153163.Bytes);
public long this[int i]=>Value[i];

public static A153163Inst Instance=new A153163Inst();

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