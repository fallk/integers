using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A088699
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,7L,4L,1L,1L,5L,13L,13L,5L,1L,1L,6L,21L,34L,21L,6L,1L,1L,7L,31L,73L,73L,31L,7L,1L,1L,8L,43L,136L,209L,136L,43L,8L,1L,1L,9L,57L,229L,501L,501L,229L,57L,9L,1L,1L,10L,73L,358L,1045L,1546L,1045L,358L,73L,10L,1L,1L,11L,91L,529L,1961L,4051L,4051L,1961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088699Inst : IEnumerable<long>
{
public static readonly long[] Value=A088699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088699.Bytes);
public long this[int i]=>Value[i];

public static A088699Inst Instance=new A088699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088700
{
public static readonly long[] Value={ 1L,1L,0L,2L,0L,2L,0L,1L,0L,2L,0L,0L,1L,0L,2L,1L,0L,1L,0L,0L,2L,0L,1L,2L,0L,1L,1L,0L,0L,1L,0L,0L,0L,3L,2L,1L,0L,0L,0L,0L,0L,1L,1L,0L,2L,0L,0L,0L,0L,2L,1L,0L,0L,1L,1L,1L,0L,2L,0L,0L,2L,2L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,3L,0L,2L,0L,1L,0L,1L,0L,1L,0L,2L,1L,2L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,2L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088700Inst : IEnumerable<long>
{
public static readonly long[] Value=A088700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088700.Bytes);
public long this[int i]=>Value[i];

public static A088700Inst Instance=new A088700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088701
{
public static readonly long[] Value={ 9L,4L,10L,95L,818L,2681L,16053L,35981L,797542L,1069541L,340894L,6974465L,3586843L,2070050198L,5238280946L,14499777101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088701Inst : IEnumerable<long>
{
public static readonly long[] Value=A088701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088701.Bytes);
public long this[int i]=>Value[i];

public static A088701Inst Instance=new A088701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088702
{
public static readonly long[] Value={ 0L,1L,2L,7L,28L,124L,588L,2939L,15292L,82168L,453376L,2558074L,14712038L,86029132L,510455002L,3068304865L,18658787150L,114663168405L,711391109162L,4452321247688L,28090360338572L,178550339417087L,1142799275636690L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088702Inst : IEnumerable<long>
{
public static readonly long[] Value=A088702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088702.Bytes);
public long this[int i]=>Value[i];

public static A088702Inst Instance=new A088702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088703
{
public static readonly long[] Value={ 33L,244L,275L,1025L,1056L,1267L,3126L,3157L,3368L,4149L,7777L,7808L,8019L,8800L,10901L,16808L,16839L,17050L,17831L,19932L,24583L,32769L,32800L,33011L,33792L,35893L,40544L,49575L,59050L,59081L,59292L,60073L,62174L,66825L,75856L,91817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088703Inst : IEnumerable<long>
{
public static readonly long[] Value=A088703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088703.Bytes);
public long this[int i]=>Value[i];

public static A088703Inst Instance=new A088703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088704
{
public static readonly long[] Value={ 1L,1L,3L,7L,23L,71L,231L,743L,2431L,7999L,26563L,88683L,297551L,1002015L,3385175L,11466887L,38933183L,132454719L,451423203L,1540920939L,5267257103L,18027478847L,61770328227L,211872505243L,727411948351L,2499560376671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088704Inst : IEnumerable<long>
{
public static readonly long[] Value=A088704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088704.Bytes);
public long this[int i]=>Value[i];

public static A088704Inst Instance=new A088704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088705
{
public static readonly long[] Value={ 0L,1L,0L,1L,-1L,1L,0L,1L,-2L,1L,0L,1L,-1L,1L,0L,1L,-3L,1L,0L,1L,-1L,1L,0L,1L,-2L,1L,0L,1L,-1L,1L,0L,1L,-4L,1L,0L,1L,-1L,1L,0L,1L,-2L,1L,0L,1L,-1L,1L,0L,1L,-3L,1L,0L,1L,-1L,1L,0L,1L,-2L,1L,0L,1L,-1L,1L,0L,1L,-5L,1L,0L,1L,-1L,1L,0L,1L,-2L,1L,0L,1L,-1L,1L,0L,1L,-3L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088705Inst : IEnumerable<long>
{
public static readonly long[] Value=A088705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088705.Bytes);
public long this[int i]=>Value[i];

public static A088705Inst Instance=new A088705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088706
{
public static readonly long[] Value={ 6L,10L,14L,7L,8L,31L,35L,17L,43L,40L,229L,248L,212L,818L,799L,733L,151L,2191L,1139L,20894L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088706Inst : IEnumerable<long>
{
public static readonly long[] Value=A088706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088706.Bytes);
public long this[int i]=>Value[i];

public static A088706Inst Instance=new A088706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088707
{
public static readonly long[] Value={ 5L,7L,10L,11L,15L,16L,22L,23L,26L,27L,34L,35L,36L,39L,40L,47L,50L,52L,56L,58L,59L,63L,66L,70L,75L,78L,83L,86L,87L,88L,92L,94L,95L,96L,107L,112L,116L,119L,120L,122L,123L,124L,130L,134L,135L,142L,143L,144L,146L,147L,156L,159L,160L,162L,167L,170L,178L,179L,184L,186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088707Inst : IEnumerable<long>
{
public static readonly long[] Value=A088707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088707.Bytes);
public long this[int i]=>Value[i];

public static A088707Inst Instance=new A088707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088756
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L,77L,5L,2L,5L,653L,5L,579L,1L,37L,1L,4787L,25L,2L,77L,37L,25L,37969L,1L,3581L,25L,1L,653L,2L,25L,3L,579L,77L,1L,271L,143L,25607L,1L,2L,4787L,213L,125L,143L,1L,653L,77L,1887L,185L,1L,125L,193L,37969L,186629L,1L,1641L,3581L,143L,125L,77L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088756Inst : IEnumerable<long>
{
public static readonly long[] Value=A088756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088756.Bytes);
public long this[int i]=>Value[i];

public static A088756Inst Instance=new A088756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088757
{
public static readonly long[] Value={ 2L,5L,7L,8L,26L,40L,134L,160L,107L,172L,35L,79L,739L,267L,137L,1119L,97L,1498L,983L,1404L,2193L,1206L,3262L,369L,3256L,2728L,1406L,3483L,6771L,2226L,12077L,8533L,1890L,9889L,10925L,10935L,3981L,10763L,13030L,16958L,13433L,16369L,47602L,26190L,17115L,33262L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088757Inst : IEnumerable<long>
{
public static readonly long[] Value=A088757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088757.Bytes);
public long this[int i]=>Value[i];

public static A088757Inst Instance=new A088757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088758
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,7L,16L,17L,21L,24L,27L,34L,37L,39L,46L,47L,54L,56L,57L,71L,72L,74L,87L,89L,92L,97L,102L,109L,119L,122L,126L,131L,136L,137L,144L,146L,147L,152L,156L,162L,164L,176L,177L,182L,187L,189L,191L,204L,211L,214L,221L,226L,232L,234L,237L,239L,254L,256L,261L,267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088758Inst : IEnumerable<long>
{
public static readonly long[] Value=A088758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088758.Bytes);
public long this[int i]=>Value[i];

public static A088758Inst Instance=new A088758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088759
{
public static readonly long[] Value={ 0L,3L,5L,7L,8L,10L,12L,17L,20L,22L,25L,27L,30L,32L,38L,40L,43L,50L,55L,57L,72L,82L,83L,85L,97L,102L,107L,108L,110L,112L,113L,115L,118L,122L,123L,128L,133L,140L,147L,150L,160L,168L,173L,175L,177L,183L,187L,192L,198L,200L,203L,207L,212L,213L,217L,218L,220L,225L,230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088759Inst : IEnumerable<long>
{
public static readonly long[] Value=A088759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088759.Bytes);
public long this[int i]=>Value[i];

public static A088759Inst Instance=new A088759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088760
{
public static readonly BigInteger[] Value={ 1L,11L,121L,11132L,1013012L,1091013924L,1032099172104L,1907319270048192L,2731281194709010944L,BigInteger.Parse("11009794495872023115264"),BigInteger.Parse("22371902415611950970216448"),BigInteger.Parse("105573007499272796628451418112"),BigInteger.Parse("781029109479620149457283591192576") };
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
public class A088760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088760Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088760.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088760Inst Instance=new A088760Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088761
{
public static readonly long[] Value={ 11L,11L,92L,91L,1077L,946L,1848L,1432L,4031L,2032L,4719L,7398L,23622L,64213L,72827L,29291L,32724L,26863L,86104L,74557L,101348L,22782L,154536L,18074L,31987L,301492L,2739L,190534L,235432L,84537L,256411L,11076L,569721L,943616L,2848663L,217439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088761Inst : IEnumerable<long>
{
public static readonly long[] Value=A088761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088761.Bytes);
public long this[int i]=>Value[i];

public static A088761Inst Instance=new A088761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088762
{
public static readonly long[] Value={ 2L,4L,7L,10L,19L,22L,34L,40L,49L,52L,55L,64L,82L,97L,112L,115L,139L,154L,157L,175L,190L,199L,220L,229L,232L,244L,250L,307L,322L,337L,370L,379L,385L,412L,427L,430L,439L,442L,454L,469L,484L,505L,544L,547L,607L,640L,649L,652L,712L,715L,724L,742L,745L,775L,784L,790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088762Inst : IEnumerable<long>
{
public static readonly long[] Value=A088762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088762.Bytes);
public long this[int i]=>Value[i];

public static A088762Inst Instance=new A088762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088763
{
public static readonly long[] Value={ 4L,5L,7L,8L,10L,13L,17L,20L,22L,25L,28L,32L,35L,38L,43L,50L,52L,53L,55L,67L,77L,80L,85L,88L,97L,98L,113L,115L,118L,127L,130L,133L,137L,140L,155L,157L,167L,175L,178L,185L,188L,193L,218L,223L,230L,232L,253L,272L,280L,283L,287L,295L,298L,302L,305L,308L,322L,325L,328L,340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088763Inst : IEnumerable<long>
{
public static readonly long[] Value=A088763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088763.Bytes);
public long this[int i]=>Value[i];

public static A088763Inst Instance=new A088763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088764
{
public static readonly long[] Value={ 3L,4L,7L,13L,16L,28L,31L,37L,46L,52L,67L,76L,88L,97L,118L,133L,136L,181L,196L,202L,217L,226L,241L,247L,283L,286L,298L,301L,328L,343L,352L,361L,373L,382L,412L,457L,466L,493L,508L,517L,532L,556L,583L,598L,613L,616L,643L,646L,661L,688L,721L,727L,742L,763L,781L,787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088764Inst : IEnumerable<long>
{
public static readonly long[] Value=A088764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088764.Bytes);
public long this[int i]=>Value[i];

public static A088764Inst Instance=new A088764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088765
{
public static readonly long[] Value={ 4L,6L,9L,12L,18L,21L,24L,33L,39L,42L,51L,54L,66L,72L,81L,84L,93L,114L,117L,123L,138L,144L,156L,171L,177L,189L,192L,207L,213L,219L,222L,231L,252L,276L,291L,306L,318L,324L,339L,348L,357L,369L,378L,396L,408L,417L,429L,441L,462L,471L,486L,507L,513L,522L,528L,546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088765Inst : IEnumerable<long>
{
public static readonly long[] Value=A088765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088765.Bytes);
public long this[int i]=>Value[i];

public static A088765Inst Instance=new A088765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088766
{
public static readonly long[] Value={ 5L,6L,8L,11L,12L,17L,18L,23L,26L,32L,33L,36L,38L,47L,51L,53L,66L,71L,72L,78L,86L,92L,93L,102L,108L,116L,117L,122L,128L,131L,137L,138L,143L,171L,176L,186L,197L,201L,207L,212L,213L,218L,227L,236L,242L,246L,248L,257L,281L,296L,303L,306L,312L,318L,323L,326L,333L,366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088766Inst : IEnumerable<long>
{
public static readonly long[] Value=A088766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088766.Bytes);
public long this[int i]=>Value[i];

public static A088766Inst Instance=new A088766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088767
{
public static readonly long[] Value={ 5L,6L,12L,15L,18L,27L,30L,33L,45L,48L,60L,72L,78L,87L,93L,102L,117L,132L,135L,138L,150L,162L,180L,183L,195L,213L,225L,228L,258L,282L,285L,297L,300L,303L,312L,327L,333L,342L,363L,375L,390L,402L,408L,423L,435L,480L,492L,495L,513L,528L,555L,558L,597L,612L,615L,642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088767Inst : IEnumerable<long>
{
public static readonly long[] Value=A088767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088767.Bytes);
public long this[int i]=>Value[i];

public static A088767Inst Instance=new A088767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088768
{
public static readonly long[] Value={ 5L,7L,10L,19L,22L,25L,37L,40L,52L,79L,82L,85L,94L,109L,115L,124L,142L,169L,172L,187L,190L,220L,235L,247L,274L,277L,289L,292L,304L,319L,325L,334L,367L,382L,409L,415L,472L,487L,502L,520L,547L,550L,589L,604L,610L,649L,655L,715L,739L,745L,775L,787L,802L,814L,850L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088768Inst : IEnumerable<long>
{
public static readonly long[] Value=A088768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088768.Bytes);
public long this[int i]=>Value[i];

public static A088768Inst Instance=new A088768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088769
{
public static readonly long[] Value={ 7L,10L,11L,14L,16L,19L,25L,26L,31L,35L,40L,44L,46L,49L,59L,61L,70L,74L,79L,86L,91L,94L,95L,101L,110L,116L,121L,124L,130L,136L,151L,161L,170L,179L,194L,196L,205L,215L,220L,224L,226L,229L,235L,250L,256L,266L,289L,304L,305L,311L,325L,326L,334L,341L,346L,350L,355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088769Inst : IEnumerable<long>
{
public static readonly long[] Value=A088769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088769.Bytes);
public long this[int i]=>Value[i];

public static A088769Inst Instance=new A088769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088770
{
public static readonly long[] Value={ 6L,10L,13L,16L,25L,28L,31L,34L,46L,49L,58L,70L,73L,91L,94L,100L,130L,133L,136L,151L,160L,163L,178L,181L,184L,199L,205L,214L,226L,238L,244L,256L,265L,283L,298L,301L,304L,325L,331L,364L,409L,424L,433L,436L,448L,478L,490L,493L,511L,514L,520L,529L,553L,556L,559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088770Inst : IEnumerable<long>
{
public static readonly long[] Value=A088770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088770.Bytes);
public long this[int i]=>Value[i];

public static A088770Inst Instance=new A088770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088771
{
public static readonly long[] Value={ 11L,11L,101L,1001L,10001L,124431L,1000000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088771Inst : IEnumerable<long>
{
public static readonly long[] Value=A088771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088771.Bytes);
public long this[int i]=>Value[i];

public static A088771Inst Instance=new A088771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088836
{
public static readonly long[] Value={ 3L,5L,7L,3L,11L,13L,4L,17L,19L,5L,23L,5L,3L,29L,31L,7L,6L,37L,8L,41L,43L,4L,47L,7L,10L,53L,8L,11L,59L,61L,5L,9L,67L,13L,71L,73L,4L,9L,79L,3L,83L,11L,16L,89L,10L,17L,12L,97L,7L,101L,103L,5L,107L,109L,20L,113L,14L,8L,12L,11L,22L,5L,127L,23L,131L,13L,4L,137L,139L,25L,12L,17L,5L,149L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088836Inst : IEnumerable<long>
{
public static readonly long[] Value=A088836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088836.Bytes);
public long this[int i]=>Value[i];

public static A088836Inst Instance=new A088836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088837
{
public static readonly long[] Value={ 3L,7L,3L,15L,3L,7L,3L,31L,3L,7L,3L,15L,3L,7L,3L,63L,3L,7L,3L,15L,3L,7L,3L,31L,3L,7L,3L,15L,3L,7L,3L,127L,3L,7L,3L,15L,3L,7L,3L,31L,3L,7L,3L,15L,3L,7L,3L,63L,3L,7L,3L,15L,3L,7L,3L,31L,3L,7L,3L,15L,3L,7L,3L,255L,3L,7L,3L,15L,3L,7L,3L,31L,3L,7L,3L,15L,3L,7L,3L,63L,3L,7L,3L,15L,3L,7L,3L,31L,3L,7L,3L,15L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088837Inst : IEnumerable<long>
{
public static readonly long[] Value=A088837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088837.Bytes);
public long this[int i]=>Value[i];

public static A088837Inst Instance=new A088837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088838
{
public static readonly long[] Value={ 4L,4L,13L,4L,4L,13L,4L,4L,40L,4L,4L,13L,4L,4L,13L,4L,4L,40L,4L,4L,13L,4L,4L,13L,4L,4L,121L,4L,4L,13L,4L,4L,13L,4L,4L,40L,4L,4L,13L,4L,4L,13L,4L,4L,40L,4L,4L,13L,4L,4L,13L,4L,4L,121L,4L,4L,13L,4L,4L,13L,4L,4L,40L,4L,4L,13L,4L,4L,13L,4L,4L,40L,4L,4L,13L,4L,4L,13L,4L,4L,364L,4L,4L,13L,4L,4L,13L,4L,4L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088838Inst : IEnumerable<long>
{
public static readonly long[] Value=A088838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088838.Bytes);
public long this[int i]=>Value[i];

public static A088838Inst Instance=new A088838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088839
{
public static readonly long[] Value={ 7L,5L,7L,31L,7L,5L,7L,21L,7L,5L,7L,31L,7L,5L,7L,127L,7L,5L,7L,31L,7L,5L,7L,21L,7L,5L,7L,31L,7L,5L,7L,85L,7L,5L,7L,31L,7L,5L,7L,21L,7L,5L,7L,31L,7L,5L,7L,127L,7L,5L,7L,31L,7L,5L,7L,21L,7L,5L,7L,31L,7L,5L,7L,511L,7L,5L,7L,31L,7L,5L,7L,21L,7L,5L,7L,31L,7L,5L,7L,127L,7L,5L,7L,31L,7L,5L,7L,21L,7L,5L,7L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088839Inst : IEnumerable<long>
{
public static readonly long[] Value=A088839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088839.Bytes);
public long this[int i]=>Value[i];

public static A088839Inst Instance=new A088839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088840
{
public static readonly long[] Value={ 1L,1L,1L,7L,1L,1L,1L,5L,1L,1L,1L,7L,1L,1L,1L,31L,1L,1L,1L,7L,1L,1L,1L,5L,1L,1L,1L,7L,1L,1L,1L,21L,1L,1L,1L,7L,1L,1L,1L,5L,1L,1L,1L,7L,1L,1L,1L,31L,1L,1L,1L,7L,1L,1L,1L,5L,1L,1L,1L,7L,1L,1L,1L,127L,1L,1L,1L,7L,1L,1L,1L,5L,1L,1L,1L,7L,1L,1L,1L,31L,1L,1L,1L,7L,1L,1L,1L,5L,1L,1L,1L,7L,1L,1L,1L,21L,1L,1L,1L,7L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088840Inst : IEnumerable<long>
{
public static readonly long[] Value=A088840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088840.Bytes);
public long this[int i]=>Value[i];

public static A088840Inst Instance=new A088840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088841
{
public static readonly long[] Value={ 8L,8L,8L,8L,8L,8L,57L,8L,8L,8L,8L,8L,8L,57L,8L,8L,8L,8L,8L,8L,57L,8L,8L,8L,8L,8L,8L,57L,8L,8L,8L,8L,8L,8L,57L,8L,8L,8L,8L,8L,8L,57L,8L,8L,8L,8L,8L,8L,400L,8L,8L,8L,8L,8L,8L,57L,8L,8L,8L,8L,8L,8L,57L,8L,8L,8L,8L,8L,8L,57L,8L,8L,8L,8L,8L,8L,57L,8L,8L,8L,8L,8L,8L,57L,8L,8L,8L,8L,8L,8L,57L,8L,8L,8L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088841Inst : IEnumerable<long>
{
public static readonly long[] Value=A088841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088841.Bytes);
public long this[int i]=>Value[i];

public static A088841Inst Instance=new A088841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088842
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,8L,1L,1L,1L,1L,1L,1L,8L,1L,1L,1L,1L,1L,1L,8L,1L,1L,1L,1L,1L,1L,8L,1L,1L,1L,1L,1L,1L,8L,1L,1L,1L,1L,1L,1L,8L,1L,1L,1L,1L,1L,1L,57L,1L,1L,1L,1L,1L,1L,8L,1L,1L,1L,1L,1L,1L,8L,1L,1L,1L,1L,1L,1L,8L,1L,1L,1L,1L,1L,1L,8L,1L,1L,1L,1L,1L,1L,8L,1L,1L,1L,1L,1L,1L,8L,1L,1L,1L,1L,1L,1L,57L,1L,1L,1L,1L,1L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088842Inst : IEnumerable<long>
{
public static readonly long[] Value=A088842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088842.Bytes);
public long this[int i]=>Value[i];

public static A088842Inst Instance=new A088842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088843
{
public static readonly long[] Value={ 1L,4L,6L,16L,10L,24L,14L,96L,96L,80L,216L,320L,26L,384L,480L,288L,576L,224L,34L,1920L,2304L,1056L,480L,896L,38L,960L,1344L,3456L,1620L,5280L,6336L,3888L,10368L,9216L,2816L,72L,144L,384L,64L,320L,480L,784L,144L,756L,196L,308L,768L,3456L,640L,3072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088843Inst : IEnumerable<long>
{
public static readonly long[] Value=A088843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088843.Bytes);
public long this[int i]=>Value[i];

public static A088843Inst Instance=new A088843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088844
{
public static readonly long[] Value={ 28L,2178540L,45532800L,142990848L,14182439040L,43861478400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088844Inst : IEnumerable<long>
{
public static readonly long[] Value=A088844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088844.Bytes);
public long this[int i]=>Value[i];

public static A088844Inst Instance=new A088844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088845
{
public static readonly BigInteger[] Value={ 496L,523776L,23569920L,142990848L,14942123276641900L,20158185857531900L,212517062615532000L,275502900594021000L,622286506811515000L,2305843008139950000L,BigInteger.Parse("69357059049509000000"),BigInteger.Parse("71065075104190100000"),BigInteger.Parse("87934476737668000000"),BigInteger.Parse("154345556085771000000") };
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
public class A088845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088845Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088845.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088845Inst Instance=new A088845Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088846
{
public static readonly long[] Value={ 8128L,1476304896L,66433720320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088846Inst : IEnumerable<long>
{
public static readonly long[] Value=A088846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088846.Bytes);
public long this[int i]=>Value[i];

public static A088846Inst Instance=new A088846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088847
{
public static readonly long[] Value={ 1L,1L,3L,4L,4L,6L,6L,8L,9L,8L,10L,12L,12L,14L,15L,16L,16L,18L,18L,20L,21L,20L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088847Inst : IEnumerable<long>
{
public static readonly long[] Value=A088847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088847.Bytes);
public long this[int i]=>Value[i];

public static A088847Inst Instance=new A088847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088848
{
public static readonly long[] Value={ 4L,4L,4L,4L,3L,4L,4L,4L,6L,4L,5L,6L,4L,4L,7L,4L,7L,4L,3L,5L,6L,5L,6L,5L,6L,4L,5L,5L,6L,5L,4L,5L,4L,4L,6L,6L,6L,6L,6L,6L,5L,5L,6L,5L,6L,6L,6L,5L,7L,5L,6L,4L,5L,6L,6L,6L,5L,6L,5L,6L,4L,6L,4L,7L,6L,7L,5L,4L,5L,4L,5L,4L,6L,6L,5L,6L,5L,6L,5L,7L,4L,5L,6L,4L,6L,4L,6L,4L,5L,5L,9L,5L,5L,6L,6L,5L,3L,4L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088848Inst : IEnumerable<long>
{
public static readonly long[] Value=A088848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088848.Bytes);
public long this[int i]=>Value[i];

public static A088848Inst Instance=new A088848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088849
{
public static readonly long[] Value={ 4L,4L,4L,4L,3L,4L,4L,4L,6L,4L,5L,6L,4L,4L,7L,5L,7L,4L,3L,5L,6L,5L,6L,5L,6L,4L,5L,5L,6L,5L,4L,5L,4L,4L,6L,6L,6L,6L,6L,6L,5L,5L,6L,5L,6L,6L,7L,5L,7L,5L,6L,4L,5L,6L,6L,6L,5L,6L,5L,6L,4L,6L,4L,7L,6L,7L,5L,4L,5L,4L,5L,4L,6L,6L,5L,6L,6L,6L,5L,7L,4L,5L,6L,4L,6L,5L,6L,4L,5L,8L,9L,5L,5L,6L,6L,5L,3L,5L,8L,5L,7L,5L,7L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088849Inst : IEnumerable<long>
{
public static readonly long[] Value=A088849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088849.Bytes);
public long this[int i]=>Value[i];

public static A088849Inst Instance=new A088849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088850
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,2L,1L,0L,4L,0L,1L,3L,1L,4L,2L,1L,3L,0L,3L,2L,4L,3L,3L,2L,5L,4L,6L,11L,2L,6L,5L,8L,8L,7L,7L,12L,14L,8L,8L,10L,7L,10L,11L,11L,11L,20L,17L,30L,19L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088850Inst : IEnumerable<long>
{
public static readonly long[] Value=A088850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088850.Bytes);
public long this[int i]=>Value[i];

public static A088850Inst Instance=new A088850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088851
{
public static readonly BigInteger[] Value={ 1L,252L,80007417506016L,BigInteger.Parse("5449713849337046134829195826736453289707341263020311856620421864359893115203485696") };
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
public class A088851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088851Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088851.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088851Inst Instance=new A088851Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088868
{
public static readonly long[] Value={ 49L,109L,307121L,3837881L,415922011L,44886856951L,73071640562111L,11741452251865261L,138599925259848671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088868Inst : IEnumerable<long>
{
public static readonly long[] Value=A088868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088868.Bytes);
public long this[int i]=>Value[i];

public static A088868Inst Instance=new A088868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088869
{
public static readonly long[] Value={ 5L,15L,197L,591L,599L,985L,23363L,70089L,182415L,32533013L,97599039L,200814277564911L,334690462608185L,100208875079675883L,119690233947031245L,120541110603088381L,152213696825889183L,167014791799459805L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088869Inst : IEnumerable<long>
{
public static readonly long[] Value=A088869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088869.Bytes);
public long this[int i]=>Value[i];

public static A088869Inst Instance=new A088869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088870
{
public static readonly BigInteger[] Value={ 13677L,14647L,21291L,29567L,43941L,69031L,88701L,105991L,126507L,317973L,156304482823L,468913448469L,21729950852487L,2212933498428421L,6638800495285263L,12049739358792173L,36149218076376519L,BigInteger.Parse("11316117499289108644863") };
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
public class A088870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088870Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088870.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088870Inst Instance=new A088870Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088871
{
public static readonly long[] Value={ 10L,22L,55L,181L,190L,362L,905L,2035L,4070L,10490L,11203L,14686L,17833L,22406L,23065L,35666L,36715L,46130L,56015L,73430L,78421L,89165L,100705L,201410L,1004530L,1093165L,1425313L,1480309L,1695710L,1956190L,2186330L,2850626L,2882707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088871Inst : IEnumerable<long>
{
public static readonly long[] Value=A088871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088871.Bytes);
public long this[int i]=>Value[i];

public static A088871Inst Instance=new A088871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088872
{
public static readonly long[] Value={ 37L,1793L,12247L,13061L,12345679L,17675669L,59454523L,10035074789L,11207086103L,12174047803L,13606288721L,14036302277L,17989804447L,19541987747L,20070727459L,21841045129L,22431989513L,23140930781L,32217871691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088872Inst : IEnumerable<long>
{
public static readonly long[] Value=A088872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088872.Bytes);
public long this[int i]=>Value[i];

public static A088872Inst Instance=new A088872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088873
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,3L,2L,4L,3L,3L,2L,5L,2L,3L,3L,5L,2L,5L,2L,5L,3L,3L,2L,6L,3L,3L,4L,5L,2L,4L,2L,6L,3L,3L,3L,6L,2L,3L,3L,6L,2L,4L,2L,5L,5L,3L,2L,8L,3L,5L,3L,5L,2L,6L,3L,6L,3L,3L,2L,7L,2L,3L,5L,7L,3L,4L,2L,5L,3L,4L,2L,8L,2L,3L,5L,5L,3L,4L,2L,8L,5L,3L,2L,7L,3L,3L,3L,6L,2L,7L,3L,5L,3L,3L,3L,9L,2L,5L,5L,6L,2L,4L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088873Inst : IEnumerable<long>
{
public static readonly long[] Value=A088873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088873.Bytes);
public long this[int i]=>Value[i];

public static A088873Inst Instance=new A088873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088874
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,3L,0L,16L,30L,15L,0L,272L,588L,420L,105L,0L,7936L,18960L,16380L,6300L,945L,0L,353792L,911328L,893640L,429660L,103950L,10395L,0L,22368256L,61152000L,65825760L,36636600L,11351340L,1891890L,135135L,0L,1903757312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088874Inst : IEnumerable<long>
{
public static readonly long[] Value=A088874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088874.Bytes);
public long this[int i]=>Value[i];

public static A088874Inst Instance=new A088874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088875
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,9L,12L,14L,17L,82L,86L,157L,158L,180L,210L,236L,245L,368L,462L,842L,1034L,3512L,3977L,8636L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088875Inst : IEnumerable<long>
{
public static readonly long[] Value=A088875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088875.Bytes);
public long this[int i]=>Value[i];

public static A088875Inst Instance=new A088875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088876
{
public static readonly long[] Value={ 2L,2L,1L,10L,108L,1065L,10699L,1000005L,10000013L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088876Inst : IEnumerable<long>
{
public static readonly long[] Value=A088876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088876.Bytes);
public long this[int i]=>Value[i];

public static A088876Inst Instance=new A088876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088877
{
public static readonly long[] Value={ 1L,3L,9L,11L,33L,111L,117L,143L,189L,231L,259L,273L,297L,333L,351L,407L,429L,481L,693L,777L,819L,1111L,1233L,1507L,2409L,3333L,4521L,7227L,7373L,11111L,26829L,27273L,33333L,81819L,100899L,101101L,108911L,111111L,123321L,128713L,129987L,142857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088877Inst : IEnumerable<long>
{
public static readonly long[] Value=A088877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088877.Bytes);
public long this[int i]=>Value[i];

public static A088877Inst Instance=new A088877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088878
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,23L,37L,43L,47L,53L,61L,67L,71L,103L,113L,127L,137L,163L,167L,181L,191L,193L,211L,251L,257L,263L,271L,277L,293L,307L,313L,331L,337L,347L,373L,401L,431L,433L,443L,461L,467L,487L,491L,523L,541L,557L,587L,593L,601L,673L,677L,727L,751L,757L,761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088878Inst : IEnumerable<long>
{
public static readonly long[] Value=A088878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088878.Bytes);
public long this[int i]=>Value[i];

public static A088878Inst Instance=new A088878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088879
{
public static readonly long[] Value={ -1L,0L,2L,4L,6L,8L,12L,14L,16L,18L,22L,26L,28L,32L,34L,36L,42L,44L,48L,54L,56L,58L,62L,64L,74L,76L,78L,82L,84L,86L,88L,92L,96L,102L,104L,114L,116L,118L,126L,128L,132L,138L,142L,146L,148L,152L,154L,158L,162L,166L,168L,172L,184L,186L,188L,194L,196L,198L,204L,212L,214L,216L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088879Inst : IEnumerable<long>
{
public static readonly long[] Value=A088879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088879.Bytes);
public long this[int i]=>Value[i];

public static A088879Inst Instance=new A088879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088880
{
public static readonly long[] Value={ 1L,1L,2L,2L,5L,4L,8L,6L,12L,10L,16L,13L,25L,18L,28L,25L,40L,32L,51L,40L,62L,51L,76L,62L,99L,77L,112L,92L,138L,109L,165L,130L,189L,153L,220L,178L,267L,208L,292L,240L,347L,274L,397L,315L,445L,361L,512L,407L,591L,464L,647L,524L,746L,588L,830L,664L,928L,746L,1034L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088880Inst : IEnumerable<long>
{
public static readonly long[] Value=A088880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088880.Bytes);
public long this[int i]=>Value[i];

public static A088880Inst Instance=new A088880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088881
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,10L,12L,16L,20L,24L,30L,36L,42L,48L,60L,72L,84L,96L,112L,128L,144L,168L,192L,224L,256L,288L,336L,384L,432L,480L,540L,600L,672L,768L,864L,960L,1080L,1200L,1320L,1440L,1620L,1800L,1980L,2160L,2400L,2640L,2880L,3240L,3600L,3960L,4320L,4800L,5280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088881Inst : IEnumerable<long>
{
public static readonly long[] Value=A088881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088881.Bytes);
public long this[int i]=>Value[i];

public static A088881Inst Instance=new A088881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088882
{
public static readonly long[] Value={ 101L,121L,131L,141L,151L,161L,171L,181L,191L,202L,212L,232L,242L,252L,262L,272L,282L,292L,303L,313L,323L,343L,353L,363L,373L,383L,393L,404L,414L,424L,434L,454L,464L,474L,484L,494L,505L,515L,525L,535L,545L,565L,575L,585L,595L,606L,616L,626L,636L,646L,656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088882Inst : IEnumerable<long>
{
public static readonly long[] Value=A088882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088882.Bytes);
public long this[int i]=>Value[i];

public static A088882Inst Instance=new A088882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088883
{
public static readonly long[] Value={ 7L,19L,97L,109L,151L,163L,181L,193L,547L,709L,727L,733L,991L,1039L,1093L,1279L,1447L,1453L,1567L,1621L,1657L,1669L,1699L,1723L,1867L,5077L,5179L,5209L,5281L,5323L,5419L,5503L,5563L,5581L,5653L,5821L,5857L,5881L,7057L,7207L,7219L,7333L,7351L,7507L,7537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088883Inst : IEnumerable<long>
{
public static readonly long[] Value=A088883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088883.Bytes);
public long this[int i]=>Value[i];

public static A088883Inst Instance=new A088883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088900
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,12L,16L,20L,25L,30L,36L,42L,49L,55L,56L,64L,70L,72L,81L,90L,100L,110L,121L,132L,144L,155L,156L,169L,180L,182L,196L,210L,225L,240L,256L,272L,289L,305L,306L,324L,342L,361L,377L,380L,400L,420L,441L,462L,484L,504L,505L,506L,529L,546L,552L,576L,600L,625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088900Inst : IEnumerable<long>
{
public static readonly long[] Value=A088900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088900.Bytes);
public long this[int i]=>Value[i];

public static A088900Inst Instance=new A088900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088901
{
public static readonly long[] Value={ 1L,2L,4L,9L,12L,16L,25L,30L,36L,49L,55L,56L,64L,70L,81L,90L,100L,121L,132L,144L,169L,180L,182L,196L,225L,240L,256L,289L,305L,306L,324L,361L,377L,380L,400L,441L,462L,484L,529L,552L,576L,625L,646L,650L,676L,729L,755L,756L,784L,841L,870L,900L,961L,987L,990L,992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088901Inst : IEnumerable<long>
{
public static readonly long[] Value=A088901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088901.Bytes);
public long this[int i]=>Value[i];

public static A088901Inst Instance=new A088901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088902
{
public static readonly long[] Value={ 1L,2L,6L,9L,20L,30L,56L,75L,84L,125L,176L,210L,264L,350L,416L,441L,624L,660L,735L,1088L,1100L,1386L,1560L,1632L,1715L,2310L,2401L,2432L,2600L,3267L,3276L,3648L,4080L,5390L,5445L,5460L,5888L,6800L,7546L,7722L,8568L,8832L,9120L,12705L,12740L,12870L,13689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088902Inst : IEnumerable<long>
{
public static readonly long[] Value=A088902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088902.Bytes);
public long this[int i]=>Value[i];

public static A088902Inst Instance=new A088902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088903
{
public static readonly long[] Value={ 5L,11L,17L,41L,59L,71L,227L,239L,269L,281L,311L,2339L,2381L,30089L,30137L,30269L,510551L,510581L,510611L,510617L,510707L,9699731L,9699887L,9699917L,223093511L,6469693331L,6469693511L,6469693661L,6469694039L,6469694057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088903Inst : IEnumerable<long>
{
public static readonly long[] Value=A088903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088903.Bytes);
public long this[int i]=>Value[i];

public static A088903Inst Instance=new A088903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088904
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,1L,3L,2L,4L,1L,4L,1L,2L,1L,3L,3L,4L,1L,4L,1L,2L,1L,3L,1L,3L,1L,3L,1L,4L,1L,4L,2L,3L,1L,4L,2L,2L,1L,3L,1L,3L,1L,2L,1L,2L,1L,3L,1L,4L,1L,2L,1L,3L,1L,3L,1L,2L,1L,2L,1L,2L,1L,3L,4L,3L,1L,4L,1L,2L,1L,5L,1L,2L,1L,2L,1L,2L,1L,4L,1L,4L,1L,3L,1L,2L,1L,2L,1L,4L,1L,2L,1L,2L,1L,3L,1L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088904Inst : IEnumerable<long>
{
public static readonly long[] Value=A088904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088904.Bytes);
public long this[int i]=>Value[i];

public static A088904Inst Instance=new A088904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088905
{
public static readonly long[] Value={ 2L,3L,7L,11L,13L,15L,19L,21L,23L,25L,27L,29L,31L,35L,39L,41L,43L,45L,47L,49L,51L,53L,55L,57L,59L,61L,63L,67L,69L,71L,73L,75L,77L,79L,81L,83L,85L,87L,89L,91L,93L,95L,97L,99L,103L,105L,107L,109L,111L,113L,115L,117L,119L,121L,123L,125L,127L,131L,133L,135L,137L,139L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088905Inst : IEnumerable<long>
{
public static readonly long[] Value=A088905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088905.Bytes);
public long this[int i]=>Value[i];

public static A088905Inst Instance=new A088905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088906
{
public static readonly BigInteger[] Value={ 1L,2L,4L,6L,10L,72L,4097L,8192L,16777217L,33554432L,137438953472L,562949953421312L,1152921504606846977L,2305843009213693952L,BigInteger.Parse("1329227995784915874056728564887191552"),BigInteger.Parse("22300745198530623141535718272648361505980417") };
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
public class A088906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088906Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088906.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088906Inst Instance=new A088906Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088907
{
public static readonly long[] Value={ 2L,5L,9L,13L,18L,23L,28L,33L,39L,44L,50L,56L,62L,68L,74L,80L,86L,92L,99L,105L,112L,118L,125L,131L,138L,145L,152L,159L,165L,172L,179L,186L,193L,200L,207L,215L,222L,229L,236L,243L,251L,258L,265L,273L,280L,287L,295L,302L,310L,317L,325L,332L,340L,348L,355L,363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088907Inst : IEnumerable<long>
{
public static readonly long[] Value=A088907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088907.Bytes);
public long this[int i]=>Value[i];

public static A088907Inst Instance=new A088907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088908
{
public static readonly long[] Value={ 5L,13L,16L,21L,24L,29L,34L,40L,45L,48L,53L,58L,72L,74L,96L,112L,117L,120L,125L,130L,144L,146L,160L,165L,168L,170L,173L,178L,192L,194L,218L,240L,264L,280L,285L,288L,290L,293L,298L,312L,314L,336L,338L,352L,357L,360L,365L,370L,386L,408L,410L,432L,458L,480L,482L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088908Inst : IEnumerable<long>
{
public static readonly long[] Value=A088908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088908.Bytes);
public long this[int i]=>Value[i];

public static A088908Inst Instance=new A088908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088909
{
public static readonly long[] Value={ 13L,29L,34L,53L,58L,74L,125L,130L,146L,170L,173L,178L,194L,218L,290L,293L,298L,314L,338L,365L,370L,386L,410L,458L,482L,530L,533L,538L,554L,578L,650L,698L,818L,845L,850L,866L,890L,962L,965L,970L,986L,1010L,1082L,1130L,1202L,1250L,1322L,1370L,1373L,1378L,1394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088909Inst : IEnumerable<long>
{
public static readonly long[] Value=A088909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088909.Bytes);
public long this[int i]=>Value[i];

public static A088909Inst Instance=new A088909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088910
{
public static readonly long[] Value={ 4L,3L,4L,4L,1L,2L,5L,5L,4L,1L,4L,4L,3L,2L,4L,3L,2L,5L,5L,4L,3L,2L,4L,3L,2L,1L,4L,4L,3L,2L,3L,5L,4L,3L,2L,4L,3L,4L,3L,3L,2L,5L,5L,4L,3L,2L,4L,3L,2L,1L,4L,4L,3L,2L,3L,5L,4L,3L,2L,4L,5L,4L,3L,3L,4L,3L,5L,4L,3L,4L,3L,3L,2L,3L,2L,4L,3L,4L,3L,4L,4L,3L,4L,3L,5L,4L,4L,3L,4L,5L,5L,4L,3L,4L,4L,3L,2L,3L,4L,4L,3L,4L,5L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088910Inst : IEnumerable<long>
{
public static readonly long[] Value=A088910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088910.Bytes);
public long this[int i]=>Value[i];

public static A088910Inst Instance=new A088910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088911
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088911Inst : IEnumerable<long>
{
public static readonly long[] Value=A088911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088911.Bytes);
public long this[int i]=>Value[i];

public static A088911Inst Instance=new A088911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088912
{
public static readonly BigInteger[] Value={ 2L,24L,4320L,8910720L,17116004505600L,BigInteger.Parse("170974031122008628879954060917200710847692800") };
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
public class A088912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088912Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088912.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088912Inst Instance=new A088912Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088913
{
public static readonly BigInteger[] Value={ 15L,315L,5760L,103635L,1860375L,33384960L,599073735L,10749954915L,192900147840L,346145279L,2875L,62113250350815L,1114577054115840L,20000273725289535L,358890350005167435L,644002L,6026378384000L,BigInteger.Parse("115561578124833652035") };
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
public class A088913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088913Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088913.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088913Inst Instance=new A088913Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088914
{
public static readonly ulong[] Value={ 1L,32L,605L,10933L,196384L,3524489L,63245753L,1134902560L,20365009477L,365435291981L,6557470308896L,117669030432337L,2111485077903025L,37889062372947488L,679891637638098029L,12200160415120530469UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088914Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A088914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088914.Bytes);
public ulong this[int i]=>Value[i];

public static A088914Inst Instance=new A088914Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088915
{
public static readonly long[] Value={ 0L,2L,6L,12L,16L,20L,30L,42L,48L,54L,56L,70L,72L,84L,90L,96L,110L,120L,126L,128L,132L,156L,160L,162L,180L,182L,198L,210L,240L,250L,264L,272L,286L,306L,308L,324L,330L,336L,342L,380L,384L,390L,420L,432L,448L,462L,468L,506L,510L,520L,540L,546L,552L,560L,576L,600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088915Inst : IEnumerable<long>
{
public static readonly long[] Value=A088915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088915.Bytes);
public long this[int i]=>Value[i];

public static A088915Inst Instance=new A088915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088916
{
public static readonly long[] Value={ 3L,4L,2L,3L,2L,2L,7L,8L,2L,2L,7L,4L,5L,0L,2L,10L,3L,5L,4L,0L,2L,3L,7L,2L,0L,0L,0L,2L,13L,2L,6L,0L,7L,7L,3L,2L,13L,4L,6L,2L,0L,3L,3L,0L,2L,17L,10L,8L,5L,4L,3L,0L,4L,4L,2L,9L,7L,5L,7L,1L,4L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088916Inst : IEnumerable<long>
{
public static readonly long[] Value=A088916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088916.Bytes);
public long this[int i]=>Value[i];

public static A088916Inst Instance=new A088916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088917
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088917Inst : IEnumerable<long>
{
public static readonly long[] Value=A088917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088917.Bytes);
public long this[int i]=>Value[i];

public static A088917Inst Instance=new A088917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088918
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088918Inst : IEnumerable<long>
{
public static readonly long[] Value=A088918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088918.Bytes);
public long this[int i]=>Value[i];

public static A088918Inst Instance=new A088918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088919
{
public static readonly long[] Value={ 1L,13L,410L,2210L,10370L,202130L,229970L,197210L,81770L,18423410L,16046810L,12625730L,21899930L,9549410L,370247930L,416392730L,579994610L,338609570L,2155919090L,601741010L,254885930L,10083683090L,4690939370L,29207671610L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088919Inst : IEnumerable<long>
{
public static readonly long[] Value=A088919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088919.Bytes);
public long this[int i]=>Value[i];

public static A088919Inst Instance=new A088919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088920
{
public static readonly BigInteger[] Value={ 2L,50L,1682L,57122L,1940450L,65918162L,2239277042L,76069501250L,2584123765442L,87784138523762L,2982076586042450L,101302819786919522L,3441313796169221282L,BigInteger.Parse("116903366249966604050"),BigInteger.Parse("3971273138702695316402") };
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
public class A088920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088920Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088920.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088920Inst Instance=new A088920Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088921
{
public static readonly long[] Value={ 1L,2L,5L,13L,33L,80L,185L,411L,885L,1862L,3853L,7881L,15993L,32284L,64945L,130359L,261293L,523282L,1047397L,2095781L,4192721L,8386792L,16775145L,33552083L,67106213L,134214750L,268432125L,536867201L,1073737705L,2147479092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088921Inst : IEnumerable<long>
{
public static readonly long[] Value=A088921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088921.Bytes);
public long this[int i]=>Value[i];

public static A088921Inst Instance=new A088921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088922
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,5L,4L,6L,6L,7L,6L,10L,7L,9L,10L,11L,9L,13L,10L,14L,13L,13L,12L,18L,14L,15L,16L,18L,15L,21L,16L,20L,19L,19L,20L,25L,19L,21L,22L,26L,21L,27L,22L,26L,27L,25L,24L,32L,26L,29L,28L,30L,27L,33L,30L,34L,31L,31L,30L,40L,31L,33L,36L,37L,35L,39L,34L,38L,37L,41L,36L,46L,37L,39L,42L,42L,41L,45L,40L,48L,44L,43L,42L,52L,45L,45L,46L,50L,45L,55L,48L,50L,49L,49L,50L,58L,49L,53L,54L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088922Inst : IEnumerable<long>
{
public static readonly long[] Value=A088922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088922.Bytes);
public long this[int i]=>Value[i];

public static A088922Inst Instance=new A088922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088923
{
public static readonly long[] Value={ 9L,19L,29L,39L,49L,59L,69L,79L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L,109L,119L,129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088923Inst : IEnumerable<long>
{
public static readonly long[] Value=A088923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088923.Bytes);
public long this[int i]=>Value[i];

public static A088923Inst Instance=new A088923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088924
{
public static readonly long[] Value={ 1L,18L,252L,3168L,37512L,427608L,4748472L,51736248L,555626232L,5900636088L,62105724792L,648951523128L,6740563708152L,69665073373368L,716985660360312L,7352870943242808L,75175838489185272L,766582546402667448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088924Inst : IEnumerable<long>
{
public static readonly long[] Value=A088924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088924.Bytes);
public long this[int i]=>Value[i];

public static A088924Inst Instance=new A088924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088925
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,6L,6L,1L,1L,10L,21L,10L,1L,1L,15L,55L,55L,15L,1L,1L,21L,120L,212L,120L,21L,1L,1L,28L,231L,644L,644L,231L,28L,1L,1L,36L,406L,1652L,2617L,1652L,406L,36L,1L,1L,45L,666L,3738L,8685L,8685L,3738L,666L,45L,1L,1L,55L,1035L,7680L,24735L,36345L,24735L,7680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088925Inst : IEnumerable<long>
{
public static readonly long[] Value=A088925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088925.Bytes);
public long this[int i]=>Value[i];

public static A088925Inst Instance=new A088925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088926
{
public static readonly BigInteger[] Value={ 1L,3L,21L,212L,2617L,36345L,544080L,8577378L,140456625L,2368062095L,40859183247L,718386164556L,12829418522056L,232153200359592L,4248457201595622L,78508329463480160L,1463164022514939392L,BigInteger.Parse("27474112707608092672") };
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
public class A088926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088926Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088926.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088926Inst Instance=new A088926Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088927
{
public static readonly long[] Value={ 1L,2L,5L,14L,43L,142L,496L,1808L,6807L,26270L,103357L,412942L,1670572L,6828824L,28159880L,116997296L,489271039L,2057800158L,8698624303L,36936288650L,157474552403L,673830974654L,2892864930292L,12457038200008L,53789813903620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088927Inst : IEnumerable<long>
{
public static readonly long[] Value=A088927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088927.Bytes);
public long this[int i]=>Value[i];

public static A088927Inst Instance=new A088927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088928
{
public static readonly long[] Value={ 2L,9L,2L,6L,0L,6L,4L,0L,5L,7L,2L,7L,3L,1L,5L,6L,4L,9L,0L,0L,4L,0L,1L,9L,9L,2L,7L,6L,1L,7L,2L,5L,6L,8L,1L,9L,6L,0L,6L,7L,0L,8L,1L,0L,0L,2L,8L,0L,5L,5L,5L,7L,3L,6L,2L,3L,7L,2L,0L,1L,4L,0L,5L,5L,7L,0L,9L,8L,9L,0L,1L,7L,3L,9L,8L,8L,5L,9L,8L,0L,4L,7L,4L,1L,5L,6L,8L,0L,2L,4L,8L,7L,2L,5L,4L,7L,7L,3L,5L,0L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088928Inst : IEnumerable<long>
{
public static readonly long[] Value=A088928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088928.Bytes);
public long this[int i]=>Value[i];

public static A088928Inst Instance=new A088928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088929
{
public static readonly long[] Value={ 1L,1L,2L,6L,23L,102L,497L,2586L,14121L,80006L,466658L,2786516L,16963465L,104952998L,658331520L,4178564242L,26795934011L,173388619910L,1130909675998L,7428671873154L,49107718199253L,326490488777384L,2181920676380877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088929Inst : IEnumerable<long>
{
public static readonly long[] Value=A088929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088929.Bytes);
public long this[int i]=>Value[i];

public static A088929Inst Instance=new A088929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088930
{
public static readonly long[] Value={ 1L,2L,4L,9L,23L,67L,220L,795L,3086L,12633L,53844L,236833L,1068313L,4919512L,23047579L,109563206L,527401808L,2566472416L,12608536729L,62465984781L,311796289951L,1566778163225L,7920718997762L,40261922412697L,205675725994566L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088930Inst : IEnumerable<long>
{
public static readonly long[] Value=A088930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088930.Bytes);
public long this[int i]=>Value[i];

public static A088930Inst Instance=new A088930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088931
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,1L,2L,1L,4L,3L,5L,4L,7L,6L,8L,7L,12L,11L,15L,14L,20L,19L,24L,23L,31L,30L,37L,36L,45L,44L,52L,51L,64L,63L,75L,74L,90L,89L,104L,103L,124L,123L,143L,142L,167L,166L,190L,189L,221L,220L,251L,250L,288L,287L,324L,323L,369L,368L,413L,412L,465L,464L,516L,515L,580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088931Inst : IEnumerable<long>
{
public static readonly long[] Value=A088931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088931.Bytes);
public long this[int i]=>Value[i];

public static A088931Inst Instance=new A088931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088948
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,8L,9L,11L,13L,15L,16L,17L,19L,21L,23L,25L,27L,29L,31L,32L,33L,35L,37L,39L,41L,43L,45L,47L,49L,51L,53L,55L,57L,59L,61L,63L,64L,65L,67L,69L,71L,73L,75L,77L,79L,81L,83L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,105L,107L,109L,111L,113L,115L,117L,119L,121L,123L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088948Inst : IEnumerable<long>
{
public static readonly long[] Value=A088948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088948.Bytes);
public long this[int i]=>Value[i];

public static A088948Inst Instance=new A088948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088949
{
public static readonly long[] Value={ 4L,8L,9L,16L,25L,27L,32L,49L,64L,81L,105L,121L,125L,128L,169L,231L,243L,256L,289L,315L,343L,361L,512L,525L,529L,625L,627L,693L,729L,735L,841L,897L,935L,945L,961L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088949Inst : IEnumerable<long>
{
public static readonly long[] Value=A088949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088949.Bytes);
public long this[int i]=>Value[i];

public static A088949Inst Instance=new A088949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088950
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,2L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,1L,2L,2L,1L,1L,1L,1L,0L,0L,0L,1L,2L,1L,1L,2L,4L,2L,1L,1L,2L,1L,0L,0L,0L,1L,1L,1L,1L,2L,2L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,2L,1L,0L,1L,1L,2L,1L,1L,1L,2L,1L,2L,2L,4L,4L,2L,2L,1L,2L,1L,1L,1L,2L,2L,2L,1L,1L,2L,1L,0L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088950Inst : IEnumerable<long>
{
public static readonly long[] Value=A088950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088950.Bytes);
public long this[int i]=>Value[i];

public static A088950Inst Instance=new A088950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088951
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,0L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088951Inst : IEnumerable<long>
{
public static readonly long[] Value=A088951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088951.Bytes);
public long this[int i]=>Value[i];

public static A088951Inst Instance=new A088951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088952
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,7L,10L,11L,15L,16L,19L,20L,21L,23L,32L,33L,34L,46L,47L,48L,57L,59L,61L,64L,65L,69L,96L,97L,100L,102L,104L,138L,140L,142L,145L,146L,173L,177L,178L,183L,185L,194L,195L,196L,208L,209L,289L,290L,291L,300L,302L,307L,312L,416L,421L,426L,428L,437L,438L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088952Inst : IEnumerable<long>
{
public static readonly long[] Value=A088952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088952.Bytes);
public long this[int i]=>Value[i];

public static A088952Inst Instance=new A088952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088953
{
public static readonly long[] Value={ 1L,3L,4L,8L,12L,20L,28L,40L,52L,72L,96L,136L,176L,228L,304L,412L,532L,696L,928L,1220L,1592L,2120L,2764L,3612L,4688L,6132L,7928L,10324L,13480L,17616L,22948L,29908L,38964L,50748L,66184L,86344L,112364L,146344L,190500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088953Inst : IEnumerable<long>
{
public static readonly long[] Value=A088953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088953.Bytes);
public long this[int i]=>Value[i];

public static A088953Inst Instance=new A088953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088954
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,14L,20L,26L,36L,46L,60L,74L,94L,114L,140L,166L,202L,238L,284L,330L,390L,450L,524L,598L,692L,786L,900L,1014L,1154L,1294L,1460L,1626L,1827L,2028L,2264L,2500L,2780L,3060L,3384L,3708L,4088L,4468L,4904L,5340L,5844L,6348L,6920L,7492L,8148L,8804L,9544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088954Inst : IEnumerable<long>
{
public static readonly long[] Value=A088954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088954.Bytes);
public long this[int i]=>Value[i];

public static A088954Inst Instance=new A088954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088955
{
public static readonly long[] Value={ 61L,181L,241L,421L,541L,601L,661L,1021L,1201L,1321L,1381L,1621L,1741L,1801L,1861L,2161L,2221L,2281L,2341L,2521L,3001L,3061L,3121L,3181L,3301L,3361L,3541L,4021L,4201L,4261L,4441L,4561L,4621L,4801L,4861L,5101L,5281L,5521L,5581L,5641L,5701L,5821L,5881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088955Inst : IEnumerable<long>
{
public static readonly long[] Value=A088955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088955.Bytes);
public long this[int i]=>Value[i];

public static A088955Inst Instance=new A088955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088956
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,1L,16L,9L,3L,1L,125L,64L,18L,4L,1L,1296L,625L,160L,30L,5L,1L,16807L,7776L,1875L,320L,45L,6L,1L,262144L,117649L,27216L,4375L,560L,63L,7L,1L,4782969L,2097152L,470596L,72576L,8750L,896L,84L,8L,1L,100000000L,43046721L,9437184L,1411788L,163296L,15750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088956Inst : IEnumerable<long>
{
public static readonly long[] Value=A088956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088956.Bytes);
public long this[int i]=>Value[i];

public static A088956Inst Instance=new A088956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088957
{
public static readonly BigInteger[] Value={ 1L,2L,6L,29L,212L,2117L,26830L,412015L,7433032L,154076201L,3608522954L,94238893883L,2715385121740L,85574061070045L,2928110179818478L,108110945014584623L,4284188833355367440L,BigInteger.Parse("181370804507130015569"),BigInteger.Parse("8169524599872649117330"),BigInteger.Parse("390114757072969964280163") };
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
public class A088957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088957Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088957.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088957Inst Instance=new A088957Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088958
{
public static readonly long[] Value={ 1L,3L,4L,7L,9L,10L,11L,17L,20L,22L,23L,27L,29L,30L,31L,36L,37L,38L,39L,42L,50L,51L,52L,53L,55L,56L,59L,67L,70L,71L,74L,76L,77L,80L,81L,85L,88L,92L,93L,94L,95L,97L,98L,102L,105L,106L,107L,108L,111L,113L,114L,116L,122L,126L,127L,128L,129L,135L,136L,137L,141L,142L,143L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088958Inst : IEnumerable<long>
{
public static readonly long[] Value=A088958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088958.Bytes);
public long this[int i]=>Value[i];

public static A088958Inst Instance=new A088958Inst();

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