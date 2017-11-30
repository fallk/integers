using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A272413
{
public static readonly long[] Value={ 2L,0L,9L,5L,8L,0L,8L,7L,4L,2L,8L,4L,1L,8L,5L,8L,1L,3L,9L,8L,9L,0L,2L,9L,6L,5L,7L,8L,1L,5L,3L,4L,9L,5L,5L,6L,9L,0L,1L,1L,3L,1L,0L,3L,2L,0L,1L,6L,2L,3L,4L,3L,3L,0L,0L,0L,6L,9L,2L,1L,5L,9L,8L,8L,1L,4L,8L,5L,3L,1L,0L,8L,8L,4L,6L,4L,2L,8L,7L,2L,6L,3L,4L,2L,8L,7L,1L,6L,3L,6L,8L,2L,9L,8L,8L,3L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272413Inst : IEnumerable<long>
{
public static readonly long[] Value=A272413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272413.Bytes);
public long this[int i]=>Value[i];

public static A272413Inst Instance=new A272413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272414
{
public static readonly long[] Value={ 0L,1L,2L,5L,5L,3L,7L,9L,0L,6L,3L,5L,9L,0L,5L,8L,7L,8L,1L,4L,7L,9L,8L,0L,0L,3L,5L,8L,4L,6L,6L,0L,1L,9L,8L,6L,7L,8L,5L,5L,0L,8L,3L,0L,1L,1L,9L,9L,3L,6L,5L,1L,7L,7L,2L,5L,9L,2L,4L,2L,5L,4L,2L,6L,7L,3L,9L,4L,6L,4L,9L,1L,4L,5L,7L,4L,3L,9L,7L,4L,9L,4L,2L,8L,8L,7L,3L,5L,1L,6L,5L,9L,3L,6L,2L,3L,5L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272414Inst : IEnumerable<long>
{
public static readonly long[] Value=A272414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272414.Bytes);
public long this[int i]=>Value[i];

public static A272414Inst Instance=new A272414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272415
{
public static readonly long[] Value={ 0L,8L,8L,3L,1L,6L,0L,9L,8L,8L,8L,3L,1L,5L,3L,6L,3L,1L,0L,1L,0L,5L,4L,2L,5L,6L,6L,4L,2L,9L,8L,7L,6L,7L,0L,1L,1L,7L,2L,3L,6L,4L,3L,2L,0L,4L,5L,1L,1L,6L,3L,3L,3L,0L,4L,6L,6L,7L,8L,7L,4L,0L,9L,3L,0L,9L,4L,2L,7L,0L,2L,2L,3L,9L,5L,7L,4L,6L,0L,9L,9L,0L,6L,0L,9L,6L,5L,9L,4L,8L,5L,1L,3L,9L,9L,7L,1L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272415Inst : IEnumerable<long>
{
public static readonly long[] Value=A272415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272415.Bytes);
public long this[int i]=>Value[i];

public static A272415Inst Instance=new A272415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272416
{
public static readonly long[] Value={ 1L,8L,5L,44L,9L,112L,21L,204L,25L,336L,37L,492L,49L,680L,85L,876L,89L,1136L,101L,1420L,113L,1736L,149L,2060L,161L,2440L,197L,2828L,233L,3248L,341L,3628L,345L,4144L,357L,4684L,369L,5256L,405L,5836L,417L,6472L,453L,7116L,489L,7792L,597L,8428L,609L,9192L,645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272416Inst : IEnumerable<long>
{
public static readonly long[] Value=A272416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272416.Bytes);
public long this[int i]=>Value[i];

public static A272416Inst Instance=new A272416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272417
{
public static readonly long[] Value={ 1L,8L,44L,204L,876L,3628L,14764L,59564L,239276L,959148L,3840684L,15370924L,61500076L,246033068L,984197804L,3936922284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272417Inst : IEnumerable<long>
{
public static readonly long[] Value=A272417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272417.Bytes);
public long this[int i]=>Value[i];

public static A272417Inst Instance=new A272417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272418
{
public static readonly long[] Value={ 1L,9L,14L,58L,67L,179L,200L,404L,429L,765L,802L,1294L,1343L,2023L,2108L,2984L,3073L,4209L,4310L,5730L,5843L,7579L,7728L,9788L,9949L,12389L,12586L,15414L,15647L,18895L,19236L,22864L,23209L,27353L,27710L,32394L,32763L,38019L,38424L,44260L,44677L,51149L,51602L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272418Inst : IEnumerable<long>
{
public static readonly long[] Value=A272418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272418.Bytes);
public long this[int i]=>Value[i];

public static A272418Inst Instance=new A272418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272419
{
public static readonly long[] Value={ 7L,-3L,39L,-35L,103L,-91L,183L,-179L,311L,-299L,455L,-443L,631L,-595L,791L,-787L,1047L,-1035L,1319L,-1307L,1623L,-1587L,1911L,-1899L,2279L,-2243L,2631L,-2595L,3015L,-2907L,3287L,-3283L,3799L,-3787L,4327L,-4315L,4887L,-4851L,5431L,-5419L,6055L,-6019L,6663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272419Inst : IEnumerable<long>
{
public static readonly long[] Value=A272419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272419.Bytes);
public long this[int i]=>Value[i];

public static A272419Inst Instance=new A272419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272452
{
public static readonly long[] Value={ 1L,5L,21L,76L,252L,1108L,5020L,21364L,86476L,343440L,1381412L,5526704L,22126848L,88572656L,354349312L,1417262424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272452Inst : IEnumerable<long>
{
public static readonly long[] Value=A272452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272452.Bytes);
public long this[int i]=>Value[i];

public static A272452Inst Instance=new A272452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272453
{
public static readonly long[] Value={ 1L,6L,18L,39L,71L,115L,188L,264L,373L,477L,662L,818L,1055L,1271L,1636L,1888L,2285L,2653L,3194L,3586L,4235L,4783L,5584L,6188L,7005L,7817L,8814L,9690L,10807L,11843L,13196L,14304L,15845L,17213L,18874L,20454L,22239L,24079L,26160L,28060L,30337L,32409L,34862L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272453Inst : IEnumerable<long>
{
public static readonly long[] Value=A272453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272453.Bytes);
public long this[int i]=>Value[i];

public static A272453Inst Instance=new A272453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272454
{
public static readonly long[] Value={ 4L,7L,9L,11L,12L,29L,3L,33L,-5L,81L,-29L,81L,-21L,149L,-113L,145L,-29L,173L,-149L,257L,-101L,253L,-197L,213L,-5L,185L,-121L,241L,-81L,317L,-245L,433L,-173L,293L,-81L,205L,55L,241L,-181L,377L,-205L,381L,-121L,297L,-45L,281L,75L,169L,79L,245L,-221L,577L,-181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272454Inst : IEnumerable<long>
{
public static readonly long[] Value=A272454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272454.Bytes);
public long this[int i]=>Value[i];

public static A272454Inst Instance=new A272454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272455
{
public static readonly long[] Value={ 1L,4L,13L,28L,33L,84L,69L,172L,117L,280L,153L,428L,225L,592L,281L,788L,365L,992L,445L,1228L,541L,1448L,685L,1792L,809L,2140L,857L,2388L,913L,2636L,1025L,3104L,1193L,3460L,1401L,3944L,1489L,4312L,1629L,4816L,1821L,5288L,2097L,5964L,2325L,6260L,2341L,6932L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272455Inst : IEnumerable<long>
{
public static readonly long[] Value=A272455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272455.Bytes);
public long this[int i]=>Value[i];

public static A272455Inst Instance=new A272455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272456
{
public static readonly long[] Value={ 1L,4L,28L,172L,788L,3104L,12100L,48388L,195740L,783952L,3147184L,12657304L,50782776L,203448672L,814440216L,3259062744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272456Inst : IEnumerable<long>
{
public static readonly long[] Value=A272456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272456.Bytes);
public long this[int i]=>Value[i];

public static A272456Inst Instance=new A272456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272457
{
public static readonly long[] Value={ 1L,5L,18L,46L,79L,163L,232L,404L,521L,801L,954L,1382L,1607L,2199L,2480L,3268L,3633L,4625L,5070L,6298L,6839L,8287L,8972L,10764L,11573L,13713L,14570L,16958L,17871L,20507L,21532L,24636L,25829L,29289L,30690L,34634L,36123L,40435L,42064L,46880L,48701L,53989L,56086L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272457Inst : IEnumerable<long>
{
public static readonly long[] Value=A272457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272457.Bytes);
public long this[int i]=>Value[i];

public static A272457Inst Instance=new A272457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272458
{
public static readonly long[] Value={ 3L,9L,15L,5L,51L,-15L,103L,-55L,163L,-127L,275L,-203L,367L,-311L,507L,-423L,627L,-547L,783L,-687L,907L,-763L,1107L,-983L,1331L,-1283L,1531L,-1475L,1723L,-1611L,2079L,-1911L,2267L,-2059L,2543L,-2455L,2823L,-2683L,3187L,-2995L,3467L,-3191L,3867L,-3639L,3935L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272458Inst : IEnumerable<long>
{
public static readonly long[] Value=A272458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272458.Bytes);
public long this[int i]=>Value[i];

public static A272458Inst Instance=new A272458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272459
{
public static readonly long[] Value={ 0L,1L,7L,18L,40L,71L,119L,180L,264L,365L,495L,646L,832L,1043L,1295L,1576L,1904L,2265L,2679L,3130L,3640L,4191L,4807L,5468L,6200L,6981L,7839L,8750L,9744L,10795L,11935L,13136L,14432L,15793L,17255L,18786L,20424L,22135L,23959L,25860L,27880L,29981L,32207L,34518L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272459Inst : IEnumerable<long>
{
public static readonly long[] Value=A272459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272459.Bytes);
public long this[int i]=>Value[i];

public static A272459Inst Instance=new A272459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272460
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,49L,168L,596L,2170L,8063L,30451L,116545L,451038L,1762065L,6939684L,27523374L,109832228L,440668881L,1776599145L,7193526536L,29240389629L,119276102017L,488106369196L,2003299984825L,8244088853598L,34010402405020L,140627814353509L,582704045483909L,2419228983607503L,10062353339406026L,41924039720446064L,174952464642171681L,731184941189099208L,3060168941260579386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272460Inst : IEnumerable<long>
{
public static readonly long[] Value=A272460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272460.Bytes);
public long this[int i]=>Value[i];

public static A272460Inst Instance=new A272460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272461
{
public static readonly long[] Value={ 1L,1L,2L,5L,14L,43L,140L,474L,1650L,5865L,21194L,77623L,287492L,1074915L,4051824L,15381073L,58749102L,225621404L,870686810L,3374625925L,13130575110L,51271434788L,200845390668L,789081913225L,3108496250028L,12275905239752L,48590260462470L,192736593501813L,766007363990640L,3049978926971396L,12164745517874576L,48596364360237882L,194426663474794450L,778968350863994065L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272461Inst : IEnumerable<long>
{
public static readonly long[] Value=A272461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272461.Bytes);
public long this[int i]=>Value[i];

public static A272461Inst Instance=new A272461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272462
{
public static readonly BigInteger[] Value={ 1L,144L,110736L,210615984L,746983671696L,4257350521714224L,BigInteger.Parse("35587232523796298256"),BigInteger.Parse("410153047417991816658864"),BigInteger.Parse("6233578942096421437956406416"),BigInteger.Parse("120792275605361900683656723353904"),BigInteger.Parse("2906718881167945096170286249866172176"),BigInteger.Parse("85040397046127662408816208740192211143344"),BigInteger.Parse("2972655821721881151201962319719058551015131536"),BigInteger.Parse("122359658857407586222518613315327725437983909211184") };
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
public class A272462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272462Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272462.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272462Inst Instance=new A272462Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272463
{
public static readonly BigInteger[] Value={ 1L,1L,2L,4L,12L,36L,112L,360L,1184L,3969L,13506L,46550L,162160L,570076L,2019864L,7205654L,25859788L,93299268L,338207096L,1231194329L,4499137382L,16498152995L,60689045230L,223891151262L,828156420320L,3070760666368L,11411884518800L,42498639965025L,158575098942194L,592761262161240L,2219513277432130L,8323806778346002L,31262959171040784L,117582688976071889L,442819400938052362L,1669735077567533522L,6303424784771599874L,BigInteger.Parse("23822450122837267190") };
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
public class A272463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272463Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272463.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272463Inst Instance=new A272463Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272464
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,1L,4L,3L,5L,2L,1L,4L,7L,3L,8L,5L,2L,1L,4L,11L,7L,10L,3L,8L,13L,5L,2L,1L,4L,15L,11L,18L,7L,17L,10L,3L,8L,21L,13L,5L,2L,1L,4L,19L,15L,26L,11L,29L,18L,25L,7L,24L,17L,27L,10L,3L,8L,21L,34L,13L,5L,2L,1L,4L,23L,19L,15L,41L,26L,37L,11L,40L,29L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272464Inst : IEnumerable<long>
{
public static readonly long[] Value=A272464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272464.Bytes);
public long this[int i]=>Value[i];

public static A272464Inst Instance=new A272464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272465
{
public static readonly long[] Value={ 1L,2L,4L,7L,12L,19L,29L,43L,64L,95L,142L,211L,317L,480L,726L,1096L,1644L,2458L,3669L,5480L,8204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272465Inst : IEnumerable<long>
{
public static readonly long[] Value=A272465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272465.Bytes);
public long this[int i]=>Value[i];

public static A272465Inst Instance=new A272465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272466
{
public static readonly long[] Value={ 6L,9L,12L,14L,16L,20L,22L,28L,30L,33L,35L,36L,49L,50L,54L,58L,64L,66L,72L,74L,75L,77L,78L,80L,86L,87L,88L,90L,94L,96L,102L,110L,116L,118L,120L,121L,124L,126L,130L,132L,141L,143L,146L,150L,158L,161L,162L,168L,169L,172L,176L,180L,182L,183L,187L,189L,191L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272466Inst : IEnumerable<long>
{
public static readonly long[] Value=A272466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272466.Bytes);
public long this[int i]=>Value[i];

public static A272466Inst Instance=new A272466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272467
{
public static readonly BigInteger[] Value={ 1L,6L,186L,14166L,2009946L,458225526L,153212718906L,70632832168086L,42939614599671066L,BigInteger.Parse("33282798350926545846"),BigInteger.Parse("32036398991671262130426"),BigInteger.Parse("37490905748197466281582806"),BigInteger.Parse("52420996658289450763331680986"),BigInteger.Parse("86309558223400912513674314622966"),BigInteger.Parse("165280246718130394753827229389826746"),BigInteger.Parse("364233987506387128128991081880073730326"),BigInteger.Parse("915234544675507984101674168382043517591706") };
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
public class A272467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272467Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272467.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272467Inst Instance=new A272467Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272516
{
public static readonly long[] Value={ 12600L,27720L,138600L,643500L,4408404L,12687675L,60780720L,238299880L,1295666424L,4208874756L,18840460800L,72351683460L,361100656224L,1228553894491L,5370616442928L,20605640103400L,97659853077800L,342942099783075L,1479570975628200L,5678915129142255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272516Inst : IEnumerable<long>
{
public static readonly long[] Value=A272516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272516.Bytes);
public long this[int i]=>Value[i];

public static A272516Inst Instance=new A272516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272517
{
public static readonly long[] Value={ 37837800L,100900800L,588107520L,2977294320L,20020160160L,164118754800L,635661248040L,3295178686800L,17741374681800L,95826446465904L,623399389674600L,2664090278249400L,13876038856379700L,71797074694745400L,375274098870636420L,2199911433079733100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272517Inst : IEnumerable<long>
{
public static readonly long[] Value=A272517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272517.Bytes);
public long this[int i]=>Value[i];

public static A272517Inst Instance=new A272517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272518
{
public static readonly BigInteger[] Value={ 2053230379200L,6453009763200L,43288940494800L,242418066770880L,1707999012720000L,12887361202716000L,144924867388501200L,620550897351184800L,4048435123506774000L,BigInteger.Parse("23424084614648718000"),BigInteger.Parse("161250104584826056800"),BigInteger.Parse("1013722794731975328000"),BigInteger.Parse("8616255173755280251200") };
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
public class A272518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272518Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272518.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272518Inst Instance=new A272518Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272519
{
public static readonly BigInteger[] Value={ 2431106898187968000L,8812762505931384000L,BigInteger.Parse("67144857188048640000"),BigInteger.Parse("416298114565901568000"),BigInteger.Parse("3144312274410635328000"),BigInteger.Parse("23728992530256389376000"),BigInteger.Parse("238675412699786289427200"),BigInteger.Parse("3207620559498676985664000"),BigInteger.Parse("16207982672116390803648000"),BigInteger.Parse("117220515926387332979520000") };
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
public class A272519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272519Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272519.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272519Inst Instance=new A272519Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272520
{
public static readonly BigInteger[] Value={ BigInteger.Parse("73566121315513295589120000"),BigInteger.Parse("302438498741554659644160000"),BigInteger.Parse("2585849164240292339957568000"),BigInteger.Parse("17681163441201479441398176000"),BigInteger.Parse("144230432460463828639480320000"),BigInteger.Parse("1126747392322972404668523840000"),BigInteger.Parse("11096383744399962905356299840000"),BigInteger.Parse("126335461333640259667975104096000") };
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
public class A272520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272520Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272520.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272520Inst Instance=new A272520Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272521
{
public static readonly BigInteger[] Value={ BigInteger.Parse("65191584694745586153436251091200000"),BigInteger.Parse("299881289595829696305806755019520000"),BigInteger.Parse("2847357699192726409368266158771200000"),BigInteger.Parse("21355182743945448070261996190784000000"),BigInteger.Parse("188337379875526275760583438815706112000"),BigInteger.Parse("1546608042571126104473205339509472000000") };
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
public class A272521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272521Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272521.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272521Inst Instance=new A272521Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272522
{
public static readonly BigInteger[] Value={ BigInteger.Parse("1906765806522767212441719098019963758016000000"),BigInteger.Parse("9707171378661360354248751771737997313536000000"),BigInteger.Parse("101439940907011215701899456014662071926451200000"),BigInteger.Parse("829726696136835328433485294068646178065075200000"),BigInteger.Parse("7898017947032824439221398664897536276307929600000") };
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
public class A272522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272522Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272522.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272522Inst Instance=new A272522Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272523
{
public static readonly long[] Value={ 2L,3L,4L,10L,35L,60L,65L,72L,87L,218L,226L,326L,365L,461L,611L,1244L,1566L,4839L,4913L,5396L,7020L,8410L,9714L,10362L,11405L,21695L,25240L,56076L,56588L,74579L,81990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272523Inst : IEnumerable<long>
{
public static readonly long[] Value=A272523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272523.Bytes);
public long this[int i]=>Value[i];

public static A272523Inst Instance=new A272523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272524
{
public static readonly long[] Value={ 1L,36L,136L,276L,1176L,2016L,2556L,2628L,3240L,4560L,11628L,12720L,12880L,18336L,18528L,25200L,32640L,32896L,51360L,64620L,73920L,86320L,89676L,100128L,114960L,115440L,126756L,131328L,148240L,166176L,248160L,253116L,265356L,270480L,294528L,295296L,320400L,345696L,373680L,380628L,400960L,401856L,438516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272524Inst : IEnumerable<long>
{
public static readonly long[] Value=A272524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272524.Bytes);
public long this[int i]=>Value[i];

public static A272524Inst Instance=new A272524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272525
{
public static readonly BigInteger[] Value={ 1L,22L,343L,4664L,58985L,713306L,8367627L,96021948L,1083676269L,12071330590L,133058984911L,1454046639232L,15775034293553L,170096021947874L,1824417009602195L,19478737997256516L,207133058984910837L,2194787379972565158L,BigInteger.Parse("23182441700960219479"),BigInteger.Parse("244170096021947873800") };
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
public class A272525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272525Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272525.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272525Inst Instance=new A272525Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272526
{
public static readonly long[] Value={ 7L,4L,3L,9L,8L,5L,6L,1L,7L,8L,2L,8L,1L,3L,4L,0L,6L,2L,9L,9L,4L,3L,7L,9L,8L,8L,5L,9L,2L,0L,4L,1L,0L,5L,5L,2L,2L,7L,3L,7L,5L,9L,9L,4L,7L,5L,9L,6L,4L,2L,8L,3L,9L,1L,7L,0L,9L,2L,9L,6L,9L,1L,8L,5L,1L,1L,9L,8L,6L,5L,7L,6L,6L,4L,9L,8L,2L,5L,2L,3L,0L,4L,4L,9L,0L,9L,4L,4L,7L,6L,1L,2L,1L,7L,0L,9L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272526Inst : IEnumerable<long>
{
public static readonly long[] Value=A272526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272526.Bytes);
public long this[int i]=>Value[i];

public static A272526Inst Instance=new A272526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272527
{
public static readonly long[] Value={ 9L,14L,20L,28L,36L,56L,67L,94L,124L,155L,173L,192L,213L,230L,253L,344L,395L,475L,504L,534L,596L,725L,759L,795L,1230L,1359L,1449L,1549L,1596L,1647L,1688L,1745L,1798L,2005L,2119L,2164L,2335L,2395L,2457L,2759L,2885L,2952L,3340L,3627L,3696L,3835L,3909L,3987L,4438L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272527Inst : IEnumerable<long>
{
public static readonly long[] Value=A272527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272527.Bytes);
public long this[int i]=>Value[i];

public static A272527Inst Instance=new A272527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272528
{
public static readonly long[] Value={ 1L,3L,8L,20L,28L,44L,48L,92L,188L,228L,236L,324L,332L,428L,668L,716L,756L,908L,1052L,1388L,1436L,1532L,1868L,1916L,2012L,2252L,2348L,2876L,3356L,3452L,3548L,3932L,4076L,4748L,5132L,5228L,5276L,5468L,5756L,5948L,6092L,6476L,7292L,7628L,8108L,8156L,8252L,8396L,8828L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272528Inst : IEnumerable<long>
{
public static readonly long[] Value=A272528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272528.Bytes);
public long this[int i]=>Value[i];

public static A272528Inst Instance=new A272528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272529
{
public static readonly long[] Value={ 8L,189L,405L,465L,2187L,2565L,3483L,6885L,41283L,46875L,389691L,796875L,13410657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272529Inst : IEnumerable<long>
{
public static readonly long[] Value=A272529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272529.Bytes);
public long this[int i]=>Value[i];

public static A272529Inst Instance=new A272529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272530
{
public static readonly long[] Value={ 0L,3L,7L,27L,15L,427L,55L,31L,215L,219L,111L,119L,63L,431L,443L,471L,439L,223L,239L,1879L,127L,1719L,863L,1755L,891L,887L,879L,3423L,447L,495L,479L,3451L,3447L,255L,3439L,3503L,1727L,27355L,1967L,1787L,1775L,14167L,1783L,1759L,1911L,1903L,895L,7855L,991L,959L,6907L,6895L,7087L,55983L,511L,7099L,6879L,14043L,7007L,3455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272530Inst : IEnumerable<long>
{
public static readonly long[] Value=A272530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272530.Bytes);
public long this[int i]=>Value[i];

public static A272530Inst Instance=new A272530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272531
{
public static readonly long[] Value={ 1L,1L,8L,7L,3L,0L,9L,3L,4L,9L,5L,7L,6L,4L,0L,8L,4L,3L,0L,1L,7L,6L,6L,6L,8L,8L,4L,1L,1L,5L,5L,3L,3L,8L,6L,2L,3L,1L,2L,5L,7L,8L,6L,6L,6L,9L,9L,6L,2L,5L,4L,8L,8L,7L,8L,3L,9L,5L,9L,6L,0L,8L,7L,8L,7L,8L,9L,3L,3L,9L,3L,1L,2L,6L,6L,5L,9L,0L,2L,9L,0L,1L,1L,6L,2L,5L,1L,7L,7L,7L,9L,0L,3L,2L,3L,6L,9L,8L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272531Inst : IEnumerable<long>
{
public static readonly long[] Value=A272531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272531.Bytes);
public long this[int i]=>Value[i];

public static A272531Inst Instance=new A272531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272580
{
public static readonly long[] Value={ 4L,3L,16L,5L,19L,8L,49L,-29L,72L,-7L,103L,-99L,99L,56L,97L,-53L,104L,13L,139L,-103L,148L,43L,188L,-159L,207L,8L,181L,-105L,248L,76L,40L,53L,171L,-20L,357L,-337L,408L,117L,35L,-168L,561L,-81L,132L,-79L,287L,341L,116L,-393L,668L,181L,-193L,9L,611L,-35L,167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272580Inst : IEnumerable<long>
{
public static readonly long[] Value=A272580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272580.Bytes);
public long this[int i]=>Value[i];

public static A272580Inst Instance=new A272580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272581
{
public static readonly long[] Value={ 1L,4L,13L,40L,29L,100L,69L,200L,85L,324L,133L,480L,181L,644L,309L,872L,325L,1124L,373L,1408L,421L,1700L,565L,2048L,613L,2404L,757L,2792L,901L,3140L,1301L,3624L,1317L,4132L,1365L,4672L,1413L,5220L,1557L,5824L,1605L,6436L,1749L,7080L,1893L,7684L,2325L,8416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272581Inst : IEnumerable<long>
{
public static readonly long[] Value=A272581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272581.Bytes);
public long this[int i]=>Value[i];

public static A272581Inst Instance=new A272581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272582
{
public static readonly BigInteger[] Value={ 0L,9L,84L,720L,6480L,63000L,665280L,7620480L,94348800L,1257379200L,17962560000L,273988915200L,4446092851200L,76498950528000L,1391365527552000L,26676557107200000L,537799391281152000L,11373816888225792000UL,BigInteger.Parse("251805357846282240000"),BigInteger.Parse("5824367407574876160000") };
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
public class A272582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272582Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272582.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272582Inst Instance=new A272582Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272583
{
public static readonly long[] Value={ 1L,5L,18L,58L,87L,187L,256L,456L,541L,865L,998L,1478L,1659L,2303L,2612L,3484L,3809L,4933L,5306L,6714L,7135L,8835L,9400L,11448L,12061L,14465L,15222L,18014L,18915L,22055L,23356L,26980L,28297L,32429L,33794L,38466L,39879L,45099L,46656L,52480L,54085L,60521L,62270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272583Inst : IEnumerable<long>
{
public static readonly long[] Value=A272583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272583.Bytes);
public long this[int i]=>Value[i];

public static A272583Inst Instance=new A272583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272584
{
public static readonly long[] Value={ 3L,9L,27L,-11L,71L,-31L,131L,-115L,239L,-191L,347L,-299L,463L,-335L,563L,-547L,799L,-751L,1035L,-987L,1279L,-1135L,1483L,-1435L,1791L,-1647L,2035L,-1891L,2239L,-1839L,2323L,-2307L,2815L,-2767L,3307L,-3259L,3807L,-3663L,4267L,-4219L,4831L,-4687L,5331L,-5187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272584Inst : IEnumerable<long>
{
public static readonly long[] Value=A272584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272584.Bytes);
public long this[int i]=>Value[i];

public static A272584Inst Instance=new A272584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272585
{
public static readonly long[] Value={ 1L,5L,13L,40L,29L,100L,69L,200L,85L,324L,133L,480L,181L,644L,309L,872L,325L,1124L,373L,1408L,421L,1700L,565L,2048L,613L,2404L,757L,2792L,901L,3140L,1301L,3624L,1317L,4132L,1365L,4672L,1413L,5220L,1557L,5824L,1605L,6436L,1749L,7080L,1893L,7684L,2325L,8416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272585Inst : IEnumerable<long>
{
public static readonly long[] Value=A272585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272585.Bytes);
public long this[int i]=>Value[i];

public static A272585Inst Instance=new A272585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272586
{
public static readonly long[] Value={ 1L,5L,40L,200L,872L,3624L,14760L,59560L,239272L,959144L,3840680L,15370920L,61500072L,246033064L,984197800L,3936922280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272586Inst : IEnumerable<long>
{
public static readonly long[] Value=A272586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272586.Bytes);
public long this[int i]=>Value[i];

public static A272586Inst Instance=new A272586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272587
{
public static readonly long[] Value={ 1L,6L,19L,59L,88L,188L,257L,457L,542L,866L,999L,1479L,1660L,2304L,2613L,3485L,3810L,4934L,5307L,6715L,7136L,8836L,9401L,11449L,12062L,14466L,15223L,18015L,18916L,22056L,23357L,26981L,28298L,32430L,33795L,38467L,39880L,45100L,46657L,52481L,54086L,60522L,62271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272587Inst : IEnumerable<long>
{
public static readonly long[] Value=A272587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272587.Bytes);
public long this[int i]=>Value[i];

public static A272587Inst Instance=new A272587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272588
{
public static readonly long[] Value={ 4L,8L,27L,-11L,71L,-31L,131L,-115L,239L,-191L,347L,-299L,463L,-335L,563L,-547L,799L,-751L,1035L,-987L,1279L,-1135L,1483L,-1435L,1791L,-1647L,2035L,-1891L,2239L,-1839L,2323L,-2307L,2815L,-2767L,3307L,-3259L,3807L,-3663L,4267L,-4219L,4831L,-4687L,5331L,-5187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272588Inst : IEnumerable<long>
{
public static readonly long[] Value=A272588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272588.Bytes);
public long this[int i]=>Value[i];

public static A272588Inst Instance=new A272588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272589
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,12L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272589Inst : IEnumerable<long>
{
public static readonly long[] Value=A272589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272589.Bytes);
public long this[int i]=>Value[i];

public static A272589Inst Instance=new A272589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272590
{
public static readonly BigInteger[] Value={ 2L,8L,24L,120L,840L,9240L,120120L,2042040L,38798760L,892371480L,25878772920L,802241960520L,29682952539240L,1217001054108840L,52331045326680120L,2459559130353965640L,BigInteger.Parse("130356633908760178920"),BigInteger.Parse("7691041400616850556280"),BigInteger.Parse("469153525437627883933080"),BigInteger.Parse("31433286204321068223516360") };
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
public class A272590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272590Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272590.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272590Inst Instance=new A272590Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272591
{
public static readonly long[] Value={ 2L,3L,0L,5L,2L,2L,3L,9L,2L,8L,7L,2L,9L,3L,0L,0L,5L,6L,6L,3L,1L,4L,7L,0L,1L,9L,1L,0L,9L,3L,3L,3L,2L,0L,8L,2L,8L,2L,3L,8L,5L,5L,8L,4L,7L,6L,0L,1L,8L,4L,6L,1L,7L,4L,3L,2L,6L,7L,3L,7L,1L,5L,4L,8L,5L,0L,9L,7L,3L,7L,8L,9L,7L,7L,9L,5L,6L,5L,9L,9L,2L,6L,9L,9L,5L,0L,5L,9L,2L,1L,8L,3L,0L,9L,4L,3L,7L,4L,8L,2L,7L,7L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272591Inst : IEnumerable<long>
{
public static readonly long[] Value=A272591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272591.Bytes);
public long this[int i]=>Value[i];

public static A272591Inst Instance=new A272591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272592
{
public static readonly long[] Value={ 8L,12L,15L,16L,20L,21L,28L,30L,32L,33L,35L,36L,39L,42L,44L,45L,51L,52L,55L,57L,63L,64L,65L,66L,68L,69L,70L,75L,76L,77L,78L,85L,87L,90L,91L,92L,93L,95L,99L,100L,102L,108L,110L,111L,114L,115L,116L,117L,119L,123L,124L,126L,128L,129L,130L,133L,135L,138L,141L,143L,145L,147L,148L,150L,153L,154L,155L,159L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272592Inst : IEnumerable<long>
{
public static readonly long[] Value=A272592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272592.Bytes);
public long this[int i]=>Value[i];

public static A272592Inst Instance=new A272592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272593
{
public static readonly long[] Value={ 24L,40L,48L,56L,60L,72L,80L,84L,88L,96L,104L,105L,112L,132L,136L,140L,144L,152L,156L,160L,165L,176L,180L,184L,192L,195L,200L,204L,208L,210L,216L,220L,224L,228L,231L,232L,248L,252L,255L,260L,272L,273L,276L,285L,288L,296L,300L,304L,308L,315L,320L,328L,330L,340L,344L,345L,348L,352L,357L,364L,368L,372L,376L,380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272593Inst : IEnumerable<long>
{
public static readonly long[] Value=A272593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272593.Bytes);
public long this[int i]=>Value[i];

public static A272593Inst Instance=new A272593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272594
{
public static readonly long[] Value={ 120L,168L,240L,264L,280L,312L,336L,360L,408L,420L,440L,456L,480L,504L,520L,528L,552L,560L,600L,616L,624L,660L,672L,680L,696L,720L,728L,744L,760L,780L,792L,816L,880L,888L,912L,920L,924L,936L,952L,960L,984L,1008L,1020L,1032L,1040L,1056L,1064L,1080L,1092L,1104L,1120L,1128L,1140L,1144L,1155L,1160L,1176L,1200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272594Inst : IEnumerable<long>
{
public static readonly long[] Value=A272594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272594.Bytes);
public long this[int i]=>Value[i];

public static A272594Inst Instance=new A272594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272595
{
public static readonly long[] Value={ 840L,1320L,1560L,1680L,1848L,2040L,2184L,2280L,2520L,2640L,2760L,2856L,3080L,3120L,3192L,3360L,3432L,3480L,3640L,3696L,3720L,3864L,3960L,4080L,4200L,4368L,4440L,4488L,4560L,4620L,4680L,4760L,4872L,4920L,5016L,5040L,5160L,5208L,5280L,5304L,5320L,5460L,5520L,5544L,5640L,5712L,5720L,5880L,5928L,6072L,6120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272595Inst : IEnumerable<long>
{
public static readonly long[] Value=A272595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272595.Bytes);
public long this[int i]=>Value[i];

public static A272595Inst Instance=new A272595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272612
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,3L,4L,3L,4L,5L,4L,5L,5L,5L,7L,5L,6L,8L,5L,7L,9L,6L,9L,8L,8L,8L,9L,11L,10L,9L,10L,10L,10L,10L,11L,11L,12L,15L,10L,12L,16L,10L,16L,12L,13L,15L,12L,15L,18L,13L,14L,15L,17L,14L,17L,15L,17L,19L,17L,15L,20L,20L,16L,19L,19L,19L,21L,19L,19L,20L,20L,20L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272612Inst : IEnumerable<long>
{
public static readonly long[] Value=A272612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272612.Bytes);
public long this[int i]=>Value[i];

public static A272612Inst Instance=new A272612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272613
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,4L,5L,5L,6L,8L,6L,8L,9L,9L,13L,10L,12L,14L,11L,17L,17L,14L,17L,22L,16L,23L,17L,24L,22L,23L,23L,23L,26L,31L,28L,28L,35L,37L,32L,32L,39L,33L,39L,46L,34L,49L,33L,45L,48L,45L,46L,60L,54L,58L,56L,58L,50L,70L,54L,53L,73L,57L,61L,61L,77L,50L,73L,56L,68L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272613Inst : IEnumerable<long>
{
public static readonly long[] Value=A272613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272613.Bytes);
public long this[int i]=>Value[i];

public static A272613Inst Instance=new A272613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272614
{
public static readonly long[] Value={ 1L,2L,6L,8L,28L,40L,104L,144L,496L,672L,1632L,2240L,7872L,11648L,27520L,33536L,120576L,175616L,445952L,629760L,2014208L,2701312L,6453248L,8712192L,33353728L,48881664L,114548736L,144949248L,476561408L,684687360L,1787789312L,2501836800L,8510177280L,11647451136L,27590000640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272614Inst : IEnumerable<long>
{
public static readonly long[] Value=A272614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272614.Bytes);
public long this[int i]=>Value[i];

public static A272614Inst Instance=new A272614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272615
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,8L,12L,63L,240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272615Inst : IEnumerable<long>
{
public static readonly long[] Value=A272615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272615.Bytes);
public long this[int i]=>Value[i];

public static A272615Inst Instance=new A272615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272616
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,6L,7L,11L,15L,9L,10L,14L,19L,32L,12L,13L,18L,23L,37L,43L,16L,17L,22L,27L,42L,49L,68L,20L,21L,26L,31L,48L,55L,75L,83L,24L,25L,30L,36L,54L,61L,82L,91L,116L,28L,29L,35L,41L,60L,67L,90L,99L,125L,171L,33L,34L,40L,47L,66L,74L,98L,107L,134L,181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272616Inst : IEnumerable<long>
{
public static readonly long[] Value=A272616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272616.Bytes);
public long this[int i]=>Value[i];

public static A272616Inst Instance=new A272616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272617
{
public static readonly BigInteger[] Value={ 11L,2112L,321123L,43211234L,5432112345L,654321123456L,76543211234567L,8765432112345678L,987654321123456789L,BigInteger.Parse("1098765432112345678910") };
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
public class A272617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272617Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272617.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272617Inst Instance=new A272617Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272618
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,4L,0L,0L,0L,4L,8L,0L,8L,9L,0L,4L,8L,9L,0L,0L,4L,8L,12L,16L,0L,8L,16L,9L,4L,8L,16L,0L,9L,16L,18L,0L,4L,8L,16L,0L,8L,16L,0L,4L,8L,9L,12L,16L,18L,20L,24L,25L,27L,0L,0L,9L,27L,4L,8L,16L,32L,25L,8L,16L,24L,27L,32L,0L,4L,8L,16L,32L,9L,27L,16L,25L,32L,0L,4L,8L,9L,12L,16L,18L,24L,27L,28L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272618Inst : IEnumerable<long>
{
public static readonly long[] Value=A272618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272618.Bytes);
public long this[int i]=>Value[i];

public static A272618Inst Instance=new A272618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272619
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,6L,6L,6L,0L,10L,0L,6L,10L,12L,6L,10L,12L,6L,10L,12L,14L,0L,10L,14L,15L,0L,6L,12L,14L,15L,18L,6L,12L,14L,15L,18L,6L,10L,12L,14L,18L,20L,0L,10L,14L,15L,20L,21L,22L,10L,15L,20L,6L,10L,12L,14L,18L,20L,22L,24L,6L,12L,15L,18L,21L,24L,6L,10L,12L,18L,20L,21L,22L,24L,26L,0L,14L,21L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272619Inst : IEnumerable<long>
{
public static readonly long[] Value=A272619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272619.Bytes);
public long this[int i]=>Value[i];

public static A272619Inst Instance=new A272619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272620
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,1L,4L,1L,1L,3L,3L,2L,3L,1L,7L,1L,2L,3L,2L,1L,3L,3L,7L,2L,3L,1L,7L,1L,1L,4L,5L,3L,2L,1L,9L,2L,5L,3L,6L,5L,3L,3L,7L,2L,2L,5L,6L,3L,3L,5L,9L,4L,4L,4L,9L,4L,4L,5L,6L,6L,1L,6L,12L,2L,2L,7L,4L,4L,6L,5L,11L,7L,3L,5L,9L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272620Inst : IEnumerable<long>
{
public static readonly long[] Value=A272620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272620.Bytes);
public long this[int i]=>Value[i];

public static A272620Inst Instance=new A272620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272621
{
public static readonly long[] Value={ 3L,9L,15L,155L,217L,281L,287L,491L,563L,581L,983L,2243L,4375L,8409L,98669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272621Inst : IEnumerable<long>
{
public static readonly long[] Value=A272621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272621.Bytes);
public long this[int i]=>Value[i];

public static A272621Inst Instance=new A272621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272622
{
public static readonly long[] Value={ 1L,2L,4L,5L,10L,14L,25L,34L,40L,63L,74L,129L,149L,345L,370L,425L,477L,627L,951L,1610L,2564L,2689L,4227L,7300L,7444L,8360L,16541L,21187L,25685L,31803L,89858L,92821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272622Inst : IEnumerable<long>
{
public static readonly long[] Value=A272622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272622.Bytes);
public long this[int i]=>Value[i];

public static A272622Inst Instance=new A272622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272623
{
public static readonly BigInteger[] Value={ 0L,1L,2L,3L,5L,8L,55L,17711L,63245986L,165580141L,498454011879264L,14472334024676221L,1100087778366101931L,BigInteger.Parse("298611126818977066918552"),BigInteger.Parse("781774079430987230203437"),BigInteger.Parse("14028366653498915298923761"),BigInteger.Parse("22698374052006863956975682"),BigInteger.Parse("36726740705505779255899443"),BigInteger.Parse("59425114757512643212875125") };
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
public class A272623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272623Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272623.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272623Inst Instance=new A272623Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272624
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,2L,0L,0L,4L,4L,4L,4L,4L,0L,0L,8L,8L,14L,14L,8L,8L,0L,0L,12L,18L,24L,36L,24L,18L,12L,0L,0L,18L,28L,44L,58L,58L,44L,28L,18L,0L,0L,24L,44L,64L,94L,100L,94L,64L,44L,24L,0L,0L,32L,60L,96L,130L,160L,160L,130L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272624Inst : IEnumerable<long>
{
public static readonly long[] Value=A272624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272624.Bytes);
public long this[int i]=>Value[i];

public static A272624Inst Instance=new A272624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272625
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,8L,0L,0L,0L,0L,18L,18L,0L,0L,0L,0L,30L,48L,30L,0L,0L,0L,0L,44L,84L,84L,44L,0L,0L,0L,0L,60L,128L,164L,128L,60L,0L,0L,0L,0L,78L,176L,264L,264L,176L,78L,0L,0L,0L,0L,98L,228L,374L,448L,374L,228L,98L,0L,0L,0L,0L,120L,284L,492L,650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272625Inst : IEnumerable<long>
{
public static readonly long[] Value=A272625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272625.Bytes);
public long this[int i]=>Value[i];

public static A272625Inst Instance=new A272625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272626
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,0L,0L,10L,10L,0L,0L,16L,28L,16L,0L,0L,22L,50L,50L,22L,0L,0L,28L,74L,96L,74L,28L,0L,0L,34L,98L,150L,150L,98L,34L,0L,0L,40L,122L,208L,244L,208L,122L,40L,0L,0L,46L,146L,268L,350L,350L,268L,146L,46L,0L,0L,52L,170L,328L,464L,516L,464L,328L,170L,52L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272626Inst : IEnumerable<long>
{
public static readonly long[] Value=A272626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272626.Bytes);
public long this[int i]=>Value[i];

public static A272626Inst Instance=new A272626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272627
{
public static readonly long[] Value={ 21L,69L,77L,93L,133L,141L,213L,237L,253L,301L,309L,341L,381L,413L,437L,453L,469L,501L,517L,573L,581L,589L,597L,669L,717L,749L,781L,789L,813L,869L,893L,917L,933L,973L,989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272627Inst : IEnumerable<long>
{
public static readonly long[] Value=A272627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272627.Bytes);
public long this[int i]=>Value[i];

public static A272627Inst Instance=new A272627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272644
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,13L,13L,1L,1L,29L,73L,29L,1L,1L,61L,301L,301L,61L,1L,1L,125L,1081L,2069L,1081L,125L,1L,1L,253L,3613L,11581L,11581L,3613L,253L,1L,1L,509L,11593L,57749L,95401L,57749L,11593L,509L,1L,1L,1021L,36301L,268381L,673261L,673261L,268381L,36301L,1021L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272644Inst : IEnumerable<long>
{
public static readonly long[] Value=A272644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272644.Bytes);
public long this[int i]=>Value[i];

public static A272644Inst Instance=new A272644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272645
{
public static readonly long[] Value={ 1L,1L,5L,13L,73L,301L,2069L,11581L,95401L,673261L,6487445L,55213453L,610093513L,6077248381L,75796724309L,864806272861L,12020754177001L,154546274524621L,2369364111428885L,33888536448984493L,568128719132038153L,8947078682269788061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272645Inst : IEnumerable<long>
{
public static readonly long[] Value=A272645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272645.Bytes);
public long this[int i]=>Value[i];

public static A272645Inst Instance=new A272645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272646
{
public static readonly BigInteger[] Value={ 1L,1L,7L,65L,859L,14733L,311111L,7807241L,227032211L,7507677445L,278238129887L,11422778680257L,514581516871339L,25237339884056125L,1338608176888717303L,BigInteger.Parse("76351140762424998521"),BigInteger.Parse("4660096802861702344387"),BigInteger.Parse("303058994467535502382197"),BigInteger.Parse("20920390811865673069060367"),BigInteger.Parse("1527794647255129205046171185") };
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
public class A272646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272646Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272646.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272646Inst Instance=new A272646Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272647
{
public static readonly long[] Value={ 1L,3L,5L,4L,5L,3L,1L,1L,3L,5L,4L,5L,3L,1L,1L,3L,5L,4L,5L,3L,1L,1L,3L,5L,4L,5L,3L,1L,1L,3L,5L,4L,5L,3L,1L,1L,3L,5L,4L,5L,3L,1L,1L,3L,5L,4L,5L,3L,1L,1L,3L,5L,4L,5L,3L,1L,1L,3L,5L,4L,5L,3L,1L,1L,3L,5L,4L,5L,3L,1L,1L,3L,5L,4L,5L,3L,1L,1L,3L,5L,4L,5L,3L,1L,1L,3L,5L,4L,5L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272647Inst : IEnumerable<long>
{
public static readonly long[] Value=A272647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272647.Bytes);
public long this[int i]=>Value[i];

public static A272647Inst Instance=new A272647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272648
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,1L,6L,6L,0L,6L,0L,6L,6L,1L,1L,0L,1L,0L,1L,1L,6L,6L,0L,6L,0L,6L,6L,1L,1L,0L,1L,0L,1L,1L,6L,6L,0L,6L,0L,6L,6L,1L,1L,0L,1L,0L,1L,1L,6L,6L,0L,6L,0L,6L,6L,1L,1L,0L,1L,0L,1L,1L,6L,6L,0L,6L,0L,6L,6L,1L,1L,0L,1L,0L,1L,1L,6L,6L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272648Inst : IEnumerable<long>
{
public static readonly long[] Value=A272648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272648.Bytes);
public long this[int i]=>Value[i];

public static A272648Inst Instance=new A272648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272649
{
public static readonly long[] Value={ 1L,2L,3L,7L,10L,13L,31L,37L,61L,83L,127L,179L,193L,277L,383L,479L,541L,641L,877L,1013L,1423L,2251L,2339L,2557L,2663L,3083L,3301L,5693L,6229L,9091L,9377L,17107L,25447L,31193L,39233L,40879L,46309L,61471L,72089L,81707L,86111L,91243L,116329L,136207L,149459L,163729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272649Inst : IEnumerable<long>
{
public static readonly long[] Value=A272649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272649.Bytes);
public long this[int i]=>Value[i];

public static A272649Inst Instance=new A272649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272650
{
public static readonly long[] Value={ 1L,5L,29L,83L,351L,519L,1291L,1747L,3357L,6553L,7501L,11839L,17219L,19263L,28199L,38583L,56049L,49043L,74771L,96133L,89059L,132087L,155209L,185653L,221741L,260983L,274803L,331913L,314355L,348943L,482091L,569587L,641707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272650Inst : IEnumerable<long>
{
public static readonly long[] Value=A272650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272650.Bytes);
public long this[int i]=>Value[i];

public static A272650Inst Instance=new A272650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272651
{
public static readonly long[] Value={ 1L,4L,6L,8L,10L,12L,14L,16L,18L,20L,22L,24L,26L,28L,30L,32L,34L,36L,38L,40L,42L,44L,46L,48L,50L,52L,54L,56L,58L,60L,62L,64L,66L,68L,70L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272651Inst : IEnumerable<long>
{
public static readonly long[] Value=A272651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272651.Bytes);
public long this[int i]=>Value[i];

public static A272651Inst Instance=new A272651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272652
{
public static readonly BigInteger[] Value={ 0L,14L,134L,4102L,BigInteger.Parse("87112285931760246646623899502532662132742"),BigInteger.Parse("1852673427797059126777135760139006525652319754650249024631321344126610074239106") };
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
public class A272652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272652Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272652.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272652Inst Instance=new A272652Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272653
{
public static readonly long[] Value={ 3L,9L,10L,15L,33L,34L,36L,43L,45L,46L,51L,53L,54L,63L,129L,130L,132L,136L,147L,149L,150L,153L,154L,156L,163L,165L,166L,169L,170L,172L,183L,187L,189L,190L,195L,197L,198L,201L,202L,204L,215L,219L,221L,222L,231L,235L,237L,238L,255L,513L,514L,516L,520L,528L,547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272653Inst : IEnumerable<long>
{
public static readonly long[] Value=A272653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272653.Bytes);
public long this[int i]=>Value[i];

public static A272653Inst Instance=new A272653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272654
{
public static readonly long[] Value={ 11L,1001L,1010L,1111L,100001L,100010L,100100L,101011L,101101L,101110L,110011L,110101L,110110L,111111L,10000001L,10000010L,10000100L,10001000L,10010011L,10010101L,10010110L,10011001L,10011010L,10011100L,10100011L,10100101L,10100110L,10101001L,10101010L,10101100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272654Inst : IEnumerable<long>
{
public static readonly long[] Value=A272654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272654.Bytes);
public long this[int i]=>Value[i];

public static A272654Inst Instance=new A272654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272655
{
public static readonly long[] Value={ 11L,22L,33L,44L,55L,66L,77L,88L,99L,1001L,1010L,1111L,1212L,1221L,1313L,1331L,1414L,1441L,1515L,1551L,1616L,1661L,1717L,1771L,1818L,1881L,1919L,1991L,2002L,2020L,2112L,2121L,2222L,2323L,2332L,2424L,2442L,2525L,2552L,2626L,2662L,2727L,2772L,2828L,2882L,2929L,2992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272655Inst : IEnumerable<long>
{
public static readonly long[] Value=A272655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272655.Bytes);
public long this[int i]=>Value[i];

public static A272655Inst Instance=new A272655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272656
{
public static readonly BigInteger[] Value={ 0L,1L,13L,461L,29093L,2829325L,392743957L,73943424413L,18176728317413L,5661698774848621L,2181096921557783605L,BigInteger.Parse("1018705098450570562877"),BigInteger.Parse("567347013156626397484421"),BigInteger.Parse("371514945708955154128328461"),BigInteger.Parse("282629242654284555347577144277"),BigInteger.Parse("247210800978211588125067686948317") };
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
public class A272656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272656Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272656.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272656Inst Instance=new A272656Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272657
{
public static readonly BigInteger[] Value={ 1L,3L,71L,3447L,273343L,31998903L,5201061455L,1123596277863L,311951144828863L,108355864447215063L,BigInteger.Parse("46066653228356851631"),BigInteger.Parse("23539631662517304379719"),BigInteger.Parse("14238556471214701698866335"),BigInteger.Parse("10063612905845566536549621687"),BigInteger.Parse("8219089293266835899526592972943"),BigInteger.Parse("7682002790499533568011331441585447") };
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
public class A272657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272657Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A272657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272657.Bytes);
public BigInteger this[int i]=>Value[i];

public static A272657Inst Instance=new A272657Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272658
{
public static readonly long[] Value={ 3L,16L,209L,8739L,1839102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272658Inst : IEnumerable<long>
{
public static readonly long[] Value=A272658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272658.Bytes);
public long this[int i]=>Value[i];

public static A272658Inst Instance=new A272658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272659
{
public static readonly long[] Value={ 3L,22L,513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272659Inst : IEnumerable<long>
{
public static readonly long[] Value=A272659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272659.Bytes);
public long this[int i]=>Value[i];

public static A272659Inst Instance=new A272659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272692
{
public static readonly long[] Value={ 805520L,163366L,424532L,909522L,1686222L,841354L,952236L,2297880L,404028L,3035810L,3710860L,7974450L,2371952L,4346998L,2370800L,16466490L,3419802L,5186806L,3908612L,5856750L,820132L,6870656L,5119108L,509922L,20820114L,5959694L,7727544L,9082170L,22438260L,2739580L,14286782L,3515668L,10049670L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272692Inst : IEnumerable<long>
{
public static readonly long[] Value=A272692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272692.Bytes);
public long this[int i]=>Value[i];

public static A272692Inst Instance=new A272692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272693
{
public static readonly long[] Value={ 0L,-1L,-2L,-5L,-4L,-3L,-3L,0L,5L,2L,-3L,-6L,-7L,-5L,2L,9L,4L,-5L,-10L,-9L,-3L,6L,11L,5L,-10L,-21L,-12L,5L,14L,9L,-5L,-19L,-17L,-4L,15L,16L,1L,-15L,-21L,-12L,11L,20L,9L,-11L,-25L,-17L,2L,21L,16L,-5L,-22L,-21L,-3L,18L,23L,5L,-22L,-33L,-15L,18L,35L,17L,-22L,-45L,-24L,17L,38L,21L,-17L,-43L,-29L,8L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272693Inst : IEnumerable<long>
{
public static readonly long[] Value=A272693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272693.Bytes);
public long this[int i]=>Value[i];

public static A272693Inst Instance=new A272693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272694
{
public static readonly long[] Value={ 0L,-1L,-1L,-3L,-2L,-2L,-2L,0L,3L,1L,-2L,-3L,-4L,-3L,1L,5L,2L,-3L,-5L,-5L,-2L,3L,6L,3L,-5L,-11L,-6L,3L,7L,5L,-3L,-10L,-9L,-2L,8L,8L,1L,-8L,-11L,-6L,6L,10L,5L,-6L,-13L,-9L,1L,11L,8L,-3L,-11L,-11L,-2L,9L,12L,3L,-11L,-17L,-8L,9L,18L,9L,-11L,-23L,-12L,9L,19L,11L,-9L,-22L,-15L,4L,20L,14L,-6L,-20L,-17L,2L,19L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272694Inst : IEnumerable<long>
{
public static readonly long[] Value=A272694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272694.Bytes);
public long this[int i]=>Value[i];

public static A272694Inst Instance=new A272694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272695
{
public static readonly long[] Value={ 0L,1L,2L,0L,-3L,-5L,-2L,5L,8L,4L,-5L,-11L,-6L,5L,14L,10L,-5L,-16L,-14L,3L,18L,18L,0L,-19L,-22L,-3L,20L,26L,8L,-19L,-30L,-13L,18L,33L,18L,-15L,-36L,-24L,11L,38L,30L,-7L,-38L,-36L,1L,38L,41L,6L,-37L,-47L,-13L,34L,51L,21L,-30L,-55L,-29L,25L,58L,38L,-18L,-59L,-46L,11L,59L,54L,-2L,-57L,-61L,-8L,54L,68L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272695Inst : IEnumerable<long>
{
public static readonly long[] Value=A272695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272695.Bytes);
public long this[int i]=>Value[i];

public static A272695Inst Instance=new A272695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272696
{
public static readonly long[] Value={ 6L,5L,8L,12L,18L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272696Inst : IEnumerable<long>
{
public static readonly long[] Value=A272696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272696.Bytes);
public long this[int i]=>Value[i];

public static A272696Inst Instance=new A272696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272697
{
public static readonly long[] Value={ 1L,16L,32L,128L,256L,1024L,4096L,262144L,524288L,8388608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272697Inst : IEnumerable<long>
{
public static readonly long[] Value=A272697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272697.Bytes);
public long this[int i]=>Value[i];

public static A272697Inst Instance=new A272697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272698
{
public static readonly long[] Value={ 2L,4L,8L,16L,32L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272698Inst : IEnumerable<long>
{
public static readonly long[] Value=A272698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272698.Bytes);
public long this[int i]=>Value[i];

public static A272698Inst Instance=new A272698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272699
{
public static readonly long[] Value={ 2L,7L,5L,3L,7L,5L,5L,2L,7L,5L,2L,7L,5L,2L,2L,5L,2L,2L,7L,5L,2L,7L,5L,3L,7L,7L,3L,2L,7L,5L,3L,7L,5L,5L,2L,5L,5L,2L,7L,5L,2L,2L,5L,3L,2L,7L,5L,2L,7L,7L,3L,7L,7L,5L,2L,7L,5L,3L,7L,5L,5L,2L,5L,5L,2L,2L,5L,2L,2L,7L,3L,2L,7L,5L,3L,7L,7L,3L,7L,7L,5L,2L,7L,5L,5L,2L,5L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272699Inst : IEnumerable<long>
{
public static readonly long[] Value=A272699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272699.Bytes);
public long this[int i]=>Value[i];

public static A272699Inst Instance=new A272699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272700
{
public static readonly long[] Value={ 1L,6L,18L,43L,71L,127L,183L,296L,356L,476L,596L,836L,956L,1196L,1436L,1917L,2041L,2289L,2537L,3033L,3281L,3777L,4273L,5265L,5513L,6009L,6505L,7497L,7993L,8985L,9977L,11962L,12214L,12718L,13222L,14230L,14734L,15742L,16750L,18766L,19270L,20278L,21286L,23302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272700Inst : IEnumerable<long>
{
public static readonly long[] Value=A272700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272700.Bytes);
public long this[int i]=>Value[i];

public static A272700Inst Instance=new A272700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272701
{
public static readonly long[] Value={ 4624776L,15438250L,27445392L,36998208L,123506000L,127396178L,216226981L,219563136L,238328064L,269442621L,295985664L,310289733L,406767816L,423432360L,449519625L,510200217L,578097000L,590421637L,632767581L,634207392L,715674609L,751462677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272701Inst : IEnumerable<long>
{
public static readonly long[] Value=A272701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272701.Bytes);
public long this[int i]=>Value[i];

public static A272701Inst Instance=new A272701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272702
{
public static readonly long[] Value={ 1L,4L,13L,24L,53L,65L,113L,112L,229L,241L,321L,289L,505L,489L,601L,480L,965L,977L,1121L,1025L,1433L,1353L,1529L,1217L,2153L,2105L,2313L,2033L,2753L,2489L,2729L,1984L,3973L,3985L,4257L,4033L,4825L,4617L,4921L,4225L,6057L,5881L,6217L,5553L,6913L,6265L,6633L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272702Inst : IEnumerable<long>
{
public static readonly long[] Value=A272702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272702.Bytes);
public long this[int i]=>Value[i];

public static A272702Inst Instance=new A272702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272703
{
public static readonly long[] Value={ 1L,5L,18L,42L,95L,160L,273L,385L,614L,855L,1176L,1465L,1970L,2459L,3060L,3540L,4505L,5482L,6603L,7628L,9061L,10414L,11943L,13160L,15313L,17418L,19731L,21764L,24517L,27006L,29735L,31719L,35692L,39677L,43934L,47967L,52792L,57409L,62330L,66555L,72612L,78493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272703Inst : IEnumerable<long>
{
public static readonly long[] Value=A272703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272703.Bytes);
public long this[int i]=>Value[i];

public static A272703Inst Instance=new A272703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A272704
{
public static readonly long[] Value={ 3L,9L,11L,29L,12L,48L,-1L,117L,12L,80L,-32L,216L,-16L,112L,-121L,485L,12L,144L,-96L,408L,-80L,176L,-312L,936L,-48L,208L,-280L,720L,-264L,240L,-745L,1989L,12L,272L,-224L,792L,-208L,304L,-696L,1832L,-176L,336L,-664L,1360L,-648L,368L,-1640L,3912L,-112L,400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A272704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A272704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A272704Inst : IEnumerable<long>
{
public static readonly long[] Value=A272704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A272704.Bytes);
public long this[int i]=>Value[i];

public static A272704Inst Instance=new A272704Inst();

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