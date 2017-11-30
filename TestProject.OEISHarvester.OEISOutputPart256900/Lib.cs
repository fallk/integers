using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A139762
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,6L,12L,10L,9L,18L,10L,3L,6L,10L,6L,12L,10L,9L,18L,19L,12L,6L,10L,6L,12L,10L,9L,18L,19L,21L,6L,10L,6L,12L,10L,9L,18L,19L,21L,15L,10L,6L,12L,10L,9L,18L,19L,21L,15L,19L,15L,12L,10L,9L,18L,19L,21L,15L,19L,24L,12L,10L,9L,18L,19L,21L,15L,19L,24L,21L,10L,9L,18L,19L,21L,15L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139762Inst : IEnumerable<long>
{
public static readonly long[] Value=A139762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139762.Bytes);
public long this[int i]=>Value[i];

public static A139762Inst Instance=new A139762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139763
{
public static readonly long[] Value={ 1L,2L,3L,4L,11L,22L,43L,84L,171L,342L,683L,1364L,2731L,5462L,10923L,21844L,43691L,87382L,174763L,349524L,699051L,1398102L,2796203L,5592404L,11184811L,22369622L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139763Inst : IEnumerable<long>
{
public static readonly long[] Value=A139763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139763.Bytes);
public long this[int i]=>Value[i];

public static A139763Inst Instance=new A139763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139764
{
public static readonly long[] Value={ 1L,2L,3L,1L,5L,1L,2L,8L,1L,2L,3L,1L,13L,1L,2L,3L,1L,5L,1L,2L,21L,1L,2L,3L,1L,5L,1L,2L,8L,1L,2L,3L,1L,34L,1L,2L,3L,1L,5L,1L,2L,8L,1L,2L,3L,1L,13L,1L,2L,3L,1L,5L,1L,2L,55L,1L,2L,3L,1L,5L,1L,2L,8L,1L,2L,3L,1L,13L,1L,2L,3L,1L,5L,1L,2L,21L,1L,2L,3L,1L,5L,1L,2L,8L,1L,2L,3L,1L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139764Inst : IEnumerable<long>
{
public static readonly long[] Value=A139764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139764.Bytes);
public long this[int i]=>Value[i];

public static A139764Inst Instance=new A139764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139765
{
public static readonly long[] Value={ 83L,101L,239L,599L,1019L,2269L,4079L,7019L,10103L,61169L,145777L,230327L,312101L,336989L,352229L,544109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139765Inst : IEnumerable<long>
{
public static readonly long[] Value=A139765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139765.Bytes);
public long this[int i]=>Value[i];

public static A139765Inst Instance=new A139765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139766
{
public static readonly long[] Value={ 3L,15L,104L,164L,255L,2625L,2834L,11715L,18315L,48704L,49215L,64004L,65535L,73124L,131144L,215775L,491535L,525986L,546272L,568815L,952575L,1925564L,5781434L,5861583L,13496384L,14409548L,17646615L,17949434L,20171384L,21475124L,22632285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139766Inst : IEnumerable<long>
{
public static readonly long[] Value=A139766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139766.Bytes);
public long this[int i]=>Value[i];

public static A139766Inst Instance=new A139766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139767
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,1L,3L,2L,1L,3L,2L,2L,2L,1L,4L,3L,3L,1L,2L,2L,2L,4L,2L,3L,3L,1L,2L,3L,1L,1L,5L,3L,1L,3L,2L,3L,4L,3L,2L,2L,1L,4L,2L,3L,3L,5L,2L,2L,3L,1L,2L,4L,1L,2L,2L,2L,3L,3L,3L,2L,3L,2L,6L,4L,1L,3L,4L,2L,1L,3L,2L,3L,3L,1L,3L,4L,5L,2L,2L,3L,1L,4L,2L,2L,3L,1L,3L,3L,1L,1L,2L,3L,2L,6L,2L,2L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139767Inst : IEnumerable<long>
{
public static readonly long[] Value=A139767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139767.Bytes);
public long this[int i]=>Value[i];

public static A139767Inst Instance=new A139767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139832
{
public static readonly long[] Value={ 7L,43L,67L,103L,127L,163L,223L,283L,307L,367L,463L,487L,523L,547L,607L,643L,727L,787L,823L,883L,907L,967L,1063L,1087L,1123L,1303L,1327L,1423L,1447L,1483L,1543L,1567L,1627L,1663L,1723L,1747L,1783L,1867L,1987L,2083L,2143L,2203L,2287L,2347L,2383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139832Inst : IEnumerable<long>
{
public static readonly long[] Value=A139832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139832.Bytes);
public long this[int i]=>Value[i];

public static A139832Inst Instance=new A139832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139833
{
public static readonly long[] Value={ 2L,29L,41L,53L,89L,113L,173L,257L,269L,281L,293L,317L,401L,449L,509L,521L,569L,641L,677L,773L,797L,857L,941L,953L,977L,1097L,1181L,1193L,1229L,1361L,1409L,1433L,1481L,1553L,1637L,1709L,1877L,1889L,1913L,1997L,2081L,2141L,2237L,2273L,2309L,2333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139833Inst : IEnumerable<long>
{
public static readonly long[] Value=A139833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139833.Bytes);
public long this[int i]=>Value[i];

public static A139833Inst Instance=new A139833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139834
{
public static readonly long[] Value={ 11L,23L,47L,83L,131L,191L,239L,251L,263L,311L,347L,359L,419L,443L,467L,479L,491L,503L,587L,647L,719L,947L,1031L,1103L,1151L,1163L,1187L,1223L,1259L,1451L,1487L,1499L,1559L,1583L,1607L,1619L,1787L,1811L,1847L,1871L,1907L,2039L,2063L,2087L,2099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139834Inst : IEnumerable<long>
{
public static readonly long[] Value=A139834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139834.Bytes);
public long this[int i]=>Value[i];

public static A139834Inst Instance=new A139834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139835
{
public static readonly long[] Value={ 2L,43L,47L,67L,83L,103L,127L,223L,263L,307L,383L,443L,463L,467L,523L,563L,587L,647L,727L,863L,883L,967L,1063L,1087L,1103L,1123L,1223L,1283L,1307L,1327L,1427L,1447L,1483L,1487L,1543L,1583L,1607L,1667L,1747L,1783L,1787L,1823L,1987L,2027L,2083L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139835Inst : IEnumerable<long>
{
public static readonly long[] Value=A139835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139835.Bytes);
public long this[int i]=>Value[i];

public static A139835Inst Instance=new A139835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139836
{
public static readonly long[] Value={ 11L,31L,71L,79L,131L,139L,199L,211L,311L,379L,419L,431L,439L,479L,499L,571L,619L,691L,719L,751L,811L,839L,911L,991L,1031L,1051L,1091L,1151L,1231L,1319L,1399L,1439L,1451L,1459L,1499L,1559L,1571L,1831L,1931L,1979L,1999L,2011L,2111L,2131L,2179L,2239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139836Inst : IEnumerable<long>
{
public static readonly long[] Value=A139836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139836.Bytes);
public long this[int i]=>Value[i];

public static A139836Inst Instance=new A139836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139837
{
public static readonly long[] Value={ 23L,31L,47L,71L,103L,191L,199L,223L,311L,367L,383L,463L,487L,599L,631L,647L,719L,727L,751L,823L,839L,863L,911L,983L,991L,1039L,1087L,1103L,1279L,1303L,1367L,1423L,1439L,1511L,1543L,1567L,1607L,1783L,1831L,1871L,1879L,1951L,2039L,2143L,2311L,2399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139837Inst : IEnumerable<long>
{
public static readonly long[] Value=A139837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139837.Bytes);
public long this[int i]=>Value[i];

public static A139837Inst Instance=new A139837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139838
{
public static readonly long[] Value={ 13L,29L,61L,101L,109L,149L,173L,197L,277L,293L,349L,373L,461L,541L,557L,613L,677L,701L,733L,821L,853L,877L,941L,997L,1069L,1117L,1229L,1381L,1429L,1493L,1597L,1613L,1669L,1693L,1733L,1789L,1861L,1877L,1933L,1949L,1997L,2053L,2141L,2213L,2221L,2309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139838Inst : IEnumerable<long>
{
public static readonly long[] Value=A139838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139838.Bytes);
public long this[int i]=>Value[i];

public static A139838Inst Instance=new A139838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139839
{
public static readonly long[] Value={ 2L,47L,59L,71L,107L,131L,191L,227L,311L,359L,419L,431L,443L,467L,479L,503L,563L,599L,659L,683L,839L,887L,971L,1031L,1103L,1151L,1163L,1187L,1223L,1259L,1307L,1427L,1451L,1523L,1559L,1583L,1619L,1787L,1823L,1847L,1907L,1931L,2003L,2087L,2267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139839Inst : IEnumerable<long>
{
public static readonly long[] Value=A139839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139839.Bytes);
public long this[int i]=>Value[i];

public static A139839Inst Instance=new A139839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139840
{
public static readonly long[] Value={ 17L,29L,53L,89L,137L,197L,269L,353L,389L,401L,449L,461L,509L,557L,569L,641L,677L,761L,773L,797L,809L,821L,881L,929L,941L,953L,1013L,1049L,1097L,1109L,1181L,1193L,1277L,1301L,1481L,1553L,1697L,1877L,1889L,1913L,1949L,1997L,2069L,2129L,2213L,2297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139840Inst : IEnumerable<long>
{
public static readonly long[] Value=A139840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139840.Bytes);
public long this[int i]=>Value[i];

public static A139840Inst Instance=new A139840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139841
{
public static readonly long[] Value={ 2L,53L,59L,83L,101L,149L,179L,251L,293L,389L,443L,461L,467L,491L,509L,557L,563L,587L,659L,701L,773L,797L,971L,1019L,1109L,1181L,1259L,1277L,1283L,1301L,1307L,1373L,1427L,1613L,1619L,1667L,1709L,1733L,1787L,1811L,1973L,1997L,2027L,2099L,2141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139841Inst : IEnumerable<long>
{
public static readonly long[] Value=A139841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139841.Bytes);
public long this[int i]=>Value[i];

public static A139841Inst Instance=new A139841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139842
{
public static readonly long[] Value={ 3L,37L,61L,109L,139L,163L,181L,211L,277L,283L,379L,397L,499L,541L,547L,571L,619L,643L,691L,709L,787L,811L,853L,877L,907L,997L,1051L,1093L,1117L,1213L,1459L,1621L,1627L,1669L,1693L,1723L,1741L,1867L,1933L,2011L,2029L,2131L,2179L,2203L,2221L,2251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139842Inst : IEnumerable<long>
{
public static readonly long[] Value=A139842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139842.Bytes);
public long this[int i]=>Value[i];

public static A139842Inst Instance=new A139842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139843
{
public static readonly long[] Value={ 17L,23L,41L,71L,113L,167L,233L,311L,401L,431L,449L,479L,503L,521L,617L,641L,719L,743L,809L,839L,857L,881L,887L,911L,929L,983L,1031L,1049L,1151L,1193L,1217L,1289L,1319L,1367L,1433L,1439L,1553L,1559L,1601L,1697L,1847L,2063L,2081L,2111L,2153L,2207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139843Inst : IEnumerable<long>
{
public static readonly long[] Value=A139843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139843.Bytes);
public long this[int i]=>Value[i];

public static A139843Inst Instance=new A139843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139844
{
public static readonly long[] Value={ 2L,53L,113L,137L,197L,233L,317L,557L,617L,653L,953L,977L,1373L,1493L,1733L,1877L,1913L,1997L,2153L,2213L,2237L,2297L,2333L,2417L,2633L,2657L,2753L,2837L,3137L,3257L,3413L,3557L,3593L,3677L,3833L,3917L,4013L,4253L,4337L,4397L,4517L,4673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139844Inst : IEnumerable<long>
{
public static readonly long[] Value=A139844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139844.Bytes);
public long this[int i]=>Value[i];

public static A139844Inst Instance=new A139844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139845
{
public static readonly long[] Value={ 3L,47L,83L,167L,227L,383L,467L,503L,563L,587L,647L,887L,983L,1223L,1307L,1427L,1487L,1823L,1847L,1907L,2063L,2243L,2267L,2663L,2687L,2903L,3023L,3083L,3167L,3323L,3407L,3527L,3863L,3923L,3947L,4007L,4283L,4583L,4703L,4787L,5003L,5087L,5507L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139845Inst : IEnumerable<long>
{
public static readonly long[] Value=A139845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139845.Bytes);
public long this[int i]=>Value[i];

public static A139845Inst Instance=new A139845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139846
{
public static readonly long[] Value={ 5L,41L,89L,101L,269L,461L,509L,521L,761L,881L,929L,941L,1049L,1109L,1181L,1301L,1361L,1601L,1721L,1889L,1949L,2141L,2309L,2441L,2609L,2621L,2729L,2789L,2861L,3041L,3209L,3449L,3461L,3701L,3821L,3881L,3989L,4049L,4241L,4289L,4409L,4721L,4889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139846Inst : IEnumerable<long>
{
public static readonly long[] Value=A139846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139846.Bytes);
public long this[int i]=>Value[i];

public static A139846Inst Instance=new A139846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139847
{
public static readonly long[] Value={ 19L,31L,139L,199L,271L,439L,619L,691L,811L,859L,1039L,1231L,1279L,1291L,1399L,1459L,1531L,1699L,1879L,1951L,2131L,2239L,2371L,2539L,2551L,2659L,2719L,2791L,2971L,3079L,3331L,3391L,3499L,3559L,3631L,3919L,4051L,4219L,4231L,4339L,4591L,4639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139847Inst : IEnumerable<long>
{
public static readonly long[] Value=A139847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139847.Bytes);
public long this[int i]=>Value[i];

public static A139847Inst Instance=new A139847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139896
{
public static readonly long[] Value={ 31L,47L,79L,127L,191L,263L,271L,311L,359L,367L,479L,503L,599L,607L,727L,743L,751L,823L,839L,887L,911L,967L,983L,1063L,1087L,1279L,1303L,1319L,1423L,1439L,1447L,1471L,1487L,1511L,1583L,1607L,1663L,1759L,1783L,1871L,1951L,1999L,2143L,2207L,2351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139896Inst : IEnumerable<long>
{
public static readonly long[] Value=A139896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139896.Bytes);
public long this[int i]=>Value[i];

public static A139896Inst Instance=new A139896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139897
{
public static readonly long[] Value={ 3L,83L,107L,227L,347L,443L,467L,563L,587L,683L,827L,947L,1163L,1187L,1283L,1307L,1427L,1523L,1667L,1787L,1907L,2003L,2027L,2243L,2267L,2843L,2963L,3083L,3203L,3323L,3347L,3467L,3803L,3923L,3947L,4283L,4523L,4547L,4643L,4787L,5003L,5147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139897Inst : IEnumerable<long>
{
public static readonly long[] Value=A139897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139897.Bytes);
public long this[int i]=>Value[i];

public static A139897Inst Instance=new A139897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139898
{
public static readonly long[] Value={ 61L,109L,181L,229L,349L,421L,541L,661L,709L,829L,1021L,1069L,1381L,1429L,1549L,1621L,1669L,1741L,1789L,1861L,2029L,2221L,2269L,2341L,2389L,2749L,3061L,3109L,3181L,3229L,3301L,3469L,3541L,3709L,4021L,4261L,4549L,4621L,4789L,4861L,4909L,5101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139898Inst : IEnumerable<long>
{
public static readonly long[] Value=A139898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139898.Bytes);
public long this[int i]=>Value[i];

public static A139898Inst Instance=new A139898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139899
{
public static readonly long[] Value={ 5L,53L,173L,197L,293L,317L,557L,653L,677L,773L,797L,1013L,1277L,1373L,1493L,1613L,1637L,1733L,1877L,1973L,1997L,2213L,2237L,2333L,2357L,2477L,2693L,2837L,2957L,3413L,3533L,3557L,3677L,3797L,3917L,4013L,4133L,4157L,4253L,4373L,4397L,4493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139899Inst : IEnumerable<long>
{
public static readonly long[] Value=A139899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139899.Bytes);
public long this[int i]=>Value[i];

public static A139899Inst Instance=new A139899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139900
{
public static readonly long[] Value={ 23L,47L,167L,263L,383L,503L,647L,743L,863L,887L,983L,1103L,1223L,1367L,1487L,1583L,1607L,1823L,1847L,2063L,2087L,2207L,2423L,2447L,2543L,2663L,2687L,2903L,2927L,3023L,3167L,3407L,3527L,3623L,3767L,3863L,4007L,4127L,4463L,4583L,4703L,4943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139900Inst : IEnumerable<long>
{
public static readonly long[] Value=A139900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139900.Bytes);
public long this[int i]=>Value[i];

public static A139900Inst Instance=new A139900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139901
{
public static readonly long[] Value={ 31L,79L,151L,199L,271L,439L,631L,751L,919L,991L,1039L,1231L,1279L,1399L,1471L,1759L,1831L,1879L,1951L,1999L,2239L,2311L,2551L,2671L,2719L,2791L,3079L,3271L,3319L,3391L,3511L,3559L,3631L,3919L,4111L,4159L,4231L,4519L,4591L,4639L,4759L,4831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139901Inst : IEnumerable<long>
{
public static readonly long[] Value=A139901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139901.Bytes);
public long this[int i]=>Value[i];

public static A139901Inst Instance=new A139901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139902
{
public static readonly long[] Value={ 19L,139L,211L,331L,379L,499L,571L,619L,691L,739L,811L,859L,1051L,1171L,1291L,1459L,1531L,1579L,1699L,2011L,2131L,2179L,2251L,2371L,2539L,2659L,2731L,2851L,2971L,3019L,3259L,3331L,3499L,3571L,3691L,3739L,3931L,4051L,4099L,4219L,4339L,4651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139902Inst : IEnumerable<long>
{
public static readonly long[] Value=A139902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139902.Bytes);
public long this[int i]=>Value[i];

public static A139902Inst Instance=new A139902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139903
{
public static readonly long[] Value={ 17L,113L,137L,233L,257L,353L,593L,617L,857L,953L,977L,1097L,1193L,1217L,1433L,1553L,1697L,1913L,2153L,2273L,2297L,2393L,2417L,2633L,2657L,2753L,2777L,2897L,3137L,3257L,3593L,3617L,3833L,4073L,4217L,4337L,4457L,4673L,4793L,4817L,4937L,5153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139903Inst : IEnumerable<long>
{
public static readonly long[] Value=A139903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139903.Bytes);
public long this[int i]=>Value[i];

public static A139903Inst Instance=new A139903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139904
{
public static readonly long[] Value={ 2L,127L,131L,139L,151L,167L,211L,239L,271L,307L,347L,439L,491L,547L,607L,739L,811L,887L,967L,1051L,1151L,1163L,1223L,1231L,1283L,1319L,1327L,1427L,1451L,1531L,1559L,1619L,1823L,1867L,1979L,1987L,2063L,2111L,2239L,2243L,2339L,2371L,2543L,2647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139904Inst : IEnumerable<long>
{
public static readonly long[] Value=A139904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139904.Bytes);
public long this[int i]=>Value[i];

public static A139904Inst Instance=new A139904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139905
{
public static readonly long[] Value={ 11L,23L,67L,103L,191L,199L,251L,367L,379L,383L,419L,467L,619L,631L,643L,727L,751L,839L,907L,911L,971L,983L,1103L,1123L,1171L,1259L,1279L,1303L,1307L,1367L,1423L,1483L,1523L,1571L,1607L,1699L,1747L,1831L,1907L,1951L,2011L,2039L,2179L,2311L,2399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139905Inst : IEnumerable<long>
{
public static readonly long[] Value=A139905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139905.Bytes);
public long this[int i]=>Value[i];

public static A139905Inst Instance=new A139905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139906
{
public static readonly long[] Value={ 17L,61L,109L,149L,241L,281L,293L,337L,373L,457L,557L,569L,613L,677L,701L,733L,769L,937L,941L,953L,1009L,1033L,1069L,1201L,1217L,1229L,1249L,1493L,1597L,1601L,1693L,1801L,1861L,1877L,1949L,1993L,1997L,2081L,2089L,2153L,2213L,2273L,2389L,2437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139906Inst : IEnumerable<long>
{
public static readonly long[] Value=A139906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139906.Bytes);
public long this[int i]=>Value[i];

public static A139906Inst Instance=new A139906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139907
{
public static readonly long[] Value={ 2L,137L,149L,197L,281L,317L,401L,449L,557L,617L,821L,977L,1061L,1229L,1289L,1373L,1409L,1493L,1709L,1877L,1913L,1997L,2069L,2153L,2333L,2381L,2633L,2657L,2741L,2801L,2969L,3089L,3257L,3413L,3557L,3581L,3593L,3677L,3833L,4253L,4337L,4349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139907Inst : IEnumerable<long>
{
public static readonly long[] Value=A139907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139907.Bytes);
public long this[int i]=>Value[i];

public static A139907Inst Instance=new A139907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139908
{
public static readonly long[] Value={ 3L,103L,139L,199L,283L,367L,439L,523L,607L,727L,859L,1039L,1063L,1231L,1291L,1447L,1459L,1483L,1531L,1543L,1699L,1951L,2131L,2239L,2287L,2383L,2467L,2539L,2551L,2707L,2791L,2887L,3163L,3331L,3559L,3631L,3643L,3727L,4003L,4339L,4423L,4507L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139908Inst : IEnumerable<long>
{
public static readonly long[] Value=A139908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139908.Bytes);
public long this[int i]=>Value[i];

public static A139908Inst Instance=new A139908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139909
{
public static readonly long[] Value={ 47L,59L,83L,167L,227L,383L,479L,587L,839L,983L,1151L,1259L,1307L,1319L,1487L,1571L,1931L,2099L,2243L,2267L,2351L,2399L,2411L,2579L,2663L,2819L,3023L,3083L,3167L,3191L,3323L,3359L,3491L,3659L,3671L,3863L,3911L,3947L,4259L,4283L,4451L,4583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139909Inst : IEnumerable<long>
{
public static readonly long[] Value=A139909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139909.Bytes);
public long this[int i]=>Value[i];

public static A139909Inst Instance=new A139909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139910
{
public static readonly long[] Value={ 7L,67L,151L,163L,331L,379L,463L,487L,499L,631L,739L,967L,1051L,1087L,1423L,1471L,1579L,1723L,1747L,1831L,2143L,2179L,2251L,2347L,2503L,2647L,2671L,2683L,2767L,3187L,3271L,3343L,3607L,3739L,3907L,3931L,4243L,4327L,4363L,4519L,4831L,4951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139910Inst : IEnumerable<long>
{
public static readonly long[] Value=A139910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139910.Bytes);
public long this[int i]=>Value[i];

public static A139910Inst Instance=new A139910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139911
{
public static readonly long[] Value={ 13L,73L,97L,229L,241L,349L,397L,409L,577L,661L,733L,769L,853L,1021L,1237L,1321L,1489L,1657L,1669L,1753L,1861L,2113L,2281L,2593L,2749L,2917L,2953L,3001L,3037L,3373L,3517L,3541L,3673L,3853L,4093L,4129L,4297L,4357L,4441L,4513L,4597L,4933L,5101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139911Inst : IEnumerable<long>
{
public static readonly long[] Value=A139911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139911.Bytes);
public long this[int i]=>Value[i];

public static A139911Inst Instance=new A139911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139992
{
public static readonly long[] Value={ 47L,167L,383L,503L,647L,887L,983L,1223L,1487L,1823L,1847L,2063L,2663L,2687L,2903L,3023L,3167L,3407L,3527L,3863L,4007L,4583L,4703L,5087L,5927L,6047L,6263L,6863L,7103L,7607L,7703L,7727L,8447L,8543L,8783L,9623L,9743L,9887L,10223L,10247L,10463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139992Inst : IEnumerable<long>
{
public static readonly long[] Value=A139992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139992.Bytes);
public long this[int i]=>Value[i];

public static A139992Inst Instance=new A139992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139993
{
public static readonly long[] Value={ 61L,181L,229L,349L,661L,829L,1021L,1069L,1669L,1741L,1861L,2029L,2341L,2749L,3181L,3541L,3709L,4021L,4261L,4549L,4861L,5101L,5701L,5869L,6229L,6709L,6781L,6949L,7069L,7549L,7621L,7741L,7789L,8221L,8389L,8461L,8581L,8629L,9421L,9901L,10069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139993Inst : IEnumerable<long>
{
public static readonly long[] Value=A139993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139993.Bytes);
public long this[int i]=>Value[i];

public static A139993Inst Instance=new A139993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139994
{
public static readonly long[] Value={ 59L,131L,251L,419L,971L,1091L,1259L,1571L,1811L,1931L,1979L,2099L,2411L,2579L,2819L,2939L,3251L,3491L,3659L,3779L,4091L,4259L,4451L,4931L,5099L,5171L,5939L,6011L,6131L,6299L,6779L,6971L,7019L,7451L,7691L,8291L,8699L,8819L,9371L,9491L,9539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139994Inst : IEnumerable<long>
{
public static readonly long[] Value=A139994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139994.Bytes);
public long this[int i]=>Value[i];

public static A139994Inst Instance=new A139994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139995
{
public static readonly long[] Value={ 41L,89L,521L,761L,881L,929L,1049L,1361L,1601L,1721L,1889L,2441L,2609L,2729L,3041L,3209L,3449L,3881L,4049L,4241L,4289L,4409L,4721L,4889L,5081L,5801L,6089L,6569L,6761L,7481L,7649L,8081L,8609L,9161L,9281L,9929L,10169L,10289L,10601L,11681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139995Inst : IEnumerable<long>
{
public static readonly long[] Value=A139995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139995.Bytes);
public long this[int i]=>Value[i];

public static A139995Inst Instance=new A139995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139996
{
public static readonly long[] Value={ 37L,277L,373L,613L,757L,877L,1093L,1117L,1213L,1453L,1597L,1933L,2053L,2293L,2437L,2557L,2797L,3613L,3637L,3733L,4813L,4957L,5077L,5413L,5653L,6133L,6637L,6997L,7333L,7477L,7933L,8317L,8677L,9013L,9157L,9277L,9613L,10333L,10357L,10453L,10837L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139996Inst : IEnumerable<long>
{
public static readonly long[] Value=A139996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139996.Bytes);
public long this[int i]=>Value[i];

public static A139996Inst Instance=new A139996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139997
{
public static readonly long[] Value={ 29L,149L,389L,701L,821L,1061L,1229L,1709L,1901L,2069L,2381L,2549L,2741L,2909L,3221L,3389L,3581L,4229L,4349L,4421L,5021L,5189L,5261L,5741L,5861L,6029L,6101L,6269L,6581L,6701L,6869L,7109L,7541L,7589L,7949L,8429L,9221L,9461L,9629L,9941L,10061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139997Inst : IEnumerable<long>
{
public static readonly long[] Value=A139997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139997.Bytes);
public long this[int i]=>Value[i];

public static A139997Inst Instance=new A139997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139998
{
public static readonly long[] Value={ 31L,199L,271L,439L,1039L,1231L,1279L,1399L,1879L,1951L,2239L,2551L,2719L,2791L,3079L,3391L,3559L,3631L,3919L,4231L,4591L,4639L,4759L,5431L,5479L,6079L,6151L,6271L,6991L,7159L,7591L,7759L,7951L,8431L,8599L,8839L,9439L,9511L,9631L,9679L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139998Inst : IEnumerable<long>
{
public static readonly long[] Value=A139998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139998.Bytes);
public long this[int i]=>Value[i];

public static A139998Inst Instance=new A139998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139999
{
public static readonly long[] Value={ 3L,443L,467L,587L,683L,947L,1307L,1523L,1787L,1907L,2003L,2027L,2267L,2843L,2963L,3083L,3323L,3347L,3947L,4283L,4547L,4643L,5003L,5483L,5867L,5987L,6323L,6803L,7043L,7187L,7283L,7307L,7547L,7643L,7907L,8123L,8243L,8363L,8387L,8627L,8867L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139999Inst : IEnumerable<long>
{
public static readonly long[] Value=A139999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139999.Bytes);
public long this[int i]=>Value[i];

public static A139999Inst Instance=new A139999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140000
{
public static readonly long[] Value={ 331L,379L,499L,619L,691L,859L,1171L,1291L,1699L,2011L,2179L,2539L,2731L,2971L,3019L,3259L,3331L,3499L,3931L,4051L,4339L,4651L,5179L,5659L,5779L,6451L,6571L,6691L,7219L,7459L,8011L,8419L,8539L,8779L,9091L,9619L,9739L,9859L,9931L,10099L,10459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140000Inst : IEnumerable<long>
{
public static readonly long[] Value=A140000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140000.Bytes);
public long this[int i]=>Value[i];

public static A140000Inst Instance=new A140000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140001
{
public static readonly long[] Value={ 5L,269L,389L,509L,1061L,1109L,1181L,1301L,1709L,1901L,2069L,2381L,2621L,2861L,2909L,3221L,3389L,3701L,3821L,4229L,4349L,5021L,5261L,5501L,5669L,5861L,6029L,6389L,6581L,6869L,7109L,7349L,7901L,8429L,8501L,8669L,9029L,9221L,9461L,9629L,9749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140001Inst : IEnumerable<long>
{
public static readonly long[] Value=A140001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140001.Bytes);
public long this[int i]=>Value[i];

public static A140001Inst Instance=new A140001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140002
{
public static readonly long[] Value={ 173L,197L,293L,557L,677L,1493L,1613L,1733L,1877L,1997L,2213L,2477L,2837L,3533L,3797L,4133L,4157L,4253L,4373L,4397L,4517L,4637L,5477L,5573L,5693L,5717L,6173L,7013L,7757L,7853L,8093L,8117L,8597L,9173L,9413L,9437L,9533L,9677L,10133L,10733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140002Inst : IEnumerable<long>
{
public static readonly long[] Value=A140002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140002.Bytes);
public long this[int i]=>Value[i];

public static A140002Inst Instance=new A140002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140003
{
public static readonly long[] Value={ 167L,263L,503L,743L,887L,1223L,1487L,1583L,1823L,1847L,2063L,2087L,2207L,2543L,2903L,3167L,3407L,3527L,3863L,4127L,4463L,4583L,4703L,4967L,5783L,5807L,5903L,6047L,6287L,6863L,7103L,7127L,7487L,7607L,7823L,8087L,8423L,8447L,8543L,8663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140003Inst : IEnumerable<long>
{
public static readonly long[] Value=A140003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140003.Bytes);
public long this[int i]=>Value[i];

public static A140003Inst Instance=new A140003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140004
{
public static readonly long[] Value={ 11L,131L,491L,659L,1019L,1091L,1451L,1619L,1811L,1931L,1979L,2339L,2411L,2459L,2939L,3011L,3251L,3299L,3539L,3659L,3779L,4091L,4259L,4451L,5051L,5099L,5651L,5939L,6299L,6899L,6971L,7211L,7499L,7691L,8219L,8291L,8819L,9011L,9059L,9371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140004Inst : IEnumerable<long>
{
public static readonly long[] Value=A140004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140004.Bytes);
public long this[int i]=>Value[i];

public static A140004Inst Instance=new A140004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140005
{
public static readonly long[] Value={ 113L,137L,257L,353L,617L,977L,1193L,1433L,1697L,2297L,2633L,2753L,2777L,2897L,3257L,3617L,3833L,4073L,4217L,4337L,4673L,4937L,5153L,5273L,5393L,5417L,5657L,5897L,6257L,6473L,6737L,6857L,6977L,7577L,7793L,8273L,8297L,8537L,9377L,9497L,9857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140005Inst : IEnumerable<long>
{
public static readonly long[] Value=A140005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140005.Bytes);
public long this[int i]=>Value[i];

public static A140005Inst Instance=new A140005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140006
{
public static readonly long[] Value={ 103L,223L,367L,463L,487L,727L,823L,1087L,1303L,1423L,1543L,1567L,1783L,2143L,2887L,3463L,3727L,3943L,4327L,4423L,4447L,4783L,5503L,5527L,5647L,5743L,6007L,6367L,6703L,6823L,6967L,7687L,8167L,8287L,8647L,9007L,9343L,9463L,9967L,10663L,11047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140006Inst : IEnumerable<long>
{
public static readonly long[] Value=A140006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140006.Bytes);
public long this[int i]=>Value[i];

public static A140006Inst Instance=new A140006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140007
{
public static readonly long[] Value={ 71L,191L,311L,599L,719L,839L,911L,1439L,1511L,1871L,2039L,2399L,2711L,3191L,3359L,3719L,4079L,4271L,4679L,4799L,4871L,5039L,5351L,5399L,5471L,5591L,5879L,6359L,6719L,6791L,6911L,7151L,8039L,8111L,8231L,8831L,8999L,9311L,9431L,9551L,9791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140007Inst : IEnumerable<long>
{
public static readonly long[] Value=A140007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140007.Bytes);
public long this[int i]=>Value[i];

public static A140007Inst Instance=new A140007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140120
{
public static readonly long[] Value={ 5L,13L,73L,433L,661L,2017L,3121L,6553L,16633L,47041L,53353L,55681L,116929L,159193L,198901L,216217L,223681L,250993L,256021L,364801L,404461L,444841L,938953L,988021L,1022113L,1299457L,1340929L,1476217L,1545001L,1640953L,1687393L,1932001L,1971181L,2030617L,2099593L,2119921L,2178541L,2301241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140120Inst : IEnumerable<long>
{
public static readonly long[] Value=A140120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140120.Bytes);
public long this[int i]=>Value[i];

public static A140120Inst Instance=new A140120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140121
{
public static readonly long[] Value={ 7L,17L,37L,673L,1153L,4093L,7393L,8641L,22501L,32401L,57601L,64513L,70753L,72901L,126733L,136897L,176401L,190093L,205201L,256033L,313597L,324901L,329473L,348097L,430333L,497017L,541693L,585217L,715681L,891133L,974161L,988033L,1238761L,1267873L,1416097L,1432801L,1664101L,1674433L,1742401L,1932037L,2005021L,2146201L,2238013L,2265001L,2480617L,2637373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140121Inst : IEnumerable<long>
{
public static readonly long[] Value=A140121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140121.Bytes);
public long this[int i]=>Value[i];

public static A140121Inst Instance=new A140121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140122
{
public static readonly long[] Value={ 1L,1L,7L,17L,209L,25L,37L,281L,9797L,92711L,120011L,1589737L,2027317L,30861373L,38322673L,735926129L,6107595203L,5188977503L,6040786643L,5218865543L,174771852097L,4738609625857L,5386574286277L,4776172794577L,197777244862999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140122Inst : IEnumerable<long>
{
public static readonly long[] Value=A140122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140122.Bytes);
public long this[int i]=>Value[i];

public static A140122Inst Instance=new A140122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140123
{
public static readonly long[] Value={ 4L,12L,36L,180L,1260L,252L,252L,2772L,69300L,900900L,900900L,15315300L,15315300L,290990700L,290990700L,6692786100L,46849502700L,46849502700L,46849502700L,46849502700L,1358635578300L,42117702927300L,42117702927300L,42117702927300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140123Inst : IEnumerable<long>
{
public static readonly long[] Value=A140123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140123.Bytes);
public long this[int i]=>Value[i];

public static A140123Inst Instance=new A140123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140124
{
public static readonly BigInteger[] Value={ 1L,20L,243L,3104L,46625L,823500L,16777159L,387420416L,9999999909L,285311670500L,8916100448123L,302875106592096L,11112006825557833L,437893890380859164L,18446744073709551375UL,BigInteger.Parse("827240261886336763904"),BigInteger.Parse("39346408075296537575117") };
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
public class A140124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140124Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A140124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140124.Bytes);
public BigInteger this[int i]=>Value[i];

public static A140124Inst Instance=new A140124Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140125
{
public static readonly long[] Value={ 1373L,1459L,1301L,1877L,1231L,1319L,1163L,1741L,1097L,1187L,1033L,1613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140125Inst : IEnumerable<long>
{
public static readonly long[] Value=A140125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140125.Bytes);
public long this[int i]=>Value[i];

public static A140125Inst Instance=new A140125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140126
{
public static readonly long[] Value={ 1L,3L,6L,11L,18L,26L,36L,48L,61L,79L,99L,126L,154L,187L,224L,266L,311L,358L,413L,471L,531L,593L,656L,721L,788L,861L,936L,1014L,1094L,1179L,1267L,1357L,1449L,1551L,1654L,1759L,1871L,1986L,2104L,2224L,2349L,2477L,2607L,2739L,2874L,3014L,3156L,3306L,3459L,3616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140126Inst : IEnumerable<long>
{
public static readonly long[] Value=A140126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140126.Bytes);
public long this[int i]=>Value[i];

public static A140126Inst Instance=new A140126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140127
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,-3L,5L,25L,621L,385613L,148697385121L,BigInteger.Parse("22110912341822991798377"),BigInteger.Parse("488892444587780299304228901641309659922062749"),BigInteger.Parse("239015822375015830469277614767879892635108603674971498096787773471947363213442923403867269") };
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
public class A140127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140127Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A140127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140127.Bytes);
public BigInteger this[int i]=>Value[i];

public static A140127Inst Instance=new A140127Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140128
{
public static readonly long[] Value={ 2L,3L,4L,14L,16L,21L,26L,33L,34L,35L,38L,44L,57L,75L,85L,86L,93L,94L,98L,104L,116L,118L,122L,133L,135L,141L,142L,145L,147L,152L,153L,158L,164L,170L,171L,174L,175L,177L,188L,189L,201L,202L,205L,207L,213L,214L,217L,218L,225L,230L,231L,242L,243L,244L,245L,253L,272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140128Inst : IEnumerable<long>
{
public static readonly long[] Value=A140128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140128.Bytes);
public long this[int i]=>Value[i];

public static A140128Inst Instance=new A140128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140129
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,2L,0L,1L,1L,3L,1L,3L,2L,3L,0L,1L,1L,3L,1L,5L,3L,7L,1L,5L,3L,7L,2L,5L,3L,4L,0L,1L,1L,3L,1L,5L,3L,7L,1L,9L,5L,11L,3L,13L,7L,15L,1L,9L,5L,11L,3L,13L,7L,15L,2L,9L,5L,11L,3L,7L,4L,5L,0L,1L,1L,3L,1L,5L,3L,7L,1L,9L,5L,11L,3L,13L,7L,15L,1L,17L,9L,19L,5L,21L,11L,23L,3L,25L,13L,27L,7L,29L,15L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140129Inst : IEnumerable<long>
{
public static readonly long[] Value=A140129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140129.Bytes);
public long this[int i]=>Value[i];

public static A140129Inst Instance=new A140129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140130
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,4L,2L,4L,1L,2L,1L,1L,1L,8L,4L,8L,2L,8L,4L,8L,1L,4L,2L,4L,1L,2L,1L,1L,1L,16L,8L,16L,4L,16L,8L,16L,2L,16L,8L,16L,4L,16L,8L,16L,1L,8L,4L,8L,2L,8L,4L,8L,1L,4L,2L,4L,1L,2L,1L,1L,1L,32L,16L,32L,8L,32L,16L,32L,4L,32L,16L,32L,8L,32L,16L,32L,2L,32L,16L,32L,8L,32L,16L,32L,4L,32L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140130Inst : IEnumerable<long>
{
public static readonly long[] Value=A140130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140130.Bytes);
public long this[int i]=>Value[i];

public static A140130Inst Instance=new A140130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140131
{
public static readonly long[] Value={ 0L,1L,2L,6L,16L,35L,66L,121L,203L,333L,550L,902L,1473L,2401L,3896L,6330L,10264L,16619L,26919L,43588L,70562L,114198L,184804L,299051L,483906L,783013L,1266971L,2050038L,3317059L,5367143L,8684259L,14051473L,22735799L,36787341L,59523223L,96310634L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140131Inst : IEnumerable<long>
{
public static readonly long[] Value=A140131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140131.Bytes);
public long this[int i]=>Value[i];

public static A140131Inst Instance=new A140131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140132
{
public static readonly long[] Value={ 0L,1L,2L,6L,7L,8L,3L,4L,5L,9L,10L,11L,6L,7L,8L,3L,4L,5L,9L,10L,11L,6L,7L,8L,3L,4L,5L,9L,10L,11L,6L,7L,8L,3L,4L,5L,9L,10L,11L,6L,7L,8L,3L,4L,5L,9L,10L,11L,6L,7L,8L,3L,4L,5L,9L,10L,11L,6L,7L,8L,3L,4L,5L,9L,10L,11L,6L,7L,8L,3L,4L,5L,9L,10L,11L,6L,7L,8L,3L,4L,5L,9L,10L,11L,6L,7L,8L,3L,4L,5L,9L,10L,11L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140132Inst : IEnumerable<long>
{
public static readonly long[] Value=A140132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140132.Bytes);
public long this[int i]=>Value[i];

public static A140132Inst Instance=new A140132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140133
{
public static readonly long[] Value={ 1L,8L,5L,3L,2L,6L,8L,4L,4L,8L,7L,0L,7L,9L,8L,7L,0L,3L,3L,2L,2L,1L,9L,3L,6L,4L,0L,3L,4L,3L,9L,7L,2L,7L,8L,8L,7L,9L,4L,6L,9L,6L,5L,3L,8L,9L,6L,3L,2L,5L,4L,6L,4L,0L,1L,3L,5L,5L,7L,8L,1L,0L,0L,2L,0L,6L,7L,8L,7L,9L,7L,3L,6L,5L,0L,8L,5L,1L,6L,6L,2L,7L,1L,1L,7L,1L,3L,3L,4L,8L,8L,5L,5L,6L,9L,0L,2L,5L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140133Inst : IEnumerable<long>
{
public static readonly long[] Value=A140133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140133.Bytes);
public long this[int i]=>Value[i];

public static A140133Inst Instance=new A140133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140134
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,63L,126L,252L,504L,1008L,2016L,4032L,8001L,16002L,32004L,63000L,126000L,252000L,504000L,1008000L,2016000L,4032000L,8001000L,16002000L,32004000L,63000000L,126000000L,252000000L,504000000L,1008000000L,2016000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140134Inst : IEnumerable<long>
{
public static readonly long[] Value=A140134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140134.Bytes);
public long this[int i]=>Value[i];

public static A140134Inst Instance=new A140134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140135
{
public static readonly long[] Value={ 16L,24L,36L,54L,54L,81L,100L,140L,140L,140L,196L,225L,315L,315L,315L,315L,315L,441L,484L,550L,550L,625L,676L,858L,858L,858L,858L,858L,858L,1089L,1156L,1225L,1330L,1330L,1444L,1521L,1794L,1794L,1794L,1794L,1794L,1794L,2116L,2254L,2254L,2401L,2499L,2601L,2805L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140135Inst : IEnumerable<long>
{
public static readonly long[] Value=A140135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140135.Bytes);
public long this[int i]=>Value[i];

public static A140135Inst Instance=new A140135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140168
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,1L,8L,3L,3L,1L,16L,5L,9L,2L,1L,32L,11L,23L,7L,4L,1L,64L,21L,57L,16L,15L,3L,1L,128L,43L,135L,41L,46L,12L,5L,1L,256L,85L,313L,94L,133L,34L,22L,4L,1L,512L,171L,711L,219L,360L,99L,78L,18L,6L,1L,1024L,341L,1593L,492L,939L,261L,255L,60L,30L,5L,1L,2048L,683L,3527L,1101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140168Inst : IEnumerable<long>
{
public static readonly long[] Value=A140168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140168.Bytes);
public long this[int i]=>Value[i];

public static A140168Inst Instance=new A140168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140169
{
public static readonly long[] Value={ 1L,2L,1L,4L,3L,2L,8L,7L,10L,2L,16L,15L,34L,12L,4L,32L,31L,98L,46L,32L,4L,64L,63L,258L,144L,156L,36L,8L,128L,127L,642L,402L,600L,192L,88L,8L,256L,255L,1358L,1044L,2004L,792L,560L,96L,16L,512L,511L,3586L,2582L,6096L,2796L,2704L,656L,224L,16L,1024L,1023L,8194L,6168L,17356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140169Inst : IEnumerable<long>
{
public static readonly long[] Value=A140169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140169.Bytes);
public long this[int i]=>Value[i];

public static A140169Inst Instance=new A140169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140170
{
public static readonly long[] Value={ 1L,2L,42L,521L,4624L,347352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140170Inst : IEnumerable<long>
{
public static readonly long[] Value=A140170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140170.Bytes);
public long this[int i]=>Value[i];

public static A140170Inst Instance=new A140170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140171
{
public static readonly long[] Value={ 18303877L,91744613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140171Inst : IEnumerable<long>
{
public static readonly long[] Value=A140171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140171.Bytes);
public long this[int i]=>Value[i];

public static A140171Inst Instance=new A140171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140172
{
public static readonly long[] Value={ 1L,32L,49L,100L,392L,784L,1000L,1125L,1152L,1323L,1444L,1521L,3200L,3364L,3456L,4096L,4225L,4356L,4563L,4900L,7225L,7744L,8281L,8748L,9604L,10000L,10125L,10976L,11025L,12167L,12321L,12348L,12996L,13824L,14112L,14283L,14641L,15625L,17424L,17672L,17956L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140172Inst : IEnumerable<long>
{
public static readonly long[] Value=A140172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140172.Bytes);
public long this[int i]=>Value[i];

public static A140172Inst Instance=new A140172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140173
{
public static readonly long[] Value={ 1L,6L,3720L,25080L,237000L,353430L,1201560L,1402440L,2104440L,2147040L,4140360L,22007160L,60035220L,104370420L,110095020L,136222020L,402500280L,2203551000L,2223003120L,8720021310L,35590401000L,110232105060L,116046010080L,212062116000L,440401221000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140173Inst : IEnumerable<long>
{
public static readonly long[] Value=A140173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140173.Bytes);
public long this[int i]=>Value[i];

public static A140173Inst Instance=new A140173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140174
{
public static readonly long[] Value={ 0L,2L,30L,1122L,24300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140174Inst : IEnumerable<long>
{
public static readonly long[] Value=A140174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140174.Bytes);
public long this[int i]=>Value[i];

public static A140174Inst Instance=new A140174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140175
{
public static readonly long[] Value={ 4621L,34361L,2881861L,63882851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140175Inst : IEnumerable<long>
{
public static readonly long[] Value=A140175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140175.Bytes);
public long this[int i]=>Value[i];

public static A140175Inst Instance=new A140175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140176
{
public static readonly long[] Value={ 1L,3L,8L,17L,36L,71L,144L,289L,594L,1231L,2602L,5573L,12128L,26727L,59668L,134729L,307618L,709503L,1652402L,3883445L,9206712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140176Inst : IEnumerable<long>
{
public static readonly long[] Value=A140176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140176.Bytes);
public long this[int i]=>Value[i];

public static A140176Inst Instance=new A140176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140177
{
public static readonly long[] Value={ 1L,4L,25L,171L,1024L,5452L,27319L,133343L,650240L,3183136L,15730003L,78792479L,401274724L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140177Inst : IEnumerable<long>
{
public static readonly long[] Value=A140177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140177.Bytes);
public long this[int i]=>Value[i];

public static A140177Inst Instance=new A140177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140178
{
public static readonly long[] Value={ 1L,4L,32L,427L,7396L,130612L,2097152L,30417025L,409957616L,5282779354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140178Inst : IEnumerable<long>
{
public static readonly long[] Value=A140178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140178.Bytes);
public long this[int i]=>Value[i];

public static A140178Inst Instance=new A140178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140179
{
public static readonly long[] Value={ 1L,4L,32L,512L,14513L,603485L,29856303L,1487335683L,68719476736L,2898212537994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140179Inst : IEnumerable<long>
{
public static readonly long[] Value=A140179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140179.Bytes);
public long this[int i]=>Value[i];

public static A140179Inst Instance=new A140179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140180
{
public static readonly long[] Value={ 1L,2L,5L,10L,11L,13L,16L,22L,23L,25L,26L,28L,29L,33L,35L,36L,39L,40L,41L,43L,46L,50L,52L,53L,56L,58L,61L,63L,65L,66L,67L,70L,73L,78L,81L,82L,83L,86L,88L,89L,92L,93L,95L,96L,100L,101L,105L,106L,111L,112L,113L,116L,119L,122L,124L,125L,126L,127L,130L,131L,134L,136L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140180Inst : IEnumerable<long>
{
public static readonly long[] Value=A140180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140180.Bytes);
public long this[int i]=>Value[i];

public static A140180Inst Instance=new A140180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140181
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,12L,14L,15L,17L,18L,19L,20L,21L,24L,27L,30L,31L,32L,34L,37L,38L,42L,44L,45L,47L,48L,49L,51L,54L,55L,57L,59L,60L,62L,64L,68L,69L,71L,72L,74L,75L,76L,77L,79L,80L,84L,85L,87L,90L,91L,94L,97L,98L,99L,102L,103L,104L,107L,108L,109L,110L,114L,115L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140181Inst : IEnumerable<long>
{
public static readonly long[] Value=A140181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140181.Bytes);
public long this[int i]=>Value[i];

public static A140181Inst Instance=new A140181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140182
{
public static readonly long[] Value={ 1L,2L,3L,3L,7L,1L,4L,12L,4L,3L,5L,18L,10L,13L,1L,6L,25L,20L,35L,6L,3L,7L,33L,35L,75L,21L,19L,1L,8L,42L,56L,140L,56L,70L,8L,3L,9L,52L,84L,238L,126L,196L,36L,25L,1L,10L,63L,120L,378L,252L,462L,120L,117L,10L,3L,11L,75L,165L,570L,462L,966L,330L,405L,55L,31L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140182Inst : IEnumerable<long>
{
public static readonly long[] Value=A140182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140182.Bytes);
public long this[int i]=>Value[i];

public static A140182Inst Instance=new A140182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140183
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,1L,4L,9L,4L,2L,5L,14L,10L,9L,1L,6L,20L,20L,25L,6L,2L,7L,27L,35L,55L,21L,13L,1L,8L,35L,56L,105L,56L,49L,8L,2L,9L,44L,84L,182L,126L,140L,36L,17L,1L,10L,54L,120L,294L,252L,336L,120L,81L,10L,2L,1L,65L,165L,450L,462L,714L,330L,285L,55L,21L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140183Inst : IEnumerable<long>
{
public static readonly long[] Value=A140183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140183.Bytes);
public long this[int i]=>Value[i];

public static A140183Inst Instance=new A140183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140216
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-3L,1L,-1L,3L,-2L,1L,1L,-5L,2L,-5L,1L,-1L,5L,-1L,5L,-3L,1L,1L,-7L,1L,0L,3L,-7L,1L,-1L,7L,-4L,0L,2L,7L,-4L,1L,1L,3L,4L,-21L,-2L,21L,4L,-9L,1L,-1L,-3L,13L,21L,-26L,-21L,10L,9L,-5L,1L,1L,-121L,-13L,66L,26L,-231L,-10L,33L,5L,-11L,1L,-1L,121L,-142L,-66L,229L,231L,-116L,-33L,25L,11L,-6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140216Inst : IEnumerable<long>
{
public static readonly long[] Value=A140216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140216.Bytes);
public long this[int i]=>Value[i];

public static A140216Inst Instance=new A140216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140217
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,34L,730L,4376L,905345L,10601986L,10009765626L,200097656252L,2177748514672962L,85812416258106784L,BigInteger.Parse("4142789042980129347156"),BigInteger.Parse("289904403212517959978240"),BigInteger.Parse("175519033940460517461369847809") };
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
public class A140217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140217Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A140217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140217.Bytes);
public BigInteger this[int i]=>Value[i];

public static A140217Inst Instance=new A140217Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140218
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,4L,1L,2L,1L,1L,4L,1L,2L,1L,1L,1L,4L,1L,1L,1L,2L,1L,1L,4L,1L,1L,1L,2L,1L,1L,1L,8L,1L,2L,1L,4L,1L,2L,1L,1L,8L,1L,2L,1L,4L,1L,2L,1L,1L,1L,8L,1L,1L,1L,4L,1L,2L,1L,2L,1L,1L,8L,1L,1L,1L,4L,1L,2L,1L,2L,1L,1L,1L,8L,1L,2L,1L,2L,1L,2L,1L,4L,1L,2L,1L,1L,8L,1L,2L,1L,2L,1L,2L,1L,4L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140218Inst : IEnumerable<long>
{
public static readonly long[] Value=A140218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140218.Bytes);
public long this[int i]=>Value[i];

public static A140218Inst Instance=new A140218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140219
{
public static readonly long[] Value={ 1L,1L,2L,2L,6L,6L,6L,6L,10L,10L,6L,6L,210L,210L,2L,2L,30L,30L,42L,42L,110L,110L,6L,6L,546L,546L,2L,2L,30L,30L,462L,462L,170L,170L,6L,6L,51870L,51870L,2L,2L,330L,330L,42L,42L,46L,46L,6L,6L,6630L,6630L,22L,22L,30L,30L,798L,798L,290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140219Inst : IEnumerable<long>
{
public static readonly long[] Value=A140219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140219.Bytes);
public long this[int i]=>Value[i];

public static A140219Inst Instance=new A140219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140220
{
public static readonly long[] Value={ 1L,40L,900L,15000L,206250L,2475000L,26812500L,268125000L,2513671875L,22343750000L,189921875000L,1553906250000L,12301757812500L,94628906250000L,709716796875000L,5204589843750000L,37407989501953125L,264056396484375000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140220Inst : IEnumerable<long>
{
public static readonly long[] Value=A140220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140220.Bytes);
public long this[int i]=>Value[i];

public static A140220Inst Instance=new A140220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140221
{
public static readonly long[] Value={ 1L,2L,3L,7L,9L,10L,11L,12L,13L,14L,17L,19L,23L,25L,27L,28L,29L,31L,32L,34L,35L,37L,41L,43L,45L,49L,50L,51L,52L,53L,54L,56L,58L,59L,61L,62L,65L,67L,69L,71L,73L,75L,77L,79L,81L,82L,83L,84L,86L,87L,88L,89L,92L,93L,94L,95L,97L,98L,101L,103L,107L,109L,111L,113L,115L,117L,119L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140221Inst : IEnumerable<long>
{
public static readonly long[] Value=A140221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140221.Bytes);
public long this[int i]=>Value[i];

public static A140221Inst Instance=new A140221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140222
{
public static readonly long[] Value={ 2L,3L,9L,11L,13L,14L,28L,29L,31L,34L,35L,51L,54L,56L,61L,81L,83L,93L,94L,97L,98L,123L,124L,131L,140L,142L,171L,173L,177L,179L,180L,185L,187L,190L,191L,193L,195L,228L,230L,231L,233L,234L,248L,251L,290L,293L,294L,296L,297L,304L,309L,310L,315L,316L,320L,322L,373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140222Inst : IEnumerable<long>
{
public static readonly long[] Value=A140222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140222.Bytes);
public long this[int i]=>Value[i];

public static A140222Inst Instance=new A140222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140223
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,1L,2L,2L,3L,1L,2L,2L,2L,3L,1L,2L,2L,2L,3L,4L,1L,2L,2L,2L,2L,3L,4L,1L,2L,2L,2L,2L,3L,4L,4L,1L,2L,2L,2L,2L,3L,3L,4L,4L,1L,2L,2L,2L,2L,3L,3L,4L,4L,4L,1L,2L,2L,2L,2L,2L,3L,3L,4L,4L,4L,1L,2L,2L,2L,2L,2L,3L,3L,4L,4L,4L,6L,1L,2L,2L,2L,2L,2L,2L,3L,3L,4L,4L,4L,6L,1L,2L,2L,2L,2L,2L,2L,3L,3L,4L,4L,4L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140223Inst : IEnumerable<long>
{
public static readonly long[] Value=A140223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140223.Bytes);
public long this[int i]=>Value[i];

public static A140223Inst Instance=new A140223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140224
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,0L,1L,2L,1L,0L,1L,3L,1L,0L,0L,1L,3L,1L,1L,0L,0L,1L,4L,1L,1L,0L,0L,0L,1L,4L,1L,2L,0L,0L,0L,0L,1L,4L,2L,2L,0L,0L,0L,0L,0L,1L,4L,2L,3L,0L,0L,0L,0L,0L,0L,1L,5L,2L,3L,0L,0L,0L,0L,0L,0L,0L,1L,5L,2L,3L,0L,1L,0L,0L,0L,0L,0L,0L,1L,6L,2L,3L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,6L,2L,4L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140224Inst : IEnumerable<long>
{
public static readonly long[] Value=A140224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140224.Bytes);
public long this[int i]=>Value[i];

public static A140224Inst Instance=new A140224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140225
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,1L,1L,2L,2L,3L,3L,1L,1L,1L,1L,1L,1L,2L,2L,3L,3L,3L,3L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140225Inst : IEnumerable<long>
{
public static readonly long[] Value=A140225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140225.Bytes);
public long this[int i]=>Value[i];

public static A140225Inst Instance=new A140225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140226
{
public static readonly long[] Value={ 1L,4L,10L,20L,36L,60L,94L,140L,200L,276L,370L,484L,620L,780L,966L,1180L,1424L,1700L,2010L,2356L,2740L,3164L,3630L,4140L,4696L,5300L,5954L,6660L,7420L,8236L,9110L,10044L,11040L,12100L,13226L,14420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140226Inst : IEnumerable<long>
{
public static readonly long[] Value=A140226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140226.Bytes);
public long this[int i]=>Value[i];

public static A140226Inst Instance=new A140226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140227
{
public static readonly long[] Value={ 1L,5L,15L,35L,70L,127L,215L,345L,530L,785L,1127L,1575L,2150L,2875L,3775L,4877L,6210L,7805L,9695L,11915L,14502L,17495L,20935L,24865L,29330L,34377L,40055L,46415L,53510L,61395L,70127L,79765L,90370L,102005L,114735L,128627L,143750L,160175L,177975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140227Inst : IEnumerable<long>
{
public static readonly long[] Value=A140227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140227.Bytes);
public long this[int i]=>Value[i];

public static A140227Inst Instance=new A140227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140228
{
public static readonly long[] Value={ 1L,6L,21L,56L,126L,252L,463L,798L,1308L,2058L,3129L,4620L,6650L,9360L,12915L,17506L,23352L,30702L,39837L,51072L,64758L,81284L,101079L,124614L,152404L,185010L,223041L,267156L,318066L,376536L,443387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140228Inst : IEnumerable<long>
{
public static readonly long[] Value=A140228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140228.Bytes);
public long this[int i]=>Value[i];

public static A140228Inst Instance=new A140228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140229
{
public static readonly long[] Value={ 1L,4L,10L,20L,33L,49L,68L,90L,115L,143L,174L,208L,245L,285L,328L,374L,423L,475L,530L,588L,649L,713L,780L,850L,923L,999L,1078L,1160L,1245L,1333L,1424L,1518L,1615L,1715L,1818L,1924L,2033L,2145L,2260L,2378L,2499L,2623L,2750L,2880L,3013L,3149L,3288L,3430L,3575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140229Inst : IEnumerable<long>
{
public static readonly long[] Value=A140229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140229.Bytes);
public long this[int i]=>Value[i];

public static A140229Inst Instance=new A140229Inst();

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