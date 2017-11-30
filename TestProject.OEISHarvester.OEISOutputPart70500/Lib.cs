using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A142593
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,4L,1L,1L,5L,1L,1L,6L,1L,1L,1L,7L,1L,1L,1L,8L,3L,1L,1L,9L,3L,1L,1L,10L,3L,1L,1L,1L,11L,3L,1L,1L,1L,12L,3L,1L,1L,1L,1L,13L,3L,1L,1L,1L,1L,14L,3L,1L,1L,1L,1L,15L,3L,1L,1L,1L,1L,16L,3L,1L,1L,1L,1L,1L,17L,3L,1L,1L,1L,1L,1L,18L,3L,1L,1L,1L,1L,1L,1L,19L,3L,1L,1L,1L,1L,1L,1L,20L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142593Inst : IEnumerable<long>
{
public static readonly long[] Value=A142593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142593.Bytes);
public long this[int i]=>Value[i];

public static A142593Inst Instance=new A142593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142594
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,24L,27L,30L,33L,36L,39L,42L,45L,48L,51L,54L,57L,60L,63L,66L,69L,288L,300L,390L,405L,420L,435L,450L,465L,480L,495L,510L,525L,540L,555L,570L,585L,600L,615L,630L,645L,660L,675L,690L,705L,1728L,1764L,1800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142594Inst : IEnumerable<long>
{
public static readonly long[] Value=A142594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142594.Bytes);
public long this[int i]=>Value[i];

public static A142594Inst Instance=new A142594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142595
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,10L,10L,1L,1L,22L,40L,22L,1L,1L,46L,124L,124L,46L,1L,1L,94L,340L,496L,340L,94L,1L,1L,190L,868L,1672L,1672L,868L,190L,1L,1L,382L,2116L,5080L,6688L,5080L,2116L,382L,1L,1L,766L,4996L,14392L,23536L,23536L,14392L,4996L,766L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142595Inst : IEnumerable<long>
{
public static readonly long[] Value=A142595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142595.Bytes);
public long this[int i]=>Value[i];

public static A142595Inst Instance=new A142595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142596
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,21L,21L,1L,1L,66L,126L,66L,1L,1L,201L,576L,576L,201L,1L,1L,606L,2331L,3456L,2331L,606L,1L,1L,1821L,8811L,17361L,17361L,8811L,1821L,1L,1L,5466L,31896L,78516L,104166L,78516L,31896L,5466L,1L,1L,16401L,112086L,331236L,548046L,548046L,331236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142596Inst : IEnumerable<long>
{
public static readonly long[] Value=A142596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142596.Bytes);
public long this[int i]=>Value[i];

public static A142596Inst Instance=new A142596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142597
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,36L,36L,1L,1L,148L,288L,148L,1L,1L,596L,1744L,1744L,596L,1L,1L,2388L,9360L,13952L,9360L,2388L,1L,1L,9556L,46992L,93248L,93248L,46992L,9556L,1L,1L,38228L,226192L,560960L,745984L,560960L,226192L,38228L,1L,1L,152916L,1057680L,3148608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142597Inst : IEnumerable<long>
{
public static readonly long[] Value=A142597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142597.Bytes);
public long this[int i]=>Value[i];

public static A142597Inst Instance=new A142597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142598
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,2L,1L,1L,0L,1L,1L,0L,2L,1L,0L,1L,0L,1L,1L,0L,2L,1L,1L,1L,1L,0L,1L,1L,0L,2L,1L,2L,2L,1L,1L,0L,1L,1L,0L,2L,1L,2L,2L,1L,0L,1L,0L,1L,1L,0L,2L,1L,2L,2L,2L,2L,1L,1L,0L,1L,1L,0L,2L,1L,2L,2L,2L,3L,2L,1L,1L,0L,1L,1L,0L,2L,1L,2L,2L,2L,3L,2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142598Inst : IEnumerable<long>
{
public static readonly long[] Value=A142598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142598.Bytes);
public long this[int i]=>Value[i];

public static A142598Inst Instance=new A142598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142599
{
public static readonly long[] Value={ 5L,2L,77L,35L,221L,20L,437L,143L,725L,56L,1085L,323L,1517L,110L,2021L,575L,2597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142599Inst : IEnumerable<long>
{
public static readonly long[] Value=A142599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142599.Bytes);
public long this[int i]=>Value[i];

public static A142599Inst Instance=new A142599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142632
{
public static readonly long[] Value={ 43L,263L,373L,593L,1033L,1583L,1693L,1913L,2243L,2683L,2903L,3343L,3673L,4003L,4663L,4993L,5323L,5653L,6203L,6863L,7193L,7523L,7853L,7963L,8293L,8513L,8623L,9173L,9283L,9613L,9833L,10163L,10273L,11483L,11593L,11813L,11923L,12143L,12253L,12473L,12583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142632Inst : IEnumerable<long>
{
public static readonly long[] Value=A142632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142632.Bytes);
public long this[int i]=>Value[i];

public static A142632Inst Instance=new A142632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142633
{
public static readonly long[] Value={ 101L,211L,431L,541L,761L,1091L,1201L,1531L,1861L,2081L,2411L,2521L,2741L,2851L,3181L,3511L,4391L,4721L,4831L,5051L,5381L,5711L,5821L,6151L,6481L,6701L,7691L,8461L,8681L,9011L,9341L,9781L,10111L,10331L,10771L,11321L,11981L,12421L,12641L,13411L,14071L,14401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142633Inst : IEnumerable<long>
{
public static readonly long[] Value=A142633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142633.Bytes);
public long this[int i]=>Value[i];

public static A142633Inst Instance=new A142633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142634
{
public static readonly long[] Value={ 47L,157L,487L,1367L,1697L,2027L,2137L,2357L,2467L,2687L,2797L,3347L,3457L,3677L,4007L,4337L,4447L,5107L,5437L,5657L,5987L,6317L,6427L,6977L,7307L,7417L,8297L,8627L,8737L,9067L,9397L,10607L,10937L,11047L,11597L,11927L,12037L,12697L,12917L,13577L,13687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142634Inst : IEnumerable<long>
{
public static readonly long[] Value=A142634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142634.Bytes);
public long this[int i]=>Value[i];

public static A142634Inst Instance=new A142634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142635
{
public static readonly long[] Value={ 103L,433L,653L,983L,1093L,1423L,1753L,1973L,2083L,2633L,2963L,3623L,3733L,4283L,4723L,4943L,5273L,6043L,6263L,6373L,6703L,7253L,7583L,8243L,8353L,8573L,9013L,9343L,10223L,10333L,10663L,10883L,10993L,11213L,12203L,12973L,13523L,13633L,13963L,14293L,14843L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142635Inst : IEnumerable<long>
{
public static readonly long[] Value=A142635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142635.Bytes);
public long this[int i]=>Value[i];

public static A142635Inst Instance=new A142635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142636
{
public static readonly long[] Value={ 269L,379L,599L,709L,929L,1039L,1259L,1699L,2029L,2579L,2689L,2909L,3019L,4229L,4339L,4889L,4999L,5659L,5879L,6869L,7309L,7529L,7639L,8629L,8849L,9619L,9839L,9949L,10169L,10499L,10939L,11159L,11489L,12149L,12479L,12589L,12809L,12919L,13249L,13469L,13799L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142636Inst : IEnumerable<long>
{
public static readonly long[] Value=A142636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142636.Bytes);
public long this[int i]=>Value[i];

public static A142636Inst Instance=new A142636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142637
{
public static readonly long[] Value={ 271L,491L,601L,821L,1151L,1481L,1811L,2141L,2251L,2801L,3461L,3571L,4231L,4451L,4561L,5441L,5881L,6101L,6211L,6761L,6871L,8081L,8191L,8521L,8741L,9181L,9511L,10061L,10391L,10501L,10831L,11161L,11491L,11821L,12041L,13691L,14461L,15121L,15451L,15671L,16001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142637Inst : IEnumerable<long>
{
public static readonly long[] Value=A142637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142637.Bytes);
public long this[int i]=>Value[i];

public static A142637Inst Instance=new A142637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142638
{
public static readonly long[] Value={ 107L,547L,877L,1097L,1427L,1867L,2087L,2417L,2857L,3187L,3407L,3517L,3847L,4177L,4397L,4507L,5167L,5387L,5717L,5827L,6047L,7477L,8467L,9127L,9677L,9787L,10007L,10337L,10667L,11437L,11657L,11987L,12097L,12647L,12757L,13417L,13967L,14407L,14627L,14737L,14957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142638Inst : IEnumerable<long>
{
public static readonly long[] Value=A142638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142638.Bytes);
public long this[int i]=>Value[i];

public static A142638Inst Instance=new A142638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142639
{
public static readonly long[] Value={ 53L,163L,383L,823L,1153L,1373L,1483L,2143L,2473L,2693L,2803L,3023L,3463L,3793L,4013L,4673L,4783L,5003L,5113L,5333L,5443L,6323L,6653L,6763L,6983L,7643L,7753L,8963L,9293L,9403L,9623L,9733L,10613L,10723L,11273L,11383L,11933L,12043L,12263L,12373L,12703L,12923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142639Inst : IEnumerable<long>
{
public static readonly long[] Value=A142639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142639.Bytes);
public long this[int i]=>Value[i];

public static A142639Inst Instance=new A142639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142640
{
public static readonly long[] Value={ 109L,439L,659L,769L,1319L,1429L,1759L,1979L,2089L,2309L,2749L,2969L,3079L,3299L,3739L,4289L,4729L,5059L,5279L,5939L,6269L,6379L,6599L,6709L,7039L,7369L,7589L,7699L,7919L,8689L,9239L,9349L,9679L,10009L,10559L,10889L,11329L,11549L,12539L,12979L,13309L,13859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142640Inst : IEnumerable<long>
{
public static readonly long[] Value=A142640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142640.Bytes);
public long this[int i]=>Value[i];

public static A142640Inst Instance=new A142640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142641
{
public static readonly long[] Value={ 113L,281L,337L,449L,617L,673L,953L,1009L,1289L,2017L,2129L,2297L,2521L,2633L,2689L,2801L,2857L,2969L,3137L,3361L,3529L,3697L,4201L,4481L,4649L,4817L,5153L,5209L,5657L,5881L,6217L,6329L,6553L,6833L,7001L,7057L,7393L,7561L,7673L,7841L,8009L,8233L,8513L,8681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142641Inst : IEnumerable<long>
{
public static readonly long[] Value=A142641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142641.Bytes);
public long this[int i]=>Value[i];

public static A142641Inst Instance=new A142641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142642
{
public static readonly long[] Value={ 3L,59L,227L,283L,563L,619L,787L,1123L,1291L,1459L,1571L,1627L,1907L,2131L,2243L,2411L,2467L,2579L,2803L,2971L,3083L,3251L,3307L,3643L,3923L,4091L,4259L,4483L,4651L,4931L,4987L,5099L,5323L,5659L,5827L,5939L,6163L,6779L,6947L,7283L,7451L,7507L,8011L,8123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142642Inst : IEnumerable<long>
{
public static readonly long[] Value=A142642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142642.Bytes);
public long this[int i]=>Value[i];

public static A142642Inst Instance=new A142642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142643
{
public static readonly long[] Value={ 5L,61L,173L,229L,397L,509L,677L,733L,1013L,1069L,1181L,1237L,1741L,2357L,2693L,2749L,2861L,2917L,3253L,3533L,3701L,4093L,4261L,4373L,4597L,4877L,4933L,5101L,5381L,5437L,5717L,6053L,6221L,6277L,6389L,6781L,6949L,7229L,7621L,7789L,7901L,8069L,8237L,8293L,8461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142643Inst : IEnumerable<long>
{
public static readonly long[] Value=A142643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142643.Bytes);
public long this[int i]=>Value[i];

public static A142643Inst Instance=new A142643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142644
{
public static readonly long[] Value={ 233L,401L,457L,569L,1129L,1297L,1409L,1801L,1913L,2081L,2137L,2417L,2473L,2753L,3089L,3257L,3313L,3593L,3761L,3929L,4153L,4657L,4937L,4993L,5273L,5441L,6113L,6337L,6449L,6673L,6841L,7121L,7177L,7457L,7681L,7793L,8017L,8297L,8353L,8521L,8689L,8969L,9137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142644Inst : IEnumerable<long>
{
public static readonly long[] Value=A142644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142644.Bytes);
public long this[int i]=>Value[i];

public static A142644Inst Instance=new A142644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142645
{
public static readonly long[] Value={ 11L,67L,179L,347L,571L,683L,739L,907L,1019L,1187L,1523L,1579L,1747L,2027L,2083L,2251L,2531L,2699L,3203L,3259L,3371L,3539L,3931L,4099L,4211L,4547L,4603L,5051L,5107L,5387L,5443L,5779L,6451L,6563L,6619L,6899L,7459L,7907L,7963L,8243L,8467L,8747L,8803L,8971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142645Inst : IEnumerable<long>
{
public static readonly long[] Value=A142645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142645.Bytes);
public long this[int i]=>Value[i];

public static A142645Inst Instance=new A142645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142646
{
public static readonly long[] Value={ 13L,181L,293L,349L,461L,797L,853L,1021L,1301L,1637L,1693L,1861L,1973L,2029L,2141L,2309L,2477L,3037L,3373L,3541L,3709L,3821L,3877L,3989L,4157L,4493L,4549L,5333L,5501L,5557L,5669L,6173L,6229L,6397L,6733L,7013L,7069L,7237L,7349L,7517L,7573L,7741L,7853L,8581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142646Inst : IEnumerable<long>
{
public static readonly long[] Value=A142646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142646.Bytes);
public long this[int i]=>Value[i];

public static A142646Inst Instance=new A142646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142647
{
public static readonly long[] Value={ 71L,127L,239L,463L,631L,743L,911L,967L,1303L,1471L,1583L,2087L,2143L,2311L,2423L,2591L,2647L,2927L,3319L,3767L,3823L,4159L,4271L,4327L,4663L,4831L,4943L,4999L,5167L,5279L,5503L,5783L,5839L,6007L,6287L,6343L,6679L,6791L,6959L,7127L,7351L,7687L,8191L,8527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142647Inst : IEnumerable<long>
{
public static readonly long[] Value=A142647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142647.Bytes);
public long this[int i]=>Value[i];

public static A142647Inst Instance=new A142647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142680
{
public static readonly long[] Value={ 139L,367L,709L,823L,937L,1051L,1279L,1621L,2647L,3217L,3331L,3559L,3673L,4129L,4243L,4357L,4813L,5839L,5953L,6067L,6637L,7207L,7321L,7549L,8233L,8461L,8689L,8803L,9601L,9829L,10399L,10513L,10627L,11083L,11197L,11311L,12109L,12451L,12907L,13249L,13477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142680Inst : IEnumerable<long>
{
public static readonly long[] Value=A142680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142680.Bytes);
public long this[int i]=>Value[i];

public static A142680Inst Instance=new A142680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142681
{
public static readonly long[] Value={ 83L,197L,311L,653L,881L,1109L,1223L,1451L,1907L,2477L,2591L,2819L,3389L,3617L,4073L,4643L,4871L,5099L,5441L,5669L,5783L,5897L,6011L,6353L,6581L,7151L,7607L,7949L,8291L,8747L,8861L,9203L,9431L,9887L,10343L,10457L,10799L,11027L,11369L,11483L,11597L,11939L,12281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142681Inst : IEnumerable<long>
{
public static readonly long[] Value=A142681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142681.Bytes);
public long this[int i]=>Value[i];

public static A142681Inst Instance=new A142681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142682
{
public static readonly long[] Value={ 199L,313L,541L,769L,883L,997L,1453L,1567L,2137L,2251L,2593L,2707L,3049L,3163L,3391L,3733L,3847L,4759L,4987L,5101L,5443L,5557L,6469L,7039L,7723L,7951L,8179L,8293L,8521L,8863L,9091L,9319L,9433L,9547L,9661L,10459L,10687L,11257L,11827L,11941L,12511L,12739L,12853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142682Inst : IEnumerable<long>
{
public static readonly long[] Value=A142682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142682.Bytes);
public long this[int i]=>Value[i];

public static A142682Inst Instance=new A142682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142683
{
public static readonly long[] Value={ 29L,257L,599L,827L,941L,1283L,1511L,2081L,2309L,2423L,2879L,3221L,3449L,3677L,4019L,4133L,4703L,4817L,4931L,5273L,5387L,5501L,5843L,6299L,6869L,6983L,7211L,8009L,8123L,8237L,8693L,8807L,9377L,9491L,9719L,9833L,10061L,10289L,10631L,10859L,10973L,11087L,11657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142683Inst : IEnumerable<long>
{
public static readonly long[] Value=A142683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142683.Bytes);
public long this[int i]=>Value[i];

public static A142683Inst Instance=new A142683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142684
{
public static readonly long[] Value={ 31L,373L,487L,601L,829L,1171L,1399L,1627L,1741L,2083L,2311L,2539L,2767L,3109L,3793L,3907L,4021L,4363L,4591L,4933L,5503L,6073L,6301L,6529L,6871L,7213L,7669L,8011L,8353L,8467L,8581L,8923L,9151L,9721L,9949L,10177L,10861L,11317L,11887L,12343L,12457L,12799L,13597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142684Inst : IEnumerable<long>
{
public static readonly long[] Value=A142684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142684.Bytes);
public long this[int i]=>Value[i];

public static A142684Inst Instance=new A142684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142685
{
public static readonly long[] Value={ 89L,317L,431L,659L,773L,887L,1229L,1571L,1913L,2027L,2141L,2711L,2939L,3167L,3623L,3851L,4079L,4421L,4649L,4877L,5333L,5903L,6131L,6359L,6473L,6701L,7043L,7499L,7727L,7841L,8069L,8297L,8753L,8867L,9209L,9323L,9437L,9551L,10007L,10463L,10691L,11261L,11489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142685Inst : IEnumerable<long>
{
public static readonly long[] Value=A142685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142685.Bytes);
public long this[int i]=>Value[i];

public static A142685Inst Instance=new A142685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142686
{
public static readonly long[] Value={ 433L,547L,661L,1117L,1231L,1459L,1801L,2029L,2143L,2371L,2713L,3169L,3511L,3739L,3853L,3967L,4423L,4651L,4993L,5107L,5449L,5563L,5791L,6133L,6247L,6361L,6703L,7159L,8527L,8641L,9439L,9781L,10009L,11149L,11491L,11719L,11833L,12289L,12517L,12973L,13999L,14341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142686Inst : IEnumerable<long>
{
public static readonly long[] Value=A142686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142686.Bytes);
public long this[int i]=>Value[i];

public static A142686Inst Instance=new A142686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142687
{
public static readonly long[] Value={ 149L,263L,491L,719L,947L,1061L,1289L,1973L,2087L,2543L,2657L,2999L,3797L,3911L,4139L,4253L,4481L,4937L,5051L,5279L,5393L,5507L,5849L,6761L,7103L,7331L,7559L,7673L,7901L,8243L,8699L,9041L,9497L,9839L,10067L,10181L,10979L,11093L,11321L,11549L,11777L,12119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142687Inst : IEnumerable<long>
{
public static readonly long[] Value=A142687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142687.Bytes);
public long this[int i]=>Value[i];

public static A142687Inst Instance=new A142687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142688
{
public static readonly long[] Value={ 37L,151L,379L,607L,1063L,1291L,1747L,1861L,2089L,2203L,2659L,2887L,3001L,3229L,3343L,3457L,3571L,4027L,4483L,4597L,5167L,5281L,5623L,5737L,5851L,6079L,6421L,6763L,6991L,7219L,7333L,7561L,7789L,8017L,8929L,9043L,9157L,9613L,10069L,10639L,10753L,10867L,11437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142688Inst : IEnumerable<long>
{
public static readonly long[] Value=A142688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142688.Bytes);
public long this[int i]=>Value[i];

public static A142688Inst Instance=new A142688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142689
{
public static readonly long[] Value={ 97L,211L,439L,1009L,1123L,1237L,1579L,1693L,2377L,2719L,2833L,3061L,3517L,3631L,4201L,4657L,4999L,5113L,5227L,5569L,5683L,6367L,6481L,6709L,6823L,7393L,7507L,7621L,7963L,8191L,8419L,8647L,8761L,9103L,9787L,9901L,10243L,10357L,11383L,11497L,11839L,11953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142689Inst : IEnumerable<long>
{
public static readonly long[] Value=A142689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142689.Bytes);
public long this[int i]=>Value[i];

public static A142689Inst Instance=new A142689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142690
{
public static readonly long[] Value={ 41L,269L,383L,839L,953L,1181L,1409L,1523L,1637L,1979L,2207L,2549L,2663L,2777L,3119L,3347L,3461L,3803L,3917L,4259L,4373L,4943L,5171L,5399L,5741L,6197L,6311L,6653L,7109L,7451L,7793L,7907L,8363L,8819L,8933L,9161L,10301L,10529L,11213L,11783L,11897L,12011L,12239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142690Inst : IEnumerable<long>
{
public static readonly long[] Value=A142690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142690.Bytes);
public long this[int i]=>Value[i];

public static A142690Inst Instance=new A142690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142691
{
public static readonly long[] Value={ 43L,157L,271L,499L,613L,727L,1069L,1297L,1753L,1867L,2437L,2551L,3121L,3463L,3691L,3919L,4261L,4603L,4831L,5059L,5743L,5857L,6199L,6427L,6883L,6997L,7681L,8707L,8821L,9049L,9277L,9391L,9619L,9733L,10303L,10531L,10987L,11329L,11443L,12241L,12583L,12697L,13267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142691Inst : IEnumerable<long>
{
public static readonly long[] Value=A142691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142691.Bytes);
public long this[int i]=>Value[i];

public static A142691Inst Instance=new A142691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142692
{
public static readonly long[] Value={ 101L,443L,557L,1013L,1583L,1697L,1811L,2039L,2153L,2267L,2381L,2609L,2837L,3407L,3863L,4091L,4547L,4889L,5003L,5231L,5573L,5801L,6029L,6143L,6257L,6599L,6827L,7283L,7853L,8081L,8423L,8537L,9221L,9677L,9791L,10133L,10247L,10589L,11159L,11273L,12071L,12413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142692Inst : IEnumerable<long>
{
public static readonly long[] Value=A142692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142692.Bytes);
public long this[int i]=>Value[i];

public static A142692Inst Instance=new A142692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142693
{
public static readonly long[] Value={ 103L,331L,673L,787L,1129L,1471L,1699L,2269L,2383L,2953L,3067L,3181L,3637L,4093L,4549L,4663L,5119L,5233L,5347L,5689L,6373L,6829L,7057L,7741L,8311L,8539L,9109L,9337L,9679L,9907L,10477L,11047L,11161L,11503L,11617L,11731L,11959L,12073L,12301L,12757L,13099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142693Inst : IEnumerable<long>
{
public static readonly long[] Value=A142693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142693.Bytes);
public long this[int i]=>Value[i];

public static A142693Inst Instance=new A142693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142694
{
public static readonly long[] Value={ 47L,389L,503L,617L,1187L,1301L,1871L,2099L,2213L,2441L,2897L,3011L,3467L,3581L,3923L,4493L,4721L,5519L,5861L,6089L,6203L,6317L,6659L,7001L,7229L,7457L,8369L,8597L,9281L,9623L,9851L,10079L,10193L,11447L,11789L,11903L,12473L,13043L,13499L,13613L,13841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142694Inst : IEnumerable<long>
{
public static readonly long[] Value=A142694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142694.Bytes);
public long this[int i]=>Value[i];

public static A142694Inst Instance=new A142694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142695
{
public static readonly long[] Value={ 163L,277L,619L,733L,1303L,1531L,1759L,1873L,1987L,2557L,2671L,3469L,3583L,3697L,4153L,4723L,4951L,5179L,5407L,5521L,5749L,6091L,6547L,6661L,7459L,7573L,7687L,8599L,8713L,8941L,9283L,9397L,9511L,9739L,9967L,10651L,10993L,11677L,12589L,12703L,13159L,13729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142695Inst : IEnumerable<long>
{
public static readonly long[] Value=A142695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142695.Bytes);
public long this[int i]=>Value[i];

public static A142695Inst Instance=new A142695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142712
{
public static readonly long[] Value={ 3L,3L,5L,5L,7L,17L,17L,29L,31L,43L,43L,53L,61L,61L,67L,83L,101L,103L,127L,127L,137L,163L,173L,179L,179L,193L,199L,257L,257L,269L,277L,283L,293L,311L,313L,347L,349L,367L,367L,373L,379L,389L,389L,401L,409L,431L,433L,433L,467L,503L,541L,541L,577L,599L,601L,601L,617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142712Inst : IEnumerable<long>
{
public static readonly long[] Value=A142712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142712.Bytes);
public long this[int i]=>Value[i];

public static A142712Inst Instance=new A142712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142713
{
public static readonly BigInteger[] Value={ 1L,2L,3L,5L,7L,11L,13L,-2L,38L,2728L,-443641L,1935029933L,-1006469613597229L,BigInteger.Parse("314740206896238505761377"),BigInteger.Parse("-4106778990409111362977439949403921647"),BigInteger.Parse("-99836159842345073697494052403203681150224535412233647440794") };
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
public class A142713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142713Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A142713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142713.Bytes);
public BigInteger this[int i]=>Value[i];

public static A142713Inst Instance=new A142713Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142714
{
public static readonly BigInteger[] Value={ 1L,2L,3L,-1L,-11L,-34L,-87L,-199L,-803L,30260L,-6666549L,4437571247L,89838030364819L,BigInteger.Parse("-618601670062754874640"),BigInteger.Parse("-2753159856116491857977786378841"),BigInteger.Parse("-247721126779198534020836382643398254287524379") };
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
public class A142714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142714Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A142714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142714.Bytes);
public BigInteger this[int i]=>Value[i];

public static A142714Inst Instance=new A142714Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142715
{
public static readonly long[] Value={ 31L,89L,263L,379L,727L,1249L,1307L,1423L,1481L,1597L,2003L,2293L,2351L,2467L,2699L,3163L,3221L,3511L,3917L,4091L,4729L,4787L,4903L,5077L,5309L,5483L,5657L,6121L,6353L,6469L,6701L,6991L,7687L,7919L,8093L,8209L,8731L,8963L,9137L,9311L,9601L,9833L,9949L,10007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142715Inst : IEnumerable<long>
{
public static readonly long[] Value=A142715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142715.Bytes);
public long this[int i]=>Value[i];

public static A142715Inst Instance=new A142715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142716
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,3L,3L,6L,6L,9L,9L,18L,18L,18L,45L,36L,45L,99L,81L,108L,216L,189L,243L,486L,432L,540L,1107L,972L,1215L,2511L,2187L,2754L,5670L,4941L,6237L,12798L,11178L,14094L,28917L,25272L,31833L,65367L,57105L,71928L,147744L,129033L,162567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142716Inst : IEnumerable<long>
{
public static readonly long[] Value=A142716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142716.Bytes);
public long this[int i]=>Value[i];

public static A142716Inst Instance=new A142716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142717
{
public static readonly long[] Value={ 3L,5L,15L,21L,35L,45L,63L,77L,99L,117L,143L,165L,195L,221L,255L,285L,323L,357L,399L,437L,483L,525L,575L,621L,675L,725L,783L,837L,899L,957L,1023L,1085L,1155L,1221L,1295L,1365L,1443L,1517L,1599L,1677L,1763L,1845L,1935L,2021L,2115L,2205L,2303L,2397L,2499L,2597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142717Inst : IEnumerable<long>
{
public static readonly long[] Value=A142717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142717.Bytes);
public long this[int i]=>Value[i];

public static A142717Inst Instance=new A142717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142718
{
public static readonly long[] Value={ 1L,1L,11L,17L,29L,199L,321L,521L,3571L,5777L,9349L,64079L,103681L,167761L,1149851L,1860497L,3010349L,20633239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142718Inst : IEnumerable<long>
{
public static readonly long[] Value=A142718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142718.Bytes);
public long this[int i]=>Value[i];

public static A142718Inst Instance=new A142718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142719
{
public static readonly long[] Value={ 41L,41L,43L,47L,53L,61L,71L,83L,97L,113L,131L,151L,173L,197L,223L,251L,281L,313L,347L,383L,421L,461L,503L,547L,593L,641L,691L,743L,797L,853L,911L,971L,1033L,1097L,1163L,1231L,1301L,1373L,1447L,1523L,1601L,41L,43L,47L,53L,61L,71L,83L,97L,113L,131L,151L,173L,197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142719Inst : IEnumerable<long>
{
public static readonly long[] Value=A142719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142719.Bytes);
public long this[int i]=>Value[i];

public static A142719Inst Instance=new A142719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142720
{
public static readonly long[] Value={ -1L,-1L,-1L,-1L,-1L,0L,-1L,-1L,-1L,0L,-1L,0L,-1L,-1L,-1L,0L,-1L,0L,-1L,0L,-1L,-1L,-1L,0L,-1L,0L,-1L,0L,-1L,0L,-1L,-1L,-1L,0L,-1L,0L,-1L,0L,-1L,0L,-1L,0L,-1L,-1L,-1L,0L,-1L,0L,-1L,0L,-1L,0L,-1L,0L,-1L,0L,-1L,-1L,-1L,0L,-1L,0L,-1L,0L,-1L,0L,-1L,0L,-1L,0L,-1L,0L,-1L,-1L,-1L,0L,-1L,0L,-1L,0L,-1L,0L,-1L,0L,-1L,0L,-1L,0L,-1L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142720Inst : IEnumerable<long>
{
public static readonly long[] Value=A142720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142720.Bytes);
public long this[int i]=>Value[i];

public static A142720Inst Instance=new A142720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142721
{
public static readonly long[] Value={ 0L,2L,1L,5L,2L,6L,3L,11L,4L,12L,5L,13L,6L,14L,7L,23L,8L,24L,9L,25L,10L,26L,11L,27L,12L,28L,13L,29L,14L,30L,15L,47L,16L,48L,17L,49L,18L,50L,19L,51L,20L,52L,21L,53L,22L,54L,23L,55L,24L,56L,25L,57L,26L,58L,27L,59L,28L,60L,29L,61L,30L,62L,31L,95L,32L,96L,33L,97L,34L,98L,35L,99L,36L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142721Inst : IEnumerable<long>
{
public static readonly long[] Value=A142721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142721.Bytes);
public long this[int i]=>Value[i];

public static A142721Inst Instance=new A142721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142722
{
public static readonly BigInteger[] Value={ 1L,1L,-2L,11L,-79L,722L,-8021L,104995L,-1582946L,27015077L,-514869409L,10839272666L,-249818140727L,6256292790841L,-169169723493434L,4912178274100427L,-152446696220606671L,5035653153554120570L,BigInteger.Parse("-176400307070614826621"),BigInteger.Parse("6531847014766302705547") };
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
public class A142722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142722Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A142722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142722.Bytes);
public BigInteger this[int i]=>Value[i];

public static A142722Inst Instance=new A142722Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142723
{
public static readonly long[] Value={ 4L,3L,0L,3L,2L,3L,9L,3L,0L,1L,9L,8L,3L,1L,2L,2L,5L,4L,7L,5L,0L,7L,2L,5L,6L,5L,3L,7L,1L,2L,9L,4L,6L,1L,0L,1L,1L,0L,0L,5L,8L,7L,4L,9L,8L,2L,5L,6L,1L,5L,9L,3L,3L,2L,7L,6L,9L,9L,6L,6L,3L,7L,1L,8L,1L,0L,8L,6L,7L,0L,5L,5L,2L,1L,6L,2L,6L,3L,9L,5L,7L,8L,9L,0L,1L,9L,6L,0L,0L,2L,4L,3L,7L,4L,8L,7L,1L,5L,5L,8L,7L,3L,6L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142723Inst : IEnumerable<long>
{
public static readonly long[] Value=A142723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142723.Bytes);
public long this[int i]=>Value[i];

public static A142723Inst Instance=new A142723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142724
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,2L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,2L,0L,2L,1L,2L,1L,1L,2L,1L,2L,0L,2L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142724Inst : IEnumerable<long>
{
public static readonly long[] Value=A142724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142724.Bytes);
public long this[int i]=>Value[i];

public static A142724Inst Instance=new A142724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142725
{
public static readonly BigInteger[] Value={ 5L,24L,1151L,6727710L,97954001297811L,BigInteger.Parse("12083213443785578998604325741"),BigInteger.Parse("2111557350230332542969297514824119073134312726162508784857"),BigInteger.Parse("5126406954746155312559668571658555244727150562238830979161154018392336359308299948544053564102183773577991816755308") };
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
public class A142725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142725Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A142725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142725.Bytes);
public BigInteger this[int i]=>Value[i];

public static A142725Inst Instance=new A142725Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142726
{
public static readonly BigInteger[] Value={ 5L,43L,2850L,9380555L,131539825706327L,BigInteger.Parse("25568462906010064277774504354"),BigInteger.Parse("1702783284378767791750994476557209698496292570221862357616"),BigInteger.Parse("9282809298390896944529722953873240985108041182275536393531898614770319137100914187360035180181565645720539192811580") };
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
public class A142726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142726Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A142726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142726.Bytes);
public BigInteger this[int i]=>Value[i];

public static A142726Inst Instance=new A142726Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142727
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,6L,8L,8L,9L,12L,12L,14L,15L,16L,16L,18L,20L,20L,22L,24L,24L,24L,25L,27L,30L,30L,30L,32L,32L,32L,36L,36L,39L,40L,42L,42L,44L,45L,46L,48L,48L,48L,50L,50L,52L,52L,55L,59L,60L,60L,60L,60L,60L,64L,64L,66L,66L,67L,69L,70L,71L,72L,75L,76L,76L,78L,80L,81L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142727Inst : IEnumerable<long>
{
public static readonly long[] Value=A142727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142727.Bytes);
public long this[int i]=>Value[i];

public static A142727Inst Instance=new A142727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142760
{
public static readonly long[] Value={ 151L,269L,859L,977L,1213L,1567L,2039L,2393L,3691L,4517L,4871L,5107L,6287L,7349L,7703L,8293L,8647L,9001L,9473L,10181L,10771L,10889L,11243L,11597L,11833L,12541L,12659L,13249L,13367L,13721L,14783L,15137L,15373L,15727L,16553L,17497L,17851L,18913L,19031L,19267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142760Inst : IEnumerable<long>
{
public static readonly long[] Value=A142760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142760.Bytes);
public long this[int i]=>Value[i];

public static A142760Inst Instance=new A142760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142761
{
public static readonly long[] Value={ 211L,683L,919L,1627L,2099L,2689L,4813L,4931L,5167L,5521L,5639L,6229L,6701L,8117L,8353L,8707L,9533L,9769L,9887L,10477L,10831L,10949L,11657L,12011L,12601L,13309L,13781L,14489L,14843L,15551L,15787L,16141L,17203L,17321L,17911L,18973L,19681L,20389L,20507L,20743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142761Inst : IEnumerable<long>
{
public static readonly long[] Value=A142761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142761.Bytes);
public long this[int i]=>Value[i];

public static A142761Inst Instance=new A142761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142762
{
public static readonly long[] Value={ 271L,389L,743L,1097L,1451L,2749L,3221L,3457L,3929L,4283L,4519L,4637L,5227L,5581L,6053L,6761L,6997L,7351L,7823L,8059L,9239L,9829L,10301L,10891L,11717L,11953L,12071L,13487L,13723L,13841L,14431L,14549L,15139L,15493L,16319L,16673L,17027L,17971L,18089L,18443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142762Inst : IEnumerable<long>
{
public static readonly long[] Value=A142762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142762.Bytes);
public long this[int i]=>Value[i];

public static A142762Inst Instance=new A142762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142763
{
public static readonly long[] Value={ 331L,449L,1039L,1511L,1747L,2927L,3163L,3517L,3989L,4933L,5051L,5641L,6113L,6703L,7057L,7411L,7529L,7883L,8237L,9181L,10007L,10243L,10597L,11069L,11423L,11777L,12721L,13901L,15199L,15671L,15907L,18149L,18503L,19211L,19447L,19801L,19919L,20509L,20627L,20981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142763Inst : IEnumerable<long>
{
public static readonly long[] Value=A142763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142763.Bytes);
public long this[int i]=>Value[i];

public static A142763Inst Instance=new A142763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142764
{
public static readonly long[] Value={ 37L,509L,863L,1217L,1453L,1571L,2161L,2633L,3931L,4049L,4639L,4993L,5347L,5701L,6173L,6763L,7589L,8179L,8297L,8887L,9241L,9949L,10067L,10303L,10657L,11483L,11719L,12073L,12781L,12899L,14197L,14551L,14669L,15259L,15377L,15731L,17029L,17383L,17737L,18917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142764Inst : IEnumerable<long>
{
public static readonly long[] Value=A142764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142764.Bytes);
public long this[int i]=>Value[i];

public static A142764Inst Instance=new A142764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142765
{
public static readonly long[] Value={ 97L,569L,1277L,1867L,2221L,2339L,2693L,3637L,4463L,4817L,5171L,5407L,5879L,6469L,6823L,7177L,7649L,9419L,10009L,11071L,11779L,11897L,12251L,12487L,12841L,12959L,13313L,13903L,15083L,15319L,15791L,16381L,17207L,17443L,18269L,18859L,19213L,20393L,20747L,20983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142765Inst : IEnumerable<long>
{
public static readonly long[] Value=A142765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142765.Bytes);
public long this[int i]=>Value[i];

public static A142765Inst Instance=new A142765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142766
{
public static readonly long[] Value={ 157L,983L,2281L,2399L,2753L,3343L,3461L,3697L,4051L,4523L,4759L,4877L,5113L,5231L,5821L,5939L,6529L,6883L,7001L,7237L,7591L,9007L,9479L,9833L,10069L,11131L,11839L,12547L,13963L,14081L,15497L,15733L,16087L,18211L,18329L,18919L,19037L,19273L,19391L,20807L,21397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142766Inst : IEnumerable<long>
{
public static readonly long[] Value=A142766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142766.Bytes);
public long this[int i]=>Value[i];

public static A142766Inst Instance=new A142766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142767
{
public static readonly long[] Value={ 571L,1279L,1987L,2341L,2459L,3049L,3167L,4111L,4229L,4583L,4937L,5527L,5881L,6353L,7297L,8123L,8713L,8831L,9067L,9421L,9539L,10247L,10601L,10837L,12253L,13669L,14731L,15439L,16619L,17209L,17327L,17681L,18743L,18979L,19333L,19687L,20749L,21221L,21929L,22283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142767Inst : IEnumerable<long>
{
public static readonly long[] Value=A142767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142767.Bytes);
public long this[int i]=>Value[i];

public static A142767Inst Instance=new A142767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142768
{
public static readonly long[] Value={ 41L,277L,631L,1103L,1693L,1811L,3109L,3463L,3581L,4289L,4643L,5233L,5351L,7121L,7829L,8419L,8537L,9127L,11251L,11369L,11959L,13729L,14083L,14437L,15263L,15971L,16561L,17033L,17387L,17623L,17977L,18803L,19157L,20101L,20219L,20809L,21163L,21517L,21871L,22343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142768Inst : IEnumerable<long>
{
public static readonly long[] Value=A142768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142768.Bytes);
public long this[int i]=>Value[i];

public static A142768Inst Instance=new A142768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142769
{
public static readonly long[] Value={ 101L,337L,691L,809L,1163L,1399L,1753L,1871L,2579L,3169L,3877L,4231L,4349L,4703L,5647L,6473L,6709L,6827L,7417L,8243L,8597L,8951L,9187L,10957L,11311L,11783L,12373L,12491L,13553L,13789L,13907L,14143L,14851L,14969L,15559L,15913L,16267L,17093L,17683L,19571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142769Inst : IEnumerable<long>
{
public static readonly long[] Value=A142769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142769.Bytes);
public long this[int i]=>Value[i];

public static A142769Inst Instance=new A142769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142770
{
public static readonly long[] Value={ 43L,397L,751L,1223L,1459L,1931L,2521L,3229L,3347L,3583L,3701L,4409L,4999L,5471L,7477L,7949L,8539L,8893L,9011L,9601L,9719L,10427L,10663L,10781L,11489L,12197L,12433L,13259L,13613L,13967L,14321L,14557L,15383L,15619L,15737L,15973L,16091L,17389L,18097L,18451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142770Inst : IEnumerable<long>
{
public static readonly long[] Value=A142770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142770.Bytes);
public long this[int i]=>Value[i];

public static A142770Inst Instance=new A142770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142771
{
public static readonly long[] Value={ 103L,457L,811L,929L,1283L,1637L,1873L,2699L,3407L,3643L,3761L,5059L,5413L,5531L,6121L,6829L,6947L,7537L,8009L,8363L,8599L,9661L,10133L,10369L,10487L,10723L,11549L,11903L,12611L,15443L,15679L,15797L,16033L,16741L,17449L,17921L,19219L,19927L,20399L,20753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142771Inst : IEnumerable<long>
{
public static readonly long[] Value=A142771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142771.Bytes);
public long this[int i]=>Value[i];

public static A142771Inst Instance=new A142771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142772
{
public static readonly long[] Value={ 163L,281L,1579L,1697L,1933L,2287L,3467L,3821L,4057L,5119L,5237L,5591L,5827L,6299L,6653L,7243L,7951L,8069L,8423L,9013L,9721L,9839L,10193L,10429L,11491L,12553L,12671L,12907L,14087L,14323L,15031L,15149L,15739L,16447L,17509L,17627L,17863L,17981L,18217L,19751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142772Inst : IEnumerable<long>
{
public static readonly long[] Value=A142772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142772.Bytes);
public long this[int i]=>Value[i];

public static A142772Inst Instance=new A142772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142773
{
public static readonly long[] Value={ 223L,577L,1049L,1993L,2111L,2347L,2819L,3527L,3881L,4943L,5179L,5297L,5651L,6359L,6949L,8011L,8719L,8837L,9781L,10253L,10607L,11197L,11551L,12377L,12613L,12967L,14029L,14737L,15091L,16979L,17333L,17569L,17923L,18041L,18749L,19457L,20047L,20873L,21227L,21817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142773Inst : IEnumerable<long>
{
public static readonly long[] Value=A142773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142773.Bytes);
public long this[int i]=>Value[i];

public static A142773Inst Instance=new A142773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142774
{
public static readonly long[] Value={ 47L,283L,401L,991L,1109L,1699L,2053L,2879L,3469L,3823L,4177L,4649L,5003L,5711L,6301L,7127L,7481L,7717L,8543L,8779L,9133L,10313L,10667L,10903L,11257L,12437L,12791L,13381L,13499L,14207L,14561L,14797L,15269L,15859L,16567L,16921L,17393L,17747L,18691L,19163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142774Inst : IEnumerable<long>
{
public static readonly long[] Value=A142774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142774.Bytes);
public long this[int i]=>Value[i];

public static A142774Inst Instance=new A142774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142775
{
public static readonly long[] Value={ 107L,461L,1051L,1523L,1759L,1877L,2113L,2467L,2939L,3529L,4001L,4591L,5417L,5653L,6007L,6361L,6833L,7069L,7187L,7541L,8839L,9311L,9547L,9901L,11317L,11789L,12143L,12379L,12497L,13441L,13913L,14149L,14503L,14621L,15329L,15683L,15919L,16273L,16981L,17099L,17807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142775Inst : IEnumerable<long>
{
public static readonly long[] Value=A142775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142775.Bytes);
public long this[int i]=>Value[i];

public static A142775Inst Instance=new A142775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142824
{
public static readonly long[] Value={ 331L,941L,1063L,1307L,1429L,2039L,2161L,3137L,3259L,4357L,4723L,4967L,5333L,5821L,6553L,7529L,8017L,8627L,10091L,10457L,11311L,11677L,12043L,12409L,12653L,13751L,13873L,15581L,16069L,17167L,18143L,19973L,21193L,21559L,21803L,22291L,22901L,23633L,24121L,25097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142824Inst : IEnumerable<long>
{
public static readonly long[] Value=A142824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142824.Bytes);
public long this[int i]=>Value[i];

public static A142824Inst Instance=new A142824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142825
{
public static readonly long[] Value={ 149L,271L,881L,1613L,1979L,2467L,2711L,2833L,3931L,4297L,4663L,5273L,5639L,6737L,7103L,7591L,8689L,8933L,9421L,9787L,11251L,11617L,12227L,12959L,13691L,14057L,14423L,15277L,15643L,15887L,16253L,16619L,16741L,17107L,17351L,17839L,19181L,19913L,21011L,21377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142825Inst : IEnumerable<long>
{
public static readonly long[] Value=A142825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142825.Bytes);
public long this[int i]=>Value[i];

public static A142825Inst Instance=new A142825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142826
{
public static readonly long[] Value={ 89L,211L,577L,821L,1187L,1553L,4481L,4603L,4969L,5701L,6067L,6311L,7043L,8263L,8629L,9239L,10093L,10337L,10459L,11069L,11801L,11923L,12289L,12899L,13997L,14851L,15217L,15461L,15583L,16193L,17047L,17291L,17657L,19121L,19609L,19853L,20219L,20341L,20707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142826Inst : IEnumerable<long>
{
public static readonly long[] Value=A142826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142826.Bytes);
public long this[int i]=>Value[i];

public static A142826Inst Instance=new A142826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142827
{
public static readonly long[] Value={ 29L,151L,761L,883L,1249L,1493L,2347L,2591L,2713L,2957L,3079L,3323L,4177L,4421L,4787L,4909L,5153L,5519L,5641L,6007L,6373L,6983L,7349L,8081L,8447L,10399L,11131L,11497L,11863L,12107L,12473L,13327L,13693L,14303L,14669L,15401L,15767L,15889L,16987L,17231L,17597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142827Inst : IEnumerable<long>
{
public static readonly long[] Value=A142827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142827.Bytes);
public long this[int i]=>Value[i];

public static A142827Inst Instance=new A142827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142828
{
public static readonly long[] Value={ 457L,701L,823L,1433L,2287L,2531L,2897L,3019L,4483L,5581L,6679L,7411L,8387L,8753L,9241L,9851L,9973L,10949L,11071L,11437L,11681L,12413L,13267L,13633L,13877L,13999L,14243L,14731L,16073L,16561L,16927L,17293L,17659L,17903L,18269L,18757L,19001L,19489L,21319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142828Inst : IEnumerable<long>
{
public static readonly long[] Value=A142828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142828.Bytes);
public long this[int i]=>Value[i];

public static A142828Inst Instance=new A142828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142829
{
public static readonly long[] Value={ 31L,397L,641L,1129L,1373L,1861L,2593L,2837L,3203L,3691L,4057L,4423L,4789L,5399L,5521L,6131L,6619L,6863L,7229L,7351L,7717L,8693L,9059L,9181L,9547L,9791L,10889L,11621L,11743L,11987L,12109L,12841L,13451L,14549L,15647L,17477L,17599L,19429L,20161L,20771L,21503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142829Inst : IEnumerable<long>
{
public static readonly long[] Value=A142829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142829.Bytes);
public long this[int i]=>Value[i];

public static A142829Inst Instance=new A142829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142830
{
public static readonly long[] Value={ 337L,947L,1069L,1801L,2411L,2777L,3631L,4241L,4363L,4729L,4973L,5827L,6803L,7901L,8389L,8999L,10463L,11317L,11927L,12049L,12659L,12781L,13147L,13513L,13757L,13879L,14489L,16319L,17417L,17539L,17783L,18149L,18637L,19979L,20101L,22541L,22907L,23029L,23761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142830Inst : IEnumerable<long>
{
public static readonly long[] Value=A142830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142830.Bytes);
public long this[int i]=>Value[i];

public static A142830Inst Instance=new A142830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142831
{
public static readonly long[] Value={ 277L,521L,643L,887L,1009L,1619L,1741L,2351L,2473L,3083L,3449L,3571L,4547L,5279L,6011L,6133L,7109L,7841L,7963L,8329L,8573L,10037L,10159L,10891L,11257L,11867L,12721L,13331L,13697L,14551L,15161L,15527L,15649L,16381L,16747L,18089L,18211L,19309L,19553L,19919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142831Inst : IEnumerable<long>
{
public static readonly long[] Value=A142831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142831.Bytes);
public long this[int i]=>Value[i];

public static A142831Inst Instance=new A142831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142832
{
public static readonly long[] Value={ 461L,827L,1193L,1559L,2657L,3023L,3389L,3511L,3877L,4243L,6073L,6317L,7537L,8147L,8269L,8513L,9001L,9733L,10099L,10343L,10709L,10831L,11197L,11807L,12539L,13759L,14369L,15101L,15467L,16931L,17053L,17419L,18517L,19249L,20347L,21323L,22543L,22787L,24007L,24251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142832Inst : IEnumerable<long>
{
public static readonly long[] Value=A142832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142832.Bytes);
public long this[int i]=>Value[i];

public static A142832Inst Instance=new A142832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142833
{
public static readonly long[] Value={ 157L,401L,523L,1499L,1621L,1987L,2719L,2963L,3329L,4549L,4793L,5281L,5647L,6257L,6379L,7477L,8087L,8209L,8819L,8941L,9551L,10039L,10771L,11503L,12113L,12479L,12601L,12967L,13577L,14431L,14797L,15773L,16139L,16871L,16993L,17359L,18457L,18701L,19433L,20287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142833Inst : IEnumerable<long>
{
public static readonly long[] Value=A142833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142833.Bytes);
public long this[int i]=>Value[i];

public static A142833Inst Instance=new A142833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142834
{
public static readonly long[] Value={ 97L,463L,829L,1439L,2293L,2659L,2903L,3391L,4001L,4733L,5099L,5953L,6197L,6563L,7417L,9491L,9613L,9857L,10223L,10589L,10711L,11321L,11443L,12541L,12907L,13151L,13883L,14249L,14737L,16567L,16811L,17299L,17909L,18397L,19373L,19739L,19861L,20593L,20959L,21569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142834Inst : IEnumerable<long>
{
public static readonly long[] Value=A142834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142834.Bytes);
public long this[int i]=>Value[i];

public static A142834Inst Instance=new A142834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142835
{
public static readonly long[] Value={ 37L,281L,647L,769L,1013L,1867L,2111L,2477L,2843L,3209L,3331L,3697L,4673L,5039L,5527L,6869L,6991L,7723L,8089L,8699L,8821L,9187L,9431L,10163L,10529L,10651L,11261L,11383L,13457L,15287L,16141L,17117L,17239L,17483L,17971L,18947L,19069L,19801L,20411L,20533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142835Inst : IEnumerable<long>
{
public static readonly long[] Value=A142835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142835.Bytes);
public long this[int i]=>Value[i];

public static A142835Inst Instance=new A142835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142836
{
public static readonly long[] Value={ 587L,709L,953L,1319L,2417L,2539L,3271L,3637L,3881L,4003L,5101L,5711L,6199L,7297L,7541L,7907L,8273L,8761L,9127L,9371L,9859L,10103L,10957L,11689L,11933L,12421L,13397L,13763L,14251L,14983L,15227L,15349L,15959L,16447L,16691L,17789L,17911L,18521L,19009L,20107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142836Inst : IEnumerable<long>
{
public static readonly long[] Value=A142836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142836.Bytes);
public long this[int i]=>Value[i];

public static A142836Inst Instance=new A142836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142837
{
public static readonly long[] Value={ 283L,1259L,1381L,1747L,2113L,2357L,3089L,3821L,3943L,4919L,5407L,5651L,6871L,7237L,7481L,7603L,9067L,9311L,9433L,9677L,10531L,12239L,13093L,13337L,14557L,14923L,15289L,16631L,17729L,17851L,18217L,18461L,18583L,19559L,19681L,20047L,21023L,22853L,24317L,24439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142837Inst : IEnumerable<long>
{
public static readonly long[] Value=A142837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142837.Bytes);
public long this[int i]=>Value[i];

public static A142837Inst Instance=new A142837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142838
{
public static readonly long[] Value={ 101L,223L,467L,1321L,1931L,2053L,2297L,2663L,3517L,3761L,4127L,4493L,5347L,5591L,6079L,6323L,6689L,7177L,8641L,9007L,9739L,10837L,11447L,11813L,12301L,12911L,13033L,13399L,14009L,14741L,15107L,15473L,16693L,16937L,17669L,17791L,18401L,18523L,20231L,20353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142838Inst : IEnumerable<long>
{
public static readonly long[] Value=A142838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142838.Bytes);
public long this[int i]=>Value[i];

public static A142838Inst Instance=new A142838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142839
{
public static readonly long[] Value={ 41L,163L,773L,1627L,1871L,1993L,2237L,2969L,3457L,3701L,3823L,4799L,5531L,5653L,5897L,6263L,7727L,8093L,8581L,9679L,9923L,10289L,12119L,12241L,12973L,13217L,13339L,14071L,14437L,15413L,15901L,16267L,16633L,17609L,18097L,18341L,19073L,19927L,20903L,21269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142839Inst : IEnumerable<long>
{
public static readonly long[] Value=A142839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142839.Bytes);
public long this[int i]=>Value[i];

public static A142839Inst Instance=new A142839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142888
{
public static readonly long[] Value={ 3L,-1L,13L,-9L,29L,-23L,51L,-43L,79L,-69L,113L,-101L,153L,-139L,199L,-183L,251L,-233L,309L,-289L,373L,-351L,443L,-419L,519L,-493L,601L,-573L,689L,-659L,783L,-751L,883L,-849L,989L,-953L,1101L,-1063L,1219L,-1179L,1343L,-1301L,1473L,-1429L,1609L,-1563L,1751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142888Inst : IEnumerable<long>
{
public static readonly long[] Value=A142888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142888.Bytes);
public long this[int i]=>Value[i];

public static A142888Inst Instance=new A142888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142889
{
public static readonly long[] Value={ 127L,379L,631L,757L,883L,1009L,2017L,2143L,2269L,2521L,2647L,3529L,3907L,4159L,4663L,4789L,5167L,5419L,5923L,6301L,6427L,6553L,6679L,7057L,7309L,7561L,7687L,8191L,8317L,8443L,8821L,9199L,9829L,10333L,10459L,10711L,10837L,11467L,11593L,11719L,11971L,12097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142889Inst : IEnumerable<long>
{
public static readonly long[] Value=A142889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142889.Bytes);
public long this[int i]=>Value[i];

public static A142889Inst Instance=new A142889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142890
{
public static readonly long[] Value={ 2L,191L,317L,443L,569L,821L,947L,1451L,2081L,2207L,2333L,2459L,2711L,2837L,2963L,3089L,3467L,3593L,3719L,4349L,5231L,5483L,5861L,5987L,6113L,6491L,6869L,7121L,7247L,7499L,7877L,9011L,9137L,9767L,10271L,11027L,11279L,11657L,11783L,11909L,12161L,12413L,12539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142890Inst : IEnumerable<long>
{
public static readonly long[] Value=A142890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142890.Bytes);
public long this[int i]=>Value[i];

public static A142890Inst Instance=new A142890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142891
{
public static readonly long[] Value={ 67L,193L,571L,823L,1201L,1327L,1453L,1579L,1831L,2083L,2713L,3217L,3343L,3469L,3847L,4099L,4603L,4729L,5107L,5233L,5737L,6367L,6619L,6871L,6997L,7753L,7879L,8761L,8887L,9013L,9391L,9643L,9769L,10273L,10399L,10651L,10903L,12037L,12163L,12289L,12541L,12919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142891Inst : IEnumerable<long>
{
public static readonly long[] Value=A142891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142891.Bytes);
public long this[int i]=>Value[i];

public static A142891Inst Instance=new A142891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142892
{
public static readonly long[] Value={ 5L,131L,257L,383L,509L,761L,887L,1013L,2273L,2399L,2777L,2903L,3407L,3533L,3659L,3911L,4289L,4793L,4919L,5171L,5297L,5801L,5927L,6053L,7187L,7691L,7817L,8069L,8447L,8573L,8699L,8951L,9203L,9833L,10211L,10337L,10463L,10589L,11093L,11471L,11597L,12101L,12227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142892Inst : IEnumerable<long>
{
public static readonly long[] Value=A142892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142892.Bytes);
public long this[int i]=>Value[i];

public static A142892Inst Instance=new A142892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142893
{
public static readonly long[] Value={ 71L,197L,449L,701L,827L,953L,1583L,1709L,2087L,2213L,2339L,2591L,2843L,2969L,3221L,3347L,3851L,4229L,4481L,4733L,5237L,5741L,5867L,7001L,7127L,7253L,7757L,7883L,8009L,8387L,8513L,9521L,10151L,10529L,10781L,11159L,11411L,11789L,12041L,12671L,12923L,13049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142893Inst : IEnumerable<long>
{
public static readonly long[] Value=A142893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142893.Bytes);
public long this[int i]=>Value[i];

public static A142893Inst Instance=new A142893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142894
{
public static readonly long[] Value={ 73L,199L,577L,829L,1459L,2089L,2341L,2467L,2593L,2719L,2971L,3727L,3853L,4231L,4357L,4483L,4861L,4987L,5113L,5743L,5869L,6121L,6247L,6373L,7129L,7507L,7759L,8011L,8263L,8389L,8641L,8893L,9397L,9649L,9901L,10531L,10657L,10909L,11161L,11287L,12043L,12421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142894Inst : IEnumerable<long>
{
public static readonly long[] Value=A142894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142894.Bytes);
public long this[int i]=>Value[i];

public static A142894Inst Instance=new A142894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142895
{
public static readonly long[] Value={ 11L,137L,263L,389L,641L,1019L,1523L,1901L,2027L,2153L,2531L,2657L,2909L,3413L,3539L,3917L,4421L,4547L,4673L,4799L,5051L,5303L,5807L,6311L,6563L,6689L,7193L,7823L,7949L,8831L,9209L,9461L,9587L,9839L,10091L,10343L,10847L,10973L,11351L,11981L,12107L,12611L,13241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142895Inst : IEnumerable<long>
{
public static readonly long[] Value=A142895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142895.Bytes);
public long this[int i]=>Value[i];

public static A142895Inst Instance=new A142895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142896
{
public static readonly long[] Value={ 13L,139L,643L,769L,1021L,1399L,1777L,2029L,2281L,2659L,3037L,3163L,3541L,3793L,3919L,4297L,4423L,4549L,4801L,5179L,5431L,5557L,5683L,6691L,7069L,7321L,7573L,7699L,7951L,8329L,8581L,8707L,9337L,9463L,9967L,10093L,10597L,10723L,11353L,11731L,12109L,12487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142896Inst : IEnumerable<long>
{
public static readonly long[] Value=A142896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142896.Bytes);
public long this[int i]=>Value[i];

public static A142896Inst Instance=new A142896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142897
{
public static readonly long[] Value={ 79L,331L,457L,709L,1087L,1213L,2221L,2347L,2473L,2851L,3229L,3607L,3733L,4111L,4363L,4993L,5119L,5623L,5749L,6379L,6883L,7639L,8017L,8269L,8521L,8647L,9151L,9277L,9403L,9781L,9907L,10159L,10663L,10789L,11923L,12049L,12301L,12553L,13183L,13309L,13687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142897Inst : IEnumerable<long>
{
public static readonly long[] Value=A142897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142897.Bytes);
public long this[int i]=>Value[i];

public static A142897Inst Instance=new A142897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142898
{
public static readonly long[] Value={ 17L,269L,521L,647L,773L,1151L,1277L,1907L,2411L,2663L,2789L,3041L,3167L,3671L,3797L,3923L,4049L,4679L,4931L,5309L,5813L,5939L,6317L,6569L,6947L,7451L,7577L,7703L,7829L,8081L,8837L,8963L,9341L,9467L,9719L,10223L,10601L,10853L,10979L,11483L,11987L,12113L,12239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142898Inst : IEnumerable<long>
{
public static readonly long[] Value=A142898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142898.Bytes);
public long this[int i]=>Value[i];

public static A142898Inst Instance=new A142898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142899
{
public static readonly long[] Value={ 19L,271L,397L,523L,1153L,1279L,1531L,1657L,1783L,2161L,2287L,2539L,2791L,2917L,3169L,3547L,3673L,4051L,4177L,4933L,5059L,5437L,5563L,5689L,6067L,6571L,6823L,6949L,8209L,8461L,8713L,8839L,9091L,9343L,9721L,9973L,10099L,10477L,10729L,11863L,12241L,12619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142899Inst : IEnumerable<long>
{
public static readonly long[] Value=A142899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142899.Bytes);
public long this[int i]=>Value[i];

public static A142899Inst Instance=new A142899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142900
{
public static readonly long[] Value={ 83L,461L,587L,839L,1091L,1217L,1721L,1847L,1973L,2099L,2351L,2477L,2729L,3359L,3863L,3989L,4241L,4493L,4871L,5501L,5879L,6131L,6257L,6761L,7013L,7517L,7643L,8147L,8273L,9029L,9281L,9533L,10037L,10163L,10289L,10667L,11171L,11423L,11549L,11801L,11927L,12809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142900Inst : IEnumerable<long>
{
public static readonly long[] Value=A142900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142900.Bytes);
public long this[int i]=>Value[i];

public static A142900Inst Instance=new A142900Inst();

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