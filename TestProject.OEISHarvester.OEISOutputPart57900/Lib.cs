using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A065445
{
public static readonly long[] Value={ 1L,6L,4L,6L,7L,6L,0L,2L,5L,8L,1L,2L,1L,0L,6L,5L,6L,4L,8L,3L,6L,6L,0L,5L,1L,2L,2L,2L,2L,8L,2L,2L,9L,8L,4L,3L,5L,6L,5L,2L,3L,7L,6L,7L,2L,5L,7L,0L,1L,0L,2L,7L,4L,0L,9L,0L,1L,2L,4L,0L,5L,3L,1L,7L,5L,5L,1L,7L,2L,8L,1L,6L,2L,4L,3L,9L,1L,4L,1L,3L,7L,2L,1L,6L,1L,8L,8L,6L,9L,3L,9L,9L,9L,0L,7L,6L,5L,6L,4L,3L,5L,6L,6L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065445Inst : IEnumerable<long>
{
public static readonly long[] Value=A065445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065445.Bytes);
public long this[int i]=>Value[i];

public static A065445Inst Instance=new A065445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065446
{
public static readonly long[] Value={ 3L,4L,6L,2L,7L,4L,6L,6L,1L,9L,4L,5L,5L,0L,6L,3L,6L,1L,1L,5L,3L,7L,9L,5L,7L,3L,4L,2L,9L,2L,4L,4L,3L,1L,1L,6L,4L,5L,4L,0L,7L,5L,7L,9L,0L,2L,9L,0L,4L,4L,3L,8L,3L,9L,1L,3L,2L,9L,3L,5L,3L,0L,3L,1L,7L,5L,8L,9L,1L,5L,4L,3L,9L,7L,4L,0L,4L,2L,0L,6L,4L,5L,6L,8L,7L,9L,2L,7L,7L,4L,0L,2L,9L,4L,8L,4L,3L,3L,5L,3L,5L,0L,8L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065446Inst : IEnumerable<long>
{
public static readonly long[] Value=A065446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065446.Bytes);
public long this[int i]=>Value[i];

public static A065446Inst Instance=new A065446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065447
{
public static readonly BigInteger[] Value={ 1L,100L,100111L,1001110000L,100111000011111L,BigInteger.Parse("100111000011111000000"),BigInteger.Parse("1001110000111110000001111111"),BigInteger.Parse("100111000011111000000111111100000000"),BigInteger.Parse("100111000011111000000111111100000000111111111"),BigInteger.Parse("1001110000111110000001111111000000001111111110000000000") };
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
public class A065447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065447Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A065447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065447.Bytes);
public BigInteger this[int i]=>Value[i];

public static A065447Inst Instance=new A065447Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065448
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,14L,19L,20L,29L,30L,31L,33L,36L,39L,40L,49L,50L,52L,55L,59L,60L,63L,64L,69L,70L,71L,77L,79L,80L,89L,90L,99L,100L,102L,108L,110L,113L,118L,119L,120L,132L,140L,150L,166L,168L,180L,190L,195L,198L,200L,201L,204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065448Inst : IEnumerable<long>
{
public static readonly long[] Value=A065448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065448.Bytes);
public long this[int i]=>Value[i];

public static A065448Inst Instance=new A065448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065449
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,4L,4L,12L,12L,16L,40L,88L,48L,232L,336L,240L,552L,1596L,1152L,4032L,3200L,5040L,17424L,28656L,12672L,60000L,120640L,89856L,188160L,514228L,288000L,1343296L,1217712L,1742400L,5697720L,6814080L,4396032L,23656320L,37691136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065449Inst : IEnumerable<long>
{
public static readonly long[] Value=A065449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065449.Bytes);
public long this[int i]=>Value[i];

public static A065449Inst Instance=new A065449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065450
{
public static readonly long[] Value={ 1L,2L,10L,22L,37L,54L,76L,100L,129L,160L,196L,234L,277L,322L,372L,424L,481L,540L,604L,670L,741L,814L,892L,972L,1057L,1144L,1236L,1330L,1429L,1530L,1636L,1744L,1857L,1972L,2092L,2214L,2341L,2470L,2604L,2740L,2881L,3024L,3172L,3322L,3477L,3634L,3796L,3960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065450Inst : IEnumerable<long>
{
public static readonly long[] Value=A065450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065450.Bytes);
public long this[int i]=>Value[i];

public static A065450Inst Instance=new A065450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065451
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,3L,1L,8L,3L,8L,3L,55L,3L,144L,8L,21L,21L,987L,8L,2584L,21L,144L,55L,17711L,21L,6765L,144L,2584L,144L,317811L,21L,832040L,987L,6765L,987L,46368L,144L,14930352L,2584L,46368L,987L,102334155L,144L,267914296L,6765L,46368L,17711L,1836311903L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065451Inst : IEnumerable<long>
{
public static readonly long[] Value=A065451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065451.Bytes);
public long this[int i]=>Value[i];

public static A065451Inst Instance=new A065451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065452
{
public static readonly long[] Value={ 2L,5L,0L,1L,0L,8L,5L,7L,5L,8L,0L,1L,4L,5L,6L,8L,8L,7L,6L,3L,2L,1L,3L,7L,9L,0L,9L,9L,2L,5L,6L,2L,8L,2L,1L,8L,1L,8L,6L,5L,9L,5L,4L,9L,6L,7L,2L,5L,5L,7L,9L,9L,6L,6L,7L,2L,4L,9L,6L,5L,4L,2L,0L,0L,6L,7L,4L,5L,0L,9L,2L,0L,9L,8L,4L,4L,1L,6L,4L,4L,2L,7L,7L,8L,4L,0L,2L,3L,8L,2L,2L,4L,5L,5L,8L,0L,6L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065452Inst : IEnumerable<long>
{
public static readonly long[] Value=A065452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065452.Bytes);
public long this[int i]=>Value[i];

public static A065452Inst Instance=new A065452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065453
{
public static readonly long[] Value={ 3L,0L,4L,2L,4L,8L,7L,6L,1L,2L,5L,8L,5L,9L,5L,1L,3L,2L,1L,0L,3L,1L,1L,8L,9L,7L,5L,3L,0L,5L,8L,4L,0L,9L,1L,3L,2L,0L,1L,8L,1L,5L,6L,0L,0L,2L,3L,7L,1L,5L,4L,4L,0L,1L,8L,0L,9L,6L,2L,1L,4L,6L,0L,3L,6L,9L,9L,3L,3L,2L,9L,3L,8L,9L,3L,3L,3L,2L,7L,7L,9L,2L,0L,2L,9L,0L,5L,8L,4L,2L,9L,3L,9L,0L,2L,0L,8L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065453Inst : IEnumerable<long>
{
public static readonly long[] Value=A065453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065453.Bytes);
public long this[int i]=>Value[i];

public static A065453Inst Instance=new A065453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065454
{
public static readonly long[] Value={ 9L,11L,13L,14L,21L,25L,27L,29L,33L,34L,35L,37L,38L,39L,44L,45L,47L,49L,50L,51L,54L,55L,56L,57L,59L,61L,64L,67L,69L,73L,74L,75L,77L,79L,81L,83L,84L,85L,86L,89L,90L,91L,92L,93L,94L,95L,97L,98L,101L,103L,105L,107L,110L,111L,113L,114L,115L,116L,117L,118L,121L,122L,123L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065454Inst : IEnumerable<long>
{
public static readonly long[] Value=A065454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065454.Bytes);
public long this[int i]=>Value[i];

public static A065454Inst Instance=new A065454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065455
{
public static readonly long[] Value={ 1L,2L,4L,7L,14L,25L,49L,89L,172L,316L,605L,1120L,2131L,3965L,7513L,14026L,26504L,49591L,93538L,175277L,330205L,619369L,1165892L,2188312L,4117045L,7730828L,14539447L,27309529L,51349169L,96468034L,181357036L,340753271L,640539142L,1203616849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065455Inst : IEnumerable<long>
{
public static readonly long[] Value=A065455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065455.Bytes);
public long this[int i]=>Value[i];

public static A065455Inst Instance=new A065455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065456
{
public static readonly BigInteger[] Value={ 0L,1L,9L,95L,1220L,18694L,334369L,6852460L,158479488L,4085349936L,116193701393L,3615197586912L,122165572502324L,4456126288810624L,174520484866919385L,7304657490838627072L,BigInteger.Parse("325420940777809245152"),BigInteger.Parse("15374940186972235659264"),BigInteger.Parse("767898500931828204443769") };
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
public class A065456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065456Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A065456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065456.Bytes);
public BigInteger this[int i]=>Value[i];

public static A065456Inst Instance=new A065456Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065457
{
public static readonly long[] Value={ 2L,2L,4L,6L,6L,10L,12L,4L,8L,18L,6L,22L,20L,18L,28L,10L,10L,12L,36L,12L,20L,14L,12L,46L,42L,8L,52L,20L,18L,58L,60L,6L,12L,66L,22L,70L,18L,20L,30L,78L,54L,82L,8L,28L,22L,12L,10L,36L,48L,30L,100L,102L,12L,106L,36L,36L,28L,44L,12L,24L,110L,20L,100L,14L,14L,130L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065457Inst : IEnumerable<long>
{
public static readonly long[] Value=A065457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065457.Bytes);
public long this[int i]=>Value[i];

public static A065457Inst Instance=new A065457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065458
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,4L,4L,2L,6L,7L,6L,4L,8L,10L,14L,2L,11L,14L,13L,7L,23L,15L,17L,4L,24L,21L,31L,10L,25L,37L,28L,2L,46L,29L,49L,14L,38L,35L,61L,7L,45L,62L,49L,15L,93L,47L,57L,4L,72L,67L,97L,21L,71L,84L,101L,10L,119L,70L,86L,37L,92L,79L,165L,2L,138L,127L,109L,29L,168L,140L,121L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065458Inst : IEnumerable<long>
{
public static readonly long[] Value=A065458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065458.Bytes);
public long this[int i]=>Value[i];

public static A065458Inst Instance=new A065458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065459
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,5L,6L,7L,8L,13L,12L,13L,17L,25L,22L,27L,31L,35L,38L,46L,49L,61L,61L,61L,73L,92L,83L,112L,106L,118L,127L,147L,138L,185L,175L,178L,198L,239L,212L,254L,262L,298L,294L,341L,304L,404L,376L,385L,432L,483L,441L,539L,517L,560L,551L,680L,587L,745L,693L,698L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065459Inst : IEnumerable<long>
{
public static readonly long[] Value=A065459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065459.Bytes);
public long this[int i]=>Value[i];

public static A065459Inst Instance=new A065459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065460
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,5L,9L,9L,9L,18L,23L,24L,29L,37L,53L,62L,59L,77L,116L,106L,130L,156L,199L,192L,221L,257L,342L,336L,384L,402L,577L,501L,599L,639L,835L,774L,910L,912L,1220L,1113L,1378L,1298L,1703L,1530L,1907L,1862L,2398L,2094L,2471L,2393L,3356L,2765L,3543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065460Inst : IEnumerable<long>
{
public static readonly long[] Value=A065460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065460.Bytes);
public long this[int i]=>Value[i];

public static A065460Inst Instance=new A065460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065461
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,7L,10L,13L,16L,27L,36L,43L,58L,72L,99L,130L,146L,178L,254L,265L,342L,417L,507L,540L,726L,745L,975L,1092L,1289L,1338L,1845L,1751L,2246L,2447L,2948L,2852L,3932L,3638L,4728L,4868L,5778L,5618L,7659L,6887L,8891L,8887L,10825L,10109L,13712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065461Inst : IEnumerable<long>
{
public static readonly long[] Value=A065461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065461.Bytes);
public long this[int i]=>Value[i];

public static A065461Inst Instance=new A065461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065462
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,11L,18L,25L,36L,51L,73L,90L,133L,169L,223L,295L,380L,452L,603L,763L,903L,1115L,1385L,1668L,2025L,2398L,2811L,3535L,4011L,4683L,5503L,6724L,7316L,8684L,9946L,11844L,12994L,15091L,16712L,20493L,21663L,24975L,27536L,33079L,34654L,39957L,43315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065462Inst : IEnumerable<long>
{
public static readonly long[] Value=A065462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065462.Bytes);
public long this[int i]=>Value[i];

public static A065462Inst Instance=new A065462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065463
{
public static readonly long[] Value={ 7L,0L,4L,4L,4L,2L,2L,0L,0L,9L,9L,9L,1L,6L,5L,5L,9L,2L,7L,3L,6L,6L,0L,3L,3L,5L,0L,3L,2L,6L,6L,3L,7L,2L,1L,0L,1L,8L,8L,5L,8L,6L,4L,3L,1L,4L,1L,7L,0L,9L,8L,0L,4L,9L,4L,1L,4L,2L,2L,6L,8L,4L,2L,5L,9L,1L,0L,9L,7L,0L,5L,6L,6L,8L,2L,0L,0L,6L,7L,7L,8L,5L,3L,6L,8L,0L,8L,2L,4L,4L,1L,4L,5L,6L,9L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065463Inst : IEnumerable<long>
{
public static readonly long[] Value=A065463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065463.Bytes);
public long this[int i]=>Value[i];

public static A065463Inst Instance=new A065463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065464
{
public static readonly long[] Value={ 4L,2L,8L,2L,4L,9L,5L,0L,5L,6L,7L,7L,0L,9L,4L,4L,4L,0L,2L,1L,8L,7L,6L,5L,7L,0L,7L,5L,8L,1L,8L,2L,3L,5L,4L,6L,1L,2L,1L,2L,9L,8L,5L,1L,3L,3L,5L,5L,9L,3L,6L,1L,4L,4L,0L,3L,1L,9L,0L,1L,3L,7L,9L,5L,3L,2L,1L,2L,3L,0L,5L,2L,1L,6L,1L,0L,8L,3L,0L,4L,4L,1L,0L,5L,3L,4L,8L,5L,1L,4L,5L,2L,4L,6L,8L,0L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065464Inst : IEnumerable<long>
{
public static readonly long[] Value=A065464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065464.Bytes);
public long this[int i]=>Value[i];

public static A065464Inst Instance=new A065464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065465
{
public static readonly long[] Value={ 8L,8L,1L,5L,1L,3L,8L,3L,9L,7L,2L,5L,1L,7L,0L,7L,7L,6L,9L,2L,8L,3L,9L,1L,8L,2L,2L,9L,0L,3L,2L,2L,7L,8L,4L,7L,1L,2L,9L,8L,6L,9L,2L,5L,7L,2L,0L,8L,0L,7L,6L,7L,3L,3L,6L,7L,0L,1L,6L,8L,5L,3L,5L,5L,4L,8L,6L,5L,7L,9L,0L,6L,3L,7L,9L,4L,1L,6L,9L,7L,4L,1L,0L,2L,2L,0L,4L,5L,5L,1L,7L,9L,7L,0L,2L,0L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065465Inst : IEnumerable<long>
{
public static readonly long[] Value=A065465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065465.Bytes);
public long this[int i]=>Value[i];

public static A065465Inst Instance=new A065465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065466
{
public static readonly long[] Value={ 9L,4L,7L,7L,3L,3L,2L,6L,2L,1L,4L,3L,6L,7L,5L,3L,7L,5L,9L,3L,9L,5L,2L,1L,5L,3L,7L,6L,5L,4L,1L,8L,9L,6L,1L,3L,0L,3L,3L,6L,3L,1L,6L,3L,2L,3L,1L,7L,4L,1L,3L,8L,5L,2L,8L,2L,8L,7L,5L,1L,0L,8L,8L,9L,0L,9L,3L,2L,3L,3L,2L,9L,4L,7L,8L,9L,8L,9L,9L,8L,7L,1L,3L,9L,5L,3L,4L,4L,1L,2L,8L,2L,6L,1L,3L,4L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065466Inst : IEnumerable<long>
{
public static readonly long[] Value=A065466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065466.Bytes);
public long this[int i]=>Value[i];

public static A065466Inst Instance=new A065466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065467
{
public static readonly long[] Value={ 9L,7L,5L,8L,2L,4L,1L,5L,3L,0L,4L,7L,6L,6L,8L,2L,4L,1L,6L,7L,9L,0L,1L,1L,4L,3L,6L,5L,9L,4L,7L,9L,9L,8L,3L,1L,9L,7L,1L,7L,6L,4L,9L,7L,1L,2L,2L,9L,2L,1L,2L,6L,0L,9L,4L,4L,2L,5L,1L,5L,7L,7L,3L,2L,4L,4L,2L,0L,6L,2L,6L,7L,0L,6L,8L,5L,8L,3L,6L,0L,8L,3L,6L,6L,5L,4L,6L,1L,8L,5L,6L,3L,6L,8L,5L,7L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065467Inst : IEnumerable<long>
{
public static readonly long[] Value=A065467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065467.Bytes);
public long this[int i]=>Value[i];

public static A065467Inst Instance=new A065467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065468
{
public static readonly long[] Value={ 9L,8L,8L,5L,0L,4L,3L,9L,7L,7L,4L,1L,2L,4L,6L,9L,0L,8L,7L,5L,1L,1L,0L,6L,6L,2L,3L,8L,5L,1L,1L,8L,6L,6L,6L,4L,4L,0L,0L,9L,5L,8L,0L,8L,3L,2L,7L,5L,3L,4L,6L,1L,8L,8L,1L,2L,0L,5L,1L,3L,9L,2L,6L,2L,4L,4L,0L,5L,7L,8L,4L,7L,5L,7L,3L,0L,8L,5L,7L,9L,3L,5L,1L,8L,8L,8L,0L,0L,7L,5L,3L,6L,7L,7L,2L,5L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065468Inst : IEnumerable<long>
{
public static readonly long[] Value=A065468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065468.Bytes);
public long this[int i]=>Value[i];

public static A065468Inst Instance=new A065468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065469
{
public static readonly long[] Value={ 5L,3L,0L,7L,1L,1L,8L,2L,0L,4L,7L,2L,0L,4L,4L,7L,9L,4L,9L,7L,2L,9L,4L,3L,7L,7L,2L,4L,7L,2L,9L,7L,7L,1L,7L,0L,9L,4L,7L,8L,6L,1L,0L,2L,2L,2L,0L,9L,8L,6L,0L,4L,0L,3L,4L,7L,5L,8L,1L,9L,0L,4L,9L,2L,8L,0L,9L,0L,5L,0L,6L,7L,9L,2L,6L,0L,9L,5L,7L,9L,0L,6L,3L,8L,6L,3L,8L,1L,9L,2L,4L,5L,6L,3L,6L,2L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065469Inst : IEnumerable<long>
{
public static readonly long[] Value=A065469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065469.Bytes);
public long this[int i]=>Value[i];

public static A065469Inst Instance=new A065469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065470
{
public static readonly long[] Value={ 7L,8L,8L,1L,6L,2L,5L,0L,0L,0L,3L,0L,2L,2L,0L,7L,0L,0L,5L,7L,6L,9L,4L,9L,5L,9L,3L,0L,5L,3L,5L,0L,3L,9L,6L,8L,9L,5L,6L,1L,6L,3L,6L,8L,4L,6L,9L,3L,5L,6L,9L,3L,0L,3L,3L,5L,2L,5L,1L,4L,2L,9L,2L,1L,2L,7L,5L,4L,1L,3L,2L,9L,4L,1L,9L,7L,8L,5L,4L,6L,4L,0L,4L,2L,4L,8L,6L,5L,4L,4L,0L,6L,9L,8L,8L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065470Inst : IEnumerable<long>
{
public static readonly long[] Value=A065470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065470.Bytes);
public long this[int i]=>Value[i];

public static A065470Inst Instance=new A065470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065471
{
public static readonly long[] Value={ 9L,0L,1L,9L,2L,6L,0L,3L,9L,5L,8L,7L,0L,8L,2L,1L,7L,1L,3L,7L,7L,7L,1L,5L,2L,0L,2L,5L,5L,0L,4L,7L,1L,9L,3L,4L,1L,5L,2L,5L,5L,5L,4L,5L,3L,1L,5L,5L,5L,5L,5L,3L,5L,8L,3L,5L,8L,4L,3L,3L,3L,2L,7L,2L,8L,9L,2L,9L,3L,7L,8L,1L,0L,7L,2L,5L,6L,8L,1L,5L,7L,5L,2L,3L,8L,9L,0L,4L,9L,9L,9L,0L,1L,0L,3L,3L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065471Inst : IEnumerable<long>
{
public static readonly long[] Value=A065471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065471.Bytes);
public long this[int i]=>Value[i];

public static A065471Inst Instance=new A065471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065472
{
public static readonly long[] Value={ 7L,7L,5L,8L,8L,3L,5L,1L,0L,0L,0L,3L,8L,9L,5L,4L,9L,9L,6L,2L,0L,4L,0L,4L,2L,8L,4L,4L,2L,7L,9L,0L,0L,6L,1L,1L,4L,8L,2L,4L,1L,3L,4L,6L,5L,9L,7L,3L,0L,1L,6L,2L,7L,6L,2L,2L,1L,0L,6L,3L,1L,1L,6L,4L,6L,1L,3L,8L,7L,6L,4L,9L,2L,4L,9L,7L,4L,5L,6L,9L,9L,5L,3L,7L,1L,9L,3L,1L,3L,2L,3L,3L,1L,2L,8L,1L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065472Inst : IEnumerable<long>
{
public static readonly long[] Value=A065472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065472.Bytes);
public long this[int i]=>Value[i];

public static A065472Inst Instance=new A065472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065473
{
public static readonly long[] Value={ 2L,8L,6L,7L,4L,7L,4L,2L,8L,4L,3L,4L,4L,7L,8L,7L,3L,4L,1L,0L,7L,8L,9L,2L,7L,1L,2L,7L,8L,9L,8L,3L,8L,4L,4L,6L,4L,3L,4L,3L,3L,1L,8L,4L,4L,0L,9L,7L,0L,5L,6L,9L,9L,5L,6L,4L,1L,4L,7L,7L,8L,5L,9L,3L,3L,6L,6L,5L,2L,2L,4L,3L,1L,3L,1L,9L,4L,3L,2L,5L,8L,2L,4L,8L,9L,1L,2L,6L,8L,2L,5L,5L,3L,7L,4L,2L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065473Inst : IEnumerable<long>
{
public static readonly long[] Value=A065473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065473.Bytes);
public long this[int i]=>Value[i];

public static A065473Inst Instance=new A065473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065474
{
public static readonly long[] Value={ 3L,2L,2L,6L,3L,4L,0L,9L,8L,9L,3L,9L,2L,4L,4L,6L,7L,0L,5L,7L,9L,5L,3L,1L,6L,9L,2L,5L,4L,8L,2L,3L,7L,0L,6L,6L,5L,7L,0L,9L,5L,0L,5L,7L,9L,6L,6L,5L,8L,3L,2L,7L,0L,9L,9L,6L,1L,8L,1L,1L,2L,5L,2L,4L,5L,3L,2L,5L,0L,0L,6L,3L,4L,8L,6L,2L,4L,4L,6L,0L,9L,8L,8L,4L,5L,2L,3L,4L,8L,1L,5L,6L,8L,5L,6L,3L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065474Inst : IEnumerable<long>
{
public static readonly long[] Value=A065474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065474.Bytes);
public long this[int i]=>Value[i];

public static A065474Inst Instance=new A065474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065475
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065475Inst : IEnumerable<long>
{
public static readonly long[] Value=A065475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065475.Bytes);
public long this[int i]=>Value[i];

public static A065475Inst Instance=new A065475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065476
{
public static readonly long[] Value={ 7L,2L,3L,6L,4L,8L,4L,0L,2L,2L,9L,8L,2L,0L,0L,0L,0L,9L,4L,0L,8L,8L,4L,9L,1L,4L,9L,8L,0L,9L,1L,2L,7L,5L,9L,9L,0L,4L,1L,7L,8L,3L,7L,5L,1L,5L,7L,3L,0L,7L,7L,0L,2L,9L,1L,7L,6L,1L,1L,9L,8L,8L,9L,7L,9L,1L,2L,5L,8L,8L,3L,5L,2L,5L,1L,4L,3L,1L,5L,2L,6L,2L,6L,9L,2L,8L,5L,2L,1L,4L,9L,7L,7L,3L,1L,3L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065476Inst : IEnumerable<long>
{
public static readonly long[] Value=A065476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065476.Bytes);
public long this[int i]=>Value[i];

public static A065476Inst Instance=new A065476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065477
{
public static readonly long[] Value={ 7L,4L,3L,9L,7L,1L,1L,9L,3L,3L,5L,0L,3L,7L,4L,7L,4L,4L,6L,8L,6L,5L,5L,9L,6L,0L,7L,5L,8L,5L,6L,5L,0L,0L,0L,0L,9L,8L,6L,0L,0L,8L,6L,9L,2L,8L,6L,1L,3L,2L,7L,8L,7L,3L,3L,1L,9L,5L,1L,2L,3L,8L,9L,1L,7L,2L,2L,4L,6L,7L,4L,3L,0L,5L,6L,9L,7L,9L,5L,3L,4L,0L,6L,2L,5L,2L,3L,6L,2L,1L,8L,1L,8L,7L,1L,7L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065477Inst : IEnumerable<long>
{
public static readonly long[] Value=A065477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065477.Bytes);
public long this[int i]=>Value[i];

public static A065477Inst Instance=new A065477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065478
{
public static readonly long[] Value={ 5L,7L,5L,9L,5L,9L,9L,6L,8L,8L,9L,2L,9L,4L,5L,4L,3L,9L,6L,4L,3L,1L,6L,3L,3L,7L,5L,4L,9L,2L,4L,9L,6L,6L,9L,2L,5L,0L,6L,5L,1L,3L,9L,6L,7L,1L,7L,6L,4L,9L,2L,3L,6L,3L,6L,0L,0L,6L,4L,0L,7L,9L,8L,6L,6L,5L,3L,7L,2L,5L,5L,1L,6L,9L,8L,8L,6L,8L,5L,2L,8L,4L,3L,6L,4L,0L,9L,8L,7L,2L,0L,9L,1L,7L,2L,6L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065478Inst : IEnumerable<long>
{
public static readonly long[] Value=A065478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065478.Bytes);
public long this[int i]=>Value[i];

public static A065478Inst Instance=new A065478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065479
{
public static readonly long[] Value={ 7L,1L,5L,4L,6L,8L,2L,3L,5L,9L,8L,9L,9L,5L,5L,8L,4L,5L,0L,9L,4L,7L,7L,4L,7L,0L,5L,7L,1L,1L,7L,2L,8L,0L,7L,7L,6L,7L,5L,9L,7L,6L,2L,4L,8L,9L,8L,3L,7L,6L,7L,7L,6L,7L,4L,2L,6L,7L,2L,4L,7L,6L,9L,4L,4L,2L,4L,9L,5L,3L,5L,5L,5L,5L,1L,9L,7L,5L,5L,8L,5L,6L,8L,3L,3L,1L,5L,5L,5L,4L,0L,9L,0L,9L,0L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065479Inst : IEnumerable<long>
{
public static readonly long[] Value=A065479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065479.Bytes);
public long this[int i]=>Value[i];

public static A065479Inst Instance=new A065479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065480
{
public static readonly long[] Value={ 6L,6L,9L,5L,8L,0L,2L,9L,0L,5L,3L,9L,0L,6L,2L,3L,6L,7L,6L,3L,5L,0L,2L,5L,6L,9L,5L,6L,1L,2L,4L,3L,4L,2L,2L,7L,2L,1L,7L,3L,3L,9L,8L,2L,5L,4L,1L,6L,2L,3L,3L,0L,2L,5L,6L,2L,4L,6L,5L,4L,6L,2L,6L,3L,3L,0L,9L,8L,3L,6L,6L,1L,9L,9L,5L,4L,7L,2L,4L,5L,7L,1L,4L,5L,7L,5L,6L,6L,2L,6L,0L,3L,8L,6L,9L,6L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065480Inst : IEnumerable<long>
{
public static readonly long[] Value=A065480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065480.Bytes);
public long this[int i]=>Value[i];

public static A065480Inst Instance=new A065480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065481
{
public static readonly long[] Value={ 3L,8L,8L,9L,4L,5L,1L,8L,9L,9L,7L,9L,5L,6L,1L,9L,2L,9L,3L,1L,1L,5L,7L,8L,7L,8L,9L,7L,6L,4L,4L,5L,0L,9L,1L,2L,6L,7L,6L,5L,4L,4L,9L,5L,4L,2L,7L,5L,6L,9L,5L,8L,6L,4L,7L,4L,1L,4L,3L,2L,0L,9L,8L,3L,7L,0L,0L,3L,9L,1L,2L,3L,3L,1L,9L,1L,7L,9L,0L,3L,2L,8L,0L,9L,7L,9L,7L,2L,7L,7L,5L,9L,6L,0L,8L,6L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065481Inst : IEnumerable<long>
{
public static readonly long[] Value=A065481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065481.Bytes);
public long this[int i]=>Value[i];

public static A065481Inst Instance=new A065481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065482
{
public static readonly long[] Value={ 2L,2L,3L,4L,6L,11L,18L,32L,57L,102L,186L,341L,630L,1170L,2185L,4096L,7710L,14564L,27594L,52429L,99864L,190650L,364722L,699051L,1342177L,2581110L,4971027L,9586981L,18512790L,35791394L,69273666L,134217728L,260301048L,505290270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065482Inst : IEnumerable<long>
{
public static readonly long[] Value=A065482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065482.Bytes);
public long this[int i]=>Value[i];

public static A065482Inst Instance=new A065482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065483
{
public static readonly long[] Value={ 1L,3L,3L,9L,7L,8L,4L,1L,5L,3L,5L,7L,4L,3L,4L,7L,2L,4L,6L,5L,9L,9L,1L,5L,2L,5L,8L,6L,5L,1L,4L,8L,8L,6L,0L,5L,2L,7L,7L,5L,2L,4L,2L,2L,4L,9L,7L,8L,8L,1L,8L,2L,8L,0L,6L,6L,6L,3L,0L,1L,5L,0L,6L,7L,6L,4L,6L,7L,9L,4L,8L,2L,7L,2L,7L,6L,0L,0L,9L,8L,2L,3L,7L,3L,7L,3L,4L,3L,6L,6L,4L,4L,0L,8L,5L,0L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065483Inst : IEnumerable<long>
{
public static readonly long[] Value=A065483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065483.Bytes);
public long this[int i]=>Value[i];

public static A065483Inst Instance=new A065483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065484
{
public static readonly long[] Value={ 2L,2L,0L,3L,8L,5L,6L,5L,9L,6L,4L,3L,7L,8L,5L,9L,7L,8L,7L,8L,7L,2L,8L,2L,8L,3L,1L,6L,4L,8L,0L,0L,8L,9L,6L,6L,2L,5L,6L,7L,1L,7L,3L,1L,9L,3L,7L,8L,7L,8L,5L,8L,6L,3L,4L,1L,7L,0L,4L,9L,5L,5L,4L,4L,8L,7L,1L,6L,6L,8L,8L,6L,8L,1L,1L,8L,5L,2L,6L,9L,5L,4L,9L,7L,5L,7L,2L,6L,6L,0L,4L,1L,9L,0L,1L,3L,9L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065484Inst : IEnumerable<long>
{
public static readonly long[] Value=A065484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065484.Bytes);
public long this[int i]=>Value[i];

public static A065484Inst Instance=new A065484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065485
{
public static readonly long[] Value={ 2L,8L,2L,6L,4L,1L,9L,9L,9L,7L,0L,6L,7L,5L,9L,1L,5L,7L,5L,5L,4L,6L,3L,9L,1L,7L,4L,7L,2L,3L,6L,9L,5L,3L,7L,4L,9L,0L,1L,3L,0L,4L,1L,1L,0L,5L,4L,5L,9L,2L,6L,6L,8L,7L,6L,1L,7L,9L,7L,4L,5L,8L,3L,4L,5L,3L,0L,7L,5L,7L,6L,2L,4L,4L,5L,9L,7L,6L,2L,4L,0L,5L,5L,3L,3L,4L,5L,8L,6L,6L,4L,9L,8L,8L,1L,8L,4L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065485Inst : IEnumerable<long>
{
public static readonly long[] Value=A065485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065485.Bytes);
public long this[int i]=>Value[i];

public static A065485Inst Instance=new A065485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065486
{
public static readonly long[] Value={ 1L,2L,6L,6L,5L,5L,8L,5L,0L,1L,4L,7L,1L,5L,2L,8L,5L,7L,1L,6L,1L,4L,5L,4L,7L,1L,1L,2L,6L,2L,9L,6L,4L,0L,8L,4L,5L,3L,9L,5L,5L,6L,0L,2L,3L,5L,4L,5L,7L,3L,4L,4L,8L,2L,1L,1L,2L,1L,9L,6L,7L,3L,2L,9L,5L,4L,8L,3L,9L,6L,1L,0L,6L,0L,7L,5L,1L,6L,4L,0L,8L,6L,8L,8L,8L,1L,7L,2L,0L,9L,0L,4L,2L,3L,6L,8L,2L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065486Inst : IEnumerable<long>
{
public static readonly long[] Value=A065486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065486.Bytes);
public long this[int i]=>Value[i];

public static A065486Inst Instance=new A065486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065487
{
public static readonly long[] Value={ 1L,2L,3L,1L,2L,9L,1L,1L,4L,8L,8L,8L,8L,6L,0L,3L,5L,6L,2L,7L,7L,4L,7L,8L,7L,6L,5L,1L,2L,7L,2L,0L,3L,3L,7L,0L,9L,8L,6L,3L,6L,9L,4L,5L,9L,4L,5L,6L,1L,7L,1L,5L,3L,4L,1L,2L,4L,8L,3L,1L,1L,2L,8L,7L,5L,6L,9L,2L,6L,9L,6L,0L,7L,9L,7L,4L,1L,0L,8L,6L,7L,8L,0L,7L,2L,2L,1L,1L,4L,0L,4L,9L,3L,3L,5L,2L,7L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065487Inst : IEnumerable<long>
{
public static readonly long[] Value=A065487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065487.Bytes);
public long this[int i]=>Value[i];

public static A065487Inst Instance=new A065487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065488
{
public static readonly long[] Value={ 2L,6L,7L,4L,1L,1L,2L,7L,2L,5L,5L,7L,0L,0L,2L,1L,5L,0L,8L,9L,6L,0L,4L,1L,1L,8L,3L,0L,4L,4L,5L,4L,8L,8L,0L,3L,7L,5L,0L,2L,3L,9L,8L,6L,2L,8L,3L,9L,7L,6L,9L,1L,9L,8L,5L,2L,0L,0L,8L,1L,9L,0L,4L,1L,9L,6L,0L,8L,6L,5L,9L,5L,6L,1L,0L,5L,3L,0L,2L,8L,6L,8L,6L,4L,4L,8L,5L,0L,9L,2L,9L,7L,1L,7L,3L,4L,8L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065488Inst : IEnumerable<long>
{
public static readonly long[] Value=A065488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065488.Bytes);
public long this[int i]=>Value[i];

public static A065488Inst Instance=new A065488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065489
{
public static readonly long[] Value={ 1L,4L,1L,9L,5L,6L,2L,8L,8L,0L,5L,0L,5L,4L,8L,5L,9L,1L,9L,3L,1L,7L,2L,3L,5L,8L,6L,1L,7L,8L,9L,7L,3L,5L,3L,5L,9L,1L,6L,6L,0L,7L,1L,5L,8L,6L,3L,0L,5L,1L,2L,2L,5L,4L,2L,6L,9L,8L,9L,8L,3L,6L,9L,5L,5L,6L,4L,3L,3L,0L,9L,7L,1L,3L,3L,9L,4L,7L,1L,6L,0L,8L,6L,3L,9L,9L,4L,0L,3L,6L,9L,4L,8L,0L,2L,7L,9L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065489Inst : IEnumerable<long>
{
public static readonly long[] Value=A065489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065489.Bytes);
public long this[int i]=>Value[i];

public static A065489Inst Instance=new A065489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065490
{
public static readonly long[] Value={ 0L,1L,-1L,1L,-2L,3L,-4L,5L,-8L,13L,-18L,25L,-40L,62L,-90L,135L,-210L,324L,-492L,750L,-1164L,1809L,-2786L,4305L,-6710L,10460L,-16264L,25350L,-39650L,62057L,-97108L,152145L,-238818L,375165L,-589520L,927200L,-1459960L,2300346L,-3626200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065490Inst : IEnumerable<long>
{
public static readonly long[] Value=A065490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065490.Bytes);
public long this[int i]=>Value[i];

public static A065490Inst Instance=new A065490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065491
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,7L,14L,25L,48L,88L,168L,310L,590L,1103L,2092L,3945L,7500L,14216L,27102L,51627L,98694L,188766L,361936L,694565L,1335466L,2570375L,4954744L,9561045L,18473140L,35728300L,69176558L,134063535L,260062168L,504911460L,981117286L,1907939760L,3713106350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065491Inst : IEnumerable<long>
{
public static readonly long[] Value=A065491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065491.Bytes);
public long this[int i]=>Value[i];

public static A065491Inst Instance=new A065491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065492
{
public static readonly long[] Value={ 0L,1L,-1L,2L,-4L,8L,-14L,25L,-48L,92L,-168L,310L,-590L,1117L,-2092L,3945L,-7500L,14264L,-27102L,51627L,-98694L,188934L,-361936L,694565L,-1335466L,2570965L,-4954744L,9561045L,-18473140L,35730392L,-69176558L,134063535L,-260062168L,504918960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065492Inst : IEnumerable<long>
{
public static readonly long[] Value=A065492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065492.Bytes);
public long this[int i]=>Value[i];

public static A065492Inst Instance=new A065492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065493
{
public static readonly long[] Value={ 6L,6L,1L,3L,1L,7L,0L,4L,9L,4L,6L,9L,6L,2L,2L,3L,3L,5L,2L,8L,9L,7L,6L,5L,8L,4L,6L,2L,7L,4L,1L,1L,8L,5L,3L,3L,2L,8L,5L,4L,7L,5L,2L,8L,9L,8L,3L,2L,9L,1L,6L,3L,5L,4L,9L,8L,0L,9L,0L,5L,6L,2L,6L,2L,2L,6L,6L,2L,5L,0L,3L,1L,7L,4L,3L,1L,2L,2L,3L,0L,4L,9L,4L,2L,2L,6L,1L,7L,4L,0L,7L,8L,4L,2L,8L,1L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065493Inst : IEnumerable<long>
{
public static readonly long[] Value=A065493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065493.Bytes);
public long this[int i]=>Value[i];

public static A065493Inst Instance=new A065493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065494
{
public static readonly long[] Value={ 1L,2L,4L,8L,15L,30L,57L,112L,216L,420L,815L,1580L,3069L,5950L,11552L,22408L,43487L,84378L,163725L,317700L,616444L,1196172L,2321007L,4503704L,8738921L,16956954L,32903164L,63845000L,123884479L,240384374L,466440273L,905077080L,1756205088L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065494Inst : IEnumerable<long>
{
public static readonly long[] Value=A065494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065494.Bytes);
public long this[int i]=>Value[i];

public static A065494Inst Instance=new A065494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065495
{
public static readonly long[] Value={ 1L,2L,6L,14L,32L,72L,156L,336L,712L,1496L,3120L,6464L,13328L,27360L,55968L,114144L,232192L,471296L,954816L,1931264L,3900800L,7869312L,15858432L,31928832L,64232704L,129128960L,259431936L,520941056L,1045557248L,2097616896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065495Inst : IEnumerable<long>
{
public static readonly long[] Value=A065495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065495.Bytes);
public long this[int i]=>Value[i];

public static A065495Inst Instance=new A065495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065496
{
public static readonly long[] Value={ 3L,7L,21L,22L,31L,66L,70L,81L,93L,94L,102L,110L,115L,119L,127L,142L,159L,170L,187L,210L,214L,217L,265L,282L,310L,322L,343L,345L,357L,364L,381L,382L,385L,400L,472L,497L,510L,517L,527L,642L,651L,679L,690L,710L,714L,742L,745L,770L,782L,795L,820L,862L,884L,889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065496Inst : IEnumerable<long>
{
public static readonly long[] Value=A065496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065496.Bytes);
public long this[int i]=>Value[i];

public static A065496Inst Instance=new A065496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065497
{
public static readonly long[] Value={ 1L,2L,7L,16L,40L,92L,209L,468L,1027L,2242L,4832L,10360L,22049L,46694L,98419L,206588L,432132L,900980L,1873297L,3884904L,8038295L,16597478L,34205700L,70372728L,144550977L,296486538L,607301551L,1242406568L,2538762208L,5182207180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065497Inst : IEnumerable<long>
{
public static readonly long[] Value=A065497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065497.Bytes);
public long this[int i]=>Value[i];

public static A065497Inst Instance=new A065497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065498
{
public static readonly BigInteger[] Value={ 1L,2L,288L,1886976L,489104179200L,4755360379856486400L,BigInteger.Parse("1695944421638473850132889600"),BigInteger.Parse("21967113634648374162210646578639667200"),BigInteger.Parse("10286692771039109536373764545035369981946101760000") };
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
public class A065498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065498Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A065498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065498.Bytes);
public BigInteger this[int i]=>Value[i];

public static A065498Inst Instance=new A065498Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065499
{
public static readonly long[] Value={ 0L,344L,8451L,176128L,465125L,8190720L,6569479L,90177536L,166341033L,750016000L,233671691L,4193648640L,878081581L,14985313280L,21730143375L,46170898432L,7384597649L,161217941760L,17874835219L,384008192000L,414816720885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065499Inst : IEnumerable<long>
{
public static readonly long[] Value=A065499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065499.Bytes);
public long this[int i]=>Value[i];

public static A065499Inst Instance=new A065499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065500
{
public static readonly long[] Value={ 1L,1L,3L,8L,15L,64L,65L,426L,847L,2528L,2529L,27730L,27731L,360372L,360373L,360374L,720735L,12252256L,12252257L,232792578L,232792579L,232792580L,232792581L,5354228902L,5354228903L,26771144424L,26771144425L,80313433226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065500Inst : IEnumerable<long>
{
public static readonly long[] Value=A065500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065500.Bytes);
public long this[int i]=>Value[i];

public static A065500Inst Instance=new A065500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065501
{
public static readonly long[] Value={ 1L,3L,7L,10L,9L,21L,11L,30L,25L,27L,15L,70L,17L,33L,63L,76L,21L,75L,23L,90L,77L,45L,23L,210L,49L,51L,79L,110L,33L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065501Inst : IEnumerable<long>
{
public static readonly long[] Value=A065501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065501.Bytes);
public long this[int i]=>Value[i];

public static A065501Inst Instance=new A065501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065502
{
public static readonly long[] Value={ 2L,4L,5L,6L,8L,10L,12L,14L,15L,16L,18L,20L,22L,24L,25L,26L,28L,30L,32L,34L,35L,36L,38L,40L,42L,44L,45L,46L,48L,50L,52L,54L,55L,56L,58L,60L,62L,64L,65L,66L,68L,70L,72L,74L,75L,76L,78L,80L,82L,84L,85L,86L,88L,90L,92L,94L,95L,96L,98L,100L,102L,104L,105L,106L,108L,110L,112L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065502Inst : IEnumerable<long>
{
public static readonly long[] Value=A065502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065502.Bytes);
public long this[int i]=>Value[i];

public static A065502Inst Instance=new A065502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065503
{
public static readonly long[] Value={ 5L,7L,10L,13L,26L,33L,60L,113L,116L,142L,265L,288L,313L,332L,353L,384L,408L,484L,498L,542L,625L,636L,719L,805L,864L,1064L,1070L,1194L,1328L,1456L,1477L,1528L,1538L,1571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065503Inst : IEnumerable<long>
{
public static readonly long[] Value=A065503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065503.Bytes);
public long this[int i]=>Value[i];

public static A065503Inst Instance=new A065503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065504
{
public static readonly long[] Value={ 1L,3L,6L,11L,17L,24L,33L,43L,54L,66L,79L,94L,110L,127L,145L,164L,184L,206L,229L,253L,278L,304L,331L,359L,389L,420L,452L,485L,519L,554L,590L,627L,665L,705L,746L,788L,831L,875L,920L,966L,1013L,1061L,1110L,1161L,1213L,1266L,1320L,1375L,1431L,1488L,1546L,1605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065504Inst : IEnumerable<long>
{
public static readonly long[] Value=A065504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065504.Bytes);
public long this[int i]=>Value[i];

public static A065504Inst Instance=new A065504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065505
{
public static readonly long[] Value={ 7L,2309L,2753L,2789L,26183L,46933L,53597L,58411L,61357L,69481L,87691L,111487L,124991L,134327L,140659L,144651L,147551L,236519L,247711L,164643L,270223L,291359L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065505Inst : IEnumerable<long>
{
public static readonly long[] Value=A065505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065505.Bytes);
public long this[int i]=>Value[i];

public static A065505Inst Instance=new A065505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065506
{
public static readonly long[] Value={ 1L,2L,7L,15L,39L,84L,196L,419L,928L,1965L,4227L,8871L,18742L,39032L,81481L,168606L,349011L,718371L,1477783L,3028412L,6200296L,12660171L,25823604L,52569417L,106908199L,217086287L,440402878L,892384788L,1806730377L,3654428154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065506Inst : IEnumerable<long>
{
public static readonly long[] Value=A065506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065506.Bytes);
public long this[int i]=>Value[i];

public static A065506Inst Instance=new A065506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065507
{
public static readonly long[] Value={ 3L,3L,5L,3L,5L,3L,7L,17L,11L,7L,109L,5L,17L,5L,5L,21943L,17L,7L,3L,5L,7L,3L,19L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065507Inst : IEnumerable<long>
{
public static readonly long[] Value=A065507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065507.Bytes);
public long this[int i]=>Value[i];

public static A065507Inst Instance=new A065507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065508
{
public static readonly long[] Value={ 2L,3L,7L,13L,67L,79L,139L,151L,163L,193L,337L,349L,379L,457L,541L,613L,643L,727L,769L,919L,991L,1021L,1093L,1117L,1201L,1231L,1381L,1423L,1549L,1567L,1597L,1621L,1693L,1747L,1789L,1801L,1933L,1987L,2011L,2017L,2113L,2137L,2143L,2239L,2281L,2557L,2647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065508Inst : IEnumerable<long>
{
public static readonly long[] Value=A065508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065508.Bytes);
public long this[int i]=>Value[i];

public static A065508Inst Instance=new A065508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065509
{
public static readonly long[] Value={ 2L,7L,13L,17L,23L,29L,43L,73L,79L,83L,127L,193L,227L,239L,263L,277L,337L,359L,373L,397L,439L,457L,479L,503L,557L,563L,617L,919L,967L,1009L,1129L,1187L,1249L,1297L,1327L,1429L,1493L,1553L,1579L,1657L,1663L,1979L,1987L,2069L,2243L,2383L,2617L,2663L,2789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065509Inst : IEnumerable<long>
{
public static readonly long[] Value=A065509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065509.Bytes);
public long this[int i]=>Value[i];

public static A065509Inst Instance=new A065509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065510
{
public static readonly long[] Value={ 2L,3L,5L,11L,37L,43L,47L,71L,131L,157L,223L,251L,257L,307L,487L,641L,1087L,1093L,1187L,1291L,1433L,1567L,1621L,1637L,1831L,1873L,1901L,2017L,2111L,2143L,2293L,2333L,2473L,2621L,2663L,2683L,2707L,2777L,2843L,2903L,3257L,3413L,3463L,3613L,3617L,3761L,3793L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065510Inst : IEnumerable<long>
{
public static readonly long[] Value=A065510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065510.Bytes);
public long this[int i]=>Value[i];

public static A065510Inst Instance=new A065510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065511
{
public static readonly long[] Value={ 1L,92L,105L,106L,689L,1138L,1280L,1373L,1432L,1600L,1960L,2416L,2683L,2846L,2968L,3042L,3091L,4694L,4884L,5191L,5284L,5642L,6905L,6949L,7074L,7095L,7213L,7274L,7418L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065511Inst : IEnumerable<long>
{
public static readonly long[] Value=A065511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065511.Bytes);
public long this[int i]=>Value[i];

public static A065511Inst Instance=new A065511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065512
{
public static readonly long[] Value={ 1L,3L,5L,6L,10L,11L,12L,17L,20L,22L,24L,26L,27L,29L,30L,38L,41L,42L,45L,46L,51L,55L,59L,62L,68L,69L,71L,77L,82L,85L,88L,91L,99L,101L,104L,105L,106L,107L,108L,114L,116L,118L,125L,126L,132L,135L,136L,137L,140L,141L,145L,146L,147L,149L,150L,155L,158L,160L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065512Inst : IEnumerable<long>
{
public static readonly long[] Value=A065512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065512.Bytes);
public long this[int i]=>Value[i];

public static A065512Inst Instance=new A065512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065513
{
public static readonly BigInteger[] Value={ 2L,24L,300L,4320L,72030L,1376256L,29760696L,720000000L,19292299290L,567575838720L,18197320924068L,631732166467584L,23613833496093750L,945755921747804160L,BigInteger.Parse("40410678374256222960"),BigInteger.Parse("1835086247681868693504"),BigInteger.Parse("88263072551692077310386"),BigInteger.Parse("4482662400000000000000000") };
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
public class A065513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065513Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A065513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065513.Bytes);
public BigInteger this[int i]=>Value[i];

public static A065513Inst Instance=new A065513Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065514
{
public static readonly long[] Value={ 1L,2L,4L,5L,9L,11L,16L,17L,19L,27L,29L,32L,37L,41L,43L,49L,53L,59L,64L,67L,71L,73L,81L,83L,89L,97L,101L,103L,107L,109L,125L,128L,131L,137L,139L,149L,151L,157L,163L,169L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,243L,256L,257L,263L,269L,271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065514Inst : IEnumerable<long>
{
public static readonly long[] Value=A065514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065514.Bytes);
public long this[int i]=>Value[i];

public static A065514Inst Instance=new A065514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065515
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,5L,6L,7L,8L,8L,9L,9L,10L,10L,10L,11L,12L,12L,13L,13L,13L,13L,14L,14L,15L,15L,16L,16L,17L,17L,18L,19L,19L,19L,19L,19L,20L,20L,20L,20L,21L,21L,22L,22L,22L,22L,23L,23L,24L,24L,24L,24L,25L,25L,25L,25L,25L,25L,26L,26L,27L,27L,27L,28L,28L,28L,29L,29L,29L,29L,30L,30L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065515Inst : IEnumerable<long>
{
public static readonly long[] Value=A065515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065515.Bytes);
public long this[int i]=>Value[i];

public static A065515Inst Instance=new A065515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065516
{
public static readonly long[] Value={ 2L,3L,1L,4L,1L,6L,1L,3L,1L,7L,1L,1L,3L,1L,7L,3L,2L,4L,2L,1L,4L,3L,4L,5L,3L,5L,3L,1L,1L,4L,2L,1L,1L,11L,5L,4L,3L,1L,2L,1L,1L,6L,4L,1L,7L,1L,1L,2L,1L,9L,3L,1L,2L,5L,3L,8L,1L,5L,2L,2L,7L,7L,1L,1L,2L,1L,3L,4L,1L,1L,2L,1L,1L,2L,5L,9L,2L,10L,2L,4L,1L,5L,3L,3L,2L,7L,4L,9L,2L,2L,4L,3L,1L,2L,1L,1L,2L,4L,5L,5L,2L,2L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065516Inst : IEnumerable<long>
{
public static readonly long[] Value=A065516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065516.Bytes);
public long this[int i]=>Value[i];

public static A065516Inst Instance=new A065516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065517
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,10L,11L,4L,13L,14L,5L,16L,17L,2L,19L,10L,7L,11L,23L,4L,25L,13L,3L,14L,29L,10L,31L,32L,11L,34L,35L,4L,37L,38L,13L,10L,41L,7L,43L,11L,5L,23L,47L,4L,49L,10L,17L,52L,53L,6L,11L,56L,19L,58L,59L,10L,61L,31L,7L,32L,65L,11L,67L,34L,23L,10L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065517Inst : IEnumerable<long>
{
public static readonly long[] Value=A065517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065517.Bytes);
public long this[int i]=>Value[i];

public static A065517Inst Instance=new A065517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065518
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,4L,5L,2L,7L,8L,1L,10L,1L,1L,2L,5L,1L,7L,4L,1L,5L,11L,1L,4L,5L,2L,7L,8L,1L,10L,11L,4L,1L,5L,1L,7L,2L,1L,5L,11L,1L,13L,1L,2L,7L,8L,1L,2L,11L,4L,13L,14L,1L,7L,4L,1L,5L,11L,2L,13L,7L,5L,1L,8L,1L,10L,11L,4L,13L,2L,5L,16L,1L,1L,5L,11L,1L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065518Inst : IEnumerable<long>
{
public static readonly long[] Value=A065518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065518.Bytes);
public long this[int i]=>Value[i];

public static A065518Inst Instance=new A065518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065519
{
public static readonly long[] Value={ 0L,0L,1L,2L,-2L,3L,5L,0L,1L,-5L,4L,6L,1L,-7L,6L,8L,-1L,2L,3L,-9L,12L,5L,7L,1L,10L,2L,-1L,-15L,10L,6L,1L,2L,-16L,17L,7L,2L,-18L,19L,6L,0L,3L,4L,-20L,25L,3L,4L,5L,6L,7L,-1L,12L,8L,2L,11L,15L,2L,-28L,29L,7L,2L,-30L,31L,9L,0L,3L,8L,-30L,43L,6L,8L,5L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065519Inst : IEnumerable<long>
{
public static readonly long[] Value=A065519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065519.Bytes);
public long this[int i]=>Value[i];

public static A065519Inst Instance=new A065519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065520
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,9L,11L,13L,17L,19L,21L,23L,27L,29L,31L,33L,37L,39L,51L,53L,57L,59L,71L,73L,77L,79L,91L,93L,97L,99L,111L,113L,117L,119L,131L,133L,137L,139L,171L,173L,177L,179L,191L,193L,197L,199L,211L,213L,217L,219L,231L,233L,237L,239L,271L,273L,277L,279L,291L,293L,297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065520Inst : IEnumerable<long>
{
public static readonly long[] Value=A065520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065520.Bytes);
public long this[int i]=>Value[i];

public static A065520Inst Instance=new A065520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065521
{
public static readonly long[] Value={ 2L,1L,1L,1L,9L,11L,11L,13L,13L,11L,13L,35L,37L,41L,43L,43L,43L,47L,47L,49L,53L,53L,55L,55L,53L,55L,59L,61L,65L,67L,121L,125L,127L,133L,131L,137L,139L,141L,145L,147L,149L,155L,153L,159L,163L,169L,165L,161L,165L,171L,175L,177L,183L,181L,183L,185L,187L,193L,195L,199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065521Inst : IEnumerable<long>
{
public static readonly long[] Value=A065521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065521.Bytes);
public long this[int i]=>Value[i];

public static A065521Inst Instance=new A065521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065522
{
public static readonly long[] Value={ 21L,93L,381L,1065L,1173L,5065L,5670L,5729L,6603L,8809L,10281L,15960L,17110L,39286L,40526L,47882L,49951L,61962L,85058L,85261L,99066L,117860L,125985L,126853L,135890L,143241L,171945L,179556L,185853L,208744L,209585L,210450L,251394L,261767L,288792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065522Inst : IEnumerable<long>
{
public static readonly long[] Value=A065522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065522.Bytes);
public long this[int i]=>Value[i];

public static A065522Inst Instance=new A065522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065523
{
public static readonly long[] Value={ 3L,7L,21L,31L,81L,93L,127L,217L,381L,400L,651L,889L,2667L,3937L,8191L,11811L,24573L,27559L,57337L,82677L,131071L,172011L,253921L,393213L,524287L,761763L,917497L,1040257L,1572861L,1777447L,2752491L,3120771L,3670009L,4063201L,5332341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065523Inst : IEnumerable<long>
{
public static readonly long[] Value=A065523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065523.Bytes);
public long this[int i]=>Value[i];

public static A065523Inst Instance=new A065523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065524
{
public static readonly long[] Value={ 4L,10L,38L,164L,760L,3634L,17653L,86542L,426510L,2109602L,10458654L,51938515L,258246036L,1285227649L,6400837884L,31896080698L,159013169263L,793026358830L,3956152086139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065524Inst : IEnumerable<long>
{
public static readonly long[] Value=A065524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065524.Bytes);
public long this[int i]=>Value[i];

public static A065524Inst Instance=new A065524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065525
{
public static readonly long[] Value={ 4L,12L,52L,275L,1539L,8883L,51974L,306464L,1815791L,10791313L,64266028L,383289080L,2288430270L,13674181949L,81759268145L,489087871679L,2926904894187L,17521456528700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065525Inst : IEnumerable<long>
{
public static readonly long[] Value=A065525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065525.Bytes);
public long this[int i]=>Value[i];

public static A065525Inst Instance=new A065525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065526
{
public static readonly long[] Value={ 4L,20L,159L,1542L,16523L,177115L,1914605L,20805629L,226837179L,2473489545L,27097055903L,296926482905L,3255249694017L,35704359451621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065526Inst : IEnumerable<long>
{
public static readonly long[] Value=A065526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065526.Bytes);
public long this[int i]=>Value[i];

public static A065526Inst Instance=new A065526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065527
{
public static readonly long[] Value={ 4L,21L,187L,2000L,23303L,272662L,3217385L,38159996L,454037291L,5405466113L,64592435478L,772175552229L,9235851081078L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065527Inst : IEnumerable<long>
{
public static readonly long[] Value=A065527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065527.Bytes);
public long this[int i]=>Value[i];

public static A065527Inst Instance=new A065527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065528
{
public static readonly long[] Value={ 5L,8L,10L,12L,15L,16L,17L,20L,24L,30L,32L,34L,37L,40L,48L,51L,57L,60L,63L,64L,68L,74L,76L,80L,85L,96L,101L,102L,108L,114L,120L,125L,126L,128L,136L,160L,170L,185L,192L,197L,202L,204L,219L,240L,247L,250L,255L,256L,257L,259L,272L,273L,285L,292L,296L,304L,315L,320L,327L,333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065528Inst : IEnumerable<long>
{
public static readonly long[] Value=A065528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065528.Bytes);
public long this[int i]=>Value[i];

public static A065528Inst Instance=new A065528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065529
{
public static readonly long[] Value={ 2L,6L,1L,1L,3L,1L,1L,2L,1L,1L,1L,1L,1L,3L,4L,2L,1L,2L,1L,3L,1L,2L,2L,2L,1L,3L,3L,1L,1L,1L,34L,3L,1L,1L,2L,5L,1L,1L,5L,1L,1L,2L,1L,1L,2L,1L,1L,9L,17L,1L,1L,4L,10L,1L,1L,2L,1L,2L,2L,1L,1L,4L,3L,12L,1L,1L,6L,1L,2L,15L,1L,3L,1L,1L,4L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065529Inst : IEnumerable<long>
{
public static readonly long[] Value=A065529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065529.Bytes);
public long this[int i]=>Value[i];

public static A065529Inst Instance=new A065529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065530
{
public static readonly long[] Value={ 0L,1L,8L,3L,24L,5L,48L,7L,80L,9L,120L,11L,168L,13L,224L,15L,288L,17L,360L,19L,440L,21L,528L,23L,624L,25L,728L,27L,840L,29L,960L,31L,1088L,33L,1224L,35L,1368L,37L,1520L,39L,1680L,41L,1848L,43L,2024L,45L,2208L,47L,2400L,49L,2600L,51L,2808L,53L,3024L,55L,3248L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065530Inst : IEnumerable<long>
{
public static readonly long[] Value=A065530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065530.Bytes);
public long this[int i]=>Value[i];

public static A065530Inst Instance=new A065530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065531
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,1L,2L,2L,2L,3L,1L,2L,2L,2L,3L,3L,3L,3L,1L,3L,4L,2L,2L,4L,2L,4L,3L,4L,2L,3L,3L,3L,3L,3L,2L,5L,2L,3L,2L,5L,2L,4L,2L,3L,4L,4L,1L,5L,2L,4L,4L,5L,1L,4L,4L,4L,4L,2L,2L,6L,2L,3L,5L,4L,5L,4L,3L,4L,2L,4L,2L,6L,3L,3L,3L,3L,2L,6L,1L,7L,3L,4L,2L,6L,5L,3L,2L,5L,2L,5L,4L,5L,4L,2L,2L,6L,2L,5L,4L,7L,2L,4L,1L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065531Inst : IEnumerable<long>
{
public static readonly long[] Value=A065531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065531.Bytes);
public long this[int i]=>Value[i];

public static A065531Inst Instance=new A065531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065532
{
public static readonly long[] Value={ -1L,47L,191L,431L,767L,1199L,1727L,2351L,3071L,3887L,4799L,5807L,6911L,8111L,9407L,10799L,12287L,13871L,15551L,17327L,19199L,21167L,23231L,25391L,27647L,29999L,32447L,34991L,37631L,40367L,43199L,46127L,49151L,52271L,55487L,58799L,62207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065532Inst : IEnumerable<long>
{
public static readonly long[] Value=A065532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065532.Bytes);
public long this[int i]=>Value[i];

public static A065532Inst Instance=new A065532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065533
{
public static readonly long[] Value={ 3L,31L,311L,3119L,31193L,311951L,3119533L,31195343L,311953441L,3119534441L,31195344413L,311953444133L,3119534441393L,31195344413953L,311953444139539L,3119534441395579L,31195344413955853L,311953444139558593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065533Inst : IEnumerable<long>
{
public static readonly long[] Value=A065533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065533.Bytes);
public long this[int i]=>Value[i];

public static A065533Inst Instance=new A065533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065534
{
public static readonly long[] Value={ 5L,53L,541L,5413L,54133L,541339L,5413391L,54133921L,541339231L,5413392311L,54133923121L,541339231241L,5413392312463L,54133923124643L,541339231246433L,5413392312464369L,54133923124643743L,541339231246437473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065534Inst : IEnumerable<long>
{
public static readonly long[] Value=A065534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065534.Bytes);
public long this[int i]=>Value[i];

public static A065534Inst Instance=new A065534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065535
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065535Inst : IEnumerable<long>
{
public static readonly long[] Value=A065535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065535.Bytes);
public long this[int i]=>Value[i];

public static A065535Inst Instance=new A065535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065536
{
public static readonly long[] Value={ 1L,2L,3L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065536Inst : IEnumerable<long>
{
public static readonly long[] Value=A065536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065536.Bytes);
public long this[int i]=>Value[i];

public static A065536Inst Instance=new A065536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065537
{
public static readonly long[] Value={ 7L,71L,719L,7193L,71933L,719333L,7193357L,71933597L,719335993L,7193359933L,71933599363L,719335993631L,7193359936331L,71933599363319L,719335993633291L,7193359936332919L,71933599363329217L,719335993633292261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065537Inst : IEnumerable<long>
{
public static readonly long[] Value=A065537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065537.Bytes);
public long this[int i]=>Value[i];

public static A065537Inst Instance=new A065537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065538
{
public static readonly long[] Value={ 11L,113L,1151L,11519L,115201L,1152023L,11520269L,115202701L,1152027101L,11520271019L,115202710219L,1152027102209L,11520271022149L,115202710221517L,1152027102215173L,11520271022151733L,115202710221517367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065538Inst : IEnumerable<long>
{
public static readonly long[] Value=A065538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065538.Bytes);
public long this[int i]=>Value[i];

public static A065538Inst Instance=new A065538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065539
{
public static readonly long[] Value={ 13L,131L,1319L,13217L,132173L,1321753L,13217531L,132175313L,1321753177L,13217531771L,132175317727L,1321753177271L,13217531772769L,132175317727727L,1321753177277287L,13217531772772933L,132175317727729369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065539Inst : IEnumerable<long>
{
public static readonly long[] Value=A065539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065539.Bytes);
public long this[int i]=>Value[i];

public static A065539Inst Instance=new A065539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065540
{
public static readonly long[] Value={ 3L,11L,37L,113L,347L,1049L,3163L,9491L,28477L,85439L,256337L,769019L,2307059L,6921179L,20763541L,62290633L,186871907L,560615723L,1681847191L,5045541577L,15136624739L,45409874221L,136229622677L,408688868051L,1226066604179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065540Inst : IEnumerable<long>
{
public static readonly long[] Value=A065540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065540.Bytes);
public long this[int i]=>Value[i];

public static A065540Inst Instance=new A065540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065541
{
public static readonly long[] Value={ 5L,29L,149L,751L,3761L,18839L,94201L,471007L,2355037L,11775191L,58875961L,294379823L,1471899119L,7359495683L,36797478433L,183987392167L,919936960849L,4599684804259L,22998424021409L,114992120107093L,574960600535527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065541Inst : IEnumerable<long>
{
public static readonly long[] Value=A065541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065541.Bytes);
public long this[int i]=>Value[i];

public static A065541Inst Instance=new A065541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065542
{
public static readonly long[] Value={ 7L,53L,373L,2617L,18329L,128311L,898181L,6287273L,44010929L,308076523L,2156535743L,15095750209L,105670251529L,739691760707L,5177842324987L,36244896274921L,253714273924549L,1775999917471859L,12431999422303051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065542Inst : IEnumerable<long>
{
public static readonly long[] Value=A065542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065542.Bytes);
public long this[int i]=>Value[i];

public static A065542Inst Instance=new A065542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065543
{
public static readonly long[] Value={ 11L,127L,1399L,15391L,169307L,1862381L,20486203L,225348257L,2478830833L,27267139177L,299938530953L,3299323840567L,36292562246243L,399218184708683L,4391400031795559L,48305400349751191L,531359403847263197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065543Inst : IEnumerable<long>
{
public static readonly long[] Value=A065543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065543.Bytes);
public long this[int i]=>Value[i];

public static A065543Inst Instance=new A065543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065544
{
public static readonly long[] Value={ 13L,173L,2251L,29269L,380503L,4946581L,64305559L,835972301L,10867639987L,141279319843L,1836631157971L,23876205053627L,310390665697169L,4035078654063221L,52456022502821891L,681928292536684637L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065544Inst : IEnumerable<long>
{
public static readonly long[] Value=A065544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065544.Bytes);
public long this[int i]=>Value[i];

public static A065544Inst Instance=new A065544Inst();

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